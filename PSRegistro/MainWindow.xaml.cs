using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using Microsoft.EntityFrameworkCore;
using static PSRegistro.MainWindow;

namespace PSRegistro
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private Actores actor;

        public MainWindow()
        {
            InitializeComponent();
            actor= new Actores();

            this.DataContext = actor;
        }

        public void GuardarButton_Click(object sender, RoutedEventArgs e){
        //Instancia de Contexto    
            Contexto context = new Contexto();
        //Instancia de Actores
            Actores actor = new Actores();
            //Para que el usuario puedan ingresar nombres
            actor.Nombres= NombresTextBox.Text;
            //Para que el usuario puede ingresar salarios y se convierte de string a decimal
            actor.Salario= Convert.ToDecimal(SalarioTextBox.Text);


            context.Actores.Add(actor);
            int cant = context.SaveChanges();// retorna la cantidad de registros afectados

            if(cant>0){
                MessageBox.Show("Guardo! 👍");
                this.actor =  new Actores();
                this.DataContext = this.actor;
            }

            context.Dispose();

        }

    }
 
}
