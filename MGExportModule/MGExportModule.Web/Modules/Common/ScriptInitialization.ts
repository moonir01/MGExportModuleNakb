/// <reference path="../Common/Helpers/LanguageList.ts" />
/// <reference path="../_Ext/_q/_q.var.ts" />
namespace MGExportModule.ScriptInitialization {
    Q.Config.responsiveDialogs = true;
    Q.Config.rootNamespaces.push('MGExportModule');
    Q.Config.rootNamespaces.push('_Ext');
    Serenity.EntityDialog.defaultLanguageList = LanguageList.getValue;

    if ($.fn['colorbox']) {
        $.fn['colorbox'].settings.maxWidth = "95%";
        $.fn['colorbox'].settings.maxHeight = "95%";
    }

    window.onerror = Q.ErrorHandling.runtimeErrorHandler;
}   