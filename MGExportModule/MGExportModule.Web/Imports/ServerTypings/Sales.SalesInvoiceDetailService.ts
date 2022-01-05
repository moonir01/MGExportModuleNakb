namespace MGExportModule.Sales {
    export namespace SalesInvoiceDetailService {
        export const baseUrl = 'Sales/SalesInvoiceDetail';

        export declare function Create(request: Serenity.SaveRequest<SalesInvoiceDetailRow>, onSuccess?: (response: Serenity.SaveResponse) => void, opt?: Q.ServiceOptions<any>): JQueryXHR;
        export declare function Update(request: Serenity.SaveRequest<SalesInvoiceDetailRow>, onSuccess?: (response: Serenity.SaveResponse) => void, opt?: Q.ServiceOptions<any>): JQueryXHR;
        export declare function Delete(request: Serenity.DeleteRequest, onSuccess?: (response: Serenity.DeleteResponse) => void, opt?: Q.ServiceOptions<any>): JQueryXHR;
        export declare function Retrieve(request: Serenity.RetrieveRequest, onSuccess?: (response: Serenity.RetrieveResponse<SalesInvoiceDetailRow>) => void, opt?: Q.ServiceOptions<any>): JQueryXHR;
        export declare function List(request: Serenity.ListRequest, onSuccess?: (response: Serenity.ListResponse<SalesInvoiceDetailRow>) => void, opt?: Q.ServiceOptions<any>): JQueryXHR;

        export declare const enum Methods {
            Create = "Sales/SalesInvoiceDetail/Create",
            Update = "Sales/SalesInvoiceDetail/Update",
            Delete = "Sales/SalesInvoiceDetail/Delete",
            Retrieve = "Sales/SalesInvoiceDetail/Retrieve",
            List = "Sales/SalesInvoiceDetail/List"
        }

        [
            'Create', 
            'Update', 
            'Delete', 
            'Retrieve', 
            'List'
        ].forEach(x => {
            (<any>SalesInvoiceDetailService)[x] = function (r, s, o) {
                return Q.serviceRequest(baseUrl + '/' + x, r, s, o);
            };
        });
    }
}

