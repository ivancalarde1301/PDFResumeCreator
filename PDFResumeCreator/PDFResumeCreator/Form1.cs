using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using iTextSharp;
using iTextSharp.text;
using iTextSharp.text.pdf;

namespace ResumeCreator
{
    public class Resume
    {
        public string[] PersonalInformation { get; set; }
        public string[] Address { get; set; }
        public string CareerObjective { get; set; }
        public string[] WorkExperience { get; set; }
        public string Education { get; set; }
    }
    public partial class ResumeCreator : Form
    {
        public class Resume
        {
            public string FirstName { get; set; }
            public string MiddleName { get; set; }
            public string LastName { get; set; }
            public string Position { get; set; }
            public string Email { get; set; }
            public string Phone { get; set; }
            public string URL { get; set; }
            public string UBL { get; set; }
            public string Street { get; set; }
            public string Barangay { get; set; }
            public string ZipCode { get; set; }
            public string City { get; set; }
            public string Province { get; set; }
            public string Region { get; set; }
            public string CareerObjective { get; set; }
            public string WorkExperience1Work { get; set; }
            public string WorkExperience1Date { get; set; }
            public string WorkExperience1Description { get; set; }
            public string WorkExperience2Work { get; set; }
            public string WorkExperience2Date { get; set; }
            public string WorkExperience2Description { get; set; }
            public string TertiaryEducation { get; set; }
            public string Course { get; set; }
            public string SecondaryEducation { get; set; }
            public string Track { get; set; }
            public string PrimaryEducation { get; set; }
        }

        public ResumeCreator()
        {
            InitializeComponent();
        }

        private void buttonImportInformation_Click(object sender, EventArgs e)
        {
            var jsonFilePath = @"C:\Users\ivanc\source\repos\PDFResumeConverter\Resume.json";
            string jsonFileRead = File.ReadAllText(jsonFilePath);

            Resume c = JsonConvert.DeserializeObject<Resume>(jsonFileRead);
        }

        private void buttonCreateResume_Click(object sender, EventArgs e)
        {

        }
    }

}