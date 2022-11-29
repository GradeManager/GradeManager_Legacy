using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GradeManager
{
    internal class Design
    {
        [DllImport("user32.dll")]
        private static extern IntPtr SendMessage(IntPtr hWnd, int Msg, int wParam, [MarshalAs(UnmanagedType.LPWStr)] string lParam);

        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn
        (
            int nLeftRect,     // x-coordinate of upper-left corner
            int nTopRect,      // y-coordinate of upper-left corner
            int nRightRect,    // x-coordinate of lower-right corner
            int nBottomRect,   // y-coordinate of lower-right corner
            int nWidthEllipse, // width of ellipse
            int nHeightEllipse // height of ellipse
        );
        public static void createRoundedCorners(Form form)
        {
            form.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, form.Width, form.Height, 10, 10));
        }

        public static void createTextboxPreview(string Previewtext, TextBox textbox)
        {
            SendMessage(textbox.Handle, 0x1501, 1, Previewtext);
        }

        public static void changeItemVisibility(Form form, bool visible)
        {
            foreach (Control control in form.Controls)
            {
                control.Visible = visible;
            }

            if (!visible)
                form.BackgroundImage = Properties.Resources.GM_grey;
            else
                form.BackgroundImage = null;
        }
    }
}
