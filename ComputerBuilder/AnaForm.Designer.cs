namespace ComputerBuilder
{
    partial class AnaForm
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
            this.bilgiPanel = new System.Windows.Forms.Panel();
            this.bilgisayarPanel = new System.Windows.Forms.Panel();
            this.oyunAlanıPanel = new System.Windows.Forms.Panel();
            this.sureLabel = new System.Windows.Forms.Label();
            this.bilgiPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // bilgiPanel
            // 
            this.bilgiPanel.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.bilgiPanel.Controls.Add(this.sureLabel);
            this.bilgiPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.bilgiPanel.Location = new System.Drawing.Point(0, 0);
            this.bilgiPanel.Name = "bilgiPanel";
            this.bilgiPanel.Size = new System.Drawing.Size(1128, 92);
            this.bilgiPanel.TabIndex = 0;
            // 
            // bilgisayarPanel
            // 
            this.bilgisayarPanel.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.bilgisayarPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.bilgisayarPanel.Location = new System.Drawing.Point(0, 607);
            this.bilgisayarPanel.Name = "bilgisayarPanel";
            this.bilgisayarPanel.Size = new System.Drawing.Size(1128, 50);
            this.bilgisayarPanel.TabIndex = 1;
            // 
            // oyunAlanıPanel
            // 
            this.oyunAlanıPanel.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.oyunAlanıPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.oyunAlanıPanel.Location = new System.Drawing.Point(0, 92);
            this.oyunAlanıPanel.Name = "oyunAlanıPanel";
            this.oyunAlanıPanel.Size = new System.Drawing.Size(1128, 515);
            this.oyunAlanıPanel.TabIndex = 2;
            // 
            // sureLabel
            // 
            this.sureLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.sureLabel.BackColor = System.Drawing.Color.Transparent;
            this.sureLabel.Font = new System.Drawing.Font("Times New Roman", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.sureLabel.Location = new System.Drawing.Point(914, 13);
            this.sureLabel.Name = "sureLabel";
            this.sureLabel.Size = new System.Drawing.Size(202, 76);
            this.sureLabel.TabIndex = 0;
            this.sureLabel.Text = "0:00";
            this.sureLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // AnaForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1128, 657);
            this.Controls.Add(this.oyunAlanıPanel);
            this.Controls.Add(this.bilgisayarPanel);
            this.Controls.Add(this.bilgiPanel);
            this.Name = "AnaForm";
            this.Text = "Form1";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.AnaForm_KeyDown_1);
            this.bilgiPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel bilgiPanel;
        private System.Windows.Forms.Label sureLabel;
        private System.Windows.Forms.Panel bilgisayarPanel;
        private System.Windows.Forms.Panel oyunAlanıPanel;
    }
}

