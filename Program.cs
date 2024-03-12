using System;
using MQTTnet.Samples.Server;

Console.BackgroundColor = ConsoleColor.White;
Console.ForegroundColor = ConsoleColor.Red;
Console.Title = "Samples - MQTTnet";
Console.WriteLine("----------------------------------------------");
Console.WriteLine("-         Welcome to MQTTnet Server Broker!        -");
Console.WriteLine("----------------------------------------------");
Console.ResetColor();
Console.WriteLine();

Console.WriteLine("Executing the broker...");
Console.WriteLine();

try
{
    await MQTTServer.Start();
}
catch (Exception exception)
{
    Console.WriteLine(exception.ToString());
}

Console.WriteLine();
Console.WriteLine("Press Enter to exit.");
Console.ReadLine();