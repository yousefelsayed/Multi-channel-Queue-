namespace Task1_Simulation
{
    partial class ServiceTimeDistributionForm
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
            this.ServiceTimeDGV = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.ServiceTimeCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProbabilityCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CumulativeProbabilityCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RangeCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.ServiceTimeDGV)).BeginInit();
            this.SuspendLayout();
            // 
            // ServiceTimeDGV
            // 
            this.ServiceTimeDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ServiceTimeDGV.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ServiceTimeCol,
            this.ProbabilityCol,
            this.CumulativeProbabilityCol,
            this.RangeCol,
            this.Column1});
            this.ServiceTimeDGV.Location = new System.Drawing.Point(-4, 43);
            this.ServiceTimeDGV.Name = "ServiceTimeDGV";
            this.ServiceTimeDGV.Size = new System.Drawing.Size(503, 197);
            this.ServiceTimeDGV.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(120, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(215, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Service Time  distribution ";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(197, 268);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(120, 43);
            this.button1.TabIndex = 2;
            this.button1.Text = "Submit";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // ServiceTimeCol
            // 
            this.ServiceTimeCol.HeaderText = "ServiceTime";
            this.ServiceTimeCol.Name = "ServiceTimeCol";
            // 
            // ProbabilityCol
            // 
            this.ProbabilityCol.HeaderText = "Probability";
            this.ProbabilityCol.Name = "ProbabilityCol";
            // 
            // CumulativeProbabilityCol
            // 
            this.CumulativeProbabilityCol.HeaderText = "CumulativeProbability";
            this.CumulativeProbabilityCol.Name = "CumulativeProbabilityCol";
            // 
            // RangeCol
            // 
            this.RangeCol.HeaderText = "Min Range";
            this.RangeCol.Name = "RangeCol";
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Max Range";
            this.Column1.Name = "Column1";
            // 
            // ServiceTimeDistributionForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(511, 318);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ServiceTimeDGV);
            this.Name = "ServiceTimeDistributionForm";
            this.Text = "ServiceTimeDistributionForm";
            this.Activated += new System.EventHandler(this.ServiceTimeDistributionForm_Activated);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.ServiceTimeDistributionForm_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.ServiceTimeDGV)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView ServiceTimeDGV;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridViewTextBoxColumn ServiceTimeCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProbabilityCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn CumulativeProbabilityCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn RangeCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
    }
}