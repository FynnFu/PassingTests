using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;



namespace PassingTests
{
    public partial class StartForm : Form
    {
        public static OpenFileDialog openFileDialog = null;

        public StartForm()
        {
            InitializeComponent();
            if (openFileDialog != null)
            {
                if (openFileDialog.FileName != "")
                {
                    textBox1.Text = openFileDialog.FileName;
                    PreviewText.Text = File.ReadAllText(openFileDialog.FileName);
                }
            }
        }

        private void OpenButton_Click(object sender, EventArgs e)
        {
            openFileDialog = new OpenFileDialog
            {
                InitialDirectory = @"C:\Users\Rashid\Downloads",
                Title = "Browse Text Files",

                CheckFileExists = true,
                CheckPathExists = true,

                DefaultExt = "txt",
                Filter = "txt files (*.txt)|*.txt",
                FilterIndex = 2,
                RestoreDirectory = true,

                ReadOnlyChecked = true,
                ShowReadOnly = true
            };

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                textBox1.Text = openFileDialog.FileName;
                PreviewText.Text = File.ReadAllText(openFileDialog.FileName);
            }
        }

        private void StartTestButton_Click(object sender, EventArgs e)
        {
            if(openFileDialog!=null)
            {
                if (openFileDialog.FileName != "")
                {
                    this.Hide();
                    TestForm form2 = new TestForm();
                    form2.Visible = true;
                }
            }
        }
        private void StartForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Process[] chromeInstances = Process.GetProcessesByName("PassingTests");
            foreach (Process p in chromeInstances)
                p.Kill();
        }
    }
}
