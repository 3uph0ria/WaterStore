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
    /// Логика взаимодействия для PageAddEditClients.xaml
    /// </summary>
    public partial class PageAddEditClients : Page
    {
        private Clients _ccurrnetServices = new Clients();
        public PageAddEditClients(Clients selectService)
        {
            InitializeComponent();
            if (selectService != null)
            {
                _ccurrnetServices = selectService;
            }

            DataContext = _ccurrnetServices;
        }

        private void BtnAddservice_Click(object sender, RoutedEventArgs e)
        {
            if (_ccurrnetServices.Id == 0)
                WaterStoreEntities.GetContext().Clients.Add(_ccurrnetServices);

            try
            {
                WaterStoreEntities.GetContext().SaveChanges();
                MessageBox.Show("Клиент успешно сохранен");
                NavManager.AccountFrame.Navigate(new PageClients(NavManager.BtnServices.Content + ""));
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
