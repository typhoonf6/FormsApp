using iText.Forms;
using iText.Kernel.Pdf;
using System;
using System.IO;
using System.Windows.Forms;

namespace FormsApp
{
    public partial class Form1 : Form
    {

        #region Constructor

        /// <summary>
        /// Default Constructor
        /// </summary>
        public Form1()
        {
            InitializeComponent();

        }

        #endregion

        #region Button Handlers

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

                // Reset all the text boxes
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

                companyGroup.Enabled = true;
            }
            catch (Exception ex)
            {
                sourceTextBox.Text = "";
                MessageBox.Show(ex.Message);
            }
        }

        /// <summary>
        /// Show a form to enter a new user
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void addNewTech_Click(object sender, EventArgs e)
        {
            MessageBox.Show("This Button Does Nothing!");
        }

        /// <summary>
        /// Enables the data entry text boxes for manual input
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void manualInputButton_Click(object sender, EventArgs e)
        {
            dataGroup.Enabled = true;
        }

        #endregion

        #region Other Event Handlers

        /// <summary>
        /// Sets the selectedTech when the selection is changed on the combobox
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void techComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            var comboBox = sender as ComboBox;
            selectedTech = comboBox.SelectedItem as Tech;
            pdfGroup.Enabled = true;
        }

        /// <summary>
        /// Loads tech data as the form loads
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private async void Form1_Load(object sender, EventArgs e)
        {
            techComboBox.DisplayMember = "Name";
            techComboBox.DataSource = await DatabaseHelper.GetTechsAsync();
            techGroup.Enabled = true;
        }

        /// <summary>
        /// Loads the company data when the group is enabled
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private async void companyGroup_EnabledChanged(object sender, EventArgs e)
        {
            var groupBox = sender as GroupBox;
            if (groupBox.Enabled == true)
            {
                companyComboBox.DisplayMember = "CompanyName";
                companyComboBox.DataSource = await DatabaseHelper.GetCompaniesAsync();
            }
        }

        /// <summary>
        /// Changes datacontext when the company is changed
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void companyComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            var comboBox = sender as ComboBox;
            if (comboBox.SelectedItem == null)
                return;

            var company = comboBox.SelectedItem as Company;

            contactTextBox.Text = company.ContactName;
            orgTextBox.Text = company.CompanyName;
            addressTextBox.Text = company.Address;
            suburbTextBox.Text = company.Suburb;
        }

        #endregion

        #region Methods

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

        #endregion

    }
}
