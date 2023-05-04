using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Appliances_Management_System
{
    public partial class Dashboard : Form
    {

        private Button currentButton;
        private Random random;
        private int tempIndex;
        private Form activeForm;

        
        public Dashboard()
        {
            InitializeComponent();
            random = new Random();
             
        }

        private Color SelectTheme()
        {
            int index=random.Next(ThemeColor.ColorList.Count);
            while (tempIndex == index)
            {
              index = random.Next(ThemeColor.ColorList.Count);

            }
            tempIndex = index;
            string color = ThemeColor.ColorList[index];

            // There's an error here if you clicking 2 Panel multiple times :(
            return ColorTranslator.FromHtml(color); 
        }
        private void ActivateButton (object btnsender)
        {

            if (btnsender != null)
            {
                if (currentButton !=(Button)btnsender)
                {
                    DisableButton();
                    Color color = SelectTheme();
                    currentButton = (Button)btnsender;
                    currentButton.BackColor = color;
                    currentButton.ForeColor = Color.White;
                    currentButton.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                    panelTitle.BackColor = ThemeColor.ChangeColorBrightness(color, 0.2);  
                    panelLogo.BackColor = ThemeColor.ChangeColorBrightness(color, 0.5);

                    
                    
                }
                        

                
            }
        }
        private void DisableButton()
        {
            foreach (Control previousBtn in panelMenu.Controls)
            {
                if(previousBtn.GetType() == typeof(Button))
                {
                    previousBtn.BackColor = Color.FromArgb(51, 51, 76);
                    previousBtn.ForeColor = Color.Gainsboro;
                    previousBtn.Font = new System.Drawing.Font("Nirmala UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                }
            }
        }

        private void OpenChildForm(Form childForm, object btnSender)
        {
            if (activeForm != null)
            {
                activeForm.Close();
            }
            ActivateButton(btnSender);
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            this.panelDesktopPanel.Controls.Add(childForm); 
            this.panelDesktopPanel.Tag = childForm; 
            childForm.BringToFront();
            childForm.Show();
            lblTitle.Text = childForm.Text;




        }

        private void btnProduct_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Forms.FormProduct(), sender);

        }

        private void btnStocks_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Forms.FormStocks(), sender);
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void panelDesktopPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void lblTitle_Click(object sender, EventArgs e)
        {
          
        }

        private void btnTransaction_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Forms.FormTransaction(), sender);
        }

        private void btnHistory_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Forms.FormHistory(), sender);
        }
    }
}
