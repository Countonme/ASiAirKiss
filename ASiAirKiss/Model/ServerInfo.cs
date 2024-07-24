namespace ASiAirKiss.Model
{
    public class ServerInfo
    {
        /// <summary>
        /// OTA Server
        /// </summary>
        public static string OTA_SERVER { get; set; }
        /// <summary>
        /// mqttServer
        /// </summary>
        public static string MQTT_SERVER { get; set; }
        /// <summary>
        /// mqtt 端口
        /// </summary>
        public static int MQTT_PORT { get; set; }
        /// <summary>
        /// wifi 名称
        /// </summary>
        public static string SSID_NAME { get; set; }
        /// <summary>
        /// 密码
        /// </summary>
        public static string PASSWORD { get; set; }
    }
}
