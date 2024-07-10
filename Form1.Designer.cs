namespace EmployeeApp
{
    partial class frmEployeeApp
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lstEmployeeList = new System.Windows.Forms.ListBox();
            this.btnCount = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.lblEmployeeID = new System.Windows.Forms.Label();
            this.lblEmployeeName = new System.Windows.Forms.Label();
            this.lblEmployeeSalary = new System.Windows.Forms.Label();
            this.lblCount = new System.Windows.Forms.Label();
            this.lblTotal = new System.Windows.Forms.Label();
            this.tbxEmployeeID = new System.Windows.Forms.TextBox();
            this.tbxEmployeeName = new System.Windows.Forms.TextBox();
            this.tbxEmployeeSalary = new System.Windows.Forms.TextBox();
            this.btnTotal = new System.Windows.Forms.Button();
            this.btnLoadFromTextFile = new System.Windows.Forms.Button();
            this.btnSaveToTextFile = new System.Windows.Forms.Button();
            this.btnSaveToBinary = new System.Windows.Forms.Button();
            this.btnLoadFromBinaryFile = new System.Windows.Forms.Button();
            this.btnSearchByName = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lstEmployeeList
            // 
            this.lstEmployeeList.FormattingEnabled = true;
            this.lstEmployeeList.Location = new System.Drawing.Point(207, 118);
            this.lstEmployeeList.Name = "lstEmployeeList";
            this.lstEmployeeList.Size = new System.Drawing.Size(395, 147);
            this.lstEmployeeList.TabIndex = 0;
            // 
            // btnCount
            // 
            this.btnCount.Location = new System.Drawing.Point(608, 205);
            this.btnCount.Name = "btnCount";
            this.btnCount.Size = new System.Drawing.Size(75, 23);
            this.btnCount.TabIndex = 1;
            this.btnCount.Text = "Count";
            this.btnCount.UseVisualStyleBackColor = true;
            this.btnCount.Click += new System.EventHandler(this.btnCount_Click);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(115, 342);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(75, 40);
            this.btnClear.TabIndex = 2;
            this.btnClear.Text = "Clear All";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(17, 342);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 40);
            this.btnAdd.TabIndex = 3;
            this.btnAdd.Text = "Add To List";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // lblEmployeeID
            // 
            this.lblEmployeeID.AutoSize = true;
            this.lblEmployeeID.Location = new System.Drawing.Point(27, 131);
            this.lblEmployeeID.Name = "lblEmployeeID";
            this.lblEmployeeID.Size = new System.Drawing.Size(67, 13);
            this.lblEmployeeID.TabIndex = 4;
            this.lblEmployeeID.Text = "Employee ID";
            this.lblEmployeeID.Click += new System.EventHandler(this.label1_Click);
            // 
            // lblEmployeeName
            // 
            this.lblEmployeeName.AutoSize = true;
            this.lblEmployeeName.Location = new System.Drawing.Point(9, 181);
            this.lblEmployeeName.Name = "lblEmployeeName";
            this.lblEmployeeName.Size = new System.Drawing.Size(84, 13);
            this.lblEmployeeName.TabIndex = 5;
            this.lblEmployeeName.Text = "Employee Name";
            // 
            // lblEmployeeSalary
            // 
            this.lblEmployeeSalary.AutoSize = true;
            this.lblEmployeeSalary.Location = new System.Drawing.Point(9, 228);
            this.lblEmployeeSalary.Name = "lblEmployeeSalary";
            this.lblEmployeeSalary.Size = new System.Drawing.Size(85, 13);
            this.lblEmployeeSalary.TabIndex = 6;
            this.lblEmployeeSalary.Text = "Employee Salary";
            // 
            // lblCount
            // 
            this.lblCount.AutoSize = true;
            this.lblCount.Location = new System.Drawing.Point(706, 210);
            this.lblCount.Name = "lblCount";
            this.lblCount.Size = new System.Drawing.Size(0, 13);
            this.lblCount.TabIndex = 7;
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Location = new System.Drawing.Point(705, 139);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(0, 13);
            this.lblTotal.TabIndex = 8;
            // 
            // tbxEmployeeID
            // 
            this.tbxEmployeeID.Location = new System.Drawing.Point(101, 131);
            this.tbxEmployeeID.Name = "tbxEmployeeID";
            this.tbxEmployeeID.Size = new System.Drawing.Size(100, 20);
            this.tbxEmployeeID.TabIndex = 9;
            // 
            // tbxEmployeeName
            // 
            this.tbxEmployeeName.Location = new System.Drawing.Point(101, 181);
            this.tbxEmployeeName.Name = "tbxEmployeeName";
            this.tbxEmployeeName.Size = new System.Drawing.Size(100, 20);
            this.tbxEmployeeName.TabIndex = 10;
            // 
            // tbxEmployeeSalary
            // 
            this.tbxEmployeeSalary.Location = new System.Drawing.Point(101, 228);
            this.tbxEmployeeSalary.Name = "tbxEmployeeSalary";
            this.tbxEmployeeSalary.Size = new System.Drawing.Size(100, 20);
            this.tbxEmployeeSalary.TabIndex = 11;
            // 
            // btnTotal
            // 
            this.btnTotal.Location = new System.Drawing.Point(608, 134);
            this.btnTotal.Name = "btnTotal";
            this.btnTotal.Size = new System.Drawing.Size(75, 23);
            this.btnTotal.TabIndex = 12;
            this.btnTotal.Text = "Total";
            this.btnTotal.UseVisualStyleBackColor = true;
            this.btnTotal.Click += new System.EventHandler(this.btnTotal_Click);
            // 
            // btnLoadFromTextFile
            // 
            this.btnLoadFromTextFile.Location = new System.Drawing.Point(318, 342);
            this.btnLoadFromTextFile.Name = "btnLoadFromTextFile";
            this.btnLoadFromTextFile.Size = new System.Drawing.Size(75, 40);
            this.btnLoadFromTextFile.TabIndex = 14;
            this.btnLoadFromTextFile.Text = "Load From Text File";
            this.btnLoadFromTextFile.UseVisualStyleBackColor = true;
            this.btnLoadFromTextFile.Click += new System.EventHandler(this.btnLoadFromTextFile_Click);
            // 
            // btnSaveToTextFile
            // 
            this.btnSaveToTextFile.Location = new System.Drawing.Point(218, 342);
            this.btnSaveToTextFile.Name = "btnSaveToTextFile";
            this.btnSaveToTextFile.Size = new System.Drawing.Size(75, 40);
            this.btnSaveToTextFile.TabIndex = 15;
            this.btnSaveToTextFile.Text = "Save To Text File";
            this.btnSaveToTextFile.UseVisualStyleBackColor = true;
            this.btnSaveToTextFile.Click += new System.EventHandler(this.btnSaveToTextFile_Click);
            // 
            // btnSaveToBinary
            // 
            this.btnSaveToBinary.Location = new System.Drawing.Point(427, 342);
            this.btnSaveToBinary.Name = "btnSaveToBinary";
            this.btnSaveToBinary.Size = new System.Drawing.Size(75, 40);
            this.btnSaveToBinary.TabIndex = 16;
            this.btnSaveToBinary.Text = "Save to Binary File";
            this.btnSaveToBinary.UseVisualStyleBackColor = true;
            this.btnSaveToBinary.Click += new System.EventHandler(this.btnSaveToBinary_Click);
            // 
            // btnLoadFromBinaryFile
            // 
            this.btnLoadFromBinaryFile.Location = new System.Drawing.Point(543, 342);
            this.btnLoadFromBinaryFile.Name = "btnLoadFromBinaryFile";
            this.btnLoadFromBinaryFile.Size = new System.Drawing.Size(75, 40);
            this.btnLoadFromBinaryFile.TabIndex = 17;
            this.btnLoadFromBinaryFile.Text = "Load From Binary  File";
            this.btnLoadFromBinaryFile.UseVisualStyleBackColor = true;
            this.btnLoadFromBinaryFile.Click += new System.EventHandler(this.btnLoadFromBinaryFile_Click);
            // 
            // btnSearchByName
            // 
            this.btnSearchByName.Location = new System.Drawing.Point(663, 342);
            this.btnSearchByName.Name = "btnSearchByName";
            this.btnSearchByName.Size = new System.Drawing.Size(75, 40);
            this.btnSearchByName.TabIndex = 18;
            this.btnSearchByName.Text = "Search by Name";
            this.btnSearchByName.UseVisualStyleBackColor = true;
            this.btnSearchByName.Click += new System.EventHandler(this.button1_Click);
            // 
            // frmEployeeApp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(808, 443);
            this.Controls.Add(this.btnSearchByName);
            this.Controls.Add(this.btnLoadFromBinaryFile);
            this.Controls.Add(this.btnSaveToBinary);
            this.Controls.Add(this.btnSaveToTextFile);
            this.Controls.Add(this.btnLoadFromTextFile);
            this.Controls.Add(this.btnTotal);
            this.Controls.Add(this.tbxEmployeeSalary);
            this.Controls.Add(this.tbxEmployeeName);
            this.Controls.Add(this.tbxEmployeeID);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.lblCount);
            this.Controls.Add(this.lblEmployeeSalary);
            this.Controls.Add(this.lblEmployeeName);
            this.Controls.Add(this.lblEmployeeID);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnCount);
            this.Controls.Add(this.lstEmployeeList);
            this.Name = "frmEployeeApp";
            this.Text = "EmployeeApp";
            this.Load += new System.EventHandler(this.frmEployeeApp_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lstEmployeeList;
        private System.Windows.Forms.Button btnCount;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Label lblEmployeeID;
        private System.Windows.Forms.Label lblEmployeeName;
        private System.Windows.Forms.Label lblEmployeeSalary;
        private System.Windows.Forms.Label lblCount;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.TextBox tbxEmployeeID;
        private System.Windows.Forms.TextBox tbxEmployeeName;
        private System.Windows.Forms.TextBox tbxEmployeeSalary;
        private System.Windows.Forms.Button btnTotal;
        private System.Windows.Forms.Button btnLoadFromTextFile;
        private System.Windows.Forms.Button btnSaveToTextFile;
        private System.Windows.Forms.Button btnSaveToBinary;
        private System.Windows.Forms.Button btnLoadFromBinaryFile;
        private System.Windows.Forms.Button btnSearchByName;
    }
}

