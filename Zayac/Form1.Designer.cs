namespace Zayac
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.менюToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.загрузитьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.сохранитьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.XandY = new System.Windows.Forms.TabControl();
            this.X = new System.Windows.Forms.TabPage();
            this.raspredX = new System.Windows.Forms.DataGridView();
            this.NumberX = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RangeX = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CountX = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AverageX = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HeightPoligonX = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HeightGistX = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FuncX = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Y = new System.Windows.Forms.TabPage();
            this.raspredY = new System.Windows.Forms.DataGridView();
            this.NumberY = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RangeY = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CountY = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AverageY = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HeightPoligonY = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HeightGistY = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FuncY = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.openFile = new System.Windows.Forms.OpenFileDialog();
            this.saveFile = new System.Windows.Forms.SaveFileDialog();
            this.menuStrip1.SuspendLayout();
            this.XandY.SuspendLayout();
            this.X.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.raspredX)).BeginInit();
            this.Y.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.raspredY)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.менюToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(952, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // менюToolStripMenuItem
            // 
            this.менюToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.загрузитьToolStripMenuItem,
            this.сохранитьToolStripMenuItem});
            this.менюToolStripMenuItem.Name = "менюToolStripMenuItem";
            this.менюToolStripMenuItem.Size = new System.Drawing.Size(53, 20);
            this.менюToolStripMenuItem.Text = "Меню";
            // 
            // загрузитьToolStripMenuItem
            // 
            this.загрузитьToolStripMenuItem.Name = "загрузитьToolStripMenuItem";
            this.загрузитьToolStripMenuItem.Size = new System.Drawing.Size(132, 22);
            this.загрузитьToolStripMenuItem.Text = "Загрузить";
            this.загрузитьToolStripMenuItem.Click += new System.EventHandler(this.загрузитьToolStripMenuItem_Click);
            // 
            // сохранитьToolStripMenuItem
            // 
            this.сохранитьToolStripMenuItem.Name = "сохранитьToolStripMenuItem";
            this.сохранитьToolStripMenuItem.Size = new System.Drawing.Size(132, 22);
            this.сохранитьToolStripMenuItem.Text = "Сохранить";
            // 
            // XandY
            // 
            this.XandY.Controls.Add(this.X);
            this.XandY.Controls.Add(this.Y);
            this.XandY.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.XandY.Location = new System.Drawing.Point(0, 27);
            this.XandY.Name = "XandY";
            this.XandY.Padding = new System.Drawing.Point(3, 3);
            this.XandY.SelectedIndex = 0;
            this.XandY.Size = new System.Drawing.Size(952, 537);
            this.XandY.TabIndex = 1;
            // 
            // X
            // 
            this.X.BackColor = System.Drawing.Color.FloralWhite;
            this.X.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.X.Controls.Add(this.raspredX);
            this.X.Location = new System.Drawing.Point(4, 25);
            this.X.Name = "X";
            this.X.Padding = new System.Windows.Forms.Padding(3);
            this.X.Size = new System.Drawing.Size(944, 508);
            this.X.TabIndex = 0;
            this.X.Text = "    X";
            // 
            // raspredX
            // 
            this.raspredX.AllowUserToDeleteRows = false;
            this.raspredX.AllowUserToOrderColumns = true;
            this.raspredX.AllowUserToResizeColumns = false;
            this.raspredX.AllowUserToResizeRows = false;
            this.raspredX.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
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
            this.AverageX,
            this.HeightPoligonX,
            this.HeightGistX,
            this.FuncX});
            this.raspredX.EnableHeadersVisualStyles = false;
            this.raspredX.Location = new System.Drawing.Point(-2, -2);
            this.raspredX.Name = "raspredX";
            this.raspredX.ReadOnly = true;
            this.raspredX.RowHeadersVisible = false;
            this.raspredX.RowTemplate.ReadOnly = true;
            this.raspredX.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.raspredX.Size = new System.Drawing.Size(633, 247);
            this.raspredX.TabIndex = 0;
            // 
            // NumberX
            // 
            this.NumberX.FillWeight = 31.37694F;
            this.NumberX.HeaderText = "i";
            this.NumberX.MaxInputLength = 2;
            this.NumberX.Name = "NumberX";
            this.NumberX.ReadOnly = true;
            this.NumberX.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // RangeX
            // 
            this.RangeX.FillWeight = 115.1833F;
            this.RangeX.HeaderText = "[aᵢ₋₁ ; aᵢ)";
            this.RangeX.Name = "RangeX";
            this.RangeX.ReadOnly = true;
            this.RangeX.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // CountX
            // 
            this.CountX.FillWeight = 55.60566F;
            this.CountX.HeaderText = "nᵢ";
            this.CountX.Name = "CountX";
            this.CountX.ReadOnly = true;
            this.CountX.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // AverageX
            // 
            this.AverageX.FillWeight = 115.1833F;
            this.AverageX.HeaderText = "X˟ᵢ";
            this.AverageX.Name = "AverageX";
            this.AverageX.ReadOnly = true;
            this.AverageX.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // HeightPoligonX
            // 
            this.HeightPoligonX.HeaderText = "nᵢ /n";
            this.HeightPoligonX.Name = "HeightPoligonX";
            this.HeightPoligonX.ReadOnly = true;
            // 
            // HeightGistX
            // 
            this.HeightGistX.FillWeight = 115.1833F;
            this.HeightGistX.HeaderText = "nᵢ /(n∙h)";
            this.HeightGistX.Name = "HeightGistX";
            this.HeightGistX.ReadOnly = true;
            this.HeightGistX.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // FuncX
            // 
            this.FuncX.FillWeight = 115.1833F;
            this.FuncX.HeaderText = "Fn(X)";
            this.FuncX.Name = "FuncX";
            this.FuncX.ReadOnly = true;
            // 
            // Y
            // 
            this.Y.BackColor = System.Drawing.Color.FloralWhite;
            this.Y.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.Y.Controls.Add(this.raspredY);
            this.Y.Cursor = System.Windows.Forms.Cursors.Default;
            this.Y.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Y.Location = new System.Drawing.Point(4, 25);
            this.Y.Name = "Y";
            this.Y.Padding = new System.Windows.Forms.Padding(3);
            this.Y.Size = new System.Drawing.Size(944, 508);
            this.Y.TabIndex = 1;
            this.Y.Text = "    Y";
            // 
            // raspredY
            // 
            this.raspredY.AllowUserToDeleteRows = false;
            this.raspredY.AllowUserToOrderColumns = true;
            this.raspredY.AllowUserToResizeColumns = false;
            this.raspredY.AllowUserToResizeRows = false;
            this.raspredY.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.raspredY.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.raspredY.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.raspredY.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.NumberY,
            this.RangeY,
            this.CountY,
            this.AverageY,
            this.HeightPoligonY,
            this.HeightGistY,
            this.FuncY});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.raspredY.DefaultCellStyle = dataGridViewCellStyle3;
            this.raspredY.EnableHeadersVisualStyles = false;
            this.raspredY.Location = new System.Drawing.Point(-2, -2);
            this.raspredY.Name = "raspredY";
            this.raspredY.ReadOnly = true;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.raspredY.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.raspredY.RowHeadersVisible = false;
            this.raspredY.RowTemplate.ReadOnly = true;
            this.raspredY.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.raspredY.Size = new System.Drawing.Size(633, 247);
            this.raspredY.TabIndex = 1;
            // 
            // NumberY
            // 
            this.NumberY.FillWeight = 31.37694F;
            this.NumberY.HeaderText = "i";
            this.NumberY.MaxInputLength = 2;
            this.NumberY.Name = "NumberY";
            this.NumberY.ReadOnly = true;
            this.NumberY.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // RangeY
            // 
            this.RangeY.FillWeight = 115.1833F;
            this.RangeY.HeaderText = "[bᵢ₋₁ ; bᵢ)";
            this.RangeY.Name = "RangeY";
            this.RangeY.ReadOnly = true;
            this.RangeY.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // CountY
            // 
            this.CountY.FillWeight = 55.60566F;
            this.CountY.HeaderText = "mᵢ";
            this.CountY.Name = "CountY";
            this.CountY.ReadOnly = true;
            this.CountY.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // AverageY
            // 
            this.AverageY.FillWeight = 115.1833F;
            this.AverageY.HeaderText = "Y˟ᵢ";
            this.AverageY.Name = "AverageY";
            this.AverageY.ReadOnly = true;
            this.AverageY.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // HeightPoligonY
            // 
            this.HeightPoligonY.HeaderText = "mᵢ / n";
            this.HeightPoligonY.Name = "HeightPoligonY";
            this.HeightPoligonY.ReadOnly = true;
            // 
            // HeightGistY
            // 
            this.HeightGistY.FillWeight = 115.1833F;
            this.HeightGistY.HeaderText = "mᵢ /(n∙h)";
            this.HeightGistY.Name = "HeightGistY";
            this.HeightGistY.ReadOnly = true;
            this.HeightGistY.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // FuncY
            // 
            this.FuncY.FillWeight = 115.1833F;
            this.FuncY.HeaderText = "Fm(Y)";
            this.FuncY.Name = "FuncY";
            this.FuncY.ReadOnly = true;
            // 
            // openFile
            // 
            this.openFile.FileName = "openFileDialog1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(952, 564);
            this.Controls.Add(this.XandY);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.XandY.ResumeLayout(false);
            this.X.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.raspredX)).EndInit();
            this.Y.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.raspredY)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem менюToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem загрузитьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem сохранитьToolStripMenuItem;
        private System.Windows.Forms.TabControl XandY;
        private System.Windows.Forms.TabPage X;
        private System.Windows.Forms.DataGridView raspredX;
        private System.Windows.Forms.TabPage Y;
        private System.Windows.Forms.DataGridView raspredY;
        private System.Windows.Forms.OpenFileDialog openFile;
        private System.Windows.Forms.SaveFileDialog saveFile;
        private System.Windows.Forms.DataGridViewTextBoxColumn NumberX;
        private System.Windows.Forms.DataGridViewTextBoxColumn RangeX;
        private System.Windows.Forms.DataGridViewTextBoxColumn CountX;
        private System.Windows.Forms.DataGridViewTextBoxColumn AverageX;
        private System.Windows.Forms.DataGridViewTextBoxColumn HeightPoligonX;
        private System.Windows.Forms.DataGridViewTextBoxColumn HeightGistX;
        private System.Windows.Forms.DataGridViewTextBoxColumn FuncX;
        private System.Windows.Forms.DataGridViewTextBoxColumn NumberY;
        private System.Windows.Forms.DataGridViewTextBoxColumn RangeY;
        private System.Windows.Forms.DataGridViewTextBoxColumn CountY;
        private System.Windows.Forms.DataGridViewTextBoxColumn AverageY;
        private System.Windows.Forms.DataGridViewTextBoxColumn HeightPoligonY;
        private System.Windows.Forms.DataGridViewTextBoxColumn HeightGistY;
        private System.Windows.Forms.DataGridViewTextBoxColumn FuncY;
    }
}

