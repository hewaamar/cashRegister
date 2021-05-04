using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading; // allows Thread.Sleep()

namespace cashRegister
{
    public partial class Form1 : Form
    {
        double pencilPrice = 5.00;
        double staplerPrice = 10.00;
        double casePrice = 15.00;

        double pencilQuantity = 0;
        double staplerQuantity = 0;
        double caseQuantity = 0;

        double subtotal = 0;
        double taxRate = 0.13;
        double taxAmount = 0;
        double total;
        double tendered;
        double change;


        public Form1()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void totalButton_Click(object sender, EventArgs e) // TOTAL BUTTON
        {
            // disable 'Calculate Change' button


            // change pencil input to numbers only
            pencilQuantity = Convert.ToDouble(pencilInput.Text);
            // change stapler input to numbers only
            staplerQuantity = Convert.ToDouble(staplerInput.Text);
            // change pencil case input to numbers only
            caseQuantity = Convert.ToDouble(caseInput.Text);

            // calculate subtotal
            subtotal = pencilQuantity * pencilPrice + staplerQuantity * staplerPrice + caseQuantity * casePrice;
            // display subtotal
            subtotalOutput.Text = $" {subtotal.ToString("C")}";

            // calculate tax
            taxAmount = taxRate * subtotal;
            // display tax alone on purchase
            taxOutput.Text = $"{taxAmount.ToString("C")}";

            // calculate total cost (with tax)
            total = subtotal + taxAmount;
            // display total cost
            totalOutput.Text = $"{total.ToString("C")}";

        }

        private void changeButton_Click(object sender, EventArgs e) // CHANGE BUTTON
        {
            // change tendered input to numbers only
            tendered = Convert.ToDouble(tenderedInput.Text);
            // state change value
            change = tendered - total;
            // display change
            changeOutput.Text = $"{change.ToString("C")}";
        }

        private void receipt_Click(object sender, EventArgs e)
        {

        }

        private void printButton_Click(object sender, EventArgs e)
        {
 



            // display receipt title
            receiptOutput.Text = "        Your Receipt";
            // display receipt headers and pause
            receiptOutput.Text += "\n\n Item           Quantity";
            Refresh();
            Thread.Sleep(1000);
            //display pencil price+quantity and pause
            receiptOutput.Text += $" \n\n Pencil         {pencilPrice.ToString("C")}   x {pencilQuantity.ToString("0")}";
            Refresh();
            Thread.Sleep(1000);
            //display stapler price+quantity and pause
            receiptOutput.Text += $" \n Stapler        {staplerPrice.ToString("C")}  x {staplerQuantity.ToString("0")}";
            Refresh();
            Thread.Sleep(1000);
            //display pencil case price+quantity and pause
            receiptOutput.Text += $" \n Pencil Case    {casePrice.ToString("C")}  x {pencilQuantity.ToString("0")}";
            Refresh();
            Thread.Sleep(1000);




        }

        private void item3Label_Click(object sender, EventArgs e)
        {

        }
    }
}
