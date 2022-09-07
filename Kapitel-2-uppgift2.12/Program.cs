using System;
namespace Uppgift_2_12
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hur många dagar ska du ha bilen?");
            string dagar = Console.ReadLine();
            Console.WriteLine("Hur mågna kilometer ska du åka?");
            string distans = Console.ReadLine();

            float dagar_tal = float.Parse(dagar);   
            float distans_tal = float.Parse(distans);   

            float resa = 300 + distans_tal + (dagar_tal * 500) - 500; 

            Console.WriteLine("Bilen kommer kosta dig " + resa); 
        }
    }
}