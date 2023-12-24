using ArtistManagementApp.DAL.Interface;
using ArtistManagementApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;

namespace ArtistManagementApp.DAL.Repository
{
    public class ArtistRepository : IArtistRepository
    {
        private ArtistDbContext _context;
        public ArtistRepository(ArtistDbContext Context)
        {
            this._context = Context;
        }
      
        public Artist GetArtistById(int artistId)
        {
            //write your code here
            throw new NotImplementedException();
        }

        public IEnumerable<Artist> GetAllArtists()
        {
            //write your code here
            throw new NotImplementedException();
        }

        public Artist AddArtist(Artist artist)
        {
            //write your code here
            throw new NotImplementedException();
        }


        public Artist UpdateArtist(Artist updatedArtist)
        {
            //write your code here
            throw new NotImplementedException();
        }

        public Artist DeleteArtist(int artistId)
        {
            //write your code here
            throw new NotImplementedException();
        }
    }
}
