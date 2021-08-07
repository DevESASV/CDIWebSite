using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.IO;
using CDIWebSite.SQL.DataContext;
using CDIWebSite.Services.Services;

namespace CDIWebSite.Web.Services.Calls
{
    public class PageSectionServices
    {
        public readonly PageSectionRepository _manejoPageSectionRepository = new PageSectionRepository();

        public byte[] ConvertToBytesArray(HttpPostedFileBase img)
        {
            byte[] ImgByte = null;
            using (var BinaryReader = new BinaryReader(img.InputStream))
            {
                ImgByte = BinaryReader.ReadBytes(img.ContentLength);
            }

            return ImgByte;
        }
    }
}