CREATE TABLE Owners (
    Id INT PRIMARY KEY IDENTITY,
    [Name] VARCHAR(50) NOT NULL,
    PhoneNumber VARCHAR(15) NOT NULL,
    [Address] VARCHAR(50)
)

CREATE TABLE AnimalTypes (
    Id INT PRIMARY KEY IDENTITY,
    AnimalType VARCHAR(30) NOT NULL
)

CREATE TABLE Cages (
    Id INT PRIMARY KEY IDENTITY,
    AnimalTypeId INT FOREIGN KEY REFERENCES AnimalTypes(Id) NOT NULL
)

CREATE TABLE Animals (
    Id INT PRIMARY KEY IDENTITY,
    [Name] VARCHAR(30) NOT NULL,
    BirthDate DATE NOT NULL,
    OwnerId INT FOREIGN KEY REFERENCES Owners(Id),
    AnimalTypeId INT FOREIGN KEY REFERENCES AnimalTypes(Id) NOT NULL
)

CREATE TABLE AnimalsCages (
    CageId INT FOREIGN KEY REFERENCES Cages(Id) NOT NULL,
    AnimalId INT FOREIGN KEY REFERENCES Animals(Id) NOT NULL,
    PRIMARY KEY (CageId, AnimalId)
)

CREATE TABLE VolunteersDepartments (
    Id INT PRIMARY KEY IDENTITY,
    DepartmentName VARCHAR(30) NOT NULL
)

CREATE TABLE Volunteers (
    Id INT PRIMARY KEY IDENTITY,
    [Name] VARCHAR(50) NOT NULL,
    PhoneNumber VARCHAR(15) NOT NULL,
    [Address] VARCHAR(50),
    AnimalId INT FOREIGN KEY REFERENCES Animals(Id),
    DepartmentId INT FOREIGN KEY REFERENCES VolunteersDepartments(Id) NOT NULL
)