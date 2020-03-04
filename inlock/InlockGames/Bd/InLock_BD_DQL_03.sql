use InlockGames_Manhã;

Select * FROM TipoUsuario
Select * FROM Usuario
Select * FROM Estudio
SELECT * FROM Jogo;

Select TituloJogo, Descricao, DataLan, Valor, Estudio.NomeEstudio  FROM Jogo 
INNER JOIN Estudio ON Estudio.idEstudio = Jogo.idEstudio;