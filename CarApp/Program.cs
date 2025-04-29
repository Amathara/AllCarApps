using System.Collections;
using System.ComponentModel.Design;
using System.Diagnostics.Metrics;

namespace CarApp
{
    internal class Program
    {
        static void Main(string[] args)

        {

            //SCOPE! Kan sættes indenfor eller undenfor main!

            string brand = "Toyota";
            string model = "Corolla";
            int year = 2020;
            char gearType = 'A';
            double kiloStand = 4799;
            double kmPerLiter = 25;

            bool motorTændt = true;



      
                Console.WriteLine("Hej!");

            // Tilføjer et delay før næste linje kommer:
            System.Threading.Thread.Sleep(2300);

            bool running = true;
            while (running)
            { 

            // Menu til at kalde "metoder"
            Console.WriteLine("Hvad vil du nu? \n " +
            "\n 1. Tilføje bildetaljer.\n " +
            "\n 2. Køre en tur!\n " +
            "\n 3. Beregne pris for køretur $ \n " +
            "\n 4. Vide om vi har et plaindrom?\n " +
            "\n 5. Se bildetaljer! \n" +
            "\n 6. Jeg vil se mig ALLE bilers detaljer! \n " +
            "\n 7. Afslut programmet :( ");

            int valg = int.Parse(Console.ReadLine());

                switch (valg)
                {
                    case 1:
                        skrivBilDetaljer();
                        break;
                    case 2:
                        kørEnTur();
                        break;
                    case 3:

                        beregnPris();
                        break;
                    case 4:

                        //harViPalindrom(kiloStand);
                        break;
                    case 5:

                        visBilInfo();
                        break;
                    case 6:
                        
                        showAllCars();
                        break;

                    case 7:
                        Console.WriteLine("Ses!");
                        running = false;
                        break;

                }



            }
        

        // Case 1: Færdig?
        void skrivBilDetaljer()
        {
            //indtasting af biloplysninger:
            Console.WriteLine("Indtast Bilmærke:");
            brand = Console.ReadLine();

            Console.WriteLine("Indtast Model:");
            model = Console.ReadLine();

            Console.WriteLine("Indtast Årgang:");
            year = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Og indtast nu geartype ('A' for automatisk og 'M' for manuel):");

            gearType = Console.ReadLine()[0];

            // Fortæller biloplysninger

            Console.WriteLine($"Okay! Så den bil du tænker på er en {brand} og modellen hedder {model}. \n Den er fra årgang {year} og geartypen er {gearType}");
       

            }

        //Case 2: IKKE FÆRDIG
        void kørEnTur()
        {
            Console.WriteLine("Nå, så du vil køre en tur! \n Modigt ;) ");


                if (motorTændt)
                {
                    Console.WriteLine("Så starter vi motoren! \n Let's gooooo ");
                    Console.WriteLine("Hvor langt vil du køre?");
                    Console.ReadLine();


                }

                else { Console.WriteLine("Øv, så kan du ikke køre"); }



            

        }
            // Case 3: Færdig?
            void beregnPris()
            {
                Console.WriteLine("For at kunne beregne prisen for din tur skal vi først bruge nogle oplysninger:");
                Console.WriteLine("Bruger bilen diesel eller benzin?");
                string fuelType = Console.ReadLine();

                // Definerer fuelPrice
                double fuelPrice = 0;


                if (fuelType.ToLower() == "diesel")
                {
                    fuelPrice = 12.29;
                }
                else if (fuelType.ToLower() == "benzin")
                {
                    fuelPrice = 13.49;
                }
                else
                {
                    fuelPrice = 13.49;
                }





                Console.WriteLine("Hvor mange kilometer kan den køre på literen?");


                double kmPerLiter = double.Parse(Console.ReadLine());

                Console.WriteLine("Hvor mange kilometer har bilen kørt i alt?");
                int kiloStand = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Tak for info :)");
               
                Console.WriteLine("NU kan vi regne!");

                Console.WriteLine("Hvor mange kilometer vil du køre i dag?");
                int distance = Convert.ToInt32(Console.ReadLine());

                double fuelNeeded = distance / kmPerLiter;
                double tripCost = fuelNeeded * fuelPrice;
                // Tre måder at gøre det på!
                Console.WriteLine("Jamen så har du brug for" + " " + fuelNeeded + " " + "liter" + " " + fuelType + " " + "og turen vil koste dig" + " " + tripCost + " " + "kr");
                Console.WriteLine($"Jamen så har du brug for {fuelNeeded} liter {fuelType} og turen vil koste dig {tripCost} kr");
                string carinfo = String.Format("Jamen så har du brug for {0} liter {1} og turen vil koste dig {2} kr.", fuelNeeded, fuelType, tripCost);
                Console.WriteLine(carinfo);
                double newKiloStand = kiloStand + distance;


                Console.WriteLine("Desuden er din bils nye kilometerstand" + " " + newKiloStand + " " + "km");

            }
            // Case 4: IKKE FÆRDIG

            void harViPalindrom() 
            {
                Console.WriteLine("Det vides ikke endnu!");
                // Vi kører et for-loop
               
                /* - IKKE FÆRDIG
                string length = Console.ReadLine();

                for (int i = 0; i = (length/2) - i; i++)

                {
                    Console.WriteLine("Iteration: " + i);
                }
                */
            }
            // Case 5: vis bilinfo
            void visBilInfo()
                {
                int mærkeBredde = 15;
                int modelBredde = 15;
                int kilometerBredde = 15;

                Console.WriteLine("bilMærke".PadRight(mærkeBredde) + "|".PadRight(modelBredde) + "Model:".PadRight(modelBredde) + "|" + "Kilometertal".PadLeft(kilometerBredde));
                Console.WriteLine(new string('-', mærkeBredde + modelBredde + kilometerBredde + 4));
                Console.WriteLine(brand.PadRight(mærkeBredde) + "|".PadRight(modelBredde) + model.PadRight(modelBredde) + "|" + kiloStand.ToString("N0").PadLeft(kilometerBredde));


            }
            //Case 6: nogle andre biler: bruger objekt til at tilføje flere
            void showAllCars()
            {
                // Object!! Adding a specific car manually IN the code, not the console.
                Car car1 = new Car("Toytoa", "Corolla", 2020, 'A', 2609, "Benzin", true, 30);
                Car car2 = new Car("Toytoa", "Corolla", 2020, 'A', 2609, "Benzin", true, 30);
                Car car3 = new Car("Toytoa", "Corolla", 2020, 'A', 2609, "Benzin", true, 30);
                Car car4 = new Car("Toytoa", "Corolla", 2020, 'A', 2609, "Benzin", true, 30);
                Car car5 = new Car("Toytoa", "Corolla", 2020, 'A', 2609, "Benzin", true, 30);




                // For at få info om diverse biler
                Console.WriteLine("Her er alle biler på parkeringspladen:");
                Console.WriteLine(car1.GetCarInfo());
                Console.WriteLine(car2.GetCarInfo());
                Console.WriteLine(car3.GetCarInfo());
                Console.WriteLine(car4.GetCarInfo());
                Console.WriteLine(car5.GetCarInfo());
                Console.WriteLine("---------------------------------");

            }


            Console.ReadLine();
        }
    }
}
