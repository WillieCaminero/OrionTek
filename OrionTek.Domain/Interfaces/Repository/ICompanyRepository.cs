using OrionTek.Domain.Entities;

namespace OrionTek.Domain.Interfaces.Repository
{
    public interface ICompanyRepository
    {
        bool CreateCompany(Company company);

        Company GetCompany(int Id);
    }
}
