/*
select
     es.Modelo as 'Carros'
from Estoque es 
	inner join Carros ca on es.Id = ca.Modelo;
*/
SELECT  YEAR (la.[Data]) as 'Ano' , 
		COUNT(*)	as 'Numero de Locação',
		es.Modelo as 'Modelo'
from Locacao la
	inner join Estoque es on  la.Modelo = es.Modelo
group by YEAR (la.[Data]),es.Modelo
  