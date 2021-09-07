using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab_0
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button_calculation_Click(object sender, EventArgs e)
        {
            double length, time, speed;
            if (textBoxLength.Text == "" || textBoxTime.Text == "") MessageBox.Show("Введите значение!");
            else
            {
                length = time = speed = 0;
                try
                {
                    length = Convert.ToDouble(textBoxLength.Text);
                    time = Convert.ToDouble(textBoxTime.Text);
                }
                catch
                {
                    MessageBox.Show("Некорректный ввод данных!");
                }
                
                speed = length / time;
                if (time == 0) speed = 0;
                if (length == 0) MessageBox.Show("Корабль должен иметь длину!");
                if (time < 0 || length < 0)
                {
                    MessageBox.Show("Время и длина не могут быть отрицательными!");
                    speed = 0;
                }
                textBoxSpeed.Text = speed.ToString();
            }
            
        }

        private void button_clear_Click(object sender, EventArgs e)
        {
            textBoxLength.Text = "";
            textBoxTime.Text = "";
            textBoxSpeed.Text = "";
        }

        private void textBoxLength_KeyPress(object sender, KeyPressEventArgs e)//запрет ввода символов, кроме цифр
        {
            char number = e.KeyChar;
            if (!Char.IsDigit(number) && number != 8 && number != 44) // цифры, клавиша BackSpace и запятая
            {
                e.Handled = true;
            }
        }

        private void textBoxTime_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;
            if (!Char.IsDigit(number) && number != 8 && number != 44) 
            {
                e.Handled = true;
            }
        }
    }
}
