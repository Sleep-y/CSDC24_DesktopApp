namespace DesktopApp
{
    partial class ManageTaskForm
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvSelectedDate = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtTaskID = new System.Windows.Forms.TextBox();
            this.txtTaskName = new System.Windows.Forms.TextBox();
            this.grpRadioBtns = new System.Windows.Forms.GroupBox();
            this.rbtnYes = new System.Windows.Forms.RadioButton();
            this.rbtnNo = new System.Windows.Forms.RadioButton();
            this.dtTaskDate = new System.Windows.Forms.DateTimePicker();
            this.cmbTaskFreq = new System.Windows.Forms.ComboBox();
            this.townCrierDBDataSet = new DesktopApp.TownCrierDBDataSet();
            this.fREQUENCIESBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.fREQUENCIESTableAdapter = new DesktopApp.TownCrierDBDataSetTableAdapters.FREQUENCIESTableAdapter();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.lblSelectedDate = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSelectedDate)).BeginInit();
            this.grpRadioBtns.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.townCrierDBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fREQUENCIESBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(202, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Manage Task For";
            // 
            // dgvSelectedDate
            // 
            this.dgvSelectedDate.AllowUserToAddRows = false;
            this.dgvSelectedDate.AllowUserToDeleteRows = false;
            this.dgvSelectedDate.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSelectedDate.Location = new System.Drawing.Point(331, 60);
            this.dgvSelectedDate.Name = "dgvSelectedDate";
            this.dgvSelectedDate.ReadOnly = true;
            this.dgvSelectedDate.RowHeadersWidth = 62;
            this.dgvSelectedDate.RowTemplate.Height = 28;
            this.dgvSelectedDate.Size = new System.Drawing.Size(457, 436);
            this.dgvSelectedDate.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 25);
            this.label2.TabIndex = 2;
            this.label2.Text = "Task ID";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 126);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(113, 25);
            this.label3.TabIndex = 3;
            this.label3.Text = "Task Name";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(12, 198);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(139, 25);
            this.label4.TabIndex = 4;
            this.label4.Text = "Task Is Done?";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(12, 281);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(181, 25);
            this.label5.TabIndex = 5;
            this.label5.Text = "Task Finished Date";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(12, 352);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(105, 25);
            this.label6.TabIndex = 6;
            this.label6.Text = "Frequency";
            // 
            // txtTaskID
            // 
            this.txtTaskID.Location = new System.Drawing.Point(17, 89);
            this.txtTaskID.Name = "txtTaskID";
            this.txtTaskID.Size = new System.Drawing.Size(253, 26);
            this.txtTaskID.TabIndex = 7;
            this.txtTaskID.TabStop = false;
            // 
            // txtTaskName
            // 
            this.txtTaskName.Location = new System.Drawing.Point(17, 154);
            this.txtTaskName.Name = "txtTaskName";
            this.txtTaskName.Size = new System.Drawing.Size(253, 26);
            this.txtTaskName.TabIndex = 8;
            this.txtTaskName.TabStop = false;
            // 
            // grpRadioBtns
            // 
            this.grpRadioBtns.Controls.Add(this.rbtnYes);
            this.grpRadioBtns.Controls.Add(this.rbtnNo);
            this.grpRadioBtns.Location = new System.Drawing.Point(17, 226);
            this.grpRadioBtns.Name = "grpRadioBtns";
            this.grpRadioBtns.Size = new System.Drawing.Size(140, 46);
            this.grpRadioBtns.TabIndex = 11;
            this.grpRadioBtns.TabStop = false;
            // 
            // rbtnYes
            // 
            this.rbtnYes.AutoSize = true;
            this.rbtnYes.Location = new System.Drawing.Point(79, 11);
            this.rbtnYes.Name = "rbtnYes";
            this.rbtnYes.Size = new System.Drawing.Size(62, 24);
            this.rbtnYes.TabIndex = 12;
            this.rbtnYes.TabStop = true;
            this.rbtnYes.Text = "Yes";
            this.rbtnYes.UseVisualStyleBackColor = true;
            // 
            // rbtnNo
            // 
            this.rbtnNo.AutoSize = true;
            this.rbtnNo.Location = new System.Drawing.Point(6, 11);
            this.rbtnNo.Name = "rbtnNo";
            this.rbtnNo.Size = new System.Drawing.Size(54, 24);
            this.rbtnNo.TabIndex = 11;
            this.rbtnNo.TabStop = true;
            this.rbtnNo.Text = "No";
            this.rbtnNo.UseVisualStyleBackColor = true;
            // 
            // dtTaskDate
            // 
            this.dtTaskDate.CustomFormat = "MM/dd/yyyy";
            this.dtTaskDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtTaskDate.Location = new System.Drawing.Point(17, 309);
            this.dtTaskDate.Name = "dtTaskDate";
            this.dtTaskDate.Size = new System.Drawing.Size(253, 26);
            this.dtTaskDate.TabIndex = 36;
            // 
            // cmbTaskFreq
            // 
            this.cmbTaskFreq.DataSource = this.fREQUENCIESBindingSource;
            this.cmbTaskFreq.DisplayMember = "freqName";
            this.cmbTaskFreq.FormattingEnabled = true;
            this.cmbTaskFreq.Location = new System.Drawing.Point(17, 380);
            this.cmbTaskFreq.Name = "cmbTaskFreq";
            this.cmbTaskFreq.Size = new System.Drawing.Size(253, 28);
            this.cmbTaskFreq.TabIndex = 37;
            this.cmbTaskFreq.ValueMember = "freqID";
            // 
            // townCrierDBDataSet
            // 
            this.townCrierDBDataSet.DataSetName = "TownCrierDBDataSet";
            this.townCrierDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // fREQUENCIESBindingSource
            // 
            this.fREQUENCIESBindingSource.DataMember = "FREQUENCIES";
            this.fREQUENCIESBindingSource.DataSource = this.townCrierDBDataSet;
            // 
            // fREQUENCIESTableAdapter
            // 
            this.fREQUENCIESTableAdapter.ClearBeforeFill = true;
            // 
            // btnUpdate
            // 
            this.btnUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdate.Location = new System.Drawing.Point(156, 442);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(114, 32);
            this.btnUpdate.TabIndex = 38;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            // 
            // btnDelete
            // 
            this.btnDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.Location = new System.Drawing.Point(17, 442);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(114, 32);
            this.btnDelete.TabIndex = 39;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            // 
            // lblSelectedDate
            // 
            this.lblSelectedDate.AutoSize = true;
            this.lblSelectedDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSelectedDate.Location = new System.Drawing.Point(220, 9);
            this.lblSelectedDate.Name = "lblSelectedDate";
            this.lblSelectedDate.Size = new System.Drawing.Size(63, 29);
            this.lblSelectedDate.TabIndex = 40;
            this.lblSelectedDate.Text = "Date";
            // 
            // ManageTaskForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 508);
            this.Controls.Add(this.lblSelectedDate);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.cmbTaskFreq);
            this.Controls.Add(this.dtTaskDate);
            this.Controls.Add(this.grpRadioBtns);
            this.Controls.Add(this.txtTaskName);
            this.Controls.Add(this.txtTaskID);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dgvSelectedDate);
            this.Controls.Add(this.label1);
            this.Name = "ManageTaskForm";
            this.Text = "Manage Task";
            this.Load += new System.EventHandler(this.ManageTaskForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSelectedDate)).EndInit();
            this.grpRadioBtns.ResumeLayout(false);
            this.grpRadioBtns.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.townCrierDBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fREQUENCIESBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvSelectedDate;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtTaskID;
        private System.Windows.Forms.TextBox txtTaskName;
        private System.Windows.Forms.GroupBox grpRadioBtns;
        private System.Windows.Forms.RadioButton rbtnYes;
        private System.Windows.Forms.RadioButton rbtnNo;
        private System.Windows.Forms.DateTimePicker dtTaskDate;
        private System.Windows.Forms.ComboBox cmbTaskFreq;
        private TownCrierDBDataSet townCrierDBDataSet;
        private System.Windows.Forms.BindingSource fREQUENCIESBindingSource;
        private TownCrierDBDataSetTableAdapters.FREQUENCIESTableAdapter fREQUENCIESTableAdapter;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Label lblSelectedDate;
    }
}