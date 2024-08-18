using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using RazorPagesApp.Models;

using FusionCharts.DataEngine;
using FusionCharts.Visualization;
using System.Data;

namespace RazorPagesApp.Pages
{
    public class hallwayModel : PageModel
    {
        // create a public property. OnGet method() set the chart configuration json in this property.
        // When the page is being loaded, OnGet method will be  invoked
        public string ChartJson { get; internal set; } // FusionCharts

        //public int count = 10;
        public async Task OnGet() // ������� �� IIS: public void OnGet()
        {
            //����������� ���� ������ - 1������
            SensorData_04 = context.SensorData_04.AsNoTracking().OrderBy(p => p.date).ToList();
            //����������� ���� ������ - 1�����

            //������ ������� ������
            // create data table to store data
            DataTable ChartData = new DataTable();
            // Add columns to data table
            ChartData.Columns.Add("t", typeof(System.String));
            ChartData.Columns.Add("���-��", typeof(System.Single));
            // Add rows to data table
            for (int i = 0; i < SensorData_04.Count; i++)
            {
                ChartData.Rows.Add($"{SensorData_04[i].date.ToShortTimeString()}, {(SensorData_04[i].date.ToShortDateString()).Substring(0, 5)}", (SensorData_04[i].temp));
            }
            // Create static source with this data table
            StaticSource source = new StaticSource(ChartData);
            // Create instance of DataModel class
            DataModel model = new DataModel();
            // Add DataSource to the DataModel
            model.DataSources.Add(source);
            // Instantiate Column Chart
            Charts.ColumnChart column = new Charts.ColumnChart("first_chart");
            // Set Chart's width and height
            column.Width.Pixel(700);
            column.Height.Pixel(400);
            // Set DataModel instance as the data source of the chart
            column.Data.Source = model;
            // Set Chart Title
            column.Caption.Text = "�����������";
            // Set chart sub title
            //column.SubCaption.Text = "2017-2018";
            // hide chart Legend
            column.Legend.Show = false;
            // set XAxis Text
            column.XAxis.Text = "�����";
            // Set YAxis title
            column.YAxis.Text = "����������� (t)";
            // set chart theme
            column.ThemeName = FusionChartsTheme.ThemeName.FUSION;
            // set chart rendering json
            ChartJson = column.Render();
            //������ ������� �����

        }
        public string PrintTime() => DateTime.Now.ToShortTimeString();
        public Sensor_04 bme280_04 { get; set; } = new();//���� ��� ������ � �������� � ���� ������

        //����������� ���� ������ - 2������
        ApplicationContext context;

        //public List<User> Users { get; private set; } = new();
        public List<Sensor_04> SensorData_04 { get; private set; } = new();

        public hallwayModel(ApplicationContext db)
        {
            context = db;
        }
        //����������� ���� ������ - 2�����
    }
}
