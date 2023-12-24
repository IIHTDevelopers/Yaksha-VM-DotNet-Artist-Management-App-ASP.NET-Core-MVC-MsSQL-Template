using ArtistManagementApp.DAL.Interface;
using ArtistManagementApp.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ArtistManagementApp.DAL.Repository
{
    public class ArtistManagementService : IArtistInterface
    {
        private IArtistRepository _repo;
        public ArtistManagementService(IArtistRepository repo)
        {
            this._repo = repo;
        }

        public Artist AddArtist(Artist artist)
        {
            //write your code here
            throw new NotImplementedException();
        }

        public Artist DeleteArtist(int artistId)
        {
            //write your code here
            throw new NotImplementedException();
        }

        public IEnumerable<Artist> GetAllArtists()
        {
            //write your code here
            throw new NotImplementedException();
        }

        public Artist GetArtistById(int artistId)
        {
            //write your code here
            throw new NotImplementedException();
        }

        public Artist UpdateArtist(Artist artist)
        {
            //write your code here
            throw new NotImplementedException();
        }
    }
}