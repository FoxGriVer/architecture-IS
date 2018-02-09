using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Web;
using VkNet;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System.Net;
using System.IO;

namespace AIS_lab6
{
    public partial class Form1 : Form
    {
        public string Access_token { get; set; }
        string UserID;

        //https://oauth.vk.com/blank.html#access_token=95341d219ade8fb9c9cede393b83279ee6cabb7b902966f1fe631dabd2e9fe261df5621b223212270893e&expires_in=86400&user_id=311940768
        //https://oauth.vk.com/blank.html#access_token=889c8038ba2e5ee41ea0a27e430066d25972fb9c3d7b723f8546d6c489c84abcdf71e67633c801e2e4eff&expires_in=86400&user_id=311940768
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void autif_Click(object sender, EventArgs e)
        {
            string appId = "6304791";
            var uriStr = @"https://oauth.vk.com/authorize?client_id=" + appId +
                         @"&scope=friends,photos&redirect_uri=https://oauth.vk.com/blank.html&display=page&v=5.6&response_type=token";
            ourBrowser.Navigate(new Uri(uriStr));
            Form2 form2 = new Form2(this);
            form2.Show();
        }

        private void ourBrowser_Navigated(object sender, WebBrowserNavigatedEventArgs e)
        {
            if (e.Url.AbsoluteUri.Contains(@"oauth.vk.com/blank.html"))
            {
                string url = e.Url.Fragment;
                url = url.Trim('#');
                Access_token = HttpUtility.ParseQueryString(url).Get("access_token");
                UserID = HttpUtility.ParseQueryString(url).Get("user_id");               
            }
        }

        public string GET(string Url, string Method, string Token)
        {
            WebRequest req = WebRequest.Create(String.Format(Url, Method, Token));
            WebResponse resp = req.GetResponse();
            Stream stream = resp.GetResponseStream();
            StreamReader sr = new StreamReader(stream);
            string Out = sr.ReadToEnd();
            return Out;
        }

    }
}
