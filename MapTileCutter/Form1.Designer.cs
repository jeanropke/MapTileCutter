namespace MapTileCutter
{
    partial class Form1
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.MapImagePath = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.MinZoomTextBox = new System.Windows.Forms.TextBox();
            this.MaxZoomTextBox = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.TileSizeTextBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.TileFormat = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.structureComboBox = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.exportPathButton = new System.Windows.Forms.Button();
            this.ExportPath = new System.Windows.Forms.TextBox();
            this.ProgressLabel = new System.Windows.Forms.Label();
            this.BackgroundColorLabel = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.BackgroundColorTextBox = new System.Windows.Forms.TextBox();
            this.BackgroundColorTooltip = new System.Windows.Forms.ToolTip(this.components);
            this.label7 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel5.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.MapImagePath);
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.groupBox1.Location = new System.Drawing.Point(14, 13);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox1.Size = new System.Drawing.Size(905, 75);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Map Image";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(790, 25);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(108, 30);
            this.button1.TabIndex = 1;
            this.button1.Text = "Open";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.SelectMapImageButton_Click);
            // 
            // MapImagePath
            // 
            this.MapImagePath.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.MapImagePath.Location = new System.Drawing.Point(92, 26);
            this.MapImagePath.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MapImagePath.Name = "MapImagePath";
            this.MapImagePath.Size = new System.Drawing.Size(689, 27);
            this.MapImagePath.TabIndex = 0;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(832, 257);
            this.button2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(87, 30);
            this.button2.TabIndex = 1;
            this.button2.Text = "Make Tiles";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.MakeTilesButton_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.panel5);
            this.groupBox2.Controls.Add(this.panel4);
            this.groupBox2.Controls.Add(this.panel3);
            this.groupBox2.Controls.Add(this.panel2);
            this.groupBox2.Controls.Add(this.panel1);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.exportPathButton);
            this.groupBox2.Controls.Add(this.ExportPath);
            this.groupBox2.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.groupBox2.Location = new System.Drawing.Point(14, 96);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox2.Size = new System.Drawing.Size(905, 153);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Export Options";
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.MinZoomTextBox);
            this.panel4.Controls.Add(this.MaxZoomTextBox);
            this.panel4.Controls.Add(this.label6);
            this.panel4.Controls.Add(this.label5);
            this.panel4.Location = new System.Drawing.Point(6, 98);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(271, 46);
            this.panel4.TabIndex = 7;
            // 
            // MinZoomTextBox
            // 
            this.MinZoomTextBox.Location = new System.Drawing.Point(213, 11);
            this.MinZoomTextBox.Name = "MinZoomTextBox";
            this.MinZoomTextBox.Size = new System.Drawing.Size(40, 25);
            this.MinZoomTextBox.TabIndex = 3;
            this.MinZoomTextBox.Text = "1";
            // 
            // MaxZoomTextBox
            // 
            this.MaxZoomTextBox.Location = new System.Drawing.Point(85, 11);
            this.MaxZoomTextBox.Name = "MaxZoomTextBox";
            this.MaxZoomTextBox.Size = new System.Drawing.Size(40, 25);
            this.MaxZoomTextBox.TabIndex = 2;
            this.MaxZoomTextBox.Text = "7";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(134, 14);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(71, 19);
            this.label6.TabIndex = 1;
            this.label6.Text = "Min zoom";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 14);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(73, 19);
            this.label5.TabIndex = 0;
            this.label5.Text = "Max zoom";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.TileSizeTextBox);
            this.panel3.Controls.Add(this.label4);
            this.panel3.Location = new System.Drawing.Point(552, 60);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(229, 43);
            this.panel3.TabIndex = 6;
            // 
            // TileSizeTextBox
            // 
            this.TileSizeTextBox.Location = new System.Drawing.Point(65, 8);
            this.TileSizeTextBox.Name = "TileSizeTextBox";
            this.TileSizeTextBox.Size = new System.Drawing.Size(63, 25);
            this.TileSizeTextBox.TabIndex = 1;
            this.TileSizeTextBox.Text = "256";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(3, 10);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 19);
            this.label4.TabIndex = 0;
            this.label4.Text = "Tile size";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.TileFormat);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Location = new System.Drawing.Point(295, 60);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(232, 43);
            this.panel2.TabIndex = 5;
            // 
            // TileFormat
            // 
            this.TileFormat.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.TileFormat.FormattingEnabled = true;
            this.TileFormat.Items.AddRange(new object[] {
            "JPG",
            "PNG"});
            this.TileFormat.Location = new System.Drawing.Point(73, 7);
            this.TileFormat.Name = "TileFormat";
            this.TileFormat.Size = new System.Drawing.Size(145, 25);
            this.TileFormat.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(2, 10);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 19);
            this.label3.TabIndex = 0;
            this.label3.Text = "Export as";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.structureComboBox);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(6, 60);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(271, 43);
            this.panel1.TabIndex = 5;
            // 
            // structureComboBox
            // 
            this.structureComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.structureComboBox.FormattingEnabled = true;
            this.structureComboBox.Items.AddRange(new object[] {
            "z_x_y.png",
            "z/x/y.png",
            "z/x_y.png"});
            this.structureComboBox.Location = new System.Drawing.Point(86, 7);
            this.structureComboBox.Name = "structureComboBox";
            this.structureComboBox.Size = new System.Drawing.Size(167, 25);
            this.structureComboBox.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 10);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 19);
            this.label2.TabIndex = 3;
            this.label2.Text = "Structure";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.label1.Location = new System.Drawing.Point(6, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 19);
            this.label1.TabIndex = 2;
            this.label1.Text = "Export path";
            // 
            // exportPathButton
            // 
            this.exportPathButton.Location = new System.Drawing.Point(790, 25);
            this.exportPathButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.exportPathButton.Name = "exportPathButton";
            this.exportPathButton.Size = new System.Drawing.Size(107, 30);
            this.exportPathButton.TabIndex = 1;
            this.exportPathButton.Text = "Choose";
            this.exportPathButton.UseVisualStyleBackColor = true;
            this.exportPathButton.Click += new System.EventHandler(this.ExportPathButton_Click);
            // 
            // ExportPath
            // 
            this.ExportPath.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.ExportPath.Location = new System.Drawing.Point(92, 26);
            this.ExportPath.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ExportPath.Name = "ExportPath";
            this.ExportPath.Size = new System.Drawing.Size(689, 27);
            this.ExportPath.TabIndex = 0;
            // 
            // ProgressLabel
            // 
            this.ProgressLabel.AutoSize = true;
            this.ProgressLabel.Location = new System.Drawing.Point(12, 284);
            this.ProgressLabel.Name = "ProgressLabel";
            this.ProgressLabel.Size = new System.Drawing.Size(0, 19);
            this.ProgressLabel.TabIndex = 3;
            // 
            // BackgroundColorLabel
            // 
            this.BackgroundColorLabel.AutoSize = true;
            this.BackgroundColorLabel.Location = new System.Drawing.Point(3, 14);
            this.BackgroundColorLabel.Name = "BackgroundColorLabel";
            this.BackgroundColorLabel.Size = new System.Drawing.Size(116, 19);
            this.BackgroundColorLabel.TabIndex = 8;
            this.BackgroundColorLabel.Text = "Background color";
            this.BackgroundColorLabel.MouseHover += new System.EventHandler(this.ShowTooltip_MouseHover);
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.BackgroundColorTextBox);
            this.panel5.Controls.Add(this.BackgroundColorLabel);
            this.panel5.Location = new System.Drawing.Point(295, 98);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(232, 46);
            this.panel5.TabIndex = 9;
            // 
            // BackgroundColorTextBox
            // 
            this.BackgroundColorTextBox.Location = new System.Drawing.Point(126, 12);
            this.BackgroundColorTextBox.Name = "BackgroundColorTextBox";
            this.BackgroundColorTextBox.Size = new System.Drawing.Size(92, 25);
            this.BackgroundColorTextBox.TabIndex = 9;
            this.BackgroundColorTextBox.Text = "#00FFFFFF";
            // 
            // BackgroundColorTooltip
            // 
            this.BackgroundColorTooltip.AutoPopDelay = 5000;
            this.BackgroundColorTooltip.InitialDelay = 50;
            this.BackgroundColorTooltip.ReshowDelay = 100;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(8, 31);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(79, 19);
            this.label7.TabIndex = 2;
            this.label7.Text = "Image path";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(933, 298);
            this.Controls.Add(this.ProgressLabel);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Map Tile Cutter";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox MapImagePath;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button exportPathButton;
        private System.Windows.Forms.TextBox ExportPath;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox structureComboBox;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.ComboBox TileFormat;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TextBox TileSizeTextBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.TextBox MinZoomTextBox;
        private System.Windows.Forms.TextBox MaxZoomTextBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label ProgressLabel;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.TextBox BackgroundColorTextBox;
        private System.Windows.Forms.Label BackgroundColorLabel;
        private System.Windows.Forms.ToolTip BackgroundColorTooltip;
        private System.Windows.Forms.Label label7;
    }
}

