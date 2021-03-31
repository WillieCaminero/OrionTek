using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;

namespace OrionTek.Controllers.Common
{
    public class BaseController : Controller
    {
        /// <summary>
        /// Procesando excepcion
        /// </summary>
        /// <param name="oracleException"></param>
        /// <returns></returns>
        internal ObjectResult ProcessExcepcion(string message)
        {
            return StatusCode(StatusCodes.Status500InternalServerError, new
            {
                message
            });
        }

        /// <summary>
        /// Procesando excepcion general
        /// </summary>
        /// <param name="ex"></param>
        /// <returns></returns>
        internal ObjectResult ProcessExcepcion(Exception ex)
        {
            string message = ex.InnerException == null ? ex.Message : string.Format("{0}. {1}", ex.Message, ex.InnerException);

            return StatusCode(StatusCodes.Status500InternalServerError, new
            {
                message
            });
        }
    }
}
