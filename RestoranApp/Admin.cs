using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RestoranApp
{
    public partial class Admin : Form
    {
        Form form = new Form();
        Person selectedMaderatorPerson;
        Person selectedWaiterPerson;

        List<Person> AllPersonWaiter;
        List<Waiter> AllWaiter;
        List<Person> AllPersonMaderator;
        List<Maderator> AllMaderator;

        public Admin(Form _form)
        {
            form = _form;
        }

        public Admin(List<Person> _AllPersonWaiter, List<Waiter> _AllWaiter, List<Maderator> _AllMaderator, List<Person> _AllPersonMaderator,Form _form) : this()
        {
            form = _form;

            AllPersonWaiter = _AllPersonWaiter;
            AllWaiter = _AllWaiter;
            AllPersonMaderator = _AllPersonMaderator;
            AllMaderator = _AllMaderator;

            this.comboBox_Maderator.DataSource = _AllPersonMaderator;
            this.comboBox_Maderator.DisplayMember = "username";
            this.comboBox_Waiter.DataSource = _AllPersonWaiter;
            this.comboBox_Waiter.DisplayMember = "username";
        }

        public Admin()
        {
            InitializeComponent();
            this.BackgroundImage = Properties.Resources.abstract3_12;

            selectedMaderatorPerson = new Person();
            selectedWaiterPerson = new Person();

            AllPersonWaiter = new List<RestoranApp.Person>();
            AllWaiter = new List<RestoranApp.Waiter>();
            AllPersonMaderator = new List<RestoranApp.Person>();
            AllMaderator = new List<RestoranApp.Maderator>();
        }

        private void Admin_FormClosing(object sender, FormClosingEventArgs e)
        {
            form.Close();
        }

        private void button_OtherRoles_Click(object sender, EventArgs e)
        {
            this.Hide();
            form.Show();
        }

        StringBuilder selectedMaderator;
        
        private void comboBox_Maderator_SelectedValueChanged(object sender, EventArgs e)
        {
            selectedMaderator = new StringBuilder();
            selectedMaderatorPerson = (Person)(sender as ComboBox).SelectedValue;
            
            if (selectedMaderatorPerson!=null)
            {
                selectedMaderator.Append(selectedMaderatorPerson.username);
            }

        }

        private void button_Maderator_Click(object sender, EventArgs e)
        {
            if (AllPersonMaderator.Count!=0)
            {
                this.Hide();
                AllMaderator[0] = new Maderator(AllPersonWaiter,AllWaiter, form);
                AllMaderator[0].Show();
            }
            else
            {
                MessageBox.Show("There isn't the Maderator");
            }
        }

        StringBuilder selectedWaiter;

        private void comboBox_Waiter_SelectedValueChanged(object sender, EventArgs e)
        {
            selectedWaiter = new StringBuilder();
            selectedWaiterPerson = (Person)(sender as ComboBox).SelectedValue;
            if (selectedWaiterPerson != null)
            {
                selectedWaiter.Append(selectedWaiterPerson.username);
            }
            
        }

        private void button_Waiter_Click(object sender, EventArgs e)
        {
            if (AllPersonWaiter.Count!=0)
            {
                for (int i = 0; i < AllPersonWaiter.Count; i++)
                {
                    if (AllPersonWaiter[i].username == selectedWaiter.ToString())
                    {
                        this.Hide();
                        AllWaiter[i].Show();
                    }
                }
            }
            else
            {
                MessageBox.Show("There isn't the Waiter");
            }
            
        }
    }
}
