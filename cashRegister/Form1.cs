using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;  // allows sound effects
using System.Threading; // allows Thread.Sleep() (pauses between printing receipt)

        // HEWAN AMARE
        // ICS3U, MR.T
        // CASH REGISTER SUMMATIVE

namespace cashRegister
{
    public partial class Form1 : Form
    {
        // state item prices
        double pencilPrice = 5.00;
        double staplerPrice = 10.00;
        double casePrice = 15.00;

        // state item quantities
        double pencilQuantity = 0;
        double staplerQuantity = 0;
        double caseQuantity = 0;

        // state transaction details
        double subtotal = 0;
        double taxRate = 0.13;
        double taxAmount = 0;
        double total;
        double tendered = 0;
        double change;

        // create a pause time for receipt printing
        int pause = 600;

        public Form1()
        {
            InitializeComponent();

            // disable all buttons except total button
            changeButton.Enabled = false;
            printButton.Enabled = false;
            newButton.Enabled = false;
        }

        private void totalButton_Click(object sender, EventArgs e) // CLICK TOTAL BUTTON
        {
            try {

                // Extend length of form
                Form1.ActiveForm.Height = 600;

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

                // enable change button
                changeButton.Enabled = true;

                // make the error message invisible
                totalErrorOutput.Visible = false;

            }

            catch {
                totalErrorOutput.Text = "Please input numerical values";
            }
        }

        private void changeButton_Click(object sender, EventArgs e) // CLICK CHANGE BUTTON
        {
            try
            {
                // change tendered input to numbers only
                tendered = Convert.ToDouble(tenderedInput.Text);

                // state change value
                change = tendered - total;

                // display change
                changeOutput.Text = $"{change.ToString("C")}";

                //enable print button
                printButton.Enabled = true;

                // make the error message for money amount invisible
                changeAmountOutput.Visible = false;

                // make the error message for wrong characters invisible
                changeLetterOutput.Visible = false;

                if (tendered < total)
                {
                    // tell user to enter enough money to pay
                    changeAmountOutput.Text += ("Please input a sufficient amount.");

                    // make message visible
                    changeAmountOutput.Visible = true;
                    changeLetterOutput.Visible = false;

                    // disable print button to prevent customer from not paying enough money
                    printButton.Enabled = false;
                }

                else
                {
                    
                }
            }

            catch
            {
                // display error message when numbers are not entered
                changeLetterOutput.Text = "Please enter a numerical value.";

                // make error message for wrong character submission visible
                changeLetterOutput.Visible = true;

                // make error message for insufficient tendered amount invisible
                changeAmountOutput.Visible = false;

            }
        }


        private void printButton_Click(object sender, EventArgs e) // CLICK PRINT BUTTON
        {

            // extend width to show receipt
            Form1.ActiveForm.Width = 700;

            SoundPlayer player = new SoundPlayer(Properties.Resources.printSound);
            player.Play();

            // enable new order button
            newButton.Enabled = true;

            // display receipt title
            receiptOutput.Text = "        Your Receipt";

            // display receipt headers and pause
            receiptOutput.Text += "\n\n Item           Quantity";
            Refresh();
            Thread.Sleep(pause);

            //display pencil price+quantity and pause
            receiptOutput.Text += $" \n\n Pencil         {pencilPrice.ToString("C")}   x {pencilQuantity.ToString("0")}";
            Refresh();
            Thread.Sleep(pause);

            //display stapler price+quantity and pause
            receiptOutput.Text += $" \n Stapler        {staplerPrice.ToString("C")}  x {staplerQuantity.ToString("0")}";
            Refresh();
            Thread.Sleep(pause);

            //display pencil case price+quantity and pause
            receiptOutput.Text += $" \n Pencil Case    {casePrice.ToString("C")}  x {pencilQuantity.ToString("0")}";
            Refresh();
            Thread.Sleep(pause);

            // display subtotal and pause
            receiptOutput.Text += $" \n\n\n Sub-Total        {subtotal.ToString("C")}";
            Refresh();
            Thread.Sleep(pause);

            // display tax and pause
            receiptOutput.Text += $"          Tax              {taxAmount.ToString("C")}";
            Refresh();
            Thread.Sleep(pause);

            // display total
            receiptOutput.Text += $"\n Total            {total.ToString("C")}";
            Refresh();
            Thread.Sleep(pause);

            // display tendered
            receiptOutput.Text += $"\n Tendered         {tendered.ToString("C")}";
            Refresh();
            Thread.Sleep(pause);

            // display change 
            receiptOutput.Text += $"\n\n Change           {change.ToString("C")}";

        }

        private void newButton_Click(object sender, EventArgs e)
        {
            // clear all inputs
            subtotalOutput.Text = "";
            taxOutput.Text = "";
            totalOutput.Text = "";
            changeOutput.Text = "";
            receiptOutput.Text = "";
            pencilInput.Text = "";
            staplerInput.Text = "";
            caseInput.Text = "";
            tenderedInput.Text = "";
            changeAmountOutput.Text = "";
            changeLetterOutput.Text = "";
            
        }
    }
}
