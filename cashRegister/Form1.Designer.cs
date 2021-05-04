
namespace cashRegister
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.item1Label = new System.Windows.Forms.Label();
            this.item2Label = new System.Windows.Forms.Label();
            this.item3Label = new System.Windows.Forms.Label();
            this.pencilInput = new System.Windows.Forms.TextBox();
            this.caseInput = new System.Windows.Forms.TextBox();
            this.staplerInput = new System.Windows.Forms.TextBox();
            this.totalButton = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.subtotalLabel = new System.Windows.Forms.Label();
            this.taxLabel = new System.Windows.Forms.Label();
            this.totalLabel = new System.Windows.Forms.Label();
            this.tenderedLabel = new System.Windows.Forms.Label();
            this.taxOutput = new System.Windows.Forms.Label();
            this.totalOutput = new System.Windows.Forms.Label();
            this.tenderedInput = new System.Windows.Forms.TextBox();
            this.changeButton = new System.Windows.Forms.Button();
            this.subtotalOutput = new System.Windows.Forms.Label();
            this.changeLabel = new System.Windows.Forms.Label();
            this.changeOutput = new System.Windows.Forms.Label();
            this.printButton = new System.Windows.Forms.Button();
            this.receiptOutput = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(145, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(110, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Cash Register";
            // 
            // item1Label
            // 
            this.item1Label.AutoSize = true;
            this.item1Label.Location = new System.Drawing.Point(56, 72);
            this.item1Label.Name = "item1Label";
            this.item1Label.Size = new System.Drawing.Size(54, 20);
            this.item1Label.TabIndex = 1;
            this.item1Label.Text = "Item 1";
            // 
            // item2Label
            // 
            this.item2Label.AutoSize = true;
            this.item2Label.Location = new System.Drawing.Point(56, 135);
            this.item2Label.Name = "item2Label";
            this.item2Label.Size = new System.Drawing.Size(54, 20);
            this.item2Label.TabIndex = 2;
            this.item2Label.Text = "Item 2";
            // 
            // item3Label
            // 
            this.item3Label.AutoSize = true;
            this.item3Label.Location = new System.Drawing.Point(56, 195);
            this.item3Label.Name = "item3Label";
            this.item3Label.Size = new System.Drawing.Size(54, 20);
            this.item3Label.TabIndex = 3;
            this.item3Label.Text = "Item 3";
            this.item3Label.Click += new System.EventHandler(this.item3Label_Click);
            // 
            // pencilInput
            // 
            this.pencilInput.Location = new System.Drawing.Point(149, 72);
            this.pencilInput.Name = "pencilInput";
            this.pencilInput.Size = new System.Drawing.Size(195, 26);
            this.pencilInput.TabIndex = 4;
            // 
            // caseInput
            // 
            this.caseInput.Location = new System.Drawing.Point(149, 195);
            this.caseInput.Name = "caseInput";
            this.caseInput.Size = new System.Drawing.Size(195, 26);
            this.caseInput.TabIndex = 5;
            // 
            // staplerInput
            // 
            this.staplerInput.Location = new System.Drawing.Point(149, 129);
            this.staplerInput.Name = "staplerInput";
            this.staplerInput.Size = new System.Drawing.Size(195, 26);
            this.staplerInput.TabIndex = 6;
            // 
            // totalButton
            // 
            this.totalButton.Location = new System.Drawing.Point(121, 242);
            this.totalButton.Name = "totalButton";
            this.totalButton.Size = new System.Drawing.Size(181, 41);
            this.totalButton.TabIndex = 7;
            this.totalButton.Text = "Calculate Total";
            this.totalButton.UseVisualStyleBackColor = true;
            this.totalButton.Click += new System.EventHandler(this.totalButton_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(45, 472);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 20);
            this.label2.TabIndex = 8;
            // 
            // subtotalLabel
            // 
            this.subtotalLabel.AutoSize = true;
            this.subtotalLabel.Location = new System.Drawing.Point(86, 304);
            this.subtotalLabel.Name = "subtotalLabel";
            this.subtotalLabel.Size = new System.Drawing.Size(77, 20);
            this.subtotalLabel.TabIndex = 9;
            this.subtotalLabel.Text = "Sub Total";
            // 
            // taxLabel
            // 
            this.taxLabel.AutoSize = true;
            this.taxLabel.Location = new System.Drawing.Point(86, 363);
            this.taxLabel.Name = "taxLabel";
            this.taxLabel.Size = new System.Drawing.Size(34, 20);
            this.taxLabel.TabIndex = 10;
            this.taxLabel.Text = "Tax";
            this.taxLabel.Click += new System.EventHandler(this.label3_Click);
            // 
            // totalLabel
            // 
            this.totalLabel.AutoSize = true;
            this.totalLabel.Location = new System.Drawing.Point(86, 416);
            this.totalLabel.Name = "totalLabel";
            this.totalLabel.Size = new System.Drawing.Size(44, 20);
            this.totalLabel.TabIndex = 11;
            this.totalLabel.Text = "Total";
            // 
            // tenderedLabel
            // 
            this.tenderedLabel.AutoSize = true;
            this.tenderedLabel.Location = new System.Drawing.Point(86, 477);
            this.tenderedLabel.Name = "tenderedLabel";
            this.tenderedLabel.Size = new System.Drawing.Size(77, 20);
            this.tenderedLabel.TabIndex = 12;
            this.tenderedLabel.Text = "Tendered";
            // 
            // taxOutput
            // 
            this.taxOutput.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.taxOutput.Location = new System.Drawing.Point(267, 363);
            this.taxOutput.Name = "taxOutput";
            this.taxOutput.Size = new System.Drawing.Size(77, 33);
            this.taxOutput.TabIndex = 14;
            // 
            // totalOutput
            // 
            this.totalOutput.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.totalOutput.Location = new System.Drawing.Point(267, 417);
            this.totalOutput.Name = "totalOutput";
            this.totalOutput.Size = new System.Drawing.Size(77, 33);
            this.totalOutput.TabIndex = 15;
            // 
            // tenderedInput
            // 
            this.tenderedInput.Location = new System.Drawing.Point(271, 471);
            this.tenderedInput.Name = "tenderedInput";
            this.tenderedInput.Size = new System.Drawing.Size(73, 26);
            this.tenderedInput.TabIndex = 16;
            // 
            // changeButton
            // 
            this.changeButton.Location = new System.Drawing.Point(146, 520);
            this.changeButton.Name = "changeButton";
            this.changeButton.Size = new System.Drawing.Size(166, 47);
            this.changeButton.TabIndex = 17;
            this.changeButton.Text = "Calculate Change";
            this.changeButton.UseVisualStyleBackColor = true;
            this.changeButton.Click += new System.EventHandler(this.changeButton_Click);
            // 
            // subtotalOutput
            // 
            this.subtotalOutput.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.subtotalOutput.Location = new System.Drawing.Point(267, 304);
            this.subtotalOutput.Name = "subtotalOutput";
            this.subtotalOutput.Size = new System.Drawing.Size(77, 33);
            this.subtotalOutput.TabIndex = 18;
            // 
            // changeLabel
            // 
            this.changeLabel.AutoSize = true;
            this.changeLabel.Location = new System.Drawing.Point(100, 610);
            this.changeLabel.Name = "changeLabel";
            this.changeLabel.Size = new System.Drawing.Size(65, 20);
            this.changeLabel.TabIndex = 19;
            this.changeLabel.Text = "Change";
            // 
            // changeOutput
            // 
            this.changeOutput.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.changeOutput.Location = new System.Drawing.Point(267, 610);
            this.changeOutput.Name = "changeOutput";
            this.changeOutput.Size = new System.Drawing.Size(77, 33);
            this.changeOutput.TabIndex = 20;
            // 
            // printButton
            // 
            this.printButton.Location = new System.Drawing.Point(146, 674);
            this.printButton.Name = "printButton";
            this.printButton.Size = new System.Drawing.Size(163, 39);
            this.printButton.TabIndex = 21;
            this.printButton.Text = "Print Receipt";
            this.printButton.UseVisualStyleBackColor = true;
            this.printButton.Click += new System.EventHandler(this.printButton_Click);
            // 
            // receiptOutput
            // 
            this.receiptOutput.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.receiptOutput.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.receiptOutput.Location = new System.Drawing.Point(400, 42);
            this.receiptOutput.Name = "receiptOutput";
            this.receiptOutput.Size = new System.Drawing.Size(396, 479);
            this.receiptOutput.TabIndex = 22;
            this.receiptOutput.Click += new System.EventHandler(this.receipt_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(826, 763);
            this.Controls.Add(this.receiptOutput);
            this.Controls.Add(this.printButton);
            this.Controls.Add(this.changeOutput);
            this.Controls.Add(this.changeLabel);
            this.Controls.Add(this.subtotalOutput);
            this.Controls.Add(this.changeButton);
            this.Controls.Add(this.tenderedInput);
            this.Controls.Add(this.totalOutput);
            this.Controls.Add(this.taxOutput);
            this.Controls.Add(this.tenderedLabel);
            this.Controls.Add(this.totalLabel);
            this.Controls.Add(this.taxLabel);
            this.Controls.Add(this.subtotalLabel);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.totalButton);
            this.Controls.Add(this.staplerInput);
            this.Controls.Add(this.caseInput);
            this.Controls.Add(this.pencilInput);
            this.Controls.Add(this.item3Label);
            this.Controls.Add(this.item2Label);
            this.Controls.Add(this.item1Label);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label item1Label;
        private System.Windows.Forms.Label item2Label;
        private System.Windows.Forms.Label item3Label;
        private System.Windows.Forms.TextBox pencilInput;
        private System.Windows.Forms.TextBox caseInput;
        private System.Windows.Forms.TextBox staplerInput;
        private System.Windows.Forms.Button totalButton;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label subtotalLabel;
        private System.Windows.Forms.Label taxLabel;
        private System.Windows.Forms.Label totalLabel;
        private System.Windows.Forms.Label tenderedLabel;
        private System.Windows.Forms.Label taxOutput;
        private System.Windows.Forms.Label totalOutput;
        private System.Windows.Forms.TextBox tenderedInput;
        private System.Windows.Forms.Button changeButton;
        private System.Windows.Forms.Label subtotalOutput;
        private System.Windows.Forms.Label changeLabel;
        private System.Windows.Forms.Label changeOutput;
        private System.Windows.Forms.Button printButton;
        private System.Windows.Forms.Label receiptOutput;
    }
}

