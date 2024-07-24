using ASiAirKiss.Services;
using Sunny.UI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ASiAirKiss
{
    public partial class Form1 : UIForm
    {
        AirkissServices servie = new AirkissServices();
        public Form1()
        {
            InitializeComponent();
            this.btnStart.Click += BtnStart_Click;
            this.Text += $"_Version:{Application.ProductVersion}";
        }

        private void BtnStart_Click(object sender, EventArgs e)
        {
            var flag = servie.CheckBroadcastSupport();

            uiRichTextBox1.Text += flag.message;


        }
    }
}
