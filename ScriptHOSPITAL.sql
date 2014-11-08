
--USE SALES 
--GO

-- DROP TABLES
if exists (select * from sysobjects where id = object_id('TREATMENT'))
  drop table TREATMENT
if exists (select * from sysobjects where id = object_id('PATIENT'))
  drop table PATIENT
if exists (select * from sysobjects where id = object_id('PHYSICIAN'))
  drop table PHYSICIAN

GO

/******  CREATE PHYSICIAN TABLE ******/
CREATE TABLE PHYSICIAN (
	PhysicianID bigint NOT NULL PRIMARY KEY,
	PhysicianName varchar (100) NOT NULL,
	Specialization varchar (100) NOT NULL,
	Salary bigint NOT NULL
)
GO
 
/******  CREATE PATIENT TABLE ******/
CREATE TABLE PATIENT (
	PatientID bigint NOT NULL PRIMARY KEY,
	PatientName varchar (100) NOT NULL,
	PhoneNumber bigint NOT NULL,
	EmergencyContact varchar (100) NOT NULL,
	AdmittedDate datetime NOT NULL,
	
	PhysicianID bigint NOT NULL REFERENCES PHYSICIAN(PhysicianID)

	--FOREIGN KEY (PhysicianID) REFERENCES PHYSICIAN(PhysicianID)
)
GO

/******  CREATE TREATMENT TABLE ******/
CREATE TABLE TREATMENT (
	TreatmentID bigint IDENTITY PRIMARY KEY,
	PatientID bigint NOT NULL REFERENCES PATIENT(PatientID),
	PhysicianID bigint NOT NULL REFERENCES PHYSICIAN(PhysicianID),
	TreatmentName varchar (100) NOT NULL,
	DateTreated datetime NOT NULL , /*or prescribed*/
	TreatmentDosage int NOT NULL /*can be null if not a medicine*/
	--dosage previously was not 'not null' but 
)
GO

--SET IDENTITY_INSERT TREATMENT ON
--GO

/******  INSERT STARTER DATA INTO TABLES ******/
INSERT INTO PATIENT
   VALUES(1, 'Name 1', 1112222, 'Emergency Contact 1', '10-Dec-2003', 1);
INSERT INTO PATIENT
   VALUES(2, 'Name 2', 1112222, 'Emergency Contact 2', '13-Dec-2003', 1);
INSERT INTO PATIENT
   VALUES(2, 'Name 3', 1112222, 'Emergency Contact 3', '14-Dec-2003', 2);
   
INSERT INTO PHYSICIAN
   VALUES(1, 'Doctor 1', 'specialization 1', 100000);
INSERT INTO PHYSICIAN
   VALUES(2, 'Doctor 2', 'specialization 2', 2000);
INSERT INTO PHYSICIAN
   VALUES(3, 'Doctor 3', 'specialization 3', 300000);
INSERT INTO PHYSICIAN
   VALUES(4, 'Doctor 4', 'specialization 4', 400000000);
INSERT INTO PHYSICIAN
   VALUES(5, 'Doctor 5', 'specialization 5', 5);
   
INSERT INTO TREATMENT
   VALUES(101, 1, 1, 'DOXYCYCLIN', '10-Dec-2003', 2);
INSERT INTO TREATMENT 
   VALUES(102, 1, 1, 'stop eating', '10-Dec-2003', 0);
INSERT INTO TREATMENT 
   VALUES(103, 2, 3, 'heart surgery', '15-Dec-2003', 0);
INSERT INTO TREATMENT 
   VALUES(104, 2, 2, 'heart medication', '15-Dec-2003', 5);
INSERT INTO TREATMENT 
   VALUES(105, 3, 1, 'anti-acids', '14-Dec-2003', 10);
INSERT INTO TREATMENT 
   VALUES(106, 1, 5, 'vallium', '116-Dec-2003', 3);

