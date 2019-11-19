using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Navegador
{
    public partial class PagInicio : Form
    {
        public String nuevaPagIni;


        public PagInicio()
        {
            InitializeComponent();
            
        }

        public PagInicio(string nuevaPagIni)
        {
            this.nuevaPagIni = "";
        }



        private void btnGuardar_Click(object sender, EventArgs e)
        {
             nuevaPagIni = richTextBox1nuevoFavorito.Text;
                     
        }

        private void PagInicio_Load(object sender, EventArgs e)
        {

        }
    }
}
