using Gtk;

namespace GtkTest
{
    class Program
    {
        static void Main(string[] args)
        {
            Application.Init();

            using (Window window = new Window("Gtk# Widget viewer"))
            {
                window.DeleteEvent += OnWindowDelete;
                window.SetDefaultSize(800, 600);
                window.ShowAll();

                Application.Run();
            }
        }

        static void OnWindowDelete(object o, DeleteEventArgs args)
        {
            Application.Quit();
            args.RetVal = true;
        }
    }
}
