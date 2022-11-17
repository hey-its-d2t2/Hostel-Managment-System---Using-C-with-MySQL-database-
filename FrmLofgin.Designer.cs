namespace Hostel_Managment_System
{
    partial class FrmLofgin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmLofgin));
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges1 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties stateProperties1 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties();
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties stateProperties2 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties();
            this.FrmElipse = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.LblTitle = new System.Windows.Forms.Label();
            this.BtnExit = new Bunifu.UI.WinForms.BunifuImageButton();
            this.BtnLogin = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.PnlTop = new System.Windows.Forms.Panel();
            this.PnlBotttom = new System.Windows.Forms.Panel();
            this.LblForPass = new System.Windows.Forms.Label();
            this.LblCreateAccount = new System.Windows.Forms.Label();
            this.PicLogo = new System.Windows.Forms.PictureBox();
            this.TxtUID = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.TxtPass = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.bunifuDragControl1 = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.bunifuDragControl2 = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.Lbl_IDMsg = new System.Windows.Forms.Label();
            this.LblMsg_InvPass = new System.Windows.Forms.Label();
            this.PnlTop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PicLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // FrmElipse
            // 
            this.FrmElipse.ElipseRadius = 30;
            this.FrmElipse.TargetControl = this;
            // 
            // LblTitle
            // 
            this.LblTitle.AutoSize = true;
            this.LblTitle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(215)))), ((int)(((byte)(35)))));
            this.LblTitle.Font = new System.Drawing.Font("Yummy Delivery Blur", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(43)))), ((int)(((byte)(59)))));
            this.LblTitle.Location = new System.Drawing.Point(2, 8);
            this.LblTitle.Name = "LblTitle";
            this.LblTitle.Size = new System.Drawing.Size(249, 46);
            this.LblTitle.TabIndex = 201;
            this.LblTitle.Text = "Genesis Hostel";
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
            this.BtnExit.Location = new System.Drawing.Point(307, 10);
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
            this.BtnExit.Click += new System.EventHandler(this.BtnExit_Click);
            // 
            // BtnLogin
            // 
            this.BtnLogin.AllowToggling = false;
            this.BtnLogin.AnimationSpeed = 200;
            this.BtnLogin.AutoGenerateColors = false;
            this.BtnLogin.BackColor = System.Drawing.Color.Transparent;
            this.BtnLogin.BackColor1 = System.Drawing.Color.Transparent;
            this.BtnLogin.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BtnLogin.BackgroundImage")));
            this.BtnLogin.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.BtnLogin.ButtonText = "login";
            this.BtnLogin.ButtonTextMarginLeft = 0;
            this.BtnLogin.ColorContrastOnClick = 45;
            this.BtnLogin.ColorContrastOnHover = 45;
            this.BtnLogin.Cursor = System.Windows.Forms.Cursors.Hand;
            borderEdges1.BottomLeft = true;
            borderEdges1.BottomRight = true;
            borderEdges1.TopLeft = true;
            borderEdges1.TopRight = true;
            this.BtnLogin.CustomizableEdges = borderEdges1;
            this.BtnLogin.DialogResult = System.Windows.Forms.DialogResult.None;
            this.BtnLogin.DisabledBorderColor = System.Drawing.Color.Empty;
            this.BtnLogin.DisabledFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.BtnLogin.DisabledForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.BtnLogin.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed;
            this.BtnLogin.Font = new System.Drawing.Font("Eras Demi ITC", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnLogin.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(215)))), ((int)(((byte)(35)))));
            this.BtnLogin.IconLeftCursor = System.Windows.Forms.Cursors.Hand;
            this.BtnLogin.IconMarginLeft = 11;
            this.BtnLogin.IconPadding = 10;
            this.BtnLogin.IconRightCursor = System.Windows.Forms.Cursors.Hand;
            this.BtnLogin.IdleBorderColor = System.Drawing.Color.Yellow;
            this.BtnLogin.IdleBorderRadius = 30;
            this.BtnLogin.IdleBorderThickness = 1;
            this.BtnLogin.IdleFillColor = System.Drawing.Color.Transparent;
            this.BtnLogin.IdleIconLeftImage = null;
            this.BtnLogin.IdleIconRightImage = null;
            this.BtnLogin.IndicateFocus = false;
            this.BtnLogin.Location = new System.Drawing.Point(88, 378);
            this.BtnLogin.Name = "BtnLogin";
            stateProperties1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(215)))), ((int)(((byte)(35)))));
            stateProperties1.BorderRadius = 30;
            stateProperties1.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            stateProperties1.BorderThickness = 1;
            stateProperties1.FillColor = System.Drawing.Color.Yellow;
            stateProperties1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(43)))), ((int)(((byte)(59)))));
            stateProperties1.IconLeftImage = null;
            stateProperties1.IconRightImage = null;
            this.BtnLogin.onHoverState = stateProperties1;
            stateProperties2.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(215)))), ((int)(((byte)(35)))));
            stateProperties2.BorderRadius = 30;
            stateProperties2.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            stateProperties2.BorderThickness = 1;
            stateProperties2.FillColor = System.Drawing.Color.YellowGreen;
            stateProperties2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(43)))), ((int)(((byte)(59)))));
            stateProperties2.IconLeftImage = null;
            stateProperties2.IconRightImage = null;
            this.BtnLogin.OnPressedState = stateProperties2;
            this.BtnLogin.Size = new System.Drawing.Size(163, 48);
            this.BtnLogin.TabIndex = 3;
            this.BtnLogin.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.BtnLogin.TextMarginLeft = 0;
            this.BtnLogin.UseDefaultRadiusAndThickness = true;
            this.BtnLogin.Click += new System.EventHandler(this.BtnLogin_Click);
            // 
            // PnlTop
            // 
            this.PnlTop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(215)))), ((int)(((byte)(35)))));
            this.PnlTop.Controls.Add(this.BtnExit);
            this.PnlTop.Location = new System.Drawing.Point(-2, 0);
            this.PnlTop.Name = "PnlTop";
            this.PnlTop.Size = new System.Drawing.Size(352, 51);
            this.PnlTop.TabIndex = 25;
            // 
            // PnlBotttom
            // 
            this.PnlBotttom.BackColor = System.Drawing.Color.YellowGreen;
            this.PnlBotttom.Location = new System.Drawing.Point(-2, 490);
            this.PnlBotttom.Name = "PnlBotttom";
            this.PnlBotttom.Size = new System.Drawing.Size(352, 13);
            this.PnlBotttom.TabIndex = 26;
            // 
            // LblForPass
            // 
            this.LblForPass.AutoSize = true;
            this.LblForPass.Cursor = System.Windows.Forms.Cursors.Hand;
            this.LblForPass.Font = new System.Drawing.Font("Eras Medium ITC", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblForPass.ForeColor = System.Drawing.Color.YellowGreen;
            this.LblForPass.Location = new System.Drawing.Point(200, 469);
            this.LblForPass.Name = "LblForPass";
            this.LblForPass.Size = new System.Drawing.Size(148, 19);
            this.LblForPass.TabIndex = 4;
            this.LblForPass.Text = "Forgot password ?";
            this.LblForPass.Click += new System.EventHandler(this.LblForPass_Click);
            this.LblForPass.MouseLeave += new System.EventHandler(this.LblForPass_MouseLeave);
            this.LblForPass.MouseHover += new System.EventHandler(this.LblForPass_MouseHover);
            this.LblForPass.MouseMove += new System.Windows.Forms.MouseEventHandler(this.LblForPass_MouseMove);
            // 
            // LblCreateAccount
            // 
            this.LblCreateAccount.AutoSize = true;
            this.LblCreateAccount.Cursor = System.Windows.Forms.Cursors.Hand;
            this.LblCreateAccount.Font = new System.Drawing.Font("Eras Medium ITC", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblCreateAccount.ForeColor = System.Drawing.Color.YellowGreen;
            this.LblCreateAccount.Location = new System.Drawing.Point(12, 469);
            this.LblCreateAccount.Name = "LblCreateAccount";
            this.LblCreateAccount.Size = new System.Drawing.Size(138, 19);
            this.LblCreateAccount.TabIndex = 5;
            this.LblCreateAccount.Text = "Create account ...";
            this.LblCreateAccount.Click += new System.EventHandler(this.LblCreateAccount_Click);
            this.LblCreateAccount.MouseLeave += new System.EventHandler(this.LblCreateAccount_MouseLeave);
            this.LblCreateAccount.MouseHover += new System.EventHandler(this.label3_MouseHover);
            // 
            // PicLogo
            // 
            this.PicLogo.Image = ((System.Drawing.Image)(resources.GetObject("PicLogo.Image")));
            this.PicLogo.Location = new System.Drawing.Point(87, 14);
            this.PicLogo.Name = "PicLogo";
            this.PicLogo.Size = new System.Drawing.Size(180, 179);
            this.PicLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PicLogo.TabIndex = 29;
            this.PicLogo.TabStop = false;
            // 
            // TxtUID
            // 
            this.TxtUID.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.TxtUID.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.TxtUID.characterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.TxtUID.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TxtUID.Font = new System.Drawing.Font("Eras Medium ITC", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtUID.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(215)))), ((int)(((byte)(35)))));
            this.TxtUID.HintForeColor = System.Drawing.Color.CadetBlue;
            this.TxtUID.HintText = "type user ID";
            this.TxtUID.isPassword = false;
            this.TxtUID.LineFocusedColor = System.Drawing.Color.Yellow;
            this.TxtUID.LineIdleColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(215)))), ((int)(((byte)(35)))));
            this.TxtUID.LineMouseHoverColor = System.Drawing.Color.YellowGreen;
            this.TxtUID.LineThickness = 1;
            this.TxtUID.Location = new System.Drawing.Point(44, 206);
            this.TxtUID.Margin = new System.Windows.Forms.Padding(4);
            this.TxtUID.MaxLength = 25;
            this.TxtUID.Name = "TxtUID";
            this.TxtUID.Size = new System.Drawing.Size(287, 36);
            this.TxtUID.TabIndex = 1;
            this.TxtUID.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.TxtUID.Click += new System.EventHandler(this.TxtUID_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Eras Medium ITC", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.YellowGreen;
            this.label4.Location = new System.Drawing.Point(44, 186);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 19);
            this.label4.TabIndex = 202;
            this.label4.Text = "User ID";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Eras Medium ITC", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.YellowGreen;
            this.label5.Location = new System.Drawing.Point(44, 274);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(81, 19);
            this.label5.TabIndex = 204;
            this.label5.Text = "Password";
            // 
            // TxtPass
            // 
            this.TxtPass.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.TxtPass.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.TxtPass.characterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.TxtPass.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TxtPass.Font = new System.Drawing.Font("Eras Medium ITC", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtPass.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(215)))), ((int)(((byte)(35)))));
            this.TxtPass.HintForeColor = System.Drawing.Color.CadetBlue;
            this.TxtPass.HintText = "type password";
            this.TxtPass.isPassword = true;
            this.TxtPass.LineFocusedColor = System.Drawing.Color.Yellow;
            this.TxtPass.LineIdleColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(215)))), ((int)(((byte)(35)))));
            this.TxtPass.LineMouseHoverColor = System.Drawing.Color.YellowGreen;
            this.TxtPass.LineThickness = 1;
            this.TxtPass.Location = new System.Drawing.Point(44, 296);
            this.TxtPass.Margin = new System.Windows.Forms.Padding(4);
            this.TxtPass.MaxLength = 25;
            this.TxtPass.Name = "TxtPass";
            this.TxtPass.Size = new System.Drawing.Size(287, 36);
            this.TxtPass.TabIndex = 2;
            this.TxtPass.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.TxtPass.Click += new System.EventHandler(this.TxtPass_Click);
            // 
            // bunifuDragControl1
            // 
            this.bunifuDragControl1.Fixed = true;
            this.bunifuDragControl1.Horizontal = true;
            this.bunifuDragControl1.TargetControl = this.LblTitle;
            this.bunifuDragControl1.Vertical = true;
            // 
            // bunifuDragControl2
            // 
            this.bunifuDragControl2.Fixed = true;
            this.bunifuDragControl2.Horizontal = true;
            this.bunifuDragControl2.TargetControl = this.PnlTop;
            this.bunifuDragControl2.Vertical = true;
            // 
            // Lbl_IDMsg
            // 
            this.Lbl_IDMsg.AutoSize = true;
            this.Lbl_IDMsg.Font = new System.Drawing.Font("Eras Medium ITC", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_IDMsg.ForeColor = System.Drawing.Color.Tomato;
            this.Lbl_IDMsg.Location = new System.Drawing.Point(50, 246);
            this.Lbl_IDMsg.Name = "Lbl_IDMsg";
            this.Lbl_IDMsg.Size = new System.Drawing.Size(98, 15);
            this.Lbl_IDMsg.TabIndex = 203;
            this.Lbl_IDMsg.Text = "invalid user ID...";
            this.Lbl_IDMsg.Visible = false;
            // 
            // LblMsg_InvPass
            // 
            this.LblMsg_InvPass.AutoSize = true;
            this.LblMsg_InvPass.Font = new System.Drawing.Font("Eras Medium ITC", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblMsg_InvPass.ForeColor = System.Drawing.Color.Tomato;
            this.LblMsg_InvPass.Location = new System.Drawing.Point(45, 336);
            this.LblMsg_InvPass.Name = "LblMsg_InvPass";
            this.LblMsg_InvPass.Size = new System.Drawing.Size(114, 15);
            this.LblMsg_InvPass.TabIndex = 205;
            this.LblMsg_InvPass.Text = "invalid password...";
            this.LblMsg_InvPass.Visible = false;
            // 
            // FrmLofgin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(43)))), ((int)(((byte)(59)))));
            this.ClientSize = new System.Drawing.Size(350, 500);
            this.Controls.Add(this.LblMsg_InvPass);
            this.Controls.Add(this.Lbl_IDMsg);
            this.Controls.Add(this.TxtPass);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.TxtUID);
            this.Controls.Add(this.LblCreateAccount);
            this.Controls.Add(this.LblForPass);
            this.Controls.Add(this.PnlBotttom);
            this.Controls.Add(this.BtnLogin);
            this.Controls.Add(this.LblTitle);
            this.Controls.Add(this.PnlTop);
            this.Controls.Add(this.PicLogo);
            this.Font = new System.Drawing.Font("Eras Medium ITC", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FrmLofgin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmLofgin";
            this.Load += new System.EventHandler(this.FrmLofgin_Load);
            this.PnlTop.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.PicLogo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Bunifu.Framework.UI.BunifuElipse FrmElipse;
        private System.Windows.Forms.Label LblTitle;
        private Bunifu.UI.WinForms.BunifuImageButton BtnExit;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton BtnLogin;
        private System.Windows.Forms.Panel PnlTop;
        private System.Windows.Forms.Label LblCreateAccount;
        private System.Windows.Forms.Label LblForPass;
        private System.Windows.Forms.Panel PnlBotttom;
        private System.Windows.Forms.PictureBox PicLogo;
        private Bunifu.Framework.UI.BunifuMaterialTextbox TxtPass;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private Bunifu.Framework.UI.BunifuMaterialTextbox TxtUID;
        private Bunifu.Framework.UI.BunifuDragControl bunifuDragControl1;
        private Bunifu.Framework.UI.BunifuDragControl bunifuDragControl2;
        private System.Windows.Forms.Label LblMsg_InvPass;
        private System.Windows.Forms.Label Lbl_IDMsg;
    }
}