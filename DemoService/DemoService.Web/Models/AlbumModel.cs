using System.Collections.Generic;
using System.Linq;
using AutoMapper;
using DemoService.Core;
using Album = DemoService.Web.Models.ViewModels.Album;

namespace DemoService.Web.Models
{
    public interface IAlbumModel
    {
        IEnumerable<Album> GetAllAlbums();
        Album GetAlbum(int id);
        int SaveAlbum(Album album);
        int SaveAlbum(int id, Album album);
        void DeleteAlbum(int id);
    }

    public class AlbumModel : IAlbumModel
    {
        private readonly IAlbumRepository _albumRepository = new AlbumRepository();

        public IEnumerable<Album> GetAllAlbums()
        {
            return
                _albumRepository.GetListOfPeople()
                                 .Select(Mapper.Map<Core.Album, Album>)
                                 .ToList();
        }

        public Album GetAlbum(int id)
        {
            var album = _albumRepository.GetAlbum(id);

            return Mapper.Map<Core.Album, Album>(album);
        }

        public int SaveAlbum(Album album)
        {
            return _albumRepository.SaveAlbum(Mapper.Map<Album, Core.Album>(album));
        }

        public int SaveAlbum(int id, Album album)
        {
            return _albumRepository.SaveAlbum(id, Mapper.Map<Album, Core.Album>(album));
        }

        public void DeleteAlbum(int id)
        {
            _albumRepository.DeleteAlbum(id);
        }
    }
}