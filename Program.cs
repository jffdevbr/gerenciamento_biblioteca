using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Biblioteca
{
    internal static class Program
    {
        /// <summary>
        /// Ponto de entrada principal para o aplicativo.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new pgLogin());
        }
    }
    public static class UsuarioAtual
    {
        public static string UsuarioLogin { get; set; }
        public static bool Admnistrador { get; set; }
        public static int ID_Usuario { get; set; }
    }
    public static class Parametros 
    {
        public static string StringConexao = "Data Source=DESKTOP-T11K1K8;Initial Catalog=Biblioteca;User ID=DFJL;Password=02061928";
    }
}
