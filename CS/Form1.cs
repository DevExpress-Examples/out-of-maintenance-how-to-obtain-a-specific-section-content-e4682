using System;
using System.Windows.Forms;
using DevExpress.XtraRichEdit;
using DevExpress.XtraRichEdit.Utils;
using DevExpress.XtraRichEdit.API.Native;

namespace RichEditSectionContent {
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();

            string path = System.IO.Directory.GetCurrentDirectory() + @"\..\..\Template.rtf";
            
            richEditControl1.LoadDocument(path);
        }

        private void button1_Click(object sender, EventArgs e) {
            Document document = richEditControl1.Document;

            Section currentSection = document.GetSection(document.CaretPosition);
            Paragraph currentParagraph = document.Paragraphs.Get(document.CaretPosition);
            
            for (int i = 0; i < document.Sections.Count; i++) {
                if (document.Sections[i].Equals(currentSection)){
                    MessageBox.Show("Current Section Index: " + (i + 1).ToString());
                    break;
                }
            }

            for (int i = 0; i < currentSection.Paragraphs.Count; i++) {
                if (currentSection.Paragraphs[i].Equals(currentParagraph)) {
                    MessageBox.Show("Current Paragraph In Section Index: " + (i + 1).ToString());
                    break;
                }
            }

            DocumentPosition currentSectionStart = currentSection.Paragraphs[0].Range.Start;
            DocumentPosition currentSectionEnd = currentSection.Paragraphs[currentSection.Paragraphs.Count - 1].Range.End;

            string currentSetionText = document.GetText(
                document.CreateRange(currentSectionStart, currentSectionEnd.ToInt() - currentSectionStart.ToInt()));

            MessageBox.Show("Current Setion Text (PlainText Format):\r\n" + currentSetionText);
        }
    }
}