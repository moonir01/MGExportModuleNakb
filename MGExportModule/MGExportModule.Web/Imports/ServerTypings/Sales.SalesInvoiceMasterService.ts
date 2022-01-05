namespace MGExportModule.Sales {
    export namespace SalesInvoiceMasterService {
        export const baseUrl = 'Sales/SalesInvoiceMaster';

        export declare function Create(request: Serenity.SaveRequest<SalesInvoiceMasterRow>, onSuccess?: (response: Serenity.SaveResponse) => void, opt?: Q.ServiceOptions<any>): JQueryXHR;
        export declare function Update(request: Serenity.SaveRequest<SalesInvoiceMasterRow>, onSuccess?: (response: Serenity.SaveResponse) => void, opt?: Q.ServiceOptions<any>): JQueryXHR;
        export declare function Delete(request: Serenity.DeleteRequest, onSuccess?: (response: Serenity.DeleteResponse) => void, opt?: Q.ServiceOptions<any>): JQueryXHR;
        export declare function Retrieve(request: Serenity.RetrieveRequest, onSuccess?: (response: Serenity.RetrieveResponse<SalesInvoiceMasterRow>) => void, opt?: Q.ServiceOptions<any>): JQueryXHR;
        export declare function List(request: Serenity.ListRequest, onSuccess?: (response: Serenity.ListResponse<SalesInvoiceMasterRow>) => void, opt?: Q.ServiceOptions<any>): JQueryXHR;

        export declare const enum Methods {
            Create = "Sales/SalesInvoiceMaster/Create",
            Update = "Sales/SalesInvoiceMaster/Update",
            Delete = "Sales/SalesInvoiceMaster/Delete",
            Retrieve = "Sales/SalesInvoiceMaster/Retrieve",
            List = "Sales/SalesInvoiceMaster/List"
        }

        [
            'Create', 
            'Update', 
            'Delete', 
            'Retrieve', 
            'List'
        ].forEach(x => {
            (<any>SalesInvoiceMasterService)[x] = function (r, s, o) {
                return Q.serviceRequest(baseUrl + '/' + x, r, s, o);
            };
        });
    }
}

