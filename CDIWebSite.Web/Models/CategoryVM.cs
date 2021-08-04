using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace CDIWebSite.Web.Models
{
    public class CategoryVM
    {
        public int IdCategory { get; set; }
        [Required(ErrorMessage = "El nombre de la Categoria es requerido!")]
        [MaxLength(45, ErrorMessage = "El nombre de categoria no puede superar los 45 caracteres!")]
        public string Category { get; set; }
        [Required(ErrorMessage = "La Descripcion de la categoria es requerida!")]
        [MaxLength(300, ErrorMessage ="La descripcion no puede superar los 300 caracteres!")]
        public string Description { get; set; }

        public List<CategoryVM> CategoryLst { get; set; }
    }
}