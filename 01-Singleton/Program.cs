﻿using Singleton;

Console.Title = "Singleton Pattern";

// call the proterty getter twice
var instance1 = Logger.Instance;
var instance2 = Logger.Instance;
 

if (instance1 == instance2 && instance2 == Logger.Instance)
{
    Console.WriteLine("Instances are the same");
}

instance1.Log($"Message from {nameof(instance1)}");
// or
instance1.Log($"Message from {nameof(instance2)}");
//or
Logger.Instance.Log($"Message from {nameof(Logger.Instance)}");

Console.ReadLine();