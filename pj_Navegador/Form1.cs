using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pj_Navegador
{
    public partial class Form1 : Form
    {
        //lista para guardar los favoritos
        List<string> Favorito = new List<string>();

        public Form1()
        {
            InitializeComponent();

            //quitar borde del cuadro de texto
            tf_direccion.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            tf_direccion.Font = new Font("Arial", 10);
            box_favoritos.Font = new Font("Arial", 10);
        }


        //cuando se crea el panel
        private void Form1_Load(object sender, EventArgs e)
        {
            //para que por defecto habra la pagina de google
            webBrowser1.Navigate("https://www.google.com/");
            tf_direccion.Text = "https://www.google.com/";
        }

        private void btn_ir_Click(object sender, EventArgs e)
        {
            //cuando de click
            webBrowser1.Navigate(tf_direccion.Text);
            DeshabilitarElementos();
            toolStripStatusLabel1.Text = "Vavegacion comenzada";
        }

        private void btn_atras_Click(object sender, EventArgs e)
        {
            //para volver atras
            webBrowser1.GoBack();
        }

        private void btn_agregarFavoritos_Click(object sender, EventArgs e)
        {
            //agregar item a la lista
            Favorito.Add(webBrowser1.Url.ToString());
            ActualizarBoxFavorito();
        }

        //agregar el nuevo item o URL al box
        private void ActualizarBoxFavorito()
        {
            //limpia el box y luego lo crea con los datos que estan dentro de la lista
            //Favoritos
            box_favoritos.Items.Clear();
            foreach ( string dirrecion in Favorito)
            {
                box_favoritos.Items.Add(dirrecion);
            }
        }

        //cuando se cambie el item del box
        private void box_favoritos_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            webBrowser1.Navigate(box_favoritos.SelectedItem.ToString());
        }


        //esto se ejecuta cuando se complete WebNavigate
        private void webBrowser1_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {
            btn_atras.Enabled = true;
            btn_ir.Enabled = true;
            tf_direccion.Enabled = true;
            toolStripStatusLabel1.Text = "Vavegacion completada";
        }

        private void DeshabilitarElementos()
        {
            btn_atras.Enabled = false;
            btn_ir.Enabled = false;
            tf_direccion.Enabled = false;
        }

        //esto pasa cuando se preciona alguna tecla con el focos en ese elemento
        private void tf_direccion_KeyPress(object sender, KeyPressEventArgs e)
        {
            //cuando se preciones la tecla enter
            if (e.KeyChar == (char)ConsoleKey.Enter)
            {
                webBrowser1.Navigate(tf_direccion.Text);
            }
        }

        //cuando el progreso del elemento este cambiando
        private void webBrowser1_ProgressChanged(object sender, WebBrowserProgressChangedEventArgs e)
        {
            //creo que esto es para que la barra de porgreso este justamente igual al progreso del elemento de la navegador
            if (e.CurrentProgress > 0 && e.MaximumProgress > 0)
            {
                toolStripProgressBar1.ProgressBar.Value = (int)(e.CurrentProgress * 100 / e.MaximumProgress);
            }
        }


    }
}
