namespace Zayac
{
    partial class HipotesyY
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
            this.raspredY = new System.Windows.Forms.DataGridView();
            this.NumberX = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RangeX = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CountX = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Norm_X = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Func_lap_X = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ver_X = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FuncX = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Stat_X = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.raspredY)).BeginInit();
            this.SuspendLayout();
            // 
            // raspredY
            // 
            this.raspredY.AllowUserToAddRows = false;
            this.raspredY.AllowUserToDeleteRows = false;
            this.raspredY.AllowUserToOrderColumns = true;
            this.raspredY.AllowUserToResizeColumns = false;
            this.raspredY.AllowUserToResizeRows = false;
            this.raspredY.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.raspredY.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.raspredY.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.raspredY.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
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
            this.raspredY.DefaultCellStyle = dataGridViewCellStyle2;
            this.raspredY.Dock = System.Windows.Forms.DockStyle.Top;
            this.raspredY.EnableHeadersVisualStyles = false;
            this.raspredY.Location = new System.Drawing.Point(0, 0);
            this.raspredY.Name = "raspredY";
            this.raspredY.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.raspredY.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.raspredY.RowHeadersVisible = false;
            this.raspredY.RowTemplate.ReadOnly = true;
            this.raspredY.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.raspredY.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.raspredY.Size = new System.Drawing.Size(800, 229);
            this.raspredY.TabIndex = 3;
            // 
            // NumberX
            // 
            this.NumberX.FillWeight = 95.97235F;
            this.NumberX.HeaderText = "i";
            this.NumberX.MaxInputLength = 2;
            this.NumberX.Name = "NumberX";
            this.NumberX.ReadOnly = true;
            this.NumberX.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // RangeX
            // 
            this.RangeX.FillWeight = 136.6384F;
            this.RangeX.HeaderText = "[bᵢ₋₁ ; bᵢ)";
            this.RangeX.Name = "RangeX";
            this.RangeX.ReadOnly = true;
            this.RangeX.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // CountX
            // 
            this.CountX.FillWeight = 65.93104F;
            this.CountX.HeaderText = "mᵢ";
            this.CountX.Name = "CountX";
            this.CountX.ReadOnly = true;
            this.CountX.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // Norm_X
            // 
            this.Norm_X.FillWeight = 66.65572F;
            this.Norm_X.HeaderText = "zᵢ";
            this.Norm_X.Name = "Norm_X";
            this.Norm_X.ReadOnly = true;
            this.Norm_X.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // Func_lap_X
            // 
            this.Func_lap_X.FillWeight = 79.52046F;
            this.Func_lap_X.HeaderText = "Ф(zᵢ)";
            this.Func_lap_X.Name = "Func_lap_X";
            this.Func_lap_X.ReadOnly = true;
            // 
            // Ver_X
            // 
            this.Ver_X.FillWeight = 83.48478F;
            this.Ver_X.HeaderText = "pᵢ";
            this.Ver_X.Name = "Ver_X";
            this.Ver_X.ReadOnly = true;
            this.Ver_X.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // FuncX
            // 
            this.FuncX.FillWeight = 75.90346F;
            this.FuncX.HeaderText = "npᵢ";
            this.FuncX.Name = "FuncX";
            this.FuncX.ReadOnly = true;
            // 
            // Stat_X
            // 
            this.Stat_X.FillWeight = 143.6097F;
            this.Stat_X.HeaderText = "(nᵢ - npᵢ) / (npᵢ)";
            this.Stat_X.Name = "Stat_X";
            this.Stat_X.ReadOnly = true;
            // 
            // HipotesyY
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.raspredY);
            this.Name = "HipotesyY";
            this.Text = "Hipotesy_Y";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Hipotesy_Y_FormClosed);
            this.Load += new System.EventHandler(this.Hipotesy_Y_Load);
            ((System.ComponentModel.ISupportInitialize)(this.raspredY)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView raspredY;
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