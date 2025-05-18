using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace project_1
{
    public partial class Instructor_Registration : Form
    {
        string connectionString = Connection.ConnectionText;

        public Instructor_Registration()
        {
            InitializeComponent();
        }

        private void Instructor_Registration_Load(object sender, EventArgs e)
        {

        }
        private bool validation()
        {
            bool Fname = false, Lname = false, 
     NationalNumber = false,  Password = false,
     Country = false, City = false, Email = false;



            // City
            if (Validation.ValidateCity(TB_City.Text))
            {
                TB_City.BackColor = Color.White;
                City = true;  // inverted
            }
            else
            {
                TB_City.BackColor = Color.MistyRose;
                City = false;  // inverted

            }

            // Country
            if (string.IsNullOrWhiteSpace(TB_Country.Text))
            {
                TB_Country.BackColor = Color.MistyRose;
                Country = false;  // inverted
            }
            else if (Validation.ValidateCountry(TB_Country.Text))
            {
                TB_Country.BackColor = Color.White;
                Country = true;  // inverted
            }

            // Email (not tracked in flag, you can add it if needed)
            if (Validation.IsValidEmail(TB_Email.Text, "Instructor"))
            {
                TB_Email.BackColor = Color.White;
                Email = true;  // inverted
            }
            else
            {
                TB_Email.BackColor = Color.MistyRose;
                Email = false;  // inverted
            }

            // First Name
            if (Validation.ValidateFirstName(TB_FName.Text))
            {
                TB_FName.BackColor = Color.White;
                Fname = true;  // inverted
            }
            else
            {
                TB_FName.BackColor = Color.MistyRose;
                Fname = false;  // inverted

            }

            // Last Name

            if (Validation.ValidateLastName(TB_LName.Text))
            {
                TB_LName.BackColor = Color.White;
                Lname = true;  // inverted
            }
            else
            {
                TB_LName.BackColor = Color.MistyRose;
                Lname = false;  // inverted}
            }
            // National Number

            if (Validation.ValidateNationalNumber(TB_NationalNumber.Text,"Student"))
            {
                TB_NationalNumber.BackColor = Color.White;
                NationalNumber = true;  // inverted
            }
            else
            {
                TB_NationalNumber.BackColor = Color.MistyRose;
                NationalNumber = false;  // inverted
            }

            // Password
            if (string.IsNullOrWhiteSpace(TB_Password.Text))
            {
                TB_Password.BackColor = Color.MistyRose;
                MessageBox.Show("enter the password");
                Password = false;  // inverted
            }
            else
            {
                TB_Password.BackColor = Color.White;
                Password = true;  // inverted
            }

            // Phone 1







            return Fname && Lname && Email && City && Country && Password && NationalNumber ;
        }
        private void B_RegisterInstructor_Click(object sender, EventArgs e)
        {
            string nationalNumber = TB_NationalNumber.Text;
            string firstName = TB_FName.Text;
            string lastName = TB_LName.Text;
            string country = TB_Country.Text;
            string city = TB_City.Text;
            string email = TB_Email.Text;
            string password = TB_Password.Text;
            if(validation())
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    SqlTransaction transaction = conn.BeginTransaction();

                    try
                    {
                        

                        string query = @"INSERT INTO Instructor 
                            (NationalNumber, firstname, lastname, Country, City, Email, Password)
                             VALUES (@NationalNumber, @FirstName, @LastName, @Country, @City, @Email, @Password)";

                        SqlCommand cmd = new SqlCommand(query, conn);

                        cmd.Parameters.AddWithValue("@NationalNumber", nationalNumber);
                        cmd.Parameters.AddWithValue("@FirstName", firstName);
                        cmd.Parameters.AddWithValue("@LastName", lastName);
                        cmd.Parameters.AddWithValue("@Country", country);
                        cmd.Parameters.AddWithValue("@City", city);
                        cmd.Parameters.AddWithValue("@Email", email);
                        cmd.Parameters.AddWithValue("@Password", password);
                        transaction.Commit();
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Instructor registered successfully!");
                    }
                    catch (Exception ex)
                    {
                        transaction.Rollback();
                        MessageBox.Show("An error occurred: " + ex.Message);
                        //ClearForm();
                    }
                    finally
                    {
                        conn.Close();
                    }
                }
           
                    
        }
            
        }

        private void B_Back_Click(object sender, EventArgs e)
        {
            F_LOGIN F1 = new F_LOGIN();
            F1.Show();
            this.Hide();
        }
    }
}
