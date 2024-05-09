namespace XslTransformGUI
{
    partial class InfoForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(InfoForm));
            infoBox = new TextBox();
            textBox1 = new TextBox();
            SuspendLayout();
            // 
            // infoBox
            // 
            infoBox.Location = new Point(12, 12);
            infoBox.Multiline = true;
            infoBox.Name = "infoBox";
            infoBox.ReadOnly = true;
            infoBox.Size = new Size(510, 112);
            infoBox.TabIndex = 1;
            infoBox.Text = resources.GetString("infoBox.Text");
            // 
            // textBox1
            // 
            textBox1.Location = new Point(12, 130);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.ReadOnly = true;
            textBox1.Size = new Size(510, 369);
            textBox1.TabIndex = 2;
            textBox1.Text = resources.GetString("textBox1.Text");
            // 
            // InfoForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(534, 511);
            Controls.Add(textBox1);
            Controls.Add(infoBox);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximumSize = new Size(550, 550);
            MinimumSize = new Size(550, 550);
            Name = "InfoForm";
            Text = "How To Use";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox infoBox;
        private TextBox textBox1;
    }
}