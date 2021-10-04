using Db4objects.Db4o;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DB4ODemo
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        IObjectContainer db = null;
        IObjectSet result = null;

        private void frmMain_Load(object sender, EventArgs e)
        {
            db = Db4oEmbedded.OpenFile("pilotdb.yap");
            loadData();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            // Validation

            // Create and store
            var pilot = new Pilot(int.Parse(txtID.Text), txtName.Text, int.Parse(txtPoint.Text));
            db.Store(pilot);

            //Clear text
            txtName.Clear();
            txtPoint.Clear();

            loadData();
        }

        private void btnReload_Click(object sender, EventArgs e)
        {
            loadData();
        }

        private void loadData()
        {
            var template = new Pilot(0, null);
            result = db.QueryByExample(template);
            dgvPilot.DataSource = result;
        }

        private void dgvPilot_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            var pilotObj = (Pilot) result[e.RowIndex];
            //MessageBox.Show(pilotObj.ToString());
            txtID.Text = pilotObj.Id.ToString();
            txtName.Text = pilotObj.Name;
            txtPoint.Text = pilotObj.Point.ToString();
        }

        private void btnModify_Click(object sender, EventArgs e)
        {
            var pilotFilter = new Pilot(int.Parse(txtID.Text), null);
            var filterResult = db.QueryByExample(pilotFilter);
            var pilotObj = (Pilot)filterResult[0];
            pilotObj.Name = txtName.Text;
            pilotObj.Point = int.Parse(txtPoint.Text);

            db.Store(pilotObj);

            loadData();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var pilotFilter = new Pilot(int.Parse(txtID.Text), null);
            var filterResult = db.QueryByExample(pilotFilter);
            var pilotObj = (Pilot)filterResult[0];
            db.Delete(pilotFilter);

            loadData();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            var pilotFilter = new Pilot(0, txtName.Text);
            var filterResult = db.QueryByExample(pilotFilter);
            dgvPilot.DataSource = filterResult;
        }
    }
}
