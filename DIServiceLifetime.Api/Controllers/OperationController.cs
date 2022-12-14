namespace DIServiceLifetime.Api.Controllers;

[Route("api/[controller]")]
[ApiController]
public class OperationController : ControllerBase
{
    private readonly IOperationTransient _otr1;
    private readonly IOperationTransient _otr2;

    private readonly IOperationScoped _osc1;
    private readonly IOperationScoped _osc2;

    private readonly IOperationSingleton _osg1;
    private readonly IOperationSingleton _osg2;

    public OperationController(IOperationTransient otr1, IOperationTransient otr2, IOperationScoped osc1, IOperationScoped osc2, IOperationSingleton osg1, IOperationSingleton osg2)
    {
        _otr1 = otr1;
        _otr2 = otr2;
        _osc1 = osc1;
        _osc2 = osc2;
        _osg1 = osg1;
        _osg2 = osg2;
    }

    [HttpGet]
    public IActionResult Get()
    {
        string result =
            $"Transient 1: {_otr1.OperationId} \n" +
            $"Transient 2: {_otr2.OperationId} \n" +
            $"\n" +
            $"Scoped 1: {_osc1.OperationId} \n" +
            $"Scoped 2: {_osc2.OperationId} \n" +
            $"\n" +
            $"Singleton 1: {_osg1.OperationId} \n" +
            $"Singleton 2: {_osg2.OperationId} \n";

        return Ok(result);
    }
}
