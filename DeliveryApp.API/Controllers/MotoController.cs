using DeliveryApp.Application.InputModels;
using DeliveryApp.Application.Services;
using Microsoft.AspNetCore.Mvc;

namespace DeliveryApp.API.Controllers;

[ApiController]
[Route("delivery-app")]
public class MotoController : ControllerBase
{
    private readonly IMotoService _service;

    public MotoController(IMotoService service)
    {
        _service = service;
    }

    [HttpPost]
    public async Task<IActionResult> InsertMotoAsync(MotoInputModel model)
    {
        var licensePlate = await _service.InsertMotoAsync(model);

        return CreatedAtAction(nameof(GetByLicensePlateAsync), new { licensePlate }, model);
    }

    [HttpGet]
    public async Task<IActionResult> GetAllAsync()
    {
        var listMoto = await _service.GetAllAsync();

        return Ok(listMoto);
    }

    [HttpGet("{licensePlate}")]
    public async Task<IActionResult> GetByLicensePlateAsync(string licensePlate)
    {
        var moto = await _service.GetByLicensePlateAsync(licensePlate);

        if (moto == null)
            return NotFound();

        return Ok(moto);
    }
}