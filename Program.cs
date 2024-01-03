// See https://aka.ms/new-console-template for more information
using eventy;

Console.WriteLine("Hello, World!");


var filePath = @"C:\temp\events.txt";
var fileEvent = new FileEventExample(filePath);
fileEvent.FileChanged += FileEvent_FileChanged;

void FileEvent_FileChanged(string content)
{
    Console.WriteLine(content);
}

Console.ReadLine();