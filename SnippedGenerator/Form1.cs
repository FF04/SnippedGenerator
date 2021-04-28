using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SnippedGenerator
{
    public partial class Form1 : Form
    {
        public const string SnippedTemplatePath = @"..\..\..\Snippet_template.txt";
        public string snippedTemplate;

        public Form1()
        {
            InitializeComponent();



            TypeUI = new Control[6]; // 5 bc 5 objects
            types = new List<Types>();


            TypeUI[0] = comboBox_types;
            TypeUI[1] = textBox_defaultValue;
            TypeUI[2] = label5;
            TypeUI[3] = label4;
            TypeUI[4] = textBox_typeToolTip;
            TypeUI[5] = button_inserttype;

            VisibleTypeUI(false);


            snippedTemplate = File.ReadAllText(SnippedTemplatePath);



        }

        // um die TypeUI zu kontrollieren, wenn es beispielsweiße noch keine types gibt, sollen auch noch keine textfelder angezeigt werden
        public Control[] TypeUI;
        public List<Types> types;

        private void Form1_Load(object sender, EventArgs e)
        {


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
            currentSelectedItem = currentLastItem - 1;
            comboBox_types.SelectedIndex = currentLastItem - 1;

            textBox_Code.Text = textBox_Code.Text.Insert(currentCursorCodePosition, types.Last().Name);

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



        private void textBox_Code_TextChanged(object sender, EventArgs e)
        {


        }


        public int currentCursorCodePosition = 0;
        private void textBox1_Leave(object sender, EventArgs e)
        {
            // jedes mal wenn man etwas anderes macht (also aus der Textbox heraus geht) wird die cursor pos gespeichert, um später möglicherweise an der Stelle etwas einzufügen
            currentCursorCodePosition = textBox_Code.SelectionStart;

        }

        private void button_inserttype_Click(object sender, EventArgs e)
        {
            textBox_Code.Text = textBox_Code.Text.Insert(currentCursorCodePosition, types[currentSelectedItem].Name);

        }

        private void button_Generate_Click(object sender, EventArgs e)
        {




            // all types hier extra einfügen



            if (textBox_Shortcut.Text == null || (textBox_Shortcut.Text.Length < 1))
            {
                MessageBox.Show("Shortcut is empty");
                return;
            }
            if (textBox_Code.Text == null || (textBox_Code.Text.Length < 1))
            {
                MessageBox.Show("Code is empty");
                return;
            }


            string shortCut = textBox_Shortcut.Text;
            string code = textBox_Code.Text;
            string Description = textBox_Description.Text ?? "";

            string typesLiteral = "";
            foreach (var item in types)
            {
                if (!code.Contains(item.Name)) // nur wenn der type im code enthalten ist soll auch die jeweilige beschreibung hinzugefügt werden
                    continue;

                //das ist mit absicht so verschoben
                typesLiteral += $@"				<Literal>
					<ID>{item.Name.Replace("$", "")}</ID>
					<ToolTip>{item.Tooltip}</ToolTip>
					<Default>{item.DefaultValue}</Default>
				</Literal>
";
            }



            if (!code.Contains("$end$")) // $end$ ist immer dort wo der cursor nach dem das snipped eingefügt wurde steht
            {
                code += "$end$";
            }

            // *1*  Title & Shortcut
            // *2* Description
            // *3* <literal>  (nur die types nehmen welche auch im code vorkommen)
            // *4* Code
            snippedTemplate = snippedTemplate.Replace("*1*", shortCut);
            snippedTemplate = snippedTemplate.Replace("*2*", textBox_Description.Text);
            snippedTemplate = snippedTemplate.Replace("*3*", typesLiteral);
            snippedTemplate = snippedTemplate.Replace("*4*", code);





            string savePath = $@"C:\Users\{Environment.UserName}\Downloads\{shortCut}.snippet";


            File.WriteAllText(savePath, snippedTemplate);

            Process.Start("explorer.exe", $@"C:\Users\{Environment.UserName}\Downloads"); // öffnen des ordners

        }



    }




    public class Types
    {

        public string Name { get; set; }
        public string DefaultValue { get; set; }
        public string Tooltip { get; set; }



    }

}
