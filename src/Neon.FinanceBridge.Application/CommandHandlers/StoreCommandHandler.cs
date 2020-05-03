using AutoMapper;
using MediatR;
using Neon.FinanceBridge.Application.Commands.Store;
using Neon.FinanceBridge.Data.SQL.Repositories;
using Neon.FinanceBridge.Domain.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Neon.FinanceBridge.Application.CommandHandlers
{
    public class StoreCommandHandler : IRequestHandler<AddStoreCommand>, IRequestHandler<UpdateStoreCommand>, IRequestHandler<DeleteStoreCommand>
    {
        private readonly ICrudRepository repository;
        private readonly IMapper mapper;

        public StoreCommandHandler(ICrudRepository repository, IMapper mapper)
        {
            this.repository = repository;
            this.mapper = mapper;
        }

        public Task<Unit> Handle(AddStoreCommand request, CancellationToken cancellationToken)
        {
            var store = mapper.Map<Store>(request);
            repository.Create(store);
            repository.Save();
            return Task.FromResult(Unit.Value);
        }
        public Task<Unit> Handle(UpdateStoreCommand request, CancellationToken cancellationToken)
        {
            var store = mapper.Map<Store>(request);
            repository.Update(store);
            repository.Save();
            return Task.FromResult(Unit.Value);
        }
        public Task<Unit> Handle(DeleteStoreCommand request, CancellationToken cancellationToken)
        {
            repository.Delete<Store>(request.Id);
            repository.Save();
            return Task.FromResult(Unit.Value);
        }

    }
}
