SELECT d.cod_prod_ensamblado, e.cod_prod_ensamblado, d.cantidad, d.precio, d.cantidad * d.precio as subtotal
                        FROM factura f, detalle_factura_prodEnsamblado d, producto_ensamblado e
                        WHERE d.cod_prod_ensamblado = e.cod_prod_ensamblado AND
	                    f.num_factura = d.num_factura AND
	                    f.id_tipo_factura = d.id_tipo_factura AND
	                    f.id_tipo_factura = d.id_tipo_factura ;

	SELECT d.cod_articulo, a.nombre, d.cantidad, d.precio, d.cantidad * d.precio as subtotal
                            FROM factura f, detalle_factura_articulo d, articulo a
                            WHERE d.cod_articulo = a.cod_articulo AND
	                        f.num_factura = d.num_factura AND
	                        f.id_tipo_factura = d.id_tipo_factura AND
	                        f.id_tipo_factura = d.id_tipo_factura AND 
                            f.num_factura = 2 AND f.id_tipo_factura = 1;
