using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PraktikumWeek13
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void labelInput_Click(object sender, EventArgs e)
        {

        }

        private void buttonProses_Click(object sender, EventArgs e)
        {
            if (labelNama.Text == "[EMPTY]")
            {
                labelNama.Text = textBoxNama.Text;
            }
            else if (textBoxNama.Text == "DELETE")
            {
                labelNama.Text = "[EMPTY]";
                labelNama.ForeColor = Color.Empty;
            }
            else if (labelNama.Text != "[EMPTY]")
            {
                if (textBoxNama.Text == "HIDE")
                {
                    labelNama.Visible = false;
                }
                else if (textBoxNama.Text == "SHOWN")
                {
                    labelNama.Visible = true;
                }
                else if (textBoxNama.Text == "BLUE")
                {
                    labelNama.ForeColor = Color.Blue;
                }
                else if (textBoxNama.Text == "RED")
                {
                    labelNama.ForeColor = Color.Red;
                }
                else if (textBoxNama.Text == "GREEN")
                {
                    labelNama.ForeColor = Color.Green;
                }
            }
        }
    }
}
