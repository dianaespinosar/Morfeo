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
    public partial class ExerciseSchedule : Form
    {

        MorfeoAppEntities context = new MorfeoAppEntities();
        public ExerciseSchedule()
        {
            InitializeComponent();
        }

        private void dtDay_ValueChanged(object sender, EventArgs e)
        {
            string cadsql;
            cadsql = $"select * from Exercise where idAstr = '{Form1.idAstron}' and day(starT) ='{dtDay.Value.Day}' and month(start) = '{dtDay.Value.Month}' and year(starT) = '{dtDay.Value.Year}'";
            List<Exercise> lsExer = context.Exercise.SqlQuery(cadsql).ToList();
            dgEx.DataSource = lsExer;
        }

        private void ExerciseSchedule_Load(object sender, EventArgs e)
        {
            string cadsql;
            cadsql = $"select * from Exercise where idAstr = '{Form1.idAstron}' and day(starT) ='{dtDay.Value.Day}' and month(start) = '{dtDay.Value.Month}' and year(starT) = '{dtDay.Value.Year}'";
            List<Exercise> lsExer = context.Exercise.SqlQuery(cadsql).ToList();
            dgEx.DataSource = lsExer;
        }
    }
}
