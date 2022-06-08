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
    /// Логика взаимодействия для PageClients.xaml
    /// </summary>
    public partial class PageClients : Page
    {
        public PageClients(string header)
        {
            InitializeComponent();
            Header.Text = header;
            DGridClients.ItemsSource = WaterStoreEntities.GetContext().Clients.ToList();
        }

        private void BtnEditClient_Click(object sender, RoutedEventArgs e)
        {
            NavManager.AccountFrame.Navigate(new PageAddEditClients((sender as Button).DataContext as Clients));
        }

        private void BtnAddClient_Click(object sender, RoutedEventArgs e)
        {
            NavManager.AccountFrame.Navigate(new PageAddEditClients(null));
        }

        private void BtndelClient_Click(object sender, RoutedEventArgs e)
        {
            var serviceForDelete = DGridClients.SelectedItems.Cast<Clients>().ToList();
            if (MessageBox.Show($"Вы действительно хотите удалить {serviceForDelete.Count} элементов?", "Внимание!", MessageBoxButton.YesNo, MessageBoxImage.Question) == MessageBoxResult.Yes)
            {
                try
                {
                    WaterStoreEntities.GetContext().Clients.RemoveRange(serviceForDelete);
                    WaterStoreEntities.GetContext().SaveChanges();
                    DGridClients.ItemsSource = WaterStoreEntities.GetContext().Clients.ToList();
                    MessageBox.Show("Удаление выделенных элементов прошло успешно");
                    NavManager.AccountFrame.Navigate(new PageClients(NavManager.BtClients.Content + ""));
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }
            }
        }
    }
}
