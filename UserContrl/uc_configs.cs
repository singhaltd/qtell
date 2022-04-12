using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;

namespace qtellq.UserContrl
{
    public partial class uc_configs : UserControl
    {
        private AppServices appServices = new AppServices();

        public uc_configs()
        {
            InitializeComponent();
        }

        private void uc_configs_Load(object sender, EventArgs e)
        {
            uc_general getser = new uc_general();
            txCounter.Text = appServices.getCounter("counter");

            getCombServ();


            //DataTable dtlang = new DataTable();

            //dtlang.Columns.Add("lcode");
            //dtlang.Columns.Add("lname");


            //DataRow drlang = dtlang.NewRow();

            //drlang["lcode"] = "laos";
            //drlang["lname"] = "Laos";
            //dtlang.Rows.InsertAt(drlang,0);

            //drlang["lcode"] = "english";
            //drlang["lname"] = "English";
            //dtlang.Rows.InsertAt(drlang,1);

            //combLanguage.DataSource = dtlang;
            //combLanguage.DisplayMember = "lname";
            //combLanguage.ValueMember = "lcode";


        }

        public async void getCombServ()
        {
            var dt = await appServices.getSevWaiting();

            var dfl = JsonConvert.DeserializeObject<ServiceModel>(dt);
            combServ.DataSource =dfl.Data;
            combServ.DisplayMember = "title";
            combServ.ValueMember = "qcode";

            combServ.SelectedValue = ConfigurationManager.AppSettings["service"];
        }


        private static void SetSetting(string key, string value)
        {
            Configuration configuration =
                ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
            configuration.AppSettings.Settings[key].Value = value;
            configuration.Save(ConfigurationSaveMode.Full, true);
            ConfigurationManager.RefreshSection("appSettings");
        }


        public class DatServ
        {
            [JsonProperty("qcode")] public string Qcode { get; set; }

            [JsonProperty("title")] public string Title { get; set; }
        }

        public class ServiceModel
        {
            [JsonProperty("error")] public bool Error { get; set; }

            [JsonProperty("message")] public string Message { get; set; }

            [JsonProperty("data")] public List<UserContrl.DatServ> Data { get; set; }


        }

        private void btConfigSave_Click(object sender, EventArgs e)
        {
            SetSetting("counter", txCounter.Text);

            DialogResult dl = MessageBox.Show("Configuration updated. Application Will Restart");
            switch (dl)
            {
                case DialogResult.OK:
                    Application.Restart();
                    break;
                case DialogResult.No:
                    Application.Restart();
                    break;
            }
        }
    }
}
