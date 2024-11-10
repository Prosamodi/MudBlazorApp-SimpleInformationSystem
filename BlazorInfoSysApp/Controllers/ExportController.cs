using BlazorInfoSysApp.Services;
using Microsoft.AspNetCore.Mvc;
using DocumentFormat.OpenXml.Packaging;

namespace BlazorInfoSysApp.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ExportController : ControllerBase
    {
        private readonly ExportToExcelService exportToExcelService;

        public ExportController(ExportToExcelService exportToExcelService)
        {
            this.exportToExcelService = exportToExcelService;
        }

        [HttpGet("ExportAllDataToExcel")]
        public async Task<IActionResult> ExportToExcel()
        {
            var content = await exportToExcelService.ExportDataToExcelAsync();

            if (content == null || content.Length == 0)
            {
                return NotFound("No data available to export.");
            }

            return File(
                content,
                "application/vnd.openxmlformats-officedocument.spreadsheetml.sheet",
                "Mudblazor Simple Information System.xlsx");
        }
    }
}
