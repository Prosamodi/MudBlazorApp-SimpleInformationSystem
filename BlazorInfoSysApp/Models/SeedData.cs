using Microsoft.EntityFrameworkCore;

namespace BlazorInfoSysApp.Models
{

    public static class SeedData
    {
        public static void SeedDatabase(DataContext context)
        {
            context.Database.Migrate();
            if (context.People.Count() == 0)
            {
                context.People.AddRange(
                    new Person
                    {
                        Firstname = "Sammy",
                        Middlename = "Vicente",
                        Lastname = "Odi",
                        Birthday = new DateTime(1992, 05, 12),
                        Age = 23,
                        Gender = "Male",
                        Email = "odisammyv@gmail.com",
                        PhoneNumber = "0960 469 9493",
                        Address = "Phase 2 Package 2 Block 40 Lot 30 Bagong Silang",
                        Barangay = "Barangay 176",
                        City = "Caloocan",
                        ZIP = "1428",
                        Region = "National Capital Region",
                        WorkTitle = "Web Developer",
                        CivilStatus = "Single",
                        Province = "Catanduanes",
                        UpdatedAt = DateTime.UtcNow
                    },
                    new Person
                    {
                        Firstname = "Catalina",
                        Middlename = "Odi",
                        Lastname = "Mislang",
                        Birthday = new DateTime(1977, 02, 19),
                        Age = 47,
                        Gender = "Female",
                        Email = "catalinamislang@gmail.com",
                        PhoneNumber = "0960 299 7891",
                        Address = "Phase 2 Package 2 Block 40 Lot 30 Bagong Silang",
                        Barangay = "Barangay 176",
                        City = "Caloocan",
                        ZIP = "1428",
                        Region = "National Capital Region",
                        WorkTitle = "Teacher",
                        CivilStatus = "Married",
                        Province = "Catanduanes",
                        UpdatedAt = DateTime.UtcNow
                    },
                    new Person
                    {
                        Firstname = "Liza",
                        Middlename = "Vicente",
                        Lastname = "Odi",
                        Birthday = new DateTime(1979, 05, 05),
                        Age = 45,
                        Gender = "Female",
                        Email = "lizaodi@gmail.com",
                        PhoneNumber = "0960 299 7891",
                        Address = "Phase 2 Package 2 Block 40 Lot 30 Bagong Silang",
                        Barangay = "Barangay 176",
                        City = "Caloocan",
                        ZIP = "1428",
                        Region = "National Capital Region",
                        WorkTitle = "Midwife",
                        CivilStatus = "Single",
                        Province = "Catanduanes",
                        UpdatedAt = DateTime.UtcNow
                    },
                    new Person
                    {
                        Firstname = "Mariane",
                        Middlename = "Odi",
                        Lastname = "Palagar",
                        Birthday = new DateTime(1982, 05, 04),
                        Age = 42,
                        Gender = "Female",
                        Email = "marianepalagar@gmail.com",
                        PhoneNumber = "0960 299 7891",
                        Address = "Phase 2 Package 2 Block 40 Lot 30 Bagong Silang",
                        Barangay = "Barangay 176",
                        City = "Caloocan",
                        ZIP = "1428",
                        Region = "National Capital Region",
                        WorkTitle = "Teacher",
                        CivilStatus = "Married",
                        Province = "Catanduanes",
                        UpdatedAt = DateTime.UtcNow
                    },
                    new Person
                    {
                        Firstname = "Melchora",
                        Middlename = "Vicente",
                        Lastname = "Odi",
                        Birthday = new DateTime(1984, 01, 06),
                        Age = 40,
                        Gender = "Female",
                        Email = "melchoraodi@gmail.com",
                        PhoneNumber = "0960 299 7891",
                        Address = "Phase 2 Package 2 Block 40 Lot 30 Bagong Silang",
                        Barangay = "Barangay 176",
                        City = "Caloocan",
                        ZIP = "1428",
                        Region = "National Capital Region",
                        WorkTitle = "Teacher",
                        CivilStatus = "Single",
                        Province = "Catanduanes",
                        UpdatedAt = DateTime.UtcNow
                    },
                    new Person
                    {
                        Firstname = "Enrico",
                        Middlename = "Vicente",
                        Lastname = "Odi",
                        Birthday = new DateTime(1987, 01, 03),
                        Age = 37,
                        Gender = "Male",
                        Email = "enricoodi@gmail.com",
                        PhoneNumber = "0960 919 299 7891",
                        Address = "Phase 2 Package 2 Block 40 Lot 30 Bagong Silang",
                        Barangay = "Barangay 176",
                        City = "Caloocan",
                        ZIP = "1428",
                        Region = "National Capital Region",
                        WorkTitle = "Driver",
                        CivilStatus = "Single",
                        Province = "Catanduanes",
                        UpdatedAt = DateTime.UtcNow

                    },
                    new Person
                    {
                        Firstname = "Angelica",
                        Middlename = "Vicente",
                        Lastname = "Odi",
                        Birthday = new DateTime(1995, 02, 08),
                        Age = 29,
                        Gender = "Female",
                        Email = "angelicaodi@gmail.com",
                        PhoneNumber = "0960 299 7891",
                        Address = "Phase 2 Package 2 Block 40 Lot 30 Bagong Silang",
                        Barangay = "Barangay 176",
                        City = "Caloocan",
                        ZIP = "1428",
                        Region = "National Capital Region",
                        WorkTitle = "Technician",
                        CivilStatus = "Single",
                        Province = "Catanduanes",
                        UpdatedAt = DateTime.UtcNow
                    },
                    new Person
                    {
                        Firstname = "Salvador",
                        Middlename = "Olfindo",
                        Lastname = "Odi",
                        Birthday = new DateTime(1950, 09, 08),
                        Age = 74,
                        Gender = "Male",
                        Email = "salvadorodi@gmail.com",
                        PhoneNumber = "0960 299 7891",
                        Address = "Phase 2 Package 2 Block 40 Lot 30 Bagong Silang",
                        Barangay = "Barangay 176",
                        City = "Caloocan",
                        ZIP = "1428",
                        Region = "National Capital Region",
                        WorkTitle = "Steel Fabricator",
                        CivilStatus = "Married",
                        Province = "Catanduanes",
                        UpdatedAt = DateTime.UtcNow
                    },
                    new Person
                    {
                        Firstname = "Maria",
                        Middlename = "Vicente",
                        Lastname = "Odi",
                        Birthday = new DateTime(1952, 04, 22),
                        Age = 72,
                        Gender = "Female",
                        Email = "mariaodi@gmail.com",
                        PhoneNumber = "0960 299 7891",
                        Address = "Phase 2 Package 2 Block 40 Lot 30 Bagong Silang",
                        Barangay = "Barangay 176",
                        City = "Caloocan",
                        ZIP = "1428",
                        Region = "National Capital Region",
                        WorkTitle = "Loveable Mother",
                        CivilStatus = "Married",
                        Province = "Catanduanes",
                        UpdatedAt = DateTime.UtcNow
                    },
                    new Person
                    {
                        Firstname = "Jeffry",
                        Middlename = "Maximo",
                        Lastname = "Palagar",
                        Birthday = new DateTime(1980, 04, 04),
                        Age = 44,
                        Gender = "Male",
                        Email = "jeffrypalagar@gmail.com",
                        PhoneNumber = "0960 299 7891",
                        Address = "Phase 2 Package 2 Block 40 Lot 30 Bagong Silang",
                        Barangay = "Barangay 176",
                        City = "Caloocan",
                        ZIP = "1428",
                        Region = "National Capital Region",
                        WorkTitle = "Teacher",
                        CivilStatus = "Married",
                        Province = "Catanduanes",
                        UpdatedAt = DateTime.UtcNow
                    },
                    new Person
                    {
                        Firstname = "Rizza",
                        Middlename = "Odi",
                        Lastname = "Escueta",
                        Birthday = new DateTime(1982, 05, 04),
                        Age = 42,
                        Gender = "Female",
                        Email = "marianepalagar@gmail.com",
                        PhoneNumber = "0960 299 7891",
                        Address = "Phase 2 Package 2 Block 40 Lot 30 Bagong Silang",
                        Barangay = "Barangay 176",
                        City = "Caloocan",
                        ZIP = "1428",
                        Region = "National Capital Region",
                        WorkTitle = "Office Assistant",
                        CivilStatus = "Single",
                        Province = "Catanduanes",
                        UpdatedAt = DateTime.UtcNow
                    },
                    new Person
                    {
                        Firstname = "Maria Leona",
                        Middlename = "Odi",
                        Lastname = "Palagar",
                        Birthday = new DateTime(2011, 04, 14),
                        Age = 13,
                        Gender = "Female",
                        Email = "marialeonapalagar@gmail.com",
                        PhoneNumber = "0960 299 7891",
                        Address = "Phase 2 Package 2 Block 40 Lot 30 Bagong Silang",
                        Barangay = "Barangay 176",
                        City = "Caloocan",
                        ZIP = "1428",
                        Region = "National Capital Region",
                        WorkTitle = "Lawyer",
                        CivilStatus = "Single",
                        Province = "Catanduanes",
                        UpdatedAt = DateTime.UtcNow
                    },
                    new Person
                    {
                        Firstname = "Brandon Victor",
                        Middlename = "Odi",
                        Lastname = "Palagar",
                        Birthday = new DateTime(2015, 09, 01),
                        Age = 9,
                        Gender = "Male",
                        Email = "brandonvictorpalagar@gmail.com",
                        PhoneNumber = "0960 299 7891",
                        Address = "Phase 2 Package 2 Block 40 Lot 30 Bagong Silang",
                        Barangay = "Barangay 176",
                        City = "Caloocan",
                        ZIP = "1428",
                        Region = "National Capital Region",
                        WorkTitle = "Jet Pilot",
                        CivilStatus = "Single",
                        Province = "Catanduanes",
                        UpdatedAt = DateTime.UtcNow
                    },
                    new Person
                    {
                        Firstname = "Cathleen Earnest",
                        Middlename = "Escueta",
                        Lastname = "Odi",
                        Birthday = new DateTime(2018, 03, 01),
                        Age = 6,
                        Gender = "Female",
                        Email = "cathleenearnestodi@gmail.com",
                        PhoneNumber = "0960 299 7891",
                        Address = "Phase 2 Package 2 Block 40 Lot 30 Bagong Silang",
                        Barangay = "Barangay 176",
                        City = "Caloocan",
                        ZIP = "1428",
                        Region = "National Capital Region",
                        WorkTitle = "Doctor",
                        CivilStatus = "Single",
                        Province = "Catanduanes",
                        UpdatedAt = DateTime.UtcNow
                    },
                    new Person
                    {
                        Firstname = "Heavenly Aedan",
                        Middlename = "Escueta",
                        Lastname = "Odi",
                        Birthday = new DateTime(2020, 05, 20),
                        Age = 4,
                        Gender = "Male",
                        Email = "marianepalagar@gmail.com",
                        PhoneNumber = "0960 299 7891",
                        Address = "Phase 2 Package 2 Block 40 Lot 30 Bagong Silang",
                        Barangay = "Barangay 176",
                        City = "Caloocan",
                        ZIP = "1428",
                        Region = "National Capital Region",
                        WorkTitle = "Doctor",
                        CivilStatus = "Single",
                        Province = "Catanduanes",
                        UpdatedAt = DateTime.UtcNow
                    },
                    new Person
                    {
                        Firstname = "Ernesto",
                        Middlename = "Ramos",
                        Lastname = "Mislang",
                        Birthday = new DateTime(1977, 05, 13),
                        Age = 47,
                        Gender = "Male",
                        Email = "ernestomislang@gmail.com",
                        PhoneNumber = "0960 299 7891",
                        Address = "Phase 2 Package 2 Block 40 Lot 30 Bagong Silang",
                        Barangay = "Barangay 176",
                        City = "Caloocan",
                        ZIP = "1428",
                        Region = "National Capital Region",
                        WorkTitle = "Master Electrician",
                        CivilStatus = "Married",
                        Province = "Catanduanes",
                        UpdatedAt = DateTime.UtcNow
                    }
                );
                context.SaveChanges();
            }
        }
    }
}