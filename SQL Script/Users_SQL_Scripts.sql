
Create Database UsersDB

CREATE TABLE UserDetails(
  UserDetailsId UNIQUEIDENTIFIER DEFAULT (newsequentialid()) NOT NULL,
  FirstName   NVARCHAR(256) NOT NULL, 
  LastName    NVARCHAR(256) NOT NULL,
  Email       NVARCHAR(256) NOT NULL,
  Active      BIT NOT NULL,
  CONSTRAINT [PK_dbo.UserDetails] PRIMARY KEY CLUSTERED ([UserDetailsId] ASC)
);

INSERT INTO [UserDetails] VALUES
(NewID(),'Emma','Dunham','emma.dunham@vtgrafix.gov',1),
(NewID(),'Ivan','Risley','ivan.risley@nitrosystems.co',1),
(NewID(),'Rikki','Paquette','rikki.paquette@anaplex.xyz',1),
(NewID(),'Roman','Bourne','roman.bourne@baramax.co',1),
(NewID(),'Lyn','Chapman','lyn.chapman@loopsys.xyz',1),
(NewID(),'Rosie','Finn','rosie.finn@sealine.co',1),
(NewID(),'Cedric','Webster','cedric.webster@solexis.co',1),
(NewID(),'Rosanne','Starck','rosanne.starck@dalserve.org',1),
(NewID(),'Emma','Young','emma.young@terralabs.info',1),
(NewID(),'Stan','Milling','stan.milling@corerobotics.gov',1),
(NewID(),'Jenette','Oldman','jenette.oldman@hivemind.biz',1),
(NewID(),'Max','Hyder','max.hyder@polycore.gov',1),
(NewID(),'Juliana','Kelsey','juliana.kelsey@grafixmedia.xyz',1),
(NewID(),'Adam','Hollis','adam.hollis@triosys.co',1),
(NewID(),'Alexis','Brandt','alexis.brandt@terralabs.gov',1),
(NewID(),'Travis','Cappel','travis.cappel@ulogica.gov',1),
(NewID(),'Layla','Flinn','layla.flinn@seelogic.club',1),
(NewID(),'Raylene','Sager','raylene.sager@infratouch.net',1),
(NewID(),'Chloe','Turner','chloe.turner@playtech.mobi',1),
(NewID(),'Roman','Porras','roman.porras@mediadime.xyz',1);