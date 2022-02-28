using System;
					
public class cmdline
{
	public static void Main(string[] args){
    foreach(var arg in args){
        double x = double.Parse(arg);
        Console.WriteLine($"{x} {Math.Sin(x)} {Math.Cos(x)}");
        }
    }
}