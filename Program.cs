// See https://aka.ms/new-console-template for more information
var destinations = new List<String> { "Paris", "New York", "Tokyo" };
var trending = new Random().Next(0, 3);
Console.WriteLine($"Trending destination: {destinations[trending]}");

