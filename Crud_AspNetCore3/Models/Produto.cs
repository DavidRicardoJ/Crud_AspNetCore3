using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;


namespace Crud_AspNetCore3.Models
{
    public class Produto
    {
        [Key]
        public int ProdutoId { get; set; }

        [Display(Name = "Nome do Produto")]
        [Required(ErrorMessage ="Campo obrigátorio.")]
        [StringLength(100, MinimumLength = 4, ErrorMessage = "Requer no mínimo 4 caracteres e no máximo 100 caracteres.")]
        public string NomeProduto { get; set; }
       

        [Required(ErrorMessage = "Campo obrigátorio.")]
        [StringLength(100, MinimumLength = 4, ErrorMessage = "Requer no mínimo 4 caracteres e no máximo 100 caracteres.")]
        public string Descricao { get; set; }


        [Required(ErrorMessage = "Campo obrigátorio.")]
        [StringLength (100, MinimumLength = 4, ErrorMessage ="Requer no mínimo 4 caracteres e no máximo 100 caracteres.")]
        public string Fabricante { get; set; }
    }
}
