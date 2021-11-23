using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MultiColorModernUI
{
    public partial class MainCard : Form
    {

        //fields
        private Button currentButton;
        private Random random;
        private int tempIndex;
        private Form activeForam;
        


        //Constructor
        public MainCard()
        {
            InitializeComponent();
            random = new Random();
           
        }

        private void Form1_Load(object sender, EventArgs e)
        {
           
        }

        //methods
        private Color SelectThemeColor()
        {
            int index = random.Next(ThemeColor.ColorList.Count);

            while(tempIndex == index)
            {
                index =  random.Next(ThemeColor.ColorList.Count);
            }
            tempIndex = index;

            string color = ThemeColor.ColorList[index];

            return ColorTranslator.FromHtml(color);
        }

        private void ActivateButton(object btnSender)
        {
            if(btnSender != null)
            {
                if(currentButton != (Button)btnSender)
                {
                    DisableButton();
                    Color color = SelectThemeColor();
                    currentButton = (Button)btnSender;
                    currentButton.BackColor = color;
                    currentButton.ForeColor = Color.White;


                }
            }
        }


        private void openChildCard(Form childForm, Object btnSender)
        {
            if (activeForam != null)
            {
                activeForam.Close();
            }
            ActivateButton(btnSender);
            activeForam = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            this.panelWorkSpace.Controls.Add(childForm);
           this.panelWorkSpace.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();


         }

        private void DisableButton ()
        {
            foreach(Control previousBtn in panelMenu.Controls)
            {
                if(previousBtn.GetType() == typeof(Button))
                {
                    //previousBtn.Enabled = false;
                    previousBtn.BackColor = Color.FromArgb(149, 152, 194);
                    previousBtn.ForeColor = Color.White;
                }
            }
        }

        private void btnDashboard_Click(object sender, EventArgs e)
        {
            ActivateButton(sender);
        }

        private void btnProcurment_Click(object sender, EventArgs e)
        {
            ActivateButton(sender);
        }

        private void btnWarehouse_Click(object sender, EventArgs e)
        {
            ActivateButton(sender);
        }

        private void btnProducts_Click(object sender, EventArgs e)
        {



            openChildCard(new Cards.ProductsCard(), sender);



        }

        private void btnSales_Click(object sender, EventArgs e)
        {
            ActivateButton(sender);
        }

        private void btnAccounting_Click(object sender, EventArgs e)
        {
            ActivateButton(sender);
        }

        private void btnSuppliers_Click(object sender, EventArgs e)
        {
            ActivateButton(sender);
        }

        private void btnCustomers_Click(object sender, EventArgs e)
        {
            ActivateButton(sender);
        }

        private void btnHR_Click(object sender, EventArgs e)
        {
            ActivateButton(sender);
        }

        private void btnIT_Click(object sender, EventArgs e)
        {
            ActivateButton(sender);
        }

        private void btnProject_Click(object sender, EventArgs e)
        {
            ActivateButton(sender);
        }

        private void btnProfile_Click(object sender, EventArgs e)
        {
            ActivateButton(sender);
        }

        private void btnSettings_Click(object sender, EventArgs e)
        {
            ActivateButton(sender);
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
