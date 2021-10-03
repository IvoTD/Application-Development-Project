namespace Application_Development_Project
{
    partial class frm_view_lended_books
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
            this.dgv_view_lends = new System.Windows.Forms.DataGridView();
            this.btn_cancel = new System.Windows.Forms.Button();
            this.col_isbn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_booktype = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_bookname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_author = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_dateborrowed = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_membername = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_view_lends)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 22F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(248, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(415, 51);
            this.label1.TabIndex = 20;
            this.label1.Text = "View lended books";
            // 
            // dgv_view_lends
            // 
            this.dgv_view_lends.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_view_lends.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.col_isbn,
            this.col_booktype,
            this.col_bookname,
            this.col_author,
            this.col_dateborrowed,
            this.col_id,
            this.col_membername});
            this.dgv_view_lends.Location = new System.Drawing.Point(46, 85);
            this.dgv_view_lends.Name = "dgv_view_lends";
            this.dgv_view_lends.RowHeadersWidth = 62;
            this.dgv_view_lends.RowTemplate.Height = 28;
            this.dgv_view_lends.Size = new System.Drawing.Size(1153, 523);
            this.dgv_view_lends.TabIndex = 21;
            // 
            // btn_cancel
            // 
            this.btn_cancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_cancel.Location = new System.Drawing.Point(46, 644);
            this.btn_cancel.Name = "btn_cancel";
            this.btn_cancel.Size = new System.Drawing.Size(250, 80);
            this.btn_cancel.TabIndex = 48;
            this.btn_cancel.Text = "Cancel";
            this.btn_cancel.UseVisualStyleBackColor = true;
            this.btn_cancel.Click += new System.EventHandler(this.btn_cancel_Click);
            // 
            // col_isbn
            // 
            this.col_isbn.HeaderText = "ISBN";
            this.col_isbn.MinimumWidth = 8;
            this.col_isbn.Name = "col_isbn";
            this.col_isbn.Width = 150;
            // 
            // col_booktype
            // 
            this.col_booktype.HeaderText = "Book type";
            this.col_booktype.MinimumWidth = 8;
            this.col_booktype.Name = "col_booktype";
            this.col_booktype.Width = 150;
            // 
            // col_bookname
            // 
            this.col_bookname.HeaderText = "Book Name";
            this.col_bookname.MinimumWidth = 8;
            this.col_bookname.Name = "col_bookname";
            this.col_bookname.Width = 150;
            // 
            // col_author
            // 
            this.col_author.HeaderText = "Author";
            this.col_author.MinimumWidth = 8;
            this.col_author.Name = "col_author";
            this.col_author.Width = 150;
            // 
            // col_dateborrowed
            // 
            this.col_dateborrowed.HeaderText = "Date Borrowed";
            this.col_dateborrowed.MinimumWidth = 8;
            this.col_dateborrowed.Name = "col_dateborrowed";
            this.col_dateborrowed.Width = 150;
            // 
            // col_id
            // 
            this.col_id.HeaderText = "Member ID";
            this.col_id.MinimumWidth = 8;
            this.col_id.Name = "col_id";
            this.col_id.Width = 150;
            // 
            // col_membername
            // 
            this.col_membername.HeaderText = "Member Name";
            this.col_membername.MinimumWidth = 8;
            this.col_membername.Name = "col_membername";
            this.col_membername.Width = 150;
            // 
            // frm_view_lended_books
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1211, 753);
            this.Controls.Add(this.btn_cancel);
            this.Controls.Add(this.dgv_view_lends);
            this.Controls.Add(this.label1);
            this.Name = "frm_view_lended_books";
            this.Text = "frm_view_lended_books";
            ((System.ComponentModel.ISupportInitialize)(this.dgv_view_lends)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgv_view_lends;
        private System.Windows.Forms.Button btn_cancel;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_isbn;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_booktype;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_bookname;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_author;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_dateborrowed;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_membername;
    }
}