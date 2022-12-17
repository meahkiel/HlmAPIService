using System.ComponentModel;
using System.Data;
using ExportReports.DTO;
using OfficeOpenXml;

namespace ExportReports.Infrastructure;

public class ExcelExportHelper
{
    public static string ExcelContentType => "application/vnd.openxmlformats-officedocument.spreadsheetml.sheet";
    
    public static DataTable ListToDataTable(List<ItemMasterResult> results)
    {

        PropertyDescriptorCollection properties = TypeDescriptor.GetProperties(typeof(ItemMasterResult));

        DataTable dataTable = new DataTable();
        
        for (int i = 0; i < properties.Count; i++)
        {
            PropertyDescriptor property = properties[i];
            dataTable.Columns.Add(property.Name);
        }

        object[] values = new object[properties.Count];
        foreach (ItemMasterResult item in results)
        {
            values[0] = item.ItemCode;
            values[1] = item.ItemDescription;
            values[2] = item.TotalQty;
            values[3] = item.TotalUnitRate;
            values[4] = item.Company;
            values[5] = "";

            dataTable.Rows.Add(values);
            if (item.Details.Count > 0)
            {
                foreach (var detail in item.Details)
                {
                    values[0] = " ";
                    values[1] = string.IsNullOrEmpty(detail.TypeOfDoc) ? detail.TypeOfDocPO : detail.TypeOfDoc;
                    values[2] = detail.ReferenceNo;
                    values[3] = detail.UOM;
                    
                    if (!string.IsNullOrEmpty(detail.TypeOfDocPO))
                        values[4] = detail.UnitRate;
                    else
                        values[4] = detail.Qty;
                    
                    values[5] = "";
                    
                    dataTable.Rows.Add(values);
                }
            }
        }
        return dataTable;
    }

    public static async Task<byte[]> ExportExcel(List<ItemMasterResult> data) {

        return await ExportExcel(ListToDataTable(data),"",false,data.Sum(i => i.TotalQty));
    }

    public static async Task<byte[]> ExportExcel(DataTable dataTable, string heading = "", bool showSrNo = false,decimal totalQuantity = 0, params string[] columnsToTake)
    {
        byte[] result = null;  
        ExcelPackage.LicenseContext = ExcelPackage.LicenseContext;

        using(ExcelPackage package = new ExcelPackage()) {

            ExcelWorksheet workSheet = package.Workbook.Worksheets.Add(String.Format("{0} Data",heading));
            
            int startRowFrom = String.IsNullOrEmpty(heading) ? 1 : 2;
            var totalRow = dataTable.Rows.Count;
            workSheet.Cells["A" + startRowFrom].LoadFromDataTable(dataTable,true);
            workSheet.Cells["E"+(totalRow + 5)].Value = totalQuantity;
            result = await package.GetAsByteArrayAsync();
            
            return result;
        }
    }

   




}
