﻿select temp.*,IIF(temp.Media >= 7, 'Aprovado','Reprovado') as 'Status' from
(Select
		Nome,
		Materia,
		((Nota1 + Nota2 + Nota3)/3) as 'Media'
	from Diario) temp;