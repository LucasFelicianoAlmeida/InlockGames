use InlockGames_Manh�;

INSERT INTO TipoUsuario (Titulo)
VALUES ('Administrador'),('Cliente');

INSERT INTO Usuario (Email,Senha,idTipoUsuario)
VALUES ('admin@admin.com','admin',1),
('cliente@cliente.com','Cliente',2);

INSERT INTO Estudio (NomeEstudio)
VALUES ('Blizzard'),
('Rockstar Games');

INSERT INTO Jogo (TituloJogo,Descricao,DataLan,Valor,idEstudio)
VALUES ('Diablo 3','� um jogo que cont�m bastante a��o e � viciante, seja voc� um novato ou um f�','15/05/2012',99.00,1),
('Red Dead Redemption 2','jogo eletr�nico de a��o-aventura western','26/10/2018',120.00,2);
