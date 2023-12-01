using Microsoft.AspNetCore.Diagnostics;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using ShakenOrStirred.Model;
using System;
using System.IO;
using System.Net.Http.Headers;
using System.Text;
using System.Text.Json.Nodes;

namespace ShakenOrStirred.Pages.Shaken
{
    public class IndexModel : PageModel
    {
        private readonly ApplicationDbContext _db;

        public IndexModel(ApplicationDbContext db)
        {
            _db = db;
        }

        [BindProperty(SupportsGet = true)]
        public IEnumerable<Drink> Drinks { get; set; }

        public List<Drink> DrinkSet {get; set;}

        [HttpPost]
        public async Task<IActionResult> OnPostLoadSearch()
        {
            // Create a new instance of HttpClient
            using (var HttpClient = new HttpClient())
            {
                // Call the API
                using (HttpResponseMessage response = await HttpClient.GetAsync("http://www.thecocktaildb.com/api/json/v1/1/search.php?api_key=1&s=margarita"))
                {
                    string apiResponse = await response.Content.ReadAsStringAsync();
                    DrinkList drinkList = JsonConvert.DeserializeObject<DrinkList>(apiResponse);
                    DrinkSet = drinkList.Drinks.ToList();
                    //return new JsonResult(DrinkSet);
                    DeserializeJsonResult(new JsonResult(DrinkSet));
                    return RedirectToPage("/Shaken/Search");
                }

            }

        }
        public List<Drink> DeserializeJsonResult(JsonResult DrinkSet)
        {
            string json = JsonConvert.SerializeObject(DrinkSet.Value);
            List<Drink> drinks = JsonConvert.DeserializeObject<List<Drink>>(json);
            return drinks;
        }

    }
}
