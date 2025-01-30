using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace ControlCuentas_ShekinahServices
{
    public static class Libreria_Interna
    {
        // Método para centrar un Label horizontalmente en un formulario
        public static void CentrarLabel_Horizontal(Label label, Form formulario)
        {
            // Calcular la posición 'Left' para centrar el Label
            int posicionX = (formulario.ClientSize.Width - label.Width) / 2;

            // Asignar la posición calculada al Label
            label.Left = posicionX;
        }

        public static void CentrarPicture_Horizontal(PictureBox picture, Form formulario)
        {
            // Calcular la posición 'Left' para centrar el Label
            int posicionX = (formulario.ClientSize.Width - picture.Width) / 2;

            // Asignar la posición calculada al Label
            picture.Left = posicionX;
        }

        // Importar la función CreateRoundRectRgn desde la API de Windows
        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn(
            int nLeftRect,      // Coordenada izquierda
            int nTopRect,       // Coordenada superior
            int nRightRect,     // Coordenada derecha
            int nBottomRect,    // Coordenada inferior
            int nWidthEllipse,  // Ancho de la elipse
            int nHeightEllipse  // Altura de la elipse
        );


        // Función para redondear las esquinas del formulario
        public static void AplicarEsquinasRedondeadas(Form form, int cornerRadius)
        {
            form.FormBorderStyle = FormBorderStyle.None; // Quitar los bordes predeterminados
            form.Region = Region.FromHrgn(CreateRoundRectRgn(
                0, 0,
                form.Width, form.Height,
                cornerRadius, cornerRadius
            ));
        }



        // Función para aplicar esquinas redondeadas a un control
        public static void AplicarBordesEsquinasBoton(Control control, int cornerRadius)
        {
            control.Region = Region.FromHrgn(CreateRoundRectRgn(
                0, 0,
                control.Width, control.Height,
                cornerRadius, cornerRadius
            ));
        }

    }
}
