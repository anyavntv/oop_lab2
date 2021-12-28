namespace Lab2
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.TextOutput = new System.Windows.Forms.RichTextBox();
            this.ManufacturerComboBox = new System.Windows.Forms.ComboBox();
            this.ConditionComboBox = new System.Windows.Forms.ComboBox();
            this.OSComboBox = new System.Windows.Forms.ComboBox();
            this.ManufacturerLabel = new System.Windows.Forms.Label();
            this.PriceLabel = new System.Windows.Forms.Label();
            this.ConditionLabel = new System.Windows.Forms.Label();
            this.OSLabel = new System.Windows.Forms.Label();
            this.PriceTextBox = new System.Windows.Forms.TextBox();
            this.DomRadioButton = new System.Windows.Forms.RadioButton();
            this.SaxRadioButton = new System.Windows.Forms.RadioButton();
            this.LinqRadioButton = new System.Windows.Forms.RadioButton();
            this.TransformButton = new System.Windows.Forms.Button();
            this.ClearSearchButton = new System.Windows.Forms.Button();
            this.AlgoGroupBox = new System.Windows.Forms.GroupBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.FileStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.OpenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.SearchGroupBox = new System.Windows.Forms.GroupBox();
            this.TransformGroupBox = new System.Windows.Forms.GroupBox();
            this.AlgoGroupBox.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SearchGroupBox.SuspendLayout();
            this.TransformGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // TextOutput
            // 
            this.TextOutput.BackColor = System.Drawing.SystemColors.Window;
            this.TextOutput.ForeColor = System.Drawing.SystemColors.WindowText;
            this.TextOutput.Location = new System.Drawing.Point(1, 0);
            this.TextOutput.Name = "TextOutput";
            this.TextOutput.ReadOnly = true;
            this.TextOutput.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.ForcedVertical;
            this.TextOutput.Size = new System.Drawing.Size(409, 449);
            this.TextOutput.TabIndex = 0;
            this.TextOutput.Text = "Спочатку відкрийте файл...";
            // 
            // ManufacturerComboBox
            // 
            this.ManufacturerComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ManufacturerComboBox.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ManufacturerComboBox.FormattingEnabled = true;
            this.ManufacturerComboBox.Location = new System.Drawing.Point(217, 26);
            this.ManufacturerComboBox.Name = "ManufacturerComboBox";
            this.ManufacturerComboBox.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.ManufacturerComboBox.Size = new System.Drawing.Size(151, 28);
            this.ManufacturerComboBox.Sorted = true;
            this.ManufacturerComboBox.TabIndex = 2;
            this.ManufacturerComboBox.SelectedValueChanged += new System.EventHandler(this.ManufacturerComboBox_SelectedValueChanged);
            // 
            // ConditionComboBox
            // 
            this.ConditionComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ConditionComboBox.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ConditionComboBox.FormattingEnabled = true;
            this.ConditionComboBox.Location = new System.Drawing.Point(217, 127);
            this.ConditionComboBox.Name = "ConditionComboBox";
            this.ConditionComboBox.Size = new System.Drawing.Size(151, 28);
            this.ConditionComboBox.Sorted = true;
            this.ConditionComboBox.TabIndex = 4;
            this.ConditionComboBox.SelectedValueChanged += new System.EventHandler(this.ConditionComboBox_SelectedValueChanged);
            // 
            // OSComboBox
            // 
            this.OSComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.OSComboBox.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.OSComboBox.FormattingEnabled = true;
            this.OSComboBox.Location = new System.Drawing.Point(217, 178);
            this.OSComboBox.Name = "OSComboBox";
            this.OSComboBox.Size = new System.Drawing.Size(151, 28);
            this.OSComboBox.Sorted = true;
            this.OSComboBox.TabIndex = 5;
            this.OSComboBox.SelectedValueChanged += new System.EventHandler(this.OSComboBox_SelectedValueChanged);
            // 
            // ManufacturerLabel
            // 
            this.ManufacturerLabel.AutoSize = true;
            this.ManufacturerLabel.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ManufacturerLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ManufacturerLabel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ManufacturerLabel.Location = new System.Drawing.Point(27, 26);
            this.ManufacturerLabel.Name = "ManufacturerLabel";
            this.ManufacturerLabel.Size = new System.Drawing.Size(157, 22);
            this.ManufacturerLabel.TabIndex = 6;
            this.ManufacturerLabel.Text = "Виробник                   ";
            // 
            // PriceLabel
            // 
            this.PriceLabel.AutoSize = true;
            this.PriceLabel.BackColor = System.Drawing.SystemColors.ControlLight;
            this.PriceLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PriceLabel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.PriceLabel.Location = new System.Drawing.Point(29, 78);
            this.PriceLabel.Name = "PriceLabel";
            this.PriceLabel.Size = new System.Drawing.Size(157, 22);
            this.PriceLabel.TabIndex = 7;
            this.PriceLabel.Text = "Діапазон цін              ";
            // 
            // ConditionLabel
            // 
            this.ConditionLabel.AutoSize = true;
            this.ConditionLabel.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ConditionLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ConditionLabel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ConditionLabel.Location = new System.Drawing.Point(29, 130);
            this.ConditionLabel.Name = "ConditionLabel";
            this.ConditionLabel.Size = new System.Drawing.Size(155, 22);
            this.ConditionLabel.TabIndex = 8;
            this.ConditionLabel.Text = "Стан                            ";
            // 
            // OSLabel
            // 
            this.OSLabel.AutoSize = true;
            this.OSLabel.BackColor = System.Drawing.SystemColors.ControlLight;
            this.OSLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.OSLabel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.OSLabel.Location = new System.Drawing.Point(29, 181);
            this.OSLabel.Name = "OSLabel";
            this.OSLabel.Size = new System.Drawing.Size(155, 22);
            this.OSLabel.TabIndex = 9;
            this.OSLabel.Text = "Операційна система";
            // 
            // PriceTextBox
            // 
            this.PriceTextBox.BackColor = System.Drawing.SystemColors.ControlLight;
            this.PriceTextBox.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.PriceTextBox.Location = new System.Drawing.Point(217, 75);
            this.PriceTextBox.Name = "PriceTextBox";
            this.PriceTextBox.Size = new System.Drawing.Size(151, 27);
            this.PriceTextBox.TabIndex = 11;
            this.PriceTextBox.Text = "0-999999";
            this.PriceTextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.PriceTextBox_KeyDown);
            this.PriceTextBox.Leave += new System.EventHandler(this.PriceTextBox_Leave);
            // 
            // DomRadioButton
            // 
            this.DomRadioButton.AutoSize = true;
            this.DomRadioButton.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.DomRadioButton.Location = new System.Drawing.Point(29, 36);
            this.DomRadioButton.Name = "DomRadioButton";
            this.DomRadioButton.Size = new System.Drawing.Size(65, 24);
            this.DomRadioButton.TabIndex = 12;
            this.DomRadioButton.TabStop = true;
            this.DomRadioButton.Text = "DOM";
            this.DomRadioButton.UseVisualStyleBackColor = true;
            this.DomRadioButton.CheckedChanged += new System.EventHandler(this.DomRadioButton_CheckedChanged);
            // 
            // SaxRadioButton
            // 
            this.SaxRadioButton.AutoSize = true;
            this.SaxRadioButton.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.SaxRadioButton.Location = new System.Drawing.Point(151, 36);
            this.SaxRadioButton.Name = "SaxRadioButton";
            this.SaxRadioButton.Size = new System.Drawing.Size(57, 24);
            this.SaxRadioButton.TabIndex = 13;
            this.SaxRadioButton.TabStop = true;
            this.SaxRadioButton.Text = "SAX";
            this.SaxRadioButton.UseVisualStyleBackColor = true;
            this.SaxRadioButton.CheckedChanged += new System.EventHandler(this.SaxRadioButton_CheckedChanged);
            // 
            // LinqRadioButton
            // 
            this.LinqRadioButton.AutoSize = true;
            this.LinqRadioButton.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LinqRadioButton.Location = new System.Drawing.Point(254, 36);
            this.LinqRadioButton.Name = "LinqRadioButton";
            this.LinqRadioButton.Size = new System.Drawing.Size(114, 24);
            this.LinqRadioButton.TabIndex = 14;
            this.LinqRadioButton.TabStop = true;
            this.LinqRadioButton.Text = "LINQ to XML";
            this.LinqRadioButton.UseVisualStyleBackColor = true;
            this.LinqRadioButton.CheckedChanged += new System.EventHandler(this.LinqRadioButton_CheckedChanged);
            // 
            // TransformButton
            // 
            this.TransformButton.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TransformButton.Location = new System.Drawing.Point(121, 14);
            this.TransformButton.Name = "TransformButton";
            this.TransformButton.Size = new System.Drawing.Size(151, 29);
            this.TransformButton.TabIndex = 15;
            this.TransformButton.Text = "XML —> HTML";
            this.TransformButton.UseVisualStyleBackColor = true;
            this.TransformButton.Click += new System.EventHandler(this.TransformButton_Click);
            // 
            // ClearSearchButton
            // 
            this.ClearSearchButton.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ClearSearchButton.Location = new System.Drawing.Point(121, 216);
            this.ClearSearchButton.Name = "ClearSearchButton";
            this.ClearSearchButton.Size = new System.Drawing.Size(151, 29);
            this.ClearSearchButton.TabIndex = 16;
            this.ClearSearchButton.Text = "Очистити пошук";
            this.ClearSearchButton.UseVisualStyleBackColor = true;
            this.ClearSearchButton.Click += new System.EventHandler(this.ClearSearchButton_Click);
            // 
            // AlgoGroupBox
            // 
            this.AlgoGroupBox.Controls.Add(this.LinqRadioButton);
            this.AlgoGroupBox.Controls.Add(this.SaxRadioButton);
            this.AlgoGroupBox.Controls.Add(this.DomRadioButton);
            this.AlgoGroupBox.Enabled = false;
            this.AlgoGroupBox.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.AlgoGroupBox.Location = new System.Drawing.Point(417, 312);
            this.AlgoGroupBox.Name = "AlgoGroupBox";
            this.AlgoGroupBox.Size = new System.Drawing.Size(380, 84);
            this.AlgoGroupBox.TabIndex = 18;
            this.AlgoGroupBox.TabStop = false;
            this.AlgoGroupBox.Text = "Алгоритм пошуку   ";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Dock = System.Windows.Forms.DockStyle.None;
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.FileStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(412, 0);
            this.menuStrip1.MaximumSize = new System.Drawing.Size(385, 0);
            this.menuStrip1.MinimumSize = new System.Drawing.Size(385, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(385, 28);
            this.menuStrip1.TabIndex = 19;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // FileStripMenuItem
            // 
            this.FileStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.OpenToolStripMenuItem});
            this.FileStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.FileStripMenuItem.Name = "FileStripMenuItem";
            this.FileStripMenuItem.Size = new System.Drawing.Size(62, 24);
            this.FileStripMenuItem.Text = "Файл";
            // 
            // OpenToolStripMenuItem
            // 
            this.OpenToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("OpenToolStripMenuItem.Image")));
            this.OpenToolStripMenuItem.Name = "OpenToolStripMenuItem";
            this.OpenToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.OpenToolStripMenuItem.Size = new System.Drawing.Size(213, 26);
            this.OpenToolStripMenuItem.Text = "Відкрити";
            this.OpenToolStripMenuItem.Click += new System.EventHandler(this.OpenToolStripMenuItem_Click);
            // 
            // SearchGroupBox
            // 
            this.SearchGroupBox.Controls.Add(this.ConditionComboBox);
            this.SearchGroupBox.Controls.Add(this.ManufacturerLabel);
            this.SearchGroupBox.Controls.Add(this.ManufacturerComboBox);
            this.SearchGroupBox.Controls.Add(this.PriceTextBox);
            this.SearchGroupBox.Controls.Add(this.PriceLabel);
            this.SearchGroupBox.Controls.Add(this.ClearSearchButton);
            this.SearchGroupBox.Controls.Add(this.ConditionLabel);
            this.SearchGroupBox.Controls.Add(this.OSLabel);
            this.SearchGroupBox.Controls.Add(this.OSComboBox);
            this.SearchGroupBox.Enabled = false;
            this.SearchGroupBox.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.SearchGroupBox.Location = new System.Drawing.Point(417, 51);
            this.SearchGroupBox.Name = "SearchGroupBox";
            this.SearchGroupBox.Size = new System.Drawing.Size(380, 255);
            this.SearchGroupBox.TabIndex = 20;
            this.SearchGroupBox.TabStop = false;
            this.SearchGroupBox.Text = "Пошук";
            // 
            // TransformGroupBox
            // 
            this.TransformGroupBox.Controls.Add(this.TransformButton);
            this.TransformGroupBox.Enabled = false;
            this.TransformGroupBox.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.TransformGroupBox.Location = new System.Drawing.Point(417, 397);
            this.TransformGroupBox.Name = "TransformGroupBox";
            this.TransformGroupBox.Size = new System.Drawing.Size(380, 52);
            this.TransformGroupBox.TabIndex = 21;
            this.TransformGroupBox.TabStop = false;
            this.TransformGroupBox.Text = "Конвертація";
            // 
            // Form1
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(800, 451);
            this.Controls.Add(this.TransformGroupBox);
            this.Controls.Add(this.SearchGroupBox);
            this.Controls.Add(this.TextOutput);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.AlgoGroupBox);
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(818, 498);
            this.MinimumSize = new System.Drawing.Size(818, 498);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "XMLSearch";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.AlgoGroupBox.ResumeLayout(false);
            this.AlgoGroupBox.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.SearchGroupBox.ResumeLayout(false);
            this.SearchGroupBox.PerformLayout();
            this.TransformGroupBox.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox TextOutput;
        private System.Windows.Forms.ComboBox ManufacturerComboBox;
        private System.Windows.Forms.ComboBox ConditionComboBox;
        private System.Windows.Forms.ComboBox OSComboBox;
        private System.Windows.Forms.Label ManufacturerLabel;
        private System.Windows.Forms.Label PriceLabel;
        private System.Windows.Forms.Label ConditionLabel;
        private System.Windows.Forms.Label OSLabel;
        private System.Windows.Forms.TextBox PriceTextBox;
        private System.Windows.Forms.RadioButton DomRadioButton;
        private System.Windows.Forms.RadioButton SaxRadioButton;
        private System.Windows.Forms.RadioButton LinqRadioButton;
        private System.Windows.Forms.Button TransformButton;
        private System.Windows.Forms.Button ClearSearchButton;
        private System.Windows.Forms.GroupBox AlgoGroupBox;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem FileStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem OpenToolStripMenuItem;
        private System.Windows.Forms.GroupBox SearchGroupBox;
        private System.Windows.Forms.GroupBox TransformGroupBox;
    }
}

