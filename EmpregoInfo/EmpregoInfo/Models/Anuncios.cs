using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace EmpregoInfo.Models
{
    public class Anuncios
    {
        /// <summary>
        /// Classe representa a tabela dos 'Anuncios'. Contém os anuncios publicados por as empresas.
        /// </summary>
        /// 
            public Anuncios(){
                //inicializar a lista que o anuncio tem
                ListaDeCandidaturas = new HashSet<Candidaturas>();

            }

        [Key]
        public int ID { get; set; }

        //Full-Time ou Part-Time
        public string Tipo { get; set; }

        public string Titulo { get; set; }
        //descriacao do anuncio, aka, o que é prentendido que o utilizador façaa
        public string Descricao { get; set; }

        public string ExperienciaNecessaria { get; set; }
        
        //local onde o trabalhador vai estar
        public string Local { get; set; }

        //salario que a empresa oferece
        public string Salario { get; set; }

        [DataType(DataType.Date)]
        //data da criacao do anuncio
        public DateTime DataCriacaoAnuncio { get; set; }

        //FK empresa que colocou o anuncio
        [ForeignKey(nameof(Empresa))]
        public int EmpresaFK { get; set; }
        public Empresas Empresa { get; set; }

        public virtual ICollection<Candidaturas> ListaDeCandidaturas { get; set; }
    }
}
