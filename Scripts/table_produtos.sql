CREATE TABLE produtos (
    id SERIAL PRIMARY KEY,
    nome VARCHAR(255),
	marca VARCHAR(255),
	tipo VARCHAR(255),
	volume float,
	frasco VARCHAR(255)
);

-- Inserção 1
INSERT INTO produtos (nome, marca, tipo, volume, frasco)
VALUES ('Produto 1', 'Marca A', 'Tipo A', 100.0, 'Frasco A');

-- Inserção 2
INSERT INTO produtos (nome, marca, tipo, volume, frasco)
VALUES ('Produto 2', 'Marca B', 'Tipo B', 200.0, 'Frasco B');

-- Inserção 3
INSERT INTO produtos (nome, marca, tipo, volume, frasco)
VALUES ('Produto 3', 'Marca C', 'Tipo A', 150.0, 'Frasco A');

-- Inserção 4
INSERT INTO produtos (nome, marca, tipo, volume, frasco)
VALUES ('Produto 4', 'Marca A', 'Tipo C', 300.0, 'Frasco C');

-- Inserção 5
INSERT INTO produtos (nome, marca, tipo, volume, frasco)
VALUES ('Produto 5', 'Marca B', 'Tipo A', 120.0, 'Frasco B');

-- Inserção 6
INSERT INTO produtos (nome, marca, tipo, volume, frasco)
VALUES ('Produto 6', 'Marca D', 'Tipo B', 250.0, 'Frasco D');

-- Inserção 7
INSERT INTO produtos (nome, marca, tipo, volume, frasco)
VALUES ('Produto 7', 'Marca A', 'Tipo C', 180.0, 'Frasco C');

-- Inserção 8
INSERT INTO produtos (nome, marca, tipo, volume, frasco)
VALUES ('Produto 8', 'Marca B', 'Tipo A', 110.0, 'Frasco B');

-- Inserção 9
INSERT INTO produtos (nome, marca, tipo, volume, frasco)
VALUES ('Produto 9', 'Marca C', 'Tipo A', 220.0, 'Frasco A');

-- Inserção 10
INSERT INTO produtos (nome, marca, tipo, volume, frasco)
VALUES ('Produto 10', 'Marca D', 'Tipo B', 270.0, 'Frasco D');

SELECT * FROM produtos;