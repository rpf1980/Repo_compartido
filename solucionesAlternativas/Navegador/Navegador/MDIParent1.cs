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
    public partial class Navegador : Form
    {
        private int childFormNumber = 0;


        static String pagInicio = "https://www.google.es/search?q=";

        public Navegador()
        {
            InitializeComponent();

            //toolStripTextBox1.Text = webBrowser1.Url.ToString();

        }

        private void ShowNewForm(object sender, EventArgs e)
        {

            webBrowser1.ShowPrintPreviewDialog();

        }

        private void OpenFile(object sender, EventArgs e)
        {
            webBrowser1.ShowPageSetupDialog();

        }

        private void SaveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            saveFileDialog.Filter = "Archivos de texto (*.txt)|*.txt|Todos los archivos (*.*)|*.*";
            if (saveFileDialog.ShowDialog(this) == DialogResult.OK)
            {
                string FileName = saveFileDialog.FileName;
            }
        }

        private void ExitToolsStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void CutToolStripMenuItem_Click(object sender, EventArgs e)
        {

            PagInicio pagiInicio = new PagInicio();
            pagiInicio.ShowDialog();
            String nuevaPagina = pagiInicio.nuevaPagIni;

            pagInicio = nuevaPagina;
           
        }

        private void CopyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            webBrowser1.ShowPropertiesDialog();
        }

        private void PasteToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }


        private void CascadeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.Cascade);
        }

        private void TileVerticalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileVertical);
        }

        private void TileHorizontalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileHorizontal);
        }

        private void ArrangeIconsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.ArrangeIcons);
        }

        private void CloseAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Form childForm in MdiChildren)
            {
                childForm.Close();
            }
        }

        private void printToolStripButton_Click(object sender, EventArgs e)
        {
            webBrowser1.Refresh();
        }

        private void statusStrip_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void helpToolStripButton_Click(object sender, EventArgs e)
        {
            webBrowser1.Navigate("https://www.google.es/search?q=" + toolStripTextBox1.Text);

        }

        private void webBrowser1_Navigated(object sender, WebBrowserNavigatedEventArgs e)
        {
            toolStripTextBox1.Text = webBrowser1.Url.ToString();
        }

        private void toolStripTextBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                webBrowser1.Navigate("https://www.google.es/search?q=" + toolStripTextBox1.Text);
            }
        }

        private void saveToolStripButton_Click(object sender, EventArgs e)
        {
            toolStripTextBox1.Text = ("");
            webBrowser1.Navigate("");
        }

        private void printPreviewToolStripButton_Click(object sender, EventArgs e)
        {
            webBrowser1.Navigate(pagInicio);
        }
        private void atrasToolStripButton_Click(object sender, EventArgs e)
        {
            webBrowser1.GoBack();
        }
        private void adelanteToolStripButton_Click(object sender, EventArgs e)
        {
            webBrowser1.GoForward();
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            webBrowser1.Print();
        }

        private void ImprimirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            webBrowser1.Print();
        }

        private void FavoritosToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void Navegador_Load(object sender, EventArgs e)
        {

        }
    }
}
