﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClinicaFrba.Registro_Llegada
{
    public partial class TurnoProfesional : Form
    {
        public TurnoProfesional()
        {
            InitializeComponent();
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormProvider.RegistroLlegada.Show();
        }

        private void btnSeleccTurno_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormProvider.RegistroLlegada.Show();

        }
    }
}
