﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClinicaFrba.Cancelar_Atencion
{
    public partial class CancelacionAfiliado : Form
    {
        public CancelacionAfiliado()
        {
            InitializeComponent();
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormProvider.Cancelacion.Show();
        }

        private void btnGuardarCanc_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormProvider.Cancelacion.Show();
        }
    }
}
