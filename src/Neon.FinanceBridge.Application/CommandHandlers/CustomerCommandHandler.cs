using System.Threading;
using System.Threading.Tasks;
using AutoMapper;
using MediatR;
using Neon.FinanceBridge.Application.Commands.Customer;
using Neon.FinanceBridge.Data.SQL.Repositories;
using Neon.FinanceBridge.Domain.Models;

namespace Neon.FinanceBridge.Application.CommandHandlers
{
    public class CustomerCommandHandler : IRequestHandler<AddCustomerCommand>, IRequestHandler<UpdateCustomerCommand>, IRequestHandler<DeleteCustomerCommand>
    {
        private readonly ICrudRepository repository;
        private readonly IMapper mapper;

        public CustomerCommandHandler(ICrudRepository repository, IMapper mapper)
        {
            this.repository = repository;
            this.mapper = mapper;
        }

        public Task<Unit> Handle(AddCustomerCommand request, CancellationToken cancellationToken)
        {
            var customer = mapper.Map<Customer>(request);
            repository.Create(customer);
            return Task.FromResult(Unit.Value);
        }

        public Task<Unit> Handle(UpdateCustomerCommand request, CancellationToken cancellationToken)
        {
            var customer = mapper.Map<Customer>(request);
            repository.Update(customer);
            return Task.FromResult(Unit.Value);
        }

        public Task<Unit> Handle(DeleteCustomerCommand request, CancellationToken cancellationToken)
        {
            repository.Delete<Customer>(request.Id);
            return Task.FromResult(Unit.Value);
        }
    }
}
