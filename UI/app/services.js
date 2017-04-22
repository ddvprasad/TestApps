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

    var resource = $resource(CONFIG.apiurl + '/api/MMM/:action', { action: '@action' }, {
        UserAuthenticate: { method: 'POST', params: { action: 'UserLogin' }, isArray: true },
        saveUploadData: { method: 'POST', params: { action: 'saveUploadData' } },
        getWorkOrders: { method: 'GET', params: { action: 'getWorkOrders' }, isArray: true },
        saveCCAuditData: { method: 'POST', params: { action: 'saveCCLog' } },
    });

    return {
        UserAuthentication: function (data) {
            return resource.UserAuthenticate(data);
        },
        getWorkOrders: function (uId) {
            return resource.getWorkOrders({ UserId: uId }, function () { });
        },
        saveUploadData: function (data) {
            return resource.saveUploadData(data);
        },
        saveCCAuditData: function (data) {
            return resource.saveCCAuditData(data);
        }
    };


}]);
