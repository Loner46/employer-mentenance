using MaintenanceLibrary;
using System.ComponentModel;

namespace MentenaceUI
{
    public partial class EmployerMentenanceForm : Form
    {
        private List<PositionModel> positions = GlobalConfig.Connection.GetPositions();
        private List<ControlModel> controls = GlobalConfig.Connection.GetControls();
        private List<EmployerModel> employers = GlobalConfig.Connection.GetEmployers();
        //private EmployerModel selectedEmployer = new EmployerModel();
        public EmployerMentenanceForm()
        {
            InitializeComponent();

            InitializeForm();
        }

        private void InitializeForm()
        {
            employerCodeLabel.Enabled = true;
            employerCodeValue.Enabled = true;
            employerCodeValue.Text = string.Empty;
            displayButton.Enabled = true;

            nameLabel.Enabled = false;
            nameValue.Enabled = false;
            nameValue.Text = string.Empty;

            positionLabel.Enabled = false;
            positionDropDown.Enabled = false;
            positionDropDown.DataSource = null;

            controlLabel.Enabled = false;
            controlDropDown.Enabled = false;
            controlDropDown.DataSource = null;

            enteredDateLabel.Enabled = false;
            enteredDateValue.Enabled = false;
            enteredDateValue.Text = string.Empty;

            birthDateLabel.Enabled = false;
            birthDateValue.Enabled = false;
            birthDateValue.Text = string.Empty;

            updateButton.Enabled = false;
            deleteButton.Enabled = false;
            cancelButton.Enabled = false;
        }

        private void displayButton_Click(object sender, EventArgs e)
        {
            // Validation check employerCode value.
            // Enable downside part of form.
            // Get information from DB.
            if(ValidEmployerCodeCheck())
            {
                EnableDetailSection();

                WireUpLists();

                WireUpComponents();
            }

        }

        private void WireUpComponents()
        {

            //bool employerCDExistsChck = employers.Contains
            if (TypedEmployerNumberExists(employerCodeValue.Text))
            {
                EmployerModel selectedEmployer = employers.Where(x => x.NOé–àı == employerCodeValue.Text).First();
                nameValue.Text = selectedEmployer.NMé–àı;

                int positionIndex = positions.FindIndex(x => x.CDêEà  == selectedEmployer.êEà .CDêEà );
                int controlIndex = controls.FindIndex(x => x.CDèäëÆ == selectedEmployer.èäëÆ.CDèäëÆ);

                positionDropDown.SelectedIndex = positionIndex;
                controlDropDown.SelectedIndex = controlIndex;
                enteredDateValue.Text = selectedEmployer.DAì¸é–;
                birthDateValue.Text = selectedEmployer.DAê∂îNåéì˙; 
            }
        }

        private bool TypedEmployerNumberExists(string empNO)
        {
            bool output = false;
            List<string> employersNO = new List<string>();

            foreach (EmployerModel emp in employers)
            {
                employersNO.Add(emp.NOé–àı);
            }
            if(employersNO.Contains(empNO))
            {
                output = true;
            }
            return output;
        }

        private void WireUpLists()
        {
            //positions = GlobalConfig.Connection.GetPositions();
            //controls = GlobalConfig.Connection.GetControls();

            positionDropDown.DataSource = null;
            positionDropDown.DataSource = positions;
            positionDropDown.DisplayMember = "êEà ";

            controlDropDown.DataSource = null;
            controlDropDown.DataSource = controls;
            controlDropDown.DisplayMember = "èäëÆ";
        }

        private bool ValidEmployerCodeCheck()
        {
            if(String.IsNullOrEmpty(employerCodeValue.Text))
            {
                MessageBox.Show("é–àıÉRÅ[ÉhÇì¸óÕÇµÇƒÇ≠ÇæÇ≥Ç¢ÅB");
                employerCodeValue.Focus();
                return false;
            }
            return true;
        }

        private void EnableDetailSection()
        {
            employerCodeLabel.Enabled = false;
            employerCodeValue.Enabled = false;
            displayButton.Enabled = false;

            nameLabel.Enabled = true;
            nameValue.Enabled = true;
            nameValue.Text = string.Empty;
            nameValue.Focus();

            positionLabel.Enabled = true;
            positionDropDown.Enabled = true;
            //positionDropDown.SelectedIndex = 1;

            controlLabel.Enabled = true;
            controlDropDown.Enabled = true;
            //controlDropDown.SelectedIndex = 1;

            enteredDateLabel.Enabled = true;
            enteredDateValue.Enabled = true;
            enteredDateValue.Text = string.Empty;

            birthDateLabel.Enabled = true;
            birthDateValue.Enabled = true;
            birthDateValue.Text = string.Empty;

            updateButton.Enabled = true;
            deleteButton.Enabled = true;
            cancelButton.Enabled = true;
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            InitializeForm();
        }

        private void updateButton_Click(object sender, EventArgs e)
        {
            EmployerModel updEmp = new EmployerModel();
            updEmp.NOé–àı = employerCodeValue.Text;
            updEmp.NMé–àı = nameValue.Text;
            updEmp.êEà  = (PositionModel)positionDropDown.SelectedItem;
            updEmp.èäëÆ = (ControlModel)controlDropDown.SelectedItem;
            updEmp.DAì¸é– = enteredDateValue.Text;
            updEmp.DAê∂îNåéì˙ = birthDateValue.Text;
            GlobalConfig.Connection.UpdateEmployers(updEmp);

            InitializeForm();
        }
    }
}