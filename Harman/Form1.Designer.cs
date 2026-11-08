namespace Harman
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            lblTitle = new Label();
            lblIssueID = new Label();
            lblLocation = new Label();
            lblCategory = new Label();
            lblDescription = new Label();
            lblDateReported = new Label();
            lblPriority = new Label();
            lblStatus = new Label();
            lblReportedBy = new Label();
            lblSearchLocation = new Label();
            lblSearchCategory = new Label();
            lblSearchStatus = new Label();
            txtIssueID = new TextBox();
            txtLocation = new TextBox();
            txtDescription = new TextBox();
            txtReportedBy = new TextBox();
            txtSearchLocation = new TextBox();
            cboCategory = new ComboBox();
            cboPriority = new ComboBox();
            cboStatus = new ComboBox();
            cboSearchCategory = new ComboBox();
            cboSearchStatus = new ComboBox();
            dtpDateReported = new DateTimePicker();
            btnAdd = new Button();
            btnUpdate = new Button();
            btnDelete = new Button();
            btnClear = new Button();
            btnSearch = new Button();
            btnShowAll = new Button();
            dgvIssues = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dgvIssues).BeginInit();
            SuspendLayout();
            //
            // lblTitle
            //
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            lblTitle.Location = new Point(20, 15);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(360, 25);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "Campus Facilities Issue Register";
            //
            // lblIssueID
            //
            lblIssueID.AutoSize = true;
            lblIssueID.Location = new Point(24, 60);
            lblIssueID.Name = "lblIssueID";
            lblIssueID.Size = new Size(52, 15);
            lblIssueID.TabIndex = 1;
            lblIssueID.Text = "Issue ID";
            //
            // txtIssueID
            //
            txtIssueID.Location = new Point(120, 57);
            txtIssueID.Name = "txtIssueID";
            txtIssueID.ReadOnly = true;
            txtIssueID.Size = new Size(120, 23);
            txtIssueID.TabIndex = 2;
            //
            // lblLocation
            //
            lblLocation.AutoSize = true;
            lblLocation.Location = new Point(24, 95);
            lblLocation.Name = "lblLocation";
            lblLocation.Size = new Size(53, 15);
            lblLocation.TabIndex = 3;
            lblLocation.Text = "Location";
            //
            // txtLocation
            //
            txtLocation.Location = new Point(120, 92);
            txtLocation.Name = "txtLocation";
            txtLocation.Size = new Size(220, 23);
            txtLocation.TabIndex = 4;
            //
            // lblCategory
            //
            lblCategory.AutoSize = true;
            lblCategory.Location = new Point(24, 130);
            lblCategory.Name = "lblCategory";
            lblCategory.Size = new Size(55, 15);
            lblCategory.TabIndex = 5;
            lblCategory.Text = "Category";
            //
            // cboCategory
            //
            cboCategory.DropDownStyle = ComboBoxStyle.DropDownList;
            cboCategory.FormattingEnabled = true;
            cboCategory.Items.AddRange(new object[] { "Lighting", "Furniture", "Heating", "Maintenance", "Other" });
            cboCategory.Location = new Point(120, 127);
            cboCategory.Name = "cboCategory";
            cboCategory.Size = new Size(220, 23);
            cboCategory.TabIndex = 6;
            //
            // lblDescription
            //
            lblDescription.AutoSize = true;
            lblDescription.Location = new Point(24, 165);
            lblDescription.Name = "lblDescription";
            lblDescription.Size = new Size(69, 15);
            lblDescription.TabIndex = 7;
            lblDescription.Text = "Description";
            //
            // txtDescription
            //
            txtDescription.Location = new Point(120, 162);
            txtDescription.Multiline = true;
            txtDescription.Name = "txtDescription";
            txtDescription.Size = new Size(220, 55);
            txtDescription.TabIndex = 8;
            //
            // lblDateReported
            //
            lblDateReported.AutoSize = true;
            lblDateReported.Location = new Point(380, 60);
            lblDateReported.Name = "lblDateReported";
            lblDateReported.Size = new Size(82, 15);
            lblDateReported.TabIndex = 9;
            lblDateReported.Text = "Date Reported";
            //
            // dtpDateReported
            //
            dtpDateReported.Format = DateTimePickerFormat.Short;
            dtpDateReported.Location = new Point(480, 57);
            dtpDateReported.Name = "dtpDateReported";
            dtpDateReported.Size = new Size(150, 23);
            dtpDateReported.TabIndex = 10;
            //
            // lblPriority
            //
            lblPriority.AutoSize = true;
            lblPriority.Location = new Point(380, 95);
            lblPriority.Name = "lblPriority";
            lblPriority.Size = new Size(45, 15);
            lblPriority.TabIndex = 11;
            lblPriority.Text = "Priority";
            //
            // cboPriority
            //
            cboPriority.DropDownStyle = ComboBoxStyle.DropDownList;
            cboPriority.FormattingEnabled = true;
            cboPriority.Items.AddRange(new object[] { "Low", "Medium", "High" });
            cboPriority.Location = new Point(480, 92);
            cboPriority.Name = "cboPriority";
            cboPriority.Size = new Size(150, 23);
            cboPriority.TabIndex = 12;
            //
            // lblStatus
            //
            lblStatus.AutoSize = true;
            lblStatus.Location = new Point(380, 130);
            lblStatus.Name = "lblStatus";
            lblStatus.Size = new Size(39, 15);
            lblStatus.TabIndex = 13;
            lblStatus.Text = "Status";
            //
            // cboStatus
            //
            cboStatus.DropDownStyle = ComboBoxStyle.DropDownList;
            cboStatus.FormattingEnabled = true;
            cboStatus.Items.AddRange(new object[] { "Open", "In Progress", "Resolved" });
            cboStatus.Location = new Point(480, 127);
            cboStatus.Name = "cboStatus";
            cboStatus.Size = new Size(150, 23);
            cboStatus.TabIndex = 14;
            //
            // lblReportedBy
            //
            lblReportedBy.AutoSize = true;
            lblReportedBy.Location = new Point(380, 165);
            lblReportedBy.Name = "lblReportedBy";
            lblReportedBy.Size = new Size(73, 15);
            lblReportedBy.TabIndex = 15;
            lblReportedBy.Text = "Reported By";
            //
            // txtReportedBy
            //
            txtReportedBy.Location = new Point(480, 162);
            txtReportedBy.Name = "txtReportedBy";
            txtReportedBy.Size = new Size(150, 23);
            txtReportedBy.TabIndex = 16;
            //
            // btnAdd
            //
            btnAdd.Location = new Point(120, 235);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(90, 30);
            btnAdd.TabIndex = 17;
            btnAdd.Text = "Add";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            //
            // btnUpdate
            //
            btnUpdate.Location = new Point(220, 235);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(90, 30);
            btnUpdate.TabIndex = 18;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += btnUpdate_Click;
            //
            // btnDelete
            //
            btnDelete.Location = new Point(320, 235);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(90, 30);
            btnDelete.TabIndex = 19;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            //
            // btnClear
            //
            btnClear.Location = new Point(420, 235);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(90, 30);
            btnClear.TabIndex = 20;
            btnClear.Text = "Clear";
            btnClear.UseVisualStyleBackColor = true;
            btnClear.Click += btnClear_Click;
            //
            // lblSearchLocation
            //
            lblSearchLocation.AutoSize = true;
            lblSearchLocation.Location = new Point(24, 285);
            lblSearchLocation.Name = "lblSearchLocation";
            lblSearchLocation.Size = new Size(92, 15);
            lblSearchLocation.TabIndex = 21;
            lblSearchLocation.Text = "Search Location";
            //
            // txtSearchLocation
            //
            txtSearchLocation.Location = new Point(130, 282);
            txtSearchLocation.Name = "txtSearchLocation";
            txtSearchLocation.Size = new Size(150, 23);
            txtSearchLocation.TabIndex = 22;
            //
            // lblSearchCategory
            //
            lblSearchCategory.AutoSize = true;
            lblSearchCategory.Location = new Point(300, 285);
            lblSearchCategory.Name = "lblSearchCategory";
            lblSearchCategory.Size = new Size(53, 15);
            lblSearchCategory.TabIndex = 23;
            lblSearchCategory.Text = "Category";
            //
            // cboSearchCategory
            //
            cboSearchCategory.DropDownStyle = ComboBoxStyle.DropDownList;
            cboSearchCategory.FormattingEnabled = true;
            cboSearchCategory.Items.AddRange(new object[] { "All", "Lighting", "Furniture", "Heating", "Maintenance", "Other" });
            cboSearchCategory.Location = new Point(360, 282);
            cboSearchCategory.Name = "cboSearchCategory";
            cboSearchCategory.Size = new Size(120, 23);
            cboSearchCategory.TabIndex = 24;
            //
            // lblSearchStatus
            //
            lblSearchStatus.AutoSize = true;
            lblSearchStatus.Location = new Point(500, 285);
            lblSearchStatus.Name = "lblSearchStatus";
            lblSearchStatus.Size = new Size(39, 15);
            lblSearchStatus.TabIndex = 25;
            lblSearchStatus.Text = "Status";
            //
            // cboSearchStatus
            //
            cboSearchStatus.DropDownStyle = ComboBoxStyle.DropDownList;
            cboSearchStatus.FormattingEnabled = true;
            cboSearchStatus.Items.AddRange(new object[] { "All", "Open", "In Progress", "Resolved" });
            cboSearchStatus.Location = new Point(545, 282);
            cboSearchStatus.Name = "cboSearchStatus";
            cboSearchStatus.Size = new Size(120, 23);
            cboSearchStatus.TabIndex = 26;
            //
            // btnSearch
            //
            btnSearch.Location = new Point(680, 280);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(80, 28);
            btnSearch.TabIndex = 27;
            btnSearch.Text = "Search";
            btnSearch.UseVisualStyleBackColor = true;
            btnSearch.Click += btnSearch_Click;
            //
            // btnShowAll
            //
            btnShowAll.Location = new Point(770, 280);
            btnShowAll.Name = "btnShowAll";
            btnShowAll.Size = new Size(80, 28);
            btnShowAll.TabIndex = 28;
            btnShowAll.Text = "Show All";
            btnShowAll.UseVisualStyleBackColor = true;
            btnShowAll.Click += btnShowAll_Click;
            //
            // dgvIssues
            //
            dgvIssues.AllowUserToAddRows = false;
            dgvIssues.AllowUserToDeleteRows = false;
            dgvIssues.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvIssues.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvIssues.Location = new Point(24, 325);
            dgvIssues.MultiSelect = false;
            dgvIssues.Name = "dgvIssues";
            dgvIssues.ReadOnly = true;
            dgvIssues.RowHeadersWidth = 50;
            dgvIssues.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvIssues.Size = new Size(830, 250);
            dgvIssues.TabIndex = 29;
            dgvIssues.CellClick += dgvIssues_CellClick;
            //
            // Form1
            //
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(880, 600);
            Controls.Add(dgvIssues);
            Controls.Add(btnShowAll);
            Controls.Add(btnSearch);
            Controls.Add(cboSearchStatus);
            Controls.Add(lblSearchStatus);
            Controls.Add(cboSearchCategory);
            Controls.Add(lblSearchCategory);
            Controls.Add(txtSearchLocation);
            Controls.Add(lblSearchLocation);
            Controls.Add(btnClear);
            Controls.Add(btnDelete);
            Controls.Add(btnUpdate);
            Controls.Add(btnAdd);
            Controls.Add(txtReportedBy);
            Controls.Add(lblReportedBy);
            Controls.Add(cboStatus);
            Controls.Add(lblStatus);
            Controls.Add(cboPriority);
            Controls.Add(lblPriority);
            Controls.Add(dtpDateReported);
            Controls.Add(lblDateReported);
            Controls.Add(txtDescription);
            Controls.Add(lblDescription);
            Controls.Add(cboCategory);
            Controls.Add(lblCategory);
            Controls.Add(txtLocation);
            Controls.Add(lblLocation);
            Controls.Add(txtIssueID);
            Controls.Add(lblIssueID);
            Controls.Add(lblTitle);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Campus Facilities Issue Register";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dgvIssues).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTitle;
        private Label lblIssueID;
        private Label lblLocation;
        private Label lblCategory;
        private Label lblDescription;
        private Label lblDateReported;
        private Label lblPriority;
        private Label lblStatus;
        private Label lblReportedBy;
        private Label lblSearchLocation;
        private Label lblSearchCategory;
        private Label lblSearchStatus;
        private TextBox txtIssueID;
        private TextBox txtLocation;
        private TextBox txtDescription;
        private TextBox txtReportedBy;
        private TextBox txtSearchLocation;
        private ComboBox cboCategory;
        private ComboBox cboPriority;
        private ComboBox cboStatus;
        private ComboBox cboSearchCategory;
        private ComboBox cboSearchStatus;
        private DateTimePicker dtpDateReported;
        private Button btnAdd;
        private Button btnUpdate;
        private Button btnDelete;
        private Button btnClear;
        private Button btnSearch;
        private Button btnShowAll;
        private DataGridView dgvIssues;
    }
}
