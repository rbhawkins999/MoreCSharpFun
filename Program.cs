//for the video with methods
//internal class program
//{
//    private static void main(string[] args)
//    {
//        string name = "";

//        system.console.writeline("please enter your name");
//        name = system.console.readline();

//        system.console.writeline(printname(name));
//    }

//    private static string printname(string n)
//    {
//        string output = "";

//        output = "hello, " + n;

//        return output;
//    }
//}

using MoreCSharpFun;

internal class Program
{
    private static void Main(string[] args)
    {
        PrintStuff ps = new PrintStuff("English");

        string name = "";

        System.Console.WriteLine("Please enter your name");
        name = System.Console.ReadLine();

        ps.PrintName(name);
    }
}