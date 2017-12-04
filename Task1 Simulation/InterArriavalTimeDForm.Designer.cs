namespace Task1_Simulation
{
    partial class InterArriavalTimeDForm
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
            this.ServermethodChoice = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.ServerNum = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.InterArrivalTimeCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProbabilityCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CumulativeProbabilityCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RangeCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ServerNum)).BeginInit();
            this.SuspendLayout();
            // 
            // ServermethodChoice
            // 
            this.ServermethodChoice.FormattingEnabled = true;
            this.ServermethodChoice.Items.AddRange(new object[] {
            "Random",
            "Highest Priority",
            "Lowest Utilization"});
            this.ServermethodChoice.Location = new System.Drawing.Point(177, 42);
            this.ServermethodChoice.Name = "ServermethodChoice";
            this.ServermethodChoice.Size = new System.Drawing.Size(121, 21);
            this.ServermethodChoice.TabIndex = 2;
            this.ServermethodChoice.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(63, 45);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Server Method";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.textBox1);
            this.groupBox1.Controls.Add(this.radioButton2);
            this.groupBox1.Controls.Add(this.radioButton1);
            this.groupBox1.Location = new System.Drawing.Point(56, 97);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(380, 100);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Stopping Condition";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(245, 30);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 2;
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(20, 67);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(109, 17);
            this.radioButton2.TabIndex = 1;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "End Service Time";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(20, 33);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(133, 17);
            this.radioButton1.TabIndex = 0;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Numbers Of Customers";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.InterArrivalTimeCol,
            this.ProbabilityCol,
            this.CumulativeProbabilityCol,
            this.RangeCol,
            this.Column1});
            this.dataGridView1.Location = new System.Drawing.Point(26, 203);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(448, 194);
            this.dataGridView1.TabIndex = 5;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(177, 406);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(125, 27);
            this.button1.TabIndex = 6;
            this.button1.Text = "Submit";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // ServerNum
            // 
            this.ServerNum.Location = new System.Drawing.Point(177, 12);
            this.ServerNum.Name = "ServerNum";
            this.ServerNum.Size = new System.Drawing.Size(120, 20);
            this.ServerNum.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(63, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Server numbers";
            // 
            // InterArrivalTimeCol
            // 
            this.InterArrivalTimeCol.HeaderText = "InterArrivalTime";
            this.InterArrivalTimeCol.Name = "InterArrivalTimeCol";
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
            // InterArriavalTimeDForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(486, 445);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ServerNum);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.ServermethodChoice);
            this.Name = "InterArriavalTimeDForm";
            this.Text = "InteraArrivalTimeForm";
            this.Load += new System.EventHandler(this.InterArriavalTimeDForm_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ServerNum)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox ServermethodChoice;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.NumericUpDown ServerNum;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn InterArrivalTimeCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProbabilityCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn CumulativeProbabilityCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn RangeCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;



    }
}

