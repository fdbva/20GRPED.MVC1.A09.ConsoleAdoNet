CREATE TABLE Pessoa(
	Id INT IDENTITY(0,1) PRIMARY KEY,
	Nome VARCHAR(50)
);

INSERT INTO Pessoa
		(Nome)
VALUES	('Pessoa1'),
		('Pessoa2'),
		('Pessoa3'),
		('Pessoa4'),
		('Pessoa5'),
		('Pessoa6'),
		('Pessoa7'),
		('Pessoa8');

SELECT * FROM Pessoa;


INSERT INTO Pessoa
		(Nome)
VALUES	('Pessoa111');