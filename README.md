# EducationDetails
This is a Windows Forms application for adding student details, calculating their pending fees and generating a Crystal Report.

Minimum Software Requirements to run this .sln file:

Microsoft Windows XP

Microsoft Visual Studio 2010

SQL Server Management Studio (2005 or above)

Please rename the connection strings as per your requirements.

SQL Queries to create Master Tables:

CREATE TABLE eduCountry (CountryID int IDENTITY NOT NULL PRIMARY KEY, CountryName varchar(50));

CREATE TABLE eduState (StateID int IDENTITY NOT NULL PRIMARY KEY, CountryId int uniqueidentifier NOT NULL,
StateName varchar(50), constraint fk_eduState_eduCountry FOREIGN KEY (CountryId) references eduCountry(CountryID));

CREATE TABLE eduCity (CityID int IDENTITY NOT NULL PRIMARY KEY, StateID int uniqueidentifier NOT NULL,
CityName varchar(50), constraint fk_eduCity_eduState FOREIGN KEY (StateyId) references eduState(StateyId));

CREATE TABLE eduCollege (CollegeID int IDENTITY NOT NULL PRIMARY KEY, CityId int uniqueidentifier NOT NULL,
CollegeName varchar(50), constraint fk_eduCollegeName_eduCity FOREIGN KEY (CityId) references eduCity(CityId));

CREATE TABLE eduSchool (Schoolid int IDENTITY NOT NULL PRIMARY KEY, CityId int uniqueidentifier NOT NULL,
SchoolName varchar(50) NOT NULL, constraint fk_eduSchool_eduCity FOREIGN KEY (CityId) references eduCity(CityId));

SQL Queries to create StudentInforfation Table:

CREATE TABLE StudentInfo (StudentId int IDENTITY NOT NULL PRIMARY KEY, UserName varchar(50) NOT NULL, 
Password varchar(50) NOT NULL, Fname varchar(50) NOT NULL,SName varchar(50) NOT NULL, DadName varchar(50) NOT NULL,
MomName varchar(50) NOT NULL, DOB varchar(50) NOT NULL, Gender char(1) NOT NULL, MobNo numeric(18,0) NOT NULL, 
LandNo numeric(18,0) NOT NULL, cCountry varchar(50) NOT NULL, cState varchar(50) NOT NULL,cCity varchar(50) NOT NULL,
cAddress varchar(50) NOT NULL, pPincode numeric(18,0) NOT NULL, CourseName varchar(50) NOT NULL, 
TotalFees numeric(18,0) NOT NULL, ImgPath nvarchar(MAX) NOT NULL);

SQL Queries to create Stored Procedures:

CREATE PROCEDURE [dbo].[InsertCity]
	@cityName as varchar(30),
	@stateId as int
AS
BEGIN
	INSERT INTO eduCity (eduCity.CityName,StateID) values ( @cityName,@stateId);
END

CREATE PROCEDURE [dbo].[InsertCollege]
	 @CollegeName as varchar(30),
	 @cityId as int
AS
BEGIN
	INSERT INTO eduCollege (CityId, CollegeName) values ( @cityId, @CollegeName);
END 

CREATE PROCEDURE [dbo].[InsertCountry]
	@countryName as varchar(30)
AS
BEGIN
	INSERT INTO eduCountry (CountryName) values ( @countryName);
END 

CREATE PROCEDURE [dbo].[InsertSchool]
	 @SchoolName as varchar(30),
	 @cityId as int
AS
BEGIN
	INSERT INTO eduSchool (cityId, SchoolName) values ( @cityId, @SchoolName);
END 

CREATE PROCEDURE [dbo].[InsertState]
	-- Add the parameters for the stored procedure here
	 @StateName as varchar(30),
	 @countryId as int
AS
BEGIN
	INSERT INTO eduState (CountryId, StateName) values ( @countryId, @StateName);
END 

CREATE proc [dbo].[spStudentInfo]
@studentId int out,
@usname nvarchar(50),
@pwd nvarchar(50),
@fname nvarchar(50),
@sname nvarchar(50),
@dad nvarchar(50),
@mom nvarchar(50),
@dob nvarchar(50),
@gender nchar(2),
@mob numeric(18,0),
@land numeric(18,0),
@curCountry nvarchar(50),
@curState nvarchar(50),
@curCity nvarchar(50),
@curAddress nvarchar(50),
@curPincode numeric(18,0),
@perCountry nvarchar(50),
@perState nvarchar(50),
@perCity nvarchar(50),
@perAddress nvarchar(50),
@perPincode numeric(18,0),
@Course nvarchar(50),
@total numeric(18,0),
@img nvarchar(MAX)
AS
BEGIN
	insert into StudentInfo (UserName
      ,Password
      ,Fname
      ,Sname
      ,DadName
      ,MomName
      ,DOB
      ,Gender
      ,MobNo
      ,LandNo
      ,cCountry
      ,cState
      ,cCity
      ,cAddress
      ,cPincode
      ,pCountry
      ,pState
      ,pCity
      ,pAddress
      ,pPincode
      ,CourseName
      ,TotalFees
      ,ImgPath)
	  values(@usname,@pwd,@fname,@sname,@dad,@mom,@dob,@gender,@mob,@land,@curCountry,@curState,@curCity,
		@curAddress,@curPincode,@perCountry,@perState,@perCity,@perAddress,@perPincode,@Course,@total,
		@img)
		SELECT @studentId = SCOPE_IDENTITY()
END

CREATE proc [dbo].[updateStudentInfo]
@studentId int,
@usname nvarchar(50),
@pwd nvarchar(50),
@fname nvarchar(50),
@sname nvarchar(50),
@dad nvarchar(50),
@mom nvarchar(50),
@dob nvarchar(50),
@gender nchar(2),
@mob numeric(18,0),
@land numeric(18,0),
@curCountry nvarchar(50),
@curState nvarchar(50),
@curCity nvarchar(50),
@curAddress nvarchar(50),
@curPincode numeric(18,0),
@perCountry nvarchar(50),
@perState nvarchar(50),
@perCity nvarchar(50),
@perAddress nvarchar(50),
@perPincode numeric(18,0),
@Course nvarchar(50),
@total numeric(18,0)
AS
BEGIN
	update StudentInfo       
	set UserName = @usname,Password = @pwd,Fname = @fname,Sname = @sname,DadName = @dad,MomName= @mom,
	DOB = @dob,Gender = @gender,MobNo = @mob,LandNo = @land,cCountry = @curCountry,cState = @curState,
	cCity = @curCity,cAddress = @curAddress,cPincode = @curPincode,pCountry = @perCountry,
	pState = @perState,pCity = @perCity,pAddress = @perAddress,pPincode = @perPincode,
	CourseName = @Course,TotalFees = @total
	where StudentId = @studentId 
END

Bugs:
1. Crystal report code is still not usable.
