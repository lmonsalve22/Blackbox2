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
                node: document.getElementById('product-component-1639692445629'),
                moneyFormat: 'USD%24%20%26nbsp%3B%20%20%7B%7Bamount%7D%7D',
                options: {
                    "product": {
                        "styles": {
                            "product": {
                                "@media (min-width: 601px)": {
                                    "max-width": "100%",
                                    "margin-left": "0",
                                    "margin-bottom": "50px"
                                },
                                "text-align": "left"
                            },
                            "title": {
                                "font-size": "26px"
                            },
                            "button": {
                                ":hover": {
                                    "background-color": "#d90d0d"
                                },
                                "background-color": "#f10e0e",
                                ":focus": {
                                    "background-color": "#d90d0d"
                                },
                                "border-radius": "0px",
                                "padding-left": "126px",
                                "padding-right": "126px"
                            },
                            "price": {
                                "font-size": "18px"
                            },
                            "compareAt": {
                                "font-size": "15.299999999999999px"
                            },
                            "unitPrice": {
                                "font-size": "15.299999999999999px"
                            }
                        },
                        "buttonDestination": "checkout",
                        "layout": "horizontal",
                        "contents": {
                            "img": false,
                            "imgWithCarousel": true,
                            "description": true
                        },
                        "width": "100%",
                        "text": {
                            "button": "Compra ahora"
                        }
                    },
                    "productSet": {
                        "styles": {
                            "products": {
                                "@media (min-width: 601px)": {
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
                                "@media (min-width: 601px)": {
                                    "max-width": "100%",
                                    "margin-left": "0px",
                                    "margin-bottom": "0px"
                                }
                            },
                            "button": {
                                ":hover": {
                                    "background-color": "#d90d0d"
                                },
                                "background-color": "#f10e0e",
                                ":focus": {
                                    "background-color": "#d90d0d"
                                },
                                "border-radius": "0px",
                                "padding-left": "126px",
                                "padding-right": "126px"
                            },
                            "title": {
                                "font-family": "Helvetica Neue, sans-serif",
                                "font-weight": "bold",
                                "font-size": "26px",
                                "color": "#4c4c4c"
                            },
                            "price": {
                                "font-family": "Helvetica Neue, sans-serif",
                                "font-weight": "normal",
                                "font-size": "18px",
                                "color": "#4c4c4c"
                            },
                            "compareAt": {
                                "font-family": "Helvetica Neue, sans-serif",
                                "font-weight": "normal",
                                "font-size": "15.299999999999999px",
                                "color": "#4c4c4c"
                            },
                            "unitPrice": {
                                "font-family": "Helvetica Neue, sans-serif",
                                "font-weight": "normal",
                                "font-size": "15.299999999999999px",
                                "color": "#4c4c4c"
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
                                ":hover": {
                                    "background-color": "#d90d0d"
                                },
                                "background-color": "#f10e0e",
                                ":focus": {
                                    "background-color": "#d90d0d"
                                },
                                "border-radius": "0px"
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
                            }
                        }
                    }
                },
            });
        });
    }
})();
 /*]]>*/