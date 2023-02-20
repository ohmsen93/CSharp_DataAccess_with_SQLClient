USE SuperheroesDb;

-- Insert powers for Superman
DECLARE @superman_id INT = (SELECT Id FROM Superhero WHERE Name = 'Superman');

INSERT INTO Power (Name, Description)
VALUES
	('Flight', 'The ability to fly at incredible speeds'),
	('Super Strength', 'The ability to lift very heavy objects'),
	('Heat Vision', 'The ability to shoot intense beams of heat from his eyes'),
	('Super Breath', 'The ability to exhale powerful gusts of wind or freeze objects with his breath'),
	('Super Speed', 'The ability to move at incredible speeds');

INSERT INTO Superhero_Power (FK_Superhero_Id, FK_Power_Id)
VALUES
	(@superman_id, 1), -- Flight
	(@superman_id, 2), -- Super Strength
	(@superman_id, 3), -- Heat Vision
	(@superman_id, 4), -- Super Breath
	(@superman_id, 5); -- Super Speed


-- Insert powers for Batman
DECLARE @batman_id INT = (SELECT Id FROM Superhero WHERE Name = 'Batman');

INSERT INTO Power (Name, Description)
VALUES
	('Intelligence', 'The ability to process and analyze information quickly and accurately'),
	('Combat Training', 'The ability to fight in a variety of styles'),
	('Gadgetry', 'The ability to create and use advanced gadgets and technology'),
	('Stealth', 'The ability to move silently and remain undetected'),
	('Interrogation', 'The ability to extract information from subjects through questioning');

INSERT INTO Superhero_Power (FK_Superhero_Id, FK_Power_Id)
VALUES
	(@batman_id, 6), -- Intelligence
	(@batman_id, 7), -- Combat Training
	(@batman_id, 8), -- Gadgetry
	(@batman_id, 9), -- Stealth
	(@batman_id, 10); -- Interrogation


-- Insert powers for Flash
DECLARE @flash_id INT = (SELECT Id FROM Superhero WHERE Name = 'Flash');

INSERT INTO Power (Name, Description)
VALUES
	('Super Speed', 'The ability to move at incredible speeds'),
	('Time Travel', 'The ability to travel through time'),
	('Phasing', 'The ability to pass through solid objects'),
	('Accelerated Healing', 'The ability to heal rapidly from injuries'),
	('Vortex Creation', 'The ability to create powerful whirlwinds');

INSERT INTO Superhero_Power (FK_Superhero_Id, FK_Power_Id)
VALUES
	(@flash_id, 5), -- Super Speed
	(@flash_id, 6), -- Intelligence
	(@flash_id, 11), -- Time Travel
	(@flash_id, 12), -- Phasing
	(@flash_id, 13), -- Accelerated Healing
	(@flash_id, 14); -- Vortex Creation

-- Intelligence and Super speed are used by multiple heroes here. 