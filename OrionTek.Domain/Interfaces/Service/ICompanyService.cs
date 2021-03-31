using OrionTek.Domain.Entities;

namespace OrionTek.Domain.Interfaces.Service
{
    public interface ICompanyService
    {
        bool CreateCompany(Company company);

        Company GetCompany(int Id);
    }
}
