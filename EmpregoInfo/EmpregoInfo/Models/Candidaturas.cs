using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace EmpregoInfo.Models
{
    public class Candidaturas{
        [Key]
        public int ID { get; set; }

        public DateTime dataCandidatura { get; set; }

        //criar as FK

        // FK do anuncio a que corresponde a candidatura
        [ForeignKey(nameof(Anuncio))]
        public int AnuncioFK { get; set; }
        public Anuncios Anuncio { get; set; }

        // FK do utilizador que se candidatou ao anuncio
        [ForeignKey(nameof(Utilizador))]
        public int UtilizadorFK { get; set; }
        public Utilizadores Utilizador { get; set; }

        //FK empresa que colocou o anuncio
        [ForeignKey(nameof(Empresa))]
        public int EmpresaFK { get; set; }
        public Utilizadores Empresa { get; set; }


    }
}
