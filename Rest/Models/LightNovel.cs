using Rest.Models.Enums;

namespace Rest.Models;

public class LightNovel
{
    public int Id { get; set; }
    public string Title { get; set; }
    public string Author { get; set; }
    public string Genre { get; set; }
    public Progress Progress { get; set; }
    public int Rating { get; set; }
    public int PersonalRating { get; set; }
    public string PersonalReview { get; set; }
    public string PersonalPurchaseLink { get; set; }
}