using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MultiColorModernUI
{
    public partial class LoginCard : Form
    {
        private string connectionString;
        private SqlConnection sqlConnection;
        public LoginCard()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
           

            connectionString = @"Data Source="+ textServerName.Text+";Initial catalog=master;User ID="+ textUserID.Text+";Password="+ textPassword.Text;


            sqlConnection = new SqlConnection(connectionString);

           
            try
            {
                sqlConnection.Open();

                MessageBox.Show("Connection open!");
                buttonCreateDB.Enabled = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                buttonCreateDB.Enabled = false;
            }
            

        }

        private void buttonCreateDB_Click(object sender, EventArgs e)
        {
            buttonCreateDB.Enabled=false;
            string str;


            // grant permission user to database



            // create database 

            str = $"If(db_id(N'{textDatabaseName.Text}') IS NULL)" +
                $"begin" +
                $" create database [{textDatabaseName.Text}]" +
                $" end;";



            SqlCommand myCommand = new SqlCommand(str, sqlConnection);

            try
            {
                myCommand.ExecuteNonQuery();
               
                richTextResult.Text = "Database is Created Successfully \n";
            }
            catch(Exception ex)
            {
               MessageBox.Show(ex.Message);
            }


            //--------------------------------------------

            // create users table 

            str = $"USE [{textDatabaseName.Text}]   if  OBJECT_ID('UsersTable', 'U') IS NULL CREATE TABLE UsersTable" +
                $"(" +
                $"ID int IDENTITY (1,1) NOT NULL," +
                $"UserName varchar(100) UNIQUE NOT NULL," +
                $"Password varchar(100)," +
                $"Email varchar(100)," +
                $"CreatedBy varchar(100)," +
                $"RolesGroup varchar(100)," +
                $"Status varchar(100)," +
                $"FullName varchar(100)," +
                $"LastModified DATETIME  NOT NULL   DEFAULT CURRENT_TIMESTAMP," +
                $"PRIMARY KEY(ID)," +
                $")";

            myCommand = new SqlCommand(str, sqlConnection);

            try
            {
                myCommand.ExecuteNonQuery();

                richTextResult.Text += "UsersTable is Created Successfully \n";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }

            //--------------------------------------

            // add admin user 

            str = $"USE [{textDatabaseName.Text}] insert into UsersTable (UserName, Password, CreatedBy, Status) values('admin', 'admin', 'System Setup for first time','active')";

            myCommand = new SqlCommand(str, sqlConnection);

            try
            {
                myCommand.ExecuteNonQuery();

                richTextResult.Text += "admin user is Created Successfully \n";
            }
            catch (Exception ex)
            {
                //MessageBox.Show(ex.Message);
                richTextResult.Text += "admin user is already exisit \n";
            }

            //-----------------------------
        }

        private void buttonSaveAndConnect_Click(object sender, EventArgs e)
        {
            // save xml file for connection






            if (File.Exists($"{Application.StartupPath}/ConnectionDB.dat"))
            {
                // Connection file already saved
                Application.EnableVisualStyles();
                Application.SetCompatibleTextRenderingDefault(false);
                Application.Run(new MainCard());
            }
        }
    }
}
