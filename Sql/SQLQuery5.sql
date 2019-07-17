select
	[Aluno ],
	Idade,
	IIf(Ativo = 1,'ativo','inativo') as 'status'
  from AulaCsharp
Where Id in 
  (Select Id
	From AulaCsharp
	Where Idade < 30)
Order by Id desc;