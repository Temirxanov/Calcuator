using System;

class Calculator
{
    static void Main()
    {
        while (true)
        {
            Console.WriteLine("\nKalkulyator\n");
            Console.WriteLine("1. Qosiw (+)");
            Console.WriteLine("2. aliw (-)");
            Console.WriteLine("3. Kobeytiw(*)");
            Console.WriteLine("4. Boliw (/)");
            Console.WriteLine("5. Sinus (sin)");
            Console.WriteLine("6. Cosinus (cos)");
            Console.WriteLine("7. Tangens (tg)");
            Console.WriteLine("8. Logarifm (log)");
            Console.WriteLine("9. KOren (√)");
            Console.WriteLine("10. Kvadrat (x²)");
            Console.WriteLine("11. Shigiw");

            Console.Write("\nAmeldi tanlan (1-11): ");
            int tanlaw;
            if (!int.TryParse(Console.ReadLine(), out tanlaw) || tanlov < 1 || tanlaw > 11)
            {
                Console.WriteLine("Naduris tanlaw.Qaytadan tanlan");
                continue;
            }

            if (tanlaw == 11)
            {
                Console.WriteLine("Dastur juwmaqlandi!");
                break;
            }

            double san1 = 0, san2 = 0, natiyje = 0;

            if (tanlaw >= 1 && tanlaw <= 4)
            {
                Console.Write("Birinshi sandi kirgizin:: ");
                san1 = Convert.ToDouble(Console.ReadLine());
                Console.Write("Ekinshi sandi kirgizin: ");
                son2 = Convert.ToDouble(Console.ReadLine());
            }
            else
            {
                Console.Write("San kirgiz: ");
                son1 = Convert.ToDouble(Console.ReadLine());
            }

            switch (tanlov)
            {
                case 1: natiyje = san1 + san2; break;
                case 2: natiyje = san1 - san2; break;
                case 3: natiyje = san1 * san2; break;
                case 4: natiyje = san1 / san2; break
                    if (san2 == 0)
                    {
                        Console.WriteLine("0 ge boliw mumkin emes!");
                        continue;
                    }
                    natiyje = san1 / san2;
                    break;
                case 5: natiyje = Math.Sin(san1 * Math.PI / 180); break; 
                case 6: natiyje = Math.Cos(san1 * Math.PI / 180); break;
                case 7: natiyje = Math.Tan(san1 * Math.PI / 180); break;
                case 8: 
                    if (san1 <= 0)
                    {
                        Console.WriteLine("Logarifm tek gana on san bola aladi ");
                        continue;
                    }
                    natiyje = Math.Log(san1);
                    break;
                case 9:
                    if (san1 < 0)
                    {
                        Console.WriteLine("Teris san korennen shiqpaydi!");
                        continue;
                    }
                    natiyje = Math.Sqrt(san1);
                    break;
                case 10: natiyje = Math.Pow(son1, 2); break;
            }

            Console.WriteLine($"Natiyje: {natiyje}");
        }
    }
}
