using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web.Http;
using DemoService.Web.Models.ViewModels;

namespace DemoService.Web.Controllers
{
    public class AlbumController : ApiController
    {
        private IDictionary<int, Album> _albumDictionary; 

        public AlbumController()
        {
            _albumDictionary = new Dictionary<int, Album>
            {
                {1, new Album {Id = 1, Name = "Dark Side of the Moon", Artist = "Pink Floyd", Year = "1972"}}
            };
        }

        public IEnumerable<Album> GetListOfAlbum()
        {
            return _albumDictionary.Values.ToList();
        }

        public Album GetAlbum(int id)
        {
            if (!_albumDictionary.ContainsKey(id))
            {
                throw new HttpResponseException(HttpStatusCode.NotFound);
            }
            else
            {
                return _albumDictionary[id];
            }
        }

        public int PostAlbum(Album album)
        {
            var newId = _albumDictionary.Count + 1;
            _albumDictionary.Add(newId, album);
            return newId;
        }
    }
}
