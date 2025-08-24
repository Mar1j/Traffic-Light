using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Traffic_Light
{
    public partial class Form1 : Form
    {
        public Form1()
        {// I add this comment to test Laferrari branch
            // I am Still Testing

            InitializeComponent();
           trafficLight1.Start();
        }

      

           
            


        private void trafficLight1_OnGreenOn_1(object sender, TrafficLight.TrafficLightEventArgs e)
        {
          
            trafficLight2.CurrentLight = e._CurrentLight;
            trafficLight2.Start();
        }

        private void trafficLight1_OnOrangeOn_1(object sender, TrafficLight.TrafficLightEventArgs e)
        {
            MessageBox.Show("Get Ready", $"Current Light is {e._CurrentLight} ");
        }

        private void trafficLight1_OnRedOn_1(object sender, TrafficLight.TrafficLightEventArgs e)
        {
            MessageBox.Show("Lines Up", $"Current Light is {e._CurrentLight} ");
        }

        private void trafficLight2_OnGreenOn(object sender, TrafficLight.TrafficLightEventArgs e)
        {
            MessageBox.Show("T2", $"Current Light is {e._CurrentLight} ");
        }

        private void trafficLight2_OnOrangeOn(object sender, TrafficLight.TrafficLightEventArgs e)
        {
            MessageBox.Show("T2", $"Current Light is {e._CurrentLight} ");
        }

        private void trafficLight2_OnRedOn(object sender, TrafficLight.TrafficLightEventArgs e)
        {
            MessageBox.Show("T2", $"Current Light is {e._CurrentLight} ");
        }
    }


}
