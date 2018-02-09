using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System.Web;

namespace AIS_lab6
{
    public partial class Form2 : Form
    {
        private string f;
        private int count = 0;
        private Form1 m_parentForm1;
        List<AboutPhoto> ourUsers = new List<AboutPhoto>();
        

        public Form2(Form1 frm1)
        {
            InitializeComponent();
            m_parentForm1 = frm1;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            count++;
            if (pictureBox1.Image != null)
            {
                pictureBox1.Image.Dispose();
                pictureBox1.Image = null;
            }
            pictureBox1.Load(ourUsers[count].PhotoRef);

        }

        private void button2_Click(object sender, EventArgs e)
        {
            string reqStrTemplate = "https://api.vk.com/method/{0}?count=100&access_token={1}";
            string method = "fave.getPhotos";           
            f = m_parentForm1.GET(reqStrTemplate, method, m_parentForm1.Access_token);   
            var user = JsonConvert.DeserializeObject(f) as JObject;
            StringBuilder stroka = new StringBuilder();
            StringBuilder stroka2 = new StringBuilder();
            string numberOfPhotos =  stroka2.Append(user["response"][0]).ToString();
            for (int i = 1; i <= Convert.ToInt32(numberOfPhotos); i++)
            {
                AboutPhoto photo = new AboutPhoto();
                photo.PhotoRef = stroka.Append(user["response"][i]["src"]).ToString();
                stroka.Clear();
                photo.PhotoId = stroka.Append(user["response"][i]["pid"]).ToString();
                stroka.Clear();
                photo.OwnerId = stroka.Append(user["response"][i]["owner_id"]).ToString();
                stroka.Clear();
                ourUsers.Add(photo);
            }
            pictureBox1.Load(ourUsers[count].PhotoRef);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (count != 0)
            {
                count--;
                if (pictureBox1.Image != null)
                {
                    pictureBox1.Image.Dispose();
                    pictureBox1.Image = null;
                }
                pictureBox1.Load(ourUsers[count].PhotoRef);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {            
            ourUsers[count].Message = textBox1.Text;
            string reqStrTemplate = "https://api.vk.com/method/{0}?owner_id=" +ourUsers[count].OwnerId +"&photo_id="+ ourUsers[count].PhotoId + "&message="+ ourUsers[count].Message + "&access_token={1}";
            string method = "photos.createComment";
            m_parentForm1.GET(reqStrTemplate, method, m_parentForm1.Access_token);
        }
    }
}
