using BlazorInfoSysApp.Models;
using ClosedXML.Excel;
using Microsoft.EntityFrameworkCore;

namespace BlazorInfoSysApp.Services
{
    public class ExportToExcelService 
    {
        private DataContext _context;

        public ExportToExcelService(DataContext context)
        {
            _context = context;
        }

        public async Task<byte[]> ExportDataToExcelAsync()
        {
            using(var workbook = new XLWorkbook())
            {
                var worksheet = workbook.Worksheets.Add("MudBlazor Data");
                var currentRow = 1;

                worksheet.Cell(currentRow, 1).Value = "Full Name";
                worksheet.Cell(currentRow, 2).Value = "Birthday";
                worksheet.Cell(currentRow, 3).Value = "Age";
                worksheet.Cell(currentRow, 4).Value = "Gender";
                worksheet.Cell(currentRow, 5).Value = "Civil Status";
                worksheet.Cell(currentRow, 6).Value = "Email";
                worksheet.Cell(currentRow, 7).Value = "Phone Number";
                worksheet.Cell(currentRow, 8).Value = "Address";
                worksheet.Cell(currentRow, 9).Value = "City";
                worksheet.Cell(currentRow, 10).Value = "Barangay";
                worksheet.Cell(currentRow, 11).Value = "Region";
                worksheet.Cell(currentRow, 12).Value = "Province";
                worksheet.Cell(currentRow, 13).Value = "ZIP";
                worksheet.Cell(currentRow, 14).Value = "Work Title";

                worksheet.Cells("A1:N1").Style
                    .Font.SetBold(true)
                    .Fill.SetBackgroundColor(XLColor.AshGrey);
                    

                var people = await _context.People.ToListAsync();

                foreach (var person in people)
                {
                    currentRow++;
                    worksheet.Cell(currentRow, 1).Value = $"{person.Lastname}, {person.Firstname} {person.Lastname}";
                    worksheet.Cell(currentRow, 2).Value = person.Birthday;
                    worksheet.Cell(currentRow, 3).Value = person.Age;
                    worksheet.Cell(currentRow, 4).Value = person.Gender;
                    worksheet.Cell(currentRow, 5).Value = person.CivilStatus;
                    worksheet.Cell(currentRow, 6).Value = person.Email;
                    worksheet.Cell(currentRow, 7).Value = person.PhoneNumber;
                    worksheet.Cell(currentRow, 8).Value = person.Address;
                    worksheet.Cell(currentRow, 9).Value = person.City;
                    worksheet.Cell(currentRow, 10).Value = person.Barangay;
                    worksheet.Cell(currentRow, 11).Value = person.Region;
                    worksheet.Cell(currentRow, 12).Value = person.Province;
                    worksheet.Cell(currentRow, 13).Value = person.ZIP;
                    worksheet.Cell(currentRow, 14).Value = person.WorkTitle;
                }

                using (var stream = new MemoryStream())
                {
                    workbook.SaveAs(stream);
                    return stream.ToArray();
                }
            }
        }
    }
}
