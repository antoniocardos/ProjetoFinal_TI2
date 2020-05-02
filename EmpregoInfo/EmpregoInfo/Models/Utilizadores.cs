using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace EmpregoInfo.Models{
    /// <summary>
    /// Classe representa a tabela dos 'Utilizadores'. Contém os dados dos utilizadores registados.
    /// </summary>
    public class Utilizadores{

        [Key]
        public int ID { get; set; }

        public string Nome { get; set; }

        public string Email { get; set; }

        public string Telefone { get; set; }
        public string Cidade { get; set; }

        //Escolaridade e formacoes adquiridas por o utilizador
        public string Formacao { get; set; }

        // experiencia de trabalho
        public string Experiencia { get; set; }

        public string Foto { get; set; }

        // data da criacao da conta do utilizador
        public DateTime Data_criacao_conta { get; set; }

        public virtual ICollection<Candidaturas> ListaDeCandidaturas { get; set; }
    }
}
