using Aplicacion;
using Entidades;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ControlCuentas_ShekinahServices
{
    public partial class Acceso : Form
    {
        private IAcessoSistema<AccesoSistema> _repositorio;
        private readonly IServiceProvider _serviceProvider;
        private AccesoSistema _accesoSistema = new AccesoSistema();
        bool bandera;

        public Acceso(IAcessoSistema<AccesoSistema> repositorio, IServiceProvider serviceProvider)
        {
            _repositorio = repositorio;
            _serviceProvider = serviceProvider;
            InitializeComponent();
            Libreria_Interna.AplicarEsquinasRedondeadas(this, 20);
            Libreria_Interna.AplicarBordesEsquinasBoton(btnAcceder, 5);
            Libreria_Interna.AplicarBordesEsquinasBoton(btnCancelar, 5);
            btnAcceder.BackColor = ColoresRGB.Gris_Claro;
        }

        private void Grp_Acceso_Enter(object sender, EventArgs e)
        {

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private async void txt_Usuario_Leave(object sender, EventArgs e)
        {
            bandera = await _repositorio.Verificar_Usuario(txt_Usuario.Text);
            if (bandera)
            {
                //MessageBox.Show("Usuario Encontrado");
                txt_Usuario.BackColor = Color.White;
                erP_Usuario.Clear();
                btnAcceder.Enabled = true;
                btnAcceder.BackColor = ColoresRGB.Verde_Menta_Boton;
            }
            else
            {
                // MessageBox.Show("Usuario No Encontrado");
                txt_Usuario.BackColor = ColoresRGB.Rojo_Vino;
                erP_Usuario.SetError(txt_Usuario, "Nombre de usario no registrado!");
                btnAcceder.Enabled = false;
                btnAcceder.BackColor = ColoresRGB.Gris_Claro;
                txt_Usuario.Focus();
            }
        }

        private async void btnAcceder_Click(object sender, EventArgs e)
        {
            Acceder_Sistema();
        }

        private async void Acceder_Sistema()
        {
            if (txt_Usuario.Text == string.Empty || txt_Contrasenia.Text == string.Empty)
            {
                MessageBox.Show("Debe Completar todos los campos");
            }
            else
            {
                bandera = await _repositorio.Acceder_Sistema(txt_Usuario.Text, txt_Contrasenia.Text);
                if (bandera)
                {
                    Frm_Main frm_Main = new Frm_Main(_serviceProvider);
                    this.Hide();
                    frm_Main.ShowDialog();
                }
            }
        }

        private void txt_Contrasenia_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter) // Verifica si la tecla presionada es "Enter"
            {
                e.SuppressKeyPress = true; // Evita el sonido de "ding" en el TextBox
                Acceder_Sistema();
            }
        }
    }
}
