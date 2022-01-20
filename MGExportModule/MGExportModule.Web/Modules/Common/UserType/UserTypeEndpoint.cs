
namespace MGExportModule.Common.Endpoints
{
    using System;
    using Serenity;
    using Serenity.Data;
    using Serenity.Services;
    using Serenity.Reporting;
    using Serenity.Web;
    using System.Data;
    using System.Web.Mvc;
    using MyRepository = Repositories.UserTypeRepository;
    using MyRow = Entities.UserTypeRow;
    using System.Linq;

    [RoutePrefix("Services/Common/UserType"), Route("{action}")]
    [ConnectionKey(typeof(MyRow)), ServiceAuthorize(typeof(MyRow))]
    public class UserTypeController : ServiceEndpoint
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
            var report = new DynamicDataReport(data, request.IncludeColumns, typeof(Columns.UserTypeColumns));
            var bytes = new ReportRepository().Render(report);
            return ExcelContentResult.Create(bytes, "UserTypeList_" + DateTime.Now.ToString("yyyyMMdd_HHmmss") + ".xlsx");
        }

        [HttpPost]
        public GetUserTypeResponse GetCustomCode(IDbConnection connection, ListRequest request)
        {
            var tbl = MyRow.Fields.As("tbl");
            var user = Authorization.UserDefinition as UserDefinition;

            var queryMain = new SqlQuery();
            //var req = request.CustomerId;
            string Prefix = "UT-";
            string CustomCode = "";

            //IB-170122-001

            queryMain.Select(tbl.UserTypeId)
           .From(tbl);

            var data = connection.Query<MyRow>(queryMain).ToList();

            if (data.Count <= 0)
            {
                CustomCode = Prefix + DateTime.Now.ToString("DDMMYY") + "001";
            }
            else
            {
                string query = $"select ISNULL(MAX(UserTypeId),0) from CmnUserType";
                var maxCustomCode = connection.Query<int>(query).FirstOrDefault();

                CustomCode = Prefix + DateTime.Now.ToString("ddMMyy") + "-" + (maxCustomCode + 1).ToString("000");
            }

            return new GetUserTypeResponse { CustomCode = CustomCode };
        }

    }

    public class GetUserTypeResponse : ServiceResponse
    {
        public String CustomCode { get; set; }
    }
}
