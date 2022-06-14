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
                id: '6981294981274',
                node: document.getElementById('product-component-1639759445059'),
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
                                "font-size": "28px"
                            },
                            "button": {
                                "font-size": "14px",
                                "padding-top": "15px",
                                "padding-bottom": "15px",
                                ":hover": {
                                    "background-color": "#d90d0d"
                                },
                                "background-color": "#f10e0e",
                                ":focus": {
                                    "background-color": "#d90d0d"
                                },
                                "border-radius": "4px",
                                "padding-left": "122px",
                                "padding-right": "122px"
                            },
                            "quantityInput": {
                                "font-size": "14px",
                                "padding-top": "15px",
                                "padding-bottom": "15px"
                            },
                            "price": {
                                "font-size": "17px"
                            },
                            "compareAt": {
                                "font-size": "14.45px"
                            },
                            "unitPrice": {
                                "font-size": "14.45px"
                            }
                        },
                        "layout": "horizontal",
                        "contents": {
                            "img": false,
                            "imgWithCarousel": true,
                            "description": true
                        },
                        "width": "100%",
                        "text": {
                            "button": "Añadir a la cesta"
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
                                "font-size": "14px",
                                "padding-top": "15px",
                                "padding-bottom": "15px",
                                ":hover": {
                                    "background-color": "#d90d0d"
                                },
                                "background-color": "#f10e0e",
                                ":focus": {
                                    "background-color": "#d90d0d"
                                },
                                "border-radius": "4px",
                                "padding-left": "122px",
                                "padding-right": "122px"
                            },
                            "quantityInput": {
                                "font-size": "14px",
                                "padding-top": "15px",
                                "padding-bottom": "15px"
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
                            "button": "Añadir al Carrito"
                        }
                    },
                    "option": {},
                    "cart": {
                        "styles": {
                            "button": {
                                "font-size": "14px",
                                "padding-top": "15px",
                                "padding-bottom": "15px",
                                ":hover": {
                                    "background-color": "#d90d0d"
                                },
                                "background-color": "#f10e0e",
                                ":focus": {
                                    "background-color": "#d90d0d"
                                },
                                "border-radius": "4px"
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
                                "font-size": "14px"
                            }
                        }
                    }
                },
            });
        });
    }
})();
/*]]>*/