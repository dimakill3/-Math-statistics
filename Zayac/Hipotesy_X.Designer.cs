namespace Zayac
{
    partial class HipotesyX
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HipotesyX));
            this.raspredX = new System.Windows.Forms.DataGridView();
            this.NumberX = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RangeX = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CountX = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Norm_X = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Func_lap_X = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ver_X = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FuncX = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Stat_X = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.raspredX)).BeginInit();
            this.SuspendLayout();
            // 
            // raspredX
            // 
            this.raspredX.AllowUserToAddRows = false;
            this.raspredX.AllowUserToDeleteRows = false;
            this.raspredX.AllowUserToOrderColumns = true;
            this.raspredX.AllowUserToResizeColumns = false;
            this.raspredX.AllowUserToResizeRows = false;
            this.raspredX.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.raspredX.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.raspredX.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.raspredX.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.NumberX,
            this.RangeX,
            this.CountX,
            this.Norm_X,
            this.Func_lap_X,
            this.Ver_X,
            this.FuncX,
            this.Stat_X});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.raspredX.DefaultCellStyle = dataGridViewCellStyle2;
            resources.ApplyResources(this.raspredX, "raspredX");
            this.raspredX.EnableHeadersVisualStyles = false;
            this.raspredX.Name = "raspredX";
            this.raspredX.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.raspredX.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.raspredX.RowHeadersVisible = false;
            this.raspredX.RowTemplate.ReadOnly = true;
            this.raspredX.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.raspredX.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            // 
            // NumberX
            // 
            this.NumberX.FillWeight = 95.98091F;
            resources.ApplyResources(this.NumberX, "NumberX");
            this.NumberX.MaxInputLength = 2;
            this.NumberX.Name = "NumberX";
            this.NumberX.ReadOnly = true;
            this.NumberX.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // RangeX
            // 
            this.RangeX.FillWeight = 136.5838F;
            resources.ApplyResources(this.RangeX, "RangeX");
            this.RangeX.Name = "RangeX";
            this.RangeX.ReadOnly = true;
            this.RangeX.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // CountX
            // 
            this.CountX.FillWeight = 65.93692F;
            resources.ApplyResources(this.CountX, "CountX");
            this.CountX.Name = "CountX";
            this.CountX.ReadOnly = true;
            this.CountX.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // Norm_X
            // 
            this.Norm_X.FillWeight = 66.66167F;
            resources.ApplyResources(this.Norm_X, "Norm_X");
            this.Norm_X.Name = "Norm_X";
            this.Norm_X.ReadOnly = true;
            this.Norm_X.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // Func_lap_X
            // 
            this.Func_lap_X.FillWeight = 79.52756F;
            resources.ApplyResources(this.Func_lap_X, "Func_lap_X");
            this.Func_lap_X.Name = "Func_lap_X";
            this.Func_lap_X.ReadOnly = true;
            // 
            // Ver_X
            // 
            this.Ver_X.FillWeight = 83.49222F;
            resources.ApplyResources(this.Ver_X, "Ver_X");
            this.Ver_X.Name = "Ver_X";
            this.Ver_X.ReadOnly = true;
            this.Ver_X.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // FuncX
            // 
            this.FuncX.FillWeight = 75.91023F;
            resources.ApplyResources(this.FuncX, "FuncX");
            this.FuncX.Name = "FuncX";
            this.FuncX.ReadOnly = true;
            // 
            // Stat_X
            // 
            this.Stat_X.FillWeight = 143.6225F;
            resources.ApplyResources(this.Stat_X, "Stat_X");
            this.Stat_X.Name = "Stat_X";
            this.Stat_X.ReadOnly = true;
            // 
            // HipotesyX
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.raspredX);
            this.Name = "HipotesyX";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.HipotesyX_FormClosed);
            this.Load += new System.EventHandler(this.Hipotesy_X_Load);
            ((System.ComponentModel.ISupportInitialize)(this.raspredX)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView raspredX;
        private System.Windows.Forms.DataGridViewTextBoxColumn NumberX;
        private System.Windows.Forms.DataGridViewTextBoxColumn RangeX;
        private System.Windows.Forms.DataGridViewTextBoxColumn CountX;
        private System.Windows.Forms.DataGridViewTextBoxColumn Norm_X;
        private System.Windows.Forms.DataGridViewTextBoxColumn Func_lap_X;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ver_X;
        private System.Windows.Forms.DataGridViewTextBoxColumn FuncX;
        private System.Windows.Forms.DataGridViewTextBoxColumn Stat_X;
        
    }
}