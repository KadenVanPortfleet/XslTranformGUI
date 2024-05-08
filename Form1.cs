namespace XslTransformGUI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void selectXSLButton_Click(object sender, EventArgs e)
        {
            openFileDialog1.InitialDirectory = $"";
            openFileDialog1.Filter = "XML or XSL Files|*.xml;*.xsl";
            openFileDialog1.FilterIndex = 0;
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                xslPathTxtBox.Text = openFileDialog1.FileName;
            }
        }

        private void selectXmlButton_Click(object sender, EventArgs e)
        {
            openFileDialog1.InitialDirectory = $"";
            openFileDialog1.Filter = "XML or XSL Files|*.xml;*.xsl";
            openFileDialog1.FilterIndex = 0;
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                xmlPathTxtBox.Text = openFileDialog1.FileName;
            }
        }

        private void runTransformButton_Click(object sender, EventArgs e)
        {
            Thread newEditorSession = new Thread(delegate ()
            {
                XSLTransform.RunXslTransform(xslPathTxtBox.Text, xmlPathTxtBox.Text);
            });
            newEditorSession.Start();
        }

        private void infoButton_Click(object sender, EventArgs e)
        {
            InfoForm infoForm = new InfoForm();
            infoForm.Show();
        }
    }
}
