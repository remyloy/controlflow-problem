using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace BlogControlFlowSamples
{
    internal static class Program
    {
        /// <summary>
        ///     The main entry point for the application.
        /// </summary>
        [STAThread]
        private static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            var forms = new List<Form> {new SampleForm1(), new SampleForm2(), new SampleForm3()};
            var i = 0;
            foreach (var form in forms)
            {
                form.Visible = true;
                form.Top = i / 2 * 400;
                form.Left = i % 2 * 600;
                i++;
                form.FormClosed += (sender, args) =>
                {
                    forms.Remove((Form) sender);
                    if (forms.Count == 0)
                        Application.Exit();
                };
            }
            Application.Run();
        }
    }
}