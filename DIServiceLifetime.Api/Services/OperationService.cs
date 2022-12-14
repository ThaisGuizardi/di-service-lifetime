namespace DIServiceLifetime.Api.Services;

public class OperationService : IOperationScoped, IOperationSingleton, IOperationTransient
{
    public OperationService()
    {
        OperationId = Guid.NewGuid().ToString();
    }

    public string OperationId { get; }
}