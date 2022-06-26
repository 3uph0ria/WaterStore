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
    /// Логика взаимодействия для PageBasket.xaml
    /// </summary>
    public partial class PageBasket : Page
    {
        public PageBasket()
        {
            InitializeComponent();
            Update();
        }

        private void BtnBack_Click(object sender, RoutedEventArgs e)
        {
            NavManager.MainFrame.Navigate(new Users());
        }

        private void AddBasket_Click(object sender, RoutedEventArgs e)
        {

        }

        private void AddOrder_Click(object sender, RoutedEventArgs e)
        {

            StringBuilder erros = new StringBuilder();

            long n;
            bool isNumeric = long.TryParse(Phone.Text, out n);

            if (String.IsNullOrEmpty(FullName.Text))
                erros.AppendLine("Введите ФИО");
            else if (String.IsNullOrEmpty(Phone.Text))
                erros.AppendLine("Введите телефон");
            else if (isNumeric == false)
                erros.AppendLine("В номере телефона должны быть только цифры");
            else if(Phone.Text.Length < 11)
                erros.AppendLine("В номере доллжно быть больше 11 символов");

            if (erros.Length > 0)
            {
                MessageBox.Show(erros.ToString());
                return;
            }

            MessageBox.Show(FullName.Text + ", Ваш заказ успешно сформирован, скоро Вам перезвонит администратор");

            var clients = WaterStoreEntities.GetContext().Clients.ToList();
            clients = clients.Where(p => p.Fullname.Contains(FullName.Text)).ToList();
            var client = clients.FirstOrDefault();

            if (client == null)
            {
                Clients currnetClient = new Clients();
                currnetClient.Fullname = FullName.Text;
                currnetClient.Phone = Phone.Text;
                currnetClient.Adress = "";
                WaterStoreEntities.GetContext().Clients.Add(currnetClient);
                WaterStoreEntities.GetContext().SaveChanges();
                var newClients = WaterStoreEntities.GetContext().Clients.ToList();
                var newClient = newClients.LastOrDefault();

                foreach (var component in CurrentUser.currentServices)
                {
                    ClientService newSellService = new ClientService();
                    newSellService.IdService = component.Id;
                    newSellService.IdClient = newClient.Id;
                    newSellService.Date = DateTime.Now;
                    WaterStoreEntities.GetContext().ClientService.Add(newSellService);
                    WaterStoreEntities.GetContext().SaveChanges();
                }
            }
            else
            {
                foreach (var component in CurrentUser.currentServices)
                {
                    ClientService newSellService = new ClientService();
                    newSellService.IdService = component.Id;
                    newSellService.IdClient = client.Id;
                    newSellService.Date = DateTime.Now;
                    newSellService.Status = 1;
                    WaterStoreEntities.GetContext().ClientService.Add(newSellService);
                    WaterStoreEntities.GetContext().SaveChanges();
                }
            }
        }

        private void BtnDelService_Click(object sender, RoutedEventArgs e)
        {
            var service = (sender as Button).DataContext as Services;
            CurrentUser.currentCost -= service.Cost;

            var itemToRemove = CurrentUser.currentServices.Single(r => r.Id == service.Id);
            CurrentUser.currentServices.Remove(itemToRemove);

            NavManager.MainFrame.Navigate(new PageBasket());
        }

        public void Update()
        {
            ListServices.ItemsSource = CurrentUser.currentServices;
            currentCost.Text = "Итого: " + CurrentUser.currentCost + "₽";
        }


        private void BtnAddQuantity_Click(object sender, RoutedEventArgs e)
        {
            var currentService = (sender as Button).DataContext as Services;

            currentService.Quantity++;
            CurrentUser.currentCost += currentService.Cost;
            NavManager.MainFrame.Navigate(new PageBasket());
        }

        private void BtnDelQuantity_Click(object sender, RoutedEventArgs e)
        {
            var currentService = (sender as Button).DataContext as Services;

            if (currentService.Quantity > 1)
            {
                currentService.Quantity--;
                CurrentUser.currentCost -= currentService.Cost;
                NavManager.MainFrame.Navigate(new PageBasket());
            }
            else
            {
                return;
            }
        }

        private void BtnBack_Click_1(object sender, RoutedEventArgs e)
        {
            NavManager.MainFrame.Navigate(new Users());
        }
    }
}
