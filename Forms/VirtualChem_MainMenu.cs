using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace VirtualChem.Forms
{
    public partial class VirtualChem_MainMenu : Form
    {
        public VirtualChem_MainMenu()
        {
            InitializeComponent();
        }

        public enum Element
        {
            Hydrogen,
            Helium,
            Lithium,
            Beryllium,
            Boron,
            Carbon,
            Nitrogen,
            Oxygen,
            Fluorine,
            Neon,
            Natrium,
            Magnesium,
            Aluminum,
            Silicon,
            Phosphorus,
            Sulfur,
            Chlorine,
            Argon,
            Potassium,
            Calcium,
            Scandium,
            Titanium,
            Vanadium,
            Chromium,
            Manganese,
            Iron,
            Cobalt,
            Nickel,
            Copper,
            Zinc,
            Gallium,
            Germanium,
            Arsenic,
            Selenium,
            Bromine,
            Krypton,
            Rubidium,
            Strontium,
            Yttrium,
            Zirconium,
            Niobium,
            Molybdenum,
            Technetium,
            Ruthenium,
            Rhodium,
            Palladium,
            Silver,
            Cadmium,
            Indium,
            Tin,
            Antimony,
            Tellurium,
            Iodine,
            Xenon,
            Caesium,
            Barium,
            Lanthanum,
            Cerium,
            Praseodymium,
            Neodymium,
            Promethium,
            Samarium,
            Europium,
            Gadolinium,
            Terbium,
            Dysprosium,
            Holmium,
            Erbium,
            Thulium,
            Ytterbium,
            Lutetium,
            Hafnium,
            Tantalum,
            Tungsten,
            Rhenium,
            Osmium,
            Iridium,
            Platinum,
            Gold,
            Mercury,
            Thallium,
            Lead,
            Bismuth,
            Polonium,
            Astatine,
            Radon,
            Francium,
            Radium,
            Actinium,
            Thorium,
            Protactinium,
            Uranium,
            Neptunium,
            Plutonium,
            Americium,
            Curium,
            Berkelium,
            Californium,
            Einsteinium,
            Fermium,
            Mendelevium,
            Nobelium,
            Lawrencium,
            Rutherfordium,
            Dubnium,
            Seaborgium,
            Bohrium,
            Hassium,
            Meitnerium,
            Darmstadtium,
            Roentgenium,
            Copernicium,
            Nihonium,
            Flerovium,
            Moscovium,
            Livermorium,
            Tennessine,
            Oganesson
        }

        public static Element SelectedElement;

        private void ShowElement_Button_Click(object sender, EventArgs e)
        {
            VirtualChem_ElementMenu virtualChem_ElementMenu = new VirtualChem_ElementMenu();
            virtualChem_ElementMenu.Show();
        }

        private void Minimize_Button_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void Exit_Button_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Hydrogen_Label_Click(object sender, EventArgs e)
        {
            SelectedElement = Element.Hydrogen;
            ShowElement_Button.Text = $"Show {SelectedElement}";
        }

        private void Helium_Label_Click(object sender, EventArgs e)
        {
            SelectedElement = Element.Helium;
            ShowElement_Button.Text = $"Show {SelectedElement}";
        }

        private void Lithium_Label_Click(object sender, EventArgs e)
        {
            SelectedElement = Element.Lithium;
            ShowElement_Button.Text = $"Show {SelectedElement}";
        }

        private void Beryllium_Label_Click(object sender, EventArgs e)
        {
            SelectedElement = Element.Beryllium;
            ShowElement_Button.Text = $"Show {SelectedElement}";
        }

        private void Bor_Label_Click(object sender, EventArgs e)
        {
            SelectedElement = Element.Boron;
            ShowElement_Button.Text = $"Show {SelectedElement}";
        }

        private void Carbon_Label_Click(object sender, EventArgs e)
        {
            SelectedElement = Element.Carbon;
            ShowElement_Button.Text = $"Show {SelectedElement}";
        }

        private void Nitrogen_Button_Click(object sender, EventArgs e)
        {
            SelectedElement = Element.Nitrogen;
            ShowElement_Button.Text = $"Show {SelectedElement}";
        }

        private void Oxygen_Label_Click(object sender, EventArgs e)
        {
            SelectedElement = Element.Oxygen;
            ShowElement_Button.Text = $"Show {SelectedElement}";
        }

        private void Flor_Label_Click(object sender, EventArgs e)
        {
            SelectedElement = Element.Fluorine;
            ShowElement_Button.Text = $"Show {SelectedElement}";
        }

        private void Neon_Label_Click(object sender, EventArgs e)
        {
            SelectedElement = Element.Neon;
            ShowElement_Button.Text = $"Show {SelectedElement}";
        }

        private void Natrium_Label_Click(object sender, EventArgs e)
        {
            SelectedElement = Element.Natrium;
            ShowElement_Button.Text = $"Show {SelectedElement}";
        }

        private void Magnesium_Label_Click(object sender, EventArgs e)
        {
            SelectedElement = Element.Magnesium;
            ShowElement_Button.Text = $"Show {SelectedElement}";
        }

        private void Aluminum_Label_Click(object sender, EventArgs e)
        {
            SelectedElement = Element.Aluminum;
            ShowElement_Button.Text = $"Show {SelectedElement}";
        }

        private void Silisium_Label_Click(object sender, EventArgs e)
        {
            SelectedElement = Element.Silicon;
            ShowElement_Button.Text = $"Show {SelectedElement}";
        }

        private void Phosphorus_Label_Click(object sender, EventArgs e)
        {
            SelectedElement = Element.Phosphorus;
            ShowElement_Button.Text = $"Show {SelectedElement}";
        }

        private void Sulfur_Label_Click(object sender, EventArgs e)
        {
            SelectedElement = Element.Sulfur;
            ShowElement_Button.Text = $"Show {SelectedElement}";
        }

        private void Chlorine_Label_Click(object sender, EventArgs e)
        {
            SelectedElement = Element.Chlorine;
            ShowElement_Button.Text = $"Show {SelectedElement}";
        }

        private void Argon_Label_Click(object sender, EventArgs e)
        {
            SelectedElement = Element.Argon;
            ShowElement_Button.Text = $"Show {SelectedElement}";
        }

        private void Potassium_Label_Click(object sender, EventArgs e)
        {
            SelectedElement = Element.Potassium;
            ShowElement_Button.Text = $"Show {SelectedElement}";
        }

        private void Calcium_Label_Click(object sender, EventArgs e)
        {
            SelectedElement = Element.Calcium;
            ShowElement_Button.Text = $"Show {SelectedElement}";
        }

        private void Scandium_Label_Click(object sender, EventArgs e)
        {
            SelectedElement = Element.Scandium;
            ShowElement_Button.Text = $"Show {SelectedElement}";
        }

        private void Titanium_Label_Click(object sender, EventArgs e)
        {
            SelectedElement = Element.Titanium;
            ShowElement_Button.Text = $"Show {SelectedElement}";
        }

        private void Vanadium_Label_Click(object sender, EventArgs e)
        {
            SelectedElement = Element.Vanadium;
            ShowElement_Button.Text = $"Show {SelectedElement}";
        }

        private void Chromium_Label_Click(object sender, EventArgs e)
        {
            SelectedElement = Element.Chromium;
            ShowElement_Button.Text = $"Show {SelectedElement}";
        }

        private void Manganese_Label_Click(object sender, EventArgs e)
        {
            SelectedElement = Element.Manganese;
            ShowElement_Button.Text = $"Show {SelectedElement}";
        }

        private void Iron_Label_Click(object sender, EventArgs e)
        {
            SelectedElement = Element.Iron;
            ShowElement_Button.Text = $"Show {SelectedElement}";
        }

        private void Cobalt_Label_Click(object sender, EventArgs e)
        {
            SelectedElement = Element.Cobalt;
            ShowElement_Button.Text = $"Show {SelectedElement}";
        }

        private void Nickel_Label_Click(object sender, EventArgs e)
        {
            SelectedElement = Element.Nickel;
            ShowElement_Button.Text = $"Show {SelectedElement}";
        }

        private void Copper_Label_Click(object sender, EventArgs e)
        {
            SelectedElement = Element.Copper;
            ShowElement_Button.Text = $"Show {SelectedElement}";
        }

        private void Zinc_Label_Click(object sender, EventArgs e)
        {
            SelectedElement = Element.Zinc;
            ShowElement_Button.Text = $"Show {SelectedElement}";
        }

        private void Gallium_Label_Click(object sender, EventArgs e)
        {
            SelectedElement = Element.Gallium;
            ShowElement_Button.Text = $"Show {SelectedElement}";
        }

        private void Germanium_Label_Click(object sender, EventArgs e)
        {
            SelectedElement = Element.Germanium;
            ShowElement_Button.Text = $"Show {SelectedElement}";
        }

        private void Arsenic_Label_Click(object sender, EventArgs e)
        {
            SelectedElement = Element.Arsenic;
            ShowElement_Button.Text = $"Show {SelectedElement}";
        }

        private void Selenium_Label_Click(object sender, EventArgs e)
        {
            SelectedElement = Element.Selenium;
            ShowElement_Button.Text = $"Show {SelectedElement}";
        }

        private void Bromine_Label_Click(object sender, EventArgs e)
        {
            SelectedElement = Element.Bromine;
            ShowElement_Button.Text = $"Show {SelectedElement}";
        }

        private void Krypton_Label_Click(object sender, EventArgs e)
        {
            SelectedElement = Element.Krypton;
            ShowElement_Button.Text = $"Show {SelectedElement}";
        }

        private void Rubidium_Label_Click(object sender, EventArgs e)
        {
            SelectedElement = Element.Rubidium;
            ShowElement_Button.Text = $"Show {SelectedElement}";
        }

        private void Strontium_Label_Click(object sender, EventArgs e)
        {
            SelectedElement = Element.Strontium;
            ShowElement_Button.Text = $"Show {SelectedElement}";
        }

        private void Yttrium_Label_Click(object sender, EventArgs e)
        {
            SelectedElement = Element.Yttrium;
            ShowElement_Button.Text = $"Show {SelectedElement}";
        }

        private void Zirconium_Label_Click(object sender, EventArgs e)
        {
            SelectedElement = Element.Zirconium;
            ShowElement_Button.Text = $"Show {SelectedElement}";
        }

        private void Niobium_Label_Click(object sender, EventArgs e)
        {
            SelectedElement = Element.Niobium;
            ShowElement_Button.Text = $"Show {SelectedElement}";
        }

        private void Molybdenum_Label_Click(object sender, EventArgs e)
        {
            SelectedElement = Element.Molybdenum;
            ShowElement_Button.Text = $"Show {SelectedElement}";
        }

        private void Technetium_Label_Click(object sender, EventArgs e)
        {
            SelectedElement = Element.Technetium;
            ShowElement_Button.Text = $"Show {SelectedElement}";
        }

        private void Ruthenium_Label_Click(object sender, EventArgs e)
        {
            SelectedElement = Element.Ruthenium;
            ShowElement_Button.Text = $"Show {SelectedElement}";
        }

        private void Rhodium_Label_Click(object sender, EventArgs e)
        {
            SelectedElement = Element.Rhodium;
            ShowElement_Button.Text = $"Show {SelectedElement}";
        }

        private void Palladium_Label_Click(object sender, EventArgs e)
        {
            SelectedElement = Element.Palladium;
            ShowElement_Button.Text = $"Show {SelectedElement}";
        }

        private void Silver_Label_Click(object sender, EventArgs e)
        {
            SelectedElement = Element.Silver;
            ShowElement_Button.Text = $"Show {SelectedElement}";
        }

        private void Cadmium_Label_Click(object sender, EventArgs e)
        {
            SelectedElement = Element.Cadmium;
            ShowElement_Button.Text = $"Show {SelectedElement}";
        }

        private void Indium_Label_Click(object sender, EventArgs e)
        {
            SelectedElement = Element.Indium;
            ShowElement_Button.Text = $"Show {SelectedElement}";
        }

        private void Tin_Label_Click(object sender, EventArgs e)
        {
            SelectedElement = Element.Tin;
            ShowElement_Button.Text = $"Show {SelectedElement}";
        }

        private void Antimony_Label_Click(object sender, EventArgs e)
        {
            SelectedElement = Element.Antimony;
            ShowElement_Button.Text = $"Show {SelectedElement}";
        }

        private void Tellurium_Label_Click(object sender, EventArgs e)
        {
            SelectedElement = Element.Tellurium;
            ShowElement_Button.Text = $"Show {SelectedElement}";
        }

        private void Iodine_Label_Click(object sender, EventArgs e)
        {
            SelectedElement = Element.Iodine;
            ShowElement_Button.Text = $"Show {SelectedElement}";
        }

        private void Xenon_Label_Click(object sender, EventArgs e)
        {
            SelectedElement = Element.Xenon;
            ShowElement_Button.Text = $"Show {SelectedElement}";
        }

        private void Caesium_Label_Click(object sender, EventArgs e)
        {
            SelectedElement = Element.Caesium;
            ShowElement_Button.Text = $"Show {SelectedElement}";
        }

        private void Barium_Label_Click(object sender, EventArgs e)
        {
            SelectedElement = Element.Barium;
            ShowElement_Button.Text = $"Show {SelectedElement}";
        }

        private void Hafnium_Label_Click(object sender, EventArgs e)
        {
            SelectedElement = Element.Hafnium;
            ShowElement_Button.Text = $"Show {SelectedElement}";
        }

        private void Tantalum_Label_Click(object sender, EventArgs e)
        {
            SelectedElement = Element.Tantalum;
            ShowElement_Button.Text = $"Show {SelectedElement}";
        }

        private void Tungsten_Label_Click(object sender, EventArgs e)
        {
            SelectedElement = Element.Tungsten;
            ShowElement_Button.Text = $"Show {SelectedElement}";
        }

        private void Rhenium_Label_Click(object sender, EventArgs e)
        {
            SelectedElement = Element.Rhenium;
            ShowElement_Button.Text = $"Show {SelectedElement}";
        }

        private void Osmium_Label_Click(object sender, EventArgs e)
        {
            SelectedElement = Element.Osmium;
            ShowElement_Button.Text = $"Show {SelectedElement}";
        }

        private void Iridium_Label_Click(object sender, EventArgs e)
        {
            SelectedElement = Element.Iridium;
            ShowElement_Button.Text = $"Show {SelectedElement}";
        }

        private void Platinum_Label_Click(object sender, EventArgs e)
        {
            SelectedElement = Element.Platinum;
            ShowElement_Button.Text = $"Show {SelectedElement}";
        }

        private void Gold_Label_Click(object sender, EventArgs e)
        {
            SelectedElement = Element.Gold;
            ShowElement_Button.Text = $"Show {SelectedElement}";
        }

        private void Mercury_Label_Click(object sender, EventArgs e)
        {
            SelectedElement = Element.Mercury;
            ShowElement_Button.Text = $"Show {SelectedElement}";
        }

        private void Thallium_Label_Click(object sender, EventArgs e)
        {
            SelectedElement = Element.Thallium;
            ShowElement_Button.Text = $"Show {SelectedElement}";
        }

        private void Lead_Label_Click(object sender, EventArgs e)
        {
            SelectedElement = Element.Lead;
            ShowElement_Button.Text = $"Show {SelectedElement}";
        }

        private void Bismuth_Label_Click(object sender, EventArgs e)
        {
            SelectedElement = Element.Bismuth;
            ShowElement_Button.Text = $"Show {SelectedElement}";
        }

        private void Polonium_Label_Click(object sender, EventArgs e)
        {
            SelectedElement = Element.Polonium;
            ShowElement_Button.Text = $"Show {SelectedElement}";
        }

        private void Astatine_Label_Click(object sender, EventArgs e)
        {
            SelectedElement = Element.Astatine;
            ShowElement_Button.Text = $"Show {SelectedElement}";
        }

        private void Radon_Label_Click(object sender, EventArgs e)
        {
            SelectedElement = Element.Radon;
            ShowElement_Button.Text = $"Show {SelectedElement}";
        }

        private void Francium_Label_Click(object sender, EventArgs e)
        {
            SelectedElement = Element.Francium;
            ShowElement_Button.Text = $"Show {SelectedElement}";
        }

        private void Radium_Label_Click(object sender, EventArgs e)
        {
            SelectedElement = Element.Radium;
            ShowElement_Button.Text = $"Show {SelectedElement}";
        }

        private void Rutherfordium_Label_Click(object sender, EventArgs e)
        {
            SelectedElement = Element.Rutherfordium;
            ShowElement_Button.Text = $"Show {SelectedElement}";
        }

        private void Dubnium_Label_Click(object sender, EventArgs e)
        {
            SelectedElement = Element.Dubnium;
            ShowElement_Button.Text = $"Show {SelectedElement}";
        }

        private void Seaborgium_Label_Click(object sender, EventArgs e)
        {
            SelectedElement = Element.Seaborgium;
            ShowElement_Button.Text = $"Show {SelectedElement}";
        }

        private void Bohrium_Label_Click(object sender, EventArgs e)
        {
            SelectedElement = Element.Bohrium;
            ShowElement_Button.Text = $"Show {SelectedElement}";
        }

        private void Hassium_Label_Click(object sender, EventArgs e)
        {
            SelectedElement = Element.Hassium;
            ShowElement_Button.Text = $"Show {SelectedElement}";
        }

        private void Meitnerium_Label_Click(object sender, EventArgs e)
        {
            SelectedElement = Element.Meitnerium;
            ShowElement_Button.Text = $"Show {SelectedElement}";
        }

        private void Darmstadtium_Label_Click(object sender, EventArgs e)
        {
            SelectedElement = Element.Darmstadtium;
            ShowElement_Button.Text = $"Show {SelectedElement}";
        }

        private void Roentgenium_Label_Click(object sender, EventArgs e)
        {
            SelectedElement = Element.Roentgenium;
            ShowElement_Button.Text = $"Show {SelectedElement}";
        }

        private void Copernicium_Label_Click(object sender, EventArgs e)
        {
            SelectedElement = Element.Copernicium;
            ShowElement_Button.Text = $"Show {SelectedElement}";
        }

        private void Nihonium_Label_Click(object sender, EventArgs e)
        {
            SelectedElement = Element.Nihonium;
            ShowElement_Button.Text = $"Show {SelectedElement}";
        }

        private void Flerovium_Label_Click(object sender, EventArgs e)
        {
            SelectedElement = Element.Flerovium;
            ShowElement_Button.Text = $"Show {SelectedElement}";
        }

        private void Moscovium_Label_Click(object sender, EventArgs e)
        {
            SelectedElement = Element.Moscovium;
            ShowElement_Button.Text = $"Show {SelectedElement}";
        }

        private void Livermorium_Label_Click(object sender, EventArgs e)
        {
            SelectedElement = Element.Livermorium;
            ShowElement_Button.Text = $"Show {SelectedElement}";
        }

        private void Tennessine_Label_Click(object sender, EventArgs e)
        {
            SelectedElement = Element.Tennessine;
            ShowElement_Button.Text = $"Show {SelectedElement}";
        }

        private void Oganesson_Label_Click(object sender, EventArgs e)
        {
            SelectedElement = Element.Oganesson;
            ShowElement_Button.Text = $"Show {SelectedElement}";
        }

        private void Lanthanum_Label_Click(object sender, EventArgs e)
        {
            SelectedElement = Element.Lanthanum;
            ShowElement_Button.Text = $"Show {SelectedElement}";
        }

        private void Cerium_Label_Click(object sender, EventArgs e)
        {
            SelectedElement = Element.Cerium;
            ShowElement_Button.Text = $"Show {SelectedElement}";
        }

        private void Praseodymium_Label_Click(object sender, EventArgs e)
        {
            SelectedElement = Element.Praseodymium;
            ShowElement_Button.Text = $"Show {SelectedElement}";
        }

        private void Neodymium_Label_Click(object sender, EventArgs e)
        {
            SelectedElement = Element.Neodymium;
            ShowElement_Button.Text = $"Show {SelectedElement}";
        }

        private void Promethium_Label_Click(object sender, EventArgs e)
        {
            SelectedElement = Element.Promethium;
            ShowElement_Button.Text = $"Show {SelectedElement}";
        }

        private void Samarium_Label_Click(object sender, EventArgs e)
        {
            SelectedElement = Element.Samarium;
            ShowElement_Button.Text = $"Show {SelectedElement}";
        }

        private void Europium_Label_Click(object sender, EventArgs e)
        {
            SelectedElement = Element.Europium;
            ShowElement_Button.Text = $"Show {SelectedElement}";
        }

        private void Gadolinium_Label_Click(object sender, EventArgs e)
        {
            SelectedElement = Element.Gadolinium;
            ShowElement_Button.Text = $"Show {SelectedElement}";
        }

        private void Terbium_Label_Click(object sender, EventArgs e)
        {
            SelectedElement = Element.Terbium;
            ShowElement_Button.Text = $"Show {SelectedElement}";
        }

        private void Dysprosium_Label_Click(object sender, EventArgs e)
        {
            SelectedElement = Element.Dysprosium;
            ShowElement_Button.Text = $"Show {SelectedElement}";
        }

        private void Holmium_Label_Click(object sender, EventArgs e)
        {
            SelectedElement = Element.Holmium;
            ShowElement_Button.Text = $"Show {SelectedElement}";
        }

        private void Erbium_Label_Click(object sender, EventArgs e)
        {
            SelectedElement = Element.Erbium;
            ShowElement_Button.Text = $"Show {SelectedElement}";
        }

        private void Thulium_Label_Click(object sender, EventArgs e)
        {
            SelectedElement = Element.Thulium;
            ShowElement_Button.Text = $"Show {SelectedElement}";
        }

        private void Ytterbium_Label_Click(object sender, EventArgs e)
        {
            SelectedElement = Element.Ytterbium;
            ShowElement_Button.Text = $"Show {SelectedElement}";
        }

        private void Lutetium_Label_Click(object sender, EventArgs e)
        {
            SelectedElement = Element.Lutetium;
            ShowElement_Button.Text = $"Show {SelectedElement}";
        }

        private void Actinium_Label_Click(object sender, EventArgs e)
        {
            SelectedElement = Element.Actinium;
            ShowElement_Button.Text = $"Show {SelectedElement}";
        }

        private void Thorium_Label_Click(object sender, EventArgs e)
        {
            SelectedElement = Element.Thorium;
            ShowElement_Button.Text = $"Show {SelectedElement}";
        }

        private void Protactinium_Label_Click(object sender, EventArgs e)
        {
            SelectedElement = Element.Protactinium;
            ShowElement_Button.Text = $"Show {SelectedElement}";
        }

        private void Uranium_Label_Click(object sender, EventArgs e)
        {
            SelectedElement = Element.Uranium;
            ShowElement_Button.Text = $"Show {SelectedElement}";
        }

        private void Neptunium_Label_Click(object sender, EventArgs e)
        {
            SelectedElement = Element.Neptunium;
            ShowElement_Button.Text = $"Show {SelectedElement}";
        }

        private void Plutonium_Label_Click(object sender, EventArgs e)
        {
            SelectedElement = Element.Plutonium;
            ShowElement_Button.Text = $"Show {SelectedElement}";
        }

        private void Americium_Label_Click(object sender, EventArgs e)
        {
            SelectedElement = Element.Americium;
            ShowElement_Button.Text = $"Show {SelectedElement}";
        }

        private void Curium_Label_Click(object sender, EventArgs e)
        {
            SelectedElement = Element.Curium;
            ShowElement_Button.Text = $"Show {SelectedElement}";
        }

        private void Berkelium_Label_Click(object sender, EventArgs e)
        {
            SelectedElement = Element.Berkelium;
            ShowElement_Button.Text = $"Show {SelectedElement}";
        }

        private void Californium_Label_Click(object sender, EventArgs e)
        {
            SelectedElement = Element.Californium;
            ShowElement_Button.Text = $"Show {SelectedElement}";
        }

        private void Einsteinium_Label_Click(object sender, EventArgs e)
        {
            SelectedElement = Element.Einsteinium;
            ShowElement_Button.Text = $"Show {SelectedElement}";
        }

        private void Fermium_Label_Click(object sender, EventArgs e)
        {
            SelectedElement = Element.Fermium;
            ShowElement_Button.Text = $"Show {SelectedElement}";
        }

        private void Mendelevium_Label_Click(object sender, EventArgs e)
        {
            SelectedElement = Element.Mendelevium;
            ShowElement_Button.Text = $"Show {SelectedElement}";
        }

        private void Nobelium_Label_Click(object sender, EventArgs e)
        {
            SelectedElement = Element.Nobelium;
            ShowElement_Button.Text = $"Show {SelectedElement}";
        }

        private void Lawrencium_Label_Click(object sender, EventArgs e)
        {
            SelectedElement = Element.Lawrencium;
            ShowElement_Button.Text = $"Show {SelectedElement}";
        }
    }
}
