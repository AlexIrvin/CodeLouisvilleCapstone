using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using ShakenOrStirred.Model;

namespace ShakenOrStirred.Pages.Shaken
{
    public class SearchModel : PageModel
    {
        private readonly ApplicationDbContext _db;

        public SearchModel(ApplicationDbContext db)
        {
            _db = db;
        }

        public void OnGet()
        {
            // Instantiate the DeserializeJsonResult function
            //DrinkSet = DeserializeJsonResult(new JsonResult(Drinks));
            //List<Drink> drinks = DeserializeJsonResult((JsonResult)DrinkSet);
        }
    }
}