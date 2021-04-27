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
    public partial class Form1 : Form
    {
        public const string SnippedTemplatePath = @"..\..\..\Snippet_template.txt";
        public Form1()
        {
            InitializeComponent();
        }

        // um die TypeUI zu kontrollieren, wenn es beispielsweiße noch keine types gibt, sollen auch noch keine textfelder angezeigt werden
        public Control[] TypeUI;
        public List<Types> types;

        private void Form1_Load(object sender, EventArgs e)
        {
            TypeUI = new Control[5]; // 5 bc 5 objects
            types = new List<Types>();


            TypeUI[0] = comboBox_types;
            TypeUI[1] = textBox_defaultValue;
            TypeUI[2] = label5;
            TypeUI[3] = label4;
            TypeUI[4] = textBox_typeToolTip;

            EnableTypeUI(false);

        }

        public void EnableTypeUI(bool state)
        {
            foreach (var item in TypeUI)
            {
                item.Enabled = state;
            }
        }


        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        public int currentLastItem = 0;
        public int currentSelectedItem = 0;
        private void AddType_Button_Click(object sender, EventArgs e)
        {

            currentLastItem++;
            types.Add(new Types());
            types.Last().Name = $"$type{currentLastItem}$"; 
            comboBox_types.Items.Add(types.Last().Name);
            currentSelectedItem = currentLastItem;

            EnableTypeUI(true);
        }

        private void textBox_defaultValue_TextChanged(object sender, EventArgs e)
        {
            types[currentSelectedItem].DefaultValue = textBox_defaultValue.Text;
        }

        private void textBox_typeToolTip_TextChanged(object sender, EventArgs e)
        {
            types[currentSelectedItem].Tooltip = textBox_typeToolTip.Text;

        }

        private void comboBox_types_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }

    public class Types
    {
  
        public string Name { get; set; }
        public string DefaultValue { get; set; }
        public string Tooltip { get; set; }



    }

}
