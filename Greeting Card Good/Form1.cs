using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Greeting_Card_Good
{
    public partial class lepusConstellation : Form
    {
        public lepusConstellation()
        {
            InitializeComponent();
            //Start with paragraph invisible
            labelParagraph.Visible = false;
        }

        private void Form1_MouseClick(object sender, MouseEventArgs e)
        {
            //Setting up graphics
            Graphics g = this.CreateGraphics();
            //Creating brush for stars
            SolidBrush starBrush = new SolidBrush(Color.White);
            //Creating brush for lines
            Pen linePen = new Pen(Color.BlueViolet, 5);
            //Make labels disappear
            labelLepusTitle.Visible = false;
            labelName.Visible = false;
            //Title font
            Font titleFont = new Font("Futura", 35, FontStyle.Bold);
            SolidBrush titleBrush = new SolidBrush(Color.White);
            //Body text font
            Font bodyFont = new Font("Times New Roman", 12, FontStyle.Bold);
            SolidBrush bodyBrush = new SolidBrush(Color.White);
            //Clear Background
            g.Clear(Color.Black);
            //Line connecting Star 6 and Star 9
            g.DrawLine(linePen, 377, 135, 433, 112);
            //Line connecting Star 9 and Star 7
            g.DrawLine(linePen, 433, 112, 488, 124);
            //Line connecting Star 7 and Star 2
            g.DrawLine(linePen, 488, 124, 575, 184);
            //Line connecting Star 2 and Star 5
            g.DrawLine(linePen, 575, 184, 697, 151);
            //Line connecting Star 2 and Star 3
            g.DrawLine(linePen, 575, 184, 613, 289);
            //Line connecting Star 5 and Star 11
            g.DrawLine(linePen, 700, 151, 669, 79);
            //Line connecting Star 5 and Star 12
            g.DrawLine(linePen, 701, 151, 715, 70);
            //Line connecting Star 5 and Star 4
            g.DrawLine(linePen, 701, 151, 754, 319);
            //Line connecting Star 4 and Star 3
            g.DrawLine(linePen, 754, 319, 612, 289);
            //Line connecting Star 3 and Star 8
            g.DrawLine(linePen, 612, 289, 507, 315);
            //Line connecting Star 8 and Star 10
            g.DrawLine(linePen, 507, 315, 466, 266);
            //Line connecting Star 10 and Star 6
            g.DrawLine(linePen, 466, 266, 379, 134);
            //Line connecting Star 10 and Star 2
            g.DrawLine(linePen, 466, 266, 572, 186);
            //Star 6
            g.FillEllipse(starBrush, 375, 130, 10, 10);
            //Star 9
            g.FillEllipse(starBrush, 430, 107, 10, 10);
            //Star 7
            g.FillEllipse(starBrush, 485, 120, 10, 10);
            //Star 2
            g.FillEllipse(starBrush, 570, 180, 10, 10);
            //Star 5
            g.FillEllipse(starBrush, 695, 145, 10, 10);
            //Star 11
            g.FillEllipse(starBrush, 665, 75, 10, 10);
            //Star 12
            g.FillEllipse(starBrush, 710, 68, 10, 10);
            //Star 4
            g.FillEllipse(starBrush, 750, 315, 10, 10);
            //Star 3
            g.FillEllipse(starBrush, 610, 285, 10, 10);
            //Star 8 
            g.FillEllipse(starBrush, 505, 310, 10, 10);
            //Star 10
            g.FillEllipse(starBrush, 460, 260, 10, 10);
            //Star 1
            g.FillEllipse(starBrush, 620, 350, 10, 10);
            //Lepus constellation title
            g.DrawString("LEPUS CONSTELLATION", titleFont, titleBrush, 310, 375);
            //Make paragraph visible
            labelParagraph.Visible = true;
        }
    }
}
