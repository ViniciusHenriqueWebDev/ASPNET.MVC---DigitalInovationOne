using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CursoMVC.Models
{
    public class Categoria
    {
        public int id { get; set; }

        [Required(ErrorMessage = "O campo descrição e obrigatório!")]
        [Display(Name = "Descrição")]
        public string Descricao { get; set; }

    }
}
