using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace KlasserObjekt
{
    class fordonLista
    {
        private List<Fordon> FordonLista = new List<Fordon>();

        public void nyFordon()
        {
            string nyttMärke;
            string nyModell;
            int nyHästkraft;
            Console.Write("Ange ett fordons märke: ");
            nyttMärke = Console.ReadLine();
            Console.Write("Ange en fordons modell från märket:");
            nyModell = Console.ReadLine();
            Console.Write("Ange fordonets hästkrafter:")
            nyHästkraft = Convert.ToInt32(Console.ReadLine());

            Fordon nyFordon = new Fordon(nyttMärke, nyHästkraft, nyModell);
            FordonLista.Add(nyFordon);
        }

        public void skrivUt()
        {
            foreach(Fordon element in FordonLista)
            {
                Console.WriteLine(element.Märke);
                Console.WriteLine(element.Modell);
                Console.WriteLine(element.Hästkraft);
            }
        }

      
        
    }
}