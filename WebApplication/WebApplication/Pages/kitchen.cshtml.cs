using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using RazorPagesApp.Models;

namespace RazorPagesApp.Pages
{
    public class kitchenModel : PageModel
    {
        public int count = 10;
        public async Task OnGet() // ������� �� IIS: public void OnGet()
        {
            //����������� ���� ������ - 1������
            SensorData_05 = context.SensorData_05.AsNoTracking().ToList();
            //����������� ���� ������ - 1�����

        }
        public string PrintTime() => DateTime.Now.ToShortTimeString();
        public Sensor_05 bme280_05 { get; set; } = new();//���� ��� ������ � �������� � ���� ������

        //����������� ���� ������ - 2������
        ApplicationContext context;

        //public List<User> Users { get; private set; } = new();
        public List<Sensor_05> SensorData_05 { get; private set; } = new();

        public kitchenModel(ApplicationContext db)
        {
            context = db;
        }
        //����������� ���� ������ - 2�����
    }
}
