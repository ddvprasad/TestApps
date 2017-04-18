'use strict';
var absURL = document.URL;
var parser = document.createElement('a');
parser.href = absURL;
var config = {
    apiurl: parser.protocol + '//' + parser.host + '/AspenportalAdminWebApi',
    errorUrl: parser.protocol + '//' + parser.host + '/Exceptions/GeneralException.aspx'
};
var mmmServices = angular.module("mmmServices", []).constant('CONFIG', {
    apiurl: config.apiurl,
    errorUrl: config.errorUrl
});
mmmServices.factory("MMMfactory", ["$resource", "$rootScope", 'CONFIG', function ($resource, $rootScope, CONFIG) {

    var resource = $resource(CONFIG.apiurl + '/api/CCs/:action', { action: '@action' }, {
        GetUploadData: { method: 'GET', params: { action: 'GetUploadData' }, isArray: true },
        saveUploadData: { method: 'POST', params: { action: 'saveUploadData' } },
        getCommunications: { method: 'GET', params: { action: 'GetCCData' }, isArray: true },
        saveCCAuditData: { method: 'POST', params: { action: 'saveCCLog' } },
    });

    return {
        GetUploadData: function (oem) {
            return resource.GetUploadData({ brand: oem }, function () { });
        },
        getCommunications: function (oem, uType, id) {
            return resource.getCommunications({ brand: oem, userType: uType, DId: id }, function () { });
        },
        saveUploadData: function (data) {
            return resource.saveUploadData(data);
        },
        saveCCAuditData: function (data) {
            return resource.saveCCAuditData(data);
        }
    };


}]);
