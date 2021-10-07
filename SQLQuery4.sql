
SELECT d.cod_prod_ensamblado, a.cod_prod_ensamblado, d.cantidad, d.precio, d.cantidad * d.precio as subtotal
FROM factura f, detalle_factura_prodEnsamblado d, producto_ensamblado a
WHERE d.cod_prod_ensamblado = a.cod_prod_ensamblado AND
	f.num_factura = d.num_factura AND
	f.id_tipo_factura = d.id_tipo_factura AND
	f.id_tipo_factura = d.id_tipo_factura AND 
	f.id_tipo_factura = 1 AND f.num_factura = 21;

