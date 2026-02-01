namespace v1
{
    partial class mainScreen
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(mainScreen));
            newPatientGroupBox = new GroupBox();
            birthDateTextBox = new TextBox();
            addPatientButton = new Button();
            phoneNumberTextBox = new TextBox();
            genderComboBox = new ComboBox();
            bloodTypeComboBox = new ComboBox();
            nationalIdNumberTextBox = new TextBox();
            surnameTextBox = new TextBox();
            nameTextBox = new TextBox();
            groupBox2 = new GroupBox();
            updateUpdateButton = new Button();
            updateBirthDateTextBox = new TextBox();
            updatePhoneNumberTextBox = new TextBox();
            updateGenderComboBox = new ComboBox();
            updateBloodTypeComboBox = new ComboBox();
            updateNationalIdNumberTextBox = new TextBox();
            updateSurnameTextBox = new TextBox();
            updateNameTextBox = new TextBox();
            groupBox3 = new GroupBox();
            deleteDeleteButton = new Button();
            deleteFindButton = new Button();
            deleteNationalIdNumberTextBox = new TextBox();
            deleteSurnameTextBox = new TextBox();
            deleteNameTextBox = new TextBox();
            deletePatientIdTextBox = new TextBox();
            dataGridView1 = new DataGridView();
            pictureBox1 = new PictureBox();
            label1 = new Label();
            label2 = new Label();
            newPatientGroupBox.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // newPatientGroupBox
            // 
            newPatientGroupBox.BackColor = Color.DarkSlateGray;
            newPatientGroupBox.Controls.Add(birthDateTextBox);
            newPatientGroupBox.Controls.Add(addPatientButton);
            newPatientGroupBox.Controls.Add(phoneNumberTextBox);
            newPatientGroupBox.Controls.Add(genderComboBox);
            newPatientGroupBox.Controls.Add(bloodTypeComboBox);
            newPatientGroupBox.Controls.Add(nationalIdNumberTextBox);
            newPatientGroupBox.Controls.Add(surnameTextBox);
            newPatientGroupBox.Controls.Add(nameTextBox);
            newPatientGroupBox.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 162);
            newPatientGroupBox.ForeColor = Color.White;
            newPatientGroupBox.Location = new Point(12, 633);
            newPatientGroupBox.Name = "newPatientGroupBox";
            newPatientGroupBox.Size = new Size(352, 216);
            newPatientGroupBox.TabIndex = 0;
            newPatientGroupBox.TabStop = false;
            newPatientGroupBox.Text = "New Patient";
            // 
            // birthDateTextBox
            // 
            birthDateTextBox.Location = new Point(6, 169);
            birthDateTextBox.Name = "birthDateTextBox";
            birthDateTextBox.Size = new Size(159, 27);
            birthDateTextBox.TabIndex = 8;
            birthDateTextBox.Text = "Birth Date";
            birthDateTextBox.Click += birthDateTextBox_Click;
            // 
            // addPatientButton
            // 
            addPatientButton.BackColor = Color.DarkGreen;
            addPatientButton.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 162);
            addPatientButton.ForeColor = Color.White;
            addPatientButton.Location = new Point(187, 155);
            addPatientButton.Name = "addPatientButton";
            addPatientButton.Size = new Size(159, 55);
            addPatientButton.TabIndex = 7;
            addPatientButton.Text = "Add";
            addPatientButton.UseVisualStyleBackColor = false;
            addPatientButton.Click += addPatientButton_Click;
            // 
            // phoneNumberTextBox
            // 
            phoneNumberTextBox.Location = new Point(6, 122);
            phoneNumberTextBox.Name = "phoneNumberTextBox";
            phoneNumberTextBox.Size = new Size(159, 27);
            phoneNumberTextBox.TabIndex = 5;
            phoneNumberTextBox.Text = "Phone Number";
            phoneNumberTextBox.Click += phoneNumberTextBox_Click;
            // 
            // genderComboBox
            // 
            genderComboBox.FormattingEnabled = true;
            genderComboBox.Items.AddRange(new object[] { "Unknown", "Doesn’t appear", "Female", "Male" });
            genderComboBox.Location = new Point(187, 121);
            genderComboBox.Name = "genderComboBox";
            genderComboBox.Size = new Size(159, 28);
            genderComboBox.TabIndex = 4;
            genderComboBox.Text = "Gender";
            genderComboBox.Click += genderComboBox_Click;
            // 
            // bloodTypeComboBox
            // 
            bloodTypeComboBox.FormattingEnabled = true;
            bloodTypeComboBox.Items.AddRange(new object[] { "Unknown", "0 Rh -", "0 Rh +", "A Rh -", "A Rh +", "B Rh -", "B Rh +", "AB Rh -", "AB Rh +" });
            bloodTypeComboBox.Location = new Point(187, 72);
            bloodTypeComboBox.Name = "bloodTypeComboBox";
            bloodTypeComboBox.Size = new Size(159, 28);
            bloodTypeComboBox.TabIndex = 3;
            bloodTypeComboBox.Text = "Blood Type";
            bloodTypeComboBox.Click += bloodTypeComboBox_Click;
            // 
            // nationalIdNumberTextBox
            // 
            nationalIdNumberTextBox.Location = new Point(6, 72);
            nationalIdNumberTextBox.Name = "nationalIdNumberTextBox";
            nationalIdNumberTextBox.Size = new Size(159, 27);
            nationalIdNumberTextBox.TabIndex = 2;
            nationalIdNumberTextBox.Text = "National Id Number";
            nationalIdNumberTextBox.Click += nationalIdNumberTextBox_Click;
            // 
            // surnameTextBox
            // 
            surnameTextBox.Location = new Point(187, 26);
            surnameTextBox.Name = "surnameTextBox";
            surnameTextBox.Size = new Size(159, 27);
            surnameTextBox.TabIndex = 1;
            surnameTextBox.Text = "Surname";
            surnameTextBox.Click += surnameTextBox_Click;
            // 
            // nameTextBox
            // 
            nameTextBox.Location = new Point(6, 26);
            nameTextBox.Name = "nameTextBox";
            nameTextBox.Size = new Size(159, 27);
            nameTextBox.TabIndex = 0;
            nameTextBox.Text = "Name";
            nameTextBox.Click += nameTextBox_Click;
            // 
            // groupBox2
            // 
            groupBox2.BackColor = Color.DarkSlateGray;
            groupBox2.Controls.Add(updateUpdateButton);
            groupBox2.Controls.Add(updateBirthDateTextBox);
            groupBox2.Controls.Add(updatePhoneNumberTextBox);
            groupBox2.Controls.Add(updateGenderComboBox);
            groupBox2.Controls.Add(updateBloodTypeComboBox);
            groupBox2.Controls.Add(updateNationalIdNumberTextBox);
            groupBox2.Controls.Add(updateSurnameTextBox);
            groupBox2.Controls.Add(updateNameTextBox);
            groupBox2.ForeColor = Color.White;
            groupBox2.Location = new Point(738, 633);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(352, 216);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "Update Patient";
            // 
            // updateUpdateButton
            // 
            updateUpdateButton.BackColor = Color.FromArgb(64, 64, 64);
            updateUpdateButton.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 162);
            updateUpdateButton.ForeColor = Color.White;
            updateUpdateButton.Location = new Point(187, 155);
            updateUpdateButton.Name = "updateUpdateButton";
            updateUpdateButton.Size = new Size(159, 55);
            updateUpdateButton.TabIndex = 7;
            updateUpdateButton.Text = "Update";
            updateUpdateButton.UseVisualStyleBackColor = false;
            updateUpdateButton.Click += updateUpdateButton_Click;
            // 
            // updateBirthDateTextBox
            // 
            updateBirthDateTextBox.Location = new Point(6, 169);
            updateBirthDateTextBox.Name = "updateBirthDateTextBox";
            updateBirthDateTextBox.Size = new Size(159, 27);
            updateBirthDateTextBox.TabIndex = 6;
            updateBirthDateTextBox.Text = "Birth Date";
            updateBirthDateTextBox.Click += updateBirthDateTextBox_Click;
            // 
            // updatePhoneNumberTextBox
            // 
            updatePhoneNumberTextBox.Location = new Point(6, 121);
            updatePhoneNumberTextBox.Name = "updatePhoneNumberTextBox";
            updatePhoneNumberTextBox.Size = new Size(159, 27);
            updatePhoneNumberTextBox.TabIndex = 5;
            updatePhoneNumberTextBox.Text = "Phone Number";
            updatePhoneNumberTextBox.Click += updatePhoneNumberTextBox_Click;
            // 
            // updateGenderComboBox
            // 
            updateGenderComboBox.FormattingEnabled = true;
            updateGenderComboBox.Items.AddRange(new object[] { "Unknown", "Doesn’t appear", "Female", "Male" });
            updateGenderComboBox.Location = new Point(187, 120);
            updateGenderComboBox.Name = "updateGenderComboBox";
            updateGenderComboBox.Size = new Size(159, 28);
            updateGenderComboBox.TabIndex = 4;
            updateGenderComboBox.Text = "Gender";
            updateGenderComboBox.Click += updateGenderComboBox_Click;
            // 
            // updateBloodTypeComboBox
            // 
            updateBloodTypeComboBox.FormattingEnabled = true;
            updateBloodTypeComboBox.Items.AddRange(new object[] { "Unknown", "0 Rh -", "0 Rh +", "A Rh -", "A Rh +", "B Rh -", "B Rh +", "AB Rh -", "AB Rh +" });
            updateBloodTypeComboBox.Location = new Point(187, 71);
            updateBloodTypeComboBox.Name = "updateBloodTypeComboBox";
            updateBloodTypeComboBox.Size = new Size(159, 28);
            updateBloodTypeComboBox.TabIndex = 3;
            updateBloodTypeComboBox.Text = "Blood Type";
            updateBloodTypeComboBox.Click += updateBloodTypeComboBox_Click;
            // 
            // updateNationalIdNumberTextBox
            // 
            updateNationalIdNumberTextBox.Location = new Point(6, 73);
            updateNationalIdNumberTextBox.Name = "updateNationalIdNumberTextBox";
            updateNationalIdNumberTextBox.Size = new Size(159, 27);
            updateNationalIdNumberTextBox.TabIndex = 2;
            updateNationalIdNumberTextBox.Text = "National Id Number";
            updateNationalIdNumberTextBox.Click += updateNationalIdNumberTextBox_Click;
            // 
            // updateSurnameTextBox
            // 
            updateSurnameTextBox.Location = new Point(187, 26);
            updateSurnameTextBox.Name = "updateSurnameTextBox";
            updateSurnameTextBox.Size = new Size(159, 27);
            updateSurnameTextBox.TabIndex = 1;
            updateSurnameTextBox.Text = "Surname";
            updateSurnameTextBox.Click += updateSurnameTextBox_Click;
            // 
            // updateNameTextBox
            // 
            updateNameTextBox.Location = new Point(6, 26);
            updateNameTextBox.Name = "updateNameTextBox";
            updateNameTextBox.Size = new Size(159, 27);
            updateNameTextBox.TabIndex = 0;
            updateNameTextBox.Text = "Name";
            updateNameTextBox.Click += updateNameTextBox_Click;
            // 
            // groupBox3
            // 
            groupBox3.BackColor = Color.DarkSlateGray;
            groupBox3.Controls.Add(deleteDeleteButton);
            groupBox3.Controls.Add(deleteFindButton);
            groupBox3.Controls.Add(deleteNationalIdNumberTextBox);
            groupBox3.Controls.Add(deleteSurnameTextBox);
            groupBox3.Controls.Add(deleteNameTextBox);
            groupBox3.Controls.Add(deletePatientIdTextBox);
            groupBox3.ForeColor = Color.White;
            groupBox3.Location = new Point(370, 668);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(362, 161);
            groupBox3.TabIndex = 2;
            groupBox3.TabStop = false;
            groupBox3.Text = "Delete / Find Patient";
            // 
            // deleteDeleteButton
            // 
            deleteDeleteButton.BackColor = Color.Red;
            deleteDeleteButton.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 162);
            deleteDeleteButton.ForeColor = Color.White;
            deleteDeleteButton.Location = new Point(283, 77);
            deleteDeleteButton.Name = "deleteDeleteButton";
            deleteDeleteButton.Size = new Size(73, 78);
            deleteDeleteButton.TabIndex = 5;
            deleteDeleteButton.Text = "Delete";
            deleteDeleteButton.UseVisualStyleBackColor = false;
            deleteDeleteButton.Click += deleteDeleteButton_Click;
            // 
            // deleteFindButton
            // 
            deleteFindButton.BackColor = Color.Navy;
            deleteFindButton.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 162);
            deleteFindButton.ForeColor = Color.White;
            deleteFindButton.Location = new Point(197, 77);
            deleteFindButton.Name = "deleteFindButton";
            deleteFindButton.Size = new Size(73, 78);
            deleteFindButton.TabIndex = 4;
            deleteFindButton.Text = "Find";
            deleteFindButton.UseVisualStyleBackColor = false;
            deleteFindButton.Click += deleteFindButton_Click;
            // 
            // deleteNationalIdNumberTextBox
            // 
            deleteNationalIdNumberTextBox.Location = new Point(197, 26);
            deleteNationalIdNumberTextBox.Name = "deleteNationalIdNumberTextBox";
            deleteNationalIdNumberTextBox.Size = new Size(159, 27);
            deleteNationalIdNumberTextBox.TabIndex = 3;
            deleteNationalIdNumberTextBox.Text = "National Id Number";
            deleteNationalIdNumberTextBox.Click += deleteNationalIdNumberTextBox_Click;
            // 
            // deleteSurnameTextBox
            // 
            deleteSurnameTextBox.Location = new Point(6, 128);
            deleteSurnameTextBox.Name = "deleteSurnameTextBox";
            deleteSurnameTextBox.Size = new Size(159, 27);
            deleteSurnameTextBox.TabIndex = 2;
            deleteSurnameTextBox.Text = "Surname";
            deleteSurnameTextBox.Click += deleteSurnameTextBox_Click;
            // 
            // deleteNameTextBox
            // 
            deleteNameTextBox.Location = new Point(6, 77);
            deleteNameTextBox.Name = "deleteNameTextBox";
            deleteNameTextBox.Size = new Size(159, 27);
            deleteNameTextBox.TabIndex = 1;
            deleteNameTextBox.Text = "Name";
            deleteNameTextBox.Click += deleteNameTextBox_Click;
            // 
            // deletePatientIdTextBox
            // 
            deletePatientIdTextBox.Location = new Point(6, 26);
            deletePatientIdTextBox.Name = "deletePatientIdTextBox";
            deletePatientIdTextBox.Size = new Size(159, 27);
            deletePatientIdTextBox.TabIndex = 0;
            deletePatientIdTextBox.Text = "Patient ID";
            deletePatientIdTextBox.Click += patientIdTextBox_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(12, 12);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(1078, 615);
            dataGridView1.TabIndex = 3;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(1105, 154);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(281, 383);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 4;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Consolas", 12F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label1.ForeColor = Color.White;
            label1.Location = new Point(1129, 557);
            label1.Name = "label1";
            label1.Size = new Size(230, 23);
            label1.TabIndex = 5;
            label1.Text = "DB Manager v1 (2026)";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Consolas", 12F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label2.ForeColor = Color.White;
            label2.Location = new Point(1096, 591);
            label2.Name = "label2";
            label2.Size = new Size(296, 23);
            label2.TabIndex = 6;
            label2.Text = "Developed by Berat Yılmaz™";
            // 
            // mainScreen
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DarkSlateGray;
            ClientSize = new Size(1398, 855);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            Controls.Add(dataGridView1);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(newPatientGroupBox);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "mainScreen";
            Text = "DB Manager v1";
            newPatientGroupBox.ResumeLayout(false);
            newPatientGroupBox.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox newPatientGroupBox;
        private GroupBox groupBox2;
        private GroupBox groupBox3;
        private TextBox nameTextBox;
        private TextBox phoneNumberTextBox;
        private ComboBox genderComboBox;
        private ComboBox bloodTypeComboBox;
        private TextBox nationalIdNumberTextBox;
        private TextBox surnameTextBox;
        private Button addPatientButton;
        private TextBox birthDateTextBox;
        private TextBox deletePatientIdTextBox;
        private TextBox deleteNameTextBox;
        private TextBox deleteSurnameTextBox;
        private Button deleteDeleteButton;
        private Button deleteFindButton;
        private TextBox deleteNationalIdNumberTextBox;
        private TextBox updatePhoneNumberTextBox;
        private ComboBox updateGenderComboBox;
        private ComboBox updateBloodTypeComboBox;
        private TextBox updateNationalIdNumberTextBox;
        private TextBox updateSurnameTextBox;
        private TextBox updateNameTextBox;
        private Button updateUpdateButton;
        private TextBox updateBirthDateTextBox;
        private DataGridView dataGridView1;
        private PictureBox pictureBox1;
        private Label label1;
        private Label label2;
    }
}
