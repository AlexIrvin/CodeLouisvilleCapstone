using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using ShakenOrStirred.Model;
using System.Net.Http.Headers;
using System.Reflection.Metadata;
using System.Security.Cryptography.Xml;
using System.Net.Http.Formatting;
using Newtonsoft.Json;

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
        public DrinkModel Drink { get; set; }

        private const string URL = "http://www.thecocktaildb.com/api/json/v1/1/search.php?s=margarita";
        private string urlParameters = "?api_key=1";

        //       public async Task<IActionResult> OnGetAsync()
        //     {
        //       return Page();
        // }

        public interface IDataRepo
        {
            Task CreateDrinks(DrinkModel model);
            Task<List<DrinkModel>> GetDrinks();
            
        }

        public async Task<IActionResult> OnGetLoadSearchAsync()
        {
            HttpClient client = new HttpClient();
            client.BaseAddress = new Uri(URL);

            // Add an Accept header for JSON format.
            client.DefaultRequestHeaders.Accept.Add(
                new MediaTypeWithQualityHeaderValue("application/json"));

            // List data response.
            HttpResponseMessage response = await client.GetAsync(urlParameters); 
            if (response.IsSuccessStatusCode)
            {
                // Parse the response body.

                var dataObjects = await response.Content.ReadAsAsync<IEnumerable<DrinkModel>>();  
                foreach (var d in dataObjects)
                {
                    Console.WriteLine(d.strDrink);
                }
            }
            else
            {
                Console.WriteLine("{0} ({1})", (int)response.StatusCode, response.ReasonPhrase);
            }

            // Make any other calls using HttpClient here.

            // Dispose once all HttpClient calls are complete.
            client.Dispose();

            return Page();
        }
    }
}
