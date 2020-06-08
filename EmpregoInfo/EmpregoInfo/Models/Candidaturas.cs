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

        public DateTime DataCandidatura { get; set; }

        //O porquê do utilizador que se está a candidatar deve ser o escolhido
        public string Descricao { get; set; }

        //criar as FK

        // FK do anuncio a que corresponde a candidatura
        [ForeignKey(nameof(Anuncio))]
        public int AnuncioFK { get; set; }
        public Anuncios Anuncio { get; set; }

        // FK do utilizador que se candidatou ao anuncio
        [ForeignKey(nameof(Utilizador))]
        public int UtilizadorFK { get; set; }
        public Utilizadores Utilizador { get; set; }

        //Curriculo do Utilizador
        [ForeignKey(nameof(CurriculoUtilizador))]
        public int CurriculoUtilizadorFK { get; set; }
        public Utilizadores CurriculoUtilizador { get; set; }

        //Foto do Utilizador
        [ForeignKey(nameof(FotoUtilizador))]
        public int FotoUtilizadorFK { get; set; }
        public Utilizadores FotoUtilizador { get; set; }


    }
}
