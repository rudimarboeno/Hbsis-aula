select Nome, 
	   Materia,
	   (((Nota1 + Nota2 + Nota3 + Nota4 + Nota5) / 5)) as 'Media',
	   IIF (((Nota1 + Nota2 + Nota3 + Nota4 + Nota5) / 5) >= 5,'Aprovado','Reprovado')
	   as 'Status'
from Diario01 ORDER BY Status asc;
go
select * from Diario01;