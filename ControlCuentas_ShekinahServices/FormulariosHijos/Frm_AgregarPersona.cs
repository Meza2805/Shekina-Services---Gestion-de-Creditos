using Aplicacion;
using Entidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ControlCuentas_ShekinahServices.FormulariosHijos
{
    public partial class Frm_AgregarPersona : Form
    {
        private readonly IPersona _Persona;
        int Id_Usuario;
        bool Guardar = true;
        bool Accion = true;
        public Frm_AgregarPersona(IPersona _Persona, IServiceProvider serviceProvider)
        {
            InitializeComponent();
            this._Persona = _Persona;
            this.KeyPreview = true; // Permite capturar teclas en el formulario
            Libreria_Interna.AplicarEsquinasRedondeadas(this, 20);
            Libreria_Interna.AplicarBordesEsquinasBoton(btnGuardar, 5);
            Libreria_Interna.AplicarBordesEsquinasBoton(btnCancelar, 5);
        }




        public void Recibir_Id_Usuario(int Id_Usuario)
        {
            this.Id_Usuario = Id_Usuario;
        }

        public void Tipo_Entrada(bool tipo)
        {
            if (tipo)
            {
                GrpAgregarCliente.Text = "Agregar Cliente";
                PicPhotoCliente.Image = Properties.Resources.AgregarPersona;
                Accion = true;
            }
            else
            {
                GrpAgregarCliente.Text = "Editar Cliente";
                PicPhotoCliente.Image = Properties.Resources.EditarPersona;
                Accion = false;
            }
        }

        public void RecibirDatosPersona(Persona persona)
        {
            txtPrimerNombreCliente.Text = persona.PrimerNombre;
            txtSegundoNombreCliente.Text = persona.SegundoNombre;
            txtPrimerApellidoCliente.Text = persona.PrimerApellido;
            txtSegundoApellidoCliente.Text = persona.SegundoApellido;
            txtNoCedulaCliente.Text = persona.NoCedula;
            txtTelefonoCliente.Text = persona.NoTelefono;
            txtDireccionCliente.Text = persona.Direccion;
            dtFechaNacCliente.Value = persona.FechaNacimiento;


        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Frm_AgregarPersona_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                this.Close(); // Cierra el formulario
            }
        }

        private void txtNoCedulaCliente_Leave(object sender, EventArgs e)
        {
            string dni = txtNoCedulaCliente.Text.Trim(); // Eliminar espacios en blanco

            string pattern = @"^\d{3}\d{6}\d{4}[A-Z]$"; // Regex corregida

            if (string.IsNullOrWhiteSpace(dni)) // Si el campo está vacío, no mostrar error
            {
                EpCedula.SetError(txtNoCedulaCliente, "");
                return;
                Guardar = false;
            }

            if (!Regex.IsMatch(dni, pattern))
            {
                EpCedula.SetError(txtNoCedulaCliente, "Formato inválido. Ejemplo: 4481504930001V");
                Guardar = false;
            }
            else
            {
                EpCedula.SetError(txtNoCedulaCliente, "");
                Guardar = true;
            }
        }

        private void txtTelefonoCliente_KeyPress(object sender, KeyPressEventArgs e)
        {
            Libreria_Interna.SoloNumeros(sender, e);
        }

        private void txtTelefonoCliente_Leave(object sender, EventArgs e)
        {
            if (txtTelefonoCliente.Text.Length < 8)
            {
                EpTelefono.SetError(txtTelefonoCliente, "La Numero Telefonico debe ser de al menos 8 Digitos");
                Guardar = false;
            }
            else
            {
                EpTelefono.SetError(txtTelefonoCliente, "");
                Guardar = true;
            }
        }

        private bool ValidarFechaNacimiento(DateTimePicker datePicker, ErrorProvider errorProvider, string mensajeError)
        {
            DateTime fechaNacimiento = datePicker.Value;
            int edad = DateTime.Now.Year - fechaNacimiento.Year;

            // Ajustar si aún no ha cumplido años este año
            if (fechaNacimiento.Date > DateTime.Now.AddYears(-edad))
            {
                edad--;
            }

            if (edad < 18)
            {
                errorProvider.SetError(datePicker, mensajeError);
                return false;
            }

            errorProvider.Clear();
            return true;
        }

        private void dtFechaNacCliente_Leave(object sender, EventArgs e)
        {
            // Calcula la diferencia de años entre la fecha seleccionada y la fecha actual
            int edad = DateTime.Now.Year - dtFechaNacCliente.Value.Year;

            // Ajustar si la fecha de nacimiento aún no ha ocurrido este año
            if (dtFechaNacCliente.Value.Date > DateTime.Now.AddYears(-edad))
            {
                edad--; // No ha cumplido años aún este año
            }

            // Validar si la persona es menor de 18 años
            if (edad < 18)
            {
                EpFechaNacimiento.SetError(dtFechaNacCliente, "La persona debe tener al menos 18 años.");
                Guardar = false;
            }
            else
            {
                EpFechaNacimiento.SetError(dtFechaNacCliente, ""); // Limpiar el error si es mayor de 18 años
                Guardar = true;
            }
        }

        private async void btnGuardar_Click(object sender, EventArgs e)
        {
            Guardar &= ValidarCampo(txtNoCedulaCliente, EpCedula, "Debe Ingresar un Número de Cédula");
            Guardar &= ValidarCampo(txtPrimerNombreCliente, EpPrimerNombre, "Debe Ingresar Primer Nombre");
            Guardar &= ValidarCampo(txtPrimerApellidoCliente, EpPrimerApellido, "Debe Ingresar Primer Apellido");
            Guardar &= ValidarCampo(txtDireccionCliente, EpDireccion, "Debe Ingresar Direccion");
            Guardar &= ValidarCampo(txtTelefonoCliente, EpTelefono, "El Teléfono debe contener exactamente 8 dígitos",
                texto => texto.All(char.IsDigit) && texto.Length == 8);
            // Validación de la fecha de nacimiento: Debe ser mayor o igual a 18 años.
            Guardar &= ValidarFechaNacimiento(dtFechaNacCliente, EpFechaNacimiento, "La persona debe tener al menos 18 años.");


            if (Guardar == true)
            {
                //MessageBox.Show("Todos los Campos son Correctos");
                Persona persona_r = new Persona
                {
                    NoCedula = txtNoCedulaCliente.Text,
                    PrimerNombre = txtPrimerNombreCliente.Text,
                    SegundoNombre = txtSegundoNombreCliente.Text,
                    PrimerApellido = txtPrimerApellidoCliente.Text,
                    SegundoApellido = txtSegundoApellidoCliente.Text,
                    FechaNacimiento = dtFechaNacCliente.Value, // ✅ Obtiene el valor de DateTimePicker correctamente
                    NoTelefono = txtTelefonoCliente.Text,
                    Direccion = txtDireccionCliente.Text,
                    UsuarioCrea = Id_Usuario
                };

                // Determinar si se debe insertar o modificar
                (int idGenerado, string mensaje) = Accion
                    ? await _Persona.InsertarAsync(persona_r)
                    : await _Persona.ModificarAsync(persona_r);

                // Verificar resultado e informar al usuario
                MessageBox.Show(mensaje, idGenerado == 1 ? "Éxito" : "Error",
                                MessageBoxButtons.OK,
                                idGenerado == 1 ? MessageBoxIcon.Information : MessageBoxIcon.Error);

                if (idGenerado == 1)
                {
                    this.Close();

                    // Buscar el formulario padre en la lista de formularios abiertos
                    if (Application.OpenForms["Frm_Persona"] is Frm_Persona padre)
                    {
                        await padre.Refrescar();
                    }
                }


            }
            else
            {
                MessageBox.Show("Campos Incompletos");
            }
        }

  

        private bool ValidarCampo(TextBox campo, ErrorProvider errorProvider, string mensajeError, Func<string, bool>? validacionAdicional = null)
        {
            string texto = campo.Text.Trim();

            if (string.IsNullOrWhiteSpace(texto) || (validacionAdicional != null && !validacionAdicional(texto)))
            {
                errorProvider.SetError(campo, mensajeError);
                return false;
            }

            errorProvider.Clear();
            return true;
        }
    }
}



