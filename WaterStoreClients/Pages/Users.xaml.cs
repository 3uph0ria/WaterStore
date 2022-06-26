using WaterStore.Classes;
using WaterStore.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity.Validation;
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
    /// Логика взаимодействия для Users.xaml
    /// </summary>
    public partial class Users : Page
    {
        public Users()
        {

            InitializeComponent();
            CBoxServices.ItemsSource = WaterStoreEntities.GetContext().Categoris.ToList();
            Update();
        }

        private void Search_TextChanged(object sender, TextChangedEventArgs e)
        {
            Update();
        }

        public void Update()
        {
            CountService.Badge = CurrentUser.currentServices.Count.ToString();

            var services = WaterStoreEntities.GetContext().Services.ToList();

          

            services = services.Where(p => p.Name.ToLower().Contains(Search.Text.ToLower())).ToList();
            ListServices.ItemsSource = services;
            
        }

        private void BtnBack_Click(object sender, RoutedEventArgs e)
        {
           // NavManager.MainFrame.Navigate(new SignIn());
        }

        private void ComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            Update();
        }

        private void AddBasket_Click(object sender, RoutedEventArgs e)
        {
            var service = (sender as Button).DataContext as Services;
            CurrentUser.currentCost += service.Cost;

            var currentServicesTmp = (sender as Button).DataContext as Services;
            currentServicesTmp.Quantity = 1;
            currentServicesTmp.Cost = currentServicesTmp.Cost;
            CurrentUser.currentServices.Add(currentServicesTmp);
            Update();
            MessageBox.Show("Товар '" + service.Name + "' успешно добавлен к корзину!", "Внимание!", MessageBoxButton.OK);
        }

        private void BtnBack_Click_1(object sender, RoutedEventArgs e)
        {
            NavManager.MainFrame.Navigate(new PageBasket());
        }

        private void BtnOrder_Click(object sender, RoutedEventArgs e)
        {
            var service = (sender as Button).DataContext as Services;
            CurrentUser.currentCost += service.Cost;
            CurrentUser.currentServices.Add((sender as Button).DataContext as Services);
            NavManager.MainFrame.Navigate(new PageBasket());
        }

        private void BtnSelectCategory_Click(object sender, RoutedEventArgs e)
        {
            Categoris name = (Categoris)(sender as Button).DataContext as Categoris;
            var services = WaterStoreEntities.GetContext().Services.ToList();
            services = services.Where(p => p.Categoris.Name.Contains(name.Name)).ToList();
            ListServices.ItemsSource = services;
        }

        private void CBoxServices_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            var cat = (Categoris)CBoxServices.SelectedItem;
            var services = WaterStoreEntities.GetContext().Services.ToList();
            services = services.Where(p => p.Categoris.Name.Contains(cat.Name)).ToList();
            ListServices.ItemsSource = services;
        }
    }
}
