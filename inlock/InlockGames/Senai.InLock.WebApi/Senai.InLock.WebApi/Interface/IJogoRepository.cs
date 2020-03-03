using Senai.InLock.WebApi.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Senai.InLock.WebApi.Interface
{
    interface IJogoRepository
    {
        List<JogoDomain> Listar();

        void Cadastrar(JogoDomain novoJogo);

        void Deletar(int id);

    }
}
