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

        public Utilizadores(){

            //inicializar a lista de candidaturas que o utilizador fez
            ListaDeCandidaturas = new HashSet<Candidaturas>();

        }
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
        [DataType(DataType.Date)]
        public DateTime Data_criacao_conta { get; set; }

        //Lista de candidaturas que o utilizador fez
        public virtual ICollection<Candidaturas> ListaDeCandidaturas { get; set; }
    }
}
