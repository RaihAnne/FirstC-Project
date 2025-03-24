// See https://aka.ms/new-console-template for more information
using System;
using System.Runtime.CompilerServices;
using RyanSpace;


Console.WriteLine("Hello lets try adding stuff!\n");
int a=0;
int b=0;

Console.WriteLine("please input addendA!\n");
if(GetIntConsole.TryGetIntFromConsole(out a) == false){
    Console.WriteLine("Something went wrong!\n");
    return;
}


Console.WriteLine("please input addendB!\n");
if(GetIntConsole.TryGetIntFromConsole(out b) == false){
    Console.WriteLine("Something went wrong!\n");
    return;
}


Adder adder = new Adder(a,b);
Console.WriteLine($"done adding. {adder.AddendA} + {adder.AddendB} = {adder.Result}");
Console.WriteLine($"Thank you!\n\n");


