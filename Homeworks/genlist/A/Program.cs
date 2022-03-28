// Online C# Editor for free
// Write, Edit and Run your C# code using C# Online Compiler
    
using System;

public class genlist<T>{
	public T[] data;
	public int size {get{return data.Length;}} // property
	public genlist(){ data = new T[0]; }
	public void push(T item){ /* add item to the list */
		T[] newdata = new T[size+1];
		for(int i=0;i<size;i++)newdata[i]=data[i];
		newdata[size]=item;
		data=newdata;
	}
}
public class HelloWorld
{
    public static void Main(string[] args)
    {
        string infile=null,outfile=null;
        foreach(var arg in args){
                var words=arg.Split(':');
                if(words[0]=="-input")infile=words[1];
                else if(words[0]=="-output")outfile=words[1];
                else { Console.Error.WriteLine("wrong argument"); return; }
                }
        var instream =new System.IO.StreamReader(infile);
        var outstream=new System.IO.StreamWriter(outfile);
        var list = new genlist<double[]>();
        char[] delimiters = {' ','\t'};
        var options = StringSplitOptions.RemoveEmptyEntries;
        for(string line = instream.ReadLine(); line!=null; line = instream.ReadLine()){
            var words = line.Split(delimiters,options);
            int n = words.Length;
            var numbers = new double[n];
            for(int i=0;i<n;i++) numbers[i] = double.Parse(words[i]);
            list.push(numbers);
                }
        for(int i=0;i<list.size;i++){
            var numbers = list.data[i];
            foreach(var number in numbers) {
                outstream.Write($"{number:e} ");
            }
            outstream.WriteLine();
            }
        instream.Close();
        outstream.Close();
    }
}