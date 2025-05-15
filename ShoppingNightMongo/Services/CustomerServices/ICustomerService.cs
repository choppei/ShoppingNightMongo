﻿using ShoppingNightMongo.Dtos.CustomerDtos;

namespace ShoppingNightMongo.Services.CustomerServices
{
    public interface ICustomerService
    {
        Task<List<ResultCustomerDto>> GetAllCustomerAsync();
        Task CreateCustomerAsync(CreateCustomerDto createCustomerDto);
        Task UpdateCustomerAsync(UpdateCustomerDto updateCustomerDto);
        Task DeleteCustomerAsync(string customerid);
        Task<GetCustomerByIdDto> GetCustomerByIdAsync(string customerid);
    }
}
