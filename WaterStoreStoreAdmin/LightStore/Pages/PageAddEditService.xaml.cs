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
    public partial class PageAddEditService : Page
    {
        private Services _ccurrnetServices = new Services();
        public PageAddEditService(Services selectService)
        {
            InitializeComponent();
            if (selectService != null)
            {
                _ccurrnetServices = selectService;
                CBoxServices.SelectedItem = selectService.Categoris;
            }
                
            DataContext = _ccurrnetServices;
            CBoxServices.ItemsSource = WaterStoreEntities.GetContext().Categoris.ToList();
        }

        private void BtnAddservice_Click(object sender, RoutedEventArgs e)
        {

            if(_ccurrnetServices.Cost <= 0)
            {
                MessageBox.Show("Цена не должна быть < 0");
                return;
            }

            Categoris p = (Categoris)CBoxServices.SelectedItem;
            _ccurrnetServices.IdCategory = p.Id;

            if (_ccurrnetServices.Id == 0)
                WaterStoreEntities.GetContext().Services.Add(_ccurrnetServices);

            try
            {
                WaterStoreEntities.GetContext().SaveChanges();
                MessageBox.Show("Товар успешно сохранен");
                NavManager.AccountFrame.Navigate(new PageServices(NavManager.BtnServices.Content + ""));
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
