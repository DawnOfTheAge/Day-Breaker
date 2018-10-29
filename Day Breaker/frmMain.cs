using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Day_Breaker
{
    public partial class frmMain : Form
    {
        private double m_TotalDays;

        public frmMain()
        {
            InitializeComponent();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            dtStart.Value = new DateTime(2018, 9, 23);
            dtEnd.Value = DateTime.Now;
        }
        
        private void btnCalculate_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtCurrentKilometersCount.Text))
            {
                MessageBox.Show("Enter Current Kilometers Count");

                return;
            }

            if (string.IsNullOrEmpty(txtKilometersAYear.Text))
            {
                MessageBox.Show("Enter Current Kilometers A Year");

                return;
            }

            m_TotalDays = (dtEnd.Value - dtStart.Value).TotalDays;

            txtDays.Text = ((int)m_TotalDays).ToString();
            txtPlannedKilometersPerDay.Text = (int.Parse(txtKilometersAYear.Text) / 365).ToString();
            txtShouldBeKilometersCount.Text = ((int.Parse(txtKilometersAYear.Text) / 365) * (int)m_TotalDays).ToString();
            txtKilometersPerDay.Text = (int.Parse(txtCurrentKilometersCount.Text) / (int)m_TotalDays).ToString();
        }
    }
}
