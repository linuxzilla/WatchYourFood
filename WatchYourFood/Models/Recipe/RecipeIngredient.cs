namespace WatchYourFood.Models.Recipe;

public class RecipeIngredient : IRecipeIngredient
{
    public double? Amount { get; set; }
    public string? Hint { get; set; }
}