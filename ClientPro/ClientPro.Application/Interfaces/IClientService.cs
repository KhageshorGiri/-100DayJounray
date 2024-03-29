﻿using ClientPro.Application.Dtos.Client;

namespace ClientPro.Application.Interfaces
{
    public interface IClientService
    {
        Task<IEnumerable<ClientDto>> GetAllClientAsync();
        Task<ClientDto> GetClientAsync(int id);
        Task<ClientDto> AddAsync(CreateClientDto client);
        Task<ClientDto> UpdateAsync(UpdateClientDto client);
        Task<ClientDto> DeleteAsync(int id);
    }
}
