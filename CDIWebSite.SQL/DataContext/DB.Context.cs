﻿//------------------------------------------------------------------------------
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
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    using System.Data.Entity.Core.Objects;
    using System.Linq;
    
    public partial class CDIWebSiteEntities : DbContext
    {
        public CDIWebSiteEntities()
            : base("name=CDIWebSiteEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<CategorySection> CategorySection { get; set; }
        public virtual DbSet<Evento> Evento { get; set; }
        public virtual DbSet<ImgSection> ImgSection { get; set; }
        public virtual DbSet<Inscriptions> Inscriptions { get; set; }
        public virtual DbSet<NetUsers> NetUsers { get; set; }
        public virtual DbSet<Persona> Persona { get; set; }
        public virtual DbSet<Request> Request { get; set; }
        public virtual DbSet<VidSection> VidSection { get; set; }
        public virtual DbSet<ImageCategory> ImageCategory { get; set; }
        public virtual DbSet<PageSection> PageSection { get; set; }
    
        [DbFunction("CDIWebSiteEntities", "FnPager")]
        public virtual IQueryable<FnPager_Result> FnPager(Nullable<int> pagina, Nullable<int> cantRegistros)
        {
            var paginaParameter = pagina.HasValue ?
                new ObjectParameter("pagina", pagina) :
                new ObjectParameter("pagina", typeof(int));
    
            var cantRegistrosParameter = cantRegistros.HasValue ?
                new ObjectParameter("cantRegistros", cantRegistros) :
                new ObjectParameter("cantRegistros", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.CreateQuery<FnPager_Result>("[CDIWebSiteEntities].[FnPager](@pagina, @cantRegistros)", paginaParameter, cantRegistrosParameter);
        }
    }
}
