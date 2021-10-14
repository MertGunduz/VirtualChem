using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace VirtualChem.Forms
{
    public partial class VirtualChem_ElementMenu : Form
    {
        public VirtualChem_ElementMenu()
        {
            InitializeComponent();
        }

        private void VirtualChem_ElementMenu_Load(object sender, EventArgs e)
        {
            Element_Label.Text = VirtualChem_MainMenu.SelectedElement.ToString();

            switch (VirtualChem_MainMenu.SelectedElement)
            {
                case VirtualChem_MainMenu.Element.Hydrogen:
                    Series_TextBox.Text += " Reactive Nonmetals";
                    Weight_TextBox.Text += " 1.008u";
                    MeltingPoint_TextBox.Text += " -259.1 Degree Celcius";
                    BoilingPoint_TextBox.Text += " -252.9 Degree Celcius";
                    Radius_TextBox.Text += " 53pm";
                    Discovered_TextBox.Text += " 1766";
                    break;
                case VirtualChem_MainMenu.Element.Helium:
                    Series_TextBox.Text += " Noble Gases";
                    Weight_TextBox.Text += " 4.002602u";
                    MeltingPoint_TextBox.Text += " N/A";
                    BoilingPoint_TextBox.Text += " -269 Degree Celcius";
                    Radius_TextBox.Text += " 31pm";
                    Discovered_TextBox.Text += " 1895";
                    break;
                case VirtualChem_MainMenu.Element.Lithium:
                    Series_TextBox.Text += " Alkali Metals";
                    Weight_TextBox.Text += " 6.94u";
                    MeltingPoint_TextBox.Text += " 180.54 Degree Celcius";
                    BoilingPoint_TextBox.Text += " 1,342 Degree Celcius";
                    Radius_TextBox.Text += " 167pm";
                    Discovered_TextBox.Text += " 1817";
                    break;
                case VirtualChem_MainMenu.Element.Beryllium:
                    Series_TextBox.Text += " Alkaline Earth Metals";
                    Weight_TextBox.Text += " 9.0121831u";
                    MeltingPoint_TextBox.Text += " 1,287 Degree Celcius";
                    BoilingPoint_TextBox.Text += " 2,470 Degree Celcius";
                    Radius_TextBox.Text += " 112pm";
                    Discovered_TextBox.Text += " 1797";
                    break;
                case VirtualChem_MainMenu.Element.Boron:
                    Series_TextBox.Text += " Metalloids";
                    Weight_TextBox.Text += " 10.81u";
                    MeltingPoint_TextBox.Text += " 2,075 Degree Celcius";
                    BoilingPoint_TextBox.Text += " 4,000 Degree Celcius";
                    Radius_TextBox.Text += " 87pm";
                    Discovered_TextBox.Text += " 1808";
                    break;
                case VirtualChem_MainMenu.Element.Carbon:
                    Series_TextBox.Text += " Reactive Nonmetals";
                    Weight_TextBox.Text += " 12.011u";
                    MeltingPoint_TextBox.Text += " 3,642 Degree Celcius";
                    BoilingPoint_TextBox.Text += " 3,642 Degree Celcius";
                    Radius_TextBox.Text += " 67pm";
                    Discovered_TextBox.Text += " 3750 BCE";
                    break;
                case VirtualChem_MainMenu.Element.Nitrogen:
                    Series_TextBox.Text += " Reactive Nonmetals";
                    Weight_TextBox.Text += " 14.007u";
                    MeltingPoint_TextBox.Text += " -210.1 Degree Celcius";
                    BoilingPoint_TextBox.Text += " -195.8 Degree Celcius";
                    Radius_TextBox.Text += " 56pm";
                    Discovered_TextBox.Text += " 1772";
                    break;
                case VirtualChem_MainMenu.Element.Oxygen:
                    Series_TextBox.Text += " Reactive Nonmetals";
                    Weight_TextBox.Text += " 15.999u";
                    MeltingPoint_TextBox.Text += " -218 Degree Celcius";
                    BoilingPoint_TextBox.Text += " -183 Degree Celcius";
                    Radius_TextBox.Text += " 48pm";
                    Discovered_TextBox.Text += " 1774";
                    break;
                case VirtualChem_MainMenu.Element.Fluorine:
                    Series_TextBox.Text += " Reactive Nonmetals";
                    Weight_TextBox.Text += " 18.998403163u";
                    MeltingPoint_TextBox.Text += " -220 Degree Celcius";
                    BoilingPoint_TextBox.Text += " -188.1 Degree Celcius";
                    Radius_TextBox.Text += " 42pm";
                    Discovered_TextBox.Text += " 1886";
                    break;
                case VirtualChem_MainMenu.Element.Neon:
                    Series_TextBox.Text += " Noble Gases";
                    Weight_TextBox.Text += " 20.1797u";
                    MeltingPoint_TextBox.Text += " -248.6 Degree Celcius";
                    BoilingPoint_TextBox.Text += " -246.1 Degree Celcius";
                    Radius_TextBox.Text += " 38pm";
                    Discovered_TextBox.Text += " 1898";
                    break;
                case VirtualChem_MainMenu.Element.Natrium:
                    Series_TextBox.Text += " Alkali Metals";
                    Weight_TextBox.Text += " 22.98976928u";
                    MeltingPoint_TextBox.Text += " 97.720 Degree Celcius";
                    BoilingPoint_TextBox.Text += " 882.9 Degree Celcius";
                    Radius_TextBox.Text += " 190pm";
                    Discovered_TextBox.Text += " 1807";
                    break;
                case VirtualChem_MainMenu.Element.Magnesium:
                    Series_TextBox.Text += " Alkaline Earth Metals";
                    Weight_TextBox.Text += " 24.305u";
                    MeltingPoint_TextBox.Text += " 650 Degree Celcius";
                    BoilingPoint_TextBox.Text += " 1,090 Degree Celcius";
                    Radius_TextBox.Text += " 145pm";
                    Discovered_TextBox.Text += " 1755";
                    break;
                case VirtualChem_MainMenu.Element.Aluminum:
                    Series_TextBox.Text += " Alkaline Earth Metals";
                    Weight_TextBox.Text += " 24.305u";
                    MeltingPoint_TextBox.Text += " 650 Degree Celcius";
                    BoilingPoint_TextBox.Text += " 1,090 Degree Celcius";
                    Radius_TextBox.Text += " 145pm";
                    Discovered_TextBox.Text += " 1755";
                    break;
                case VirtualChem_MainMenu.Element.Silicon:
                    Series_TextBox.Text += " Metalloids";
                    Weight_TextBox.Text += " 28.085u";
                    MeltingPoint_TextBox.Text += " 1,414 Degree Celcius";
                    BoilingPoint_TextBox.Text += " 2,900 Degree Celcius";
                    Radius_TextBox.Text += " 111pm";
                    Discovered_TextBox.Text += " 1824";
                    break;
                case VirtualChem_MainMenu.Element.Phosphorus:
                    Series_TextBox.Text += " Reactive Nonmetals";
                    Weight_TextBox.Text += " 30.973761998u";
                    MeltingPoint_TextBox.Text += " 44.15 Degree Celcius";
                    BoilingPoint_TextBox.Text += " 280.5 Degree Celcius";
                    Radius_TextBox.Text += " 98pm";
                    Discovered_TextBox.Text += " 1669";
                    break;
                case VirtualChem_MainMenu.Element.Sulfur:
                    Series_TextBox.Text += " Reactive Nonmetals";
                    Weight_TextBox.Text += " 32.06u";
                    MeltingPoint_TextBox.Text += " 115.21 Degree Celcius";
                    BoilingPoint_TextBox.Text += " 444.72 Degree Celcius";
                    Radius_TextBox.Text += " 88pm";
                    Discovered_TextBox.Text += " 500 BCE";
                    break;
                case VirtualChem_MainMenu.Element.Chlorine:
                    Series_TextBox.Text += " Reactive Nonmetals";
                    Weight_TextBox.Text += " 35.45u";
                    MeltingPoint_TextBox.Text += " -101.5 Degree Celcius";
                    BoilingPoint_TextBox.Text += " -34.04 Degree Celcius";
                    Radius_TextBox.Text += " 79pm";
                    Discovered_TextBox.Text += " 1774";
                    break;
                case VirtualChem_MainMenu.Element.Argon:
                    Series_TextBox.Text += " Noble Gases";
                    Weight_TextBox.Text += " 39.948u";
                    MeltingPoint_TextBox.Text += " -189 Degree Celcius";
                    BoilingPoint_TextBox.Text += " -186 Degree Celcius";
                    Radius_TextBox.Text += " 71pm";
                    Discovered_TextBox.Text += " 1894";
                    break;
                case VirtualChem_MainMenu.Element.Potassium:
                    Series_TextBox.Text += " Alkali Metals";
                    Weight_TextBox.Text += " 39.0983u";
                    MeltingPoint_TextBox.Text += " 63.380 Degree Celcius";
                    BoilingPoint_TextBox.Text += " 758.9 Degree Celcius";
                    Radius_TextBox.Text += " 243pm";
                    Discovered_TextBox.Text += " 1807";
                    break;
                case VirtualChem_MainMenu.Element.Calcium:
                    Series_TextBox.Text += " Alkaline Earth Metals";
                    Weight_TextBox.Text += " 40.078u";
                    MeltingPoint_TextBox.Text += " 841.9 Degree Celcius";
                    BoilingPoint_TextBox.Text += " 1,484 Degree Celcius";
                    Radius_TextBox.Text += " 194pm";
                    Discovered_TextBox.Text += " 1808";
                    break;
                case VirtualChem_MainMenu.Element.Scandium:
                    Series_TextBox.Text += " Transition Metal";
                    Weight_TextBox.Text += " 44.955908u";
                    MeltingPoint_TextBox.Text += " 1,541 Degree Celcius";
                    BoilingPoint_TextBox.Text += " 2,830 Degree Celcius";
                    Radius_TextBox.Text += " 184pm";
                    Discovered_TextBox.Text += " 1879";
                    break;
                case VirtualChem_MainMenu.Element.Titanium:
                    Series_TextBox.Text += " Transition Metal";
                    Weight_TextBox.Text += " 47.867u";
                    MeltingPoint_TextBox.Text += " 1,668 Degree Celcius";
                    BoilingPoint_TextBox.Text += " 3,287 Degree Celcius";
                    Radius_TextBox.Text += " 176pm";
                    Discovered_TextBox.Text += " 1791";
                    break;
                case VirtualChem_MainMenu.Element.Vanadium:
                    Series_TextBox.Text += " Transition Metal";
                    Weight_TextBox.Text += " 50.9415u";
                    MeltingPoint_TextBox.Text += " 1,910 Degree Celcius";
                    BoilingPoint_TextBox.Text += " 3,407 Degree Celcius";
                    Radius_TextBox.Text += " 171pm";
                    Discovered_TextBox.Text += " 1801";
                    break;
                case VirtualChem_MainMenu.Element.Chromium:
                    Series_TextBox.Text += " Transition Metal";
                    Weight_TextBox.Text += " 51.9961u";
                    MeltingPoint_TextBox.Text += " 1,907 Degree Celcius";
                    BoilingPoint_TextBox.Text += " 2,671 Degree Celcius";
                    Radius_TextBox.Text += " 166pm";
                    Discovered_TextBox.Text += " 1797";
                    break;
                case VirtualChem_MainMenu.Element.Manganese:
                    Series_TextBox.Text += " Transition Metal";
                    Weight_TextBox.Text += " 54.938044u";
                    MeltingPoint_TextBox.Text += " 1,246 Degree Celcius";
                    BoilingPoint_TextBox.Text += " 2,061 Degree Celcius";
                    Radius_TextBox.Text += " 161pm";
                    Discovered_TextBox.Text += " 1774";
                    break;
                case VirtualChem_MainMenu.Element.Iron:
                    Series_TextBox.Text += " Transition Metal";
                    Weight_TextBox.Text += " 55.845u";
                    MeltingPoint_TextBox.Text += " 1,538 Degree Celcius";
                    BoilingPoint_TextBox.Text += " 2,861 Degree Celcius";
                    Radius_TextBox.Text += " 156pm";
                    Discovered_TextBox.Text += " 2000 BCE";
                    break;
                case VirtualChem_MainMenu.Element.Cobalt:
                    Series_TextBox.Text += " Transition Metal";
                    Weight_TextBox.Text += " 58.933194u";
                    MeltingPoint_TextBox.Text += " 1,495 Degree Celcius";
                    BoilingPoint_TextBox.Text += " 2,900 Degree Celcius";
                    Radius_TextBox.Text += " 152pm";
                    Discovered_TextBox.Text += " 1735";
                    break;
                case VirtualChem_MainMenu.Element.Nickel:
                    Series_TextBox.Text += " Transition Metal";
                    Weight_TextBox.Text += " 58.6934u";
                    MeltingPoint_TextBox.Text += " 1,455 Degree Celcius";
                    BoilingPoint_TextBox.Text += " 2,913 Degree Celcius";
                    Radius_TextBox.Text += " 149pm";
                    Discovered_TextBox.Text += " 1751";
                    break;
                case VirtualChem_MainMenu.Element.Copper:
                    Series_TextBox.Text += " Transition Metal";
                    Weight_TextBox.Text += " 63.546u";
                    MeltingPoint_TextBox.Text += " 1,084 Degree Celcius";
                    BoilingPoint_TextBox.Text += " 2,562 Degree Celcius";
                    Radius_TextBox.Text += " 145pm";
                    Discovered_TextBox.Text += " 8000 BCE";
                    break;
                case VirtualChem_MainMenu.Element.Zinc:
                    Series_TextBox.Text += " Transition Metal";
                    Weight_TextBox.Text += " 65.38u";
                    MeltingPoint_TextBox.Text += " 419.53 Degree Celcius";
                    BoilingPoint_TextBox.Text += " 906.9 Degree Celcius";
                    Radius_TextBox.Text += " 142pm";
                    Discovered_TextBox.Text += " 1500";
                    break;
                case VirtualChem_MainMenu.Element.Gallium:
                    Series_TextBox.Text += " Post Transition Metal";
                    Weight_TextBox.Text += " 69.723u";
                    MeltingPoint_TextBox.Text += " 29.760 Degree Celcius";
                    BoilingPoint_TextBox.Text += " 2,204 Degree Celcius";
                    Radius_TextBox.Text += " 136pm";
                    Discovered_TextBox.Text += " 1875";
                    break;
                case VirtualChem_MainMenu.Element.Germanium:
                    Series_TextBox.Text += " Metalloid";
                    Weight_TextBox.Text += " 72.63u";
                    MeltingPoint_TextBox.Text += " 938.25 Degree Celcius";
                    BoilingPoint_TextBox.Text += " 2,820 Degree Celcius";
                    Radius_TextBox.Text += " 125pm";
                    Discovered_TextBox.Text += " 1886";
                    break;
                case VirtualChem_MainMenu.Element.Arsenic:
                    Series_TextBox.Text += " Metalloid";
                    Weight_TextBox.Text += " 74.921595u";
                    MeltingPoint_TextBox.Text += " 816.9 Degree Celcius";
                    BoilingPoint_TextBox.Text += " 614 Degree Celcius";
                    Radius_TextBox.Text += " 114pm";
                    Discovered_TextBox.Text += " 1250";
                    break;
                case VirtualChem_MainMenu.Element.Selenium:
                    Series_TextBox.Text += " Reactive Nonmetals";
                    Weight_TextBox.Text += " 78.971u";
                    MeltingPoint_TextBox.Text += " 221 Degree Celcius";
                    BoilingPoint_TextBox.Text += " 685 Degree Celcius";
                    Radius_TextBox.Text += " 103pm";
                    Discovered_TextBox.Text += " 1817";
                    break;
                case VirtualChem_MainMenu.Element.Bromine:
                    Series_TextBox.Text += " Reactive Nonmetals";
                    Weight_TextBox.Text += " 79.904u";
                    MeltingPoint_TextBox.Text += " -7.350 Degree Celcius";
                    BoilingPoint_TextBox.Text += " 58.9 Degree Celcius";
                    Radius_TextBox.Text += " 94pm";
                    Discovered_TextBox.Text += " 1826";
                    break;
                case VirtualChem_MainMenu.Element.Krypton:
                    Series_TextBox.Text += " Noble Gases";
                    Weight_TextBox.Text += " 83.798u";
                    MeltingPoint_TextBox.Text += " -157.36 Degree Celcius";
                    BoilingPoint_TextBox.Text += " -153.22 Degree Celcius";
                    Radius_TextBox.Text += " 88pm";
                    Discovered_TextBox.Text += " 1898";
                    break;
                case VirtualChem_MainMenu.Element.Rubidium:
                    Series_TextBox.Text += " Alkali Metals";
                    Weight_TextBox.Text += " 85.4678u";
                    MeltingPoint_TextBox.Text += " 39.310 Degree Celcius";
                    BoilingPoint_TextBox.Text += " 688 Degree Celcius";
                    Radius_TextBox.Text += " 265pm";
                    Discovered_TextBox.Text += " 1861";
                    break;
                case VirtualChem_MainMenu.Element.Strontium:
                    Series_TextBox.Text += " Alkaline Earth Metals";
                    Weight_TextBox.Text += " 87.62u";
                    MeltingPoint_TextBox.Text += " 776.9 Degree Celcius";
                    BoilingPoint_TextBox.Text += " 1,382 Degree Celcius";
                    Radius_TextBox.Text += " 219pm";
                    Discovered_TextBox.Text += " 1790";
                    break;
                case VirtualChem_MainMenu.Element.Yttrium:
                    Series_TextBox.Text += " Transition Metals";
                    Weight_TextBox.Text += " 88.90584u";
                    MeltingPoint_TextBox.Text += " 1,526 Degree Celcius";
                    BoilingPoint_TextBox.Text += " 3,345 Degree Celcius";
                    Radius_TextBox.Text += " 212pm";
                    Discovered_TextBox.Text += " 1794";
                    break;
                case VirtualChem_MainMenu.Element.Zirconium:
                    Series_TextBox.Text += " Transition Metals";
                    Weight_TextBox.Text += " 91.224u";
                    MeltingPoint_TextBox.Text += " 1,855 Degree Celcius";
                    BoilingPoint_TextBox.Text += " 4,409 Degree Celcius";
                    Radius_TextBox.Text += " 206pm";
                    Discovered_TextBox.Text += " 1789";
                    break;
                case VirtualChem_MainMenu.Element.Niobium:
                    Series_TextBox.Text += " Transition Metals";
                    Weight_TextBox.Text += " 92.90637u";
                    MeltingPoint_TextBox.Text += " 2,477 Degree Celcius";
                    BoilingPoint_TextBox.Text += " 4,744 Degree Celcius";
                    Radius_TextBox.Text += " 198pm";
                    Discovered_TextBox.Text += " 1801";
                    break;
                case VirtualChem_MainMenu.Element.Molybdenum:
                    Series_TextBox.Text += " Transition Metals";
                    Weight_TextBox.Text += " 95.95u";
                    MeltingPoint_TextBox.Text += " 2,623 Degree Celcius";
                    BoilingPoint_TextBox.Text += " 4,639 Degree Celcius";
                    Radius_TextBox.Text += " 190pm";
                    Discovered_TextBox.Text += " 1781";
                    break;
                case VirtualChem_MainMenu.Element.Technetium:
                    Series_TextBox.Text += " Transition Metals";
                    Weight_TextBox.Text += " 98u";
                    MeltingPoint_TextBox.Text += " 2,157 Degree Celcius";
                    BoilingPoint_TextBox.Text += " 4,265 Degree Celcius";
                    Radius_TextBox.Text += " 183pm";
                    Discovered_TextBox.Text += " 1937";
                    break;
                case VirtualChem_MainMenu.Element.Ruthenium:
                    Series_TextBox.Text += " Transition Metals";
                    Weight_TextBox.Text += " 101.07u";
                    MeltingPoint_TextBox.Text += " 2,334 Degree Celcius";
                    BoilingPoint_TextBox.Text += " 4,150 Degree Celcius";
                    Radius_TextBox.Text += " 178pm";
                    Discovered_TextBox.Text += " 1844";
                    break;
                case VirtualChem_MainMenu.Element.Rhodium:
                    Series_TextBox.Text += " Transition Metals";
                    Weight_TextBox.Text += " 102.90550u";
                    MeltingPoint_TextBox.Text += " 1,964 Degree Celcius";
                    BoilingPoint_TextBox.Text += " 3,695 Degree Celcius";
                    Radius_TextBox.Text += " 173pm";
                    Discovered_TextBox.Text += " 1803";
                    break;
                case VirtualChem_MainMenu.Element.Palladium:
                    Series_TextBox.Text += " Transition Metals";
                    Weight_TextBox.Text += " 106.42u";
                    MeltingPoint_TextBox.Text += " 1,554 Degree Celcius";
                    BoilingPoint_TextBox.Text += " 2,963 Degree Celcius";
                    Radius_TextBox.Text += " 173pm";
                    Discovered_TextBox.Text += " 1803";
                    break;
                case VirtualChem_MainMenu.Element.Silver:
                    Series_TextBox.Text += " Transition Metals";
                    Weight_TextBox.Text += " 107.8682u";
                    MeltingPoint_TextBox.Text += " 961 Degree Celcius";
                    BoilingPoint_TextBox.Text += " 2,162 Degree Celcius";
                    Radius_TextBox.Text += " 165pm";
                    Discovered_TextBox.Text += " 3000 BCE";
                    break;
                case VirtualChem_MainMenu.Element.Cadmium:
                    Series_TextBox.Text += " Transition Metals";
                    Weight_TextBox.Text += " 112.414u";
                    MeltingPoint_TextBox.Text += " 321 Degree Celcius";
                    BoilingPoint_TextBox.Text += " 766 Degree Celcius";
                    Radius_TextBox.Text += " 161pm";
                    Discovered_TextBox.Text += " 1817";
                    break;
                case VirtualChem_MainMenu.Element.Indium:
                    Series_TextBox.Text += " Post-Transition Metals";
                    Weight_TextBox.Text += " 114.818u";
                    MeltingPoint_TextBox.Text += " 156 Degree Celcius";
                    BoilingPoint_TextBox.Text += " 2,072 Degree Celcius";
                    Radius_TextBox.Text += " 156pm";
                    Discovered_TextBox.Text += " 1863";
                    break;
                case VirtualChem_MainMenu.Element.Tin:
                    Series_TextBox.Text += " Post-Transition Metals";
                    Weight_TextBox.Text += " 118.710u";
                    MeltingPoint_TextBox.Text += " 231 Degree Celcius";
                    BoilingPoint_TextBox.Text += " 2,602 Degree Celcius";
                    Radius_TextBox.Text += " 145pm";
                    Discovered_TextBox.Text += " 3000 BCE";
                    break;
                case VirtualChem_MainMenu.Element.Antimony:
                    Series_TextBox.Text += " Metalloids";
                    Weight_TextBox.Text += " 121.760u";
                    MeltingPoint_TextBox.Text += " 630 Degree Celcius";
                    BoilingPoint_TextBox.Text += " 1,587 Degree Celcius";
                    Radius_TextBox.Text += " 133pm";
                    Discovered_TextBox.Text += " 3000 BCE";
                    break;
                case VirtualChem_MainMenu.Element.Tellurium:
                    Series_TextBox.Text += " Metalloids";
                    Weight_TextBox.Text += " 127.60u";
                    MeltingPoint_TextBox.Text += " 449 Degree Celcius";
                    BoilingPoint_TextBox.Text += " 987 Degree Celcius";
                    Radius_TextBox.Text += " 123pm";
                    Discovered_TextBox.Text += " 1783";
                    break;
                case VirtualChem_MainMenu.Element.Iodine:
                    Series_TextBox.Text += " Reactive Nonmetals";
                    Weight_TextBox.Text += " 126.90447u";
                    MeltingPoint_TextBox.Text += " 113 Degree Celcius";
                    BoilingPoint_TextBox.Text += " 184 Degree Celcius";
                    Radius_TextBox.Text += " 115pm";
                    Discovered_TextBox.Text += " 1811";
                    break;
                case VirtualChem_MainMenu.Element.Xenon:
                    Series_TextBox.Text += " Noble Gases";
                    Weight_TextBox.Text += " 131.293u";
                    MeltingPoint_TextBox.Text += " -111.8 Degree Celcius";
                    BoilingPoint_TextBox.Text += " -108.0 Degree Celcius";
                    Radius_TextBox.Text += " 108pm";
                    Discovered_TextBox.Text += " 1898";
                    break;
                case VirtualChem_MainMenu.Element.Caesium:
                    Series_TextBox.Text += " Alkali Metals";
                    Weight_TextBox.Text += " 132.90545196u";
                    MeltingPoint_TextBox.Text += " 28.440 Degree Celcius";
                    BoilingPoint_TextBox.Text += " 671 Degree Celcius";
                    Radius_TextBox.Text += " 298pm";
                    Discovered_TextBox.Text += " 1860";
                    break;
                case VirtualChem_MainMenu.Element.Barium:
                    Series_TextBox.Text += " Alkaline Earth Metals";
                    Weight_TextBox.Text += " 137.327u";
                    MeltingPoint_TextBox.Text += " 730 Degree Celcius";
                    BoilingPoint_TextBox.Text += " 1,870 Degree Celcius";
                    Radius_TextBox.Text += " 253pm";
                    Discovered_TextBox.Text += " 1808";
                    break;
                case VirtualChem_MainMenu.Element.Hafnium:
                    Series_TextBox.Text += " Transition Metals";
                    Weight_TextBox.Text += " 178.486u";
                    MeltingPoint_TextBox.Text += " 2,233 Degree Celcius";
                    BoilingPoint_TextBox.Text += " 4,603 Degree Celcius";
                    Radius_TextBox.Text += " 208pm";
                    Discovered_TextBox.Text += " 1923";
                    break;

            }
        }

        private void Return_Button_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
