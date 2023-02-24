using CSharp_WinForm_HW3.Properties;
namespace CSharp_WinForm_HW3
{
    public partial class Form1 : Form
    {
        static Color black;
        static Color white;
        static FontStyle fontStyle1;
        static FontStyle fontStyle2;
        static FontStyle fontStyle3;
        static short count1, count2, count3 = 1, count4 = 1, count5 = 1, count6 = 1, size1;
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            foreach (FontFamily font in FontFamily.Families)
            {
                ComboBoxFont.Items.Add(font.Name.ToString());
            }
        }
        private void LightNightButton_Click(object sender, EventArgs e)
        {
            count3++;
            if (count3 % 2 == 1)
            {
                black = Color.White;
                white = Color.Black;
                LightNight_Button.BackgroundImage = Resources.Night;

            }
            else
            {
                black = Color.Black;
                white = Color.White;
                LightNight_Button.BackgroundImage = Resources.Light;

            }
            Panel.BackColor = black;
            TextBoxBig.ForeColor= white;
            TextBoxBig.BackColor= black;
            Label_Font.ForeColor = white;
            Label_Font.BackColor = black;
            Label_Size.ForeColor = white;
            Label_Size.BackColor = black;
            Label_FontStyle.ForeColor = white;
            Label_FontStyle.BackColor = black;
            Label_Alignment.ForeColor = white;
            Label_Alignment.BackColor = black;
            Label_Color.ForeColor = white;
            Label_Color.BackColor = black;
            ComboBoxFont.ForeColor = white;
            ComboBoxFont.BackColor = black;
            ComboBoxSize.ForeColor = white;
            ComboBoxSize.BackColor = black;
            ComboBoxColor.ForeColor = white;
            ComboBoxColor.BackColor = black;
            TextBox_Load.ForeColor = white;
            TextBox_Load.BackColor = black;
            TextBox_Save.ForeColor = white;
            TextBox_Save.BackColor = black;
            Load_Button.ForeColor = white;
            Load_Button.BackColor = black;
            Save_Button.ForeColor = white;
            Save_Button.BackColor= black;
            ButtonFontStyle1.ForeColor = white;
            ButtonFontStyle1.BackColor = black;
            ButtonFontStyle2.ForeColor = white;
            ButtonFontStyle2.BackColor = black;
            ButtonFontStyle3.ForeColor = white;
            ButtonFontStyle3.BackColor = black;
            ButtonAlignment1.ForeColor = white;
            ButtonAlignment1.BackColor = black;
            ButtonAlignment2.ForeColor = white;
            ButtonAlignment2.BackColor = black;
            ButtonAlignment3.ForeColor = white;
            ButtonAlignment3.BackColor = black;
        }


        private void ComboBoxFont_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                TextBoxBig.Font = new Font(ComboBoxFont.Text , TextBoxBig.Font.Size);
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void ComboBoxSize_SelectedIndexChanged(object sender, EventArgs e)
        {
            size1 = Convert.ToInt16(ComboBoxSize.Text);
            TextBoxBig.Font = new Font(TextBoxBig.Font.FontFamily, size1);
        }
        private void ComboBoxColor_Click(object sender, EventArgs e)
        {
            string[] colors = Enum.GetNames(typeof(System.Drawing.KnownColor));
            ComboBoxColor.Items.AddRange(colors);        
        }
        private void ComboBoxColor_DrawItem(object sender, DrawItemEventArgs e)
        {
            try
            {
                e.DrawBackground();
                string? text1 = ComboBoxColor.Items[e.Index].ToString();               
                Brush bord = new SolidBrush(e.ForeColor);
                Color color = Color.FromName(text1);
                Brush pinc = new SolidBrush(color);
                Pen bol = new Pen(e.ForeColor);            
                e.Graphics.DrawRectangle(bol, new Rectangle(e.Bounds.Left + 2, e.Bounds.Top + 2, 50, e.Bounds.Height - 4));
                e.Graphics.FillRectangle(pinc, new Rectangle(e.Bounds.Left + 3, e.Bounds.Top + 3, 48, e.Bounds.Height - 6));
                e.Graphics.DrawString(text1, e.Font, bord, e.Bounds.Left + 65, e.Bounds.Top + 2);
                e.DrawFocusRectangle();
                TextBoxBig.ForeColor = color;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }


        private void ButtonFontStyle1_Click(object sender, EventArgs e)
        {
            count4++;
            if (count4 % 2 == 0)
            {
                fontStyle1 = FontStyle.Bold;
            }
            else if(count4 % 2 == 1)
            {
                fontStyle1 = FontStyle.Regular;
            }
            TextBoxBig.Font = new Font(TextBoxBig.Font.FontFamily, TextBoxBig.Font.Size, fontStyle1);
        }
        private void ButtonFontStyle2_Click(object sender, EventArgs e)
        {
            count5++;
            if (count4 % 2 == 0)
            {
                fontStyle2 = FontStyle.Italic;
            }
            else if(count4 % 2 == 1)
            {
                fontStyle2 = FontStyle.Regular;
            }
            TextBoxBig.Font = new Font(TextBoxBig.Font.FontFamily, TextBoxBig.Font.Size, fontStyle2);
        }
        private void ButtonFontStyle3_Click(object sender, EventArgs e)
        {
            count6++;
            if (count4 % 2 == 0)
            {
                fontStyle3 = FontStyle.Underline;
            }
            else if (count4 % 2 == 1)
            {
                fontStyle3 = FontStyle.Regular;
            }
            TextBoxBig.Font = new Font(TextBoxBig.Font.FontFamily, TextBoxBig.Font.Size, fontStyle3);
        }


        private void ButtonAlignment1_Click(object sender, EventArgs e)
        {
            TextBoxBig.TextAlign = HorizontalAlignment.Left;
        }
        private void ButtonAlignment2_Click(object sender, EventArgs e)
        {
            TextBoxBig.TextAlign = HorizontalAlignment.Center;
        }
        private void ButtonAlignment3_Click(object sender, EventArgs e)
        {
            TextBoxBig.TextAlign = HorizontalAlignment.Right;
        }


        private void TextBox_Load_TextChanged(object sender, EventArgs e)
        {
            count1++;
            if (count1 == 1)
            {
                TextBox_Load.Text = null;
            }
        }
        private void TextBox_Save_TextChanged(object sender, EventArgs e)
        {
            count2++;
            if (count2 == 1)
            {
                TextBox_Save.Text = null;
            }
        }

        private void Load_Button_Click(object sender, EventArgs e)
        {
            try
            {
                saveFileDialog1.FileName = TextBox_Load.Text;
                if (saveFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    string filename = saveFileDialog1.FileName;
                    string text = File.ReadAllText(filename);
                    TextBoxBig.Text = text;
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            TextBox_Load.Text = null;
        }
        private void Save_Button_Click(object sender, EventArgs e)
        {
            try
            {
                saveFileDialog1.FileName = TextBox_Save.Text;
                saveFileDialog1.FileName += ".txt";
                if (saveFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    File.WriteAllText(saveFileDialog1.FileName, TextBoxBig.Text);
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            TextBox_Save.Text = null;
        }
    }
}