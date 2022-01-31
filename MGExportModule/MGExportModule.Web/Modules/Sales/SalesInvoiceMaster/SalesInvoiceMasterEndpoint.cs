
namespace MGExportModule.Sales.Endpoints
{
    using System;
    using Serenity;
    using Serenity.Data;
    using Serenity.Services;
    using Serenity.Reporting;
    using Serenity.Web;
    using System.Data;
    using System.Web.Mvc;
    using MyRepository = Repositories.SalesInvoiceMasterRepository;
    using MyRow = Entities.SalesInvoiceMasterRow;
    using System.Linq;

    [RoutePrefix("Services/Sales/SalesInvoiceMaster"), Route("{action}")]
    [ConnectionKey(typeof(MyRow)), ServiceAuthorize(typeof(MyRow))]
    public class SalesInvoiceMasterController : ServiceEndpoint
    {
        [HttpPost, AuthorizeCreate(typeof(MyRow))]
        public SaveResponse Create(IUnitOfWork uow, SaveRequest<MyRow> request)
        {
            return new MyRepository().Create(uow, request);
        }

        [HttpPost, AuthorizeUpdate(typeof(MyRow))]
        public SaveResponse Update(IUnitOfWork uow, SaveRequest<MyRow> request)
        {
            return new MyRepository().Update(uow, request);
        }
 
        [HttpPost, AuthorizeDelete(typeof(MyRow))]
        public DeleteResponse Delete(IUnitOfWork uow, DeleteRequest request)
        {
            return new MyRepository().Delete(uow, request);
        }

        [HttpPost]
        public RetrieveResponse<MyRow> Retrieve(IDbConnection connection, RetrieveRequest request)
        {
            return new MyRepository().Retrieve(connection, request);
        }

        [HttpPost]
        public ListResponse<MyRow> List(IDbConnection connection, ListRequest request)
        {
            return new MyRepository().List(connection, request);
        }

		public FileContentResult ListExcel(IDbConnection connection, ListRequest request) {
            var data = List(connection, request).Entities;
            var report = new DynamicDataReport(data, request.IncludeColumns, typeof(Columns.SalesInvoiceMasterColumns));
            var bytes = new ReportRepository().Render(report);
            return ExcelContentResult.Create(bytes, "SalesInvoiceMasterList_" + DateTime.Now.ToString("yyyyMMdd_HHmmss") + ".xlsx");
        }

        [HttpPost]
        public GetJournalIDResponse GetJournalID(IDbConnection connection, GetRealizeRequest request)
        {
            var tbl = MyRow.Fields.As("tbl");
            var user = Authorization.UserDefinition as UserDefinition;

            var queryMain = new SqlQuery();
            var req = request.RealizeId;
    
            int JournalID = 0;
            var param = new DynamicParameters();
            //param.Add("@Bill_Year", Row.BillYear, DbType.String, ParameterDirection.Input);
            //param.Add("@Bill_Month", Row.BillMonth, DbType.String, ParameterDirection.Input);
            //param.Add("@IssueDate", Row.IssueDate, DbType.DateTime, ParameterDirection.Input);
            //param.Add("@LastDateOfBillPay", Row.LastDateOfBillPay, DbType.DateTime, ParameterDirection.Input);

            //param.Add("@ClientInfoId", Row.ClientInfoId, DbType.Int64, ParameterDirection.Input);
            //param.Add("@ZoneInfoId", user.ZoneInfoId, DbType.Int32, ParameterDirection.Input);
            //param.Add("@User", user.UserId, DbType.Int32, ParameterDirection.Input);
            param.Add("@ExFacId", req, DbType.Int64, ParameterDirection.Input);

            //param.Add("@numErrorCode", 0, DbType.Int32, ParameterDirection.Output);
            //param.Add("@strErrorMsg", "", DbType.String, ParameterDirection.Output);
            //param.Add("@numTotalProcessed", 0, DbType.Int32, ParameterDirection.Output);


            var result = connection.Query("spButtonClick", param, commandType: CommandType.StoredProcedure, commandTimeout: 0);



            //string query = $"select ISNULL(MAX(BrandId),0) from CmnItemBrand";
            //     JournalID = connection.Query<int>(query).FirstOrDefault();

           
          

            return new GetJournalIDResponse { JournalID = JournalID };
        }
    }

    public class GetJournalIDResponse : ServiceResponse
    {
        public int JournalID { get; set; }
    }

    public class GetRealizeRequest : ListRequest
    {
        public int RealizeId { get; set; }
    }
}
