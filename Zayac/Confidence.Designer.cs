namespace Zayac
{
    partial class Confidence
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
            this.label_dover_MX_min = new System.Windows.Forms.Label();
            this.label_dover_MX_max = new System.Windows.Forms.Label();
            this.label_dover_DX_min = new System.Windows.Forms.Label();
            this.label_dover_DX_max = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label_dover_MX_min
            // 
            this.label_dover_MX_min.AutoSize = true;
            this.label_dover_MX_min.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_dover_MX_min.Location = new System.Drawing.Point(51, 50);
            this.label_dover_MX_min.Name = "label_dover_MX_min";
            this.label_dover_MX_min.Size = new System.Drawing.Size(66, 24);
            this.label_dover_MX_min.TabIndex = 2;
            this.label_dover_MX_min.Text = "label1";
            // 
            // label_dover_MX_max
            // 
            this.label_dover_MX_max.AutoSize = true;
            this.label_dover_MX_max.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_dover_MX_max.Location = new System.Drawing.Point(269, 50);
            this.label_dover_MX_max.Name = "label_dover_MX_max";
            this.label_dover_MX_max.Size = new System.Drawing.Size(66, 24);
            this.label_dover_MX_max.TabIndex = 3;
            this.label_dover_MX_max.Text = "label1";
            // 
            // label_dover_DX_min
            // 
            this.label_dover_DX_min.AutoSize = true;
            this.label_dover_DX_min.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_dover_DX_min.Location = new System.Drawing.Point(51, 114);
            this.label_dover_DX_min.Name = "label_dover_DX_min";
            this.label_dover_DX_min.Size = new System.Drawing.Size(66, 24);
            this.label_dover_DX_min.TabIndex = 4;
            this.label_dover_DX_min.Text = "label2";
            // 
            // label_dover_DX_max
            // 
            this.label_dover_DX_max.AutoSize = true;
            this.label_dover_DX_max.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_dover_DX_max.Location = new System.Drawing.Point(269, 114);
            this.label_dover_DX_max.Name = "label_dover_DX_max";
            this.label_dover_DX_max.Size = new System.Drawing.Size(66, 24);
            this.label_dover_DX_max.TabIndex = 5;
            this.label_dover_DX_max.Text = "label3";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::Zayac.Properties.Resources.Скриншот_15_12_2019_184258;
            this.pictureBox2.Location = new System.Drawing.Point(133, 111);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(115, 27);
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Zayac.Properties.Resources.Скриншот_15_12_2019_184246;
            this.pictureBox1.Location = new System.Drawing.Point(133, 45);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(115, 29);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // Confidence
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(398, 193);
            this.Controls.Add(this.label_dover_DX_max);
            this.Controls.Add(this.label_dover_DX_min);
            this.Controls.Add(this.label_dover_MX_max);
            this.Controls.Add(this.label_dover_MX_min);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Confidence";
            this.Text = "Confidence";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Confidence_FormClosed);
            this.Load += new System.EventHandler(this.Confidence_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label_dover_MX_min;
        private System.Windows.Forms.Label label_dover_MX_max;
        private System.Windows.Forms.Label label_dover_DX_min;
        private System.Windows.Forms.Label label_dover_DX_max;
    }
}