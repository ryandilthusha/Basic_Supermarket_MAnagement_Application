
namespace YT_Sophisticated_Design_1
{
    partial class Categories_Form
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_delete = new System.Windows.Forms.Button();
            this.btn_edit = new System.Windows.Forms.Button();
            this.btn_add = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_description = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.txt_name = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_selling = new System.Windows.Forms.Button();
            this.btn_products = new System.Windows.Forms.Button();
            this.btn_sellers = new System.Windows.Forms.Button();
            this.lbl_X = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.pic_box_logout = new System.Windows.Forms.PictureBox();
            this.dgv_categories = new Guna.UI2.WinForms.Guna2DataGridView();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic_box_logout)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_categories)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DarkOrange;
            this.panel1.Controls.Add(this.dgv_categories);
            this.panel1.Controls.Add(this.btn_delete);
            this.panel1.Controls.Add(this.btn_edit);
            this.panel1.Controls.Add(this.btn_add);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.txt_description);
            this.panel1.Controls.Add(this.txt_name);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(158, 75);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(709, 475);
            this.panel1.TabIndex = 1;
            // 
            // btn_delete
            // 
            this.btn_delete.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_delete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_delete.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_delete.ForeColor = System.Drawing.Color.Black;
            this.btn_delete.Location = new System.Drawing.Point(181, 336);
            this.btn_delete.Name = "btn_delete";
            this.btn_delete.Size = new System.Drawing.Size(83, 33);
            this.btn_delete.TabIndex = 1;
            this.btn_delete.Text = "DELETE";
            this.btn_delete.UseVisualStyleBackColor = false;
            this.btn_delete.Click += new System.EventHandler(this.btn_delete_Click);
            // 
            // btn_edit
            // 
            this.btn_edit.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_edit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_edit.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_edit.ForeColor = System.Drawing.Color.Black;
            this.btn_edit.Location = new System.Drawing.Point(92, 336);
            this.btn_edit.Name = "btn_edit";
            this.btn_edit.Size = new System.Drawing.Size(83, 33);
            this.btn_edit.TabIndex = 1;
            this.btn_edit.Text = "EDIT";
            this.btn_edit.UseVisualStyleBackColor = false;
            this.btn_edit.Click += new System.EventHandler(this.btn_edit_Click);
            // 
            // btn_add
            // 
            this.btn_add.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_add.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_add.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_add.ForeColor = System.Drawing.Color.Black;
            this.btn_add.Location = new System.Drawing.Point(3, 336);
            this.btn_add.Name = "btn_add";
            this.btn_add.Size = new System.Drawing.Size(83, 33);
            this.btn_add.TabIndex = 1;
            this.btn_add.Text = "ADD";
            this.btn_add.UseVisualStyleBackColor = false;
            this.btn_add.Click += new System.EventHandler(this.btn_add_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(22, 161);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 16);
            this.label3.TabIndex = 6;
            this.label3.Text = "Name";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(22, 209);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(87, 16);
            this.label5.TabIndex = 6;
            this.label5.Text = "Description";
            // 
            // txt_description
            // 
            this.txt_description.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_description.Font = new System.Drawing.Font("Cooper Black", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_description.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txt_description.HintForeColor = System.Drawing.Color.Empty;
            this.txt_description.HintText = "";
            this.txt_description.isPassword = false;
            this.txt_description.LineFocusedColor = System.Drawing.Color.Silver;
            this.txt_description.LineIdleColor = System.Drawing.Color.OldLace;
            this.txt_description.LineMouseHoverColor = System.Drawing.Color.Silver;
            this.txt_description.LineThickness = 1;
            this.txt_description.Location = new System.Drawing.Point(109, 190);
            this.txt_description.Margin = new System.Windows.Forms.Padding(4);
            this.txt_description.Name = "txt_description";
            this.txt_description.Size = new System.Drawing.Size(155, 35);
            this.txt_description.TabIndex = 5;
            this.txt_description.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // txt_name
            // 
            this.txt_name.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_name.Font = new System.Drawing.Font("Cooper Black", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_name.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txt_name.HintForeColor = System.Drawing.Color.Empty;
            this.txt_name.HintText = "";
            this.txt_name.isPassword = false;
            this.txt_name.LineFocusedColor = System.Drawing.Color.Silver;
            this.txt_name.LineIdleColor = System.Drawing.Color.OldLace;
            this.txt_name.LineMouseHoverColor = System.Drawing.Color.Silver;
            this.txt_name.LineThickness = 1;
            this.txt_name.Location = new System.Drawing.Point(109, 142);
            this.txt_name.Margin = new System.Windows.Forms.Padding(4);
            this.txt_name.Name = "txt_name";
            this.txt_name.Size = new System.Drawing.Size(155, 35);
            this.txt_name.TabIndex = 5;
            this.txt_name.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(265, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(267, 31);
            this.label2.TabIndex = 4;
            this.label2.Text = "Manage Categories";
            // 
            // btn_selling
            // 
            this.btn_selling.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_selling.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_selling.ForeColor = System.Drawing.Color.Red;
            this.btn_selling.Location = new System.Drawing.Point(12, 206);
            this.btn_selling.Name = "btn_selling";
            this.btn_selling.Size = new System.Drawing.Size(102, 33);
            this.btn_selling.TabIndex = 5;
            this.btn_selling.Text = "Sell";
            this.btn_selling.UseVisualStyleBackColor = false;
            this.btn_selling.Click += new System.EventHandler(this.btn_selling_Click);
            // 
            // btn_products
            // 
            this.btn_products.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_products.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_products.ForeColor = System.Drawing.Color.Red;
            this.btn_products.Location = new System.Drawing.Point(12, 139);
            this.btn_products.Name = "btn_products";
            this.btn_products.Size = new System.Drawing.Size(102, 33);
            this.btn_products.TabIndex = 4;
            this.btn_products.Text = "Products";
            this.btn_products.UseVisualStyleBackColor = false;
            this.btn_products.Click += new System.EventHandler(this.btn_products_Click);
            // 
            // btn_sellers
            // 
            this.btn_sellers.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_sellers.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_sellers.ForeColor = System.Drawing.Color.Red;
            this.btn_sellers.Location = new System.Drawing.Point(12, 75);
            this.btn_sellers.Name = "btn_sellers";
            this.btn_sellers.Size = new System.Drawing.Size(102, 33);
            this.btn_sellers.TabIndex = 3;
            this.btn_sellers.Text = "Sellers";
            this.btn_sellers.UseVisualStyleBackColor = false;
            this.btn_sellers.Click += new System.EventHandler(this.btn_sellers_Click);
            // 
            // lbl_X
            // 
            this.lbl_X.AutoSize = true;
            this.lbl_X.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_X.ForeColor = System.Drawing.Color.Red;
            this.lbl_X.Location = new System.Drawing.Point(842, 9);
            this.lbl_X.Name = "lbl_X";
            this.lbl_X.Size = new System.Drawing.Size(25, 24);
            this.lbl_X.TabIndex = 9;
            this.lbl_X.Text = "X";
            this.lbl_X.Click += new System.EventHandler(this.lbl_X_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.Red;
            this.label10.Location = new System.Drawing.Point(59, 534);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(55, 16);
            this.label10.TabIndex = 52;
            this.label10.Text = "Logout";
            // 
            // pic_box_logout
            // 
            this.pic_box_logout.Image = global::YT_Sophisticated_Design_1.Properties.Resources.Logout1;
            this.pic_box_logout.Location = new System.Drawing.Point(24, 526);
            this.pic_box_logout.Name = "pic_box_logout";
            this.pic_box_logout.Size = new System.Drawing.Size(29, 24);
            this.pic_box_logout.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pic_box_logout.TabIndex = 54;
            this.pic_box_logout.TabStop = false;
            this.pic_box_logout.Click += new System.EventHandler(this.pic_box_logout_Click);
            // 
            // dgv_categories
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(216)))), ((int)(((byte)(189)))));
            this.dgv_categories.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgv_categories.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_categories.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgv_categories.BackgroundColor = System.Drawing.Color.White;
            this.dgv_categories.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgv_categories.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgv_categories.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(126)))), ((int)(((byte)(34)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_categories.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgv_categories.ColumnHeadersHeight = 30;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(229)))), ((int)(((byte)(211)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(169)))), ((int)(((byte)(107)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv_categories.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgv_categories.EnableHeadersVisualStyles = false;
            this.dgv_categories.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(209)))), ((int)(((byte)(177)))));
            this.dgv_categories.Location = new System.Drawing.Point(271, 118);
            this.dgv_categories.Name = "dgv_categories";
            this.dgv_categories.ReadOnly = true;
            this.dgv_categories.RowHeadersVisible = false;
            this.dgv_categories.RowTemplate.Height = 28;
            this.dgv_categories.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_categories.Size = new System.Drawing.Size(423, 341);
            this.dgv_categories.TabIndex = 8;
            this.dgv_categories.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.Carrot;
            this.dgv_categories.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(216)))), ((int)(((byte)(189)))));
            this.dgv_categories.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dgv_categories.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dgv_categories.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dgv_categories.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dgv_categories.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.dgv_categories.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(209)))), ((int)(((byte)(177)))));
            this.dgv_categories.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(126)))), ((int)(((byte)(34)))));
            this.dgv_categories.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgv_categories.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgv_categories.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dgv_categories.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dgv_categories.ThemeStyle.HeaderStyle.Height = 30;
            this.dgv_categories.ThemeStyle.ReadOnly = true;
            this.dgv_categories.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(229)))), ((int)(((byte)(211)))));
            this.dgv_categories.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgv_categories.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.dgv_categories.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.Black;
            this.dgv_categories.ThemeStyle.RowsStyle.Height = 28;
            this.dgv_categories.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(169)))), ((int)(((byte)(107)))));
            this.dgv_categories.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.dgv_categories.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_categories_CellDoubleClick);
            // 
            // Categories_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gainsboro;
            this.ClientSize = new System.Drawing.Size(879, 562);
            this.Controls.Add(this.pic_box_logout);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.lbl_X);
            this.Controls.Add(this.btn_selling);
            this.Controls.Add(this.btn_products);
            this.Controls.Add(this.btn_sellers);
            this.Controls.Add(this.panel1);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Categories_Form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Categories_Form";
            this.Load += new System.EventHandler(this.Categories_Form_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic_box_logout)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_categories)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btn_delete;
        private System.Windows.Forms.Button btn_edit;
        private System.Windows.Forms.Button btn_add;
        private System.Windows.Forms.Label label3;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txt_description;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txt_name;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btn_selling;
        private System.Windows.Forms.Button btn_products;
        private System.Windows.Forms.Button btn_sellers;
        private System.Windows.Forms.Label lbl_X;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.PictureBox pic_box_logout;
        private Guna.UI2.WinForms.Guna2DataGridView dgv_categories;
    }
}