//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace CDIWebSite.SQL.DataContext
{
    using System;
    using System.Collections.Generic;
    
    public partial class CategorySection
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public CategorySection()
        {
            this.ImgSection = new HashSet<ImgSection>();
            this.VidSection = new HashSet<VidSection>();
        }
    
        public int IdCategory { get; set; }
        public string Category { get; set; }
        public string CatDescription { get; set; }
        public int Active { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ImgSection> ImgSection { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<VidSection> VidSection { get; set; }
    }
}
