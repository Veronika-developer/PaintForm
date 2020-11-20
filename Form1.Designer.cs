namespace PaintApp
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.menuStrip2 = new System.Windows.Forms.MenuStrip();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.newToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem6 = new System.Windows.Forms.ToolStripMenuItem();
            this.undoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.renoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.penToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.styleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.solidToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dotToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dashDotDotToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.colorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem7 = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStrip2 = new System.Windows.Forms.ToolStrip();
            this.NEWtoolStripButton6 = new System.Windows.Forms.ToolStripButton();
            this.SAVEtoolStripButton = new System.Windows.Forms.ToolStripButton();
            this.OPENtoolStripButton8 = new System.Windows.Forms.ToolStripButton();
            this.COLORtoolStripButton9 = new System.Windows.Forms.ToolStripButton();
            this.EXITtoolStripButton10 = new System.Windows.Forms.ToolStripButton();
            this.picDrawingSurface = new System.Windows.Forms.PictureBox();
            this.RazmerKisti = new System.Windows.Forms.TrackBar();
            this.Lupa = new System.Windows.Forms.TrackBar();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.LBLxy = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.menuStrip2.SuspendLayout();
            this.toolStrip2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picDrawingSurface)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.RazmerKisti)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Lupa)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip2
            // 
            this.menuStrip2.BackColor = System.Drawing.Color.WhiteSmoke;
            this.menuStrip2.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1,
            this.toolStripMenuItem6,
            this.toolStripMenuItem7});
            this.menuStrip2.Location = new System.Drawing.Point(0, 0);
            this.menuStrip2.Name = "menuStrip2";
            this.menuStrip2.Padding = new System.Windows.Forms.Padding(4, 2, 0, 2);
            this.menuStrip2.Size = new System.Drawing.Size(866, 24);
            this.menuStrip2.TabIndex = 16;
            this.menuStrip2.Text = "menuStrip2";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newToolStripMenuItem,
            this.openToolStripMenuItem,
            this.saveToolStripMenuItem,
            this.toolStripSeparator1,
            this.exitToolStripMenuItem});
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(37, 20);
            this.toolStripMenuItem1.Text = "File";
            // 
            // newToolStripMenuItem
            // 
            this.newToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("newToolStripMenuItem.Image")));
            this.newToolStripMenuItem.Name = "newToolStripMenuItem";
            this.newToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
            this.newToolStripMenuItem.Size = new System.Drawing.Size(141, 22);
            this.newToolStripMenuItem.Text = "New";
            this.newToolStripMenuItem.Click += new System.EventHandler(this.newToolStripMenuItem_Click);
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("openToolStripMenuItem.Image")));
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F3;
            this.openToolStripMenuItem.Size = new System.Drawing.Size(141, 22);
            this.openToolStripMenuItem.Text = "Open";
            this.openToolStripMenuItem.Click += new System.EventHandler(this.openToolStripMenuItem_Click);
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("saveToolStripMenuItem.Image")));
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F2;
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(141, 22);
            this.saveToolStripMenuItem.Text = "Save";
            this.saveToolStripMenuItem.Click += new System.EventHandler(this.saveToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(138, 6);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("exitToolStripMenuItem.Image")));
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.X)));
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(141, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // toolStripMenuItem6
            // 
            this.toolStripMenuItem6.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.undoToolStripMenuItem,
            this.renoToolStripMenuItem,
            this.penToolStripMenuItem});
            this.toolStripMenuItem6.Name = "toolStripMenuItem6";
            this.toolStripMenuItem6.Size = new System.Drawing.Size(39, 20);
            this.toolStripMenuItem6.Text = "Edit";
            // 
            // undoToolStripMenuItem
            // 
            this.undoToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("undoToolStripMenuItem.Image")));
            this.undoToolStripMenuItem.Name = "undoToolStripMenuItem";
            this.undoToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Z)));
            this.undoToolStripMenuItem.Size = new System.Drawing.Size(174, 22);
            this.undoToolStripMenuItem.Text = "Undo";
            this.undoToolStripMenuItem.Click += new System.EventHandler(this.undoToolStripMenuItem_Click);
            // 
            // renoToolStripMenuItem
            // 
            this.renoToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("renoToolStripMenuItem.Image")));
            this.renoToolStripMenuItem.Name = "renoToolStripMenuItem";
            this.renoToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.Z)));
            this.renoToolStripMenuItem.Size = new System.Drawing.Size(174, 22);
            this.renoToolStripMenuItem.Text = "Redo";
            this.renoToolStripMenuItem.Click += new System.EventHandler(this.renoToolStripMenuItem_Click);
            // 
            // penToolStripMenuItem
            // 
            this.penToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.styleToolStripMenuItem,
            this.colorToolStripMenuItem});
            this.penToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("penToolStripMenuItem.Image")));
            this.penToolStripMenuItem.Name = "penToolStripMenuItem";
            this.penToolStripMenuItem.Size = new System.Drawing.Size(174, 22);
            this.penToolStripMenuItem.Text = "Pen";
            // 
            // styleToolStripMenuItem
            // 
            this.styleToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.solidToolStripMenuItem,
            this.dotToolStripMenuItem,
            this.dashDotDotToolStripMenuItem});
            this.styleToolStripMenuItem.Name = "styleToolStripMenuItem";
            this.styleToolStripMenuItem.Size = new System.Drawing.Size(103, 22);
            this.styleToolStripMenuItem.Text = "Style";
            // 
            // solidToolStripMenuItem
            // 
            this.solidToolStripMenuItem.Checked = true;
            this.solidToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.solidToolStripMenuItem.Name = "solidToolStripMenuItem";
            this.solidToolStripMenuItem.Size = new System.Drawing.Size(138, 22);
            this.solidToolStripMenuItem.Text = "Solid";
            this.solidToolStripMenuItem.Click += new System.EventHandler(this.solidToolStripMenuItem_Click);
            // 
            // dotToolStripMenuItem
            // 
            this.dotToolStripMenuItem.Name = "dotToolStripMenuItem";
            this.dotToolStripMenuItem.Size = new System.Drawing.Size(138, 22);
            this.dotToolStripMenuItem.Text = "Dot";
            this.dotToolStripMenuItem.Click += new System.EventHandler(this.dotToolStripMenuItem_Click);
            // 
            // dashDotDotToolStripMenuItem
            // 
            this.dashDotDotToolStripMenuItem.Name = "dashDotDotToolStripMenuItem";
            this.dashDotDotToolStripMenuItem.Size = new System.Drawing.Size(138, 22);
            this.dashDotDotToolStripMenuItem.Text = "DashDotDot";
            this.dashDotDotToolStripMenuItem.Click += new System.EventHandler(this.dashDotDotToolStripMenuItem_Click);
            // 
            // colorToolStripMenuItem
            // 
            this.colorToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("colorToolStripMenuItem.Image")));
            this.colorToolStripMenuItem.Name = "colorToolStripMenuItem";
            this.colorToolStripMenuItem.Size = new System.Drawing.Size(103, 22);
            this.colorToolStripMenuItem.Text = "Color";
            this.colorToolStripMenuItem.Click += new System.EventHandler(this.colorToolStripMenuItem_Click);
            // 
            // toolStripMenuItem7
            // 
            this.toolStripMenuItem7.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem});
            this.toolStripMenuItem7.Name = "toolStripMenuItem7";
            this.toolStripMenuItem7.Size = new System.Drawing.Size(44, 20);
            this.toolStripMenuItem7.Text = "Help";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("aboutToolStripMenuItem.Image")));
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F1;
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(184, 26);
            this.aboutToolStripMenuItem.Text = "About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // toolStrip2
            // 
            this.toolStrip2.Dock = System.Windows.Forms.DockStyle.Left;
            this.toolStrip2.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStrip2.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.NEWtoolStripButton6,
            this.SAVEtoolStripButton,
            this.OPENtoolStripButton8,
            this.COLORtoolStripButton9,
            this.EXITtoolStripButton10});
            this.toolStrip2.Location = new System.Drawing.Point(0, 24);
            this.toolStrip2.Name = "toolStrip2";
            this.toolStrip2.Size = new System.Drawing.Size(111, 510);
            this.toolStrip2.TabIndex = 20;
            this.toolStrip2.Text = "toolStrip2";
            // 
            // NEWtoolStripButton6
            // 
            this.NEWtoolStripButton6.AutoSize = false;
            this.NEWtoolStripButton6.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.NEWtoolStripButton6.Image = ((System.Drawing.Image)(resources.GetObject("NEWtoolStripButton6.Image")));
            this.NEWtoolStripButton6.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.NEWtoolStripButton6.ImageTransparentColor = System.Drawing.Color.DarkOrchid;
            this.NEWtoolStripButton6.Name = "NEWtoolStripButton6";
            this.NEWtoolStripButton6.Size = new System.Drawing.Size(110, 80);
            this.NEWtoolStripButton6.Text = "toolStripButton1";
            this.NEWtoolStripButton6.Click += new System.EventHandler(this.NEWtoolStripButton6_Click);
            // 
            // SAVEtoolStripButton
            // 
            this.SAVEtoolStripButton.AutoSize = false;
            this.SAVEtoolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.SAVEtoolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("SAVEtoolStripButton.Image")));
            this.SAVEtoolStripButton.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.SAVEtoolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.SAVEtoolStripButton.Name = "SAVEtoolStripButton";
            this.SAVEtoolStripButton.Size = new System.Drawing.Size(110, 80);
            this.SAVEtoolStripButton.Text = "toolStripButton2";
            this.SAVEtoolStripButton.Click += new System.EventHandler(this.SAVEtoolStripButton_Click);
            // 
            // OPENtoolStripButton8
            // 
            this.OPENtoolStripButton8.AutoSize = false;
            this.OPENtoolStripButton8.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.OPENtoolStripButton8.Image = ((System.Drawing.Image)(resources.GetObject("OPENtoolStripButton8.Image")));
            this.OPENtoolStripButton8.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.OPENtoolStripButton8.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.OPENtoolStripButton8.Name = "OPENtoolStripButton8";
            this.OPENtoolStripButton8.Size = new System.Drawing.Size(110, 80);
            this.OPENtoolStripButton8.Text = "toolStripButton3";
            this.OPENtoolStripButton8.Click += new System.EventHandler(this.OPENtoolStripButton8_Click);
            // 
            // COLORtoolStripButton9
            // 
            this.COLORtoolStripButton9.AutoSize = false;
            this.COLORtoolStripButton9.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.COLORtoolStripButton9.Image = ((System.Drawing.Image)(resources.GetObject("COLORtoolStripButton9.Image")));
            this.COLORtoolStripButton9.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.COLORtoolStripButton9.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.COLORtoolStripButton9.Name = "COLORtoolStripButton9";
            this.COLORtoolStripButton9.Size = new System.Drawing.Size(110, 80);
            this.COLORtoolStripButton9.Text = "toolStripButton4";
            this.COLORtoolStripButton9.Click += new System.EventHandler(this.COLORtoolStripButton9_Click);
            // 
            // EXITtoolStripButton10
            // 
            this.EXITtoolStripButton10.AutoSize = false;
            this.EXITtoolStripButton10.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.EXITtoolStripButton10.Image = ((System.Drawing.Image)(resources.GetObject("EXITtoolStripButton10.Image")));
            this.EXITtoolStripButton10.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.EXITtoolStripButton10.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.EXITtoolStripButton10.Name = "EXITtoolStripButton10";
            this.EXITtoolStripButton10.Size = new System.Drawing.Size(110, 80);
            this.EXITtoolStripButton10.Text = "toolStripButton5";
            this.EXITtoolStripButton10.Click += new System.EventHandler(this.EXITtoolStripButton10_Click);
            // 
            // picDrawingSurface
            // 
            this.picDrawingSurface.BackColor = System.Drawing.Color.White;
            this.picDrawingSurface.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picDrawingSurface.Location = new System.Drawing.Point(19, 18);
            this.picDrawingSurface.Name = "picDrawingSurface";
            this.picDrawingSurface.Size = new System.Drawing.Size(706, 410);
            this.picDrawingSurface.TabIndex = 21;
            this.picDrawingSurface.TabStop = false;
            this.picDrawingSurface.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.picDrawingSurface_MouseDoubleClick);
            this.picDrawingSurface.MouseDown += new System.Windows.Forms.MouseEventHandler(this.picDrawingSurface_MouseDown);
            this.picDrawingSurface.MouseMove += new System.Windows.Forms.MouseEventHandler(this.picDrawingSurface_MouseMove);
            this.picDrawingSurface.MouseUp += new System.Windows.Forms.MouseEventHandler(this.picDrawingSurface_MouseUp);
            // 
            // RazmerKisti
            // 
            this.RazmerKisti.Location = new System.Drawing.Point(98, 434);
            this.RazmerKisti.Name = "RazmerKisti";
            this.RazmerKisti.Size = new System.Drawing.Size(287, 45);
            this.RazmerKisti.TabIndex = 22;
            this.RazmerKisti.Scroll += new System.EventHandler(this.RazmerKisti_Scroll);
            // 
            // Lupa
            // 
            this.Lupa.Location = new System.Drawing.Point(391, 434);
            this.Lupa.Name = "Lupa";
            this.Lupa.Size = new System.Drawing.Size(287, 45);
            this.Lupa.TabIndex = 23;
            this.Lupa.Scroll += new System.EventHandler(this.Lupa_Scroll);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(520, 466);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(32, 13);
            this.label3.TabIndex = 25;
            this.label3.Text = "Лупа";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(197, 466);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 13);
            this.label2.TabIndex = 26;
            this.label2.Text = "Размер кисти";
            // 
            // LBLxy
            // 
            this.LBLxy.AutoSize = true;
            this.LBLxy.Location = new System.Drawing.Point(16, 456);
            this.LBLxy.Name = "LBLxy";
            this.LBLxy.Size = new System.Drawing.Size(22, 13);
            this.LBLxy.TabIndex = 27;
            this.LBLxy.Text = ".....";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.picDrawingSurface);
            this.panel1.Controls.Add(this.LBLxy);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.Lupa);
            this.panel1.Controls.Add(this.RazmerKisti);
            this.panel1.Location = new System.Drawing.Point(114, 24);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(740, 507);
            this.panel1.TabIndex = 28;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(866, 534);
            this.Controls.Add(this.toolStrip2);
            this.Controls.Add(this.menuStrip2);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.Text = "Paint";
            this.menuStrip2.ResumeLayout(false);
            this.menuStrip2.PerformLayout();
            this.toolStrip2.ResumeLayout(false);
            this.toolStrip2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picDrawingSurface)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.RazmerKisti)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Lupa)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip2;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem newToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem6;
        private System.Windows.Forms.ToolStripMenuItem undoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem renoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem penToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem styleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem solidToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dotToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dashDotDotToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem colorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem7;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStrip toolStrip2;
        private System.Windows.Forms.ToolStripButton NEWtoolStripButton6;
        private System.Windows.Forms.ToolStripButton SAVEtoolStripButton;
        private System.Windows.Forms.ToolStripButton OPENtoolStripButton8;
        private System.Windows.Forms.ToolStripButton COLORtoolStripButton9;
        private System.Windows.Forms.ToolStripButton EXITtoolStripButton10;
        public System.Windows.Forms.PictureBox picDrawingSurface;
        private System.Windows.Forms.TrackBar RazmerKisti;
        private System.Windows.Forms.TrackBar Lupa;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label LBLxy;
        private System.Windows.Forms.Panel panel1;
    }
}

