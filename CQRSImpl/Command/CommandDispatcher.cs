using CQRSImpl.Handler;
using System.Windows.Input;

namespace CQRSImpl.Command;

public class CommandDispatcher
{
    private readonly IServiceProvider _serviceProvider;

    public CommandDispatcher(IServiceProvider serviceProvider)
    {
        _serviceProvider = serviceProvider;
    }

    public void Dispatch<TCommand>(TCommand command) where TCommand : class, ICommand
    {
        var handler = _serviceProvider.GetService<ICommandHandler<TCommand>>();
        if (handler != null)
        {
            handler.Handle(command);
        }
        else
        {
            throw new Exception($"No handler found for {typeof(TCommand).Name}");
        }
    }
}
