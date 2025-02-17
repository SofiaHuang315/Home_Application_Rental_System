Create table Customer
(
    CustomerID Varchar(20) not null Primary Key,
    CustomerName Varchar(50),
    UserName Varchar(50),
    Password Varchar(20),
    Address Varchar(100),
    PhoneNumber Varchar(20)
);
Select * from Customer 
 
Create table Admin
(
    AdminID Varchar(20) not null Primary Key,
    AdminName Varchar(50),
    UserName Varchar(50),
    Password Varchar(20),
    Address Varchar(100),
    PhoneNumber Varchar(20),
    AdminPhoto Varchar(255)
);
 
Select * from Admin

Create table ApplianceType
(
    ApplianceTypeID Varchar(20) not null Primary Key,
    ApplianceType Varchar(50),
);
 
Select * from ApplianceType

Create table Appliances 
(
	ApplianceID Varchar(20) not null,
	ApplianceName Varchar(50),
	PowerUsage Varchar(50),
	TypicalUsage Varchar(50),
	EstimatedAnnualCosts int,
	Model Varchar(50),
	Dimension Varchar(50),
	Colour Varchar(50),
	EnergyConsumption Varchar(50), 
	MonthlyFees int, 
	AdminID Varchar(20),
	ApplianceTypeID Varchar(20),
	ApplianceImage Varchar(255),
	Quantity int,
	Primary Key (ApplianceID),
	Foreign Key (AdminID) References Admin(AdminID),
	Foreign Key (ApplianceTypeID) References ApplianceType(ApplianceTypeID)
);
Delete from Appliances
Drop table Appliances
Select * from Appliances

Create table Rental
(
    RentID Varchar(20) not null,
    CustomerID Varchar(20),
    RentDate Date,
    Months int,
    RentQuantity int,
    RentPrice int,
    TotalAmount int,
    RentStatus Varchar(30),
    Primary Key(RentID),
    Foreign Key(CustomerID) References Customer(CustomerID)
);
Drop table Rental
Select * from Rental
 
Create table RentalApplianceDetails
(
    RentID Varchar(20) not null,
    ApplianceID Varchar(20) not null,
    UnitPrice int,
    UnitQuantity int,
    UnitAmount int,
    Foreign Key(RentID) References Rental(RentID),
    Foreign Key(ApplianceID) References Appliances(ApplianceID),
    Primary Key(RentID, ApplianceID)
);

Drop Table RentalApplianceDetails
Select * from RentalApplianceDetails

Create View ViewAppliance
AS
(
Select a.ApplianceID, a.ApplianceName, a.PowerUsage, a.TypicalUsage, a.EstimatedAnnualCosts, a.Model, a.Dimension, a.Colour, a.MonthlyFees, at.ApplianceType
From Appliances a, ApplianceType at
Where a.ApplianceTypeID=at.ApplianceTypeID
)
Drop view ViewAppliance
Select * from ViewAppliance


Create View ViewRentAppliance
as
(
Select r.RentID, c.CustomerName, r.RentDate, r.Months,r.RentQuantity, r.RentPrice,r.TotalAmount,r.RentStatus
From Customer c, Rental r 
Where c.CustomerID=r.CustomerID
)

Select * from ViewRentAppliance

Create View ViewRentDetail
as
(
    Select rd.RentID, ap.ApplianceName, at.ApplianceType,
    rd.UnitPrice,rd.UnitQuantity,rd.UnitAmount
    From RentalApplianceDetails rd, Appliances ap, ApplianceType at
    Where ap.ApplianceID=rd.ApplianceID
    AND ap.ApplianceTypeID=at.ApplianceTypeID
)

Select * from ViewRentDetail
drop view ViewRentDetail