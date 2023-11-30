using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json;
using System.Text.Json.Serialization;

namespace ShakenOrStirred.Model;

public class DrinkList
{
    [JsonPropertyName("drinks")]
    public List<Drink> Drinks { get; set; }
}

public class Drink
{
    public string idDrink { get; set; } = default!;
    public string strDrink { get; set; } = default!;
    public object strDrinkAlternate { get; set; } = default!;
    public object strTags { get; set; } = default!;
    public object strVideo { get; set; } = default!;
    public string strCategory { get; set; } = default!;
    public object strIBA { get; set; } = default!;
    public string strAlcoholic { get; set; } = default!;
    public string strGlass { get; set; } = default!;
    public string strInstructions { get; set; } = default!;
    public object strInstructionsES { get; set; } = default!;
    public string strInstructionsDE { get; set; } = default!;
    public object strInstructionsFR { get; set; } = default!;
    public string strInstructionsIT { get; set; } = default!;

    [JsonProperty("strInstructionsZH-HANS")]
    public object StrInstructionsZHHANS { get; set; } = default!;

    [JsonProperty("strInstructionsZH-HANT")]
    public object StrInstructionsZHHANT { get; set; } = default!;
    public string strDrinkThumb { get; set; } = default!;
    public string strIngredient1 { get; set; } = default!;
    public string strIngredient2 { get; set; } = default!;
    public string strIngredient3 { get; set; } = default!;
    public string strIngredient4 { get; set; } = default!;
    public string strIngredient5 { get; set; } = default!;
    public string strIngredient6 { get; set; } = default!;
    public object strIngredient7 { get; set; } = default!;
    public object strIngredient8 { get; set; } = default!;
    public object strIngredient9 { get; set; } = default!;
    public object strIngredient10 { get; set; } = default!;
    public object strIngredient11 { get; set; } = default!;
    public object strIngredient12 { get; set; } = default!;
    public object strIngredient13 { get; set; } = default!;
    public object strIngredient14 { get; set; } = default!;
    public object strIngredient15 { get; set; } = default!;
    public string strMeasure1 { get; set; } = default!;
    public string strMeasure2 { get; set; } = default!;
    public string strMeasure3 { get; set; } = default!;
    public string strMeasure4 { get; set; } = default!;
    public string strMeasure5 { get; set; } = default!;
    public string strMeasure6 { get; set; } = default!;
    public string strMeasure7 { get; set; } = default!;
    public object strMeasure8 { get; set; } = default!;
    public object strMeasure9 { get; set; } = default!;
    public object strMeasure10 { get; set; } = default!;
    public object strMeasure11 { get; set; } = default!;
    public object strMeasure12 { get; set; } = default!;
    public object strMeasure13 { get; set; } = default!;
    public object strMeasure14 { get; set; } = default!;
    public object strMeasure15 { get; set; } = default!;
    public string strImageSource { get; set; } = default!;
    public object strImageAttribution { get; set; } = default!;
    public string strCreativeCommonsConfirmed { get; set; } = default!;
    public string dateModified { get; set; } = default!;
}