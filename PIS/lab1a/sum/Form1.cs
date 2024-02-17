using Newtonsoft.Json;
using System.Text;

namespace sum
{
    public partial class Form1 : Form
    {
        HttpClient client = new HttpClient();

        public Form1()
        {
            client.BaseAddress = new Uri("http://localhost:5158");
            InitializeComponent();
        }

        private async void button1_Click(object sender, EventArgs e)
        {
            int x = int.Parse(textBox1.Text);
            int y = int.Parse(textBox2.Text);

            var content = new StringContent($"X={x}&Y={y}", Encoding.UTF8,"application/x-www-form-urlencoded");


            var response = await client.PostAsync("/4", content);
            var result = await response.Content.ReadAsStringAsync();

            label4.Text = result;
            
            
        }
    }
}