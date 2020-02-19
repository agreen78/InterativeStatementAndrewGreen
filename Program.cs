using System;

namespace InterativeStatementAndrewGreen
{
    class Program
    {
        static void Main(string[] args)

        {
            //Interation with "for" statement 

            Console.WriteLine("Enter an integer between 2 and 10:");
                      
            int num = Convert.ToInt32(Console.ReadLine());
                                  
            if (num%2 == 1)
                
                for(int i = 1; i < num;i++)
              
            {
                Console.WriteLine("You entered an odd number");     
            }
            else

                for (int i = 1; i < num; i++)
                {
                Console.WriteLine("You entered an even number");
            }

        }

                    
    }
}
