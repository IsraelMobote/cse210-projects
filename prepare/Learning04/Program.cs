using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Learning04 World!");
        MathAssignment maths = new MathAssignment("Israel mobote","Mathematics","7.3 ","8-19");
        WritingAssignment writing = new WritingAssignment("Israel mobote","European History","The Causes of World War II");
        string text = maths.GetSummary();
        string text2 = maths.GetHomeWorkList();
        string text3 = writing.GetSummary();
        string text4 = writing.GetWritingInformation();
        Console.WriteLine(text);
        Console.WriteLine(text2);
        Console.WriteLine();
        Console.WriteLine(text3);
        Console.WriteLine(text4);
        
    }

}
