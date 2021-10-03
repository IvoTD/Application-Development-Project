namespace Application_Development_Project
{
    partial class frm_lend_books
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
            this.label1 = new System.Windows.Forms.Label();
            this.txt_bookname = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btn_lend = new System.Windows.Forms.Button();
            this.pb_bookpicture = new System.Windows.Forms.PictureBox();
            this.btn_cancel = new System.Windows.Forms.Button();
            this.cmb_booklocation = new System.Windows.Forms.ComboBox();
            this.txt_authorsname = new System.Windows.Forms.TextBox();
            this.cmb_booktype = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cmb_isbn = new System.Windows.Forms.ComboBox();
            this.lbl_id = new System.Windows.Forms.Label();
            this.cmb_id = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.pb_bookpicture)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 22F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(299, 4);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(244, 51);
            this.label1.TabIndex = 19;
            this.label1.Text = "Lend book";
            // 
            // txt_bookname
            // 
            this.txt_bookname.Enabled = false;
            this.txt_bookname.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_bookname.Location = new System.Drawing.Point(336, 170);
            this.txt_bookname.Name = "txt_bookname";
            this.txt_bookname.Size = new System.Drawing.Size(256, 53);
            this.txt_bookname.TabIndex = 52;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(26, 99);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(104, 40);
            this.label3.TabIndex = 51;
            this.label3.Text = "ISBN";
            // 
            // btn_lend
            // 
            this.btn_lend.Enabled = false;
            this.btn_lend.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_lend.Location = new System.Drawing.Point(619, 74);
            this.btn_lend.Name = "btn_lend";
            this.btn_lend.Size = new System.Drawing.Size(250, 80);
            this.btn_lend.TabIndex = 50;
            this.btn_lend.Text = "Lend";
            this.btn_lend.UseVisualStyleBackColor = true;
            this.btn_lend.Click += new System.EventHandler(this.btn_lend_Click);
            // 
            // pb_bookpicture
            // 
            this.pb_bookpicture.Location = new System.Drawing.Point(622, 177);
            this.pb_bookpicture.Name = "pb_bookpicture";
            this.pb_bookpicture.Size = new System.Drawing.Size(247, 273);
            this.pb_bookpicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pb_bookpicture.TabIndex = 48;
            this.pb_bookpicture.TabStop = false;
            // 
            // btn_cancel
            // 
            this.btn_cancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_cancel.Location = new System.Drawing.Point(33, 647);
            this.btn_cancel.Name = "btn_cancel";
            this.btn_cancel.Size = new System.Drawing.Size(250, 80);
            this.btn_cancel.TabIndex = 47;
            this.btn_cancel.Text = "Cancel";
            this.btn_cancel.UseVisualStyleBackColor = true;
            this.btn_cancel.Click += new System.EventHandler(this.btn_cancel_Click);
            // 
            // cmb_booklocation
            // 
            this.cmb_booklocation.Enabled = false;
            this.cmb_booklocation.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_booklocation.FormattingEnabled = true;
            this.cmb_booklocation.Items.AddRange(new object[] {
            "Room 1",
            "Room 2",
            "Room 3"});
            this.cmb_booklocation.Location = new System.Drawing.Point(336, 425);
            this.cmb_booklocation.Name = "cmb_booklocation";
            this.cmb_booklocation.Size = new System.Drawing.Size(190, 54);
            this.cmb_booklocation.TabIndex = 46;
            // 
            // txt_authorsname
            // 
            this.txt_authorsname.Enabled = false;
            this.txt_authorsname.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_authorsname.Location = new System.Drawing.Point(336, 338);
            this.txt_authorsname.Name = "txt_authorsname";
            this.txt_authorsname.Size = new System.Drawing.Size(256, 53);
            this.txt_authorsname.TabIndex = 45;
            // 
            // cmb_booktype
            // 
            this.cmb_booktype.Enabled = false;
            this.cmb_booktype.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_booktype.FormattingEnabled = true;
            this.cmb_booktype.Items.AddRange(new object[] {
            "Computing",
            "Business",
            "Healthcare"});
            this.cmb_booktype.Location = new System.Drawing.Point(336, 260);
            this.cmb_booktype.Name = "cmb_booktype";
            this.cmb_booktype.Size = new System.Drawing.Size(190, 54);
            this.cmb_booktype.TabIndex = 44;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(28, 425);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(246, 40);
            this.label7.TabIndex = 42;
            this.label7.Text = "Book location";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(28, 338);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(261, 40);
            this.label5.TabIndex = 41;
            this.label5.Text = "Author\'s name";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(28, 260);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(186, 40);
            this.label4.TabIndex = 40;
            this.label4.Text = "Book type";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(28, 177);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(208, 40);
            this.label2.TabIndex = 39;
            this.label2.Text = "Book name";
            // 
            // cmb_isbn
            // 
            this.cmb_isbn.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_isbn.FormattingEnabled = true;
            this.cmb_isbn.Location = new System.Drawing.Point(334, 85);
            this.cmb_isbn.Name = "cmb_isbn";
            this.cmb_isbn.Size = new System.Drawing.Size(190, 54);
            this.cmb_isbn.TabIndex = 53;
            this.cmb_isbn.SelectedIndexChanged += new System.EventHandler(this.cmb_isbn_SelectedIndexChanged);
            // 
            // lbl_id
            // 
            this.lbl_id.AutoSize = true;
            this.lbl_id.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_id.Location = new System.Drawing.Point(28, 535);
            this.lbl_id.Name = "lbl_id";
            this.lbl_id.Size = new System.Drawing.Size(48, 40);
            this.lbl_id.TabIndex = 54;
            this.lbl_id.Text = "Id";
            this.lbl_id.Visible = false;
            // 
            // cmb_id
            // 
            this.cmb_id.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_id.FormattingEnabled = true;
            this.cmb_id.Location = new System.Drawing.Point(336, 528);
            this.cmb_id.Name = "cmb_id";
            this.cmb_id.Size = new System.Drawing.Size(190, 54);
            this.cmb_id.TabIndex = 55;
            this.cmb_id.Visible = false;
            this.cmb_id.SelectedIndexChanged += new System.EventHandler(this.cmb_id_SelectedIndexChanged);
            // 
            // frm_lend_books
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(911, 748);
            this.Controls.Add(this.cmb_id);
            this.Controls.Add(this.lbl_id);
            this.Controls.Add(this.cmb_isbn);
            this.Controls.Add(this.txt_bookname);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btn_lend);
            this.Controls.Add(this.pb_bookpicture);
            this.Controls.Add(this.btn_cancel);
            this.Controls.Add(this.cmb_booklocation);
            this.Controls.Add(this.txt_authorsname);
            this.Controls.Add(this.cmb_booktype);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "frm_lend_books";
            this.Text = "frm_lend_books";
            this.Load += new System.EventHandler(this.frm_lend_books_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pb_bookpicture)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_bookname;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btn_lend;
        private System.Windows.Forms.PictureBox pb_bookpicture;
        private System.Windows.Forms.Button btn_cancel;
        private System.Windows.Forms.ComboBox cmb_booklocation;
        private System.Windows.Forms.TextBox txt_authorsname;
        private System.Windows.Forms.ComboBox cmb_booktype;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmb_isbn;
        private System.Windows.Forms.Label lbl_id;
        private System.Windows.Forms.ComboBox cmb_id;
    }
}