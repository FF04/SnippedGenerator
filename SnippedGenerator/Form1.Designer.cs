
namespace SnippedGenerator
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox_Shortcut = new System.Windows.Forms.TextBox();
            this.textBox_Description = new System.Windows.Forms.TextBox();
            this.textBox_Code = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.AddType_Button = new System.Windows.Forms.Button();
            this.comboBox_types = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox_typeToolTip = new System.Windows.Forms.TextBox();
            this.textBox_defaultValue = new System.Windows.Forms.TextBox();
            this.button_inserttype = new System.Windows.Forms.Button();
            this.button_Generate = new System.Windows.Forms.Button();
            this.button_AddEnd = new System.Windows.Forms.Button();
            this.button_AddSelection = new System.Windows.Forms.Button();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.button_settings = new System.Windows.Forms.Button();
            this.comboBox_kinds = new System.Windows.Forms.ComboBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(41, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Shortcut";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(41, 106);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(184, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "Shortcut Description";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(41, 244);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 25);
            this.label3.TabIndex = 2;
            this.label3.Text = "Code";
            // 
            // textBox_Shortcut
            // 
            this.textBox_Shortcut.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBox_Shortcut.Location = new System.Drawing.Point(41, 56);
            this.textBox_Shortcut.Name = "textBox_Shortcut";
            this.textBox_Shortcut.PlaceholderText = "cr";
            this.textBox_Shortcut.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.textBox_Shortcut.Size = new System.Drawing.Size(147, 29);
            this.textBox_Shortcut.TabIndex = 3;
            // 
            // textBox_Description
            // 
            this.textBox_Description.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBox_Description.Location = new System.Drawing.Point(41, 144);
            this.textBox_Description.Multiline = true;
            this.textBox_Description.Name = "textBox_Description";
            this.textBox_Description.PlaceholderText = "A snipped for Console.ReadLine()";
            this.textBox_Description.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBox_Description.Size = new System.Drawing.Size(369, 77);
            this.textBox_Description.TabIndex = 4;
            this.textBox_Description.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // textBox_Code
            // 
            this.textBox_Code.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBox_Code.Location = new System.Drawing.Point(27, 272);
            this.textBox_Code.Multiline = true;
            this.textBox_Code.Name = "textBox_Code";
            this.textBox_Code.PlaceholderText = "Console.ReadLine();";
            this.textBox_Code.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.textBox_Code.Size = new System.Drawing.Size(1003, 316);
            this.textBox_Code.TabIndex = 5;
            this.textBox_Code.TextChanged += new System.EventHandler(this.textBox_Code_TextChanged);
            this.textBox_Code.Leave += new System.EventHandler(this.textBox1_Leave);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Black;
            this.panel1.Location = new System.Drawing.Point(549, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(2, 264);
            this.panel1.TabIndex = 6;
            // 
            // AddType_Button
            // 
            this.AddType_Button.Location = new System.Drawing.Point(569, 75);
            this.AddType_Button.Name = "AddType_Button";
            this.AddType_Button.Size = new System.Drawing.Size(121, 33);
            this.AddType_Button.TabIndex = 7;
            this.AddType_Button.Text = "Add type";
            this.AddType_Button.UseVisualStyleBackColor = true;
            this.AddType_Button.Click += new System.EventHandler(this.AddType_Button_Click);
            // 
            // comboBox_types
            // 
            this.comboBox_types.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_types.FormattingEnabled = true;
            this.comboBox_types.Location = new System.Drawing.Point(569, 115);
            this.comboBox_types.Name = "comboBox_types";
            this.comboBox_types.Size = new System.Drawing.Size(121, 23);
            this.comboBox_types.TabIndex = 8;
            this.comboBox_types.SelectedIndexChanged += new System.EventHandler(this.comboBox_types_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(758, 156);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 21);
            this.label4.TabIndex = 9;
            this.label4.Text = "ToolTip";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(758, 75);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(101, 21);
            this.label5.TabIndex = 10;
            this.label5.Text = "Default value";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // textBox_typeToolTip
            // 
            this.textBox_typeToolTip.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBox_typeToolTip.Location = new System.Drawing.Point(758, 180);
            this.textBox_typeToolTip.Multiline = true;
            this.textBox_typeToolTip.Name = "textBox_typeToolTip";
            this.textBox_typeToolTip.PlaceholderText = "Any variable";
            this.textBox_typeToolTip.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBox_typeToolTip.Size = new System.Drawing.Size(228, 58);
            this.textBox_typeToolTip.TabIndex = 11;
            this.textBox_typeToolTip.TextChanged += new System.EventHandler(this.textBox_typeToolTip_TextChanged);
            // 
            // textBox_defaultValue
            // 
            this.textBox_defaultValue.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBox_defaultValue.Location = new System.Drawing.Point(758, 103);
            this.textBox_defaultValue.Name = "textBox_defaultValue";
            this.textBox_defaultValue.PlaceholderText = "var";
            this.textBox_defaultValue.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.textBox_defaultValue.Size = new System.Drawing.Size(147, 29);
            this.textBox_defaultValue.TabIndex = 12;
            this.textBox_defaultValue.TextChanged += new System.EventHandler(this.textBox_defaultValue_TextChanged);
            // 
            // button_inserttype
            // 
            this.button_inserttype.Location = new System.Drawing.Point(569, 169);
            this.button_inserttype.Name = "button_inserttype";
            this.button_inserttype.Size = new System.Drawing.Size(105, 52);
            this.button_inserttype.TabIndex = 13;
            this.button_inserttype.Text = "Insert at last cursor position";
            this.button_inserttype.UseVisualStyleBackColor = true;
            this.button_inserttype.Click += new System.EventHandler(this.button_inserttype_Click);
            // 
            // button_Generate
            // 
            this.button_Generate.BackColor = System.Drawing.SystemColors.Control;
            this.button_Generate.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button_Generate.BackgroundImage")));
            this.button_Generate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_Generate.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button_Generate.Image = ((System.Drawing.Image)(resources.GetObject("button_Generate.Image")));
            this.button_Generate.Location = new System.Drawing.Point(1036, 519);
            this.button_Generate.Name = "button_Generate";
            this.button_Generate.Size = new System.Drawing.Size(200, 69);
            this.button_Generate.TabIndex = 14;
            this.button_Generate.Text = "Generate Snipped";
            this.button_Generate.UseVisualStyleBackColor = false;
            this.button_Generate.Click += new System.EventHandler(this.button_Generate_Click);
            // 
            // button_AddEnd
            // 
            this.button_AddEnd.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button_AddEnd.Location = new System.Drawing.Point(1036, 272);
            this.button_AddEnd.Name = "button_AddEnd";
            this.button_AddEnd.Size = new System.Drawing.Size(200, 64);
            this.button_AddEnd.TabIndex = 15;
            this.button_AddEnd.Text = "Add end";
            this.toolTip1.SetToolTip(this.button_AddEnd, "This button is optional.\r\nThis is the position where the cursor will be after ins" +
        "erting the snipped. \r\nThis element ist only one time allowed in the code!\r\n(If n" +
        "ot added it will be att the end)");
            this.button_AddEnd.UseVisualStyleBackColor = true;
            this.button_AddEnd.Click += new System.EventHandler(this.button_AddEnd_Click);
            // 
            // button_AddSelection
            // 
            this.button_AddSelection.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button_AddSelection.Location = new System.Drawing.Point(1036, 342);
            this.button_AddSelection.Name = "button_AddSelection";
            this.button_AddSelection.Size = new System.Drawing.Size(200, 64);
            this.button_AddSelection.TabIndex = 16;
            this.button_AddSelection.Text = "Add selection";
            this.toolTip1.SetToolTip(this.button_AddSelection, "This Button is optional.\r\nIf you add \"selection\" the code will sourrond the selec" +
        "ted Code.\r\n(The selected code will be replaced by the \"selection\")\r\nThis element" +
        " ist only one time allowed in the code!");
            this.button_AddSelection.UseVisualStyleBackColor = true;
            this.button_AddSelection.Click += new System.EventHandler(this.button_AddSelection_Click);
            // 
            // toolTip1
            // 
            this.toolTip1.AutomaticDelay = 100;
            this.toolTip1.ToolTipTitle = "Hint";
            // 
            // button_settings
            // 
            this.button_settings.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button_settings.Location = new System.Drawing.Point(1036, 421);
            this.button_settings.Name = "button_settings";
            this.button_settings.Size = new System.Drawing.Size(200, 64);
            this.button_settings.TabIndex = 17;
            this.button_settings.Text = "Settings";
            this.toolTip1.SetToolTip(this.button_settings, "This Button is optional.\r\nIf you add \"selection\" the code will sourrond the selec" +
        "ted Code.\r\n(The selected code will be replaced by the \"selection\")\r\nThis element" +
        " ist only one time allowed in the code!");
            this.button_settings.UseVisualStyleBackColor = true;
            this.button_settings.Click += new System.EventHandler(this.button_settings_Click);
            // 
            // comboBox_kinds
            // 
            this.comboBox_kinds.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_kinds.FormattingEnabled = true;
            this.comboBox_kinds.Location = new System.Drawing.Point(1071, 56);
            this.comboBox_kinds.Name = "comboBox_kinds";
            this.comboBox_kinds.Size = new System.Drawing.Size(121, 23);
            this.comboBox_kinds.TabIndex = 18;
            this.comboBox_kinds.SelectedIndexChanged += new System.EventHandler(this.comboBox_kinds_SelectedIndexChanged);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Black;
            this.panel2.Location = new System.Drawing.Point(1004, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(2, 264);
            this.panel2.TabIndex = 7;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(1071, 28);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(114, 21);
            this.label6.TabIndex = 19;
            this.label6.Text = "Kind of snippet";
            this.toolTip1.SetToolTip(this.label6, "Optional attribute that specifies the kind of code that the snippet contains.");
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1267, 617);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.comboBox_kinds);
            this.Controls.Add(this.button_settings);
            this.Controls.Add(this.button_AddSelection);
            this.Controls.Add(this.button_AddEnd);
            this.Controls.Add(this.button_Generate);
            this.Controls.Add(this.button_inserttype);
            this.Controls.Add(this.textBox_defaultValue);
            this.Controls.Add(this.textBox_typeToolTip);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.comboBox_types);
            this.Controls.Add(this.AddType_Button);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.textBox_Code);
            this.Controls.Add(this.textBox_Description);
            this.Controls.Add(this.textBox_Shortcut);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Snipped Generator";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox_Shortcut;
        private System.Windows.Forms.TextBox textBox_Description;
        private System.Windows.Forms.TextBox textBox_Code;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button AddType_Button;
        private System.Windows.Forms.ComboBox comboBox_types;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBox_typeToolTip;
        private System.Windows.Forms.TextBox textBox_defaultValue;
        private System.Windows.Forms.Button button_inserttype;
        private System.Windows.Forms.Button button_Generate;
        private System.Windows.Forms.Button button_AddEnd;
        private System.Windows.Forms.Button button_AddSelection;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Button button_settings;
        private System.Windows.Forms.ComboBox comboBox_kinds;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label6;
    }
}

