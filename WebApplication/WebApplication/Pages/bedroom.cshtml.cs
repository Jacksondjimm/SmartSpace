using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Runtime.Serialization;
using System.Globalization; // ��� �������� ����� ������ �������  //https://metanit.com/sharp/tutorial/20.4.php
using Microsoft.EntityFrameworkCore;
using RazorPagesApp.Models;
using Microsoft.AspNetCore.SignalR;
using System;

namespace RazorPagesApp.Pages
{
    public class bedroomModel: PageModel
    {
        public int count = 10;
        public async Task OnGet() // ������� �� IIS: public void OnGet()
        {
            //����������� ���� ������ - 1������
            SensorData_01 = context.SensorData_01.AsNoTracking().ToList();
            //����������� ���� ������ - 1�����

        }
        public string PrintTime() => DateTime.Now.ToShortTimeString();
        public Sensor_01 bme280_01 { get; set; } = new();//���� ��� ������ � �������� � ���� ������

        //����������� ���� ������ - 2������
        ApplicationContext context;

        //public List<User> Users { get; private set; } = new();
        public List<Sensor_01> SensorData_01 { get; private set; } = new();

        public bedroomModel(ApplicationContext db)
        {
            context = db;
        }
        //����������� ���� ������ - 2�����
    }
}
