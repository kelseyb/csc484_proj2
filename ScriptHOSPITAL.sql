/*********** EXAMPLE OF AN SQL SCRIPT FILE ************/
 
USE SALES /*well, we don't want to use sales, but. i don't know what we want to use.*/
GO

-- DROP TABLES
if exists (select * from sysobjects where id = object_id('PATIENT'))
  drop table PATIENT
if exists (select * from sysobjects where id = object_id('PHYSICIAN'))
  drop table PHYSICIAN
/*if exists (select * from sysobjects where id = object_id('TREATMENT'))
  drop table TREATMENT*/
if exists (select * from sysobjects where id = object_id('MEDICATION'))
  drop table MEDICATION
if exists (select * from sysobjects where id = object_id('LABS'))
  drop table LABS
if exists (select * from sysobjects where id = object_id('SPECIAL_DIET'))
  drop table SPECIAL_DIET
  
  /*possibly treatment and treatment details? hmmm*/
GO

/******  CREATE PATIENT TABLE ******/
CREATE TABLE PATIENT (
	PatientID bigint NOT NULL PRIMARY KEY,
	PatientName varchar (100) NOT NULL,
	PhoneNumber bigint NOT NULL,
	EmergencyContact varchar (100) NOT NULL,
	AdmittedDate datetime NOT NULL

	/*is this treating or admitting tho? 
	if we keep the admitting, then this is treating
	but
	we have a physid in treatment so
	what now
	get rid of it?
	
	at this point, this would be the admitting physician
	*/
	FOREIGN KEY (PhysicianID) REFERENCES PHYSICIAN(PhysicianID)
	
)
GO

/******  CREATE PHYSICIAN TABLE ******/
CREATE TABLE PHYSICIAN (
	PhysicianID bigint NOT NULL PRIMARY KEY,
	PhysicianName varchar (100) NOT NULL,
	Specialization varchar (100) NOT NULL,
	Salary bigint NOT NULL
	
	/* what else?
	salary?
	start date?
	*/
)
GO

/******  CREATE TREATMENT TABLE ******/
/*may have to split this up- wants medication, dosage, 
lab esams done and special diets
*/
/*
CREATE TABLE TREATMENT (
	PhysicianID bigint NOT NULL REFERENCES PHYSICIAN(PhysicianID),
	PatientID bigint NOT NULL REFERENCES PATIENT(PatientID),
	SpecialDiet varchar (100) NOT NULL,
	
	PRIMARY KEY (PhysicianID, PatientID)
)
GO*/

/*new possible treatment table (with treatment_detail
CREATE TABLE TREATMENT (
	TreatmentID bigint IDENTITY PRIMARY KEY,
	PatientID bigint NOT NULL ,
	TreatmentName varchar (100) NOT NULL,
	TreatmentDosage int, /*can be null if not a medicine*/
	DateTreated datetime NOT NULL , /*or prescribed*/
	
    FOREIGN KEY (PatientID) REFERENCES PATIENT(PatientID)
)
GO

CREATE TABLE TREATMENT_DETAIL (
	TreatmentID bigint NOT NULL REFERENCES TREATMENT(TreatmentID),
	PhysicianID bigint NOT NULL REFERENCES PHYSICIAN(PhysicianID),
/*orderdetail has a date here. not sure how to cope. */
	PRIMARY KEY (TreatmentID, PhysicianID)
)
GO
*/

CREATE TABLE MEDICATION (
	PhysicianID bigint NOT NULL REFERENCES PHYSICIAN(PhysicianID),
	PatientID bigint NOT NULL REFERENCES PATIENT(PatientID),
	MedicationName varchar (100) NOT NULL,
	Dosage int NOT NULL,
	
	PRIMARY KEY (PhysicianID, PatientID)
)
GO

CREATE TABLE LABS (
	PhysicianID bigint NOT NULL REFERENCES PHYSICIAN(PhysicianID),
	PatientID bigint NOT NULL REFERENCES PATIENT(PatientID),
	TreatmentID bigint NOT NULL,
	LabName varchar (100) NOT NULL,
	DateLabDone datetime NOT NULL,
	
	PRIMARY KEY (PhysicianID, PatientID)
)
GO

CREATE TABLE SPECIAL_DIET (
	PhysicianID bigint NOT NULL REFERENCES PHYSICIAN(PhysicianID),
	PatientID bigint NOT NULL REFERENCES PATIENT(PatientID),
	DietName varchar (100) NOT NULL,
	
	PRIMARY KEY (PhysicianID, PatientID)
)
GO

/*
/*do we need this??
oh. this is a waste of space.
*/
/******  CREATE ADMITTED TABLE ******/
CREATE TABLE ADMITTED (
	PhysicianID bigint NOT NULL REFERENCES PHYSICIAN(PhysicianID),
	PatientID bigint NOT NULL REFERENCES PATIENT(PatientID),
	AdmittedDate datetime NOT NULL,
	PRIMARY KEY (PhysicianID, PatientID)
)
GO
*/

/*
/******  CREATE PRODUCT TABLE  ******/
CREATE TABLE PRODUCT (
	ProductID bigint NOT NULL PRIMARY KEY,
	ProductName varchar (100) NOT NULL ,
	QuantityInStock int NOT NULL CHECK (QuantityInStock > 0),
	PricePerItem money NOT NULL
)
GO

/******  CREATE ORDER1 TABLE ******/
CREATE TABLE ORDER1 (
	OrderID bigint IDENTITY PRIMARY KEY,
	CustomerID bigint NOT NULL ,
	DateOrdered datetime NOT NULL ,
	ShipDate datetime NOT NULL ,
        FOREIGN KEY (CustomerID) REFERENCES CUSTOMER(CustomerID)
)
GO

/******  CREATE ORDERDETAIL TABLE ******/
CREATE TABLE ORDERDETAIL (
	OrderID bigint NOT NULL REFERENCES ORDER1(OrderID),
	ProductID bigint NOT NULL REFERENCES PRODUCT(ProductID),
	QuantityOrdered int NOT NULL ,
	HasShipped tinyint NOT NULL ,
	PRIMARY KEY (OrderID,ProductID)
)
GO
*/

/******  INSERT STARTER DATA INTO TABLES ******/

INSERT INTO PATIENT
   VALUES(1, 'Name 1', 1112222, 'Emergency Contact 1', '10-Dec-2003', 1);
   
INSERT INTO PHYSICIAN
   VALUES(1, 'Doctor 1', 'specialization 1', 100000);
   
INSERT INTO MEDICATION
   VALUES(1, 1, 'DOXYCYCLIN', 2);
   
INSERT INTO SPECIAL_DIET
	VALUES(1, 1, 'diabetic');
	
INSERT INTO LABS
	VALUES(1, 1, 'X-RAY', '11-Dec-2003'

/*INSERT INTO CUSTOMER
   VALUES(120, 'Name 1', 2200, 0, '10-Dec-2003');
INSERT INTO CUSTOMER
   VALUES(130, 'Name 2', 1800, 0, '21-Sep-2003');
INSERT INTO CUSTOMER
   VALUES(140, 'Name 1', 2000, 0, '02-Mar-2002');
INSERT INTO CUSTOMER
   VALUES(150, 'Name 1', 2500, 0, '09-Nov-2003');

INSERT INTO PRODUCT
   VALUES(200, 'Item 1', 5, 200.00);
INSERT INTO PRODUCT
   VALUES(210, 'Item 2', 10, 100.00);
INSERT INTO PRODUCT
   VALUES(220, 'Item 3', 8, 50.00);
INSERT INTO PRODUCT
   VALUES(230, 'Item 4', 20, 35.00);
INSERT INTO PRODUCT
   VALUES(240, 'Item 5', 12, 45.00);

INSERT INTO ORDER1
   VALUES(140, '3/20/2006', '01-Apr-2006');
INSERT INTO ORDER1
   VALUES(130, '9/18/2006', '22-Sep-2006');
INSERT INTO ORDER1
   VALUES(120, '09/15/2006', '20-Sep-2006');

INSERT INTO ORDERDETAIL
   VALUES(1, 210, 2, 1);
INSERT INTO ORDERDETAIL
   VALUES(1, 230, 1, 1);
INSERT INTO ORDERDETAIL
   VALUES(2, 200, 1, 0);
INSERT INTO ORDERDETAIL
   VALUES(2, 220, 3, 0);
INSERT INTO ORDERDETAIL
   VALUES(2, 240, 4, 0);
INSERT INTO ORDERDETAIL
   VALUES(3, 220, 2, 1);
INSERT INTO ORDERDETAIL
   VALUES(3, 230, 3, 0);*/

/***** END OF SCRIPT *****/
