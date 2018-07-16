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
    public partial class Maderator : Form
    {
        Form form = new Form();

        List<Waiter> AllWaiter;
        List<Person> AllPersonWaiter;

        public Maderator(Form _form)
        {
            form = _form;  
        }

        public Maderator(List<Person> _AllPerson,List<Waiter> _AllWaiter,Form _form) : this()
        {
            form = _form;

            AllWaiter = _AllWaiter;
            AllPersonWaiter = _AllPerson;

            comboBox_waiter.DataSource = _AllPerson;
            comboBox_waiter.DisplayMember = "username";
        }

        public Maderator()
        {
            InitializeComponent();
            this.BackgroundImage = Properties.Resources.bg;
            AllWaiter = new List<RestoranApp.Waiter>();
        }

        private void button_otherRoles_Click(object sender, EventArgs e)
        {
            this.Hide();
            form.Show();
        }

        StringBuilder selectedWaiter;
        Person selectedPerson = new Person();

        private void comboBox_waiter_SelectedValueChanged(object sender, EventArgs e)
        {
            selectedWaiter = new StringBuilder();
            selectedPerson =(Person)(sender as ComboBox).SelectedValue;
            
            if (selectedPerson!=null)
            {
                selectedWaiter.Append(selectedPerson.username);
            }
        }
    
        private void button_edit_Click(object sender, EventArgs e)
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
        private void Maderator_FormClosing(object sender, FormClosingEventArgs e)
        {
            form.Close();
        }


    }
}
