using BlazorMusicCatalog.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlazorMusicCatalog.Data.Services
{
    public interface IAlbumService
    {
        Task<IEnumerable<Album>> GetAlbums();
        Task<Album> GetAlbumDetails(int id);
        Task<bool> InsertAlbum(Album album);
        Task<bool> UpdateAlbum(Album album);
        Task<bool> DeleteAlbum(Album album);

    }
}
