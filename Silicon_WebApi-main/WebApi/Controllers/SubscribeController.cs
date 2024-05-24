using Infrastructure.Context;
using Infrastructure.Dtos;
using Infrastructure.Entities;
using Infrastructure.Filters;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace WebApi.Controllers;

[Route("api/[controller]")]
[ApiController]
[UseApiKey]
public class SubscribeController(ApiContext context) : ControllerBase
{
    private readonly ApiContext _context = context;

    [HttpPost]
    public async Task<IActionResult> Subscribe(SubscriberDto dto)
    {
        if (ModelState.IsValid)
        {
            if (! await _context.Subscribers.AnyAsync(x => x.Email == dto.Email))
            {
                _context.Subscribers.Add(new SubscriberEntity
                {
                    Email = dto.Email,
                    DailyNewsletter = dto.DailyNewsletter,
                    AdvertisingUpdates = dto.AdvertisingUpdates,
                    WeekInReviews = dto.WeekInReviews,
                    EventUppdates = dto.EventUppdates,
                    StartupsWeekly = dto.StartupsWeekly,
                    Podcasts = dto.Podcasts,
                });

                await _context.SaveChangesAsync();
                return Created();
            }
            else
            {
                return Conflict();
            }
        }

        return BadRequest();


    }

    [HttpDelete]
    public async Task<IActionResult> Unsubscribe(string email)
    {
        if (ModelState.IsValid)
        {
            var subscriberEntity = await _context.Subscribers.FirstOrDefaultAsync(x => x.Email == email);
            if (subscriberEntity == null)
            {
                return NotFound();
            }

            _context.Remove(subscriberEntity);
            await _context.SaveChangesAsync();
            return Ok();
        }
        return BadRequest();
    }
}
