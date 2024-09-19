DECLARE @Products TABLE (Id INT NOT NULL, Name NVARCHAR(1000) NOT NULL);
DECLARE @Categories TABLE (Id INT NOT NULL, Name NVARCHAR(1000) NOT NULL);
DECLARE @Relations TABLE (ProductId INT NOT NULL, CategoryId INT NOT NULL);

INSERT INTO @Products VALUES 
  (1, 'Product A'),
  (2, 'Product B'),
  (3, 'Product C'),
  (4, 'Product D'),
  (5, 'Product E'),
  (6, 'Product F'),
  (7, 'Product G'),
  (8, 'Product H'),
  (9, 'Product J'),
  (10, 'Product I'),
  (11, 'Product K'),
  (12, 'Product L'),
  (13, 'Product M'),
  (14, 'Product N'),
  (15, 'Product O');

INSERT INTO @Categories VALUES 
  (1, 'Category A'),
  (2, 'Category B'),
  (3, 'Category C'),
  (4, 'Category D');

INSERT INTO @Relations VALUES 
  (1, 1),
  (2, 1),
  (3, 1),
  (4, 1),
  (4, 2),
  (5, 2),
  (6, 2),
  (7, 2),
  (7, 3),
  (7, 4),
  (8, 3),
  (9, 3),
  (10, 3),
  (11, 1),
  (11, 2),
  (11, 4),
  (12, 4),
  (13, 4);


SELECT P.Name, C.Name
FROM 
  @Products P 
  LEFT JOIN @Relations R ON P.Id = R.ProductId
  LEFT JOIN @Categories C ON C.Id = R.CategoryId;