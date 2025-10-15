using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CreatingTextFile
{
    public partial class FrmRegistration : Form
    {
        public FrmRegistration()
        {
            InitializeComponent();
        }

        private void FrmRegistration_Load(object sender, EventArgs e)
        {

        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            string[] studentInfo =
            {
                "Student No: " + txtStudentNo.Text,
                "Last Name: "  + txtLastName.Text,
                "Program: " + cbProgram.Text,
                "Gender: " + cbGender.Text,
                "Age: " + txtAge.Text,
                "Birthday: " + dTPickerBday.Text,
                "Contact No: " + txtContactNo.Text,
            };

            string relativePath = @"..\..\MyProjects";
            string docPath = Path.GetFullPath(relativePath);
            string fileName = txtStudentNo.Text + ".txt";

            using (StreamWriter writer = new StreamWriter(Path.Combine(docPath, fileName)))
            {
                foreach (string line in studentInfo)
                {
                    writer.WriteLine(line);
                }

            }

            MessageBox.Show($"Registration saved!\nFile created: {fileName}", "Success");
           
        }
    }
}
