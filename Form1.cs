using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ATM_Talent
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void ATM_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void ATM_LOAD_Click(object sender, EventArgs e)
        {


            ATM.Items.Add(1000);
            ATM.Items.Add(1000);
            ATM.Items.Add(500);
            ATM.Items.Add(500);
            ATM.Items.Add(500);
            ATM.Items.Add(100);
            ATM.Items.Add(100);
            ATM.Items.Add(100);
            ATM.Items.Add(100);
            ATM.Items.Add(100);




        }

   

        private void WITHDRAWAL_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void AMOUNT_TextChanged(object sender, EventArgs e)
        {

        }

        private void ATM_TAKE_Click(object sender, EventArgs e)
        {
            int amount = 0;

            try
            {
                amount = int.Parse(AMOUNT.Text);
            }
            catch
            {

                WITHDRAWAL.Items.Add("Amount error");
                return;

            }

            foreach (var x in ATM.Items)
            {
                int x2 = int.Parse(x.ToString());
                if (amount >= x2)
                {
                    amount -= x2;
                    listBox1.Items.Add(x);
                }

            }

            string a;

            if (amount == 0)
            {
                a = "Varsågod: ";

                foreach (var y in listBox1.Items)
                {
                    a += " " + y.ToString();
                    ATM.Items.Remove(y);
                }
            }
            else
            {
                a = "Operation not possible";
            }

            WITHDRAWAL.Items.Add(a);
            listBox1.Items.Clear();
        }
        private void label2_Click(object sender, EventArgs e)
        {

        }

       





        // 
        //
    }
}
