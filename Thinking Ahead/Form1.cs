using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Thinking_Ahead
{
    public partial class Form1 : Form
    {
        //declare variables here
        public int buttonCounter = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            buttonCounter++; //imcrements it by one
            MessageBox.Show("Hello World");
            MessageBox.Show( buttonCounter.ToString());
        }
        private void DoubleButtonCounter()
        {
            buttonCounter = buttonCounter * 2;
        }

        private void ButtonDoubleCounter_Click(object sender, EventArgs e)
        {
            DoubleButtonCounter();
            MessageBox.Show(buttonCounter.ToString());
        }
        public int findMax(int[] listInt) //all usable function that will find the maxu=imum of a list of given integers called listInt
        {
            int highest = 0;
            for(int i=0;i<listInt.Length;i++) //for integer
            {
                if (highest < listInt[i])
                {
                    highest = listInt[i];
                }
            }

            return highest; //returns chosen value
        }

        private void Listcounter_Click(object sender, EventArgs e)
        {
            int[] num = new int[] { 78, 34, 56, 11, 13, 2002 };
            int high = findMax(num);
            MessageBox.Show(high.ToString());
        }
    }
}
