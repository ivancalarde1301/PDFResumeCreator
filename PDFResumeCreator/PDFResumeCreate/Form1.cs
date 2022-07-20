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

namespace PDFResumeCreate
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
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

        private void buttonImportInformation_Click(object sender, EventArgs e)
        {
            var jsonFilePath = @"C:\Users\ivanc\source\repos\PDFResumeCreator\Resume.json";
            string jsonFileRead = File.ReadAllText(jsonFilePath);

            Resume convert = JsonConvert.DeserializeObject<Resume>(jsonFileRead);
            textBoxFirstName.Text = convert.FirstName;
            textBoxMiddleName.Text = convert.MiddleName;
            textBoxLastName.Text = convert.LastName;
            textBoxPosition.Text = convert.Position;
            textBoxEmail.Text = convert.Email;
            textBoxPhone.Text = convert.Phone;
            textBoxURL.Text = convert.URL;
            textBoxUBL.Text = convert.UBL;
            textBoxStreet.Text = convert.Street;
            textBoxBarangay.Text = convert.Barangay;
            textBoxZipCode.Text = convert.ZipCode;
            textBoxCity.Text = convert.City;
            textBoxProvince.Text = convert.Province;
            textBoxRegion.Text = convert.Region;
            textBoxWorkExperience1.Text = convert.WorkExperience1Work;
            textBoxWorkExperience1Date.Text = convert.WorkExperience1Date;
            textBoxWorkExperience1Description.Text = convert.WorkExperience1Description;
            textBoxWorkExperience2.Text = convert.WorkExperience2Work;
            textBoxWorkExperience2Date.Text = convert.WorkExperience2Date;
            textBoxWorkExperience2Description.Text = convert.WorkExperience2Description;
            textBoxTertiaryEducation.Text = convert.TertiaryEducation;
            textBoxCourse.Text = convert.Course;
            textBoxSecondaryEducation.Text = convert.SecondaryEducation;
            textBoxTrack.Text = convert.Track;
            textBoxPrimaryEducation.Text = convert.PrimaryEducation;
        }

        private void buttonCreateResume_Click(object sender, EventArgs e)
        {
            Document docx = new Document();
            PdfWriter.GetInstance(docx, new FileStream(@"C:\Users\ivanc\Downloads\Resume.pdf", FileMode.Create));
            docx.Open();
            Chunk separator = new Chunk("_____________________________________________________________________");
            Paragraph name = new Paragraph(textBoxFirstName.Text + " " + textBoxMiddleName.Text + " " + textBoxLastName.Text, FontFactory.GetFont("Arial", 25));
            Paragraph pos = new Paragraph(textBoxPosition.Text, FontFactory.GetFont("Arial", 15));
            MessageBox.Show("PDF Resume Created!");
            docx.Add(separator);
            docx.Add(name);
            docx.Add(pos);
            docx.Close();
        }
    }
}
