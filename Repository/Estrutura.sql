SELECT id,nome FROM plantas WHERE nome LIKE '';
CREATE TABLE plantas(
id INT PRIMARY KEY IDENTITY(1,1),
nome VARCHAR(100),
carnivora BIT,
peso DECIMAL(5,2),
altura DECIMAL(3,1)

);
