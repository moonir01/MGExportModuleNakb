namespace MGExportModule.Common {
    export namespace CmnItemBrandService {
        export const baseUrl = 'Common/CmnItemBrand';

        export declare function Create(request: Serenity.SaveRequest<CmnItemBrandRow>, onSuccess?: (response: Serenity.SaveResponse) => void, opt?: Q.ServiceOptions<any>): JQueryXHR;
        export declare function Update(request: Serenity.SaveRequest<CmnItemBrandRow>, onSuccess?: (response: Serenity.SaveResponse) => void, opt?: Q.ServiceOptions<any>): JQueryXHR;
        export declare function Delete(request: Serenity.DeleteRequest, onSuccess?: (response: Serenity.DeleteResponse) => void, opt?: Q.ServiceOptions<any>): JQueryXHR;
        export declare function Retrieve(request: Serenity.RetrieveRequest, onSuccess?: (response: Serenity.RetrieveResponse<CmnItemBrandRow>) => void, opt?: Q.ServiceOptions<any>): JQueryXHR;
        export declare function List(request: Serenity.ListRequest, onSuccess?: (response: Serenity.ListResponse<CmnItemBrandRow>) => void, opt?: Q.ServiceOptions<any>): JQueryXHR;
        export declare function GetCustomCode(request: GetCustomCodeRequest, onSuccess?: (response: GetCustomCodeResponse) => void, opt?: Q.ServiceOptions<any>): JQueryXHR;

        export declare const enum Methods {
            Create = "Common/CmnItemBrand/Create",
            Update = "Common/CmnItemBrand/Update",
            Delete = "Common/CmnItemBrand/Delete",
            Retrieve = "Common/CmnItemBrand/Retrieve",
            List = "Common/CmnItemBrand/List",
            GetCustomCode = "Common/CmnItemBrand/GetCustomCode"
        }

        [
            'Create', 
            'Update', 
            'Delete', 
            'Retrieve', 
            'List', 
            'GetCustomCode'
        ].forEach(x => {
            (<any>CmnItemBrandService)[x] = function (r, s, o) {
                return Q.serviceRequest(baseUrl + '/' + x, r, s, o);
            };
        });
    }
}

