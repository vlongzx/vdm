﻿using Sunny.UI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace com.vdm.form
{
    public partial class frmPlantInfo : UIEditForm
    {
        private int plant_id;
        public frmPlantInfo()
        {
            InitializeComponent();
        }

        public frmPlantInfo(int plant_id)
        {
            InitializeComponent();
            this.plant_id = plant_id;
        }
    }
}
