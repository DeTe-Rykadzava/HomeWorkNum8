namespace HomeWorkNum8.Core;

public static class ConsoleReaderManager
{
    private static readonly ConsoleReader _consoleReader = new ConsoleReader();

    private static object _userInput;
    
    public static async Task<object> GetUserInput(Type requiredType, string message)
    {
        
        
        Console.WriteLine(message);
        
        
    }
    
    

    private class ConsoleReader
    {
        public Action<object> SuccessReadEvent;

        public Action FailReadEvent;

        public async Task GetUserInput()
        {
            var 
        }

    }
}
