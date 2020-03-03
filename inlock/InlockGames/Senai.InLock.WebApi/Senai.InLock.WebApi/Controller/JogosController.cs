using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Senai.InLock.WebApi.Domain;
using Senai.InLock.WebApi.Interface;
using Senai.InLock.WebApi.Repository;

namespace Senai.InLock.WebApi.Controller
{
    [Produces("application/json")]
    [Route("api/[controller]")]
    [ApiController]

    //[Authorize]
    public class JogosController : ControllerBase
    {
        private IJogoRepository _jogoRepository { get; set; }

        public JogosController()
        {
            _jogoRepository = new JogoRepository();
            
        }

        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            //JogoDomain jogoBusado = _jogoRepository.Deletar(id);
        }
        

        [HttpGet]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public IActionResult Get()
        {
            return Ok(_jogoRepository.Listar());
        }

        [HttpPost]
        public IActionResult Post(JogoDomain novojogo)
        {
            if (novojogo.TituloJogo == null)
            {
                return BadRequest("O nome do Jogo é obrigatório!");
            }
            // Faz a chamada para o método .Cadastrar();
            _jogoRepository.Cadastrar(novojogo);

            // Retorna o status code 201 - Created com a URI e o objeto cadastrado
            return Created("http://localhost:5000/api/Jogos", novojogo);
        }



    }
}