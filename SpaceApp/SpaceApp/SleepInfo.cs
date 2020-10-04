using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SpaceApp
{
    public partial class SleepInfo : Form
    {
        MorfeoAppEntities context = new MorfeoAppEntities();
        public SleepInfo()
        {
            InitializeComponent();

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void SleepInfo_Load(object sender, EventArgs e)
        {
            dtNight.Value = dtNight.Value.AddDays(-1);
            this.lbTi.AutoSize = false;
            this.lbTi.Height = 25;
            String query = $"select * from Sleep where idAstr = '{Form1.idAstron}' and day(bedTime) = '{dtNight.Value.Day}' and MONTH(bedTime) = '{dtNight.Value.Month}' and year(bedTime) = '{dtNight.Value.Year}'";
            List<Sleep> lsSleep = context.Sleep.SqlQuery(query).ToList();
            if (lsSleep.Count != 0)
            {
                txInt.Enabled = false;
                txReas.Enabled = false;
                txSh.Enabled = false;
                txSm.Enabled = false;
                txWh.Enabled = false;
                txWm.Enabled = false;
                cbAwake.Enabled = false;
                cbLight.Enabled = false;
                cbMusic.Enabled = false;
                cbSleep.Enabled = false;
                comboBox1.Enabled = false;
                btAdd.Enabled = false;
            }

            SleeepClass a = new SleeepClass();
            OleDbConnection con = new OleDbConnection();
            con.ConnectionString = "Provider = Microsoft.ACE.OLEDB.12.0; Data Source = C:/Users/super/Documents/Diana/ITAM/4to semestre/Base de Datos/Clases en Línea/C6/OLAP/FoodMart/FoodMart.accdb";
            con.Open();
            String sql = "select customer_id from customer ";

            OleDbCommand cmd = new OleDbCommand(sql, con);
            OleDbDataReader re = cmd.ExecuteReader();
            List<double> xx = new List<double>();
            List<double> yy = new List<double>();
            int i = 0;
            while (re.Read())
            {
                xx.Add(re.GetInt32(0)/10);
                yy.Add(re.GetInt32(0) / 10);
                i++;
            }
            con.Close();
            double[] x = xx.ToArray();
            double[] y = yy.ToArray();
            String res = a.sleepMOrf(x, y);
            lbBoolean.Text = res; //This information will be provided by the electrocardiogram
        }

        private void btAdd_Click(object sender, EventArgs e)
        {
            //The music selection is from Sleep Genius App from Horowitz and Massey. 
            //It´s music therapy to increase sleep. 
            DateTime bed = Convert.ToDateTime(dtNight.Value.ToShortDateString());
            bed = bed.AddHours(Convert.ToInt32(txSh.Text));
            bed = bed.AddMinutes(Convert.ToInt32(txSm.Text));
            DateTime wake = Convert.ToDateTime(dtNight.Value.ToShortDateString());
            wake = wake.AddDays(1);
            wake = wake.AddHours(Convert.ToInt32(txWh.Text));
            wake = wake.AddMinutes(Convert.ToInt32(txWm.Text));
            /*To estimate the circadian phase  we will use the Circadian performance simulation software ((CPSS version 2.1, Brigham and
            Women’s Hospital, Boston, MA, USA)
            Most of the variables are being consider has an input in this interface, but there are other variables like light exposure that will 
            be calculated using a light sensor.
             */
            lbCircadian.Text = "Circadian misaligned."; //Or Circadian aligned 

            Sleep s = new Sleep(Form1.idAstron, bed, wake, Convert.ToInt32(txInt.Text), txReas.Text, true, cbLight.Text, lbCircadian.Text);

            context.Sleep.Add(s);
            context.SaveChanges();
            lbCirclye.Visible = true;
            lbCircadian.Visible = true;
            int hours = (wake.Hour + 24 - bed.Hour)%24 + ((wake.Minute + 60 - bed.Minute)%60/60);
            if(hours < 6.5)
            {
                lbNap.Visible = true;
                /*A method that will calculated the best time to take a nap. 
                Time of the nap 8 - hours. 
                At 10:30am if the astronaut is exercising in the afternoon. 
                At 3:00pm if the astronaut is exercising in the morning. 
                */
            }
            btAdd.Enabled = false;
            txInt.Enabled = false;
            txReas.Enabled = false;
            txSh.Enabled = false;
            txSm.Enabled = false;
            txWh.Enabled = false;
            txWm.Enabled = false;
            cbAwake.Enabled = false;
            cbLight.Enabled = false;
            cbMusic.Enabled = false;
            cbSleep.Enabled = false;
            comboBox1.Enabled = false;

        }

        private void dtNight_ValueChanged(object sender, EventArgs e)
        {
            String query = $"select * from Sleep where idAstr = '{Form1.idAstron}' and day(bedTime) = '{dtNight.Value.Day}' and MONTH(bedTime) = '{dtNight.Value.Month}' and year(bedTime) = '{dtNight.Value.Year}'";
            List<Sleep> lsSleep = context.Sleep.SqlQuery(query).ToList();

            if (lsSleep.Count != 0)
            {
                txInt.Enabled = false;
                txReas.Enabled = false;
                txSh.Enabled = false;
                txSm.Enabled = false;
                txWh.Enabled = false;
                txWm.Enabled = false;
                cbAwake.Enabled = false;
                cbLight.Enabled = false;
                cbMusic.Enabled = false;
                cbSleep.Enabled = false;
                comboBox1.Enabled = false;
                btAdd.Enabled = false;
            }
            else
            {
                txInt.Enabled = true;
                txReas.Enabled = true;
                txSh.Enabled = true;
                txSm.Enabled = true;
                txWh.Enabled = true;
                txWm.Enabled = true;
                cbAwake.Enabled = true;
                cbLight.Enabled = true;
                cbMusic.Enabled = true;
                cbSleep.Enabled = true;
                comboBox1.Enabled = true;
                btAdd.Enabled = true;

            }
        }
    }
}
