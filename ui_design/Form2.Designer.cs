namespace PTS_UI
{
    partial class MainScreen
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
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.logoSmall = new System.Windows.Forms.PictureBox();
            this.projectInformation = new System.Windows.Forms.Button();
            this.projectRequirements = new System.Windows.Forms.Button();
            this.projectEffort = new System.Windows.Forms.Button();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.InfoTabs = new System.Windows.Forms.TabControl();
            this.descriptionTab = new System.Windows.Forms.TabPage();
            this.teamTab = new System.Windows.Forms.TabPage();
            this.riskTab = new System.Windows.Forms.TabPage();
            this.label2 = new System.Windows.Forms.Label();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.logoSmall)).BeginInit();
            this.tableLayoutPanel3.SuspendLayout();
            this.InfoTabs.SuspendLayout();
            this.descriptionTab.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 320F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel3, 1, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1182, 753);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 1;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Controls.Add(this.logoSmall, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.projectInformation, 0, 2);
            this.tableLayoutPanel2.Controls.Add(this.projectRequirements, 0, 3);
            this.tableLayoutPanel2.Controls.Add(this.projectEffort, 0, 4);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 6;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 250F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(314, 747);
            this.tableLayoutPanel2.TabIndex = 0;
            // 
            // logoSmall
            // 
            this.logoSmall.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.logoSmall.Image = global::PTS_UI.Properties.Resources.logo_temp;
            this.logoSmall.Location = new System.Drawing.Point(57, 25);
            this.logoSmall.Name = "logoSmall";
            this.logoSmall.Size = new System.Drawing.Size(200, 200);
            this.logoSmall.TabIndex = 0;
            this.logoSmall.TabStop = false;
            // 
            // projectInformation
            // 
            this.projectInformation.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.projectInformation.Font = new System.Drawing.Font("Lato", 14F);
            this.projectInformation.Location = new System.Drawing.Point(3, 280);
            this.projectInformation.Name = "projectInformation";
            this.projectInformation.Size = new System.Drawing.Size(308, 80);
            this.projectInformation.TabIndex = 1;
            this.projectInformation.Text = "General Project Information";
            this.projectInformation.UseVisualStyleBackColor = true;
            // 
            // projectRequirements
            // 
            this.projectRequirements.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.projectRequirements.Font = new System.Drawing.Font("Lato", 14F);
            this.projectRequirements.Location = new System.Drawing.Point(3, 380);
            this.projectRequirements.Name = "projectRequirements";
            this.projectRequirements.Size = new System.Drawing.Size(308, 80);
            this.projectRequirements.TabIndex = 2;
            this.projectRequirements.Text = "Project Requirements";
            this.projectRequirements.UseVisualStyleBackColor = true;
            // 
            // projectEffort
            // 
            this.projectEffort.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.projectEffort.Font = new System.Drawing.Font("Lato", 14F);
            this.projectEffort.Location = new System.Drawing.Point(3, 480);
            this.projectEffort.Name = "projectEffort";
            this.projectEffort.Size = new System.Drawing.Size(308, 80);
            this.projectEffort.TabIndex = 3;
            this.projectEffort.Text = "Project Effort: Monitoring and Tracking";
            this.projectEffort.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 1;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.InfoTabs, 0, 1);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(323, 3);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 2;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(856, 747);
            this.tableLayoutPanel3.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Modern No. 20", 32F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Padding = new System.Windows.Forms.Padding(10, 20, 10, 10);
            this.label1.Size = new System.Drawing.Size(672, 85);
            this.label1.TabIndex = 1;
            this.label1.Text = "General Project Information";
            // 
            // InfoTabs
            // 
            this.InfoTabs.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.InfoTabs.Controls.Add(this.descriptionTab);
            this.InfoTabs.Controls.Add(this.teamTab);
            this.InfoTabs.Controls.Add(this.riskTab);
            this.InfoTabs.Location = new System.Drawing.Point(29, 126);
            this.InfoTabs.Name = "InfoTabs";
            this.InfoTabs.SelectedIndex = 0;
            this.InfoTabs.Size = new System.Drawing.Size(798, 595);
            this.InfoTabs.TabIndex = 4;
            // 
            // descriptionTab
            // 
            this.descriptionTab.Controls.Add(this.label2);
            this.descriptionTab.Location = new System.Drawing.Point(4, 25);
            this.descriptionTab.Name = "descriptionTab";
            this.descriptionTab.Padding = new System.Windows.Forms.Padding(3);
            this.descriptionTab.Size = new System.Drawing.Size(790, 566);
            this.descriptionTab.TabIndex = 1;
            this.descriptionTab.Text = "Project Description";
            this.descriptionTab.UseVisualStyleBackColor = true;
            // 
            // teamTab
            // 
            this.teamTab.Location = new System.Drawing.Point(4, 25);
            this.teamTab.Name = "teamTab";
            this.teamTab.Padding = new System.Windows.Forms.Padding(3);
            this.teamTab.Size = new System.Drawing.Size(790, 566);
            this.teamTab.TabIndex = 2;
            this.teamTab.Text = "Team Members";
            this.teamTab.UseVisualStyleBackColor = true;
            // 
            // riskTab
            // 
            this.riskTab.Location = new System.Drawing.Point(4, 25);
            this.riskTab.Name = "riskTab";
            this.riskTab.Padding = new System.Windows.Forms.Padding(3);
            this.riskTab.Size = new System.Drawing.Size(790, 566);
            this.riskTab.TabIndex = 3;
            this.riskTab.Text = "Risk and Risk Status";
            this.riskTab.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Lato", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(0, 0);
            this.label2.Name = "label2";
            this.label2.Padding = new System.Windows.Forms.Padding(10, 10, 10, 0);
            this.label2.Size = new System.Drawing.Size(433, 46);
            this.label2.TabIndex = 0;
            this.label2.Text = "High-level project description:";
            // 
            // MainScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1182, 753);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "MainScreen";
            this.Text = "Tracking System";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.logoSmall)).EndInit();
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel3.PerformLayout();
            this.InfoTabs.ResumeLayout(false);
            this.descriptionTab.ResumeLayout(false);
            this.descriptionTab.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.PictureBox logoSmall;
        private System.Windows.Forms.Button projectInformation;
        private System.Windows.Forms.Button projectRequirements;
        private System.Windows.Forms.Button projectEffort;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.TabControl InfoTabs;
        private System.Windows.Forms.TabPage descriptionTab;
        private System.Windows.Forms.TabPage teamTab;
        private System.Windows.Forms.TabPage riskTab;
        private System.Windows.Forms.Label label2;
    }
}
