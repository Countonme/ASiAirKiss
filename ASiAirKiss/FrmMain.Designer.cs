namespace ASiAirKiss
{
    partial class FrmMain
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMain));
            this.btnStart = new Sunny.UI.UIButton();
            this.uiTitlePanel1 = new Sunny.UI.UITitlePanel();
            this.uiRichTextBox1 = new Sunny.UI.UIRichTextBox();
            this.txtMqttServer = new Sunny.UI.UIIPTextBox();
            this.ledStatus = new Sunny.UI.UILight();
            this.txtStatus = new Sunny.UI.UILinkLabel();
            this.btnStop = new Sunny.UI.UIButton();
            this.uiLinkLabel2 = new Sunny.UI.UILinkLabel();
            this.uiLinkLabel3 = new Sunny.UI.UILinkLabel();
            this.txtMqttPort = new Sunny.UI.UITextBox();
            this.uiLinkLabel4 = new Sunny.UI.UILinkLabel();
            this.uiLinkLabel5 = new Sunny.UI.UILinkLabel();
            this.txtPassword = new Sunny.UI.UITextBox();
            this.txtSSID = new Sunny.UI.UITextBox();
            this.uiLinkLabel6 = new Sunny.UI.UILinkLabel();
            this.txtOTAServer = new Sunny.UI.UIIPTextBox();
            this.uiTitlePanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnStart
            // 
            this.btnStart.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnStart.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(150)))), ((int)(((byte)(136)))));
            this.btnStart.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(150)))), ((int)(((byte)(136)))));
            this.btnStart.FillHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(171)))), ((int)(((byte)(160)))));
            this.btnStart.FillPressColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(120)))), ((int)(((byte)(109)))));
            this.btnStart.FillSelectedColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(120)))), ((int)(((byte)(109)))));
            this.btnStart.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnStart.Location = new System.Drawing.Point(4, 99);
            this.btnStart.MinimumSize = new System.Drawing.Size(1, 1);
            this.btnStart.Name = "btnStart";
            this.btnStart.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(150)))), ((int)(((byte)(136)))));
            this.btnStart.RectHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(171)))), ((int)(((byte)(160)))));
            this.btnStart.RectPressColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(120)))), ((int)(((byte)(109)))));
            this.btnStart.RectSelectedColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(120)))), ((int)(((byte)(109)))));
            this.btnStart.Size = new System.Drawing.Size(100, 35);
            this.btnStart.Style = Sunny.UI.UIStyle.Custom;
            this.btnStart.TabIndex = 0;
            this.btnStart.Text = "启动";
            this.btnStart.TipsFont = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            // 
            // uiTitlePanel1
            // 
            this.uiTitlePanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.uiTitlePanel1.Controls.Add(this.uiRichTextBox1);
            this.uiTitlePanel1.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uiTitlePanel1.Location = new System.Drawing.Point(4, 152);
            this.uiTitlePanel1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.uiTitlePanel1.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiTitlePanel1.Name = "uiTitlePanel1";
            this.uiTitlePanel1.ShowText = false;
            this.uiTitlePanel1.Size = new System.Drawing.Size(1015, 437);
            this.uiTitlePanel1.TabIndex = 1;
            this.uiTitlePanel1.Text = "Logs";
            this.uiTitlePanel1.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // uiRichTextBox1
            // 
            this.uiRichTextBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.uiRichTextBox1.FillColor = System.Drawing.Color.White;
            this.uiRichTextBox1.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uiRichTextBox1.Location = new System.Drawing.Point(0, 0);
            this.uiRichTextBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.uiRichTextBox1.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiRichTextBox1.Name = "uiRichTextBox1";
            this.uiRichTextBox1.Padding = new System.Windows.Forms.Padding(2);
            this.uiRichTextBox1.ScrollBarStyleInherited = false;
            this.uiRichTextBox1.ShowText = false;
            this.uiRichTextBox1.Size = new System.Drawing.Size(1015, 437);
            this.uiRichTextBox1.TabIndex = 0;
            this.uiRichTextBox1.Text = "Logs";
            this.uiRichTextBox1.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtMqttServer
            // 
            this.txtMqttServer.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            this.txtMqttServer.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtMqttServer.Location = new System.Drawing.Point(417, 77);
            this.txtMqttServer.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtMqttServer.MinimumSize = new System.Drawing.Size(1, 1);
            this.txtMqttServer.Name = "txtMqttServer";
            this.txtMqttServer.Padding = new System.Windows.Forms.Padding(1);
            this.txtMqttServer.ShowText = false;
            this.txtMqttServer.Size = new System.Drawing.Size(150, 29);
            this.txtMqttServer.TabIndex = 2;
            this.txtMqttServer.Text = "10.132.136.90";
            this.txtMqttServer.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            this.txtMqttServer.Value = ((System.Net.IPAddress)(resources.GetObject("txtMqttServer.Value")));
            // 
            // ledStatus
            // 
            this.ledStatus.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.ledStatus.Location = new System.Drawing.Point(9, 40);
            this.ledStatus.MinimumSize = new System.Drawing.Size(1, 1);
            this.ledStatus.Name = "ledStatus";
            this.ledStatus.OnColor = System.Drawing.Color.Red;
            this.ledStatus.Radius = 30;
            this.ledStatus.Size = new System.Drawing.Size(32, 30);
            this.ledStatus.TabIndex = 3;
            this.ledStatus.Text = "uiLight1";
            // 
            // txtStatus
            // 
            this.txtStatus.ActiveLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(160)))), ((int)(((byte)(255)))));
            this.txtStatus.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtStatus.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.txtStatus.LinkBehavior = System.Windows.Forms.LinkBehavior.AlwaysUnderline;
            this.txtStatus.Location = new System.Drawing.Point(44, 47);
            this.txtStatus.Name = "txtStatus";
            this.txtStatus.Size = new System.Drawing.Size(189, 23);
            this.txtStatus.TabIndex = 4;
            this.txtStatus.TabStop = true;
            this.txtStatus.Text = "未启动";
            this.txtStatus.VisitedLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            // 
            // btnStop
            // 
            this.btnStop.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnStop.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(184)))), ((int)(((byte)(0)))));
            this.btnStop.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(184)))), ((int)(((byte)(0)))));
            this.btnStop.FillHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(198)))), ((int)(((byte)(51)))));
            this.btnStop.FillPressColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(148)))), ((int)(((byte)(0)))));
            this.btnStop.FillSelectedColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(148)))), ((int)(((byte)(0)))));
            this.btnStop.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnStop.Location = new System.Drawing.Point(110, 99);
            this.btnStop.MinimumSize = new System.Drawing.Size(1, 1);
            this.btnStop.Name = "btnStop";
            this.btnStop.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(184)))), ((int)(((byte)(0)))));
            this.btnStop.RectHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(198)))), ((int)(((byte)(51)))));
            this.btnStop.RectPressColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(148)))), ((int)(((byte)(0)))));
            this.btnStop.RectSelectedColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(148)))), ((int)(((byte)(0)))));
            this.btnStop.Size = new System.Drawing.Size(100, 35);
            this.btnStop.Style = Sunny.UI.UIStyle.Custom;
            this.btnStop.TabIndex = 5;
            this.btnStop.Text = "停止";
            this.btnStop.TipsFont = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            // 
            // uiLinkLabel2
            // 
            this.uiLinkLabel2.ActiveLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(160)))), ((int)(((byte)(255)))));
            this.uiLinkLabel2.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uiLinkLabel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.uiLinkLabel2.LinkBehavior = System.Windows.Forms.LinkBehavior.AlwaysUnderline;
            this.uiLinkLabel2.Location = new System.Drawing.Point(276, 83);
            this.uiLinkLabel2.Name = "uiLinkLabel2";
            this.uiLinkLabel2.Size = new System.Drawing.Size(120, 23);
            this.uiLinkLabel2.TabIndex = 6;
            this.uiLinkLabel2.TabStop = true;
            this.uiLinkLabel2.Text = "MQTT 服务器IP:";
            this.uiLinkLabel2.VisitedLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            // 
            // uiLinkLabel3
            // 
            this.uiLinkLabel3.ActiveLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(160)))), ((int)(((byte)(255)))));
            this.uiLinkLabel3.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uiLinkLabel3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.uiLinkLabel3.LinkBehavior = System.Windows.Forms.LinkBehavior.AlwaysUnderline;
            this.uiLinkLabel3.Location = new System.Drawing.Point(259, 116);
            this.uiLinkLabel3.Name = "uiLinkLabel3";
            this.uiLinkLabel3.Size = new System.Drawing.Size(141, 23);
            this.uiLinkLabel3.TabIndex = 7;
            this.uiLinkLabel3.TabStop = true;
            this.uiLinkLabel3.Text = "MQTT 服务器Port:";
            this.uiLinkLabel3.VisitedLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            // 
            // txtMqttPort
            // 
            this.txtMqttPort.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtMqttPort.DoubleValue = 1883D;
            this.txtMqttPort.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtMqttPort.IntValue = 1883;
            this.txtMqttPort.Location = new System.Drawing.Point(417, 113);
            this.txtMqttPort.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtMqttPort.MinimumSize = new System.Drawing.Size(1, 16);
            this.txtMqttPort.Name = "txtMqttPort";
            this.txtMqttPort.Padding = new System.Windows.Forms.Padding(5);
            this.txtMqttPort.ShowText = false;
            this.txtMqttPort.Size = new System.Drawing.Size(150, 29);
            this.txtMqttPort.TabIndex = 8;
            this.txtMqttPort.Text = "1883";
            this.txtMqttPort.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.txtMqttPort.Type = Sunny.UI.UITextBox.UIEditType.Integer;
            this.txtMqttPort.Watermark = "";
            // 
            // uiLinkLabel4
            // 
            this.uiLinkLabel4.ActiveLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(160)))), ((int)(((byte)(255)))));
            this.uiLinkLabel4.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uiLinkLabel4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.uiLinkLabel4.LinkBehavior = System.Windows.Forms.LinkBehavior.AlwaysUnderline;
            this.uiLinkLabel4.Location = new System.Drawing.Point(593, 46);
            this.uiLinkLabel4.Name = "uiLinkLabel4";
            this.uiLinkLabel4.Size = new System.Drawing.Size(96, 23);
            this.uiLinkLabel4.TabIndex = 9;
            this.uiLinkLabel4.TabStop = true;
            this.uiLinkLabel4.Text = "SSID:";
            this.uiLinkLabel4.VisitedLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            // 
            // uiLinkLabel5
            // 
            this.uiLinkLabel5.ActiveLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(160)))), ((int)(((byte)(255)))));
            this.uiLinkLabel5.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uiLinkLabel5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.uiLinkLabel5.LinkBehavior = System.Windows.Forms.LinkBehavior.AlwaysUnderline;
            this.uiLinkLabel5.Location = new System.Drawing.Point(593, 83);
            this.uiLinkLabel5.Name = "uiLinkLabel5";
            this.uiLinkLabel5.Size = new System.Drawing.Size(96, 23);
            this.uiLinkLabel5.TabIndex = 10;
            this.uiLinkLabel5.TabStop = true;
            this.uiLinkLabel5.Text = "Password:";
            this.uiLinkLabel5.VisitedLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            // 
            // txtPassword
            // 
            this.txtPassword.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtPassword.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtPassword.Location = new System.Drawing.Point(696, 77);
            this.txtPassword.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtPassword.MinimumSize = new System.Drawing.Size(1, 16);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Padding = new System.Windows.Forms.Padding(5);
            this.txtPassword.ShowText = false;
            this.txtPassword.Size = new System.Drawing.Size(211, 29);
            this.txtPassword.TabIndex = 11;
            this.txtPassword.Text = "IOT#1688";
            this.txtPassword.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.txtPassword.Watermark = "";
            // 
            // txtSSID
            // 
            this.txtSSID.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtSSID.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtSSID.Location = new System.Drawing.Point(696, 40);
            this.txtSSID.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtSSID.MinimumSize = new System.Drawing.Size(1, 16);
            this.txtSSID.Name = "txtSSID";
            this.txtSSID.Padding = new System.Windows.Forms.Padding(5);
            this.txtSSID.ShowText = false;
            this.txtSSID.Size = new System.Drawing.Size(211, 29);
            this.txtSSID.TabIndex = 12;
            this.txtSSID.Text = "IOT";
            this.txtSSID.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.txtSSID.Watermark = "";
            // 
            // uiLinkLabel6
            // 
            this.uiLinkLabel6.ActiveLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(160)))), ((int)(((byte)(255)))));
            this.uiLinkLabel6.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uiLinkLabel6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.uiLinkLabel6.LinkBehavior = System.Windows.Forms.LinkBehavior.AlwaysUnderline;
            this.uiLinkLabel6.Location = new System.Drawing.Point(286, 46);
            this.uiLinkLabel6.Name = "uiLinkLabel6";
            this.uiLinkLabel6.Size = new System.Drawing.Size(114, 23);
            this.uiLinkLabel6.TabIndex = 14;
            this.uiLinkLabel6.TabStop = true;
            this.uiLinkLabel6.Text = "OTA 服务器IP:";
            this.uiLinkLabel6.VisitedLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            // 
            // txtOTAServer
            // 
            this.txtOTAServer.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            this.txtOTAServer.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtOTAServer.Location = new System.Drawing.Point(417, 40);
            this.txtOTAServer.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtOTAServer.MinimumSize = new System.Drawing.Size(1, 1);
            this.txtOTAServer.Name = "txtOTAServer";
            this.txtOTAServer.Padding = new System.Windows.Forms.Padding(1);
            this.txtOTAServer.ShowText = false;
            this.txtOTAServer.Size = new System.Drawing.Size(150, 29);
            this.txtOTAServer.TabIndex = 13;
            this.txtOTAServer.Text = "10.132.136.90";
            this.txtOTAServer.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            this.txtOTAServer.Value = ((System.Net.IPAddress)(resources.GetObject("txtOTAServer.Value")));
            // 
            // FrmMain
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(1023, 589);
            this.Controls.Add(this.uiLinkLabel6);
            this.Controls.Add(this.txtOTAServer);
            this.Controls.Add(this.txtSSID);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.uiLinkLabel5);
            this.Controls.Add(this.uiLinkLabel4);
            this.Controls.Add(this.txtMqttPort);
            this.Controls.Add(this.uiLinkLabel3);
            this.Controls.Add(this.uiLinkLabel2);
            this.Controls.Add(this.btnStop);
            this.Controls.Add(this.txtStatus);
            this.Controls.Add(this.ledStatus);
            this.Controls.Add(this.txtMqttServer);
            this.Controls.Add(this.uiTitlePanel1);
            this.Controls.Add(this.btnStart);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmMain";
            this.Text = "ASi AirKiss 配置工具";
            this.ZoomScaleRect = new System.Drawing.Rectangle(15, 15, 704, 359);
            this.uiTitlePanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Sunny.UI.UIButton btnStart;
        private Sunny.UI.UITitlePanel uiTitlePanel1;
        private Sunny.UI.UIIPTextBox txtMqttServer;
        private Sunny.UI.UILight ledStatus;
        private Sunny.UI.UILinkLabel txtStatus;
        private Sunny.UI.UIButton btnStop;
        private Sunny.UI.UIRichTextBox uiRichTextBox1;
        private Sunny.UI.UILinkLabel uiLinkLabel2;
        private Sunny.UI.UILinkLabel uiLinkLabel3;
        private Sunny.UI.UITextBox txtMqttPort;
        private Sunny.UI.UILinkLabel uiLinkLabel4;
        private Sunny.UI.UILinkLabel uiLinkLabel5;
        private Sunny.UI.UITextBox txtPassword;
        private Sunny.UI.UITextBox txtSSID;
        private Sunny.UI.UILinkLabel uiLinkLabel6;
        private Sunny.UI.UIIPTextBox txtOTAServer;
    }
}

