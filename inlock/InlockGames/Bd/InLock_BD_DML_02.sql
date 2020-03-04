use InlockGames_Manhã;

INSERT INTO TipoUsuario (Titulo)
VALUES ('Administrador'),('Cliente');

INSERT INTO Usuario (Email,Senha,idTipoUsuario)
VALUES ('admin@admin.com','admin',1),
('cliente@cliente.com','Cliente',2);

INSERT INTO Estudio (NomeEstudio)
VALUES ('Blizzard'),
('Rockstar Games');

INSERT INTO Jogo (TituloJogo,Descricao,DataLan,Valor,idEstudio)
VALUES ('Diablo 3','é um jogo que contém bastante ação e é viciante, seja você um novato ou um fã','15/05/2012',99.00,1),
('Red Dead Redemption 2','jogo eletrônico de ação-aventura western','26/10/2018',120.00,2);
