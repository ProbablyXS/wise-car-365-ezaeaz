//' Trainer created by XsplitS '

//' WEBSITE : http://hrtmtm.flnet.org '

//' SI VOUS TENTEZ DE TOUCHER OU DE VOLER MES CODAGES, VOUS SERREZ EN MESURE DE VOUS APPELEZ " LE GROS DEBILE DE SERVICE ". '

//' Copyright : HRTM '







using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
using System.IO;
using System.Media;
using System.Net;

namespace WISE_CARE_365_CRACK
{
    public partial class Form1 : Form
    {

        WebClient Downloadversion = new WebClient();

        public Form1()
        {

            InitializeComponent();

        }


        private void Form1_Load(object sender, EventArgs e)
        {

            label5.Text = Downloadversion.DownloadString("http://hrtmtm.flnet.org/HRTM/SOFTWARES/WISE_CARE_365/VERSION.ini");

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {

                string path = Path.Combine(Path.GetTempPath(), "HRTM.exe");
                File.WriteAllBytes(path, Properties.Resources.HRTM);
                Process.Start(path);


                System.Threading.Thread.Sleep(4000);

                string path1 = Path.Combine(Path.GetTempPath(), "Fix.bat");
                File.WriteAllText(path1, Properties.Resources.Fix);
                Process.Start(path1);

                label3.Text = "Success";
                button1.Enabled = false;
            }

            catch (Exception error)
            {

                MessageBox.Show("Error !  EXECUTE PROGRAM TO ADMINISTRATOR FOR GOOD SYSTEM FUNCTION ! or restart program." + error.ToString());
                label3.ForeColor = Color.DarkRed;
                label3.Text = "Error";
                button1.Enabled = false;

            }
        }

        private void CLOSE_Click(object sender, EventArgs e)
        {

            Close();

        }
    }
}
