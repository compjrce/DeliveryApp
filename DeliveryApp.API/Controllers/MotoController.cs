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
    public async Task<IActionResult> Post(MotoInputModel model)
    {
        var id = _service.InsertMoto(model);

        return Ok();
    }
}