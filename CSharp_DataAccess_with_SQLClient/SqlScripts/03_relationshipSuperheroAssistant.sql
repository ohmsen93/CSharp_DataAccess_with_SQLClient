use SuperheroesDb
GO

ALTER TABLE Assistant
	ADD [FK_Superhero_Id] [int]
GO

ALTER TABLE Assistant
ADD CONSTRAINT FK_Assistant_Superhero
FOREIGN KEY (FK_Superhero_Id)
REFERENCES Superhero(Id);
GO