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
    public partial class frmFirst : Form
    {
        public static int IDCurrentContact = 0;
        public frmFirst()
        {
            InitializeComponent();
        }
        Entities contacts = new Entities();

        private void frmFirst_Load(object sender, EventArgs e)
        {
           
            dgvContacts_Table.AutoGenerateColumns = false;
            RefreshList();
            label2.Visible = false;
        }
        private void toolStripButtonNewUser_Click(object sender, EventArgs e)
        {
            IDCurrentContact = 0;
            frmNewEditPerson frm = new frmNewEditPerson();
            frm.ShowDialog();
            RefreshList();
            if (frm.DialogResult == DialogResult.OK)
            {
                RefreshList();
            }
        }

        private void tsbRefresh_Click(object sender, EventArgs e)
        {
            RefreshList();
        }
        private void RefreshList()
        {
            
            dgvContacts_Table.DataSource = null;
            dgvContacts_Table.DataSource = contacts.SelectAll();

        }

        private void tsbDelete_Click(object sender, EventArgs e)
        {
            if (dgvContacts_Table.CurrentCell == null)
            {
                MessageBox.Show("لطفا شخصی را انتخاب کنید", "توجه", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            string name = dgvContacts_Table.Rows[dgvContacts_Table.CurrentCell.RowIndex].Cells[1].Value.ToString();
            string family = dgvContacts_Table.Rows[dgvContacts_Table.CurrentCell.RowIndex].Cells[2].Value.ToString();
            DialogResult dialogResult = MessageBox.Show($" آیا از حذف {name} {family} مطمین اید ؟", "توجه", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            string currentID = dgvContacts_Table.Rows[dgvContacts_Table.CurrentRow.Index].Cells[0].Value.ToString();
            if (dialogResult == DialogResult.Yes)
            {
                dgvContacts_Table.DataSource = null;
                bool isSecceed = contacts.Delete(currentID);
                if (isSecceed == false)
                {
                    MessageBox.Show("عملیات ناموفق بود", "هشدار", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }
            if (dialogResult == DialogResult.No)
            {
                return;
            }
            RefreshList();
        }

        private void tsbEdit_Click(object sender, EventArgs e)
        {
            if (dgvContacts_Table.CurrentRow == null)
            {
                MessageBox.Show("با کلیک بر روی  اسم شخص آن را انتخاب کنید !", "توجه", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            IDCurrentContact = int.Parse(dgvContacts_Table.CurrentRow.Cells[0].Value.ToString());
            frmNewEditPerson frm = new frmNewEditPerson();
            frm.ShowDialog();
            RefreshList();
            IDCurrentContact = 0;
        }

        private void tbSearch_TextChanged(object sender, EventArgs e)
        {
            List<tblContact> selectedContacts = contacts.Search(tbSearch.Text);
            dgvContacts_Table.DataSource = selectedContacts;
            
            if (tbSearch.Text.Length > 0)
                label2.Visible = true;
            else
                label2.Visible = false;

        }
    }
}