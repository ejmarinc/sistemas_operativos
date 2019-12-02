using Xamarin.Forms;
using System;
using System.Collections.Generic;
using System.Text;

namespace IngresaDatos
{
    public class MainPage : ContentPage
    {
 
        Entry nombre;
        Entry primerApellido;
        Entry segundoApellido;
        Entry fechaDeNacimiento;
        Entry correoElectronico;
        Entry telefono;
        Entry contrasena;
        Entry confirmacion;
        
        Button guardarButton;
        
        public MainPage()
        {
            this.Padding = new Thickness(10, 10, 10, 10);

            StackLayout panel = new StackLayout
            {
                
            };

            panel.Children.Add(new Label
            {
                Text = "Nombre:",
                FontSize = Device.GetNamedSize(NamedSize.Small, typeof(Label))
            });

            panel.Children.Add(nombre = new Entry
            {
                 Placeholder="Nombre"
            });

            panel.Children.Add(new Label
            {
                Text = "Primer Apellido:",
                FontSize = Device.GetNamedSize(NamedSize.Small, typeof(Label))
            });

            panel.Children.Add(primerApellido = new Entry
            {
                Placeholder="Primer Apellido"
            });
            panel.Children.Add(new Label
            {
                Text = "Segundo Apellido:",
                FontSize = Device.GetNamedSize(NamedSize.Small, typeof(Label))
            });

            panel.Children.Add(segundoApellido = new Entry
            {
                Placeholder= "Segundo Apellido"
            });

            panel.Children.Add(new Label
            {
                Text = "Fecha de Nacimiento:",
                FontSize = Device.GetNamedSize(NamedSize.Small, typeof(Label))
            });

            panel.Children.Add(fechaDeNacimiento = new Entry
            {
                Placeholder = "DD/MM/YY"
             
            });

            panel.Children.Add(new Label
            {
                Text = "Correo electrónico:",
                FontSize = Device.GetNamedSize(NamedSize.Small, typeof(Label))
            });

            panel.Children.Add(correoElectronico = new Entry
            {
                Placeholder = "Correo electrónico"
            });

            panel.Children.Add(new Label
            {
                Text = "Teléfono:",
                FontSize = Device.GetNamedSize(NamedSize.Small, typeof(Label))
            });

            panel.Children.Add(telefono = new Entry
            {
                Placeholder = "###-####",
            });

            panel.Children.Add(new Label
            {
                Text = "Contraseña:",
                FontSize = Device.GetNamedSize(NamedSize.Small, typeof(Label))
            });

            panel.Children.Add(contrasena = new Entry
            {
                Placeholder = "Contraseña",
                IsPassword = true
            });

            panel.Children.Add(new Label
            {
                Text = "Confirmación de Contraseña:",
                FontSize = Device.GetNamedSize(NamedSize.Small, typeof(Label))
                
            });

            panel.Children.Add(confirmacion = new Entry
            {
                Placeholder = "Reingrese Contraseña",
                IsPassword = true

            });

            panel.Children.Add(guardarButton = new Button
            {
                Text = "Guardar"
            });


            guardarButton.Clicked += OnGuardar;
            this.Content = panel;
        }

        private void OnGuardar(object sender, EventArgs e)
        {
            this.DisplayAlert("Atención", "Datos Guardados Correctamente", "Aceptar");
        }
    }
}
