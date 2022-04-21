// configure console
Console.Title = "Hi, man!";
Console.CursorSize = 50;
// Variables
Random random = new Random();
var outString1 = "Where is Hello World? \nHere:";
// out
foreach(char c in outString1)
{
    Console.ForegroundColor = ConsoleColor.Red;
    Console.Write(c);
    Thread.Sleep(150);
}
var outString2 = @"
 _   _      _ _         _    _            _     _ 
| | | |    | | |       | |  | |          | |   | |
| |_| | ___| | | ___   | |  | | ___  _ __| | __| |
|  _  |/ _ \ | |/ _ \  | |/\| |/ _ \| '__| |/ _` |
| | | |  __/ | | (_) | \  /\  / (_) | |  | | (_| |
\_| |_/\___|_|_|\___/   \/  \/ \___/|_|  |_|\__,_|
";
foreach (char c in outString2)
{
    Console.ForegroundColor = (ConsoleColor)random.Next(1, 16);
    Console.Write(c);
    Thread.Sleep(10);
}
// set default
Console.ForegroundColor = ConsoleColor.White;

Console.ReadKey();

