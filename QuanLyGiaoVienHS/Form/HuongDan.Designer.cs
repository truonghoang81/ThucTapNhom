namespace QuanLyGiaoVienHS
{
    partial class HuongDan
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HuongDan));
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.btThoatTroGiup = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // richTextBox1
            // 
            this.richTextBox1.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.richTextBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.richTextBox1.Location = new System.Drawing.Point(3, 322);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(796, 174);
            this.richTextBox1.TabIndex = 0;
            this.richTextBox1.Text = resources.GetString("richTextBox1.Text");
            // 
            // btThoatTroGiup
            // 
            this.btThoatTroGiup.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btThoatTroGiup.Image = global::QuanLyGiaoVienHS.Properties.Resources.Cancel;
            this.btThoatTroGiup.Location = new System.Drawing.Point(740, 450);
            this.btThoatTroGiup.Name = "btThoatTroGiup";
            this.btThoatTroGiup.Size = new System.Drawing.Size(59, 46);
            this.btThoatTroGiup.TabIndex = 1;
            this.btThoatTroGiup.Text = "Thoát";
            this.btThoatTroGiup.UseVisualStyleBackColor = false;
            this.btThoatTroGiup.Click += new System.EventHandler(this.btThoatTroGiup_Click);
            // 
            // HuongDan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::QuanLyGiaoVienHS.Properties.Resources._1_Ngaykhaigiang;
            this.ClientSize = new System.Drawing.Size(797, 496);
            this.Controls.Add(this.btThoatTroGiup);
            this.Controls.Add(this.richTextBox1);
            this.Name = "HuongDan";
            this.Text = "HuongDan";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Button btThoatTroGiup;
    }
}