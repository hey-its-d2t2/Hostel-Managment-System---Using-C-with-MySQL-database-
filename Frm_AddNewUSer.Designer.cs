namespace Hostel_Managment_System
{
    partial class Frm_AddNewUSer
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_AddNewUSer));
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges1 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties stateProperties1 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties();
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties stateProperties2 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties();
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.bunifuDragControl1 = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.PnlTop = new System.Windows.Forms.Panel();
            this.BtnClose = new Bunifu.UI.WinForms.BunifuImageButton();
            this.LblTitle = new System.Windows.Forms.Label();
            this.LBLMsg_InvKey = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.TxtUID = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.TxtPass = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.LblPass = new System.Windows.Forms.Label();
            this.BtnAdd = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.TxtsecretKey = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.LblSK = new System.Windows.Forms.Label();
            this.LblUID = new System.Windows.Forms.Label();
            this.TxtUserName = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.LblCNA = new System.Windows.Forms.Label();
            this.PnlBotttom = new System.Windows.Forms.Panel();
            this.PicLogo = new System.Windows.Forms.PictureBox();
            this.bunifuDragControl2 = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.PnlTop.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PicLogo)).BeginInit();
            this.SuspendLayout();
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
            // PnlTop
            // 
            this.PnlTop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(215)))), ((int)(((byte)(35)))));
            this.PnlTop.Controls.Add(this.BtnClose);
            this.PnlTop.Controls.Add(this.LblTitle);
            this.PnlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.PnlTop.Location = new System.Drawing.Point(0, 0);
            this.PnlTop.Name = "PnlTop";
            this.PnlTop.Size = new System.Drawing.Size(418, 51);
            this.PnlTop.TabIndex = 44;
            // 
            // BtnClose
            // 
            this.BtnClose.ActiveImage = null;
            this.BtnClose.AllowAnimations = true;
            this.BtnClose.AllowBuffering = false;
            this.BtnClose.AllowZooming = true;
            this.BtnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnClose.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(215)))), ((int)(((byte)(35)))));
            this.BtnClose.ErrorImage = ((System.Drawing.Image)(resources.GetObject("BtnClose.ErrorImage")));
            this.BtnClose.FadeWhenInactive = false;
            this.BtnClose.Flip = Bunifu.UI.WinForms.BunifuImageButton.FlipOrientation.Normal;
            this.BtnClose.Image = ((System.Drawing.Image)(resources.GetObject("BtnClose.Image")));
            this.BtnClose.ImageActive = null;
            this.BtnClose.ImageLocation = null;
            this.BtnClose.ImageMargin = 2;
            this.BtnClose.ImageSize = new System.Drawing.Size(32, 32);
            this.BtnClose.ImageZoomSize = new System.Drawing.Size(34, 34);
            this.BtnClose.InitialImage = ((System.Drawing.Image)(resources.GetObject("BtnClose.InitialImage")));
            this.BtnClose.Location = new System.Drawing.Point(366, 9);
            this.BtnClose.Margin = new System.Windows.Forms.Padding(9);
            this.BtnClose.Name = "BtnClose";
            this.BtnClose.Rotation = 0;
            this.BtnClose.ShowActiveImage = true;
            this.BtnClose.ShowCursorChanges = true;
            this.BtnClose.ShowImageBorders = true;
            this.BtnClose.ShowSizeMarkers = false;
            this.BtnClose.Size = new System.Drawing.Size(34, 34);
            this.BtnClose.TabIndex = 42;
            this.BtnClose.ToolTipText = "Close";
            this.BtnClose.WaitOnLoad = false;
            this.BtnClose.Zoom = 2;
            this.BtnClose.ZoomSpeed = 10;
            this.BtnClose.Click += new System.EventHandler(this.BtnClose_Click);
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
            this.LblTitle.TabIndex = 200;
            this.LblTitle.Text = "Genesis Hostel";
            // 
            // LBLMsg_InvKey
            // 
            this.LBLMsg_InvKey.AutoSize = true;
            this.LBLMsg_InvKey.Font = new System.Drawing.Font("Eras Medium ITC", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBLMsg_InvKey.ForeColor = System.Drawing.Color.IndianRed;
            this.LBLMsg_InvKey.Location = new System.Drawing.Point(51, 93);
            this.LBLMsg_InvKey.Name = "LBLMsg_InvKey";
            this.LBLMsg_InvKey.Size = new System.Drawing.Size(99, 19);
            this.LBLMsg_InvKey.TabIndex = 203;
            this.LBLMsg_InvKey.Text = "Invalid key...";
            this.LBLMsg_InvKey.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Eras Medium ITC", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.YellowGreen;
            this.label1.Location = new System.Drawing.Point(51, 190);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 19);
            this.label1.TabIndex = 205;
            this.label1.Text = "User ID";
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
            this.TxtUID.Location = new System.Drawing.Point(51, 223);
            this.TxtUID.Margin = new System.Windows.Forms.Padding(4);
            this.TxtUID.MaxLength = 25;
            this.TxtUID.Name = "TxtUID";
            this.TxtUID.Size = new System.Drawing.Size(283, 36);
            this.TxtUID.TabIndex = 3;
            this.TxtUID.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.LBLMsg_InvKey);
            this.panel1.Controls.Add(this.TxtPass);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.TxtUID);
            this.panel1.Controls.Add(this.LblPass);
            this.panel1.Controls.Add(this.BtnAdd);
            this.panel1.Controls.Add(this.TxtsecretKey);
            this.panel1.Controls.Add(this.LblSK);
            this.panel1.Controls.Add(this.LblUID);
            this.panel1.Controls.Add(this.TxtUserName);
            this.panel1.Location = new System.Drawing.Point(23, 169);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(371, 455);
            this.panel1.TabIndex = 101;
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
            this.TxtPass.Location = new System.Drawing.Point(51, 306);
            this.TxtPass.Margin = new System.Windows.Forms.Padding(4);
            this.TxtPass.MaxLength = 25;
            this.TxtPass.Name = "TxtPass";
            this.TxtPass.Size = new System.Drawing.Size(283, 36);
            this.TxtPass.TabIndex = 4;
            this.TxtPass.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // LblPass
            // 
            this.LblPass.AutoSize = true;
            this.LblPass.Font = new System.Drawing.Font("Eras Medium ITC", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblPass.ForeColor = System.Drawing.Color.YellowGreen;
            this.LblPass.Location = new System.Drawing.Point(51, 273);
            this.LblPass.Name = "LblPass";
            this.LblPass.Size = new System.Drawing.Size(81, 19);
            this.LblPass.TabIndex = 206;
            this.LblPass.Text = "Password";
            // 
            // BtnAdd
            // 
            this.BtnAdd.AllowToggling = false;
            this.BtnAdd.AnimationSpeed = 200;
            this.BtnAdd.AutoGenerateColors = false;
            this.BtnAdd.BackColor = System.Drawing.Color.Transparent;
            this.BtnAdd.BackColor1 = System.Drawing.Color.Transparent;
            this.BtnAdd.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BtnAdd.BackgroundImage")));
            this.BtnAdd.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.BtnAdd.ButtonText = "Add";
            this.BtnAdd.ButtonTextMarginLeft = 0;
            this.BtnAdd.ColorContrastOnClick = 45;
            this.BtnAdd.ColorContrastOnHover = 45;
            this.BtnAdd.Cursor = System.Windows.Forms.Cursors.Hand;
            borderEdges1.BottomLeft = true;
            borderEdges1.BottomRight = true;
            borderEdges1.TopLeft = true;
            borderEdges1.TopRight = true;
            this.BtnAdd.CustomizableEdges = borderEdges1;
            this.BtnAdd.DialogResult = System.Windows.Forms.DialogResult.None;
            this.BtnAdd.DisabledBorderColor = System.Drawing.Color.Empty;
            this.BtnAdd.DisabledFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.BtnAdd.DisabledForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.BtnAdd.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed;
            this.BtnAdd.Font = new System.Drawing.Font("Eras Demi ITC", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnAdd.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(215)))), ((int)(((byte)(35)))));
            this.BtnAdd.IconLeftCursor = System.Windows.Forms.Cursors.Hand;
            this.BtnAdd.IconMarginLeft = 11;
            this.BtnAdd.IconPadding = 10;
            this.BtnAdd.IconRightCursor = System.Windows.Forms.Cursors.Hand;
            this.BtnAdd.IdleBorderColor = System.Drawing.Color.Yellow;
            this.BtnAdd.IdleBorderRadius = 30;
            this.BtnAdd.IdleBorderThickness = 1;
            this.BtnAdd.IdleFillColor = System.Drawing.Color.Transparent;
            this.BtnAdd.IdleIconLeftImage = null;
            this.BtnAdd.IdleIconRightImage = null;
            this.BtnAdd.IndicateFocus = false;
            this.BtnAdd.Location = new System.Drawing.Point(98, 379);
            this.BtnAdd.Name = "BtnAdd";
            stateProperties1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(215)))), ((int)(((byte)(35)))));
            stateProperties1.BorderRadius = 30;
            stateProperties1.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            stateProperties1.BorderThickness = 1;
            stateProperties1.FillColor = System.Drawing.Color.Yellow;
            stateProperties1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(43)))), ((int)(((byte)(59)))));
            stateProperties1.IconLeftImage = null;
            stateProperties1.IconRightImage = null;
            this.BtnAdd.onHoverState = stateProperties1;
            stateProperties2.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(215)))), ((int)(((byte)(35)))));
            stateProperties2.BorderRadius = 30;
            stateProperties2.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            stateProperties2.BorderThickness = 1;
            stateProperties2.FillColor = System.Drawing.Color.YellowGreen;
            stateProperties2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(43)))), ((int)(((byte)(59)))));
            stateProperties2.IconLeftImage = null;
            stateProperties2.IconRightImage = null;
            this.BtnAdd.OnPressedState = stateProperties2;
            this.BtnAdd.Size = new System.Drawing.Size(163, 48);
            this.BtnAdd.TabIndex = 5;
            this.BtnAdd.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.BtnAdd.TextMarginLeft = 0;
            this.BtnAdd.UseDefaultRadiusAndThickness = true;
            this.BtnAdd.Click += new System.EventHandler(this.BtnAdd_Click);
            // 
            // TxtsecretKey
            // 
            this.TxtsecretKey.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.TxtsecretKey.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.TxtsecretKey.characterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.TxtsecretKey.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TxtsecretKey.Font = new System.Drawing.Font("Eras Medium ITC", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtsecretKey.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(215)))), ((int)(((byte)(35)))));
            this.TxtsecretKey.HintForeColor = System.Drawing.Color.CadetBlue;
            this.TxtsecretKey.HintText = "type secret key";
            this.TxtsecretKey.isPassword = false;
            this.TxtsecretKey.LineFocusedColor = System.Drawing.Color.Yellow;
            this.TxtsecretKey.LineIdleColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(215)))), ((int)(((byte)(35)))));
            this.TxtsecretKey.LineMouseHoverColor = System.Drawing.Color.YellowGreen;
            this.TxtsecretKey.LineThickness = 1;
            this.TxtsecretKey.Location = new System.Drawing.Point(51, 57);
            this.TxtsecretKey.Margin = new System.Windows.Forms.Padding(4);
            this.TxtsecretKey.MaxLength = 25;
            this.TxtsecretKey.Name = "TxtsecretKey";
            this.TxtsecretKey.Size = new System.Drawing.Size(283, 36);
            this.TxtsecretKey.TabIndex = 1;
            this.TxtsecretKey.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.TxtsecretKey.Click += new System.EventHandler(this.TxtsecretKey_Click);
            // 
            // LblSK
            // 
            this.LblSK.AutoSize = true;
            this.LblSK.Font = new System.Drawing.Font("Eras Medium ITC", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblSK.ForeColor = System.Drawing.Color.YellowGreen;
            this.LblSK.Location = new System.Drawing.Point(51, 24);
            this.LblSK.Name = "LblSK";
            this.LblSK.Size = new System.Drawing.Size(83, 19);
            this.LblSK.TabIndex = 202;
            this.LblSK.Text = "Secret key";
            // 
            // LblUID
            // 
            this.LblUID.AutoSize = true;
            this.LblUID.Font = new System.Drawing.Font("Eras Medium ITC", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblUID.ForeColor = System.Drawing.Color.YellowGreen;
            this.LblUID.Location = new System.Drawing.Point(51, 116);
            this.LblUID.Name = "LblUID";
            this.LblUID.Size = new System.Drawing.Size(90, 19);
            this.LblUID.TabIndex = 204;
            this.LblUID.Text = "User name";
            // 
            // TxtUserName
            // 
            this.TxtUserName.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.TxtUserName.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.TxtUserName.characterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.TxtUserName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TxtUserName.Font = new System.Drawing.Font("Eras Medium ITC", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtUserName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(215)))), ((int)(((byte)(35)))));
            this.TxtUserName.HintForeColor = System.Drawing.Color.CadetBlue;
            this.TxtUserName.HintText = "type user name";
            this.TxtUserName.isPassword = false;
            this.TxtUserName.LineFocusedColor = System.Drawing.Color.Yellow;
            this.TxtUserName.LineIdleColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(215)))), ((int)(((byte)(35)))));
            this.TxtUserName.LineMouseHoverColor = System.Drawing.Color.YellowGreen;
            this.TxtUserName.LineThickness = 1;
            this.TxtUserName.Location = new System.Drawing.Point(51, 140);
            this.TxtUserName.Margin = new System.Windows.Forms.Padding(4);
            this.TxtUserName.MaxLength = 25;
            this.TxtUserName.Name = "TxtUserName";
            this.TxtUserName.Size = new System.Drawing.Size(283, 36);
            this.TxtUserName.TabIndex = 2;
            this.TxtUserName.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // LblCNA
            // 
            this.LblCNA.AutoSize = true;
            this.LblCNA.Font = new System.Drawing.Font("Eras Medium ITC", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblCNA.ForeColor = System.Drawing.Color.YellowGreen;
            this.LblCNA.Location = new System.Drawing.Point(139, 151);
            this.LblCNA.Name = "LblCNA";
            this.LblCNA.Size = new System.Drawing.Size(156, 26);
            this.LblCNA.TabIndex = 201;
            this.LblCNA.Text = "Add new user";
            // 
            // PnlBotttom
            // 
            this.PnlBotttom.BackColor = System.Drawing.Color.YellowGreen;
            this.PnlBotttom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.PnlBotttom.Location = new System.Drawing.Point(0, 658);
            this.PnlBotttom.Name = "PnlBotttom";
            this.PnlBotttom.Size = new System.Drawing.Size(418, 13);
            this.PnlBotttom.TabIndex = 46;
            // 
            // PicLogo
            // 
            this.PicLogo.Image = ((System.Drawing.Image)(resources.GetObject("PicLogo.Image")));
            this.PicLogo.Location = new System.Drawing.Point(122, 0);
            this.PicLogo.Name = "PicLogo";
            this.PicLogo.Size = new System.Drawing.Size(186, 196);
            this.PicLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PicLogo.TabIndex = 45;
            this.PicLogo.TabStop = false;
            // 
            // bunifuDragControl2
            // 
            this.bunifuDragControl2.Fixed = true;
            this.bunifuDragControl2.Horizontal = true;
            this.bunifuDragControl2.TargetControl = this.LblTitle;
            this.bunifuDragControl2.Vertical = true;
            // 
            // Frm_AddNewUSer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(43)))), ((int)(((byte)(59)))));
            this.ClientSize = new System.Drawing.Size(418, 671);
            this.Controls.Add(this.LblCNA);
            this.Controls.Add(this.PnlBotttom);
            this.Controls.Add(this.PnlTop);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.PicLogo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Frm_AddNewUSer";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Frm_AddNewUSer";
            this.PnlTop.ResumeLayout(false);
            this.PnlTop.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PicLogo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private System.Windows.Forms.Label LblCNA;
        private System.Windows.Forms.Panel PnlBotttom;
        private System.Windows.Forms.Panel PnlTop;
        private Bunifu.UI.WinForms.BunifuImageButton BtnClose;
        private System.Windows.Forms.Label LblTitle;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label LBLMsg_InvKey;
        private Bunifu.Framework.UI.BunifuMaterialTextbox TxtPass;
        private System.Windows.Forms.Label label1;
        private Bunifu.Framework.UI.BunifuMaterialTextbox TxtUID;
        private System.Windows.Forms.Label LblPass;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton BtnAdd;
        private Bunifu.Framework.UI.BunifuMaterialTextbox TxtsecretKey;
        private System.Windows.Forms.Label LblSK;
        private System.Windows.Forms.Label LblUID;
        private Bunifu.Framework.UI.BunifuMaterialTextbox TxtUserName;
        private System.Windows.Forms.PictureBox PicLogo;
        private Bunifu.Framework.UI.BunifuDragControl bunifuDragControl1;
        private Bunifu.Framework.UI.BunifuDragControl bunifuDragControl2;
    }
}