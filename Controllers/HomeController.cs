using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using api_stone.Models;
using api_stone.Servicos;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace api_stone.Controllers
{
    [ApiController]
    public class HomeController : ControllerBase
    {
        [HttpGet]
        [Route("/")]
        public ActionResult Get()
        {
            var clientes = ClienteSingleton.GetInstancia().Clientes();
            return StatusCode(200, clientes);
        }

        [HttpPost]
        [Route("/")]
        public ActionResult Post([FromBody] Cliente cliente)
        {
            ClienteSingleton.GetInstancia().Adicionar(cliente);
            return StatusCode(201, cliente);
        }

        [HttpPut]
        [Route("/")]
        public dynamic Atualizando()
        {
            return new
            {
                Mensagem = "Estou acessando um PUT"
            };
        }

        [HttpDelete]
        [Route("/")]
        public dynamic Excluindo()
        {
            return new
            {
                Mensagem = "Estou acessando um Delete"
            };
        }
    }
}
