USE Filmes

INSERT INTO Genero (Nome)
VALUES ('Terror'), 
('Aventura')

INSERT INTO Filme (IdGenero, Titulo)
VALUES (1, 'O Iluminado'), (2, 'De Volta Pro Futuro')

INSERT INTO Usuario
VALUES ('luizgameplays@gmail.com', '1234', 0), ('filmeseseries@gmail.com', '1234', 1)

SELECT * FROM Usuario


SELECT * FROM Usuario WHERE Email LIKE 'luizgameplays@gmail.com' AND Senha LIKE '1234'