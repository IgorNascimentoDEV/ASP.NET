using Domain.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entidades
{
    public class EnderecoModel
    {
        [Key]
        public int Id { get; set; }
        public string CEP { get; set; }
        public string? Logradouro { get; set; }
        public string? Bairro { get; set; } 
        public string? UF { get; set; }
    }
}