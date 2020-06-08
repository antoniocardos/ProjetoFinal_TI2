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
        [Required(ErrorMessage = "O Nome é de preenchimento obrigatório")]
        [StringLength(40, ErrorMessage = "O {0} só pode ter, no máximo, {1} carateres.")]
        [RegularExpression("[A-ZÁÍÓÚÉÂ][a-zãõáéíóúàèìòùäëïöüçâêîôû]+" +
         "(( | e |-|'| d'| de | d[ao](s)? )[A-ZÁÍÓÚÉÂ][a-zãõáéíóúàèìòùäëïöüçâêîôû]+){1,3}",
            ErrorMessage = "Só são aceites letras. Cada palavra deve começar por uma Maiúscula, separadas por um espaço em branco.")]
        public string Nome { get; set; }

        // Morada da sede da empresa
        [Required(ErrorMessage = "A Morada é de preenchimento obrigatório")]
        [Display(Name = "Morada")]
        [StringLength(40, ErrorMessage = "O {0} só pode ter, no máximo, {1} carateres.")]
        [RegularExpression(@"^[A-Za-z0-9]+(?:\s[A-Za-z0-9'_-]+)+$",
            ErrorMessage = "Por favor insira uma morada válida.")]
        public string Morada { get; set; }
    
        [Required(ErrorMessage = "O código postal é de preenchimento obrigatório")]
        [Display(Name = "Codigo Postal")]
        [RegularExpression("[1-9] [0-9]{3}-[0-9]{3}",
            ErrorMessage = "Por favor insira Código Postal válido")]
        public string CodigoPostal { get; set; }

        // NIF da empresa
        [RegularExpression("[12356][0-9]{8}", 
            ErrorMessage = "Por favor insira NIF válido.")]
        public string NIF { get; set; }

        //atividade que a empresa pratica
        public string Atividade { get; set; }

        public string WebSite { get; set; }

        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }

        public string Telefone { get; set; }

        public string Logotipo { get; set; }

        //lista de anuncios que uma empresa lançou
        public virtual ICollection<Anuncios> ListaDeAnuncios { get; set; }
    }
}
