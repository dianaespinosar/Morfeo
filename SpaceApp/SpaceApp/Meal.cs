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
    public partial class Meal : Form
    {

        MorfeoAppEntities context = new MorfeoAppEntities();
        public Meal()
        {
            InitializeComponent();
        }



        private void Meal_Load(object sender, EventArgs e)
        {
            //Carga el combo de los alumnos con los nombres. 
            foreach (Food a in context.Food)
                cbFood.Items.Add(a.foodN);

        }

        private void cbFood_SelectedIndexChanged(object sender, EventArgs e)
        {


        }

        private void btAdd_Click(object sender, EventArgs e)
        {
            int hour = 0;
            int min = 0;

            if (!String.IsNullOrEmpty(txHour.Text))
                hour = Convert.ToInt32(txHour.Text);

            if(!String.IsNullOrEmpty(txMinute.Text))
                min = Convert.ToInt32(txMinute.Text);

            if (hour > 23 || hour < 0 || min < 0 || min >= 60)
            {
                MessageBox.Show("Wrong time");
            }
            else
            {
                string cadSql;
                cadSql = $"select * from Food where foodN = '{cbFood.Text}'";
                List<Food> lsFood = context.Food.SqlQuery(cadSql).ToList();
                DateTime fecha = Convert.ToDateTime(dtpTime.Value.ToShortDateString());
                fecha = fecha.AddHours(hour);
                fecha = fecha.AddMinutes(min);

                //inserta
                Meals m = new Meals(Form1.idAstron, lsFood[0].idFood, fecha, cbBLD.Text);
                context.Meals.Add(m);
                context.SaveChanges();
                MessageBox.Show("Registered meal.");
                txHour.Text = "";
                txMinute.Text = "";
                cbFood.Text = "";
                cbBLD.Text = "";
            }
               

           
        }
    }
}
