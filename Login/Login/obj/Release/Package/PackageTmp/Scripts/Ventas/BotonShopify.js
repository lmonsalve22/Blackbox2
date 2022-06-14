
/*<![CDATA[*/
(function () {
    var scriptURL = 'https://sdks.shopifycdn.com/buy-button/latest/buy-button-storefront.min.js';
    if (window.ShopifyBuy) {
        if (window.ShopifyBuy.UI) {
            ShopifyBuyInit();
        } else {
            loadScript();
        }
    } else {
        loadScript();
    }
    function loadScript() {
        var script = document.createElement('script');
        script.async = true;
        script.src = scriptURL;
        (document.getElementsByTagName('head')[0] || document.getElementsByTagName('body')[0]).appendChild(script);
        script.onload = ShopifyBuyInit;
    }
    function ShopifyBuyInit() {
        var client = ShopifyBuy.buildClient({
            domain: 'data-intelligence.myshopify.com',
            storefrontAccessToken: 'fb49951c07ba85833561f2126d99f2c7',
        });
        ShopifyBuy.UI.onReady(client).then(function (ui) {
            ui.createComponent('product', {
                id: '6952889286810',
                variantId: '40614678560922',
                node: document.getElementById('product-component-1639696174392'),
                moneyFormat: 'USD%24%20%26nbsp%3B%20%20%7B%7Bamount%7D%7D',
                options: {
                    "product": {
                        "styles": {
                            "product": {
                                "@@media (min-width: 601px)": {
                                    "max-width": "calc(25% - 20px)",
                                    "margin-left": "20px",
                                    "margin-bottom": "50px"
                                }
                            },
                            "button": {
                                "font-size": "13px",
                                "padding-top": "14.5px",
                                "padding-bottom": "14.5px",
                                ":hover": {
                                    "background-color": "#d90d0d"
                                },
                                "background-color": "#f10e0e",
                                ":focus": {
                                    "background-color": "#d90d0d"
                                },
                                "border-radius": "29px",
                                "padding-left": "43px",
                                "padding-right": "43px"
                            },
                            "quantityInput": {
                                "font-size": "13px",
                                "padding-top": "14.5px",
                                "padding-bottom": "14.5px"
                            }
                        },
                        "buttonDestination": "checkout",
                        "contents": {
                            "img": false,
                            "title": false,
                            "price": false,
                            "options": false
                        },
                        "text": {
                            "button": "ADQUIRIR SUSCRIPCIÓN"
                        },
                        "variantId": "40614678560922"
                    },
                    "productSet": {
                        "styles": {
                            "products": {
                                "@@media (min-width: 601px)": {
                                    "margin-left": "-20px"
                                }
                            }
                        }
                    },
                    "modalProduct": {
                        "contents": {
                            "img": false,
                            "imgWithCarousel": true,
                            "button": false,
                            "buttonWithQuantity": true
                        },
                        "styles": {
                            "product": {
                                "@@media (min-width: 601px)": {
                                    "max-width": "100%",
                                    "margin-left": "0px",
                                    "margin-bottom": "0px"
                                }
                            },
                            "button": {
                                "font-size": "13px",
                                "padding-top": "14.5px",
                                "padding-bottom": "14.5px",
                                ":hover": {
                                    "background-color": "#d90d0d"
                                },
                                "background-color": "#f10e0e",
                                ":focus": {
                                    "background-color": "#d90d0d"
                                },
                                "border-radius": "29px",
                                "padding-left": "43px",
                                "padding-right": "43px"
                            },
                            "quantityInput": {
                                "font-size": "13px",
                                "padding-top": "14.5px",
                                "padding-bottom": "14.5px"
                            }
                        },
                        "text": {
                            "button": "Añadir a la cesta"
                        }
                    },
                    "option": {},
                    "cart": {
                        "styles": {
                            "button": {
                                "font-size": "13px",
                                "padding-top": "14.5px",
                                "padding-bottom": "14.5px",
                                ":hover": {
                                    "background-color": "#d90d0d"
                                },
                                "background-color": "#f10e0e",
                                ":focus": {
                                    "background-color": "#d90d0d"
                                },
                                "border-radius": "29px"
                            }
                        },
                        "text": {
                            "title": "Carro",
                            "total": "Subtotal",
                            "empty": "Tu carrito esta vacío.",
                            "notice": "Los códigos de envío y descuento se agregan al finalizar la compra.",
                            "button": "Pagar"
                        }
                    },
                    "toggle": {
                        "styles": {
                            "toggle": {
                                "background-color": "#f10e0e",
                                ":hover": {
                                    "background-color": "#d90d0d"
                                },
                                ":focus": {
                                    "background-color": "#d90d0d"
                                }
                            },
                            "count": {
                                "font-size": "13px"
                            }
                        }
                    }
                },
            });
        });
    }
})();
/*]]>*/
