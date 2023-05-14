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

        IDataStorageClients adminClients;
        IDataStorageCars adminCars;

        private const int WIDTH_CONTROL = 100;
        private const int DIMENSION_PAS_Y = 30;
        private const int DIMENSION_PAS_X = 120;
        private const int OFFSET_X = 600;

        //Client's labels
        private Label lblFirstName;
        private Label[] lblsFirstName;

        private Label lblLastName;
        private Label[] lblsLastName;

        private Label lblEmail;
        private Label[] lblsEmail;

        private Label lblPhone_Number;
        private Label[] lblsPhone_Number;
        //--------------------------------------------------------------------------

        //Car's labels
        private Label lblMaker;
        private Label[] lblsMake;

        private Label lblModel;
        private Label[] lblsModel;

        private Label lblYear;
        private Label[] lblsYear;

        private Label lblPrice;
        private Label[] lblsPrice;

        private Label lblColor;
        private Label[] lblsColor;

        private Label lblOptions;
        private Label[] lblsOptions;

        ArrayList selectedOptions = new ArrayList();
        //-----------------------------------------------------------------------------

        public Form1()
        {

            //CLIENTS-----------------------------------------------------------------------------------------
            //Clients client = new Clients();
            string fileName = ConfigurationManager.AppSettings["FileName"];
            string ClientsSolutionFileLocation = Directory.GetParent(Directory.GetCurrentDirectory()).Parent.Parent.FullName;
            string ClientsCompleteFileLocation = Path.Combine(ClientsSolutionFileLocation, fileName);
            adminClients = FactoryStorage.GetAdminStorage();
            //adminClients = new ClientAdministration(ClientsCompleteFileLocation);
            //int nrClients = 0;
            //Clients[] clients = adminClients.GetClients(out nrClients);

            //CARS--------------------------------------------------------------------------------------------
            //Cars car = new Cars();
            string fileNameCar = ConfigurationManager.AppSettings["FileNameCar"];
            string CarSolutionFileLocation = Directory.GetParent(Directory.GetCurrentDirectory()).Parent.Parent.FullName;
            string CarCompleteFileLocation = Path.Combine(CarSolutionFileLocation, fileNameCar);
            adminCars = FactoryStorageCars.GetAdminStorageCar();
            //adminCars = new CarAdministration(CarCompleteFileLocation);
            //int nrCars = 0;
            //Cars[] cars = adminCars.GetCars(out nrCars);

            InitializeComponent();

            //properties settings
            this.Size = new Size(500, 200);
            this.StartPosition = FormStartPosition.Manual;
            this.Location = new Point(100, 100);
            this.Font = new Font("Arial", 9, FontStyle.Bold);
            this.ForeColor = Color.LimeGreen;
            this.Text = "Car_Rental_System: ";
            
        }
            private void Form1_Load(object sender, EventArgs e)
            {
                List<Clients> clients = adminClients.GetClients();
                DisplayClients(clients);

                 List<Cars> cars = adminCars.GetCars();
                 DisplayCars(cars);
            }

            private void DisplayClients(List<Clients> clients)
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

                //ArrayList clients = adminClients.GetClients();

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
                    lblsFirstName[i].Width =WIDTH_CONTROL;
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


        private void DisplayCars(List<Cars> cars)
        {
            //add Label for 'Maker'
            lblMake = new Label();
            lblMake.Width = WIDTH_CONTROL;
            lblMake.Text = "Maker";
            lblMake.Left = 6 * DIMENSION_PAS_X;
            lblMake.Top = 14 * DIMENSION_PAS_Y;
            lblMake.ForeColor = Color.DarkGreen;
            this.Controls.Add(lblMake);

            //add Label for 'Model'
            lblModel = new Label();
            lblModel.Width = WIDTH_CONTROL;
            lblModel.Text = "Model";
            lblModel.Left = 7 * DIMENSION_PAS_X;
            lblModel.Top = 14 * DIMENSION_PAS_Y;
            lblModel.ForeColor = Color.DarkGreen;
            this.Controls.Add(lblModel);

            //add Label for 'Year'
            lblYear = new Label();
            lblYear.Width = WIDTH_CONTROL;
            lblYear.Text = "Year";
            lblYear.Left = 8 * DIMENSION_PAS_X;
            lblYear.Top = 14 * DIMENSION_PAS_Y;
            lblYear.ForeColor = Color.DarkGreen;
            this.Controls.Add(lblYear);

            //add Label for 'Price'
            lblPrice = new Label();
            lblPrice.Width = WIDTH_CONTROL;
            lblPrice.Text = "Price";
            lblPrice.Left = 9 * DIMENSION_PAS_X;
            lblPrice.Top = 14 * DIMENSION_PAS_Y;
            lblPrice.ForeColor = Color.DarkGreen;
            this.Controls.Add(lblPrice);

            //add Label for "Car's color"
            lblColor = new Label();
            lblColor.Width = WIDTH_CONTROL;
            lblColor.Text = "Car's color";
            lblColor.Left = 10 * DIMENSION_PAS_X;
            lblColor.Top = 14 * DIMENSION_PAS_Y;
            lblColor.ForeColor = Color.DarkGreen;
            this.Controls.Add(lblColor);

            //add Label for "Car's options" 
            lblOptions = new Label();
            lblOptions.Width = WIDTH_CONTROL;
            lblOptions.Text = "Car's options";
            lblOptions.Left = 11 * DIMENSION_PAS_X;
            lblOptions.Top = 14 * DIMENSION_PAS_Y;
            lblOptions.ForeColor = Color.DarkGreen;
            this.Controls.Add(lblOptions);

           // ArrayList cars = adminCars.GetCars();

            int nrCars = cars.Count;
            lblsMake = new Label[nrCars];
            lblsModel = new Label[nrCars];
            lblsYear = new Label[nrCars];
            lblsPrice = new Label[nrCars];
            lblsColor = new Label[nrCars];
            lblsOptions = new Label[nrCars];

            int i = 0;
            int topOffset = 15 * DIMENSION_PAS_Y;
            foreach (Cars car in cars)
            {
                //add Label for car's maker
                lblsMake[i] = new Label();
                lblsMake[i].Width = WIDTH_CONTROL;
                lblsMake[i].Text = car.Make;
                lblsMake[i].Left = OFFSET_X + DIMENSION_PAS_X;
                lblsMake[i].Top = topOffset + i * DIMENSION_PAS_Y;
                this.Controls.Add(lblsMake[i]);

                //add Label for car's model
                lblsModel[i] = new Label();
                lblsModel[i].Width = WIDTH_CONTROL;
                lblsModel[i].Text = car.Model;
                lblsModel[i].Left = OFFSET_X + 2 * DIMENSION_PAS_X;
                lblsModel[i].Top = topOffset + i * DIMENSION_PAS_Y;
                this.Controls.Add(lblsModel[i]);

                //add Label for car's year
                lblsYear[i] = new Label();
                lblsYear[i].Width = WIDTH_CONTROL;
                lblsYear[i].Text = Convert.ToString(car.Year);
                lblsYear[i].Left = OFFSET_X + 3 * DIMENSION_PAS_X;
                lblsYear[i].Top = topOffset + i * DIMENSION_PAS_Y;
                this.Controls.Add(lblsYear[i]);

                //add Label for car's price
                lblsPrice[i] = new Label();
                lblsPrice[i].Width = WIDTH_CONTROL;
                lblsPrice[i].Text = Convert.ToString(car.Price);
                lblsPrice[i].Left = OFFSET_X + 4 * DIMENSION_PAS_X;
                lblsPrice[i].Top = topOffset + i * DIMENSION_PAS_Y;
                this.Controls.Add(lblsPrice[i]);

                //add Label for car's color
                lblsColor[i] = new Label();
                lblsColor[i].Width = WIDTH_CONTROL;
                lblsColor[i].Text = car.Color.ToString();
                lblsColor[i].Left = OFFSET_X + 5 * DIMENSION_PAS_X;
                lblsColor[i].Top = topOffset + i * DIMENSION_PAS_Y;
                this.Controls.Add(lblsColor[i]);

                //add Label for car's options
                lblsOptions[i] = new Label();
                lblsOptions[i].Width = 5 * WIDTH_CONTROL;
                lblsOptions[i].Text = car.OptionsAsString;
                lblsOptions[i].Left = OFFSET_X + 6 * DIMENSION_PAS_X;
                lblsOptions[i].Top = topOffset + i * DIMENSION_PAS_Y;
                this.Controls.Add(lblsOptions[i]);

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
            List <Clients> clients = adminClients.GetClients();
            DisplayClients(clients);
            DisplayClientsInControlListBox(clients);
        }

        private void DisplayClientsInControlListBox(List<Clients> clients)
        {
            lstDisplayClients.Items.Clear();
            foreach (Clients client in clients)
            {
                lstDisplayClients.Items.Add(client);
            }
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

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void btnAddCar_Click(object sender, EventArgs e)
        {          
            Cars car = new Cars(0, txtMake.Text, txtModel.Text, txtYear.Text, txtPrice.Text);

            CarColor selectedColor = GetSelectedColor();
            car.Color = selectedColor;

            car.Options = new ArrayList();
            car.Options.AddRange(selectedOptions);

            adminCars.AddCar(car);

            CarsControlReset();

        }

        private void ckbOptions_CheckedChanged(object sender, EventArgs e)
        {
            CheckBox checkBoxControl = sender as CheckBox;

            string selectedOption = checkBoxControl.Text;

            if (checkBoxControl.Checked == true)
                selectedOptions.Add(selectedOption);
            else
                selectedOptions.Remove(selectedOption);

        }

        private void CarsControlReset()
        {
            txtMake.Text = txtModel.Text = txtYear.Text = txtPrice.Text = string.Empty;

            rdbBlack.Checked = false;
            rdbBlue.Checked = false;
            rdbBrown.Checked = false;
            rdbGray.Checked = false;
            rdbGreen.Checked = false;
            rdbRed.Checked = false;
            rdbSilver.Checked = false;
            rdbWhite.Checked = false;
            rdbYellow.Checked = false;

            ckbAirConditioner.Checked = false;
            ckbAutomaticTransmission.Checked = false;
            ckbCruiseControl.Checked = false;
            ckbFourWheelDrive.Checked = false;
            ckbNavigationSystem.Checked = false;
            ckbSunroof.Checked = false;

            selectedOptions.Clear();
        }

        private CarColor GetSelectedColor()
        {
            if (rdbBlack.Checked)
                return CarColor.Black;
            if (rdbWhite.Checked)
                return CarColor.White;
            if (rdbGray.Checked)
                return CarColor.Gray;
            if (rdbBlue.Checked)
                return CarColor.Blue;
            if (rdbBrown.Checked)
                return CarColor.Brown;
            if (rdbGreen.Checked)
                return CarColor.Green;
            if (rdbYellow.Checked)
                return CarColor.Yellow;
            if (rdbRed.Checked)
                return CarColor.Red;
            if (rdbSilver.Checked)
                return CarColor.Silver;

            return CarColor.Unknown;
        }

        private void btnDisplayCar_Click(object sender, EventArgs e)
        {
            List<Cars> cars = adminCars.GetCars();
            DisplayCars(cars);
            DisplayCarsInControlListBox(cars);
        }

        private void DisplayCarsInControlListBox(List<Cars> cars)
        {
            lstDisplayCars.Items.Clear();
            foreach (Cars car in cars)
            {
                lstDisplayCars.Items.Add(car);
            }
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

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


