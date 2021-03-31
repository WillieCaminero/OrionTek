using OrionTek.Domain.Entities;
using OrionTek.Domain.Interfaces.Repository;
using OrionTek.Domain.Interfaces.Service;

namespace OrionTek.Domain.Service
{
    public class ClientService : IClientService
    {
        private readonly IClientRepository clientRepository;

        public ClientService(IClientRepository clientRepository) => this.clientRepository = clientRepository;

        public bool CreateClient(Client client) => clientRepository.CreateClient(client);

        public bool CreateAddress(Address address) => clientRepository.CreateAddress(address);
    }
}
