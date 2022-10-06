namespace WatchYourFood.Models.Recipe;

public interface IRecipeIngredient
{
    public Double? Amount { get; set; }
    public string? Hint { get; set; }
}