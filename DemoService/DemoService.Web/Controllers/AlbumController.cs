using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Mvc;
using DemoService.Web.Models;
using DemoService.Web.Models.ViewModels;

namespace DemoService.Web.Controllers
{
    public class AlbumController : ApiController
    {
        private readonly IAlbumModel _albumModel;

        public AlbumController()
        {
            AutoMapperConfiguration.Configure();
            _albumModel = new AlbumModel();
        }

        public IEnumerable<Album> GetListOfAlbum()
        {
            return _albumModel.GetAllAlbums();
        }

        public HttpResponseMessage GetAlbum(int id)
        {
            var album = _albumModel.GetAlbum(id);

            if (album == null)
            {
                return new HttpResponseMessage(HttpStatusCode.NotFound);
            }
            return Request.CreateResponse(HttpStatusCode.OK, album);
        }

        public int PostAlbum(Album album)
        {
            var newId = _albumModel.SaveAlbum(album);
            return newId;
        }

        public HttpResponseMessage PutAlbum(int id, Album album)
        {
            try
            {
                _albumModel.SaveAlbum(album);
                return new HttpResponseMessage(HttpStatusCode.OK);
            }
            catch (Exception)
            {
                
                return new HttpResponseMessage(HttpStatusCode.MethodNotAllowed);
            }
        }
    }
}
