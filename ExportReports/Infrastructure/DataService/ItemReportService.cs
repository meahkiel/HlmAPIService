using System.Data.SqlClient;
using ExportReports.Applications;
using ExportReports.DTO;
using Shared.Helper;

namespace ExportReports.Infrastructure.DataService;

public class ItemReportService : IDataService, IDisposable
{

    private readonly SqlConnection _dbConnection;

    public ItemReportService(string connectionString)
    {
        _dbConnection = new SqlConnection(connectionString);
    }

    public void Dispose()
    {
        _dbConnection.Dispose();
    }

    private string DynamicCondition(
        string? company = null,
        string? projectDepartment = null,
        string? itemGroups = null,
        string? itemSubGroups = null,
        string? itemCategory = null,
        string? itemSubCategory = null,
        string? dateFrom = null,
        string? dateTo = null) {
        
        string sqlCondition = "";


        if(!string.IsNullOrEmpty(company)) {
            //split the company to append single quote needed in the query
            sqlCondition = (sqlCondition.Contains("WHERE") ? " AND " : " WHERE ") + " dt.company IN (" + company.WithSingleQuote() + ")";
        }

        if(!string.IsNullOrEmpty(projectDepartment)) {
            //split the company to append single quote needed in the query
            sqlCondition = sqlCondition +  (sqlCondition.Contains("WHERE") ? " AND " : " WHERE ") + "dt.projDept IN (" + projectDepartment.WithSingleQuote() + ")";
        }

        if(!string.IsNullOrEmpty(itemGroups)) {
            //split the company to append single quote needed in the query
            sqlCondition = sqlCondition + (sqlCondition.Contains("WHERE") ? " AND " : " WHERE ") + "itm.groupCode IN (" + itemGroups.WithSingleQuote() + ")";
        }

         if(!string.IsNullOrEmpty(itemSubGroups)) {
            //split the company to append single quote needed in the query
            sqlCondition = sqlCondition + (sqlCondition.Contains("WHERE") ? " AND " : " WHERE ") + "itm.subGroupCode IN (" + itemSubGroups.WithSingleQuote() + ")";
        }

        if(!string.IsNullOrEmpty(itemCategory)) {
            //split the company to append single quote needed in the query
            sqlCondition = sqlCondition + (sqlCondition.Contains("WHERE") ? " AND " : " WHERE ") + "itm.catCode IN (" + itemCategory.WithSingleQuote() + ")";
        }

        if(!string.IsNullOrEmpty(itemSubCategory)) {
            //split the company to append single quote needed in the query
            sqlCondition = sqlCondition + (sqlCondition.Contains("WHERE") ? " AND " : " WHERE ") + "itm.subCatCode IN (" + itemSubCategory.WithSingleQuote() + ")";
        }

        if(!string.IsNullOrEmpty(dateFrom) && !string.IsNullOrEmpty(dateTo)) {
            sqlCondition = sqlCondition + (sqlCondition.Contains("WHERE") ? " AND " : " WHERE ") + $"dt.createdDate BETWEEN '{dateFrom}' AND '{dateTo}'";
        }

        return sqlCondition;

    }

    public async Task<IEnumerable<ItemMasterResult>> GetData(string? company = null,
        string? projectDepartment = null,
        string? itemGroups = null,
        string? itemSubGroups = null,
        string? itemCategory = null,
        string? itemSubCategory = null,
        string? dateFrom = null,
        string? dateTo = null)
    {

        try
        {

            _dbConnection.Open();
            var sp = "sp_ItemTransactionDetail";
            var itemParameter = new SqlParameter("@condition", System.Data.SqlDbType.NVarChar);
            itemParameter.Value = DynamicCondition(company,projectDepartment,itemGroups,itemSubGroups,itemCategory,itemSubCategory,dateFrom,dateTo);

            var cmd = _dbConnection.CreateCommand();
            cmd.CommandText = "sp_ItemTransactionDetail";
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            cmd.Parameters.Add(itemParameter);
            SqlDataReader reader = await cmd.ExecuteReaderAsync();
            List<ItemMasterResult> results = new List<ItemMasterResult>();
            ItemMasterResult? result = null;
            while (reader.Read())
            {
                if (result != null && result.ItemCode == reader["Item_Code"].ToString())
                {

                }
                else
                {
                    result = new ItemMasterResult
                    {
                        ItemCode = reader["Item_Code"].ToString() ?? "",
                        ItemDescription = reader["Item_Description"].ToString() ?? "",
                        Company = reader["company"].ToString() ?? ""
                    };

                    results.Add(result);
                }

                decimal detQty = 0m;
                if (reader["Qty"] == null) detQty = 0;
                else decimal.TryParse(reader["Qty"].ToString(), out detQty);

                var detail1 = new ItemMasterDetailResult
                {
                    Qty = detQty,
                    TypeOfDoc = reader["typeOfDoc"] == null ? "" : reader["typeOfDoc"].ToString(),
                    UOM = "Qty",
                    ReferenceNo = reader["ReferenceNo"] == null ? "" : reader["ReferenceNo"].ToString(),
                };

                result!.Details.Add(detail1);

                decimal detUnitRate = 0m;
                if (reader["UnitRate"] == null) detQty = 0;
                else decimal.TryParse(reader["UnitRate"].ToString(), out detUnitRate);

                //po
                if (reader["typeOfDocPO"] != null)
                {
                    result!.Details.Add(new ItemMasterDetailResult
                    {
                        Qty = 0,
                        UnitRate = detUnitRate,
                        TypeOfDocPO = reader["typeOfDocPO"] == null ? "" : reader["typeOfDocPO"].ToString(),
                        UOM = "Total(QR)",
                        ReferenceNo = reader["lpoNo"] == null ? "" : reader["lpoNo"].ToString(),
                    });
                }

            }

            _dbConnection.Close();
            return results;
        }
        catch (Exception ex)
        {

            if (_dbConnection.State == System.Data.ConnectionState.Open)
                _dbConnection.Close();

            throw new Exception(ex.Message, ex);
        }


    }
}
