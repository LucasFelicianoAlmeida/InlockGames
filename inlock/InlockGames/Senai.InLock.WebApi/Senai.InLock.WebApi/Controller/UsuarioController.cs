using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Senai.InLock.WebApi.Interface;
using Senai.InLock.WebApi.Repository;

namespace Senai.InLock.WebApi.Controller
{
    // Define que o tipo de resposta da API será no formato JSON
    [Produces("application/json")]

    // Define que a rota de uma requisição será no formato domínio/api/NomeController
    [Route("api/[controller]")]

    // Define que é um controlador de API
    [ApiController]

    // Define que somente usuários logados possam acessar os endpoints
    [Authorize]
    public class UsuarioController : ControllerBase
    {

        private IJogoRepository _jogoRepository { get; set; }

        public UsuarioController()
        {
            _jogoRepository = new JogoRepository();

        }
    }
}