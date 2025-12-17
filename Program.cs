using static System.Net.Mime.MediaTypeNames;

namespace OOP4
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            /* Стандартний вхід у WinForms програму */
            ApplicationConfiguration.Initialize();

            /* Запуск першої форми з вибором фігури */
            Application.Run(new FormSelect());
        }
    }
}
