using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace YT_Sophisticated_Design_1
{
    public partial class Splash : Form
    {
        int startpoint = 0;

        public Splash()
        {
            InitializeComponent();            
            
        }

        private void timer1_Tick(object sender, EventArgs e)
        {

            bunifuProgressBar1.Value = startpoint;
            startpoint += 5;            

            if(bunifuProgressBar1.Value == 100)
            {                
                timer1.Stop();

                Login_Form F = new Login_Form();
                this.Hide();
                F.Show();
            }

        }

        private void Splash_Load(object sender, EventArgs e)
        {
            
            timer1.Start();
        }
    }
}
