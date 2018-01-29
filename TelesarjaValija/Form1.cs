using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.IO;
using System.Linq;
using ListIsNullOrEmpty;

namespace TelesarjaValija
{
    public partial class TelesarjaValija : Form
    {
        public List<string> path { get; set; }
        static Random rnd = new Random();

        public TelesarjaValija()
        {
            InitializeComponent();

            if (File.Exists("Directory.txt"))
            {
                path = Directory.GetDirectories(File.ReadAllText("Directory.txt")).ToList();
            }
        }

        private void directoryBtn_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog fbd = new FolderBrowserDialog();
            if (fbd.ShowDialog() == DialogResult.OK)
            {
                path = Directory.GetDirectories(fbd.SelectedPath).ToList();
                File.WriteAllText("Directory.txt", fbd.SelectedPath);
            }
        }

        private void otsustaBtn_Click(object sender, EventArgs e)
        {
            if (!Try.IsNullOrEmpty(path))
            {
                int r = rnd.Next(path.Count);
                label1.Text = "Sina vaatad täna: " + Path.GetFileName((string)path[r]);
            }
            else
            {
                MessageBox.Show("Vali palun path");
            }
        }
    }
}
