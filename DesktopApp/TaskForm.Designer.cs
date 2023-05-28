namespace DesktopApp
{
    partial class TaskForm
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
            this.label3 = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txtTaskName = new System.Windows.Forms.TextBox();
            this.cmbTaskFreq = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dtTaskDate = new System.Windows.Forms.DateTimePicker();
            this.townCrierDBDataSet = new DesktopApp.TownCrierDBDataSet();
            this.fREQUENCIESBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.fREQUENCIESTableAdapter = new DesktopApp.TownCrierDBDataSetTableAdapters.FREQUENCIESTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.townCrierDBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fREQUENCIESBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(26, 90);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(122, 20);
            this.label3.TabIndex = 23;
            this.label3.Text = "Task Frequency";
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(322, 242);
            this.btnSave.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(112, 35);
            this.btnSave.TabIndex = 21;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(30, 24);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 20);
            this.label2.TabIndex = 20;
            this.label2.Text = "Task Name";
            // 
            // txtTaskName
            // 
            this.txtTaskName.Location = new System.Drawing.Point(30, 49);
            this.txtTaskName.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtTaskName.Name = "txtTaskName";
            this.txtTaskName.Size = new System.Drawing.Size(404, 26);
            this.txtTaskName.TabIndex = 18;
            // 
            // cmbTaskFreq
            // 
            this.cmbTaskFreq.DataSource = this.fREQUENCIESBindingSource;
            this.cmbTaskFreq.DisplayMember = "freqName";
            this.cmbTaskFreq.FormattingEnabled = true;
            this.cmbTaskFreq.Location = new System.Drawing.Point(30, 113);
            this.cmbTaskFreq.Name = "cmbTaskFreq";
            this.cmbTaskFreq.Size = new System.Drawing.Size(404, 28);
            this.cmbTaskFreq.TabIndex = 33;
            this.cmbTaskFreq.ValueMember = "freqID";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 164);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 20);
            this.label1.TabIndex = 34;
            this.label1.Text = "Task Date";
            // 
            // dtTaskDate
            // 
            this.dtTaskDate.CustomFormat = "MM/dd/yyyy";
            this.dtTaskDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtTaskDate.Location = new System.Drawing.Point(30, 187);
            this.dtTaskDate.Name = "dtTaskDate";
            this.dtTaskDate.Size = new System.Drawing.Size(404, 26);
            this.dtTaskDate.TabIndex = 35;
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
            // TaskForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(453, 291);
            this.Controls.Add(this.dtTaskDate);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmbTaskFreq);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtTaskName);
            this.Name = "TaskForm";
            this.Text = "Create New Task";
            this.Load += new System.EventHandler(this.TaskForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.townCrierDBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fREQUENCIESBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtTaskName;
        private System.Windows.Forms.ComboBox cmbTaskFreq;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dtTaskDate;
        private TownCrierDBDataSet townCrierDBDataSet;
        private System.Windows.Forms.BindingSource fREQUENCIESBindingSource;
        private TownCrierDBDataSetTableAdapters.FREQUENCIESTableAdapter fREQUENCIESTableAdapter;
    }
}