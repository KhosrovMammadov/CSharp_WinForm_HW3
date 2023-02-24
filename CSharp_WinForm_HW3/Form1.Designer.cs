namespace CSharp_WinForm_HW3
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.TextBoxBig = new System.Windows.Forms.TextBox();
            this.Panel = new System.Windows.Forms.Panel();
            this.ButtonAlignment3 = new System.Windows.Forms.Button();
            this.ButtonAlignment2 = new System.Windows.Forms.Button();
            this.ButtonAlignment1 = new System.Windows.Forms.Button();
            this.ButtonFontStyle3 = new System.Windows.Forms.Button();
            this.ButtonFontStyle2 = new System.Windows.Forms.Button();
            this.ButtonFontStyle1 = new System.Windows.Forms.Button();
            this.LightNight_Button = new System.Windows.Forms.Button();
            this.ComboBoxColor = new System.Windows.Forms.ComboBox();
            this.ComboBoxSize = new System.Windows.Forms.ComboBox();
            this.ComboBoxFont = new System.Windows.Forms.ComboBox();
            this.TextBox_Save = new System.Windows.Forms.TextBox();
            this.TextBox_Load = new System.Windows.Forms.TextBox();
            this.Save_Button = new System.Windows.Forms.Button();
            this.Load_Button = new System.Windows.Forms.Button();
            this.Label_Color = new System.Windows.Forms.Label();
            this.Label_Alignment = new System.Windows.Forms.Label();
            this.Label_FontStyle = new System.Windows.Forms.Label();
            this.Label_Size = new System.Windows.Forms.Label();
            this.Label_Font = new System.Windows.Forms.Label();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.Panel.SuspendLayout();
            this.SuspendLayout();
            // 
            // TextBoxBig
            // 
            this.TextBoxBig.Location = new System.Drawing.Point(0, 116);
            this.TextBoxBig.Multiline = true;
            this.TextBoxBig.Name = "TextBoxBig";
            this.TextBoxBig.Size = new System.Drawing.Size(982, 440);
            this.TextBoxBig.TabIndex = 0;
            // 
            // Panel
            // 
            this.Panel.Controls.Add(this.ButtonAlignment3);
            this.Panel.Controls.Add(this.ButtonAlignment2);
            this.Panel.Controls.Add(this.ButtonAlignment1);
            this.Panel.Controls.Add(this.ButtonFontStyle3);
            this.Panel.Controls.Add(this.ButtonFontStyle2);
            this.Panel.Controls.Add(this.ButtonFontStyle1);
            this.Panel.Controls.Add(this.LightNight_Button);
            this.Panel.Controls.Add(this.ComboBoxColor);
            this.Panel.Controls.Add(this.ComboBoxSize);
            this.Panel.Controls.Add(this.ComboBoxFont);
            this.Panel.Controls.Add(this.TextBox_Save);
            this.Panel.Controls.Add(this.TextBox_Load);
            this.Panel.Controls.Add(this.Save_Button);
            this.Panel.Controls.Add(this.Load_Button);
            this.Panel.Controls.Add(this.Label_Color);
            this.Panel.Controls.Add(this.Label_Alignment);
            this.Panel.Controls.Add(this.Label_FontStyle);
            this.Panel.Controls.Add(this.Label_Size);
            this.Panel.Controls.Add(this.Label_Font);
            this.Panel.Location = new System.Drawing.Point(0, 1);
            this.Panel.Name = "Panel";
            this.Panel.Size = new System.Drawing.Size(982, 109);
            this.Panel.TabIndex = 1;
            // 
            // ButtonAlignment3
            // 
            this.ButtonAlignment3.Location = new System.Drawing.Point(425, 68);
            this.ButtonAlignment3.Name = "ButtonAlignment3";
            this.ButtonAlignment3.Size = new System.Drawing.Size(28, 28);
            this.ButtonAlignment3.TabIndex = 18;
            this.ButtonAlignment3.Text = "R";
            this.ButtonAlignment3.UseVisualStyleBackColor = true;
            this.ButtonAlignment3.Click += new System.EventHandler(this.ButtonAlignment3_Click);
            // 
            // ButtonAlignment2
            // 
            this.ButtonAlignment2.Location = new System.Drawing.Point(391, 68);
            this.ButtonAlignment2.Name = "ButtonAlignment2";
            this.ButtonAlignment2.Size = new System.Drawing.Size(28, 28);
            this.ButtonAlignment2.TabIndex = 17;
            this.ButtonAlignment2.Text = "C";
            this.ButtonAlignment2.UseVisualStyleBackColor = true;
            this.ButtonAlignment2.Click += new System.EventHandler(this.ButtonAlignment2_Click);
            // 
            // ButtonAlignment1
            // 
            this.ButtonAlignment1.Location = new System.Drawing.Point(357, 68);
            this.ButtonAlignment1.Name = "ButtonAlignment1";
            this.ButtonAlignment1.Size = new System.Drawing.Size(28, 28);
            this.ButtonAlignment1.TabIndex = 16;
            this.ButtonAlignment1.Text = "L";
            this.ButtonAlignment1.UseVisualStyleBackColor = true;
            this.ButtonAlignment1.Click += new System.EventHandler(this.ButtonAlignment1_Click);
            // 
            // ButtonFontStyle3
            // 
            this.ButtonFontStyle3.Font = new System.Drawing.Font("Times New Roman", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point);
            this.ButtonFontStyle3.Location = new System.Drawing.Point(305, 67);
            this.ButtonFontStyle3.Name = "ButtonFontStyle3";
            this.ButtonFontStyle3.Size = new System.Drawing.Size(28, 28);
            this.ButtonFontStyle3.TabIndex = 15;
            this.ButtonFontStyle3.Text = "U";
            this.ButtonFontStyle3.UseVisualStyleBackColor = true;
            this.ButtonFontStyle3.Click += new System.EventHandler(this.ButtonFontStyle3_Click);
            // 
            // ButtonFontStyle2
            // 
            this.ButtonFontStyle2.Font = new System.Drawing.Font("Times New Roman", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.ButtonFontStyle2.Location = new System.Drawing.Point(271, 67);
            this.ButtonFontStyle2.Name = "ButtonFontStyle2";
            this.ButtonFontStyle2.Size = new System.Drawing.Size(28, 28);
            this.ButtonFontStyle2.TabIndex = 14;
            this.ButtonFontStyle2.Text = "I";
            this.ButtonFontStyle2.UseVisualStyleBackColor = true;
            this.ButtonFontStyle2.Click += new System.EventHandler(this.ButtonFontStyle2_Click);
            // 
            // ButtonFontStyle1
            // 
            this.ButtonFontStyle1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.ButtonFontStyle1.Location = new System.Drawing.Point(237, 67);
            this.ButtonFontStyle1.Name = "ButtonFontStyle1";
            this.ButtonFontStyle1.Size = new System.Drawing.Size(28, 28);
            this.ButtonFontStyle1.TabIndex = 13;
            this.ButtonFontStyle1.Text = "B";
            this.ButtonFontStyle1.UseVisualStyleBackColor = false;
            this.ButtonFontStyle1.Click += new System.EventHandler(this.ButtonFontStyle1_Click);
            // 
            // LightNight_Button
            // 
            this.LightNight_Button.BackgroundImage = global::CSharp_WinForm_HW3.Properties.Resources.Night;
            this.LightNight_Button.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.LightNight_Button.Location = new System.Drawing.Point(12, 9);
            this.LightNight_Button.Name = "LightNight_Button";
            this.LightNight_Button.Size = new System.Drawing.Size(30, 30);
            this.LightNight_Button.TabIndex = 12;
            this.LightNight_Button.UseVisualStyleBackColor = true;
            this.LightNight_Button.Click += new System.EventHandler(this.LightNightButton_Click);
            // 
            // ComboBoxColor
            // 
            this.ComboBoxColor.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.ComboBoxColor.FormattingEnabled = true;
            this.ComboBoxColor.Location = new System.Drawing.Point(481, 67);
            this.ComboBoxColor.Name = "ComboBoxColor";
            this.ComboBoxColor.Size = new System.Drawing.Size(151, 28);
            this.ComboBoxColor.TabIndex = 11;
            this.ComboBoxColor.Text = "Window";
            this.ComboBoxColor.DrawItem += new System.Windows.Forms.DrawItemEventHandler(this.ComboBoxColor_DrawItem);
            this.ComboBoxColor.Click += new System.EventHandler(this.ComboBoxColor_Click);
            // 
            // ComboBoxSize
            // 
            this.ComboBoxSize.FormattingEnabled = true;
            this.ComboBoxSize.Items.AddRange(new object[] {
            "8",
            "9",
            "10",
            "11",
            "12",
            "14",
            "16",
            "18",
            "20",
            "22",
            "24",
            "26",
            "28",
            "36",
            "48",
            "72"});
            this.ComboBoxSize.Location = new System.Drawing.Point(150, 68);
            this.ComboBoxSize.Name = "ComboBoxSize";
            this.ComboBoxSize.Size = new System.Drawing.Size(60, 28);
            this.ComboBoxSize.TabIndex = 10;
            this.ComboBoxSize.Text = "11";
            this.ComboBoxSize.SelectedIndexChanged += new System.EventHandler(this.ComboBoxSize_SelectedIndexChanged);
            // 
            // ComboBoxFont
            // 
            this.ComboBoxFont.FormattingEnabled = true;
            this.ComboBoxFont.Location = new System.Drawing.Point(12, 68);
            this.ComboBoxFont.Name = "ComboBoxFont";
            this.ComboBoxFont.Size = new System.Drawing.Size(130, 28);
            this.ComboBoxFont.TabIndex = 9;
            this.ComboBoxFont.Text = "Segoe UI";
            this.ComboBoxFont.SelectedIndexChanged += new System.EventHandler(this.ComboBoxFont_SelectedIndexChanged);
            // 
            // TextBox_Save
            // 
            this.TextBox_Save.Location = new System.Drawing.Point(652, 68);
            this.TextBox_Save.Name = "TextBox_Save";
            this.TextBox_Save.Size = new System.Drawing.Size(200, 27);
            this.TextBox_Save.TabIndex = 8;
            this.TextBox_Save.Text = "Tap to enter name and save";
            this.TextBox_Save.TextChanged += new System.EventHandler(this.TextBox_Save_TextChanged);
            // 
            // TextBox_Load
            // 
            this.TextBox_Load.Location = new System.Drawing.Point(652, 16);
            this.TextBox_Load.Name = "TextBox_Load";
            this.TextBox_Load.Size = new System.Drawing.Size(200, 27);
            this.TextBox_Load.TabIndex = 7;
            this.TextBox_Load.Text = "Enter name and load file";
            this.TextBox_Load.TextChanged += new System.EventHandler(this.TextBox_Load_TextChanged);
            // 
            // Save_Button
            // 
            this.Save_Button.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Save_Button.Location = new System.Drawing.Point(858, 68);
            this.Save_Button.Name = "Save_Button";
            this.Save_Button.Size = new System.Drawing.Size(100, 27);
            this.Save_Button.TabIndex = 6;
            this.Save_Button.Text = "Save";
            this.Save_Button.UseVisualStyleBackColor = true;
            this.Save_Button.Click += new System.EventHandler(this.Save_Button_Click);
            // 
            // Load_Button
            // 
            this.Load_Button.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Load_Button.Location = new System.Drawing.Point(858, 16);
            this.Load_Button.Name = "Load_Button";
            this.Load_Button.Size = new System.Drawing.Size(100, 27);
            this.Load_Button.TabIndex = 5;
            this.Load_Button.Text = "Load";
            this.Load_Button.UseVisualStyleBackColor = true;
            this.Load_Button.Click += new System.EventHandler(this.Load_Button_Click);
            // 
            // Label_Color
            // 
            this.Label_Color.AutoSize = true;
            this.Label_Color.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Label_Color.Location = new System.Drawing.Point(526, 20);
            this.Label_Color.Name = "Label_Color";
            this.Label_Color.Size = new System.Drawing.Size(52, 19);
            this.Label_Color.TabIndex = 4;
            this.Label_Color.Text = "Color";
            // 
            // Label_Alignment
            // 
            this.Label_Alignment.AutoSize = true;
            this.Label_Alignment.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Label_Alignment.Location = new System.Drawing.Point(357, 20);
            this.Label_Alignment.Name = "Label_Alignment";
            this.Label_Alignment.Size = new System.Drawing.Size(87, 19);
            this.Label_Alignment.TabIndex = 3;
            this.Label_Alignment.Text = "Alignment";
            // 
            // Label_FontStyle
            // 
            this.Label_FontStyle.AutoSize = true;
            this.Label_FontStyle.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Label_FontStyle.Location = new System.Drawing.Point(240, 20);
            this.Label_FontStyle.Name = "Label_FontStyle";
            this.Label_FontStyle.Size = new System.Drawing.Size(84, 19);
            this.Label_FontStyle.TabIndex = 2;
            this.Label_FontStyle.Text = "FontStyle";
            // 
            // Label_Size
            // 
            this.Label_Size.AutoSize = true;
            this.Label_Size.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Label_Size.Location = new System.Drawing.Point(159, 20);
            this.Label_Size.Name = "Label_Size";
            this.Label_Size.Size = new System.Drawing.Size(42, 19);
            this.Label_Size.TabIndex = 1;
            this.Label_Size.Text = "Size";
            // 
            // Label_Font
            // 
            this.Label_Font.AutoSize = true;
            this.Label_Font.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Label_Font.Location = new System.Drawing.Point(56, 20);
            this.Label_Font.Name = "Label_Font";
            this.Label_Font.Size = new System.Drawing.Size(45, 19);
            this.Label_Font.TabIndex = 0;
            this.Label_Font.Text = "Font";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(982, 553);
            this.Controls.Add(this.Panel);
            this.Controls.Add(this.TextBoxBig);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(1000, 600);
            this.MinimumSize = new System.Drawing.Size(1000, 600);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MarsPad";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Panel.ResumeLayout(false);
            this.Panel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox TextBoxBig;
        private Panel Panel;
        private Label Label_Color;
        private Label Label_Alignment;
        private Label Label_FontStyle;
        private Label Label_Size;
        private Label Label_Font;
        private TextBox TextBox_Save;
        private TextBox TextBox_Load;
        private Button Save_Button;
        private Button Load_Button;
        private ComboBox ComboBoxColor;
        private ComboBox ComboBoxSize;
        private ComboBox ComboBoxFont;
        private Button LightNight_Button;
        private Button ButtonFontStyle1;
        private Button ButtonFontStyle2;
        private Button ButtonFontStyle3;
        private Button ButtonAlignment3;
        private Button ButtonAlignment2;
        private Button ButtonAlignment1;
        private SaveFileDialog saveFileDialog1;
    }
}