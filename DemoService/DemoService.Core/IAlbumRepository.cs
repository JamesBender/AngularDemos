using System.Collections.Generic;

namespace DemoService.Core
{
    public interface IAlbumRepository
    {
        Album GetAlbum(int userId);
        int SaveAlbum(Album addedAlbum);
        int SaveAlbum(int id, Album savedAlbum);
        int UpdateAlbum(Album updatedAlbum);
        void DeleteAlbum(int userId);
        IEnumerable<Album> GetListOfPeople();
    }
}