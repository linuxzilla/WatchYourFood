namespace WatchYourFood.Models.Recipe;

public interface IReceiptStep
{
    public string Title { get; set; }
    public string Description { get; set; }
    public int StepNumber { get; set; }
}