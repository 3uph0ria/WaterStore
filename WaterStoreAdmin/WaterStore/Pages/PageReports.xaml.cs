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
using System.Windows.Forms.DataVisualization.Charting;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using Excel = Microsoft.Office.Interop.Excel;

namespace WaterStore.Pages
{
    /// <summary>
    /// Логика взаимодействия для PageReports.xaml
    /// </summary>
    public partial class PageReports : Page
    {
        public PageReports(string header)
        {
            InitializeComponent();
            Header.Text = header;
            DGridReports.ItemsSource = WaterStoreEntities.GetContext().ClientService.ToList();
        }

        private void Btnreport_Click(object sender, RoutedEventArgs e)
        {
            var application = new Excel.Application();
            Excel.Workbook workbook = application.Workbooks.Add();

            var sales = WaterStoreEntities.GetContext().ClientService.ToList();
            sales = sales.Where(p => p.Date > Convert.ToDateTime(DateStart.Text)).ToList();
            sales = sales.Where(p => p.Date < Convert.ToDateTime(DateEnd.Text)).ToList();

            Excel.Worksheet worksheet = application.Worksheets.Item[1];
            worksheet.Name = "Отчет по продажам";

            Excel.Range headerRange = worksheet.Range[worksheet.Cells[1][1], worksheet.Cells[5][1]];
            headerRange.Merge();

            if (String.IsNullOrEmpty(DateStart.Text) == false && String.IsNullOrEmpty(DateEnd.Text) == false)
            {
                headerRange.Value = "Отчет по продажам (c " + DateStart.Text + " по " + DateEnd.Text + ")";
            }
            else
            {
                headerRange.Value = "Отчет по продажам на " + DateTime.Now;
            }

            headerRange.HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter;
            headerRange.Font.Italic = true;

            worksheet.Cells[1][2] = "Клиент";
            worksheet.Cells[2][2] = "Телефон";
            worksheet.Cells[3][2] = "Покупка";
            worksheet.Cells[4][2] = "Дата";


            int row = 3;
            foreach (var sale in sales)
            {
                worksheet.Cells[1][row] = sale.Clients.Fullname;
                worksheet.Cells[2][row] = sale.Clients.Phone;
                worksheet.Cells[3][row] = sale.Services.Name;
                worksheet.Cells[4][row] = sale.Date;

                row++;
            }

            application.Visible = true;
        }

        public void Update()
        {
            if (String.IsNullOrEmpty(DateStart.Text) == false && String.IsNullOrEmpty(DateEnd.Text) == false)
            {
                var sales = WaterStoreEntities.GetContext().ClientService.ToList();
                sales = sales.Where(p => p.Date > Convert.ToDateTime(DateStart.Text)).ToList();
                sales = sales.Where(p => p.Date < Convert.ToDateTime(DateEnd.Text)).ToList();
                DGridReports.ItemsSource = sales;
            }

        }

        private void DateEnd_SelectedDateChanged(object sender, SelectionChangedEventArgs e)
        {
            Update();
        }

        private void DateStart_SelectedDateChanged(object sender, SelectionChangedEventArgs e)
        {
            Update();
        }
    }
}
