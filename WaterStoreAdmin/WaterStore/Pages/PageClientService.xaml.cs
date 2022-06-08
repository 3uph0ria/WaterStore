using WaterStore.Classes;
using WaterStore.Models;
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

namespace WaterStore.Pages
{
    /// <summary>
    /// Логика взаимодействия для PageClientService.xaml
    /// </summary>
    public partial class PageClientService : Page
    {
        public PageClientService(string header)
        {
            InitializeComponent();
            Header.Text = header;
            DGridClientServices.ItemsSource = WaterStoreEntities.GetContext().ClientService.ToList();
        }

        private void BtnEditClientService_Click(object sender, RoutedEventArgs e)
        {
           
            NavManager.AccountFrame.Navigate(new PageAddEditCientService((sender as Button).DataContext as ClientService));
        }

        private void BtnAddClientService_Click(object sender, RoutedEventArgs e)
        {
            NavManager.AccountFrame.Navigate(new PageAddEditCientService(null));
        }

        private void BtndelClientService_Click(object sender, RoutedEventArgs e)
        {
            var serviceForDelete = DGridClientServices.SelectedItems.Cast<ClientService>().ToList();
            if (MessageBox.Show($"Вы действительно хотите удалить {serviceForDelete.Count} элементов?", "Внимание!", MessageBoxButton.YesNo, MessageBoxImage.Question) == MessageBoxResult.Yes)
            {
                try
                {
                    WaterStoreEntities.GetContext().ClientService.RemoveRange(serviceForDelete);
                    WaterStoreEntities.GetContext().SaveChanges();
                    DGridClientServices.ItemsSource = WaterStoreEntities.GetContext().ClientService.ToList();
                    MessageBox.Show("Удаление выделенных элементов прошло успешно");
                    NavManager.AccountFrame.Navigate(new PageClientService(NavManager.BtnClientService.Content + ""));
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }
            }
        }
    }
}
