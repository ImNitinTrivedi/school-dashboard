using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace school_system
{
    public partial class examination : Form
    {
        public examination()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            int num1, num2, num3, num4, num5, num6 ,Total, Obatin, p1, p2, p3, p4,Per;

            num1 = Convert.ToInt32(textHindi.Text);
            num2 = Convert.ToInt32(textEnglish.Text);
            num3 = Convert.ToInt32(textMath.Text);
            num4 = Convert.ToInt32(textScience.Text);
            num5 = Convert.ToInt32(textSocialS.Text);                 
            num6 = Convert.ToInt32(textPractical.Text);

            //For Obtain Marks

            Total = num1 + num2 + num3 + num4 + num5 + num6 ;
            lblTotalO.Text = Total.ToString();

            //For Individual Course Grade
           int A;
           A = Convert.ToInt32(textHindi.Text);
           if (A >= 85 && A <= 100)
           {
               lblH.Text = "A+";
           }
           else if (A >= 75 && A <= 84)
           {
               lblH.Text = "A";
           }
           else if (A >= 60 && A <= 74)
           {
               lblH.Text = "B";
           }
           else if (A >= 33 && A <= 59)
           {
               lblH.Text = "C";
           }
           else if (A >= 0 && A <= 32)
           {
               lblH.Text = "F";
           }
           int B;
           B= Convert.ToInt32(textEnglish.Text);
           if (B >= 85 && B <= 100)
           {
               lblE.Text = "A+";
           }
           else  if (B >= 70 && B<= 84)
           {
               lblE.Text = "A";
           }
           else if (B >= 60 && B <= 74)
           {
               lblE.Text = "B";
           }
           else if (B >= 33 && B <= 59)
           {
               lblE.Text = "C";
           }
           else if (B >= 0 && B <= 32)
           {
               lblE.Text = "F";
           }
           int C;
           C = Convert.ToInt32(textMath.Text);
           if (C >= 85 && C <= 100)
           {
               lblM.Text = "A+";
           }
           else if (C >= 75 && C <= 84)
           {
               lblM.Text = "A";
           }
           else if (C >= 60 && C <= 74)
           {
               lblM.Text = "B";
           }
           else if (C >= 33 && C <= 59)
           {
               lblM.Text = "C";
           }
           else if (C >= 0 && C <= 32)
           {
               lblM.Text = "F";
           }
           int D;
           D = Convert.ToInt32(textScience.Text);
           if (D >= 85 && D <= 100)
           {
               lblS.Text = "A+";
           }
           else if (D >= 75 && D <= 84)
           {
               lblS.Text = "A";
           }
           else if (D >= 60 && D <= 74)
           {
               lblS.Text = "B";
           }
           else if (D >= 33 && D <= 59)
           {
               lblS.Text = "C";
           }
           else if (D >= 0 && D <= 32)
           {
               lblS.Text = "F";
           }
         int E;
         E = Convert.ToInt32(textSocialS.Text);
           if (E >= 85 && E <= 100)
           {
               lblSS.Text = "A+";
           }
           else  if (E >= 75 && E<= 84)
           {
               lblSS.Text = "A";
           }
           else if (E >= 60 && E <= 74)
           {
               lblSS.Text = "B";
           }
           else if (E >= 33 && E <= 59)
           {
               lblSS.Text = "C";
           }
           else if (E >= 0 && E <= 32)
           {
               lblSS.Text = "F";
           }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
