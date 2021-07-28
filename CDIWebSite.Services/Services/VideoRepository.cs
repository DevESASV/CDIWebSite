using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CDIWebSite.SQL.DataContext;

namespace CDIWebSite.Services.Services
{
    class VideoRepository
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
    }
}
