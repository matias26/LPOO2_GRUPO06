﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace Vistas
{
    /// <summary>
    /// Author Paulo
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Author Paulo
        /// boton en el menu encargado de cerrar la aplicacion
        /// </summary>
        private void MenuItem_Click(object sender, RoutedEventArgs e)
        {
            if (MessageBox.Show("¿Cerrar aplicación?", "Question", MessageBoxButton.YesNo, MessageBoxImage.Warning) == MessageBoxResult.Yes)
            {
                this.Close();
            }
            
        }

        private void Panel_articulos(object sender, RoutedEventArgs e)
        {
            Panel_articulos articulos = new Panel_articulos();
            articulos.Show();
        }

        private void Panel_categorias(object sender, RoutedEventArgs e)
        {
            Panel_categorias categorias = new Panel_categorias();
            categorias.Show();
        }

        private void Familias(object sender, RoutedEventArgs e)
        {
            Familias familias = new Familias();
            familias.Show();
        }

        private void Unidades_medida(object sender, RoutedEventArgs e)
        {
            Unidades_medida unidades = new Unidades_medida();
            unidades.Show();
        }

        private void Panel_clientes(object sender, RoutedEventArgs e)
        {
            Panel_cliente clientes = new Panel_cliente();
            clientes.Show();
        }

        private void Mesas(object sender, RoutedEventArgs e)
        {
            VentaMesas mesas = new VentaMesas();
            mesas.Show();
        }

    }
}
