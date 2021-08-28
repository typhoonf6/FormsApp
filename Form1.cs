using iText.Forms;
using iText.Kernel.Pdf;
using System;
using System.IO;
using System.Windows.Forms;

namespace FormsApp
{
    public partial class Form1 : Form
    {
        /// <summary>
        /// Defualt Constructor
        /// </summary>
        public Form1()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Runs when the save button is pressed
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void saveButton_Click(object sender, EventArgs e)
        {
            try
            {
                // Create a document to write to
                using var pdf = new PdfDocument(
                    new PdfReader(sourceTextBox.Text),
                    new PdfWriter(Path.GetDirectoryName(sourceTextBox.Text) + "\\test-modified.pdf"));

                var form = PdfAcroForm.GetAcroForm(pdf, false);

                // Set the values in the form
                form.GetField("Text1.0").SetValue(contactTextBox.Text);
                form.GetField("Text1.1").SetValue(orgTextBox.Text);
                form.GetField("Text1.2").SetValue(addressTextBox.Text);
                form.GetField("Text1.3").SetValue(suburbTextBox.Text);

                // Save the pdf
                pdf.Close();

                ResetUI();
                MessageBox.Show("File Saved Successfully!");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        /// <summary>
        /// Runs when the browse button is clicked
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void browseButton_Click(object sender, EventArgs e)
        {
            // Show open file dialog
            var dResult = openFileDialog.ShowDialog();

            // If ok is NOT selected, stop running this method
            if (dResult != DialogResult.OK)
                return;

            try
            {
                // Set Text box text as file path
                sourceTextBox.Text = openFileDialog.FileName;

                // Open the document
                using var pdf = new PdfDocument(new PdfReader(sourceTextBox.Text));
                var form = PdfAcroForm.GetAcroForm(pdf, false);

                // Add data from form to the text boxes
                contactTextBox.Text = form.GetField("Text1.0").GetValueAsString();
                orgTextBox.Text = form.GetField("Text1.1").GetValueAsString();
                addressTextBox.Text = form.GetField("Text1.2").GetValueAsString();
                suburbTextBox.Text = form.GetField("Text1.3").GetValueAsString();

                // Enable the text boxes for editing
                contactTextBox.Enabled = true;
                orgTextBox.Enabled = true;
                addressTextBox.Enabled = true;
                suburbTextBox.Enabled = true;

                saveButton.Enabled = true;
            }
            catch (Exception ex)
            {
                sourceTextBox.Text = "";
                MessageBox.Show(ex.Message);
            }
        }

        /// <summary>
        /// Resets all values in the UI to default
        /// </summary>
        private void ResetUI()
        {
            contactTextBox.Text = "";
            contactTextBox.Enabled = false;

            orgTextBox.Text = "";
            orgTextBox.Enabled = false;

            addressTextBox.Text = "";
            addressTextBox.Enabled = false;

            suburbTextBox.Text = "";
            suburbTextBox.Enabled = false;

            sourceTextBox.Text = "";

            saveButton.Enabled = false;
        }
    }
}
