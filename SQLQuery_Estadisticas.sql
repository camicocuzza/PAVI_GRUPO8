SELECT d.cod_articulo, a.nombre, COUNT(a.cod_articulo) AS CantidadVendida
FROM detalle_factura_articulo d
JOIN articulo a ON d.cod_articulo = a.cod_articulo
GROUP BY d.cod_articulo, a.nombre;

SELECT c.razon_social, c.cuit_cliente, COUNT(c.cuit_cliente) AS CantidadVentas, SUM(f.monto_total) AS Total
FROM factura f
JOIN cliente c ON f.cuit_cliente = c.cuit_cliente
GROUP BY c.razon_social, c.cuit_cliente;
