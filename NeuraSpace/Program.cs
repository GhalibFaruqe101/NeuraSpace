namespace NeuraSpace
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        public static database_connection dbConnect = new database_connection();
        [STAThread]
        static void Main()
        {
            dbConnect = new database_connection();
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            Application.Run(new Form1());
        }
    }
}