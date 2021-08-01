using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace CDIWebSite.Web.Models
{
    public class VidSectionVM : BaseModel
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "Es necesario definir una categoria para el video!")]
        public int IdCategory { get; set; }
        [Required(ErrorMessage = "Este campo no puede estar vacio!")]
        public string iFrame { get; set; }
        [Required(ErrorMessage = "Este campo no puede estar vacio!")]
        [MaxLength(100, ErrorMessage = "El Titulo no puede superar los 100 caracteres!")]
        public string Title { get; set; }
        [Required(ErrorMessage = "Este campo no puede estar vacio!")]
        [MaxLength(150, ErrorMessage = "La Cita Biblica no puede superar los 150 caracteres!")]
        public string Cita { get; set; }
        [Required(ErrorMessage = "Este campo no puede estar vacio!")]
        [MaxLength(100, ErrorMessage = "El campo Pastor no puede superar los 100 caracteres!")]
        public string Pastor { get; set; }
        [MaxLength(300, ErrorMessage = "La descripcion no puede superar los 300 caracteres!")]
        public string Description { get; set; }

        public List<VidSectionVM> Lst { get; set; }
    }
}