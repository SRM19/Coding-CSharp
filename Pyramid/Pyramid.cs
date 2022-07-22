using System;

namespace Pyramid
{
    public class Program
    {
        private static void Pyramid(int height)
        {
            int addStar = 0;
            for(int i = 1; i <= height; i++)
            {
                int spaceCount = height - i;
                int starCount = i + addStar;
                while (spaceCount-- > 0)
                {
                    Console.Write(" ");
                }
                while(starCount-- > 0)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
                //additional stars required for each line
                addStar++;                
            }
        }
        
        public static void Main(string[] args)
        {
            Pyramid(5);
        }
    }
}