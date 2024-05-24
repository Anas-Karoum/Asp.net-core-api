using Infrastructure.Entities;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Context;

public class ApiContext(DbContextOptions<ApiContext> options) : DbContext(options)
{
    public DbSet<SubscriberEntity> Subscribers { get; set; }
    public DbSet<ContactEntity> Contacts { get; set; }
    public DbSet<CoursesEntity> Courses { get; set; }
}