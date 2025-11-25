namespace LibraryFormApp
{
    partial class Form2
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            loginToolStripMenuItem = new ToolStripMenuItem();
            viewBookToolStripMenuItem = new ToolStripMenuItem();
            updateBookToolStripMenuItem = new ToolStripMenuItem();
            exitToolStripMenuItem = new ToolStripMenuItem();
            menuStrip1 = new MenuStrip();
            deleteBookToolStripMenuItem = new ToolStripMenuItem();
            homePageToolStripMenuItem = new ToolStripMenuItem();
            label1 = new Label();
            label2 = new Label();
            searchBookToolStripMenuItem = new ToolStripMenuItem();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // loginToolStripMenuItem
            // 
            loginToolStripMenuItem.Name = "loginToolStripMenuItem";
            loginToolStripMenuItem.Size = new Size(89, 24);
            loginToolStripMenuItem.Text = "Add Book";
            loginToolStripMenuItem.Click += loginToolStripMenuItem_Click;
            // 
            // viewBookToolStripMenuItem
            // 
            viewBookToolStripMenuItem.Name = "viewBookToolStripMenuItem";
            viewBookToolStripMenuItem.Size = new Size(93, 24);
            viewBookToolStripMenuItem.Text = "View Book";
            viewBookToolStripMenuItem.Click += viewBookToolStripMenuItem_Click;
            // 
            // updateBookToolStripMenuItem
            // 
            updateBookToolStripMenuItem.Name = "updateBookToolStripMenuItem";
            updateBookToolStripMenuItem.Size = new Size(110, 24);
            updateBookToolStripMenuItem.Text = "Update Book";
            updateBookToolStripMenuItem.Click += updateBookToolStripMenuItem_Click;
            // 
            // exitToolStripMenuItem
            // 
            exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            exitToolStripMenuItem.Size = new Size(47, 24);
            exitToolStripMenuItem.Text = "Exit";
            exitToolStripMenuItem.Click += exitToolStripMenuItem_Click;
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { loginToolStripMenuItem, viewBookToolStripMenuItem, updateBookToolStripMenuItem, exitToolStripMenuItem, deleteBookToolStripMenuItem, homePageToolStripMenuItem, searchBookToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(1007, 28);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // deleteBookToolStripMenuItem
            // 
            deleteBookToolStripMenuItem.Name = "deleteBookToolStripMenuItem";
            deleteBookToolStripMenuItem.Size = new Size(105, 24);
            deleteBookToolStripMenuItem.Text = "Delete Book";
            deleteBookToolStripMenuItem.Click += deleteBookToolStripMenuItem_Click;
            // 
            // homePageToolStripMenuItem
            // 
            homePageToolStripMenuItem.Name = "homePageToolStripMenuItem";
            homePageToolStripMenuItem.Size = new Size(96, 24);
            homePageToolStripMenuItem.Text = "HomePage";
            homePageToolStripMenuItem.Click += homePageToolStripMenuItem_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = SystemColors.ButtonFace;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(46, 278);
            label1.Name = "label1";
            label1.Size = new Size(888, 41);
            label1.TabIndex = 1;
            label1.Text = "Navigate to your desired page from the menu-strip at the top";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = SystemColors.ActiveCaption;
            label2.Font = new Font("Segoe UI", 22.2F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label2.Location = new Point(353, 161);
            label2.Name = "label2";
            label2.Size = new Size(204, 50);
            label2.TabIndex = 2;
            label2.Text = "Welcome! ";
            // 
            // searchBookToolStripMenuItem
            // 
            searchBookToolStripMenuItem.Name = "searchBookToolStripMenuItem";
            searchBookToolStripMenuItem.Size = new Size(105, 24);
            searchBookToolStripMenuItem.Text = "Search Book";
            searchBookToolStripMenuItem.Click += searchBookToolStripMenuItem_Click;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaptionText;
            ClientSize = new Size(1007, 783);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "Form2";
            Text = "LoginSuccessful";
            Load += Form1_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private ToolStripMenuItem loginToolStripMenuItem;
        private ToolStripMenuItem viewBookToolStripMenuItem;
        private ToolStripMenuItem updateBookToolStripMenuItem;
      
        private ToolStripMenuItem exitToolStripMenuItem;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem deleteBookToolStripMenuItem;
        private ToolStripMenuItem homePageToolStripMenuItem;
        private Label label1;
        private Label label2;
        private ToolStripMenuItem searchBookToolStripMenuItem;
    }
}
