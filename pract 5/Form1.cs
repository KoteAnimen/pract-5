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
            string txt = car.SetParams(car);
            listBox.Items.Add(txt);
        }

        private void ChangeButton_Click(object sender, EventArgs e)
        {
            try
            {
                Car car = new Car(markAuto.Text, (int)countCylinders.Value, (int)powerAuto.Value);
                listBox.Items[listBox.SelectedIndex] = car.SetParams(car);
            }
            catch
            {
                MessageBox.Show("Элемент списка не выбран");
            }
            
        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            try
            {
                listBox.Items.RemoveAt(listBox.SelectedIndex);
            }
            catch
            {
                MessageBox.Show("Элемент списка не выбран");
            }
        }

        private void AddOnlyMark_Click(object sender, EventArgs e)
        {
            Car car = new Car(markAuto.Text, (int)countCylinders.Value, (int)powerAuto.Value);
            listBox.Items.Add(car.SetParams(markAuto.Text));
        }

        private void AddOnlyCylinders_Click(object sender, EventArgs e)
        {
            Car car = new Car(markAuto.Text, (int)countCylinders.Value, (int)powerAuto.Value);
            listBox.Items.Add(car.SetParams((int)countCylinders.Value));
        }

        private void AddMarkPower_Click(object sender, EventArgs e)
        {
            Car car = new Car(markAuto.Text, (int)countCylinders.Value, (int)powerAuto.Value);
            listBox.Items.Add(car.SetParams((int)powerAuto.Value, markAuto.Text));
        }

        private void AddMarkCylinders_Click(object sender, EventArgs e)
        {
            Car car = new Car(markAuto.Text, (int)countCylinders.Value, (int)powerAuto.Value);
            listBox.Items.Add(car.SetParams(markAuto.Text, (int)countCylinders.Value));
        }

        private void AddCylindersPower_Click(object sender, EventArgs e)
        {
            Car car = new Car(markAuto.Text, (int)countCylinders.Value, (int)powerAuto.Value);
            listBox.Items.Add(car.SetParams((int)countCylinders.Value, (int)powerAuto.Value));
        }
    }
}
