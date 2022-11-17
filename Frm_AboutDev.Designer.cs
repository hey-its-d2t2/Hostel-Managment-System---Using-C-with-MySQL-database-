namespace Hostel_Managment_System
{
    partial class Frm_AboutDev
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_AboutDev));
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges1 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties stateProperties1 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties();
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties stateProperties2 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties();
            this.BtnExit = new Bunifu.UI.WinForms.BunifuImageButton();
            this.PnlTop = new System.Windows.Forms.Panel();
            this.LblTitle = new System.Windows.Forms.Label();
            this.PnlBotttom = new System.Windows.Forms.Panel();
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.bunifuDragControl1 = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.BtnBack = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.PnlTop.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // BtnExit
            // 
            this.BtnExit.ActiveImage = null;
            this.BtnExit.AllowAnimations = true;
            this.BtnExit.AllowBuffering = false;
            this.BtnExit.AllowZooming = true;
            this.BtnExit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(215)))), ((int)(((byte)(35)))));
            this.BtnExit.ErrorImage = ((System.Drawing.Image)(resources.GetObject("BtnExit.ErrorImage")));
            this.BtnExit.FadeWhenInactive = false;
            this.BtnExit.Flip = Bunifu.UI.WinForms.BunifuImageButton.FlipOrientation.Normal;
            this.BtnExit.Image = ((System.Drawing.Image)(resources.GetObject("BtnExit.Image")));
            this.BtnExit.ImageActive = null;
            this.BtnExit.ImageLocation = null;
            this.BtnExit.ImageMargin = 2;
            this.BtnExit.ImageSize = new System.Drawing.Size(28, 28);
            this.BtnExit.ImageZoomSize = new System.Drawing.Size(30, 30);
            this.BtnExit.InitialImage = ((System.Drawing.Image)(resources.GetObject("BtnExit.InitialImage")));
            this.BtnExit.Location = new System.Drawing.Point(1056, 15);
            this.BtnExit.Margin = new System.Windows.Forms.Padding(6);
            this.BtnExit.Name = "BtnExit";
            this.BtnExit.Rotation = 0;
            this.BtnExit.ShowActiveImage = true;
            this.BtnExit.ShowCursorChanges = true;
            this.BtnExit.ShowImageBorders = true;
            this.BtnExit.ShowSizeMarkers = false;
            this.BtnExit.Size = new System.Drawing.Size(30, 30);
            this.BtnExit.TabIndex = 6;
            this.BtnExit.ToolTipText = "Exit";
            this.BtnExit.WaitOnLoad = false;
            this.BtnExit.Zoom = 2;
            this.BtnExit.ZoomSpeed = 10;
            // 
            // PnlTop
            // 
            this.PnlTop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(215)))), ((int)(((byte)(35)))));
            this.PnlTop.Controls.Add(this.LblTitle);
            this.PnlTop.Controls.Add(this.BtnExit);
            this.PnlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.PnlTop.Location = new System.Drawing.Point(0, 0);
            this.PnlTop.Name = "PnlTop";
            this.PnlTop.Size = new System.Drawing.Size(1101, 51);
            this.PnlTop.TabIndex = 33;
            // 
            // LblTitle
            // 
            this.LblTitle.AutoSize = true;
            this.LblTitle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(215)))), ((int)(((byte)(35)))));
            this.LblTitle.Font = new System.Drawing.Font("Yummy Delivery Blur", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(43)))), ((int)(((byte)(59)))));
            this.LblTitle.Location = new System.Drawing.Point(1, 6);
            this.LblTitle.Name = "LblTitle";
            this.LblTitle.Size = new System.Drawing.Size(249, 46);
            this.LblTitle.TabIndex = 30;
            this.LblTitle.Text = "Genesis Hostel";
            // 
            // PnlBotttom
            // 
            this.PnlBotttom.BackColor = System.Drawing.Color.YellowGreen;
            this.PnlBotttom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.PnlBotttom.Location = new System.Drawing.Point(0, 754);
            this.PnlBotttom.Name = "PnlBotttom";
            this.PnlBotttom.Size = new System.Drawing.Size(1101, 13);
            this.PnlBotttom.TabIndex = 45;
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 30;
            this.bunifuElipse1.TargetControl = this;
            // 
            // bunifuDragControl1
            // 
            this.bunifuDragControl1.Fixed = true;
            this.bunifuDragControl1.Horizontal = true;
            this.bunifuDragControl1.TargetControl = this.PnlTop;
            this.bunifuDragControl1.Vertical = true;
            // 
            // BtnBack
            // 
            this.BtnBack.AllowToggling = false;
            this.BtnBack.AnimationSpeed = 200;
            this.BtnBack.AutoGenerateColors = false;
            this.BtnBack.BackColor = System.Drawing.Color.Transparent;
            this.BtnBack.BackColor1 = System.Drawing.Color.Transparent;
            this.BtnBack.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BtnBack.BackgroundImage")));
            this.BtnBack.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.BtnBack.ButtonText = "Back";
            this.BtnBack.ButtonTextMarginLeft = 0;
            this.BtnBack.ColorContrastOnClick = 45;
            this.BtnBack.ColorContrastOnHover = 45;
            this.BtnBack.Cursor = System.Windows.Forms.Cursors.Hand;
            borderEdges1.BottomLeft = true;
            borderEdges1.BottomRight = true;
            borderEdges1.TopLeft = true;
            borderEdges1.TopRight = true;
            this.BtnBack.CustomizableEdges = borderEdges1;
            this.BtnBack.DialogResult = System.Windows.Forms.DialogResult.None;
            this.BtnBack.DisabledBorderColor = System.Drawing.Color.Empty;
            this.BtnBack.DisabledFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.BtnBack.DisabledForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.BtnBack.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed;
            this.BtnBack.Font = new System.Drawing.Font("Eras Demi ITC", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnBack.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(215)))), ((int)(((byte)(35)))));
            this.BtnBack.IconLeftCursor = System.Windows.Forms.Cursors.Hand;
            this.BtnBack.IconMarginLeft = 11;
            this.BtnBack.IconPadding = 10;
            this.BtnBack.IconRightCursor = System.Windows.Forms.Cursors.Hand;
            this.BtnBack.IdleBorderColor = System.Drawing.Color.Yellow;
            this.BtnBack.IdleBorderRadius = 30;
            this.BtnBack.IdleBorderThickness = 1;
            this.BtnBack.IdleFillColor = System.Drawing.Color.Transparent;
            this.BtnBack.IdleIconLeftImage = null;
            this.BtnBack.IdleIconRightImage = null;
            this.BtnBack.IndicateFocus = false;
            this.BtnBack.Location = new System.Drawing.Point(463, 680);
            this.BtnBack.Name = "BtnBack";
            stateProperties1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(215)))), ((int)(((byte)(35)))));
            stateProperties1.BorderRadius = 30;
            stateProperties1.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            stateProperties1.BorderThickness = 1;
            stateProperties1.FillColor = System.Drawing.Color.Yellow;
            stateProperties1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(43)))), ((int)(((byte)(59)))));
            stateProperties1.IconLeftImage = null;
            stateProperties1.IconRightImage = null;
            this.BtnBack.onHoverState = stateProperties1;
            stateProperties2.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(215)))), ((int)(((byte)(35)))));
            stateProperties2.BorderRadius = 30;
            stateProperties2.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            stateProperties2.BorderThickness = 1;
            stateProperties2.FillColor = System.Drawing.Color.YellowGreen;
            stateProperties2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(43)))), ((int)(((byte)(59)))));
            stateProperties2.IconLeftImage = null;
            stateProperties2.IconRightImage = null;
            this.BtnBack.OnPressedState = stateProperties2;
            this.BtnBack.Size = new System.Drawing.Size(163, 48);
            this.BtnBack.TabIndex = 1;
            this.BtnBack.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.BtnBack.TextMarginLeft = 0;
            this.BtnBack.UseDefaultRadiusAndThickness = true;
            this.BtnBack.Click += new System.EventHandler(this.BtnBack_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Yummy Delivery Blur", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.GhostWhite;
            this.label1.Location = new System.Drawing.Point(403, 80);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(283, 46);
            this.label1.TabIndex = 101;
            this.label1.Text = "About Developer";
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(54, 139);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(981, 520);
            this.panel1.TabIndex = 201;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Eras Medium ITC", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.GhostWhite;
            this.label2.Location = new System.Drawing.Point(190, 88);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(614, 322);
            this.label2.TabIndex = 0;
            this.label2.Text = resources.GetString("label2.Text");
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // Frm_AboutDev
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(43)))), ((int)(((byte)(59)))));
            this.ClientSize = new System.Drawing.Size(1101, 767);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BtnBack);
            this.Controls.Add(this.PnlBotttom);
            this.Controls.Add(this.PnlTop);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Frm_AboutDev";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Frm_AboutDev";
            this.PnlTop.ResumeLayout(false);
            this.PnlTop.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Bunifu.UI.WinForms.BunifuImageButton BtnExit;
        private System.Windows.Forms.Panel PnlTop;
        private System.Windows.Forms.Label LblTitle;
        private System.Windows.Forms.Panel PnlBotttom;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private Bunifu.Framework.UI.BunifuDragControl bunifuDragControl1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton BtnBack;
        private System.Windows.Forms.Label label2;
    }
}