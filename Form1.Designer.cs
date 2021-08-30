
namespace FormsApp
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.sourceTextBox = new System.Windows.Forms.TextBox();
            this.browseButton = new System.Windows.Forms.Button();
            this.dataGroup = new System.Windows.Forms.GroupBox();
            this.suburbTextBox = new System.Windows.Forms.TextBox();
            this.addressTextBox = new System.Windows.Forms.TextBox();
            this.orgTextBox = new System.Windows.Forms.TextBox();
            this.contactTextBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.sourceGroup = new System.Windows.Forms.GroupBox();
            this.saveButton = new System.Windows.Forms.Button();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.pdfGroup = new System.Windows.Forms.GroupBox();
            this.companyGroup = new System.Windows.Forms.GroupBox();
            this.manualInputButton = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.companyComboBox = new System.Windows.Forms.ComboBox();
            this.techGroup = new System.Windows.Forms.GroupBox();
            this.addNewTech = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.techComboBox = new System.Windows.Forms.ComboBox();
            this.dataGroup.SuspendLayout();
            this.sourceGroup.SuspendLayout();
            this.pdfGroup.SuspendLayout();
            this.companyGroup.SuspendLayout();
            this.techGroup.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "Source:";
            // 
            // sourceTextBox
            // 
            this.sourceTextBox.Enabled = false;
            this.sourceTextBox.Location = new System.Drawing.Point(113, 41);
            this.sourceTextBox.Name = "sourceTextBox";
            this.sourceTextBox.Size = new System.Drawing.Size(604, 39);
            this.sourceTextBox.TabIndex = 1;
            // 
            // browseButton
            // 
            this.browseButton.Location = new System.Drawing.Point(723, 37);
            this.browseButton.Name = "browseButton";
            this.browseButton.Size = new System.Drawing.Size(46, 46);
            this.browseButton.TabIndex = 2;
            this.browseButton.Text = "...";
            this.browseButton.UseVisualStyleBackColor = true;
            this.browseButton.Click += new System.EventHandler(this.browseButton_Click);
            // 
            // dataGroup
            // 
            this.dataGroup.Controls.Add(this.suburbTextBox);
            this.dataGroup.Controls.Add(this.addressTextBox);
            this.dataGroup.Controls.Add(this.orgTextBox);
            this.dataGroup.Controls.Add(this.contactTextBox);
            this.dataGroup.Controls.Add(this.label5);
            this.dataGroup.Controls.Add(this.label4);
            this.dataGroup.Controls.Add(this.label3);
            this.dataGroup.Controls.Add(this.label2);
            this.dataGroup.Enabled = false;
            this.dataGroup.Location = new System.Drawing.Point(23, 320);
            this.dataGroup.Name = "dataGroup";
            this.dataGroup.Size = new System.Drawing.Size(794, 345);
            this.dataGroup.TabIndex = 3;
            this.dataGroup.TabStop = false;
            this.dataGroup.Text = "Data to insert";
            // 
            // suburbTextBox
            // 
            this.suburbTextBox.Location = new System.Drawing.Point(176, 276);
            this.suburbTextBox.Name = "suburbTextBox";
            this.suburbTextBox.Size = new System.Drawing.Size(593, 39);
            this.suburbTextBox.TabIndex = 7;
            // 
            // addressTextBox
            // 
            this.addressTextBox.Location = new System.Drawing.Point(176, 205);
            this.addressTextBox.Name = "addressTextBox";
            this.addressTextBox.Size = new System.Drawing.Size(593, 39);
            this.addressTextBox.TabIndex = 6;
            // 
            // orgTextBox
            // 
            this.orgTextBox.Location = new System.Drawing.Point(176, 135);
            this.orgTextBox.Name = "orgTextBox";
            this.orgTextBox.Size = new System.Drawing.Size(593, 39);
            this.orgTextBox.TabIndex = 5;
            // 
            // contactTextBox
            // 
            this.contactTextBox.Location = new System.Drawing.Point(176, 65);
            this.contactTextBox.Name = "contactTextBox";
            this.contactTextBox.Size = new System.Drawing.Size(593, 39);
            this.contactTextBox.TabIndex = 4;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(15, 283);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(91, 32);
            this.label5.TabIndex = 3;
            this.label5.Text = "Suburb";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(15, 208);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(98, 32);
            this.label4.TabIndex = 2;
            this.label4.Text = "Address";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(15, 138);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(155, 32);
            this.label3.TabIndex = 1;
            this.label3.Text = "Organisation:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 68);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(101, 32);
            this.label2.TabIndex = 0;
            this.label2.Text = "Contact:";
            // 
            // sourceGroup
            // 
            this.sourceGroup.Controls.Add(this.label1);
            this.sourceGroup.Controls.Add(this.browseButton);
            this.sourceGroup.Controls.Add(this.sourceTextBox);
            this.sourceGroup.Location = new System.Drawing.Point(23, 38);
            this.sourceGroup.Name = "sourceGroup";
            this.sourceGroup.Size = new System.Drawing.Size(794, 112);
            this.sourceGroup.TabIndex = 4;
            this.sourceGroup.TabStop = false;
            // 
            // saveButton
            // 
            this.saveButton.Location = new System.Drawing.Point(642, 689);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(150, 46);
            this.saveButton.TabIndex = 5;
            this.saveButton.Text = "Save";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // pdfGroup
            // 
            this.pdfGroup.Controls.Add(this.companyGroup);
            this.pdfGroup.Controls.Add(this.saveButton);
            this.pdfGroup.Controls.Add(this.sourceGroup);
            this.pdfGroup.Controls.Add(this.dataGroup);
            this.pdfGroup.Enabled = false;
            this.pdfGroup.Location = new System.Drawing.Point(35, 168);
            this.pdfGroup.Name = "pdfGroup";
            this.pdfGroup.Size = new System.Drawing.Size(842, 761);
            this.pdfGroup.TabIndex = 6;
            this.pdfGroup.TabStop = false;
            this.pdfGroup.Text = "PDF";
            // 
            // companyGroup
            // 
            this.companyGroup.Controls.Add(this.manualInputButton);
            this.companyGroup.Controls.Add(this.label7);
            this.companyGroup.Controls.Add(this.companyComboBox);
            this.companyGroup.Enabled = false;
            this.companyGroup.Location = new System.Drawing.Point(28, 164);
            this.companyGroup.Name = "companyGroup";
            this.companyGroup.Size = new System.Drawing.Size(789, 150);
            this.companyGroup.TabIndex = 6;
            this.companyGroup.TabStop = false;
            this.companyGroup.Text = "Company Data";
            this.companyGroup.EnabledChanged += new System.EventHandler(this.companyGroup_EnabledChanged);
            // 
            // manualInputButton
            // 
            this.manualInputButton.Location = new System.Drawing.Point(398, 58);
            this.manualInputButton.Name = "manualInputButton";
            this.manualInputButton.Size = new System.Drawing.Size(201, 46);
            this.manualInputButton.TabIndex = 3;
            this.manualInputButton.Text = "Input Manually";
            this.manualInputButton.UseVisualStyleBackColor = true;
            this.manualInputButton.Click += new System.EventHandler(this.manualInputButton_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(335, 65);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(46, 32);
            this.label7.TabIndex = 2;
            this.label7.Text = "OR";
            // 
            // companyComboBox
            // 
            this.companyComboBox.FormattingEnabled = true;
            this.companyComboBox.Location = new System.Drawing.Point(33, 62);
            this.companyComboBox.Name = "companyComboBox";
            this.companyComboBox.Size = new System.Drawing.Size(281, 40);
            this.companyComboBox.TabIndex = 0;
            this.companyComboBox.Text = "Choose...";
            this.companyComboBox.SelectedIndexChanged += new System.EventHandler(this.companyComboBox_SelectedIndexChanged);
            // 
            // techGroup
            // 
            this.techGroup.Controls.Add(this.addNewTech);
            this.techGroup.Controls.Add(this.label6);
            this.techGroup.Controls.Add(this.techComboBox);
            this.techGroup.Enabled = false;
            this.techGroup.Location = new System.Drawing.Point(35, 12);
            this.techGroup.Name = "techGroup";
            this.techGroup.Size = new System.Drawing.Size(842, 150);
            this.techGroup.TabIndex = 7;
            this.techGroup.TabStop = false;
            this.techGroup.Text = "Technician Data";
            // 
            // addNewTech
            // 
            this.addNewTech.Location = new System.Drawing.Point(384, 58);
            this.addNewTech.Name = "addNewTech";
            this.addNewTech.Size = new System.Drawing.Size(150, 46);
            this.addNewTech.TabIndex = 2;
            this.addNewTech.Text = "Add New";
            this.addNewTech.UseVisualStyleBackColor = true;
            this.addNewTech.Click += new System.EventHandler(this.addNewTech_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(318, 65);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(46, 32);
            this.label6.TabIndex = 1;
            this.label6.Text = "OR";
            // 
            // techComboBox
            // 
            this.techComboBox.FormattingEnabled = true;
            this.techComboBox.Location = new System.Drawing.Point(28, 62);
            this.techComboBox.Name = "techComboBox";
            this.techComboBox.Size = new System.Drawing.Size(271, 40);
            this.techComboBox.TabIndex = 0;
            this.techComboBox.Text = "Choose...";
            this.techComboBox.SelectedIndexChanged += new System.EventHandler(this.techComboBox_SelectedIndexChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 32F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(907, 954);
            this.Controls.Add(this.techGroup);
            this.Controls.Add(this.pdfGroup);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.dataGroup.ResumeLayout(false);
            this.dataGroup.PerformLayout();
            this.sourceGroup.ResumeLayout(false);
            this.sourceGroup.PerformLayout();
            this.pdfGroup.ResumeLayout(false);
            this.companyGroup.ResumeLayout(false);
            this.companyGroup.PerformLayout();
            this.techGroup.ResumeLayout(false);
            this.techGroup.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox sourceTextBox;
        private System.Windows.Forms.Button browseButton;
        private System.Windows.Forms.GroupBox dataGroup;
        private System.Windows.Forms.GroupBox sourceGroup;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.TextBox suburbTextBox;
        private System.Windows.Forms.TextBox addressTextBox;
        private System.Windows.Forms.TextBox orgTextBox;
        private System.Windows.Forms.TextBox contactTextBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.GroupBox pdfGroup;
        private System.Windows.Forms.GroupBox techGroup;
        private System.Windows.Forms.ComboBox techComboBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button addNewTech;
        private System.Windows.Forms.GroupBox companyGroup;
        private System.Windows.Forms.ComboBox companyComboBox;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button manualInputButton;
    }
}

