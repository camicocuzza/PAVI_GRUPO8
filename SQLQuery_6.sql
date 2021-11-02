select stock.cod_articulo, a.nombre, stock.cantidad, stock.fecha
from stock 
join articulo a on stock.cod_articulo = a.cod_articulo join
(
    select cod_articulo, max(fecha) as max_dt 
    from stock
    group by cod_articulo
) t
on stock.cod_articulo= t.cod_articulo and stock.fecha = t.max_dt 
order by len(stock.cod_articulo), stock.cod_articulo;

select stock.cod_articulo, a.nombre, stock.cantidad, stock.fecha
from stock 
join articulo a on stock.cod_articulo = a.cod_articulo
order by len(stock.cod_articulo), stock.cod_articulo;

select stock_prod_ensamblado.cod_prod_ensamblado, a.nombre, stock_prod_ensamblado.cantidad, stock_prod_ensamblado.fecha
                        from stock_prod_ensamblado
                        join producto_ensamblado a on stock_prod_ensamblado.cod_prod_ensamblado = a.cod_prod_ensamblado join
                        (
                            select cod_prod_ensamblado, max(fecha) as max_dt
                            from stock_prod_ensamblado
                            group by cod_prod_ensamblado
                        ) t
                        on stock_prod_ensamblado.cod_prod_ensamblado = t.cod_prod_ensamblado and stock_prod_ensamblado.fecha = t.max_dt
                        order by len(stock_prod_ensamblado.cod_prod_ensamblado), stock_prod_ensamblado.cod_prod_ensamblado;