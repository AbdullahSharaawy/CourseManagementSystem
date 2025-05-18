using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Drawing.Drawing2D;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Globalization;
using System.Text.RegularExpressions;
namespace project_1
{
    public partial class F_STUDENT_R : Form
    {
        public F_STUDENT_R()
        {
            InitializeComponent();
        }
        private void F_STUDENT_R_Paint(object sender, PaintEventArgs e)
        {
            
        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void F_STUDENT_R_Load(object sender, EventArgs e)
        {
           
            TB_Stage.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
        
        
        private void label3_Click(object sender, EventArgs e)
        {

        }
       
        private bool validation()
        {
            bool Fname = false, Lname = false,  Stage = false,
     NationalNumber = false, Phone1 = false, Password = false,
     Country = false, City = false,Email=false,Phone2=true;

           

            // City
             if(Validation.ValidateCity(TB_City.Text)) 
            {
                TB_City.BackColor = Color.White;
                City = true;  // inverted
            }else
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
            else if(Validation.ValidateCountry(TB_Country.Text))
            {
                TB_Country.BackColor = Color.White;
                Country = true;  // inverted
            }

            // Email (not tracked in flag, you can add it if needed)
            if(Validation.IsValidEmail(TB_Email.Text,"Instructor"))
            {
                TB_Email.BackColor = Color.White;
                Email = true;  // inverted
            }else 
            {
                TB_Email.BackColor = Color.MistyRose;
                Email = false;  // inverted
            }

            // First Name
            if(Validation.ValidateFirstName(TB_FName.Text)) 
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
              
           if(Validation.ValidateNationalNumber(TB_NationalNumber.Text, "Instructor")) 
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
           
            if(Validation.IsValidPhoneNumber(TB_Phone.Text, TB_Phone))
            {
                Phone1 = true;
                
            }else
            {
                TB_Phone.BackColor = Color.MistyRose;
                Phone1 = false;  // inverted
            }

            // Phone 2 (not tracked with a flag)
            if (Validation.IsValidPhoneNumber(TB_Phone.Text, TB_Phone))
            {
                Phone2 = true;
            }
            else
            {
                TB_Phone.BackColor = Color.MistyRose;
                Phone1 = false;  // inverted
            }


            // Stage
            if (TB_Stage.SelectedItem==null)
            {
                TB_Stage.BackColor = Color.MistyRose;
                MessageBox.Show("please enter the stage.");
                Stage = false;  // inverted
            }
            else 
            {
                TB_Stage.BackColor = Color.White;
                Stage = true;  // inverted
            }

           
            
            return Fname && Lname && Email && City && Country && Phone1 && Password && NationalNumber && Stage && Phone2;
        }
        private void B_Submit_Click(object sender, EventArgs e)
        {

            if(validation())
            {
                string connectionString = Connection.ConnectionText;

                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    SqlTransaction transaction = conn.BeginTransaction();

                    try
                    {
                        string insertStudentQuery = @"
                INSERT INTO Student 
                ( NationalNumber, firstname, lastname, Country, City, Email, 
                Password, Stage, GPA, BirthDate, no_hours)
                OUTPUT INSERTED.student_id
                VALUES 
                ( @NationalNumber, @firstname, @lastname, @Country, @City, @Email, 
                  @Password, @Stage, @GPA, @BirthDate, @no_hours)";

                        SqlCommand studentCmd = new SqlCommand(insertStudentQuery, conn);

                        studentCmd.Parameters.AddWithValue("@firstname", TB_FName.Text);
                        studentCmd.Parameters.AddWithValue("@lastname", TB_LName.Text);
                        studentCmd.Parameters.AddWithValue("@BirthDate", TB_BirthDate.Value);
                        
                        studentCmd.Parameters.AddWithValue("@Email", TB_Email.Text);
                        studentCmd.Parameters.AddWithValue("@Password", TB_Password.Text);
                        studentCmd.Parameters.AddWithValue("@Stage", TB_Stage.Text);
                        studentCmd.Parameters.AddWithValue("@NationalNumber", TB_NationalNumber.Text);
                        studentCmd.Parameters.AddWithValue("@Country", TB_Country.Text);
                        studentCmd.Parameters.AddWithValue("@City", TB_City.Text);
                        studentCmd.Parameters.AddWithValue("@GPA", 0);
                        studentCmd.Parameters.AddWithValue("@no_hours", 0);

                        int studentId = (int)studentCmd.ExecuteScalar();

                        string insertPhoneQuery = @"INSERT INTO Phone (number, student_id) VALUES (@PhoneNumber, @StudentId)";
                        SqlCommand phoneCmd = new SqlCommand(insertPhoneQuery, conn, transaction);
                        phoneCmd.Parameters.AddWithValue("@PhoneNumber", TB_Phone.Text);
                        phoneCmd.Parameters.AddWithValue("@StudentId", studentId);
                        phoneCmd.ExecuteNonQuery();
                        SqlCommand phoneCmd2 = new SqlCommand(insertPhoneQuery, conn, transaction);

                        if (txtPhone2.Text.Length > 0)
                        {
                            phoneCmd2.Parameters.AddWithValue("@PhoneNumber", txtPhone2.Text);
                            phoneCmd2.Parameters.AddWithValue("@StudentId", studentId);
                            phoneCmd2.ExecuteNonQuery();

                        }

                        transaction.Commit();
                        MessageBox.Show("Student information saved successfully.");
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

        private void ClearForm()
        {
            // Reset all input fields
            TB_FName.Text = "";
            TB_LName.Text = "";
            TB_NationalNumber.Text = "";
            TB_Phone.Text = "";
            txtPhone2.Text = "";
            TB_Password.Text = "";
            TB_Country.Text = "";
            TB_City.Text = "";
            TB_Email.Text = "";
            TB_Stage.SelectedIndex = -1;
            TB_BirthDate.Value = DateTime.Now;

            // Reset background colors
            TB_FName.BackColor = Color.White;
            TB_LName.BackColor = Color.White;
            TB_NationalNumber.BackColor = Color.White;
            TB_Phone.BackColor = Color.White;
            txtPhone2.BackColor = Color.White;
            TB_Password.BackColor = Color.White;
            TB_Country.BackColor = Color.White;
            TB_City.BackColor = Color.White;
            TB_Email.BackColor = Color.White;
            TB_Stage.BackColor = Color.White;
        }
        private void B_Back_Click(object sender, EventArgs e)
        {
            F_LOGIN F1 = new F_LOGIN();
            F1.Show();
            this.Hide();
        }
    }
}
