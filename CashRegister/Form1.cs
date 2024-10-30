using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using System.Media;

namespace CashRegister
{
    public partial class Form1 : Form
    {
        double applePrice = 1.00;
        double bananaPrice = 2.00;
        double blueberryPrice = 0.50;
        int numOfApples = 0;
        int numOfBananas = 0;
        int numOfBlueberries = 0;
        double applePriceTotal = 0;
        double bananaPriceTotal = 0;
        double blueberryPriceTotal = 0;
        double taxRate = 0.13;
        double subtotal = 0;
        double taxAmount = 0;
        double totalPrice = 0;
        double tenderedMoney = 0;
        double changeAmount = 0;

        public Form1()
        {
            InitializeComponent();

            calculateChangeButton.Visible = false;

            printReceiptButton.Visible = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {

            try
            {
                numOfApples = Convert.ToInt32(hmaInput.Text);

                numOfBananas = Convert.ToInt32(hmbInput.Text);

                numOfBlueberries = Convert.ToInt32(hmbbInput.Text);

                errorLabel.Text = "";
            }

            catch
            {
                errorLabel.Text = "ERROR";
            }

            applePriceTotal = applePrice * numOfApples;

            bananaPriceTotal = bananaPrice * numOfBananas;

            blueberryPriceTotal = blueberryPrice * numOfBlueberries;

            subtotal = applePriceTotal + bananaPriceTotal + blueberryPriceTotal;

            taxAmount = subtotal * taxRate;

            totalPrice = subtotal + taxAmount;

            subTotalOutput.Text = $"{subtotal.ToString("C")}";

            taxOutput.Text = $"{taxAmount.ToString("C")}";

            totalOutput.Text = $"{totalPrice.ToString("C")}";

            calculateChangeButton.Visible = true;
        }

        private void calculateChangeButton_Click(object sender, EventArgs e)
        {
            try
            {
                tenderedMoney = Convert.ToInt32(tenderedInput.Text);

                errorLabel2.Text = "";
            }

            catch
            {
                errorLabel2.Text = "ERROR";
            }
                

            changeAmount = tenderedMoney - totalPrice;

            changeOutput.Text = $"{changeAmount.ToString("C")}";

            printReceiptButton.Visible = true;
        }

        private void printReceiptButton_Click(object sender, EventArgs e)
        {
            SoundPlayer sp = new SoundPlayer(Properties.Resources.printSound);
            sp.Play();

            printReceiptOutput.Text += $"\n{numOfApples} apples                                           {applePriceTotal.ToString("C")}";
            printReceiptOutput.Text += $"\n{numOfBananas} bananas                                        {bananaPriceTotal.ToString("C")}";
            printReceiptOutput.Text += $"\n{numOfBlueberries} blueberries                                     {blueberryPriceTotal.ToString("C")}";
            sp.Play();   
            Refresh();
            Thread.Sleep(2000);
            printReceiptOutput.Text += $"\n";
            printReceiptOutput.Text += $"\n-------------------------------------------------------------------------------------";
            printReceiptOutput.Text += $"\n";
            printReceiptOutput.Text += $"\nSub Total:                                         {subtotal.ToString("C")}";
            printReceiptOutput.Text += $"\nTax:                                                  {taxAmount.ToString("C")}";
            printReceiptOutput.Text += $"\nTotal:                                                {totalPrice.ToString("C")}";
            sp.Play();
            Refresh();
            Thread.Sleep(2000);
            printReceiptOutput.Text += $"\n";
            printReceiptOutput.Text += $"\n--------------------------------------------------------------------------------------";
            printReceiptOutput.Text += $"\n";
            printReceiptOutput.Text += $"\nTendered:                                         {tenderedMoney.ToString("C")}";
            printReceiptOutput.Text += $"\nChange:                                           {changeAmount.ToString("C")}";
            sp.Play();
            Refresh();
            Thread.Sleep(2000);
        }
    }
}
