using System.Reflection.Metadata;
using ControleBar.WinApp.Compartilhado;

namespace ControleBar.WinApp
{
    public class Program
    {
        [STAThread]
        static void Main(string[] args)
        {
            ApplicationConfiguration.Initialize();
            Application.Run(new TelaPrincipal());

            ControleBarDbContext dbContext = new ControleBarDbContext();
        }
    }
}