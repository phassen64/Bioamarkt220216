﻿using System;
using System.Windows.Forms;

namespace ProNatur_Biomarkt_GmbH
{
    public partial class Form_LoadingScreen : Form
    {
        const string sFile = "peter";
        private bool bForm_load = false;
        private int iLoad = 0;
        public Form_LoadingScreen()
        {
            InitializeComponent();
        }

        private void Form_LoadingScreen_Load(object sender, EventArgs e)
        {
            if (!bForm_load)
            {
                bForm_load = true;
                iLoad = progressBar_main.Minimum;
            }
            timer_loading.Start();
            label_loading.Text = "wait!";
        }

        private void timer_loading_Tick(object sender, EventArgs e)
        {
            float   f;
            int     i;

            if (iLoad <= progressBar_main.Minimum)
            {
                label_loading.Text = "loading ...";
            }
            else if (iLoad > progressBar_main.Maximum)
            {
                timer_loading.Stop();
                label_loading.Text = "finished!";
            }
            else
            {
                f = (float)iLoad / (float)progressBar_main.Maximum;
                f *= 100.0f;
                i = (int)Math.Truncate(f);
                progressBar_main.Value = i;

                label_pct.Text = iLoad.ToString() + "%";
            }
            iLoad += 1;
        }

        private void button_restart_Click(object sender, EventArgs e)
        {
            iLoad = progressBar_main.Minimum;
            label_loading.Text = "wait! ...";
            timer_loading.Start();
        }
    }
}
