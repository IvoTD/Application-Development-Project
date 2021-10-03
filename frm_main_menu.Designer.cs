namespace Application_Development_Project
{
    partial class frm_main_menu
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.lIbraryMembersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addMembersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.removeMembersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.retrieveMembersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.booksToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addBookToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.removeBookToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.retrieveBookToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lendingToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lendBookToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.returnBookToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewLendedBooksToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btn_cancel = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.menuStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Visible;
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lIbraryMembersToolStripMenuItem,
            this.booksToolStripMenuItem,
            this.lendingToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 40);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // lIbraryMembersToolStripMenuItem
            // 
            this.lIbraryMembersToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addMembersToolStripMenuItem,
            this.removeMembersToolStripMenuItem,
            this.retrieveMembersToolStripMenuItem});
            this.lIbraryMembersToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lIbraryMembersToolStripMenuItem.Name = "lIbraryMembersToolStripMenuItem";
            this.lIbraryMembersToolStripMenuItem.Size = new System.Drawing.Size(231, 36);
            this.lIbraryMembersToolStripMenuItem.Text = "LIbrary Members";
            // 
            // addMembersToolStripMenuItem
            // 
            this.addMembersToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI Black", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addMembersToolStripMenuItem.Name = "addMembersToolStripMenuItem";
            this.addMembersToolStripMenuItem.Size = new System.Drawing.Size(281, 34);
            this.addMembersToolStripMenuItem.Text = "Add Members";
            this.addMembersToolStripMenuItem.Click += new System.EventHandler(this.addMembersToolStripMenuItem_Click);
            // 
            // removeMembersToolStripMenuItem
            // 
            this.removeMembersToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI Black", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.removeMembersToolStripMenuItem.Name = "removeMembersToolStripMenuItem";
            this.removeMembersToolStripMenuItem.Size = new System.Drawing.Size(281, 34);
            this.removeMembersToolStripMenuItem.Text = "Remove Members";
            this.removeMembersToolStripMenuItem.Click += new System.EventHandler(this.removeMembersToolStripMenuItem_Click);
            // 
            // retrieveMembersToolStripMenuItem
            // 
            this.retrieveMembersToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI Black", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.retrieveMembersToolStripMenuItem.Name = "retrieveMembersToolStripMenuItem";
            this.retrieveMembersToolStripMenuItem.Size = new System.Drawing.Size(281, 34);
            this.retrieveMembersToolStripMenuItem.Text = "Retrieve Members";
            this.retrieveMembersToolStripMenuItem.Click += new System.EventHandler(this.retrieveMembersToolStripMenuItem_Click);
            // 
            // booksToolStripMenuItem
            // 
            this.booksToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addBookToolStripMenuItem,
            this.removeBookToolStripMenuItem,
            this.retrieveBookToolStripMenuItem});
            this.booksToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.booksToolStripMenuItem.Name = "booksToolStripMenuItem";
            this.booksToolStripMenuItem.Size = new System.Drawing.Size(104, 36);
            this.booksToolStripMenuItem.Text = "Books";
            // 
            // addBookToolStripMenuItem
            // 
            this.addBookToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI Black", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addBookToolStripMenuItem.Name = "addBookToolStripMenuItem";
            this.addBookToolStripMenuItem.Size = new System.Drawing.Size(242, 34);
            this.addBookToolStripMenuItem.Text = "Add book";
            this.addBookToolStripMenuItem.Click += new System.EventHandler(this.addBookToolStripMenuItem_Click);
            // 
            // removeBookToolStripMenuItem
            // 
            this.removeBookToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI Black", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.removeBookToolStripMenuItem.Name = "removeBookToolStripMenuItem";
            this.removeBookToolStripMenuItem.Size = new System.Drawing.Size(242, 34);
            this.removeBookToolStripMenuItem.Text = "Remove book";
            this.removeBookToolStripMenuItem.Click += new System.EventHandler(this.removeBookToolStripMenuItem_Click);
            // 
            // retrieveBookToolStripMenuItem
            // 
            this.retrieveBookToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI Black", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.retrieveBookToolStripMenuItem.Name = "retrieveBookToolStripMenuItem";
            this.retrieveBookToolStripMenuItem.Size = new System.Drawing.Size(242, 34);
            this.retrieveBookToolStripMenuItem.Text = "Retrieve book";
            this.retrieveBookToolStripMenuItem.Click += new System.EventHandler(this.retrieveBookToolStripMenuItem_Click);
            // 
            // lendingToolStripMenuItem
            // 
            this.lendingToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lendBookToolStripMenuItem,
            this.returnBookToolStripMenuItem,
            this.viewLendedBooksToolStripMenuItem});
            this.lendingToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lendingToolStripMenuItem.Name = "lendingToolStripMenuItem";
            this.lendingToolStripMenuItem.Size = new System.Drawing.Size(131, 36);
            this.lendingToolStripMenuItem.Text = "Lending ";
            // 
            // lendBookToolStripMenuItem
            // 
            this.lendBookToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI Black", 9F, System.Drawing.FontStyle.Bold);
            this.lendBookToolStripMenuItem.Name = "lendBookToolStripMenuItem";
            this.lendBookToolStripMenuItem.Size = new System.Drawing.Size(286, 34);
            this.lendBookToolStripMenuItem.Text = "Lend book";
            this.lendBookToolStripMenuItem.Click += new System.EventHandler(this.lendBookToolStripMenuItem_Click);
            // 
            // returnBookToolStripMenuItem
            // 
            this.returnBookToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI Black", 9F, System.Drawing.FontStyle.Bold);
            this.returnBookToolStripMenuItem.Name = "returnBookToolStripMenuItem";
            this.returnBookToolStripMenuItem.Size = new System.Drawing.Size(286, 34);
            this.returnBookToolStripMenuItem.Text = "Return book";
            this.returnBookToolStripMenuItem.Click += new System.EventHandler(this.returnBookToolStripMenuItem_Click);
            // 
            // viewLendedBooksToolStripMenuItem
            // 
            this.viewLendedBooksToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI Black", 9F, System.Drawing.FontStyle.Bold);
            this.viewLendedBooksToolStripMenuItem.Name = "viewLendedBooksToolStripMenuItem";
            this.viewLendedBooksToolStripMenuItem.Size = new System.Drawing.Size(286, 34);
            this.viewLendedBooksToolStripMenuItem.Text = "View lended books";
            this.viewLendedBooksToolStripMenuItem.Click += new System.EventHandler(this.viewLendedBooksToolStripMenuItem_Click);
            // 
            // btn_cancel
            // 
            this.btn_cancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_cancel.Location = new System.Drawing.Point(12, 358);
            this.btn_cancel.Name = "btn_cancel";
            this.btn_cancel.Size = new System.Drawing.Size(250, 80);
            this.btn_cancel.TabIndex = 65;
            this.btn_cancel.Text = "Exit";
            this.btn_cancel.UseVisualStyleBackColor = true;
            this.btn_cancel.Click += new System.EventHandler(this.btn_cancel_Click);
            // 
            // frm_main_menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_cancel);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frm_main_menu";
            this.Text = "main_manu";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem lIbraryMembersToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addMembersToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem removeMembersToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem retrieveMembersToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem booksToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addBookToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem removeBookToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem retrieveBookToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem lendingToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem lendBookToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem returnBookToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewLendedBooksToolStripMenuItem;
        private System.Windows.Forms.Button btn_cancel;
    }
}