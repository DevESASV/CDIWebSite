using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CDIWebSite.SQL.DataContext;
using System.Data.Entity;
using System.Diagnostics;

namespace CDIWebSite.Services.Services
{
    public class VideoRepository
    {
        public List<FnPager_Result> GetVideos(int page)
        {
            List<FnPager_Result> lst;
            using (var db = new CDIWebSiteEntities())
            {
                lst = db.FnPager(page, 9).ToList();
            }

            return lst;
        }

        public int TotalReg()
        {
            int TotalRegistros;
            using(var db = new CDIWebSiteEntities())
            {
                TotalRegistros = db.VidSection.Where(x => x.Active == 1).Count();
            }

            return TotalRegistros;
        }

        public bool NewVideo(VidSection model)
        {
            bool Exito;
            using(var db = new CDIWebSiteEntities())
            {
                try
                {
                    db.VidSection.Add(model);
                    db.SaveChanges();
                    Exito = true;
                }catch(Exception e)
                {
                    Debug.WriteLine("<<< catch : " + e.Message);
                    Exito = false;
                }

                return Exito;
            }
        }

        public VidSection GetVideoById(int id)
        {
            VidSection obj = new VidSection();
            using(var db = new CDIWebSiteEntities())
            {
                try
                {
                    obj = db.VidSection.Where(x => x.IdVideo == id).Single();
                }catch(Exception e)
                {
                    Debug.WriteLine("<<< catch : " + e.Message);
                }

                return obj;
            }
        }

        public bool EditVids(VidSection model)
        {
            bool Exito;
            using(var db = new CDIWebSiteEntities()) 
            {
                try
                {
                    db.Entry(model).State = EntityState.Modified;
                    db.SaveChanges();
                    Exito = true;
                }catch(Exception e)
                {
                    Debug.WriteLine("<<< catch : " + e.Message);
                    Exito = false;
                }

                return Exito;
            }
        }

        public bool DeleteVid(int id)
        {
            bool Exito;
            using(var db = new CDIWebSiteEntities())
            {
                try
                {
                    VidSection model = db.VidSection.Where(x => x.IdVideo == id).Single();
                    model.Active = 0;

                    db.Entry(model).State = EntityState.Modified;
                    db.SaveChanges();
                    Exito = true;
                }
                catch(Exception e)
                {
                    Debug.WriteLine("<<< catch : " + e.Message);
                    Exito = false;
                }

                return Exito;
            }
        }
    }
}
