using WatchYourFood.Models.Core;

namespace WatchYourFood.Models.Recipe;

public class ReceiptStep : MongoDbDocument, IReceiptStep
{
    public string? Title { get; set; }
    public string? Description { get; set; }
    public int StepNumber { get; set; }
}