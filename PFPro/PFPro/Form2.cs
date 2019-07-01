using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FotoFly;

namespace WindowsFormsApp1
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            comboBox1.Items.Add("PLACEHOLDER");
            comboBox1.Items.Add("Put the file");
            comboBox1.Items.Add("Without the Append");
            comboBox1.Items.Add("Yeet");
            comboBox1.Items.Add("Skeet");

        }
    }
}
