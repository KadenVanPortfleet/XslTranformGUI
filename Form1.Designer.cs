namespace XslTransformGUI
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
            openFileDialog1 = new OpenFileDialog();
            LayoutLabel = new Label();
            xslPathTxtBox = new TextBox();
            xmlPathTxtBox = new TextBox();
            label2 = new Label();
            runTransformButton = new Button();
            selectXSLButton = new Button();
            selectXmlButton = new Button();
            infoButton = new Button();
            SuspendLayout();
            // 
            // openFileDialog1
            // 
            openFileDialog1.FileName = "openFileDialog1";
            // 
            // LayoutLabel
            // 
            LayoutLabel.Location = new Point(12, 9);
            LayoutLabel.Name = "LayoutLabel";
            LayoutLabel.Size = new Size(235, 23);
            LayoutLabel.TabIndex = 2;
            LayoutLabel.Text = "Layout XSL Path:";
            LayoutLabel.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // xslPathTxtBox
            // 
            xslPathTxtBox.Location = new Point(12, 35);
            xslPathTxtBox.Name = "xslPathTxtBox";
            xslPathTxtBox.Size = new Size(360, 23);
            xslPathTxtBox.TabIndex = 1;
            // 
            // xmlPathTxtBox
            // 
            xmlPathTxtBox.Location = new Point(12, 87);
            xmlPathTxtBox.Name = "xmlPathTxtBox";
            xmlPathTxtBox.Size = new Size(360, 23);
            xmlPathTxtBox.TabIndex = 5;
            // 
            // label2
            // 
            label2.Location = new Point(12, 61);
            label2.Name = "label2";
            label2.Size = new Size(235, 23);
            label2.TabIndex = 6;
            label2.Text = "Results XML Path:";
            label2.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // runTransformButton
            // 
            runTransformButton.Location = new Point(12, 116);
            runTransformButton.Name = "runTransformButton";
            runTransformButton.Size = new Size(360, 91);
            runTransformButton.TabIndex = 8;
            runTransformButton.Text = "Run Transformation Utility";
            runTransformButton.UseVisualStyleBackColor = true;
            runTransformButton.Click += runTransformButton_Click;
            // 
            // selectXSLButton
            // 
            selectXSLButton.Location = new Point(297, 9);
            selectXSLButton.Name = "selectXSLButton";
            selectXSLButton.Size = new Size(75, 23);
            selectXSLButton.TabIndex = 9;
            selectXSLButton.Text = "Select";
            selectXSLButton.UseVisualStyleBackColor = true;
            selectXSLButton.Click += selectXSLButton_Click;
            // 
            // selectXmlButton
            // 
            selectXmlButton.Location = new Point(297, 61);
            selectXmlButton.Name = "selectXmlButton";
            selectXmlButton.Size = new Size(75, 23);
            selectXmlButton.TabIndex = 10;
            selectXmlButton.Text = "Select";
            selectXmlButton.UseVisualStyleBackColor = true;
            selectXmlButton.Click += selectXmlButton_Click;
            // 
            // infoButton
            // 
            infoButton.Location = new Point(12, 213);
            infoButton.Name = "infoButton";
            infoButton.Size = new Size(360, 36);
            infoButton.TabIndex = 11;
            infoButton.Text = "How To Use";
            infoButton.UseVisualStyleBackColor = true;
            infoButton.Click += infoButton_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(384, 261);
            Controls.Add(infoButton);
            Controls.Add(selectXmlButton);
            Controls.Add(selectXSLButton);
            Controls.Add(runTransformButton);
            Controls.Add(xmlPathTxtBox);
            Controls.Add(label2);
            Controls.Add(xslPathTxtBox);
            Controls.Add(LayoutLabel);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximumSize = new Size(400, 300);
            MinimumSize = new Size(400, 300);
            Name = "Form1";
            Text = "Kaden's XSL Transform GUI Utility";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private OpenFileDialog openFileDialog1;
        private Label LayoutLabel;
        private TextBox xslPathTxtBox;
        private TextBox xmlPathTxtBox;
        private Label label2;
        private Button runTransformButton;
        private Button selectXSLButton;
        private Button selectXmlButton;
        private Button infoButton;
    }
}
