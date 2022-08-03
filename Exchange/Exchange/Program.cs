namespace Exchange
{
    using System;
    using System.Windows.Forms;
    using global::Exchange.LogData;

    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            // Application.Run(new Exchange());
            Application.Run(new MainSelectionMenu());
        }
    }
}
