using System.ComponentModel.DataAnnotations;

namespace Infrastructure.Entities;

public class CoursesEntity
{
    public int Id { get; set; }
    [StringLength(30)]
    public string ImageName { get; set; } = null!;
    [StringLength(100)]
    public string Title { get; set; } = null!;
    [StringLength(100)]
    public string Author { get; set; } = null!;
    [StringLength(10)]
    public string Price { get; set; } = null!;
    [StringLength(10)]
    public string DiscountedPrice { get; set; } = null!;
    [StringLength(10)]
    public string Hours { get; set; } = null!;
    [StringLength(10)]
    public string LikesPercent { get; set; } = null!;
    [StringLength(10)]
    public string Likes { get; set; } = null!;

    public bool IsBestseller {  get; set; } = false;
}
