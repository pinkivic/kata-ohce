using Ohce;

var clock = new OsClock();
var greeter = new Greeter(clock);
var greetings = greeter.Greet();
Console.WriteLine(greetings);
var ui = new UI();
ui.MainLoop();
