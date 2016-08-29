using System;
using System.Diagnostics;
using System.Windows.Forms;
/// <summary>
/// En este ejemplo se puede ver la secuencia de eventos que ocurren en los formularios.
/// El resultado de este ejemplo se puede ver en la Ventana de Resultados, accesible desde el menú Depurar-->Ventanas-->Resultados.
/// </summary>
namespace _01_PrimerForm
{
    public partial class MiForm1 : Form
    {
        public MiForm1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MiForm2 f2 = new MiForm2();
            f2.Owner = this;
            f2.Show();
            this.Hide();
        }
        //
        // Sección de eventos
        //
        private void MiForm1_Load(object sender, EventArgs e)
        {
            Debug.WriteLine("Form1 Load");
        }

        private void MiForm1_VisibleChanged(object sender, EventArgs e)
        {
            Debug.WriteLine("Form1 Visible Changed");
        }

        private void MiForm1_Activated(object sender, EventArgs e)
        {
            Debug.WriteLine("Form1 Activated");
        }

        private void MiForm1_Shown(object sender, EventArgs e)
        {
            Debug.WriteLine("Form1 Shown");
        }

        private void MiForm1_FormClosing(object sender, FormClosingEventArgs e)
        {
            Debug.WriteLine("Form1 Form Closing");
        }

        private void MiForm1_FormClosed(object sender, FormClosedEventArgs e)
        {
            Debug.WriteLine("Form1 Form Closed");
        }

        private void MiForm1_Deactivate(object sender, EventArgs e)
        {
            Debug.WriteLine("Form1 Deactivated");
        }

        private void MiForm1_Enter(object sender, EventArgs e)
        {
            Debug.WriteLine("Form1 Enter");
        }

        private void MiForm1_Leave(object sender, EventArgs e)
        {
            Debug.WriteLine("Form1 Leave");
        }
    }
}
