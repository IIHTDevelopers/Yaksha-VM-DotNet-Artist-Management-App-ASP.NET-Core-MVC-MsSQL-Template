using Microsoft.AspNetCore.Mvc;
using ArtistManagementApp.DAL.Interface;
using ArtistManagementApp.Models;

namespace ArtistManagementApp.Controllers
{
    public class ArtistController : Controller
    {
        private readonly IArtistInterface _artistRepository;

        public ArtistController(IArtistInterface artistRepository)
        {
            _artistRepository = artistRepository;
        }

        // GET: /Artist/Index
        public IActionResult Index()
        {
            //write your code here
            throw new NotImplementedException();
        }

        // GET: /Artist/Details/{id}
        public IActionResult Details(int id)
        {
            //write your code here
            throw new NotImplementedException();
        }

        // GET: /Artist/Create
        public IActionResult Create()
        {
            //write your code here
            throw new NotImplementedException();
        }

        // POST: /Artist/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(Artist artist)
        {
            //write your code here
            throw new NotImplementedException();
        }

        // GET: /Artist/Edit/{id}
        public IActionResult Edit(int id)
        {
            //write your code here
            throw new NotImplementedException();
        }

        // POST: /Artist/Edit/{id}
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(int id, Artist updatedArtist)
        {
            //write your code here
            throw new NotImplementedException();
        }

        // GET: /Artist/Delete/{id}
        public IActionResult Delete(int id)
        {
            //write your code here
            throw new NotImplementedException();
        }

        // POST: /Artist/Delete/{id}
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public IActionResult DeleteConfirmed(int id)
        {
            //write your code here
            throw new NotImplementedException();
        }
    }
}
