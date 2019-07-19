select 
		BL.Nome,
		COUNT(LV.Alocado) as 'QuantidadedeLivros',
		US.Nome as 'UserName'
from Biblioteca BL
inner join Livros LV on BL.Id = LV.Biblioteca
inner join Usuario US on LV.UsuInc = US.Id
group by BL.Nome,US.Nome