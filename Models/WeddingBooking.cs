using System.ComponentModel.DataAnnotations;

public class WeddingBooking
{
    [Key]
    public int Id { get; set; } // Primary key
    public string Name { get; set; }
    public string Phone { get; set; }
    public DateTime WeddingDate { get; set; }
    public string Location { get; set; }
}
