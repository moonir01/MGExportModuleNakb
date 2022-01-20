namespace MGExportModule.Common {
    export namespace UserTypeService {
        export const baseUrl = 'Common/UserType';

        export declare function Create(request: Serenity.SaveRequest<UserTypeRow>, onSuccess?: (response: Serenity.SaveResponse) => void, opt?: Q.ServiceOptions<any>): JQueryXHR;
        export declare function Update(request: Serenity.SaveRequest<UserTypeRow>, onSuccess?: (response: Serenity.SaveResponse) => void, opt?: Q.ServiceOptions<any>): JQueryXHR;
        export declare function Delete(request: Serenity.DeleteRequest, onSuccess?: (response: Serenity.DeleteResponse) => void, opt?: Q.ServiceOptions<any>): JQueryXHR;
        export declare function Retrieve(request: Serenity.RetrieveRequest, onSuccess?: (response: Serenity.RetrieveResponse<UserTypeRow>) => void, opt?: Q.ServiceOptions<any>): JQueryXHR;
        export declare function List(request: Serenity.ListRequest, onSuccess?: (response: Serenity.ListResponse<UserTypeRow>) => void, opt?: Q.ServiceOptions<any>): JQueryXHR;
        export declare function GetCustomCode(request: Serenity.ListRequest, onSuccess?: (response: GetUserTypeResponse) => void, opt?: Q.ServiceOptions<any>): JQueryXHR;

        export declare const enum Methods {
            Create = "Common/UserType/Create",
            Update = "Common/UserType/Update",
            Delete = "Common/UserType/Delete",
            Retrieve = "Common/UserType/Retrieve",
            List = "Common/UserType/List",
            GetCustomCode = "Common/UserType/GetCustomCode"
        }

        [
            'Create', 
            'Update', 
            'Delete', 
            'Retrieve', 
            'List', 
            'GetCustomCode'
        ].forEach(x => {
            (<any>UserTypeService)[x] = function (r, s, o) {
                return Q.serviceRequest(baseUrl + '/' + x, r, s, o);
            };
        });
    }
}

