using System.Threading;
using System.Threading.Tasks;
using AutoMapper;
using MediatR;
using Neon.FinanceBridge.Application.Commands.Item;
using Neon.FinanceBridge.Data.SQL.Repositories;
using Neon.FinanceBridge.Domain.Models;
namespace Neon.FinanceBridge.Application.CommandHandlers
{
  
    public class ItemCommandHandler : IRequestHandler<AddItemCommand>, IRequestHandler<UpdateItemCommand>, IRequestHandler<DeleteItemCommand>
    {
        private readonly ICrudRepository repository;
        private readonly IMapper mapper;

        public ItemCommandHandler(ICrudRepository repository, IMapper mapper)
        {
            this.repository = repository;
            this.mapper = mapper;
        }

        public Task<Unit> Handle(AddItemCommand request, CancellationToken cancellationToken)
        {
            var item = mapper.Map<Item>(request);
            repository.Create(item);
            repository.Save();
            return Task.FromResult(Unit.Value);
        }

        public Task<Unit> Handle(UpdateItemCommand request, CancellationToken cancellationToken)
        {
            var item = mapper.Map<Item>(request);
            repository.Update(item);
            repository.Save();
            return Task.FromResult(Unit.Value);
        }

        public Task<Unit> Handle(DeleteItemCommand request, CancellationToken cancellationToken)
        {
            repository.Delete<Item>(request.Id);
            repository.Save();
            return Task.FromResult(Unit.Value);
        }
    }
}
