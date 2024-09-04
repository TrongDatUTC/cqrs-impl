namespace CQRSImpl.Command;

public class CreateProductCommand : ICommand
{
    public string Name { get; set; }
    public string Description { get; set; }
    public decimal UnitPrice { get; set; }
}