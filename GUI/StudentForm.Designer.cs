namespace Lab3.GUI
{
    partial class StudentForm
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
            this.buttonClose = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.buttonUpdateDB = new System.Windows.Forms.Button();
            this.buttonDelete = new System.Windows.Forms.Button();
            this.buttonModify = new System.Windows.Forms.Button();
            this.buttonSearch = new System.Windows.Forms.Button();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.textBoxEmail = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxLastName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxFirstName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxStudentId = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonListStudentFromDB = new System.Windows.Forms.Button();
            this.dataGridViewStudent = new System.Windows.Forms.DataGridView();
            this.dataGridViewStudentFromDS = new System.Windows.Forms.DataGridView();
            this.buttonListStudentFromDS = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewStudent)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewStudentFromDS)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonClose
            // 
            this.buttonClose.Location = new System.Drawing.Point(764, 441);
            this.buttonClose.Name = "buttonClose";
            this.buttonClose.Size = new System.Drawing.Size(119, 42);
            this.buttonClose.TabIndex = 0;
            this.buttonClose.Text = "&Close";
            this.buttonClose.UseVisualStyleBackColor = true;
            this.buttonClose.Click += new System.EventHandler(this.buttonClose_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.buttonUpdateDB);
            this.groupBox1.Controls.Add(this.buttonDelete);
            this.groupBox1.Controls.Add(this.buttonModify);
            this.groupBox1.Controls.Add(this.buttonSearch);
            this.groupBox1.Controls.Add(this.buttonAdd);
            this.groupBox1.Controls.Add(this.textBoxEmail);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.textBoxLastName);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.textBoxFirstName);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.textBoxStudentId);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(24, 22);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(868, 166);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Student Information";
            // 
            // buttonUpdateDB
            // 
            this.buttonUpdateDB.Location = new System.Drawing.Point(693, 88);
            this.buttonUpdateDB.Name = "buttonUpdateDB";
            this.buttonUpdateDB.Size = new System.Drawing.Size(153, 38);
            this.buttonUpdateDB.TabIndex = 12;
            this.buttonUpdateDB.Text = "&Update Database";
            this.buttonUpdateDB.UseVisualStyleBackColor = true;
            this.buttonUpdateDB.Click += new System.EventHandler(this.buttonUpdateDB_Click);
            // 
            // buttonDelete
            // 
            this.buttonDelete.Location = new System.Drawing.Point(536, 88);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(125, 38);
            this.buttonDelete.TabIndex = 11;
            this.buttonDelete.Text = "&Delete";
            this.buttonDelete.UseVisualStyleBackColor = true;
            this.buttonDelete.Click += new System.EventHandler(this.buttonDelete_Click);
            // 
            // buttonModify
            // 
            this.buttonModify.Location = new System.Drawing.Point(369, 88);
            this.buttonModify.Name = "buttonModify";
            this.buttonModify.Size = new System.Drawing.Size(125, 38);
            this.buttonModify.TabIndex = 10;
            this.buttonModify.Text = "&Modify";
            this.buttonModify.UseVisualStyleBackColor = true;
            this.buttonModify.Click += new System.EventHandler(this.buttonModify_Click);
            // 
            // buttonSearch
            // 
            this.buttonSearch.Location = new System.Drawing.Point(196, 88);
            this.buttonSearch.Name = "buttonSearch";
            this.buttonSearch.Size = new System.Drawing.Size(125, 38);
            this.buttonSearch.TabIndex = 9;
            this.buttonSearch.Text = "&Search";
            this.buttonSearch.UseVisualStyleBackColor = true;
            this.buttonSearch.Click += new System.EventHandler(this.buttonSearch_Click);
            // 
            // buttonAdd
            // 
            this.buttonAdd.Location = new System.Drawing.Point(39, 88);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(125, 38);
            this.buttonAdd.TabIndex = 8;
            this.buttonAdd.Text = "&Add";
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // textBoxEmail
            // 
            this.textBoxEmail.Location = new System.Drawing.Point(536, 50);
            this.textBoxEmail.Name = "textBoxEmail";
            this.textBoxEmail.Size = new System.Drawing.Size(209, 20);
            this.textBoxEmail.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(533, 33);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(32, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Email";
            // 
            // textBoxLastName
            // 
            this.textBoxLastName.Location = new System.Drawing.Point(369, 50);
            this.textBoxLastName.Name = "textBoxLastName";
            this.textBoxLastName.Size = new System.Drawing.Size(130, 20);
            this.textBoxLastName.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(366, 33);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Last Name";
            // 
            // textBoxFirstName
            // 
            this.textBoxFirstName.Location = new System.Drawing.Point(196, 50);
            this.textBoxFirstName.Name = "textBoxFirstName";
            this.textBoxFirstName.Size = new System.Drawing.Size(125, 20);
            this.textBoxFirstName.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(193, 33);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "First Name";
            // 
            // textBoxStudentId
            // 
            this.textBoxStudentId.Location = new System.Drawing.Point(39, 50);
            this.textBoxStudentId.Name = "textBoxStudentId";
            this.textBoxStudentId.Size = new System.Drawing.Size(125, 20);
            this.textBoxStudentId.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(36, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Student ID";
            // 
            // buttonListStudentFromDB
            // 
            this.buttonListStudentFromDB.Location = new System.Drawing.Point(24, 213);
            this.buttonListStudentFromDB.Name = "buttonListStudentFromDB";
            this.buttonListStudentFromDB.Size = new System.Drawing.Size(166, 38);
            this.buttonListStudentFromDB.TabIndex = 12;
            this.buttonListStudentFromDB.Text = "List students from DB";
            this.buttonListStudentFromDB.UseVisualStyleBackColor = true;
            this.buttonListStudentFromDB.Click += new System.EventHandler(this.buttonListStudentFromDB_Click);
            // 
            // dataGridViewStudent
            // 
            this.dataGridViewStudent.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewStudent.Location = new System.Drawing.Point(26, 285);
            this.dataGridViewStudent.Name = "dataGridViewStudent";
            this.dataGridViewStudent.Size = new System.Drawing.Size(386, 125);
            this.dataGridViewStudent.TabIndex = 13;
            this.dataGridViewStudent.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewStudent_CellContentClick);
            // 
            // dataGridViewStudentFromDS
            // 
            this.dataGridViewStudentFromDS.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewStudentFromDS.Location = new System.Drawing.Point(464, 275);
            this.dataGridViewStudentFromDS.Name = "dataGridViewStudentFromDS";
            this.dataGridViewStudentFromDS.Size = new System.Drawing.Size(386, 125);
            this.dataGridViewStudentFromDS.TabIndex = 15;
            // 
            // buttonListStudentFromDS
            // 
            this.buttonListStudentFromDS.Location = new System.Drawing.Point(462, 203);
            this.buttonListStudentFromDS.Name = "buttonListStudentFromDS";
            this.buttonListStudentFromDS.Size = new System.Drawing.Size(166, 38);
            this.buttonListStudentFromDS.TabIndex = 14;
            this.buttonListStudentFromDS.Text = "List students from DS";
            this.buttonListStudentFromDS.UseVisualStyleBackColor = true;
            this.buttonListStudentFromDS.Click += new System.EventHandler(this.buttonListStudentFromDS_Click);
            // 
            // StudentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(914, 525);
            this.ControlBox = false;
            this.Controls.Add(this.dataGridViewStudentFromDS);
            this.Controls.Add(this.buttonListStudentFromDS);
            this.Controls.Add(this.dataGridViewStudent);
            this.Controls.Add(this.buttonListStudentFromDB);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.buttonClose);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "StudentForm";
            this.Text = "Student Maintenance";
            this.Load += new System.EventHandler(this.StudentForm_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewStudent)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewStudentFromDS)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonClose;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button buttonUpdateDB;
        private System.Windows.Forms.Button buttonDelete;
        private System.Windows.Forms.Button buttonModify;
        private System.Windows.Forms.Button buttonSearch;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.TextBox textBoxEmail;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxLastName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxFirstName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxStudentId;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonListStudentFromDB;
        private System.Windows.Forms.DataGridView dataGridViewStudent;
        private System.Windows.Forms.DataGridView dataGridViewStudentFromDS;
        private System.Windows.Forms.Button buttonListStudentFromDS;
    }
}