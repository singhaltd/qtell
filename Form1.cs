using ComponentFactory.Krypton.Toolkit;
using Newtonsoft.Json;
using SocketIOClient;

namespace qtellq
{
    public partial class QtelFrm : KryptonForm
    {
       private AppServices appServices = new AppServices();
        public QtelFrm()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void btnSetting_Click(object sender, EventArgs e)
        {
            fmSetting fm = new fmSetting();
            fm.ShowDialog();

        }

        private void QtelFrm_Load(object sender, EventArgs e)
        {
            
            Thread.CurrentThread.CurrentUICulture = new System.Globalization.CultureInfo("lao");
            lbCounter.Controls.Clear();
            lbCounter.Text = appServices.getCounter("counter");

            InitDataQtel();
            socketTest();



        }

        private async void btnCall_Click(object sender, EventArgs e)
        {
            AppServices appServices = new AppServices();

           var d = await appServices.ActionQtel("CALL");
           var dfl = JsonConvert.DeserializeObject<Qres>(d);
           lbMecalled.Text = dfl.Data.Qnumber.ToString().PadLeft(3, '0');
            MessageBox.Show($"{dfl.Data.Qnumber.ToString().PadLeft(3,'0')}");

            InitDataQtel();
        }

        private async void btnRecall_Click(object sender, EventArgs e)
        {
            AppServices appServices = new AppServices();

            var d = await appServices.ActionQtel("RECALL");

            MessageBox.Show(d);

        }

        public async void InitDataQtel()
        {
            var dt = await appServices.getQflowl();
            var dfl = JsonConvert.DeserializeObject<DatQtel>(dt);

            lbNextNumber.Text = dfl.Data.Currnum.ToString().PadLeft(3, '0') ;
            lbNextService.Text = dfl.Data.Service;
            lbWaiting.Text = dfl.Data.Waiting.ToString();

        }


        public class qData
        {
            [JsonProperty("waiting")]
            public int Waiting { get; set; }

            [JsonProperty("currnum")]
            public string Currnum { get; set; }

            [JsonProperty("service")]
            public string Service { get; set; }
        }

        public class DatQtel
        {
            [JsonProperty("error")]
            public bool Error { get; set; }

            [JsonProperty("message")]
            public string Message { get; set; }

            [JsonProperty("data")]
            public qData Data { get; set; }
        }

        
        public class Ditem
        {
            [JsonProperty("id")]
            public int Id { get; set; }

            [JsonProperty("trn_dt")]
            public DateTime TrnDt { get; set; }

            [JsonProperty("trn_tm")]
            public string TrnTm { get; set; }

            [JsonProperty("qnumber")]
            public string Qnumber { get; set; }

            [JsonProperty("status")]
            public int Status { get; set; }

            [JsonProperty("counter")]
            public string Counter { get; set; }

            [JsonProperty("recall")]
            public int Recall { get; set; }

            [JsonProperty("service")]
            public string Service { get; set; }
        }

        public class Qres
        {
            [JsonProperty("error")]
            public bool Error { get; set; }

            [JsonProperty("message")]
            public int Message { get; set; }

            [JsonProperty("data")]
            public Ditem Data { get; set; }
        }

        public async void socketTest()
        {
            var client = new SocketIO("http://10.0.34.37:3333");

            try
            {
                client.OnConnected += async (sender, e) =>
                {
                    // Emit a string
                    //await client.EmitAsync("hi", "socket.io");
                    //MessageBox.Show("conn");

                };
                client.On("TakeQue", response =>
                {
                    InitDataQtel();
                });
                await client.ConnectAsync();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString());
            }
           
        }

        private void btnServed_Click(object sender, EventArgs e)
        {
            socketTest();
        }

        private void btnReject_Click(object sender, EventArgs e)
        {
            
        }
    }
}