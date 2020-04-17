using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Java_to_C___Convertor
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            label1.Visible = false;
            Convert c = new Convert();
            c.a = textBox1.Text.ToString();
            if(c.LexicalError())
            {
                if (c.SyntaxError())
                {
                    textBox2.Text = c.output;
                }
                else
                {
                    label1.Text = c.errorrs;
                    label1.Visible = true;
                }
            }
            else
            {
                label1.Text = c.errorrs;
                label1.Visible = true;
            }

        }
    }
}
