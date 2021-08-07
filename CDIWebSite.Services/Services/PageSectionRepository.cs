using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CDIWebSite.SQL.DataContext;
using System.Data.Entity;

namespace CDIWebSite.Services.Services
{
    public class PageSectionRepository
    {
        public readonly CDIWebSiteEntities bd = new CDIWebSiteEntities();

        public List<PageSection> GetBanners()
        {
            List<PageSection> Banners = new List<PageSection>();
            try
            {
                Banners = bd.PageSection.Where(x => (x.idCategory == 1) && (x.Active == 1) ).ToList();
            }
            catch(Exception e)
            {
                Debug.WriteLine("<<< catch : " + e.Message);
            }
            return Banners;
        }

        public bool AddBanner(PageSection model)
        {
            bool Exito;
            try
            {
                model.idCategory = 1;
                bd.PageSection.Add(model);
                bd.SaveChanges();
                Exito = true;
            }catch(Exception e)
            {
                Debug.WriteLine("<<< catch : " + e.Message);
                Exito = false;
            }

            return Exito;
        }

        public bool DeleteAnyBanner(int id)
        {
            bool Exito;
            try
            {
                var banner = bd.PageSection.Where(x => x.idPS == 1).Single();
                banner.Active = 0;
                bd.Entry(banner).State = EntityState.Modified;
                bd.SaveChanges();
                Exito = true;
            }catch(Exception e)
            {
                Debug.WriteLine("<<< catch : " + e.Message);
                Exito = false;
            }
            return Exito;
        }

        public List<PageSection> GetInvBanners()
        {
            List<PageSection> InvBanners = new List<PageSection>();
            try
            {
                InvBanners = bd.PageSection.Where(x => (x.idCategory == 2) && (x.Active == 1)).ToList();
            }catch(Exception e)
            {
                Debug.WriteLine("<<< catch : " + e.Message);
            }

            return InvBanners;
        }

        public bool AddInvBanner(PageSection model)
        {
            bool Exito;
            try
            {
                model.idCategory = 2;
                bd.PageSection.Add(model);
                bd.SaveChanges();
                Exito = true;
            }catch(Exception e)
            {
                Debug.WriteLine("<<< catch : " + e.Message);
                Exito = false;
            }
            return Exito;
        }

        public List<PageSection> GetVideoBanners()
        {
            List<PageSection> VideoBanner = new List<PageSection>();
            try
            {
                VideoBanner = bd.PageSection.Where(x => (x.idCategory == 3) && (x.Active == 1)).ToList();
            }catch(Exception e)
            {
                Debug.WriteLine("<<< catch : " + e.Message);
            }
            return VideoBanner;
        }

        public bool AddGetVideobanner(PageSection model)
        {
            bool Exito;
            try
            {
                model.idCategory = 3;
                bd.PageSection.Add(model);
                bd.SaveChanges();
                Exito = true;
            }catch(Exception e)
            {
                Debug.WriteLine("<<< catch : " + e.Message);
                Exito = false;
            }
            return Exito;
        }

        public List<PageSection> GetCuidaBanners()
        {
            List<PageSection> CuidaBanners = new List<PageSection>();
            try
            {
                CuidaBanners = bd.PageSection.Where(x => (x.idCategory == 4) && (x.Active == 1)).ToList();
            }catch(Exception e)
            {
                Debug.WriteLine("<<< catch : " + e.Message);
            }
            return CuidaBanners;
        }

        public bool AddCuidaBanner(PageSection model)
        {
            bool Exito;
            try
            {
                model.idCategory = 4;
                bd.PageSection.Add(model);
                bd.SaveChanges();
                Exito = true;
            }catch(Exception e)
            {
                Debug.WriteLine("<<< catch : " + e.Message);
                Exito = true;
            }
            return Exito;
        }
    }
}
