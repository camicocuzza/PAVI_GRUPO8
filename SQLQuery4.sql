SELECT s.cantidad 
                          FROM articulo a JOIN stock s ON a.cod_articulo = s.cod_articulo
                          WHERE a.cod_articulo = '1' 
                          AND s.fecha = (SELECT max(s1.fecha) FROM stock s1
                                         WHERE s1.cod_articulo = s.cod_articulo);