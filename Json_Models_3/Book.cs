using System.Runtime.Serialization;

public class Book
{
    public int PublishingHouseId { get; set; }
    public string? Title { get; set; }
    public PublishingHouse? PublishingHouse { get; set; }

    [OnSerializing]
    private void OnSerializing(StreamingContext context)
    {
        this.Title = this.PublishingHouse!.Name;
    }
}
