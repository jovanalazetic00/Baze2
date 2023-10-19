DROP TABLE IF EXISTS SUDIJA3;
DROP TABLE IF EXISTS Licenca1;
DROP TABLE IF EXISTS ZaTakmicare1;
DROP TABLE IF EXISTS ZaStazu1;
DROP TABLE IF EXISTS ProizvodjacOpreme1;
DROP TABLE IF EXISTS Drzava1;
DROP TABLE IF EXISTS Skijas1;
DROP TABLE IF EXISTS Trka1;
DROP TABLE IF EXISTS Staza1;
DROP TABLE IF EXISTS Ucestvuje1;
DROP TABLE IF EXISTS Oprema1;


CREATE TABLE SUDIJA3 (
  IdSud2 INT ,
  ImeSud2 VARCHAR(255),
  PrzSud2 VARCHAR(255),
  TipSud2 VARCHAR(255)
  CONSTRAINT Sudija2 PRIMARY KEY (IdSud2)
);

DELETE FROM SUDIJA3
INSERT INTO SUDIJA3(IdSud2, ImeSud2, PrzSud2, TipSud2) VALUES ('1', 'Marko', 'Markovic', 'ZaStazu');
INSERT INTO SUDIJA3 (IdSud2, ImeSud2, PrzSud2, TipSud2) VALUES ('2', 'Nikola', 'Nikolic', 'ZaTakmicare');
INSERT INTO SUDIJA3 (IdSud2, ImeSud2, PrzSud2, TipSud2) VALUES ('3', 'Stefan', 'Stefanovic', 'ZaStazu');
SELECT * FROM SUDIJA3


CREATE TABLE Licenca1 (
  IdLic1 INT PRIMARY KEY,
  DatIzdv1 DATE,
  DatIstk1 DATE,
  NazLic1 VARCHAR(255),
  IdSud2 INT,
  FOREIGN KEY (IdSud2) REFERENCES SUDIJA3(IdSud2)
);

DELETE FROM Licenca1
INSERT INTO Licenca1 (IdLic1, DatIzdv1, DatIstk1, NazLic1, IdSud2) VALUES ('4', '2000-05-06', '2013-02-06', 'Licenca1', '1');
INSERT INTO Licenca1 (IdLic1, DatIzdv1, DatIstk1, NazLic1, IdSud2) VALUES ('5', '2005-06-06', '2020-09-12', 'Licenca2', '2');
INSERT INTO Licenca1 (IdLic1, DatIzdv1, DatIstk1, NazLic1, IdSud2) VALUES ('6', '2000-03-16', '2027-05-23', 'Licenca3', '3');
SELECT * FROM Licenca1

CREATE TABLE ZaTakmicare1 (
  IdSud2 INT PRIMARY KEY,
  FOREIGN KEY (IdSud2) REFERENCES SUDIJA3(IdSud2)
);

DELETE FROM ZaTakmicare1
INSERT INTO ZaTakmicare1(IdSud2) VALUES ('1');
INSERT INTO ZaTakmicare1(IdSud2) VALUES ('2');
INSERT INTO ZaTakmicare1(IdSud2) VALUES ('3');
SELECT * FROM ZaTakmicare1


CREATE TABLE ZaStazu1 (
  IdSud2 INT PRIMARY KEY,
  FOREIGN KEY (IdSud2) REFERENCES SUDIJA3(IdSud2)
);

DELETE FROM ZaStazu1
INSERT INTO ZaStazu1(IdSud2) VALUES ('1');
INSERT INTO ZaStazu1(IdSud2) VALUES ('2');
INSERT INTO ZaStazu1(IdSud2) VALUES ('3');
SELECT * FROM ZaStazu1

CREATE TABLE ProizvodjacOpreme1 (
  IdProiz1 INT PRIMARY KEY,
  NazProiz1 VARCHAR(255)
);

DELETE FROM ProizvodjacOpreme1
INSERT INTO ProizvodjacOpreme1(IdProiz1, NazProiz1) VALUES ('1', 'Fischer');
INSERT INTO ProizvodjacOpreme1 (IdProiz1, NazProiz1) VALUES ('2', 'Burton');
INSERT INTO ProizvodjacOpreme1 (IdProiz1, NazProiz1) VALUES ('3', 'Atomic');
SELECT * FROM ProizvodjacOpreme1

CREATE TABLE Oprema1 (
  IdOp1 INT,
  VelOp1 VARCHAR(255),
  VrstOp1 VARCHAR(255),
  IdProiz1 INT,
  PRIMARY KEY (IdOp1, IdProiz1),
  FOREIGN KEY (IdProiz1) REFERENCES ProizvodjacOpreme1(IdProiz1)
);

DELETE FROM Oprema1
INSERT INTO Oprema1(IdOp1, VelOp1, VrstOp1, IdProiz1) VALUES ('5', 'S', 'Muska', '1');
INSERT INTO Oprema1 (IdOp1, VelOp1, VrstOp1, IdProiz1) VALUES ('6', 'M', 'Zenska', '2');
INSERT INTO Oprema1 (IdOp1, VelOp1, VrstOp1, IdProiz1) VALUES ('7', 'L', 'Djecija', '3');
SELECT * FROM Oprema1

CREATE TABLE Drzava1 (
  IdDrz1 INT PRIMARY KEY,
  NazDrz1 VARCHAR(255)
);


DELETE FROM Drzava1
INSERT INTO Drzava1(IdDrz1, NazDrz1) VALUES ('7', 'Austrija');
INSERT INTO Drzava1 (IdDrz1, NazDrz1) VALUES ('23', 'Francuska');
INSERT INTO Drzava1 (IdDrz1, NazDrz1) VALUES ('16', 'Rusija');
SELECT * FROM Drzava1

CREATE TABLE Skijas1 (
  IdSk1 INT PRIMARY KEY,
  ImeSk1 VARCHAR(255),
  PrzSk1 VARCHAR(255),
  RezSk1 VARCHAR(255),
  BrSkiPas1 VARCHAR(255),
  IdDrz1 INT,
  FOREIGN KEY (IdDrz1) REFERENCES Drzava1(IdDrz1)
);

DELETE FROM Skijas1
INSERT INTO Skijas1(IdSk1, ImeSk1, PrzSk1, RezSk1, BrSkiPas1, IdDrz1) VALUES ('11', 'Igor', 'Šuka', '10', '12', '7');
INSERT INTO Skijas1 (IdSk1, ImeSk1, PrzSk1, RezSk1, BrSkiPas1, IdDrz1) VALUES ('21', 'Nikola', 'Vujovic', '15', '17', '23');
INSERT INTO Skijas1 (IdSk1, ImeSk1, PrzSk1, RezSk1, BrSkiPas1, IdDrz1) VALUES ('31', 'Milan', 'Dikic', '12', '33', '16');
SELECT * FROM Skijas1


CREATE TABLE Trka1 (
  IdTrk1 INT PRIMARY KEY,
  NazTrke1 VARCHAR(255),
  VrTrk1 VARCHAR(255),
  DatTrk1 DATE,
  KatTrk1 VARCHAR(255),
  IdDrz1 INT,
  FOREIGN KEY (IdDrz1) REFERENCES Drzava1(IdDrz1)
);

DELETE FROM Trka1
INSERT INTO Trka1(IdTrk1, NazTrke1, VrTrk1, DatTrk1, KatTrk1, IdDrz1) VALUES ('13', 'OI', '20', '2021-03-04', 'Slalom', '7');
INSERT INTO Trka1 (IdTrk1, NazTrke1, VrTrk1, DatTrk1, KatTrk1, IdDrz1) VALUES ('14', 'Alpsko Skijanje', '50', '2022-02-11', 'Spust', '23');
INSERT INTO Trka1 (IdTrk1, NazTrke1, VrTrk1, DatTrk1, KatTrk1, IdDrz1) VALUES ('15', 'FIS', '40', '2023-04-04', 'Veleslalom', '16');
SELECT * FROM Trka1



CREATE TABLE Staza1 (
  IdSt1 INT,
  NazSt1 VARCHAR(255),
  DuzinaSt1 VARCHAR(255),
  IdTrk1 INT,
  PRIMARY KEY (IdSt1, IdTrk1),
  FOREIGN KEY (IdTrk1) REFERENCES Trka1(IdTrk1)
);

DELETE FROM Staza1
INSERT INTO Staza1(IdSt1, NazSt1, DuzinaSt1, IdTrk1) VALUES ('100', 'Streif', '1000', '13');
INSERT INTO Staza1 (IdSt1, NazSt1, DuzinaSt1, IdTrk1) VALUES ('101', 'Val d Isere', '1500', '14');
INSERT INTO Staza1 (IdSt1, NazSt1, DuzinaSt1, IdTrk1) VALUES ('102', 'Rosa Khutor', '2000', '15');
SELECT * FROM Staza1



CREATE TABLE Ucestvuje1 (
  IdSk1 INT,
  IdTrk1 INT,
  IdSud2 INT,
  PRIMARY KEY (IdSk1, IdTrk1, IdSud2),
  FOREIGN KEY (IdSk1) REFERENCES Skijas1(IdSk1),
  FOREIGN KEY (IdTrk1) REFERENCES Trka1(IdTrk1),
  FOREIGN KEY (IdSud2) REFERENCES ZaTakmicare1(IdSud2)
);

DELETE FROM Ucestvuje1
INSERT INTO Ucestvuje1 (IdSk1, IdTrk1, IdSud2) VALUES ('11', '13', '1');
INSERT INTO Ucestvuje1 (IdSk1, IdTrk1, IdSud2) VALUES ('21', '14', '2');
INSERT INTO Ucestvuje1 (IdSk1, IdTrk1, IdSud2) VALUES ('31', '15', '3');
SELECT * FROM Ucestvuje1
