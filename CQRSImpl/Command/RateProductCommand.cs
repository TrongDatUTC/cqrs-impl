namespace CQRSImpl.Command;

public class RateProductCommand : ICommand
{
    public int ProductId { get; set; }
    public int Rating { get; set; }
    public int UserId { get; set; }
}
