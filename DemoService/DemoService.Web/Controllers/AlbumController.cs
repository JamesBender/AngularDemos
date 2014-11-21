using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web.Http;
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

        public Album GetAlbum(int id)
        {
            var album = _albumModel.GetAlbum(id);

            if (album == null)
            {
                throw new HttpResponseException(HttpStatusCode.NotFound);
            }
            else
            {
                return album;
            }
        }

        public int PostAlbum(Album album)
        {
            var newId = _albumModel.SaveAlbum(album);
            return newId;
        }
    }
}
