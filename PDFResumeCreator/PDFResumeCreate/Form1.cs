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
            Paragraph position = new Paragraph(textBoxPosition.Text, FontFactory.GetFont("Arial", 12));
            Paragraph email = new Paragraph(textBoxEmail.Text, FontFactory.GetFont("Arial", 8));
            Paragraph phone = new Paragraph(textBoxPhone.Text, FontFactory.GetFont("Arial", 8));
            Paragraph url = new Paragraph(textBoxURL.Text, FontFactory.GetFont("Arial", 8));
            Paragraph address = new Paragraph(textBoxUBL.Text + "," + textBoxStreet.Text + "," + textBoxBarangay.Text + "," +
                                              textBoxZipCode.Text + "," + textBoxCity.Text + "," + textBoxProvince.Text + "," +
                                              textBoxRegion.Text, FontFactory.GetFont("Arial", 8));
            Paragraph workexperience = new Paragraph(labelWorkExperience.Text, FontFactory.GetFont("Arial", 15));
            Paragraph workexperience1work = new Paragraph(textBoxWorkExperience1.Text, FontFactory.GetFont("Arial", 12));
            Paragraph workexperience1date = new Paragraph(textBoxWorkExperience1Date.Text, FontFactory.GetFont("Arial", 10));
            Paragraph workexperience1description = new Paragraph(textBoxWorkExperience1Description.Text, FontFactory.GetFont("Arial", 8));
            Paragraph workexperience2work = new Paragraph(textBoxWorkExperience2.Text, FontFactory.GetFont("Arial", 12));
            Paragraph workexperience2date = new Paragraph(textBoxWorkExperience2Date.Text, FontFactory.GetFont("Arial", 10));
            Paragraph workexperience2description = new Paragraph(textBoxWorkExperience2Description.Text, FontFactory.GetFont("Arial", 8));
            Paragraph education = new Paragraph(labelEducation.Text, FontFactory.GetFont("Arial", 15));
            Paragraph tertiaryeducationlabel = new Paragraph(labelTertiaryEducation.Text, FontFactory.GetFont("Arial", 12));
            Paragraph tertiaryeducation = new Paragraph(textBoxTertiaryEducation.Text, FontFactory.GetFont("Arial", 10));
            Paragraph course = new Paragraph(textBoxCourse.Text, FontFactory.GetFont("Arial", 8));
            Paragraph secondaryeducationlabel = new Paragraph(labelSecondaryEducation.Text, FontFactory.GetFont("Arial", 12));
            Paragraph secondaryeducation = new Paragraph(textBoxSecondaryEducation.Text, FontFactory.GetFont("Arial", 10));
            Paragraph track = new Paragraph(textBoxTrack.Text, FontFactory.GetFont("Arial", 8));
            Paragraph primaryeducationlabel = new Paragraph(labelPrimaryEducation.Text, FontFactory.GetFont("Arial", 12));
            Paragraph primaryeducation = new Paragraph(textBoxPrimaryEducation.Text, FontFactory.GetFont("Arial", 10));
            MessageBox.Show("PDF Resume Created!");
            docx.Add(separator);
            docx.Add(name);
            docx.Add(position);
            docx.Add(email);
            docx.Add(phone);
            docx.Add(url);
            docx.Add(address);
            docx.Add(separator);
            docx.Add(workexperience);
            docx.Add(workexperience1work);
            docx.Add(workexperience1date);
            docx.Add(workexperience1description);
            docx.Add(workexperience2work);
            docx.Add(workexperience2date);
            docx.Add(workexperience2description);
            docx.Add(separator);
            docx.Add(education);
            docx.Add(tertiaryeducationlabel);
            docx.Add(tertiaryeducation);
            docx.Add(course);
            docx.Add(secondaryeducationlabel);
            docx.Add(secondaryeducation);
            docx.Add(track);
            docx.Add(primaryeducationlabel);
            docx.Add(primaryeducation);
            docx.Add(separator);
            docx.Close();
        }
    }
}
