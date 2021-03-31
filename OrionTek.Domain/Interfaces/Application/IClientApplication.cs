using OrionTek.Domain.Entities;

namespace OrionTek.Domain.Interfaces.Application
{
    public interface IClientApplication
    {
        bool CreateClient(Client client);

        bool CreateAddress(Address address);
    }
}
