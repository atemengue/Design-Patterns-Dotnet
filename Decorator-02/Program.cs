using Decorator;

Console.Title = "Decorator Mail";

// instantiate mail services
var cloudMailService = new CloudMailService();
cloudMailService.sendMail("Hi there");

var onPermiseMailService = new OnPermiseMailService();
onPermiseMailService.sendMail("Hi there");

// add behavoir
var statisticsDecorator = new StatisticsDecorator(cloudMailService);
statisticsDecorator.sendMail($"Hi there via {nameof(statisticsDecorator)} wrapper");

// add behavoir
var messageDatabaseDecorator = new MessageDatabaseDecorator(onPermiseMailService);
messageDatabaseDecorator.sendMail($"Hi there via {nameof(MessageDatabaseDecorator)} wrapper, message 1"); 
messageDatabaseDecorator.sendMail($"Hi there via {nameof(MessageDatabaseDecorator)} wrapper, message 2");

foreach (var message in messageDatabaseDecorator.sentMessages)
{
   Console.WriteLine($"Stored message:\"{message}\"");
}

Console.ReadKey();