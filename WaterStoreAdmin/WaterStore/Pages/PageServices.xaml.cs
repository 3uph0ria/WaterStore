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
            CBoxServices.ItemsSource = WaterStoreEntities.GetContext().Categoris.ToList();
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

        private void Search_TextChanged(object sender, TextChangedEventArgs e)
        {
            Update();
        }

        private void CBoxServices_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            var cat = (Categoris)CBoxServices.SelectedItem;
            var services = WaterStoreEntities.GetContext().Services.ToList();
            services = services.Where(p => p.Categoris.Name.Contains(cat.Name)).ToList();
            DGridServices.ItemsSource = services;
        }

        public void Update()
        {

            var services = WaterStoreEntities.GetContext().Services.ToList();



            services = services.Where(p => p.Name.ToLower().Contains(Search.Text.ToLower())).ToList();
            DGridServices.ItemsSource = services;

        }
    }
}
