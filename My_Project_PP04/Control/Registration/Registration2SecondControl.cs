﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace My_Project_PP04.Control.Registration
{
    public partial class Registration2SecondControl : UserControl
    {
        public Registration2SecondControl()
        {
            InitializeComponent();
        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            Program.AuthorizationAndRegistration.Registration.radioButtonControl1.Checked = true;
        }

        private void buttonContinue_Click(object sender, EventArgs e)
        {
            Program.AuthorizationAndRegistration.Registration.radioButtonControl3.Checked = true;
        }

        private void Registration2SecondControl_Load(object sender, EventArgs e)
        {
            Program.AuthorizationAndRegistration.Registration.validateTexBoxCheckasd.Add(validateTexBox1);
            Program.AuthorizationAndRegistration.Registration.validateTexBoxCheckasd.Add(validateTexBox2);
            Program.AuthorizationAndRegistration.Registration.validateTexBoxCheckasd.Add(validateTexBox3);

        }

        private void Registration2SecondControl_VisibleChanged(object sender, EventArgs e)
        {
            if (this.Visible == true)
            {
                Program.AuthorizationAndRegistration.Registration.radioButtonControl2.Checked = true;
            }
            
        }
    }
}
