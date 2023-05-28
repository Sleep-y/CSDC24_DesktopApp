namespace DesktopApp
{
    partial class EventForm
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
            this.txtEventName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.txtEventLoc = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.dtDateStart = new System.Windows.Forms.DateTimePicker();
            this.dtTimeStart = new System.Windows.Forms.DateTimePicker();
            this.dtTimeEnd = new System.Windows.Forms.DateTimePicker();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.dtDateEnd = new System.Windows.Forms.DateTimePicker();
            this.cmbEventFreq = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.townCrierDBDataSet = new DesktopApp.TownCrierDBDataSet();
            this.fREQUENCIESBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.fREQUENCIESTableAdapter = new DesktopApp.TownCrierDBDataSetTableAdapters.FREQUENCIESTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.townCrierDBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fREQUENCIESBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // txtEventName
            // 
            this.txtEventName.Location = new System.Drawing.Point(29, 49);
            this.txtEventName.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtEventName.Name = "txtEventName";
            this.txtEventName.Size = new System.Drawing.Size(404, 26);
            this.txtEventName.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(29, 259);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Date";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(29, 24);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Event Name";
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(400, 415);
            this.btnSave.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(112, 35);
            this.btnSave.TabIndex = 4;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(29, 89);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(115, 20);
            this.label3.TabIndex = 6;
            this.label3.Text = "Event Location";
            // 
            // txtEventLoc
            // 
            this.txtEventLoc.Location = new System.Drawing.Point(29, 114);
            this.txtEventLoc.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtEventLoc.Name = "txtEventLoc";
            this.txtEventLoc.Size = new System.Drawing.Size(404, 26);
            this.txtEventLoc.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(105, 337);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 20);
            this.label4.TabIndex = 8;
            this.label4.Text = "Start";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(339, 337);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(38, 20);
            this.label5.TabIndex = 10;
            this.label5.Text = "End";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(30, 337);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(43, 20);
            this.label6.TabIndex = 11;
            this.label6.Text = "Time";
            // 
            // dtDateStart
            // 
            this.dtDateStart.CustomFormat = "MM/dd/yyyy";
            this.dtDateStart.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtDateStart.Location = new System.Drawing.Point(108, 282);
            this.dtDateStart.Name = "dtDateStart";
            this.dtDateStart.Size = new System.Drawing.Size(169, 26);
            this.dtDateStart.TabIndex = 12;
            // 
            // dtTimeStart
            // 
            this.dtTimeStart.CustomFormat = "HH:mm";
            this.dtTimeStart.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtTimeStart.Location = new System.Drawing.Point(105, 364);
            this.dtTimeStart.Name = "dtTimeStart";
            this.dtTimeStart.Size = new System.Drawing.Size(169, 26);
            this.dtTimeStart.TabIndex = 13;
            // 
            // dtTimeEnd
            // 
            this.dtTimeEnd.CustomFormat = "HH:mm";
            this.dtTimeEnd.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtTimeEnd.Location = new System.Drawing.Point(343, 364);
            this.dtTimeEnd.Name = "dtTimeEnd";
            this.dtTimeEnd.Size = new System.Drawing.Size(169, 26);
            this.dtTimeEnd.TabIndex = 14;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(104, 259);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(44, 20);
            this.label7.TabIndex = 15;
            this.label7.Text = "Start";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(338, 259);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(38, 20);
            this.label8.TabIndex = 16;
            this.label8.Text = "End";
            // 
            // dtDateEnd
            // 
            this.dtDateEnd.CustomFormat = "MM/dd/yyyy";
            this.dtDateEnd.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtDateEnd.Location = new System.Drawing.Point(342, 282);
            this.dtDateEnd.Name = "dtDateEnd";
            this.dtDateEnd.Size = new System.Drawing.Size(169, 26);
            this.dtDateEnd.TabIndex = 17;
            // 
            // cmbEventFreq
            // 
            this.cmbEventFreq.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.fREQUENCIESBindingSource, "freqID", true));
            this.cmbEventFreq.DataSource = this.fREQUENCIESBindingSource;
            this.cmbEventFreq.DisplayMember = "freqName";
            this.cmbEventFreq.FormattingEnabled = true;
            this.cmbEventFreq.Location = new System.Drawing.Point(28, 182);
            this.cmbEventFreq.Name = "cmbEventFreq";
            this.cmbEventFreq.Size = new System.Drawing.Size(404, 28);
            this.cmbEventFreq.TabIndex = 35;
            this.cmbEventFreq.ValueMember = "freqID";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(29, 159);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(129, 20);
            this.label9.TabIndex = 34;
            this.label9.Text = "Event Frequency";
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
            // EventForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(532, 484);
            this.Controls.Add(this.cmbEventFreq);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.dtDateEnd);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.dtTimeEnd);
            this.Controls.Add(this.dtTimeStart);
            this.Controls.Add(this.dtDateStart);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtEventLoc);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtEventName);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "EventForm";
            this.Text = "Create New Event";
            this.Load += new System.EventHandler(this.EventForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.townCrierDBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fREQUENCIESBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtEventName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtEventLoc;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DateTimePicker dtDateStart;
        private System.Windows.Forms.DateTimePicker dtTimeStart;
        private System.Windows.Forms.DateTimePicker dtTimeEnd;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DateTimePicker dtDateEnd;
        private System.Windows.Forms.ComboBox cmbEventFreq;
        private System.Windows.Forms.Label label9;
        private TownCrierDBDataSet townCrierDBDataSet;
        private System.Windows.Forms.BindingSource fREQUENCIESBindingSource;
        private TownCrierDBDataSetTableAdapters.FREQUENCIESTableAdapter fREQUENCIESTableAdapter;
    }
}