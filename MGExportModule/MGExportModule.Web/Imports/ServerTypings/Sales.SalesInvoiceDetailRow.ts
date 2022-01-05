namespace MGExportModule.Sales {
    export interface SalesInvoiceDetailRow {
        SalesDetailId?: number;
        CustomCode?: string;
        SalesId?: number;
        ItemId?: string;
        Quontity?: number;
        UnitPrice?: number;
        TotalPrice?: number;
        Coaid?: number;
        DrAmount?: number;
        CrAmount?: number;
        IsDelete?: boolean;
        SalesCustomCode?: string;
        SalesDescription?: string;
        SalesBuyerId?: number;
        SalesSalesDate?: string;
        SalesIsDelete?: boolean;
    }

    export namespace SalesInvoiceDetailRow {
        export const idProperty = 'SalesDetailId';
        export const nameProperty = 'CustomCode';
        export const localTextPrefix = 'Sales.SalesInvoiceDetail';
        export const deletePermission = 'Sales:SalesInvoiceDetail:Delete';
        export const insertPermission = 'Sales:SalesInvoiceDetail:Insert';
        export const readPermission = 'Sales:SalesInvoiceDetail:Read';
        export const updatePermission = 'Sales:SalesInvoiceDetail:Update';

        export declare const enum Fields {
            SalesDetailId = "SalesDetailId",
            CustomCode = "CustomCode",
            SalesId = "SalesId",
            ItemId = "ItemId",
            Quontity = "Quontity",
            UnitPrice = "UnitPrice",
            TotalPrice = "TotalPrice",
            Coaid = "Coaid",
            DrAmount = "DrAmount",
            CrAmount = "CrAmount",
            IsDelete = "IsDelete",
            SalesCustomCode = "SalesCustomCode",
            SalesDescription = "SalesDescription",
            SalesBuyerId = "SalesBuyerId",
            SalesSalesDate = "SalesSalesDate",
            SalesIsDelete = "SalesIsDelete"
        }
    }
}

