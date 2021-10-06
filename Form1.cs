using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Forma_for_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            int[] Arr = textBox1.Text.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).Select(n => int.Parse(n.Trim())).ToArray();
            

            var m = Logic.FindAll(Arr);
            MessageBox.Show ($"Первое макс число:" +m.max1+"\n"+"Второе макс число: " + m.max2 +"\n" + "Первое мин число:" + m.min1 +"\n" + "Второе мин число:" + m.min2 +"\n" );
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
    public struct Result
    {
        public int min1;
        public int min2;
        public int max1;
        public int max2;
    }
    public class Logic

    {

        public static Result FindAll(int[] Arr)
        {
            var m = new Result();
            m.min1 = Logic.GetMin1(Arr);
            m.min2 = Logic.GetMin2(Arr);
            m.max1 = Logic.GetMax1(Arr);
            m.max2 = Logic.GetMax2(Arr);
            return m;
        }
        public static int GetMin1(int[] Arr)
        {

            int temp;

            for (int i = 0; i < Arr.Length - 1; i++)
            {

                for (int j = i + 1; j < Arr.Length; j++)
                {
                    if (Arr[i] > Arr[j])
                    {
                        temp = Arr[i];
                        Arr[i] = Arr[j];
                        Arr[j] = temp;
                    }
                }
            }
            int sum_min1 = Arr[0];
            return sum_min1;
        }
        public static int GetMin2(int[] Arr)
        {

            int temp;

            for (int i = 0; i < Arr.Length - 1; i++)
            {

                for (int j = i + 1; j < Arr.Length; j++)
                {
                    if (Arr[i] > Arr[j])
                    {
                        temp = Arr[i];
                        Arr[i] = Arr[j];
                        Arr[j] = temp;
                    }
                }
            }
            int sum_min2 = Arr[1];
            return sum_min2;
        }
        public static int GetMax1(int[] Arr)
        {

            int temp;

            for (int i = 0; i < Arr.Length - 1; i++)
            {

                for (int j = i + 1; j < Arr.Length; j++)
                {
                    if (Arr[i] > Arr[j])
                    {
                        temp = Arr[i];
                        Arr[i] = Arr[j];
                        Arr[j] = temp;
                    }
                }
            }
            int sum_max1 = Arr[Arr.Length - 1];
            return sum_max1;
        }
        public static int GetMax2(int[] Arr)
        {

            int temp;

            for (int i = 0; i < Arr.Length - 1; i++)
            {

                for (int j = i + 1; j < Arr.Length; j++)
                {
                    if (Arr[i] > Arr[j])
                    {
                        temp = Arr[i];
                        Arr[i] = Arr[j];
                        Arr[j] = temp;
                    }
                }
            }
            int sum_max2 = Arr[Arr.Length - 2];
            return sum_max2;
        }
    }
}

