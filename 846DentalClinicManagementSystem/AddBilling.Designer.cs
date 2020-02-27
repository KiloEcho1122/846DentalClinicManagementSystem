namespace _846DentalClinicManagementSystem
{
    partial class AddBilling
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddBilling));
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.TopBillingPanel = new System.Windows.Forms.Panel();
            this.btn_Close = new Bunifu.Framework.UI.BunifuImageButton();
            this.txt_formHeader = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.pictureBox7 = new System.Windows.Forms.PictureBox();
            this.btn_AddBilling = new System.Windows.Forms.Button();
            this.lbl_TotalAmt = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.lbl_Total = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.TopBillingPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btn_Close)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).BeginInit();
            this.SuspendLayout();
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 5;
            this.bunifuElipse1.TargetControl = this;
            // 
            // TopBillingPanel
            // 
            this.TopBillingPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(60)))), ((int)(((byte)(90)))));
            this.TopBillingPanel.Controls.Add(this.btn_Close);
            this.TopBillingPanel.Controls.Add(this.txt_formHeader);
            this.TopBillingPanel.Controls.Add(this.pictureBox7);
            this.TopBillingPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.TopBillingPanel.Location = new System.Drawing.Point(0, 0);
            this.TopBillingPanel.Name = "TopBillingPanel";
            this.TopBillingPanel.Size = new System.Drawing.Size(379, 45);
            this.TopBillingPanel.TabIndex = 65;
            // 
            // btn_Close
            // 
            this.btn_Close.BackColor = System.Drawing.Color.Red;
            this.btn_Close.Image = ((System.Drawing.Image)(resources.GetObject("btn_Close.Image")));
            this.btn_Close.ImageActive = null;
            this.btn_Close.Location = new System.Drawing.Point(350, 0);
            this.btn_Close.Name = "btn_Close";
            this.btn_Close.Size = new System.Drawing.Size(29, 28);
            this.btn_Close.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btn_Close.TabIndex = 79;
            this.btn_Close.TabStop = false;
            this.btn_Close.Zoom = 10;
            this.btn_Close.Click += new System.EventHandler(this.btn_Close_Click);
            // 
            // txt_formHeader
            // 
            this.txt_formHeader.AutoSize = true;
            this.txt_formHeader.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_formHeader.ForeColor = System.Drawing.Color.Silver;
            this.txt_formHeader.Location = new System.Drawing.Point(53, 9);
            this.txt_formHeader.Name = "txt_formHeader";
            this.txt_formHeader.Size = new System.Drawing.Size(205, 22);
            this.txt_formHeader.TabIndex = 61;
            this.txt_formHeader.Text = "Add Billing Statement";
            // 
            // pictureBox7
            // 
            this.pictureBox7.BackgroundImage = global::_846DentalClinicManagementSystem.Properties.Resources.btninventory;
            this.pictureBox7.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox7.Location = new System.Drawing.Point(9, 6);
            this.pictureBox7.Name = "pictureBox7";
            this.pictureBox7.Size = new System.Drawing.Size(32, 28);
            this.pictureBox7.TabIndex = 60;
            this.pictureBox7.TabStop = false;
            // 
            // btn_AddBilling
            // 
            this.btn_AddBilling.BackColor = System.Drawing.Color.LightGoldenrodYellow;
            this.btn_AddBilling.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_AddBilling.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.btn_AddBilling.ForeColor = System.Drawing.Color.Black;
            this.btn_AddBilling.Location = new System.Drawing.Point(259, 143);
            this.btn_AddBilling.Margin = new System.Windows.Forms.Padding(0);
            this.btn_AddBilling.Name = "btn_AddBilling";
            this.btn_AddBilling.Size = new System.Drawing.Size(111, 42);
            this.btn_AddBilling.TabIndex = 65;
            this.btn_AddBilling.Text = "ADD";
            this.btn_AddBilling.UseVisualStyleBackColor = false;
            this.btn_AddBilling.Click += new System.EventHandler(this.btn_AddBilling_Click);
            this.btn_AddBilling.KeyDown += new System.Windows.Forms.KeyEventHandler(this.btn_AddBilling_KeyDown);
            // 
            // lbl_TotalAmt
            // 
            this.lbl_TotalAmt.AutoSize = true;
            this.lbl_TotalAmt.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_TotalAmt.ForeColor = System.Drawing.Color.Teal;
            this.lbl_TotalAmt.Location = new System.Drawing.Point(20, 88);
            this.lbl_TotalAmt.Name = "lbl_TotalAmt";
            this.lbl_TotalAmt.Size = new System.Drawing.Size(120, 20);
            this.lbl_TotalAmt.TabIndex = 76;
            this.lbl_TotalAmt.Text = "TOTAL AMOUNT\r\n";
            // 
            // lbl_Total
            // 
            this.lbl_Total.AutoSize = true;
            this.lbl_Total.BackColor = System.Drawing.Color.White;
            this.lbl_Total.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Total.ForeColor = System.Drawing.Color.Teal;
            this.lbl_Total.Location = new System.Drawing.Point(249, 88);
            this.lbl_Total.Name = "lbl_Total";
            this.lbl_Total.Size = new System.Drawing.Size(31, 20);
            this.lbl_Total.TabIndex = 80;
            this.lbl_Total.Text = "₱ 0";
            // 
            // AddBilling
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(379, 210);
            this.Controls.Add(this.lbl_Total);
            this.Controls.Add(this.btn_AddBilling);
            this.Controls.Add(this.lbl_TotalAmt);
            this.Controls.Add(this.TopBillingPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AddBilling";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AddBilling";
            this.Load += new System.EventHandler(this.AddBilling_Load);
            this.TopBillingPanel.ResumeLayout(false);
            this.TopBillingPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btn_Close)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private System.Windows.Forms.Panel TopBillingPanel;
        private Bunifu.Framework.UI.BunifuCustomLabel txt_formHeader;
        private System.Windows.Forms.PictureBox pictureBox7;
        private System.Windows.Forms.Button btn_AddBilling;
        private Bunifu.Framework.UI.BunifuCustomLabel lbl_TotalAmt;
        private Bunifu.Framework.UI.BunifuCustomLabel lbl_Total;
        private Bunifu.Framework.UI.BunifuImageButton btn_Close;
    }
}