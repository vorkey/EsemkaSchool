namespace EsemkaSchool
{
    partial class AdminMainForm
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
            this.btnMasterMajor = new System.Windows.Forms.Button();
            this.btnMasterTestSchedule = new System.Windows.Forms.Button();
            this.btnReview = new System.Windows.Forms.Button();
            this.btnLogout = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnMasterMajor
            // 
            this.btnMasterMajor.Location = new System.Drawing.Point(45, 61);
            this.btnMasterMajor.Name = "btnMasterMajor";
            this.btnMasterMajor.Size = new System.Drawing.Size(200, 32);
            this.btnMasterMajor.TabIndex = 0;
            this.btnMasterMajor.Text = "Master Major";
            this.btnMasterMajor.UseVisualStyleBackColor = true;
            this.btnMasterMajor.Click += new System.EventHandler(this.btnMasterMajor_Click);
            // 
            // btnMasterTestSchedule
            // 
            this.btnMasterTestSchedule.Location = new System.Drawing.Point(45, 99);
            this.btnMasterTestSchedule.Name = "btnMasterTestSchedule";
            this.btnMasterTestSchedule.Size = new System.Drawing.Size(200, 32);
            this.btnMasterTestSchedule.TabIndex = 1;
            this.btnMasterTestSchedule.Text = "Master Test Schedule";
            this.btnMasterTestSchedule.UseVisualStyleBackColor = true;
            this.btnMasterTestSchedule.Click += new System.EventHandler(this.btnMasterTestSchedule_Click);
            // 
            // btnReview
            // 
            this.btnReview.Location = new System.Drawing.Point(45, 137);
            this.btnReview.Name = "btnReview";
            this.btnReview.Size = new System.Drawing.Size(200, 32);
            this.btnReview.TabIndex = 2;
            this.btnReview.Text = "Review Registration Documents";
            this.btnReview.UseVisualStyleBackColor = true;
            this.btnReview.Click += new System.EventHandler(this.btnReview_Click);
            // 
            // btnLogout
            // 
            this.btnLogout.Location = new System.Drawing.Point(45, 214);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(200, 32);
            this.btnLogout.TabIndex = 3;
            this.btnLogout.Text = "Logout";
            this.btnLogout.UseVisualStyleBackColor = true;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(176, 24);
            this.label1.TabIndex = 4;
            this.label1.Text = "Admin Main Form";
            // 
            // AdminMainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(290, 306);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnLogout);
            this.Controls.Add(this.btnReview);
            this.Controls.Add(this.btnMasterTestSchedule);
            this.Controls.Add(this.btnMasterMajor);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "AdminMainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Admin Main Form";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.AdminMainForm_FormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnMasterMajor;
        private System.Windows.Forms.Button btnMasterTestSchedule;
        private System.Windows.Forms.Button btnReview;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.Label label1;
    }
}