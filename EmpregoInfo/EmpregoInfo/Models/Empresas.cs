using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EmpregoInfo.Models
{
    public class Empresas{

        public int ID { get; set; }

        public string Nome { get; set; }

        // Morada da sede da empresa
        public string Morada { get; set; }

        // NIF da empresa
        public string NIF { get; set; }

        //atividade que a empresa pratica
        public string Atividade { get; set; }

        public string WebSite { get; set; }

        public string Telefone { get; set; }
    }
}
