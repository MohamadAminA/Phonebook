using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SQL_Connection;

namespace Amoozesh_vs_desktop
{
    public partial class frmNewEditPerson : Form
    {

        public frmNewEditPerson()
        {
            InitializeComponent();
        }

        private void btnSabt_Click(object sender, EventArgs e)
        {
            Entities contacts = new Entities();
            if (tbName.Text == "" || tbFamily.Text == "" || tbPhone.Text == "")
            {
                MessageBox.Show("لطفا همه فیلد هارا پر کنید", "هشدار", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            
            if (frmFirst.IDCurrentContact == 0)
            {
                if (contacts.Insert(tbName.Text, tbFamily.Text, tbPhone.Text, tbAddress.Text))
                {
                    MessageBox.Show($"{tbName.Text} {tbFamily.Text} با موفقیت اضافه شد", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.DialogResult = DialogResult.Yes;
                }
                else
                {
                    MessageBox.Show("عملیات ناموفق بود", "هشدار", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    this.DialogResult = DialogResult.No;
                }
            }
            else
            {
                if (contacts.Update(frmFirst.IDCurrentContact.ToString(), tbName.Text, tbFamily.Text, tbPhone.Text, tbAddress.Text) == true)
                {
                    MessageBox.Show($"{tbName.Text} {tbFamily.Text} با موفقیت اضافه شد", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("عملیات موفقیت آمیز نبود", "هشدار", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            CleanBoxes();
            this.Close();
        }

        private void CleanBoxes()
        {
            tbName.Clear();
            tbFamily.Clear();
            tbPhone.Clear();
            tbAddress.Clear();
        }

        private void frmNewEditPerson_Load(object sender, EventArgs e)
        {
            if (frmFirst.IDCurrentContact == 0)
            {
                this.Text = "شخص جدید";
                btnSabt.Text = "ثبت";
                CleanBoxes();
            }
            else
            {
                this.Text = "ویرایش شخص";
                btnSabt.Text = "ویرایش";
                ContactsRepository contact = new ContactsRepository();
                DataTable dataContact = new DataTable();
                dataContact = contact.GetContact(frmFirst.IDCurrentContact.ToString());
                tbName.Text = dataContact.Rows[0][1].ToString();
                tbFamily.Text = dataContact.Rows[0][2].ToString();
                tbPhone.Text = dataContact.Rows[0][3].ToString();
                tbAddress.Text = dataContact.Rows[0][4].ToString();
            }
        }
    }
}