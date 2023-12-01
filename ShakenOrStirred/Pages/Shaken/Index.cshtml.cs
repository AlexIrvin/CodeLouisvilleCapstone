using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Newtonsoft.Json;
using ShakenOrStirred.Model;

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

        private const string URL = "http://www.thecocktaildb.com/api/json/v1/1/search.php?";
        private string urlParameters = "?api_key=1&s=margarita";


        public List<DrinkList> DrinkSet = new List<DrinkList>();

        public List<Drink> List2 = new List<Drink>();

        [HttpPost]
        public async Task<IEnumerable<Drink>> OnPostSearchAsync()
        {
        public List<Drink> drinks = new List<Drink>();
        HttpClient client = new HttpClient();
        client.BaseAddress = new Uri(URL);
        // Add an Accept header for JSON format.
        client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

            // List data response.
        HttpResponseMessage response = await client.GetAsync(urlParameters);
        var stream = await client.GetStringAsync(urlParameters);

        // DrinkList DrinkSet = JsonSerializer.Deserialize<DrinkList>(stream);
        Console.WriteLine("StopHere");
              
            if (response.IsSuccessStatusCode)
            {
            var jsonString = await response.Content.ReadAsStringAsync();
        var drinkList = JsonConvert.DeserializeObject<DrinkList>(jsonString);
    }
                if (drinkList != null)
                {
        
                }
}
}