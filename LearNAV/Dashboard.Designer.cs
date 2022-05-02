﻿namespace Libre
{
    partial class Dashboard
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Dashboard));
            this.Main = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.exit_btn = new Guna.UI2.WinForms.Guna2CircleButton();
            this.left_panel = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.right_panel = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.main_pnl = new Guna.UI2.WinForms.Guna2Panel();
            this.guna2Button1 = new Guna.UI2.WinForms.Guna2Button();
            this.theme_mode = new Guna.UI2.WinForms.Guna2ToggleSwitch();
            this.btn_change_view = new Guna.UI2.WinForms.Guna2GradientButton();
            this.btn_details = new Guna.UI2.WinForms.Guna2GradientButton();
            this.btn_accs = new Guna.UI2.WinForms.Guna2GradientButton();
            this.btn_quick = new Guna.UI2.WinForms.Guna2Button();
            this.btn_advanced = new Guna.UI2.WinForms.Guna2Button();
            this.lbl_qck_srch = new System.Windows.Forms.Label();
            this.search_txtbx = new Guna.UI2.WinForms.Guna2TextBox();
            this.search_results = new System.Windows.Forms.ListView();
            this.ID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.guna2Elipse3 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.guna2Elipse4 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.mainDrag = new Guna.UI2.WinForms.Guna2DragControl(this.components);
            this.pnl_drag = new Guna.UI2.WinForms.Guna2DragControl(this.components);
            this.lbl_libre = new System.Windows.Forms.Label();
            this.lbl_c = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lbl_version = new System.Windows.Forms.Label();
            this.theme_management = new System.Windows.Forms.ToolTip(this.components);
            this.guna2Elipse2 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.guna2Elipse5 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.guna2Elipse6 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.btn_close = new Guna.UI2.WinForms.Guna2CircleButton();
            this.pnl_results = new System.Windows.Forms.FlowLayoutPanel();
            this.main_pnl.SuspendLayout();
            this.SuspendLayout();
            // 
            // Main
            // 
            this.Main.BorderRadius = 30;
            this.Main.TargetControl = this;
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
            this.exit_btn.Location = new System.Drawing.Point(825, 8);
            this.exit_btn.Name = "exit_btn";
            this.exit_btn.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.exit_btn.ShadowDecoration.Parent = this.exit_btn;
            this.exit_btn.Size = new System.Drawing.Size(15, 15);
            this.exit_btn.TabIndex = 0;
            this.exit_btn.Text = "guna2CircleButton1";
            this.exit_btn.Click += new System.EventHandler(this.exit_btn_Click);
            // 
            // left_panel
            // 
            this.left_panel.BorderRadius = 15;
            // 
            // right_panel
            // 
            this.right_panel.BorderRadius = 30;
            this.right_panel.TargetControl = this.main_pnl;
            // 
            // main_pnl
            // 
            this.main_pnl.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(41)))), ((int)(((byte)(54)))));
            this.main_pnl.BackgroundImage = global::Libre.Properties.Resources.final_test1;
            this.main_pnl.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.main_pnl.Controls.Add(this.guna2Button1);
            this.main_pnl.Controls.Add(this.theme_mode);
            this.main_pnl.Controls.Add(this.pnl_results);
            this.main_pnl.Controls.Add(this.btn_change_view);
            this.main_pnl.Controls.Add(this.btn_details);
            this.main_pnl.Controls.Add(this.btn_accs);
            this.main_pnl.Controls.Add(this.btn_quick);
            this.main_pnl.Controls.Add(this.btn_advanced);
            this.main_pnl.Controls.Add(this.lbl_qck_srch);
            this.main_pnl.Controls.Add(this.search_txtbx);
            this.main_pnl.Controls.Add(this.search_results);
            this.main_pnl.Location = new System.Drawing.Point(12, 29);
            this.main_pnl.Name = "main_pnl";
            this.main_pnl.ShadowDecoration.Parent = this.main_pnl;
            this.main_pnl.Size = new System.Drawing.Size(828, 535);
            this.main_pnl.TabIndex = 1;
            // 
            // guna2Button1
            // 
            this.guna2Button1.Animated = true;
            this.guna2Button1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(92)))), ((int)(((byte)(121)))));
            this.guna2Button1.BorderRadius = 8;
            this.guna2Button1.BorderThickness = 2;
            this.guna2Button1.CheckedState.Parent = this.guna2Button1;
            this.guna2Button1.CustomImages.Parent = this.guna2Button1;
            this.guna2Button1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(28)))), ((int)(((byte)(37)))));
            this.guna2Button1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.guna2Button1.ForeColor = System.Drawing.Color.White;
            this.guna2Button1.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(92)))), ((int)(((byte)(121)))));
            this.guna2Button1.HoverState.Parent = this.guna2Button1;
            this.guna2Button1.Location = new System.Drawing.Point(653, 29);
            this.guna2Button1.Name = "guna2Button1";
            this.guna2Button1.ShadowDecoration.Parent = this.guna2Button1;
            this.guna2Button1.Size = new System.Drawing.Size(22, 20);
            this.guna2Button1.TabIndex = 0;
            this.guna2Button1.Text = ">";
            this.guna2Button1.Visible = false;
            this.guna2Button1.Click += new System.EventHandler(this.guna2Button1_Click_1);
            // 
            // theme_mode
            // 
            this.theme_mode.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(115)))), ((int)(((byte)(194)))), ((int)(((byte)(196)))));
            this.theme_mode.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(115)))), ((int)(((byte)(194)))), ((int)(((byte)(196)))));
            this.theme_mode.CheckedState.InnerBorderColor = System.Drawing.Color.White;
            this.theme_mode.CheckedState.InnerColor = System.Drawing.Color.White;
            this.theme_mode.CheckedState.Parent = this.theme_mode;
            this.theme_mode.Location = new System.Drawing.Point(208, 31);
            this.theme_mode.Name = "theme_mode";
            this.theme_mode.ShadowDecoration.Parent = this.theme_mode;
            this.theme_mode.Size = new System.Drawing.Size(35, 20);
            this.theme_mode.TabIndex = 0;
            this.theme_mode.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.theme_mode.UncheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.theme_mode.UncheckedState.InnerBorderColor = System.Drawing.Color.White;
            this.theme_mode.UncheckedState.InnerColor = System.Drawing.Color.White;
            this.theme_mode.UncheckedState.Parent = this.theme_mode;
            this.theme_mode.CheckedChanged += new System.EventHandler(this.theme_mode_CheckedChanged);
            // 
            // btn_change_view
            // 
            this.btn_change_view.Animated = true;
            this.btn_change_view.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(55)))), ((int)(((byte)(144)))));
            this.btn_change_view.BorderRadius = 8;
            this.btn_change_view.BorderThickness = 2;
            this.btn_change_view.CheckedState.Parent = this.btn_change_view;
            this.btn_change_view.CustomImages.Parent = this.btn_change_view;
            this.btn_change_view.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(41)))), ((int)(((byte)(54)))));
            this.btn_change_view.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(41)))), ((int)(((byte)(54)))));
            this.btn_change_view.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_change_view.ForeColor = System.Drawing.Color.White;
            this.btn_change_view.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(146)))), ((int)(((byte)(75)))), ((int)(((byte)(73)))));
            this.btn_change_view.HoverState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(55)))), ((int)(((byte)(144)))));
            this.btn_change_view.HoverState.Parent = this.btn_change_view;
            this.btn_change_view.Location = new System.Drawing.Point(20, 471);
            this.btn_change_view.Name = "btn_change_view";
            this.btn_change_view.ShadowDecoration.Parent = this.btn_change_view;
            this.btn_change_view.Size = new System.Drawing.Size(223, 36);
            this.btn_change_view.TabIndex = 27;
            this.btn_change_view.Text = "Change View";
            this.btn_change_view.Click += new System.EventHandler(this.btn_change_view_Click);
            // 
            // btn_details
            // 
            this.btn_details.Animated = true;
            this.btn_details.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(83)))), ((int)(((byte)(165)))));
            this.btn_details.BorderRadius = 8;
            this.btn_details.BorderThickness = 2;
            this.btn_details.CheckedState.Parent = this.btn_details;
            this.btn_details.CustomImages.Parent = this.btn_details;
            this.btn_details.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(41)))), ((int)(((byte)(54)))));
            this.btn_details.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(41)))), ((int)(((byte)(54)))));
            this.btn_details.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_details.ForeColor = System.Drawing.Color.White;
            this.btn_details.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(93)))), ((int)(((byte)(96)))), ((int)(((byte)(177)))));
            this.btn_details.HoverState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(83)))), ((int)(((byte)(165)))));
            this.btn_details.HoverState.Parent = this.btn_details;
            this.btn_details.Location = new System.Drawing.Point(486, 473);
            this.btn_details.Name = "btn_details";
            this.btn_details.ShadowDecoration.Parent = this.btn_details;
            this.btn_details.Size = new System.Drawing.Size(136, 36);
            this.btn_details.TabIndex = 24;
            this.btn_details.Text = "Visit Shelf";
            this.btn_details.Click += new System.EventHandler(this.btn_details_Click);
            // 
            // btn_accs
            // 
            this.btn_accs.Animated = true;
            this.btn_accs.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(97)))), ((int)(((byte)(179)))), ((int)(((byte)(154)))));
            this.btn_accs.CheckedState.Parent = this.btn_accs;
            this.btn_accs.CustomImages.Parent = this.btn_accs;
            this.btn_accs.Enabled = false;
            this.btn_accs.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(97)))), ((int)(((byte)(179)))), ((int)(((byte)(127)))));
            this.btn_accs.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(97)))), ((int)(((byte)(179)))), ((int)(((byte)(154)))));
            this.btn_accs.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_accs.ForeColor = System.Drawing.Color.White;
            this.btn_accs.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(97)))), ((int)(((byte)(179)))), ((int)(((byte)(127)))));
            this.btn_accs.HoverState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(97)))), ((int)(((byte)(179)))), ((int)(((byte)(154)))));
            this.btn_accs.HoverState.Parent = this.btn_accs;
            this.btn_accs.Location = new System.Drawing.Point(628, 471);
            this.btn_accs.Name = "btn_accs";
            this.btn_accs.ShadowDecoration.BorderRadius = 40;
            this.btn_accs.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.btn_accs.ShadowDecoration.Parent = this.btn_accs;
            this.btn_accs.ShadowDecoration.Shadow = new System.Windows.Forms.Padding(5, 5, 15, 15);
            this.btn_accs.Size = new System.Drawing.Size(183, 38);
            this.btn_accs.TabIndex = 23;
            this.btn_accs.Text = "Access";
            this.btn_accs.Click += new System.EventHandler(this.btn_accs_Click);
            // 
            // btn_quick
            // 
            this.btn_quick.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(28)))), ((int)(((byte)(37)))));
            this.btn_quick.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(92)))), ((int)(((byte)(121)))));
            this.btn_quick.BorderThickness = 2;
            this.btn_quick.CheckedState.Parent = this.btn_quick;
            this.btn_quick.CustomImages.Parent = this.btn_quick;
            this.btn_quick.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(28)))), ((int)(((byte)(37)))));
            this.btn_quick.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_quick.ForeColor = System.Drawing.Color.White;
            this.btn_quick.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(28)))), ((int)(((byte)(37)))));
            this.btn_quick.HoverState.Parent = this.btn_quick;
            this.btn_quick.Location = new System.Drawing.Point(552, 56);
            this.btn_quick.Name = "btn_quick";
            this.btn_quick.ShadowDecoration.Parent = this.btn_quick;
            this.btn_quick.Size = new System.Drawing.Size(98, 28);
            this.btn_quick.TabIndex = 1;
            this.btn_quick.Text = "Search";
            this.btn_quick.Click += new System.EventHandler(this.guna2Button1_Click);
            // 
            // btn_advanced
            // 
            this.btn_advanced.Animated = true;
            this.btn_advanced.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(92)))), ((int)(((byte)(121)))));
            this.btn_advanced.BorderRadius = 12;
            this.btn_advanced.BorderThickness = 2;
            this.btn_advanced.CheckedState.Parent = this.btn_advanced;
            this.btn_advanced.CustomImages.Parent = this.btn_advanced;
            this.btn_advanced.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(41)))), ((int)(((byte)(54)))));
            this.btn_advanced.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_advanced.ForeColor = System.Drawing.Color.White;
            this.btn_advanced.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(92)))), ((int)(((byte)(121)))));
            this.btn_advanced.HoverState.Parent = this.btn_advanced;
            this.btn_advanced.Location = new System.Drawing.Point(638, 55);
            this.btn_advanced.Name = "btn_advanced";
            this.btn_advanced.ShadowDecoration.Parent = this.btn_advanced;
            this.btn_advanced.Size = new System.Drawing.Size(173, 30);
            this.btn_advanced.TabIndex = 22;
            this.btn_advanced.Text = "Advanced Search";
            this.btn_advanced.Click += new System.EventHandler(this.btn_advanced_Click);
            // 
            // lbl_qck_srch
            // 
            this.lbl_qck_srch.AutoSize = true;
            this.lbl_qck_srch.BackColor = System.Drawing.Color.Transparent;
            this.lbl_qck_srch.Font = new System.Drawing.Font("Microsoft Sans Serif", 22F, System.Drawing.FontStyle.Bold);
            this.lbl_qck_srch.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(130)))), ((int)(((byte)(205)))), ((int)(((byte)(185)))));
            this.lbl_qck_srch.Location = new System.Drawing.Point(14, 15);
            this.lbl_qck_srch.Name = "lbl_qck_srch";
            this.lbl_qck_srch.Size = new System.Drawing.Size(205, 36);
            this.lbl_qck_srch.TabIndex = 0;
            this.lbl_qck_srch.Text = "Quick Search";
            // 
            // search_txtbx
            // 
            this.search_txtbx.AutoRoundedCorners = true;
            this.search_txtbx.BorderRadius = 12;
            this.search_txtbx.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.search_txtbx.DefaultText = "test";
            this.search_txtbx.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.search_txtbx.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.search_txtbx.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.search_txtbx.DisabledState.Parent = this.search_txtbx;
            this.search_txtbx.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.search_txtbx.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.search_txtbx.FocusedState.Parent = this.search_txtbx;
            this.search_txtbx.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.search_txtbx.ForeColor = System.Drawing.Color.Black;
            this.search_txtbx.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.search_txtbx.HoverState.Parent = this.search_txtbx;
            this.search_txtbx.IconLeft = global::Libre.Properties.Resources.search_outline;
            this.search_txtbx.Location = new System.Drawing.Point(20, 56);
            this.search_txtbx.Margin = new System.Windows.Forms.Padding(5);
            this.search_txtbx.Name = "search_txtbx";
            this.search_txtbx.PasswordChar = '\0';
            this.search_txtbx.PlaceholderText = "";
            this.search_txtbx.SelectedText = "";
            this.search_txtbx.SelectionStart = 4;
            this.search_txtbx.ShadowDecoration.Parent = this.search_txtbx;
            this.search_txtbx.Size = new System.Drawing.Size(562, 26);
            this.search_txtbx.TabIndex = 21;
            this.search_txtbx.TextChanged += new System.EventHandler(this.search_txtbx_TextChanged);
            // 
            // search_results
            // 
            this.search_results.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.search_results.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.ID,
            this.columnHeader2,
            this.columnHeader3});
            this.search_results.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.search_results.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(76)))), ((int)(((byte)(83)))));
            this.search_results.FullRowSelect = true;
            this.search_results.HideSelection = false;
            this.search_results.Location = new System.Drawing.Point(20, 90);
            this.search_results.Name = "search_results";
            this.search_results.Size = new System.Drawing.Size(791, 388);
            this.search_results.TabIndex = 25;
            this.search_results.UseCompatibleStateImageBehavior = false;
            this.search_results.View = System.Windows.Forms.View.Details;
            // 
            // ID
            // 
            this.ID.Text = "ID";
            this.ID.Width = 40;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Name";
            this.columnHeader2.Width = 300;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Resource";
            this.columnHeader3.Width = 180;
            // 
            // guna2Elipse1
            // 
            this.guna2Elipse1.BorderRadius = 15;
            this.guna2Elipse1.TargetControl = this.btn_advanced;
            // 
            // guna2Elipse3
            // 
            this.guna2Elipse3.BorderRadius = 12;
            this.guna2Elipse3.TargetControl = this.btn_accs;
            // 
            // guna2Elipse4
            // 
            this.guna2Elipse4.BorderRadius = 12;
            this.guna2Elipse4.TargetControl = this.btn_details;
            // 
            // mainDrag
            // 
            this.mainDrag.TargetControl = this;
            // 
            // pnl_drag
            // 
            this.pnl_drag.TargetControl = this.main_pnl;
            // 
            // lbl_libre
            // 
            this.lbl_libre.AutoSize = true;
            this.lbl_libre.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.lbl_libre.ForeColor = System.Drawing.Color.White;
            this.lbl_libre.Location = new System.Drawing.Point(336, 4);
            this.lbl_libre.Name = "lbl_libre";
            this.lbl_libre.Size = new System.Drawing.Size(74, 20);
            this.lbl_libre.TabIndex = 26;
            this.lbl_libre.Text = "L i b r e.";
            // 
            // lbl_c
            // 
            this.lbl_c.AutoSize = true;
            this.lbl_c.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Italic);
            this.lbl_c.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(92)))), ((int)(((byte)(121)))));
            this.lbl_c.Location = new System.Drawing.Point(29, 9);
            this.lbl_c.Name = "lbl_c";
            this.lbl_c.Size = new System.Drawing.Size(122, 13);
            this.lbl_c.TabIndex = 27;
            this.lbl_c.Text = "(C) 2019-2020 | team jar.";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(92)))), ((int)(((byte)(121)))));
            this.label4.Location = new System.Drawing.Point(415, 4);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(113, 20);
            this.label4.TabIndex = 28;
            this.label4.Text = "Beta Version";
            // 
            // lbl_version
            // 
            this.lbl_version.AutoSize = true;
            this.lbl_version.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic);
            this.lbl_version.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(92)))), ((int)(((byte)(121)))));
            this.lbl_version.Location = new System.Drawing.Point(685, 4);
            this.lbl_version.Name = "lbl_version";
            this.lbl_version.Size = new System.Drawing.Size(123, 20);
            this.lbl_version.TabIndex = 29;
            this.lbl_version.Text = "version 2. 0. 0. 1";
            // 
            // theme_management
            // 
            this.theme_management.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.theme_management.ToolTipTitle = "Use this to  change how this windows look.";
            // 
            // guna2Elipse2
            // 
            this.guna2Elipse2.BorderRadius = 12;
            this.guna2Elipse2.TargetControl = this.btn_change_view;
            // 
            // guna2Elipse5
            // 
            this.guna2Elipse5.BorderRadius = 12;
            this.guna2Elipse5.TargetControl = this.btn_details;
            // 
            // guna2Elipse6
            // 
            this.guna2Elipse6.BorderRadius = 12;
            this.guna2Elipse6.TargetControl = this.search_results;
            // 
            // btn_close
            // 
            this.btn_close.Animated = true;
            this.btn_close.BackColor = System.Drawing.Color.Transparent;
            this.btn_close.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(81)))), ((int)(((byte)(81)))));
            this.btn_close.CheckedState.Parent = this.btn_close;
            this.btn_close.CustomImages.Parent = this.btn_close;
            this.btn_close.FillColor = System.Drawing.Color.White;
            this.btn_close.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btn_close.ForeColor = System.Drawing.Color.White;
            this.btn_close.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(170)))), ((int)(((byte)(86)))));
            this.btn_close.HoverState.Parent = this.btn_close;
            this.btn_close.Location = new System.Drawing.Point(804, 8);
            this.btn_close.Name = "btn_close";
            this.btn_close.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.btn_close.ShadowDecoration.Parent = this.btn_close;
            this.btn_close.Size = new System.Drawing.Size(15, 15);
            this.btn_close.TabIndex = 30;
            this.btn_close.Text = "guna2CircleButton1";
            this.btn_close.Click += new System.EventHandler(this.btn_close_Click);
            // 
            // pnl_results
            // 
            this.pnl_results.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnl_results.AutoScroll = true;
            this.pnl_results.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(28)))), ((int)(((byte)(37)))));
            this.pnl_results.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pnl_results.Location = new System.Drawing.Point(20, 90);
            this.pnl_results.Name = "pnl_results";
            this.pnl_results.Size = new System.Drawing.Size(791, 388);
            this.pnl_results.TabIndex = 26;
            this.pnl_results.Paint += new System.Windows.Forms.PaintEventHandler(this.pnl_results_Paint);
            // 
            // Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(28)))), ((int)(((byte)(37)))));
            this.ClientSize = new System.Drawing.Size(851, 585);
            this.Controls.Add(this.btn_close);
            this.Controls.Add(this.lbl_version);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lbl_c);
            this.Controls.Add(this.lbl_libre);
            this.Controls.Add(this.main_pnl);
            this.Controls.Add(this.exit_btn);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Dashboard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Dashboard";
            this.Load += new System.EventHandler(this.Dashboard_Load);
            this.main_pnl.ResumeLayout(false);
            this.main_pnl.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Elipse Main;
        private Guna.UI2.WinForms.Guna2Panel main_pnl;
        private Guna.UI2.WinForms.Guna2Elipse left_panel;
        private Guna.UI2.WinForms.Guna2Elipse right_panel;
        private Guna.UI2.WinForms.Guna2Button btn_quick;
        private System.Windows.Forms.Label lbl_qck_srch;
        private Guna.UI2.WinForms.Guna2TextBox search_txtbx;
        private Guna.UI2.WinForms.Guna2Button btn_advanced;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
        private Guna.UI2.WinForms.Guna2GradientButton btn_accs;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse3;
        private Guna.UI2.WinForms.Guna2GradientButton btn_details;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse4;
        private Guna.UI2.WinForms.Guna2DragControl mainDrag;
        private Guna.UI2.WinForms.Guna2DragControl pnl_drag;
        private Guna.UI2.WinForms.Guna2CircleButton exit_btn;
        private System.Windows.Forms.ListView search_results;
        private System.Windows.Forms.ColumnHeader ID;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lbl_c;
        private System.Windows.Forms.Label lbl_libre;
        private System.Windows.Forms.Label lbl_version;
        private Guna.UI2.WinForms.Guna2ToggleSwitch theme_mode;
        private System.Windows.Forms.ToolTip theme_management;
        private Guna.UI2.WinForms.Guna2GradientButton btn_change_view;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse2;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse5;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse6;
        private Guna.UI2.WinForms.Guna2Button guna2Button1;
        private Guna.UI2.WinForms.Guna2CircleButton btn_close;
        private System.Windows.Forms.FlowLayoutPanel pnl_results;
    }
}