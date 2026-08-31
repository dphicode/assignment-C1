namespace InvoiceTotal
{
    partial class frmInvoiceTotal
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            txtSubTotal = new TextBox();
            label2 = new Label();
            txtDiscountPct = new TextBox();
            label3 = new Label();
            txtDiscountAmt = new TextBox();
            label4 = new Label();
            txtTotal = new TextBox();
            btnCalculate = new Button();
            btnExit = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(21, 18);
            label1.Name = "label1";
            label1.Size = new Size(54, 15);
            label1.TabIndex = 0;
            label1.Text = "&Subtotal:";
            label1.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // txtSubTotal
            // 
            txtSubTotal.Location = new Point(133, 15);
            txtSubTotal.Name = "txtSubTotal";
            txtSubTotal.Size = new Size(100, 23);
            txtSubTotal.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(21, 47);
            label2.Name = "label2";
            label2.Size = new Size(100, 15);
            label2.TabIndex = 2;
            label2.Text = "Discount percent:";
            label2.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // txtDiscountPct
            // 
            txtDiscountPct.Location = new Point(133, 44);
            txtDiscountPct.Name = "txtDiscountPct";
            txtDiscountPct.ReadOnly = true;
            txtDiscountPct.Size = new Size(100, 23);
            txtDiscountPct.TabIndex = 3;
            txtDiscountPct.TabStop = false;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(21, 76);
            label3.Name = "label3";
            label3.Size = new Size(102, 15);
            label3.TabIndex = 4;
            label3.Text = "Discount amount:";
            label3.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // txtDiscountAmt
            // 
            txtDiscountAmt.Location = new Point(133, 73);
            txtDiscountAmt.Name = "txtDiscountAmt";
            txtDiscountAmt.ReadOnly = true;
            txtDiscountAmt.Size = new Size(100, 23);
            txtDiscountAmt.TabIndex = 5;
            txtDiscountAmt.TabStop = false;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(21, 105);
            label4.Name = "label4";
            label4.Size = new Size(35, 15);
            label4.TabIndex = 6;
            label4.Text = "Total:";
            label4.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // txtTotal
            // 
            txtTotal.Location = new Point(133, 102);
            txtTotal.Name = "txtTotal";
            txtTotal.ReadOnly = true;
            txtTotal.Size = new Size(100, 23);
            txtTotal.TabIndex = 7;
            txtTotal.TabStop = false;
            // 
            // btnCalculate
            // 
            btnCalculate.Location = new Point(66, 142);
            btnCalculate.Name = "btnCalculate";
            btnCalculate.Size = new Size(75, 23);
            btnCalculate.TabIndex = 2;
            btnCalculate.Text = "&Calculate";
            btnCalculate.UseVisualStyleBackColor = true;
            btnCalculate.Click += btnCalculate_Click;
            // 
            // btnExit
            // 
            btnExit.Location = new Point(158, 142);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(75, 23);
            btnExit.TabIndex = 3;
            btnExit.Text = "E&xit";
            btnExit.UseVisualStyleBackColor = true;
            btnExit.Click += btnExit_Click;
            // 
            // frmInvoiceTotal
            // 
            AcceptButton = btnCalculate;
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            CancelButton = btnExit;
            ClientSize = new Size(254, 181);
            Controls.Add(btnExit);
            Controls.Add(btnCalculate);
            Controls.Add(txtTotal);
            Controls.Add(label4);
            Controls.Add(txtDiscountAmt);
            Controls.Add(label3);
            Controls.Add(txtDiscountPct);
            Controls.Add(label2);
            Controls.Add(txtSubTotal);
            Controls.Add(label1);
            Name = "frmInvoiceTotal";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Invoice Total";
            ResumeLayout(false);
            PerformLayout();

        }

        #endregion

        private Label label1;
        private TextBox txtSubTotal;
        private Label label2;
        private TextBox txtDiscountPct;
        private Label label3;
        private TextBox txtDiscountAmt;
        private Label label4;
        private TextBox txtTotal;
        private Button btnCalculate;
        private Button btnExit;
    }
}