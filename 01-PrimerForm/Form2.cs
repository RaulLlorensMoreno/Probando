using System;
using System.Diagnostics;
using System.Windows.Forms;

namespace _01_PrimerForm
{
    public partial class MiForm2 : Form
    {
        public MiForm2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Owner.Show();
            this.Close();
        }
        //
        // Sección de eventos
        //
        private void MiForm2_Load(object sender, EventArgs e)
        {
            Debug.WriteLine("Form2 Load");
        }

        private void MiForm2_VisibleChanged(object sender, EventArgs e)
        {
            Debug.WriteLine("Form2 Visible Changed");
        }

        private void MiForm2_Activated(object sender, EventArgs e)
        {
            Debug.WriteLine("Form2 Activated");
        }

        private void MiForm2_Shown(object sender, EventArgs e)
        {
            Debug.WriteLine("Form2 Shown");
        }

        private void MiForm2_FormClosing(object sender, FormClosingEventArgs e)
        {
            Debug.WriteLine("Form2 Form Closing");
        }

        private void MiForm2_FormClosed(object sender, FormClosedEventArgs e)
        {
            Debug.WriteLine("Form2 Form Closed");
        }

        private void MiForm2_Deactivate(object sender, EventArgs e)
        {
            Debug.WriteLine("Form2 Deactivated");
        }

        private void MiForm2_Enter(object sender, EventArgs e)
        {
            Debug.WriteLine("Form2 Enter");
        }

        private void MiForm2_Leave(object sender, EventArgs e)
        {
            Debug.WriteLine("Form2 Leave");
        }
    }
}
