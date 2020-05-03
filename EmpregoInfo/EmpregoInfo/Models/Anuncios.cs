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
        [Key]
        public int ID { get; set; }


        public string Tipo { get; set; }

        public string Titulo { get; set; }
        //descriacao do anuncio, aka, o que é prentendido que o utilizador façaa
        public string Descricao { get; set; }

        public string ExperienciaNecessaria { get; set; }
        //nome da empresa que publicou o anuncio
        public string NomeEmpresa { get; set; }

        //salario que a empresa oferece
        public float Salario { get; set; }

        [DataType(DataType.Date)]
        //data da criacao do anuncio
        public DateTime DataCriacaoAnuncio { get; set; }

        //FK empresa que colocou o anuncio
        [ForeignKey(nameof(Empresa))]
        public int EmpresaFK { get; set; }
        public Empresas Empresa { get; set; }
    }
}
