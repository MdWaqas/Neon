using AutoMapper;
using Neon.FinanceBridge.Application.Commands.Customer;
using Neon.FinanceBridge.Domain.Models;

namespace Neon.FinanceBridge.Application.AutoMapper
{
    public class CommandToModelMappingProfile : Profile
    {
        public CommandToModelMappingProfile()
        {
            CreateMap<Customer, AddCustomerCommand>();
            CreateMap<Customer, UpdateCustomerCommand>();
        }
    }
}
