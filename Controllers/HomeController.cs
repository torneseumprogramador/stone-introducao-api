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
        private DbContexto db;
        public HomeController(DbContexto _db)
        {
            this.db = _db;
        }

        [HttpGet]
        [Route("/")]
        public ActionResult Get()
        {
            return StatusCode(200, new {
                Mensagem = "Bem vindo a API",
                Documentacao = "https://localhost:5001/swagger/index.html"
            });
        }
    }
}
