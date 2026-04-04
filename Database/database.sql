Create database Proyecto_VLR;
GO

USE Proyecto_VLR;
GO

create table login
(
    ID_Login INT IDENTITY(1,1) PRIMARY KEY,
    Username VARCHAR(50) NOT NULL,
    Password VARCHAR(50) NOT NULL
);
GO

CREATE TABLE Player
(
    ID INT IDENTITY(1,1) PRIMARY KEY,
    TagName VARCHAR(100) NOT NULL,
    Equipo VARCHAR(100) NOT NULL,
    Estado VARCHAR(50) NOT NULL,
    Juego VARCHAR(50) NOT NULL
);
GO

INSERT INTO login (Username, Password)
VALUES ('admin', '123');
GO

INSERT INTO Player (TagName, Equipo, Estado, Juego)
VALUES 
('Hans', 'BBL Esports', 'Fichado', 'Valorant'),
('Willito', 'N/A', 'Free agent', 'League of legends'),
('Xavierobsd', 'EDward Gaming', 'Fichado', 'Overwatch');
GO
