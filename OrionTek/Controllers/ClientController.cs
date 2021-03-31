using Microsoft.AspNetCore.Mvc;
using OrionTek.Controllers.Common;
using OrionTek.Domain.Entities;
using OrionTek.Domain.Interfaces.Application;
using System;

namespace OrionTek.Controllers
{
    public class ClientController : BaseController
    {
        private readonly IClientApplication clientApplication;

        public ClientController(IClientApplication clientApplication) => this.clientApplication = clientApplication;

        [HttpPost("create-client")]
        public IActionResult CreateClient([FromBody] Client client)
        {
            try
            {
                clientApplication.CreateClient(client);

                return Ok();
            }
            catch (Exception ex)
            {
                return ProcessExcepcion(ex);
            }
        }

        [HttpPost("create-address")]
        public IActionResult CreateAddress([FromBody] Address address)
        {
            try
            {
                clientApplication.CreateAddress(address);

                return Ok();
            }
            catch (Exception ex)
            {
                return ProcessExcepcion(ex);
            }
        }
    }
}
