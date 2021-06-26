using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DelegateSample
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Button button = new Button();
            button.Text = "Click Me";
            button.Size = new Size(100, 40);
            button.Location = new Point(100, 100);
            this.Controls.Add(button);
            button.Click += new EventHandler(b_Click);
            button.Click += delegate
            {
                MessageBox.Show("Hello Delegates");
            };


        }

        public void b_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Hello ");
        }
    }
}
