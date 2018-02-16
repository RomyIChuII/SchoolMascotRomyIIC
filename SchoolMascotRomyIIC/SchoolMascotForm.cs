/*
 * Created by: Romy I. Chu II
 * Created on: 16-February-2018
 * Created for: ICS3U Programming
 * Daily Assignment – Day #7 - School Mascot
*/
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SchoolMascotRomyIIC
{
    public partial class frmSchoolMascot : Form
    {
        public frmSchoolMascot()
        {
            InitializeComponent();
        }

        private void mniImmaculata_Click(object sender, EventArgs e)
        {
            lblSchoolName.Text = "Immaculata High School";
            lblSchoolMascot.Text = "Saints";
        }

        private void mniBellHigh_Click(object sender, EventArgs e)
        {
            lblSchoolName.Text = "Bell High school";
            lblSchoolMascot.Text = "Bruins";
        }

        private void mniStMark_Click(object sender, EventArgs e)
        {
            lblSchoolName.Text = "St. Mark's High School";
            lblSchoolMascot.Text = "Lions";
        }

        private void mniStPaul_Click(object sender, EventArgs e)
        {
            lblSchoolName.Text = "St. Paul's High School";
            lblSchoolMascot.Text = "Golden Bears";
        }
    }
}
