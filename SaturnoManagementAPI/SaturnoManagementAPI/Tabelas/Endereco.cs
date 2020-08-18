using SaturnoManagementAPI.Enum;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace SaturnoManagementAPI.Tabelas
{
    public class Endereco
    {
        [Key]
        public int ID { get; set; }
        [Required]
        [StringLength(2)]
        public string Estado { get; set; }
        [Required]
        [MaxLength(32, ErrorMessage = "Ultrapassado o limite de 32 caracteres.")]
        [MinLength(3, ErrorMessage = "Ultrapassado o limite mínimo de 3 caracteres.")]
        public string Cidade { get; set; }
        [Required]
        [MaxLength(32, ErrorMessage = "Ultrapassado o limite de 32 caracteres.")]
        [MinLength(3, ErrorMessage = "Ultrapassado o limite mínimo de 3 caracteres.")]
        public string Bairro { get; set; }
        [Required]
        [MaxLength(32, ErrorMessage = "Ultrapassado o limite de 32 caracteres.")]
        [MinLength(3, ErrorMessage = "Ultrapassado o limite mínimo de 3 caracteres.")]
        public string Rua { get; set; }
        [Required]
        [StringLength(8)]
        public string CEP { get; set; }
        [Required]
        [MaxLength(6, ErrorMessage = "Ultrapassado o limite de 6 caracteres.")]
        [MinLength(1, ErrorMessage = "Ultrapassado o limite mínimo de 1 caracteres.")]
        public int Numero { get; set; }
        public string Complemento { get; set; }
        [Required]
        public PermissaoEnum Permissao { get; set; }


    }
}
