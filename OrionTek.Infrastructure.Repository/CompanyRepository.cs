using Dapper;
using OrionTek.Domain.Entities;
using OrionTek.Domain.Interfaces.Repository;
using OrionTek.Infrastructure.Repository.Common;
using System.Data;
using System.Data.SqlClient;
using System.Linq;

namespace OrionTek.Infrastructure.Repository
{
    public class CompanyRepository : RepAttributes, ICompanyRepository
    {
        public bool CreateCompany(Company company)
        {
            using (var connection = new SqlConnection(ConexionOrionTek))
            {
                string statement = $"[{Schema}].[SP_INSERTAR_EMPRESA]";

                var parameters = new DynamicParameters();
                parameters.Add("@Empresa", company.Empresa);

                connection.Execute(statement, parameters, commandType: CommandType.StoredProcedure);
            }

            return true;
        }

        public Company GetCompany(int Id)
        {
            Company company = null;

            using (SqlConnection conexion = new SqlConnection(ConexionOrionTek))
            {
                string statement = $"EXEC [{Schema}].[SP_OBTENER_EMPRESA_POR_ID] @Id";

                company = conexion.Query<Company>(statement, new { Id }).FirstOrDefault();
            }

            return company;
        }
    }
}
