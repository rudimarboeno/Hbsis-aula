select tr.Nome as 'Turma',
		a.Aluno
	from Turmas tr 
	inner join TurmaAlunos ta on tr.Id = ta.Turma
	inner join Alunos a on ta.Aluno = a.Id;
	--Trago todos os alunos da tuma

select
	  d.[Data],
	  TR.Aluno,
	  n.Nota AS 'Média',
	  IIF(ISNULL(p.Id,0) > 0,'Presenças','Ausente') as 'Presenças'
from Diarios d 
	inner join TurmaAlunos TR on d.Turma = TR.Turma
	left join Presenca p on d.Id = p.Diario and TR.Aluno = p.Aluno
	left join Notas n on TR.Aluno = n.Aluno and d.Id = n.Diario


