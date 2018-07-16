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
    public partial class Login : Form
    {
        Register register;
        Waiter Waiter;

        public Login()
        {
            InitializeComponent();

            textBox_password.PasswordChar = '*';
            textBox_password.MaxLength = 15;

            register = new Register(this);
        }

        private void button_register_Click(object sender, EventArgs e)
        {
            this.Hide();
            register.Show();

            textBox_username.Text = "";
            textBox_password.Text = "";
        }

        private void button_login_Click(object sender, EventArgs e)
        {
            if (Control(register.AllOwn.People))
            {
                this.Hide();

                if (ControlRoles(register.AllOwn.People, GetPersonIndex(register.AllOwn.People)) == "Waiter")
                {
                    Waiter = ControlWaiter(register.AllWaiter.AllWaiters, GetPersonIndex(register.AllWaiter.AllPersonWaiters));
                    Waiter.Show();
                    Waiter.Text = "";
                    Waiter.Text = Waiter.Text + "Waiter - Welcome, " + register.AllOwn.People[GetPersonIndex(register.AllOwn.People)].username;
                }
                if (ControlRoles(register.AllOwn.People, GetPersonIndex(register.AllOwn.People)) == "Maderator")
                {
                    register.AllMaderator.AllMaderators[0] = new Maderator(register.AllWaiter.AllPersonWaiters,register.AllWaiter.AllWaiters,this);
                    register.AllMaderator.AllMaderators[0].Show();
                    register.AllMaderator.AllMaderators[0].Text = "";
                    register.AllMaderator.AllMaderators[0].Text = register.AllMaderator.AllMaderators[0] + "Maderator - Welcome, " + register.AllOwn.People[GetPersonIndex(register.AllOwn.People)].username;
                }
                if (ControlRoles(register.AllOwn.People, GetPersonIndex(register.AllOwn.People)) == "Admin")
                {
                    register.AllAdmin.AllAdmins[0] = new Admin(register.AllWaiter.AllPersonWaiters, register.AllWaiter.AllWaiters, register.AllMaderator.AllMaderators, register.AllMaderator.AllPersonMaderators,this);
                    register.AllAdmin.AllAdmins[0].Show();
                    register.AllAdmin.AllAdmins[0].Text = "";
                    register.AllAdmin.AllAdmins[0].Text = register.AllAdmin.AllAdmins[0].Text + "Admin - Welcome, " + register.AllOwn.People[GetPersonIndex(register.AllOwn.People)].username;
                }
            }
            else if (textBox_username.Text == "" || textBox_password.Text == "")
            {
                MessageBox.Show("Please, Include Information");
            }
            else
            MessageBox.Show("Wrong Username Or Password. Please, Include Correct Information");

            textBox_username.Text = "";
            textBox_password.Text = "";
        }
        public bool Control(List<Person> _AllPerson)
        {
            foreach (Person person in _AllPerson)
            {
                if (textBox_username.Text == person.username && textBox_password.Text == person.password)
                {
                    return true;
                }
            }
            return false;
        }
        public int GetPersonIndex(List<Person> _AllPerson)
        {
            for (int i = 0; i < _AllPerson.Count; i++)
            {
                if (textBox_username.Text == _AllPerson[i].username)
                {
                    return i;
                }
            }
            return 0;
        }
        public Waiter ControlWaiter(List<Waiter> _AllWaiter,int num)
        {
            for (int i = 0; i < _AllWaiter.Count; i++)
            {
                if (num==i)
                {
                    return _AllWaiter[i];
                }
            }
            return _AllWaiter[_AllWaiter.Count-1];
        }
        public string ControlRoles(List<Person> _AllPerson,int num)
        {
            if ((_AllPerson[num].role | Role.Waiter) == Role.Waiter)
            {
                return "Waiter";
            }
            if ((_AllPerson[num].role | Role.Moderator) == Role.Moderator)
            {
                return "Maderator";
            }
            if ((_AllPerson[num].role | Role.Admin) == Role.Admin)
            {
                return "Admin";
            }
            return "";
        }
    }
}
