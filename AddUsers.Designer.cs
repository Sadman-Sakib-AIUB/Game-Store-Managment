namespace GameStoreManagement
{
    partial class AddUsers
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnRemove = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.rtxtAddressAdd = new System.Windows.Forms.RichTextBox();
            this.lblAddressAdd = new System.Windows.Forms.Label();
            this.cmbRoleAdd = new System.Windows.Forms.ComboBox();
            this.txtPhoneNumAdd = new System.Windows.Forms.TextBox();
            this.lblPhoneNumAdd = new System.Windows.Forms.Label();
            this.lblRoleAdd = new System.Windows.Forms.Label();
            this.txtPasswordAdd = new System.Windows.Forms.TextBox();
            this.lblPasswordAdd = new System.Windows.Forms.Label();
            this.txtUserIdAdd = new System.Windows.Forms.TextBox();
            this.lblUserIdAdd = new System.Windows.Forms.Label();
            this.txtUserNameAdd = new System.Windows.Forms.TextBox();
            this.lblUserNameAdd = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.lblSearch = new System.Windows.Forms.Label();
            this.lblAllUsersData = new System.Windows.Forms.Label();
            this.dgvUserData = new System.Windows.Forms.DataGridView();
            this.UserId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UserName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Password = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Role = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Address = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PhoneNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUserData)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.btnClear);
            this.panel1.Controls.Add(this.btnRemove);
            this.panel1.Controls.Add(this.btnUpdate);
            this.panel1.Controls.Add(this.btnAdd);
            this.panel1.Controls.Add(this.rtxtAddressAdd);
            this.panel1.Controls.Add(this.lblAddressAdd);
            this.panel1.Controls.Add(this.cmbRoleAdd);
            this.panel1.Controls.Add(this.txtPhoneNumAdd);
            this.panel1.Controls.Add(this.lblPhoneNumAdd);
            this.panel1.Controls.Add(this.lblRoleAdd);
            this.panel1.Controls.Add(this.txtPasswordAdd);
            this.panel1.Controls.Add(this.lblPasswordAdd);
            this.panel1.Controls.Add(this.txtUserIdAdd);
            this.panel1.Controls.Add(this.lblUserIdAdd);
            this.panel1.Controls.Add(this.txtUserNameAdd);
            this.panel1.Controls.Add(this.lblUserNameAdd);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(280, 582);
            this.panel1.TabIndex = 0;
            // 
            // btnClear
            // 
            this.btnClear.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(134)))), ((int)(((byte)(156)))));
            this.btnClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClear.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.ForeColor = System.Drawing.Color.White;
            this.btnClear.Location = new System.Drawing.Point(151, 513);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(108, 36);
            this.btnClear.TabIndex = 16;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = false;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnRemove
            // 
            this.btnRemove.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(134)))), ((int)(((byte)(156)))));
            this.btnRemove.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRemove.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRemove.ForeColor = System.Drawing.Color.White;
            this.btnRemove.Location = new System.Drawing.Point(18, 513);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(110, 36);
            this.btnRemove.TabIndex = 15;
            this.btnRemove.Text = "Remove";
            this.btnRemove.UseVisualStyleBackColor = false;
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(134)))), ((int)(((byte)(156)))));
            this.btnUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdate.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdate.ForeColor = System.Drawing.Color.White;
            this.btnUpdate.Location = new System.Drawing.Point(151, 457);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(108, 36);
            this.btnUpdate.TabIndex = 14;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = false;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(134)))), ((int)(((byte)(156)))));
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdd.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.ForeColor = System.Drawing.Color.White;
            this.btnAdd.Location = new System.Drawing.Point(18, 457);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(115, 36);
            this.btnAdd.TabIndex = 13;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // rtxtAddressAdd
            // 
            this.rtxtAddressAdd.Location = new System.Drawing.Point(18, 354);
            this.rtxtAddressAdd.Name = "rtxtAddressAdd";
            this.rtxtAddressAdd.Size = new System.Drawing.Size(218, 64);
            this.rtxtAddressAdd.TabIndex = 12;
            this.rtxtAddressAdd.Text = "";
            // 
            // lblAddressAdd
            // 
            this.lblAddressAdd.AutoSize = true;
            this.lblAddressAdd.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAddressAdd.Location = new System.Drawing.Point(14, 331);
            this.lblAddressAdd.Name = "lblAddressAdd";
            this.lblAddressAdd.Size = new System.Drawing.Size(69, 20);
            this.lblAddressAdd.TabIndex = 11;
            this.lblAddressAdd.Text = "Address";
            // 
            // cmbRoleAdd
            // 
            this.cmbRoleAdd.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbRoleAdd.FormattingEnabled = true;
            this.cmbRoleAdd.Items.AddRange(new object[] {
            "Admin",
            "Salesman"});
            this.cmbRoleAdd.Location = new System.Drawing.Point(18, 225);
            this.cmbRoleAdd.Name = "cmbRoleAdd";
            this.cmbRoleAdd.Size = new System.Drawing.Size(226, 28);
            this.cmbRoleAdd.TabIndex = 10;
            // 
            // txtPhoneNumAdd
            // 
            this.txtPhoneNumAdd.Font = new System.Drawing.Font("Microsoft YaHei UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPhoneNumAdd.Location = new System.Drawing.Point(18, 292);
            this.txtPhoneNumAdd.Name = "txtPhoneNumAdd";
            this.txtPhoneNumAdd.Size = new System.Drawing.Size(226, 24);
            this.txtPhoneNumAdd.TabIndex = 9;
            // 
            // lblPhoneNumAdd
            // 
            this.lblPhoneNumAdd.AutoSize = true;
            this.lblPhoneNumAdd.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPhoneNumAdd.Location = new System.Drawing.Point(14, 269);
            this.lblPhoneNumAdd.Name = "lblPhoneNumAdd";
            this.lblPhoneNumAdd.Size = new System.Drawing.Size(119, 20);
            this.lblPhoneNumAdd.TabIndex = 8;
            this.lblPhoneNumAdd.Text = "Phone Number";
            // 
            // lblRoleAdd
            // 
            this.lblRoleAdd.AutoSize = true;
            this.lblRoleAdd.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRoleAdd.Location = new System.Drawing.Point(14, 202);
            this.lblRoleAdd.Name = "lblRoleAdd";
            this.lblRoleAdd.Size = new System.Drawing.Size(42, 20);
            this.lblRoleAdd.TabIndex = 6;
            this.lblRoleAdd.Text = "Role";
            // 
            // txtPasswordAdd
            // 
            this.txtPasswordAdd.Font = new System.Drawing.Font("Microsoft YaHei UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPasswordAdd.Location = new System.Drawing.Point(18, 162);
            this.txtPasswordAdd.Name = "txtPasswordAdd";
            this.txtPasswordAdd.Size = new System.Drawing.Size(226, 24);
            this.txtPasswordAdd.TabIndex = 5;
            // 
            // lblPasswordAdd
            // 
            this.lblPasswordAdd.AutoSize = true;
            this.lblPasswordAdd.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPasswordAdd.Location = new System.Drawing.Point(14, 139);
            this.lblPasswordAdd.Name = "lblPasswordAdd";
            this.lblPasswordAdd.Size = new System.Drawing.Size(78, 20);
            this.lblPasswordAdd.TabIndex = 4;
            this.lblPasswordAdd.Text = "Password";
            // 
            // txtUserIdAdd
            // 
            this.txtUserIdAdd.Font = new System.Drawing.Font("Microsoft YaHei UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUserIdAdd.Location = new System.Drawing.Point(18, 101);
            this.txtUserIdAdd.Name = "txtUserIdAdd";
            this.txtUserIdAdd.ReadOnly = true;
            this.txtUserIdAdd.Size = new System.Drawing.Size(226, 24);
            this.txtUserIdAdd.TabIndex = 3;
            // 
            // lblUserIdAdd
            // 
            this.lblUserIdAdd.AutoSize = true;
            this.lblUserIdAdd.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUserIdAdd.Location = new System.Drawing.Point(14, 78);
            this.lblUserIdAdd.Name = "lblUserIdAdd";
            this.lblUserIdAdd.Size = new System.Drawing.Size(61, 20);
            this.lblUserIdAdd.TabIndex = 2;
            this.lblUserIdAdd.Text = "User ID";
            // 
            // txtUserNameAdd
            // 
            this.txtUserNameAdd.Font = new System.Drawing.Font("Microsoft YaHei UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUserNameAdd.Location = new System.Drawing.Point(18, 40);
            this.txtUserNameAdd.Name = "txtUserNameAdd";
            this.txtUserNameAdd.Size = new System.Drawing.Size(226, 24);
            this.txtUserNameAdd.TabIndex = 1;
            // 
            // lblUserNameAdd
            // 
            this.lblUserNameAdd.AutoSize = true;
            this.lblUserNameAdd.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUserNameAdd.Location = new System.Drawing.Point(14, 17);
            this.lblUserNameAdd.Name = "lblUserNameAdd";
            this.lblUserNameAdd.Size = new System.Drawing.Size(82, 20);
            this.lblUserNameAdd.TabIndex = 0;
            this.lblUserNameAdd.Text = "Username";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.txtSearch);
            this.panel2.Controls.Add(this.lblSearch);
            this.panel2.Controls.Add(this.lblAllUsersData);
            this.panel2.Controls.Add(this.dgvUserData);
            this.panel2.Location = new System.Drawing.Point(301, 3);
            this.panel2.Name = "panel2";
            this.panel2.Padding = new System.Windows.Forms.Padding(0, 45, 15, 15);
            this.panel2.Size = new System.Drawing.Size(885, 575);
            this.panel2.TabIndex = 1;
            // 
            // txtSearch
            // 
            this.txtSearch.Font = new System.Drawing.Font("Microsoft YaHei UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearch.Location = new System.Drawing.Point(637, 11);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(226, 24);
            this.txtSearch.TabIndex = 17;
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
            // 
            // lblSearch
            // 
            this.lblSearch.AutoSize = true;
            this.lblSearch.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSearch.Location = new System.Drawing.Point(531, 15);
            this.lblSearch.Name = "lblSearch";
            this.lblSearch.Size = new System.Drawing.Size(102, 17);
            this.lblSearch.TabIndex = 18;
            this.lblSearch.Text = "Search by ID";
            // 
            // lblAllUsersData
            // 
            this.lblAllUsersData.AutoSize = true;
            this.lblAllUsersData.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAllUsersData.Location = new System.Drawing.Point(13, 15);
            this.lblAllUsersData.Name = "lblAllUsersData";
            this.lblAllUsersData.Size = new System.Drawing.Size(112, 17);
            this.lblAllUsersData.TabIndex = 17;
            this.lblAllUsersData.Text = "All Users Data";
            // 
            // dgvUserData
            // 
            this.dgvUserData.AllowUserToAddRows = false;
            this.dgvUserData.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.MediumSpringGreen;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvUserData.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvUserData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvUserData.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.UserId,
            this.UserName,
            this.Password,
            this.Role,
            this.Address,
            this.PhoneNumber});
            this.dgvUserData.Dock = System.Windows.Forms.DockStyle.Right;
            this.dgvUserData.EnableHeadersVisualStyles = false;
            this.dgvUserData.Location = new System.Drawing.Point(16, 45);
            this.dgvUserData.Name = "dgvUserData";
            this.dgvUserData.ReadOnly = true;
            this.dgvUserData.RowHeadersWidth = 51;
            this.dgvUserData.RowTemplate.Height = 24;
            this.dgvUserData.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvUserData.Size = new System.Drawing.Size(854, 515);
            this.dgvUserData.TabIndex = 0;
            this.dgvUserData.DoubleClick += new System.EventHandler(this.dgvUserData_DoubleClick);
            // 
            // UserId
            // 
            this.UserId.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.UserId.DataPropertyName = "UserId";
            this.UserId.HeaderText = "User ID";
            this.UserId.MinimumWidth = 6;
            this.UserId.Name = "UserId";
            this.UserId.ReadOnly = true;
            // 
            // UserName
            // 
            this.UserName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.UserName.DataPropertyName = "UserName";
            this.UserName.HeaderText = "User Name";
            this.UserName.MinimumWidth = 6;
            this.UserName.Name = "UserName";
            this.UserName.ReadOnly = true;
            // 
            // Password
            // 
            this.Password.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Password.DataPropertyName = "Password";
            this.Password.HeaderText = "Password";
            this.Password.MinimumWidth = 6;
            this.Password.Name = "Password";
            this.Password.ReadOnly = true;
            // 
            // Role
            // 
            this.Role.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Role.DataPropertyName = "Role";
            this.Role.HeaderText = "Role";
            this.Role.MinimumWidth = 6;
            this.Role.Name = "Role";
            this.Role.ReadOnly = true;
            // 
            // Address
            // 
            this.Address.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Address.DataPropertyName = "Address";
            this.Address.HeaderText = "Address";
            this.Address.MinimumWidth = 6;
            this.Address.Name = "Address";
            this.Address.ReadOnly = true;
            // 
            // PhoneNumber
            // 
            this.PhoneNumber.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.PhoneNumber.DataPropertyName = "PhoneNumber";
            this.PhoneNumber.HeaderText = "Phone Number";
            this.PhoneNumber.MinimumWidth = 6;
            this.PhoneNumber.Name = "PhoneNumber";
            this.PhoneNumber.ReadOnly = true;
            // 
            // AddUsers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "AddUsers";
            this.Size = new System.Drawing.Size(1189, 582);
            this.Load += new System.EventHandler(this.AddUsers_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUserData)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lblUserNameAdd;
        private System.Windows.Forms.TextBox txtPhoneNumAdd;
        private System.Windows.Forms.Label lblPhoneNumAdd;
        private System.Windows.Forms.Label lblRoleAdd;
        private System.Windows.Forms.TextBox txtPasswordAdd;
        private System.Windows.Forms.Label lblPasswordAdd;
        private System.Windows.Forms.TextBox txtUserIdAdd;
        private System.Windows.Forms.Label lblUserIdAdd;
        private System.Windows.Forms.TextBox txtUserNameAdd;
        private System.Windows.Forms.ComboBox cmbRoleAdd;
        private System.Windows.Forms.RichTextBox rtxtAddressAdd;
        private System.Windows.Forms.Label lblAddressAdd;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnRemove;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Label lblAllUsersData;
        private System.Windows.Forms.DataGridView dgvUserData;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Label lblSearch;
        private System.Windows.Forms.DataGridViewTextBoxColumn UserId;
        private System.Windows.Forms.DataGridViewTextBoxColumn UserName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Password;
        private System.Windows.Forms.DataGridViewTextBoxColumn Role;
        private System.Windows.Forms.DataGridViewTextBoxColumn Address;
        private System.Windows.Forms.DataGridViewTextBoxColumn PhoneNumber;
    }
}
