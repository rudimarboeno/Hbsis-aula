select --chama as tabelas que quero pesquisar
		Dogs,               --nome que quero chamar para coluna
		SUM(TotalVendas) as 'Total Vendas',
		MONTH(DataVenda) as 'Mês'
from FoodTruckZezinho -- chamo o nome da tabela
where MONTH(DataVenda) BETWEEN 1 and 4 --BETWEEN inicio mes 1 ate mes 4 vai contar apenas o que esta entre eles
group by Dogs,MONTH(DataVenda)
order by 'Total Vendas' desc;

--SUM significa para somar agrupador
--MONTH agrupa
