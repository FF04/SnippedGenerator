using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
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
            TypeUI = new Control[6]; // 5 bc 5 objects
            types = new List<Types>();


            TypeUI[0] = comboBox_types;
            TypeUI[1] = textBox_defaultValue;
            TypeUI[2] = label5;
            TypeUI[3] = label4;
            TypeUI[4] = textBox_typeToolTip;
            TypeUI[5] = button_inserttype;

            VisibleTypeUI(false);

        }

        public void VisibleTypeUI(bool state)
        {
            foreach (var item in TypeUI)
            {
                item.Visible = state;
            }
        }


        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        public int currentLastItem = 0; // type index des letzten/neuesten hinzugefügten types
        public int currentSelectedItem = 0; // type Index welches gerade selected ist
        private void AddType_Button_Click(object sender, EventArgs e)
        {

            currentLastItem++;
            types.Add(new Types());
            types.Last().Name = $"$type{currentLastItem}$";
            comboBox_types.Items.Add(types.Last().Name);
            currentSelectedItem = currentLastItem-1;
            comboBox_types.SelectedIndex = currentLastItem-1;

            textBox1.Text = textBox1.Text.Insert(currentCursorCodePosition, types.Last().Name);

            VisibleTypeUI(true);
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
            currentSelectedItem = comboBox_types.SelectedIndex;
            textBox_defaultValue.Text = types[currentSelectedItem].DefaultValue;
            textBox_typeToolTip.Text = types[currentSelectedItem].Tooltip;


        }

      

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

         
        }


        public int currentCursorCodePosition=0;
        private void textBox1_Leave(object sender, EventArgs e)
        {
            // jedes mal wenn man etwas anderes macht (also aus der Textbox heraus geht) wird die cursor pos gespeichert, um später möglicherweise an der Stelle etwas einzufügen
            currentCursorCodePosition = textBox1.SelectionStart;
 
        }

        private void button_inserttype_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text.Insert(currentCursorCodePosition, types[currentSelectedItem].Name);

        }



#warning todo: einen extra button machen das der derzeit ausgewählte typoe in den code eingefügt wird und die code textbox umbenennen
    }




    public class Types
    {

        public string Name { get; set; }
        public string DefaultValue { get; set; }
        public string Tooltip { get; set; }



    }

}
