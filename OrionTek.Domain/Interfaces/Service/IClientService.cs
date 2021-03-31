using OrionTek.Domain.Entities;

namespace OrionTek.Domain.Interfaces.Service
{
    public interface IClientService
    {
        bool CreateClient(Client client);

        bool CreateAddress(Address address);
    }
}
