namespace LearNAV
{
    partial class Shelf
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
            this._shelf_elipse = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.pnl_above = new Guna.UI2.WinForms.Guna2ShadowPanel();
            this.exit_btn = new Guna.UI2.WinForms.Guna2CircleButton();
            this.lbl_title = new System.Windows.Forms.Label();
            this.guna2Button4 = new Guna.UI2.WinForms.Guna2Button();
            this.btn_refresh = new Guna.UI2.WinForms.Guna2Button();
            this.btn_new_tags = new Guna.UI2.WinForms.Guna2Button();
            this.btn_new_resource = new Guna.UI2.WinForms.Guna2Button();
            this.guna2GradientPanel1 = new Guna.UI2.WinForms.Guna2GradientPanel();
            this.pnl_tags = new System.Windows.Forms.FlowLayoutPanel();
            this.item_list = new System.Windows.Forms.ListView();
            this.ID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.R_Name = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.R_Author = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Date_Ad = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Tags = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btn_accss = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.guna2DragControl1 = new Guna.UI2.WinForms.Guna2DragControl(this.components);
            this.guna2DragControl2 = new Guna.UI2.WinForms.Guna2DragControl(this.components);
            this.btn_new_folder = new Guna.UI2.WinForms.Guna2Button();
            this.pnl_methods = new System.Windows.Forms.Panel();
            this.guna2Button1 = new Guna.UI2.WinForms.Guna2Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.search_bar = new Guna.UI2.WinForms.Guna2TextBox();
            this.pnl_above.SuspendLayout();
            this.pnl_methods.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // _shelf_elipse
            // 
            this._shelf_elipse.BorderRadius = 15;
            this._shelf_elipse.TargetControl = this;
            // 
            // pnl_above
            // 
            this.pnl_above.BackColor = System.Drawing.Color.Transparent;
            this.pnl_above.Controls.Add(this.exit_btn);
            this.pnl_above.Controls.Add(this.lbl_title);
            this.pnl_above.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnl_above.FillColor = System.Drawing.SystemColors.ControlDark;
            this.pnl_above.Location = new System.Drawing.Point(0, 0);
            this.pnl_above.Name = "pnl_above";
            this.pnl_above.ShadowColor = System.Drawing.Color.Black;
            this.pnl_above.ShadowDepth = 12;
            this.pnl_above.ShadowShift = 3;
            this.pnl_above.ShadowStyle = Guna.UI2.WinForms.Guna2ShadowPanel.ShadowMode.Dropped;
            this.pnl_above.Size = new System.Drawing.Size(967, 43);
            this.pnl_above.TabIndex = 0;
            // 
            // exit_btn
            // 
            this.exit_btn.Animated = true;
            this.exit_btn.BackColor = System.Drawing.Color.Transparent;
            this.exit_btn.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(81)))), ((int)(((byte)(81)))));
            this.exit_btn.CheckedState.Parent = this.exit_btn;
            this.exit_btn.CustomImages.Parent = this.exit_btn;
            this.exit_btn.FillColor = System.Drawing.Color.White;
            this.exit_btn.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.exit_btn.ForeColor = System.Drawing.Color.White;
            this.exit_btn.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(81)))), ((int)(((byte)(81)))));
            this.exit_btn.HoverState.Parent = this.exit_btn;
            this.exit_btn.Location = new System.Drawing.Point(939, 12);
            this.exit_btn.Name = "exit_btn";
            this.exit_btn.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.exit_btn.ShadowDecoration.Parent = this.exit_btn;
            this.exit_btn.Size = new System.Drawing.Size(15, 15);
            this.exit_btn.TabIndex = 3;
            this.exit_btn.Text = "guna2CircleButton1";
            this.exit_btn.Click += new System.EventHandler(this.exit_btn_Click);
            // 
            // lbl_title
            // 
            this.lbl_title.AutoSize = true;
            this.lbl_title.Font = new System.Drawing.Font("Fira Sans SemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_title.ForeColor = System.Drawing.Color.White;
            this.lbl_title.Location = new System.Drawing.Point(433, 9);
            this.lbl_title.Name = "lbl_title";
            this.lbl_title.Size = new System.Drawing.Size(99, 19);
            this.lbl_title.TabIndex = 0;
            this.lbl_title.Text = "Libr-e SHELF";
            // 
            // guna2Button4
            // 
            this.guna2Button4.Animated = true;
            this.guna2Button4.AutoRoundedCorners = true;
            this.guna2Button4.BorderColor = System.Drawing.SystemColors.ControlDarkDark;
            this.guna2Button4.BorderRadius = 17;
            this.guna2Button4.BorderThickness = 1;
            this.guna2Button4.CheckedState.Parent = this.guna2Button4;
            this.guna2Button4.CustomImages.Parent = this.guna2Button4;
            this.guna2Button4.FillColor = System.Drawing.SystemColors.Control;
            this.guna2Button4.Font = new System.Drawing.Font("Fira Sans", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2Button4.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.guna2Button4.HoverState.FillColor = System.Drawing.SystemColors.ControlDarkDark;
            this.guna2Button4.HoverState.ForeColor = System.Drawing.Color.White;
            this.guna2Button4.HoverState.Parent = this.guna2Button4;
            this.guna2Button4.Location = new System.Drawing.Point(707, 87);
            this.guna2Button4.Name = "guna2Button4";
            this.guna2Button4.ShadowDecoration.Parent = this.guna2Button4;
            this.guna2Button4.Size = new System.Drawing.Size(214, 37);
            this.guna2Button4.TabIndex = 8;
            this.guna2Button4.Text = "Advanced Search";
            // 
            // btn_refresh
            // 
            this.btn_refresh.Animated = true;
            this.btn_refresh.AutoRoundedCorners = true;
            this.btn_refresh.BorderColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btn_refresh.BorderRadius = 17;
            this.btn_refresh.BorderThickness = 1;
            this.btn_refresh.CheckedState.Parent = this.btn_refresh;
            this.btn_refresh.CustomImages.Parent = this.btn_refresh;
            this.btn_refresh.FillColor = System.Drawing.SystemColors.Control;
            this.btn_refresh.Font = new System.Drawing.Font("Fira Sans", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_refresh.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btn_refresh.HoverState.FillColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btn_refresh.HoverState.ForeColor = System.Drawing.Color.White;
            this.btn_refresh.HoverState.Parent = this.btn_refresh;
            this.btn_refresh.Location = new System.Drawing.Point(561, 87);
            this.btn_refresh.Name = "btn_refresh";
            this.btn_refresh.ShadowDecoration.Parent = this.btn_refresh;
            this.btn_refresh.Size = new System.Drawing.Size(119, 37);
            this.btn_refresh.TabIndex = 7;
            this.btn_refresh.Text = "Refresh";
            // 
            // btn_new_tags
            // 
            this.btn_new_tags.Animated = true;
            this.btn_new_tags.AutoRoundedCorners = true;
            this.btn_new_tags.BorderColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btn_new_tags.BorderRadius = 17;
            this.btn_new_tags.BorderThickness = 1;
            this.btn_new_tags.CheckedState.Parent = this.btn_new_tags;
            this.btn_new_tags.CustomImages.Parent = this.btn_new_tags;
            this.btn_new_tags.FillColor = System.Drawing.SystemColors.Control;
            this.btn_new_tags.Font = new System.Drawing.Font("Fira Sans", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_new_tags.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btn_new_tags.HoverState.FillColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btn_new_tags.HoverState.ForeColor = System.Drawing.Color.White;
            this.btn_new_tags.HoverState.Parent = this.btn_new_tags;
            this.btn_new_tags.Location = new System.Drawing.Point(215, 87);
            this.btn_new_tags.Name = "btn_new_tags";
            this.btn_new_tags.ShadowDecoration.Parent = this.btn_new_tags;
            this.btn_new_tags.Size = new System.Drawing.Size(197, 37);
            this.btn_new_tags.TabIndex = 6;
            this.btn_new_tags.Text = "New Tag Collection";
            // 
            // btn_new_resource
            // 
            this.btn_new_resource.Animated = true;
            this.btn_new_resource.AutoRoundedCorners = true;
            this.btn_new_resource.BackColor = System.Drawing.Color.Transparent;
            this.btn_new_resource.BorderColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btn_new_resource.BorderRadius = 17;
            this.btn_new_resource.BorderThickness = 1;
            this.btn_new_resource.CheckedState.Parent = this.btn_new_resource;
            this.btn_new_resource.CustomImages.Parent = this.btn_new_resource;
            this.btn_new_resource.FillColor = System.Drawing.SystemColors.Control;
            this.btn_new_resource.Font = new System.Drawing.Font("Fira Sans", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_new_resource.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btn_new_resource.HoverState.FillColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btn_new_resource.HoverState.ForeColor = System.Drawing.Color.White;
            this.btn_new_resource.HoverState.Parent = this.btn_new_resource;
            this.btn_new_resource.ImageSize = new System.Drawing.Size(23, 20);
            this.btn_new_resource.Location = new System.Drawing.Point(12, 87);
            this.btn_new_resource.Name = "btn_new_resource";
            this.btn_new_resource.ShadowDecoration.Parent = this.btn_new_resource;
            this.btn_new_resource.Size = new System.Drawing.Size(197, 37);
            this.btn_new_resource.TabIndex = 5;
            this.btn_new_resource.Text = "New Resource";
            this.btn_new_resource.Click += new System.EventHandler(this.btn_new_resource_Click);
            // 
            // guna2GradientPanel1
            // 
            this.guna2GradientPanel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.guna2GradientPanel1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(150)))), ((int)(((byte)(243)))));
            this.guna2GradientPanel1.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(122)))), ((int)(((byte)(107)))));
            this.guna2GradientPanel1.Location = new System.Drawing.Point(0, 558);
            this.guna2GradientPanel1.Name = "guna2GradientPanel1";
            this.guna2GradientPanel1.ShadowDecoration.Parent = this.guna2GradientPanel1;
            this.guna2GradientPanel1.Size = new System.Drawing.Size(967, 10);
            this.guna2GradientPanel1.TabIndex = 9;
            // 
            // pnl_tags
            // 
            this.pnl_tags.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnl_tags.Location = new System.Drawing.Point(12, 130);
            this.pnl_tags.Name = "pnl_tags";
            this.pnl_tags.Size = new System.Drawing.Size(197, 422);
            this.pnl_tags.TabIndex = 10;
            // 
            // item_list
            // 
            this.item_list.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.item_list.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.ID,
            this.R_Name,
            this.R_Author,
            this.Date_Ad,
            this.Tags});
            this.item_list.Font = new System.Drawing.Font("Fira Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.item_list.Location = new System.Drawing.Point(215, 130);
            this.item_list.Name = "item_list";
            this.item_list.Size = new System.Drawing.Size(739, 385);
            this.item_list.TabIndex = 11;
            this.item_list.UseCompatibleStateImageBehavior = false;
            this.item_list.View = System.Windows.Forms.View.Details;
            // 
            // ID
            // 
            this.ID.Text = "ID";
            // 
            // R_Name
            // 
            this.R_Name.Text = "Resource Name";
            this.R_Name.Width = 167;
            // 
            // R_Author
            // 
            this.R_Author.Text = "Resource Author";
            this.R_Author.Width = 190;
            // 
            // Date_Ad
            // 
            this.Date_Ad.Text = "Date Added";
            this.Date_Ad.Width = 110;
            // 
            // Tags
            // 
            this.Tags.Text = "Tags";
            this.Tags.Width = 204;
            // 
            // btn_accss
            // 
            this.btn_accss.Animated = true;
            this.btn_accss.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(97)))), ((int)(((byte)(179)))), ((int)(((byte)(154)))));
            this.btn_accss.BorderRadius = 8;
            this.btn_accss.BorderThickness = 2;
            this.btn_accss.CheckedState.Parent = this.btn_accss;
            this.btn_accss.CustomImages.Parent = this.btn_accss;
            this.btn_accss.FillColor = System.Drawing.SystemColors.Control;
            this.btn_accss.Font = new System.Drawing.Font("Fira Sans", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_accss.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(97)))), ((int)(((byte)(179)))), ((int)(((byte)(154)))));
            this.btn_accss.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(97)))), ((int)(((byte)(179)))), ((int)(((byte)(154)))));
            this.btn_accss.HoverState.ForeColor = System.Drawing.Color.White;
            this.btn_accss.HoverState.Parent = this.btn_accss;
            this.btn_accss.Location = new System.Drawing.Point(782, 501);
            this.btn_accss.Name = "btn_accss";
            this.btn_accss.ShadowDecoration.Parent = this.btn_accss;
            this.btn_accss.Size = new System.Drawing.Size(172, 37);
            this.btn_accss.TabIndex = 12;
            this.btn_accss.Text = "Access";
            // 
            // guna2Elipse1
            // 
            this.guna2Elipse1.BorderRadius = 12;
            this.guna2Elipse1.TargetControl = this.item_list;
            // 
            // guna2DragControl1
            // 
            this.guna2DragControl1.TargetControl = this;
            // 
            // guna2DragControl2
            // 
            this.guna2DragControl2.TargetControl = this.pnl_above;
            // 
            // btn_new_folder
            // 
            this.btn_new_folder.Animated = true;
            this.btn_new_folder.AutoRoundedCorners = true;
            this.btn_new_folder.BorderColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btn_new_folder.BorderRadius = 17;
            this.btn_new_folder.BorderThickness = 1;
            this.btn_new_folder.CheckedState.Parent = this.btn_new_folder;
            this.btn_new_folder.CustomImages.Parent = this.btn_new_folder;
            this.btn_new_folder.FillColor = System.Drawing.SystemColors.Control;
            this.btn_new_folder.Font = new System.Drawing.Font("Fira Sans", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_new_folder.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btn_new_folder.HoverState.FillColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btn_new_folder.HoverState.ForeColor = System.Drawing.Color.White;
            this.btn_new_folder.HoverState.Parent = this.btn_new_folder;
            this.btn_new_folder.Location = new System.Drawing.Point(418, 87);
            this.btn_new_folder.Name = "btn_new_folder";
            this.btn_new_folder.ShadowDecoration.Parent = this.btn_new_folder;
            this.btn_new_folder.Size = new System.Drawing.Size(137, 37);
            this.btn_new_folder.TabIndex = 13;
            this.btn_new_folder.Text = "New(Folder)";
            // 
            // pnl_methods
            // 
            this.pnl_methods.Controls.Add(this.guna2Button1);
            this.pnl_methods.Location = new System.Drawing.Point(975, 45);
            this.pnl_methods.Name = "pnl_methods";
            this.pnl_methods.Size = new System.Drawing.Size(277, 515);
            this.pnl_methods.TabIndex = 14;
            // 
            // guna2Button1
            // 
            this.guna2Button1.Animated = true;
            this.guna2Button1.AutoRoundedCorners = true;
            this.guna2Button1.BorderColor = System.Drawing.SystemColors.ControlDarkDark;
            this.guna2Button1.BorderRadius = 17;
            this.guna2Button1.BorderThickness = 1;
            this.guna2Button1.CheckedState.Parent = this.guna2Button1;
            this.guna2Button1.CustomImages.Parent = this.guna2Button1;
            this.guna2Button1.FillColor = System.Drawing.SystemColors.Control;
            this.guna2Button1.Font = new System.Drawing.Font("Fira Sans", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2Button1.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.guna2Button1.HoverState.FillColor = System.Drawing.SystemColors.ControlDarkDark;
            this.guna2Button1.HoverState.ForeColor = System.Drawing.Color.White;
            this.guna2Button1.HoverState.Parent = this.guna2Button1;
            this.guna2Button1.Location = new System.Drawing.Point(155, 472);
            this.guna2Button1.Name = "guna2Button1";
            this.guna2Button1.ShadowDecoration.Parent = this.guna2Button1;
            this.guna2Button1.Size = new System.Drawing.Size(119, 37);
            this.guna2Button1.TabIndex = 15;
            this.guna2Button1.Text = "Done";
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.Image = global::LearNAV.Properties.Resources.basic_settings;
            this.pictureBox2.Location = new System.Drawing.Point(927, 54);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(27, 27);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 3;
            this.pictureBox2.TabStop = false;
            // 
            // search_bar
            // 
            this.search_bar.Animated = true;
            this.search_bar.AutoRoundedCorners = true;
            this.search_bar.BackColor = System.Drawing.Color.Transparent;
            this.search_bar.BorderRadius = 17;
            this.search_bar.BorderThickness = 2;
            this.search_bar.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.search_bar.DefaultText = "";
            this.search_bar.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.search_bar.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.search_bar.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.search_bar.DisabledState.Parent = this.search_bar;
            this.search_bar.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.search_bar.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.search_bar.FocusedState.Parent = this.search_bar;
            this.search_bar.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.search_bar.HoverState.BorderColor = System.Drawing.SystemColors.ControlDarkDark;
            this.search_bar.HoverState.Parent = this.search_bar;
            this.search_bar.IconLeft = global::LearNAV.Properties.Resources.basic_magnifier;
            this.search_bar.IconLeftOffset = new System.Drawing.Point(10, 0);
            this.search_bar.Location = new System.Drawing.Point(12, 45);
            this.search_bar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.search_bar.Name = "search_bar";
            this.search_bar.PasswordChar = '\0';
            this.search_bar.PlaceholderText = "";
            this.search_bar.SelectedText = "";
            this.search_bar.ShadowDecoration.BorderRadius = 15;
            this.search_bar.ShadowDecoration.Color = System.Drawing.SystemColors.ControlDarkDark;
            this.search_bar.ShadowDecoration.Depth = 100;
            this.search_bar.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.search_bar.ShadowDecoration.Parent = this.search_bar;
            this.search_bar.ShadowDecoration.Shadow = new System.Windows.Forms.Padding(5, 5, 5, 100);
            this.search_bar.Size = new System.Drawing.Size(909, 36);
            this.search_bar.TabIndex = 1;
            // 
            // Shelf
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(967, 568);
            this.Controls.Add(this.pnl_methods);
            this.Controls.Add(this.btn_new_folder);
            this.Controls.Add(this.item_list);
            this.Controls.Add(this.btn_accss);
            this.Controls.Add(this.pnl_tags);
            this.Controls.Add(this.guna2GradientPanel1);
            this.Controls.Add(this.guna2Button4);
            this.Controls.Add(this.btn_refresh);
            this.Controls.Add(this.btn_new_tags);
            this.Controls.Add(this.btn_new_resource);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.search_bar);
            this.Controls.Add(this.pnl_above);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Shelf";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Libr-e SHELF";
            this.pnl_above.ResumeLayout(false);
            this.pnl_above.PerformLayout();
            this.pnl_methods.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Elipse _shelf_elipse;
        private Guna.UI2.WinForms.Guna2TextBox search_bar;
        private Guna.UI2.WinForms.Guna2ShadowPanel pnl_above;
        private System.Windows.Forms.Label lbl_title;
        private Guna.UI2.WinForms.Guna2CircleButton exit_btn;
        private System.Windows.Forms.PictureBox pictureBox2;
        private Guna.UI2.WinForms.Guna2Button btn_new_resource;
        private Guna.UI2.WinForms.Guna2Button btn_refresh;
        private Guna.UI2.WinForms.Guna2Button btn_new_tags;
        private Guna.UI2.WinForms.Guna2Button guna2Button4;
        private Guna.UI2.WinForms.Guna2GradientPanel guna2GradientPanel1;
        private Guna.UI2.WinForms.Guna2Button btn_accss;
        private System.Windows.Forms.ListView item_list;
        private System.Windows.Forms.FlowLayoutPanel pnl_tags;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
        private System.Windows.Forms.ColumnHeader ID;
        private System.Windows.Forms.ColumnHeader R_Name;
        private System.Windows.Forms.ColumnHeader R_Author;
        private System.Windows.Forms.ColumnHeader Date_Ad;
        private System.Windows.Forms.ColumnHeader Tags;
        private Guna.UI2.WinForms.Guna2DragControl guna2DragControl1;
        private Guna.UI2.WinForms.Guna2DragControl guna2DragControl2;
        private Guna.UI2.WinForms.Guna2Button btn_new_folder;
        private System.Windows.Forms.Panel pnl_methods;
        private Guna.UI2.WinForms.Guna2Button guna2Button1;
    }
}