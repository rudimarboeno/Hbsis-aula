select 'MediaVenda' as 'MediaVenda',
		SUM(Temp.Media) as 'Vendas',
		Temp.MesVenda
from (select 
			DogCasa,
			DogEgg,
			DogSoya
		(SUM(TotalVendas) / COUNT(*)) as 'Medias',
		YEAR(DataVenda) as 'MesVenda'
from FoodTruckZezinho
group by TotalVendas,YEAR(DataVenda)) Temp
group by Temp.MesVenda;