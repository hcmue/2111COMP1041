using Db4objects.Db4o;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace DemoDB4O
{
    public partial class frmMain : Form
    {
        IObjectContainer db = null;
        public frmMain()
        {
            InitializeComponent();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            db = Db4oFactory.OpenFile("PilotDb.db");
            LoadAllData();
        }

        private void frmMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            db.Close();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            // Step 0: check validation

            // Step 1: New object
            var pilot = new Pilot()
            {
                Id = Guid.NewGuid().ToString(),
                Name = txtName.Text,
                Point = double.Parse(txtPoint.Text)
            };

            // Step 2: Store DB
            db.Store(pilot);

            // Step 3: Load all data
            LoadAllData();
        }

        private void LoadAllData()
        {
            var filterObj = new Pilot();
            var result = db.QueryByExample(filterObj);
            dgvPilot.DataSource = result;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            LoadAllData();
        }

        private void dgvPilot_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txtId.Text = dgvPilot.Rows[e.RowIndex].Cells[0].Value.ToString();
            txtName.Text = dgvPilot.Rows[e.RowIndex].Cells[1].Value.ToString();
            txtPoint.Text = dgvPilot.Rows[e.RowIndex].Cells[2].Value.ToString();
        }

        private void dgvPilot_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtId.Text = dgvPilot.Rows[e.RowIndex].Cells[0].Value.ToString();
            txtName.Text = dgvPilot.Rows[e.RowIndex].Cells[1].Value.ToString();
            txtPoint.Text = dgvPilot.Rows[e.RowIndex].Cells[2].Value.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var filterObj = new Pilot(txtId.Text);
            var result = (Pilot) db.QueryByExample(filterObj)[0];
            result.Name = txtName.Text;
            result.Point = double.Parse(txtPoint.Text);

            db.Store(result);

            LoadAllData();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            var filterObj = new Pilot(txtId.Text);
            var result = (Pilot)db.QueryByExample(filterObj)[0];
            db.Delete(result);

            LoadAllData();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            //Filter by name
            IList<Pilot> result = db.Query(delegate (Pilot pilot) {
                return pilot.Name.ToLower().Contains(txtName.Text.ToLower());
            });
            dgvPilot.DataSource = result.ToList();
        }
    }
}
