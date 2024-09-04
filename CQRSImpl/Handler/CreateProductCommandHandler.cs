using CQRSImpl.Command;

namespace CQRSImpl.Handler;

public class CreateProductCommandHandler : ICommandHandler<CreateProductCommand>
{
    public void Handle(CreateProductCommand command)
    {
        Console.WriteLine("Handle CreateProductCommand!!!");
    }
}
    