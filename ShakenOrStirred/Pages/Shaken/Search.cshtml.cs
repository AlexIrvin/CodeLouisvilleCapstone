using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using ShakenOrStirred.Model;
using System.Net.Http.Headers;
using System.Reflection.Metadata;
using System.Security.Cryptography.Xml;
using System.Net.Http.Formatting;
using System.Diagnostics;
using System;
using System.Text.Json;
using System.Collections.Generic;

namespace ShakenOrStirred.Pages.Shaken
{
    public class SearchModel : PageModel
    {
        private readonly ApplicationDbContext _db;

        public SearchModel(ApplicationDbContext db)
        {
            _db = db;
        }

        [BindProperty(SupportsGet = true)]
        public List<Drink> Drink { get; set; }

        private const string URL = "http://www.thecocktaildb.com/api/json/v1/1/search.php?";
        private string urlParameters = "?api_key=1&s=margarita";
        public DrinkList drinks { get; set; }

        public List<DrinkList> DrinkSet = new List<DrinkList>();

        public async Task<IActionResult> OnPostSearch()
        {
            HttpClient client = new HttpClient();
            client.BaseAddress = new Uri(URL);

            // Add an Accept header for JSON format.
            client.DefaultRequestHeaders.Accept.Add(
                new MediaTypeWithQualityHeaderValue("application/json"));

            // List data response.
            HttpResponseMessage response = await client.GetAsync(urlParameters);
            var stream = await client.GetStringAsync(urlParameters);
            DrinkList DrinkSet = JsonSerializer.Deserialize<DrinkList>(stream);

            if (response.IsSuccessStatusCode)
            {

                
 
            }
            else
            {
                Debug.WriteLine("{0} ({1})", (int)response.StatusCode, response.ReasonPhrase);
            }
            // Make any other calls using HttpClient here.

            // Dispose once all HttpClient calls are complete.
            client.Dispose();

            return Page();
        }
    }
}
