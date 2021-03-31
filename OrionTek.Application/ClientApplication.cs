using OrionTek.Domain.Entities;
using OrionTek.Domain.Interfaces.Application;
using OrionTek.Domain.Interfaces.Service;

namespace OrionTek.Application
{
    public class ClientApplication : IClientApplication
    {
        private readonly IClientService clientService;

        public ClientApplication(IClientService clientService) => this.clientService = clientService;

        public bool CreateClient(Client client) => clientService.CreateClient(client);

        public bool CreateAddress(Address address) => clientService.CreateAddress(address);
    }
}
