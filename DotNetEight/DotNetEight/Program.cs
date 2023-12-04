// See https://aka.ms/new-console-template for more information
using DotNetEight;

Console.WriteLine("Hello, welcome to .NET 8!");

#region Primary Constructor
Console.WriteLine("****** Primary Constructors Start ******");

var primaryConstructorForPropertyInitialization = new PrimaryConstructorForPropertyInitilization(nameof(PrimaryConstructorForPropertyInitilization));
Console.WriteLine($"Primary constructor class name in string: {primaryConstructorForPropertyInitialization.Name}");

var primaryConstructorForBaseConstructor = new PrimaryConstructorForBaseConstructor(nameof(PrimaryConstructorForBaseConstructor));
Console.WriteLine($"Primary constructor class name in string: {primaryConstructorForBaseConstructor.Name}");

var primaryConstructorForInstanceMember = new PrimaryConstructorForInstanceMember(nameof(PrimaryConstructorForInstanceMember));
Console.WriteLine($"Primary constructor class name in string begining: {primaryConstructorForInstanceMember.Name}");
primaryConstructorForInstanceMember.AppendToInstanceName("-Appended");
Console.WriteLine($"Primary constructor class name in string after: {primaryConstructorForInstanceMember.Name}");
Console.WriteLine("****** Primary Constructors End ******");
#endregion
