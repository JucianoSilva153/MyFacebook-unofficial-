using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FACEBOOK_FREE
{
    public partial class Form1 : Form
    {
        int tempo = 0;
        bool progress = false;
        public Form1()
        {
            InitializeComponent();
        }

        private void webBrowser1_Navigating(object sender, WebBrowserNavigatingEventArgs e)
        {
            progress = false;
            tempo = 0;
            timer1.Start();
            bunifuMetroTextbox1.Visible = true;
            bunifuMetroTextbox1.Text = "Carregando...";
            
            
        }

        private void webBrowser1_Navigated(object sender, WebBrowserNavigatedEventArgs e)
        {
            bunifuMetroTextbox1.Text = "Carregado";
            timer1.Start();
            progress = true;
          
        }

        private void páginaInicialToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void avançarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            webBrowser1.GoForward();
        }

        private void retrocederToolStripMenuItem_Click(object sender, EventArgs e)
        {
            webBrowser1.GoBack();

            
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            
           
            if(progress == true)
            {
                tempo++;
                if (tempo == 5)
                {
                    tempo = 0;
                    bunifuMetroTextbox1.Visible = false;
                }
            }
           

            
        }

        private void webBrowser1_FileDownload(object sender, EventArgs e)
        {
            
        }
    }
}
