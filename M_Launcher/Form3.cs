using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace M_Launcher
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void iconButton1_Click(object sender, EventArgs e)
        {
            string textoACopiar = "Este es el texto que se copiará al portapapeles.";
            Clipboard.SetText("MAGICLAND");
        }

        private void iconButton2_Click(object sender, EventArgs e)
        {
            string textoACopiar = "Este es el texto que se copiará al portapapeles.";
            Clipboard.SetText("magicland.playit.plus");
        }
    }
}
