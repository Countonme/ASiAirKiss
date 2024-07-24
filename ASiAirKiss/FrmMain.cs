using ASiAirKiss.Model;
using ASiAirKiss.Services;
using Sunny.UI;
using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace ASiAirKiss
{
    public partial class FrmMain : UIForm
    {
        /// <summary>
        /// 服务层注入
        /// </summary>
        private readonly AirkissServices service;
        public FrmMain()
        {
            InitializeComponent();
            service = new AirkissServices(this);
            this.btnStart.Click += BtnStart_Click;
            this.btnStop.Click += BtnStop_Click;
            this.Text += $"_Version:{Application.ProductVersion}";
        }

        /// <summary>
        /// 停止UDP 广播
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnStop_Click(object sender, EventArgs e)
        {

            ShowStop();
        }

        /// <summary>
        /// 启动UDP 广播
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
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
                service.StopBroadcasting();
                service.StartBroadcasting(flag.message);
                ShowStart();
            }
            else
            {
                ShowStop();


            }





        }


        /// <summary>
        /// ShowStop显示停止
        /// </summary>
        public void ShowStop()
        {
            service.StopBroadcasting();
            ledStatus.OnColor = Color.Red;
            txtStatus.Text = "广播已停止";
            ledStatus.State = UILightState.Blink;
        }


        /// <summary>
        /// ShowStart 显示启动
        /// </summary>
        public void ShowStart()
        {

            ledStatus.OnColor = Color.SpringGreen;
            txtStatus.Text = "广播已启动";
            ledStatus.State = UILightState.Blink;
            ShowMessage("广播已启动" + Environment.NewLine);

        }

        public void ShowMessage(string message)
        {

            uiRichTextBox1.BeginInvoke(new Action(() =>
            {

                uiRichTextBox1.Text = message;
                if (RadioSaveLogs.Checked)
                {

                    string path = Application.StartupPath + @"\logs\" + DateTime.Now.ToString("yyyyMMdd");
                    if (!Directory.Exists(path))
                    {

                        Directory.CreateDirectory(path);
                    }
                    string fileName = DateTime.Now.ToString("yyyyMMddHH") + ".log";
                    File.AppendAllText($@"{path}\{fileName}", message);

                }


            }));


        }

    }
}
