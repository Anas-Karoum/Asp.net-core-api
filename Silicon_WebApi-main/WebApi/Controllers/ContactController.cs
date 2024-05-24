using Infrastructure.Context;
using Infrastructure.Dtos;
using Infrastructure.Filters;
using Microsoft.AspNetCore.Mvc;
using Infrastructure.Entities;

namespace WebApi.Controllers;

[Route("api/[controller]")]
[ApiController]
[UseApiKey]

public class ContactController(ApiContext context) : ControllerBase
{
    private readonly ApiContext _context = context;

    [HttpPost]
    public async Task<IActionResult>ContactForm(ContactDto dto)
    {
        if (!ModelState.IsValid)
        {
            _context.Contacts.Add(new ContactEntity
            {
                FullName = dto.FullName,
                Email = dto.Email,
                Service = dto.Service,
                Message = dto.Message
            });

            await _context.SaveChangesAsync();
            return Created();
        }
        return BadRequest();
    }
}
