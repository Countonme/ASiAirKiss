#region << 版 本 注 释 >>
/*----------------------------------------------------------------
 * 版权所有 (c) 2024 Shengbi NJRN 保留所有权利。
 * CLR版本：4.0.30319.42000
 * 机器名称：REDEEMER
 * 公司名称：国际开源协会
 * 唯一标识：30b7da02-9b9f-4544-82bf-1aad5a3ef69a
 * 文件名：AirkissServices
 * 当前用户域：REDEEMER
 * 
 * 创建者：Shengbi
 * 电子邮箱：（yysvent@163.com）
 * Github  ：https://github.com/Countonme
 * 创建时间：2024/7/24 16:21:57
 * 版本：V1.0.0
 * 描述：初始版本
 *  
 * 1.在追求理想的道路上，剑锋所指，坚韧与担当铸就人生的意义
 * 2.开源是遍地生花的最好方法， 闭源是确保利益不受损害的最好方法
 * 3.预测未来的最好方法就是去创造它 
 * 承接 Web/小程序/App/测试系统/AI/视觉/卷积网络神经/物联网/等项目开发
 * ----------------------------------------------------------------
 * 修改人：
 * 时间：
 * 修改说明：
 *
 * 版本：V1.0.1
 *----------------------------------------------------------------*/

#endregion << 版 本 注 释 >>
using ASiAirKiss.Model;
using Newtonsoft.Json;
using System;
using System.Management;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ASiAirKiss.Services
{
    public class AirkissServices
    {
        /// <summary>
        /// 多线程 
        /// </summary>

        private CancellationTokenSource _cancellationTokenSource;
        private Task _broadcastTask;
        /// <summary>
        /// 初始化
        /// </summary>
        /// 
        private readonly FrmMain _frm;
        /// <summary>
        /// AirkissServices
        /// </summary>
        /// <param name="frm"></param>
        public AirkissServices(FrmMain frm)
        {
            _frm = frm;


        }

        /// <summary>
        /// 检查网卡是否支持广播
        /// </summary>
        /// <returns></returns>
        public (bool flag, string message) CheckBroadcastSupport()
        {
            try
            {
                var searcher = new ManagementObjectSearcher("SELECT * FROM Win32_NetworkAdapter WHERE NetConnectionStatus=2");
                foreach (ManagementObject queryObj in searcher.Get())
                {
                    string adapterName = queryObj["Name"].ToString();
                    bool isWireless = adapterName.ToLower().Contains("wireless") || adapterName.ToLower().Contains("wi-fi");

                    if (isWireless)
                    {
                        try
                        {
                            using (UdpClient udpClient = new UdpClient())
                            {
                                udpClient.EnableBroadcast = true;
                                IPEndPoint endPoint = new IPEndPoint(IPAddress.Broadcast, 10000);
                                byte[] sendBytes = Encoding.UTF8.GetBytes("Test Broadcast Message");

                                udpClient.Send(sendBytes, sendBytes.Length, endPoint);
                                return (true, $"网卡 {adapterName} 支持广播功能");
                            }
                        }
                        catch (SocketException ex)
                        {
                            return (false, $"发送广播消息时出错: {ex.Message}");
                        }
                    }
                }
            }
            catch (ManagementException ex)
            {
                return (false, $"检查广播支持时出错: {ex.Message}");
            }

            return (false, "未找到支持广播功能的无线网卡");
        }

        /// <summary>
        /// 获取网卡地址
        /// </summary>
        /// <param name="adapterName"></param>
        /// <returns></returns>
        private string GetWirelessAdapterIPAddress(string adapterName)
        {
            var host = Dns.GetHostEntry(Dns.GetHostName());
            foreach (var ip in host.AddressList)
            {
                if (ip.AddressFamily == AddressFamily.InterNetwork)
                {
                    var adapters = System.Net.NetworkInformation.NetworkInterface.GetAllNetworkInterfaces();
                    foreach (var adapter in adapters)
                    {
                        if (adapter.Name == adapterName)
                        {
                            var properties = adapter.GetIPProperties();
                            foreach (var unicast in properties.UnicastAddresses)
                            {
                                if (unicast.Address.AddressFamily == AddressFamily.InterNetwork)
                                {
                                    return unicast.Address.ToString();
                                }
                            }
                        }
                    }
                }
            }
            return null;
        }

        /// <summary>
        /// 开启广播
        /// </summary>
        public void StartBroadcasting(string adapterName)
        {
            _cancellationTokenSource = new CancellationTokenSource();
            _broadcastTask = Task.Run(() => BroadcastLoop(adapterName, _cancellationTokenSource.Token));
        }

        /// <summary>
        /// 停止广播
        /// </summary>
        public void StopBroadcasting()
        {
            if (_cancellationTokenSource != null)
            {
                _cancellationTokenSource.Cancel();
            }
        }

        /// <summary>
        /// 循环监听
        /// </summary>
        /// <param name="adapterName"></param>
        /// <param name="token"></param>
        private void BroadcastLoop(string adapterName, CancellationToken token)
        {
            try
            {
                using (UdpClient udpClient = new UdpClient())
                {
                    udpClient.EnableBroadcast = true;
                    IPEndPoint endPoint = new IPEndPoint(IPAddress.Broadcast, 10000);


                    while (!token.IsCancellationRequested)
                    {
                        ServerInfo server = new ServerInfo();
                        string data = JsonConvert.SerializeObject(new
                        {
                            OTA_SERVER = ServerInfo.OTA_SERVER,
                            MQTT_SERVER = ServerInfo.MQTT_SERVER,
                            MQTT_PORT = ServerInfo.MQTT_PORT,
                            SSID_NAME = ServerInfo.SSID_NAME,
                            PASSWORD = ServerInfo.PASSWORD
                        }, Formatting.Indented);

                        _frm.ShowMessage($"{adapterName}\r\n{DateTime.Now}\r\nData:\r\n {data}");

                        byte[] sendBytes = Encoding.UTF8.GetBytes(data);
                        udpClient.Send(sendBytes, sendBytes.Length, endPoint);
                        Task.Delay(1000).Wait();
                    }
                }
            }
            catch (Exception ex)
            {
                // 处理异常
                _frm.ShowMessage(ex.Message);
            }
        }
    }
}
