using Microsoft.EntityFrameworkCore;
using Troshka.Blazor.Domain.Entities;
using Troshka.Blazor.Domain.Entities.Car;

namespace Troshka.Blazor.Infrastructure.Data
{
    public class TroshkaDbContext : DbContext
    {
        public DbSet<CategoryEntity> Category { get; set; }
        public DbSet<CarBrandEntity> CarBrands { get; set; }

        public TroshkaDbContext(DbContextOptions<TroshkaDbContext> options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            #region Categories
            modelBuilder
                .Entity<CategoryEntity>()
                .ToTable("Categories", schema: SchemaNames.Troshka);

            modelBuilder
                .Entity<CategoryEntity>()
                .HasData(
                    new CategoryEntity { Id = "0Uun56AGjKNM2f07qMBS", Name = "Cars" },
                    new CategoryEntity { Id = "AhHuT41lRddLH1wachlm", Name = "Buses" },
                    new CategoryEntity { Id = "DARdvjHJcTyGCYGekfIn", Name = "Motorcycles" },
                    new CategoryEntity { Id = "ExCL3LNxUqXNC8LFF8rL", Name = "Trucks" },
                    new CategoryEntity { Id = "GFF7R0xsM4muSxEG8k0J", Name = "Caravans" },
                    new CategoryEntity { Id = "lnm5mTuNV56JTQQYWPRe", Name = "Boats" },
                    new CategoryEntity { Id = "NUSX1N5R2xUS9WfTo3lp", Name = "Construction" },
                    new CategoryEntity { Id = "poo2JeVEhMn8wJz0KJdR", Name = "Agriciltural" }
                );
            #endregion Categories

            #region Cars
            modelBuilder
            .Entity<CarBrandEntity>()
            .ToTable("Brands", schema: SchemaNames.Cars);

            modelBuilder
                .Entity<CarBrandEntity>()
                .HasData(
                    new CarBrandEntity { Id = "06MxFkB3ArFfVraVWN1u", Name = "AC" },
                    new CarBrandEntity { Id = "0SlIJFKD3VdaMAEnxfTT", Name = "Abarth" },
                    new CarBrandEntity { Id = "2FEzeyYHYe3zlhjMeaEF", Name = "Acura" },
                    new CarBrandEntity { Id = "2SBENlnqR76XRNAjbAs3", Name = "Aixam" },
                    new CarBrandEntity { Id = "2VS5yLgAuj7VmYeRVxTD", Name = "Alfa Romeo" },
                    new CarBrandEntity { Id = "2xSRLgR4QgzYhDLjfgAM", Name = "Alpina" },
                    new CarBrandEntity { Id = "3qGrKAnyJ2rmHlevXb8c", Name = "Aro" },
                    new CarBrandEntity { Id = "3yTpJND7nxjtqoDcuc5M", Name = "Asia" },
                    new CarBrandEntity { Id = "470SJrcKER8YaPHSS0br", Name = "Aston Martin" },
                    new CarBrandEntity { Id = "48xSUCHrRIfABkLmGHxD", Name = "Audi" },
                    new CarBrandEntity { Id = "5aFWwvagmpfBWQlHxU5M", Name = "Austin" },
                    new CarBrandEntity { Id = "5kDhCqXf6JTAIvz61oEz", Name = "BMW" },
                    new CarBrandEntity { Id = "5TgVdpBPF4SsQWVFP08j", Name = "Bentley" },
                    new CarBrandEntity { Id = "65B72rCez5bGWR7Po3Ny", Name = "Berliner" },
                    new CarBrandEntity { Id = "6mI4J3fGUdG5KvEHYjqL", Name = "Bertone" },
                    new CarBrandEntity { Id = "7ReFhJXxyx7pAkvlW1eS", Name = "Borgward" },
                    new CarBrandEntity { Id = "8mIlNn2498yIC72vgKBK", Name = "Brilliance" },
                    new CarBrandEntity { Id = "9NRn3UNnrPnf2yJoGIBH", Name = "Bugatti" },
                    new CarBrandEntity { Id = "aPIB6410rSAP3jxueo2Y", Name = "Buick" },
                    new CarBrandEntity { Id = "axxx6410rzzz3jxueox5", Name = "BYD" },
                    new CarBrandEntity { Id = "ATbb9NezfDxSdpBXdqd6", Name = "Cadillac" },
                    new CarBrandEntity { Id = "B42TXsELwNJNBewRvcu5", Name = "Chery" },
                    new CarBrandEntity { Id = "BESQA89ghmpmxnMv6lb4", Name = "Chevrolet" },
                    new CarBrandEntity { Id = "bshsdfzU1lNaPe58k9Io", Name = "Chrysler" },
                    new CarBrandEntity { Id = "bXGDbcoVlUUFaUAeuBhU", Name = "Citroen" },
                    new CarBrandEntity { Id = "bymbQs0TabKzPsrN3TlL", Name = "Corvette" },
                    new CarBrandEntity { Id = "CDKhu32A8uPkeWM4eblC", Name = "Cupra" },
                    new CarBrandEntity { Id = "cjnwEk8Wle037jtonYsj", Name = "DONGFENG" },
                    new CarBrandEntity { Id = "cYgoBzV1QqkgGALBMqxE", Name = "DS" },
                    new CarBrandEntity { Id = "cYlq5o6z4W9RcnLLB6zq", Name = "Dacia" },
                    new CarBrandEntity { Id = "D67BxpjC6stcD4YYGmdn", Name = "Daewoo" },
                    new CarBrandEntity { Id = "D6a4Vo3VE2WzDdgA5AFo", Name = "Daihatsu" },
                    new CarBrandEntity { Id = "d6V8Py7xGhHTTVvS02QR", Name = "Daimler" },
                    new CarBrandEntity { Id = "Dfej8VedBqRvW5SVCeo3", Name = "Datsun" },
                    new CarBrandEntity { Id = "dksqVUhgDuHJ9KJ2uqyP", Name = "Dkw" },
                    new CarBrandEntity { Id = "DsQDYqGhCx8KL7zF4UFK", Name = "Dodge" },
                    new CarBrandEntity { Id = "DumA309cvKSKLalqcW6h", Name = "Dr" },
                    new CarBrandEntity { Id = "DV94kh1MyMbGW3P4aac5", Name = "Eagle" },
                    new CarBrandEntity { Id = "e7NrNKeWFc73uCAkz1Ar", Name = "FSO" },
                    new CarBrandEntity { Id = "eF1lrB1EP63Y0DablBJF", Name = "Ferrari" },
                    new CarBrandEntity { Id = "EMczl7VAvCRwT3kAz4In", Name = "Fiat" },
                    new CarBrandEntity { Id = "emn3h8NrhdSz7ojPBV2H", Name = "Ford" },
                    new CarBrandEntity { Id = "etMtb4JLm7eB90mlnd72", Name = "GOUPIL" },
                    new CarBrandEntity { Id = "eUMYrz00U0nQH5KTc7uR", Name = "Gaz" },
                    new CarBrandEntity { Id = "fAVrUUNVKFbMuNlP7oUW", Name = "Geely" },
                    new CarBrandEntity { Id = "FcCNt3RVlzMFl9Jtw38m", Name = "Genesis" },
                    new CarBrandEntity { Id = "Fjw2xBL9BqCaQBzxcxDI", Name = "Geo" },
                    new CarBrandEntity { Id = "FtX2HosXUQDnvSScsyP8", Name = "GMC" },
                    new CarBrandEntity { Id = "FXHe5SU6zyIfYHPGygNC", Name = "Gonow" },
                    new CarBrandEntity { Id = "GBnMMAvdjskIFpKTYLb1", Name = "Great Wall" },
                    new CarBrandEntity { Id = "ghyFhm7jzcjYDrjMVLs1", Name = "Haval" },
                    new CarBrandEntity { Id = "gXuBjVjveGKf3R9Kc9vE", Name = "Heinkel" },
                    new CarBrandEntity { Id = "h6Bfvk5LdFwXv9QzKLxU", Name = "Hillman" },
                    new CarBrandEntity { Id = "hajLAGmn9WWXQco4CXw1", Name = "Honda" },
                    new CarBrandEntity { Id = "Hc1zhgoBCF1639Rp1PkY", Name = "Hummer" },
                    new CarBrandEntity { Id = "HhvYG9GBNEg7RhQBIjtY", Name = "Hyundai" },
                    new CarBrandEntity { Id = "HKjqbIm3EQ96YdfpakFI", Name = "Ifa" },
                    new CarBrandEntity { Id = "HrERVHUdBMrdUrgLsvuT", Name = "Infiniti" },
                    new CarBrandEntity { Id = "hy7DsFSFE0ugKvGj8Hfk", Name = "Innocenti" },
                    new CarBrandEntity { Id = "IIqtbBpQcKHy7TVA10Nl", Name = "Isuzu" },
                    new CarBrandEntity { Id = "IR6qs66ukTVnB4w0NIFq", Name = "Iveco" },
                    new CarBrandEntity { Id = "j0N3jEL5HfQ9Ve0KVNUl", Name = "JAC" },
                    new CarBrandEntity { Id = "J3wnurM4CgKVkRFfRvHs", Name = "JAS" },
                    new CarBrandEntity { Id = "JqgJmqpSsWvQ7b60GLvq", Name = "Jaguar" },
                    new CarBrandEntity { Id = "jyCumAseWnFjQjPzn3kQ", Name = "Jeep" },
                    new CarBrandEntity { Id = "k4Lylg5nrM6Vt1MrWfxS", Name = "Jpx" },
                    new CarBrandEntity { Id = "KCEkkBQL72L0jmEutbgl", Name = "Kia" },
                    new CarBrandEntity { Id = "kF0x9WcUJs7aHYtoKzWY", Name = "Lada" },
                    new CarBrandEntity { Id = "KQMma7dRwtXlcym9oSWC", Name = "Laforza" },
                    new CarBrandEntity { Id = "KRmmVEwPAtzSzJQgD6HY", Name = "Lamborghini" },
                    new CarBrandEntity { Id = "KvyHwQN3QMrXmgbsvne9", Name = "Lancia" },
                    new CarBrandEntity { Id = "kXULxNaVDJWKs2ACmH5C", Name = "Land Rover" },
                    new CarBrandEntity { Id = "l5Xv7WgEwDFBEEnFG9uC", Name = "Landwind" },
                    new CarBrandEntity { Id = "laJM8lrsRY8D0eRYypqk", Name = "Lexus" },
                    new CarBrandEntity { Id = "LcuKvSewzBSW3KEJdLIa", Name = "Lifan" },
                    new CarBrandEntity { Id = "lEVEcrE9FIVtGbtFarHV", Name = "Lincoln" },
                    new CarBrandEntity { Id = "lgRSEHsdarS0gC4osQWQ", Name = "Lotus" },
                    new CarBrandEntity { Id = "Lxge9Bn07u7pWE0RqbwJ", Name = "MG" },
                    new CarBrandEntity { Id = "m5L90Q8l2fTcbPyeA3GF", Name = "Mahindra" },
                    new CarBrandEntity { Id = "mEjXfYc5wzIHYnGGpCbE", Name = "Maserati" },
                    new CarBrandEntity { Id = "MlFe1uw8xqqhdAUnqcHd", Name = "Matra" },
                    new CarBrandEntity { Id = "MvMqrrJaUbAAVIvJHQcu", Name = "Maybach" },
                    new CarBrandEntity { Id = "MX3aL9JN6gD0F4KRl0Nq", Name = "Mazda" },
                    new CarBrandEntity { Id = "n1jg2wtcteSRvhvMGm4n", Name = "McLaren" },
                    new CarBrandEntity { Id = "nDxKpo5IAKk62ekEBbNS", Name = "Mercedes-Benz" },
                    new CarBrandEntity { Id = "nm2AJSoa0dWnayDNBRnh", Name = "Mercury" },
                    new CarBrandEntity { Id = "nsITvMBs2Ujtv8rQ0KJM", Name = "Microcar" },
                    new CarBrandEntity { Id = "nul5YjFdxToWeg1GrlCX", Name = "Mini" },
                    new CarBrandEntity { Id = "nWD6UJdXnV7cjq8tP6R8", Name = "Mitsubishi" },
                    new CarBrandEntity { Id = "oyETMjvBlpVLEDFlVADI", Name = "Morgan" },
                    new CarBrandEntity { Id = "p4hD4RsKIPD68JMtt4N2", Name = "Moskvich" },
                    new CarBrandEntity { Id = "p6Wbw5sW2Fj67lvp482v", Name = "Nissan" },
                    new CarBrandEntity { Id = "zzzbw5sz2hj27fvp4x2v", Name = "NIO" },
                    new CarBrandEntity { Id = "pjQ5tv7x5L1UYaKzhokc", Name = "Oldsmobile" },
                    new CarBrandEntity { Id = "PpQFVF4cAQlfX3BppjFB", Name = "Opel" },
                    new CarBrandEntity { Id = "PsbTIAKWHCVgruG7IgRE", Name = "Perodua" },
                    new CarBrandEntity { Id = "pTCUtnhqCmkJALgYU8NY", Name = "Peugeot" },
                    new CarBrandEntity { Id = "Q6kJ5uDgBmklCCBwofrx", Name = "Pgo" },
                    new CarBrandEntity { Id = "QExc6n8HRxp39gGTKXSt", Name = "Plymouth" },
                    new CarBrandEntity { Id = "qnkV2dT7G6arP780Dwxs", Name = "Polestar" },
                    new CarBrandEntity { Id = "QojugShL0F4QRXbwv1r3", Name = "Polonez" },
                    new CarBrandEntity { Id = "QS0jwSg5owyS3XS5xnbY", Name = "Pontiac" },
                    new CarBrandEntity { Id = "R0e7DzoQBFL5UIyTpqDP", Name = "Porsche" },
                    new CarBrandEntity { Id = "R9BIHlzCwb67GPT89e7F", Name = "Proton" },
                    new CarBrandEntity { Id = "RgqbbBCJaJLWTlu87M9R", Name = "Qoros" },
                    new CarBrandEntity { Id = "RRr4RDrnqyqmT3ehdy6Q", Name = "Renault" },
                    new CarBrandEntity { Id = "RuSMmRIATbwWRYSkgIrH", Name = "Rieju" },
                    new CarBrandEntity { Id = "rYJp3Jg61wKdUqFGSAp3", Name = "Rolls-Royce" },
                    new CarBrandEntity { Id = "sAKTDDgl9EDeyYnG77R8", Name = "Rover" },
                    new CarBrandEntity { Id = "SGKURGhEbYHIdqkxpDJh", Name = "SECMA" },
                    new CarBrandEntity { Id = "Sn4CRrl6hfVTTra5B0pd", Name = "SH auto" },
                    new CarBrandEntity { Id = "sQ5C4f7H60rzJLhMA0T5", Name = "Saab" },
                    new CarBrandEntity { Id = "sSh78RpjbHGvjL43TzMl", Name = "Samand" },
                    new CarBrandEntity { Id = "Sw3e46nyzgd7zmMPVG4r", Name = "Santana" },
                    new CarBrandEntity { Id = "sx9Vqv3yxRnX4SGwQa4y", Name = "Saturn" },
                    new CarBrandEntity { Id = "T8karRTfSTcM29oupBnt", Name = "Scion" },
                    new CarBrandEntity { Id = "t9gPoXWQAlKYkzxc7EaK", Name = "Seat" },
                    new CarBrandEntity { Id = "TjjXJlSeru5Ccm3G2Vet", Name = "Shatenet" },
                    new CarBrandEntity { Id = "TJTAqICS7fjRu8I4afxm", Name = "Shuanghuan" },
                    new CarBrandEntity { Id = "Tuaz0kuNQvU5jsy459u2", Name = "Simca" },
                    new CarBrandEntity { Id = "TXVRNj5SbqClTvNfEI8c", Name = "Skoda" },
                    new CarBrandEntity { Id = "u3lzgWdKo9KaByo34lmN", Name = "Smart" },
                    new CarBrandEntity { Id = "UG6N8tBL4hpBPkjX12Bh", Name = "SsangYong" },
                    new CarBrandEntity { Id = "ulCdKx22IbD50hbfYtIE", Name = "Subaru" },
                    new CarBrandEntity { Id = "UpE1pLHfAgAQDHEVWdAb", Name = "Suzuki" },
                    new CarBrandEntity { Id = "UpsGGKBQ2fXfNQBgABoF", Name = "Talbot" },
                    new CarBrandEntity { Id = "v1Q2gNvx2B1YX6h2w0TR", Name = "Tata" },
                    new CarBrandEntity { Id = "v4vruTNk6WkdcxN3fFA0", Name = "Tavria" },
                    new CarBrandEntity { Id = "V9HWmNFfpUS2Y5eLqrct", Name = "Tazzari" },
                    new CarBrandEntity { Id = "vMFor3Ks1QECjDpWHUqW", Name = "Tempo" },
                    new CarBrandEntity { Id = "vYf86TFDqUkh9RcEN9VN", Name = "Terberg" },
                    new CarBrandEntity { Id = "W5TnArCA9xCEodsTpDHG", Name = "Tesla" },
                    new CarBrandEntity { Id = "wC0Q8eUqQLkE6cpVwHgu", Name = "Tofas" },
                    new CarBrandEntity { Id = "wDseIgWSpqkLesX2ftwn", Name = "Toyota" },
                    new CarBrandEntity { Id = "whPfE6p1LaKgaGTWoNqj", Name = "Trabant" },
                    new CarBrandEntity { Id = "wMQSzkfJzJhYwfV22Ew6", Name = "Triumph" },
                    new CarBrandEntity { Id = "wwSqJWvMPuau2LBxW24w", Name = "Uaz" },
                    new CarBrandEntity { Id = "XECbl6phGcsYXQWHwrT7", Name = "VROMOS" },
                    new CarBrandEntity { Id = "xHqKd4nN6cMLEAaL4zdp", Name = "VW" },
                    new CarBrandEntity { Id = "XQ0Nk2N0zDYDydY9CEpC", Name = "Volga" },
                    new CarBrandEntity { Id = "xqP1xuan2MoXnMkwolM7", Name = "Volvo" },
                    new CarBrandEntity { Id = "Xsx7AcUNguMUYwC2eInr", Name = "Warszawa" },
                    new CarBrandEntity { Id = "XW7Xpw80z3VgX82egcWN", Name = "Wartburg" },
                    new CarBrandEntity { Id = "Xz43eo1VM5H41uNJ9x28", Name = "Wiesmann" },
                    new CarBrandEntity { Id = "yjnmBGS0tfeUY6wppqlL", Name = "Xinkai" },
                    new CarBrandEntity { Id = "YK3JYVEmHcskgB4f1s9M", Name = "Xinshun" },
                    new CarBrandEntity { Id = "YK3zzVEmH55kg41f1s2M", Name = "Xpeng" },
                    new CarBrandEntity { Id = "yL0kvEf81nf8Sd7CGQys", Name = "Yogomo" },
                    new CarBrandEntity { Id = "YSHfWTR5rJ8vCR2S95xp", Name = "Zastava" },
                    new CarBrandEntity { Id = "YUWNuWGy76j0cK9LWTP8", Name = "Zaz" },
                    new CarBrandEntity { Id = "zlaX6newWoQPagELHC4J", Name = "Other" },
                    new CarBrandEntity { Id = "zmtbQwqcCyHjrSKk77Se", Name = "Победа" },
                    new CarBrandEntity { Id = "zpPwsvLWKJ4CmjHmU1ES", Name = "София" },
                    new CarBrandEntity { Id = "zvQcGcl1nR7SpAfIMvxF", Name = "Чайка" }
                );
            #endregion Cars
        }

        private static class SchemaNames
        {
            public const string Troshka = $"{nameof(Troshka)}";
            public const string Cars = $"{nameof(Cars)}";
        }
    }
}