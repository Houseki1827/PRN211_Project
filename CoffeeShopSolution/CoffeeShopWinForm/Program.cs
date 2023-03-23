using BusinessObject.Models;

namespace CoffeeShopWinForm {
    internal static class Program {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main() {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            CoffeeShopContext context = new CoffeeShopContext();    
            ApplicationConfiguration.Initialize();
            Application.Run(new Form4(context.Users.Find(2)));
        }
    }
}