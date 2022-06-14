using System;
using System.Collections.Generic;
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

namespace ResCar
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            employeListView.ItemsSource = ApplicationData.listeEmployes;
            carListView.ItemsSource = ApplicationData.listeVehicules;
            empruntDataGrid.ItemsSource = ApplicationData.listeEmprunts;
        }

        private void quit_Button(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Etes-vous sûr de vouloir quitter ?", "Quitter ?", MessageBoxButton.YesNo);
            System.Windows.Application.Current.Shutdown();
        }

        private void resClick_Button(object sender, RoutedEventArgs e)
        {
            this.employeListView.Visibility = Visibility.Visible;
            this.carListView.Visibility = Visibility.Visible;
            this.carComboBox.Visibility = Visibility.Visible;
            this.dateSelect.Visibility = Visibility.Visible;
            this.missionTextBox.Visibility = Visibility.Visible;
            this.reserverButton.Visibility = Visibility.Visible;
            this.modifierButton.Visibility = Visibility.Collapsed;
        }

        private void resButton_Click(object sender, RoutedEventArgs e)
        {
            this.employeListView.Visibility = Visibility.Collapsed;
            this.carListView.Visibility = Visibility.Collapsed;
            this.carComboBox.Visibility = Visibility.Collapsed;
            this.dateSelect.Visibility = Visibility.Collapsed;
            this.missionTextBox.Visibility = Visibility.Collapsed;
            this.reserverButton.Visibility = Visibility.Collapsed;
            this.modifierButton.Visibility = Visibility.Collapsed;
        }

        private void modButton_Click(object sender, RoutedEventArgs e)
        {
            this.employeListView.Visibility = Visibility.Collapsed;
            this.carListView.Visibility = Visibility.Collapsed;
            this.carComboBox.Visibility = Visibility.Collapsed;
            this.dateSelect.Visibility = Visibility.Collapsed;
            this.missionTextBox.Visibility = Visibility.Collapsed;
            this.reserverButton.Visibility = Visibility.Collapsed;
            this.modifierButton.Visibility = Visibility.Collapsed;
        }
        private void modClick_Button(object sender, RoutedEventArgs e)
        {
            this.employeListView.Visibility = Visibility.Visible;
            this.carListView.Visibility = Visibility.Visible;
            this.carComboBox.Visibility = Visibility.Visible;
            this.dateSelect.Visibility = Visibility.Visible;
            this.missionTextBox.Visibility = Visibility.Visible;
            this.reserverButton.Visibility = Visibility.Collapsed;
            this.modifierButton.Visibility = Visibility.Visible;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            MessageBoxResult result = MessageBox.Show("Etes-vous sur le vouloir supprimer ?", "Supprimer ?", MessageBoxButton.YesNo);
            switch (result)
            {
                case MessageBoxResult.Yes:
                    Emprunt supEmp = (Emprunt)empruntDataGrid.SelectedItem;
                    if (supEmp is null)
                        MessageBox.Show("Veuillez selectionner un emprunt");
                    else
                    {
                        supEmp.Delete();
                        ApplicationData.loadApplicationData();
                        empruntDataGrid.ItemsSource = ApplicationData.listeEmprunts;
                    }
                    
                    break;
                case MessageBoxResult.No:
                    break;
            }
        }
    }
}
