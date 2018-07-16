using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;
using System.Reflection;
using System.Data.SqlClient;

namespace RestoranApp
{
    public partial class Waiter : Form
    {

        List<Product> products = new List<Product>();
        Form form = new Form();

        public Waiter(Form _form):this()
        {
            form = _form;
        }
        SqlConnection collection;
        SqlCommand command;
        SqlDataReader reader;

        public Waiter()
        {
            InitializeComponent();

            string query = "select * from Products;";

            try
            {
                collection = new SqlConnection("Data Source=DESKTOP-5IDPN0T\\SQLEXPRESS;Initial Catalog=RestoranDB;Integrated Security=true;");

                collection.Open();

                command = new SqlCommand(query, collection);

                reader = command.ExecuteReader();

                while (reader.Read())
                {
                    products.AddRange(new Product[]
                    {
                    new Product
                    {
                        name=reader["Name"].ToString(),
                        price=Convert.ToDecimal(reader["Price"]),
                        id=Convert.ToInt32(reader["Id"]),
                        category=(Category)Enum.Parse(typeof(Category),reader["Category"].ToString())
                    }
                    });
                }
            }
            catch (Exception exp)
            {
                MessageBox.Show(exp.Message);
            }
            finally
            {
                collection.Close();
                command.Dispose();
                reader.Close();
            }

            
            this.BackgroundImage = Properties.Resources.background;

            comboBox_category.DataSource = Enum.GetNames(typeof(Category));

        }

        private void comboBox_category_SelectedValueChanged(object sender, EventArgs e)
        {
            string selectedValue = (sender as ComboBox).SelectedValue.ToString();

            Category newSelectedValue = (Category)Enum.Parse(typeof(Category), selectedValue);

            List<Product> selectedProduct = new List<RestoranApp.Product>();

            foreach (Product pro in products)
            {
                if (pro.category==newSelectedValue)
                {
                    selectedProduct.Add(pro);
                }
            }

            comboBox_eaten.DataSource = selectedProduct;
            comboBox_eaten.DisplayMember = "name";
        }

        Product selectPro;

        private void comboBox_eaten_SelectedValueChanged(object sender, EventArgs e)
        {
            selectPro = (Product)(sender as ComboBox).SelectedValue;
            textBox_price.Text = selectPro.price.ToString();

            textBox_price.Text = textBox_price.Text + " AZN";
        }

        private void textBox_count_Enter(object sender, EventArgs e)
        {
            textBox_count.Text = "";
        }

        private void textBox_count_Leave(object sender, EventArgs e)
        {
            if (textBox_count.Text == "")
            {
                textBox_count.Text = "1";
            }
        }

        Basket basket = new Basket();
        int number = 1;

        private void button_order_Click(object sender, EventArgs e)
        {
            
            ProductOfBasket productOfBasket = new ProductOfBasket
            {
                name = selectPro.name,
                category = selectPro.category,
                price = selectPro.price,
                count = Convert.ToByte(textBox_count.Text),
                id=selectPro.id,
                totalPrice=selectPro.price* Convert.ToByte(textBox_count.Text)
            };

            basket.products.Add(productOfBasket);

            ListViewItem list = new ListViewItem(number.ToString());
            list.SubItems.Add(productOfBasket.name);
            list.SubItems.Add(productOfBasket.category.ToString());
            list.SubItems.Add(productOfBasket.price.ToString()+" AZN");
            list.SubItems.Add(productOfBasket.count.ToString());
            list.SubItems.Add(productOfBasket.totalPrice.ToString()+ " AZN");

            listView_row.Items.Add(list);

            label_allPrice.Text= SumTotalPrice(basket.products).ToString()+" AZN";

            number++;

            textBox_count.Text = "1";
        }
        

        private decimal SumTotalPrice(List<ProductOfBasket> products)
        {
            decimal Sum = 0;
            foreach (ProductOfBasket pro in products)
            {
                Sum += pro.totalPrice;
            }
            return Sum;
        }

        private void button_refresh_Click(object sender, EventArgs e)
        {
            listView_row.Items.Clear();
        }

        private void button_delete_Click(object sender, EventArgs e)
        {
            if(listView_row.SelectedItems.Count!=0)
            listView_row.SelectedItems[0].Remove();

            //but dont write update form
        }

        private void Waiter_FormClosing(object sender, FormClosingEventArgs e)
        {
            form.Close();
        }

        private void button_otherRoles_Click(object sender, EventArgs e)
        {
            this.Hide();
            form.Show();
        }

        private void textBox_count_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}
