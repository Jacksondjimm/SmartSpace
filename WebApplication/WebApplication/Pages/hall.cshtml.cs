using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using RazorPagesApp.Models;

namespace RazorPagesApp.Pages
{
    public class hallModel : PageModel
    {
        public int count = 10;
        public async Task OnGet() // ������� �� IIS: public void OnGet()
        {
            //����������� ���� ������ - 1������
            SensorData_03 = context.SensorData_03.AsNoTracking().ToList();
            //����������� ���� ������ - 1�����

        }
        public string PrintTime() => DateTime.Now.ToShortTimeString();
        public Sensor_03 bme280_03 { get; set; } = new();//���� ��� ������ � �������� � ���� ������

        //����������� ���� ������ - 2������
        ApplicationContext context;

        //public List<User> Users { get; private set; } = new();
        public List<Sensor_03> SensorData_03 { get; private set; } = new();

        public hallModel(ApplicationContext db)
        {
            context = db;
        }
        //����������� ���� ������ - 2�����
    }
}
