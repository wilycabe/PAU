//using System;
//using System.Collections.Generic;
//using System.ComponentModel;
//using System.Data;
//using System.Drawing;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;
////using System.Windows.Forms;
////using MySql.Data;
////using MySql.Data.MySqlClient;

//namespace CapaBase
//{
//    public partial class ReporteEncomienda : Form
//    {
//        public ReporteEncomienda()
//        {
//            InitializeComponent();
//        }

//        private void ReporteEncomienda_Load(object sender, EventArgs e)
//        {
//            string constr = "server=DESKTOP-HK8GGIP ; database=PAU ; integrated security = true";//"Data Source=DESKTOP-HK8GGIP\\SQLEXPRESS; Initial Catalog=PAU;Integrated Security=true";
//            MySqlConnection conectar = new MySqlConnection(constr);
//              try
//            {
//                conectar.Open();
//                string sql= "SELECT codigo_enc, ciudad_env_enc, direccion_env_enc, ciudad_lleg_enc, direccion_lleg_enc, fecha_enc, valor_enc, coigo_postal_enc,peso,descripcion,cedula_destinatario,cedula_cliente";
//            }
//              catch (Exception ex)
//            {
//                Console.WriteLine("Error al abrir la conexion", ex.Message);
//            }
//            conectar.Close();
//        }

       
              
        

//    } 
//}

