using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SnippetGenerator
{

    
    public partial class Form1 : Form
    {
        public const string SnippetTemplatePath = @"..\..\..\Snippet_template.txt";
        public string snippetTemplate;



        public Settings settingsForm;
        public Form1()
        {
            InitializeComponent();

            settingsForm = new Settings(this);

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


        private void button_AddEnd_Click(object sender, EventArgs e)
        {
            try
            {
                textBox_Code.Text = textBox_Code.Text.Replace("$end$", ""); // es soll immer nur ein $end$ geben
                textBox_Code.Text = textBox_Code.Text.Insert(currentCursorCodePosition, "$end$");
            }
            catch (Exception)
            {

           
            }
        }

        private void button_AddSelection_Click(object sender, EventArgs e)
        {
            try
            {
                textBox_Code.Text = textBox_Code.Text.Replace("$selected$", ""); // es soll immer nur ein $selected$ geben
                textBox_Code.Text = textBox_Code.Text.Insert(currentCursorCodePosition, "$selected$");
            }
            catch (Exception)
            {

            
            }
        }


        /// <summary>
        /// This Button opens a settings menu
        /// There it is possible to chnage toe author or Title (...)
        /// Info: How to add snippets
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button_settings_Click(object sender, EventArgs e)
        {
            
            if(settingsForm.title.Length<1) // wenn noch kein titel zugewiesen, wird der derzeitige shortcut genommen
            settingsForm.title = textBox_Shortcut.Text;
            settingsForm.Reload();
            settingsForm.Visible = true;
        }

        private void comboBox_kinds_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button_Generate_Click(object sender, EventArgs e)
        {


            snippetTemplate = File.ReadAllText(SnippetTemplatePath);


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
            string Author = settingsForm.Author;
            string code = textBox_Code.Text;
            string Description = textBox_Description.Text ?? "";
            string title = settingsForm.title;

            if (title.Length < 1) // falls kein Titel extra zugewiesen wurde, ist der Titel = shortcut
                title = shortCut;



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



            if (!code.Contains("$end$")) // $end$ ist immer dort wo der cursor nach dem das snippet eingefügt wurde steht
            {
                code += "$end$";
            }

            // *1*  Title
            // *2* Shortcut
            // *3* Description
            // *4* Author
            // *5* <literal>  (nur die types nehmen welche auch im code vorkommen)
            // *6* Code
            snippetTemplate = snippetTemplate.Replace("*1*", title);
            snippetTemplate = snippetTemplate.Replace("*2*", shortCut);
            snippetTemplate = snippetTemplate.Replace("*3*", Description);
            snippetTemplate = snippetTemplate.Replace("*4*", Author);
            snippetTemplate = snippetTemplate.Replace("*5*", typesLiteral);
            snippetTemplate = snippetTemplate.Replace("*6*", code);





            string savePath = $@"C:\Users\{Environment.UserName}\Downloads\{title}.snippet";

            //überprüfung falls das file schon existiert, wenn ja wird ein file mit dem namen angelegt, welches daneben einen int wert hat (immer höher als der bereits existierende)
            for (int i = 1; i < int.MaxValue; i++)
            {
              

                if (File.Exists(savePath))
                {
                    savePath = $@"C:\Users\{Environment.UserName}\Downloads\{title}({i}).snippet";
                    if(i==int.MaxValue-1)
                    {
                        //chance is dast gleich 0 das man hier je rein kommt, aber trotzdem absicherung
                        MessageBox.Show("es gibt bereits zu viele Files mit dem namen "+title);
                        break;
                    }
                    continue;
                }

            File.WriteAllText(savePath, snippetTemplate);
            Process.Start("explorer.exe", $@"C:\Users\{Environment.UserName}\Downloads"); // öffnen des ordners
                break;
            }







        }

        private void textBox_Shortcut_TextChanged(object sender, EventArgs e)
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
