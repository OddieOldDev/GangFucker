namespace Gang_Fucker
{
    partial class gangFucker
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(gangFucker));
            this.ChooseFile = new System.Windows.Forms.Button();
            this.Patch = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.Minimizer = new System.Windows.Forms.Button();
            this.Quit = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.progress = new System.Windows.Forms.ProgressBar();
            this.reporter = new System.Windows.Forms.Label();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.open = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // ChooseFile
            // 
            this.ChooseFile.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.ChooseFile.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.ChooseFile.FlatAppearance.BorderSize = 0;
            this.ChooseFile.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ChooseFile.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.ChooseFile.ForeColor = System.Drawing.Color.White;
            this.ChooseFile.Location = new System.Drawing.Point(14, 288);
            this.ChooseFile.Name = "ChooseFile";
            this.ChooseFile.Size = new System.Drawing.Size(95, 32);
            this.ChooseFile.TabIndex = 0;
            this.ChooseFile.Text = "Choose Folder";
            this.ChooseFile.UseVisualStyleBackColor = false;
            this.ChooseFile.Click += new System.EventHandler(this.ChooseFile_Click);
            // 
            // Patch
            // 
            this.Patch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.Patch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.Patch.FlatAppearance.BorderSize = 0;
            this.Patch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Patch.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.25F);
            this.Patch.ForeColor = System.Drawing.Color.White;
            this.Patch.Location = new System.Drawing.Point(14, 250);
            this.Patch.Name = "Patch";
            this.Patch.Size = new System.Drawing.Size(95, 32);
            this.Patch.TabIndex = 2;
            this.Patch.Text = "Patch";
            this.Patch.UseVisualStyleBackColor = false;
            this.Patch.Click += new System.EventHandler(this.Inject_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.panel1.Controls.Add(this.Minimizer);
            this.panel1.Controls.Add(this.Quit);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(558, 35);
            this.panel1.TabIndex = 4;
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.draggerMouseDown);
            this.panel1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.draggerMouseMove);
            // 
            // Minimizer
            // 
            this.Minimizer.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Minimizer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.Minimizer.FlatAppearance.BorderSize = 0;
            this.Minimizer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Minimizer.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.Minimizer.ForeColor = System.Drawing.Color.White;
            this.Minimizer.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.Minimizer.Location = new System.Drawing.Point(498, 6);
            this.Minimizer.Name = "Minimizer";
            this.Minimizer.Size = new System.Drawing.Size(23, 23);
            this.Minimizer.TabIndex = 7;
            this.Minimizer.Text = "-";
            this.Minimizer.UseVisualStyleBackColor = false;
            this.Minimizer.Click += new System.EventHandler(this.Minimizer_Click);
            // 
            // Quit
            // 
            this.Quit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Quit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.Quit.FlatAppearance.BorderSize = 0;
            this.Quit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Quit.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F);
            this.Quit.ForeColor = System.Drawing.Color.White;
            this.Quit.Location = new System.Drawing.Point(527, 6);
            this.Quit.Name = "Quit";
            this.Quit.Size = new System.Drawing.Size(23, 23);
            this.Quit.TabIndex = 5;
            this.Quit.Text = "X";
            this.Quit.UseVisualStyleBackColor = false;
            this.Quit.Click += new System.EventHandler(this.Quit_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label2.Location = new System.Drawing.Point(10, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 17);
            this.label2.TabIndex = 5;
            this.label2.Text = "Gang Fucker";
            // 
            // progress
            // 
            this.progress.AccessibleRole = System.Windows.Forms.AccessibleRole.MenuBar;
            this.progress.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.progress.Cursor = System.Windows.Forms.Cursors.SizeNESW;
            this.progress.Location = new System.Drawing.Point(129, 306);
            this.progress.Name = "progress";
            this.progress.Size = new System.Drawing.Size(404, 14);
            this.progress.TabIndex = 5;
            // 
            // reporter
            // 
            this.reporter.AutoSize = true;
            this.reporter.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.reporter.ForeColor = System.Drawing.Color.White;
            this.reporter.Location = new System.Drawing.Point(131, 290);
            this.reporter.Name = "reporter";
            this.reporter.Size = new System.Drawing.Size(16, 13);
            this.reporter.TabIndex = 6;
            this.reporter.Text = "...";
            // 
            // richTextBox1
            // 
            this.richTextBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.richTextBox1.ForeColor = System.Drawing.SystemColors.MenuBar;
            this.richTextBox1.Location = new System.Drawing.Point(129, 57);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(404, 231);
            this.richTextBox1.TabIndex = 7;
            this.richTextBox1.Text = resources.GetString("richTextBox1.Text");
            // 
            // open
            // 
            this.open.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.open.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.open.FlatAppearance.BorderSize = 0;
            this.open.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.open.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.25F);
            this.open.ForeColor = System.Drawing.Color.White;
            this.open.Location = new System.Drawing.Point(14, 212);
            this.open.Name = "open";
            this.open.Size = new System.Drawing.Size(95, 32);
            this.open.TabIndex = 8;
            this.open.Text = "Open Patch";
            this.open.UseVisualStyleBackColor = false;
            this.open.Click += new System.EventHandler(this.open_Click);
            // 
            // gangFucker
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(24)))), ((int)(((byte)(24)))));
            this.ClientSize = new System.Drawing.Size(558, 332);
            this.Controls.Add(this.open);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.reporter);
            this.Controls.Add(this.progress);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.Patch);
            this.Controls.Add(this.ChooseFile);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "gangFucker";
            this.Text = "Gang Fucker";
            this.Load += new System.EventHandler(this.gangFucker_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button ChooseFile;
        private System.Windows.Forms.Button Patch;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button Quit;
        private System.Windows.Forms.Button Minimizer;
        private System.Windows.Forms.ProgressBar progress;
        private System.Windows.Forms.Label reporter;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Button open;
    }
}

