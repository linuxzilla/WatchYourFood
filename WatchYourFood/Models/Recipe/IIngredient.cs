namespace WatchYourFood.Models.Recipe;

public interface IIngredient
{
    public string Name { get; set; }
    public string? Description { get; set; }
}