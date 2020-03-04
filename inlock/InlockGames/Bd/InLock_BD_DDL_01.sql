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







