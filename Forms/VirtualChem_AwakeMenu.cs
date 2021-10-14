using System;
using System.Windows.Forms;

namespace VirtualChem.Forms
{
    public partial class VirtualChem_AwakeMenu : Form
    {
        int time = 0;

        public VirtualChem_AwakeMenu()
        {
            InitializeComponent();
        }
        private void VirtualChem_AwakeMenu_Load(object sender, EventArgs e)
        {
            Menu_Timer.Start();
        }

        private void Menu_Timer_Tick(object sender, EventArgs e)
        {
            time++;

            if (time == 100)
            {
                Menu_Timer.Stop();

                VirtualChem_MainMenu virtualChem_MainMenu = new VirtualChem_MainMenu();
                this.Hide();
                virtualChem_MainMenu.Show();
            }
        }
    }
}
