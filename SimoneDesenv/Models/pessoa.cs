using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace SimoneDesenv.Models
{
    public class pessoa
    {
        [Key]
        public int CodigoId { get; set; }
        public String Nome { get; set; }
        public String Endereco { get; set; }
        public String Nascimento { get; set; }
        public String Salario { get; set; }
        public String Genero { get; set; }
    }
}
