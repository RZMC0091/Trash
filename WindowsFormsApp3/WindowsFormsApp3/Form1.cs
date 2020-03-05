using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MetroFramework.Components;
using System.Diagnostics;
using System.IO;

namespace WindowsFormsApp3
{
    public partial class Form1 : MetroFramework.Forms.MetroForm
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            MetroStyleManager MetroStyleManager1 = null;
            this.StyleManager = MetroStyleManager1;
            treeView1.Nodes.Clear();
            string[] allfiles = Directory.GetFiles(metroTextBox1.Text);
            string[] allfolders = Directory.GetDirectories(metroTextBox1.Text);
            foreach (string filename in allfiles)
            {
                treeView1.Nodes.Add(filename);
            }
            foreach (string folder in allfolders)
            {
                treeView1.Nodes.Add(folder);
            }
        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            treeView1.Nodes.Clear();
            string[] allfiles = Directory.GetFiles(metroTextBox1.Text);
            string[] allfolders = Directory.GetDirectories(metroTextBox1.Text);
            foreach (string filename in allfiles)
            {
                treeView1.Nodes.Add(filename);
            }
            foreach (string folder in allfolders)
            {
                treeView1.Nodes.Add(folder);
            }
        }

        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {
            metroTextBox1.Text = treeView1.SelectedNode.Text.ToString();
            treeView1.Nodes.Clear();
            string[] allfiles = Directory.GetFiles(metroTextBox1.Text);
            string[] allfolders = Directory.GetDirectories(metroTextBox1.Text);
            foreach (string filename in allfiles)
            {
                treeView1.Nodes.Add(filename);
            }
            foreach (string folder in allfolders)
            {
                treeView1.Nodes.Add(folder);
            }
        }

        private void metroTextBox1_Click(object sender, EventArgs e)
        {
            
        }

        private void metroButton2_Click(object sender, EventArgs e)
        {
            metroTextBox1.Text = treeView1.SelectedNode.Text.ToString();
        }

        private void metroButton3_Click(object sender, EventArgs e)
        {
            string b = "C:/";
            metroTextBox1.Text = b;
            treeView1.Nodes.Clear();
            string[] allfiles = Directory.GetFiles(metroTextBox1.Text);
            string[] allfolders = Directory.GetDirectories(metroTextBox1.Text);
            foreach (string filename in allfiles)
            {
                treeView1.Nodes.Add(filename);
            }
            foreach (string folder in allfolders)
            {
                treeView1.Nodes.Add(folder);
            }
        }

        private void metroButton2_Click_1(object sender, EventArgs e)
        {
            string b = "D:/";
            metroTextBox1.Text = b;
            treeView1.Nodes.Clear();
            string[] allfiles = Directory.GetFiles(metroTextBox1.Text);
            string[] allfolders = Directory.GetDirectories(metroTextBox1.Text);
            foreach (string filename in allfiles)
            {
                treeView1.Nodes.Add(filename);
            }
            foreach (string folder in allfolders)
            {
                treeView1.Nodes.Add(folder);
            }
        }
    }
}
