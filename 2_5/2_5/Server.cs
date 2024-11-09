namespace _2_5;

public class Server
{
    private ILogger _logger { set; get; }

    public Server(ILogger logger)
    {
        _logger = logger;
    }

    public string GetLog()
    {
        return _logger.Log();
    }
}