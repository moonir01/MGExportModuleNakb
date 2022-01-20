
namespace MGExportModule.Common.Entities
{
    using MGExportModule.Northwind;
    using Serenity;
    using Serenity.ComponentModel;
    using Serenity.Data;
    using Serenity.Data.Mapping;
    using System;
    using System.ComponentModel;
    using System.IO;

    [ConnectionKey("Default"), Module("Common"), TableName("[dbo].[CmnUserInfo]")]
    [DisplayName("User Info"), InstanceName("User Info")]
    //[ReadPermission("Administration:General")]
    //[ModifyPermission("Administration:General")]
    [ReadPermission("Administration:General:View")]
    [InsertPermission("Administration:General:Insert")]
    [ModifyPermission("Administration:General:Modify")]
    [DeletePermission("Administration:General:Delete")]
    [LookupScript]
    public sealed class UserInfoRow : Row, IIdRow, INameRow
    {
        [DisplayName("User Id"), Column("UserID"), Identity]
        public Int32? UserId
        {
            get { return Fields.UserId[this]; }
            set { Fields.UserId[this] = value; }
        }

        [DisplayName("Custom Code"), Size(100), QuickSearch]
        public String CustomCode
        {
            get { return Fields.CustomCode[this]; }
            set { Fields.CustomCode[this] = value; }
        }

        [DisplayName("User Full Name"), Size(500), NotNull]
        public String UserFullName
        {
            get { return Fields.UserFullName[this]; }
            set { Fields.UserFullName[this] = value; }
        }   
        
        [DisplayName("User Image"), Size(500), NotNull]
        [ImageUploadEditor]
        public String UserImage
        {
            get { return Fields.UserImage[this]; }
            set { Fields.UserImage[this] = value; }
        }

        [DisplayName("User Type Id"), Column("UserTypeID"), NotNull]
        [LookupEditor(typeof(UserTypeRow))]
        public Int32? UserTypeId
        {
            get { return Fields.UserTypeId[this]; }
            set { Fields.UserTypeId[this] = value; }
        }

        [DisplayName("Insert Date")]
        [Hidden]
        public DateTime? InsertDate
        {
            get { return Fields.InsertDate[this]; }
            set { Fields.InsertDate[this] = value; }
        }

        [DisplayName("Insert User Id")]
        [Hidden]
        public Int32? InsertUserId
        {
            get { return Fields.InsertUserId[this]; }
            set { Fields.InsertUserId[this] = value; }
        }

        [DisplayName("Update Date")]
        [Hidden]
        public DateTime? UpdateDate
        {
            get { return Fields.UpdateDate[this]; }
            set { Fields.UpdateDate[this] = value; }
        }

        [DisplayName("Update User Id")]
        [Hidden]
        public Int32? UpdateUserId
        {
            get { return Fields.UpdateUserId[this]; }
            set { Fields.UpdateUserId[this] = value; }
        }

        [DisplayName("Is Delete"), NotNull]
        [Hidden]
        public Boolean? IsDelete
        {
            get { return Fields.IsDelete[this]; }
            set { Fields.IsDelete[this] = value; }
        }

        IIdField IIdRow.IdField
        {
            get { return Fields.UserId; }
        }

        StringField INameRow.NameField
        {
            get { return Fields.UserFullName; }
        }

        public static readonly RowFields Fields = new RowFields().Init();

        public UserInfoRow()
            : base(Fields)
        {
        }

        public class RowFields : RowFieldsBase
        {
            public Int32Field UserId;
            public StringField CustomCode;
            public StringField UserFullName;
            public Int32Field UserTypeId;
            public DateTimeField InsertDate;
            public Int32Field InsertUserId;
            public DateTimeField UpdateDate;
            public Int32Field UpdateUserId;
            public BooleanField IsDelete;
            public StringField UserImage;
        }
    }
}
