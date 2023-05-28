namespace DesktopApp
{
    partial class UserControlDays
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
            this.components = new System.ComponentModel.Container();
            this.lbdays = new System.Windows.Forms.Label();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.ucDayList = new System.Windows.Forms.ListView();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // lbdays
            // 
            this.lbdays.AutoSize = true;
            this.lbdays.Font = new System.Drawing.Font("Mongolian Baiti", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbdays.Location = new System.Drawing.Point(21, 25);
            this.lbdays.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbdays.Name = "lbdays";
            this.lbdays.Size = new System.Drawing.Size(36, 25);
            this.lbdays.TabIndex = 0;
            this.lbdays.Text = "00";
            // 
            // ucDayList
            // 
            this.ucDayList.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ucDayList.Enabled = false;
            this.ucDayList.HideSelection = false;
            this.ucDayList.Location = new System.Drawing.Point(4, 54);
            this.ucDayList.Name = "ucDayList";
            this.ucDayList.Size = new System.Drawing.Size(163, 97);
            this.ucDayList.TabIndex = 1;
            this.ucDayList.TabStop = false;
            this.ucDayList.UseCompatibleStateImageBehavior = false;
            // 
            // UserControlDays
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.ucDayList);
            this.Controls.Add(this.lbdays);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "UserControlDays";
            this.Size = new System.Drawing.Size(170, 154);
            this.Click += new System.EventHandler(this.UserControlDays_Click);
            this.DoubleClick += new System.EventHandler(this.UserControlDays_DoubleClick);
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbdays;
        private System.Windows.Forms.BindingSource bindingSource1;
        private System.Windows.Forms.ListView ucDayList;
    }
}
