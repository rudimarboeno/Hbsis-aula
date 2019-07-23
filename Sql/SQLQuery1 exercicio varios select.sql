
--1-
select Nome from Marcas where UsuInc = 1;

--2-
select Nome from Marcas where UsuInc = 2;

--3-
select COUNT(Nome) AS 'Quantidade de marcas'
from Marcas 
where UsuInc = 1
Order by 'Quantidade de marcas' desc;

--4-
select COUNT(Nome) AS 'Quantidade de marcas'
from Marcas 
where UsuInc = 2
Order by 'Quantidade de marcas' asc;

--5-
select COUNT(Nome) as 'Quantidade'
from Marcas;

--6-
select Modelo from Carros where UsuInc = 1;

--7-
select Modelo from Carros where UsuInc = 2;

--8-
select COUNT(Modelo) AS 'Quantidade'
from Carros 
where UsuInc = 1
Order by 'Quantidade' desc;

--9-
select COUNT(Modelo) AS 'Quantidade'
from Carros 
where UsuInc = 2
Order by 'Quantidade' asc;

--10-
select COUNT(Modelo) AS 'Quantidade'
from Carros; 

--11-
select  
     c.Modelo as 'Carro'
from Carros as c
inner join Marcas as m on c.Marca = m.Id 
where c.UsuInc = 1;

--12-
select  
     c.Modelo as 'Carro'
from Carros as c
inner join Marcas as m on c.Marca = m.Id 
where c.UsuInc = 2;

--13-
select
		COUNT(c.Modelo) as 'Carro'
from Carros as c
inner join Marcas as m on c.Marca = m.Id 
where c.UsuInc = 1
order by 'Carro' desc;

--14-
select
		COUNT(c.Modelo) as 'Carro'
from Carros as c
inner join Marcas as m on c.Marca = m.Id 
where c.UsuInc = 2
order by 'Carro' asc;


--15-
select sum(Valor) as 'Total venda de 2019'
From Vendas 
where YEAR(DatInc) = 2019;

--16-
select sum(Quantidade) as 'Quantidade Total venda de 2019'
From Vendas 
where YEAR(DatInc) = 2019;

--17-

select sum(Valor) as 'Total venda de cada ano',
		year(DatInc) as 'Anos'
From Vendas 
group by YEAR(DatInc) 
order by 'Total venda de cada ano' desc;

--18-

select sum(Quantidade) as 'Quantidade total venda de cada ano',
		year(DatInc) as 'Anos'
From Vendas 
group by YEAR(DatInc) 
order by 'Quantidade total venda de cada ano' desc;

--19-

select sum(Quantidade) as 'Quantidade total venda de cada mes',
	 MONTH(DatInc) as 'Mes'
From Vendas 
group by MONTH(DatInc) 
order by 'Quantidade total venda de cada mes' desc;

--20-

select sum(Valor) as 'total venda de cada mes',
  MONTH(DatInc) as 'Mes'
From Vendas 
group by MONTH(DatInc) 
order by 'total venda de cada mes' desc;

--21-

select sum(Valor) as 'total de venda'
From Vendas as v
where v.UsuInc = 1;

--22-

select sum(Valor) as 'total de venda'
From Vendas as v
where v.UsuInc = 1;

--23-

select sum(Valor) as 'total de venda'
From Vendas as v
where v.UsuInc = 2;

--24-

select sum(Quantidade) as 'total de venda'
From Vendas as v
where v.UsuInc = 1;

--25-

select sum(Quantidade) as 'total de venda'
From Vendas as v
where v.UsuInc = 2;

--26-

select sum(Valor) , Count(UsuInc) as 'teste'   
From Vendas as v
where v.UsuInc = 1  
order by 'teste' desc;

--27-

select sum(Quantidade) , Count(UsuInc) as 'Quantidade' 
From Vendas as v
where v.UsuInc = 1  
order by 'Quantidade' desc;

--28-

select 
		ma.Nome
from Marcas as ma
	inner join Vendas as ve on ma.Id = ve.Carro
order by ma.Nome desc;

--29-


