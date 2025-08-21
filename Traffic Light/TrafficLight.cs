using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Traffic_Light.Properties;

namespace Traffic_Light
{
    public partial class TrafficLight : UserControl
    {


        public enum Traffic_Light { Red, Green, Orange }

        private Traffic_Light _CurrentLight = Traffic_Light.Red;
        public class TrafficLightEventArgs : EventArgs
        {
          public Traffic_Light _CurrentLight { get; }
          public int LightDuration { get; }
            public TrafficLightEventArgs(Traffic_Light currentLight, int lightDuration)
            {
                _CurrentLight = currentLight;
                LightDuration = lightDuration;
            }
    
            
        }

        public int RedTime
        {
            get
            {
                return _RedTime;


            }
            set
            {
                _RedTime = value;
            }
        }

        public Traffic_Light CurrentLight 
        {
            get
            {
                return _CurrentLight;
            }
            set
            {
                _CurrentLight = value;
             

                switch (_CurrentLight)
                {
                    case Traffic_Light.Red :

                        pictureBox1.Image = Resources.Red;
                        lb_Timer.ForeColor = Color.Red;
                        _CurrentCountDownValue = _RedTime;
                        break;

                    case Traffic_Light.Orange:

                        pictureBox1.Image = Resources.Orange;
                        lb_Timer.ForeColor = Color.Orange;
                        _CurrentCountDownValue = _OrangeTime;
                        break;
                    case Traffic_Light.Green:

                        pictureBox1.Image = Resources.Green;
                        lb_Timer.ForeColor = Color.Green;
                        _CurrentCountDownValue = _GreenTime;
                        break;


                }
            }
       
        }

     








        // Event for the Red Traffic Light
        public event EventHandler<TrafficLightEventArgs> OnRedOn;

        public void  RaiseOnRedON()
        {
            OnRedOn(this, new TrafficLightEventArgs(Traffic_Light.Red, _RedTime));//why i did not use _CurrentLight to get the current light

        }
        protected virtual void OnRedON(object Sender,TrafficLightEventArgs e)
        {
            OnRedOn ?.Invoke (Sender, e);
        }


        // Event for the Orange Traffic Light

        public event EventHandler<TrafficLightEventArgs> OnOrangeOn;
        public void RaiseOnOrangeON()
        {
            OnOrangeOn(this, new TrafficLightEventArgs(Traffic_Light.Orange, _RedTime));

        }

        protected virtual void OnOrangeON(object Sender, TrafficLightEventArgs e)
        {
            OnOrangeOn?.Invoke(Sender, e);
        }

        //Event For The Green Traffic Light



        public event EventHandler<TrafficLightEventArgs> OnGreenOn;
        public void RaiseOnGreenON()
        {
            OnGreenOn(this, new TrafficLightEventArgs(Traffic_Light.Green, _RedTime));

        }

        protected virtual void OnGreenON(object Sender, TrafficLightEventArgs e)
        {
            OnGreenOn?.Invoke(Sender, e);
        }


        private int _RedTime ;
        private int _OrangeTime;
        private int _GreenTime;
       

        public int OrangeTime
        {
            get
            {
                return _OrangeTime;


            }
            set
            {
                _OrangeTime = value;
            }
        }

        public int GreenTime
        {
            get
            {
                return _GreenTime;


            }
            set
            {
                _GreenTime = value;
            }
        }


        private int _CurrentCountDownValue;



        void ChangeColor ()
        {

            switch (_CurrentLight)
            {

                case Traffic_Light.Red:

                _CurrentLight = Traffic_Light.Orange;
                 _CurrentCountDownValue = _RedTime;
                    pictureBox1.Image = Resources.Red;
                    lb_Timer.ForeColor = Color.Red;

                    RaiseOnRedON();
                    break;

                case Traffic_Light.Orange:
                    _CurrentLight = Traffic_Light.Green;
                    _CurrentCountDownValue = _OrangeTime;
                    pictureBox1.Image = Resources.Orange;
                    lb_Timer.ForeColor = Color.Orange;

                    RaiseOnOrangeON();

                    break;

                case Traffic_Light.Green:
                    _CurrentLight = Traffic_Light.Red;
                    _CurrentCountDownValue = _GreenTime;
                    pictureBox1.Image= Resources.Green;
                    lb_Timer.ForeColor = Color.Green;

                    RaiseOnGreenON();
                    break;
            }
        }


        private void Timer_Tick(object sender, EventArgs e)
        {
            lb_Timer.Text = _CurrentCountDownValue.ToString();
            if(_CurrentCountDownValue==0)
            {
                ChangeColor();

            }
            else
            {
                --_CurrentCountDownValue;
            }

        
        }
        public Timer T = new Timer();

        public TrafficLight()
        {
            InitializeComponent();
          
            T.Interval = 1000;
            T.Tick += Timer_Tick;

        }

        public void Start()
        {
            T.Start();
        }
    }
}