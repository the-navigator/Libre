namespace Libre
{
    partial class cmn_line
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
            this.form_elipse_cmn = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.cmn_history = new System.Windows.Forms.ListBox();
            this.lv_results = new System.Windows.Forms.ListView();
            this.pk_id = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.id = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.rname = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.rloc = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.rauthor = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.glvel = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.tags = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.code_accs = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.panel1 = new System.Windows.Forms.Panel();
            this.exit_btn = new Guna.UI2.WinForms.Guna2CircleButton();
            this.txt_cmn_ = new Guna.UI2.WinForms.Guna2TextBox();
            this.btn_query = new Guna.UI2.WinForms.Guna2Button();
            this.guna2DragControl1 = new Guna.UI2.WinForms.Guna2DragControl(this.components);
            this.guna2DragControl2 = new Guna.UI2.WinForms.Guna2DragControl(this.components);
            this.tableLayoutPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // form_elipse_cmn
            // 
            this.form_elipse_cmn.BorderRadius = 15;
            this.form_elipse_cmn.TargetControl = this;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 321F));
            this.tableLayoutPanel1.Controls.Add(this.cmn_history, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.lv_results, 0, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(12, 102);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1109, 427);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // cmn_history
            // 
            this.cmn_history.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(41)))), ((int)(((byte)(54)))));
            this.cmn_history.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.cmn_history.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cmn_history.Font = new System.Drawing.Font("Consolas", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmn_history.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(115)))), ((int)(((byte)(194)))), ((int)(((byte)(196)))));
            this.cmn_history.FormattingEnabled = true;
            this.cmn_history.ItemHeight = 15;
            this.cmn_history.Location = new System.Drawing.Point(791, 3);
            this.cmn_history.Name = "cmn_history";
            this.cmn_history.Size = new System.Drawing.Size(315, 421);
            this.cmn_history.TabIndex = 0;
            // 
            // lv_results
            // 
            this.lv_results.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(41)))), ((int)(((byte)(54)))));
            this.lv_results.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lv_results.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.pk_id,
            this.id,
            this.rname,
            this.rloc,
            this.rauthor,
            this.glvel,
            this.tags,
            this.code_accs});
            this.lv_results.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lv_results.Font = new System.Drawing.Font("Consolas", 10F);
            this.lv_results.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(115)))), ((int)(((byte)(194)))), ((int)(((byte)(196)))));
            this.lv_results.Location = new System.Drawing.Point(3, 3);
            this.lv_results.MultiSelect = false;
            this.lv_results.Name = "lv_results";
            this.lv_results.Size = new System.Drawing.Size(782, 421);
            this.lv_results.TabIndex = 1;
            this.lv_results.UseCompatibleStateImageBehavior = false;
            this.lv_results.View = System.Windows.Forms.View.Details;
            // 
            // pk_id
            // 
            this.pk_id.Text = "PK_ID";
            // 
            // id
            // 
            this.id.Text = "ID";
            // 
            // rname
            // 
            this.rname.Text = "RNAME";
            // 
            // rloc
            // 
            this.rloc.Text = "RLOC";
            // 
            // rauthor
            // 
            this.rauthor.Text = "RAUTHOR";
            // 
            // glvel
            // 
            this.glvel.Text = "GLEVEL";
            // 
            // tags
            // 
            this.tags.Text = "TAGS";
            // 
            // code_accs
            // 
            this.code_accs.Text = "CODE_ACCSS";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.exit_btn);
            this.panel1.Controls.Add(this.txt_cmn_);
            this.panel1.Controls.Add(this.btn_query);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1121, 96);
            this.panel1.TabIndex = 2;
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
            this.exit_btn.Location = new System.Drawing.Point(1094, 12);
            this.exit_btn.Name = "exit_btn";
            this.exit_btn.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.exit_btn.ShadowDecoration.Parent = this.exit_btn;
            this.exit_btn.Size = new System.Drawing.Size(15, 15);
            this.exit_btn.TabIndex = 2;
            this.exit_btn.Text = "guna2CircleButton1";
            this.exit_btn.Click += new System.EventHandler(this.exit_btn_Click);
            // 
            // txt_cmn_
            // 
            this.txt_cmn_.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange;
            this.txt_cmn_.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(41)))), ((int)(((byte)(54)))));
            this.txt_cmn_.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_cmn_.BorderRadius = 7;
            this.txt_cmn_.BorderThickness = 2;
            this.txt_cmn_.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_cmn_.DefaultText = "lolz";
            this.txt_cmn_.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txt_cmn_.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txt_cmn_.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_cmn_.DisabledState.Parent = this.txt_cmn_;
            this.txt_cmn_.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_cmn_.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(41)))), ((int)(((byte)(54)))));
            this.txt_cmn_.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_cmn_.FocusedState.Parent = this.txt_cmn_;
            this.txt_cmn_.Font = new System.Drawing.Font("Consolas", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_cmn_.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_cmn_.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_cmn_.HoverState.Parent = this.txt_cmn_;
            this.txt_cmn_.Location = new System.Drawing.Point(18, 27);
            this.txt_cmn_.Margin = new System.Windows.Forms.Padding(4);
            this.txt_cmn_.Name = "txt_cmn_";
            this.txt_cmn_.PasswordChar = '\0';
            this.txt_cmn_.PlaceholderText = "";
            this.txt_cmn_.SelectedText = "";
            this.txt_cmn_.SelectionStart = 4;
            this.txt_cmn_.ShadowDecoration.Parent = this.txt_cmn_;
            this.txt_cmn_.Size = new System.Drawing.Size(1058, 31);
            this.txt_cmn_.TabIndex = 0;
            // 
            // btn_query
            // 
            this.btn_query.CheckedState.Parent = this.btn_query;
            this.btn_query.CustomImages.Parent = this.btn_query;
            this.btn_query.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btn_query.ForeColor = System.Drawing.Color.White;
            this.btn_query.HoverState.Parent = this.btn_query;
            this.btn_query.Location = new System.Drawing.Point(896, 51);
            this.btn_query.Name = "btn_query";
            this.btn_query.ShadowDecoration.Parent = this.btn_query;
            this.btn_query.Size = new System.Drawing.Size(180, 42);
            this.btn_query.TabIndex = 1;
            this.btn_query.Text = "PerformQuery";
            this.btn_query.Click += new System.EventHandler(this.btn_query_Click);
            // 
            // guna2DragControl1
            // 
            this.guna2DragControl1.TargetControl = this.panel1;
            // 
            // guna2DragControl2
            // 
            this.guna2DragControl2.TargetControl = this.tableLayoutPanel1;
            // 
            // cmn_line
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(41)))), ((int)(((byte)(54)))));
            this.ClientSize = new System.Drawing.Size(1121, 541);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.tableLayoutPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "cmn_line";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "cmn_line";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Elipse form_elipse_cmn;
        private System.Windows.Forms.Panel panel1;
        private Guna.UI2.WinForms.Guna2TextBox txt_cmn_;
        private Guna.UI2.WinForms.Guna2Button btn_query;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.ListBox cmn_history;
        private System.Windows.Forms.ListView lv_results;
        private System.Windows.Forms.ColumnHeader pk_id;
        private System.Windows.Forms.ColumnHeader id;
        private System.Windows.Forms.ColumnHeader rname;
        private System.Windows.Forms.ColumnHeader rloc;
        private System.Windows.Forms.ColumnHeader rauthor;
        private System.Windows.Forms.ColumnHeader glvel;
        private System.Windows.Forms.ColumnHeader tags;
        private System.Windows.Forms.ColumnHeader code_accs;
        private Guna.UI2.WinForms.Guna2CircleButton exit_btn;
        private Guna.UI2.WinForms.Guna2DragControl guna2DragControl1;
        private Guna.UI2.WinForms.Guna2DragControl guna2DragControl2;
    }
}