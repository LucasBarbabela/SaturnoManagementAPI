using SaturnoManagementAPI.Enum;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace SaturnoManagementAPI.Tabelas
{
    public class Cliente
    {
        [Key]
        public int ID { get; set; }
        [Required]
        [MaxLength(60, ErrorMessage = "Ultrapassado o limite de 60 caracteres.")]
        [MinLength(5, ErrorMessage = "Ultrapassado o limite mínimo de 5 caracteres.")]
        public string Nome { get; set; }
        [StringLength(11, ErrorMessage = "O CPF deve ter 11 caracteres")]
        public string CPF { get; set; }
        [Required]
        [MaxLength(30, ErrorMessage = "Ultrapassado o limite de 30 caracteres.")]
        [MinLength(6, ErrorMessage = "Ultrapassado o limite mínimo de 6 caracteres.")]
        public string Telefone { get; set; }    
        public string Email { get; set; }
        [Required]
        public Endereco Endereco { get; set; }
        [Required]
        public PermissaoEnum Permissao { get; set; }

    }
}
