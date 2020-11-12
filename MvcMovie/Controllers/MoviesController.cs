using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using MvcMovie.Data;
using MvcMovie.Models;


namespace MvcMovie.Controllers
{
    public class MoviesController : Controller
    {
        private readonly MvcMovieContext _context;
        [Obsolete]
        private readonly IHostingEnvironment hostingEnvironment;

        public IList<Movie> Movies { get; set; }

        [Obsolete]
        public MoviesController(MvcMovieContext context,
                                IHostingEnvironment hostingEnvironment)
        {
            _context = context;
            this.hostingEnvironment = hostingEnvironment;
        }

        // GET: Movies
        public async Task<IActionResult> Index(string sortOrder, string searchString)
        {

            
            ViewData["DateSortParm"] = sortOrder == "ReleasedDate" ? "date_desc" : "ReleasedDate";
            var movies = from m in _context.Movie.Include(m => m.Genre) select m;

            if (!String.IsNullOrEmpty(searchString))
            {
                movies = movies.Where(s => s.Title.Contains(searchString));
            }


            switch (sortOrder)
            {
                
                case "ReleasedDate":
                    movies = movies.OrderBy(s => s.ReleaseDate);
                    break;
                case "date_desc":
                    movies = movies.OrderByDescending(s => s.ReleaseDate);
                    break;
                default:
                    movies = movies.OrderBy(s => s.ReleaseDate);
                    break;
            }

            return View(await movies.AsNoTracking().ToListAsync());
        }

        // GET: Movies/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var movie = await _context.Movie
                .Include(m => m.Genre)
                .FirstOrDefaultAsync(m => m.ID == id);
            if (movie == null)
            {
                return NotFound();
            }

            return View(movie);
        }

        // GET: Movies/Create
        public IActionResult Create()
        {
            ViewData["GenreID"] = new SelectList(_context.Genre, "GenreID", "Description");
            return View();
        }

        // POST: Movies/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        [Obsolete]
        
        public async Task<IActionResult> Create([Bind("ID,Title,ReleaseDate,GenreID,Price,Photo")] MovieCreateViewModel movie)
        {
            

            if (ModelState.IsValid)
            {
                string uniqueFilename = null;
                if (movie.Photo != null)
                {

                    string uploadsFolder = Path.Combine(hostingEnvironment.WebRootPath, "images");
                    uniqueFilename = Guid.NewGuid().ToString() + "_" + movie.Photo.FileName;
                    string filePath = Path.Combine(uploadsFolder, uniqueFilename);
                    movie.Photo.CopyTo(new FileStream(filePath, FileMode.Create));
                }

                Movie m = new Movie
                {
                    Title = movie.Title,
                    ReleaseDate = movie.ReleaseDate,
                    GenreID = movie.GenreID,
                    Price = movie.Price,
                    PhotoPath = uniqueFilename
                };

                //_context.Add(movie);
                _context.Add(m);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));                
            }

            ViewData["GenreID"] = new SelectList(_context.Genre, "GenreID", "Description", movie.GenreID);
            //return View(movie);
            return View(movie);
        }

        // GET: Movies/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var movie = await _context.Movie.FindAsync(id);
            if (movie == null)
            {
                return NotFound();
            }
            ViewData["GenreID"] = new SelectList(_context.Genre, "GenreID", "Description", movie.GenreID);

            MovieEditViewModel m = new MovieEditViewModel
            {
                ID = movie.ID,
                Title = movie.Title,
                ReleaseDate = movie.ReleaseDate,
                Price = movie.Price,
                GenreID = movie.GenreID
            };

            //return View(movie);
            return View(m);
        }

        // POST: Movies/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        [Obsolete]
        
        public async Task<IActionResult> Edit(int id, [Bind("ID,Title,ReleaseDate,GenreID,Price,Photo")] MovieEditViewModel movie)
        {
            if (id != movie.ID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    string uniqueFilename = null;
                    if (movie.Photo != null)
                    {

                        string uploadsFolder = Path.Combine(hostingEnvironment.WebRootPath, "images");
                        uniqueFilename = Guid.NewGuid().ToString() + "_" + movie.Photo.FileName;
                        string filePath = Path.Combine(uploadsFolder, uniqueFilename);
                        movie.Photo.CopyTo(new FileStream(filePath, FileMode.Create));
                    }

                    Movie m = new Movie
                    {
                        ID = movie.ID,
                        Title = movie.Title,
                        ReleaseDate = movie.ReleaseDate,
                        GenreID = movie.GenreID,
                        Price = movie.Price,
                        PhotoPath = uniqueFilename
                    };
                    

                    //_context.Update(movie);
                    _context.Update(m);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!MovieExists(movie.ID))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            ViewData["GenreID"] = new SelectList(_context.Genre, "GenreID", "Description", movie.GenreID);
            return View(movie);
        }

        // GET: Movies/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var movie = await _context.Movie
                .Include(m => m.Genre)
                .FirstOrDefaultAsync(m => m.ID == id);
            if (movie == null)
            {
                return NotFound();
            }

            return View(movie);
        }

        // POST: Movies/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var movie = await _context.Movie.FindAsync(id);
            _context.Movie.Remove(movie);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool MovieExists(int id)
        {
            return _context.Movie.Any(e => e.ID == id);
        }
    }
}
