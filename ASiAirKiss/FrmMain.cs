using ASiAirKiss.Model;
using ASiAirKiss.Services;
using Sunny.UI;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace ASiAirKiss
{
    public partial class FrmMain : UIForm
    {
        AirkissServices service = new AirkissServices();
        public FrmMain()
        {
            InitializeComponent();
            this.btnStart.Click += BtnStart_Click;
            this.btnStop.Click += BtnStop_Click;
            this.Text += $"_Version:{Application.ProductVersion}";
        }

        private void BtnStop_Click(object sender, EventArgs e)
        {
            service.StopBroadcasting();
            uiRichTextBox1.Text += "广播已停止" + Environment.NewLine;
            ledStatus.OnColor = Color.Red;
            txtStatus.Text = "广播已停止";
            ledStatus.State = UILightState.Blink;
        }

        private void BtnStart_Click(object sender, EventArgs e)
        {
            var flag = service.CheckBroadcastSupport();


            if (flag.flag)
            {
                ServerInfo.OTA_SERVER = txtOTAServer.Text;
                ServerInfo.MQTT_SERVER = txtMqttServer.Text;
                ServerInfo.MQTT_PORT = txtMqttPort.IntValue;
                ServerInfo.SSID_NAME = txtSSID.Text;
                ServerInfo.PASSWORD = txtPassword.Text;
                ledStatus.OnColor = Color.SpringGreen;
                txtStatus.Text = "广播已启动";
                ledStatus.State = UILightState.Blink;
                service.StartBroadcasting();
                uiRichTextBox1.Text += "广播已启动" + Environment.NewLine;
            }
            else
            {

                ledStatus.OnColor = Color.Red;
                txtStatus.Text = "广播已停止";
                ledStatus.State = UILightState.Blink;

            }


        }


    }
}
