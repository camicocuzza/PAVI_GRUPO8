SELECT d.cod_articulo, a.nombre, d.cantidad, d.precio, d.cantidad * d.precio as subtotal
                            FROM factura f, detalle_factura_articulo d, articulo a
                            WHERE d.cod_articulo = a.cod_articulo AND
	                        f.num_factura = d.num_factura AND
	                        f.id_tipo_factura = d.id_tipo_factura AND
	                        f.id_tipo_factura = d.id_tipo_factura AND 
                            f.num_factura = 34 AND f.id_tipo_factura = 3 AND d.eliminado = 0;

							SELECT * from factura where eliminado = 0;