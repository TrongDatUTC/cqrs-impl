using CQRSImpl.Command;
using Microsoft.AspNetCore.Mvc;

namespace CQRSImpl.Controllers;

[ApiController]
[Route("api/[controller]")]
public class ProductController : ControllerBase
{
    private readonly CommandDispatcher _commandDispatcher;
    public ProductController(CommandDispatcher commandDispatcher)
    {
        _commandDispatcher = commandDispatcher;
    }

    [HttpPost]
    public IActionResult Create(CreateProductCommand command)
    {
        _commandDispatcher.Dispatch(command);
        return Ok();
    }

    [HttpPost("Rate")]
    public IActionResult RateProduct(RateProductCommand command)
    {
        _commandDispatcher.Dispatch(command);
        return Ok();
    }
}
