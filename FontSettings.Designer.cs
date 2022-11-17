namespace Notepad
{
    partial class FontSettings
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FontSettings));
            this.ExampleLable = new System.Windows.Forms.Label();
            this.ExampleText = new System.Windows.Forms.Label();
            this.fontBox = new System.Windows.Forms.ComboBox();
            this.styleBox = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // ExampleLable
            // 
            this.ExampleLable.AutoSize = true;
            this.ExampleLable.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold);
            this.ExampleLable.Location = new System.Drawing.Point(12, 176);
            this.ExampleLable.Name = "ExampleLable";
            this.ExampleLable.Size = new System.Drawing.Size(80, 23);
            this.ExampleLable.TabIndex = 0;
            this.ExampleLable.Text = "Образец";
            // 
            // ExampleText
            // 
            this.ExampleText.AutoSize = true;
            this.ExampleText.Font = new System.Drawing.Font("Microsoft Sans Serif", 28.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ExampleText.Location = new System.Drawing.Point(77, 30);
            this.ExampleText.Name = "ExampleText";
            this.ExampleText.Size = new System.Drawing.Size(245, 54);
            this.ExampleText.TabIndex = 1;
            this.ExampleText.Text = "AaBbYyZz";
            this.ExampleText.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // fontBox
            // 
            this.fontBox.FormattingEnabled = true;
            this.fontBox.Items.AddRange(new object[] {
            "8",
            "9",
            "10",
            "11",
            "12",
            "14",
            "16",
            "18",
            "20",
            "22",
            "24",
            "26",
            "28",
            "30",
            "32"});
            this.fontBox.Location = new System.Drawing.Point(16, 89);
            this.fontBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.fontBox.Name = "fontBox";
            this.fontBox.Size = new System.Drawing.Size(151, 31);
            this.fontBox.TabIndex = 3;
            this.fontBox.SelectedValueChanged += new System.EventHandler(this.OnFontChanged);
            // 
            // styleBox
            // 
            this.styleBox.FormattingEnabled = true;
            this.styleBox.Items.AddRange(new object[] {
            "обычный",
            "курсив",
            "полужирный",
            "подчеркнутый",
            "зачеркнутый"});
            this.styleBox.Location = new System.Drawing.Point(254, 89);
            this.styleBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.styleBox.Name = "styleBox";
            this.styleBox.Size = new System.Drawing.Size(151, 31);
            this.styleBox.TabIndex = 4;
            this.styleBox.SelectedValueChanged += new System.EventHandler(this.OnStyleChanged);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold);
            this.button1.Location = new System.Drawing.Point(122, 405);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(170, 52);
            this.button1.TabIndex = 5;
            this.button1.Text = "ОК";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(14, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 23);
            this.label1.TabIndex = 6;
            this.label1.Text = "Размер:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(250, 45);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(110, 23);
            this.label2.TabIndex = 7;
            this.label2.Text = "Начертание:";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Window;
            this.panel1.Controls.Add(this.ExampleText);
            this.panel1.Location = new System.Drawing.Point(16, 221);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(389, 109);
            this.panel1.TabIndex = 8;
            // 
            // FontSettings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(422, 480);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.ExampleLable);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.styleBox);
            this.Controls.Add(this.fontBox);
            this.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "FontSettings";
            this.Text = "Шрифт";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label ExampleLable;
        private System.Windows.Forms.Label ExampleText;
        private System.Windows.Forms.ComboBox fontBox;
        private System.Windows.Forms.ComboBox styleBox;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel1;
    }
}