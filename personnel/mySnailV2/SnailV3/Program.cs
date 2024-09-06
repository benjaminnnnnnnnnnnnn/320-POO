using ExSnail;

namespace mysnail
{
    internal class Program
    {
        static void Main(string[] args)
        {

            List<Snail> snails = new List<Snail>();



            for (int i = 0; i < 2; i++)
            {
                snails.Add(new Snail(i));


            }

            Random r = new Random();

            int t = 0;
            int j = 0;
            int winner = 0;
            foreach (Snail snail in snails)
            {


                snail.vie = r.Next(3, 100);
                snail.originalvie = snail.vie;

                if (snail.vie > t)
                {
                    t = snail.vie;
                    winner = j;
                }
                j++;



                snail.name = RandomName();
                Console.WriteLine(snail.name);
                Console.SetCursorPosition(9, snail.y);
                Console.WriteLine(": _@_ö");

            }


            Console.ForegroundColor = ConsoleColor.Green;



            Console.Write("\t\t\t\t\tqui vas ganier ? : ");


            string pari;


            bool ok = true;

            do
            {
                Console.SetCursorPosition(59, 10);
                pari = Console.ReadLine();

                foreach (Snail snail in snails)
                {
                    if (snail.name.ToLower() == pari)
                    {
                        ok = false;
                    }
                }
                Console.SetCursorPosition(59, 10);
                Console.WriteLine("                                            ");

            } while (ok);

            Console.CursorVisible = false;



            while (snails[winner].vie > 0)
            {



                foreach (Snail snail in snails)
                {

                    if (snail.vie > (snail.originalvie / 2))
                        Console.ForegroundColor = ConsoleColor.Green;
                    if (snail.vie <= (snail.originalvie / 2))
                        Console.ForegroundColor = ConsoleColor.Yellow;
                    if (snail.vie <= (snail.originalvie / 4))
                        Console.ForegroundColor = ConsoleColor.Red;

                    Console.SetCursorPosition(0, snail.y);
                    Console.WriteLine(snail.name + "\t :");
                    Console.SetCursorPosition(9, snail.y);
                    Console.WriteLine(":");

                    Console.SetCursorPosition(59, 10);
                    Console.WriteLine(pari);


                    if (snail.vie == 0)
                    {
                        Console.SetCursorPosition(snail.x, snail.y);
                        Console.Write(snail.dead);
                    }
                    else
                    {
                        Console.SetCursorPosition(snail.x, snail.y);
                        Console.Write(snail.alive);

                        snail.move();
                    }




                }
                Thread.Sleep(100);

            }

            if (pari == snails[winner].name.ToLower())
            {
                Console.WriteLine("\n\n\t\t\t\tGood Job, " + snails[winner].name + " won ! with a score of " + snails[winner].originalvie + "!!");
            }
            else
            {
                Console.WriteLine("\n\n\t\t\t\tToo bad, " + snails[winner].name + " won with a score if " + snails[winner].originalvie);
            }




            Console.ForegroundColor = ConsoleColor.White;

            Console.ReadKey();


            static string RandomName()
            {
                Console.Title = "Pendu : randompassword";
                string line;
                int i = 0;

                StreamReader sr = new StreamReader("first-names.txt");
                string[] Names = new string[4946];

                line = sr.ReadLine();


                while (line != null)
                {
                    Names[i++] = line;

                    //Read the next line
                    line = sr.ReadLine();
                }

                Random rnd = new Random();

                string randomName = Names[rnd.Next(4946)];

                return randomName;
            }
        }
    }
}
