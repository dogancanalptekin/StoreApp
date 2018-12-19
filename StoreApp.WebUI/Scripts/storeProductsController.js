﻿var productUrl = "http://localhost:50444/api/products/";

var getProducts = function () {
    sendRequest(productUrl + "getproducts", "Get", null, function (data) {
        model.products.removeAll();
        model.products.push.apply(model.products, data);
    })
};

var deleteProduct = function (id) {
    sendRequest(productUrl + "DeleteProduct" + "/" + id, "DELETE", null, function () {
        model.products.removeAll(function (item) {
            return item.Id == id;
        })
    })
};

var saveProduct = function (product, successCallback) {
    sendRequest(productUrl + "PostProduct", "POST", product, function () {
        getProducts();
        if (successCallback) {
            successCallback();
        }
    });
}