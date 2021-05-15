using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SnippedGenerator
{
    public partial class Settings : Form
    {

        Form1 form1;
        public Settings(Form1 form)
        {
            form1 = form;
       

            InitializeComponent();

        }

        public string title = "";
        public string Author = "Snipped Generator - FF"; // Default Value

        public void Reload()
        {


            textBox_Author.Text = Author;
            textBox_title.Text = title;
        }


        private void Settings_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Visible = false;

            e.Cancel = true;


            
           
        }

        private void textBox_Author_TextChanged(object sender, EventArgs e)
        {
            Author = textBox_Author.Text;
            
        }

        private void textBox_title_TextChanged(object sender, EventArgs e)
        {
            title = textBox_title.Text;
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}
