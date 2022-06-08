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
    /// Логика взаимодействия для PageServices.xaml
    /// </summary>
    public partial class PageServices : Page
    {
        public PageServices(string header)
        {
            InitializeComponent();
            DGridServices.ItemsSource = WaterStoreEntities.GetContext().Services.ToList();
            Header.Text = header;
        }

        private void BtnEditService_Click(object sender, RoutedEventArgs e)
        {
            NavManager.AccountFrame.Navigate(new PageAddEditService((sender as Button).DataContext as Services));
        }

        private void BtnAddService_Click(object sender, RoutedEventArgs e)
        {
            NavManager.AccountFrame.Navigate(new PageAddEditService(null));
        }

        private void BtndelService_Click(object sender, RoutedEventArgs e)
        {
            var serviceForDelete = DGridServices.SelectedItems.Cast<Services>().ToList();
            if (MessageBox.Show($"Вы действительно хотите удалить {serviceForDelete.Count} элементов?", "Внимание!", MessageBoxButton.YesNo, MessageBoxImage.Question) == MessageBoxResult.Yes)
            {
                try
                {
                    WaterStoreEntities.GetContext().Services.RemoveRange(serviceForDelete);
                    WaterStoreEntities.GetContext().SaveChanges();
                    DGridServices.ItemsSource = WaterStoreEntities.GetContext().Clients.ToList();
                    MessageBox.Show("Удаление выделенных элементов прошло успешно");
                    NavManager.AccountFrame.Navigate(new PageServices(NavManager.BtnServices.Content + ""));
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }
            }
        }
    }
}
