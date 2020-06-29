namespace PTS_UI
{
    partial class HomeScreen
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.title = new System.Windows.Forms.Label();
            this.newProject = new System.Windows.Forms.Button();
            this.loadProject = new System.Windows.Forms.Button();
            this.logoBig = new System.Windows.Forms.PictureBox();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.logoBig)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.title, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.newProject, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.loadProject, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.logoBig, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 5;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 340F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 46.34146F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 26.82927F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 26.82927F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1182, 753);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // title
            // 
            this.title.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.title.AutoSize = true;
            this.title.Font = new System.Drawing.Font("Modern No. 20", 40F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.title.Location = new System.Drawing.Point(242, 448);
            this.title.Name = "title";
            this.title.Size = new System.Drawing.Size(697, 69);
            this.title.TabIndex = 0;
            this.title.Text = "Project Tracking System";
            // 
            // newProject
            // 
            this.newProject.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.newProject.Location = new System.Drawing.Point(441, 573);
            this.newProject.Name = "newProject";
            this.newProject.Size = new System.Drawing.Size(300, 50);
            this.newProject.TabIndex = 1;
            this.newProject.Text = "Start New Project";
            this.newProject.UseVisualStyleBackColor = true;
            this.newProject.Click += new System.EventHandler(this.newProject_Click);
            // 
            // loadProject
            // 
            this.loadProject.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.loadProject.Location = new System.Drawing.Point(441, 652);
            this.loadProject.Name = "loadProject";
            this.loadProject.Size = new System.Drawing.Size(300, 50);
            this.loadProject.TabIndex = 2;
            this.loadProject.Text = "Load Project";
            this.loadProject.UseVisualStyleBackColor = true;
            this.loadProject.Click += new System.EventHandler(this.loadProject_Click);
            // 
            // logoBig
            // 
            this.logoBig.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.logoBig.Image = global::PTS_UI.Properties.Resources.logo_temp;
            this.logoBig.Location = new System.Drawing.Point(441, 20);
            this.logoBig.Name = "logoBig";
            this.logoBig.Size = new System.Drawing.Size(300, 300);
            this.logoBig.TabIndex = 3;
            this.logoBig.TabStop = false;
            // 
            // HomeScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1182, 753);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "HomeScreen";
            this.Text = "Tracking System";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.logoBig)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label title;
        private System.Windows.Forms.Button newProject;
        private System.Windows.Forms.Button loadProject;
        private System.Windows.Forms.PictureBox logoBig;
    }
}

