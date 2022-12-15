using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Pruebas_Web
{
    public partial class Michael : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            
            
        }
        protected void OneClick_Submite(object sender,EventArgs e)
        {
            label2.Text= text.Text;
        }
        public void Calender1_seleccionado(object sender, EventArgs e)
        {
           // data_text.Text = "You selected" + calendar1.SelectedDate.ToString("D")+"\n";
            string dia = calendar1.SelectedDate.Day.ToString();
            string mes = calendar1.SelectedDate.Month.ToString();
            //data_text.Text = mes + "" + dia;
            Dictionary <string,string> cumpleaños = new Dictionary<string,string>();
            string completo = dia+"-"+mes;
            cumpleaños.Add("30-05","Marc");
            cumpleaños.Add("12-08", "Sergi");
            cumpleaños.Add("22-12", "Jordi");
            cumpleaños.Add("10-12", "Michael");
            cumpleaños.Add("16-01", "Dana");


          /*  foreach (var entry in cumpleaños)
            {
                
                cumples.Items.Add(entry.Value);
            }*/
            bool v = true;
            

        }public void desplegable(object sender, EventArgs e)
        {
            
            string Conection_String = "Data Source=localhost\\SQLEXPRESS;Database=asp_pruebas;integrated security=SSPI";
            SqlConnection connection = new SqlConnection(Conection_String);
            SqlCommand cm = new SqlCommand("select * from cumpleños", connection);

            connection.Open();

            SqlDataReader sdr = cm.ExecuteReader();

            while (sdr.Read())
            {
                string todo = ("Dia y mes de cumpleaños: "+sdr["dia"] + "-" + sdr["mes"] + " nombre: " + sdr["nombre"]);
                cumples.Items.Add(todo);
            }
        }

    }
}