using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using RazorPagesApp.Models;

namespace RazorPagesApp.Pages
{
    public class hallwayModel : PageModel
    {
        public int count = 10;
        public async Task OnGet() // ������� �� IIS: public void OnGet()
        {
            //����������� ���� ������ - 1������
            SensorData_04 = context.SensorData_04.AsNoTracking().ToList();
            //����������� ���� ������ - 1�����

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
