﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FISCA.Presentation.Controls;
using FISCA.UDT;

namespace ischool.Sports.Ribbon.EventTemplates
{
    public partial class frmEventTemplates : BaseForm
    {
        private AccessHelper _access = new AccessHelper();
        private string _userAccount = DAO.Actor.Instance().GetUserAccount();

        public frmEventTemplates()
        {
            InitializeComponent();
        }
    }
}