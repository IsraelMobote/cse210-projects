// To exceed requirements in the program, I added some lines of code at the beginning of the program to 
// prompt the user to choose between three different scriptures to memorize in stead of just one scripture

using System.IO;
using System.Net;



namespace StreamReadWrite
{
    class Program
    {
        static void Main(string[] args)
        {
            
            int numberToHide = 10;
            string response = "";
           
            
            bool value = true;
            Console.WriteLine("Welcome, please choose a scripture! you would like to memorise");

            Console.WriteLine("1. John 3:16");
            Console.WriteLine("2. Joshua 24:15");
            Console.WriteLine("3. Moses 1:39");

            Console.WriteLine("Please enter the number next to your chosen scripture");
            Console.Write("> ");
            string textEntry = Console.ReadLine();
            int scriptureNo = int.Parse(textEntry);
            Reference Reference = new Reference("John",3,16);
            Scripture Scripture = new Scripture(Reference, "For God so loved the world that he gave his only begotten son, that who so ever believe in him shall not perish but have everlasting life");

            if (scriptureNo == 1)
            {
                Reference Reference1 = new Reference("John",3,16);
                Reference = Reference1;
                Scripture Scripture1 = new Scripture(Reference1, "For God so loved the world that he gave his only begotten son, that who so ever believe in him shall not perish but have everlasting life");
                Scripture = Scripture1;

            }

            if (scriptureNo == 2)
            {
                Reference Reference1 = new Reference("Joshua",24,15);
                Reference = Reference1;
                Scripture Scripture1 = new Scripture(Reference1, "Choose ye this day whom ye will serve as for me and my house, We will serve The LORD");
                Scripture = Scripture1;

;
            }

             if (scriptureNo == 3)
            {
                Reference Reference1 = new Reference("Moses",1,39);
                Reference = Reference1;
                Scripture Scripture1 = new Scripture(Reference1, "For this is my work and my glory to bring to pass the immortality and eternal life of man");
                Scripture = Scripture1;

 
            }

             

            while (value == true)
            {
                if (response != "quit")
                {
                  
                    Scripture.HideRandomWords(numberToHide);
                    Scripture.GetDisplayText();

                    numberToHide = numberToHide - 2;

                    Console.WriteLine("");
                    Console.WriteLine("Press enter to continue or type 'quit' to finish");
                    Console.Write("> ");
                    response = Console.ReadLine();
                    value = Scripture.IsCompletelyHidden();
                    Console.Clear();
                }

                else if (response == "quit")
                {
                    value = false;
                }
            }
         
          

        }

    }
}
