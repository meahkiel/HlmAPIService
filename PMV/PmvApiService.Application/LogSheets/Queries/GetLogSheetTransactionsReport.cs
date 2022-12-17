using Dapper;
using MediatR;
using Microsoft.EntityFrameworkCore;
using PMV.PmvApiService.Application.Core;
using PMV.PmvApiService.Application.Interfaces.Repositories;
using PMV.PmvApiService.Application.LogSheets.DTO;

namespace PMV.PmvApiService.Application.LogSheets.Queries
{
    public class GetLogSheetTransactionsReport
    {
        
        public record Query(string dateFrom,string dateTo) : IRequest<Result<IEnumerable<FuelLogTransactionsResponse>>>;

        public class QueryHandler : IRequestHandler<Query, Result<IEnumerable<FuelLogTransactionsResponse>>>
        {
            private readonly IUnitWork _context;

            public QueryHandler(IUnitWork context)
            {
                _context = context;
            }
            public async Task<Result<IEnumerable<FuelLogTransactionsResponse>>> Handle(Query request, CancellationToken cancellationToken)
            {
                
                try {
                    
                    using(var context = _context.GetContext())
                    using(var connection = context.Database.GetDbConnection()) {
                        var results = await connection.QueryAsync<FuelLogTransactionsResponse>(
                            "sp_TransactionsLogView",
                            new { dateFrom = request.dateFrom, dateTo = request.dateTo },
                            commandType: System.Data.CommandType.StoredProcedure);
                        
                        return Result<IEnumerable<FuelLogTransactionsResponse>>.Success(results);
                    }
                }
                catch(Exception ex) {

                    return Result<IEnumerable<FuelLogTransactionsResponse>>.Failure(ex.Message);
                }

                
            }
        }
    }
}