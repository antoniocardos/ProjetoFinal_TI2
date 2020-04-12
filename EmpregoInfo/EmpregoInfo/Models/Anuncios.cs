using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EmpregoInfo.Models
{
    public class Anuncios
    {
        public int ID { get; set; }


        public string Tipo { get; set; }

        //descriacao do anuncio, aka o que é prentendido que o utilizador faca
        public string Descricao { get; set; }

        public string ExperienciaNecessaria { get; set; }
        //nome da empresa que publicou o anuncio
        public string NomeEmpresa { get; set; }

        //salario que a empresa oferece
        public float Salario { get; set; }
        //data da criacao do anuncio
        public DateTime dataCriacaoAnuncio { get; set; }
    }
}
