namespace Zayac
{
    partial class Correlative
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.CorrTable = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.inter_X = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.inter_Y_1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.inter_Y_3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.inter_Y_4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.inter_Y_5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.inter_Y_2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.inter_Y_6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.inter_Y_7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Count_X = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.CorrTable)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // CorrTable
            // 
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.CorrTable.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.CorrTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.CorrTable.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.inter_X,
            this.inter_Y_1,
            this.inter_Y_3,
            this.inter_Y_4,
            this.inter_Y_5,
            this.inter_Y_2,
            this.inter_Y_6,
            this.inter_Y_7,
            this.Count_X});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.CorrTable.DefaultCellStyle = dataGridViewCellStyle2;
            this.CorrTable.EnableHeadersVisualStyles = false;
            this.CorrTable.Location = new System.Drawing.Point(12, 12);
            this.CorrTable.Name = "CorrTable";
            this.CorrTable.RowHeadersVisible = false;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CorrTable.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.CorrTable.Size = new System.Drawing.Size(669, 203);
            this.CorrTable.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(132, 274);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 24);
            this.label1.TabIndex = 1;
            this.label1.Text = "label1";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Zayac.Properties.Resources.Скриншот_16_12_2019_032048;
            this.pictureBox1.Location = new System.Drawing.Point(63, 270);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(63, 33);
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // inter_X
            // 
            this.inter_X.HeaderText = "X \\ Y";
            this.inter_X.Name = "inter_X";
            this.inter_X.Width = 70;
            // 
            // inter_Y_1
            // 
            this.inter_Y_1.HeaderText = "Column1";
            this.inter_Y_1.Name = "inter_Y_1";
            this.inter_Y_1.Width = 80;
            // 
            // inter_Y_3
            // 
            this.inter_Y_3.HeaderText = "Column1";
            this.inter_Y_3.Name = "inter_Y_3";
            this.inter_Y_3.Width = 80;
            // 
            // inter_Y_4
            // 
            this.inter_Y_4.HeaderText = "Column1";
            this.inter_Y_4.Name = "inter_Y_4";
            this.inter_Y_4.Width = 80;
            // 
            // inter_Y_5
            // 
            this.inter_Y_5.HeaderText = "Column1";
            this.inter_Y_5.Name = "inter_Y_5";
            this.inter_Y_5.Width = 80;
            // 
            // inter_Y_2
            // 
            this.inter_Y_2.HeaderText = "Column1";
            this.inter_Y_2.Name = "inter_Y_2";
            this.inter_Y_2.Width = 80;
            // 
            // inter_Y_6
            // 
            this.inter_Y_6.HeaderText = "Column1";
            this.inter_Y_6.Name = "inter_Y_6";
            this.inter_Y_6.Width = 80;
            // 
            // inter_Y_7
            // 
            this.inter_Y_7.HeaderText = "Column1";
            this.inter_Y_7.Name = "inter_Y_7";
            this.inter_Y_7.Width = 80;
            // 
            // Count_X
            // 
            this.Count_X.HeaderText = "ni";
            this.Count_X.Name = "Count_X";
            this.Count_X.Width = 35;
            // 
            // Correlative
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(696, 347);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.CorrTable);
            this.Name = "Correlative";
            this.Text = "Correlative";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Correlative_FormClosed);
            this.Load += new System.EventHandler(this.Correlative_Load);
            ((System.ComponentModel.ISupportInitialize)(this.CorrTable)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView CorrTable;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.DataGridViewTextBoxColumn inter_X;
        private System.Windows.Forms.DataGridViewTextBoxColumn inter_Y_1;
        private System.Windows.Forms.DataGridViewTextBoxColumn inter_Y_3;
        private System.Windows.Forms.DataGridViewTextBoxColumn inter_Y_4;
        private System.Windows.Forms.DataGridViewTextBoxColumn inter_Y_5;
        private System.Windows.Forms.DataGridViewTextBoxColumn inter_Y_2;
        private System.Windows.Forms.DataGridViewTextBoxColumn inter_Y_6;
        private System.Windows.Forms.DataGridViewTextBoxColumn inter_Y_7;
        private System.Windows.Forms.DataGridViewTextBoxColumn Count_X;
    }
}