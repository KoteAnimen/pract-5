using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CarLibrary;

namespace pract_5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            Car car = new Car(markAuto.Text, (int)countCylinders.Value, (int)powerAuto.Value);
            listBox.Items.Add("" + car.MarkAuto + " " + car.CountCylinders.ToString() + " " + car.Power.ToString());
        }
    }
}
