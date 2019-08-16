select 'Carros' as 'Carros',
		SUM(Temp.Media) as 'Vendas',
		Temp.AnoVenda
	from (select 
				ano,
			(SUM(NumeroV) / COUNT(*)) as 'Media',
			YEAR(DataVenda) as 'AnoVenda'
		from RegistroCarro
		group by ano,YEAR(DataVenda)) Temp
		group by Temp.AnoVenda;
	   