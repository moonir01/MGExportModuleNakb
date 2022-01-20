
namespace MGExportModule.Common.Endpoints
{
    using Serenity;
    using Serenity.Data;
    using Serenity.Services;
    using System;
    using System.Data;
    using System.Linq;
    using System.Web.Mvc;
    using MyRepository = Repositories.UserInfoRepository;
    using MyRow = Entities.UserInfoRow;

    [RoutePrefix("Services/Common/UserInfo"), Route("{action}")]
    [ConnectionKey(typeof(MyRow)), ServiceAuthorize(typeof(MyRow))]
    public class UserInfoController : ServiceEndpoint
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

        [HttpPost]
        public GetUserCodeResponse GetCustomCode(IDbConnection connection, GetCustomCodeRequest request)
        {
            var tbl = MyRow.Fields.As("tbl");
            var user = Authorization.UserDefinition as UserDefinition;

            var queryMain = new SqlQuery();
            
            string Prefix = "MG-";
            string CustomCode = "";

            //IB-170122-001

            queryMain.Select(tbl.UserId)
           .From(tbl);

            var data = connection.Query<MyRow>(queryMain).ToList();

            if (data.Count <= 0)
            {
                CustomCode = Prefix + DateTime.Now.ToString("DDMMYY") + "001";
            }
            else
            {
                string query = $"select ISNULL(MAX(UserId),0) from CmnUserInfo";
                var maxCustomCode = connection.Query<int>(query).FirstOrDefault();

                CustomCode = Prefix + DateTime.Now.ToString("ddMMyy") + "-" + (maxCustomCode + 1).ToString("000");
            }

            return new GetUserCodeResponse { CustomCode = CustomCode };
        }

    }
    public class GetUserCodeResponse : ServiceResponse
    {
        public String CustomCode { get; set; }
    }
}
