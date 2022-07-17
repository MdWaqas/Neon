using AutoMapper;
using Neon.FinanceBridge.Application.Commands.Customer;
using Neon.FinanceBridge.Application.Commands.Item;
using Neon.FinanceBridge.Application.Commands.Store;
using Neon.FinanceBridge.Domain.Models;

namespace Neon.FinanceBridge.Application.AutoMapper
{
    public class CommandToModelMappingProfile : Profile
    {
        public CommandToModelMappingProfile()
        {
            CreateMap<Customer, AddCustomerCommand>().ReverseMap();
            CreateMap<Customer, UpdateCustomerCommand>().ReverseMap();
            CreateMap<Item, AddItemCommand>().ReverseMap();
            CreateMap<Item, UpdateItemCommand>().ReverseMap();
            CreateMap<Store, AddStoreCommand>().ReverseMap();
            CreateMap<Store, UpdateStoreCommand>().ReverseMap();

        }
    }
}
