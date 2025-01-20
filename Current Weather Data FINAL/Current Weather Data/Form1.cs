using Newtonsoft.Json.Linq;

namespace Current_Weather_Data
{
    public partial class Form1 : Form
    {
        private DateTime time = DateTime.Now;
        public DateTime Time { get => time; set => time = value; }

        private DateTime date = DateTime.Now;
        public DateTime Date { get => date; set => date = value; }

        private string city = Settings1.Default.City;
        public string City { get => city; set => city = value; }

        private double temp = -255;
        public double Temp { get => temp; set => temp = value; }

        private string desc = "nema";
        public string Desc { get => desc; set => desc = value; }

        private int clouds = 0;
        public int Clouds { get => clouds; set => clouds = value; }

        private double windSpeed = 0;
        public double WindSpeed { get => windSpeed; set => windSpeed = value; }

        private string cityTry;
        public string CityTry { get => cityTry; set => cityTry = value; }

        private readonly string apiKey = "d9b447e955ba148ff4f87931f58a52cd";




        public Form1()
        {
            InitializeComponent();

        }
        private void Form1_Load(object sender, EventArgs e)
        {
            GetWeatherData(City); // when form first thing shown will be this method
            //


            timer1.Interval = 1000;
            timer1.Tick += timer1_Tick;
            timer1.Start(); // starting timer for clock

            timer2.Interval = 30000; //30 sekundi
            timer2.Tick += timer2_Tick;
            timer2.Start();

            labelDate.Text = Date.ToString("dd.MM.yyyy.");

            labelCity.Text = City.ToString();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            time = DateTime.Now;

            labelTime.Text = time.ToString("HH:mm:ss");

        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            GetWeatherData(City);
        }

        private async Task GetWeatherData(String place)
        {
            string url = $"https://api.openweathermap.org/data/2.5/weather?q={place}&appid={apiKey}&units=metric";
            using (HttpClient client = new HttpClient())
            {
                try
                {
                    string response = await client.GetStringAsync(url);
                    JObject json = JObject.Parse(response);

                    Temp = (double)json["main"]["temp"];

                    Desc = json["weather"][0]["description"].ToString();

                    WindSpeed = (double)json["wind"]["speed"];

                    Clouds = (int)json["clouds"]["all"];

                    City = place;

                    asignValuesToLabels();



                    //  string jsonFormatted = json.ToString(Newtonsoft.Json.Formatting.Indented);
                    //  MessageBox.Show(jsonFormatted);

                    //  HttpResponseMessage response2 = await client.GetAsync(url);

                    /*  if (response2.IsSuccessStatusCode)
                      {
                          string responseBody = await response2.Content.ReadAsStringAsync();
                          JObject weatherData = JObject.Parse(responseBody);

                          //DisplayForecast(weatherData);

                      } */

                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error fetching weather data: {ex.Message}");
                }
            }

        }

        private void asignValuesToLabels()
        {
            labelTemp.Text = Temp.ToString()+ "\u00B0C";

            labelDesc.Text = Desc;

            labelWindSpeed.Text = WindSpeed.ToString();

            labelClouds.Text = Clouds.ToString();

            labelCity.Text = City;



        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Length > 0)
            {
                GetWeatherData(textBox1.Text);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Settings1.Default.City = City;
            Settings1.Default.Save();
            Application.Exit();
        }
    }
}
