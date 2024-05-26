using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Consecionario_sistemas_2b
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        //================
        // metodos
        public void FnCmbiarColor()
        {
 
        }

        public void FnCerrarFormulario(object sender, FormClosedEventArgs e)
        {
            FnCmbiarColor();
        }

        public void FnMostraFormulario()
        {
            if (pnl_contenedor.Controls.Count > 0)
            {
                pnl_contenedor.Controls.RemoveAt(0);
            }

            FrmAutos frm = new FrmAutos();
            frm.TopLevel = false;
            frm.Dock = DockStyle.Fill;
            pnl_contenedor.Controls.Add(frm);
            frm.BringToFront();
            frm.FormClosed += FnCerrarFormulario;
        }
        //===============
        private void btn_autos_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
