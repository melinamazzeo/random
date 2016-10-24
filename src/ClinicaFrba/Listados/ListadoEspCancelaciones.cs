﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClinicaFrba.Listados
{
    public partial class ListadoEspCancelaciones : Form
    {
        public ListadoEspCancelaciones()
        {
            InitializeComponent();

            dgvResultado.Rows.Clear();
            pickerAño.Format = DateTimePickerFormat.Custom;
            pickerAño.CustomFormat = "yyyy";
            pickerAño.ShowUpDown = true;
        }

        private void cmbSemestre_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormProvider.ListadoEstadistico.Show();
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            dgvResultado.Rows.Clear();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            Int32 mesInicio;
            Int32 mesFin;
            if (cmbSemestre.SelectedIndex == 0)
            {
                mesInicio = 1;
                mesFin = 6;
            }
            else
            {
                mesInicio = 7;
                mesFin = 12;
            }
            //Creo las fechas de inicio y fin dependiendo del año y el semestre elegido
            DateTime fechaInicio = new DateTime(Int32.Parse(pickerAño.Text), mesInicio, 1);
            DateTime fechaFin = new DateTime(Int32.Parse(pickerAño.Text), mesFin, 1);
            List<string> lista = new List<string>();
            lista.Add("@fechaFrom");
            lista.Add("@fechaTo");

            DataTable dt = Conexion.obtenerTablaProcedure("RANDOM.top5EspecialidadesConMasCancelacionesDeTurno",
            lista, String.Format("{0:yyyyMMdd HH:mm:ss}", fechaInicio), String.Format("{0:yyyyMMdd HH:mm:ss}", fechaFin));
            this.dgvResultado.DataSource = dt;
            dgvResultado.Enabled = false;
        }
    }
}
