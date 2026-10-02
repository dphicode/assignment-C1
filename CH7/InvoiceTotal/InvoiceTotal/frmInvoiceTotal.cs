namespace InvoiceTotal
{
    public partial class frmInvoiceTotal : Form
    {
        public frmInvoiceTotal()
        {
            InitializeComponent();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(txtSubtotal.Text))
                {
                    MessageBox.Show("Subtotal is required.");
                }
                else
                {
                    decimal subtotal = Decimal.Parse(txtSubtotal.Text);
                    if (subtotal > 0 && subtotal < 10000)
                    {
                        decimal discountPct = .25m;
                        decimal discountAmt = Math.Round(subtotal * discountPct, 2);
                        decimal invoiceTotal = Math.Round(subtotal - discountAmt, 2);

                        txtDiscountPct.Text = discountPct.ToString("p1");
                        txtDiscountAmt.Text = discountAmt.ToString("c");
                        txtTotal.Text = invoiceTotal.ToString("c");
                    }
                    else
                    {
                        MessageBox.Show("Subtotal must be between 1 and 9,999.");
                    }
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show("Please enter a valid number for your Subtotal.");
            }
            txtSubtotal.Focus();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}