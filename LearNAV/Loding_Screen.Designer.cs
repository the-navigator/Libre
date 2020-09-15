namespace LearNAV
{
    partial class Loding_Screen
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
            this._elipse_ldng_screen = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.loading_progress = new Guna.UI2.WinForms.Guna2ProgressBar();
            this._elipse_loading_progress = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.prog = new System.ComponentModel.BackgroundWorker();
            this.SuspendLayout();
            // 
            // _elipse_ldng_screen
            // 
            this._elipse_ldng_screen.BorderRadius = 25;
            this._elipse_ldng_screen.TargetControl = this;
            // 
            // loading_progress
            // 
            this.loading_progress.FillColor = System.Drawing.Color.White;
            this.loading_progress.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal;
            this.loading_progress.Location = new System.Drawing.Point(12, 41);
            this.loading_progress.Name = "loading_progress";
            this.loading_progress.ProgressColor = System.Drawing.Color.FromArgb(((int)(((byte)(89)))), ((int)(((byte)(67)))), ((int)(((byte)(117)))));
            this.loading_progress.ProgressColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(115)))), ((int)(((byte)(194)))), ((int)(((byte)(196)))));
            this.loading_progress.ShadowDecoration.Parent = this.loading_progress;
            this.loading_progress.Size = new System.Drawing.Size(579, 30);
            this.loading_progress.TabIndex = 0;
            this.loading_progress.TextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault;
            // 
            // _elipse_loading_progress
            // 
            this._elipse_loading_progress.BorderRadius = 25;
            this._elipse_loading_progress.TargetControl = this.loading_progress;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Gelion Black", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(115)))), ((int)(((byte)(194)))), ((int)(((byte)(196)))));
            this.label1.Location = new System.Drawing.Point(190, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(236, 29);
            this.label1.TabIndex = 2;
            this.label1.Text = "Loading Resources...";
            // 
            // prog
            // 
            this.prog.DoWork += new System.ComponentModel.DoWorkEventHandler(this.prog_DoWork);
            // 
            // Loding_Screen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(41)))), ((int)(((byte)(54)))));
            this.ClientSize = new System.Drawing.Size(603, 93);
            this.Controls.Add(this.loading_progress);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Loding_Screen";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Loding_Screen";
            this.Load += new System.EventHandler(this.Loding_Screen_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Elipse _elipse_ldng_screen;
        private Guna.UI2.WinForms.Guna2ProgressBar loading_progress;
        private Guna.UI2.WinForms.Guna2Elipse _elipse_loading_progress;
        private System.Windows.Forms.Label label1;
        public System.ComponentModel.BackgroundWorker prog;
    }
}