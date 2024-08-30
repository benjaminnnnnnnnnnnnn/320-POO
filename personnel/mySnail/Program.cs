using ExSnail;

namespace mysnail
{
    internal class Program
    {
        static void Main(string[] args)
        {

            List<Snail> snails = new List<Snail>();


            for (int i = 0; i < 10; i++)
            {
                snails.Add(new Snail(i));


            }



            Console.CursorVisible = false;
            Console.ForegroundColor = ConsoleColor.Green;
            while (snails[0].vie > 0)
            {

                Console.Clear();

                foreach (Snail snail in snails)
                {
                    if (snail.vie == 30)
                        Console.ForegroundColor = ConsoleColor.Yellow;
                    if (snail.vie == 10)
                        Console.ForegroundColor = ConsoleColor.Red;


                    Console.SetCursorPosition(0, 0);
                    Console.Write(snail.vie);


                    Console.SetCursorPosition(snail.x, snail.y);
                    Console.Write(snail.alive);


                    snail.move();


                }
                Thread.Sleep(40);

            }

            Console.Clear();
            foreach (Snail snail in snails)
            {
                Console.SetCursorPosition(snail.x, snail.y);
                Console.Write(snail.dead);




            }

            Console.ForegroundColor = ConsoleColor.White;
        }
    }
}
