Create Database InlockGames_Manhã;
use InlockGames_Manhã;

CREATE TABLE TipoUsuario(
idTipoUsuario INT PRIMARY KEY IDENTITY,
Titulo VARCHAR(200)not null
);

CREATE TABLE Usuario(
idUsuario INT PRIMARY KEY IDENTITY,
Email VARCHAR(200)not null,
Senha VARCHAR(200)not null,
idTipoUsuario INT FOREIGN KEY REFERENCES TipoUsuario(idTipoUsuario)not null
);


CREATE TABLE Estudio (
idEstudio INT PRIMARY KEY IDENTITY,
NomeEstudio VARCHAR(200)Not null
);

CREATE TABLE Jogo(
idJogo INT PRIMARY KEY IDENTITY,
TituloJogo VARCHAR(200)NOT NULL,
Descricao VARCHAR(255)not null,
DataLan DATE NOT NULL,
Valor Decimal not null,
idEstudio INT FOREIGN KEY REFERENCES Estudio(idEstudio)
);

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



Select * FROM TipoUsuario
Select * FROM Usuario
Select * FROM Estudio
Select * FROM Jogo


