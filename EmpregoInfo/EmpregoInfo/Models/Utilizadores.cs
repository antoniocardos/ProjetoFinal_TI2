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

        [Required(ErrorMessage = "O Nome é de preenchimento obrigatório")]
        [StringLength(40, ErrorMessage = "O {0} só pode ter, no máximo, {1} carateres.")]
        [RegularExpression("[A-ZÁÍÓÚÉÂ][a-zãõáéíóúàèìòùäëïöüçâêîôû]+" +
         "(( | e |-|'| d'| de | d[ao](s)? )[A-ZÁÍÓÚÉÂ][a-zãõáéíóúàèìòùäëïöüçâêîôû]+){1,3}",
            ErrorMessage = "Só são aceites letras. Cada palavra deve começar por uma Maiúscula, separadas por um espaço em branco.")]
        public string Nome { get; set; }

        [Required(ErrorMessage = "O email é de preenchimento obrigatório")]
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }

        [Required(ErrorMessage = "O telefone é de preenchimento obrigatório, mas apenas será visivel para si.")]
        [StringLength(9, ErrorMessage = "O número de telefone deverá ter no máximo 9 números.")]
        [RegularExpression("9[1236][0-9]{7}|2[1-9][0-9]{7}", ErrorMessage = "O número de telefone deverá ter 9 números. E deverá começar por um 9, seguido de 1,2,3 ou 6.")]
        public string Telefone { get; set; }


        [Required(ErrorMessage = "A cidade é de preenchimento obrigatório")]
        
        public string Cidade { get; set; }
         
        //Escolaridade e formacoes adquiridas por o utilizador
        public string Formacao { get; set; }

        // experiencia de trabalho
        public string Experiencia { get; set; }

        public string Foto { get; set; }

        // data da criacao da conta do utilizador
        [DataType(DataType.Date)]
        public DateTime Data_criacao_conta { get; set; }

        /// <summary>
        /// https://imar.spaanjaars.com/297/regular-expression-for-a-strong-password
        /// Passwords will contain at least (1) upper case letter
        /// Passwords will contain at least(1) lower case letter
        ///Passwords will contain at least(1) number or special character
        ///Passwords will contain at least(8) characters in length
        /// </summary>
        [Required]
        [DataType(DataType.Password)]
        [Display(Name = "Password")]
        public string Password { get; set; }

        //Lista de candidaturas que o utilizador fez
        public virtual ICollection<Candidaturas> ListaDeCandidaturas { get; set; }
    }
}
