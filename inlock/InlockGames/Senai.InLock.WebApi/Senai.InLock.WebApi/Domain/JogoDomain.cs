using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Senai.InLock.WebApi.Domain
{
    public class JogoDomain
    {
        public int IdJogo { get; set; }

        public string TituloJogo { get; set; }

        public string Descricao { get; set; }

        public DateTime DataLan { get; set; }

        public decimal Valor { get; set; }

        public int IdEstudio { get; set; }

        public EstudioDomain Estudio { get; set; }

    }
}
