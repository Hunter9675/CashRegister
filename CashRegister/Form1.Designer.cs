namespace CashRegister
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
            this.components = new System.ComponentModel.Container();
            this.hmaInput = new System.Windows.Forms.TextBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.hmbInput = new System.Windows.Forms.TextBox();
            this.hmbbInput = new System.Windows.Forms.TextBox();
            this.hmaLabel = new System.Windows.Forms.Label();
            this.hmbLabel = new System.Windows.Forms.Label();
            this.hmbbLabel = new System.Windows.Forms.Label();
            this.calculateTotalsButton = new System.Windows.Forms.Button();
            this.subTotalLabel = new System.Windows.Forms.Label();
            this.totalLabel = new System.Windows.Forms.Label();
            this.taxLabel = new System.Windows.Forms.Label();
            this.subTotalOutput = new System.Windows.Forms.Label();
            this.taxOutput = new System.Windows.Forms.Label();
            this.totalOutput = new System.Windows.Forms.Label();
            this.line2 = new System.Windows.Forms.Label();
            this.tenderedLabel = new System.Windows.Forms.Label();
            this.tenderedInput = new System.Windows.Forms.TextBox();
            this.calculateChangeButton = new System.Windows.Forms.Button();
            this.changeLabel = new System.Windows.Forms.Label();
            this.changeOutput = new System.Windows.Forms.Label();
            this.printReceiptButton = new System.Windows.Forms.Button();
            this.titleLabel = new System.Windows.Forms.Label();
            this.line1 = new System.Windows.Forms.Label();
            this.printReceiptOutput = new System.Windows.Forms.Label();
            this.errorLabel = new System.Windows.Forms.Label();
            this.errorLabel2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // hmaInput
            // 
            this.hmaInput.Location = new System.Drawing.Point(163, 77);
            this.hmaInput.Name = "hmaInput";
            this.hmaInput.Size = new System.Drawing.Size(61, 20);
            this.hmaInput.TabIndex = 0;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // hmbInput
            // 
            this.hmbInput.Location = new System.Drawing.Point(163, 126);
            this.hmbInput.Name = "hmbInput";
            this.hmbInput.Size = new System.Drawing.Size(61, 20);
            this.hmbInput.TabIndex = 2;
            // 
            // hmbbInput
            // 
            this.hmbbInput.Location = new System.Drawing.Point(163, 169);
            this.hmbbInput.Name = "hmbbInput";
            this.hmbbInput.Size = new System.Drawing.Size(61, 20);
            this.hmbbInput.TabIndex = 3;
            // 
            // hmaLabel
            // 
            this.hmaLabel.AutoSize = true;
            this.hmaLabel.Location = new System.Drawing.Point(12, 80);
            this.hmaLabel.Name = "hmaLabel";
            this.hmaLabel.Size = new System.Drawing.Size(98, 13);
            this.hmaLabel.TabIndex = 4;
            this.hmaLabel.Text = "How many Apples?";
            // 
            // hmbLabel
            // 
            this.hmbLabel.AutoSize = true;
            this.hmbLabel.Location = new System.Drawing.Point(12, 126);
            this.hmbLabel.Name = "hmbLabel";
            this.hmbLabel.Size = new System.Drawing.Size(108, 13);
            this.hmbLabel.TabIndex = 5;
            this.hmbLabel.Text = "How many Bananas?";
            // 
            // hmbbLabel
            // 
            this.hmbbLabel.AutoSize = true;
            this.hmbbLabel.Location = new System.Drawing.Point(12, 169);
            this.hmbbLabel.Name = "hmbbLabel";
            this.hmbbLabel.Size = new System.Drawing.Size(118, 13);
            this.hmbbLabel.TabIndex = 6;
            this.hmbbLabel.Text = "How many Blueberries?";
            // 
            // calculateTotalsButton
            // 
            this.calculateTotalsButton.Location = new System.Drawing.Point(35, 213);
            this.calculateTotalsButton.Name = "calculateTotalsButton";
            this.calculateTotalsButton.Size = new System.Drawing.Size(168, 40);
            this.calculateTotalsButton.TabIndex = 7;
            this.calculateTotalsButton.Text = "Calculate Totals";
            this.calculateTotalsButton.UseVisualStyleBackColor = true;
            this.calculateTotalsButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // subTotalLabel
            // 
            this.subTotalLabel.AutoSize = true;
            this.subTotalLabel.Location = new System.Drawing.Point(12, 270);
            this.subTotalLabel.Name = "subTotalLabel";
            this.subTotalLabel.Size = new System.Drawing.Size(56, 13);
            this.subTotalLabel.TabIndex = 8;
            this.subTotalLabel.Text = "Sub Total:";
            // 
            // totalLabel
            // 
            this.totalLabel.AutoSize = true;
            this.totalLabel.Location = new System.Drawing.Point(12, 337);
            this.totalLabel.Name = "totalLabel";
            this.totalLabel.Size = new System.Drawing.Size(34, 13);
            this.totalLabel.TabIndex = 9;
            this.totalLabel.Text = "Total:";
            // 
            // taxLabel
            // 
            this.taxLabel.AutoSize = true;
            this.taxLabel.Location = new System.Drawing.Point(12, 302);
            this.taxLabel.Name = "taxLabel";
            this.taxLabel.Size = new System.Drawing.Size(28, 13);
            this.taxLabel.TabIndex = 10;
            this.taxLabel.Text = "Tax:";
            // 
            // subTotalOutput
            // 
            this.subTotalOutput.AutoSize = true;
            this.subTotalOutput.Location = new System.Drawing.Point(92, 270);
            this.subTotalOutput.Name = "subTotalOutput";
            this.subTotalOutput.Size = new System.Drawing.Size(0, 13);
            this.subTotalOutput.TabIndex = 11;
            // 
            // taxOutput
            // 
            this.taxOutput.AutoSize = true;
            this.taxOutput.Location = new System.Drawing.Point(92, 302);
            this.taxOutput.Name = "taxOutput";
            this.taxOutput.Size = new System.Drawing.Size(0, 13);
            this.taxOutput.TabIndex = 12;
            // 
            // totalOutput
            // 
            this.totalOutput.AutoSize = true;
            this.totalOutput.Location = new System.Drawing.Point(92, 337);
            this.totalOutput.Name = "totalOutput";
            this.totalOutput.Size = new System.Drawing.Size(0, 13);
            this.totalOutput.TabIndex = 13;
            // 
            // line2
            // 
            this.line2.AutoSize = true;
            this.line2.Location = new System.Drawing.Point(12, 362);
            this.line2.Name = "line2";
            this.line2.Size = new System.Drawing.Size(253, 13);
            this.line2.TabIndex = 14;
            this.line2.Text = "---------------------------------------------------------------------------------" +
    "-";
            // 
            // tenderedLabel
            // 
            this.tenderedLabel.AutoSize = true;
            this.tenderedLabel.Location = new System.Drawing.Point(12, 393);
            this.tenderedLabel.Name = "tenderedLabel";
            this.tenderedLabel.Size = new System.Drawing.Size(53, 13);
            this.tenderedLabel.TabIndex = 15;
            this.tenderedLabel.Text = "Tendered";
            // 
            // tenderedInput
            // 
            this.tenderedInput.Location = new System.Drawing.Point(163, 390);
            this.tenderedInput.Name = "tenderedInput";
            this.tenderedInput.Size = new System.Drawing.Size(61, 20);
            this.tenderedInput.TabIndex = 16;
            // 
            // calculateChangeButton
            // 
            this.calculateChangeButton.Location = new System.Drawing.Point(35, 426);
            this.calculateChangeButton.Name = "calculateChangeButton";
            this.calculateChangeButton.Size = new System.Drawing.Size(168, 40);
            this.calculateChangeButton.TabIndex = 17;
            this.calculateChangeButton.Text = "Calculate Change";
            this.calculateChangeButton.UseVisualStyleBackColor = true;
            this.calculateChangeButton.Click += new System.EventHandler(this.calculateChangeButton_Click);
            // 
            // changeLabel
            // 
            this.changeLabel.AutoSize = true;
            this.changeLabel.Location = new System.Drawing.Point(12, 484);
            this.changeLabel.Name = "changeLabel";
            this.changeLabel.Size = new System.Drawing.Size(47, 13);
            this.changeLabel.TabIndex = 18;
            this.changeLabel.Text = "Change:";
            // 
            // changeOutput
            // 
            this.changeOutput.AutoSize = true;
            this.changeOutput.Location = new System.Drawing.Point(92, 484);
            this.changeOutput.Name = "changeOutput";
            this.changeOutput.Size = new System.Drawing.Size(0, 13);
            this.changeOutput.TabIndex = 19;
            // 
            // printReceiptButton
            // 
            this.printReceiptButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.printReceiptButton.Location = new System.Drawing.Point(12, 517);
            this.printReceiptButton.Name = "printReceiptButton";
            this.printReceiptButton.Size = new System.Drawing.Size(241, 75);
            this.printReceiptButton.TabIndex = 20;
            this.printReceiptButton.Text = "Print Receipt";
            this.printReceiptButton.UseVisualStyleBackColor = true;
            this.printReceiptButton.Click += new System.EventHandler(this.printReceiptButton_Click);
            // 
            // titleLabel
            // 
            this.titleLabel.AutoSize = true;
            this.titleLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titleLabel.Location = new System.Drawing.Point(12, 9);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(167, 37);
            this.titleLabel.TabIndex = 21;
            this.titleLabel.Text = "Fruit Store";
            // 
            // line1
            // 
            this.line1.AutoSize = true;
            this.line1.Location = new System.Drawing.Point(12, 48);
            this.line1.Name = "line1";
            this.line1.Size = new System.Drawing.Size(253, 13);
            this.line1.TabIndex = 22;
            this.line1.Text = "---------------------------------------------------------------------------------" +
    "-";
            // 
            // printReceiptOutput
            // 
            this.printReceiptOutput.AutoSize = true;
            this.printReceiptOutput.Location = new System.Drawing.Point(302, 9);
            this.printReceiptOutput.Name = "printReceiptOutput";
            this.printReceiptOutput.Size = new System.Drawing.Size(0, 13);
            this.printReceiptOutput.TabIndex = 23;
            // 
            // errorLabel
            // 
            this.errorLabel.AutoSize = true;
            this.errorLabel.BackColor = System.Drawing.Color.Red;
            this.errorLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 53.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.errorLabel.ForeColor = System.Drawing.Color.White;
            this.errorLabel.Location = new System.Drawing.Point(86, 270);
            this.errorLabel.Name = "errorLabel";
            this.errorLabel.Size = new System.Drawing.Size(0, 81);
            this.errorLabel.TabIndex = 24;
            // 
            // errorLabel2
            // 
            this.errorLabel2.AutoSize = true;
            this.errorLabel2.BackColor = System.Drawing.Color.Red;
            this.errorLabel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.errorLabel2.ForeColor = System.Drawing.Color.White;
            this.errorLabel2.Location = new System.Drawing.Point(68, 482);
            this.errorLabel2.Name = "errorLabel2";
            this.errorLabel2.Size = new System.Drawing.Size(0, 20);
            this.errorLabel2.TabIndex = 25;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(642, 603);
            this.Controls.Add(this.errorLabel2);
            this.Controls.Add(this.errorLabel);
            this.Controls.Add(this.printReceiptOutput);
            this.Controls.Add(this.line1);
            this.Controls.Add(this.titleLabel);
            this.Controls.Add(this.printReceiptButton);
            this.Controls.Add(this.changeOutput);
            this.Controls.Add(this.changeLabel);
            this.Controls.Add(this.calculateChangeButton);
            this.Controls.Add(this.tenderedInput);
            this.Controls.Add(this.tenderedLabel);
            this.Controls.Add(this.line2);
            this.Controls.Add(this.totalOutput);
            this.Controls.Add(this.taxOutput);
            this.Controls.Add(this.subTotalOutput);
            this.Controls.Add(this.taxLabel);
            this.Controls.Add(this.totalLabel);
            this.Controls.Add(this.subTotalLabel);
            this.Controls.Add(this.calculateTotalsButton);
            this.Controls.Add(this.hmbbLabel);
            this.Controls.Add(this.hmbLabel);
            this.Controls.Add(this.hmaLabel);
            this.Controls.Add(this.hmbbInput);
            this.Controls.Add(this.hmbInput);
            this.Controls.Add(this.hmaInput);
            this.Name = "Form1";
            this.Text = "Fruit Store";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox hmaInput;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.TextBox hmbInput;
        private System.Windows.Forms.TextBox hmbbInput;
        private System.Windows.Forms.Label hmaLabel;
        private System.Windows.Forms.Label hmbLabel;
        private System.Windows.Forms.Label hmbbLabel;
        private System.Windows.Forms.Button calculateTotalsButton;
        private System.Windows.Forms.Label subTotalLabel;
        private System.Windows.Forms.Label totalLabel;
        private System.Windows.Forms.Label taxLabel;
        private System.Windows.Forms.Label subTotalOutput;
        private System.Windows.Forms.Label taxOutput;
        private System.Windows.Forms.Label totalOutput;
        private System.Windows.Forms.Label line2;
        private System.Windows.Forms.Label tenderedLabel;
        private System.Windows.Forms.TextBox tenderedInput;
        private System.Windows.Forms.Button calculateChangeButton;
        private System.Windows.Forms.Label changeLabel;
        private System.Windows.Forms.Label changeOutput;
        private System.Windows.Forms.Button printReceiptButton;
        private System.Windows.Forms.Label titleLabel;
        private System.Windows.Forms.Label line1;
        private System.Windows.Forms.Label printReceiptOutput;
        private System.Windows.Forms.Label errorLabel;
        private System.Windows.Forms.Label errorLabel2;
    }
}

