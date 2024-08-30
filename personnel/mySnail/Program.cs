namespace mysnail
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("_@_ö");

            int vie = 0;

            Console.CursorVisible = false;

            while (vie != 50)
            {

                Console.Clear();
                Console.Write(50 - vie);
                Console.SetCursorPosition(vie, 0);
                Console.Write("_@_ö");
                vie++;
                Thread.Sleep(100);
            }
            Console.Clear();
            Console.SetCursorPosition(vie, 0);
            Console.Write("___");
        }
    }
}
