namespace CVValidator
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        private TextBox txtName, txtEmail, txtPhone, txtPassword, txtAddress, txtPostal, txtCV;
        private Button btnValidateForm, btnParseCV, btnSaveResults;
        private Label lblTitle;
        private Panel pnlForm;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            txtName = new TextBox();
            txtEmail = new TextBox();
            txtPhone = new TextBox();
            txtPassword = new TextBox();
            txtAddress = new TextBox();
            txtPostal = new TextBox();
            txtCV = new TextBox();
            btnValidateForm = new Button();
            btnParseCV = new Button();
            lblTitle = new Label();
            btnSaveResults = new Button();
            pnlForm = new Panel();
            SuspendLayout();
            // 
            // pnlForm
            // 
            pnlForm.BackColor = Color.LightGray;
            pnlForm.Location = new Point(10, 10);
            pnlForm.Size = new Size(580, 340);
            pnlForm.BorderStyle = BorderStyle.FixedSingle;
            // 
            // txtName
            // 
            txtName.Location = new Point(40, 60);
            txtName.Name = "txtName";
            txtName.PlaceholderText = "Enter your full name";
            txtName.Size = new Size(250, 30);
            txtName.TabIndex = 1;
            txtName.Font = new Font("Arial", 10);
            txtName.BackColor = Color.White;
            txtName.ForeColor = Color.DarkSlateGray;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(40, 100);
            txtEmail.Name = "txtEmail";
            txtEmail.PlaceholderText = "Enter your email";
            txtEmail.Size = new Size(250, 30);
            txtEmail.TabIndex = 2;
            txtEmail.Font = new Font("Arial", 10);
            txtEmail.BackColor = Color.White;
            txtEmail.ForeColor = Color.DarkSlateGray;
            // 
            // txtPhone
            // 
            txtPhone.Location = new Point(40, 140);
            txtPhone.Name = "txtPhone";
            txtPhone.PlaceholderText = "Enter your phone number";
            txtPhone.Size = new Size(250, 30);
            txtPhone.TabIndex = 3;
            txtPhone.Font = new Font("Arial", 10);
            txtPhone.BackColor = Color.White;
            txtPhone.ForeColor = Color.DarkSlateGray;
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(40, 180);
            txtPassword.Name = "txtPassword";
            txtPassword.PlaceholderText = "Enter your password";
            txtPassword.Size = new Size(250, 30);
            txtPassword.TabIndex = 4;
            txtPassword.Font = new Font("Arial", 10);
            txtPassword.BackColor = Color.White;
            txtPassword.ForeColor = Color.DarkSlateGray;
            // 
            // txtAddress
            // 
            txtAddress.Location = new Point(40, 220);
            txtAddress.Name = "txtAddress";
            txtAddress.PlaceholderText = "Enter your address";
            txtAddress.Size = new Size(250, 30);
            txtAddress.TabIndex = 5;
            txtAddress.Font = new Font("Arial", 10);
            txtAddress.BackColor = Color.White;
            txtAddress.ForeColor = Color.DarkSlateGray;
            // 
            // txtPostal
            // 
            txtPostal.Location = new Point(40, 260);
            txtPostal.Name = "txtPostal";
            txtPostal.PlaceholderText = "Enter postal code";
            txtPostal.Size = new Size(250, 30);
            txtPostal.TabIndex = 6;
            txtPostal.Font = new Font("Arial", 10);
            txtPostal.BackColor = Color.White;
            txtPostal.ForeColor = Color.DarkSlateGray;
            // 
            // txtCV
            // 
            txtCV.Location = new Point(320, 60);
            txtCV.Multiline = true;
            txtCV.Name = "txtCV";
            txtCV.Size = new Size(220, 175);
            txtCV.TabIndex = 7;
            txtCV.Font = new Font("Arial", 10);
            txtCV.BackColor = Color.White;
            txtCV.ForeColor = Color.DarkSlateGray;
            // 
            // btnValidateForm
            // 
            btnValidateForm.Location = new Point(40, 300);
            btnValidateForm.Name = "btnValidateForm";
            btnValidateForm.Size = new Size(250, 35);
            btnValidateForm.TabIndex = 8;
            btnValidateForm.Text = "Validate Form Data";
            btnValidateForm.BackColor = Color.SeaGreen;
            btnValidateForm.ForeColor = Color.White;
            btnValidateForm.Font = new Font("Arial", 12, FontStyle.Bold);
            btnValidateForm.Click += btnValidateForm_Click;
            // 
            // btnParseCV
            // 
            btnParseCV.Location = new Point(320, 300);
            btnParseCV.Name = "btnParseCV";
            btnParseCV.Size = new Size(220, 35);
            btnParseCV.TabIndex = 9;
            btnParseCV.Text = "Parse CV Text";
            btnParseCV.BackColor = Color.SteelBlue;
            btnParseCV.ForeColor = Color.White;
            btnParseCV.Font = new Font("Arial", 12, FontStyle.Bold);
            btnParseCV.Click += btnParseCV_Click;
            // 
            // lblTitle
            // 
            lblTitle.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            lblTitle.Location = new Point(0, 10);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(580, 40);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "Smart CV & Form Validator Tool";
            lblTitle.TextAlign = ContentAlignment.MiddleCenter;
            lblTitle.ForeColor = Color.DarkSlateGray;
            // 
            // btnSaveResults
            // 
            btnSaveResults.Location = new Point(40, 340);
            btnSaveResults.Name = "btnSaveResults";
            btnSaveResults.Size = new Size(500, 35);
            btnSaveResults.TabIndex = 10;
            btnSaveResults.Text = "Save Results to File";
            btnSaveResults.BackColor = Color.OrangeRed;
            btnSaveResults.ForeColor = Color.White;
            btnSaveResults.Font = new Font("Arial", 12, FontStyle.Bold);
            btnSaveResults.Click += btnSaveResults_Click;
            // 
            // Form1
            // 
            ClientSize = new Size(600, 380);
            Controls.Add(btnSaveResults);
            Controls.Add(lblTitle);
            Controls.Add(pnlForm);
            pnlForm.Controls.Add(txtName);
            pnlForm.Controls.Add(txtEmail);
            pnlForm.Controls.Add(txtPhone);
            pnlForm.Controls.Add(txtPassword);
            pnlForm.Controls.Add(txtAddress);
            pnlForm.Controls.Add(txtPostal);
            pnlForm.Controls.Add(txtCV);
            pnlForm.Controls.Add(btnValidateForm);
            pnlForm.Controls.Add(btnParseCV);
            Name = "Form1";
            Text = "Smart CV & Form Validator";
            ResumeLayout(false);
            PerformLayout();
        }
    }
}
