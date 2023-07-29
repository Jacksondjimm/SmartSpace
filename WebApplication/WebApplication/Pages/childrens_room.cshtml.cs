using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using RazorPagesApp.Models;

namespace RazorPagesApp.Pages
{
    public class childrens_roomModel : PageModel
    {
        public int count = 10;
        public async Task OnGet() // ������� �� IIS: public void OnGet()
        {
            //����������� ���� ������ - 1������
            SensorData_02 = context.SensorData_02.AsNoTracking().ToList();
            //����������� ���� ������ - 1�����

        }
        public string PrintTime() => DateTime.Now.ToShortTimeString();
        public Sensor_02 bme280_02 { get; set; } = new();//���� ��� ������ � �������� � ���� ������

        //����������� ���� ������ - 2������
        ApplicationContext context;

        //public List<User> Users { get; private set; } = new();
        public List<Sensor_02> SensorData_02 { get; private set; } = new();

        public childrens_roomModel(ApplicationContext db)
        {
            context = db;
        }
        //����������� ���� ������ - 2�����
    }
}
