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

namespace qtellq.UserContrl
{
    public partial class uc_general : UserControl
    {
        private static AppServices appServices = new AppServices();
        public uc_general()
        {
            InitializeComponent();
        }

        private void uc_general_Load(object sender, EventArgs e)
        {

            lbTotalday.Text = "";
            lbMeCalled.Text = "";
            lbReject.Text = "";
            lbWaiting.Text = "";
            lbServed.Text = "";
            getGenflow();
            getServing();
        }

        public async void getGenflow()
        {
            var dtflow = await appServices.getGeneral();

           
            var dfl = JsonConvert.DeserializeObject<GenModel>(dtflow);

            lbTotalday.Text = $"{dfl.TotalTicket}";
            lbMeCalled.Text = $"{dfl.Mcall}";
            lbReject.Text = $"{dfl.Reject}";
            lbWaiting.Text = $"{dfl.Waiting}";
            lbServed.Text = $"{dfl.TotalServed}";

            lbTimeFast.Text = $"{dfl.Mfast}";
            lbTimeSlow.Text = $"{dfl.Mslow}";
            lbTimeLatest.Text = $"{dfl.Mlatest}";
        }

        public async void getServing()
        {
            var dfserv = await appServices.getSevWaiting();
            var dfl = JsonConvert.DeserializeObject<ServiceModel>(dfserv);
            dtgServ.DataSource = dfl.Data;

        }
    }

    public class GenModel
    {
        [JsonProperty("total_ticket")]
        public int TotalTicket { get; set; }

        [JsonProperty("waiting")]
        public int Waiting { get; set; }

        [JsonProperty("total_served")]
        public int TotalServed { get; set; }

        [JsonProperty("mcall")]
        public int Mcall { get; set; }

        [JsonProperty("reject")]
        public int Reject { get; set; }

        [JsonProperty("mfast")]
        public string Mfast { get; set; }

        [JsonProperty("mslow")]
        public string Mslow { get; set; }

        [JsonProperty("mlatest")]
        public string Mlatest { get; set; }

    }

    public class DatServ
    {
        [JsonProperty("qcode")]
        public string Qcode { get; set; }

        [JsonProperty("title")]
        public string Title { get; set; }
    }

    public class ServiceModel
    {
        [JsonProperty("error")]
        public bool Error { get; set; }

        [JsonProperty("message")]
        public string Message { get; set; }

        [JsonProperty("data")]
        public List<DatServ> Data { get; set; }
    }
}
