namespace MGExportModule.Sales {
    export interface SalesInvoiceMasterRow {
        Id?: number;
        CustomCode?: string;
        Description?: string;
        BuyerId?: number;
        SalesDate?: string;
        IsDelete?: boolean;
        SalesDetails?: SalesInvoiceDetailRow[];
    }

    export namespace SalesInvoiceMasterRow {
        export const idProperty = 'Id';
        export const nameProperty = 'CustomCode';
        export const localTextPrefix = 'Sales.SalesInvoiceMaster';
        export const deletePermission = 'Sales:SalesInvoiceMaster:Delete';
        export const insertPermission = 'Sales:SalesInvoiceMaster:Insert';
        export const readPermission = 'Sales:SalesInvoiceMaster:Read';
        export const updatePermission = 'Sales:SalesInvoiceMaster:Update';

        export declare const enum Fields {
            Id = "Id",
            CustomCode = "CustomCode",
            Description = "Description",
            BuyerId = "BuyerId",
            SalesDate = "SalesDate",
            IsDelete = "IsDelete",
            SalesDetails = "SalesDetails"
        }
    }
}

