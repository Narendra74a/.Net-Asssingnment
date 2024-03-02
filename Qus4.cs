using System;

class Program
{
    static void Main()
    {
        string originalString = "Hello programmer welcome to the world of programming";
        Console.WriteLine("Before: "+originalString);
        
        
       
        string replacedString = originalString.Replace("programmer", "coder");

        Console.WriteLine("After: "+replacedString);
         Console.WriteLine("Created By Narendra");
        Console.WriteLine("MCA II A ||  Roll.no:57");
    }
}