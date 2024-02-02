using DeliveryApp.Application.InputModels;
using DeliveryApp.Application.Services;
using Microsoft.AspNetCore.Mvc;

namespace DeliveryApp.API.Controllers;

[ApiController]
[Route("delivery-driver")]
public class DeliveryDriverController : ControllerBase
{
    private readonly IDeliveryDriverService _service;

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
}