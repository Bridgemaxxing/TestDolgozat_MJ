using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Rectangle
    {
        public double CalculateArea(double height, double width)
        {
            double eredmeny;
            if (height <0 || width<0)
            {
                throw new ArgumentException("Nem lehet nullánál kisebb érték!");
            }
            else
            {
                eredmeny = height * width;
            }
            return eredmeny;
        }
        static void Main(string[] args)
        {
           
            var plafon = new Rectangle();

            Console.WriteLine("Kérem a szélességet : ");
            
            double height = double.Parse(Console.ReadLine());
            Console.WriteLine("Kérem a magasságot : ");
            double width = double.Parse(Console.ReadLine());
            
            

           





            Console.ReadKey();
        }

        

       
    }
}
