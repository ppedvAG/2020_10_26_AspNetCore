using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.CodeAnalysis.CSharp;
using MovieSharedLibrary.Entities;
using Newtonsoft.Json;

namespace MovieUI.Controllers
{
    public class MovieController : Controller
    {
        string baseAddress = "https://localhost:44328/api/Movie/";

        public MovieController()
        {
        }

        // GET: Movie
        public async Task<IActionResult> Index()
        {

            IList<Movie> resultList = new List<Movie>();

            HttpClient client = new HttpClient();

            HttpRequestMessage message = new HttpRequestMessage(HttpMethod.Get, baseAddress);
            HttpResponseMessage response = await client.SendAsync(message);

            string jsonText = await response.Content.ReadAsStringAsync();

            resultList = JsonConvert.DeserializeObject<List<Movie>>(jsonText);

            return View(resultList);
        }

        // GET: Movie/Details/5
        public async Task<IActionResult> Details(Guid? id)
        {
            if (id == null)
            {
                return NotFound();
            }


            Movie movie = null;

            string url = baseAddress + id.ToString();

            using (HttpClient client = new HttpClient())
            {
                HttpResponseMessage response = await client.GetAsync(url);
                string jsonText = await response.Content.ReadAsStringAsync();
                movie = JsonConvert.DeserializeObject<Movie>(jsonText);
            }



            if (movie == null)
            {
                return NotFound();
            }

            return View(movie);
        }

        // GET: Movie/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Movie/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Title,Start,IMDB_Bewertung")] Movie movie)
        {
            if (ModelState.IsValid)
            {
                movie.Id = Guid.NewGuid();

                string json = JsonConvert.SerializeObject(movie);

                var data = new StringContent(json, Encoding.UTF8, "application/json");

                using (HttpClient client = new HttpClient())
                {
                    HttpResponseMessage response = await client.PostAsync(baseAddress, data);
                    string result = await response.Content.ReadAsStringAsync();
                }
                


                return RedirectToAction(nameof(Index));
            }
            return View(movie);
        }

        // GET: Movie/Edit/5
        public async Task<IActionResult> Edit(Guid? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Movie movie = null;

            string url = baseAddress + id.ToString();

            using (HttpClient client = new HttpClient())
            {
                var response = client.GetAsync(url);
                string jsonText = await response.Result.Content.ReadAsStringAsync();
                movie = JsonConvert.DeserializeObject<Movie>(jsonText);
            }

            if (movie == null)
            {
                return NotFound();
            }
            return View(movie);
        }

        // POST: Movie/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(Guid id, [Bind("Id,Title,Start,IMDB_Bewertung")] Movie movie)
        {
            if (id != movie.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {

                string url = baseAddress + id.ToString();

                string json = JsonConvert.SerializeObject(movie);
                var data = new StringContent(json, Encoding.UTF8, "application/json");

                using (HttpClient client = new HttpClient())
                {
                    var response = client.PutAsync(url, data);
                    string result = await response.Result.Content.ReadAsStringAsync();
                }

                return RedirectToAction(nameof(Index));
            }
            return View(movie);
        }

        // GET: Movie/Delete/5
        public async Task<IActionResult> Delete(Guid? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Movie movie = null;

            string url = baseAddress + id.ToString();

            using (HttpClient client = new HttpClient())
            {
                HttpResponseMessage response = await client.GetAsync(url);
                string jsonText = await response.Content.ReadAsStringAsync();
                movie = JsonConvert.DeserializeObject<Movie>(jsonText);
            }

            if (movie == null)
            {
                return NotFound();
            }

            return View(movie);
        }

        // POST: Movie/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(Guid id)
        {
            string url = baseAddress + id.ToString();

            using (HttpClient client = new HttpClient())
            {
                var response = await client.DeleteAsync(url);

                string result = await response.Content.ReadAsStringAsync();
            }



            return RedirectToAction(nameof(Index));
        }

        
    }
}
