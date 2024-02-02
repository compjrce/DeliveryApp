using DeliveryApp.Application.InputModels;
using DeliveryApp.Application.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Routing.Constraints;

namespace DeliveryApp.API.Controllers;

[ApiController]
[Route("delivery-driver")]
public class DeliveryDriverController : ControllerBase
{
    private readonly IDeliveryDriverService _service;
    private readonly string[] _validImageType = { "image/png", "image/bmp" };

    public DeliveryDriverController(IDeliveryDriverService service)
    {
        _service = service;
    }

    [HttpPost]
    public async Task<IActionResult> InsertAsync(DeliveryDriverInputModel model)
    {
        var driverLicenseNumber = await _service.InsertAsync(model);

        return CreatedAtAction(null, null);
    }

    [HttpPut("{driverLicenseNumber}")]
    public async Task<IActionResult> UpdateDriverLicenseImageAsync(IFormFile file, string driverLicenseNumber)
    {
        if (file == null || file.Length == 0)
            return BadRequest("Arquivo vazio");

        if (!_validImageType.Any(x => x.Equals(file.ContentType)))
            return BadRequest("Tipo inválido");

        var extension = "." + file.FileName.Split('.')[file.FileName.Split('.').Length - 1];
        var fileName = "DriverLicenseNumber_" + driverLicenseNumber + extension;
        var filePath = Path.Combine(Directory.GetCurrentDirectory(), "Upload//Files", fileName);

        await _service.UpdateDriverLicenseImageAsync(driverLicenseNumber, filePath);

        using (var stream = new FileStream(filePath, FileMode.Create))
        {
            await file.CopyToAsync(stream);
        }

        return Ok();
    }


}