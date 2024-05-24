using System.ComponentModel.DataAnnotations;

namespace Infrastructure.Dtos;

public class SubscriberDto
{
    [Required]
    public string Email { get; set; } = null!;

    public bool DailyNewsletter { get; set; }
    public bool AdvertisingUpdates { get; set; }
    public bool WeekInReviews { get; set; }
    public bool EventUppdates { get; set; }
    public bool StartupsWeekly { get; set; }
    public bool Podcasts { get; set; }
}
