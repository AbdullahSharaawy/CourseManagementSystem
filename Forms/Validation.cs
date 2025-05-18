using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace project_1
{
    public static class Validation
    {
        public static bool IsValidPhoneNumber(string phoneNumber, System.Windows.Forms.TextBox textBox)
        {
            if (string.IsNullOrEmpty(phoneNumber))
                return false;
            bool isValid = true;
            textBox.BackColor = Color.White;
            foreach (char x in phoneNumber)
            {
                if (!char.IsDigit(x))
                {
                    isValid = false;
                    textBox.BackColor = Color.MistyRose;
                    MessageBox.Show("enter a valid phone number");
                    break;
                }

            }
            if ((phoneNumber.Substring(0, 3) != "010" && phoneNumber.Substring(1, 2) != "011" && phoneNumber.Substring(1, 2) != "012" && phoneNumber.Substring(1, 2) != "015") || phoneNumber.Length != 11)
            {
                MessageBox.Show("enter a valid phone number");
                isValid = false;
            }
            return isValid; 
        }
        public static bool ValidateNationalNumber(string nationalNumber,string MatchingTable)
        {
            if (string.IsNullOrEmpty(nationalNumber))
            {
                return false;
            }
            // Check length is 14 and contains only digits
            bool isValid = nationalNumber.Length == 14 && nationalNumber.All(char.IsDigit);
            if (!isValid || IsNationalNumberExists(nationalNumber,MatchingTable)) MessageBox.Show("please enter a valid national number.");
            return isValid && !IsNationalNumberExists(nationalNumber, MatchingTable);
        }
        public static bool ValidateFirstName(string firstName)
        {
            firstName = firstName.Trim();
            bool isValid = !firstName.Any(char.IsDigit);

            if (!isValid || firstName.Length==0) MessageBox.Show("please enter a valid name for the first name.");
            return isValid && Convert.ToBoolean(firstName.Length);
        }
        public static bool ValidateLastName(string lastName)
        {
            lastName = lastName.Trim();
            bool isValid = !lastName.Any(char.IsDigit);

            if (!isValid || lastName.Length == 0) MessageBox.Show("please enter a valid name for the last name.");
            return isValid && Convert.ToBoolean(lastName.Length);
        }
        public static bool ValidateCountry(string country)
        {
            country = country.Trim();
            bool isValid = !country.Any(char.IsDigit);

            if (!isValid || country.Length == 0) MessageBox.Show("please enter a valid name for the country.");
            return isValid && Convert.ToBoolean(country.Length);
        }
        public static bool ValidateCity(string city)
        {

            city = city.Trim();
            bool isValid = !city.Any(char.IsDigit);

            if (!isValid || city.Length==0) MessageBox.Show("please enter a valid name for the city.");
            return isValid && Convert.ToBoolean(city.Length);
        }
        public static bool ValidateGPA(decimal gpa)
        {
            bool isValid = gpa >= 0.00m && gpa <= 4.00m;
            if (!isValid) MessageBox.Show("GPA must be between 0.00 and 4.00");
            return isValid;
        }
        public static bool IsValidEmail(string email,string MathcingWith)
        {
            if(string.IsNullOrEmpty(email)) return false;
            // Regular expression for email validation
            var regex = @"^([\w-\.]+)@((\[[0-9]{1,3}\.[0-9]{1,3}\.[0-9]{1,3}\.[0-9]{1,3}\])|(([a-zA-Z\-0-9]+\.)+([a-zA-Z]{2,})))$";
            if (!Regex.IsMatch(email, regex) || IsEmailExists(email, MathcingWith))
                MessageBox.Show("enter a valid email");
            return Regex.IsMatch(email, regex) && !IsEmailExists(email,MathcingWith);
        }
        public static bool IsEmailExists(string Email, string TableName)
        {
            string query = $"select 1 from {TableName} where Email='{ Email}' ";
            int Exists=0;
            using (SqlConnection conn = new SqlConnection(Connection.ConnectionText))
            {
                conn.Open();
               
                try
                {
                   
                    SqlCommand studentCmd = new SqlCommand(query, conn);

                    Exists = studentCmd.ExecuteScalar()==null?0:1;

                   
                }
                catch (Exception ex)
                {
                   
                    MessageBox.Show("An error occurred: " + ex.Message);
                    //ClearForm();
                }
                finally
                {
                    conn.Close();
                }
            }
            return Exists == 1 ? true : false;
        }
        public static bool IsNationalNumberExists(string NationalNumber, string TableName)
        {
            string query = $"select 1 from {TableName} where NationalNumber='{NationalNumber}' ";
            int Exists = 0;
            using (SqlConnection conn = new SqlConnection(Connection.ConnectionText))
            {
                conn.Open();

                try
                {

                    SqlCommand studentCmd = new SqlCommand(query, conn);

                    Exists = studentCmd.ExecuteScalar() == null ? 0 : 1;


                }
                catch (Exception ex)
                {

                    MessageBox.Show("An error occurred: " + ex.Message);
                    //ClearForm();
                }
                finally
                {
                    conn.Close();
                }
            }
            return Exists == 1 ? true : false;
        }
    }
    }

