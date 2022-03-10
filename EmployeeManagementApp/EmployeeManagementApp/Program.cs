namespace EmployeeManagementApp
{
    struct User { 
        public string Name;
        public string Password;
        public int Privilage;

    }

    struct Project {
        public string Name;
        public int Number;
        public string Location;
    }


    internal static  class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        ///      

        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            Application.Run(new LoginForm());
            
        }
    }
}