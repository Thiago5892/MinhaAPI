using Microsoft.AspNetCore.Mvc;
using MinhaAPI.Model;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace MinhaAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsuarioController : ControllerBase
    {
        // GET: api/<UsuarioController>
        [HttpGet]
        public IEnumerable<Model.UsuarioModel> Get()
        {
            List<UsuarioModel> usuarioModels = new List<UsuarioModel>();
            usuarioModels.Add(new UsuarioModel() { Id = 1, Nome = "Thiago Borba", Email = "thiagoborba8@gmail.com" });
            return usuarioModels;
        }

        // GET api/<UsuarioController>/5
        [HttpGet("{id}")]
        public UsuarioModel Get(int id)
        {
            UsuarioModel usuario = new UsuarioModel() { Id = 1, Nome = "Thiago Borba", Email = "thiagoborba8@gmail.com"};
           
            return usuario;
        }

        // POST api/<UsuarioController>
        [HttpPost]
        public void Post([FromBody] UsuarioModel usuario)
        {
            //Para cadastrar
        }

        // PUT api/<UsuarioController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] UsuarioModel usuario)
        {
            //Para Atualizar
        }

        // DELETE api/<UsuarioController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
           // passando o id para deletar
        }
    }
}
