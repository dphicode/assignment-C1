using System.Windows.Forms;

namespace InvoiceTotal
{
    public partial class frmInvoiceTotal : Form
    {
        public frmInvoiceTotal()
        {
            InitializeComponent();
        }

        // TODO: declare class variables for array and list here
        int totalIdx = 0;
        decimal[] arrInvTotal = new decimal[5];

        List<decimal> lstInvTotal = new List<decimal>();
        private void btnCalculate_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtSubtotal.Text == "")
                {
                    MessageBox.Show(
                        "Subtotal is a required field.", "Entry Error");
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

                        arrInvTotal[totalIdx] = invoiceTotal;
                        totalIdx++;
                        lstInvTotal.Add(invoiceTotal);
                        
                    }
                    else
                    {
                        MessageBox.Show(
                            "Subtotal must be greater than 0 and less than 10,000.",
                            "Entry Error");
                    }
                }
            }
            catch (IndexOutOfRangeException ex)
            {
                MessageBox.Show($"Index out of range. {ex.Message}");
                //MessageBox.Show(
                //    "Please enter a valid number for the Subtotal field.",
                //    "Entry Error");
            }
            txtSubtotal.Focus();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            // TODO: add code that displays dialog boxes here
            Array.Sort(arrInvTotal);
            string msg = "";
            foreach (decimal tot in arrInvTotal)
            {
                if (tot > 0)
                {
                    msg += tot.ToString("c") + Environment.NewLine;
                }
            }
            MessageBox.Show(msg, "Array of Order Totals");

            lstInvTotal.Sort();
            msg = "";
            foreach (decimal tot in lstInvTotal)
            {
                msg += tot.ToString("c") + Environment.NewLine;
            }
            MessageBox.Show(msg, "List of Invoice Totals");

            this.Close();
        }
    }
}