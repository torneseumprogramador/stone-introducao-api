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
    [Route("/clientes")]
    public class ClientesController : ControllerBase
    {
        private DbContexto db;
        public ClientesController(DbContexto _db)
        {
            this.db = _db;
        }

        [HttpGet]
        [Route("")]
        public ActionResult Get()
        {
            return StatusCode(200, db.Clientes.ToList());
        }

        [HttpPost]
        [Route("")]
        public ActionResult Post([FromBody] Cliente cliente)
        {
            db.Clientes.Add(cliente);
            db.SaveChanges();

            return StatusCode(201, cliente);
        }

        [HttpPut]
        [Route("{id}")]
        public ActionResult Atualizar(int id, [FromBody] Cliente cliente)
        {
            if(id < 1)
            {
                return StatusCode(404, new {
                    Mensagem = "Cliente não encontrado, id precisa ser maior que 0"
                });
            } 

            var clienteDb = db.Clientes.Find(id);
            if(clienteDb == null)
            {
                return StatusCode(404, new {
                    Mensagem = "Cliente não encontrado, id não existe no banco de dados"
                });
            }

            clienteDb.Nome = cliente.Nome;
            clienteDb.Telefone = cliente.Telefone;

            db.Clientes.Update(clienteDb);
            db.SaveChanges();

            return StatusCode(200, clienteDb);
        }

        [HttpDelete]
        [Route("{id}")]
        public ActionResult Excluir(int id)
        {
            if(id < 1)
            {
                return StatusCode(404, new {
                    Mensagem = "Cliente não encontrado, id precisa ser maior que 0"
                });
            } 

            var clienteDb = db.Clientes.Find(id);
            if(clienteDb == null)
            {
                return StatusCode(404, new {
                    Mensagem = "Cliente não encontrado, id não existe no banco de dados"
                });
            }

            db.Clientes.Remove(clienteDb);
            db.SaveChanges();

            return StatusCode(204);
        }
    }
}
