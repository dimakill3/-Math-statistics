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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.менюToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.загрузитьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.сохранитьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.XandY = new System.Windows.Forms.TabControl();
            this.X = new System.Windows.Forms.TabPage();
            this.Y = new System.Windows.Forms.TabPage();
            this.raspredX = new System.Windows.Forms.DataGridView();
            this.raspredY = new System.Windows.Forms.DataGridView();
            this.NumberY = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RangeY = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CountY = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AverageY = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HeightY = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FuncY = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NumberX = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RangeX = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CountX = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AverageX = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HeightX = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FuncX = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.openFile = new System.Windows.Forms.OpenFileDialog();
            this.saveFile = new System.Windows.Forms.SaveFileDialog();
            this.menuStrip1.SuspendLayout();
            this.XandY.SuspendLayout();
            this.X.SuspendLayout();
            this.Y.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.raspredX)).BeginInit();
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
            this.загрузитьToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.загрузитьToolStripMenuItem.Text = "Загрузить";
            this.загрузитьToolStripMenuItem.Click += new System.EventHandler(this.загрузитьToolStripMenuItem_Click);
            // 
            // сохранитьToolStripMenuItem
            // 
            this.сохранитьToolStripMenuItem.Name = "сохранитьToolStripMenuItem";
            this.сохранитьToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
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
            // raspredX
            // 
            this.raspredX.AllowUserToDeleteRows = false;
            this.raspredX.AllowUserToOrderColumns = true;
            this.raspredX.AllowUserToResizeColumns = false;
            this.raspredX.AllowUserToResizeRows = false;
            this.raspredX.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.raspredX.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.raspredX.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.raspredX.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.NumberX,
            this.RangeX,
            this.CountX,
            this.AverageX,
            this.HeightX,
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
            // raspredY
            // 
            this.raspredY.AllowUserToDeleteRows = false;
            this.raspredY.AllowUserToOrderColumns = true;
            this.raspredY.AllowUserToResizeColumns = false;
            this.raspredY.AllowUserToResizeRows = false;
            this.raspredY.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.raspredY.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.raspredY.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.raspredY.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.NumberY,
            this.RangeY,
            this.CountY,
            this.AverageY,
            this.HeightY,
            this.FuncY});
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.raspredY.DefaultCellStyle = dataGridViewCellStyle7;
            this.raspredY.EnableHeadersVisualStyles = false;
            this.raspredY.Location = new System.Drawing.Point(-2, -2);
            this.raspredY.Name = "raspredY";
            this.raspredY.ReadOnly = true;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.raspredY.RowHeadersDefaultCellStyle = dataGridViewCellStyle8;
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
            this.RangeY.HeaderText = "[aᵢ₋₁ ; aᵢ)";
            this.RangeY.Name = "RangeY";
            this.RangeY.ReadOnly = true;
            this.RangeY.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // CountY
            // 
            this.CountY.FillWeight = 55.60566F;
            this.CountY.HeaderText = "nᵢ";
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
            // HeightY
            // 
            this.HeightY.FillWeight = 115.1833F;
            this.HeightY.HeaderText = "nᵢ /(n∙h)";
            this.HeightY.Name = "HeightY";
            this.HeightY.ReadOnly = true;
            this.HeightY.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // FuncY
            // 
            this.FuncY.FillWeight = 115.1833F;
            this.FuncY.HeaderText = "Fn(Y)";
            this.FuncY.Name = "FuncY";
            this.FuncY.ReadOnly = true;
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
            // HeightX
            // 
            this.HeightX.FillWeight = 115.1833F;
            this.HeightX.HeaderText = "nᵢ /(n∙h)";
            this.HeightX.Name = "HeightX";
            this.HeightX.ReadOnly = true;
            this.HeightX.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // FuncX
            // 
            this.FuncX.FillWeight = 115.1833F;
            this.FuncX.HeaderText = "Fn(X)";
            this.FuncX.Name = "FuncX";
            this.FuncX.ReadOnly = true;
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
            this.Y.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.raspredX)).EndInit();
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
        private System.Windows.Forms.DataGridViewTextBoxColumn NumberX;
        private System.Windows.Forms.DataGridViewTextBoxColumn RangeX;
        private System.Windows.Forms.DataGridViewTextBoxColumn CountX;
        private System.Windows.Forms.DataGridViewTextBoxColumn AverageX;
        private System.Windows.Forms.DataGridViewTextBoxColumn HeightX;
        private System.Windows.Forms.DataGridViewTextBoxColumn FuncX;
        private System.Windows.Forms.DataGridViewTextBoxColumn NumberY;
        private System.Windows.Forms.DataGridViewTextBoxColumn RangeY;
        private System.Windows.Forms.DataGridViewTextBoxColumn CountY;
        private System.Windows.Forms.DataGridViewTextBoxColumn AverageY;
        private System.Windows.Forms.DataGridViewTextBoxColumn HeightY;
        private System.Windows.Forms.DataGridViewTextBoxColumn FuncY;
        private System.Windows.Forms.OpenFileDialog openFile;
        private System.Windows.Forms.SaveFileDialog saveFile;
    }
}

