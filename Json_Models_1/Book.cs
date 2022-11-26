public class Book
{
    public int PublishingHouseId { get; set; }
    public string? Title { get; set; }
    public PublishingHouse? PublishingHouse { get; set; }
}
