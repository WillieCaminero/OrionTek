using Dapper;
using OrionTek.Domain.Entities;
using OrionTek.Domain.Interfaces.Repository;
using OrionTek.Infrastructure.Repository.Common;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;

namespace OrionTek.Infrastructure.Repository
{
    public class ClientRepository : RepAttributes, IClientRepository
    {
        public bool CreateClient(Client client)
        {
            using (var connection = new SqlConnection(ConexionOrionTek))
            {
                string statement = $"[{Schema}].[SP_INSERTAR_CLIENTE]";

                var parameters = new DynamicParameters();
                parameters.Add("@Empresa", client.Empresa);
                parameters.Add("@Nombres", client.Nombres);
                parameters.Add("@Apellidos", client.Apellidos);

                connection.Execute(statement, parameters, commandType: CommandType.StoredProcedure);
            }

            return true;
        }

        public bool CreateAddress(Address address)
        {
            using (var connection = new SqlConnection(ConexionOrionTek))
            {
                string statement = $"[{Schema}].[SP_INSERTAR_DIRECCION]";

                var parameters = new DynamicParameters();
                parameters.Add("@Cliente", address.ClientId);
                parameters.Add("@Calle", address.Calle);
                parameters.Add("@Numero", address.Numero);
                parameters.Add("@Apartamento", address.Apartamento);
                parameters.Add("@Referencia", address.Referencia);
                parameters.Add("@Sector", address.Sector);

                connection.Execute(statement, parameters, commandType: CommandType.StoredProcedure);
            }

            return true;
        }

        public List<Client> GetClientsByCompanyId(int Id)
        {
            List<Client> clients = null;

            using (SqlConnection conexion = new SqlConnection(ConexionOrionTek))
            {
                string statement = $"EXEC [{Schema}].[SP_OBTENER_CLIENTES_POR_EMPRESA_ID] @Empresa";

                clients = conexion.Query<Client>(statement, new { Empresa = Id }).ToList();
            }

            return clients;
        }

        public List<Address> GetAddressesByClientId(int Id)
        {
            List<Address> addresses = null;

            using (SqlConnection conexion = new SqlConnection(ConexionOrionTek))
            {
                string statement = $"EXEC [{Schema}].[SP_OBTENER_DIRECCIONES_POR_Cliente_ID] @Cliente";

                addresses = conexion.Query<Address>(statement, new { Cliente = Id }).ToList();
            }

            return addresses;
        }
    }
}
