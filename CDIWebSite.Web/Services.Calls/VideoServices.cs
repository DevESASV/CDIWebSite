using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using CDIWebSite.Web.Models;
using CDIWebSite.SQL.DataContext;
using CDIWebSite.Services.Services;

namespace CDIWebSite.Web.Services.Calls
{
    public class VideoServices
    {
        public readonly VideoRepository _manejoVideoRepository = new VideoRepository();
        public bool AgregarVideo(VidSectionVM model)
        {
            bool Exito;
            VidSection obj = new VidSection
            {
                IdCategory = model.IdCategory,
                iFrameVideo = model.iFrame,
                Titulo = model.Title,
                CitaBiblica = model.Cita,
                Pastor = model.Pastor,
                Descripcion = model.Description,
                Active = 1
            };

            Exito = _manejoVideoRepository.NewVideo(obj);
            return Exito;
        }

        public VidSectionVM ListaVideos(int page)
        {
            VidSectionVM model = new VidSectionVM();
            var lista = _manejoVideoRepository.GetVideos(page);
            foreach(var item in lista)
            {
                model.Lst.Add(new VidSectionVM
                {
                    Id = (int)item.IdVideo,
                    IdCategory = (int)item.IdCategory,
                    Title = item.Title,
                    Pastor = item.Pastor,
                    Description = item.Descripcion,
                    iFrame = item.iFrame
                });
            }
            model.TotalReg = _manejoVideoRepository.TotalReg();
            model.Page = page;
            return model;
        }
    }
}