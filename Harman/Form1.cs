using System;
using System.Windows.Forms;

namespace Harman
{
    public partial class Form1 : Form
    {
        private IssueDatabase issueDatabase;

        public Form1()
        {
            InitializeComponent();
            issueDatabase = new IssueDatabase();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            cboCategory.SelectedIndex = 0;
            cboPriority.SelectedIndex = 1;
            cboStatus.SelectedIndex = 0;
            cboSearchCategory.SelectedIndex = 0;
            cboSearchStatus.SelectedIndex = 0;
            dtpDateReported.Value = DateTime.Today;
            LoadIssues();
        }

        private void LoadIssues()
        {
            try
            {
                dgvIssues.DataSource = issueDatabase.GetAllIssues();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Could not load issues from the database.\n" + ex.Message, "Database Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private FacilitiesIssue GetIssueFromForm()
        {
            FacilitiesIssue issue = new FacilitiesIssue();

            if (!string.IsNullOrWhiteSpace(txtIssueID.Text))
            {
                issue.IssueID = int.Parse(txtIssueID.Text);
            }

            issue.Location = txtLocation.Text.Trim();
            issue.IssueCategory = cboCategory.Text;
            issue.Description = txtDescription.Text.Trim();
            issue.DateReported = dtpDateReported.Value.Date;
            issue.Priority = cboPriority.Text;
            issue.Status = cboStatus.Text;
            issue.ReportedBy = txtReportedBy.Text.Trim();

            return issue;
        }

        private void ClearForm()
        {
            txtIssueID.Clear();
            txtLocation.Clear();
            txtDescription.Clear();
            txtReportedBy.Clear();
            cboCategory.SelectedIndex = 0;
            cboPriority.SelectedIndex = 1;
            cboStatus.SelectedIndex = 0;
            dtpDateReported.Value = DateTime.Today;
            dgvIssues.ClearSelection();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            FacilitiesIssue issue = GetIssueFromForm();
            string validationMessage = issue.Validate();

            if (validationMessage != string.Empty)
            {
                MessageBox.Show(validationMessage, "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                issueDatabase.AddIssue(issue);
                MessageBox.Show("Issue added successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ClearForm();
                LoadIssues();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Could not add the issue.\n" + ex.Message, "Database Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtIssueID.Text))
            {
                MessageBox.Show("Please select an issue from the list to update.", "Update",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            FacilitiesIssue issue = GetIssueFromForm();
            string validationMessage = issue.Validate();

            if (validationMessage != string.Empty)
            {
                MessageBox.Show(validationMessage, "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                issueDatabase.UpdateIssue(issue);
                MessageBox.Show("Issue updated successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ClearForm();
                LoadIssues();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Could not update the issue.\n" + ex.Message, "Database Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtIssueID.Text))
            {
                MessageBox.Show("Please select an issue from the list to delete.", "Delete",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DialogResult result = MessageBox.Show("Are you sure you want to delete this issue?", "Confirm Delete",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result != DialogResult.Yes)
            {
                return;
            }

            try
            {
                int issueID = int.Parse(txtIssueID.Text);
                issueDatabase.DeleteIssue(issueID);
                MessageBox.Show("Issue deleted successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ClearForm();
                LoadIssues();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Could not delete the issue.\n" + ex.Message, "Database Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearForm();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            try
            {
                dgvIssues.DataSource = issueDatabase.SearchIssues(
                    txtSearchLocation.Text,
                    cboSearchCategory.Text,
                    cboSearchStatus.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Could not search issues.\n" + ex.Message, "Database Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnShowAll_Click(object sender, EventArgs e)
        {
            txtSearchLocation.Clear();
            cboSearchCategory.SelectedIndex = 0;
            cboSearchStatus.SelectedIndex = 0;
            LoadIssues();
        }

        private void dgvIssues_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
            {
                return;
            }

            DataGridViewRow row = dgvIssues.Rows[e.RowIndex];

            txtIssueID.Text = Convert.ToString(row.Cells["IssueID"].Value);
            txtLocation.Text = Convert.ToString(row.Cells["Location"].Value);
            cboCategory.Text = Convert.ToString(row.Cells["IssueCategory"].Value);
            txtDescription.Text = Convert.ToString(row.Cells["Description"].Value);
            dtpDateReported.Value = Convert.ToDateTime(row.Cells["DateReported"].Value);
            cboPriority.Text = Convert.ToString(row.Cells["Priority"].Value);
            cboStatus.Text = Convert.ToString(row.Cells["Status"].Value);
            txtReportedBy.Text = Convert.ToString(row.Cells["ReportedBy"].Value);
        }
    }
}
