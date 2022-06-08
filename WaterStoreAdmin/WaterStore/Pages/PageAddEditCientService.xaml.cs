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
    /// Логика взаимодействия для PageAddEditCientService.xaml
    /// </summary>
    public partial class PageAddEditCientService : Page
    {
        private ClientService _ccurrnetClientService = new ClientService();
        public PageAddEditCientService(ClientService selectClientService)
        {
            InitializeComponent();
            if (selectClientService != null)
            {
                _ccurrnetClientService = selectClientService;
                CBoxServices.SelectedItem = selectClientService.Services;
                CBoxClients.SelectedItem = selectClientService.Clients;
                CBoxStatus.SelectedItem = selectClientService.Status1;
            }

            DataContext = _ccurrnetClientService;
            CBoxServices.ItemsSource = WaterStoreEntities.GetContext().Services.ToList();
            CBoxClients.ItemsSource = WaterStoreEntities.GetContext().Clients.ToList();
            CBoxStatus.ItemsSource = WaterStoreEntities.GetContext().Status.ToList();
        }

        private void BtnAddservice_Click(object sender, RoutedEventArgs e)
        {
            Services p = (Services)CBoxServices.SelectedItem;
            Clients o = (Clients)CBoxClients.SelectedItem;
            Status s = (Status)CBoxStatus.SelectedItem;
            _ccurrnetClientService.IdService = p.Id;
            _ccurrnetClientService.IdClient = o.Id;
            _ccurrnetClientService.Status = s.Id;

            if (_ccurrnetClientService.Id == 0)
                WaterStoreEntities.GetContext().ClientService.Add(_ccurrnetClientService);

            try
            {
                WaterStoreEntities.GetContext().SaveChanges();
                MessageBox.Show("Продажа успешно сохранена");
                NavManager.AccountFrame.Navigate(new PageClientService(NavManager.BtnClientService.Content + ""));
            }
            catch (DbEntityValidationException ex)
            {
                if (ApplicationConfig.IsDev)
                {
                    foreach (var errors in ex.EntityValidationErrors)
                    {
                        foreach (var validationError in errors.ValidationErrors)
                        {
                            MessageBox.Show(validationError.ErrorMessage);
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Произошла ошибка", "Внимание", MessageBoxButton.OK, MessageBoxImage.Warning);
                }
            }
        }
    }
}
