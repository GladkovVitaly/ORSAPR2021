namespace СrowbarUI
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.buildButton = new System.Windows.Forms.Button();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.label2 = new System.Windows.Forms.Label();
            this.workingAreaWidthTextBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.workingAreaLengthTextBox = new System.Windows.Forms.TextBox();
            this.workingPartHeightTextBox = new System.Windows.Forms.TextBox();
            this.drummerСornerTextBox = new System.Windows.Forms.TextBox();
            this.diameterTextBox = new System.Windows.Forms.TextBox();
            this.mainBodyLengthTextBox = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.mainBodyLengthLabel = new System.Windows.Forms.Label();
            this.diameterLabel = new System.Windows.Forms.Label();
            this.drummerСornerLabel = new System.Windows.Forms.Label();
            this.workingPartHeightLabel = new System.Windows.Forms.Label();
            this.workingAreaLengthLabel = new System.Windows.Forms.Label();
            this.workingAreaWidthLabel = new System.Windows.Forms.Label();
            this.defaultPArametersButton = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.defaultPArametersButton);
            this.groupBox1.Controls.Add(this.buildButton);
            this.groupBox1.Controls.Add(this.tableLayoutPanel1);
            this.groupBox1.Location = new System.Drawing.Point(13, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(305, 235);
            this.groupBox1.TabIndex = 37;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Параметры";
            // 
            // buildButton
            // 
            this.buildButton.Enabled = false;
            this.buildButton.Location = new System.Drawing.Point(214, 203);
            this.buildButton.Name = "buildButton";
            this.buildButton.Size = new System.Drawing.Size(75, 23);
            this.buildButton.TabIndex = 6;
            this.buildButton.Text = "Построить";
            this.buildButton.UseVisualStyleBackColor = true;
            this.buildButton.Click += new System.EventHandler(this.BuildButton_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 80F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 120F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanel1.Controls.Add(this.workingAreaWidthLabel, 2, 5);
            this.tableLayoutPanel1.Controls.Add(this.workingAreaLengthLabel, 2, 4);
            this.tableLayoutPanel1.Controls.Add(this.workingPartHeightLabel, 2, 3);
            this.tableLayoutPanel1.Controls.Add(this.drummerСornerLabel, 2, 2);
            this.tableLayoutPanel1.Controls.Add(this.diameterLabel, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.label2, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.workingAreaWidthTextBox, 1, 5);
            this.tableLayoutPanel1.Controls.Add(this.label5, 0, 5);
            this.tableLayoutPanel1.Controls.Add(this.label4, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.label3, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.workingAreaLengthTextBox, 1, 4);
            this.tableLayoutPanel1.Controls.Add(this.workingPartHeightTextBox, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.drummerСornerTextBox, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.diameterTextBox, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.mainBodyLengthTextBox, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.label6, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.label7, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.mainBodyLengthLabel, 2, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(8, 19);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 6;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(281, 178);
            this.tableLayoutPanel1.TabIndex = 32;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 8);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 13);
            this.label2.TabIndex = 18;
            this.label2.Text = "Высота H";
            // 
            // workingAreaWidthTextBox
            // 
            this.workingAreaWidthTextBox.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.workingAreaWidthTextBox.Enabled = false;
            this.workingAreaWidthTextBox.Location = new System.Drawing.Point(83, 151);
            this.workingAreaWidthTextBox.Name = "workingAreaWidthTextBox";
            this.workingAreaWidthTextBox.Size = new System.Drawing.Size(94, 20);
            this.workingAreaWidthTextBox.TabIndex = 5;
            this.workingAreaWidthTextBox.TextChanged += new System.EventHandler(this.Textbox_Validating);
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(3, 155);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(59, 13);
            this.label5.TabIndex = 21;
            this.label5.Text = "Высота W";
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(3, 95);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 13);
            this.label4.TabIndex = 20;
            this.label4.Text = "Высота K";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 37);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 13);
            this.label3.TabIndex = 19;
            this.label3.Text = "Диаметр D";
            // 
            // workingAreaLengthTextBox
            // 
            this.workingAreaLengthTextBox.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.workingAreaLengthTextBox.Enabled = false;
            this.workingAreaLengthTextBox.Location = new System.Drawing.Point(83, 120);
            this.workingAreaLengthTextBox.Name = "workingAreaLengthTextBox";
            this.workingAreaLengthTextBox.Size = new System.Drawing.Size(94, 20);
            this.workingAreaLengthTextBox.TabIndex = 4;
            this.workingAreaLengthTextBox.TextChanged += new System.EventHandler(this.Textbox_Validating);
            // 
            // workingPartHeightTextBox
            // 
            this.workingPartHeightTextBox.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.workingPartHeightTextBox.Enabled = false;
            this.workingPartHeightTextBox.Location = new System.Drawing.Point(83, 91);
            this.workingPartHeightTextBox.Name = "workingPartHeightTextBox";
            this.workingPartHeightTextBox.Size = new System.Drawing.Size(94, 20);
            this.workingPartHeightTextBox.TabIndex = 3;
            this.workingPartHeightTextBox.TextChanged += new System.EventHandler(this.Textbox_Validating);
            // 
            // drummerСornerTextBox
            // 
            this.drummerСornerTextBox.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.drummerСornerTextBox.Location = new System.Drawing.Point(83, 62);
            this.drummerСornerTextBox.Name = "drummerСornerTextBox";
            this.drummerСornerTextBox.Size = new System.Drawing.Size(94, 20);
            this.drummerСornerTextBox.TabIndex = 2;
            this.drummerСornerTextBox.TextChanged += new System.EventHandler(this.Textbox_Validating);
            // 
            // diameterTextBox
            // 
            this.diameterTextBox.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.diameterTextBox.Location = new System.Drawing.Point(83, 33);
            this.diameterTextBox.Name = "diameterTextBox";
            this.diameterTextBox.Size = new System.Drawing.Size(94, 20);
            this.diameterTextBox.TabIndex = 1;
            this.diameterTextBox.TextChanged += new System.EventHandler(this.Textbox_Validating);
            // 
            // mainBodyLengthTextBox
            // 
            this.mainBodyLengthTextBox.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.mainBodyLengthTextBox.Location = new System.Drawing.Point(83, 4);
            this.mainBodyLengthTextBox.Name = "mainBodyLengthTextBox";
            this.mainBodyLengthTextBox.Size = new System.Drawing.Size(94, 20);
            this.mainBodyLengthTextBox.TabIndex = 0;
            this.mainBodyLengthTextBox.TextChanged += new System.EventHandler(this.Textbox_Validating);
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(3, 66);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(42, 13);
            this.label6.TabIndex = 22;
            this.label6.Text = "Угол X";
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(3, 124);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(62, 13);
            this.label7.TabIndex = 23;
            this.label7.Text = "Диаметр L";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.InitialImage = null;
            this.pictureBox1.Location = new System.Drawing.Point(323, 10);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(293, 434);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 36;
            this.pictureBox1.TabStop = false;
            // 
            // mainBodyLengthLabel
            // 
            this.mainBodyLengthLabel.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.mainBodyLengthLabel.AutoSize = true;
            this.mainBodyLengthLabel.Location = new System.Drawing.Point(203, 8);
            this.mainBodyLengthLabel.Name = "mainBodyLengthLabel";
            this.mainBodyLengthLabel.Size = new System.Drawing.Size(71, 13);
            this.mainBodyLengthLabel.TabIndex = 24;
            this.mainBodyLengthLabel.Text = "(300-600) мм";
            // 
            // diameterLabel
            // 
            this.diameterLabel.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.diameterLabel.AutoSize = true;
            this.diameterLabel.Location = new System.Drawing.Point(203, 37);
            this.diameterLabel.Name = "diameterLabel";
            this.diameterLabel.Size = new System.Drawing.Size(59, 13);
            this.diameterLabel.TabIndex = 25;
            this.diameterLabel.Text = "(10-20) мм";
            // 
            // drummerСornerLabel
            // 
            this.drummerСornerLabel.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.drummerСornerLabel.AutoSize = true;
            this.drummerСornerLabel.Location = new System.Drawing.Point(203, 66);
            this.drummerСornerLabel.Name = "drummerСornerLabel";
            this.drummerСornerLabel.Size = new System.Drawing.Size(44, 13);
            this.drummerСornerLabel.TabIndex = 26;
            this.drummerСornerLabel.Text = "(30-45)°";
            // 
            // workingPartHeightLabel
            // 
            this.workingPartHeightLabel.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.workingPartHeightLabel.AutoSize = true;
            this.workingPartHeightLabel.Location = new System.Drawing.Point(203, 95);
            this.workingPartHeightLabel.Name = "workingPartHeightLabel";
            this.workingPartHeightLabel.Size = new System.Drawing.Size(41, 13);
            this.workingPartHeightLabel.TabIndex = 27;
            this.workingPartHeightLabel.Text = "label10";
            this.workingPartHeightLabel.Visible = false;
            // 
            // workingAreaLengthLabel
            // 
            this.workingAreaLengthLabel.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.workingAreaLengthLabel.AutoSize = true;
            this.workingAreaLengthLabel.Location = new System.Drawing.Point(203, 124);
            this.workingAreaLengthLabel.Name = "workingAreaLengthLabel";
            this.workingAreaLengthLabel.Size = new System.Drawing.Size(41, 13);
            this.workingAreaLengthLabel.TabIndex = 28;
            this.workingAreaLengthLabel.Text = "label11";
            this.workingAreaLengthLabel.Visible = false;
            // 
            // workingAreaWidthLabel
            // 
            this.workingAreaWidthLabel.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.workingAreaWidthLabel.AutoSize = true;
            this.workingAreaWidthLabel.Location = new System.Drawing.Point(203, 155);
            this.workingAreaWidthLabel.Name = "workingAreaWidthLabel";
            this.workingAreaWidthLabel.Size = new System.Drawing.Size(41, 13);
            this.workingAreaWidthLabel.TabIndex = 29;
            this.workingAreaWidthLabel.Text = "label12";
            this.workingAreaWidthLabel.Visible = false;
            // 
            // defaultPArametersButton
            // 
            this.defaultPArametersButton.Location = new System.Drawing.Point(8, 203);
            this.defaultPArametersButton.Name = "defaultPArametersButton";
            this.defaultPArametersButton.Size = new System.Drawing.Size(200, 23);
            this.defaultPArametersButton.TabIndex = 38;
            this.defaultPArametersButton.Text = "Параметры по умолчанию";
            this.defaultPArametersButton.UseVisualStyleBackColor = true;
            this.defaultPArametersButton.Click += new System.EventHandler(this.DefaultParametersButton_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(628, 456);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "MainForm";
            this.Text = "Строим лом";
            this.groupBox1.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button buildButton;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label label2;
        public System.Windows.Forms.TextBox workingAreaWidthTextBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        public System.Windows.Forms.TextBox workingAreaLengthTextBox;
        public System.Windows.Forms.TextBox workingPartHeightTextBox;
        public System.Windows.Forms.TextBox drummerСornerTextBox;
        public System.Windows.Forms.TextBox diameterTextBox;
        public System.Windows.Forms.TextBox mainBodyLengthTextBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button defaultPArametersButton;
        private System.Windows.Forms.Label workingAreaWidthLabel;
        private System.Windows.Forms.Label workingAreaLengthLabel;
        private System.Windows.Forms.Label workingPartHeightLabel;
        private System.Windows.Forms.Label drummerСornerLabel;
        private System.Windows.Forms.Label diameterLabel;
        private System.Windows.Forms.Label mainBodyLengthLabel;
    }
}