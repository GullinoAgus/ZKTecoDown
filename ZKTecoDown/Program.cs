namespace ZKTecoDown
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        
        static void Main()
        {
            //Block multiple instances from runing
            bool isAnotherInstanceOpen;
            using(var mutex = new Mutex(true, "ZKTecoDownloader", out isAnotherInstanceOpen))
            {
                if (!isAnotherInstanceOpen)
                {
                    MessageBox.Show("El programa ya se esta ejecutando, revise la bandeja de aplicaciones.",
                        "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
            
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
                try
                {
                    ApplicationConfiguration.Initialize();
                    Application.Run(new MachineDL());

                }
                catch (Exception e)
                {
             
                    MessageBox.Show("Error inesperado contacte a un tecnico.\n" +
                        e.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                mutex.ReleaseMutex();
            }

        }
    }
}