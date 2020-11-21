namespace Draw
{
	partial class MainForm
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		
		/// <summary>
		/// Disposes resources used by the form.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing) {
				if (components != null) {
					components.Dispose();
				}
			}
			base.Dispose(disposing);
		}
		
		/// <summary>
		/// This method is required for Windows Forms designer support.
		/// Do not change the method contents inside the source code editor. The Forms designer might
		/// not be able to load this method if it was changed manually.
		/// </summary>
		private void InitializeComponent()
		{
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.mainMenu = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.imageToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statusBar = new System.Windows.Forms.StatusStrip();
            this.currentStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.speedMenu = new System.Windows.Forms.ToolStrip();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.ColorDialog = new System.Windows.Forms.ColorDialog();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.BorderSize = new System.Windows.Forms.TrackBar();
            this.pickUpSpeedButton = new System.Windows.Forms.ToolStripButton();
            this.BorderColor = new System.Windows.Forms.ToolStripButton();
            this.FillColor = new System.Windows.Forms.ToolStripButton();
            this.drawRectangleSpeedButton = new System.Windows.Forms.ToolStripButton();
            this.DrawEllipseButton = new System.Windows.Forms.ToolStripButton();
            this.DrawLineButton = new System.Windows.Forms.ToolStripButton();
            this.ColorChoose = new System.Windows.Forms.ToolStripButton();
            this.BorderPenSize = new System.Windows.Forms.ToolStripButton();
            this.BiggerShapeSize = new System.Windows.Forms.ToolStripButton();
            this.SmallerShapeSize = new System.Windows.Forms.ToolStripButton();
            this.DeleteButton = new System.Windows.Forms.ToolStripButton();
            this.SaveButton = new System.Windows.Forms.ToolStripMenuItem();
            this.OpenFile = new System.Windows.Forms.ToolStripMenuItem();
            this.viewPort = new Draw.DoubleBufferedPanel();
            this.mainMenu.SuspendLayout();
            this.statusBar.SuspendLayout();
            this.speedMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BorderSize)).BeginInit();
            this.SuspendLayout();
            // 
            // mainMenu
            // 
            this.mainMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.editToolStripMenuItem,
            this.imageToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.mainMenu.Location = new System.Drawing.Point(0, 0);
            this.mainMenu.Name = "mainMenu";
            this.mainMenu.Size = new System.Drawing.Size(693, 24);
            this.mainMenu.TabIndex = 1;
            this.mainMenu.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitToolStripMenuItem,
            this.SaveButton,
            this.OpenFile});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(106, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.ExitToolStripMenuItemClick);
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(39, 20);
            this.editToolStripMenuItem.Text = "Edit";
            // 
            // imageToolStripMenuItem
            // 
            this.imageToolStripMenuItem.Name = "imageToolStripMenuItem";
            this.imageToolStripMenuItem.Size = new System.Drawing.Size(52, 20);
            this.imageToolStripMenuItem.Text = "Image";
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(116, 22);
            this.aboutToolStripMenuItem.Text = "About...";
            // 
            // statusBar
            // 
            this.statusBar.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.currentStatusLabel});
            this.statusBar.Location = new System.Drawing.Point(0, 401);
            this.statusBar.Name = "statusBar";
            this.statusBar.Size = new System.Drawing.Size(693, 22);
            this.statusBar.TabIndex = 2;
            this.statusBar.Text = "statusStrip1";
            // 
            // currentStatusLabel
            // 
            this.currentStatusLabel.Name = "currentStatusLabel";
            this.currentStatusLabel.Size = new System.Drawing.Size(0, 17);
            // 
            // speedMenu
            // 
            this.speedMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.pickUpSpeedButton,
            this.BorderColor,
            this.FillColor,
            this.toolStripSeparator1,
            this.drawRectangleSpeedButton,
            this.DrawEllipseButton,
            this.DrawLineButton,
            this.toolStripSeparator2,
            this.toolStripLabel1,
            this.ColorChoose,
            this.BorderPenSize,
            this.BiggerShapeSize,
            this.SmallerShapeSize,
            this.DeleteButton});
            this.speedMenu.Location = new System.Drawing.Point(0, 24);
            this.speedMenu.Name = "speedMenu";
            this.speedMenu.Size = new System.Drawing.Size(693, 25);
            this.speedMenu.TabIndex = 3;
            this.speedMenu.Text = "Кръг";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(41, 22);
            this.toolStripLabel1.Text = "Colors";
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // BorderSize
            // 
            this.BorderSize.Location = new System.Drawing.Point(381, 24);
            this.BorderSize.Minimum = 1;
            this.BorderSize.Name = "BorderSize";
            this.BorderSize.Size = new System.Drawing.Size(143, 45);
            this.BorderSize.TabIndex = 5;
            this.BorderSize.Value = 1;
            this.BorderSize.Scroll += new System.EventHandler(this.BorderSize_Scroll);
            // 
            // pickUpSpeedButton
            // 
            this.pickUpSpeedButton.Checked = true;
            this.pickUpSpeedButton.CheckOnClick = true;
            this.pickUpSpeedButton.CheckState = System.Windows.Forms.CheckState.Checked;
            this.pickUpSpeedButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.pickUpSpeedButton.Image = ((System.Drawing.Image)(resources.GetObject("pickUpSpeedButton.Image")));
            this.pickUpSpeedButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.pickUpSpeedButton.Name = "pickUpSpeedButton";
            this.pickUpSpeedButton.Size = new System.Drawing.Size(23, 22);
            this.pickUpSpeedButton.Text = "toolStripButton1";
            // 
            // BorderColor
            // 
            this.BorderColor.CheckOnClick = true;
            this.BorderColor.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.BorderColor.Image = global::Draw.Properties.Resources._9200365481558965373_128;
            this.BorderColor.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.BorderColor.Name = "BorderColor";
            this.BorderColor.Size = new System.Drawing.Size(23, 22);
            this.BorderColor.Text = "BorderColor";
            // 
            // FillColor
            // 
            this.FillColor.CheckOnClick = true;
            this.FillColor.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.FillColor.Image = global::Draw.Properties.Resources._7666514461555931400_128;
            this.FillColor.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.FillColor.Name = "FillColor";
            this.FillColor.Size = new System.Drawing.Size(23, 22);
            this.FillColor.Text = "FillColor";
            // 
            // drawRectangleSpeedButton
            // 
            this.drawRectangleSpeedButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.drawRectangleSpeedButton.Image = ((System.Drawing.Image)(resources.GetObject("drawRectangleSpeedButton.Image")));
            this.drawRectangleSpeedButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.drawRectangleSpeedButton.Name = "drawRectangleSpeedButton";
            this.drawRectangleSpeedButton.Size = new System.Drawing.Size(23, 22);
            this.drawRectangleSpeedButton.Text = "Правоъгълник";
            this.drawRectangleSpeedButton.Click += new System.EventHandler(this.DrawRectangleSpeedButtonClick);
            // 
            // DrawEllipseButton
            // 
            this.DrawEllipseButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.DrawEllipseButton.Image = global::Draw.Properties.Resources.circle;
            this.DrawEllipseButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.DrawEllipseButton.Name = "DrawEllipseButton";
            this.DrawEllipseButton.Size = new System.Drawing.Size(23, 22);
            this.DrawEllipseButton.Text = "toolStripButton1";
            this.DrawEllipseButton.Click += new System.EventHandler(this.DrawEllipseButton_Click);
            // 
            // DrawLineButton
            // 
            this.DrawLineButton.CheckOnClick = true;
            this.DrawLineButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.DrawLineButton.Image = global::Draw.Properties.Resources.line;
            this.DrawLineButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.DrawLineButton.Name = "DrawLineButton";
            this.DrawLineButton.Size = new System.Drawing.Size(23, 22);
            this.DrawLineButton.Text = "Линия";
            this.DrawLineButton.Click += new System.EventHandler(this.DrawLineButton_Click);
            // 
            // ColorChoose
            // 
            this.ColorChoose.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.ColorChoose.Image = global::Draw.Properties.Resources.colorful;
            this.ColorChoose.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ColorChoose.Name = "ColorChoose";
            this.ColorChoose.Size = new System.Drawing.Size(23, 22);
            this.ColorChoose.Text = "ChooseColor";
            this.ColorChoose.Click += new System.EventHandler(this.ColorChoose_Click);
            // 
            // BorderPenSize
            // 
            this.BorderPenSize.CheckOnClick = true;
            this.BorderPenSize.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.BorderPenSize.Image = global::Draw.Properties.Resources._2944585831586788051_512;
            this.BorderPenSize.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.BorderPenSize.Name = "BorderPenSize";
            this.BorderPenSize.Size = new System.Drawing.Size(23, 22);
            this.BorderPenSize.Text = "BorderPenSize";
            // 
            // BiggerShapeSize
            // 
            this.BiggerShapeSize.CheckOnClick = true;
            this.BiggerShapeSize.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.BiggerShapeSize.Image = global::Draw.Properties.Resources.plus;
            this.BiggerShapeSize.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.BiggerShapeSize.Name = "BiggerShapeSize";
            this.BiggerShapeSize.Size = new System.Drawing.Size(23, 22);
            this.BiggerShapeSize.Text = "Bigger Shape Size";
            // 
            // SmallerShapeSize
            // 
            this.SmallerShapeSize.CheckOnClick = true;
            this.SmallerShapeSize.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.SmallerShapeSize.Image = global::Draw.Properties.Resources.minus;
            this.SmallerShapeSize.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.SmallerShapeSize.Name = "SmallerShapeSize";
            this.SmallerShapeSize.Size = new System.Drawing.Size(23, 22);
            this.SmallerShapeSize.Text = "Smaller Shape Size";
            // 
            // DeleteButton
            // 
            this.DeleteButton.CheckOnClick = true;
            this.DeleteButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.DeleteButton.Image = global::Draw.Properties.Resources.Delete;
            this.DeleteButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.DeleteButton.Name = "DeleteButton";
            this.DeleteButton.Size = new System.Drawing.Size(23, 22);
            this.DeleteButton.Text = "Delete";
            // 
            // SaveButton
            // 
            this.SaveButton.Name = "SaveButton";
            this.SaveButton.Size = new System.Drawing.Size(106, 22);
            this.SaveButton.Text = "Save";
            this.SaveButton.Click += new System.EventHandler(this.SaveButton_Click);
            // 
            // OpenFile
            // 
            this.OpenFile.Name = "OpenFile";
            this.OpenFile.Size = new System.Drawing.Size(106, 22);
            this.OpenFile.Text = "Open ";
            this.OpenFile.Click += new System.EventHandler(this.OpenFile_Click);
            // 
            // viewPort
            // 
            this.viewPort.Dock = System.Windows.Forms.DockStyle.Fill;
            this.viewPort.Location = new System.Drawing.Point(0, 49);
            this.viewPort.Name = "viewPort";
            this.viewPort.Size = new System.Drawing.Size(693, 352);
            this.viewPort.TabIndex = 4;
            this.viewPort.Paint += new System.Windows.Forms.PaintEventHandler(this.ViewPortPaint);
            this.viewPort.MouseClick += new System.Windows.Forms.MouseEventHandler(this.viewPort_MouseClick);
            this.viewPort.MouseDown += new System.Windows.Forms.MouseEventHandler(this.ViewPortMouseDown);
            this.viewPort.MouseMove += new System.Windows.Forms.MouseEventHandler(this.ViewPortMouseMove);
            this.viewPort.MouseUp += new System.Windows.Forms.MouseEventHandler(this.ViewPortMouseUp);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(693, 423);
            this.Controls.Add(this.BorderSize);
            this.Controls.Add(this.viewPort);
            this.Controls.Add(this.speedMenu);
            this.Controls.Add(this.statusBar);
            this.Controls.Add(this.mainMenu);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.mainMenu;
            this.Name = "MainForm";
            this.Text = "Draw";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.mainMenu.ResumeLayout(false);
            this.mainMenu.PerformLayout();
            this.statusBar.ResumeLayout(false);
            this.statusBar.PerformLayout();
            this.speedMenu.ResumeLayout(false);
            this.speedMenu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BorderSize)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

		}
		
		private System.Windows.Forms.ToolStripStatusLabel currentStatusLabel;
		private Draw.DoubleBufferedPanel viewPort;
		private System.Windows.Forms.ToolStripButton pickUpSpeedButton;
		private System.Windows.Forms.ToolStripButton drawRectangleSpeedButton;
		private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem imageToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
		private System.Windows.Forms.ToolStrip speedMenu;
		private System.Windows.Forms.StatusStrip statusBar;
		private System.Windows.Forms.MenuStrip mainMenu;
		private System.Windows.Forms.ToolStripButton DrawEllipseButton;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton DrawLineButton;
        private System.Windows.Forms.ColorDialog ColorDialog;
        private System.Windows.Forms.ToolStripButton ColorChoose;
        private System.Windows.Forms.ToolStripButton FillColor;
        private System.Windows.Forms.ToolStripButton BorderColor;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.ToolStripButton BorderPenSize;
        private System.Windows.Forms.TrackBar BorderSize;
        private System.Windows.Forms.ToolStripButton BiggerShapeSize;
        private System.Windows.Forms.ToolStripButton SmallerShapeSize;
        private System.Windows.Forms.ToolStripButton DeleteButton;
        private System.Windows.Forms.ToolStripMenuItem SaveButton;
        private System.Windows.Forms.ToolStripMenuItem OpenFile;
    }
}
