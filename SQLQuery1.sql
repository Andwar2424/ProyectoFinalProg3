create table usuario (id int primary key identity(1,1),usario varchar(50),password varchar(50),nivel int)
insert usuario (usario,password,nivel)values('admin','admin',1);

CREATE TABLE [inventario].[dbo].[merca](
    [id] INT PRIMARY KEY,
    [nombre] NVARCHAR(50) NOT NULL,
    [cantidad] INT NOT NULL,
    [distribuidora] NVARCHAR(50) NOT NULL
);

CREATE PROCEDURE delete_merca
    @id INT
AS
BEGIN
    DELETE FROM merca WHERE id = @id
END