using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Prime_Number_Gen
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int number1;
        int number2;

        Boolean isPrime(int number)
        {
            if (number == 1) return false;
            if (number == 2) return true;

            for (int i = 2; i <= Math.Ceiling(Math.Sqrt(number)); ++i)
            {
                if (number % i == 0) return false;
            }
            return true;
        }

        private void button_find_Click(object sender, EventArgs e)
        {
            listbox_output.Items.Clear();

            number1 = Convert.ToInt16(textbox_number01.Text);
            number2 = Convert.ToInt16(textbox_number2.Text);

            int amount = number2 - number1;



            for (int i = number1; i <= number2; i++)
            {

                Boolean primecheck = isPrime(i);
                if (primecheck == true)
                {
                    listbox_output.Items.Add(i);
                    Console.WriteLine(i);
                }
                if (primecheck == false)
                {
                }
            }


            
        }

        private void Sort_Click(object sender, EventArgs e)
        {
            listbox_output.Sorted = true;
        }
    }
}
