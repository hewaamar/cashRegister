
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.pencilLabel = new System.Windows.Forms.Label();
            this.staplerLabel = new System.Windows.Forms.Label();
            this.caseLabel = new System.Windows.Forms.Label();
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
            this.newButton = new System.Windows.Forms.Button();
            this.totalErrorOutput = new System.Windows.Forms.Label();
            this.changeAmountOutput = new System.Windows.Forms.Label();
            this.changeLetterOutput = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Transparent;
            resources.ApplyResources(this.label1, "label1");
            this.label1.ForeColor = System.Drawing.Color.LightCoral;
            this.label1.Name = "label1";
            // 
            // pencilLabel
            // 
            resources.ApplyResources(this.pencilLabel, "pencilLabel");
            this.pencilLabel.Name = "pencilLabel";
            // 
            // staplerLabel
            // 
            resources.ApplyResources(this.staplerLabel, "staplerLabel");
            this.staplerLabel.Name = "staplerLabel";
            // 
            // caseLabel
            // 
            resources.ApplyResources(this.caseLabel, "caseLabel");
            this.caseLabel.Name = "caseLabel";
            // 
            // pencilInput
            // 
            this.pencilInput.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            resources.ApplyResources(this.pencilInput, "pencilInput");
            this.pencilInput.Name = "pencilInput";
            // 
            // caseInput
            // 
            resources.ApplyResources(this.caseInput, "caseInput");
            this.caseInput.Name = "caseInput";
            // 
            // staplerInput
            // 
            resources.ApplyResources(this.staplerInput, "staplerInput");
            this.staplerInput.Name = "staplerInput";
            // 
            // totalButton
            // 
            this.totalButton.BackColor = System.Drawing.Color.LightCyan;
            resources.ApplyResources(this.totalButton, "totalButton");
            this.totalButton.Name = "totalButton";
            this.totalButton.UseVisualStyleBackColor = false;
            this.totalButton.Click += new System.EventHandler(this.totalButton_Click);
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.Name = "label2";
            // 
            // subtotalLabel
            // 
            resources.ApplyResources(this.subtotalLabel, "subtotalLabel");
            this.subtotalLabel.Name = "subtotalLabel";
            // 
            // taxLabel
            // 
            resources.ApplyResources(this.taxLabel, "taxLabel");
            this.taxLabel.Name = "taxLabel";
            this.taxLabel.Click += new System.EventHandler(this.totalButton_Click);
            // 
            // totalLabel
            // 
            resources.ApplyResources(this.totalLabel, "totalLabel");
            this.totalLabel.Name = "totalLabel";
            // 
            // tenderedLabel
            // 
            resources.ApplyResources(this.tenderedLabel, "tenderedLabel");
            this.tenderedLabel.Name = "tenderedLabel";
            // 
            // taxOutput
            // 
            this.taxOutput.BackColor = System.Drawing.SystemColors.ActiveCaption;
            resources.ApplyResources(this.taxOutput, "taxOutput");
            this.taxOutput.Name = "taxOutput";
            // 
            // totalOutput
            // 
            this.totalOutput.BackColor = System.Drawing.SystemColors.ActiveCaption;
            resources.ApplyResources(this.totalOutput, "totalOutput");
            this.totalOutput.Name = "totalOutput";
            // 
            // tenderedInput
            // 
            resources.ApplyResources(this.tenderedInput, "tenderedInput");
            this.tenderedInput.Name = "tenderedInput";
            // 
            // changeButton
            // 
            this.changeButton.BackColor = System.Drawing.Color.LightCyan;
            resources.ApplyResources(this.changeButton, "changeButton");
            this.changeButton.Name = "changeButton";
            this.changeButton.UseVisualStyleBackColor = false;
            this.changeButton.Click += new System.EventHandler(this.changeButton_Click);
            // 
            // subtotalOutput
            // 
            this.subtotalOutput.BackColor = System.Drawing.SystemColors.ActiveCaption;
            resources.ApplyResources(this.subtotalOutput, "subtotalOutput");
            this.subtotalOutput.Name = "subtotalOutput";
            // 
            // changeLabel
            // 
            resources.ApplyResources(this.changeLabel, "changeLabel");
            this.changeLabel.Name = "changeLabel";
            // 
            // changeOutput
            // 
            this.changeOutput.BackColor = System.Drawing.SystemColors.ActiveCaption;
            resources.ApplyResources(this.changeOutput, "changeOutput");
            this.changeOutput.Name = "changeOutput";
            // 
            // printButton
            // 
            this.printButton.BackColor = System.Drawing.Color.LightCyan;
            resources.ApplyResources(this.printButton, "printButton");
            this.printButton.Name = "printButton";
            this.printButton.UseVisualStyleBackColor = false;
            this.printButton.Click += new System.EventHandler(this.printButton_Click);
            // 
            // receiptOutput
            // 
            this.receiptOutput.BackColor = System.Drawing.SystemColors.ControlLightLight;
            resources.ApplyResources(this.receiptOutput, "receiptOutput");
            this.receiptOutput.Name = "receiptOutput";
            // 
            // newButton
            // 
            this.newButton.BackColor = System.Drawing.Color.PaleGoldenrod;
            resources.ApplyResources(this.newButton, "newButton");
            this.newButton.Name = "newButton";
            this.newButton.UseVisualStyleBackColor = false;
            this.newButton.Click += new System.EventHandler(this.newButton_Click);
            // 
            // totalErrorOutput
            // 
            resources.ApplyResources(this.totalErrorOutput, "totalErrorOutput");
            this.totalErrorOutput.ForeColor = System.Drawing.Color.IndianRed;
            this.totalErrorOutput.Name = "totalErrorOutput";
            // 
            // changeAmountOutput
            // 
            resources.ApplyResources(this.changeAmountOutput, "changeAmountOutput");
            this.changeAmountOutput.ForeColor = System.Drawing.Color.IndianRed;
            this.changeAmountOutput.Name = "changeAmountOutput";
            // 
            // changeLetterOutput
            // 
            resources.ApplyResources(this.changeLetterOutput, "changeLetterOutput");
            this.changeLetterOutput.ForeColor = System.Drawing.Color.IndianRed;
            this.changeLetterOutput.Name = "changeLetterOutput";
            // 
            // Form1
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.Controls.Add(this.changeLetterOutput);
            this.Controls.Add(this.changeAmountOutput);
            this.Controls.Add(this.totalErrorOutput);
            this.Controls.Add(this.newButton);
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
            this.Controls.Add(this.caseLabel);
            this.Controls.Add(this.staplerLabel);
            this.Controls.Add(this.pencilLabel);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label pencilLabel;
        private System.Windows.Forms.Label staplerLabel;
        private System.Windows.Forms.Label caseLabel;
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
        private System.Windows.Forms.Button newButton;
        private System.Windows.Forms.Label totalErrorOutput;
        private System.Windows.Forms.Label changeAmountOutput;
        private System.Windows.Forms.Label changeLetterOutput;
    }
}

