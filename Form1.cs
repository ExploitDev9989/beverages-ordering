using System.ComponentModel;
using System;
using System.ComponentModel;
using System.Windows.Forms;

namespace beverages_menu
{
    public partial class Form1 : Form
    {
        // BindingList updates the grid automatically (better than List for WinForms UI)
        private BindingList<Coffee> coffees = new BindingList<Coffee>();

        public Form1()
        {
            InitializeComponent();

            // Bind list to grid
            dgvCoffees.AutoGenerateColumns = true;
            dgvCoffees.DataSource = coffees;

            // Starter data (optional)
            coffees.Add(new Coffee("Latte", "Medium", false, "Medium", 2, true, false));
            coffees.Add(new Coffee("Cold Brew", "Large", true, "Dark", 1, false, false));
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            // Basic validation for shots
            if (!int.TryParse(txtShots.Text, out int shots) || shots <= 0)
            {
                MessageBox.Show("Shots must be a number greater than 0.");
                return;
            }

            // Build a Coffee object from inputs
            Coffee coffee = new Coffee(
                txtName.Text,
                txtSize.Text,
                chkIced.Checked,
                txtRoast.Text,
                shots,
                chkCream.Checked,
                chkSugar.Checked
            );

            coffees.Add(coffee);
            ClearInputs();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dgvCoffees.CurrentRow == null)
            {
                MessageBox.Show("Select a coffee row to delete.");
                return;
            }

            // CurrentRow.DataBoundItem is the Coffee object in that row
            Coffee selected = dgvCoffees.CurrentRow.DataBoundItem as Coffee;

            if (selected != null)
            {
                coffees.Remove(selected);
            }
        }

        private void ClearInputs()
        {
            txtName.Text = "";
            txtSize.Text = "";
            txtRoast.Text = "";
            txtShots.Text = "";

            chkIced.Checked = false;
            chkCream.Checked = false;
            chkSugar.Checked = false;
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            // You can leave this empty for now
        }
    }
}