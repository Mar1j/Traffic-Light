namespace Traffic_Light
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.trafficLight2 = new Traffic_Light.TrafficLight();
            this.trafficLight1 = new Traffic_Light.TrafficLight();
            this.SuspendLayout();
            // 
            // trafficLight2
            // 
            this.trafficLight2.CurrentLight = Traffic_Light.TrafficLight.Traffic_Light.Red;
            this.trafficLight2.GreenTime = 5;
            this.trafficLight2.Location = new System.Drawing.Point(357, 92);
            this.trafficLight2.Name = "trafficLight2";
            this.trafficLight2.OrangeTime = 5;
            this.trafficLight2.RedTime = 5;
            this.trafficLight2.Size = new System.Drawing.Size(98, 210);
            this.trafficLight2.TabIndex = 1;
            this.trafficLight2.OnRedOn += new System.EventHandler<Traffic_Light.TrafficLight.TrafficLightEventArgs>(this.trafficLight2_OnRedOn);
            this.trafficLight2.OnOrangeOn += new System.EventHandler<Traffic_Light.TrafficLight.TrafficLightEventArgs>(this.trafficLight2_OnOrangeOn);
            this.trafficLight2.OnGreenOn += new System.EventHandler<Traffic_Light.TrafficLight.TrafficLightEventArgs>(this.trafficLight2_OnGreenOn);
            // 
            // trafficLight1
            // 
            this.trafficLight1.CurrentLight = Traffic_Light.TrafficLight.Traffic_Light.Red;
            this.trafficLight1.GreenTime = 10;
            this.trafficLight1.Location = new System.Drawing.Point(128, 92);
            this.trafficLight1.Name = "trafficLight1";
            this.trafficLight1.OrangeTime = 10;
            this.trafficLight1.RedTime = 10;
            this.trafficLight1.Size = new System.Drawing.Size(98, 210);
            this.trafficLight1.TabIndex = 0;
            this.trafficLight1.OnRedOn += new System.EventHandler<Traffic_Light.TrafficLight.TrafficLightEventArgs>(this.trafficLight1_OnRedOn_1);
            this.trafficLight1.OnOrangeOn += new System.EventHandler<Traffic_Light.TrafficLight.TrafficLightEventArgs>(this.trafficLight1_OnOrangeOn_1);
            this.trafficLight1.OnGreenOn += new System.EventHandler<Traffic_Light.TrafficLight.TrafficLightEventArgs>(this.trafficLight1_OnGreenOn_1);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.trafficLight2);
            this.Controls.Add(this.trafficLight1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private TrafficLight trafficLight1;
        private TrafficLight trafficLight2;
    }
}

