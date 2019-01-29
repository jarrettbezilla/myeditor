using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace myeditor
{
    public partial class Form1 : Form
    {
        string path;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnSelect_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK) //only opens when you click OK or Open
            {
                path = openFileDialog1.FileName; //opens the file path and puts it in path
                System.IO.StreamReader sr = new System.IO.StreamReader(path);
                richTextBox1.Text = sr.ReadToEnd();
                sr.Close();

                //MessageBox.Show(path); //shows the file path in a box/other form
            }
            
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            //richTextBox1.SaveFile(path, RichTextBoxStreamType.PlainText);
            System.IO.StreamWriter sw = new System.IO.StreamWriter(path);
            sw.WriteLine(richTextBox1.Text);
            sw.Close();
            MessageBox.Show("Save Successful.");
            //this is a change 
        }
    }
}
