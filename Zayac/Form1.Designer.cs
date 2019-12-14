namespace Zayac
{
    partial class MainForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.менюToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.загрузитьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.сохранитьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.XandY = new System.Windows.Forms.TabControl();
            this.X = new System.Windows.Forms.TabPage();
            this.button_Hipotezy_X = new System.Windows.Forms.Button();
            this.ToGraphicsX = new System.Windows.Forms.Button();
            this.ToMarksX = new System.Windows.Forms.Button();
            this.RashPromX = new System.Windows.Forms.TextBox();
            this.LenghtInterX = new System.Windows.Forms.TextBox();
            this.countInterX = new System.Windows.Forms.TextBox();
            this.razmahX = new System.Windows.Forms.TextBox();
            this.labelRash = new System.Windows.Forms.Label();
            this.labelLenghtInter = new System.Windows.Forms.Label();
            this.labelKolVoInter = new System.Windows.Forms.Label();
            this.labelRazmah = new System.Windows.Forms.Label();
            this.raspredX = new System.Windows.Forms.DataGridView();
            this.NumberX = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RangeX = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CountX = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AverageX = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HeightPoligonX = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HeightGistX = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FuncX = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Y = new System.Windows.Forms.TabPage();
            this.button_Hipotezy_Y = new System.Windows.Forms.Button();
            this.ToGraphicsY = new System.Windows.Forms.Button();
            this.ToMarksY = new System.Windows.Forms.Button();
            this.RashPromY = new System.Windows.Forms.TextBox();
            this.LenghtInterY = new System.Windows.Forms.TextBox();
            this.countInterY = new System.Windows.Forms.TextBox();
            this.razmahY = new System.Windows.Forms.TextBox();
            this.labelRashY = new System.Windows.Forms.Label();
            this.labelLenghtInterY = new System.Windows.Forms.Label();
            this.labelKolVoInterY = new System.Windows.Forms.Label();
            this.labelRazmahY = new System.Windows.Forms.Label();
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
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.HipotesyX = new System.Windows.Forms.Button();
            this.HipotesyY = new System.Windows.Forms.Button();
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
            this.XandY.Dock = System.Windows.Forms.DockStyle.Fill;
            this.XandY.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.XandY.Location = new System.Drawing.Point(0, 24);
            this.XandY.Name = "XandY";
            this.XandY.Padding = new System.Drawing.Point(3, 3);
            this.XandY.SelectedIndex = 0;
            this.XandY.Size = new System.Drawing.Size(952, 540);
            this.XandY.TabIndex = 1;
            // 
            // X
            // 
            this.X.BackColor = System.Drawing.Color.FloralWhite;
            this.X.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.X.Controls.Add(this.HipotesyX);
            this.X.Controls.Add(this.ToGraphicsX);
            this.X.Controls.Add(this.ToMarksX);
            this.X.Controls.Add(this.RashPromX);
            this.X.Controls.Add(this.LenghtInterX);
            this.X.Controls.Add(this.countInterX);
            this.X.Controls.Add(this.razmahX);
            this.X.Controls.Add(this.labelRash);
            this.X.Controls.Add(this.labelLenghtInter);
            this.X.Controls.Add(this.labelKolVoInter);
            this.X.Controls.Add(this.labelRazmah);
            this.X.Controls.Add(this.raspredX);
            this.X.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.X.Location = new System.Drawing.Point(4, 25);
            this.X.Name = "X";
            this.X.Padding = new System.Windows.Forms.Padding(3);
            this.X.Size = new System.Drawing.Size(944, 511);
            this.X.TabIndex = 0;
            this.X.Text = "Группированный ряд для X";
            this.X.Click += new System.EventHandler(this.X_Click);
            // 
            // button_Hipotezy_X
            // 
            this.button_Hipotezy_X.Location = new System.Drawing.Point(812, 357);
            this.button_Hipotezy_X.Name = "button_Hipotezy_X";
            this.button_Hipotezy_X.Size = new System.Drawing.Size(98, 23);
            this.button_Hipotezy_X.TabIndex = 21;
            this.button_Hipotezy_X.Text = "Гипотезы";
            this.button_Hipotezy_X.UseVisualStyleBackColor = true;
            this.button_Hipotezy_X.Click += new System.EventHandler(this.Button_Hipotezy_X_Click);
            // 
            // ToGraphicsX
            // 
            this.ToGraphicsX.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ToGraphicsX.Location = new System.Drawing.Point(811, 306);
            this.ToGraphicsX.Name = "ToGraphicsX";
            this.ToGraphicsX.Size = new System.Drawing.Size(99, 23);
            this.ToGraphicsX.TabIndex = 20;
            this.ToGraphicsX.Text = "Графики";
            this.ToGraphicsX.UseVisualStyleBackColor = true;
            this.ToGraphicsX.Click += new System.EventHandler(this.ToGraphicsX_Click);
            // 
            // ToMarksX
            // 
            this.ToMarksX.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ToMarksX.Location = new System.Drawing.Point(811, 236);
            this.ToMarksX.Name = "ToMarksX";
            this.ToMarksX.Size = new System.Drawing.Size(99, 43);
            this.ToMarksX.TabIndex = 10;
            this.ToMarksX.Text = "Точечные оценки";
            this.ToMarksX.UseVisualStyleBackColor = true;
            this.ToMarksX.Click += new System.EventHandler(this.ToMarksX_Click);
            // 
            // RashPromX
            // 
            this.RashPromX.Enabled = false;
            this.RashPromX.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.RashPromX.Location = new System.Drawing.Point(812, 156);
            this.RashPromX.Name = "RashPromX";
            this.RashPromX.Size = new System.Drawing.Size(100, 22);
            this.RashPromX.TabIndex = 9;
            this.RashPromX.TextChanged += new System.EventHandler(this.RashPromX_TextChanged);
            this.RashPromX.MouseHover += new System.EventHandler(this.RashPromX_MouseHover);
            // 
            // LenghtInterX
            // 
            this.LenghtInterX.Enabled = false;
            this.LenghtInterX.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LenghtInterX.Location = new System.Drawing.Point(812, 110);
            this.LenghtInterX.Name = "LenghtInterX";
            this.LenghtInterX.Size = new System.Drawing.Size(100, 22);
            this.LenghtInterX.TabIndex = 8;
            this.LenghtInterX.TextChanged += new System.EventHandler(this.LenghtInterX_TextChanged);
            // 
            // countInterX
            // 
            this.countInterX.Enabled = false;
            this.countInterX.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.countInterX.Location = new System.Drawing.Point(812, 61);
            this.countInterX.Name = "countInterX";
            this.countInterX.Size = new System.Drawing.Size(100, 22);
            this.countInterX.TabIndex = 7;
            // 
            // razmahX
            // 
            this.razmahX.Enabled = false;
            this.razmahX.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.razmahX.Location = new System.Drawing.Point(812, 10);
            this.razmahX.Name = "razmahX";
            this.razmahX.Size = new System.Drawing.Size(100, 22);
            this.razmahX.TabIndex = 6;
            this.razmahX.Text = " ";
            // 
            // labelRash
            // 
            this.labelRash.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelRash.Location = new System.Drawing.Point(637, 145);
            this.labelRash.Name = "labelRash";
            this.labelRash.Size = new System.Drawing.Size(151, 48);
            this.labelRash.TabIndex = 5;
            this.labelRash.Text = "Расширение промежутка разбиения";
            // 
            // labelLenghtInter
            // 
            this.labelLenghtInter.AutoSize = true;
            this.labelLenghtInter.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelLenghtInter.Location = new System.Drawing.Point(637, 116);
            this.labelLenghtInter.Name = "labelLenghtInter";
            this.labelLenghtInter.Size = new System.Drawing.Size(162, 16);
            this.labelLenghtInter.TabIndex = 4;
            this.labelLenghtInter.Text = "Длина интервала h =";
            // 
            // labelKolVoInter
            // 
            this.labelKolVoInter.AutoSize = true;
            this.labelKolVoInter.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelKolVoInter.Location = new System.Drawing.Point(637, 67);
            this.labelKolVoInter.Name = "labelKolVoInter";
            this.labelKolVoInter.Size = new System.Drawing.Size(172, 16);
            this.labelKolVoInter.TabIndex = 3;
            this.labelKolVoInter.Text = "Кол-во интервалов r =";
            // 
            // labelRazmah
            // 
            this.labelRazmah.AutoSize = true;
            this.labelRazmah.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelRazmah.Location = new System.Drawing.Point(637, 16);
            this.labelRazmah.Name = "labelRazmah";
            this.labelRazmah.Size = new System.Drawing.Size(156, 16);
            this.labelRazmah.TabIndex = 2;
            this.labelRazmah.Text = "Размах выборки R =";
            // 
            // raspredX
            // 
            this.raspredX.AllowUserToAddRows = false;
            this.raspredX.AllowUserToDeleteRows = false;
            this.raspredX.AllowUserToOrderColumns = true;
            this.raspredX.AllowUserToResizeColumns = false;
            this.raspredX.AllowUserToResizeRows = false;
            this.raspredX.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle10.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle10.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle10.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle10.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.raspredX.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle10;
            this.raspredX.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.raspredX.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.NumberX,
            this.RangeX,
            this.CountX,
            this.AverageX,
            this.HeightPoligonX,
            this.HeightGistX,
            this.FuncX});
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle11.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle11.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle11.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle11.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle11.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.raspredX.DefaultCellStyle = dataGridViewCellStyle11;
            this.raspredX.EnableHeadersVisualStyles = false;
            this.raspredX.Location = new System.Drawing.Point(-2, -2);
            this.raspredX.Name = "raspredX";
            this.raspredX.ReadOnly = true;
            dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle12.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle12.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle12.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle12.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle12.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle12.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.raspredX.RowHeadersDefaultCellStyle = dataGridViewCellStyle12;
            this.raspredX.RowHeadersVisible = false;
            this.raspredX.RowTemplate.ReadOnly = true;
            this.raspredX.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.raspredX.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.raspredX.Size = new System.Drawing.Size(633, 181);
            this.raspredX.TabIndex = 1;
            this.raspredX.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.RaspredX_CellContentClick);
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
            this.Y.Controls.Add(this.HipotesyY);
            this.Y.Controls.Add(this.ToGraphicsY);
            this.Y.Controls.Add(this.ToMarksY);
            this.Y.Controls.Add(this.RashPromY);
            this.Y.Controls.Add(this.LenghtInterY);
            this.Y.Controls.Add(this.countInterY);
            this.Y.Controls.Add(this.razmahY);
            this.Y.Controls.Add(this.labelRashY);
            this.Y.Controls.Add(this.labelLenghtInterY);
            this.Y.Controls.Add(this.labelKolVoInterY);
            this.Y.Controls.Add(this.labelRazmahY);
            this.Y.Controls.Add(this.raspredY);
            this.Y.Cursor = System.Windows.Forms.Cursors.Default;
            this.Y.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Y.Location = new System.Drawing.Point(4, 25);
            this.Y.Name = "Y";
            this.Y.Padding = new System.Windows.Forms.Padding(3);
            this.Y.Size = new System.Drawing.Size(944, 511);
            this.Y.TabIndex = 1;
            this.Y.Text = "Группированный ряд для Y";
            // 
            // button_Hipotezy_Y
            // 
            this.button_Hipotezy_Y.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_Hipotezy_Y.Location = new System.Drawing.Point(811, 358);
            this.button_Hipotezy_Y.Name = "button_Hipotezy_Y";
            this.button_Hipotezy_Y.Size = new System.Drawing.Size(99, 23);
            this.button_Hipotezy_Y.TabIndex = 20;
            this.button_Hipotezy_Y.Text = "Гипотезы";
            this.button_Hipotezy_Y.UseVisualStyleBackColor = true;
            this.button_Hipotezy_Y.Click += new System.EventHandler(this.Button_Hipotezy_Y_Click);
            // 
            // ToGraphicsY
            // 
            this.ToGraphicsY.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ToGraphicsY.Location = new System.Drawing.Point(811, 306);
            this.ToGraphicsY.Name = "ToGraphicsY";
            this.ToGraphicsY.Size = new System.Drawing.Size(99, 23);
            this.ToGraphicsY.TabIndex = 19;
            this.ToGraphicsY.Text = "Графики";
            this.ToGraphicsY.UseVisualStyleBackColor = true;
            this.ToGraphicsY.Click += new System.EventHandler(this.ToGraphicsY_Click);
            // 
            // ToMarksY
            // 
            this.ToMarksY.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ToMarksY.Location = new System.Drawing.Point(811, 236);
            this.ToMarksY.Name = "ToMarksY";
            this.ToMarksY.Size = new System.Drawing.Size(99, 43);
            this.ToMarksY.TabIndex = 18;
            this.ToMarksY.Text = "Точечные оценки";
            this.ToMarksY.UseVisualStyleBackColor = true;
            this.ToMarksY.Click += new System.EventHandler(this.ToMarksY_Click);
            // 
            // RashPromY
            // 
            this.RashPromY.Enabled = false;
            this.RashPromY.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.RashPromY.Location = new System.Drawing.Point(812, 156);
            this.RashPromY.Name = "RashPromY";
            this.RashPromY.Size = new System.Drawing.Size(100, 22);
            this.RashPromY.TabIndex = 17;
            // 
            // LenghtInterY
            // 
            this.LenghtInterY.Enabled = false;
            this.LenghtInterY.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LenghtInterY.Location = new System.Drawing.Point(812, 110);
            this.LenghtInterY.Name = "LenghtInterY";
            this.LenghtInterY.Size = new System.Drawing.Size(100, 22);
            this.LenghtInterY.TabIndex = 16;
            // 
            // countInterY
            // 
            this.countInterY.Enabled = false;
            this.countInterY.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.countInterY.Location = new System.Drawing.Point(812, 61);
            this.countInterY.Name = "countInterY";
            this.countInterY.Size = new System.Drawing.Size(100, 22);
            this.countInterY.TabIndex = 15;
            // 
            // razmahY
            // 
            this.razmahY.Enabled = false;
            this.razmahY.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.razmahY.Location = new System.Drawing.Point(812, 10);
            this.razmahY.Name = "razmahY";
            this.razmahY.Size = new System.Drawing.Size(100, 22);
            this.razmahY.TabIndex = 14;
            this.razmahY.TextChanged += new System.EventHandler(this.RazmahY_TextChanged);
            // 
            // labelRashY
            // 
            this.labelRashY.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelRashY.Location = new System.Drawing.Point(637, 145);
            this.labelRashY.Name = "labelRashY";
            this.labelRashY.Size = new System.Drawing.Size(151, 48);
            this.labelRashY.TabIndex = 13;
            this.labelRashY.Text = "Расширение промежутка разбиения";
            // 
            // labelLenghtInterY
            // 
            this.labelLenghtInterY.AutoSize = true;
            this.labelLenghtInterY.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelLenghtInterY.Location = new System.Drawing.Point(637, 116);
            this.labelLenghtInterY.Name = "labelLenghtInterY";
            this.labelLenghtInterY.Size = new System.Drawing.Size(162, 16);
            this.labelLenghtInterY.TabIndex = 12;
            this.labelLenghtInterY.Text = "Длина интервала h =";
            // 
            // labelKolVoInterY
            // 
            this.labelKolVoInterY.AutoSize = true;
            this.labelKolVoInterY.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelKolVoInterY.Location = new System.Drawing.Point(637, 67);
            this.labelKolVoInterY.Name = "labelKolVoInterY";
            this.labelKolVoInterY.Size = new System.Drawing.Size(172, 16);
            this.labelKolVoInterY.TabIndex = 11;
            this.labelKolVoInterY.Text = "Кол-во интервалов r =";
            // 
            // labelRazmahY
            // 
            this.labelRazmahY.AutoSize = true;
            this.labelRazmahY.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelRazmahY.Location = new System.Drawing.Point(637, 16);
            this.labelRazmahY.Name = "labelRazmahY";
            this.labelRazmahY.Size = new System.Drawing.Size(156, 16);
            this.labelRazmahY.TabIndex = 10;
            this.labelRazmahY.Text = "Размах выборки R =";
            // 
            // raspredY
            // 
            this.raspredY.AllowUserToAddRows = false;
            this.raspredY.AllowUserToDeleteRows = false;
            this.raspredY.AllowUserToOrderColumns = true;
            this.raspredY.AllowUserToResizeColumns = false;
            this.raspredY.AllowUserToResizeRows = false;
            this.raspredY.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.raspredY.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.raspredY.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.raspredY.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.NumberY,
            this.RangeY,
            this.CountY,
            this.AverageY,
            this.HeightPoligonY,
            this.HeightGistY,
            this.FuncY});
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.raspredY.DefaultCellStyle = dataGridViewCellStyle8;
            this.raspredY.EnableHeadersVisualStyles = false;
            this.raspredY.Location = new System.Drawing.Point(-2, -2);
            this.raspredY.Name = "raspredY";
            this.raspredY.ReadOnly = true;
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle9.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.raspredY.RowHeadersDefaultCellStyle = dataGridViewCellStyle9;
            this.raspredY.RowHeadersVisible = false;
            this.raspredY.RowTemplate.ReadOnly = true;
            this.raspredY.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.raspredY.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.raspredY.Size = new System.Drawing.Size(633, 181);
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
            this.FuncY.HeaderText = "Fn(Y)";
            this.FuncY.Name = "FuncY";
            this.FuncY.ReadOnly = true;
            // 
            // openFile
            // 
            this.openFile.FileName = "openFileDialog1";
            // 
            // HipotesyX
            // 
            this.HipotesyX.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.HipotesyX.Location = new System.Drawing.Point(812, 356);
            this.HipotesyX.Name = "HipotesyX";
            this.HipotesyX.Size = new System.Drawing.Size(98, 43);
            this.HipotesyX.TabIndex = 21;
            this.HipotesyX.Text = "Проверка гипотезы";
            this.HipotesyX.UseVisualStyleBackColor = true;
            this.HipotesyX.Click += new System.EventHandler(this.HipotesyX_Click);
            // 
            // HipotesyY
            // 
            this.HipotesyY.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.HipotesyY.Location = new System.Drawing.Point(812, 356);
            this.HipotesyY.Name = "HipotesyY";
            this.HipotesyY.Size = new System.Drawing.Size(98, 43);
            this.HipotesyY.TabIndex = 22;
            this.HipotesyY.Text = "Проверка гипотезы";
            this.HipotesyY.UseVisualStyleBackColor = true;
            this.HipotesyY.Click += new System.EventHandler(this.HipotesyY_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(952, 564);
            this.Controls.Add(this.XandY);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.Text = "Расчётное задание";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.XandY.ResumeLayout(false);
            this.X.ResumeLayout(false);
            this.X.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.raspredX)).EndInit();
            this.Y.ResumeLayout(false);
            this.Y.PerformLayout();
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
        private System.Windows.Forms.TextBox RashPromX;
        private System.Windows.Forms.TextBox LenghtInterX;
        private System.Windows.Forms.TextBox countInterX;
        private System.Windows.Forms.TextBox razmahX;
        private System.Windows.Forms.Label labelRash;
        private System.Windows.Forms.Label labelLenghtInter;
        private System.Windows.Forms.Label labelKolVoInter;
        private System.Windows.Forms.Label labelRazmah;
        private System.Windows.Forms.TextBox RashPromY;
        private System.Windows.Forms.TextBox LenghtInterY;
        private System.Windows.Forms.TextBox countInterY;
        private System.Windows.Forms.TextBox razmahY;
        private System.Windows.Forms.Label labelRashY;
        private System.Windows.Forms.Label labelLenghtInterY;
        private System.Windows.Forms.Label labelKolVoInterY;
        private System.Windows.Forms.Label labelRazmahY;
        private System.Windows.Forms.Button ToMarksX;
        private System.Windows.Forms.Button ToMarksY;
        private System.Windows.Forms.Button ToGraphicsX;
        private System.Windows.Forms.Button ToGraphicsY;
        private System.Windows.Forms.DataGridViewTextBoxColumn NumberY;
        private System.Windows.Forms.DataGridViewTextBoxColumn RangeY;
        private System.Windows.Forms.DataGridViewTextBoxColumn CountY;
        private System.Windows.Forms.DataGridViewTextBoxColumn AverageY;
        private System.Windows.Forms.DataGridViewTextBoxColumn HeightPoligonY;
        private System.Windows.Forms.DataGridViewTextBoxColumn HeightGistY;
        private System.Windows.Forms.DataGridViewTextBoxColumn FuncY;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.Button HipotesyX;
        private System.Windows.Forms.Button HipotesyY;
    }
}

