using System;
using System.Linq;
using System.Windows.Forms;
using v1;

namespace v1
{
    public partial class mainScreen : Form
    {
        private PatientDAL patientDAL = new PatientDAL();

        public mainScreen()
        {
            InitializeComponent();

            // when program running add the data from database to datagridview
            RefreshDataGridAndSelect(null); 
        }

        // datagridview refresh and select
        private void RefreshDataGridAndSelect(string patientId)
        {
            // refresh datagridview
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = patientDAL.GetAll();

            // if patientId null or empty do not do select 
            if (string.IsNullOrWhiteSpace(patientId)) return;

            // find from patientId and select
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                if (row.Cells["PatientId"].Value.ToString() == patientId)
                {
                    row.Selected = true;
                    dataGridView1.FirstDisplayedScrollingRowIndex = row.Index; // görünmesini sağla
                    break;
                }
            }
        }

        // text boxes click event (if added something its not deleting after clicking)
        private void nameTextBox_Click(object sender, EventArgs e)
        {
            if (nameTextBox.Text == "Name") nameTextBox.Text = String.Empty;
        }

        private void surnameTextBox_Click(object sender, EventArgs e)
        {
            if (surnameTextBox.Text == "Surname") surnameTextBox.Text = String.Empty;
        }

        private void nationalIdNumberTextBox_Click(object sender, EventArgs e)
        {
            if (nationalIdNumberTextBox.Text == "National Id Number") nationalIdNumberTextBox.Text = String.Empty;
        }

        private void bloodTypeComboBox_Click(object sender, EventArgs e)
        {
            if (bloodTypeComboBox.Text == "Blood Type") bloodTypeComboBox.SelectedIndex = 0;
        }

        private void phoneNumberTextBox_Click(object sender, EventArgs e)
        {
            if (phoneNumberTextBox.Text == "Phone Number") phoneNumberTextBox.Text = String.Empty;
        }

        private void genderComboBox_Click(object sender, EventArgs e)
        {
            if (genderComboBox.Text == "Gender") genderComboBox.SelectedIndex = 0;
        }

        private void birthDateTextBox_Click(object sender, EventArgs e)
        {
            if (birthDateTextBox.Text == "Birth Date") birthDateTextBox.Text = String.Empty;
        }

        private void patientIdTextBox_Click(object sender, EventArgs e)
        {
            deletePatientIdTextBox.Text = String.Empty;
        }

        private void deleteNationalIdNumberTextBox_Click(object sender, EventArgs e)
        {
            deleteNationalIdNumberTextBox.Text = String.Empty;
        }

        private void deleteNameTextBox_Click(object sender, EventArgs e)
        {
            deleteNameTextBox.Text = String.Empty;
        }

        private void deleteSurnameTextBox_Click(object sender, EventArgs e)
        {
            deleteSurnameTextBox.Text = String.Empty;
        }

        private void updateNameTextBox_Click(object sender, EventArgs e)
        {
            if (updateNameTextBox.Text == "Name") updateNameTextBox.Text = String.Empty;
        }

        private void updateSurnameTextBox_Click(object sender, EventArgs e)
        {
            if (updateSurnameTextBox.Text == "Surname") updateSurnameTextBox.Text = String.Empty;
        }

        private void updateNationalIdNumberTextBox_Click(object sender, EventArgs e)
        {
            if (updateNationalIdNumberTextBox.Text == "National Id Number") updateNationalIdNumberTextBox.Text = String.Empty;
        }

        private void updatePhoneNumberTextBox_Click(object sender, EventArgs e)
        {
            if (updatePhoneNumberTextBox.Text == "Phone Number") updatePhoneNumberTextBox.Text = String.Empty;
        }

        private void updateBirthDateTextBox_Click(object sender, EventArgs e)
        {
            if (updateBirthDateTextBox.Text == "Birth Date") updateBirthDateTextBox.Text = String.Empty;
        }

        private void updateBloodTypeComboBox_Click(object sender, EventArgs e)
        {
            if (updateBloodTypeComboBox.Text == "Blood Type") updateBloodTypeComboBox.SelectedIndex = 0;
        }

        private void updateGenderComboBox_Click(object sender, EventArgs e)
        {
            if (updateGenderComboBox.Text == "Gender") updateGenderComboBox.SelectedIndex = 0;
        }

        // add patient
        private void addPatientButton_Click(object sender, EventArgs e)
        {
            bool comfirm = true;

            if (nameTextBox.Text.Length == 0 || nameTextBox.Text == "Name")
            {
                MessageBox.Show("Name cannot be null.");
                comfirm = false;
            }

            if (surnameTextBox.Text.Length == 0 || surnameTextBox.Text == "Surname")
            {
                MessageBox.Show("Surname cannot be null.");
                comfirm = false;
            }

            if (nationalIdNumberTextBox.Text.Length != 11 || !nationalIdNumberTextBox.Text.All(char.IsDigit))
            {
                MessageBox.Show("National ID number must be exactly 11 digits.");
                comfirm = false;
            }

            if (phoneNumberTextBox.Text.Length != 10 || !phoneNumberTextBox.Text.All(char.IsDigit))
            {
                MessageBox.Show("Phone number must be exactly 10 digits.");
                comfirm = false;
            }

            if (birthDateTextBox.Text == string.Empty || birthDateTextBox.Text == "Birth Date")
            {
                MessageBox.Show("Birth Date cannot be null.");
                comfirm = false;
            }
            else if (DateConverter(birthDateTextBox.Text) > TodayToInt())
            {
                MessageBox.Show("Birth date cannot be greater than today.");
                comfirm = false;
            }

            if (!comfirm) return;

            Patient patient = new Patient
            {
                Name = nameTextBox.Text,
                Surname = surnameTextBox.Text,
                NationalId = nationalIdNumberTextBox.Text,
                PhoneNumber = phoneNumberTextBox.Text,
                Gender = genderComboBox.Text,
                BloodType = bloodTypeComboBox.Text,
                BirthDate = DateTime.Parse(birthDateTextBox.Text)
            };

            bool added = patientDAL.Add(patient);

            MessageBox.Show(added ? "Patient added successfully." : "Patient already exists.");

            // refresh datagridview and select new added patient
            RefreshDataGridAndSelect(patient.PatientId.ToString());
        }

        private int DateConverter(string data)
        {
            int result = 0;
            foreach (char i in data)
            {
                if (i >= '0' && i <= '9') result = result * 10 + (i - '0');
            }

            int day = result / 1000000;
            int month = (result / 10000) % 100;
            int year = result % 10000;

            return year * 10000 + month * 100 + day; // yyyyMMdd
        }

        private int TodayToInt()
        {
            DateTime today = DateTime.Today;
            return today.Year * 10000 + today.Month * 100 + today.Day;
        }

        // delete patient 
        private void deleteFindButton_Click(object sender, EventArgs e)
        {
            string nationalId = deleteNationalIdNumberTextBox.Text;

            if (string.IsNullOrWhiteSpace(nationalId) || nationalId.Length != 11)
            {
                MessageBox.Show("Please enter a valid 11-digit National ID.");
                return;
            }

            Patient patient = patientDAL.GetByNationalId(nationalId);

            if (patient == null)
            {
                MessageBox.Show("Patient not found.");
                return;
            }

            // write update box 
            updateNameTextBox.Text = patient.Name;
            updateSurnameTextBox.Text = patient.Surname;
            updateNationalIdNumberTextBox.Text = patient.NationalId;
            updatePhoneNumberTextBox.Text = patient.PhoneNumber;
            updateBirthDateTextBox.Text = patient.BirthDate.ToString("dd.MM.yyyy");
            updateBloodTypeComboBox.Text = patient.BloodType;
            updateGenderComboBox.Text = patient.Gender;

            // select patient at datagridview 
            RefreshDataGridAndSelect(patient.PatientId.ToString());
        }

        private void updateUpdateButton_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(deletePatientIdTextBox.Text, out int patientId))
            {
                MessageBox.Show("Please enter a valid Patient ID.");
                return;
            }

            Patient updatedPatient = new Patient
            {
                PatientId = patientId,
                Name = updateNameTextBox.Text,
                Surname = updateSurnameTextBox.Text,
                NationalId = updateNationalIdNumberTextBox.Text,
                PhoneNumber = updatePhoneNumberTextBox.Text,
                Gender = updateGenderComboBox.Text,
                BloodType = updateBloodTypeComboBox.Text,
                BirthDate = DateTime.Parse(updateBirthDateTextBox.Text)
            };

            bool updated = patientDAL.Update(updatedPatient);

            MessageBox.Show(updated ? "Patient updated successfully." : "Patient not found.");

            // refresh datagridview and select updated patient
            RefreshDataGridAndSelect(updatedPatient.PatientId.ToString());
        }

        private void deleteDeleteButton_Click(object sender, EventArgs e)
        {
            string idText = deletePatientIdTextBox.Text;

            if (string.IsNullOrWhiteSpace(idText))
            {
                MessageBox.Show("Please enter a valid Patient ID.");
                return;
            }

            bool deleted = patientDAL.Delete(idText);

            MessageBox.Show(deleted ? "Patient deleted successfully." : "Patient not found.");

            RefreshDataGridAndSelect(null);
        }
    }
}


