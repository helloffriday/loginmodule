namespace inventory
{
    partial class DashboardForm
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.lblWelcome = new System.Windows.Forms.Label();
            this.lblRole = new System.Windows.Forms.Label();
            this.btnLogout = new System.Windows.Forms.Button();
            this.SuspendLayout();
            //
            // lblWelcome
            //
            this.lblWelcome.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold);
            this.lblWelcome.ForeColor = System.Drawing.Color.MidnightBlue;
            this.lblWelcome.Location = new System.Drawing.Point(0, 150);
            this.lblWelcome.Name = "lblWelcome";
            this.lblWelcome.Size = new System.Drawing.Size(900, 70);
            this.lblWelcome.Text = "Welcome!";
            this.lblWelcome.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            //
            // lblRole
            //
            this.lblRole.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.lblRole.Location = new System.Drawing.Point(0, 225);
            this.lblRole.Name = "lblRole";
            this.lblRole.Size = new System.Drawing.Size(900, 30);
            this.lblRole.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            //
            // btnLogout
            //
            this.btnLogout.BackColor = System.Drawing.Color.MidnightBlue;
            this.btnLogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogout.Font = new System.Drawing.Font("Segoe UI", 16F);
            this.btnLogout.ForeColor = System.Drawing.Color.White;
            this.btnLogout.Location = new System.Drawing.Point(375, 300);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(150, 50);
            this.btnLogout.TabIndex = 0;
            this.btnLogout.Text = "Logout";
            this.btnLogout.UseVisualStyleBackColor = false;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            //
            // DashboardForm
            //
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(215, 250, 255);
            this.ClientSize = new System.Drawing.Size(900, 590);
            this.Controls.Add(this.lblWelcome);
            this.Controls.Add(this.lblRole);
            this.Controls.Add(this.btnLogout);
            this.Name = "DashboardForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "INVENTORY MANAGEMENT SYSTEM - Dashboard";
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.Label lblWelcome;
        private System.Windows.Forms.Label lblRole;
        private System.Windows.Forms.Button btnLogout;
    }
}
