using System;

namespace ClientLibrary
{
    public class Clients
    {
        private const char MAIN_FILE_SEPARATOR = ';';

        private const int ID = 0;
        private const int FIRST_NAME = 1;
        private const int LAST_NAME = 2;
        private const int EMAIL_ADDRESS = 3;
        private const int PHONE_NUMBER = 4;

        public int IdClient { get; set; }
        public string First_name { get; set; }
        public string Last_name { get; set; }
        public string Email_address { get; set; }
        public string Phone_number { get; set; }

        public Clients()
        {
            First_name = Last_name = Email_address = Phone_number = string.Empty;
        }

        public Clients(int idClient, string first_name, string last_name, string email_address, string phone_number)
        {
            this.IdClient = idClient;
            this.First_name = first_name ?? throw new ArgumentNullException(nameof(first_name));
            this.Last_name = last_name ?? throw new ArgumentNullException(nameof(last_name));
            this.Email_address = email_address ?? throw new ArgumentNullException(nameof(email_address));
            this.Phone_number = phone_number ?? throw new ArgumentNullException(nameof(phone_number));
        }

        public Clients(string fileLine)
        {
            var fileData = fileLine.Split(MAIN_FILE_SEPARATOR);

            IdClient = Convert.ToInt32(fileData[ID]);
            First_name = fileData[FIRST_NAME];
            Last_name = fileData[LAST_NAME];
            Email_address = fileData[EMAIL_ADDRESS];
            Phone_number = fileData[PHONE_NUMBER];
        }

        public string Info()
        {
            string info = string.Format("Id:{0}, First Name: {1}, Last Name: {2}, Phone Number: {3}, Email Address: {4}",
                IdClient.ToString(),
                (First_name ?? " UNKNOWN "),
                (Last_name ?? " UNKNOWN "),
                (Email_address ?? " UNKNOWN "),
                (Phone_number ?? " UNKNOWN "));

            return info;
        }

        public string ConvertToString_ForFile()
        {
            string clientObjectForFile = string.Format("{1}{0}{2}{0}{3}{0}{4}{0}{5}",
                MAIN_FILE_SEPARATOR,
                IdClient.ToString(),
                (First_name ?? " UNKNOWN "),
                (Last_name ?? " UNKNOWN "),
                (Email_address ?? " UNKNOWN "),
                (Phone_number ?? " UNKNOWN "));

            return clientObjectForFile;
        }

        public override string ToString()
        {
            return ConvertToString_ForFile();
        }

    }
}