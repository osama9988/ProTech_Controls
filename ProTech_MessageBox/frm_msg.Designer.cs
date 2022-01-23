
namespace ProTech_MessageBox
{
    partial class frm_msg
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.pnl_title = new System.Windows.Forms.Panel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.btn_ar = new FontAwesome.Sharp.IconButton();
            this.btn_en = new FontAwesome.Sharp.IconButton();
            this.lbl_caption = new System.Windows.Forms.Label();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.pnl_buttons = new System.Windows.Forms.Panel();
            this.btn3 = new FontAwesome.Sharp.IconButton();
            this.btn2 = new FontAwesome.Sharp.IconButton();
            this.btn1 = new FontAwesome.Sharp.IconButton();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.pnl_title.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.pnl_buttons.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DodgerBlue;
            this.panel1.Controls.Add(this.pnl_title);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(796, 41);
            this.panel1.TabIndex = 0;
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseDown);
            // 
            // pnl_title
            // 
            this.pnl_title.Controls.Add(this.tableLayoutPanel1);
            this.pnl_title.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnl_title.Location = new System.Drawing.Point(0, 0);
            this.pnl_title.Margin = new System.Windows.Forms.Padding(4);
            this.pnl_title.Name = "pnl_title";
            this.pnl_title.Size = new System.Drawing.Size(796, 41);
            this.pnl_title.TabIndex = 0;
            this.pnl_title.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pnl_title_MouseDown);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 5;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 3.125F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 83.0402F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 5.150754F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 3.625F));
            this.tableLayoutPanel1.Controls.Add(this.btn_ar, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.btn_en, 3, 0);
            this.tableLayoutPanel1.Controls.Add(this.lbl_caption, 2, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(4);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(796, 41);
            this.tableLayoutPanel1.TabIndex = 0;
            this.tableLayoutPanel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.tableLayoutPanel1_MouseDown);
            // 
            // btn_ar
            // 
            this.btn_ar.BackColor = System.Drawing.Color.Transparent;
            this.btn_ar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btn_ar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_ar.IconChar = FontAwesome.Sharp.IconChar.WindowClose;
            this.btn_ar.IconColor = System.Drawing.Color.Tomato;
            this.btn_ar.IconFont = FontAwesome.Sharp.IconFont.Solid;
            this.btn_ar.IconSize = 38;
            this.btn_ar.Location = new System.Drawing.Point(28, 4);
            this.btn_ar.Margin = new System.Windows.Forms.Padding(4);
            this.btn_ar.Name = "btn_ar";
            this.btn_ar.Size = new System.Drawing.Size(31, 33);
            this.btn_ar.TabIndex = 2;
            this.btn_ar.Text = " ";
            this.btn_ar.UseVisualStyleBackColor = false;
            this.btn_ar.Click += new System.EventHandler(this.btn_ar_Click);
            // 
            // btn_en
            // 
            this.btn_en.BackColor = System.Drawing.Color.Transparent;
            this.btn_en.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btn_en.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_en.IconChar = FontAwesome.Sharp.IconChar.WindowClose;
            this.btn_en.IconColor = System.Drawing.Color.Tomato;
            this.btn_en.IconFont = FontAwesome.Sharp.IconFont.Solid;
            this.btn_en.IconSize = 38;
            this.btn_en.Location = new System.Drawing.Point(728, 4);
            this.btn_en.Margin = new System.Windows.Forms.Padding(4);
            this.btn_en.Name = "btn_en";
            this.btn_en.Size = new System.Drawing.Size(33, 33);
            this.btn_en.TabIndex = 1;
            this.btn_en.Text = " ";
            this.btn_en.UseVisualStyleBackColor = false;
            this.btn_en.Click += new System.EventHandler(this.btn_en_Click);
            // 
            // lbl_caption
            // 
            this.lbl_caption.AutoSize = true;
            this.lbl_caption.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbl_caption.Font = new System.Drawing.Font("Tahoma", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.lbl_caption.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lbl_caption.Location = new System.Drawing.Point(67, 0);
            this.lbl_caption.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_caption.Name = "lbl_caption";
            this.lbl_caption.Size = new System.Drawing.Size(653, 41);
            this.lbl_caption.TabIndex = 3;
            this.lbl_caption.Text = " ";
            this.lbl_caption.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lbl_caption.MouseDown += new System.Windows.Forms.MouseEventHandler(this.label1_MouseDown);
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 3;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 90F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.tableLayoutPanel2.Controls.Add(this.pnl_buttons, 1, 2);
            this.tableLayoutPanel2.Controls.Add(this.textBox1, 1, 1);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(0, 41);
            this.tableLayoutPanel2.Margin = new System.Windows.Forms.Padding(4);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 4;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 70F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(796, 252);
            this.tableLayoutPanel2.TabIndex = 1;
            // 
            // pnl_buttons
            // 
            this.pnl_buttons.Controls.Add(this.btn3);
            this.pnl_buttons.Controls.Add(this.btn2);
            this.pnl_buttons.Controls.Add(this.btn1);
            this.pnl_buttons.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnl_buttons.Location = new System.Drawing.Point(43, 192);
            this.pnl_buttons.Margin = new System.Windows.Forms.Padding(4);
            this.pnl_buttons.Name = "pnl_buttons";
            this.pnl_buttons.Size = new System.Drawing.Size(708, 42);
            this.pnl_buttons.TabIndex = 0;
            // 
            // btn3
            // 
            this.btn3.FlatAppearance.BorderSize = 3;
            this.btn3.Font = new System.Drawing.Font("Tahoma", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn3.IconChar = FontAwesome.Sharp.IconChar.Ban;
            this.btn3.IconColor = System.Drawing.Color.DarkRed;
            this.btn3.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btn3.IconSize = 35;
            this.btn3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn3.Location = new System.Drawing.Point(474, 0);
            this.btn3.Margin = new System.Windows.Forms.Padding(4);
            this.btn3.Name = "btn3";
            this.btn3.Size = new System.Drawing.Size(230, 40);
            this.btn3.TabIndex = 2;
            this.btn3.Text = "iconButton5";
            this.btn3.UseVisualStyleBackColor = true;
            this.btn3.Visible = false;
            // 
            // btn2
            // 
            this.btn2.FlatAppearance.BorderSize = 3;
            this.btn2.Font = new System.Drawing.Font("Tahoma", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn2.ForeColor = System.Drawing.Color.DarkRed;
            this.btn2.IconChar = FontAwesome.Sharp.IconChar.Ban;
            this.btn2.IconColor = System.Drawing.Color.DarkRed;
            this.btn2.IconFont = FontAwesome.Sharp.IconFont.Solid;
            this.btn2.IconSize = 35;
            this.btn2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn2.Location = new System.Drawing.Point(239, 0);
            this.btn2.Margin = new System.Windows.Forms.Padding(4);
            this.btn2.Name = "btn2";
            this.btn2.Size = new System.Drawing.Size(230, 40);
            this.btn2.TabIndex = 1;
            this.btn2.Text = "iconButton4";
            this.btn2.UseVisualStyleBackColor = true;
            this.btn2.Visible = false;
            // 
            // btn1
            // 
            this.btn1.FlatAppearance.BorderSize = 3;
            this.btn1.Font = new System.Drawing.Font("Tahoma", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn1.IconChar = FontAwesome.Sharp.IconChar.CheckCircle;
            this.btn1.IconColor = System.Drawing.Color.DarkRed;
            this.btn1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btn1.IconSize = 35;
            this.btn1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn1.Location = new System.Drawing.Point(4, 0);
            this.btn1.Margin = new System.Windows.Forms.Padding(4);
            this.btn1.Name = "btn1";
            this.btn1.Size = new System.Drawing.Size(230, 40);
            this.btn1.TabIndex = 0;
            this.btn1.Text = "iconButton3";
            this.btn1.UseVisualStyleBackColor = true;
            this.btn1.Visible = false;
            this.btn1.Click += new System.EventHandler(this.btn1_Click);
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBox1.Font = new System.Drawing.Font("Tahoma", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.ForeColor = System.Drawing.Color.Black;
            this.textBox1.Location = new System.Drawing.Point(42, 15);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(710, 170);
            this.textBox1.TabIndex = 1;
            this.textBox1.TabStop = false;
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // frm_msg
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(796, 293);
            this.ControlBox = false;
            this.Controls.Add(this.tableLayoutPanel2);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frm_msg";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.pnl_title.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.pnl_buttons.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel pnl_title;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private FontAwesome.Sharp.IconButton btn_en;
        private FontAwesome.Sharp.IconButton btn_ar;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private FontAwesome.Sharp.IconButton btn3;
        private FontAwesome.Sharp.IconButton btn2;
        private FontAwesome.Sharp.IconButton btn1;
        public System.Windows.Forms.Panel pnl_buttons;
        public System.Windows.Forms.Label lbl_caption;
        private System.Windows.Forms.TextBox textBox1;
    }
}

