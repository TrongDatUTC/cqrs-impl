using CQRSImpl.Data.Entities;

namespace CQRSImpl.Data.MemoryContext;

public class MemoryDbContext
{
    public Dictionary<string, Product> SecuritiesDailies { get; init; } = new Dictionary<string, Product>();
}
