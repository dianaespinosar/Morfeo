using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SpaceApp
{
    
    public partial class Form1 : Form
    {

        MorfeoAppEntities context = new MorfeoAppEntities();
        public Form1()
        {
            InitializeComponent();
        }

        private void btAcceder_Click(object sender, EventArgs e)
        {

            string cadSQL;
            cadSQL = $"select * from Astronaut where idAstr = '{txUsu.Text}' and " +
                $"passw = '{txContra.Text}'";
           
            List<Astronaut> lsAstr = context.Astronaut.SqlQuery(cadSQL).ToList();

            //Verifing that the information is correct
            if (lsAstr.Count != 0)
            {
                idAstron = lsAstr[0].idAstr;
                MainWindow w = new MainWindow();
                    w.Show();
                
              
            }
            else
                MessageBox.Show("Incorrect information.");
        }

        public static int idAstron = 0;
    }
}
