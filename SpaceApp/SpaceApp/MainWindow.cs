using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SpaceApp
{
    public partial class MainWindow : Form
    {
        MorfeoAppEntities context = new MorfeoAppEntities();
        public MainWindow()
        {
            InitializeComponent();
        }

        private void profileMenu_Click(object sender, EventArgs e)
        {
            Profile p = new Profile();
            p.Show();
        }

        private void mealsMenu_Click(object sender, EventArgs e)
        {
            Meal m = new Meal();
            m.Show();
        }


        private void logOutMenu_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void MainWindow_Load(object sender, EventArgs e)
        {
            string cadSQL;
            cadSQL = $"select * from Trip t order by idTrip desc";
            List<Trip> lsTrip = context.Trip.SqlQuery(cadSQL).ToList();

            DateTime today = DateTime.Today;
            DateTime ar = lsTrip[0].arrivalTime.Value;
            int a = Convert.ToInt32(ar.DayOfWeek); //day of the week when they don´t exercise
            if (Convert.ToInt32(today.DayOfWeek) == a) //Every time is this day of the week the programme will schedule the exercise itinerary of the week. 

            {
                DateTime day = new DateTime(today.Year, today.Month, today.Day, 00, 00, 00);
                string cadSQLExis;
                cadSQLExis = $"select * from Exercise where idAstr = '{Form1.idAstron}' and day(starT) ='{day.AddDays(1).Day}' and month(start) = '{day.Month}' and year(starT) = '{day.Year}'";
                List<Exercise> lsExerExis = context.Exercise.SqlQuery(cadSQLExis).ToList();
                if(lsExerExis.Count == 0)//There is no previous information. We need to add the exercise schedule for the week. 
                {
                    int maq = 0;
                    string cadSQLEqMor;
                    cadSQLEqMor = $"select * from Exercise where day(starT) ='{day.AddDays(1).Day}' and month(start) = '{day.Month}' and year(starT) = '{day.Year}' and datepart(hour,starT) = 10";
                    List<Exercise> lsExerMor = context.Exercise.SqlQuery(cadSQLEqMor).ToList();
                    maq = lsExerMor.Count + 1; //
                    if (maq <= 3)
                    {                        
                        day = day.AddHours(10.5);
                        switch (maq)
                        {
                            case 1:
                                //10:30am -First machine they will use for the rest of the week
                                Exercise e111 = new Exercise(Form1.idAstron, Convert.ToInt16(1), day.AddDays(1), day.AddDays(1).AddMinutes(50), 20, "...");
                                Exercise e112 = new Exercise(Form1.idAstron, Convert.ToInt16(3), day.AddDays(2), day.AddDays(2).AddMinutes(50), 20, "...");
                                Exercise e113 = new Exercise(Form1.idAstron, Convert.ToInt16(2), day.AddDays(3), day.AddDays(3).AddMinutes(50), 20, "...");
                                Exercise e114 = new Exercise(Form1.idAstron, Convert.ToInt16(1), day.AddDays(4), day.AddDays(4).AddMinutes(50), 20, "...");
                                Exercise e115 = new Exercise(Form1.idAstron, Convert.ToInt16(3), day.AddDays(5), day.AddDays(5).AddMinutes(50), 20, "...");
                                Exercise e116 = new Exercise(Form1.idAstron, Convert.ToInt16(2), day.AddDays(6), day.AddDays(6).AddMinutes(50), 20, "...");

                                day = day.AddMinutes(50); //11:20am -Second machine they will use for the rest of the week
                                Exercise e121 = new Exercise(Form1.idAstron, Convert.ToInt16(2), day.AddDays(1), day.AddDays(1).AddMinutes(50), 20, "...");
                                Exercise e122 = new Exercise(Form1.idAstron, Convert.ToInt16(2), day.AddDays(2), day.AddDays(2).AddMinutes(50), 20, "...");
                                Exercise e123 = new Exercise(Form1.idAstron, Convert.ToInt16(3), day.AddDays(3), day.AddDays(3).AddMinutes(50), 20, "...");
                                Exercise e124 = new Exercise(Form1.idAstron, Convert.ToInt16(2), day.AddDays(4), day.AddDays(4).AddMinutes(50), 20, "...");
                                Exercise e125 = new Exercise(Form1.idAstron, Convert.ToInt16(2), day.AddDays(5), day.AddDays(5).AddMinutes(50), 20, "...");
                                Exercise e126 = new Exercise(Form1.idAstron, Convert.ToInt16(3), day.AddDays(6), day.AddDays(6).AddMinutes(50), 20, "...");
                                day = day.AddMinutes(50); //12:10am -Third machine they will use for the rest of the week
                                Exercise e131 = new Exercise(Form1.idAstron, Convert.ToInt16(3), day.AddDays(1), day.AddDays(1).AddMinutes(50), 20, "...");
                                Exercise e132 = new Exercise(Form1.idAstron, Convert.ToInt16(1), day.AddDays(2), day.AddDays(2).AddMinutes(50), 20, "...");
                                Exercise e133 = new Exercise(Form1.idAstron, Convert.ToInt16(1), day.AddDays(3), day.AddDays(3).AddMinutes(50), 20, "...");
                                Exercise e134 = new Exercise(Form1.idAstron, Convert.ToInt16(3), day.AddDays(4), day.AddDays(4).AddMinutes(50), 20, "...");
                                Exercise e135 = new Exercise(Form1.idAstron, Convert.ToInt16(1), day.AddDays(5), day.AddDays(5).AddMinutes(50), 20, "...");
                                Exercise e136 = new Exercise(Form1.idAstron, Convert.ToInt16(1), day.AddDays(6), day.AddDays(6).AddMinutes(50), 20, "...");
                                context.Exercise.Add(e111);
                                context.Exercise.Add(e112);
                                context.Exercise.Add(e113);
                                context.Exercise.Add(e114);
                                context.Exercise.Add(e115);
                                context.Exercise.Add(e116);
                                context.Exercise.Add(e121);
                                context.Exercise.Add(e122);
                                context.Exercise.Add(e123);
                                context.Exercise.Add(e124);
                                context.Exercise.Add(e125);
                                context.Exercise.Add(e126);
                                context.Exercise.Add(e131);
                                context.Exercise.Add(e132);
                                context.Exercise.Add(e133);
                                context.Exercise.Add(e134);
                                context.Exercise.Add(e135);
                                context.Exercise.Add(e136);
                                context.SaveChanges();
                                break;
                            case 2:
                                //10:30am -First machine they will use for the rest of the week
                                Exercise e211 = new Exercise(Form1.idAstron, Convert.ToInt16(2), day.AddDays(1), day.AddDays(1).AddMinutes(50), 20, "...");
                                Exercise e212 = new Exercise(Form1.idAstron, Convert.ToInt16(1), day.AddDays(2), day.AddDays(2).AddMinutes(50), 20, "...");
                                Exercise e213 = new Exercise(Form1.idAstron, Convert.ToInt16(3), day.AddDays(3), day.AddDays(3).AddMinutes(50), 20, "...");
                                Exercise e214 = new Exercise(Form1.idAstron, Convert.ToInt16(2), day.AddDays(4), day.AddDays(4).AddMinutes(50), 20, "...");
                                Exercise e215 = new Exercise(Form1.idAstron, Convert.ToInt16(1), day.AddDays(5), day.AddDays(5).AddMinutes(50), 20, "...");
                                Exercise e216 = new Exercise(Form1.idAstron, Convert.ToInt16(3), day.AddDays(6), day.AddDays(6).AddMinutes(50), 20, "...");

                                day = day.AddMinutes(50); //11:20am -Second machine they will use for the rest of the week
                                Exercise e221 = new Exercise(Form1.idAstron, Convert.ToInt16(3), day.AddDays(1), day.AddDays(1).AddMinutes(50), 20, "...");
                                Exercise e222 = new Exercise(Form1.idAstron, Convert.ToInt16(3), day.AddDays(2), day.AddDays(2).AddMinutes(50), 20, "...");
                                Exercise e223 = new Exercise(Form1.idAstron, Convert.ToInt16(1), day.AddDays(3), day.AddDays(3).AddMinutes(50), 20, "...");
                                Exercise e224 = new Exercise(Form1.idAstron, Convert.ToInt16(3), day.AddDays(4), day.AddDays(4).AddMinutes(50), 20, "...");
                                Exercise e225 = new Exercise(Form1.idAstron, Convert.ToInt16(3), day.AddDays(5), day.AddDays(5).AddMinutes(50), 20, "...");
                                Exercise e226 = new Exercise(Form1.idAstron, Convert.ToInt16(1), day.AddDays(6), day.AddDays(6).AddMinutes(50), 20, "...");
                                day = day.AddMinutes(50); //12:10am -Third machine they will use for the rest of the week
                                Exercise e231 = new Exercise(Form1.idAstron, Convert.ToInt16(1), day.AddDays(1), day.AddDays(1).AddMinutes(50), 20, "...");
                                Exercise e232 = new Exercise(Form1.idAstron, Convert.ToInt16(2), day.AddDays(2), day.AddDays(2).AddMinutes(50), 20, "...");
                                Exercise e233 = new Exercise(Form1.idAstron, Convert.ToInt16(2), day.AddDays(3), day.AddDays(3).AddMinutes(50), 20, "...");
                                Exercise e234 = new Exercise(Form1.idAstron, Convert.ToInt16(1), day.AddDays(4), day.AddDays(4).AddMinutes(50), 20, "...");
                                Exercise e235 = new Exercise(Form1.idAstron, Convert.ToInt16(2), day.AddDays(5), day.AddDays(5).AddMinutes(50), 20, "...");
                                Exercise e236 = new Exercise(Form1.idAstron, Convert.ToInt16(2), day.AddDays(6), day.AddDays(6).AddMinutes(50), 20, "...");
                                context.Exercise.Add(e211);
                                context.Exercise.Add(e212);
                                context.Exercise.Add(e213);
                                context.Exercise.Add(e214);
                                context.Exercise.Add(e215);
                                context.Exercise.Add(e216);
                                context.Exercise.Add(e221);
                                context.Exercise.Add(e222);
                                context.Exercise.Add(e223);
                                context.Exercise.Add(e224);
                                context.Exercise.Add(e225);
                                context.Exercise.Add(e226);
                                context.Exercise.Add(e231);
                                context.Exercise.Add(e232);
                                context.Exercise.Add(e233);
                                context.Exercise.Add(e234);
                                context.Exercise.Add(e235);
                                context.Exercise.Add(e236);
                                context.SaveChanges();
                                break;
                            case 3:
                                //10:30am -First machine they will use for the rest of the week
                                Exercise e311 = new Exercise(Form1.idAstron, Convert.ToInt16(3), day.AddDays(1), day.AddDays(1).AddMinutes(50), 20, "...");
                                Exercise e312 = new Exercise(Form1.idAstron, Convert.ToInt16(2), day.AddDays(2), day.AddDays(2).AddMinutes(50), 20, "...");
                                Exercise e313 = new Exercise(Form1.idAstron, Convert.ToInt16(1), day.AddDays(3), day.AddDays(3).AddMinutes(50), 20, "...");
                                Exercise e314 = new Exercise(Form1.idAstron, Convert.ToInt16(3), day.AddDays(4), day.AddDays(4).AddMinutes(50), 20, "...");
                                Exercise e315 = new Exercise(Form1.idAstron, Convert.ToInt16(2), day.AddDays(5), day.AddDays(5).AddMinutes(50), 20, "...");
                                Exercise e316 = new Exercise(Form1.idAstron, 1, day.AddDays(6), day.AddDays(6).AddMinutes(50), 20, "...");

                                day = day.AddMinutes(50); //11:20am -Second machine they will use for the rest of the week
                                Exercise e321 = new Exercise(Form1.idAstron, Convert.ToInt16(1), day.AddDays(1), day.AddDays(1).AddMinutes(50), 20, "...");
                                Exercise e322 = new Exercise(Form1.idAstron, Convert.ToInt16(1), day.AddDays(2), day.AddDays(2).AddMinutes(50), 20, "...");
                                Exercise e323 = new Exercise(Form1.idAstron, Convert.ToInt16(2), day.AddDays(3), day.AddDays(3).AddMinutes(50), 20, "...");
                                Exercise e324 = new Exercise(Form1.idAstron, Convert.ToInt16(1), day.AddDays(4), day.AddDays(4).AddMinutes(50), 20, "...");
                                Exercise e325 = new Exercise(Form1.idAstron, Convert.ToInt16(1), day.AddDays(5), day.AddDays(5).AddMinutes(50), 20, "...");
                                Exercise e326 = new Exercise(Form1.idAstron, Convert.ToInt16(2), day.AddDays(6), day.AddDays(6).AddMinutes(50), 20, "...");
                                day = day.AddMinutes(50); //12:10am -Third machine they will use for the rest of the week
                                Exercise e331 = new Exercise(Form1.idAstron, Convert.ToInt16(2), day.AddDays(1), day.AddDays(1).AddMinutes(50), 20, "...");
                                Exercise e332 = new Exercise(Form1.idAstron, Convert.ToInt16(3), day.AddDays(2), day.AddDays(2).AddMinutes(50), 20, "...");
                                Exercise e333 = new Exercise(Form1.idAstron, Convert.ToInt16(3), day.AddDays(3), day.AddDays(3).AddMinutes(50), 20, "...");
                                Exercise e334 = new Exercise(Form1.idAstron, Convert.ToInt16(2), day.AddDays(4), day.AddDays(4).AddMinutes(50), 20, "...");
                                Exercise e335 = new Exercise(Form1.idAstron, Convert.ToInt16(3), day.AddDays(5), day.AddDays(5).AddMinutes(50), 20, "...");
                                Exercise e336 = new Exercise(Form1.idAstron, Convert.ToInt16(3), day.AddDays(6), day.AddDays(6).AddMinutes(50), 20, "...");
                                context.Exercise.Add(e311);
                                context.Exercise.Add(e312);
                                context.Exercise.Add(e313);
                                context.Exercise.Add(e314);
                                context.Exercise.Add(e315);
                                context.Exercise.Add(e316);
                                context.Exercise.Add(e321);
                                context.Exercise.Add(e322);
                                context.Exercise.Add(e323);
                                context.Exercise.Add(e324);
                                context.Exercise.Add(e325);
                                context.Exercise.Add(e326);
                                context.Exercise.Add(e331);
                                context.Exercise.Add(e332);
                                context.Exercise.Add(e333);
                                context.Exercise.Add(e334);
                                context.Exercise.Add(e335);
                                context.Exercise.Add(e336);
                                context.SaveChanges();
                                break;


                        }
                    }
                    else
                    {
                        maq = 0;
                        string cadSQLEqEv;
                        cadSQLEqEv = $"select * from Exercise where day(starT) ='{day.AddDays(1).Day}' and month(start) = '{day.Month}' and year(starT) = '{day.Year}' and datepart(hour,starT) = 15 and datepart(minute,starT) = 00 ";
                        List<Exercise> lsExerEv = context.Exercise.SqlQuery(cadSQLEqEv).ToList();
                        maq = lsExerEv.Count + 1; //It is not possible for maq to be 4 here because there are 6 astronauts as maximum.
                        day = day.AddHours(15);
                        switch (maq)
                        {
                            case 1:
                                //15:00pm -First machine they will use for the rest of the week
                                Exercise e111 = new Exercise(Form1.idAstron, Convert.ToInt16(1), day.AddDays(1), day.AddDays(1).AddMinutes(50), 20, "...");
                                Exercise e112 = new Exercise(Form1.idAstron, Convert.ToInt16(3), day.AddDays(2), day.AddDays(2).AddMinutes(50), 20, "...");
                                Exercise e113 = new Exercise(Form1.idAstron, Convert.ToInt16(2), day.AddDays(3), day.AddDays(3).AddMinutes(50), 20, "...");
                                Exercise e114 = new Exercise(Form1.idAstron, Convert.ToInt16(1), day.AddDays(4), day.AddDays(4).AddMinutes(50), 20, "...");
                                Exercise e115 = new Exercise(Form1.idAstron, Convert.ToInt16(3), day.AddDays(5), day.AddDays(5).AddMinutes(50), 20, "...");
                                Exercise e116 = new Exercise(Form1.idAstron, Convert.ToInt16(2), day.AddDays(6), day.AddDays(6).AddMinutes(50), 20, "...");

                                day = day.AddMinutes(50); //15:50pm -Second machine they will use for the rest of the week
                                Exercise e121 = new Exercise(Form1.idAstron, Convert.ToInt16(2), day.AddDays(1), day.AddDays(1).AddMinutes(50), 20, "...");
                                Exercise e122 = new Exercise(Form1.idAstron, Convert.ToInt16(2), day.AddDays(2), day.AddDays(2).AddMinutes(50), 20, "...");
                                Exercise e123 = new Exercise(Form1.idAstron, Convert.ToInt16(3), day.AddDays(3), day.AddDays(3).AddMinutes(50), 20, "...");
                                Exercise e124 = new Exercise(Form1.idAstron, Convert.ToInt16(2), day.AddDays(4), day.AddDays(4).AddMinutes(50), 20, "...");
                                Exercise e125 = new Exercise(Form1.idAstron, Convert.ToInt16(2), day.AddDays(5), day.AddDays(5).AddMinutes(50), 20, "...");
                                Exercise e126 = new Exercise(Form1.idAstron, Convert.ToInt16(3), day.AddDays(6), day.AddDays(6).AddMinutes(50), 20, "...");
                                day = day.AddMinutes(50); //16:40pm -Third machine they will use for the rest of the week
                                Exercise e131 = new Exercise(Form1.idAstron, Convert.ToInt16(3), day.AddDays(1), day.AddDays(1).AddMinutes(50), 20, "...");
                                Exercise e132 = new Exercise(Form1.idAstron, Convert.ToInt16(1), day.AddDays(2), day.AddDays(2).AddMinutes(50), 20, "...");
                                Exercise e133 = new Exercise(Form1.idAstron, Convert.ToInt16(1), day.AddDays(3), day.AddDays(3).AddMinutes(50), 20, "...");
                                Exercise e134 = new Exercise(Form1.idAstron, Convert.ToInt16(3), day.AddDays(4), day.AddDays(4).AddMinutes(50), 20, "...");
                                Exercise e135 = new Exercise(Form1.idAstron, Convert.ToInt16(1), day.AddDays(5), day.AddDays(5).AddMinutes(50), 20, "...");
                                Exercise e136 = new Exercise(Form1.idAstron, Convert.ToInt16(1), day.AddDays(6), day.AddDays(6).AddMinutes(50), 20, "...");
                                context.Exercise.Add(e111);
                                context.Exercise.Add(e112);
                                context.Exercise.Add(e113);
                                context.Exercise.Add(e114);
                                context.Exercise.Add(e115);
                                context.Exercise.Add(e116);
                                context.Exercise.Add(e121);
                                context.Exercise.Add(e122);
                                context.Exercise.Add(e123);
                                context.Exercise.Add(e124);
                                context.Exercise.Add(e125);
                                context.Exercise.Add(e126);
                                context.Exercise.Add(e131);
                                context.Exercise.Add(e132);
                                context.Exercise.Add(e133);
                                context.Exercise.Add(e134);
                                context.Exercise.Add(e135);
                                context.Exercise.Add(e136);
                                context.SaveChanges();
                                break;
                            case 2:
                                //15:00pm -First machine they will use for the rest of the week
                                Exercise e211 = new Exercise(Form1.idAstron, Convert.ToInt16(2), day.AddDays(1), day.AddDays(1).AddMinutes(50), 20, "...");
                                Exercise e212 = new Exercise(Form1.idAstron, Convert.ToInt16(1), day.AddDays(2), day.AddDays(2).AddMinutes(50), 20, "...");
                                Exercise e213 = new Exercise(Form1.idAstron, Convert.ToInt16(3), day.AddDays(3), day.AddDays(3).AddMinutes(50), 20, "...");
                                Exercise e214 = new Exercise(Form1.idAstron, Convert.ToInt16(2), day.AddDays(4), day.AddDays(4).AddMinutes(50), 20, "...");
                                Exercise e215 = new Exercise(Form1.idAstron, Convert.ToInt16(1), day.AddDays(5), day.AddDays(5).AddMinutes(50), 20, "...");
                                Exercise e216 = new Exercise(Form1.idAstron, Convert.ToInt16(3), day.AddDays(6), day.AddDays(6).AddMinutes(50), 20, "...");

                                day = day.AddMinutes(50); //15:50pm -Second machine they will use for the rest of the week
                                Exercise e221 = new Exercise(Form1.idAstron, Convert.ToInt16(3), day.AddDays(1), day.AddDays(1).AddMinutes(50), 20, "...");
                                Exercise e222 = new Exercise(Form1.idAstron, Convert.ToInt16(3), day.AddDays(2), day.AddDays(2).AddMinutes(50), 20, "...");
                                Exercise e223 = new Exercise(Form1.idAstron, Convert.ToInt16(1), day.AddDays(3), day.AddDays(3).AddMinutes(50), 20, "...");
                                Exercise e224 = new Exercise(Form1.idAstron, Convert.ToInt16(3), day.AddDays(4), day.AddDays(4).AddMinutes(50), 20, "...");
                                Exercise e225 = new Exercise(Form1.idAstron, Convert.ToInt16(3), day.AddDays(5), day.AddDays(5).AddMinutes(50), 20, "...");
                                Exercise e226 = new Exercise(Form1.idAstron, Convert.ToInt16(1), day.AddDays(6), day.AddDays(6).AddMinutes(50), 20, "...");
                                day = day.AddMinutes(50); //14:40pm -Third machine they will use for the rest of the week
                                Exercise e231 = new Exercise(Form1.idAstron, Convert.ToInt16(1), day.AddDays(1), day.AddDays(1).AddMinutes(50), 20, "...");
                                Exercise e232 = new Exercise(Form1.idAstron, Convert.ToInt16(2), day.AddDays(2), day.AddDays(2).AddMinutes(50), 20, "...");
                                Exercise e233 = new Exercise(Form1.idAstron, Convert.ToInt16(2), day.AddDays(3), day.AddDays(3).AddMinutes(50), 20, "...");
                                Exercise e234 = new Exercise(Form1.idAstron, Convert.ToInt16(1), day.AddDays(4), day.AddDays(4).AddMinutes(50), 20, "...");
                                Exercise e235 = new Exercise(Form1.idAstron, Convert.ToInt16(2), day.AddDays(5), day.AddDays(5).AddMinutes(50), 20, "...");
                                Exercise e236 = new Exercise(Form1.idAstron, Convert.ToInt16(2), day.AddDays(6), day.AddDays(6).AddMinutes(50), 20, "...");
                                context.Exercise.Add(e211);
                                context.Exercise.Add(e212);
                                context.Exercise.Add(e213);
                                context.Exercise.Add(e214);
                                context.Exercise.Add(e215);
                                context.Exercise.Add(e216);
                                context.Exercise.Add(e221);
                                context.Exercise.Add(e222);
                                context.Exercise.Add(e223);
                                context.Exercise.Add(e224);
                                context.Exercise.Add(e225);
                                context.Exercise.Add(e226);
                                context.Exercise.Add(e231);
                                context.Exercise.Add(e232);
                                context.Exercise.Add(e233);
                                context.Exercise.Add(e234);
                                context.Exercise.Add(e235);
                                context.Exercise.Add(e236);
                                context.SaveChanges();
                                break;
                            case 3:
                                //15:00pm -First machine they will use for the rest of the week
                                Exercise e311 = new Exercise(Form1.idAstron, Convert.ToInt16(3), day.AddDays(1), day.AddDays(1).AddMinutes(50), 20, "...");
                                Exercise e312 = new Exercise(Form1.idAstron, Convert.ToInt16(2), day.AddDays(2), day.AddDays(2).AddMinutes(50), 20, "...");
                                Exercise e313 = new Exercise(Form1.idAstron, Convert.ToInt16(1), day.AddDays(3), day.AddDays(3).AddMinutes(50), 20, "...");
                                Exercise e314 = new Exercise(Form1.idAstron, Convert.ToInt16(3), day.AddDays(4), day.AddDays(4).AddMinutes(50), 20, "...");
                                Exercise e315 = new Exercise(Form1.idAstron, Convert.ToInt16(2), day.AddDays(5), day.AddDays(5).AddMinutes(50), 20, "...");
                                Exercise e316 = new Exercise(Form1.idAstron, Convert.ToInt16(1), day.AddDays(6), day.AddDays(6).AddMinutes(50), 20, "...");

                                day = day.AddMinutes(50); //15:50pm -Second machine they will use for the rest of the week
                                Exercise e321 = new Exercise(Form1.idAstron, Convert.ToInt16(1), day.AddDays(1), day.AddDays(1).AddMinutes(50), 20, "...");
                                Exercise e322 = new Exercise(Form1.idAstron, Convert.ToInt16(1), day.AddDays(2), day.AddDays(2).AddMinutes(50), 20, "...");
                                Exercise e323 = new Exercise(Form1.idAstron, Convert.ToInt16(2), day.AddDays(3), day.AddDays(3).AddMinutes(50), 20, "...");
                                Exercise e324 = new Exercise(Form1.idAstron, Convert.ToInt16(1), day.AddDays(4), day.AddDays(4).AddMinutes(50), 20, "...");
                                Exercise e325 = new Exercise(Form1.idAstron, Convert.ToInt16(1), day.AddDays(5), day.AddDays(5).AddMinutes(50), 20, "...");
                                Exercise e326 = new Exercise(Form1.idAstron, Convert.ToInt16(2), day.AddDays(6), day.AddDays(6).AddMinutes(50), 20, "...");
                                day = day.AddMinutes(50); //16:40pm -Third machine they will use for the rest of the week
                                Exercise e331 = new Exercise(Form1.idAstron, Convert.ToInt16(2), day.AddDays(1), day.AddDays(1).AddMinutes(50), 20, "...");
                                Exercise e332 = new Exercise(Form1.idAstron, Convert.ToInt16(3), day.AddDays(2), day.AddDays(2).AddMinutes(50), 20, "...");
                                Exercise e333 = new Exercise(Form1.idAstron, Convert.ToInt16(3), day.AddDays(3), day.AddDays(3).AddMinutes(50), 20, "...");
                                Exercise e334 = new Exercise(Form1.idAstron, Convert.ToInt16(2), day.AddDays(4), day.AddDays(4).AddMinutes(50), 20, "...");
                                Exercise e335 = new Exercise(Form1.idAstron, Convert.ToInt16(3), day.AddDays(5), day.AddDays(5).AddMinutes(50), 20, "...");
                                Exercise e336 = new Exercise(Form1.idAstron, Convert.ToInt16(3), day.AddDays(6), day.AddDays(6).AddMinutes(50), 20, "...");
                                context.Exercise.Add(e311);
                                context.Exercise.Add(e312);
                                context.Exercise.Add(e313);
                                context.Exercise.Add(e314);
                                context.Exercise.Add(e315);
                                context.Exercise.Add(e316);
                                context.Exercise.Add(e321);
                                context.Exercise.Add(e322);
                                context.Exercise.Add(e323);
                                context.Exercise.Add(e324);
                                context.Exercise.Add(e325);
                                context.Exercise.Add(e326);
                                context.Exercise.Add(e331);
                                context.Exercise.Add(e332);
                                context.Exercise.Add(e333);
                                context.Exercise.Add(e334);
                                context.Exercise.Add(e335);
                                context.Exercise.Add(e336);
                                context.SaveChanges();
                                break;

                        }

                    }
                }
            }
        }

        private void exerciseMenu_Click(object sender, EventArgs e)
        {
            ExerciseSchedule eS = new ExerciseSchedule();
            eS.Show();
        }

        private void napToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DateTime today = DateTime.Today;
            
            String query = $"select * from Sleep where idAstr = '{Form1.idAstron}' and day(wakeupTime) = '{today.Day}' and MONTH(wakeupTime) = '{today.Month}' and year(wakeupTime) = '{today.Year}'";
            List<Sleep> lsSleep = context.Sleep.SqlQuery(query).ToList();
            if (lsSleep.Count != 0)
            {
                DateTime wake = lsSleep[0].wakeupTime.Value;
                DateTime bed = lsSleep[0].bedTime.Value;
                double hours = (wake.Hour + 24 - bed.Hour) % 24 + ((wake.Minute + 60 - bed.Minute) % 60 / 60);
                if (hours < 6.5)
                {
                    string cadSQLExis;
                    cadSQLExis = $"select * from Exercise where idAstr = '{Form1.idAstron}' and day(starT) ='{today.Day}' and month(start) = '{today.Month}' and year(starT) = '{today.Year}'";
                    List<Exercise> lsExerExis = context.Exercise.SqlQuery(cadSQLExis).ToList();

                    DateTime exer = lsExerExis[0].starT.Value;
                    if(exer.Hour == 10)
                    {
                        MessageBox.Show("Nap schedule at 15:00 with a duration of " + (int) hours + " hour(s) and " + (wake.Minute + 60 - bed.Minute) % 60  + " minutues.");
                    }
                    else
                    {
                        MessageBox.Show("Nap schedule at 10:00 with a duration of " + (int)hours + " hour(s) and " + (int)(hours * 60) + "minutues.");
                    }

                }
                else
                {
                    MessageBox.Show("There´s not a nap schedule for today.");
                }
            }
            else
            {
                MessageBox.Show("First put last night´s sleeping information. ");
            }




           
           
        }

        private void addSleepingInformationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SleepInfo s = new SleepInfo();
            s.Show();
        }

        private void eastMenuItem_Click(object sender, EventArgs e)
        {
            East ea = new East();
            ea.Show();

        }

        private void westMenuItem_Click(object sender, EventArgs e)
        {
            West we = new West();
            we.Show();
        }
    }
}
