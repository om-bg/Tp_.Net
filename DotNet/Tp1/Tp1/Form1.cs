using System;
using System.Windows.Forms;
namespace Tp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            MessageBox.Show("Bonjour", "Load");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
           
                int t = int.Parse(zonea.Text) + int.Parse(zoneb.Text);
                res.Text = t.ToString();
                
         }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {


        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void zonea_TextChanged(object sender, System.EventArgs e)
        {
            
        }

        private void zoneb_TextChanged(object sender, EventArgs e)
        {
            

        }

        private void res_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void remis_Click(object sender, EventArgs e)
        {
            zonea.Text = "";
            zoneb.Text = "";
            res.Text="";
        }

        private void label1_Click_1(object sender, EventArgs e)
        {
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
