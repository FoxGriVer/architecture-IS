using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using AIS_lab5.EnergyUnitService;
using AIS_lab5.OurEnegryService;

namespace AIS_lab5
{
    public partial class Form1 : Form
    {
        public EnergyUnitSoapClient soapClient = new EnergyUnitSoapClient();
        public OurEnergyServiceSoapClient ourSoapClient = new OurEnergyServiceSoapClient();

        public Form1()
        {
            InitializeComponent();
        }     

        private void button1_Click(object sender, EventArgs e)
        {          
            double value = Convert.ToDouble(textBox_value.Text);
            OurEnegryService.Energys energyFrom = (OurEnegryService.Energys)comboBox_from.SelectedItem;
            OurEnegryService.Energys energyTo = (OurEnegryService.Energys)comboBox_to.SelectedItem;
            EnergyUnitService.Energys energyFrom2 = new EnergyUnitService.Energys();
            EnergyUnitService.Energys energyTo2 = (EnergyUnitService.Energys)comboBox_to.SelectedItem;

            foreach (var field in Enum.GetValues(typeof(EnergyUnitService.Energys)))
            {
                string check1 = Convert.ToString((OurEnegryService.Energys)energyFrom);
                string check2 = Convert.ToString((OurEnegryService.Energys)energyTo);                
                string check3 =Convert.ToString((EnergyUnitService.Energys)field);
                if(check1 == check3)
                {
                    energyFrom2 = (EnergyUnitService.Energys)field;
                }
                if (check2 == check3)
                {
                    energyTo2 = (EnergyUnitService.Energys)field;
                }
            }

            double result = soapClient.ChangeEnergyUnit(value, energyFrom2, energyTo2);
            label_result.Text = Convert.ToString(result);
        }

        private void Form1_Load(object sender, EventArgs e)
        {            
            textBox_value.Text = "1";                       
            comboBox_from.DataSource = Enum.GetValues(typeof(OurEnegryService.Energys));
            comboBox_from.SelectedItem = OurEnegryService.Energys.joule;
            comboBox_to.DataSource = Enum.GetValues(typeof(OurEnegryService.Energys));
            comboBox_to.SelectedItem = OurEnegryService.Energys.kilojoule;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            double value = Convert.ToDouble(textBox_value.Text);
            OurEnegryService.Energys energyFrom = (OurEnegryService.Energys)comboBox_from.SelectedItem;
            OurEnegryService.Energys energyTo = (OurEnegryService.Energys)comboBox_to.SelectedItem;

            double result = ourSoapClient.ChangeEnergyUnit(value, energyFrom, energyTo);
            label_result.Text = Convert.ToString(result);
        }
    }
}
