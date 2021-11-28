using Net6Data;
using Net6Domain;
using Net6DTO;

// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

Net6Domain.UserManager um = new Net6Domain.UserManager();
um.GetUser();
