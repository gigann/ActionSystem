# ActionSystem
This is a simple action system that uses the command pattern.

Sample Use:

```
using ActionSystem;

public class Test
{
    public class MessageCommand : IAction
    {
        private string _message;
        public MessageCommand(string message)
        {
            _message = message;
        }
        public void Execute()
        {
            Console.WriteLine(_message);
        }
    }

    static void Main(string[] args)
    {
        ActionManager am = new ActionManager();

        am.Order(new MessageCommand("Hello World!"));
        am.Order(new MessageCommand("Goodbye World!"));


        am.Process();
    }
}

```
