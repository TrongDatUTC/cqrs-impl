using CQRSImpl.Command;
using CQRSImpl.Data.Entities;

namespace CQRSImpl.Handler;

public class RateProductCommandHandler : ICommandHandler<RateProductCommand>
{
    public void Handle(RateProductCommand command)
    {
        Console.WriteLine("Handle RateProductCommand!!!");
    }
}
