SELECT c.cuit_cliente, c.razon_social, f.num_factura, f.fecha, f.monto_total
FROM factura f JOIN cliente c ON f.cuit_cliente = c.cuit_cliente
WHERE MONTH(f.fecha) = 10  AND YEAR(f.fecha) = 2021
ORDER BY f.fecha;
