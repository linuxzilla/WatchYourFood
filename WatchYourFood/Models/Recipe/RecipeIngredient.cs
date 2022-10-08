namespace WatchYourFood.Models.Recipe;

public class RecipeIngredient : IRecipeIngredient
{
    public Ingredient? Ingredient { get; set; }
    public double? Amount { get; set; }
    public string? Hint { get; set; }
}