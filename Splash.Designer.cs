namespace Hostel_Managment_System
{
    partial class Splash
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Splash));
            this.ElipseFrm = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.CircleProgress = new Bunifu.UI.WinForms.BunifuCircleProgress();
            this.label1 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // ElipseFrm
            // 
            this.ElipseFrm.ElipseRadius = 500;
            this.ElipseFrm.TargetControl = this;
            // 
            // CircleProgress
            // 
            this.CircleProgress.Animated = true;
            this.CircleProgress.AnimationInterval = 1;
            this.CircleProgress.AnimationSpeed = 1;
            this.CircleProgress.BackColor = System.Drawing.Color.Transparent;
            this.CircleProgress.CircleMargin = 10;
            this.CircleProgress.Font = new System.Drawing.Font("Microsoft Sans Serif", 4.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CircleProgress.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(43)))), ((int)(((byte)(59)))));
            this.CircleProgress.IsPercentage = true;
            this.CircleProgress.LineProgressThickness = 5;
            this.CircleProgress.LineThickness = 4;
            this.CircleProgress.Location = new System.Drawing.Point(158, 377);
            this.CircleProgress.Name = "CircleProgress";
            this.CircleProgress.ProgressBackColor = System.Drawing.Color.Gainsboro;
            this.CircleProgress.ProgressColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(215)))), ((int)(((byte)(35)))));
            this.CircleProgress.SecondaryFont = new System.Drawing.Font("Microsoft Sans Serif", 4.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CircleProgress.Size = new System.Drawing.Size(84, 84);
            this.CircleProgress.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.CircleProgress.SubScriptColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(43)))), ((int)(((byte)(59)))));
            this.CircleProgress.SubScriptMargin = new System.Windows.Forms.Padding(5, -35, 0, 0);
            this.CircleProgress.SubScriptText = "";
            this.CircleProgress.SuperScriptColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(43)))), ((int)(((byte)(59)))));
            this.CircleProgress.SuperScriptMargin = new System.Windows.Forms.Padding(5, 50, 0, 0);
            this.CircleProgress.SuperScriptText = "";
            this.CircleProgress.TabIndex = 16;
            this.CircleProgress.Text = "";
            this.CircleProgress.TextMargin = new System.Windows.Forms.Padding(8, 8, 0, 0);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Yummy Delivery Blur", 25.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Yellow;
            this.label1.Location = new System.Drawing.Point(49, 91);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(286, 53);
            this.label1.TabIndex = 17;
            this.label1.Text = "Genesis Hostel";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Splash
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(406, 494);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.CircleProgress);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Splash";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Bunifu.Framework.UI.BunifuElipse ElipseFrm;
        private Bunifu.UI.WinForms.BunifuCircleProgress CircleProgress;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Timer timer1;
    }
}

