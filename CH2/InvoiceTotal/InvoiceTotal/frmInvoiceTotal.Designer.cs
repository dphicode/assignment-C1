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
            LBL_Subtotal = new Label();
            LBL_Discperc = new Label();
            LBL_Discamt = new Label();
            LBL_Total = new Label();
            TB_Subtotal = new TextBox();
            TB_Discperc = new TextBox();
            TB_Discamt = new TextBox();
            TB_Total = new TextBox();
            BTN_Calc = new Button();
            BTN_Exit = new Button();
            SuspendLayout();
            // 
            // LBL_Subtotal
            // 
            LBL_Subtotal.AutoSize = true;
            LBL_Subtotal.Location = new Point(81, 60);
            LBL_Subtotal.Name = "LBL_Subtotal";
            LBL_Subtotal.Size = new Size(54, 15);
            LBL_Subtotal.TabIndex = 0;
            LBL_Subtotal.Text = "Subtotal:";
            // 
            // LBL_Discperc
            // 
            LBL_Discperc.AutoSize = true;
            LBL_Discperc.Location = new Point(81, 94);
            LBL_Discperc.Name = "LBL_Discperc";
            LBL_Discperc.Size = new Size(100, 15);
            LBL_Discperc.TabIndex = 1;
            LBL_Discperc.Text = "Discount Percent:";
            // 
            // LBL_Discamt
            // 
            LBL_Discamt.AutoSize = true;
            LBL_Discamt.Location = new Point(81, 131);
            LBL_Discamt.Name = "LBL_Discamt";
            LBL_Discamt.Size = new Size(104, 15);
            LBL_Discamt.TabIndex = 2;
            LBL_Discamt.Text = "Discount Amount:";
            // 
            // LBL_Total
            // 
            LBL_Total.AutoSize = true;
            LBL_Total.Location = new Point(81, 170);
            LBL_Total.Name = "LBL_Total";
            LBL_Total.Size = new Size(35, 15);
            LBL_Total.TabIndex = 3;
            LBL_Total.Text = "Total:";
            // 
            // TB_Subtotal
            // 
            TB_Subtotal.Location = new Point(200, 57);
            TB_Subtotal.Name = "TB_Subtotal";
            TB_Subtotal.Size = new Size(152, 23);
            TB_Subtotal.TabIndex = 4;
            // 
            // TB_Discperc
            // 
            TB_Discperc.Location = new Point(200, 91);
            TB_Discperc.Name = "TB_Discperc";
            TB_Discperc.Size = new Size(152, 23);
            TB_Discperc.TabIndex = 5;
            // 
            // TB_Discamt
            // 
            TB_Discamt.Location = new Point(200, 128);
            TB_Discamt.Name = "TB_Discamt";
            TB_Discamt.Size = new Size(152, 23);
            TB_Discamt.TabIndex = 6;
            // 
            // TB_Total
            // 
            TB_Total.Location = new Point(200, 167);
            TB_Total.Name = "TB_Total";
            TB_Total.Size = new Size(152, 23);
            TB_Total.TabIndex = 7;
            // 
            // BTN_Calc
            // 
            BTN_Calc.Location = new Point(141, 233);
            BTN_Calc.Name = "BTN_Calc";
            BTN_Calc.Size = new Size(87, 23);
            BTN_Calc.TabIndex = 8;
            BTN_Calc.Text = "Calculate";
            BTN_Calc.UseVisualStyleBackColor = true;
            // 
            // BTN_Exit
            // 
            BTN_Exit.Location = new Point(265, 233);
            BTN_Exit.Name = "BTN_Exit";
            BTN_Exit.Size = new Size(87, 23);
            BTN_Exit.TabIndex = 9;
            BTN_Exit.Text = "Exit";
            BTN_Exit.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(425, 450);
            Controls.Add(BTN_Exit);
            Controls.Add(BTN_Calc);
            Controls.Add(TB_Total);
            Controls.Add(TB_Discamt);
            Controls.Add(TB_Discperc);
            Controls.Add(TB_Subtotal);
            Controls.Add(LBL_Total);
            Controls.Add(LBL_Discamt);
            Controls.Add(LBL_Discperc);
            Controls.Add(LBL_Subtotal);
            Name = "Form1";
            Text = "Invoice Total";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label LBL_Subtotal;
        private Label LBL_Discperc;
        private Label LBL_Discamt;
        private Label LBL_Total;
        private TextBox TB_Subtotal;
        private TextBox TB_Discperc;
        private TextBox TB_Discamt;
        private TextBox TB_Total;
        private Button BTN_Calc;
        private Button BTN_Exit;
    }
}
