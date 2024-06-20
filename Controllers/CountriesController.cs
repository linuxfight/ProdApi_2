using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ProdApi_2.Database;
using ProdApi_2.Models;

namespace ProdApi_2.Controllers;

[ApiController]
[Route("/api/countries")]
public class CountriesController(ApplicationDbContext context) : ControllerBase
{
    [HttpGet]
    public async Task<ActionResult> GetAll([FromQuery] string? region)
    {
        List<Country> countries;
        
        if (string.IsNullOrEmpty(region))
        {
            countries = await context.Countries.ToListAsync();
        }
        else
        {
            var regions = region.Split(",");
            countries = await context.Countries
                .Where(x => regions.Contains(x.Region))
                .ToListAsync();
        }
        
        if (countries.Count == 0)
            return BadRequest(new { Reason = $"Invalid regions: {region}" });
        return Ok(countries.Select(x => new
        {
            name = x.Name,
            alpha2 = x.Alpha2,
            alpha3 = x.Alpha3,
            region = x.Region
        }));
    }
    
    [HttpGet("{countryCode}")]
    public async Task<ActionResult> GetByAlpha2(string countryCode)
    {
        var country = await context.Countries.FirstOrDefaultAsync(x => x.Alpha2 == countryCode);
        if (country == null)
            return NotFound(new { Reason = $"Invalid code: {countryCode}"});
        return Ok(new { name = country.Name, alpha2 = country.Alpha2, alpha3 = country.Alpha3, region = country.Region });
    }
}