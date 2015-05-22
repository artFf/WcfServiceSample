using System;
using System.Windows.Forms;
using ConvertingTextLibrary.Data;
using ConvertingTextLibrary.Presenters;

namespace WindowsFormsApplication1
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            var convertingTextClientForm = new ConvertingTextClient();
            var convertingTextRepository = new ConvertingTextRepository();
            var convertingTextPresenter = new ConvertingTextPresenter(convertingTextClientForm, convertingTextRepository);

            convertingTextClientForm.StartPosition = FormStartPosition.CenterScreen;
            convertingTextClientForm.FormBorderStyle = FormBorderStyle.FixedSingle;
            convertingTextClientForm.MaximizeBox = false;
            
            Application.Run(convertingTextClientForm);
        }
    }
}
