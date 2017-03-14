using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PA05
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        public NumericUpDown UD
        {
            get { return snoozeTime; }
        }

        private void setBtn_Click(object sender, EventArgs e)
        {
            Class1 MOTO = new Class1();
            MOTO.snooze = (int)snoozeTime.Value;
            this.Close();
        }
    }
}
