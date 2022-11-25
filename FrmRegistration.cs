using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
namespace FrmLab1
{
    public partial class FrmRegistration : Form
    {
        public FrmRegistration()
        {
            InitializeComponent();
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            string getStudentNo = txtStudentNo.Text;
            string getLastName = txtLastName.Text;
            string getAge = txtAge.Text;
            string getProgram = cbPrograms.Text;
            string getFirstname = txtFirstName.Text;
            string getMiddle = txtMiddleInitial.Text;
            string getBday = datePickerBirthday.Text;
            string getGender = cbGender.Text;
            string getContactNo = txtContactNo.Text;

            string docPath2 = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
        }

        private void datePickerBirthday_ValueChanged(object sender, EventArgs e)
        {

        }

        private void btnRegister_Click_1(object sender, EventArgs e)
        {
            FrmFileName fileNamee = new FrmFileName();
            fileNamee.ShowDialog();
            string getStudentNo = txtStudentNo.Text;
            string getLastName = txtLastName.Text;
            string getAge = txtAge.Text;
            string getProgram = cbPrograms.Text;
            string getFirstname = txtFirstName.Text;
            string getMiddle = txtMiddleInitial.Text;
            string getBday = datePickerBirthday.Text;
            string getGender = cbGender.Text;
            string getContactNo = txtContactNo.Text;

            string docPath =
            Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            using (StreamWriter outputFile = new StreamWriter(Path.Combine(docPath, FrmFileName.SetFileName)))
            {
                outputFile.WriteLine("Student Number.: " + getStudentNo);
                Console.WriteLine(getStudentNo);
                outputFile.WriteLine("Full Name: " + getLastName + ", " + getFirstname + " " + getMiddle);
                Console.WriteLine(getLastName, getFirstname, getMiddle);
                outputFile.WriteLine("Age.: " + getAge);
                Console.WriteLine(getAge);
                outputFile.WriteLine("Program: " + getProgram);
                Console.WriteLine(getProgram);
                outputFile.WriteLine("Birthday.: " + getBday);
                Console.WriteLine(getBday);
                outputFile.WriteLine("Gender.: " + getGender);
                Console.WriteLine(getGender);
                outputFile.WriteLine("Contact Number.: " + getContactNo);
                Console.WriteLine(getContactNo);
            }
        }
    }
}
