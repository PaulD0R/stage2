using _2_5;

ILogger logger = new Logger();
Server server = new Server(logger);

Console.WriteLine(server.GetLog());