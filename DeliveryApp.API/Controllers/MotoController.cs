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
    [ProducesResponseType(StatusCodes.Status201Created)]
    public async Task<IActionResult> InsertMotoAsync(MotoInputModel model)
    {
        var id = await _service.InsertMotoAsync(model);

        return CreatedAtAction("", id);
    }

    [HttpGet]
    public async Task<IActionResult> GetAllAsync()
    {
        var listMoto = await _service.GetAllAsync();

        return Ok(listMoto);
    }
}