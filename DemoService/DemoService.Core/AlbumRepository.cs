using System;
using System.Collections.Generic;

namespace DemoService.Core
{
    public class AlbumRepository : IAlbumRepository
    {
        private static readonly IDictionary<int, Album> AlbumList = new Dictionary<int, Album>();

        private readonly Album _sampleAlbum =
            new Album
            {
                Name = "Dark Side of the Moon",
                Artist = "Pink Floyd",
                Year = "1972",
                Id = 1
            };

        public AlbumRepository()
        {
            if (AlbumList.Count != 0) return;
            _sampleAlbum.Id = AlbumList.Count + 1;
            AlbumList.Add(_sampleAlbum.Id, _sampleAlbum);
        }

        public Album GetAlbum(int userId)
        {
            return AlbumList.ContainsKey(userId) ? AlbumList[userId] : null;
        }

        public int SaveAlbum(Album addedAlbum)
        {
            if (addedAlbum.Id != 0)
            {
                return UpdateAlbum(addedAlbum);
            }

            var newUserId = AlbumList.Count + 1;
            addedAlbum.Id = newUserId;
            AlbumList.Add(addedAlbum.Id, addedAlbum);

            return addedAlbum.Id;
        }

        public int SaveAlbum(int id, Album savedAlbum)
        {
            AlbumList.Add(id, savedAlbum);

            return id;
        }

        public int UpdateAlbum(Album updatedAlbum)
        {
            if (AlbumList.ContainsKey(updatedAlbum.Id))
            {
                AlbumList[updatedAlbum.Id] = updatedAlbum;
            }
            else
            {
                throw new ArgumentException("Album has a user id but does not exist in data store");
            }

            return updatedAlbum.Id;
        }

        public void DeleteAlbum(int userId)
        {
            if (AlbumList.ContainsKey(userId))
            {
                AlbumList.Remove(userId);
            }
        }

        public IEnumerable<Album> GetListOfPeople()
        {
            return AlbumList.Values;
        }
    }
}
