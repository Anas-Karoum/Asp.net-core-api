using System.ComponentModel.DataAnnotations;

namespace Infrastructure.Entities;

public class SubscriberEntity
{
    public string Id { get; set; } = Guid.NewGuid().ToString();

    [StringLength(60)]
    public string Email { get; set; } = null!;

    public bool DailyNewsletter { get; set; }
    public bool AdvertisingUpdates { get; set; }
    public bool WeekInReviews { get; set; }
    public bool EventUppdates { get; set; }
    public bool StartupsWeekly { get; set; }
    public bool Podcasts { get; set; }
}
