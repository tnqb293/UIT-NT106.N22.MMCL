namespace Lab1_21521865_Tran_Nguyen_Quoc_Bao
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
            Application.Run(new Form1());
            ApplicationConfiguration.Initialize();
            Application.Run(new Form2());
            ApplicationConfiguration.Initialize();
            Application.Run(new Form3());
            ApplicationConfiguration.Initialize();
            Application.Run(new Form4());
            ApplicationConfiguration.Initialize();
            Application.Run(new Form5());
            ApplicationConfiguration.Initialize();
            Application.Run(new Form6());
        }
    }
}