

SELECT d.cod_articulo, a.nombre, SUM(d.cantidad) AS CantidadVendida
FROM factura f, detalle_factura_articulo d, articulo a 
WHERE f.num_factura = d.num_factura AND d.cod_articulo = a.cod_articulo
AND f.fecha BETWEEN '1/1/2019' AND '31/12/2021'
GROUP BY d.cod_articulo, a.nombre
ORDER BY len(d.cod_articulo), d.cod_articulo;

SELECT d.cod_articulo, f.fecha, d.cantidad
FROM factura f, detalle_factura_articulo d, articulo a 
WHERE f.num_factura = d.num_factura AND d.cod_articulo = a.cod_articulo
ORDER BY len(d.cod_articulo), a.cod_articulo;



SELECT c.cuit_cliente, c.razon_social, COUNT(c.cuit_cliente) AS CantidadVentas, SUM(f.monto_total) AS MontoTotal
FROM factura f
JOIN cliente c ON f.cuit_cliente = c.cuit_cliente
WHERE  f.eliminado = 0
GROUP BY c.razon_social, c.cuit_cliente;


SELECT c.cuit_cliente, c.razon_social, COUNT(c.cuit_cliente) AS CantidadVentas, SUM(f.monto_total) AS MontoTotal
                            FROM factura f
                            JOIN cliente c ON f.cuit_cliente = c.cuit_cliente
                            WHERE f.fecha BETWEEN '01/01/2000' AND '01/01/2023' AND f.eliminado = 0
                            GROUP BY c.cuit_cliente, c.razon_social;