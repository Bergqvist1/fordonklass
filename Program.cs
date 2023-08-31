using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;



namespace KlasserObjekt
{


class Program    {
    static void Main(string[] args)
    {
        int menyval =1; 
        fordonLista f1 = new fordonLista();

        while (menyval != 0)
        {
            Console.WriteLine("Fordonsregister");
            Console.WriteLine("================"); 
            Console.WriteLine("1: Registrera ett nytt fordon");
            Console.WriteLine("2: Skriv ut alla fordon i listan");
            Console.WriteLine("0: Avsluta");
            Console.Write("Ange ditt val"); 

            menyval = Convert.ToInt32(Console.ReadLine());
            if(menyval == 1)
            {
                f1.nyFordon();
            }
            else if (menyval == 2)
            {
                f1.skrivUt();
            }
        }
    }
 }

}
 
