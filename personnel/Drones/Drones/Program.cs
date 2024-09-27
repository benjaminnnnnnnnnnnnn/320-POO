namespace Drones
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();

            // Création de la flotte de drones
            List<Drone> fleet= new List<Drone>();
            fleet.Add(new Drone(AirSpace.WIDTH / 2, AirSpace.HEIGHT / 2, "Joe"));

            List<Building> buildings = new List<Building>();
            buildings.Add(new Factory());
            buildings.Add(new Store());




            foreach (Building building in buildings)
            {
                if (building.GetType() == typeof(Store))
                {
                    Store store = (Store)building;
                    store.Show();
                }
                else if (building.GetType() == typeof(Factory))
                {
                    Factory factory = (Factory)building;
                    factory.Show();
                }
                else
                    building.Show();
            }


            try
            {
                // Démarrage
                Application.Run(new AirSpace(fleet, buildings));
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                Console.ReadLine();
            }

        }
    }
}