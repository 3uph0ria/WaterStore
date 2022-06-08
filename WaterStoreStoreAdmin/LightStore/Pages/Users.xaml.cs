﻿using WaterStore.Classes;
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

            switch (SortCategory.SelectedIndex)
            {
                case 0:
                    services = services.ToList();
                    break;
                case 1:
                    services = services.Where(p => Convert.ToString(p.IdCategory).Contains("1")).ToList(); break;
                case 2:
                    services = services.Where(p => Convert.ToString(p.IdCategory).Contains("2")).ToList(); break;
                case 3:
                    services = services.Where(p => Convert.ToString(p.IdCategory).Contains("3")).ToList(); break;
                case 4:
                    services = services.Where(p => Convert.ToString(p.IdCategory).Contains("4")).ToList(); break;
                case 5:
                    services = services.Where(p => Convert.ToString(p.IdCategory).Contains("5")).ToList(); break;
            }

            services = services.Where(p => p.Name.ToLower().Contains(Search.Text.ToLower())).ToList();
            ListServices.ItemsSource = services;
            
        }

        private void BtnBack_Click(object sender, RoutedEventArgs e)
        {
            NavManager.MainFrame.Navigate(new SignIn());
        }

        private void ComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            Update();
        }

        private void AddBasket_Click(object sender, RoutedEventArgs e)
        {
            var service = (sender as Button).DataContext as Services;
            CurrentUser.currentCost += service.Cost;
            CurrentUser.currentServices.Add((sender as Button).DataContext as Services);
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
    }
}
