using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Text;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CreatingTextFile
{
    public partial class FrmLab1 : Form
    {
        public FrmLab1()
        {
            InitializeComponent();
        }

        private void FrmLab1_Load(object sender, EventArgs e)
        {

        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            FrmFileName frmFile = new FrmFileName();
            frmFile.ShowDialog();

            string getInput = txtInput.Text;

            string relativePath = @"..\..\MyProjects";

            string docPath = Path.GetFullPath(relativePath);

            using (StreamWriter outputFile = new StreamWriter(Path.Combine(docPath, FrmFileName.SetFileName)))
            {
                outputFile.WriteLine(getInput);
                Console.WriteLine(getInput);
            }

            MessageBox.Show($"File '{FrmFileName.SetFileName}' created in your Documents folder!");

        }

        private void linkLabel1_LinkClicked (object sender, LinkLabelLinkClickedEventArgs e)
        {
            FrmRegistration frm = new FrmRegistration();
            frm.ShowDialog();
        }
    }
    }

