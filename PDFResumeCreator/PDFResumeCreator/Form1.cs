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
    public partial class ResumeCreator : Form
    {
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

        public class Resume
        {
            public string PersonalInformation { get; set; }
            public string CareerObjective { get; set; }
            public string WorkExperience { get; set; }
            public string Education { get; set; }
        }
    }

}