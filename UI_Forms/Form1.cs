using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using ClientDataStorage;
using ClientLibrary;
using CarDataStorage;
using CarLibrary;
using System.IO;
using System.Drawing.Text;
using System.Collections;

namespace UI_Forms
{
    public partial class Form1 : Form
    {

        ClientAdministration adminClients;
        CarAdministration adminCars;

        private const int WIDTH_CONTROL = 100;
        private const int DIMENSION_PAS_Y = 30;
        private const int DIMENSION_PAS_X = 120;
        private const int OFFSET_X = 600;

        //Clients
        private Label lblFirstName;
        private Label[] lblsFirstName;

        private Label lblLastName;
        private Label[] lblsLastName;

        private Label lblEmail;
        private Label[] lblsEmail;

        private Label lblPhone_Number;
        private Label[] lblsPhone_Number;

        //Cars

        public Form1()
        {

            //CLIENTS-----------------------------------------------------------------------------------------
            //Clients client = new Clients();
            string fileName = ConfigurationManager.AppSettings["FileName"];
            string ClientsSolutionFileLocation = Directory.GetParent(Directory.GetCurrentDirectory()).Parent.Parent.FullName;
            string ClientsCompleteFileLocation = Path.Combine(ClientsSolutionFileLocation, fileName);
            adminClients = new ClientAdministration(ClientsCompleteFileLocation);
            //int nrClients = 0;
            //Clients[] clients = adminClients.GetClients(out nrClients);

            //CARS--------------------------------------------------------------------------------------------
            //Cars car = new Cars();
            string fileNameCar = ConfigurationManager.AppSettings["FileNameCar"];
            string CarSolutionFileLocation = Directory.GetParent(Directory.GetCurrentDirectory()).Parent.Parent.FullName;
            string CarCompleteFileLocation = Path.Combine(CarSolutionFileLocation, fileNameCar);
            adminCars = new CarAdministration(CarCompleteFileLocation);
            //int nrCars = 0;
            //Cars[] cars = adminCars.GetCars(out nrCars);

            InitializeComponent();

            //properties settings
            this.Size = new Size(500, 200);
            this.StartPosition = FormStartPosition.Manual;
            this.Location = new Point(100, 100);
            this.Font = new Font("Arial", 9, FontStyle.Bold);
            this.ForeColor = Color.LimeGreen;
            this.Text = "Client's informations: ";
            
        }
            private void Form1_Load(object sender, EventArgs e)
            {
                DisplayClients();
            }

            private void DisplayClients()
            {
                    //add label for 'FirstName'
                 lblFirstName = new Label();
                 lblFirstName.Width = WIDTH_CONTROL;
                 lblFirstName.Text = "First Name";
                 lblFirstName.Left = 6 *DIMENSION_PAS_X;
                 lblFirstName.ForeColor = Color.DarkGreen;
                 this.Controls.Add(lblFirstName);

                     //add label for 'LastName'
                 lblLastName = new Label();
                 lblLastName.Width = WIDTH_CONTROL;
                 lblLastName.Text = "Last Name";
                 lblLastName.Left = 7 * DIMENSION_PAS_X;
                 lblLastName.ForeColor = Color.DarkGreen;
                 this.Controls.Add(lblLastName);

                    //add label for 'Email'
                 lblEmail = new Label();
                 lblEmail.Width = WIDTH_CONTROL;
                 lblEmail.Text = "Email";
                 lblEmail.Left = 8 * DIMENSION_PAS_X;
                 lblEmail.ForeColor = Color.DarkGreen;
                 this.Controls.Add(lblEmail);

                    //add label for 'Phone_number'
                 lblPhone_Number = new Label();
                 lblPhone_Number.Width = WIDTH_CONTROL;
                 lblPhone_Number.Text = "Phone Number";
                 lblPhone_Number.Left = 10 * DIMENSION_PAS_X;
                 lblPhone_Number.ForeColor = Color.DarkGreen;
                 this.Controls.Add(lblPhone_Number);

                 //Clients[] clients = adminClients.GetClients(out int nrClients);

                ArrayList clients = adminClients.GetClients();

                int nrClients = clients.Count;
                lblsFirstName = new Label[nrClients];
                lblsLastName = new Label[nrClients];
                lblsEmail = new Label[nrClients];
                lblsPhone_Number = new Label[nrClients];

                int i = 0;
                foreach (Clients client in clients)
                {

                    //add Label for Client's first name
                    lblsFirstName[i] = new Label();
                    lblsFirstName[i].Width = WIDTH_CONTROL;
                    lblsFirstName[i].Text = client.First_name;
                    lblsFirstName[i].Left = OFFSET_X + DIMENSION_PAS_X;
                    lblsFirstName[i].Top = (i + 2) * DIMENSION_PAS_Y;
                    this.Controls.Add(lblsFirstName[i]);

                    //add Label for Client's last name
                    lblsLastName[i] = new Label();
                    lblsLastName[i].Width = WIDTH_CONTROL;
                    lblsLastName[i].Text = client.Last_name;
                    lblsLastName[i].Left = OFFSET_X + 2 * DIMENSION_PAS_X;
                    lblsLastName[i].Top = (i + 2) * DIMENSION_PAS_Y;
                    this.Controls.Add(lblsLastName[i]);

                    //add Label for Client's email
                    lblsEmail[i] = new Label();
                    lblsEmail[i].Width = 2 * WIDTH_CONTROL;
                    lblsEmail[i].Text = client.Email_address;
                    lblsEmail[i].Left = OFFSET_X + 3 * DIMENSION_PAS_X;
                    lblsEmail[i].Top = (i + 2) * DIMENSION_PAS_Y;
                    this.Controls.Add(lblsEmail[i]);

                    //add Label for Client's phone number
                    lblsPhone_Number[i] = new Label();
                    lblsPhone_Number[i].Width = WIDTH_CONTROL;
                    lblsPhone_Number[i].Text = client.Phone_number;
                    lblsPhone_Number[i].Left = OFFSET_X + 5 * DIMENSION_PAS_X;
                    lblsPhone_Number[i].Top = (i + 2) * DIMENSION_PAS_Y;
                    this.Controls.Add(lblsPhone_Number[i]);

                    i++;
                }
            }

        private void ClientsControlReset()
        {
            txtFirstName.Text = txtLastName.Text = txtEmail.Text = txtPhoneNumber.Text = string.Empty;

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void btnDisplayClient_Click(object sender, EventArgs e)
        {
            DisplayClients();
            this.Width = 1200;
        }

        private void btnAddClient_Click_1(object sender, EventArgs e)
        {
            //if(!InvalidClientData())
            //{

            //}

            Clients c = new Clients(0, txtFirstName.Text, txtLastName.Text, txtEmail.Text, txtPhoneNumber.Text); ;

            adminClients.AddClient(c);


            //reset controls to add a new client
            ClientsControlReset();
        }

        /*
        Label TitleClient = new Label();
        TitleClient.Text = "Clients";
        TitleClient.BackColor = Color.Silver;
        TitleClient.AutoSize = true;
        TitleClient.Font = new Font("Segoe UI", 16, FontStyle.Bold);
        TitleClient.TextAlign = ContentAlignment.MiddleCenter;
        TitleClient.Location = new Point((this.ClientSize.Width - TitleClient.Width) / 2, 20);
        this.Controls.Add(TitleClient);

        // Create labels for each client
        int x = (this.ClientSize.Width - 200) / 2;  // Center X position of labels
        int y = 50;  // Starting Y position of labels
        int spacing = 25;  // Spacing between labels

        for (int i = 0; i < nrClients; i++)
        {
            Clients clienti = clients[i];

            // Create label for client information
            Label clientLabel = new Label();
            clientLabel.AutoSize = true;
            clientLabel.Font = new Font("Segoe UI", 10);
            clientLabel.Text = $"ID: {clienti.IdClient} | Name: {clienti.First_name} {clienti.Last_name} | Email: {clienti.Email_address} | Phone: {clienti.Phone_number}";
            clientLabel.Location = new Point(x, y);

            // Add label to form
            this.Controls.Add(clientLabel);

            // Update Y position for next label
            y += spacing;
        }

        Label TitleCar = new Label();
        TitleCar.Text = "Cars";
        TitleCar.BackColor = Color.Silver;
        TitleCar.AutoSize = true;
        TitleCar.Font = new Font("Segoe UI", 16, FontStyle.Bold);
        TitleCar.TextAlign = ContentAlignment.MiddleCenter;
        TitleCar.Location = new Point((this.ClientSize.Width - TitleCar.Width) / 2, 250);
        this.Controls.Add(TitleCar);

        // Create labels for each car
        int xCar = (this.ClientSize.Width - 200) / 2;  // Center X position of labels
        int yCar = 280;  // Starting Y position of labels
        int spacingCar = 25;  // Spacing between labels

        for (int i = 0; i < nrCars; i++)
        {
            Cars cari = cars[i];

            // Create label for car information
            Label carLabel = new Label();
            carLabel.AutoSize = true;
            carLabel.Font = new Font("Segoe UI", 10);
            carLabel.Text = $"ID: {cari.IdCar} | Make: {cari.Make} | Model: {cari.Model} | Year: {cari.Year} | Price: {cari.Price.ToString("C", new System.Globalization.CultureInfo("en-US")).Replace("$", "€")} | Color: {cari.Color} | Options: {cari.Options}";
            carLabel.Location = new Point(xCar, yCar);

            // Add label to form
            this.Controls.Add(carLabel);

            // Update Y position for next label
            yCar += spacingCar;
        }

        // Center form on screen
        this.CenterToScreen();
        */
        //}
    }
}


