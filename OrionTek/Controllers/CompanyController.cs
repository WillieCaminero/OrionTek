using Microsoft.AspNetCore.Mvc;
using OrionTek.Controllers.Common;
using OrionTek.Domain.Entities;
using OrionTek.Domain.Interfaces.Application;
using System;

namespace OrionTek.Controllers
{
    public class CompanyController : BaseController
    {
        private readonly ICompanyApplication companyApplication;

        public CompanyController(ICompanyApplication companyApplication) => this.companyApplication = companyApplication;

        [HttpPost("create-company")]
        public IActionResult CreateCompany([FromBody] Company company)
        {
            try
            {
                companyApplication.CreateCompany(company);

                return Ok();
            }
            catch (Exception ex)
            {
                return ProcessExcepcion(ex);
            }
        }

        [HttpGet("get-company/{id}")]
        public IActionResult GetCompany(int id)
        {
            try
            {
                var response = companyApplication.GetCompany(id);

                if(response == null) 
                {
                    return NoContent();
                }

                return Ok(new {
                    data = response
                });
            }
            catch (Exception ex)
            {
                return ProcessExcepcion(ex);
            }
        }
    }
}
