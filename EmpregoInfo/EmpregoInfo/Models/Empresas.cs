using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace EmpregoInfo.Models
{
    public class Empresas{
        public Empresas()
        {

            //inicializar a lista de anuncios que a empresa fez
            ListaDeAnuncios = new HashSet<Anuncios>();

        }
        [Key]
        public int ID { get; set; }
        //nome da empresa
        public string Nome { get; set; }

        // Morada da sede da empresa
        public string Morada { get; set; }

        // NIF da empresa
        public string NIF { get; set; }

        //atividade que a empresa pratica
        public string Atividade { get; set; }

        public string WebSite { get; set; }

        public string Telefone { get; set; }

        public string Foto { get; set; }


        public virtual ICollection<Anuncios> ListaDeAnuncios { get; set; }
    }
}
