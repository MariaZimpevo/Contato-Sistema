using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ControleDeContactos.Models
{
    public class ContatoModel
    {
        public int Id { get; set; }
        [Required (ErrorMessage = "Informe o nome do Contacto")]
        public string Nome { get; set; }
        [Required (ErrorMessage = "Informe o Email do Contato")]
        [EmailAddress(ErrorMessage ="Emai inválido")]
        public string Email { get; set; }
        [Required(ErrorMessage = "Informe o Número de Telefone")]
        [Phone(ErrorMessage ="Número inválido")]
        public string Telefone { get; set; }
    }
}
