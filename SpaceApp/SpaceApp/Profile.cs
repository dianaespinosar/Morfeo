using Microsoft.VisualBasic;
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
    public partial class Profile : Form
    {

        MorfeoAppEntities context = new MorfeoAppEntities();
        public Profile()
        {
            InitializeComponent();
        }



        private void Profile_Load(object sender, EventArgs e)
        {
            lbIm.ImageIndex = Form1.idAstron - 1;


            string cadSQL = $"select * from Astronaut where idAstr = '{Form1.idAstron}'";
            List<Astronaut> lsAstr = context.Astronaut.SqlQuery(cadSQL).ToList();

            string cadSQL3 = $"select * from ALLERGYASTR where idAstr = '{Form1.idAstron}'";
            List<allergyAstr> lsAll = context.allergyAstr.SqlQuery(cadSQL3).ToList();
            int n = lsAll.Count();
            StringBuilder cad = new StringBuilder();
            for(int i = 0; i < n ; i++)
            {
                string cadSQL4 = $"select * from ALLERGies where idAllergy = '{lsAll[i].idAllergy}'";
                List<Allergies> lsAlle = context.Allergies.SqlQuery(cadSQL4).ToList();
                if (i < n - 1)
                    cad.Append(lsAlle[0].allergy).Append(", ");
                else
                    cad.Append(lsAlle[0].allergy);
            }

            
            //We know the astronaut exits because it was verified in Form1.
            lbNa.Text = lsAstr[0].name + " " + lsAstr[0].surname;
            int edad = DateTime.Now.Year -  lsAstr[0].birth.Value.Year;
            lbAg.Text = Convert.ToString(edad);
            lbge.Text = lsAstr[0].gender;
            lbHei.Text = Convert.ToString(lsAstr[0].height);
            lbWei.Text = Convert.ToString(lsAstr[0].weight);
            lbNaci.Text = lsAstr[0].nationality;
            lbAll.Text = cad.ToString();

            
        }
    }
}
