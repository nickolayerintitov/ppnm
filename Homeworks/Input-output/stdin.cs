using System;
					
public class stdin
{
	public static void Main()
	{
		char[] delimiters = {' ','\t','\n'};
		var options = StringSplitOptions.RemoveEmptyEntries;
		for( string line = Console.ReadLine(); line != null; line = Console.ReadLine() ){
			var words = line.Split(delimiters,options);
			foreach(var word in words){
				double x = double.Parse(word);
				Console.WriteLine($"{x} {Math.Sin(x)} {Math.Cos(x)}");
						}
        }
	}
}