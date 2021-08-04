using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CDIWebSite.SQL.DataContext;
using System.Data.Entity;

namespace CDIWebSite.Services.Services
{
    public class CategoryRepository
    {
        public readonly CDIWebSiteEntities db = new CDIWebSiteEntities();

        public List<CategorySection> GetCategories()
        {
            List<CategorySection> Lst = db.CategorySection.Where(x => x.Active == 1).ToList();
            return Lst;
        }

        public bool NewCategory(CategorySection model)
        {
            bool Exito;
            try
            {
                db.CategorySection.Add(model);
                db.SaveChanges();
                Exito = true;
            }catch(Exception e)
            {
                Exito = false;
            }

            return Exito;
        }

        public bool DeleteCategory(int id)
        {
            bool Exito;

            try
            {
                CategorySection model = db.CategorySection.Where(x => x.IdCategory == id).Single();
                model.Active = 0;
                db.Entry(model).State = EntityState.Modified;
                db.SaveChanges();
                Exito = true;
            }catch(Exception e)
            {
                Exito = false;
            }

            return Exito;
        }
    }
}
