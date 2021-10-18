using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CursoMVC.Models
{
    public class Produto
    {
        public int id{ get; set; }

        [Required(ErrorMessage = "O campo descrição e obrigatório!")]
        [Display(Name ="Descrição")]
        public string Descricao { get; set; }

        [Required(ErrorMessage = "O campo Quantidade e obrigatório!")]
        public int Quantidade { get; set; }

        [Required(ErrorMessage = "Escolha uma categoria")]
        public int CategoriaId { get; set; }

        public Categoria Categoria { get; set; }
    }
}
