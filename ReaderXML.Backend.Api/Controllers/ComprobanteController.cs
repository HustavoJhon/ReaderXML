using System.Xml.Serialization;
using Microsoft.AspNetCore.Mvc;
using System;

namespace ReaderXML.Backend.Api.Controller
{
    [ApiController]
    [Route("api/[Controller]")]

    public class comprobanteController : ControllerBase
    {
        [HttpGet("HelloWorld")]
        public IActionResult Bienvenida()
        {
            return Ok("Bienvenido a mi API");
        }

        [HttpGet("Fecha")]
        public IActionResult FechaActual()
        {
            return Ok(DateTime.Now);
        }
    }
}
