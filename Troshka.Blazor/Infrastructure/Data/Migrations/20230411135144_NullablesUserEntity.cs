using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Troshka.Blazor.Infrastructure.Data.Migrations
{
    /// <inheritdoc />
    public partial class NullablesUserEntity : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CarOffers_UserComments_AuthorId",
                schema: "Cars",
                table: "CarOffers");

            migrationBuilder.DropForeignKey(
                name: "FK_UserComments_UserComments_AuthorId",
                table: "UserComments");

            migrationBuilder.DropForeignKey(
                name: "FK_UserComments_UserComments_RecipientId",
                table: "UserComments");

            migrationBuilder.DropPrimaryKey(
                name: "PK_UserComments",
                schema: "Troshka",
                table: "UserComments");

            migrationBuilder.DeleteData(
                schema: "Troshka",
                table: "Currencies",
                keyColumn: "Id",
                keyValue: "7rTgBav88Ef6JWaphCMx");

            migrationBuilder.DeleteData(
                schema: "Troshka",
                table: "Currencies",
                keyColumn: "Id",
                keyValue: "S7pXo6rn1AFBvQ0mArI3");

            migrationBuilder.DeleteData(
                schema: "Troshka",
                table: "Currencies",
                keyColumn: "Id",
                keyValue: "V6yIzQ7lt8QV6b7TUb0m");

            migrationBuilder.DeleteData(
                schema: "Troshka",
                table: "Engines",
                keyColumn: "Id",
                keyValue: "3wyflVbGIz37cAs6aDVK");

            migrationBuilder.DeleteData(
                schema: "Troshka",
                table: "Engines",
                keyColumn: "Id",
                keyValue: "65NKlTJ3zmRz5XvEMAWQ");

            migrationBuilder.DeleteData(
                schema: "Troshka",
                table: "Engines",
                keyColumn: "Id",
                keyValue: "8Mf3vIu20SHalXvxPDf7");

            migrationBuilder.DeleteData(
                schema: "Troshka",
                table: "Engines",
                keyColumn: "Id",
                keyValue: "MfwSv1JXDeRac9UT2RFn");

            migrationBuilder.DeleteData(
                schema: "Troshka",
                table: "Engines",
                keyColumn: "Id",
                keyValue: "So8SFMu4XtALoluQncWW");

            migrationBuilder.DeleteData(
                schema: "Troshka",
                table: "EuroStandards",
                keyColumn: "Id",
                keyValue: "45EWKLIMt3BShtG3AQTa");

            migrationBuilder.DeleteData(
                schema: "Troshka",
                table: "EuroStandards",
                keyColumn: "Id",
                keyValue: "6nVWtynUjqNfYvJBHm9y");

            migrationBuilder.DeleteData(
                schema: "Troshka",
                table: "EuroStandards",
                keyColumn: "Id",
                keyValue: "gf3m77hAch2dLJlboAmI");

            migrationBuilder.DeleteData(
                schema: "Troshka",
                table: "EuroStandards",
                keyColumn: "Id",
                keyValue: "hq0VW30hpNMC51A82FNL");

            migrationBuilder.DeleteData(
                schema: "Troshka",
                table: "EuroStandards",
                keyColumn: "Id",
                keyValue: "KVUaC1lF52IRhBaKUsSE");

            migrationBuilder.DeleteData(
                schema: "Troshka",
                table: "EuroStandards",
                keyColumn: "Id",
                keyValue: "XdTXJcYMG10CUtCUYHQ5");

            migrationBuilder.DeleteData(
                schema: "Troshka",
                table: "EuroStandards",
                keyColumn: "Id",
                keyValue: "XLvkvBUg2BqeWw1UqIJg");

            migrationBuilder.DeleteData(
                schema: "Troshka",
                table: "Interior",
                keyColumn: "Id",
                keyValue: "uLTgFceWHqWonJ0FyvY6");

            migrationBuilder.DeleteData(
                schema: "Troshka",
                table: "Interior",
                keyColumn: "Id",
                keyValue: "y79EsvBfEnypVSHxD01W");

            migrationBuilder.DeleteData(
                schema: "Troshka",
                table: "Interior",
                keyColumn: "Id",
                keyValue: "zeStkXRJNMYVAx3Ch3S7");

            migrationBuilder.DeleteData(
                schema: "Cars",
                table: "Models",
                keyColumn: "Id",
                keyValue: "02ou3v8CF2F3wuXpcHvh");

            migrationBuilder.DeleteData(
                schema: "Cars",
                table: "Models",
                keyColumn: "Id",
                keyValue: "0bfyc9EoF50FnuyjKdje");

            migrationBuilder.DeleteData(
                schema: "Cars",
                table: "Models",
                keyColumn: "Id",
                keyValue: "15M0XenEJr5AdvewD1Lj");

            migrationBuilder.DeleteData(
                schema: "Cars",
                table: "Models",
                keyColumn: "Id",
                keyValue: "1BXX4tbCjQRVDyPvNC0e");

            migrationBuilder.DeleteData(
                schema: "Cars",
                table: "Models",
                keyColumn: "Id",
                keyValue: "1jyNV2FH0t6FXfBTxt1b");

            migrationBuilder.DeleteData(
                schema: "Cars",
                table: "Models",
                keyColumn: "Id",
                keyValue: "1kEYqdGUBcHu7cFX1r0q");

            migrationBuilder.DeleteData(
                schema: "Cars",
                table: "Models",
                keyColumn: "Id",
                keyValue: "1pRFqHzTMXN3jJzqjkh1");

            migrationBuilder.DeleteData(
                schema: "Cars",
                table: "Models",
                keyColumn: "Id",
                keyValue: "1rH1DzMrFhSbPTVzjqwY");

            migrationBuilder.DeleteData(
                schema: "Cars",
                table: "Models",
                keyColumn: "Id",
                keyValue: "1T0lmhar1vTmxaPnJoLm");

            migrationBuilder.DeleteData(
                schema: "Cars",
                table: "Models",
                keyColumn: "Id",
                keyValue: "1W31KD0Y6T1Pt2uTa16A");

            migrationBuilder.DeleteData(
                schema: "Cars",
                table: "Models",
                keyColumn: "Id",
                keyValue: "3EAsksmRLSWDVm0r7uwY");

            migrationBuilder.DeleteData(
                schema: "Cars",
                table: "Models",
                keyColumn: "Id",
                keyValue: "48K4JekuC7u1VQn7D67d");

            migrationBuilder.DeleteData(
                schema: "Cars",
                table: "Models",
                keyColumn: "Id",
                keyValue: "4ETVKspl5xwsgnWL3lDh");

            migrationBuilder.DeleteData(
                schema: "Cars",
                table: "Models",
                keyColumn: "Id",
                keyValue: "4GQT0aMYEz1fSY6eY8sB");

            migrationBuilder.DeleteData(
                schema: "Cars",
                table: "Models",
                keyColumn: "Id",
                keyValue: "4I11Bn1AvP9nI2mPtX9d");

            migrationBuilder.DeleteData(
                schema: "Cars",
                table: "Models",
                keyColumn: "Id",
                keyValue: "4jwjB0Crb3pnhQChKtyV");

            migrationBuilder.DeleteData(
                schema: "Cars",
                table: "Models",
                keyColumn: "Id",
                keyValue: "4Lx37Bwu5v07caJb9qQ0");

            migrationBuilder.DeleteData(
                schema: "Cars",
                table: "Models",
                keyColumn: "Id",
                keyValue: "4oUCJnWsAMChRTcQqkPI");

            migrationBuilder.DeleteData(
                schema: "Cars",
                table: "Models",
                keyColumn: "Id",
                keyValue: "5dnCbDV8azPHnf9kygDa");

            migrationBuilder.DeleteData(
                schema: "Cars",
                table: "Models",
                keyColumn: "Id",
                keyValue: "5MNsmv4qukD0lmsAIVWf");

            migrationBuilder.DeleteData(
                schema: "Cars",
                table: "Models",
                keyColumn: "Id",
                keyValue: "5PCvLwD6dpJGCpzNWBuN");

            migrationBuilder.DeleteData(
                schema: "Cars",
                table: "Models",
                keyColumn: "Id",
                keyValue: "5THRg7LoXQQEpCwVrNdf");

            migrationBuilder.DeleteData(
                schema: "Cars",
                table: "Models",
                keyColumn: "Id",
                keyValue: "67YCQqod80IcxznEbYWG");

            migrationBuilder.DeleteData(
                schema: "Cars",
                table: "Models",
                keyColumn: "Id",
                keyValue: "6HLXKcue0uYRYyNIjsxA");

            migrationBuilder.DeleteData(
                schema: "Cars",
                table: "Models",
                keyColumn: "Id",
                keyValue: "6hQdnWafPTHCqvoqBHH7");

            migrationBuilder.DeleteData(
                schema: "Cars",
                table: "Models",
                keyColumn: "Id",
                keyValue: "6pPAnb6rYwM9fe5bb1zb");

            migrationBuilder.DeleteData(
                schema: "Cars",
                table: "Models",
                keyColumn: "Id",
                keyValue: "6tXb8YTBAGwM6suLzEMI");

            migrationBuilder.DeleteData(
                schema: "Cars",
                table: "Models",
                keyColumn: "Id",
                keyValue: "719F6n5YUFR89dGEn2Th");

            migrationBuilder.DeleteData(
                schema: "Cars",
                table: "Models",
                keyColumn: "Id",
                keyValue: "7bT2Tfmosj70qWS5yqzn");

            migrationBuilder.DeleteData(
                schema: "Cars",
                table: "Models",
                keyColumn: "Id",
                keyValue: "7MtcDjXXmGPNgDHmKVI6");

            migrationBuilder.DeleteData(
                schema: "Cars",
                table: "Models",
                keyColumn: "Id",
                keyValue: "7w6v0Xwb2HVveB0T1EFn");

            migrationBuilder.DeleteData(
                schema: "Cars",
                table: "Models",
                keyColumn: "Id",
                keyValue: "8pBqx2qA2ys4cNHardCp");

            migrationBuilder.DeleteData(
                schema: "Cars",
                table: "Models",
                keyColumn: "Id",
                keyValue: "9uDxeUbRhFKCAAVhdSU9");

            migrationBuilder.DeleteData(
                schema: "Cars",
                table: "Models",
                keyColumn: "Id",
                keyValue: "A2ahzcpXnnELwActEbpe");

            migrationBuilder.DeleteData(
                schema: "Cars",
                table: "Models",
                keyColumn: "Id",
                keyValue: "a4QvKfmbhDVS61JKsTej");

            migrationBuilder.DeleteData(
                schema: "Cars",
                table: "Models",
                keyColumn: "Id",
                keyValue: "AHAyq6UwalfeLjhq3rKL");

            migrationBuilder.DeleteData(
                schema: "Cars",
                table: "Models",
                keyColumn: "Id",
                keyValue: "AI4YMPFffh0hwUhmKAFu");

            migrationBuilder.DeleteData(
                schema: "Cars",
                table: "Models",
                keyColumn: "Id",
                keyValue: "aINSmDNJLmA4sXsV05Hl");

            migrationBuilder.DeleteData(
                schema: "Cars",
                table: "Models",
                keyColumn: "Id",
                keyValue: "ANlb9yRm1dhe9wYwamuB");

            migrationBuilder.DeleteData(
                schema: "Cars",
                table: "Models",
                keyColumn: "Id",
                keyValue: "AnrycCM7adRtDbY0TLvW");

            migrationBuilder.DeleteData(
                schema: "Cars",
                table: "Models",
                keyColumn: "Id",
                keyValue: "AP6rLPKGmQ2PQq5EUWUA");

            migrationBuilder.DeleteData(
                schema: "Cars",
                table: "Models",
                keyColumn: "Id",
                keyValue: "AsgvpgNKjkSTxdR9ckkp");

            migrationBuilder.DeleteData(
                schema: "Cars",
                table: "Models",
                keyColumn: "Id",
                keyValue: "aX3Vcbqx3fFK3vR5lHpQ");

            migrationBuilder.DeleteData(
                schema: "Cars",
                table: "Models",
                keyColumn: "Id",
                keyValue: "ay4g05uI9TjXMJa4kxqF");

            migrationBuilder.DeleteData(
                schema: "Cars",
                table: "Models",
                keyColumn: "Id",
                keyValue: "bc6Mq8C4SFpUnMtF4zAI");

            migrationBuilder.DeleteData(
                schema: "Cars",
                table: "Models",
                keyColumn: "Id",
                keyValue: "BCCVsH0XUAltrKeEuyW0");

            migrationBuilder.DeleteData(
                schema: "Cars",
                table: "Models",
                keyColumn: "Id",
                keyValue: "Bex1oom6XuTQK9BqbGf8");

            migrationBuilder.DeleteData(
                schema: "Cars",
                table: "Models",
                keyColumn: "Id",
                keyValue: "bGnvSLMaWVxumEyWCsWw");

            migrationBuilder.DeleteData(
                schema: "Cars",
                table: "Models",
                keyColumn: "Id",
                keyValue: "bKtjeHYxPQ6cw7WELzVH");

            migrationBuilder.DeleteData(
                schema: "Cars",
                table: "Models",
                keyColumn: "Id",
                keyValue: "blu063mPIqlhSnPnNd7Q");

            migrationBuilder.DeleteData(
                schema: "Cars",
                table: "Models",
                keyColumn: "Id",
                keyValue: "brIy5gkFl6BugII58jGu");

            migrationBuilder.DeleteData(
                schema: "Cars",
                table: "Models",
                keyColumn: "Id",
                keyValue: "BscFAFYQjjJfS6Wlc78q");

            migrationBuilder.DeleteData(
                schema: "Cars",
                table: "Models",
                keyColumn: "Id",
                keyValue: "bwBqLQy6PoaMV2InXxW2");

            migrationBuilder.DeleteData(
                schema: "Cars",
                table: "Models",
                keyColumn: "Id",
                keyValue: "BxSuvWYkFLsUY6DuFUp4");

            migrationBuilder.DeleteData(
                schema: "Cars",
                table: "Models",
                keyColumn: "Id",
                keyValue: "byq3AN4fuByWgJ1XSNqv");

            migrationBuilder.DeleteData(
                schema: "Cars",
                table: "Models",
                keyColumn: "Id",
                keyValue: "c2T5e8jCmm6CIsk0SLs2");

            migrationBuilder.DeleteData(
                schema: "Cars",
                table: "Models",
                keyColumn: "Id",
                keyValue: "C5DCvhzU3bze6eQ2xYkx");

            migrationBuilder.DeleteData(
                schema: "Cars",
                table: "Models",
                keyColumn: "Id",
                keyValue: "C9CTaLjVWAYVpafFpMeF");

            migrationBuilder.DeleteData(
                schema: "Cars",
                table: "Models",
                keyColumn: "Id",
                keyValue: "CaNj6Jc7njD5GjIvW0T9");

            migrationBuilder.DeleteData(
                schema: "Cars",
                table: "Models",
                keyColumn: "Id",
                keyValue: "ce5jwwR8qr4bgp9eN3BA");

            migrationBuilder.DeleteData(
                schema: "Cars",
                table: "Models",
                keyColumn: "Id",
                keyValue: "CJPP5XSvKA4FLIGufCjC");

            migrationBuilder.DeleteData(
                schema: "Cars",
                table: "Models",
                keyColumn: "Id",
                keyValue: "CNFtr9KzWHdxd6S4ynff");

            migrationBuilder.DeleteData(
                schema: "Cars",
                table: "Models",
                keyColumn: "Id",
                keyValue: "cNGFRPQoyxcPqdnEzTbT");

            migrationBuilder.DeleteData(
                schema: "Cars",
                table: "Models",
                keyColumn: "Id",
                keyValue: "CpdHbNhJGTlNL33GBG0Q");

            migrationBuilder.DeleteData(
                schema: "Cars",
                table: "Models",
                keyColumn: "Id",
                keyValue: "CtN2chHHY3dryMG5m9v8");

            migrationBuilder.DeleteData(
                schema: "Cars",
                table: "Models",
                keyColumn: "Id",
                keyValue: "CvopJBj5fUcFUTNRnW6a");

            migrationBuilder.DeleteData(
                schema: "Cars",
                table: "Models",
                keyColumn: "Id",
                keyValue: "CxuQRTlFShq2f6yScgcF");

            migrationBuilder.DeleteData(
                schema: "Cars",
                table: "Models",
                keyColumn: "Id",
                keyValue: "cYBY7915yxuKYT0UKexl");

            migrationBuilder.DeleteData(
                schema: "Cars",
                table: "Models",
                keyColumn: "Id",
                keyValue: "D1csDfv4IoBJEH02eIf7");

            migrationBuilder.DeleteData(
                schema: "Cars",
                table: "Models",
                keyColumn: "Id",
                keyValue: "DDybMB4IdDvlyBgaPAR8");

            migrationBuilder.DeleteData(
                schema: "Cars",
                table: "Models",
                keyColumn: "Id",
                keyValue: "dG0bA6JQ2nUeARTnAsDh");

            migrationBuilder.DeleteData(
                schema: "Cars",
                table: "Models",
                keyColumn: "Id",
                keyValue: "dIvQ5Gn1QdbPNdj8kThu");

            migrationBuilder.DeleteData(
                schema: "Cars",
                table: "Models",
                keyColumn: "Id",
                keyValue: "dzxvFU54f7ljnHWFJP96");

            migrationBuilder.DeleteData(
                schema: "Cars",
                table: "Models",
                keyColumn: "Id",
                keyValue: "E7Nm5XhM4BA0V2PeYgQm");

            migrationBuilder.DeleteData(
                schema: "Cars",
                table: "Models",
                keyColumn: "Id",
                keyValue: "EfJn4ynnS35rT6otuGCo");

            migrationBuilder.DeleteData(
                schema: "Cars",
                table: "Models",
                keyColumn: "Id",
                keyValue: "EHGGMQkx07fPupQQppxo");

            migrationBuilder.DeleteData(
                schema: "Cars",
                table: "Models",
                keyColumn: "Id",
                keyValue: "ELQYNALcwpAAY0A43VLo");

            migrationBuilder.DeleteData(
                schema: "Cars",
                table: "Models",
                keyColumn: "Id",
                keyValue: "eLvfBuayX92MHMab0fUA");

            migrationBuilder.DeleteData(
                schema: "Cars",
                table: "Models",
                keyColumn: "Id",
                keyValue: "EN0RlqRnxoNLIF6xN6oE");

            migrationBuilder.DeleteData(
                schema: "Cars",
                table: "Models",
                keyColumn: "Id",
                keyValue: "EPfF9YCm4gKmxxhB8eSy");

            migrationBuilder.DeleteData(
                schema: "Cars",
                table: "Models",
                keyColumn: "Id",
                keyValue: "eRVY4UBabkU9mmkNbuRI");

            migrationBuilder.DeleteData(
                schema: "Cars",
                table: "Models",
                keyColumn: "Id",
                keyValue: "eURGdTpRyGkdCQhlD3jk");

            migrationBuilder.DeleteData(
                schema: "Cars",
                table: "Models",
                keyColumn: "Id",
                keyValue: "F90vVTgvvVKnKLYhHovu");

            migrationBuilder.DeleteData(
                schema: "Cars",
                table: "Models",
                keyColumn: "Id",
                keyValue: "feAY3Cmq1vphPgNHPvsG");

            migrationBuilder.DeleteData(
                schema: "Cars",
                table: "Models",
                keyColumn: "Id",
                keyValue: "fJmXusofopkDd67DQfee");

            migrationBuilder.DeleteData(
                schema: "Cars",
                table: "Models",
                keyColumn: "Id",
                keyValue: "fJSRzeTnwU8kBzVU0ayJ");

            migrationBuilder.DeleteData(
                schema: "Cars",
                table: "Models",
                keyColumn: "Id",
                keyValue: "FjzDaNSmEQXr0Dm74KsC");

            migrationBuilder.DeleteData(
                schema: "Cars",
                table: "Models",
                keyColumn: "Id",
                keyValue: "FS2bYCBmXT2gov4qjDYx");

            migrationBuilder.DeleteData(
                schema: "Cars",
                table: "Models",
                keyColumn: "Id",
                keyValue: "FUlhe0lwljNDAGHm1EP7");

            migrationBuilder.DeleteData(
                schema: "Cars",
                table: "Models",
                keyColumn: "Id",
                keyValue: "FYq5M10U2KLfuEgpdQFn");

            migrationBuilder.DeleteData(
                schema: "Cars",
                table: "Models",
                keyColumn: "Id",
                keyValue: "g65Y6Ne5W8MWWM1kbL5s");

            migrationBuilder.DeleteData(
                schema: "Cars",
                table: "Models",
                keyColumn: "Id",
                keyValue: "g94JGR1e1jMrGTa1sgYW");

            migrationBuilder.DeleteData(
                schema: "Cars",
                table: "Models",
                keyColumn: "Id",
                keyValue: "GBJDvdYz9dUpvgkD503x");

            migrationBuilder.DeleteData(
                schema: "Cars",
                table: "Models",
                keyColumn: "Id",
                keyValue: "GbXDueg2tzXnzzpcMXY6");

            migrationBuilder.DeleteData(
                schema: "Cars",
                table: "Models",
                keyColumn: "Id",
                keyValue: "gcYrxL6MHRRPSEKaaHaM");

            migrationBuilder.DeleteData(
                schema: "Cars",
                table: "Models",
                keyColumn: "Id",
                keyValue: "gj42wdfqwalIVSJmcvIW");

            migrationBuilder.DeleteData(
                schema: "Cars",
                table: "Models",
                keyColumn: "Id",
                keyValue: "gmMPfnNpeRz3ypy3Yoe8");

            migrationBuilder.DeleteData(
                schema: "Cars",
                table: "Models",
                keyColumn: "Id",
                keyValue: "GPE4xtczgMlj70Ada0CI");

            migrationBuilder.DeleteData(
                schema: "Cars",
                table: "Models",
                keyColumn: "Id",
                keyValue: "Gs09goAhMe0x07137cWC");

            migrationBuilder.DeleteData(
                schema: "Cars",
                table: "Models",
                keyColumn: "Id",
                keyValue: "Gulu7urNWpXKdWsRf0Mk");

            migrationBuilder.DeleteData(
                schema: "Cars",
                table: "Models",
                keyColumn: "Id",
                keyValue: "gUVqvnuzYLNMPYPEP5e6");

            migrationBuilder.DeleteData(
                schema: "Cars",
                table: "Models",
                keyColumn: "Id",
                keyValue: "GYPy3ly7DpwLWEgWY5u7");

            migrationBuilder.DeleteData(
                schema: "Cars",
                table: "Models",
                keyColumn: "Id",
                keyValue: "h1ahgJASNltj9CNxP48p");

            migrationBuilder.DeleteData(
                schema: "Cars",
                table: "Models",
                keyColumn: "Id",
                keyValue: "H3HS2W3xAWPTumDH6QAb");

            migrationBuilder.DeleteData(
                schema: "Cars",
                table: "Models",
                keyColumn: "Id",
                keyValue: "hHRwEEqyKJyrKv7LysD0");

            migrationBuilder.DeleteData(
                schema: "Cars",
                table: "Models",
                keyColumn: "Id",
                keyValue: "HmS6qXL0BbGPrKaK7WhG");

            migrationBuilder.DeleteData(
                schema: "Cars",
                table: "Models",
                keyColumn: "Id",
                keyValue: "HQbAfhmeluvRLDvoPzuT");

            migrationBuilder.DeleteData(
                schema: "Cars",
                table: "Models",
                keyColumn: "Id",
                keyValue: "hSd3gUNHF7VFmp7pyW5f");

            migrationBuilder.DeleteData(
                schema: "Cars",
                table: "Models",
                keyColumn: "Id",
                keyValue: "IaR1QKfhncLddtA6HA7K");

            migrationBuilder.DeleteData(
                schema: "Cars",
                table: "Models",
                keyColumn: "Id",
                keyValue: "IKad54P2FLXqEBQNbHbp");

            migrationBuilder.DeleteData(
                schema: "Cars",
                table: "Models",
                keyColumn: "Id",
                keyValue: "IlLqDmVAjqhvahXMtzbo");

            migrationBuilder.DeleteData(
                schema: "Cars",
                table: "Models",
                keyColumn: "Id",
                keyValue: "IsEFhX33bBwX90f6gdBQ");

            migrationBuilder.DeleteData(
                schema: "Cars",
                table: "Models",
                keyColumn: "Id",
                keyValue: "ISqlUSdE8PodsAvWq2nF");

            migrationBuilder.DeleteData(
                schema: "Cars",
                table: "Models",
                keyColumn: "Id",
                keyValue: "JawERxfAoj5Lg9o1QRBX");

            migrationBuilder.DeleteData(
                schema: "Cars",
                table: "Models",
                keyColumn: "Id",
                keyValue: "JgTJmdhBqQJBIR4QLyDm");

            migrationBuilder.DeleteData(
                schema: "Cars",
                table: "Models",
                keyColumn: "Id",
                keyValue: "jhFlnWeWNXtTPR0no0YT");

            migrationBuilder.DeleteData(
                schema: "Cars",
                table: "Models",
                keyColumn: "Id",
                keyValue: "JJBnS7CxUjzn14TVGpWR");

            migrationBuilder.DeleteData(
                schema: "Cars",
                table: "Models",
                keyColumn: "Id",
                keyValue: "JjhF08DxMUxGJudNjpCX");

            migrationBuilder.DeleteData(
                schema: "Cars",
                table: "Models",
                keyColumn: "Id",
                keyValue: "Jnk9ucrHKMmuWgGAjapb");

            migrationBuilder.DeleteData(
                schema: "Cars",
                table: "Models",
                keyColumn: "Id",
                keyValue: "jqPSQshtHXFtE4k0VWjk");

            migrationBuilder.DeleteData(
                schema: "Cars",
                table: "Models",
                keyColumn: "Id",
                keyValue: "jsD6dxMpzvCYVHzb2sBd");

            migrationBuilder.DeleteData(
                schema: "Cars",
                table: "Models",
                keyColumn: "Id",
                keyValue: "k0lbeNfPqbxKJ2rUmqYV");

            migrationBuilder.DeleteData(
                schema: "Cars",
                table: "Models",
                keyColumn: "Id",
                keyValue: "k2K1bUsRRwpLh4rUfdEr");

            migrationBuilder.DeleteData(
                schema: "Cars",
                table: "Models",
                keyColumn: "Id",
                keyValue: "k998a3MQP6ycBzj4rXY2");

            migrationBuilder.DeleteData(
                schema: "Cars",
                table: "Models",
                keyColumn: "Id",
                keyValue: "kAXHV6pYVbD5dgdARAGY");

            migrationBuilder.DeleteData(
                schema: "Cars",
                table: "Models",
                keyColumn: "Id",
                keyValue: "kj0UbtyvlCYj6m5qjapa");

            migrationBuilder.DeleteData(
                schema: "Cars",
                table: "Models",
                keyColumn: "Id",
                keyValue: "knYn0wcpoEtwsKm24S94");

            migrationBuilder.DeleteData(
                schema: "Cars",
                table: "Models",
                keyColumn: "Id",
                keyValue: "KXYrA93YqsVUJwn1xFPp");

            migrationBuilder.DeleteData(
                schema: "Cars",
                table: "Models",
                keyColumn: "Id",
                keyValue: "KyV3lBflXsIUlTlEIbfy");

            migrationBuilder.DeleteData(
                schema: "Cars",
                table: "Models",
                keyColumn: "Id",
                keyValue: "L3qkfxgd6tMvKfAzmgC2");

            migrationBuilder.DeleteData(
                schema: "Cars",
                table: "Models",
                keyColumn: "Id",
                keyValue: "L5jqIPmjk0PaD43lclpj");

            migrationBuilder.DeleteData(
                schema: "Cars",
                table: "Models",
                keyColumn: "Id",
                keyValue: "LAcvlURodT0DDGg29u11");

            migrationBuilder.DeleteData(
                schema: "Cars",
                table: "Models",
                keyColumn: "Id",
                keyValue: "lFb3tseSCC0zjAlEu6KN");

            migrationBuilder.DeleteData(
                schema: "Cars",
                table: "Models",
                keyColumn: "Id",
                keyValue: "LnTSKdwhMAs1XnqffsCb");

            migrationBuilder.DeleteData(
                schema: "Cars",
                table: "Models",
                keyColumn: "Id",
                keyValue: "LphcdjHjpasuHpMokRr8");

            migrationBuilder.DeleteData(
                schema: "Cars",
                table: "Models",
                keyColumn: "Id",
                keyValue: "lu9LqDx5AJzonlqDfxmn");

            migrationBuilder.DeleteData(
                schema: "Cars",
                table: "Models",
                keyColumn: "Id",
                keyValue: "lwohUeP6mGh7gNTsJVd0");

            migrationBuilder.DeleteData(
                schema: "Cars",
                table: "Models",
                keyColumn: "Id",
                keyValue: "lXaz1PUCpmIw4YDL8q85");

            migrationBuilder.DeleteData(
                schema: "Cars",
                table: "Models",
                keyColumn: "Id",
                keyValue: "m1HlHc849BVPq5pycUhh");

            migrationBuilder.DeleteData(
                schema: "Cars",
                table: "Models",
                keyColumn: "Id",
                keyValue: "M4x9BV0yxbocgW7F6gzV");

            migrationBuilder.DeleteData(
                schema: "Cars",
                table: "Models",
                keyColumn: "Id",
                keyValue: "MdympetsemdCQeWQ2Uhc");

            migrationBuilder.DeleteData(
                schema: "Cars",
                table: "Models",
                keyColumn: "Id",
                keyValue: "me19B1bHzqP8fUoYEJ6w");

            migrationBuilder.DeleteData(
                schema: "Cars",
                table: "Models",
                keyColumn: "Id",
                keyValue: "MLJEeKjPMD7p2E4V9yru");

            migrationBuilder.DeleteData(
                schema: "Cars",
                table: "Models",
                keyColumn: "Id",
                keyValue: "msDQhJSKuySCV5jcXcPH");

            migrationBuilder.DeleteData(
                schema: "Cars",
                table: "Models",
                keyColumn: "Id",
                keyValue: "n4aK8REHYKK4Da1Ej7MH");

            migrationBuilder.DeleteData(
                schema: "Cars",
                table: "Models",
                keyColumn: "Id",
                keyValue: "n8xh44259tJbDDPV2XJg");

            migrationBuilder.DeleteData(
                schema: "Cars",
                table: "Models",
                keyColumn: "Id",
                keyValue: "NekGGPYsherm6gTH202f");

            migrationBuilder.DeleteData(
                schema: "Cars",
                table: "Models",
                keyColumn: "Id",
                keyValue: "NkEjCDRl5c3qwgyMtND7");

            migrationBuilder.DeleteData(
                schema: "Cars",
                table: "Models",
                keyColumn: "Id",
                keyValue: "nPvvwGx0JzsFR9e4N7Fw");

            migrationBuilder.DeleteData(
                schema: "Cars",
                table: "Models",
                keyColumn: "Id",
                keyValue: "Nz5w4whgUrJxmo7ujhuu");

            migrationBuilder.DeleteData(
                schema: "Cars",
                table: "Models",
                keyColumn: "Id",
                keyValue: "o2UaRk8B87gNQQR0Dyfb");

            migrationBuilder.DeleteData(
                schema: "Cars",
                table: "Models",
                keyColumn: "Id",
                keyValue: "o9WkVwIEU28LaCV8kJEQ");

            migrationBuilder.DeleteData(
                schema: "Cars",
                table: "Models",
                keyColumn: "Id",
                keyValue: "oDJncLBGoHrqTNGTwMtV");

            migrationBuilder.DeleteData(
                schema: "Cars",
                table: "Models",
                keyColumn: "Id",
                keyValue: "oelzQ4purnelV64XnKcF");

            migrationBuilder.DeleteData(
                schema: "Cars",
                table: "Models",
                keyColumn: "Id",
                keyValue: "oKbjhgWsh89c8oMXVDK1");

            migrationBuilder.DeleteData(
                schema: "Cars",
                table: "Models",
                keyColumn: "Id",
                keyValue: "oY4glkSkb7PrtAT7FpLK");

            migrationBuilder.DeleteData(
                schema: "Cars",
                table: "Models",
                keyColumn: "Id",
                keyValue: "P6v2KSwEXaFvuJ96vkAp");

            migrationBuilder.DeleteData(
                schema: "Cars",
                table: "Models",
                keyColumn: "Id",
                keyValue: "pbE1oQ2C3dFSeckEEs93");

            migrationBuilder.DeleteData(
                schema: "Cars",
                table: "Models",
                keyColumn: "Id",
                keyValue: "pCbFHTuzXIC1hUtgL2go");

            migrationBuilder.DeleteData(
                schema: "Cars",
                table: "Models",
                keyColumn: "Id",
                keyValue: "pct4pqnYgAUhv8BUQ43b");

            migrationBuilder.DeleteData(
                schema: "Cars",
                table: "Models",
                keyColumn: "Id",
                keyValue: "PlGp4odGKDAkEEvoL7qX");

            migrationBuilder.DeleteData(
                schema: "Cars",
                table: "Models",
                keyColumn: "Id",
                keyValue: "pUTzAqBudg67k4bqWcJT");

            migrationBuilder.DeleteData(
                schema: "Cars",
                table: "Models",
                keyColumn: "Id",
                keyValue: "pwnUgQMV48UXDmJ0jtgw");

            migrationBuilder.DeleteData(
                schema: "Cars",
                table: "Models",
                keyColumn: "Id",
                keyValue: "pzetmWHB9vQcosNRCKGC");

            migrationBuilder.DeleteData(
                schema: "Cars",
                table: "Models",
                keyColumn: "Id",
                keyValue: "q1g7vpPPj43d4b4HjfPj");

            migrationBuilder.DeleteData(
                schema: "Cars",
                table: "Models",
                keyColumn: "Id",
                keyValue: "q2cX9d56ywdlann16lA3");

            migrationBuilder.DeleteData(
                schema: "Cars",
                table: "Models",
                keyColumn: "Id",
                keyValue: "q5IRP8CTHQVIpskPfjt1");

            migrationBuilder.DeleteData(
                schema: "Cars",
                table: "Models",
                keyColumn: "Id",
                keyValue: "q94FD2cKHtXqdVRlHWkA");

            migrationBuilder.DeleteData(
                schema: "Cars",
                table: "Models",
                keyColumn: "Id",
                keyValue: "qfERIfrfKCftuV4Lj9p6");

            migrationBuilder.DeleteData(
                schema: "Cars",
                table: "Models",
                keyColumn: "Id",
                keyValue: "QhjAkCzrphd8UWqUJdb0");

            migrationBuilder.DeleteData(
                schema: "Cars",
                table: "Models",
                keyColumn: "Id",
                keyValue: "QQy4jKAqzeMLX4BudGsm");

            migrationBuilder.DeleteData(
                schema: "Cars",
                table: "Models",
                keyColumn: "Id",
                keyValue: "QRBrkIawcEDj0cKzeVyB");

            migrationBuilder.DeleteData(
                schema: "Cars",
                table: "Models",
                keyColumn: "Id",
                keyValue: "qXeSoLuFHD8uEJeruDx0");

            migrationBuilder.DeleteData(
                schema: "Cars",
                table: "Models",
                keyColumn: "Id",
                keyValue: "R1QCgRzpv1736f2o9KQh");

            migrationBuilder.DeleteData(
                schema: "Cars",
                table: "Models",
                keyColumn: "Id",
                keyValue: "r6VyGBpLonVohz14lnER");

            migrationBuilder.DeleteData(
                schema: "Cars",
                table: "Models",
                keyColumn: "Id",
                keyValue: "RC2tBfSrmMwkylzf1Uys");

            migrationBuilder.DeleteData(
                schema: "Cars",
                table: "Models",
                keyColumn: "Id",
                keyValue: "Rc5y62n0Hb1hQGwEI8wg");

            migrationBuilder.DeleteData(
                schema: "Cars",
                table: "Models",
                keyColumn: "Id",
                keyValue: "rhWo0L7jItll98lxMteW");

            migrationBuilder.DeleteData(
                schema: "Cars",
                table: "Models",
                keyColumn: "Id",
                keyValue: "RIL5IMgII6zgoYt4EpSo");

            migrationBuilder.DeleteData(
                schema: "Cars",
                table: "Models",
                keyColumn: "Id",
                keyValue: "rqef80XGNAaSPMRFu8C9");

            migrationBuilder.DeleteData(
                schema: "Cars",
                table: "Models",
                keyColumn: "Id",
                keyValue: "RSS5yaVGgojbYQLC0E0n");

            migrationBuilder.DeleteData(
                schema: "Cars",
                table: "Models",
                keyColumn: "Id",
                keyValue: "RtG1EDoXqamMdqSEzQdP");

            migrationBuilder.DeleteData(
                schema: "Cars",
                table: "Models",
                keyColumn: "Id",
                keyValue: "S1y5zYDcNwurb5sI3nRw");

            migrationBuilder.DeleteData(
                schema: "Cars",
                table: "Models",
                keyColumn: "Id",
                keyValue: "slow7XQw5qE4yjSyoStg");

            migrationBuilder.DeleteData(
                schema: "Cars",
                table: "Models",
                keyColumn: "Id",
                keyValue: "sQdT9PnrhKuyNgVr8xhP");

            migrationBuilder.DeleteData(
                schema: "Cars",
                table: "Models",
                keyColumn: "Id",
                keyValue: "SqS9Iq87IubmqNFSp0my");

            migrationBuilder.DeleteData(
                schema: "Cars",
                table: "Models",
                keyColumn: "Id",
                keyValue: "T1qxcYPqpLv7T50oY9ww");

            migrationBuilder.DeleteData(
                schema: "Cars",
                table: "Models",
                keyColumn: "Id",
                keyValue: "t5yJF11f5PbJMK0cwyRu");

            migrationBuilder.DeleteData(
                schema: "Cars",
                table: "Models",
                keyColumn: "Id",
                keyValue: "T72MvA1JYk8WP0tkvjfJ");

            migrationBuilder.DeleteData(
                schema: "Cars",
                table: "Models",
                keyColumn: "Id",
                keyValue: "tE85W2keDNUQ6RrnEIbc");

            migrationBuilder.DeleteData(
                schema: "Cars",
                table: "Models",
                keyColumn: "Id",
                keyValue: "TkYaSk7R7wGeaB24BGe8");

            migrationBuilder.DeleteData(
                schema: "Cars",
                table: "Models",
                keyColumn: "Id",
                keyValue: "TpmXBSdASAWr2xlnarV9");

            migrationBuilder.DeleteData(
                schema: "Cars",
                table: "Models",
                keyColumn: "Id",
                keyValue: "tTbGnB3dHJS2Stg8eref");

            migrationBuilder.DeleteData(
                schema: "Cars",
                table: "Models",
                keyColumn: "Id",
                keyValue: "U0CAlqS7JEqN69eVtteg");

            migrationBuilder.DeleteData(
                schema: "Cars",
                table: "Models",
                keyColumn: "Id",
                keyValue: "UaTlBMeCSBzm6LaVT5pT");

            migrationBuilder.DeleteData(
                schema: "Cars",
                table: "Models",
                keyColumn: "Id",
                keyValue: "Ud7oHftVxFX5ERzvV3NM");

            migrationBuilder.DeleteData(
                schema: "Cars",
                table: "Models",
                keyColumn: "Id",
                keyValue: "UDSnDkTyRQEesnsvITL1");

            migrationBuilder.DeleteData(
                schema: "Cars",
                table: "Models",
                keyColumn: "Id",
                keyValue: "ujX7wGYSEQPjoeXdtuWn");

            migrationBuilder.DeleteData(
                schema: "Cars",
                table: "Models",
                keyColumn: "Id",
                keyValue: "uLHYuSXef81hYeG7q2IE");

            migrationBuilder.DeleteData(
                schema: "Cars",
                table: "Models",
                keyColumn: "Id",
                keyValue: "ulxCpA8k55JYSIBuKzh1");

            migrationBuilder.DeleteData(
                schema: "Cars",
                table: "Models",
                keyColumn: "Id",
                keyValue: "UoPjR0JQx0LvtNeFlSMs");

            migrationBuilder.DeleteData(
                schema: "Cars",
                table: "Models",
                keyColumn: "Id",
                keyValue: "VauHLBe2mqryLlIRGzaK");

            migrationBuilder.DeleteData(
                schema: "Cars",
                table: "Models",
                keyColumn: "Id",
                keyValue: "vBAg071uEM3NEho2gQMl");

            migrationBuilder.DeleteData(
                schema: "Cars",
                table: "Models",
                keyColumn: "Id",
                keyValue: "vbCmtrTayQQsPokySE3B");

            migrationBuilder.DeleteData(
                schema: "Cars",
                table: "Models",
                keyColumn: "Id",
                keyValue: "vEDkHPchaoYryD7U5h53");

            migrationBuilder.DeleteData(
                schema: "Cars",
                table: "Models",
                keyColumn: "Id",
                keyValue: "VeI2bCf5hRBpTvB1fBWw");

            migrationBuilder.DeleteData(
                schema: "Cars",
                table: "Models",
                keyColumn: "Id",
                keyValue: "VEI6wIu7Ecb5S2CV3sFo");

            migrationBuilder.DeleteData(
                schema: "Cars",
                table: "Models",
                keyColumn: "Id",
                keyValue: "vlcwwc45C7SXjNscx7c6");

            migrationBuilder.DeleteData(
                schema: "Cars",
                table: "Models",
                keyColumn: "Id",
                keyValue: "Vxr8why3L70IXkoroWjp");

            migrationBuilder.DeleteData(
                schema: "Cars",
                table: "Models",
                keyColumn: "Id",
                keyValue: "w0XbHkkmrRLtq0RqwHAs");

            migrationBuilder.DeleteData(
                schema: "Cars",
                table: "Models",
                keyColumn: "Id",
                keyValue: "W3vaFqojEDtIQVvx3dLC");

            migrationBuilder.DeleteData(
                schema: "Cars",
                table: "Models",
                keyColumn: "Id",
                keyValue: "wb1rUXaWnBLcsKQHgLkP");

            migrationBuilder.DeleteData(
                schema: "Cars",
                table: "Models",
                keyColumn: "Id",
                keyValue: "wkVj1M9h9oj2mp5tH5Ad");

            migrationBuilder.DeleteData(
                schema: "Cars",
                table: "Models",
                keyColumn: "Id",
                keyValue: "WMJW6MPA8fft7gvAD9xw");

            migrationBuilder.DeleteData(
                schema: "Cars",
                table: "Models",
                keyColumn: "Id",
                keyValue: "WnQrWhdlJ4fegxzEL4E5");

            migrationBuilder.DeleteData(
                schema: "Cars",
                table: "Models",
                keyColumn: "Id",
                keyValue: "WvnfKRv9U9CrQYYp9YEg");

            migrationBuilder.DeleteData(
                schema: "Cars",
                table: "Models",
                keyColumn: "Id",
                keyValue: "Wz27oW5TMjtMpsGjXBUM");

            migrationBuilder.DeleteData(
                schema: "Cars",
                table: "Models",
                keyColumn: "Id",
                keyValue: "x22vj9FSy0BtRWSP7quD");

            migrationBuilder.DeleteData(
                schema: "Cars",
                table: "Models",
                keyColumn: "Id",
                keyValue: "X3aK4l1BhBBDt6B0eYnR");

            migrationBuilder.DeleteData(
                schema: "Cars",
                table: "Models",
                keyColumn: "Id",
                keyValue: "xAyAgIEG5bhhTtBlDYYQ");

            migrationBuilder.DeleteData(
                schema: "Cars",
                table: "Models",
                keyColumn: "Id",
                keyValue: "xkm3jUaw3HYhNfkbdwrz");

            migrationBuilder.DeleteData(
                schema: "Cars",
                table: "Models",
                keyColumn: "Id",
                keyValue: "xq76wYlx37wX0oPc66Q5");

            migrationBuilder.DeleteData(
                schema: "Cars",
                table: "Models",
                keyColumn: "Id",
                keyValue: "xQwDukKmAIqevJ01GCuN");

            migrationBuilder.DeleteData(
                schema: "Cars",
                table: "Models",
                keyColumn: "Id",
                keyValue: "xQxzCWaPDDw7CLLxC47Q");

            migrationBuilder.DeleteData(
                schema: "Cars",
                table: "Models",
                keyColumn: "Id",
                keyValue: "XsHSmxwlNq15EVjwXe77");

            migrationBuilder.DeleteData(
                schema: "Cars",
                table: "Models",
                keyColumn: "Id",
                keyValue: "XtsFJt3J6wXVqQrCIS19");

            migrationBuilder.DeleteData(
                schema: "Cars",
                table: "Models",
                keyColumn: "Id",
                keyValue: "XXp36Ws6zhI7KC1P7jw6");

            migrationBuilder.DeleteData(
                schema: "Cars",
                table: "Models",
                keyColumn: "Id",
                keyValue: "y4nG1TwRVu0yWpnPhkBX");

            migrationBuilder.DeleteData(
                schema: "Cars",
                table: "Models",
                keyColumn: "Id",
                keyValue: "yAukqYPYxM8L0jAcNhHd");

            migrationBuilder.DeleteData(
                schema: "Cars",
                table: "Models",
                keyColumn: "Id",
                keyValue: "yBjfcxenW2AjN2rPjgd4");

            migrationBuilder.DeleteData(
                schema: "Cars",
                table: "Models",
                keyColumn: "Id",
                keyValue: "ycVbnDUsw9nFqtEpIYJ0");

            migrationBuilder.DeleteData(
                schema: "Cars",
                table: "Models",
                keyColumn: "Id",
                keyValue: "Yk45dIha5TrwHPTrDzsD");

            migrationBuilder.DeleteData(
                schema: "Cars",
                table: "Models",
                keyColumn: "Id",
                keyValue: "yp58tHU08gK3nJWW0yMb");

            migrationBuilder.DeleteData(
                schema: "Cars",
                table: "Models",
                keyColumn: "Id",
                keyValue: "z35bUECEfLTPTsXKYBac");

            migrationBuilder.DeleteData(
                schema: "Cars",
                table: "Models",
                keyColumn: "Id",
                keyValue: "zF2hz2XDRHDsI6Hq1Ipd");

            migrationBuilder.DeleteData(
                schema: "Cars",
                table: "Models",
                keyColumn: "Id",
                keyValue: "zGjGkgw9SbxhJH9fYxtL");

            migrationBuilder.DeleteData(
                schema: "Cars",
                table: "Models",
                keyColumn: "Id",
                keyValue: "zN6e6y99qLNG6w4q85H9");

            migrationBuilder.DeleteData(
                schema: "Cars",
                table: "Models",
                keyColumn: "Id",
                keyValue: "zzM7cs7s7RPHYbNnDrQh");

            migrationBuilder.DeleteData(
                schema: "Troshka",
                table: "Transmissions",
                keyColumn: "Id",
                keyValue: "0hIuCr30Ilby0G7FjHsx");

            migrationBuilder.DeleteData(
                schema: "Troshka",
                table: "Transmissions",
                keyColumn: "Id",
                keyValue: "N0UwUhF63UJrmTwUPdhQ");

            migrationBuilder.DeleteData(
                schema: "Troshka",
                table: "Transmissions",
                keyColumn: "Id",
                keyValue: "PIQ3kQjDmKkE6MS8BRmY");

            migrationBuilder.RenameTable(
                name: "UserComments",
                schema: "Troshka",
                newName: "Users",
                newSchema: "Troshka");

            migrationBuilder.AlterColumn<double>(
                name: "Rating",
                schema: "Troshka",
                table: "Users",
                type: "float",
                nullable: true,
                oldClrType: typeof(double),
                oldType: "float");

            migrationBuilder.AlterColumn<string>(
                name: "Phone",
                schema: "Troshka",
                table: "Users",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Users",
                schema: "Troshka",
                table: "Users",
                column: "Id");

            migrationBuilder.UpdateData(
                schema: "Cars",
                table: "Brands",
                keyColumn: "Id",
                keyValue: "06MxFkB3ArFfVraVWN1u",
                columns: new[] { "DateCreated", "TrackId" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 4, 11, 13, 51, 43, 808, DateTimeKind.Unspecified).AddTicks(8121), new TimeSpan(0, 0, 0, 0, 0)), "958d6c0b-4bb5-4eac-bf07-5f88e3e79cbe" });

            migrationBuilder.UpdateData(
                schema: "Cars",
                table: "Brands",
                keyColumn: "Id",
                keyValue: "0SlIJFKD3VdaMAEnxfTT",
                columns: new[] { "DateCreated", "TrackId" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 4, 11, 13, 51, 43, 808, DateTimeKind.Unspecified).AddTicks(8130), new TimeSpan(0, 0, 0, 0, 0)), "8ef4612b-1dba-49e9-a782-fe7ebc30c3e4" });

            migrationBuilder.UpdateData(
                schema: "Cars",
                table: "Brands",
                keyColumn: "Id",
                keyValue: "2FEzeyYHYe3zlhjMeaEF",
                columns: new[] { "DateCreated", "TrackId" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 4, 11, 13, 51, 43, 808, DateTimeKind.Unspecified).AddTicks(8136), new TimeSpan(0, 0, 0, 0, 0)), "c0fdc10f-83b8-4567-b6f9-2ce45d86ea24" });

            migrationBuilder.UpdateData(
                schema: "Cars",
                table: "Brands",
                keyColumn: "Id",
                keyValue: "2SBENlnqR76XRNAjbAs3",
                columns: new[] { "DateCreated", "TrackId" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 4, 11, 13, 51, 43, 808, DateTimeKind.Unspecified).AddTicks(8142), new TimeSpan(0, 0, 0, 0, 0)), "a71b8d86-286d-4461-9b1a-e9f6c3c0a3e0" });

            migrationBuilder.UpdateData(
                schema: "Cars",
                table: "Brands",
                keyColumn: "Id",
                keyValue: "2VS5yLgAuj7VmYeRVxTD",
                columns: new[] { "DateCreated", "TrackId" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 4, 11, 13, 51, 43, 808, DateTimeKind.Unspecified).AddTicks(8148), new TimeSpan(0, 0, 0, 0, 0)), "7f1796c7-a48a-4d2a-8e19-58acd451f871" });

            migrationBuilder.UpdateData(
                schema: "Cars",
                table: "Brands",
                keyColumn: "Id",
                keyValue: "2xSRLgR4QgzYhDLjfgAM",
                columns: new[] { "DateCreated", "TrackId" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 4, 11, 13, 51, 43, 808, DateTimeKind.Unspecified).AddTicks(8153), new TimeSpan(0, 0, 0, 0, 0)), "fb33a691-5cc7-43fc-a382-0143764963d4" });

            migrationBuilder.UpdateData(
                schema: "Cars",
                table: "Brands",
                keyColumn: "Id",
                keyValue: "3qGrKAnyJ2rmHlevXb8c",
                columns: new[] { "DateCreated", "TrackId" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 4, 11, 13, 51, 43, 808, DateTimeKind.Unspecified).AddTicks(8161), new TimeSpan(0, 0, 0, 0, 0)), "70e0610e-dd43-43fe-8efa-317b8003cd1f" });

            migrationBuilder.UpdateData(
                schema: "Cars",
                table: "Brands",
                keyColumn: "Id",
                keyValue: "3yTpJND7nxjtqoDcuc5M",
                columns: new[] { "DateCreated", "TrackId" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 4, 11, 13, 51, 43, 808, DateTimeKind.Unspecified).AddTicks(8167), new TimeSpan(0, 0, 0, 0, 0)), "cf22c05d-6fce-47dc-8a07-69ac5bde51bc" });

            migrationBuilder.UpdateData(
                schema: "Cars",
                table: "Brands",
                keyColumn: "Id",
                keyValue: "470SJrcKER8YaPHSS0br",
                columns: new[] { "DateCreated", "TrackId" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 4, 11, 13, 51, 43, 808, DateTimeKind.Unspecified).AddTicks(8173), new TimeSpan(0, 0, 0, 0, 0)), "bfaa6f18-68c5-45b5-8d0a-ec471a70135e" });

            migrationBuilder.UpdateData(
                schema: "Cars",
                table: "Brands",
                keyColumn: "Id",
                keyValue: "48xSUCHrRIfABkLmGHxD",
                columns: new[] { "DateCreated", "TrackId" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 4, 11, 13, 51, 43, 808, DateTimeKind.Unspecified).AddTicks(8178), new TimeSpan(0, 0, 0, 0, 0)), "039c9c27-8956-4a26-a20d-d9975ecde17f" });

            migrationBuilder.UpdateData(
                schema: "Cars",
                table: "Brands",
                keyColumn: "Id",
                keyValue: "5aFWwvagmpfBWQlHxU5M",
                columns: new[] { "DateCreated", "TrackId" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 4, 11, 13, 51, 43, 808, DateTimeKind.Unspecified).AddTicks(8686), new TimeSpan(0, 0, 0, 0, 0)), "24e6e4c8-d3ce-43ef-aeb8-037f932585a6" });

            migrationBuilder.UpdateData(
                schema: "Cars",
                table: "Brands",
                keyColumn: "Id",
                keyValue: "5kDhCqXf6JTAIvz61oEz",
                columns: new[] { "DateCreated", "TrackId" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 4, 11, 13, 51, 43, 808, DateTimeKind.Unspecified).AddTicks(8700), new TimeSpan(0, 0, 0, 0, 0)), "5cb02edf-22f8-4d06-bfa2-960a5feabc9c" });

            migrationBuilder.UpdateData(
                schema: "Cars",
                table: "Brands",
                keyColumn: "Id",
                keyValue: "5TgVdpBPF4SsQWVFP08j",
                columns: new[] { "DateCreated", "TrackId" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 4, 11, 13, 51, 43, 808, DateTimeKind.Unspecified).AddTicks(8709), new TimeSpan(0, 0, 0, 0, 0)), "35e85dad-473c-4848-8478-7b073ae57d36" });

            migrationBuilder.UpdateData(
                schema: "Cars",
                table: "Brands",
                keyColumn: "Id",
                keyValue: "65B72rCez5bGWR7Po3Ny",
                columns: new[] { "DateCreated", "TrackId" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 4, 11, 13, 51, 43, 808, DateTimeKind.Unspecified).AddTicks(8717), new TimeSpan(0, 0, 0, 0, 0)), "b0130a3d-11b8-4da7-8f47-2e5379555eb6" });

            migrationBuilder.UpdateData(
                schema: "Cars",
                table: "Brands",
                keyColumn: "Id",
                keyValue: "6mI4J3fGUdG5KvEHYjqL",
                columns: new[] { "DateCreated", "TrackId" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 4, 11, 13, 51, 43, 808, DateTimeKind.Unspecified).AddTicks(8729), new TimeSpan(0, 0, 0, 0, 0)), "655b253a-3721-4e3b-bb58-7712f915edb4" });

            migrationBuilder.UpdateData(
                schema: "Cars",
                table: "Brands",
                keyColumn: "Id",
                keyValue: "7ReFhJXxyx7pAkvlW1eS",
                columns: new[] { "DateCreated", "TrackId" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 4, 11, 13, 51, 43, 808, DateTimeKind.Unspecified).AddTicks(8738), new TimeSpan(0, 0, 0, 0, 0)), "8cee055c-e6de-4c68-a07a-462e349d477b" });

            migrationBuilder.UpdateData(
                schema: "Cars",
                table: "Brands",
                keyColumn: "Id",
                keyValue: "8mIlNn2498yIC72vgKBK",
                columns: new[] { "DateCreated", "TrackId" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 4, 11, 13, 51, 43, 808, DateTimeKind.Unspecified).AddTicks(8747), new TimeSpan(0, 0, 0, 0, 0)), "04c1711d-ee4d-4f65-8782-76e6cf8ce842" });

            migrationBuilder.UpdateData(
                schema: "Cars",
                table: "Brands",
                keyColumn: "Id",
                keyValue: "9NRn3UNnrPnf2yJoGIBH",
                columns: new[] { "DateCreated", "TrackId" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 4, 11, 13, 51, 43, 808, DateTimeKind.Unspecified).AddTicks(8755), new TimeSpan(0, 0, 0, 0, 0)), "929fab67-e57e-4ef8-8e4a-3f707be403d9" });

            migrationBuilder.UpdateData(
                schema: "Cars",
                table: "Brands",
                keyColumn: "Id",
                keyValue: "aPIB6410rSAP3jxueo2Y",
                columns: new[] { "DateCreated", "TrackId" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 4, 11, 13, 51, 43, 808, DateTimeKind.Unspecified).AddTicks(8764), new TimeSpan(0, 0, 0, 0, 0)), "71fb6dcc-2da2-41d5-8bc7-93bca75b2ffa" });

            migrationBuilder.UpdateData(
                schema: "Cars",
                table: "Brands",
                keyColumn: "Id",
                keyValue: "ATbb9NezfDxSdpBXdqd6",
                columns: new[] { "DateCreated", "TrackId" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 4, 11, 13, 51, 43, 808, DateTimeKind.Unspecified).AddTicks(8827), new TimeSpan(0, 0, 0, 0, 0)), "908d0a2c-72c4-4cff-b423-e83516eaeb0e" });

            migrationBuilder.UpdateData(
                schema: "Cars",
                table: "Brands",
                keyColumn: "Id",
                keyValue: "axxx6410rzzz3jxueox5",
                columns: new[] { "DateCreated", "TrackId" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 4, 11, 13, 51, 43, 808, DateTimeKind.Unspecified).AddTicks(8773), new TimeSpan(0, 0, 0, 0, 0)), "4ca300a3-5e66-4c74-8b44-b91ecc30c439" });

            migrationBuilder.UpdateData(
                schema: "Cars",
                table: "Brands",
                keyColumn: "Id",
                keyValue: "B42TXsELwNJNBewRvcu5",
                columns: new[] { "DateCreated", "TrackId" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 4, 11, 13, 51, 43, 808, DateTimeKind.Unspecified).AddTicks(8836), new TimeSpan(0, 0, 0, 0, 0)), "8e36306f-b739-4626-bcdf-37323e934ff3" });

            migrationBuilder.UpdateData(
                schema: "Cars",
                table: "Brands",
                keyColumn: "Id",
                keyValue: "BESQA89ghmpmxnMv6lb4",
                columns: new[] { "DateCreated", "TrackId" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 4, 11, 13, 51, 43, 808, DateTimeKind.Unspecified).AddTicks(8845), new TimeSpan(0, 0, 0, 0, 0)), "3ac29340-5cd9-499b-a641-48c66a4caf88" });

            migrationBuilder.UpdateData(
                schema: "Cars",
                table: "Brands",
                keyColumn: "Id",
                keyValue: "bshsdfzU1lNaPe58k9Io",
                columns: new[] { "DateCreated", "TrackId" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 4, 11, 13, 51, 43, 808, DateTimeKind.Unspecified).AddTicks(8852), new TimeSpan(0, 0, 0, 0, 0)), "11162aaf-0bab-46bf-8777-1df1fa3707ca" });

            migrationBuilder.UpdateData(
                schema: "Cars",
                table: "Brands",
                keyColumn: "Id",
                keyValue: "bXGDbcoVlUUFaUAeuBhU",
                columns: new[] { "DateCreated", "TrackId" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 4, 11, 13, 51, 43, 808, DateTimeKind.Unspecified).AddTicks(8858), new TimeSpan(0, 0, 0, 0, 0)), "41f071cf-fd42-435d-be38-2ee8a97ad3ac" });

            migrationBuilder.UpdateData(
                schema: "Cars",
                table: "Brands",
                keyColumn: "Id",
                keyValue: "bymbQs0TabKzPsrN3TlL",
                columns: new[] { "DateCreated", "TrackId" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 4, 11, 13, 51, 43, 808, DateTimeKind.Unspecified).AddTicks(8863), new TimeSpan(0, 0, 0, 0, 0)), "c9b574e3-2ddb-4540-92e9-2bc1cc34c739" });

            migrationBuilder.UpdateData(
                schema: "Cars",
                table: "Brands",
                keyColumn: "Id",
                keyValue: "CDKhu32A8uPkeWM4eblC",
                columns: new[] { "DateCreated", "TrackId" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 4, 11, 13, 51, 43, 808, DateTimeKind.Unspecified).AddTicks(8869), new TimeSpan(0, 0, 0, 0, 0)), "0685c61e-9e8a-4426-a5ac-4d93b3656c9c" });

            migrationBuilder.UpdateData(
                schema: "Cars",
                table: "Brands",
                keyColumn: "Id",
                keyValue: "cjnwEk8Wle037jtonYsj",
                columns: new[] { "DateCreated", "TrackId" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 4, 11, 13, 51, 43, 808, DateTimeKind.Unspecified).AddTicks(8875), new TimeSpan(0, 0, 0, 0, 0)), "cc8f50e1-8607-4cdb-8ca9-7d723e3d7d8e" });

            migrationBuilder.UpdateData(
                schema: "Cars",
                table: "Brands",
                keyColumn: "Id",
                keyValue: "cYgoBzV1QqkgGALBMqxE",
                columns: new[] { "DateCreated", "TrackId" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 4, 11, 13, 51, 43, 808, DateTimeKind.Unspecified).AddTicks(8880), new TimeSpan(0, 0, 0, 0, 0)), "7630aa34-255d-410b-bb95-dc4cf1011f77" });

            migrationBuilder.UpdateData(
                schema: "Cars",
                table: "Brands",
                keyColumn: "Id",
                keyValue: "cYlq5o6z4W9RcnLLB6zq",
                columns: new[] { "DateCreated", "TrackId" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 4, 11, 13, 51, 43, 808, DateTimeKind.Unspecified).AddTicks(8938), new TimeSpan(0, 0, 0, 0, 0)), "7eb13148-7c94-4d8b-b1a9-1e7ab933920c" });

            migrationBuilder.UpdateData(
                schema: "Cars",
                table: "Brands",
                keyColumn: "Id",
                keyValue: "D67BxpjC6stcD4YYGmdn",
                columns: new[] { "DateCreated", "TrackId" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 4, 11, 13, 51, 43, 808, DateTimeKind.Unspecified).AddTicks(8949), new TimeSpan(0, 0, 0, 0, 0)), "31b9f356-94ee-43cd-a9cd-9319dc2483b0" });

            migrationBuilder.UpdateData(
                schema: "Cars",
                table: "Brands",
                keyColumn: "Id",
                keyValue: "D6a4Vo3VE2WzDdgA5AFo",
                columns: new[] { "DateCreated", "TrackId" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 4, 11, 13, 51, 43, 808, DateTimeKind.Unspecified).AddTicks(8955), new TimeSpan(0, 0, 0, 0, 0)), "ffcdec17-5e08-49dc-a091-20e9fd492424" });

            migrationBuilder.UpdateData(
                schema: "Cars",
                table: "Brands",
                keyColumn: "Id",
                keyValue: "d6V8Py7xGhHTTVvS02QR",
                columns: new[] { "DateCreated", "TrackId" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 4, 11, 13, 51, 43, 808, DateTimeKind.Unspecified).AddTicks(8960), new TimeSpan(0, 0, 0, 0, 0)), "bf17647b-b85e-4f73-9ec6-c33b49018319" });

            migrationBuilder.UpdateData(
                schema: "Cars",
                table: "Brands",
                keyColumn: "Id",
                keyValue: "Dfej8VedBqRvW5SVCeo3",
                columns: new[] { "DateCreated", "TrackId" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 4, 11, 13, 51, 43, 808, DateTimeKind.Unspecified).AddTicks(8966), new TimeSpan(0, 0, 0, 0, 0)), "5687d7c5-280d-4842-9a96-55b7566532b1" });

            migrationBuilder.UpdateData(
                schema: "Cars",
                table: "Brands",
                keyColumn: "Id",
                keyValue: "dksqVUhgDuHJ9KJ2uqyP",
                columns: new[] { "DateCreated", "TrackId" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 4, 11, 13, 51, 43, 808, DateTimeKind.Unspecified).AddTicks(8972), new TimeSpan(0, 0, 0, 0, 0)), "376f57c1-4f63-41cd-acba-56b06b0df686" });

            migrationBuilder.UpdateData(
                schema: "Cars",
                table: "Brands",
                keyColumn: "Id",
                keyValue: "DsQDYqGhCx8KL7zF4UFK",
                columns: new[] { "DateCreated", "TrackId" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 4, 11, 13, 51, 43, 808, DateTimeKind.Unspecified).AddTicks(8978), new TimeSpan(0, 0, 0, 0, 0)), "96cf83d1-e14f-4aae-b957-4a2dcdc7193a" });

            migrationBuilder.UpdateData(
                schema: "Cars",
                table: "Brands",
                keyColumn: "Id",
                keyValue: "DumA309cvKSKLalqcW6h",
                columns: new[] { "DateCreated", "TrackId" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 4, 11, 13, 51, 43, 808, DateTimeKind.Unspecified).AddTicks(8984), new TimeSpan(0, 0, 0, 0, 0)), "3023179f-4a14-4818-896d-d2bafcc7cf4b" });

            migrationBuilder.UpdateData(
                schema: "Cars",
                table: "Brands",
                keyColumn: "Id",
                keyValue: "DV94kh1MyMbGW3P4aac5",
                columns: new[] { "DateCreated", "TrackId" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 4, 11, 13, 51, 43, 808, DateTimeKind.Unspecified).AddTicks(8990), new TimeSpan(0, 0, 0, 0, 0)), "27b72842-ebac-4639-a28a-f0f41fee6ddc" });

            migrationBuilder.UpdateData(
                schema: "Cars",
                table: "Brands",
                keyColumn: "Id",
                keyValue: "e7NrNKeWFc73uCAkz1Ar",
                columns: new[] { "DateCreated", "TrackId" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 4, 11, 13, 51, 43, 808, DateTimeKind.Unspecified).AddTicks(8998), new TimeSpan(0, 0, 0, 0, 0)), "af4e38d6-cdf7-4f78-b713-8fad0b02df30" });

            migrationBuilder.UpdateData(
                schema: "Cars",
                table: "Brands",
                keyColumn: "Id",
                keyValue: "eF1lrB1EP63Y0DablBJF",
                columns: new[] { "DateCreated", "TrackId" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 4, 11, 13, 51, 43, 808, DateTimeKind.Unspecified).AddTicks(9037), new TimeSpan(0, 0, 0, 0, 0)), "194ca82c-6c9a-4e5b-ac6c-69a44a259cf4" });

            migrationBuilder.UpdateData(
                schema: "Cars",
                table: "Brands",
                keyColumn: "Id",
                keyValue: "EMczl7VAvCRwT3kAz4In",
                columns: new[] { "DateCreated", "TrackId" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 4, 11, 13, 51, 43, 808, DateTimeKind.Unspecified).AddTicks(9043), new TimeSpan(0, 0, 0, 0, 0)), "b0efdfbb-2c27-4038-bd0b-04ddca6d940a" });

            migrationBuilder.UpdateData(
                schema: "Cars",
                table: "Brands",
                keyColumn: "Id",
                keyValue: "emn3h8NrhdSz7ojPBV2H",
                columns: new[] { "DateCreated", "TrackId" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 4, 11, 13, 51, 43, 808, DateTimeKind.Unspecified).AddTicks(9048), new TimeSpan(0, 0, 0, 0, 0)), "0a36c190-3261-4980-828c-a4322491d89b" });

            migrationBuilder.UpdateData(
                schema: "Cars",
                table: "Brands",
                keyColumn: "Id",
                keyValue: "etMtb4JLm7eB90mlnd72",
                columns: new[] { "DateCreated", "TrackId" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 4, 11, 13, 51, 43, 808, DateTimeKind.Unspecified).AddTicks(9054), new TimeSpan(0, 0, 0, 0, 0)), "b062467b-cd94-4100-97ef-7f01e73cd39c" });

            migrationBuilder.UpdateData(
                schema: "Cars",
                table: "Brands",
                keyColumn: "Id",
                keyValue: "eUMYrz00U0nQH5KTc7uR",
                columns: new[] { "DateCreated", "TrackId" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 4, 11, 13, 51, 43, 808, DateTimeKind.Unspecified).AddTicks(9060), new TimeSpan(0, 0, 0, 0, 0)), "2fe180ec-aebb-42cc-aa46-7398a08e43af" });

            migrationBuilder.UpdateData(
                schema: "Cars",
                table: "Brands",
                keyColumn: "Id",
                keyValue: "fAVrUUNVKFbMuNlP7oUW",
                columns: new[] { "DateCreated", "TrackId" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 4, 11, 13, 51, 43, 808, DateTimeKind.Unspecified).AddTicks(9065), new TimeSpan(0, 0, 0, 0, 0)), "fa99214f-2f7c-4013-9ec9-05cc914d487c" });

            migrationBuilder.UpdateData(
                schema: "Cars",
                table: "Brands",
                keyColumn: "Id",
                keyValue: "FcCNt3RVlzMFl9Jtw38m",
                columns: new[] { "DateCreated", "TrackId" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 4, 11, 13, 51, 43, 808, DateTimeKind.Unspecified).AddTicks(9071), new TimeSpan(0, 0, 0, 0, 0)), "383fbc0d-8aeb-40c2-a3f8-eecb3693c1e8" });

            migrationBuilder.UpdateData(
                schema: "Cars",
                table: "Brands",
                keyColumn: "Id",
                keyValue: "Fjw2xBL9BqCaQBzxcxDI",
                columns: new[] { "DateCreated", "TrackId" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 4, 11, 13, 51, 43, 808, DateTimeKind.Unspecified).AddTicks(9078), new TimeSpan(0, 0, 0, 0, 0)), "7ac286cd-890c-4b82-87dc-dab98fe734ba" });

            migrationBuilder.UpdateData(
                schema: "Cars",
                table: "Brands",
                keyColumn: "Id",
                keyValue: "FtX2HosXUQDnvSScsyP8",
                columns: new[] { "DateCreated", "TrackId" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 4, 11, 13, 51, 43, 808, DateTimeKind.Unspecified).AddTicks(9084), new TimeSpan(0, 0, 0, 0, 0)), "bf915c9b-fe9a-4da3-a33e-d0cd7e8a11a2" });

            migrationBuilder.UpdateData(
                schema: "Cars",
                table: "Brands",
                keyColumn: "Id",
                keyValue: "FXHe5SU6zyIfYHPGygNC",
                columns: new[] { "DateCreated", "TrackId" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 4, 11, 13, 51, 43, 808, DateTimeKind.Unspecified).AddTicks(9122), new TimeSpan(0, 0, 0, 0, 0)), "2e569f15-fc45-4c9d-88f1-0107bed5a444" });

            migrationBuilder.UpdateData(
                schema: "Cars",
                table: "Brands",
                keyColumn: "Id",
                keyValue: "GBnMMAvdjskIFpKTYLb1",
                columns: new[] { "DateCreated", "TrackId" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 4, 11, 13, 51, 43, 808, DateTimeKind.Unspecified).AddTicks(9128), new TimeSpan(0, 0, 0, 0, 0)), "396c15ec-3afa-4dbc-8cc3-b0003f132ddc" });

            migrationBuilder.UpdateData(
                schema: "Cars",
                table: "Brands",
                keyColumn: "Id",
                keyValue: "ghyFhm7jzcjYDrjMVLs1",
                columns: new[] { "DateCreated", "TrackId" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 4, 11, 13, 51, 43, 808, DateTimeKind.Unspecified).AddTicks(9133), new TimeSpan(0, 0, 0, 0, 0)), "81e1729b-13b7-4c1f-838a-d4ca625c08ae" });

            migrationBuilder.UpdateData(
                schema: "Cars",
                table: "Brands",
                keyColumn: "Id",
                keyValue: "gXuBjVjveGKf3R9Kc9vE",
                columns: new[] { "DateCreated", "TrackId" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 4, 11, 13, 51, 43, 808, DateTimeKind.Unspecified).AddTicks(9139), new TimeSpan(0, 0, 0, 0, 0)), "591b28ae-3f46-4281-a4d4-3b2dee100cf2" });

            migrationBuilder.UpdateData(
                schema: "Cars",
                table: "Brands",
                keyColumn: "Id",
                keyValue: "h6Bfvk5LdFwXv9QzKLxU",
                columns: new[] { "DateCreated", "TrackId" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 4, 11, 13, 51, 43, 808, DateTimeKind.Unspecified).AddTicks(9144), new TimeSpan(0, 0, 0, 0, 0)), "b92742d7-0c1c-41f1-bb10-9819de12a627" });

            migrationBuilder.UpdateData(
                schema: "Cars",
                table: "Brands",
                keyColumn: "Id",
                keyValue: "hajLAGmn9WWXQco4CXw1",
                columns: new[] { "DateCreated", "TrackId" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 4, 11, 13, 51, 43, 808, DateTimeKind.Unspecified).AddTicks(9150), new TimeSpan(0, 0, 0, 0, 0)), "15e92eb7-8304-4cb1-8fd4-e261240a439a" });

            migrationBuilder.UpdateData(
                schema: "Cars",
                table: "Brands",
                keyColumn: "Id",
                keyValue: "Hc1zhgoBCF1639Rp1PkY",
                columns: new[] { "DateCreated", "TrackId" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 4, 11, 13, 51, 43, 808, DateTimeKind.Unspecified).AddTicks(9158), new TimeSpan(0, 0, 0, 0, 0)), "ee8012cf-f9c4-419a-853e-fc7528821c4f" });

            migrationBuilder.UpdateData(
                schema: "Cars",
                table: "Brands",
                keyColumn: "Id",
                keyValue: "HhvYG9GBNEg7RhQBIjtY",
                columns: new[] { "DateCreated", "TrackId" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 4, 11, 13, 51, 43, 808, DateTimeKind.Unspecified).AddTicks(9163), new TimeSpan(0, 0, 0, 0, 0)), "880b2f36-0bad-4392-8915-4f3a9a77a92a" });

            migrationBuilder.UpdateData(
                schema: "Cars",
                table: "Brands",
                keyColumn: "Id",
                keyValue: "HKjqbIm3EQ96YdfpakFI",
                columns: new[] { "DateCreated", "TrackId" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 4, 11, 13, 51, 43, 808, DateTimeKind.Unspecified).AddTicks(9169), new TimeSpan(0, 0, 0, 0, 0)), "1b4f0256-33d7-4cbb-ba32-0be7e7da6ee7" });

            migrationBuilder.UpdateData(
                schema: "Cars",
                table: "Brands",
                keyColumn: "Id",
                keyValue: "HrERVHUdBMrdUrgLsvuT",
                columns: new[] { "DateCreated", "TrackId" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 4, 11, 13, 51, 43, 808, DateTimeKind.Unspecified).AddTicks(9174), new TimeSpan(0, 0, 0, 0, 0)), "fdc12efe-da87-4edf-bb96-8c0862896673" });

            migrationBuilder.UpdateData(
                schema: "Cars",
                table: "Brands",
                keyColumn: "Id",
                keyValue: "hy7DsFSFE0ugKvGj8Hfk",
                columns: new[] { "DateCreated", "TrackId" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 4, 11, 13, 51, 43, 808, DateTimeKind.Unspecified).AddTicks(9214), new TimeSpan(0, 0, 0, 0, 0)), "deef9e40-909c-4e98-bd58-bed76080d7ac" });

            migrationBuilder.UpdateData(
                schema: "Cars",
                table: "Brands",
                keyColumn: "Id",
                keyValue: "IIqtbBpQcKHy7TVA10Nl",
                columns: new[] { "DateCreated", "TrackId" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 4, 11, 13, 51, 43, 808, DateTimeKind.Unspecified).AddTicks(9220), new TimeSpan(0, 0, 0, 0, 0)), "8f1faf80-e735-4910-91bf-c8d59e3be19d" });

            migrationBuilder.UpdateData(
                schema: "Cars",
                table: "Brands",
                keyColumn: "Id",
                keyValue: "IR6qs66ukTVnB4w0NIFq",
                columns: new[] { "DateCreated", "TrackId" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 4, 11, 13, 51, 43, 808, DateTimeKind.Unspecified).AddTicks(9225), new TimeSpan(0, 0, 0, 0, 0)), "73af190b-187b-4dc4-9918-e618893000c3" });

            migrationBuilder.UpdateData(
                schema: "Cars",
                table: "Brands",
                keyColumn: "Id",
                keyValue: "j0N3jEL5HfQ9Ve0KVNUl",
                columns: new[] { "DateCreated", "TrackId" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 4, 11, 13, 51, 43, 808, DateTimeKind.Unspecified).AddTicks(9231), new TimeSpan(0, 0, 0, 0, 0)), "26e4fb56-f1c1-4821-b55d-f960699c85f8" });

            migrationBuilder.UpdateData(
                schema: "Cars",
                table: "Brands",
                keyColumn: "Id",
                keyValue: "J3wnurM4CgKVkRFfRvHs",
                columns: new[] { "DateCreated", "TrackId" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 4, 11, 13, 51, 43, 808, DateTimeKind.Unspecified).AddTicks(9238), new TimeSpan(0, 0, 0, 0, 0)), "45488e05-34e9-4fed-a471-64ee66a2d713" });

            migrationBuilder.UpdateData(
                schema: "Cars",
                table: "Brands",
                keyColumn: "Id",
                keyValue: "JqgJmqpSsWvQ7b60GLvq",
                columns: new[] { "DateCreated", "TrackId" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 4, 11, 13, 51, 43, 808, DateTimeKind.Unspecified).AddTicks(9243), new TimeSpan(0, 0, 0, 0, 0)), "19aa1296-82b6-4abc-b395-d0b18a05b69b" });

            migrationBuilder.UpdateData(
                schema: "Cars",
                table: "Brands",
                keyColumn: "Id",
                keyValue: "jyCumAseWnFjQjPzn3kQ",
                columns: new[] { "DateCreated", "TrackId" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 4, 11, 13, 51, 43, 808, DateTimeKind.Unspecified).AddTicks(9248), new TimeSpan(0, 0, 0, 0, 0)), "b27f999f-128a-4844-85fc-490aa7573249" });

            migrationBuilder.UpdateData(
                schema: "Cars",
                table: "Brands",
                keyColumn: "Id",
                keyValue: "k4Lylg5nrM6Vt1MrWfxS",
                columns: new[] { "DateCreated", "TrackId" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 4, 11, 13, 51, 43, 808, DateTimeKind.Unspecified).AddTicks(9254), new TimeSpan(0, 0, 0, 0, 0)), "f3ed3ab7-378f-45ed-a0af-284da864cb06" });

            migrationBuilder.UpdateData(
                schema: "Cars",
                table: "Brands",
                keyColumn: "Id",
                keyValue: "KCEkkBQL72L0jmEutbgl",
                columns: new[] { "DateCreated", "TrackId" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 4, 11, 13, 51, 43, 808, DateTimeKind.Unspecified).AddTicks(9259), new TimeSpan(0, 0, 0, 0, 0)), "e1ea126d-4635-44ff-889e-9c5d79e801a2" });

            migrationBuilder.UpdateData(
                schema: "Cars",
                table: "Brands",
                keyColumn: "Id",
                keyValue: "kF0x9WcUJs7aHYtoKzWY",
                columns: new[] { "DateCreated", "TrackId" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 4, 11, 13, 51, 43, 808, DateTimeKind.Unspecified).AddTicks(9297), new TimeSpan(0, 0, 0, 0, 0)), "22af345d-d748-4807-8c80-133d853d3011" });

            migrationBuilder.UpdateData(
                schema: "Cars",
                table: "Brands",
                keyColumn: "Id",
                keyValue: "KQMma7dRwtXlcym9oSWC",
                columns: new[] { "DateCreated", "TrackId" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 4, 11, 13, 51, 43, 808, DateTimeKind.Unspecified).AddTicks(9303), new TimeSpan(0, 0, 0, 0, 0)), "53c369be-ed98-413a-865f-0a1629bfd410" });

            migrationBuilder.UpdateData(
                schema: "Cars",
                table: "Brands",
                keyColumn: "Id",
                keyValue: "KRmmVEwPAtzSzJQgD6HY",
                columns: new[] { "DateCreated", "TrackId" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 4, 11, 13, 51, 43, 808, DateTimeKind.Unspecified).AddTicks(9309), new TimeSpan(0, 0, 0, 0, 0)), "f19990ae-ad38-4e8c-9b7b-896622e09c22" });

            migrationBuilder.UpdateData(
                schema: "Cars",
                table: "Brands",
                keyColumn: "Id",
                keyValue: "KvyHwQN3QMrXmgbsvne9",
                columns: new[] { "DateCreated", "TrackId" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 4, 11, 13, 51, 43, 808, DateTimeKind.Unspecified).AddTicks(9316), new TimeSpan(0, 0, 0, 0, 0)), "197450b6-0ee8-459b-b529-1c80cf66c74a" });

            migrationBuilder.UpdateData(
                schema: "Cars",
                table: "Brands",
                keyColumn: "Id",
                keyValue: "kXULxNaVDJWKs2ACmH5C",
                columns: new[] { "DateCreated", "TrackId" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 4, 11, 13, 51, 43, 808, DateTimeKind.Unspecified).AddTicks(9321), new TimeSpan(0, 0, 0, 0, 0)), "a53e59d1-4c39-4e8e-9422-21b9d22c963e" });

            migrationBuilder.UpdateData(
                schema: "Cars",
                table: "Brands",
                keyColumn: "Id",
                keyValue: "l5Xv7WgEwDFBEEnFG9uC",
                columns: new[] { "DateCreated", "TrackId" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 4, 11, 13, 51, 43, 808, DateTimeKind.Unspecified).AddTicks(9327), new TimeSpan(0, 0, 0, 0, 0)), "d8e19462-6b96-4546-a2fe-7e30afec58d9" });

            migrationBuilder.UpdateData(
                schema: "Cars",
                table: "Brands",
                keyColumn: "Id",
                keyValue: "laJM8lrsRY8D0eRYypqk",
                columns: new[] { "DateCreated", "TrackId" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 4, 11, 13, 51, 43, 808, DateTimeKind.Unspecified).AddTicks(9333), new TimeSpan(0, 0, 0, 0, 0)), "bd270537-83d1-4345-93fd-a056d9af4e4b" });

            migrationBuilder.UpdateData(
                schema: "Cars",
                table: "Brands",
                keyColumn: "Id",
                keyValue: "LcuKvSewzBSW3KEJdLIa",
                columns: new[] { "DateCreated", "TrackId" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 4, 11, 13, 51, 43, 808, DateTimeKind.Unspecified).AddTicks(9339), new TimeSpan(0, 0, 0, 0, 0)), "ab851f4d-1090-4939-a3e5-1909e3a74127" });

            migrationBuilder.UpdateData(
                schema: "Cars",
                table: "Brands",
                keyColumn: "Id",
                keyValue: "lEVEcrE9FIVtGbtFarHV",
                columns: new[] { "DateCreated", "TrackId" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 4, 11, 13, 51, 43, 808, DateTimeKind.Unspecified).AddTicks(9344), new TimeSpan(0, 0, 0, 0, 0)), "34247602-dd25-4767-bd96-4eec3b134e4f" });

            migrationBuilder.UpdateData(
                schema: "Cars",
                table: "Brands",
                keyColumn: "Id",
                keyValue: "lgRSEHsdarS0gC4osQWQ",
                columns: new[] { "DateCreated", "TrackId" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 4, 11, 13, 51, 43, 808, DateTimeKind.Unspecified).AddTicks(9350), new TimeSpan(0, 0, 0, 0, 0)), "d4b0df9a-f951-46b0-a722-3308b729d27b" });

            migrationBuilder.UpdateData(
                schema: "Cars",
                table: "Brands",
                keyColumn: "Id",
                keyValue: "Lxge9Bn07u7pWE0RqbwJ",
                columns: new[] { "DateCreated", "TrackId" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 4, 11, 13, 51, 43, 808, DateTimeKind.Unspecified).AddTicks(9829), new TimeSpan(0, 0, 0, 0, 0)), "19b84010-76b7-4abb-8121-01840cf04464" });

            migrationBuilder.UpdateData(
                schema: "Cars",
                table: "Brands",
                keyColumn: "Id",
                keyValue: "m5L90Q8l2fTcbPyeA3GF",
                columns: new[] { "DateCreated", "TrackId" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 4, 11, 13, 51, 43, 808, DateTimeKind.Unspecified).AddTicks(9843), new TimeSpan(0, 0, 0, 0, 0)), "9c913869-01c5-4492-bfb0-2b673d894fba" });

            migrationBuilder.UpdateData(
                schema: "Cars",
                table: "Brands",
                keyColumn: "Id",
                keyValue: "mEjXfYc5wzIHYnGGpCbE",
                columns: new[] { "DateCreated", "TrackId" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 4, 11, 13, 51, 43, 808, DateTimeKind.Unspecified).AddTicks(9852), new TimeSpan(0, 0, 0, 0, 0)), "dd2f358e-5325-462b-a3e9-d6cf72128132" });

            migrationBuilder.UpdateData(
                schema: "Cars",
                table: "Brands",
                keyColumn: "Id",
                keyValue: "MlFe1uw8xqqhdAUnqcHd",
                columns: new[] { "DateCreated", "TrackId" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 4, 11, 13, 51, 43, 808, DateTimeKind.Unspecified).AddTicks(9860), new TimeSpan(0, 0, 0, 0, 0)), "cec75a77-91f7-4d2c-bf25-89565de405ab" });

            migrationBuilder.UpdateData(
                schema: "Cars",
                table: "Brands",
                keyColumn: "Id",
                keyValue: "MvMqrrJaUbAAVIvJHQcu",
                columns: new[] { "DateCreated", "TrackId" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 4, 11, 13, 51, 43, 808, DateTimeKind.Unspecified).AddTicks(9869), new TimeSpan(0, 0, 0, 0, 0)), "eb202fb8-48d2-45e2-8f9a-376765f021d0" });

            migrationBuilder.UpdateData(
                schema: "Cars",
                table: "Brands",
                keyColumn: "Id",
                keyValue: "MX3aL9JN6gD0F4KRl0Nq",
                columns: new[] { "DateCreated", "TrackId" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 4, 11, 13, 51, 43, 808, DateTimeKind.Unspecified).AddTicks(9878), new TimeSpan(0, 0, 0, 0, 0)), "d2e2f037-6a11-4739-8799-6a00f1df4fbc" });

            migrationBuilder.UpdateData(
                schema: "Cars",
                table: "Brands",
                keyColumn: "Id",
                keyValue: "n1jg2wtcteSRvhvMGm4n",
                columns: new[] { "DateCreated", "TrackId" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 4, 11, 13, 51, 43, 808, DateTimeKind.Unspecified).AddTicks(9887), new TimeSpan(0, 0, 0, 0, 0)), "4fbcd145-da14-494f-9424-1b22d5237c0d" });

            migrationBuilder.UpdateData(
                schema: "Cars",
                table: "Brands",
                keyColumn: "Id",
                keyValue: "nDxKpo5IAKk62ekEBbNS",
                columns: new[] { "DateCreated", "TrackId" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 4, 11, 13, 51, 43, 808, DateTimeKind.Unspecified).AddTicks(9894), new TimeSpan(0, 0, 0, 0, 0)), "95d27ca2-e88e-4b4d-a6f4-e773a1f34fb7" });

            migrationBuilder.UpdateData(
                schema: "Cars",
                table: "Brands",
                keyColumn: "Id",
                keyValue: "nm2AJSoa0dWnayDNBRnh",
                columns: new[] { "DateCreated", "TrackId" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 4, 11, 13, 51, 43, 808, DateTimeKind.Unspecified).AddTicks(9901), new TimeSpan(0, 0, 0, 0, 0)), "edfa7495-b676-4fe6-9a96-371457d1f32d" });

            migrationBuilder.UpdateData(
                schema: "Cars",
                table: "Brands",
                keyColumn: "Id",
                keyValue: "nsITvMBs2Ujtv8rQ0KJM",
                columns: new[] { "DateCreated", "TrackId" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 4, 11, 13, 51, 43, 808, DateTimeKind.Unspecified).AddTicks(9944), new TimeSpan(0, 0, 0, 0, 0)), "685a5346-de04-417d-8c8b-66eac8224b98" });

            migrationBuilder.UpdateData(
                schema: "Cars",
                table: "Brands",
                keyColumn: "Id",
                keyValue: "nul5YjFdxToWeg1GrlCX",
                columns: new[] { "DateCreated", "TrackId" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 4, 11, 13, 51, 43, 808, DateTimeKind.Unspecified).AddTicks(9951), new TimeSpan(0, 0, 0, 0, 0)), "62078960-a875-40eb-9f27-3f7036f91a34" });

            migrationBuilder.UpdateData(
                schema: "Cars",
                table: "Brands",
                keyColumn: "Id",
                keyValue: "nWD6UJdXnV7cjq8tP6R8",
                columns: new[] { "DateCreated", "TrackId" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 4, 11, 13, 51, 43, 808, DateTimeKind.Unspecified).AddTicks(9956), new TimeSpan(0, 0, 0, 0, 0)), "773303b9-a57b-4cef-8b1d-7a69174f1081" });

            migrationBuilder.UpdateData(
                schema: "Cars",
                table: "Brands",
                keyColumn: "Id",
                keyValue: "oyETMjvBlpVLEDFlVADI",
                columns: new[] { "DateCreated", "TrackId" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 4, 11, 13, 51, 43, 808, DateTimeKind.Unspecified).AddTicks(9962), new TimeSpan(0, 0, 0, 0, 0)), "5698d606-9580-4ff6-bfcf-066db657a0a0" });

            migrationBuilder.UpdateData(
                schema: "Cars",
                table: "Brands",
                keyColumn: "Id",
                keyValue: "p4hD4RsKIPD68JMtt4N2",
                columns: new[] { "DateCreated", "TrackId" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 4, 11, 13, 51, 43, 808, DateTimeKind.Unspecified).AddTicks(9968), new TimeSpan(0, 0, 0, 0, 0)), "bb2657b4-a8dd-496a-92f5-96753cf8da7f" });

            migrationBuilder.UpdateData(
                schema: "Cars",
                table: "Brands",
                keyColumn: "Id",
                keyValue: "p6Wbw5sW2Fj67lvp482v",
                columns: new[] { "DateCreated", "TrackId" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 4, 11, 13, 51, 43, 808, DateTimeKind.Unspecified).AddTicks(9974), new TimeSpan(0, 0, 0, 0, 0)), "028d15c9-d6e7-4cb8-a5ed-515db55849c3" });

            migrationBuilder.UpdateData(
                schema: "Cars",
                table: "Brands",
                keyColumn: "Id",
                keyValue: "pjQ5tv7x5L1UYaKzhokc",
                columns: new[] { "DateCreated", "TrackId" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 4, 11, 13, 51, 43, 808, DateTimeKind.Unspecified).AddTicks(9986), new TimeSpan(0, 0, 0, 0, 0)), "e64368de-bd2d-44e9-b5e5-26f3b13169d4" });

            migrationBuilder.UpdateData(
                schema: "Cars",
                table: "Brands",
                keyColumn: "Id",
                keyValue: "PpQFVF4cAQlfX3BppjFB",
                columns: new[] { "DateCreated", "TrackId" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 4, 11, 13, 51, 43, 808, DateTimeKind.Unspecified).AddTicks(9993), new TimeSpan(0, 0, 0, 0, 0)), "2195945c-7151-42aa-bd7b-bf36413204f9" });

            migrationBuilder.UpdateData(
                schema: "Cars",
                table: "Brands",
                keyColumn: "Id",
                keyValue: "PsbTIAKWHCVgruG7IgRE",
                columns: new[] { "DateCreated", "TrackId" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 4, 11, 13, 51, 43, 808, DateTimeKind.Unspecified).AddTicks(9999), new TimeSpan(0, 0, 0, 0, 0)), "d44445f2-5113-48aa-b980-ca044f4185b6" });

            migrationBuilder.UpdateData(
                schema: "Cars",
                table: "Brands",
                keyColumn: "Id",
                keyValue: "pTCUtnhqCmkJALgYU8NY",
                columns: new[] { "DateCreated", "TrackId" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 4, 11, 13, 51, 43, 809, DateTimeKind.Unspecified).AddTicks(37), new TimeSpan(0, 0, 0, 0, 0)), "d6758dd7-24f6-4e62-ac8a-caf1001eac7b" });

            migrationBuilder.UpdateData(
                schema: "Cars",
                table: "Brands",
                keyColumn: "Id",
                keyValue: "Q6kJ5uDgBmklCCBwofrx",
                columns: new[] { "DateCreated", "TrackId" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 4, 11, 13, 51, 43, 809, DateTimeKind.Unspecified).AddTicks(43), new TimeSpan(0, 0, 0, 0, 0)), "d2d512ad-bece-4829-bdbc-a777f19944c4" });

            migrationBuilder.UpdateData(
                schema: "Cars",
                table: "Brands",
                keyColumn: "Id",
                keyValue: "QExc6n8HRxp39gGTKXSt",
                columns: new[] { "DateCreated", "TrackId" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 4, 11, 13, 51, 43, 809, DateTimeKind.Unspecified).AddTicks(49), new TimeSpan(0, 0, 0, 0, 0)), "ec174f20-eb26-4efe-a301-050cf1a9d3cc" });

            migrationBuilder.UpdateData(
                schema: "Cars",
                table: "Brands",
                keyColumn: "Id",
                keyValue: "qnkV2dT7G6arP780Dwxs",
                columns: new[] { "DateCreated", "TrackId" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 4, 11, 13, 51, 43, 809, DateTimeKind.Unspecified).AddTicks(55), new TimeSpan(0, 0, 0, 0, 0)), "71a10558-1c2f-4571-855a-38fe4189b06a" });

            migrationBuilder.UpdateData(
                schema: "Cars",
                table: "Brands",
                keyColumn: "Id",
                keyValue: "QojugShL0F4QRXbwv1r3",
                columns: new[] { "DateCreated", "TrackId" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 4, 11, 13, 51, 43, 809, DateTimeKind.Unspecified).AddTicks(61), new TimeSpan(0, 0, 0, 0, 0)), "ac7895e4-60c0-4e22-836b-a3ead67c1538" });

            migrationBuilder.UpdateData(
                schema: "Cars",
                table: "Brands",
                keyColumn: "Id",
                keyValue: "QS0jwSg5owyS3XS5xnbY",
                columns: new[] { "DateCreated", "TrackId" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 4, 11, 13, 51, 43, 809, DateTimeKind.Unspecified).AddTicks(66), new TimeSpan(0, 0, 0, 0, 0)), "e941f6a1-a413-41f1-8101-a37564eb37de" });

            migrationBuilder.UpdateData(
                schema: "Cars",
                table: "Brands",
                keyColumn: "Id",
                keyValue: "R0e7DzoQBFL5UIyTpqDP",
                columns: new[] { "DateCreated", "TrackId" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 4, 11, 13, 51, 43, 809, DateTimeKind.Unspecified).AddTicks(73), new TimeSpan(0, 0, 0, 0, 0)), "4b6afb78-c077-4c17-8b8b-8f6939c4d9f1" });

            migrationBuilder.UpdateData(
                schema: "Cars",
                table: "Brands",
                keyColumn: "Id",
                keyValue: "R9BIHlzCwb67GPT89e7F",
                columns: new[] { "DateCreated", "TrackId" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 4, 11, 13, 51, 43, 809, DateTimeKind.Unspecified).AddTicks(79), new TimeSpan(0, 0, 0, 0, 0)), "4bf2106a-bb6c-42c4-ad49-9898dd246459" });

            migrationBuilder.UpdateData(
                schema: "Cars",
                table: "Brands",
                keyColumn: "Id",
                keyValue: "RgqbbBCJaJLWTlu87M9R",
                columns: new[] { "DateCreated", "TrackId" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 4, 11, 13, 51, 43, 809, DateTimeKind.Unspecified).AddTicks(85), new TimeSpan(0, 0, 0, 0, 0)), "13c3bd99-0137-455c-9d30-28317f645c7c" });

            migrationBuilder.UpdateData(
                schema: "Cars",
                table: "Brands",
                keyColumn: "Id",
                keyValue: "RRr4RDrnqyqmT3ehdy6Q",
                columns: new[] { "DateCreated", "TrackId" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 4, 11, 13, 51, 43, 809, DateTimeKind.Unspecified).AddTicks(135), new TimeSpan(0, 0, 0, 0, 0)), "146b364a-c7d2-43a5-9cc6-a84eda40d7d6" });

            migrationBuilder.UpdateData(
                schema: "Cars",
                table: "Brands",
                keyColumn: "Id",
                keyValue: "RuSMmRIATbwWRYSkgIrH",
                columns: new[] { "DateCreated", "TrackId" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 4, 11, 13, 51, 43, 809, DateTimeKind.Unspecified).AddTicks(142), new TimeSpan(0, 0, 0, 0, 0)), "d07eddc3-8fc5-4230-8c9d-3c91b17f1100" });

            migrationBuilder.UpdateData(
                schema: "Cars",
                table: "Brands",
                keyColumn: "Id",
                keyValue: "rYJp3Jg61wKdUqFGSAp3",
                columns: new[] { "DateCreated", "TrackId" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 4, 11, 13, 51, 43, 809, DateTimeKind.Unspecified).AddTicks(147), new TimeSpan(0, 0, 0, 0, 0)), "40a79f07-4c8e-443c-9f6f-c4cd9d06974a" });

            migrationBuilder.UpdateData(
                schema: "Cars",
                table: "Brands",
                keyColumn: "Id",
                keyValue: "sAKTDDgl9EDeyYnG77R8",
                columns: new[] { "DateCreated", "TrackId" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 4, 11, 13, 51, 43, 809, DateTimeKind.Unspecified).AddTicks(153), new TimeSpan(0, 0, 0, 0, 0)), "0f6aa7af-a44e-429f-acbe-0f618be8f789" });

            migrationBuilder.UpdateData(
                schema: "Cars",
                table: "Brands",
                keyColumn: "Id",
                keyValue: "SGKURGhEbYHIdqkxpDJh",
                columns: new[] { "DateCreated", "TrackId" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 4, 11, 13, 51, 43, 809, DateTimeKind.Unspecified).AddTicks(159), new TimeSpan(0, 0, 0, 0, 0)), "9124b8d4-8365-4ee9-8e82-8d18f8351e05" });

            migrationBuilder.UpdateData(
                schema: "Cars",
                table: "Brands",
                keyColumn: "Id",
                keyValue: "Sn4CRrl6hfVTTra5B0pd",
                columns: new[] { "DateCreated", "TrackId" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 4, 11, 13, 51, 43, 809, DateTimeKind.Unspecified).AddTicks(166), new TimeSpan(0, 0, 0, 0, 0)), "670389ba-d337-43a0-9326-0c72ed3f5fe9" });

            migrationBuilder.UpdateData(
                schema: "Cars",
                table: "Brands",
                keyColumn: "Id",
                keyValue: "sQ5C4f7H60rzJLhMA0T5",
                columns: new[] { "DateCreated", "TrackId" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 4, 11, 13, 51, 43, 809, DateTimeKind.Unspecified).AddTicks(172), new TimeSpan(0, 0, 0, 0, 0)), "6cedfa54-51c4-469e-bbb8-42adfb3bf091" });

            migrationBuilder.UpdateData(
                schema: "Cars",
                table: "Brands",
                keyColumn: "Id",
                keyValue: "sSh78RpjbHGvjL43TzMl",
                columns: new[] { "DateCreated", "TrackId" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 4, 11, 13, 51, 43, 809, DateTimeKind.Unspecified).AddTicks(178), new TimeSpan(0, 0, 0, 0, 0)), "289d0fb1-bc4c-454f-8b5b-ff53896a57b2" });

            migrationBuilder.UpdateData(
                schema: "Cars",
                table: "Brands",
                keyColumn: "Id",
                keyValue: "Sw3e46nyzgd7zmMPVG4r",
                columns: new[] { "DateCreated", "TrackId" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 4, 11, 13, 51, 43, 809, DateTimeKind.Unspecified).AddTicks(183), new TimeSpan(0, 0, 0, 0, 0)), "df8fdf1d-c5b6-4236-81ac-2f28afa6360a" });

            migrationBuilder.UpdateData(
                schema: "Cars",
                table: "Brands",
                keyColumn: "Id",
                keyValue: "sx9Vqv3yxRnX4SGwQa4y",
                columns: new[] { "DateCreated", "TrackId" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 4, 11, 13, 51, 43, 809, DateTimeKind.Unspecified).AddTicks(189), new TimeSpan(0, 0, 0, 0, 0)), "21262ddb-1467-49b2-a1e2-33573f84625e" });

            migrationBuilder.UpdateData(
                schema: "Cars",
                table: "Brands",
                keyColumn: "Id",
                keyValue: "T8karRTfSTcM29oupBnt",
                columns: new[] { "DateCreated", "TrackId" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 4, 11, 13, 51, 43, 809, DateTimeKind.Unspecified).AddTicks(227), new TimeSpan(0, 0, 0, 0, 0)), "9fede690-2319-4c99-b1ea-cb7e939eb486" });

            migrationBuilder.UpdateData(
                schema: "Cars",
                table: "Brands",
                keyColumn: "Id",
                keyValue: "t9gPoXWQAlKYkzxc7EaK",
                columns: new[] { "DateCreated", "TrackId" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 4, 11, 13, 51, 43, 809, DateTimeKind.Unspecified).AddTicks(232), new TimeSpan(0, 0, 0, 0, 0)), "b1b27123-f346-442b-8a02-624462f5a91c" });

            migrationBuilder.UpdateData(
                schema: "Cars",
                table: "Brands",
                keyColumn: "Id",
                keyValue: "TjjXJlSeru5Ccm3G2Vet",
                columns: new[] { "DateCreated", "TrackId" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 4, 11, 13, 51, 43, 809, DateTimeKind.Unspecified).AddTicks(238), new TimeSpan(0, 0, 0, 0, 0)), "79fd5e24-a99a-4ed7-b0da-e3ed1cfaec63" });

            migrationBuilder.UpdateData(
                schema: "Cars",
                table: "Brands",
                keyColumn: "Id",
                keyValue: "TJTAqICS7fjRu8I4afxm",
                columns: new[] { "DateCreated", "TrackId" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 4, 11, 13, 51, 43, 809, DateTimeKind.Unspecified).AddTicks(246), new TimeSpan(0, 0, 0, 0, 0)), "96c25e4d-b17e-43a2-aee1-a57d3de4b8ef" });

            migrationBuilder.UpdateData(
                schema: "Cars",
                table: "Brands",
                keyColumn: "Id",
                keyValue: "Tuaz0kuNQvU5jsy459u2",
                columns: new[] { "DateCreated", "TrackId" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 4, 11, 13, 51, 43, 809, DateTimeKind.Unspecified).AddTicks(251), new TimeSpan(0, 0, 0, 0, 0)), "39867cb1-8a70-4476-aee7-b5b0fe83e825" });

            migrationBuilder.UpdateData(
                schema: "Cars",
                table: "Brands",
                keyColumn: "Id",
                keyValue: "TXVRNj5SbqClTvNfEI8c",
                columns: new[] { "DateCreated", "TrackId" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 4, 11, 13, 51, 43, 809, DateTimeKind.Unspecified).AddTicks(257), new TimeSpan(0, 0, 0, 0, 0)), "b4e6daa8-1276-4a92-afef-4940ed27be4a" });

            migrationBuilder.UpdateData(
                schema: "Cars",
                table: "Brands",
                keyColumn: "Id",
                keyValue: "u3lzgWdKo9KaByo34lmN",
                columns: new[] { "DateCreated", "TrackId" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 4, 11, 13, 51, 43, 809, DateTimeKind.Unspecified).AddTicks(262), new TimeSpan(0, 0, 0, 0, 0)), "d5f87c04-8096-45e7-a21d-4daaa062800d" });

            migrationBuilder.UpdateData(
                schema: "Cars",
                table: "Brands",
                keyColumn: "Id",
                keyValue: "UG6N8tBL4hpBPkjX12Bh",
                columns: new[] { "DateCreated", "TrackId" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 4, 11, 13, 51, 43, 809, DateTimeKind.Unspecified).AddTicks(268), new TimeSpan(0, 0, 0, 0, 0)), "fab725fe-e816-4f46-ac7a-bc7fabaa2097" });

            migrationBuilder.UpdateData(
                schema: "Cars",
                table: "Brands",
                keyColumn: "Id",
                keyValue: "ulCdKx22IbD50hbfYtIE",
                columns: new[] { "DateCreated", "TrackId" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 4, 11, 13, 51, 43, 809, DateTimeKind.Unspecified).AddTicks(273), new TimeSpan(0, 0, 0, 0, 0)), "ecc57215-ded3-414c-895e-c9605ab88259" });

            migrationBuilder.UpdateData(
                schema: "Cars",
                table: "Brands",
                keyColumn: "Id",
                keyValue: "UpE1pLHfAgAQDHEVWdAb",
                columns: new[] { "DateCreated", "TrackId" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 4, 11, 13, 51, 43, 809, DateTimeKind.Unspecified).AddTicks(279), new TimeSpan(0, 0, 0, 0, 0)), "6e51b91e-f75f-4328-8996-9989064c6a25" });

            migrationBuilder.UpdateData(
                schema: "Cars",
                table: "Brands",
                keyColumn: "Id",
                keyValue: "UpsGGKBQ2fXfNQBgABoF",
                columns: new[] { "DateCreated", "TrackId" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 4, 11, 13, 51, 43, 809, DateTimeKind.Unspecified).AddTicks(318), new TimeSpan(0, 0, 0, 0, 0)), "6cec4b2e-b149-46a4-9f67-cf0d87a7cff4" });

            migrationBuilder.UpdateData(
                schema: "Cars",
                table: "Brands",
                keyColumn: "Id",
                keyValue: "v1Q2gNvx2B1YX6h2w0TR",
                columns: new[] { "DateCreated", "TrackId" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 4, 11, 13, 51, 43, 809, DateTimeKind.Unspecified).AddTicks(324), new TimeSpan(0, 0, 0, 0, 0)), "fc29aebc-edf5-41e0-86a8-1df59584dfb4" });

            migrationBuilder.UpdateData(
                schema: "Cars",
                table: "Brands",
                keyColumn: "Id",
                keyValue: "v4vruTNk6WkdcxN3fFA0",
                columns: new[] { "DateCreated", "TrackId" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 4, 11, 13, 51, 43, 809, DateTimeKind.Unspecified).AddTicks(330), new TimeSpan(0, 0, 0, 0, 0)), "117552e6-6ca5-4d6d-b98c-05b23a6d46f1" });

            migrationBuilder.UpdateData(
                schema: "Cars",
                table: "Brands",
                keyColumn: "Id",
                keyValue: "V9HWmNFfpUS2Y5eLqrct",
                columns: new[] { "DateCreated", "TrackId" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 4, 11, 13, 51, 43, 809, DateTimeKind.Unspecified).AddTicks(335), new TimeSpan(0, 0, 0, 0, 0)), "e8d92673-995f-419b-b5e6-b8f95f3eabbd" });

            migrationBuilder.UpdateData(
                schema: "Cars",
                table: "Brands",
                keyColumn: "Id",
                keyValue: "vMFor3Ks1QECjDpWHUqW",
                columns: new[] { "DateCreated", "TrackId" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 4, 11, 13, 51, 43, 809, DateTimeKind.Unspecified).AddTicks(341), new TimeSpan(0, 0, 0, 0, 0)), "3c53b93a-6b83-463a-b494-625e32950c56" });

            migrationBuilder.UpdateData(
                schema: "Cars",
                table: "Brands",
                keyColumn: "Id",
                keyValue: "vYf86TFDqUkh9RcEN9VN",
                columns: new[] { "DateCreated", "TrackId" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 4, 11, 13, 51, 43, 809, DateTimeKind.Unspecified).AddTicks(347), new TimeSpan(0, 0, 0, 0, 0)), "9b405f0c-41ef-4ea3-85db-38c347432bae" });

            migrationBuilder.UpdateData(
                schema: "Cars",
                table: "Brands",
                keyColumn: "Id",
                keyValue: "W5TnArCA9xCEodsTpDHG",
                columns: new[] { "DateCreated", "TrackId" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 4, 11, 13, 51, 43, 809, DateTimeKind.Unspecified).AddTicks(352), new TimeSpan(0, 0, 0, 0, 0)), "c12d5101-848d-4a3b-a349-7b938e11c63e" });

            migrationBuilder.UpdateData(
                schema: "Cars",
                table: "Brands",
                keyColumn: "Id",
                keyValue: "wC0Q8eUqQLkE6cpVwHgu",
                columns: new[] { "DateCreated", "TrackId" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 4, 11, 13, 51, 43, 809, DateTimeKind.Unspecified).AddTicks(358), new TimeSpan(0, 0, 0, 0, 0)), "6ff0d1d4-c6b3-4120-b5fb-c75b86a597d1" });

            migrationBuilder.UpdateData(
                schema: "Cars",
                table: "Brands",
                keyColumn: "Id",
                keyValue: "wDseIgWSpqkLesX2ftwn",
                columns: new[] { "DateCreated", "TrackId" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 4, 11, 13, 51, 43, 809, DateTimeKind.Unspecified).AddTicks(363), new TimeSpan(0, 0, 0, 0, 0)), "7eda1127-3d60-4b5e-906a-1244e42098af" });

            migrationBuilder.UpdateData(
                schema: "Cars",
                table: "Brands",
                keyColumn: "Id",
                keyValue: "whPfE6p1LaKgaGTWoNqj",
                columns: new[] { "DateCreated", "TrackId" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 4, 11, 13, 51, 43, 809, DateTimeKind.Unspecified).AddTicks(402), new TimeSpan(0, 0, 0, 0, 0)), "592485ae-a3e8-46c5-9ce5-e45d6fd01daf" });

            migrationBuilder.UpdateData(
                schema: "Cars",
                table: "Brands",
                keyColumn: "Id",
                keyValue: "wMQSzkfJzJhYwfV22Ew6",
                columns: new[] { "DateCreated", "TrackId" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 4, 11, 13, 51, 43, 809, DateTimeKind.Unspecified).AddTicks(408), new TimeSpan(0, 0, 0, 0, 0)), "ead28ad3-19c4-46d3-bee9-be9279220f07" });

            migrationBuilder.UpdateData(
                schema: "Cars",
                table: "Brands",
                keyColumn: "Id",
                keyValue: "wwSqJWvMPuau2LBxW24w",
                columns: new[] { "DateCreated", "TrackId" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 4, 11, 13, 51, 43, 809, DateTimeKind.Unspecified).AddTicks(414), new TimeSpan(0, 0, 0, 0, 0)), "b4883c49-b182-4893-a428-e9b3b46d2a30" });

            migrationBuilder.UpdateData(
                schema: "Cars",
                table: "Brands",
                keyColumn: "Id",
                keyValue: "XECbl6phGcsYXQWHwrT7",
                columns: new[] { "DateCreated", "TrackId" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 4, 11, 13, 51, 43, 809, DateTimeKind.Unspecified).AddTicks(419), new TimeSpan(0, 0, 0, 0, 0)), "920918a9-0760-40e7-b2c3-f92338f22f09" });

            migrationBuilder.UpdateData(
                schema: "Cars",
                table: "Brands",
                keyColumn: "Id",
                keyValue: "xHqKd4nN6cMLEAaL4zdp",
                columns: new[] { "DateCreated", "TrackId" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 4, 11, 13, 51, 43, 809, DateTimeKind.Unspecified).AddTicks(425), new TimeSpan(0, 0, 0, 0, 0)), "deff47b7-64f8-4301-bf74-0303ab656aa8" });

            migrationBuilder.UpdateData(
                schema: "Cars",
                table: "Brands",
                keyColumn: "Id",
                keyValue: "XQ0Nk2N0zDYDydY9CEpC",
                columns: new[] { "DateCreated", "TrackId" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 4, 11, 13, 51, 43, 809, DateTimeKind.Unspecified).AddTicks(430), new TimeSpan(0, 0, 0, 0, 0)), "482fb0d5-4d0c-47cb-9481-3b2c03e915b1" });

            migrationBuilder.UpdateData(
                schema: "Cars",
                table: "Brands",
                keyColumn: "Id",
                keyValue: "xqP1xuan2MoXnMkwolM7",
                columns: new[] { "DateCreated", "TrackId" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 4, 11, 13, 51, 43, 809, DateTimeKind.Unspecified).AddTicks(436), new TimeSpan(0, 0, 0, 0, 0)), "72fea1ba-ae94-46a2-a38b-baeb329a8cca" });

            migrationBuilder.UpdateData(
                schema: "Cars",
                table: "Brands",
                keyColumn: "Id",
                keyValue: "Xsx7AcUNguMUYwC2eInr",
                columns: new[] { "DateCreated", "TrackId" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 4, 11, 13, 51, 43, 809, DateTimeKind.Unspecified).AddTicks(442), new TimeSpan(0, 0, 0, 0, 0)), "f6d7c5af-64f3-4768-bc6f-8ff32c98158d" });

            migrationBuilder.UpdateData(
                schema: "Cars",
                table: "Brands",
                keyColumn: "Id",
                keyValue: "XW7Xpw80z3VgX82egcWN",
                columns: new[] { "DateCreated", "TrackId" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 4, 11, 13, 51, 43, 809, DateTimeKind.Unspecified).AddTicks(449), new TimeSpan(0, 0, 0, 0, 0)), "ce2e3bf3-c8e6-4c45-a846-1296976077ee" });

            migrationBuilder.UpdateData(
                schema: "Cars",
                table: "Brands",
                keyColumn: "Id",
                keyValue: "Xz43eo1VM5H41uNJ9x28",
                columns: new[] { "DateCreated", "TrackId" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 4, 11, 13, 51, 43, 809, DateTimeKind.Unspecified).AddTicks(455), new TimeSpan(0, 0, 0, 0, 0)), "f441c86e-a187-468c-a0aa-a41ac1d129f3" });

            migrationBuilder.UpdateData(
                schema: "Cars",
                table: "Brands",
                keyColumn: "Id",
                keyValue: "yjnmBGS0tfeUY6wppqlL",
                columns: new[] { "DateCreated", "TrackId" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 4, 11, 13, 51, 43, 809, DateTimeKind.Unspecified).AddTicks(926), new TimeSpan(0, 0, 0, 0, 0)), "3b66c037-2aaf-4861-88fb-f3803e373f10" });

            migrationBuilder.UpdateData(
                schema: "Cars",
                table: "Brands",
                keyColumn: "Id",
                keyValue: "YK3JYVEmHcskgB4f1s9M",
                columns: new[] { "DateCreated", "TrackId" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 4, 11, 13, 51, 43, 809, DateTimeKind.Unspecified).AddTicks(935), new TimeSpan(0, 0, 0, 0, 0)), "6f95e442-1e1e-4545-89b7-6b732ccad8da" });

            migrationBuilder.UpdateData(
                schema: "Cars",
                table: "Brands",
                keyColumn: "Id",
                keyValue: "YK3zzVEmH55kg41f1s2M",
                columns: new[] { "DateCreated", "TrackId" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 4, 11, 13, 51, 43, 809, DateTimeKind.Unspecified).AddTicks(944), new TimeSpan(0, 0, 0, 0, 0)), "8d6111a3-6d92-4000-a12b-4004692a0fb8" });

            migrationBuilder.UpdateData(
                schema: "Cars",
                table: "Brands",
                keyColumn: "Id",
                keyValue: "yL0kvEf81nf8Sd7CGQys",
                columns: new[] { "DateCreated", "TrackId" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 4, 11, 13, 51, 43, 809, DateTimeKind.Unspecified).AddTicks(953), new TimeSpan(0, 0, 0, 0, 0)), "a02513cd-e16d-414c-aed4-3f18301a900a" });

            migrationBuilder.UpdateData(
                schema: "Cars",
                table: "Brands",
                keyColumn: "Id",
                keyValue: "YSHfWTR5rJ8vCR2S95xp",
                columns: new[] { "DateCreated", "TrackId" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 4, 11, 13, 51, 43, 809, DateTimeKind.Unspecified).AddTicks(962), new TimeSpan(0, 0, 0, 0, 0)), "0db4b1a7-9c2c-432a-be9c-5f640fec0a78" });

            migrationBuilder.UpdateData(
                schema: "Cars",
                table: "Brands",
                keyColumn: "Id",
                keyValue: "YUWNuWGy76j0cK9LWTP8",
                columns: new[] { "DateCreated", "TrackId" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 4, 11, 13, 51, 43, 809, DateTimeKind.Unspecified).AddTicks(970), new TimeSpan(0, 0, 0, 0, 0)), "8bdd5b99-7022-4733-989f-16e731ebbbb2" });

            migrationBuilder.UpdateData(
                schema: "Cars",
                table: "Brands",
                keyColumn: "Id",
                keyValue: "zlaX6newWoQPagELHC4J",
                columns: new[] { "DateCreated", "TrackId" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 4, 11, 13, 51, 43, 809, DateTimeKind.Unspecified).AddTicks(982), new TimeSpan(0, 0, 0, 0, 0)), "d7e20b79-01a5-4ee5-a651-ed7be6c2692f" });

            migrationBuilder.UpdateData(
                schema: "Cars",
                table: "Brands",
                keyColumn: "Id",
                keyValue: "zmtbQwqcCyHjrSKk77Se",
                columns: new[] { "DateCreated", "TrackId" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 4, 11, 13, 51, 43, 809, DateTimeKind.Unspecified).AddTicks(991), new TimeSpan(0, 0, 0, 0, 0)), "7da5ea17-582b-4d63-a145-9713da6b6f3e" });

            migrationBuilder.UpdateData(
                schema: "Cars",
                table: "Brands",
                keyColumn: "Id",
                keyValue: "zpPwsvLWKJ4CmjHmU1ES",
                columns: new[] { "DateCreated", "TrackId" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 4, 11, 13, 51, 43, 809, DateTimeKind.Unspecified).AddTicks(997), new TimeSpan(0, 0, 0, 0, 0)), "caafcd32-8034-4d70-bdbe-d1df72b595de" });

            migrationBuilder.UpdateData(
                schema: "Cars",
                table: "Brands",
                keyColumn: "Id",
                keyValue: "zvQcGcl1nR7SpAfIMvxF",
                columns: new[] { "DateCreated", "TrackId" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 4, 11, 13, 51, 43, 809, DateTimeKind.Unspecified).AddTicks(1039), new TimeSpan(0, 0, 0, 0, 0)), "9b21d112-c4ae-4b49-acdb-2c38b2fcb93c" });

            migrationBuilder.UpdateData(
                schema: "Cars",
                table: "Brands",
                keyColumn: "Id",
                keyValue: "zzzbw5sz2hj27fvp4x2v",
                columns: new[] { "DateCreated", "TrackId" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 4, 11, 13, 51, 43, 808, DateTimeKind.Unspecified).AddTicks(9980), new TimeSpan(0, 0, 0, 0, 0)), "17817242-1a52-413e-8ca0-90d2d671d30f" });

            migrationBuilder.UpdateData(
                schema: "Troshka",
                table: "Categories",
                keyColumn: "Id",
                keyValue: "0Uun56AGjKNM2f07qMBS",
                columns: new[] { "DateCreated", "TrackId" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 4, 11, 13, 51, 43, 808, DateTimeKind.Unspecified).AddTicks(7754), new TimeSpan(0, 0, 0, 0, 0)), "0d66c266-31b9-45f2-a7a5-abcdf3e8c702" });

            migrationBuilder.UpdateData(
                schema: "Troshka",
                table: "Categories",
                keyColumn: "Id",
                keyValue: "AhHuT41lRddLH1wachlm",
                columns: new[] { "DateCreated", "TrackId" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 4, 11, 13, 51, 43, 808, DateTimeKind.Unspecified).AddTicks(7761), new TimeSpan(0, 0, 0, 0, 0)), "c01392a9-b297-447e-8cfe-bb30d67ca688" });

            migrationBuilder.UpdateData(
                schema: "Troshka",
                table: "Categories",
                keyColumn: "Id",
                keyValue: "DARdvjHJcTyGCYGekfIn",
                columns: new[] { "DateCreated", "TrackId" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 4, 11, 13, 51, 43, 808, DateTimeKind.Unspecified).AddTicks(7768), new TimeSpan(0, 0, 0, 0, 0)), "49687e4c-306d-4e77-8044-cd627360aa1e" });

            migrationBuilder.UpdateData(
                schema: "Troshka",
                table: "Categories",
                keyColumn: "Id",
                keyValue: "ExCL3LNxUqXNC8LFF8rL",
                columns: new[] { "DateCreated", "TrackId" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 4, 11, 13, 51, 43, 808, DateTimeKind.Unspecified).AddTicks(7774), new TimeSpan(0, 0, 0, 0, 0)), "6d3dfb24-2b9c-4a75-a654-74ee8b6a7c54" });

            migrationBuilder.UpdateData(
                schema: "Troshka",
                table: "Categories",
                keyColumn: "Id",
                keyValue: "GFF7R0xsM4muSxEG8k0J",
                columns: new[] { "DateCreated", "TrackId" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 4, 11, 13, 51, 43, 808, DateTimeKind.Unspecified).AddTicks(7826), new TimeSpan(0, 0, 0, 0, 0)), "e95ff4c3-fab7-4cc0-90a5-b6442f77c968" });

            migrationBuilder.UpdateData(
                schema: "Troshka",
                table: "Categories",
                keyColumn: "Id",
                keyValue: "lnm5mTuNV56JTQQYWPRe",
                columns: new[] { "DateCreated", "TrackId" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 4, 11, 13, 51, 43, 808, DateTimeKind.Unspecified).AddTicks(7832), new TimeSpan(0, 0, 0, 0, 0)), "1998ecdc-b561-4b9d-a5e5-3ee4e5077440" });

            migrationBuilder.UpdateData(
                schema: "Troshka",
                table: "Categories",
                keyColumn: "Id",
                keyValue: "NUSX1N5R2xUS9WfTo3lp",
                columns: new[] { "DateCreated", "TrackId" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 4, 11, 13, 51, 43, 808, DateTimeKind.Unspecified).AddTicks(7848), new TimeSpan(0, 0, 0, 0, 0)), "96f12160-c389-4ffb-b3d9-ac870450be07" });

            migrationBuilder.UpdateData(
                schema: "Troshka",
                table: "Categories",
                keyColumn: "Id",
                keyValue: "poo2JeVEhMn8wJz0KJdR",
                columns: new[] { "DateCreated", "TrackId" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 4, 11, 13, 51, 43, 808, DateTimeKind.Unspecified).AddTicks(7854), new TimeSpan(0, 0, 0, 0, 0)), "d4331911-265d-4ebb-b2bf-80597017ecff" });

            migrationBuilder.UpdateData(
                schema: "Cars",
                table: "Coupe",
                keyColumn: "Id",
                keyValue: "17uwRnksm3dHVtGXjxg8",
                columns: new[] { "DateCreated", "TrackId" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 4, 11, 13, 51, 43, 809, DateTimeKind.Unspecified).AddTicks(6502), new TimeSpan(0, 0, 0, 0, 0)), "5042e843-cde5-4cae-877e-764b70c00a8e" });

            migrationBuilder.UpdateData(
                schema: "Cars",
                table: "Coupe",
                keyColumn: "Id",
                keyValue: "3GLNa5pkWPOWVuSdVjdX",
                columns: new[] { "DateCreated", "TrackId" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 4, 11, 13, 51, 43, 809, DateTimeKind.Unspecified).AddTicks(6476), new TimeSpan(0, 0, 0, 0, 0)), "54d257c6-753a-4fd5-a0a6-2e1d131403bb" });

            migrationBuilder.UpdateData(
                schema: "Cars",
                table: "Coupe",
                keyColumn: "Id",
                keyValue: "JD9wmJVdkgyRHCXjCs7V",
                columns: new[] { "DateCreated", "TrackId" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 4, 11, 13, 51, 43, 809, DateTimeKind.Unspecified).AddTicks(6484), new TimeSpan(0, 0, 0, 0, 0)), "a8310f4f-22d4-4247-aeab-b395d7ce00b3" });

            migrationBuilder.UpdateData(
                schema: "Cars",
                table: "Coupe",
                keyColumn: "Id",
                keyValue: "pPrhSk2DBNYBz6sCoF81",
                columns: new[] { "DateCreated", "TrackId" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 4, 11, 13, 51, 43, 809, DateTimeKind.Unspecified).AddTicks(6507), new TimeSpan(0, 0, 0, 0, 0)), "275d5afb-d8ac-46c2-ab1e-e85bb2886cf3" });

            migrationBuilder.UpdateData(
                schema: "Cars",
                table: "Coupe",
                keyColumn: "Id",
                keyValue: "qpfpQc2ba4RuH4SUb2uI",
                columns: new[] { "DateCreated", "TrackId" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 4, 11, 13, 51, 43, 809, DateTimeKind.Unspecified).AddTicks(6555), new TimeSpan(0, 0, 0, 0, 0)), "82307f94-53b4-4202-9968-deca3ad17e40" });

            migrationBuilder.UpdateData(
                schema: "Cars",
                table: "Coupe",
                keyColumn: "Id",
                keyValue: "vqB7n29Zlq6pL8TKKL7j",
                columns: new[] { "DateCreated", "TrackId" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 4, 11, 13, 51, 43, 809, DateTimeKind.Unspecified).AddTicks(6496), new TimeSpan(0, 0, 0, 0, 0)), "d03d165f-e191-430c-b1eb-e5e8450e2d77" });

            migrationBuilder.UpdateData(
                schema: "Cars",
                table: "Coupe",
                keyColumn: "Id",
                keyValue: "xrAUDYo0LOc0HQWGSXVW",
                columns: new[] { "DateCreated", "TrackId" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 4, 11, 13, 51, 43, 809, DateTimeKind.Unspecified).AddTicks(6549), new TimeSpan(0, 0, 0, 0, 0)), "d3a7a714-cb52-47bd-a8af-4aeced302205" });

            migrationBuilder.UpdateData(
                schema: "Cars",
                table: "Coupe",
                keyColumn: "Id",
                keyValue: "ZfEvTe27FGIJe7I1eQkG",
                columns: new[] { "DateCreated", "TrackId" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 4, 11, 13, 51, 43, 809, DateTimeKind.Unspecified).AddTicks(6490), new TimeSpan(0, 0, 0, 0, 0)), "061ff3d2-3bc0-487d-9436-c7be2a85a7b2" });

            migrationBuilder.InsertData(
                schema: "Troshka",
                table: "Currencies",
                columns: new[] { "Id", "DateCreated", "DateDeleted", "DateUpdated", "IsDeleted", "Name", "TrackId" },
                values: new object[,]
                {
                    { "cmxdWnb7d1XkI2kYt1tn", new DateTimeOffset(new DateTime(2023, 4, 11, 13, 51, 43, 810, DateTimeKind.Unspecified).AddTicks(2669), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "USD", "a9e3e552-94c4-4184-924d-cc0894260a70" },
                    { "GWFxeUMQybuo8ooG0C9N", new DateTimeOffset(new DateTime(2023, 4, 11, 13, 51, 43, 810, DateTimeKind.Unspecified).AddTicks(2663), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "EUR", "cb12345f-bbcc-4170-af88-29f874bbde4a" },
                    { "Nt6E95kKmje2yp0kpmnp", new DateTimeOffset(new DateTime(2023, 4, 11, 13, 51, 43, 810, DateTimeKind.Unspecified).AddTicks(2657), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "BGN", "f3e7fd6a-390c-4af7-af0e-f6caa51b8b81" }
                });

            migrationBuilder.InsertData(
                schema: "Troshka",
                table: "Engines",
                columns: new[] { "Id", "DateCreated", "DateDeleted", "DateUpdated", "IsDeleted", "Name", "TrackId" },
                values: new object[,]
                {
                    { "7nrfrATU6wYRFlYhXar2", new DateTimeOffset(new DateTime(2023, 4, 11, 13, 51, 43, 810, DateTimeKind.Unspecified).AddTicks(2451), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "Plug-in хибрид", "8011c4d9-4064-4067-ab63-82717a0c2e8a" },
                    { "Dz9jEbh3b3mqoGX9IIAd", new DateTimeOffset(new DateTime(2023, 4, 11, 13, 51, 43, 810, DateTimeKind.Unspecified).AddTicks(2390), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "Бензин", "b900a619-c982-437b-94a0-6de498171994" },
                    { "gj7X5gw4FQ72IhK2eRfa", new DateTimeOffset(new DateTime(2023, 4, 11, 13, 51, 43, 810, DateTimeKind.Unspecified).AddTicks(2397), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "Дизел", "72ea6622-4afa-499a-8a94-ec64dd33370b" },
                    { "J90x9uTjNa7r8Ibt25rm", new DateTimeOffset(new DateTime(2023, 4, 11, 13, 51, 43, 810, DateTimeKind.Unspecified).AddTicks(2445), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "Хибрид", "e67d3e10-0057-434a-93ae-1554ce1162ae" },
                    { "o6oHm8z2thPuvJpQX172", new DateTimeOffset(new DateTime(2023, 4, 11, 13, 51, 43, 810, DateTimeKind.Unspecified).AddTicks(2403), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "Електрически", "0981d43d-7f15-41a4-ba2c-e9fe207718f3" }
                });

            migrationBuilder.InsertData(
                schema: "Troshka",
                table: "EuroStandards",
                columns: new[] { "Id", "DateCreated", "DateDeleted", "DateUpdated", "IsDeleted", "Name", "TrackId" },
                values: new object[,]
                {
                    { "KPEdwSvTqklMdWQxmN3e", new DateTimeOffset(new DateTime(2023, 4, 11, 13, 51, 43, 810, DateTimeKind.Unspecified).AddTicks(2749), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "Евро 3", "4bac8289-f3c7-4dd3-abac-fa9ed9a72a1a" },
                    { "moRoTsTCTLIIW7Exek7j", new DateTimeOffset(new DateTime(2023, 4, 11, 13, 51, 43, 810, DateTimeKind.Unspecified).AddTicks(2804), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "Евро 6", "4982f068-9e87-4228-80ee-9257c4c93ca8" },
                    { "Nq9WCGKAkkt71dp0bFNv", new DateTimeOffset(new DateTime(2023, 4, 11, 13, 51, 43, 810, DateTimeKind.Unspecified).AddTicks(2743), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "Евро 2", "0c1d05d8-6014-499a-874e-ae3182220170" },
                    { "nsLxuvw3TUbyBPPa7MYj", new DateTimeOffset(new DateTime(2023, 4, 11, 13, 51, 43, 810, DateTimeKind.Unspecified).AddTicks(2797), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "Евро 5", "d75daea0-e10c-48ce-a0d7-41ffbafb4760" },
                    { "TgkPPQopzcI9gu276e95", new DateTimeOffset(new DateTime(2023, 4, 11, 13, 51, 43, 810, DateTimeKind.Unspecified).AddTicks(2809), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "Евро 7", "9f946041-b479-4642-bc0a-a1dc927feb0d" },
                    { "UE7q5pASKodSn9fm5glj", new DateTimeOffset(new DateTime(2023, 4, 11, 13, 51, 43, 810, DateTimeKind.Unspecified).AddTicks(2737), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "Евро 1", "e87ed7c1-442e-4405-801c-dc5af7cfc253" },
                    { "y0zcBhtPxny7LFF2MI0Y", new DateTimeOffset(new DateTime(2023, 4, 11, 13, 51, 43, 810, DateTimeKind.Unspecified).AddTicks(2757), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "Евро 4", "e86f06a5-b920-48d3-84ab-ef09545e37b7" }
                });

            migrationBuilder.InsertData(
                schema: "Troshka",
                table: "Interior",
                columns: new[] { "Id", "DateCreated", "DateDeleted", "DateUpdated", "IsDeleted", "Name", "TrackId" },
                values: new object[,]
                {
                    { "eP9bxgGoUkJm25GayNFT", new DateTimeOffset(new DateTime(2023, 4, 11, 13, 51, 43, 810, DateTimeKind.Unspecified).AddTicks(2919), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "Кожа", "07e9542a-454c-4959-9f77-7518bfa8e2c2" },
                    { "QJTTXpWMEbft3uBSbd4G", new DateTimeOffset(new DateTime(2023, 4, 11, 13, 51, 43, 810, DateTimeKind.Unspecified).AddTicks(2925), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "Текстил", "fcfa4546-b672-4c5e-bbd3-4409a640eca9" },
                    { "yREGUWfTNNEjS61gp5Ee", new DateTimeOffset(new DateTime(2023, 4, 11, 13, 51, 43, 810, DateTimeKind.Unspecified).AddTicks(2913), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "Велур", "48eebe05-8c43-4ac2-957f-f5c251c8b4f0" }
                });

            migrationBuilder.UpdateData(
                schema: "Troshka",
                table: "Locations",
                keyColumn: "Id",
                keyValue: "0CjCASZC0LSzs6ToWDPf",
                columns: new[] { "DateCreated", "TrackId" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 4, 11, 13, 51, 43, 810, DateTimeKind.Unspecified).AddTicks(483), new TimeSpan(0, 0, 0, 0, 0)), "a0b97055-cf85-4b79-9ff8-93f75c2a4906" });

            migrationBuilder.UpdateData(
                schema: "Troshka",
                table: "Locations",
                keyColumn: "Id",
                keyValue: "0cN6OnAaAEe9twTMKNSL",
                columns: new[] { "DateCreated", "TrackId" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 4, 11, 13, 51, 43, 810, DateTimeKind.Unspecified).AddTicks(99), new TimeSpan(0, 0, 0, 0, 0)), "02a1a0cc-fcde-4a53-a4dc-159ab6601376" });

            migrationBuilder.UpdateData(
                schema: "Troshka",
                table: "Locations",
                keyColumn: "Id",
                keyValue: "0gRnjKRsK5HpggmJ35QP",
                columns: new[] { "DateCreated", "TrackId" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 4, 11, 13, 51, 43, 810, DateTimeKind.Unspecified).AddTicks(670), new TimeSpan(0, 0, 0, 0, 0)), "cf1aaf5e-3845-4d22-91d0-148b6cd0600a" });

            migrationBuilder.UpdateData(
                schema: "Troshka",
                table: "Locations",
                keyColumn: "Id",
                keyValue: "0kOlcUqNX3GmlqXlAfpU",
                columns: new[] { "DateCreated", "TrackId" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 4, 11, 13, 51, 43, 810, DateTimeKind.Unspecified).AddTicks(289), new TimeSpan(0, 0, 0, 0, 0)), "58f4aace-35d1-4f51-920d-a07349ad3281" });

            migrationBuilder.UpdateData(
                schema: "Troshka",
                table: "Locations",
                keyColumn: "Id",
                keyValue: "0mJJ1TNvJytdx93FG939",
                columns: new[] { "DateCreated", "TrackId" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 4, 11, 13, 51, 43, 810, DateTimeKind.Unspecified).AddTicks(35), new TimeSpan(0, 0, 0, 0, 0)), "82ad18c5-9554-47c9-aeed-fbb695a13871" });

            migrationBuilder.UpdateData(
                schema: "Troshka",
                table: "Locations",
                keyColumn: "Id",
                keyValue: "0OiRluH0unBrqtgrdIhc",
                columns: new[] { "DateCreated", "TrackId" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 4, 11, 13, 51, 43, 810, DateTimeKind.Unspecified).AddTicks(1601), new TimeSpan(0, 0, 0, 0, 0)), "22549ac9-63d9-4e0e-a7b2-7a340ae99c0a" });

            migrationBuilder.UpdateData(
                schema: "Troshka",
                table: "Locations",
                keyColumn: "Id",
                keyValue: "10unCs9PybUykwTtnWpJ",
                columns: new[] { "DateCreated", "TrackId" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 4, 11, 13, 51, 43, 810, DateTimeKind.Unspecified).AddTicks(1194), new TimeSpan(0, 0, 0, 0, 0)), "934ea7b8-a3b2-4dba-814f-132eb06663f4" });

            migrationBuilder.UpdateData(
                schema: "Troshka",
                table: "Locations",
                keyColumn: "Id",
                keyValue: "1bHqd1rUVLg6h6qfGLcS",
                columns: new[] { "DateCreated", "TrackId" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 4, 11, 13, 51, 43, 809, DateTimeKind.Unspecified).AddTicks(9268), new TimeSpan(0, 0, 0, 0, 0)), "408623d4-59ef-4a73-943d-e1b083218198" });

            migrationBuilder.UpdateData(
                schema: "Troshka",
                table: "Locations",
                keyColumn: "Id",
                keyValue: "1GRbG3rjQ2ofrU18THaz",
                columns: new[] { "DateCreated", "TrackId" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 4, 11, 13, 51, 43, 809, DateTimeKind.Unspecified).AddTicks(7812), new TimeSpan(0, 0, 0, 0, 0)), "c7321e15-391e-486c-81d6-ddab90c1318a" });

            migrationBuilder.UpdateData(
                schema: "Troshka",
                table: "Locations",
                keyColumn: "Id",
                keyValue: "1yxBQ20RxnTqWYg7ZpVO",
                columns: new[] { "DateCreated", "TrackId" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 4, 11, 13, 51, 43, 809, DateTimeKind.Unspecified).AddTicks(8184), new TimeSpan(0, 0, 0, 0, 0)), "9c98409e-0df4-4335-baa5-e456e74a2b6b" });

            migrationBuilder.UpdateData(
                schema: "Troshka",
                table: "Locations",
                keyColumn: "Id",
                keyValue: "20Fc8tVmtdLnnO9dK9PJ",
                columns: new[] { "DateCreated", "TrackId" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 4, 11, 13, 51, 43, 810, DateTimeKind.Unspecified).AddTicks(477), new TimeSpan(0, 0, 0, 0, 0)), "9eb43f58-4e07-46b5-a43b-da543e601c0a" });

            migrationBuilder.UpdateData(
                schema: "Troshka",
                table: "Locations",
                keyColumn: "Id",
                keyValue: "21myeuJwmBnKkl1V22jb",
                columns: new[] { "DateCreated", "TrackId" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 4, 11, 13, 51, 43, 810, DateTimeKind.Unspecified).AddTicks(1291), new TimeSpan(0, 0, 0, 0, 0)), "cd817ee5-47f4-4ed9-89dd-dc356c35ca79" });

            migrationBuilder.UpdateData(
                schema: "Troshka",
                table: "Locations",
                keyColumn: "Id",
                keyValue: "2IGYvWW5HtTpuUhzJzW0",
                columns: new[] { "DateCreated", "TrackId" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 4, 11, 13, 51, 43, 810, DateTimeKind.Unspecified).AddTicks(1180), new TimeSpan(0, 0, 0, 0, 0)), "79217d79-4779-40b6-b80b-0a7c8bc24d52" });

            migrationBuilder.UpdateData(
                schema: "Troshka",
                table: "Locations",
                keyColumn: "Id",
                keyValue: "2Q8Cnvp0xt0RlhXwWFrM",
                columns: new[] { "DateCreated", "TrackId" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 4, 11, 13, 51, 43, 810, DateTimeKind.Unspecified).AddTicks(582), new TimeSpan(0, 0, 0, 0, 0)), "f6a37b9c-c213-4f04-9346-8c00cd036fdd" });

            migrationBuilder.UpdateData(
                schema: "Troshka",
                table: "Locations",
                keyColumn: "Id",
                keyValue: "2RlfSIT8tVjqvQoF3Yzh",
                columns: new[] { "DateCreated", "TrackId" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 4, 11, 13, 51, 43, 810, DateTimeKind.Unspecified).AddTicks(80), new TimeSpan(0, 0, 0, 0, 0)), "144fd71a-6ad1-4a4e-8ca5-87e4923c5913" });

            migrationBuilder.UpdateData(
                schema: "Troshka",
                table: "Locations",
                keyColumn: "Id",
                keyValue: "3ON8ZtRO2cHeFGcMhvnT",
                columns: new[] { "DateCreated", "TrackId" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 4, 11, 13, 51, 43, 809, DateTimeKind.Unspecified).AddTicks(7901), new TimeSpan(0, 0, 0, 0, 0)), "005f6523-34a4-47ff-96a4-c70089757c37" });

            migrationBuilder.UpdateData(
                schema: "Troshka",
                table: "Locations",
                keyColumn: "Id",
                keyValue: "4Niku3WHFIAqKT1bLKbM",
                columns: new[] { "DateCreated", "TrackId" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 4, 11, 13, 51, 43, 809, DateTimeKind.Unspecified).AddTicks(9940), new TimeSpan(0, 0, 0, 0, 0)), "9bc68617-775d-447d-96a1-b3f83f9a0cb0" });

            migrationBuilder.UpdateData(
                schema: "Troshka",
                table: "Locations",
                keyColumn: "Id",
                keyValue: "51NCl8sofLRt5CZ6Ijb9",
                columns: new[] { "DateCreated", "TrackId" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 4, 11, 13, 51, 43, 809, DateTimeKind.Unspecified).AddTicks(9188), new TimeSpan(0, 0, 0, 0, 0)), "ea10527f-9d7c-493a-8d94-8eaedd6be28e" });

            migrationBuilder.UpdateData(
                schema: "Troshka",
                table: "Locations",
                keyColumn: "Id",
                keyValue: "58SC1K92gC6TIqc6YieE",
                columns: new[] { "DateCreated", "TrackId" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 4, 11, 13, 51, 43, 809, DateTimeKind.Unspecified).AddTicks(8086), new TimeSpan(0, 0, 0, 0, 0)), "3101d1a4-1b14-4c66-aa1c-5f4857a80684" });

            migrationBuilder.UpdateData(
                schema: "Troshka",
                table: "Locations",
                keyColumn: "Id",
                keyValue: "5dVT6X9b1jLvkFx5kfAM",
                columns: new[] { "DateCreated", "TrackId" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 4, 11, 13, 51, 43, 809, DateTimeKind.Unspecified).AddTicks(9799), new TimeSpan(0, 0, 0, 0, 0)), "46a03980-1a7b-4537-b6e1-8b737ee3cbb4" });

            migrationBuilder.UpdateData(
                schema: "Troshka",
                table: "Locations",
                keyColumn: "Id",
                keyValue: "5fCsOxNvMUvksRS1ZpQV",
                columns: new[] { "DateCreated", "TrackId" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 4, 11, 13, 51, 43, 810, DateTimeKind.Unspecified).AddTicks(28), new TimeSpan(0, 0, 0, 0, 0)), "37419299-263d-40d3-a756-eb078ff82770" });

            migrationBuilder.UpdateData(
                schema: "Troshka",
                table: "Locations",
                keyColumn: "Id",
                keyValue: "5m7B9g75rKUL9NPw6d8X",
                columns: new[] { "DateCreated", "TrackId" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 4, 11, 13, 51, 43, 809, DateTimeKind.Unspecified).AddTicks(7870), new TimeSpan(0, 0, 0, 0, 0)), "5dee3ee3-dfbc-42a3-9eca-eed7c392a367" });

            migrationBuilder.UpdateData(
                schema: "Troshka",
                table: "Locations",
                keyColumn: "Id",
                keyValue: "5Rqixw4lSU7SBGqdw1Zw",
                columns: new[] { "DateCreated", "TrackId" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 4, 11, 13, 51, 43, 809, DateTimeKind.Unspecified).AddTicks(8770), new TimeSpan(0, 0, 0, 0, 0)), "4aa9a091-9652-43a7-88f2-5e7181d2dc41" });

            migrationBuilder.UpdateData(
                schema: "Troshka",
                table: "Locations",
                keyColumn: "Id",
                keyValue: "60EtxqsrwIKU0ltomD8Z",
                columns: new[] { "DateCreated", "TrackId" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 4, 11, 13, 51, 43, 810, DateTimeKind.Unspecified).AddTicks(1266), new TimeSpan(0, 0, 0, 0, 0)), "80b7d1c5-ac17-4495-9f52-3524e34c4dd7" });

            migrationBuilder.UpdateData(
                schema: "Troshka",
                table: "Locations",
                keyColumn: "Id",
                keyValue: "6GF8DxWoU9qXj4LQ5PQx",
                columns: new[] { "DateCreated", "TrackId" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 4, 11, 13, 51, 43, 809, DateTimeKind.Unspecified).AddTicks(7636), new TimeSpan(0, 0, 0, 0, 0)), "d5385e65-8e08-4107-9ccd-0efef088faa7" });

            migrationBuilder.UpdateData(
                schema: "Troshka",
                table: "Locations",
                keyColumn: "Id",
                keyValue: "72K7099RJLSbKsSfj3vN",
                columns: new[] { "DateCreated", "TrackId" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 4, 11, 13, 51, 43, 809, DateTimeKind.Unspecified).AddTicks(9985), new TimeSpan(0, 0, 0, 0, 0)), "a506c2d1-e519-43ff-9d63-7be2294a8d03" });

            migrationBuilder.UpdateData(
                schema: "Troshka",
                table: "Locations",
                keyColumn: "Id",
                keyValue: "7keXP3PumDqPy2TtIJyE",
                columns: new[] { "DateCreated", "TrackId" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 4, 11, 13, 51, 43, 809, DateTimeKind.Unspecified).AddTicks(7600), new TimeSpan(0, 0, 0, 0, 0)), "bbc4f05b-5de1-425f-a92d-50e4f0d0d97c" });

            migrationBuilder.UpdateData(
                schema: "Troshka",
                table: "Locations",
                keyColumn: "Id",
                keyValue: "7s493n3iCAcI9eV6xOsf",
                columns: new[] { "DateCreated", "TrackId" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 4, 11, 13, 51, 43, 809, DateTimeKind.Unspecified).AddTicks(9809), new TimeSpan(0, 0, 0, 0, 0)), "2c0bc6a5-e078-415f-84d6-a7dab6cfede5" });

            migrationBuilder.UpdateData(
                schema: "Troshka",
                table: "Locations",
                keyColumn: "Id",
                keyValue: "7VIIUaptNwzhj8ej05ur",
                columns: new[] { "DateCreated", "TrackId" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 4, 11, 13, 51, 43, 809, DateTimeKind.Unspecified).AddTicks(8937), new TimeSpan(0, 0, 0, 0, 0)), "c382b52a-f687-493f-8180-75e3eae439b3" });

            migrationBuilder.UpdateData(
                schema: "Troshka",
                table: "Locations",
                keyColumn: "Id",
                keyValue: "818vJeBIuImlcdJGphu8",
                columns: new[] { "DateCreated", "TrackId" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 4, 11, 13, 51, 43, 809, DateTimeKind.Unspecified).AddTicks(8144), new TimeSpan(0, 0, 0, 0, 0)), "6ee03e10-6ee0-4d60-b940-d3981e9926ed" });

            migrationBuilder.UpdateData(
                schema: "Troshka",
                table: "Locations",
                keyColumn: "Id",
                keyValue: "82mULi1IDzKqLOn3G2uP",
                columns: new[] { "DateCreated", "TrackId" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 4, 11, 13, 51, 43, 809, DateTimeKind.Unspecified).AddTicks(8264), new TimeSpan(0, 0, 0, 0, 0)), "5edcc83c-8f88-47f0-9735-e3f9b58b5889" });

            migrationBuilder.UpdateData(
                schema: "Troshka",
                table: "Locations",
                keyColumn: "Id",
                keyValue: "8Be2RRzbuSU59GLX3Ezl",
                columns: new[] { "DateCreated", "TrackId" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 4, 11, 13, 51, 43, 810, DateTimeKind.Unspecified).AddTicks(320), new TimeSpan(0, 0, 0, 0, 0)), "92bc62a3-764b-4c91-904b-e228ca665cc7" });

            migrationBuilder.UpdateData(
                schema: "Troshka",
                table: "Locations",
                keyColumn: "Id",
                keyValue: "8HyYUQaPF48Tit9PqSQi",
                columns: new[] { "DateCreated", "TrackId" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 4, 11, 13, 51, 43, 809, DateTimeKind.Unspecified).AddTicks(8907), new TimeSpan(0, 0, 0, 0, 0)), "cb0d8846-b6fe-40bb-bbde-1ec9c5772356" });

            migrationBuilder.UpdateData(
                schema: "Troshka",
                table: "Locations",
                keyColumn: "Id",
                keyValue: "8nHE5KIPw9tUyknXo3Jl",
                columns: new[] { "DateCreated", "TrackId" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 4, 11, 13, 51, 43, 809, DateTimeKind.Unspecified).AddTicks(9079), new TimeSpan(0, 0, 0, 0, 0)), "e3b0d3d2-ec96-4988-9da9-4a781542b94d" });

            migrationBuilder.UpdateData(
                schema: "Troshka",
                table: "Locations",
                keyColumn: "Id",
                keyValue: "8Q8i1YjiArjCDECWmWRb",
                columns: new[] { "DateCreated", "TrackId" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 4, 11, 13, 51, 43, 809, DateTimeKind.Unspecified).AddTicks(9084), new TimeSpan(0, 0, 0, 0, 0)), "7306124c-0f69-4875-8856-f14d289ee0d3" });

            migrationBuilder.UpdateData(
                schema: "Troshka",
                table: "Locations",
                keyColumn: "Id",
                keyValue: "8QQI9EeWHMOtwxCOcWIT",
                columns: new[] { "DateCreated", "TrackId" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 4, 11, 13, 51, 43, 810, DateTimeKind.Unspecified).AddTicks(1559), new TimeSpan(0, 0, 0, 0, 0)), "3a5b12fd-14e4-476b-8f91-eb78e86c0349" });

            migrationBuilder.UpdateData(
                schema: "Troshka",
                table: "Locations",
                keyColumn: "Id",
                keyValue: "8U43LpX9MGvI2cmLw4rD",
                columns: new[] { "DateCreated", "TrackId" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 4, 11, 13, 51, 43, 810, DateTimeKind.Unspecified).AddTicks(226), new TimeSpan(0, 0, 0, 0, 0)), "764b8ddc-a726-4fbb-afc1-61c0561548af" });

            migrationBuilder.UpdateData(
                schema: "Troshka",
                table: "Locations",
                keyColumn: "Id",
                keyValue: "9feUqBzVA8eZsdMvXqvG",
                columns: new[] { "DateCreated", "TrackId" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 4, 11, 13, 51, 43, 809, DateTimeKind.Unspecified).AddTicks(7606), new TimeSpan(0, 0, 0, 0, 0)), "b2bed1a8-be16-44dc-b699-1ccfe89d8cfe" });

            migrationBuilder.UpdateData(
                schema: "Troshka",
                table: "Locations",
                keyColumn: "Id",
                keyValue: "9sFruqb4xl1tBUAlCjnb",
                columns: new[] { "DateCreated", "TrackId" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 4, 11, 13, 51, 43, 809, DateTimeKind.Unspecified).AddTicks(8901), new TimeSpan(0, 0, 0, 0, 0)), "fcc9f0e1-b057-4e5e-8c1e-abf9244b4652" });

            migrationBuilder.UpdateData(
                schema: "Troshka",
                table: "Locations",
                keyColumn: "Id",
                keyValue: "9twC0sUO1RE8B9LYfWdX",
                columns: new[] { "DateCreated", "TrackId" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 4, 11, 13, 51, 43, 809, DateTimeKind.Unspecified).AddTicks(9857), new TimeSpan(0, 0, 0, 0, 0)), "0fc29645-6452-4be7-9716-5fed03d15d60" });

            migrationBuilder.UpdateData(
                schema: "Troshka",
                table: "Locations",
                keyColumn: "Id",
                keyValue: "9vN2sGt2IhEntOysf32e",
                columns: new[] { "DateCreated", "TrackId" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 4, 11, 13, 51, 43, 810, DateTimeKind.Unspecified).AddTicks(301), new TimeSpan(0, 0, 0, 0, 0)), "c85b514a-731d-4c70-9c4f-ddc0d4fb5a68" });

            migrationBuilder.UpdateData(
                schema: "Troshka",
                table: "Locations",
                keyColumn: "Id",
                keyValue: "a0p6Ajl1TVHmaGVNKNLi",
                columns: new[] { "DateCreated", "TrackId" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 4, 11, 13, 51, 43, 809, DateTimeKind.Unspecified).AddTicks(8993), new TimeSpan(0, 0, 0, 0, 0)), "62177564-66ad-4880-8881-f990c4369a62" });

            migrationBuilder.UpdateData(
                schema: "Troshka",
                table: "Locations",
                keyColumn: "Id",
                keyValue: "AAAO3LJLeMao6iml66wC",
                columns: new[] { "DateCreated", "TrackId" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 4, 11, 13, 51, 43, 810, DateTimeKind.Unspecified).AddTicks(1201), new TimeSpan(0, 0, 0, 0, 0)), "79f72d76-b6ce-4188-a0d1-abb6955daadd" });

            migrationBuilder.UpdateData(
                schema: "Troshka",
                table: "Locations",
                keyColumn: "Id",
                keyValue: "Ab0ApUhICf7zaMFmHTFt",
                columns: new[] { "DateCreated", "TrackId" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 4, 11, 13, 51, 43, 810, DateTimeKind.Unspecified).AddTicks(208), new TimeSpan(0, 0, 0, 0, 0)), "6b1b3351-3f23-4b69-bf86-039bdd2b979b" });

            migrationBuilder.UpdateData(
                schema: "Troshka",
                table: "Locations",
                keyColumn: "Id",
                keyValue: "AcHS4Qb4HuqEnBoT32eu",
                columns: new[] { "DateCreated", "TrackId" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 4, 11, 13, 51, 43, 809, DateTimeKind.Unspecified).AddTicks(9915), new TimeSpan(0, 0, 0, 0, 0)), "4e283a6f-3013-47fa-822d-9a5c40ebcf0d" });

            migrationBuilder.UpdateData(
                schema: "Troshka",
                table: "Locations",
                keyColumn: "Id",
                keyValue: "ady7xTwdtnixVQs3O2oz",
                columns: new[] { "DateCreated", "TrackId" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 4, 11, 13, 51, 43, 809, DateTimeKind.Unspecified).AddTicks(7894), new TimeSpan(0, 0, 0, 0, 0)), "c6c9edbc-d415-4530-928c-482067e756e2" });

            migrationBuilder.UpdateData(
                schema: "Troshka",
                table: "Locations",
                keyColumn: "Id",
                keyValue: "AMp3jRxQAkoccRtMGfvg",
                columns: new[] { "DateCreated", "TrackId" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 4, 11, 13, 51, 43, 810, DateTimeKind.Unspecified).AddTicks(664), new TimeSpan(0, 0, 0, 0, 0)), "b6b2c321-6ef7-4fe7-868f-73348ba104fb" });

            migrationBuilder.UpdateData(
                schema: "Troshka",
                table: "Locations",
                keyColumn: "Id",
                keyValue: "an3o0hYhG7sP6YemnTPr",
                columns: new[] { "DateCreated", "TrackId" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 4, 11, 13, 51, 43, 810, DateTimeKind.Unspecified).AddTicks(1385), new TimeSpan(0, 0, 0, 0, 0)), "8b3569d3-a3b6-4dfb-840c-802b9a76255f" });

            migrationBuilder.UpdateData(
                schema: "Troshka",
                table: "Locations",
                keyColumn: "Id",
                keyValue: "aOeUgHmp1DYlbgus1iym",
                columns: new[] { "DateCreated", "TrackId" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 4, 11, 13, 51, 43, 809, DateTimeKind.Unspecified).AddTicks(9211), new TimeSpan(0, 0, 0, 0, 0)), "41eec142-c9bf-4309-8614-ed9da893b5ff" });

            migrationBuilder.UpdateData(
                schema: "Troshka",
                table: "Locations",
                keyColumn: "Id",
                keyValue: "arzgr2kBPnf94eLvHmzF",
                columns: new[] { "DateCreated", "TrackId" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 4, 11, 13, 51, 43, 810, DateTimeKind.Unspecified).AddTicks(1513), new TimeSpan(0, 0, 0, 0, 0)), "26635c8e-1971-4014-ae25-945a481a8f37" });

            migrationBuilder.UpdateData(
                schema: "Troshka",
                table: "Locations",
                keyColumn: "Id",
                keyValue: "AUdHMyIrucbK1QPSuEl6",
                columns: new[] { "DateCreated", "TrackId" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 4, 11, 13, 51, 43, 810, DateTimeKind.Unspecified).AddTicks(495), new TimeSpan(0, 0, 0, 0, 0)), "4134d251-afc0-46ce-8b0e-0bbf9467f110" });

            migrationBuilder.UpdateData(
                schema: "Troshka",
                table: "Locations",
                keyColumn: "Id",
                keyValue: "ayxopMnHP3GynSD3phZ0",
                columns: new[] { "DateCreated", "TrackId" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 4, 11, 13, 51, 43, 809, DateTimeKind.Unspecified).AddTicks(8809), new TimeSpan(0, 0, 0, 0, 0)), "c1baad1a-c8d0-4af2-a5ca-50ffedd3fe38" });

            migrationBuilder.UpdateData(
                schema: "Troshka",
                table: "Locations",
                keyColumn: "Id",
                keyValue: "B6fEB97ylQL7Np47vtYV",
                columns: new[] { "DateCreated", "TrackId" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 4, 11, 13, 51, 43, 810, DateTimeKind.Unspecified).AddTicks(1273), new TimeSpan(0, 0, 0, 0, 0)), "7f6b5ebd-5e30-4c18-8bbb-ca7ebe91d3ac" });

            migrationBuilder.UpdateData(
                schema: "Troshka",
                table: "Locations",
                keyColumn: "Id",
                keyValue: "BCxe8rk6vzMhYhXTO0rU",
                columns: new[] { "DateCreated", "TrackId" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 4, 11, 13, 51, 43, 810, DateTimeKind.Unspecified).AddTicks(365), new TimeSpan(0, 0, 0, 0, 0)), "58c1f81c-dc14-486f-bef7-cdcb35074209" });

            migrationBuilder.UpdateData(
                schema: "Troshka",
                table: "Locations",
                keyColumn: "Id",
                keyValue: "bHGMKKJTtQuMC0vS9i3Z",
                columns: new[] { "DateCreated", "TrackId" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 4, 11, 13, 51, 43, 809, DateTimeKind.Unspecified).AddTicks(8246), new TimeSpan(0, 0, 0, 0, 0)), "bc8beeb9-2fce-4d66-b435-79fbacfc9dd5" });

            migrationBuilder.UpdateData(
                schema: "Troshka",
                table: "Locations",
                keyColumn: "Id",
                keyValue: "Bj7la6MGA3NvSSopnJri",
                columns: new[] { "DateCreated", "TrackId" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 4, 11, 13, 51, 43, 809, DateTimeKind.Unspecified).AddTicks(8005), new TimeSpan(0, 0, 0, 0, 0)), "b967a757-fd0d-4c97-91a6-cd452c600aef" });

            migrationBuilder.UpdateData(
                schema: "Troshka",
                table: "Locations",
                keyColumn: "Id",
                keyValue: "blP0EqOltrrA4kScx9XG",
                columns: new[] { "DateCreated", "TrackId" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 4, 11, 13, 51, 43, 810, DateTimeKind.Unspecified).AddTicks(1501), new TimeSpan(0, 0, 0, 0, 0)), "65918ef6-4131-494e-85f0-7f12a5b227ee" });

            migrationBuilder.UpdateData(
                schema: "Troshka",
                table: "Locations",
                keyColumn: "Id",
                keyValue: "bnc8v9kl9VlsefVCPL0W",
                columns: new[] { "DateCreated", "TrackId" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 4, 11, 13, 51, 43, 810, DateTimeKind.Unspecified).AddTicks(214), new TimeSpan(0, 0, 0, 0, 0)), "596f0a1a-ce4e-40d7-9e37-d2278b34dbac" });

            migrationBuilder.UpdateData(
                schema: "Troshka",
                table: "Locations",
                keyColumn: "Id",
                keyValue: "BnHAwhVpD8t3wGhxo8Sg",
                columns: new[] { "DateCreated", "TrackId" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 4, 11, 13, 51, 43, 809, DateTimeKind.Unspecified).AddTicks(9200), new TimeSpan(0, 0, 0, 0, 0)), "527cdca3-5131-4382-9d00-34c317935c27" });

            migrationBuilder.UpdateData(
                schema: "Troshka",
                table: "Locations",
                keyColumn: "Id",
                keyValue: "BOqOCxCIc5jNlWXHJUK4",
                columns: new[] { "DateCreated", "TrackId" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 4, 11, 13, 51, 43, 809, DateTimeKind.Unspecified).AddTicks(9182), new TimeSpan(0, 0, 0, 0, 0)), "59f176ef-0e9d-4f6a-aee2-fa35a7bd349a" });

            migrationBuilder.UpdateData(
                schema: "Troshka",
                table: "Locations",
                keyColumn: "Id",
                keyValue: "BpmCmi2yyMLJaOKrSPZQ",
                columns: new[] { "DateCreated", "TrackId" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 4, 11, 13, 51, 43, 810, DateTimeKind.Unspecified).AddTicks(559), new TimeSpan(0, 0, 0, 0, 0)), "92db4e41-f7b5-42f6-94b3-832bd55dcbf7" });

            migrationBuilder.UpdateData(
                schema: "Troshka",
                table: "Locations",
                keyColumn: "Id",
                keyValue: "bQptTR8qPbrqS4Wg6ZQN",
                columns: new[] { "DateCreated", "TrackId" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 4, 11, 13, 51, 43, 809, DateTimeKind.Unspecified).AddTicks(7888), new TimeSpan(0, 0, 0, 0, 0)), "d58ccc0b-5165-40ab-bcff-be6e0550d217" });

            migrationBuilder.UpdateData(
                schema: "Troshka",
                table: "Locations",
                keyColumn: "Id",
                keyValue: "bsf5H4yuihOunxGQvTRs",
                columns: new[] { "DateCreated", "TrackId" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 4, 11, 13, 51, 43, 810, DateTimeKind.Unspecified).AddTicks(314), new TimeSpan(0, 0, 0, 0, 0)), "dce93354-1819-4604-a98d-b2a1fdb80812" });

            migrationBuilder.UpdateData(
                schema: "Troshka",
                table: "Locations",
                keyColumn: "Id",
                keyValue: "BslBNBCNreUaRxaYYFz8",
                columns: new[] { "DateCreated", "TrackId" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 4, 11, 13, 51, 43, 810, DateTimeKind.Unspecified).AddTicks(1285), new TimeSpan(0, 0, 0, 0, 0)), "2d3fd621-4aea-4f13-94a2-53c2e31cd6fa" });

            migrationBuilder.UpdateData(
                schema: "Troshka",
                table: "Locations",
                keyColumn: "Id",
                keyValue: "BxBkLPfjqiPnspDDl02r",
                columns: new[] { "DateCreated", "TrackId" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 4, 11, 13, 51, 43, 810, DateTimeKind.Unspecified).AddTicks(117), new TimeSpan(0, 0, 0, 0, 0)), "bcd11b0f-0230-4e4f-853c-749155323a86" });

            migrationBuilder.UpdateData(
                schema: "Troshka",
                table: "Locations",
                keyColumn: "Id",
                keyValue: "Byx9xuuqRVNwAvPtVdUA",
                columns: new[] { "DateCreated", "TrackId" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 4, 11, 13, 51, 43, 809, DateTimeKind.Unspecified).AddTicks(9113), new TimeSpan(0, 0, 0, 0, 0)), "40f3d755-a515-43c9-9769-e5737cc5805f" });

            migrationBuilder.UpdateData(
                schema: "Troshka",
                table: "Locations",
                keyColumn: "Id",
                keyValue: "cAm9i5Xr8AKbjxd4a0X5",
                columns: new[] { "DateCreated", "TrackId" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 4, 11, 13, 51, 43, 809, DateTimeKind.Unspecified).AddTicks(7863), new TimeSpan(0, 0, 0, 0, 0)), "3eea9a45-2e19-482a-9c00-3d2110c71b0f" });

            migrationBuilder.UpdateData(
                schema: "Troshka",
                table: "Locations",
                keyColumn: "Id",
                keyValue: "CBDlQzM1rROQtTHgzVwT",
                columns: new[] { "DateCreated", "TrackId" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 4, 11, 13, 51, 43, 810, DateTimeKind.Unspecified).AddTicks(191), new TimeSpan(0, 0, 0, 0, 0)), "edf003b3-f517-4e92-a957-3c6ded8836cb" });

            migrationBuilder.UpdateData(
                schema: "Troshka",
                table: "Locations",
                keyColumn: "Id",
                keyValue: "cBnRQo0enzpUXFrymVl7",
                columns: new[] { "DateCreated", "TrackId" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 4, 11, 13, 51, 43, 809, DateTimeKind.Unspecified).AddTicks(7693), new TimeSpan(0, 0, 0, 0, 0)), "13e7884e-6d05-4715-af09-7a32d3465e51" });

            migrationBuilder.UpdateData(
                schema: "Troshka",
                table: "Locations",
                keyColumn: "Id",
                keyValue: "cEztanE91e85HAt8d1sE",
                columns: new[] { "DateCreated", "TrackId" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 4, 11, 13, 51, 43, 810, DateTimeKind.Unspecified).AddTicks(470), new TimeSpan(0, 0, 0, 0, 0)), "2e0df117-6b93-47dc-bc3d-f7b4c6522392" });

            migrationBuilder.UpdateData(
                schema: "Troshka",
                table: "Locations",
                keyColumn: "Id",
                keyValue: "cHIsh4O8DiS3aa6BpqGy",
                columns: new[] { "DateCreated", "TrackId" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 4, 11, 13, 51, 43, 809, DateTimeKind.Unspecified).AddTicks(7999), new TimeSpan(0, 0, 0, 0, 0)), "a2199014-269c-4213-b012-9c4515564c70" });

            migrationBuilder.UpdateData(
                schema: "Troshka",
                table: "Locations",
                keyColumn: "Id",
                keyValue: "chRNgs4uXAUiB7dw6T4M",
                columns: new[] { "DateCreated", "TrackId" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 4, 11, 13, 51, 43, 809, DateTimeKind.Unspecified).AddTicks(9281), new TimeSpan(0, 0, 0, 0, 0)), "512ffba2-d6d2-4cba-8f82-5dd52123f841" });

            migrationBuilder.UpdateData(
                schema: "Troshka",
                table: "Locations",
                keyColumn: "Id",
                keyValue: "CM7iD1yu2CS7hvScKNMO",
                columns: new[] { "DateCreated", "TrackId" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 4, 11, 13, 51, 43, 809, DateTimeKind.Unspecified).AddTicks(9909), new TimeSpan(0, 0, 0, 0, 0)), "62255bb1-6eeb-4c02-ac8c-0b2e2f696ea7" });

            migrationBuilder.UpdateData(
                schema: "Troshka",
                table: "Locations",
                keyColumn: "Id",
                keyValue: "cr5i9babcZns6KgEyn24",
                columns: new[] { "DateCreated", "TrackId" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 4, 11, 13, 51, 43, 810, DateTimeKind.Unspecified).AddTicks(283), new TimeSpan(0, 0, 0, 0, 0)), "f44283c3-18a9-4196-ada3-252da56c2f92" });

            migrationBuilder.UpdateData(
                schema: "Troshka",
                table: "Locations",
                keyColumn: "Id",
                keyValue: "cU4r5FiNJgbiM6dhG8ER",
                columns: new[] { "DateCreated", "TrackId" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 4, 11, 13, 51, 43, 809, DateTimeKind.Unspecified).AddTicks(8889), new TimeSpan(0, 0, 0, 0, 0)), "6d748a4a-a15f-4ba2-a73d-b05ffab8836d" });

            migrationBuilder.UpdateData(
                schema: "Troshka",
                table: "Locations",
                keyColumn: "Id",
                keyValue: "cW98FxYnDNVMNflmC8q7",
                columns: new[] { "DateCreated", "TrackId" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 4, 11, 13, 51, 43, 810, DateTimeKind.Unspecified).AddTicks(634), new TimeSpan(0, 0, 0, 0, 0)), "93ff8c66-a3e3-436b-8f09-b235eb0b16a3" });

            migrationBuilder.UpdateData(
                schema: "Troshka",
                table: "Locations",
                keyColumn: "Id",
                keyValue: "dh8S1ZT9W1jajYz9EGG4",
                columns: new[] { "DateCreated", "TrackId" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 4, 11, 13, 51, 43, 810, DateTimeKind.Unspecified).AddTicks(1410), new TimeSpan(0, 0, 0, 0, 0)), "c2cba978-8c81-445a-86f5-79354d0acfe4" });

            migrationBuilder.UpdateData(
                schema: "Troshka",
                table: "Locations",
                keyColumn: "Id",
                keyValue: "DjTHGizW8wBL6URovDng",
                columns: new[] { "DateCreated", "TrackId" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 4, 11, 13, 51, 43, 809, DateTimeKind.Unspecified).AddTicks(8173), new TimeSpan(0, 0, 0, 0, 0)), "d87a9ad6-a1ea-4440-9297-31732f22a989" });

            migrationBuilder.UpdateData(
                schema: "Troshka",
                table: "Locations",
                keyColumn: "Id",
                keyValue: "dKTky4haW2fNOzMjNTiu",
                columns: new[] { "DateCreated", "TrackId" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 4, 11, 13, 51, 43, 810, DateTimeKind.Unspecified).AddTicks(1391), new TimeSpan(0, 0, 0, 0, 0)), "3f6bafd9-cf22-489f-860a-5f192083a4be" });

            migrationBuilder.UpdateData(
                schema: "Troshka",
                table: "Locations",
                keyColumn: "Id",
                keyValue: "dlWGw4uU8kpnrXq4zbyN",
                columns: new[] { "DateCreated", "TrackId" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 4, 11, 13, 51, 43, 809, DateTimeKind.Unspecified).AddTicks(8999), new TimeSpan(0, 0, 0, 0, 0)), "4a67e11d-60e3-4bf6-9471-f70c14faf12b" });

            migrationBuilder.UpdateData(
                schema: "Troshka",
                table: "Locations",
                keyColumn: "Id",
                keyValue: "DNQ3KHJkxqiNtn14gcaB",
                columns: new[] { "DateCreated", "TrackId" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 4, 11, 13, 51, 43, 809, DateTimeKind.Unspecified).AddTicks(7676), new TimeSpan(0, 0, 0, 0, 0)), "a6fc24db-ff41-416a-8295-72ce7210abf8" });

            migrationBuilder.UpdateData(
                schema: "Troshka",
                table: "Locations",
                keyColumn: "Id",
                keyValue: "DUwLGmp9EcEq3WlpZPAt",
                columns: new[] { "DateCreated", "TrackId" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 4, 11, 13, 51, 43, 809, DateTimeKind.Unspecified).AddTicks(9091), new TimeSpan(0, 0, 0, 0, 0)), "5c6ff30a-8342-459d-b125-6a6585fe8369" });

            migrationBuilder.UpdateData(
                schema: "Troshka",
                table: "Locations",
                keyColumn: "Id",
                keyValue: "DxK5hs209av1QkpAm0DU",
                columns: new[] { "DateCreated", "TrackId" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 4, 11, 13, 51, 43, 809, DateTimeKind.Unspecified).AddTicks(8258), new TimeSpan(0, 0, 0, 0, 0)), "bfe97b36-a4e1-42ce-b00c-c27cef01746a" });

            migrationBuilder.UpdateData(
                schema: "Troshka",
                table: "Locations",
                keyColumn: "Id",
                keyValue: "e0HXhaClTvD2A0rwtnk8",
                columns: new[] { "DateCreated", "TrackId" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 4, 11, 13, 51, 43, 810, DateTimeKind.Unspecified).AddTicks(1308), new TimeSpan(0, 0, 0, 0, 0)), "efc5755b-6d2c-4aa6-97fd-8d0c4b5d555c" });

            migrationBuilder.UpdateData(
                schema: "Troshka",
                table: "Locations",
                keyColumn: "Id",
                keyValue: "e6WZlTMDT3B7oqZqPIVD",
                columns: new[] { "DateCreated", "TrackId" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 4, 11, 13, 51, 43, 809, DateTimeKind.Unspecified).AddTicks(9205), new TimeSpan(0, 0, 0, 0, 0)), "3db635a2-92ff-434f-8c7a-0aca7f51478b" });

            migrationBuilder.UpdateData(
                schema: "Troshka",
                table: "Locations",
                keyColumn: "Id",
                keyValue: "E7yPisre4COe7jyOEBCT",
                columns: new[] { "DateCreated", "TrackId" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 4, 11, 13, 51, 43, 809, DateTimeKind.Unspecified).AddTicks(9851), new TimeSpan(0, 0, 0, 0, 0)), "16995c7c-0caa-4881-aa5b-cb6c2b481ff0" });

            migrationBuilder.UpdateData(
                schema: "Troshka",
                table: "Locations",
                keyColumn: "Id",
                keyValue: "Eg5zvbKnhciCCWDjnQoJ",
                columns: new[] { "DateCreated", "TrackId" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 4, 11, 13, 51, 43, 810, DateTimeKind.Unspecified).AddTicks(383), new TimeSpan(0, 0, 0, 0, 0)), "07f6acc1-e0d4-4643-a709-a4fc9ddc3923" });

            migrationBuilder.UpdateData(
                schema: "Troshka",
                table: "Locations",
                keyColumn: "Id",
                keyValue: "EKkLEcWxNiBqkVhNmeOz",
                columns: new[] { "DateCreated", "TrackId" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 4, 11, 13, 51, 43, 809, DateTimeKind.Unspecified).AddTicks(8271), new TimeSpan(0, 0, 0, 0, 0)), "30fa1f7a-aa45-496e-a81c-5bddc9b3b07a" });

            migrationBuilder.UpdateData(
                schema: "Troshka",
                table: "Locations",
                keyColumn: "Id",
                keyValue: "eKyPX0e83l5ulQWnQqAI",
                columns: new[] { "DateCreated", "TrackId" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 4, 11, 13, 51, 43, 809, DateTimeKind.Unspecified).AddTicks(9126), new TimeSpan(0, 0, 0, 0, 0)), "82ddfd9b-67f7-4ad8-a1a9-df9e037fa241" });

            migrationBuilder.UpdateData(
                schema: "Troshka",
                table: "Locations",
                keyColumn: "Id",
                keyValue: "EyhQMWwBO7hDquOyZ7UR",
                columns: new[] { "DateCreated", "TrackId" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 4, 11, 13, 51, 43, 809, DateTimeKind.Unspecified).AddTicks(8987), new TimeSpan(0, 0, 0, 0, 0)), "e1887253-367d-4533-8031-ed66f43b2e49" });

            migrationBuilder.UpdateData(
                schema: "Troshka",
                table: "Locations",
                keyColumn: "Id",
                keyValue: "f0B7ngALDcChR0qeW8Kx",
                columns: new[] { "DateCreated", "TrackId" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 4, 11, 13, 51, 43, 809, DateTimeKind.Unspecified).AddTicks(7912), new TimeSpan(0, 0, 0, 0, 0)), "67e09899-28d8-4ef8-bd63-b2b190f40e0f" });

            migrationBuilder.UpdateData(
                schema: "Troshka",
                table: "Locations",
                keyColumn: "Id",
                keyValue: "f58Np5BqUrjaHzzHcI3B",
                columns: new[] { "DateCreated", "TrackId" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 4, 11, 13, 51, 43, 809, DateTimeKind.Unspecified).AddTicks(9837), new TimeSpan(0, 0, 0, 0, 0)), "2dec66b0-11a7-4788-98a1-7d920bdcf234" });

            migrationBuilder.UpdateData(
                schema: "Troshka",
                table: "Locations",
                keyColumn: "Id",
                keyValue: "fAzTPYCw6IPYt7r0nyQt",
                columns: new[] { "DateCreated", "TrackId" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 4, 11, 13, 51, 43, 810, DateTimeKind.Unspecified).AddTicks(277), new TimeSpan(0, 0, 0, 0, 0)), "b723a8e5-bd10-4749-9144-d10a3f24155f" });

            migrationBuilder.UpdateData(
                schema: "Troshka",
                table: "Locations",
                keyColumn: "Id",
                keyValue: "fgY39cfPxP44RFl3ufXm",
                columns: new[] { "DateCreated", "TrackId" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 4, 11, 13, 51, 43, 810, DateTimeKind.Unspecified).AddTicks(576), new TimeSpan(0, 0, 0, 0, 0)), "9c17fa32-731b-43f3-9a33-f8da2ca9c464" });

            migrationBuilder.UpdateData(
                schema: "Troshka",
                table: "Locations",
                keyColumn: "Id",
                keyValue: "FHbfSPlAuKWuO2xnrfmB",
                columns: new[] { "DateCreated", "TrackId" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 4, 11, 13, 51, 43, 810, DateTimeKind.Unspecified).AddTicks(202), new TimeSpan(0, 0, 0, 0, 0)), "597e95f9-6954-4cb6-80fe-99b2a1ebaa1c" });

            migrationBuilder.UpdateData(
                schema: "Troshka",
                table: "Locations",
                keyColumn: "Id",
                keyValue: "fjV17FeFYtdG87NIzTTV",
                columns: new[] { "DateCreated", "TrackId" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 4, 11, 13, 51, 43, 809, DateTimeKind.Unspecified).AddTicks(8819), new TimeSpan(0, 0, 0, 0, 0)), "e0e3c415-fb31-4755-b936-b6cfe317af7e" });

            migrationBuilder.UpdateData(
                schema: "Troshka",
                table: "Locations",
                keyColumn: "Id",
                keyValue: "fz3K8nqEexm4AndgrQi4",
                columns: new[] { "DateCreated", "TrackId" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 4, 11, 13, 51, 43, 809, DateTimeKind.Unspecified).AddTicks(7994), new TimeSpan(0, 0, 0, 0, 0)), "51b25b5f-68dc-4c79-b56f-ffadfe34561f" });

            migrationBuilder.UpdateData(
                schema: "Troshka",
                table: "Locations",
                keyColumn: "Id",
                keyValue: "G6fX1XjbGqPoS8RLnpnc",
                columns: new[] { "DateCreated", "TrackId" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 4, 11, 13, 51, 43, 810, DateTimeKind.Unspecified).AddTicks(22), new TimeSpan(0, 0, 0, 0, 0)), "d1c1efb2-3480-4d66-ae5a-33fa1bff9526" });

            migrationBuilder.UpdateData(
                schema: "Troshka",
                table: "Locations",
                keyColumn: "Id",
                keyValue: "G9twrE4qbivdKWJfpaTn",
                columns: new[] { "DateCreated", "TrackId" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 4, 11, 13, 51, 43, 810, DateTimeKind.Unspecified).AddTicks(10), new TimeSpan(0, 0, 0, 0, 0)), "0b68c053-3bbe-4588-8556-9bd6599c052f" });

            migrationBuilder.UpdateData(
                schema: "Troshka",
                table: "Locations",
                keyColumn: "Id",
                keyValue: "gaYFbNX9SJExqDV2IGvI",
                columns: new[] { "DateCreated", "TrackId" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 4, 11, 13, 51, 43, 809, DateTimeKind.Unspecified).AddTicks(7988), new TimeSpan(0, 0, 0, 0, 0)), "ed0befe6-2c11-43df-8e04-ffba522efe26" });

            migrationBuilder.UpdateData(
                schema: "Troshka",
                table: "Locations",
                keyColumn: "Id",
                keyValue: "GdwsyBgAwg4b5jBslBmv",
                columns: new[] { "DateCreated", "TrackId" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 4, 11, 13, 51, 43, 809, DateTimeKind.Unspecified).AddTicks(8919), new TimeSpan(0, 0, 0, 0, 0)), "509630a6-fb71-4d00-9d5c-b4622abc6146" });

            migrationBuilder.UpdateData(
                schema: "Troshka",
                table: "Locations",
                keyColumn: "Id",
                keyValue: "GGQuu1mCVa2XyHe6OHwd",
                columns: new[] { "DateCreated", "TrackId" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 4, 11, 13, 51, 43, 809, DateTimeKind.Unspecified).AddTicks(8252), new TimeSpan(0, 0, 0, 0, 0)), "322e0858-b054-440a-b555-b69a5fe3ae14" });

            migrationBuilder.UpdateData(
                schema: "Troshka",
                table: "Locations",
                keyColumn: "Id",
                keyValue: "GPKXXzuRLzBmQY8OGUYN",
                columns: new[] { "DateCreated", "TrackId" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 4, 11, 13, 51, 43, 810, DateTimeKind.Unspecified).AddTicks(1578), new TimeSpan(0, 0, 0, 0, 0)), "bd07be46-0c64-4279-8732-da7d4d66b7de" });

            migrationBuilder.UpdateData(
                schema: "Troshka",
                table: "Locations",
                keyColumn: "Id",
                keyValue: "GtwBz0xireBoNWHleled",
                columns: new[] { "DateCreated", "TrackId" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 4, 11, 13, 51, 43, 810, DateTimeKind.Unspecified).AddTicks(371), new TimeSpan(0, 0, 0, 0, 0)), "fce78600-9bdd-4dd9-9ce9-8f3edbdc3c7a" });

            migrationBuilder.UpdateData(
                schema: "Troshka",
                table: "Locations",
                keyColumn: "Id",
                keyValue: "GUdg4bsLNwKisWTQ9rHA",
                columns: new[] { "DateCreated", "TrackId" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 4, 11, 13, 51, 43, 809, DateTimeKind.Unspecified).AddTicks(7918), new TimeSpan(0, 0, 0, 0, 0)), "5e193238-a7c6-42b2-bfc5-aa76d33a031e" });

            migrationBuilder.UpdateData(
                schema: "Troshka",
                table: "Locations",
                keyColumn: "Id",
                keyValue: "gvRcMsNyR0UElUrasG12",
                columns: new[] { "DateCreated", "TrackId" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 4, 11, 13, 51, 43, 810, DateTimeKind.Unspecified).AddTicks(1465), new TimeSpan(0, 0, 0, 0, 0)), "6f519db4-36a8-475d-a334-badf641ae77c" });

            migrationBuilder.UpdateData(
                schema: "Troshka",
                table: "Locations",
                keyColumn: "Id",
                keyValue: "Gwe46q5lQ75V8o4b39Lc",
                columns: new[] { "DateCreated", "TrackId" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 4, 11, 13, 51, 43, 810, DateTimeKind.Unspecified).AddTicks(1380), new TimeSpan(0, 0, 0, 0, 0)), "14a7f585-438a-45ca-b452-cdfe7a6b9010" });

            migrationBuilder.UpdateData(
                schema: "Troshka",
                table: "Locations",
                keyColumn: "Id",
                keyValue: "GXHYSrHAuQTT3NwQiNod",
                columns: new[] { "DateCreated", "TrackId" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 4, 11, 13, 51, 43, 809, DateTimeKind.Unspecified).AddTicks(8056), new TimeSpan(0, 0, 0, 0, 0)), "49fe0bfc-062c-421b-b9ef-fdc25cb38e18" });

            migrationBuilder.UpdateData(
                schema: "Troshka",
                table: "Locations",
                keyColumn: "Id",
                keyValue: "h7D65pNQ08GHx9b3AcxU",
                columns: new[] { "DateCreated", "TrackId" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 4, 11, 13, 51, 43, 810, DateTimeKind.Unspecified).AddTicks(489), new TimeSpan(0, 0, 0, 0, 0)), "43e1e1a6-6d5d-427a-a61d-f2b80ed27863" });

            migrationBuilder.UpdateData(
                schema: "Troshka",
                table: "Locations",
                keyColumn: "Id",
                keyValue: "hcWnu9tdf7PvuUE1Z86G",
                columns: new[] { "DateCreated", "TrackId" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 4, 11, 13, 51, 43, 810, DateTimeKind.Unspecified).AddTicks(1415), new TimeSpan(0, 0, 0, 0, 0)), "2f2797c7-995b-4c2f-ba0c-6e0596f9e7e4" });

            migrationBuilder.UpdateData(
                schema: "Troshka",
                table: "Locations",
                keyColumn: "Id",
                keyValue: "HDEj5O0QzUUz6dXZUQUC",
                columns: new[] { "DateCreated", "TrackId" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 4, 11, 13, 51, 43, 809, DateTimeKind.Unspecified).AddTicks(9029), new TimeSpan(0, 0, 0, 0, 0)), "dcc37227-b4c4-4956-b791-d6fe315e0561" });

            migrationBuilder.UpdateData(
                schema: "Troshka",
                table: "Locations",
                keyColumn: "Id",
                keyValue: "hfO3HfINfWDV0vWSfNeY",
                columns: new[] { "DateCreated", "TrackId" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 4, 11, 13, 51, 43, 809, DateTimeKind.Unspecified).AddTicks(8925), new TimeSpan(0, 0, 0, 0, 0)), "ea1c211d-d032-4dcf-b7f6-99c92ddbed5f" });

            migrationBuilder.UpdateData(
                schema: "Troshka",
                table: "Locations",
                keyColumn: "Id",
                keyValue: "hWDOJO1XVbMZtq69lVJo",
                columns: new[] { "DateCreated", "TrackId" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 4, 11, 13, 51, 43, 809, DateTimeKind.Unspecified).AddTicks(9018), new TimeSpan(0, 0, 0, 0, 0)), "9b0041b0-6495-4f89-8938-7761dcd3d462" });

            migrationBuilder.UpdateData(
                schema: "Troshka",
                table: "Locations",
                keyColumn: "Id",
                keyValue: "hY5scKz0GZmfw1t4hHrg",
                columns: new[] { "DateCreated", "TrackId" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 4, 11, 13, 51, 43, 810, DateTimeKind.Unspecified).AddTicks(1315), new TimeSpan(0, 0, 0, 0, 0)), "38c871e5-85af-4583-9c61-73401dd5df42" });

            migrationBuilder.UpdateData(
                schema: "Troshka",
                table: "Locations",
                keyColumn: "Id",
                keyValue: "I3o2PelffQGQZ2tg4PCf",
                columns: new[] { "DateCreated", "TrackId" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 4, 11, 13, 51, 43, 810, DateTimeKind.Unspecified).AddTicks(1646), new TimeSpan(0, 0, 0, 0, 0)), "dad7f98c-e010-4cda-b3e0-40293a6f340e" });

            migrationBuilder.UpdateData(
                schema: "Troshka",
                table: "Locations",
                keyColumn: "Id",
                keyValue: "i8zmw7rcQnoJw83TtkbJ",
                columns: new[] { "DateCreated", "TrackId" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 4, 11, 13, 51, 43, 809, DateTimeKind.Unspecified).AddTicks(8223), new TimeSpan(0, 0, 0, 0, 0)), "b98d9aa0-4396-4c46-bb88-6b099e7cc95a" });

            migrationBuilder.UpdateData(
                schema: "Troshka",
                table: "Locations",
                keyColumn: "Id",
                keyValue: "ICeAWglJ3SZW8AKlNJJV",
                columns: new[] { "DateCreated", "TrackId" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 4, 11, 13, 51, 43, 810, DateTimeKind.Unspecified).AddTicks(1321), new TimeSpan(0, 0, 0, 0, 0)), "b47ee5b4-1659-4197-84f9-47ea74e6e577" });

            migrationBuilder.UpdateData(
                schema: "Troshka",
                table: "Locations",
                keyColumn: "Id",
                keyValue: "IlhkJUtQ8sLs4YnQmRHN",
                columns: new[] { "DateCreated", "TrackId" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 4, 11, 13, 51, 43, 809, DateTimeKind.Unspecified).AddTicks(7800), new TimeSpan(0, 0, 0, 0, 0)), "c61d866d-d7cd-41dc-9f2a-aaa973ec2253" });

            migrationBuilder.UpdateData(
                schema: "Troshka",
                table: "Locations",
                keyColumn: "Id",
                keyValue: "iu4VWQqmLdHN17PQdvzH",
                columns: new[] { "DateCreated", "TrackId" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 4, 11, 13, 51, 43, 810, DateTimeKind.Unspecified).AddTicks(122), new TimeSpan(0, 0, 0, 0, 0)), "0e679010-5ba1-40cf-9fbc-d80ba17f85c4" });

            migrationBuilder.UpdateData(
                schema: "Troshka",
                table: "Locations",
                keyColumn: "Id",
                keyValue: "iWDmKxgAGouVUA50vC4M",
                columns: new[] { "DateCreated", "TrackId" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 4, 11, 13, 51, 43, 810, DateTimeKind.Unspecified).AddTicks(1595), new TimeSpan(0, 0, 0, 0, 0)), "83bd1d03-8b64-4778-9da2-b76d68beb7f4" });

            migrationBuilder.UpdateData(
                schema: "Troshka",
                table: "Locations",
                keyColumn: "Id",
                keyValue: "IxJYV5M8k3tW6QNI1XNy",
                columns: new[] { "DateCreated", "TrackId" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 4, 11, 13, 51, 43, 809, DateTimeKind.Unspecified).AddTicks(9825), new TimeSpan(0, 0, 0, 0, 0)), "1f2698bf-d073-44e0-8884-f77b985aa6c3" });

            migrationBuilder.UpdateData(
                schema: "Troshka",
                table: "Locations",
                keyColumn: "Id",
                keyValue: "j69zA6NGRTWjfaJiFgAv",
                columns: new[] { "DateCreated", "TrackId" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 4, 11, 13, 51, 43, 810, DateTimeKind.Unspecified).AddTicks(1303), new TimeSpan(0, 0, 0, 0, 0)), "416333e7-bf7f-4a33-9119-473e00874372" });

            migrationBuilder.UpdateData(
                schema: "Troshka",
                table: "Locations",
                keyColumn: "Id",
                keyValue: "J9xfAHAcdeoqMZf5Z32o",
                columns: new[] { "DateCreated", "TrackId" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 4, 11, 13, 51, 43, 809, DateTimeKind.Unspecified).AddTicks(9176), new TimeSpan(0, 0, 0, 0, 0)), "9a841a4c-50e5-4d82-8170-479d02da95a3" });

            migrationBuilder.UpdateData(
                schema: "Troshka",
                table: "Locations",
                keyColumn: "Id",
                keyValue: "JcR9lG8H05RZRXqxVcdn",
                columns: new[] { "DateCreated", "TrackId" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 4, 11, 13, 51, 43, 810, DateTimeKind.Unspecified).AddTicks(1640), new TimeSpan(0, 0, 0, 0, 0)), "528226f7-cdfb-4ec5-bc7f-e1a7394e8936" });

            migrationBuilder.UpdateData(
                schema: "Troshka",
                table: "Locations",
                keyColumn: "Id",
                keyValue: "jgBCeqg0TYU2bwGYLlyj",
                columns: new[] { "DateCreated", "TrackId" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 4, 11, 13, 51, 43, 810, DateTimeKind.Unspecified).AddTicks(220), new TimeSpan(0, 0, 0, 0, 0)), "fd8d4387-660a-45e2-a89f-7bed57442fac" });

            migrationBuilder.UpdateData(
                schema: "Troshka",
                table: "Locations",
                keyColumn: "Id",
                keyValue: "Jh36r96IWwkRc0jtT8Uz",
                columns: new[] { "DateCreated", "TrackId" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 4, 11, 13, 51, 43, 810, DateTimeKind.Unspecified).AddTicks(1403), new TimeSpan(0, 0, 0, 0, 0)), "1fdb1198-928c-4d7e-a12d-e90ba9a1a3a5" });

            migrationBuilder.UpdateData(
                schema: "Troshka",
                table: "Locations",
                keyColumn: "Id",
                keyValue: "jP1vOHqdRr77lzEQOhUV",
                columns: new[] { "DateCreated", "TrackId" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 4, 11, 13, 51, 43, 810, DateTimeKind.Unspecified).AddTicks(295), new TimeSpan(0, 0, 0, 0, 0)), "cde515c6-e085-429d-bb76-b31bc53f44ed" });

            migrationBuilder.UpdateData(
                schema: "Troshka",
                table: "Locations",
                keyColumn: "Id",
                keyValue: "JsJF774TI5lhUXT7lyu6",
                columns: new[] { "DateCreated", "TrackId" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 4, 11, 13, 51, 43, 809, DateTimeKind.Unspecified).AddTicks(7875), new TimeSpan(0, 0, 0, 0, 0)), "e5e7a77e-a6bd-481e-85d6-cd3ebf60669a" });

            migrationBuilder.UpdateData(
                schema: "Troshka",
                table: "Locations",
                keyColumn: "Id",
                keyValue: "jz9QoDqp8nMi3sT5bxrf",
                columns: new[] { "DateCreated", "TrackId" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 4, 11, 13, 51, 43, 809, DateTimeKind.Unspecified).AddTicks(8161), new TimeSpan(0, 0, 0, 0, 0)), "41e9198f-c554-4a3a-9a54-7b5504b938e1" });

            migrationBuilder.UpdateData(
                schema: "Troshka",
                table: "Locations",
                keyColumn: "Id",
                keyValue: "k0qeWBID2X22pEgtfvgo",
                columns: new[] { "DateCreated", "TrackId" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 4, 11, 13, 51, 43, 809, DateTimeKind.Unspecified).AddTicks(7964), new TimeSpan(0, 0, 0, 0, 0)), "916364f7-d31d-478d-bb14-ac6f30ece985" });

            migrationBuilder.UpdateData(
                schema: "Troshka",
                table: "Locations",
                keyColumn: "Id",
                keyValue: "K25n9KJ1vxNw3MGsoreR",
                columns: new[] { "DateCreated", "TrackId" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 4, 11, 13, 51, 43, 809, DateTimeKind.Unspecified).AddTicks(9035), new TimeSpan(0, 0, 0, 0, 0)), "9f2b5433-5ae2-4745-ad2a-276df3ce99fc" });

            migrationBuilder.UpdateData(
                schema: "Troshka",
                table: "Locations",
                keyColumn: "Id",
                keyValue: "KmSbHInKfoSIyIlT2gWX",
                columns: new[] { "DateCreated", "TrackId" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 4, 11, 13, 51, 43, 809, DateTimeKind.Unspecified).AddTicks(8229), new TimeSpan(0, 0, 0, 0, 0)), "89dc5327-78d0-4f39-9273-39ae8960a0b5" });

            migrationBuilder.UpdateData(
                schema: "Troshka",
                table: "Locations",
                keyColumn: "Id",
                keyValue: "Krd6NYyD0XMYztMGhAiX",
                columns: new[] { "DateCreated", "TrackId" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 4, 11, 13, 51, 43, 810, DateTimeKind.Unspecified).AddTicks(652), new TimeSpan(0, 0, 0, 0, 0)), "0014a108-c3e1-4a39-8197-c76a7e9d719b" });

            migrationBuilder.UpdateData(
                schema: "Troshka",
                table: "Locations",
                keyColumn: "Id",
                keyValue: "ktNgoxLzSAUwMztZhavh",
                columns: new[] { "DateCreated", "TrackId" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 4, 11, 13, 51, 43, 809, DateTimeKind.Unspecified).AddTicks(7594), new TimeSpan(0, 0, 0, 0, 0)), "460cfbe7-92bf-40f2-8bdf-a5d6db7c98f9" });

            migrationBuilder.UpdateData(
                schema: "Troshka",
                table: "Locations",
                keyColumn: "Id",
                keyValue: "KzVg96EpghmFIyTZQXFu",
                columns: new[] { "DateCreated", "TrackId" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 4, 11, 13, 51, 43, 810, DateTimeKind.Unspecified).AddTicks(1483), new TimeSpan(0, 0, 0, 0, 0)), "c00bd142-592b-41cb-b8e9-ddfdab81f95a" });

            migrationBuilder.UpdateData(
                schema: "Troshka",
                table: "Locations",
                keyColumn: "Id",
                keyValue: "l2yUOjlKLR2h1V5VrYsi",
                columns: new[] { "DateCreated", "TrackId" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 4, 11, 13, 51, 43, 809, DateTimeKind.Unspecified).AddTicks(7705), new TimeSpan(0, 0, 0, 0, 0)), "911766dd-79cc-4814-9f02-8877911d3e98" });

            migrationBuilder.UpdateData(
                schema: "Troshka",
                table: "Locations",
                keyColumn: "Id",
                keyValue: "lAdtqn0mI1TymJG9ZH8W",
                columns: new[] { "DateCreated", "TrackId" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 4, 11, 13, 51, 43, 810, DateTimeKind.Unspecified).AddTicks(588), new TimeSpan(0, 0, 0, 0, 0)), "f1cdb250-d5f7-44d4-8055-548c8af403cf" });

            migrationBuilder.UpdateData(
                schema: "Troshka",
                table: "Locations",
                keyColumn: "Id",
                keyValue: "lDcp7H9Ze01LedaVkc1t",
                columns: new[] { "DateCreated", "TrackId" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 4, 11, 13, 51, 43, 810, DateTimeKind.Unspecified).AddTicks(463), new TimeSpan(0, 0, 0, 0, 0)), "09f75d86-695c-4763-9461-b237196d420b" });

            migrationBuilder.UpdateData(
                schema: "Troshka",
                table: "Locations",
                keyColumn: "Id",
                keyValue: "LhvYW2Zd57VcnjPFJSSH",
                columns: new[] { "DateCreated", "TrackId" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 4, 11, 13, 51, 43, 809, DateTimeKind.Unspecified).AddTicks(9897), new TimeSpan(0, 0, 0, 0, 0)), "91a533e8-66b0-49ea-86fc-9adbf11b184d" });

            migrationBuilder.UpdateData(
                schema: "Troshka",
                table: "Locations",
                keyColumn: "Id",
                keyValue: "LMNgjYs8Wlk3fn3BAgwI",
                columns: new[] { "DateCreated", "TrackId" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 4, 11, 13, 51, 43, 810, DateTimeKind.Unspecified).AddTicks(1471), new TimeSpan(0, 0, 0, 0, 0)), "054dc5de-305c-432b-a33d-e2f2a59ff840" });

            migrationBuilder.UpdateData(
                schema: "Troshka",
                table: "Locations",
                keyColumn: "Id",
                keyValue: "LrGsNZNeH2n6cJIxmXxJ",
                columns: new[] { "DateCreated", "TrackId" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 4, 11, 13, 51, 43, 810, DateTimeKind.Unspecified).AddTicks(271), new TimeSpan(0, 0, 0, 0, 0)), "c2befa2a-c21b-4a1d-9b89-2456d987e536" });

            migrationBuilder.UpdateData(
                schema: "Troshka",
                table: "Locations",
                keyColumn: "Id",
                keyValue: "LvGdpqiL8WD3lrR9DTV5",
                columns: new[] { "DateCreated", "TrackId" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 4, 11, 13, 51, 43, 809, DateTimeKind.Unspecified).AddTicks(8791), new TimeSpan(0, 0, 0, 0, 0)), "14ac5963-1074-40e3-9735-4db5d47f6abd" });

            migrationBuilder.UpdateData(
                schema: "Troshka",
                table: "Locations",
                keyColumn: "Id",
                keyValue: "lY3jQ83TvYtUO7AGHTeG",
                columns: new[] { "DateCreated", "TrackId" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 4, 11, 13, 51, 43, 810, DateTimeKind.Unspecified).AddTicks(546), new TimeSpan(0, 0, 0, 0, 0)), "28832a97-68cd-4b11-9e33-d9a9f816f0ae" });

            migrationBuilder.UpdateData(
                schema: "Troshka",
                table: "Locations",
                keyColumn: "Id",
                keyValue: "M20lrAzqGZHVUI9MA8Wd",
                columns: new[] { "DateCreated", "TrackId" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 4, 11, 13, 51, 43, 810, DateTimeKind.Unspecified).AddTicks(1565), new TimeSpan(0, 0, 0, 0, 0)), "26a06130-44ab-45cf-9086-fddd34db44f7" });

            migrationBuilder.UpdateData(
                schema: "Troshka",
                table: "Locations",
                keyColumn: "Id",
                keyValue: "mcqsM242WDKe5RWonk0N",
                columns: new[] { "DateCreated", "TrackId" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 4, 11, 13, 51, 43, 809, DateTimeKind.Unspecified).AddTicks(8800), new TimeSpan(0, 0, 0, 0, 0)), "470b0464-5be3-447b-bae2-c10135e6dd14" });

            migrationBuilder.UpdateData(
                schema: "Troshka",
                table: "Locations",
                keyColumn: "Id",
                keyValue: "mHwqAk1qNheJohLB1Jzd",
                columns: new[] { "DateCreated", "TrackId" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 4, 11, 13, 51, 43, 809, DateTimeKind.Unspecified).AddTicks(7882), new TimeSpan(0, 0, 0, 0, 0)), "054bc5e8-36f8-4a07-a4e6-644ab4a1d68d" });

            migrationBuilder.UpdateData(
                schema: "Troshka",
                table: "Locations",
                keyColumn: "Id",
                keyValue: "mJ1WHQcCFBdZ8GLGCU3Z",
                columns: new[] { "DateCreated", "TrackId" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 4, 11, 13, 51, 43, 809, DateTimeKind.Unspecified).AddTicks(9935), new TimeSpan(0, 0, 0, 0, 0)), "06dd95c7-a9fd-415d-83b1-f1c5fef6c047" });

            migrationBuilder.UpdateData(
                schema: "Troshka",
                table: "Locations",
                keyColumn: "Id",
                keyValue: "mjSinueV18LNv9TvBaYV",
                columns: new[] { "DateCreated", "TrackId" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 4, 11, 13, 51, 43, 810, DateTimeKind.Unspecified).AddTicks(627), new TimeSpan(0, 0, 0, 0, 0)), "e4a15ea7-e422-4187-9d5d-6d816a2cf120" });

            migrationBuilder.UpdateData(
                schema: "Troshka",
                table: "Locations",
                keyColumn: "Id",
                keyValue: "mkCTXyHRMwybEqLo25cz",
                columns: new[] { "DateCreated", "TrackId" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 4, 11, 13, 51, 43, 809, DateTimeKind.Unspecified).AddTicks(9831), new TimeSpan(0, 0, 0, 0, 0)), "c8f65eb4-9519-4c2d-8c85-b8a1578606ed" });

            migrationBuilder.UpdateData(
                schema: "Troshka",
                table: "Locations",
                keyColumn: "Id",
                keyValue: "MleUdK6EdxEEgMvRFgvw",
                columns: new[] { "DateCreated", "TrackId" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 4, 11, 13, 51, 43, 810, DateTimeKind.Unspecified).AddTicks(1397), new TimeSpan(0, 0, 0, 0, 0)), "ed08bba9-c21f-4a46-be95-bea41c7e8f1c" });

            migrationBuilder.UpdateData(
                schema: "Troshka",
                table: "Locations",
                keyColumn: "Id",
                keyValue: "mMScQFWGBGj82JUVSfa8",
                columns: new[] { "DateCreated", "TrackId" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 4, 11, 13, 51, 43, 810, DateTimeKind.Unspecified).AddTicks(3), new TimeSpan(0, 0, 0, 0, 0)), "1f9362f1-485e-4bee-b3d7-5db1a1c0f449" });

            migrationBuilder.UpdateData(
                schema: "Troshka",
                table: "Locations",
                keyColumn: "Id",
                keyValue: "MrQ6MrxoNdLH9AHWd1sZ",
                columns: new[] { "DateCreated", "TrackId" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 4, 11, 13, 51, 43, 810, DateTimeKind.Unspecified).AddTicks(16), new TimeSpan(0, 0, 0, 0, 0)), "6ad15830-b6b5-44aa-9f03-d52704866e57" });

            migrationBuilder.UpdateData(
                schema: "Troshka",
                table: "Locations",
                keyColumn: "Id",
                keyValue: "Mslmta38lcifuPv0Epep",
                columns: new[] { "DateCreated", "TrackId" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 4, 11, 13, 51, 43, 809, DateTimeKind.Unspecified).AddTicks(9292), new TimeSpan(0, 0, 0, 0, 0)), "96335ee5-4196-464a-971c-ed9060d75e4f" });

            migrationBuilder.UpdateData(
                schema: "Troshka",
                table: "Locations",
                keyColumn: "Id",
                keyValue: "MWLluWB5yYYo6dNJNfEy",
                columns: new[] { "DateCreated", "TrackId" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 4, 11, 13, 51, 43, 809, DateTimeKind.Unspecified).AddTicks(8240), new TimeSpan(0, 0, 0, 0, 0)), "c2290378-31eb-4204-a8a4-4ffcd8250211" });

            migrationBuilder.UpdateData(
                schema: "Troshka",
                table: "Locations",
                keyColumn: "Id",
                keyValue: "N7ZpDTXSfenP8ZWklmhn",
                columns: new[] { "DateCreated", "TrackId" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 4, 11, 13, 51, 43, 809, DateTimeKind.Unspecified).AddTicks(7625), new TimeSpan(0, 0, 0, 0, 0)), "410bd1a0-3bd7-401b-a0df-2463d9b91cab" });

            migrationBuilder.UpdateData(
                schema: "Troshka",
                table: "Locations",
                keyColumn: "Id",
                keyValue: "n9ejZ3UFp2QRKGnJBZTQ",
                columns: new[] { "DateCreated", "TrackId" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 4, 11, 13, 51, 43, 809, DateTimeKind.Unspecified).AddTicks(9024), new TimeSpan(0, 0, 0, 0, 0)), "c28defaf-d119-4ab2-8350-daf0a7632cd0" });

            migrationBuilder.UpdateData(
                schema: "Troshka",
                table: "Locations",
                keyColumn: "Id",
                keyValue: "neRh5vRSDkskEiRjkGmS",
                columns: new[] { "DateCreated", "TrackId" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 4, 11, 13, 51, 43, 809, DateTimeKind.Unspecified).AddTicks(7723), new TimeSpan(0, 0, 0, 0, 0)), "6287cc8b-5de4-451a-a24f-b46552dac8e7" });

            migrationBuilder.UpdateData(
                schema: "Troshka",
                table: "Locations",
                keyColumn: "Id",
                keyValue: "NJ4WrirIVRD2CL5LFVgZ",
                columns: new[] { "DateCreated", "TrackId" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 4, 11, 13, 51, 43, 809, DateTimeKind.Unspecified).AddTicks(8092), new TimeSpan(0, 0, 0, 0, 0)), "4ce168e9-01a0-46c0-9a85-79b8a5b39357" });

            migrationBuilder.UpdateData(
                schema: "Troshka",
                table: "Locations",
                keyColumn: "Id",
                keyValue: "NjMzJSgUCrBYha1Zyfz9",
                columns: new[] { "DateCreated", "TrackId" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 4, 11, 13, 51, 43, 810, DateTimeKind.Unspecified).AddTicks(534), new TimeSpan(0, 0, 0, 0, 0)), "cb8e7887-25f5-4eaf-adee-d0e3856afb0b" });

            migrationBuilder.UpdateData(
                schema: "Troshka",
                table: "Locations",
                keyColumn: "Id",
                keyValue: "nKjgqQ7r6rWE89oasS55",
                columns: new[] { "DateCreated", "TrackId" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 4, 11, 13, 51, 43, 810, DateTimeKind.Unspecified).AddTicks(1279), new TimeSpan(0, 0, 0, 0, 0)), "ad89413e-2eae-400b-acac-86e0153deb85" });

            migrationBuilder.UpdateData(
                schema: "Troshka",
                table: "Locations",
                keyColumn: "Id",
                keyValue: "nT6rVJX6LUwa4voci7P3",
                columns: new[] { "DateCreated", "TrackId" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 4, 11, 13, 51, 43, 809, DateTimeKind.Unspecified).AddTicks(8050), new TimeSpan(0, 0, 0, 0, 0)), "3adab266-1e26-4862-adba-b5c440afce4b" });

            migrationBuilder.UpdateData(
                schema: "Troshka",
                table: "Locations",
                keyColumn: "Id",
                keyValue: "nXHE363SurLsIHyCMiBp",
                columns: new[] { "DateCreated", "TrackId" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 4, 11, 13, 51, 43, 809, DateTimeKind.Unspecified).AddTicks(7688), new TimeSpan(0, 0, 0, 0, 0)), "d7c21f88-a50d-478d-8950-5ca057342f17" });

            migrationBuilder.UpdateData(
                schema: "Troshka",
                table: "Locations",
                keyColumn: "Id",
                keyValue: "nXrAW7KU9IUVnH36ttyB",
                columns: new[] { "DateCreated", "TrackId" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 4, 11, 13, 51, 43, 809, DateTimeKind.Unspecified).AddTicks(9903), new TimeSpan(0, 0, 0, 0, 0)), "40c02069-ede9-4a6a-beda-0c890b96b4f2" });

            migrationBuilder.UpdateData(
                schema: "Troshka",
                table: "Locations",
                keyColumn: "Id",
                keyValue: "o0cKUmrKeP32BdCL110f",
                columns: new[] { "DateCreated", "TrackId" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 4, 11, 13, 51, 43, 809, DateTimeKind.Unspecified).AddTicks(7783), new TimeSpan(0, 0, 0, 0, 0)), "0ee9b87c-d32b-4c6d-9f41-ae3535c75c33" });

            migrationBuilder.UpdateData(
                schema: "Troshka",
                table: "Locations",
                keyColumn: "Id",
                keyValue: "o5LA79ma20RbnbEWYkmI",
                columns: new[] { "DateCreated", "TrackId" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 4, 11, 13, 51, 43, 809, DateTimeKind.Unspecified).AddTicks(8137), new TimeSpan(0, 0, 0, 0, 0)), "d98c7ba3-a9e7-43f5-891e-61fdb4159dba" });

            migrationBuilder.UpdateData(
                schema: "Troshka",
                table: "Locations",
                keyColumn: "Id",
                keyValue: "oAcrUAlW0ogYQ0RbRpVR",
                columns: new[] { "DateCreated", "TrackId" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 4, 11, 13, 51, 43, 809, DateTimeKind.Unspecified).AddTicks(7586), new TimeSpan(0, 0, 0, 0, 0)), "24c719b3-af70-4abb-8a57-0e92cbf08a6b" });

            migrationBuilder.UpdateData(
                schema: "Troshka",
                table: "Locations",
                keyColumn: "Id",
                keyValue: "oaVzgKrfm2dtvEtulIPH",
                columns: new[] { "DateCreated", "TrackId" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 4, 11, 13, 51, 43, 809, DateTimeKind.Unspecified).AddTicks(8827), new TimeSpan(0, 0, 0, 0, 0)), "218e3d89-1103-4505-aa9d-6eaf2562f507" });

            migrationBuilder.UpdateData(
                schema: "Troshka",
                table: "Locations",
                keyColumn: "Id",
                keyValue: "OCfs7lrhfbA9Wg6Rfx5F",
                columns: new[] { "DateCreated", "TrackId" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 4, 11, 13, 51, 43, 810, DateTimeKind.Unspecified).AddTicks(197), new TimeSpan(0, 0, 0, 0, 0)), "a5a85a58-beaa-4c93-ab32-581db95667e7" });

            migrationBuilder.UpdateData(
                schema: "Troshka",
                table: "Locations",
                keyColumn: "Id",
                keyValue: "oEevNbxEQnzGOkwJ6yy6",
                columns: new[] { "DateCreated", "TrackId" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 4, 11, 13, 51, 43, 809, DateTimeKind.Unspecified).AddTicks(9991), new TimeSpan(0, 0, 0, 0, 0)), "cb986779-55b4-46a0-bc9d-282908803d9c" });

            migrationBuilder.UpdateData(
                schema: "Troshka",
                table: "Locations",
                keyColumn: "Id",
                keyValue: "oJ208ZU4uli478vZ4M6i",
                columns: new[] { "DateCreated", "TrackId" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 4, 11, 13, 51, 43, 809, DateTimeKind.Unspecified).AddTicks(7577), new TimeSpan(0, 0, 0, 0, 0)), "380af90b-800c-48ee-8dd2-93e90a976c5f" });

            migrationBuilder.UpdateData(
                schema: "Troshka",
                table: "Locations",
                keyColumn: "Id",
                keyValue: "OkZdYcu0vosTiBUlsaTK",
                columns: new[] { "DateCreated", "TrackId" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 4, 11, 13, 51, 43, 810, DateTimeKind.Unspecified).AddTicks(1224), new TimeSpan(0, 0, 0, 0, 0)), "e7e911fb-4537-4fc6-b41c-477dda4260a0" });

            migrationBuilder.UpdateData(
                schema: "Troshka",
                table: "Locations",
                keyColumn: "Id",
                keyValue: "OT5qlZSGxMGbWwUlhaKg",
                columns: new[] { "DateCreated", "TrackId" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 4, 11, 13, 51, 43, 809, DateTimeKind.Unspecified).AddTicks(8895), new TimeSpan(0, 0, 0, 0, 0)), "b3393260-2405-483b-84ba-3fdf35ed6fab" });

            migrationBuilder.UpdateData(
                schema: "Troshka",
                table: "Locations",
                keyColumn: "Id",
                keyValue: "OULp9a8mh6nxjaqmen44",
                columns: new[] { "DateCreated", "TrackId" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 4, 11, 13, 51, 43, 809, DateTimeKind.Unspecified).AddTicks(7716), new TimeSpan(0, 0, 0, 0, 0)), "79b1591b-1997-45bc-abd4-e4032990c00c" });

            migrationBuilder.UpdateData(
                schema: "Troshka",
                table: "Locations",
                keyColumn: "Id",
                keyValue: "OXQIGhEAp5LWzfAAiIMw",
                columns: new[] { "DateCreated", "TrackId" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 4, 11, 13, 51, 43, 809, DateTimeKind.Unspecified).AddTicks(8063), new TimeSpan(0, 0, 0, 0, 0)), "9903a808-9f78-4aa6-888c-8be51eef1b00" });

            migrationBuilder.UpdateData(
                schema: "Troshka",
                table: "Locations",
                keyColumn: "Id",
                keyValue: "OXw0BOe4VgQX1Dulp8Y7",
                columns: new[] { "DateCreated", "TrackId" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 4, 11, 13, 51, 43, 810, DateTimeKind.Unspecified).AddTicks(1374), new TimeSpan(0, 0, 0, 0, 0)), "78a115fa-93d6-491b-9983-144d80cb223b" });

            migrationBuilder.UpdateData(
                schema: "Troshka",
                table: "Locations",
                keyColumn: "Id",
                keyValue: "p2tNo4gVXkKryIhrQO7O",
                columns: new[] { "DateCreated", "TrackId" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 4, 11, 13, 51, 43, 810, DateTimeKind.Unspecified).AddTicks(540), new TimeSpan(0, 0, 0, 0, 0)), "553494d9-43b2-49b1-b2fe-d4c33ee2270b" });

            migrationBuilder.UpdateData(
                schema: "Troshka",
                table: "Locations",
                keyColumn: "Id",
                keyValue: "PJj3P4Dm64a1F2VWqRoA",
                columns: new[] { "DateCreated", "TrackId" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 4, 11, 13, 51, 43, 809, DateTimeKind.Unspecified).AddTicks(8783), new TimeSpan(0, 0, 0, 0, 0)), "994e303c-4fb9-4f4e-9eec-35de88c529d3" });

            migrationBuilder.UpdateData(
                schema: "Troshka",
                table: "Locations",
                keyColumn: "Id",
                keyValue: "pm4OxVXHinF0L6nCdnMD",
                columns: new[] { "DateCreated", "TrackId" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 4, 11, 13, 51, 43, 809, DateTimeKind.Unspecified).AddTicks(7794), new TimeSpan(0, 0, 0, 0, 0)), "5e429672-1122-41d9-819d-c00059d97280" });

            migrationBuilder.UpdateData(
                schema: "Troshka",
                table: "Locations",
                keyColumn: "Id",
                keyValue: "PnW2WNjEeVFRvyrv5ZBt",
                columns: new[] { "DateCreated", "TrackId" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 4, 11, 13, 51, 43, 810, DateTimeKind.Unspecified).AddTicks(1490), new TimeSpan(0, 0, 0, 0, 0)), "84ab3113-3931-4bb6-be0f-5d8b9cf68311" });

            migrationBuilder.UpdateData(
                schema: "Troshka",
                table: "Locations",
                keyColumn: "Id",
                keyValue: "psNuk1A7JD7egnOkzY7h",
                columns: new[] { "DateCreated", "TrackId" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 4, 11, 13, 51, 43, 810, DateTimeKind.Unspecified).AddTicks(551), new TimeSpan(0, 0, 0, 0, 0)), "49d3ad3a-07f5-4725-95cb-0083a7dce109" });

            migrationBuilder.UpdateData(
                schema: "Troshka",
                table: "Locations",
                keyColumn: "Id",
                keyValue: "PyyPB23ytzhgST9DVsqT",
                columns: new[] { "DateCreated", "TrackId" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 4, 11, 13, 51, 43, 810, DateTimeKind.Unspecified).AddTicks(1297), new TimeSpan(0, 0, 0, 0, 0)), "c46a8b70-6b16-4982-b41b-ae2dba3adf12" });

            migrationBuilder.UpdateData(
                schema: "Troshka",
                table: "Locations",
                keyColumn: "Id",
                keyValue: "pznK4lXtvyzmSPVnsE7K",
                columns: new[] { "DateCreated", "TrackId" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 4, 11, 13, 51, 43, 809, DateTimeKind.Unspecified).AddTicks(8178), new TimeSpan(0, 0, 0, 0, 0)), "9c462f4c-0860-4e0b-82fd-8209f9cc40c7" });

            migrationBuilder.UpdateData(
                schema: "Troshka",
                table: "Locations",
                keyColumn: "Id",
                keyValue: "QARSrEJj0U53F2F3gZw5",
                columns: new[] { "DateCreated", "TrackId" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 4, 11, 13, 51, 43, 809, DateTimeKind.Unspecified).AddTicks(9171), new TimeSpan(0, 0, 0, 0, 0)), "4c540a9b-06ac-4c1b-a7db-bb3d5e267f20" });

            migrationBuilder.UpdateData(
                schema: "Troshka",
                table: "Locations",
                keyColumn: "Id",
                keyValue: "qctT3P6FBPGWKggtZQxz",
                columns: new[] { "DateCreated", "TrackId" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 4, 11, 13, 51, 43, 810, DateTimeKind.Unspecified).AddTicks(1219), new TimeSpan(0, 0, 0, 0, 0)), "53527dae-c733-4660-a002-dc998da35fbc" });

            migrationBuilder.UpdateData(
                schema: "Troshka",
                table: "Locations",
                keyColumn: "Id",
                keyValue: "QdJXciCjgzXbHUnB0vdc",
                columns: new[] { "DateCreated", "TrackId" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 4, 11, 13, 51, 43, 809, DateTimeKind.Unspecified).AddTicks(9097), new TimeSpan(0, 0, 0, 0, 0)), "f5012a93-a36a-4e10-8424-0cef772d92f4" });

            migrationBuilder.UpdateData(
                schema: "Troshka",
                table: "Locations",
                keyColumn: "Id",
                keyValue: "QDy1m1rsNP05N2pThvQD",
                columns: new[] { "DateCreated", "TrackId" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 4, 11, 13, 51, 43, 809, DateTimeKind.Unspecified).AddTicks(7682), new TimeSpan(0, 0, 0, 0, 0)), "d8875a2a-c6a3-4716-9568-79ed2242527e" });

            migrationBuilder.UpdateData(
                schema: "Troshka",
                table: "Locations",
                keyColumn: "Id",
                keyValue: "QI7qoqQIrRMgOewnFUHl",
                columns: new[] { "DateCreated", "TrackId" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 4, 11, 13, 51, 43, 810, DateTimeKind.Unspecified).AddTicks(105), new TimeSpan(0, 0, 0, 0, 0)), "eb13b7e4-f7b6-4a17-a60d-b4cf346c0b5a" });

            migrationBuilder.UpdateData(
                schema: "Troshka",
                table: "Locations",
                keyColumn: "Id",
                keyValue: "qMj4zvnLsSjVcJIHifMa",
                columns: new[] { "DateCreated", "TrackId" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 4, 11, 13, 51, 43, 809, DateTimeKind.Unspecified).AddTicks(9250), new TimeSpan(0, 0, 0, 0, 0)), "9ad63375-f933-4749-98c5-558025429c2d" });

            migrationBuilder.UpdateData(
                schema: "Troshka",
                table: "Locations",
                keyColumn: "Id",
                keyValue: "qy9lR5La7DGButn4oAWa",
                columns: new[] { "DateCreated", "TrackId" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 4, 11, 13, 51, 43, 809, DateTimeKind.Unspecified).AddTicks(7982), new TimeSpan(0, 0, 0, 0, 0)), "2fb5bc7c-63b6-4332-8af3-8b21e4771d27" });

            migrationBuilder.UpdateData(
                schema: "Troshka",
                table: "Locations",
                keyColumn: "Id",
                keyValue: "RaapWhH7MlJ4KqXrk1sK",
                columns: new[] { "DateCreated", "TrackId" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 4, 11, 13, 51, 43, 809, DateTimeKind.Unspecified).AddTicks(7969), new TimeSpan(0, 0, 0, 0, 0)), "8b51960c-0022-444c-b51b-cc701e9a2cbb" });

            migrationBuilder.UpdateData(
                schema: "Troshka",
                table: "Locations",
                keyColumn: "Id",
                keyValue: "rawPiSej2aJVSDBqB4OV",
                columns: new[] { "DateCreated", "TrackId" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 4, 11, 13, 51, 43, 810, DateTimeKind.Unspecified).AddTicks(1459), new TimeSpan(0, 0, 0, 0, 0)), "bb1b0493-b53e-4107-8771-ea613fdf88f7" });

            migrationBuilder.UpdateData(
                schema: "Troshka",
                table: "Locations",
                keyColumn: "Id",
                keyValue: "RDwk0wPVlEf8krGzgn1F",
                columns: new[] { "DateCreated", "TrackId" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 4, 11, 13, 51, 43, 810, DateTimeKind.Unspecified).AddTicks(1584), new TimeSpan(0, 0, 0, 0, 0)), "14eced78-24ba-4539-8e0c-4c2554d7c3aa" });

            migrationBuilder.UpdateData(
                schema: "Troshka",
                table: "Locations",
                keyColumn: "Id",
                keyValue: "rKsGztdt3tpTLP8oJaGm",
                columns: new[] { "DateCreated", "TrackId" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 4, 11, 13, 51, 43, 809, DateTimeKind.Unspecified).AddTicks(7613), new TimeSpan(0, 0, 0, 0, 0)), "3cd6950a-1433-4fa2-96c6-b494e6b57bec" });

            migrationBuilder.UpdateData(
                schema: "Troshka",
                table: "Locations",
                keyColumn: "Id",
                keyValue: "RlHMkFktfQKSYU27BYAd",
                columns: new[] { "DateCreated", "TrackId" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 4, 11, 13, 51, 43, 809, DateTimeKind.Unspecified).AddTicks(9818), new TimeSpan(0, 0, 0, 0, 0)), "46b1983e-0c1c-4765-9bc6-e09eed084510" });

            migrationBuilder.UpdateData(
                schema: "Troshka",
                table: "Locations",
                keyColumn: "Id",
                keyValue: "RQXQFDTvCpoZ0a3Kayho",
                columns: new[] { "DateCreated", "TrackId" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 4, 11, 13, 51, 43, 810, DateTimeKind.Unspecified).AddTicks(658), new TimeSpan(0, 0, 0, 0, 0)), "c190617d-0b00-4c44-bb6e-d3ccdd3c12db" });

            migrationBuilder.UpdateData(
                schema: "Troshka",
                table: "Locations",
                keyColumn: "Id",
                keyValue: "rQywXXnmGKlGHQnnNhwN",
                columns: new[] { "DateCreated", "TrackId" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 4, 11, 13, 51, 43, 810, DateTimeKind.Unspecified).AddTicks(1653), new TimeSpan(0, 0, 0, 0, 0)), "1e840495-e921-4121-896e-6a74c56be8a9" });

            migrationBuilder.UpdateData(
                schema: "Troshka",
                table: "Locations",
                keyColumn: "Id",
                keyValue: "rViPdOyzRTCEfafaZZva",
                columns: new[] { "DateCreated", "TrackId" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 4, 11, 13, 51, 43, 810, DateTimeKind.Unspecified).AddTicks(184), new TimeSpan(0, 0, 0, 0, 0)), "3a9c079a-e0b9-44bb-bc73-af9cdccb8ef0" });

            migrationBuilder.UpdateData(
                schema: "Troshka",
                table: "Locations",
                keyColumn: "Id",
                keyValue: "RxhSMfo1HmcWTgMQZq3K",
                columns: new[] { "DateCreated", "TrackId" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 4, 11, 13, 51, 43, 810, DateTimeKind.Unspecified).AddTicks(1207), new TimeSpan(0, 0, 0, 0, 0)), "bee266c4-c3e2-4ddb-9568-04ee0c261153" });

            migrationBuilder.UpdateData(
                schema: "Troshka",
                table: "Locations",
                keyColumn: "Id",
                keyValue: "S1sGzqNFLkd3UFZaAo80",
                columns: new[] { "DateCreated", "TrackId" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 4, 11, 13, 51, 43, 810, DateTimeKind.Unspecified).AddTicks(307), new TimeSpan(0, 0, 0, 0, 0)), "335748be-f362-42a5-b62f-91e076c2d8b0" });

            migrationBuilder.UpdateData(
                schema: "Troshka",
                table: "Locations",
                keyColumn: "Id",
                keyValue: "S2vkQdfficf7Nt5zW1qQ",
                columns: new[] { "DateCreated", "TrackId" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 4, 11, 13, 51, 43, 810, DateTimeKind.Unspecified).AddTicks(85), new TimeSpan(0, 0, 0, 0, 0)), "66e85d73-0ced-43a7-925f-bb7a903bb420" });

            migrationBuilder.UpdateData(
                schema: "Troshka",
                table: "Locations",
                keyColumn: "Id",
                keyValue: "S2w6rTeyOaF1tXhaJ8Jk",
                columns: new[] { "DateCreated", "TrackId" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 4, 11, 13, 51, 43, 809, DateTimeKind.Unspecified).AddTicks(7711), new TimeSpan(0, 0, 0, 0, 0)), "b10d25ca-bf2d-40e3-9368-210e730a88e7" });

            migrationBuilder.UpdateData(
                schema: "Troshka",
                table: "Locations",
                keyColumn: "Id",
                keyValue: "S4kkzIbMy9o6PaBFS1bp",
                columns: new[] { "DateCreated", "TrackId" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 4, 11, 13, 51, 43, 810, DateTimeKind.Unspecified).AddTicks(1496), new TimeSpan(0, 0, 0, 0, 0)), "b9529d2a-e90d-4e36-980a-3b3e2370bac4" });

            migrationBuilder.UpdateData(
                schema: "Troshka",
                table: "Locations",
                keyColumn: "Id",
                keyValue: "s5pCgajzVG8nPssxC28v",
                columns: new[] { "DateCreated", "TrackId" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 4, 11, 13, 51, 43, 809, DateTimeKind.Unspecified).AddTicks(8043), new TimeSpan(0, 0, 0, 0, 0)), "68c95530-8325-4497-b308-43c5f013e0a5" });

            migrationBuilder.UpdateData(
                schema: "Troshka",
                table: "Locations",
                keyColumn: "Id",
                keyValue: "S7um2STVboFUapfqAwjX",
                columns: new[] { "DateCreated", "TrackId" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 4, 11, 13, 51, 43, 810, DateTimeKind.Unspecified).AddTicks(1171), new TimeSpan(0, 0, 0, 0, 0)), "79fedf6e-c687-46d3-9473-dd027c9b7120" });

            migrationBuilder.UpdateData(
                schema: "Troshka",
                table: "Locations",
                keyColumn: "Id",
                keyValue: "sB1J1ycWUKtRgMNkZPMs",
                columns: new[] { "DateCreated", "TrackId" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 4, 11, 13, 51, 43, 809, DateTimeKind.Unspecified).AddTicks(9946), new TimeSpan(0, 0, 0, 0, 0)), "e48baf05-38a5-4aa3-a28e-17e3105716ac" });

            migrationBuilder.UpdateData(
                schema: "Troshka",
                table: "Locations",
                keyColumn: "Id",
                keyValue: "SFS0FQsFpzKsA1bb8z8t",
                columns: new[] { "DateCreated", "TrackId" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 4, 11, 13, 51, 43, 810, DateTimeKind.Unspecified).AddTicks(93), new TimeSpan(0, 0, 0, 0, 0)), "c49beca5-18e4-4157-83b9-ac680c9852b4" });

            migrationBuilder.UpdateData(
                schema: "Troshka",
                table: "Locations",
                keyColumn: "Id",
                keyValue: "siPMFqiO6URwVNHYeZQe",
                columns: new[] { "DateCreated", "TrackId" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 4, 11, 13, 51, 43, 810, DateTimeKind.Unspecified).AddTicks(408), new TimeSpan(0, 0, 0, 0, 0)), "fc953008-deae-4364-900d-010e3c06ee45" });

            migrationBuilder.UpdateData(
                schema: "Troshka",
                table: "Locations",
                keyColumn: "Id",
                keyValue: "t0rlN2Z8xXtbnjiGbn2g",
                columns: new[] { "DateCreated", "TrackId" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 4, 11, 13, 51, 43, 810, DateTimeKind.Unspecified).AddTicks(1572), new TimeSpan(0, 0, 0, 0, 0)), "beceaf39-32f7-4773-98c3-26eea8a925b0" });

            migrationBuilder.UpdateData(
                schema: "Troshka",
                table: "Locations",
                keyColumn: "Id",
                keyValue: "T8SgJhTrIV9JeuZoxWmp",
                columns: new[] { "DateCreated", "TrackId" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 4, 11, 13, 51, 43, 810, DateTimeKind.Unspecified).AddTicks(1156), new TimeSpan(0, 0, 0, 0, 0)), "2070284d-9d0c-45f1-8274-9de2628b53f6" });

            migrationBuilder.UpdateData(
                schema: "Troshka",
                table: "Locations",
                keyColumn: "Id",
                keyValue: "TCw3kE7IFoavq1DbZIQ4",
                columns: new[] { "DateCreated", "TrackId" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 4, 11, 13, 51, 43, 810, DateTimeKind.Unspecified).AddTicks(1477), new TimeSpan(0, 0, 0, 0, 0)), "830578a5-7111-46b5-9f61-6e47908d77ff" });

            migrationBuilder.UpdateData(
                schema: "Troshka",
                table: "Locations",
                keyColumn: "Id",
                keyValue: "TeV2DdAFfdCOkrbb4CNX",
                columns: new[] { "DateCreated", "TrackId" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 4, 11, 13, 51, 43, 810, DateTimeKind.Unspecified).AddTicks(110), new TimeSpan(0, 0, 0, 0, 0)), "7f73de96-a30a-4b51-97c2-7d032fcb3867" });

            migrationBuilder.UpdateData(
                schema: "Troshka",
                table: "Locations",
                keyColumn: "Id",
                keyValue: "TfR3QRJKEIPZ013jXnSy",
                columns: new[] { "DateCreated", "TrackId" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 4, 11, 13, 51, 43, 809, DateTimeKind.Unspecified).AddTicks(9921), new TimeSpan(0, 0, 0, 0, 0)), "1ca27040-6bc7-49ce-b148-b1622bafec61" });

            migrationBuilder.UpdateData(
                schema: "Troshka",
                table: "Locations",
                keyColumn: "Id",
                keyValue: "tnvDmxac1e1cknTnvewl",
                columns: new[] { "DateCreated", "TrackId" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 4, 11, 13, 51, 43, 809, DateTimeKind.Unspecified).AddTicks(9073), new TimeSpan(0, 0, 0, 0, 0)), "4f788f82-9ede-4356-8634-decb466a478e" });

            migrationBuilder.UpdateData(
                schema: "Troshka",
                table: "Locations",
                keyColumn: "Id",
                keyValue: "tossPcPHuBlDNrBKT570",
                columns: new[] { "DateCreated", "TrackId" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 4, 11, 13, 51, 43, 809, DateTimeKind.Unspecified).AddTicks(9263), new TimeSpan(0, 0, 0, 0, 0)), "b0cfbccb-2b81-45f7-afbb-2af585d24750" });

            migrationBuilder.UpdateData(
                schema: "Troshka",
                table: "Locations",
                keyColumn: "Id",
                keyValue: "tWUWYSi2oFeTNgxzijUa",
                columns: new[] { "DateCreated", "TrackId" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 4, 11, 13, 51, 43, 809, DateTimeKind.Unspecified).AddTicks(9107), new TimeSpan(0, 0, 0, 0, 0)), "a737b165-0197-4cf3-a4cc-084482e9730c" });

            migrationBuilder.UpdateData(
                schema: "Troshka",
                table: "Locations",
                keyColumn: "Id",
                keyValue: "TZS5F9cqVHqil0FHGjpq",
                columns: new[] { "DateCreated", "TrackId" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 4, 11, 13, 51, 43, 810, DateTimeKind.Unspecified).AddTicks(452), new TimeSpan(0, 0, 0, 0, 0)), "c491663e-f70d-425e-8339-d1515321bab6" });

            migrationBuilder.UpdateData(
                schema: "Troshka",
                table: "Locations",
                keyColumn: "Id",
                keyValue: "U7FlCWfts6poIKCBCEUU",
                columns: new[] { "DateCreated", "TrackId" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 4, 11, 13, 51, 43, 810, DateTimeKind.Unspecified).AddTicks(1507), new TimeSpan(0, 0, 0, 0, 0)), "8ae8eac5-d0f7-4711-b389-d414a9a0fe6a" });

            migrationBuilder.UpdateData(
                schema: "Troshka",
                table: "Locations",
                keyColumn: "Id",
                keyValue: "ue1Ma8tBRIWUsbflrxM2",
                columns: new[] { "DateCreated", "TrackId" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 4, 11, 13, 51, 43, 810, DateTimeKind.Unspecified).AddTicks(446), new TimeSpan(0, 0, 0, 0, 0)), "f0ac0989-c2f3-4be0-b0ca-bba2507d48fe" });

            migrationBuilder.UpdateData(
                schema: "Troshka",
                table: "Locations",
                keyColumn: "Id",
                keyValue: "ueZ1MdWK7lmwfn8Z91ap",
                columns: new[] { "DateCreated", "TrackId" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 4, 11, 13, 51, 43, 810, DateTimeKind.Unspecified).AddTicks(647), new TimeSpan(0, 0, 0, 0, 0)), "7f7de89f-21b8-4f07-ae56-939bec762bc2" });

            migrationBuilder.UpdateData(
                schema: "Troshka",
                table: "Locations",
                keyColumn: "Id",
                keyValue: "UFqsRmjk0qf0RLhr0Auj",
                columns: new[] { "DateCreated", "TrackId" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 4, 11, 13, 51, 43, 809, DateTimeKind.Unspecified).AddTicks(9929), new TimeSpan(0, 0, 0, 0, 0)), "fe7adb07-eb93-4acf-be3c-861ab8bb1c79" });

            migrationBuilder.UpdateData(
                schema: "Troshka",
                table: "Locations",
                keyColumn: "Id",
                keyValue: "UFVPO52TDL6wvWCmU2ZR",
                columns: new[] { "DateCreated", "TrackId" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 4, 11, 13, 51, 43, 809, DateTimeKind.Unspecified).AddTicks(7776), new TimeSpan(0, 0, 0, 0, 0)), "9d2d133a-d956-4de6-b488-2f9b804866c3" });

            migrationBuilder.UpdateData(
                schema: "Troshka",
                table: "Locations",
                keyColumn: "Id",
                keyValue: "UkaOFcL7n0R9GPOULEYg",
                columns: new[] { "DateCreated", "TrackId" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 4, 11, 13, 51, 43, 810, DateTimeKind.Unspecified).AddTicks(1590), new TimeSpan(0, 0, 0, 0, 0)), "08168006-aca9-4d42-94af-c16ce0a1858a" });

            migrationBuilder.UpdateData(
                schema: "Troshka",
                table: "Locations",
                keyColumn: "Id",
                keyValue: "ULEf4zBQJFH3WxKNk8qE",
                columns: new[] { "DateCreated", "TrackId" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 4, 11, 13, 51, 43, 810, DateTimeKind.Unspecified).AddTicks(359), new TimeSpan(0, 0, 0, 0, 0)), "a3bec139-d88d-4831-9b56-943e4f020db0" });

            migrationBuilder.UpdateData(
                schema: "Troshka",
                table: "Locations",
                keyColumn: "Id",
                keyValue: "uozP72hWugpEffJ4nCt8",
                columns: new[] { "DateCreated", "TrackId" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 4, 11, 13, 51, 43, 810, DateTimeKind.Unspecified).AddTicks(1552), new TimeSpan(0, 0, 0, 0, 0)), "067a6b0d-29b8-4e59-88a4-5803582932e6" });

            migrationBuilder.UpdateData(
                schema: "Troshka",
                table: "Locations",
                keyColumn: "Id",
                keyValue: "uRYk2q61neGVw3zxySGO",
                columns: new[] { "DateCreated", "TrackId" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 4, 11, 13, 51, 43, 809, DateTimeKind.Unspecified).AddTicks(7789), new TimeSpan(0, 0, 0, 0, 0)), "554db255-18d5-4e62-a021-824660aa4ff6" });

            migrationBuilder.UpdateData(
                schema: "Troshka",
                table: "Locations",
                keyColumn: "Id",
                keyValue: "uviWBW7fJ2gsQ1lwXmdj",
                columns: new[] { "DateCreated", "TrackId" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 4, 11, 13, 51, 43, 809, DateTimeKind.Unspecified).AddTicks(9997), new TimeSpan(0, 0, 0, 0, 0)), "4adff2bb-2d29-43f4-bd27-b0faa5b36c60" });

            migrationBuilder.UpdateData(
                schema: "Troshka",
                table: "Locations",
                keyColumn: "Id",
                keyValue: "uwfIrR3Z8Ynyl0MG2A5s",
                columns: new[] { "DateCreated", "TrackId" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 4, 11, 13, 51, 43, 809, DateTimeKind.Unspecified).AddTicks(8235), new TimeSpan(0, 0, 0, 0, 0)), "7d4d70bf-6568-4907-9a45-6c07321c8e7d" });

            migrationBuilder.UpdateData(
                schema: "Troshka",
                table: "Locations",
                keyColumn: "Id",
                keyValue: "V0LP9OYPgo6qtjJ9zHMi",
                columns: new[] { "DateCreated", "TrackId" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 4, 11, 13, 51, 43, 809, DateTimeKind.Unspecified).AddTicks(9845), new TimeSpan(0, 0, 0, 0, 0)), "ce7fd46f-b3ec-4ade-963d-163f8d9c25a2" });

            migrationBuilder.UpdateData(
                schema: "Troshka",
                table: "Locations",
                keyColumn: "Id",
                keyValue: "v8hGEwckM6erxaGpA72C",
                columns: new[] { "DateCreated", "TrackId" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 4, 11, 13, 51, 43, 809, DateTimeKind.Unspecified).AddTicks(8834), new TimeSpan(0, 0, 0, 0, 0)), "3c5633d4-3112-455c-8b02-f5052b7f59c9" });

            migrationBuilder.UpdateData(
                schema: "Troshka",
                table: "Locations",
                keyColumn: "Id",
                keyValue: "vdSm3tjuFT4nRQYiGddC",
                columns: new[] { "DateCreated", "TrackId" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 4, 11, 13, 51, 43, 809, DateTimeKind.Unspecified).AddTicks(8081), new TimeSpan(0, 0, 0, 0, 0)), "a2a94de5-31cb-4ca4-9ec6-1c7bccdc004b" });

            migrationBuilder.UpdateData(
                schema: "Troshka",
                table: "Locations",
                keyColumn: "Id",
                keyValue: "Vfy5GV76GiSUSdOz5mwK",
                columns: new[] { "DateCreated", "TrackId" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 4, 11, 13, 51, 43, 809, DateTimeKind.Unspecified).AddTicks(7907), new TimeSpan(0, 0, 0, 0, 0)), "bd441eb7-9296-4283-8082-fa7f57f5db0c" });

            migrationBuilder.UpdateData(
                schema: "Troshka",
                table: "Locations",
                keyColumn: "Id",
                keyValue: "VG0ih8K83XZFUAsfIqvH",
                columns: new[] { "DateCreated", "TrackId" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 4, 11, 13, 51, 43, 809, DateTimeKind.Unspecified).AddTicks(9299), new TimeSpan(0, 0, 0, 0, 0)), "0c9a09fc-3e4e-4b6e-882e-d862d56c737d" });

            migrationBuilder.UpdateData(
                schema: "Troshka",
                table: "Locations",
                keyColumn: "Id",
                keyValue: "vGWAQsutHV7z2BelkL0i",
                columns: new[] { "DateCreated", "TrackId" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 4, 11, 13, 51, 43, 809, DateTimeKind.Unspecified).AddTicks(8150), new TimeSpan(0, 0, 0, 0, 0)), "893a275b-93e2-4f67-92fe-4ff73fbaa126" });

            migrationBuilder.UpdateData(
                schema: "Troshka",
                table: "Locations",
                keyColumn: "Id",
                keyValue: "vihA0IRoR5Kl5EEfkVKA",
                columns: new[] { "DateCreated", "TrackId" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 4, 11, 13, 51, 43, 810, DateTimeKind.Unspecified).AddTicks(458), new TimeSpan(0, 0, 0, 0, 0)), "7c5ef780-a673-4df7-8735-445df2c79679" });

            migrationBuilder.UpdateData(
                schema: "Troshka",
                table: "Locations",
                keyColumn: "Id",
                keyValue: "vmzK8CfKyFJmDVvFPQ2u",
                columns: new[] { "DateCreated", "TrackId" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 4, 11, 13, 51, 43, 810, DateTimeKind.Unspecified).AddTicks(1421), new TimeSpan(0, 0, 0, 0, 0)), "4a7dfeab-e147-4115-897f-f64f64630c01" });

            migrationBuilder.UpdateData(
                schema: "Troshka",
                table: "Locations",
                keyColumn: "Id",
                keyValue: "Vnt8sAfEcMbGnLsS2WVk",
                columns: new[] { "DateCreated", "TrackId" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 4, 11, 13, 51, 43, 809, DateTimeKind.Unspecified).AddTicks(8167), new TimeSpan(0, 0, 0, 0, 0)), "f3eac1d7-dce2-41c7-82f8-a9c0672650fc" });

            migrationBuilder.UpdateData(
                schema: "Troshka",
                table: "Locations",
                keyColumn: "Id",
                keyValue: "vSQqEMQgaXGdqyiaTLFB",
                columns: new[] { "DateCreated", "TrackId" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 4, 11, 13, 51, 43, 809, DateTimeKind.Unspecified).AddTicks(9257), new TimeSpan(0, 0, 0, 0, 0)), "9a8eff6c-7ca0-48be-98ad-116ba78e2332" });

            migrationBuilder.UpdateData(
                schema: "Troshka",
                table: "Locations",
                keyColumn: "Id",
                keyValue: "VuIX2IXpHEMaONwRXNNc",
                columns: new[] { "DateCreated", "TrackId" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 4, 11, 13, 51, 43, 809, DateTimeKind.Unspecified).AddTicks(8075), new TimeSpan(0, 0, 0, 0, 0)), "12bee42e-9c1e-4e28-9781-1cb266b73e38" });

            migrationBuilder.UpdateData(
                schema: "Troshka",
                table: "Locations",
                keyColumn: "Id",
                keyValue: "VuXIqlejSA1q847cQu09",
                columns: new[] { "DateCreated", "TrackId" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 4, 11, 13, 51, 43, 809, DateTimeKind.Unspecified).AddTicks(7825), new TimeSpan(0, 0, 0, 0, 0)), "f5d5d9de-6c3a-4984-89a8-33e0ed205ea3" });

            migrationBuilder.UpdateData(
                schema: "Troshka",
                table: "Locations",
                keyColumn: "Id",
                keyValue: "w1Sz1FJaKCzennpUAe1k",
                columns: new[] { "DateCreated", "TrackId" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 4, 11, 13, 51, 43, 809, DateTimeKind.Unspecified).AddTicks(9286), new TimeSpan(0, 0, 0, 0, 0)), "a6614ea3-9d50-4701-945a-5c6f0b1a267b" });

            migrationBuilder.UpdateData(
                schema: "Troshka",
                table: "Locations",
                keyColumn: "Id",
                keyValue: "w9zUArINXv0niL56fPfN",
                columns: new[] { "DateCreated", "TrackId" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 4, 11, 13, 51, 43, 810, DateTimeKind.Unspecified).AddTicks(564), new TimeSpan(0, 0, 0, 0, 0)), "d09341a3-85e0-4d91-b3e9-b5466b56f9f0" });

            migrationBuilder.UpdateData(
                schema: "Troshka",
                table: "Locations",
                keyColumn: "Id",
                keyValue: "wf5BJ3JkTFhZmAvXig4z",
                columns: new[] { "DateCreated", "TrackId" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 4, 11, 13, 51, 43, 809, DateTimeKind.Unspecified).AddTicks(9194), new TimeSpan(0, 0, 0, 0, 0)), "5648725a-a91a-4437-87d6-035eff87dfc7" });

            migrationBuilder.UpdateData(
                schema: "Troshka",
                table: "Locations",
                keyColumn: "Id",
                keyValue: "Whp8KN0wly7vyJBV08dx",
                columns: new[] { "DateCreated", "TrackId" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 4, 11, 13, 51, 43, 809, DateTimeKind.Unspecified).AddTicks(7819), new TimeSpan(0, 0, 0, 0, 0)), "bfa42348-7cc1-41e2-afc6-d0eb6eed657b" });

            migrationBuilder.UpdateData(
                schema: "Troshka",
                table: "Locations",
                keyColumn: "Id",
                keyValue: "WKmKGc87G61qV36YDZQI",
                columns: new[] { "DateCreated", "TrackId" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 4, 11, 13, 51, 43, 809, DateTimeKind.Unspecified).AddTicks(9274), new TimeSpan(0, 0, 0, 0, 0)), "22666a07-6c59-46ab-a028-c764f436a646" });

            migrationBuilder.UpdateData(
                schema: "Troshka",
                table: "Locations",
                keyColumn: "Id",
                keyValue: "wlwq7kXv477tP5l8h2w6",
                columns: new[] { "DateCreated", "TrackId" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 4, 11, 13, 51, 43, 809, DateTimeKind.Unspecified).AddTicks(8846), new TimeSpan(0, 0, 0, 0, 0)), "e9a15213-a922-4342-83a2-7bdec585d33d" });

            migrationBuilder.UpdateData(
                schema: "Troshka",
                table: "Locations",
                keyColumn: "Id",
                keyValue: "WNsQxDfQ62aPnftdMy3Y",
                columns: new[] { "DateCreated", "TrackId" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 4, 11, 13, 51, 43, 809, DateTimeKind.Unspecified).AddTicks(7699), new TimeSpan(0, 0, 0, 0, 0)), "0a2c440d-af0a-4b25-be2b-bd95d1247601" });

            migrationBuilder.UpdateData(
                schema: "Troshka",
                table: "Locations",
                keyColumn: "Id",
                keyValue: "WNylfUSJCwHOuKoxQZto",
                columns: new[] { "DateCreated", "TrackId" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 4, 11, 13, 51, 43, 809, DateTimeKind.Unspecified).AddTicks(9120), new TimeSpan(0, 0, 0, 0, 0)), "16a2f456-9d54-4a6b-97ae-241b898bad3d" });

            migrationBuilder.UpdateData(
                schema: "Troshka",
                table: "Locations",
                keyColumn: "Id",
                keyValue: "WQKG79hP3NOpph6GIYmZ",
                columns: new[] { "DateCreated", "TrackId" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 4, 11, 13, 51, 43, 810, DateTimeKind.Unspecified).AddTicks(396), new TimeSpan(0, 0, 0, 0, 0)), "de3d9fc7-5528-4c2f-8cd7-75412733d317" });

            migrationBuilder.UpdateData(
                schema: "Troshka",
                table: "Locations",
                keyColumn: "Id",
                keyValue: "WwDGt8iofwVBruHGDqvF",
                columns: new[] { "DateCreated", "TrackId" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 4, 11, 13, 51, 43, 809, DateTimeKind.Unspecified).AddTicks(8155), new TimeSpan(0, 0, 0, 0, 0)), "3aacee03-fb32-4e32-bfe5-6a98030663ba" });

            migrationBuilder.UpdateData(
                schema: "Troshka",
                table: "Locations",
                keyColumn: "Id",
                keyValue: "x6bJPDAAZoGfIMiYm0A1",
                columns: new[] { "DateCreated", "TrackId" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 4, 11, 13, 51, 43, 809, DateTimeKind.Unspecified).AddTicks(9005), new TimeSpan(0, 0, 0, 0, 0)), "2bce69e4-b04b-49f9-a4ed-d439f273b8b3" });

            migrationBuilder.UpdateData(
                schema: "Troshka",
                table: "Locations",
                keyColumn: "Id",
                keyValue: "Xc5DkNFRN3YDCKSXjqmD",
                columns: new[] { "DateCreated", "TrackId" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 4, 11, 13, 51, 43, 809, DateTimeKind.Unspecified).AddTicks(8840), new TimeSpan(0, 0, 0, 0, 0)), "bbac0bce-de32-4b26-ab08-46b96b9e32ac" });

            migrationBuilder.UpdateData(
                schema: "Troshka",
                table: "Locations",
                keyColumn: "Id",
                keyValue: "xG94yBtSqXmcNHqlkfpF",
                columns: new[] { "DateCreated", "TrackId" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 4, 11, 13, 51, 43, 809, DateTimeKind.Unspecified).AddTicks(9163), new TimeSpan(0, 0, 0, 0, 0)), "51ef8749-ba85-4ff3-8820-d76c51add482" });

            migrationBuilder.UpdateData(
                schema: "Troshka",
                table: "Locations",
                keyColumn: "Id",
                keyValue: "XITLm79cIkPGCUZIseRi",
                columns: new[] { "DateCreated", "TrackId" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 4, 11, 13, 51, 43, 809, DateTimeKind.Unspecified).AddTicks(8130), new TimeSpan(0, 0, 0, 0, 0)), "434bac97-8fbc-4883-9d1d-7e58cbbc0b45" });

            migrationBuilder.UpdateData(
                schema: "Troshka",
                table: "Locations",
                keyColumn: "Id",
                keyValue: "xnp3ZB1fKARKQ1hlkCew",
                columns: new[] { "DateCreated", "TrackId" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 4, 11, 13, 51, 43, 810, DateTimeKind.Unspecified).AddTicks(571), new TimeSpan(0, 0, 0, 0, 0)), "4c9a8f9e-ae72-4881-aa42-face12ef187a" });

            migrationBuilder.UpdateData(
                schema: "Troshka",
                table: "Locations",
                keyColumn: "Id",
                keyValue: "XQiCPslzUNbQ4bGuRTLH",
                columns: new[] { "DateCreated", "TrackId" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 4, 11, 13, 51, 43, 810, DateTimeKind.Unspecified).AddTicks(402), new TimeSpan(0, 0, 0, 0, 0)), "c6997465-ce2a-4e51-8424-37c2468fa725" });

            migrationBuilder.UpdateData(
                schema: "Troshka",
                table: "Locations",
                keyColumn: "Id",
                keyValue: "XQnjZaeTz0HbMKc25iUO",
                columns: new[] { "DateCreated", "TrackId" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 4, 11, 13, 51, 43, 809, DateTimeKind.Unspecified).AddTicks(9012), new TimeSpan(0, 0, 0, 0, 0)), "610b85e8-a318-45fd-b4fd-6b9cee5ac4dd" });

            migrationBuilder.UpdateData(
                schema: "Troshka",
                table: "Locations",
                keyColumn: "Id",
                keyValue: "xtviuqZWNHgI8Vm3uDvm",
                columns: new[] { "DateCreated", "TrackId" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 4, 11, 13, 51, 43, 810, DateTimeKind.Unspecified).AddTicks(377), new TimeSpan(0, 0, 0, 0, 0)), "3a4b6ca8-6dd1-44ed-b466-a628f67b447e" });

            migrationBuilder.UpdateData(
                schema: "Troshka",
                table: "Locations",
                keyColumn: "Id",
                keyValue: "XW6zBYsRpc1kLLE5Kz6m",
                columns: new[] { "DateCreated", "TrackId" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 4, 11, 13, 51, 43, 809, DateTimeKind.Unspecified).AddTicks(7975), new TimeSpan(0, 0, 0, 0, 0)), "b7a8c3a8-b686-49ac-947c-cb62150d09d3" });

            migrationBuilder.UpdateData(
                schema: "Troshka",
                table: "Locations",
                keyColumn: "Id",
                keyValue: "XyBpFKul4FhqG6qJbjeJ",
                columns: new[] { "DateCreated", "TrackId" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 4, 11, 13, 51, 43, 809, DateTimeKind.Unspecified).AddTicks(8069), new TimeSpan(0, 0, 0, 0, 0)), "aa2da420-f667-43cf-9526-d43b21703ed0" });

            migrationBuilder.UpdateData(
                schema: "Troshka",
                table: "Locations",
                keyColumn: "Id",
                keyValue: "xzmKSRB4qDTxvbyF3uRp",
                columns: new[] { "DateCreated", "TrackId" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 4, 11, 13, 51, 43, 810, DateTimeKind.Unspecified).AddTicks(128), new TimeSpan(0, 0, 0, 0, 0)), "91af5d23-35c8-4c68-887f-4bcbbc97f4c5" });

            migrationBuilder.UpdateData(
                schema: "Troshka",
                table: "Locations",
                keyColumn: "Id",
                keyValue: "yCK4ieG4tnpBiiDiZenX",
                columns: new[] { "DateCreated", "TrackId" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 4, 11, 13, 51, 43, 810, DateTimeKind.Unspecified).AddTicks(388), new TimeSpan(0, 0, 0, 0, 0)), "5766b0cb-d417-4688-bbda-cc575a13d049" });

            migrationBuilder.UpdateData(
                schema: "Troshka",
                table: "Locations",
                keyColumn: "Id",
                keyValue: "yCp9InZJJIMpwiOkNs19",
                columns: new[] { "DateCreated", "TrackId" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 4, 11, 13, 51, 43, 810, DateTimeKind.Unspecified).AddTicks(73), new TimeSpan(0, 0, 0, 0, 0)), "b9f18c85-a585-495d-986f-d41fe813f07d" });

            migrationBuilder.UpdateData(
                schema: "Troshka",
                table: "Locations",
                keyColumn: "Id",
                keyValue: "Yf3xbaXybnoCEGoBzXXp",
                columns: new[] { "DateCreated", "TrackId" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 4, 11, 13, 51, 43, 810, DateTimeKind.Unspecified).AddTicks(1213), new TimeSpan(0, 0, 0, 0, 0)), "7b465ebe-3e00-4d90-994e-6e8140d79d99" });

            migrationBuilder.UpdateData(
                schema: "Troshka",
                table: "Locations",
                keyColumn: "Id",
                keyValue: "YlRTjjDvXo6T9jUyAoXm",
                columns: new[] { "DateCreated", "TrackId" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 4, 11, 13, 51, 43, 809, DateTimeKind.Unspecified).AddTicks(7806), new TimeSpan(0, 0, 0, 0, 0)), "8098352b-2ee3-4d28-ba1b-baf13ee36254" });

            migrationBuilder.UpdateData(
                schema: "Troshka",
                table: "Locations",
                keyColumn: "Id",
                keyValue: "yltDkNBX68HMpeUHLfOr",
                columns: new[] { "DateCreated", "TrackId" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 4, 11, 13, 51, 43, 810, DateTimeKind.Unspecified).AddTicks(675), new TimeSpan(0, 0, 0, 0, 0)), "c9632109-914f-48a1-91a9-3ef72d16c470" });

            migrationBuilder.UpdateData(
                schema: "Troshka",
                table: "Locations",
                keyColumn: "Id",
                keyValue: "YLUdtyrlc6gLjsr7R609",
                columns: new[] { "DateCreated", "TrackId" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 4, 11, 13, 51, 43, 809, DateTimeKind.Unspecified).AddTicks(7630), new TimeSpan(0, 0, 0, 0, 0)), "20288ce6-0119-4af6-bb4f-665d56d87036" });

            migrationBuilder.UpdateData(
                schema: "Troshka",
                table: "Locations",
                keyColumn: "Id",
                keyValue: "YryGMVv9dOjqLh0TT5Ip",
                columns: new[] { "DateCreated", "TrackId" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 4, 11, 13, 51, 43, 809, DateTimeKind.Unspecified).AddTicks(9102), new TimeSpan(0, 0, 0, 0, 0)), "1011df7e-6e81-4187-9549-2493829a56f2" });

            migrationBuilder.UpdateData(
                schema: "Troshka",
                table: "Locations",
                keyColumn: "Id",
                keyValue: "YtdC9THcgwBXzcqEKCi5",
                columns: new[] { "DateCreated", "TrackId" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 4, 11, 13, 51, 43, 809, DateTimeKind.Unspecified).AddTicks(7957), new TimeSpan(0, 0, 0, 0, 0)), "df307640-e9a1-47ac-bb77-5b733d2b0bca" });

            migrationBuilder.UpdateData(
                schema: "Troshka",
                table: "Locations",
                keyColumn: "Id",
                keyValue: "yuA0YdFLUb4Xs0ud6awq",
                columns: new[] { "DateCreated", "TrackId" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 4, 11, 13, 51, 43, 809, DateTimeKind.Unspecified).AddTicks(8912), new TimeSpan(0, 0, 0, 0, 0)), "2b351bd6-cfea-40db-b015-d056e22382da" });

            migrationBuilder.UpdateData(
                schema: "Troshka",
                table: "Locations",
                keyColumn: "Id",
                keyValue: "YUgFQ7igSTdKCm5qBjl4",
                columns: new[] { "DateCreated", "TrackId" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 4, 11, 13, 51, 43, 810, DateTimeKind.Unspecified).AddTicks(265), new TimeSpan(0, 0, 0, 0, 0)), "0f41c5b6-d335-4ed4-b88b-6b86afe05fbb" });

            migrationBuilder.UpdateData(
                schema: "Troshka",
                table: "Locations",
                keyColumn: "Id",
                keyValue: "yURtV8KVpsCiFrfZfUOI",
                columns: new[] { "DateCreated", "TrackId" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 4, 11, 13, 51, 43, 810, DateTimeKind.Unspecified).AddTicks(641), new TimeSpan(0, 0, 0, 0, 0)), "3bb4889c-67e1-4d42-949a-507048b32aea" });

            migrationBuilder.UpdateData(
                schema: "Troshka",
                table: "Locations",
                keyColumn: "Id",
                keyValue: "YvNF8L5OFrgNQAt8MyWv",
                columns: new[] { "DateCreated", "TrackId" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 4, 11, 13, 51, 43, 809, DateTimeKind.Unspecified).AddTicks(7619), new TimeSpan(0, 0, 0, 0, 0)), "8c919177-c6d2-4983-8b2d-a8a1c45cedbb" });

            migrationBuilder.UpdateData(
                schema: "Troshka",
                table: "Locations",
                keyColumn: "Id",
                keyValue: "yXx1bXVPWWU4h7uV2zBo",
                columns: new[] { "DateCreated", "TrackId" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 4, 11, 13, 51, 43, 810, DateTimeKind.Unspecified).AddTicks(1659), new TimeSpan(0, 0, 0, 0, 0)), "35d3f3d4-0512-4de2-9690-50e18b8bf4da" });

            migrationBuilder.UpdateData(
                schema: "Troshka",
                table: "Locations",
                keyColumn: "Id",
                keyValue: "ZMKNREeEFhom9N1wEbeO",
                columns: new[] { "DateCreated", "TrackId" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 4, 11, 13, 51, 43, 810, DateTimeKind.Unspecified).AddTicks(176), new TimeSpan(0, 0, 0, 0, 0)), "9e81172f-579f-4ca0-84c8-671cf71dad45" });

            migrationBuilder.UpdateData(
                schema: "Troshka",
                table: "Locations",
                keyColumn: "Id",
                keyValue: "Zp2mKsaYrEc2WBZhjtj7",
                columns: new[] { "DateCreated", "TrackId" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 4, 11, 13, 51, 43, 809, DateTimeKind.Unspecified).AddTicks(8931), new TimeSpan(0, 0, 0, 0, 0)), "72cec1d3-9544-43f5-a2b5-7c49dc0f4d62" });

            migrationBuilder.UpdateData(
                schema: "Troshka",
                table: "Locations",
                keyColumn: "Id",
                keyValue: "ZZTm6w0YgaHTc4LjEk5d",
                columns: new[] { "DateCreated", "TrackId" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 4, 11, 13, 51, 43, 809, DateTimeKind.Unspecified).AddTicks(9786), new TimeSpan(0, 0, 0, 0, 0)), "04bc1e34-27b2-4a64-b546-fd55c7691773" });

            migrationBuilder.InsertData(
                schema: "Cars",
                table: "Models",
                columns: new[] { "Id", "CarBrandId", "DateCreated", "DateDeleted", "DateUpdated", "IsDeleted", "Name", "TrackId" },
                values: new object[,]
                {
                    { "02SaKt7gU9oX86ef2DD5", "5kDhCqXf6JTAIvz61oEz", new DateTimeOffset(new DateTime(2023, 4, 11, 13, 51, 43, 809, DateTimeKind.Unspecified).AddTicks(5439), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "i4", "1486457b-5d94-44b6-97e3-36833f0fb25b" },
                    { "0nw9LrFtlk85PMFaF47X", "48xSUCHrRIfABkLmGHxD", new DateTimeOffset(new DateTime(2023, 4, 11, 13, 51, 43, 809, DateTimeKind.Unspecified).AddTicks(3965), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "RS6", "ecc11328-fb51-4068-b071-f3db7950e8c5" },
                    { "14D6JWqXh1VM24x4jBDQ", "5kDhCqXf6JTAIvz61oEz", new DateTimeOffset(new DateTime(2023, 4, 11, 13, 51, 43, 809, DateTimeKind.Unspecified).AddTicks(5416), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "Alpina XD3", "dfcd7f2a-df99-4691-8623-b5417f6f6ae7" },
                    { "15eehWsAdmrugzeG8gED", "5kDhCqXf6JTAIvz61oEz", new DateTimeOffset(new DateTime(2023, 4, 11, 13, 51, 43, 809, DateTimeKind.Unspecified).AddTicks(6069), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "X1", "266293cb-5d87-4cfc-b103-da4ce2de4f87" },
                    { "17mPIaBNLyVkMb0Bzl7A", "48xSUCHrRIfABkLmGHxD", new DateTimeOffset(new DateTime(2023, 4, 11, 13, 51, 43, 809, DateTimeKind.Unspecified).AddTicks(4069), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "S5", "ac6aa2ec-fa86-4f0f-85f7-e4e1ecebcb8f" },
                    { "20m0YumXhffMT735Yz4s", "48xSUCHrRIfABkLmGHxD", new DateTimeOffset(new DateTime(2023, 4, 11, 13, 51, 43, 809, DateTimeKind.Unspecified).AddTicks(4081), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "S6", "98a40b8e-9bbf-4987-8a36-701a1c54c944" },
                    { "21ExoxLXTG93djXL3S4o", "2FEzeyYHYe3zlhjMeaEF", new DateTimeOffset(new DateTime(2023, 4, 11, 13, 51, 43, 809, DateTimeKind.Unspecified).AddTicks(2547), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "Slx", "21bade56-8a4c-4786-9113-f5d920677386" },
                    { "2AkBnL3lthpzVRMJTy6X", "2SBENlnqR76XRNAjbAs3", new DateTimeOffset(new DateTime(2023, 4, 11, 13, 51, 43, 809, DateTimeKind.Unspecified).AddTicks(2589), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "600", "be984d58-6b1b-4058-baa3-a401a90ff458" },
                    { "2lfGppvJN8z1lppRQdMG", "48xSUCHrRIfABkLmGHxD", new DateTimeOffset(new DateTime(2023, 4, 11, 13, 51, 43, 809, DateTimeKind.Unspecified).AddTicks(3640), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "A1 Sportback", "8bdefb70-925f-43af-8fd8-e1628c43dae2" },
                    { "2qbRq6VgFqePoHQLU9DJ", "5kDhCqXf6JTAIvz61oEz", new DateTimeOffset(new DateTime(2023, 4, 11, 13, 51, 43, 809, DateTimeKind.Unspecified).AddTicks(4919), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "323", "84d152fa-f6de-4df0-b4e7-6f548067c1ef" },
                    { "2qKSlVdx2xQI5yxFK5qR", "5kDhCqXf6JTAIvz61oEz", new DateTimeOffset(new DateTime(2023, 4, 11, 13, 51, 43, 809, DateTimeKind.Unspecified).AddTicks(4735), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "116", "34e3c23f-bfab-40f5-97fd-16c00e48b317" },
                    { "31e44jEe2SXrk51Mu2LU", "2VS5yLgAuj7VmYeRVxTD", new DateTimeOffset(new DateTime(2023, 4, 11, 13, 51, 43, 809, DateTimeKind.Unspecified).AddTicks(2748), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "Giulia", "7cae7f5d-ba87-472b-8fa0-fbcbf691d786" },
                    { "3d5I25wKSozAQAMtzPS7", "5kDhCqXf6JTAIvz61oEz", new DateTimeOffset(new DateTime(2023, 4, 11, 13, 51, 43, 809, DateTimeKind.Unspecified).AddTicks(5323), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "730", "4f5a465a-d461-4d81-800b-469adf44588d" },
                    { "3euKfNTXl3ug8n7eEB1f", "5kDhCqXf6JTAIvz61oEz", new DateTimeOffset(new DateTime(2023, 4, 11, 13, 51, 43, 809, DateTimeKind.Unspecified).AddTicks(6092), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "X5", "5a8a4da3-aca0-4561-a9df-d40ddf679b26" },
                    { "3mRqG7BLMhgMnnCsK63k", "48xSUCHrRIfABkLmGHxD", new DateTimeOffset(new DateTime(2023, 4, 11, 13, 51, 43, 809, DateTimeKind.Unspecified).AddTicks(3887), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "Q5 Sportback", "29c0c353-458f-4e02-8b08-e56558422d58" },
                    { "4FYRWMwxPPUpXgglqw8L", "0SlIJFKD3VdaMAEnxfTT", new DateTimeOffset(new DateTime(2023, 4, 11, 13, 51, 43, 809, DateTimeKind.Unspecified).AddTicks(2441), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "All", "a33a119f-3539-47aa-85bd-508664d87fbd" },
                    { "4JS8QssV7EVRMe6u2u9o", "5kDhCqXf6JTAIvz61oEz", new DateTimeOffset(new DateTime(2023, 4, 11, 13, 51, 43, 809, DateTimeKind.Unspecified).AddTicks(6056), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "X6 M", "9e4e8ded-518e-4b8d-bef2-508cfbb773e9" },
                    { "53Gh5YBboF9MB9r74ILN", "2VS5yLgAuj7VmYeRVxTD", new DateTimeOffset(new DateTime(2023, 4, 11, 13, 51, 43, 809, DateTimeKind.Unspecified).AddTicks(2664), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "159", "54488ba6-1351-45a2-aa19-7c98d7076b18" },
                    { "59BdngdbkFPnnj0xntyo", "5kDhCqXf6JTAIvz61oEz", new DateTimeOffset(new DateTime(2023, 4, 11, 13, 51, 43, 809, DateTimeKind.Unspecified).AddTicks(5175), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "540", "1e84317b-9e93-45f4-9709-0df31307afc6" },
                    { "5cfVFCAc5Jlwp9hFokHx", "2VS5yLgAuj7VmYeRVxTD", new DateTimeOffset(new DateTime(2023, 4, 11, 13, 51, 43, 809, DateTimeKind.Unspecified).AddTicks(2764), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "GTV", "ed65a8ea-9a8e-46f0-9261-4305428429b8" },
                    { "5NP8g6fMLRXcGpIURYRt", "48xSUCHrRIfABkLmGHxD", new DateTimeOffset(new DateTime(2023, 4, 11, 13, 51, 43, 809, DateTimeKind.Unspecified).AddTicks(3651), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "A3", "a432471b-f17c-4903-bac5-c74cfe570210" },
                    { "5YBSSxVDhXhjargn5LpH", "2FEzeyYHYe3zlhjMeaEF", new DateTimeOffset(new DateTime(2023, 4, 11, 13, 51, 43, 809, DateTimeKind.Unspecified).AddTicks(2463), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "Mdx", "972e37a5-2be8-4d8d-95e4-e7d4d566550f" },
                    { "5YuVpdTIl8YkFxQ1KVeI", "5kDhCqXf6JTAIvz61oEz", new DateTimeOffset(new DateTime(2023, 4, 11, 13, 51, 43, 809, DateTimeKind.Unspecified).AddTicks(6081), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "X3", "400ca497-d8a0-4997-b4bf-c7bb231b577b" },
                    { "6Dqt6DEYhdsWJnAfgrJz", "5kDhCqXf6JTAIvz61oEz", new DateTimeOffset(new DateTime(2023, 4, 11, 13, 51, 43, 809, DateTimeKind.Unspecified).AddTicks(4815), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "All 2-series", "879ee35e-0dd9-46aa-bf9e-2b98fe65565f" },
                    { "6EVr2IfvsCJxPsMcIh2g", "5kDhCqXf6JTAIvz61oEz", new DateTimeOffset(new DateTime(2023, 4, 11, 13, 51, 43, 809, DateTimeKind.Unspecified).AddTicks(5009), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "418", "c85d4887-2042-493e-8d5e-ced6c2f72dcc" },
                    { "6HkqdmpG81IqEGy9VNyq", "2FEzeyYHYe3zlhjMeaEF", new DateTimeOffset(new DateTime(2023, 4, 11, 13, 51, 43, 809, DateTimeKind.Unspecified).AddTicks(2447), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "ILX", "133976a1-03c0-421b-9c5b-429e6ee821a8" },
                    { "6HobKUcCJyDdVLHpCU4e", "5kDhCqXf6JTAIvz61oEz", new DateTimeOffset(new DateTime(2023, 4, 11, 13, 51, 43, 809, DateTimeKind.Unspecified).AddTicks(5255), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "640", "bcf9734c-a868-4a40-8e8e-8a655d5bc9d7" },
                    { "6I65GCCwB2EFfcLh7pm8", "470SJrcKER8YaPHSS0br", new DateTimeOffset(new DateTime(2023, 4, 11, 13, 51, 43, 809, DateTimeKind.Unspecified).AddTicks(3508), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "Db7", "524709ca-96f7-4700-8bb8-97b0b83cfa80" },
                    { "6jREXXNKPBgjMsEpkgmD", "2FEzeyYHYe3zlhjMeaEF", new DateTimeOffset(new DateTime(2023, 4, 11, 13, 51, 43, 809, DateTimeKind.Unspecified).AddTicks(2572), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "ZDX", "7fe0860b-2916-405f-987f-0e1cc363f385" },
                    { "6MuKfzcyCPfyVQM3WHba", "48xSUCHrRIfABkLmGHxD", new DateTimeOffset(new DateTime(2023, 4, 11, 13, 51, 43, 809, DateTimeKind.Unspecified).AddTicks(3801), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "A8", "bd4ff51b-9a2e-4e06-ae1b-12d173cf6c3f" },
                    { "6yTpk1frCTBHUEGt7p9I", "2VS5yLgAuj7VmYeRVxTD", new DateTimeOffset(new DateTime(2023, 4, 11, 13, 51, 43, 809, DateTimeKind.Unspecified).AddTicks(2771), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "MiTo", "a85410c5-1609-43c5-a07d-0b21496231bc" },
                    { "774A0lmo27IHyrRIBu9E", "5kDhCqXf6JTAIvz61oEz", new DateTimeOffset(new DateTime(2023, 4, 11, 13, 51, 43, 809, DateTimeKind.Unspecified).AddTicks(5992), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "M4", "a4f4deb6-c157-4251-8e57-49e341ef2ea7" },
                    { "7e1NBjSC3h70F28268XQ", "2VS5yLgAuj7VmYeRVxTD", new DateTimeOffset(new DateTime(2023, 4, 11, 13, 51, 43, 809, DateTimeKind.Unspecified).AddTicks(2652), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "156", "c6866b9a-8c5b-441b-b7ff-a4137b789cd9" },
                    { "8E6tCqBl3N6DesujECWd", "470SJrcKER8YaPHSS0br", new DateTimeOffset(new DateTime(2023, 4, 11, 13, 51, 43, 809, DateTimeKind.Unspecified).AddTicks(3487), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "DBS", "c5b72d8e-fb67-4ada-a5cc-757f6202330c" },
                    { "8EVIgYAhWRE78pTgDUv6", "5kDhCqXf6JTAIvz61oEz", new DateTimeOffset(new DateTime(2023, 4, 11, 13, 51, 43, 809, DateTimeKind.Unspecified).AddTicks(4914), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "320", "8783bf40-28b0-47f0-8c16-70056c514a8c" },
                    { "8GMuJREeVo3TVACFYjpk", "48xSUCHrRIfABkLmGHxD", new DateTimeOffset(new DateTime(2023, 4, 11, 13, 51, 43, 809, DateTimeKind.Unspecified).AddTicks(3990), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "RSQ3", "756dea2b-23d8-4a16-8d06-7236b7a23a3e" },
                    { "8yTeTI3bl7MX03BIq9bH", "5kDhCqXf6JTAIvz61oEz", new DateTimeOffset(new DateTime(2023, 4, 11, 13, 51, 43, 809, DateTimeKind.Unspecified).AddTicks(5352), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "750IL", "37318268-3355-4fc0-bdfd-772758f2de54" },
                    { "9jopsSFUULzC68AsFmts", "2xSRLgR4QgzYhDLjfgAM", new DateTimeOffset(new DateTime(2023, 4, 11, 13, 51, 43, 809, DateTimeKind.Unspecified).AddTicks(3457), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "XD3", "7af5707e-b2f7-4adb-8e2c-d58179a06e48" },
                    { "9mQpu9qsD1TjrDjqaPmB", "2VS5yLgAuj7VmYeRVxTD", new DateTimeOffset(new DateTime(2023, 4, 11, 13, 51, 43, 809, DateTimeKind.Unspecified).AddTicks(2670), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "159 SW", "adfcff45-e296-42eb-b28a-e49f23334bb4" },
                    { "9pDbCh6wMapWCBFbWmX3", "2xSRLgR4QgzYhDLjfgAM", new DateTimeOffset(new DateTime(2023, 4, 11, 13, 51, 43, 809, DateTimeKind.Unspecified).AddTicks(2938), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "D4", "32358a4d-1645-4cf4-9862-60303e2d1073" },
                    { "9xFoMzol4TrhmvN7HwJG", "48xSUCHrRIfABkLmGHxD", new DateTimeOffset(new DateTime(2023, 4, 11, 13, 51, 43, 809, DateTimeKind.Unspecified).AddTicks(3812), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "E-tron", "bb2769ca-ec91-4077-bf2e-df66115aea5e" },
                    { "aCLQEq2HIfhzMmPfD0L8", "5kDhCqXf6JTAIvz61oEz", new DateTimeOffset(new DateTime(2023, 4, 11, 13, 51, 43, 809, DateTimeKind.Unspecified).AddTicks(4730), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "114", "4ee2ea05-6de0-406e-9a1c-788910d60274" },
                    { "aDCrGht19oYdrpmJCyJR", "5kDhCqXf6JTAIvz61oEz", new DateTimeOffset(new DateTime(2023, 4, 11, 13, 51, 43, 809, DateTimeKind.Unspecified).AddTicks(4792), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "125", "e810ab6c-b532-4d15-b854-dd3ff7c9079b" },
                    { "aKGhFykfXFfxY8NfbQv8", "48xSUCHrRIfABkLmGHxD", new DateTimeOffset(new DateTime(2023, 4, 11, 13, 51, 43, 809, DateTimeKind.Unspecified).AddTicks(3690), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "A3 Sportback", "6bc390bd-afba-4809-b07c-22bb5b235168" },
                    { "Al8QrWKsmEr8AkS9qmAI", "48xSUCHrRIfABkLmGHxD", new DateTimeOffset(new DateTime(2023, 4, 11, 13, 51, 43, 809, DateTimeKind.Unspecified).AddTicks(3795), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "A7 Sportback", "1190b1a1-79f3-4f00-9e5d-fd18f50661b1" },
                    { "Am3NKeHple4mdVP6hCkL", "2xSRLgR4QgzYhDLjfgAM", new DateTimeOffset(new DateTime(2023, 4, 11, 13, 51, 43, 809, DateTimeKind.Unspecified).AddTicks(2844), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "B3", "3118d0d1-e125-49af-926f-d4f8bab0e2a6" },
                    { "APV6Vp1X96VTbysrB3xu", "5kDhCqXf6JTAIvz61oEz", new DateTimeOffset(new DateTime(2023, 4, 11, 13, 51, 43, 809, DateTimeKind.Unspecified).AddTicks(5266), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "650", "48864714-dbe7-4175-a4c1-1d4896554d08" },
                    { "ARJTLxp3BpBvpalFL53Y", "48xSUCHrRIfABkLmGHxD", new DateTimeOffset(new DateTime(2023, 4, 11, 13, 51, 43, 809, DateTimeKind.Unspecified).AddTicks(4104), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "SQ5", "dd9e95a2-aba9-4b5b-902b-76a878894df2" },
                    { "B3JHFe4uKqg65VIzYLa2", "5kDhCqXf6JTAIvz61oEz", new DateTimeOffset(new DateTime(2023, 4, 11, 13, 51, 43, 809, DateTimeKind.Unspecified).AddTicks(5237), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "628", "a34e6028-29f4-43ee-b522-738f581f5f87" },
                    { "B81uUI9NxhjLoJc6l5Cq", "48xSUCHrRIfABkLmGHxD", new DateTimeOffset(new DateTime(2023, 4, 11, 13, 51, 43, 809, DateTimeKind.Unspecified).AddTicks(3898), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "Q8", "843b3c39-8a28-4efb-9a70-37ce36704f43" },
                    { "BGPIFuFmMdxCN5q5F6P0", "48xSUCHrRIfABkLmGHxD", new DateTimeOffset(new DateTime(2023, 4, 11, 13, 51, 43, 809, DateTimeKind.Unspecified).AddTicks(3971), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "RS6 Avant", "1c5de732-0fbd-464b-8df0-0a3bbc4caaa1" },
                    { "bH5pRsv6e3g53gHPqSIP", "48xSUCHrRIfABkLmGHxD", new DateTimeOffset(new DateTime(2023, 4, 11, 13, 51, 43, 809, DateTimeKind.Unspecified).AddTicks(4063), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "S4 Avant", "11b76c0c-93f8-4848-be7f-9941a459a591" },
                    { "bj8XwvTNucBLcYXlvCo5", "5kDhCqXf6JTAIvz61oEz", new DateTimeOffset(new DateTime(2023, 4, 11, 13, 51, 43, 809, DateTimeKind.Unspecified).AddTicks(4803), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "135", "c0dcdb2a-374b-41b8-ae30-29fdf5258ffd" },
                    { "bSLwRfQmHM6UqwjQWDrJ", "2VS5yLgAuj7VmYeRVxTD", new DateTimeOffset(new DateTime(2023, 4, 11, 13, 51, 43, 809, DateTimeKind.Unspecified).AddTicks(2639), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "147", "b1cad00e-efe3-425f-8b93-48e83a2cfe9b" },
                    { "BTsWxVrSeGcy1hj36ACh", "5kDhCqXf6JTAIvz61oEz", new DateTimeOffset(new DateTime(2023, 4, 11, 13, 51, 43, 809, DateTimeKind.Unspecified).AddTicks(4985), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "330", "22a2cb7e-90ef-47d6-8d56-5d718670fadd" },
                    { "btxPwsGw68HU1t5gczot", "5kDhCqXf6JTAIvz61oEz", new DateTimeOffset(new DateTime(2023, 4, 11, 13, 51, 43, 809, DateTimeKind.Unspecified).AddTicks(5249), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "635", "8191db70-549b-4bd6-a58e-e3dcef7e976e" },
                    { "BVj3cLI0vRo5Ae0PhnFP", "48xSUCHrRIfABkLmGHxD", new DateTimeOffset(new DateTime(2023, 4, 11, 13, 51, 43, 809, DateTimeKind.Unspecified).AddTicks(4617), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "TT Roadster", "433972ef-aff6-4802-a166-6e7099e3f3ad" },
                    { "BWNkdN50tnyvPoSrHm5S", "2VS5yLgAuj7VmYeRVxTD", new DateTimeOffset(new DateTime(2023, 4, 11, 13, 51, 43, 809, DateTimeKind.Unspecified).AddTicks(2742), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "Crosswagon", "42840307-a26f-4664-a35a-34ec47b07a85" },
                    { "bWquPERClrGzu0BQaXG5", "48xSUCHrRIfABkLmGHxD", new DateTimeOffset(new DateTime(2023, 4, 11, 13, 51, 43, 809, DateTimeKind.Unspecified).AddTicks(3732), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "A6 Allroad", "93f8b978-0d62-4c3d-9dae-53f1018ae421" },
                    { "BWx7wk8XH8ksXIDrhvty", "2FEzeyYHYe3zlhjMeaEF", new DateTimeOffset(new DateTime(2023, 4, 11, 13, 51, 43, 809, DateTimeKind.Unspecified).AddTicks(2476), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "Rdx", "35cf8f4c-4eab-435f-8cbd-a4881b4cb839" },
                    { "bXB7y9UXxFYhbGBBDUUt", "48xSUCHrRIfABkLmGHxD", new DateTimeOffset(new DateTime(2023, 4, 11, 13, 51, 43, 809, DateTimeKind.Unspecified).AddTicks(4098), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "S8", "fa6c0748-3026-4022-8677-6fbeea301bd4" },
                    { "ByqWvBp2Ra83LBUPDGud", "5kDhCqXf6JTAIvz61oEz", new DateTimeOffset(new DateTime(2023, 4, 11, 13, 51, 43, 809, DateTimeKind.Unspecified).AddTicks(5358), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "760", "897b6960-5a51-4379-b252-7253e80ade06" },
                    { "c1gCdMoTS3BDBCKCAy70", "5kDhCqXf6JTAIvz61oEz", new DateTimeOffset(new DateTime(2023, 4, 11, 13, 51, 43, 809, DateTimeKind.Unspecified).AddTicks(5065), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "435", "8e1a001e-949a-42bc-bc9b-bdd7dbea4462" },
                    { "C55XLJRSjMnezvJX26gR", "5kDhCqXf6JTAIvz61oEz", new DateTimeOffset(new DateTime(2023, 4, 11, 13, 51, 43, 809, DateTimeKind.Unspecified).AddTicks(6075), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "X2", "30e73ec6-1781-4ffa-8e4e-f320adf185e3" },
                    { "C5VgYofpVU77YF1VcVkY", "5kDhCqXf6JTAIvz61oEz", new DateTimeOffset(new DateTime(2023, 4, 11, 13, 51, 43, 809, DateTimeKind.Unspecified).AddTicks(4883), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "3 Gran Turismo", "ff65eaa3-1952-4810-b177-8bda0b843f8c" },
                    { "cAFpUYCk0Unov9QdeeCY", "5kDhCqXf6JTAIvz61oEz", new DateTimeOffset(new DateTime(2023, 4, 11, 13, 51, 43, 809, DateTimeKind.Unspecified).AddTicks(5071), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "435i", "909f7e54-64ec-49bb-9ad7-c7cdc42ec02b" },
                    { "CdX9w9dQEfQJ3PVSPVJx", "5kDhCqXf6JTAIvz61oEz", new DateTimeOffset(new DateTime(2023, 4, 11, 13, 51, 43, 809, DateTimeKind.Unspecified).AddTicks(5986), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "M3", "a66ecef0-d5de-45bb-858f-d2521b29398d" },
                    { "CgNSdrWE6lkWIWKy6azW", "5kDhCqXf6JTAIvz61oEz", new DateTimeOffset(new DateTime(2023, 4, 11, 13, 51, 43, 809, DateTimeKind.Unspecified).AddTicks(5409), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "Alpina D4", "4f35f1f5-484f-4426-bbe4-5e23b20447e0" },
                    { "cJ5uGITtFyVjflbnUDIH", "48xSUCHrRIfABkLmGHxD", new DateTimeOffset(new DateTime(2023, 4, 11, 13, 51, 43, 809, DateTimeKind.Unspecified).AddTicks(4585), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "SQ7", "99d32a9c-3d7e-4343-ae52-cf092fc099a8" },
                    { "CNvqPpkTQdsUv04dEGy9", "2xSRLgR4QgzYhDLjfgAM", new DateTimeOffset(new DateTime(2023, 4, 11, 13, 51, 43, 809, DateTimeKind.Unspecified).AddTicks(2913), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "B9", "4cccaad6-fa63-424e-bb9e-4e953540f781" },
                    { "crat5VDyW9pE57bdsxe7", "5aFWwvagmpfBWQlHxU5M", new DateTimeOffset(new DateTime(2023, 4, 11, 13, 51, 43, 809, DateTimeKind.Unspecified).AddTicks(4707), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "Mini", "f36003a2-3a62-4060-9b20-72a46036b6cf" },
                    { "cUL2bq4xBRMvLbEyur6P", "5kDhCqXf6JTAIvz61oEz", new DateTimeOffset(new DateTime(2023, 4, 11, 13, 51, 43, 809, DateTimeKind.Unspecified).AddTicks(4780), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "120", "aa7e9af0-f067-4130-9211-5d6406552999" },
                    { "CUpJ5XUvhrgCJa4DDsHY", "48xSUCHrRIfABkLmGHxD", new DateTimeOffset(new DateTime(2023, 4, 11, 13, 51, 43, 809, DateTimeKind.Unspecified).AddTicks(3623), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "80", "9da02669-8b22-45d6-83b9-7a9ecb889726" },
                    { "d1MGMwDmQLxRxrQeew0s", "2VS5yLgAuj7VmYeRVxTD", new DateTimeOffset(new DateTime(2023, 4, 11, 13, 51, 43, 809, DateTimeKind.Unspecified).AddTicks(2726), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "Alfetta", "1e32de8c-64f4-4e67-b30f-316e65c96677" },
                    { "d2ujCB4mKmGByD7Jjmmb", "5kDhCqXf6JTAIvz61oEz", new DateTimeOffset(new DateTime(2023, 4, 11, 13, 51, 43, 809, DateTimeKind.Unspecified).AddTicks(5150), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "525", "81fcf228-934c-440e-8cc8-c708fb42685e" },
                    { "Dazzz2VbvYxfHqAXwX0Y", "48xSUCHrRIfABkLmGHxD", new DateTimeOffset(new DateTime(2023, 4, 11, 13, 51, 43, 809, DateTimeKind.Unspecified).AddTicks(3806), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "Allroad", "c179e86a-96dc-4ed0-9fd1-44e983966172" },
                    { "DbTBVBDLvaNUfowR7WMc", "48xSUCHrRIfABkLmGHxD", new DateTimeOffset(new DateTime(2023, 4, 11, 13, 51, 43, 809, DateTimeKind.Unspecified).AddTicks(3835), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "Q3 Sportback", "e51d2c4b-18fb-4c05-ae18-8f9dd77d2464" },
                    { "DcA8jCj8E7MKdHf86RgA", "2xSRLgR4QgzYhDLjfgAM", new DateTimeOffset(new DateTime(2023, 4, 11, 13, 51, 43, 809, DateTimeKind.Unspecified).AddTicks(2833), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "B11", "f22c4555-5ee6-414b-b7f0-7477cb62f171" },
                    { "DhUkpR3HpIzoN5TVvWmu", "48xSUCHrRIfABkLmGHxD", new DateTimeOffset(new DateTime(2023, 4, 11, 13, 51, 43, 809, DateTimeKind.Unspecified).AddTicks(3983), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "RS7 Sportback", "31c897a2-57b5-4667-865c-4be5e03ee143" },
                    { "dKXMQJgo4mvcvc6rWKML", "5kDhCqXf6JTAIvz61oEz", new DateTimeOffset(new DateTime(2023, 4, 11, 13, 51, 43, 809, DateTimeKind.Unspecified).AddTicks(5998), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "M5", "9a41d5ef-5d4e-42bf-9b4b-3867897e80dd" },
                    { "dLzXW1g2VzmkJSCBP9Yf", "48xSUCHrRIfABkLmGHxD", new DateTimeOffset(new DateTime(2023, 4, 11, 13, 51, 43, 809, DateTimeKind.Unspecified).AddTicks(3608), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "100", "4d1c5744-f4b8-4304-b02a-4680508eda3e" },
                    { "DzUm7JTeEF0GMhhtMAb5", "48xSUCHrRIfABkLmGHxD", new DateTimeOffset(new DateTime(2023, 4, 11, 13, 51, 43, 809, DateTimeKind.Unspecified).AddTicks(4058), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "S4", "043fc09a-1113-4d8f-8e41-1010e02602d6" },
                    { "E4bc7RBn4hJ078TqesIy", "5aFWwvagmpfBWQlHxU5M", new DateTimeOffset(new DateTime(2023, 4, 11, 13, 51, 43, 809, DateTimeKind.Unspecified).AddTicks(4651), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "Maxi", "039c54d3-71cb-4446-9361-4134beeb649d" },
                    { "E4KJJ9kpR19SIvPyKKn3", "48xSUCHrRIfABkLmGHxD", new DateTimeOffset(new DateTime(2023, 4, 11, 13, 51, 43, 809, DateTimeKind.Unspecified).AddTicks(3635), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "A1", "c3411db0-3ae1-4e3d-898b-e338ae3036d0" },
                    { "eKyyFtddG0Ww4oapuX0S", "3yTpJND7nxjtqoDcuc5M", new DateTimeOffset(new DateTime(2023, 4, 11, 13, 51, 43, 809, DateTimeKind.Unspecified).AddTicks(3478), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "Rocsta", "a3811c26-5fa6-4671-b8fe-9c75dda664f3" },
                    { "eqp42zTFh4BkFL7Q87N6", "48xSUCHrRIfABkLmGHxD", new DateTimeOffset(new DateTime(2023, 4, 11, 13, 51, 43, 809, DateTimeKind.Unspecified).AddTicks(4003), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "S1", "098c06e8-9f8a-4cd7-8456-2316a148cc94" },
                    { "F2jtUQa5cHzongYTBV9u", "48xSUCHrRIfABkLmGHxD", new DateTimeOffset(new DateTime(2023, 4, 11, 13, 51, 43, 809, DateTimeKind.Unspecified).AddTicks(3721), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "A5 Sportback", "6e1baff1-4665-4c91-b237-77fea2b08f71" },
                    { "f2KdyjY97tAAYWqMNKyI", "5kDhCqXf6JTAIvz61oEz", new DateTimeOffset(new DateTime(2023, 4, 11, 13, 51, 43, 809, DateTimeKind.Unspecified).AddTicks(5457), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "iX", "275cc0cc-9ad0-485e-b248-47723797e95d" },
                    { "f98wSQT4amGCwvguPnoF", "5kDhCqXf6JTAIvz61oEz", new DateTimeOffset(new DateTime(2023, 4, 11, 13, 51, 43, 809, DateTimeKind.Unspecified).AddTicks(6061), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "All X-series", "736c4eed-05c2-4513-9e5b-73c8338adcd8" },
                    { "FKWp1dydzgEMgNFuKBXb", "48xSUCHrRIfABkLmGHxD", new DateTimeOffset(new DateTime(2023, 4, 11, 13, 51, 43, 809, DateTimeKind.Unspecified).AddTicks(3921), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "RS4", "1f431c91-97e6-4b73-9d2e-3d0a06a5b174" },
                    { "FlCgfto9005AulgaSLtT", "2xSRLgR4QgzYhDLjfgAM", new DateTimeOffset(new DateTime(2023, 4, 11, 13, 51, 43, 809, DateTimeKind.Unspecified).AddTicks(2908), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "B8", "feead4e3-2e1d-4cf6-8e77-6dd71fc8f9c0" },
                    { "fLfD3vWuJpL7UWH0IKHo", "48xSUCHrRIfABkLmGHxD", new DateTimeOffset(new DateTime(2023, 4, 11, 13, 51, 43, 809, DateTimeKind.Unspecified).AddTicks(3715), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "A5", "b4c0e27d-a83a-433b-9f94-1897d5ac2d14" },
                    { "FQIlTJ7eE5jChttlVtIz", "5kDhCqXf6JTAIvz61oEz", new DateTimeOffset(new DateTime(2023, 4, 11, 13, 51, 43, 809, DateTimeKind.Unspecified).AddTicks(5329), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "735", "0b95c571-c30a-4cb9-ac01-18875780d02a" },
                    { "FWacLT8AtEGDB52EpPDg", "2FEzeyYHYe3zlhjMeaEF", new DateTimeOffset(new DateTime(2023, 4, 11, 13, 51, 43, 809, DateTimeKind.Unspecified).AddTicks(2553), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "TLX", "092f3204-d9d2-4c8e-a411-95747ba84715" },
                    { "fzAl25tH3yzmVQPpKoTX", "2VS5yLgAuj7VmYeRVxTD", new DateTimeOffset(new DateTime(2023, 4, 11, 13, 51, 43, 809, DateTimeKind.Unspecified).AddTicks(2659), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "156 Sportwagon", "b633119c-3bab-42ab-bdcb-4421858ee21c" },
                    { "G1mNSJe6JKjaaAHJ3XTD", "5kDhCqXf6JTAIvz61oEz", new DateTimeOffset(new DateTime(2023, 4, 11, 13, 51, 43, 809, DateTimeKind.Unspecified).AddTicks(6004), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "M6", "3caab299-fbf7-42b0-acf3-9c4dbf7ae554" },
                    { "G3RwU1fFboR50yJehJdb", "48xSUCHrRIfABkLmGHxD", new DateTimeOffset(new DateTime(2023, 4, 11, 13, 51, 43, 809, DateTimeKind.Unspecified).AddTicks(3646), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "A2", "98ca4ee4-3840-47f2-ac7e-9302402e936a" },
                    { "g4IyHUarGUKVXFIYd5IH", "48xSUCHrRIfABkLmGHxD", new DateTimeOffset(new DateTime(2023, 4, 11, 13, 51, 43, 809, DateTimeKind.Unspecified).AddTicks(3617), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "200", "dd30859d-72c9-4c9f-82f4-8ae4b8a4a76b" },
                    { "GA5vh7RceCaCmoaNQpy5", "5kDhCqXf6JTAIvz61oEz", new DateTimeOffset(new DateTime(2023, 4, 11, 13, 51, 43, 809, DateTimeKind.Unspecified).AddTicks(5053), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "428", "0afeefd6-91c4-473d-9b74-a2a8ccef15eb" },
                    { "GdIMyKJ5XWc68Fy9UdXj", "2VS5yLgAuj7VmYeRVxTD", new DateTimeOffset(new DateTime(2023, 4, 11, 13, 51, 43, 809, DateTimeKind.Unspecified).AddTicks(2732), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "Arna", "c7165f0c-88e3-49cd-bfe8-5ba7800f142e" },
                    { "GHA6rKPeFDu8vrYQNyvH", "5kDhCqXf6JTAIvz61oEz", new DateTimeOffset(new DateTime(2023, 4, 11, 13, 51, 43, 809, DateTimeKind.Unspecified).AddTicks(4979), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "328", "fa01015f-877f-4518-ab67-72f317b37786" },
                    { "gPhyRTqaaS3UAFjdhybS", "5kDhCqXf6JTAIvz61oEz", new DateTimeOffset(new DateTime(2023, 4, 11, 13, 51, 43, 809, DateTimeKind.Unspecified).AddTicks(5421), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "Bertone", "fd5f2b20-019e-4ab4-b117-d38277213469" },
                    { "GSLo8s8hPM93yhuYqEWg", "48xSUCHrRIfABkLmGHxD", new DateTimeOffset(new DateTime(2023, 4, 11, 13, 51, 43, 809, DateTimeKind.Unspecified).AddTicks(3737), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "A6 Avant", "c45157a2-859f-4d3f-8148-cb3a8c3af879" },
                    { "hcuyHthIVWW4G9s6TnkU", "5kDhCqXf6JTAIvz61oEz", new DateTimeOffset(new DateTime(2023, 4, 11, 13, 51, 43, 809, DateTimeKind.Unspecified).AddTicks(5271), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "All 7-series", "af663ee0-aa53-4fbb-8597-d6356575db9e" },
                    { "hDW5upCVANhq5Fd9lpCB", "48xSUCHrRIfABkLmGHxD", new DateTimeOffset(new DateTime(2023, 4, 11, 13, 51, 43, 809, DateTimeKind.Unspecified).AddTicks(3823), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "Q2", "a5d7ad2f-105a-4e70-b280-790fed6ca4f8" },
                    { "HlPr8e6DCnPqRjk3nuYe", "2xSRLgR4QgzYhDLjfgAM", new DateTimeOffset(new DateTime(2023, 4, 11, 13, 51, 43, 809, DateTimeKind.Unspecified).AddTicks(2828), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "B10", "fd1f540b-59dc-45ea-b68f-d5bb16b3794c" },
                    { "HtrKqcMqRxQoQfdjY05d", "2xSRLgR4QgzYhDLjfgAM", new DateTimeOffset(new DateTime(2023, 4, 11, 13, 51, 43, 809, DateTimeKind.Unspecified).AddTicks(2863), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "B6", "7364f8a7-26bc-40e4-8582-89461d84b86d" },
                    { "hWwtdT3lDA4gDttLXYAP", "48xSUCHrRIfABkLmGHxD", new DateTimeOffset(new DateTime(2023, 4, 11, 13, 51, 43, 809, DateTimeKind.Unspecified).AddTicks(3828), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "Q3", "7c34705b-e6e0-4231-bd41-280df2c159ac" },
                    { "HyLotD15xJrz4PY0X86u", "5kDhCqXf6JTAIvz61oEz", new DateTimeOffset(new DateTime(2023, 4, 11, 13, 51, 43, 809, DateTimeKind.Unspecified).AddTicks(5180), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "545", "a36e7f6d-e205-49fb-b681-3be90ceacd4a" },
                    { "I7jmrhXLDwFwHbpBfRwS", "5kDhCqXf6JTAIvz61oEz", new DateTimeOffset(new DateTime(2023, 4, 11, 13, 51, 43, 809, DateTimeKind.Unspecified).AddTicks(5963), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "M135i", "2b97d2c1-8f19-4927-a42a-205268dbc2c0" },
                    { "II2t2L1DcgLlaCDb9a7J", "5kDhCqXf6JTAIvz61oEz", new DateTimeOffset(new DateTime(2023, 4, 11, 13, 51, 43, 809, DateTimeKind.Unspecified).AddTicks(5954), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "All M-series", "c949b7b5-d6e3-4a68-99b1-d8e8eb34f163" },
                    { "IJH2X0h5l06QnHtHHtx8", "5kDhCqXf6JTAIvz61oEz", new DateTimeOffset(new DateTime(2023, 4, 11, 13, 51, 43, 809, DateTimeKind.Unspecified).AddTicks(4872), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "228", "7aacc065-7e91-43f7-a73d-2152d0b1d053" },
                    { "IjI5pF2rezVWvfLTzy1V", "48xSUCHrRIfABkLmGHxD", new DateTimeOffset(new DateTime(2023, 4, 11, 13, 51, 43, 809, DateTimeKind.Unspecified).AddTicks(3876), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "Q4 e-tron", "7fba7620-a06e-4865-9d5e-e153e6545975" },
                    { "IQ7s1z1x8NqxAjITRyQs", "5kDhCqXf6JTAIvz61oEz", new DateTimeOffset(new DateTime(2023, 4, 11, 13, 51, 43, 809, DateTimeKind.Unspecified).AddTicks(6145), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "X7", "82051f73-19c1-48b3-bbdf-5abb05db84b4" },
                    { "IYuRS6V5HDI2PjUNgnvH", "5kDhCqXf6JTAIvz61oEz", new DateTimeOffset(new DateTime(2023, 4, 11, 13, 51, 43, 809, DateTimeKind.Unspecified).AddTicks(4998), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "340", "688d31b2-2142-450d-8203-f524794cd62e" },
                    { "J13hr72ueSwf8C6Khect", "5kDhCqXf6JTAIvz61oEz", new DateTimeOffset(new DateTime(2023, 4, 11, 13, 51, 43, 809, DateTimeKind.Unspecified).AddTicks(4967), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "324", "b28e18cf-22c4-48fd-b12a-ccf3bcf3611e" },
                    { "j4UIKQ3Bgpge7mNJAYnp", "5kDhCqXf6JTAIvz61oEz", new DateTimeOffset(new DateTime(2023, 4, 11, 13, 51, 43, 809, DateTimeKind.Unspecified).AddTicks(6164), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "Z4", "85265c57-7231-4897-b1cb-b8e0a47a1972" },
                    { "J6EsJNx3sRvANKaS7z5y", "2xSRLgR4QgzYhDLjfgAM", new DateTimeOffset(new DateTime(2023, 4, 11, 13, 51, 43, 809, DateTimeKind.Unspecified).AddTicks(2857), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "B5", "d7b12d40-6c2a-485d-b597-5c2bccdc67a7" },
                    { "JDE7udluXVMWEEjdtRQg", "5kDhCqXf6JTAIvz61oEz", new DateTimeOffset(new DateTime(2023, 4, 11, 13, 51, 43, 809, DateTimeKind.Unspecified).AddTicks(4974), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "325", "f7925376-0849-4b5a-8f3f-5f524566bd47" },
                    { "jFIVLK64LYnDKVpB9JI0", "48xSUCHrRIfABkLmGHxD", new DateTimeOffset(new DateTime(2023, 4, 11, 13, 51, 43, 809, DateTimeKind.Unspecified).AddTicks(4093), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "S7 Sportback", "ff083f4f-c0e4-46a7-a426-a01f24b1523e" },
                    { "jhQxrDhQozD61WEKj3o8", "5kDhCqXf6JTAIvz61oEz", new DateTimeOffset(new DateTime(2023, 4, 11, 13, 51, 43, 809, DateTimeKind.Unspecified).AddTicks(5014), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "420", "32c680f1-dd3a-4583-ab4b-fdb94b49bb50" },
                    { "jnlmSTj99deDxhEq3IPz", "5kDhCqXf6JTAIvz61oEz", new DateTimeOffset(new DateTime(2023, 4, 11, 13, 51, 43, 809, DateTimeKind.Unspecified).AddTicks(4809), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "2 Gran Tourer", "13acba04-71ea-4225-bc85-050ae484e615" },
                    { "jo3qGo18DYMEpaQM1bIE", "470SJrcKER8YaPHSS0br", new DateTimeOffset(new DateTime(2023, 4, 11, 13, 51, 43, 809, DateTimeKind.Unspecified).AddTicks(3499), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "DBX", "ba9de8ce-db47-4658-bd86-a67862d11acd" },
                    { "jPsc5n0eP4eTQeDkeuCX", "5kDhCqXf6JTAIvz61oEz", new DateTimeOffset(new DateTime(2023, 4, 11, 13, 51, 43, 809, DateTimeKind.Unspecified).AddTicks(6009), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "M8", "a4ce058c-c968-409a-ad9a-89bd8c85575d" },
                    { "JSSoF8UroY8CzUGqNArn", "48xSUCHrRIfABkLmGHxD", new DateTimeOffset(new DateTime(2023, 4, 11, 13, 51, 43, 809, DateTimeKind.Unspecified).AddTicks(3903), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "R8", "5b864dff-7f39-4dd0-a2c6-f16d5361804e" },
                    { "k6BfeL5bCscCS1p1jsLt", "2xSRLgR4QgzYhDLjfgAM", new DateTimeOffset(new DateTime(2023, 4, 11, 13, 51, 43, 809, DateTimeKind.Unspecified).AddTicks(2925), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "C2", "31b06810-891f-435e-9b60-12fe6c604162" },
                    { "KNGUUV4K1GF0Tq4l0CMR", "5kDhCqXf6JTAIvz61oEz", new DateTimeOffset(new DateTime(2023, 4, 11, 13, 51, 43, 809, DateTimeKind.Unspecified).AddTicks(4820), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "216", "42901773-2e54-46fd-b38f-e7963c45340a" },
                    { "kSdRvgyWvLML8jtu6nXg", "2VS5yLgAuj7VmYeRVxTD", new DateTimeOffset(new DateTime(2023, 4, 11, 13, 51, 43, 809, DateTimeKind.Unspecified).AddTicks(2816), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "Stelvio", "a129f1af-a9b3-4562-a6d5-139de78be7c3" },
                    { "kSF9qPlHWpN2WuEoDhw5", "5kDhCqXf6JTAIvz61oEz", new DateTimeOffset(new DateTime(2023, 4, 11, 13, 51, 43, 809, DateTimeKind.Unspecified).AddTicks(5089), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "All 5-series", "861d8dbe-e7c6-4b91-b342-8424ebff6aea" },
                    { "ksVnqG1h2js96qv0RhFU", "2xSRLgR4QgzYhDLjfgAM", new DateTimeOffset(new DateTime(2023, 4, 11, 13, 51, 43, 809, DateTimeKind.Unspecified).AddTicks(2903), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "B7", "d9b6b60d-7029-4beb-bff4-d7a6df019e8d" },
                    { "KtFvKrQrzmTv1SAdPMYx", "48xSUCHrRIfABkLmGHxD", new DateTimeOffset(new DateTime(2023, 4, 11, 13, 51, 43, 809, DateTimeKind.Unspecified).AddTicks(4076), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "S5 Sportback", "d892f2b9-ce22-4e97-a5a6-f4a688025dd5" },
                    { "kWDYA3pCp0DrHb3FmMMu", "2VS5yLgAuj7VmYeRVxTD", new DateTimeOffset(new DateTime(2023, 4, 11, 13, 51, 43, 809, DateTimeKind.Unspecified).AddTicks(2737), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "Brera", "208f1391-1c29-4fd5-b0e1-f6ca28af7820" },
                    { "l4a1l4pM4FvH2L5ggG34", "5kDhCqXf6JTAIvz61oEz", new DateTimeOffset(new DateTime(2023, 4, 11, 13, 51, 43, 809, DateTimeKind.Unspecified).AddTicks(5260), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "645", "a597d101-c020-4f18-8937-6ff72b8048c7" },
                    { "lATJaqSXcmorvGUu4zaX", "2SBENlnqR76XRNAjbAs3", new DateTimeOffset(new DateTime(2023, 4, 11, 13, 51, 43, 809, DateTimeKind.Unspecified).AddTicks(2583), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "505", "dd958210-ca3b-421f-ae9b-0d4744a7a1a5" },
                    { "LHcxSwzYltu3aUTdcjB9", "5kDhCqXf6JTAIvz61oEz", new DateTimeOffset(new DateTime(2023, 4, 11, 13, 51, 43, 809, DateTimeKind.Unspecified).AddTicks(4878), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "2800", "ee8829bb-a971-4982-b7b8-2fd2d9f68dcd" },
                    { "ljxuyne3mLs07ArpyVm7", "2VS5yLgAuj7VmYeRVxTD", new DateTimeOffset(new DateTime(2023, 4, 11, 13, 51, 43, 809, DateTimeKind.Unspecified).AddTicks(2681), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "166", "561ef337-c8b6-4303-85ee-300636b3869d" },
                    { "Loassx4UBfgDvA0FelE4", "5kDhCqXf6JTAIvz61oEz", new DateTimeOffset(new DateTime(2023, 4, 11, 13, 51, 43, 809, DateTimeKind.Unspecified).AddTicks(5371), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "850", "beee5727-7593-4c72-8b85-4df1301cb453" },
                    { "LoXk80vBEhal7e5DuWUM", "5kDhCqXf6JTAIvz61oEz", new DateTimeOffset(new DateTime(2023, 4, 11, 13, 51, 43, 809, DateTimeKind.Unspecified).AddTicks(5277), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "725", "8aec5c2d-93b0-4033-af23-1692f528d683" },
                    { "ltqhJMyQ24KTrhSfWu7f", "5aFWwvagmpfBWQlHxU5M", new DateTimeOffset(new DateTime(2023, 4, 11, 13, 51, 43, 809, DateTimeKind.Unspecified).AddTicks(4718), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "Princess", "9828d5e5-4cfd-42cd-818e-74336e9de219" },
                    { "LWu8qDJ3MIx8d2fcfCYJ", "2xSRLgR4QgzYhDLjfgAM", new DateTimeOffset(new DateTime(2023, 4, 11, 13, 51, 43, 809, DateTimeKind.Unspecified).AddTicks(2949), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "Roadster", "b7333f1f-77f1-422e-b25e-afb9dee484f6" },
                    { "mBwTrdcmsbo47aqeHL0T", "5kDhCqXf6JTAIvz61oEz", new DateTimeOffset(new DateTime(2023, 4, 11, 13, 51, 43, 809, DateTimeKind.Unspecified).AddTicks(5095), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "518", "98bac21d-5973-4816-9b88-915da1958a6e" },
                    { "MgCMLmE4mHKmXVXDcTqa", "2VS5yLgAuj7VmYeRVxTD", new DateTimeOffset(new DateTime(2023, 4, 11, 13, 51, 43, 809, DateTimeKind.Unspecified).AddTicks(2686), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "33", "ed87b0cd-43b9-4248-af29-564397fca69f" },
                    { "MkKrm5LjR5LpuyMx1xlf", "2VS5yLgAuj7VmYeRVxTD", new DateTimeOffset(new DateTime(2023, 4, 11, 13, 51, 43, 809, DateTimeKind.Unspecified).AddTicks(2595), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "145", "9073fb59-bf31-4794-8538-86c43ffc35d6" },
                    { "MmQ0YmJYol90gFA42efA", "5kDhCqXf6JTAIvz61oEz", new DateTimeOffset(new DateTime(2023, 4, 11, 13, 51, 43, 809, DateTimeKind.Unspecified).AddTicks(5446), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "i7", "54a0f8ad-e35a-487c-846e-dafdf65f443c" },
                    { "MS3Je2qDvHl6Etf5dBek", "5kDhCqXf6JTAIvz61oEz", new DateTimeOffset(new DateTime(2023, 4, 11, 13, 51, 43, 809, DateTimeKind.Unspecified).AddTicks(5169), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "535", "7e183a19-18be-456b-af95-dc4baed00d36" },
                    { "mTjeE13Cn9XWcpwwfR2P", "48xSUCHrRIfABkLmGHxD", new DateTimeOffset(new DateTime(2023, 4, 11, 13, 51, 43, 809, DateTimeKind.Unspecified).AddTicks(4595), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "SQ8", "6b92dcac-2ac1-4089-a558-9a0f45fdce80" },
                    { "N2lWuC4aj5y7pbFsHuIP", "5aFWwvagmpfBWQlHxU5M", new DateTimeOffset(new DateTime(2023, 4, 11, 13, 51, 43, 809, DateTimeKind.Unspecified).AddTicks(4712), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "Montego", "ee7d666e-911c-47a1-9c24-33411150fd33" },
                    { "n4jhE8TC6PVRvobedTHa", "470SJrcKER8YaPHSS0br", new DateTimeOffset(new DateTime(2023, 4, 11, 13, 51, 43, 809, DateTimeKind.Unspecified).AddTicks(3599), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "Vanquish", "cdbc62e6-6024-44dc-8fe8-cd00b8f0e710" },
                    { "n69WpeY8UDYfA7uKujPd", "5kDhCqXf6JTAIvz61oEz", new DateTimeOffset(new DateTime(2023, 4, 11, 13, 51, 43, 809, DateTimeKind.Unspecified).AddTicks(6086), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "X4", "1b8b8722-4b9a-4668-80fe-ea3beb09d010" },
                    { "nJWNLK1Bwhe3gSjywyKx", "470SJrcKER8YaPHSS0br", new DateTimeOffset(new DateTime(2023, 4, 11, 13, 51, 43, 809, DateTimeKind.Unspecified).AddTicks(3535), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "V12 Vantage", "514fb663-93ef-486e-9871-0b782deec5df" },
                    { "Nlx90WY9mPGcgeLYbmVf", "2xSRLgR4QgzYhDLjfgAM", new DateTimeOffset(new DateTime(2023, 4, 11, 13, 51, 43, 809, DateTimeKind.Unspecified).AddTicks(2932), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "D3", "9df3fad2-d065-4790-bf95-ae9ba7b3e164" },
                    { "nrp7CjqWvohe71eru0Tp", "48xSUCHrRIfABkLmGHxD", new DateTimeOffset(new DateTime(2023, 4, 11, 13, 51, 43, 809, DateTimeKind.Unspecified).AddTicks(3709), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "A4 Avant", "81622582-abf4-48cf-a04a-c51dda3bdfd8" },
                    { "NtS2yswl6E7B6gjPSdhp", "5aFWwvagmpfBWQlHxU5M", new DateTimeOffset(new DateTime(2023, 4, 11, 13, 51, 43, 809, DateTimeKind.Unspecified).AddTicks(4645), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "Maestro", "51a4017f-264a-4a94-8028-2a6b6b232a15" },
                    { "NuvBmKyRghdHjX4TLILz", "48xSUCHrRIfABkLmGHxD", new DateTimeOffset(new DateTime(2023, 4, 11, 13, 51, 43, 809, DateTimeKind.Unspecified).AddTicks(3698), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "A4", "df2736a1-a295-4788-9609-e473a76c7ab5" },
                    { "NVslv4nJlKq7Nwd5yYMX", "5kDhCqXf6JTAIvz61oEz", new DateTimeOffset(new DateTime(2023, 4, 11, 13, 51, 43, 809, DateTimeKind.Unspecified).AddTicks(4741), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "118", "a9e423f4-b1d7-4f73-9cee-f3ac99d7cced" },
                    { "ofqvccesMEhVEdXznb1A", "2VS5yLgAuj7VmYeRVxTD", new DateTimeOffset(new DateTime(2023, 4, 11, 13, 51, 43, 809, DateTimeKind.Unspecified).AddTicks(2600), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "146", "37654595-a426-465f-ab8c-de49b428daea" },
                    { "oJDBgMuEJ6XNbq0LQMC1", "2VS5yLgAuj7VmYeRVxTD", new DateTimeOffset(new DateTime(2023, 4, 11, 13, 51, 43, 809, DateTimeKind.Unspecified).AddTicks(2646), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "155", "567108a1-994b-4d15-a563-a83bfe9bd71c" },
                    { "ol94SQnLksDcA3LvlBan", "48xSUCHrRIfABkLmGHxD", new DateTimeOffset(new DateTime(2023, 4, 11, 13, 51, 43, 809, DateTimeKind.Unspecified).AddTicks(4009), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "S2", "f6e28fe2-6896-445f-b185-4ba974f74e69" },
                    { "oLrS1FodKs8VWe3hKtyp", "48xSUCHrRIfABkLmGHxD", new DateTimeOffset(new DateTime(2023, 4, 11, 13, 51, 43, 809, DateTimeKind.Unspecified).AddTicks(4626), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "TTS", "66509e7d-27a2-46ef-afb9-cc2fa91ddd7a" },
                    { "owNDA9jTb4sUTEMIANGg", "2xSRLgR4QgzYhDLjfgAM", new DateTimeOffset(new DateTime(2023, 4, 11, 13, 51, 43, 809, DateTimeKind.Unspecified).AddTicks(2852), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "B4", "d08dcb5b-8df9-4258-af52-4d57cea0f3bc" },
                    { "p3KQpLPKjHydW70XBuNh", "48xSUCHrRIfABkLmGHxD", new DateTimeOffset(new DateTime(2023, 4, 11, 13, 51, 43, 809, DateTimeKind.Unspecified).AddTicks(3789), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "A7", "d3646ca1-0c1e-424f-97a5-c9fd381ee1da" },
                    { "PctNmLyv1CuKPvecDD96", "5kDhCqXf6JTAIvz61oEz", new DateTimeOffset(new DateTime(2023, 4, 11, 13, 51, 43, 809, DateTimeKind.Unspecified).AddTicks(6050), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "X5 M", "6b8bf585-6f1b-44cc-8298-96e520a74ccc" },
                    { "pfJDDu58RfaneBSPEARu", "5kDhCqXf6JTAIvz61oEz", new DateTimeOffset(new DateTime(2023, 4, 11, 13, 51, 43, 809, DateTimeKind.Unspecified).AddTicks(5365), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "840", "f58cfc21-a0a5-4397-a2de-63253c78765f" },
                    { "pIvEwHW0TJzjqh3eh1oA", "48xSUCHrRIfABkLmGHxD", new DateTimeOffset(new DateTime(2023, 4, 11, 13, 51, 43, 809, DateTimeKind.Unspecified).AddTicks(3916), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "RS3 Sportback", "aa33b710-ef10-47b2-acd3-3c3bec7d58c1" },
                    { "pNHP4rnNEafLTSV26pMT", "5aFWwvagmpfBWQlHxU5M", new DateTimeOffset(new DateTime(2023, 4, 11, 13, 51, 43, 809, DateTimeKind.Unspecified).AddTicks(4693), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "Metro", "9519470e-bcff-48cc-bd45-b17ba49dd5e6" },
                    { "PR6d8JouFpJK6ADVLcjl", "470SJrcKER8YaPHSS0br", new DateTimeOffset(new DateTime(2023, 4, 11, 13, 51, 43, 809, DateTimeKind.Unspecified).AddTicks(3590), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "V8 Vantage", "28e39903-628a-446a-891d-0bf3e6428009" },
                    { "pSnybXwtzrE1qUHesIho", "470SJrcKER8YaPHSS0br", new DateTimeOffset(new DateTime(2023, 4, 11, 13, 51, 43, 809, DateTimeKind.Unspecified).AddTicks(3526), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "Rapide", "ad7bfd3c-cf40-4ccf-b6f7-62eaa89f9a40" },
                    { "ptpYDtt2b3I0HSnLhL0b", "470SJrcKER8YaPHSS0br", new DateTimeOffset(new DateTime(2023, 4, 11, 13, 51, 43, 809, DateTimeKind.Unspecified).AddTicks(3517), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "Db9", "6b857f43-9e52-4e04-bedf-62b599e349cc" },
                    { "PTvgjEEyQxH1h1PS7z8Y", "5kDhCqXf6JTAIvz61oEz", new DateTimeOffset(new DateTime(2023, 4, 11, 13, 51, 43, 809, DateTimeKind.Unspecified).AddTicks(5978), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "M240i", "67dab1f9-f212-4996-a303-8edaaa2b4058" },
                    { "PxTqCIcaYSGzJRuFMJWq", "5kDhCqXf6JTAIvz61oEz", new DateTimeOffset(new DateTime(2023, 4, 11, 13, 51, 43, 809, DateTimeKind.Unspecified).AddTicks(5316), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "728", "6c070dc6-6ebe-4c6f-a4ce-7fe4597af061" },
                    { "qb6GGSLcjR2t9Fla49e2", "2FEzeyYHYe3zlhjMeaEF", new DateTimeOffset(new DateTime(2023, 4, 11, 13, 51, 43, 809, DateTimeKind.Unspecified).AddTicks(2481), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "Rl", "98baaee3-8878-4742-9c0a-9ad2d3711167" },
                    { "QLDSHkxnUu2LUaSXLycu", "5kDhCqXf6JTAIvz61oEz", new DateTimeOffset(new DateTime(2023, 4, 11, 13, 51, 43, 809, DateTimeKind.Unspecified).AddTicks(5941), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "iX3", "4788d0f0-0644-4cec-952e-797a73469d6f" },
                    { "QnhWH1vEE5wL6JVabAeg", "48xSUCHrRIfABkLmGHxD", new DateTimeOffset(new DateTime(2023, 4, 11, 13, 51, 43, 809, DateTimeKind.Unspecified).AddTicks(3726), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "A6", "fa998eb2-5895-49fc-863e-76adf45c254c" },
                    { "qP6cdyNrC8hMJSCslMjy", "2VS5yLgAuj7VmYeRVxTD", new DateTimeOffset(new DateTime(2023, 4, 11, 13, 51, 43, 809, DateTimeKind.Unspecified).AddTicks(2759), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "GT", "ee155258-f488-4dda-a697-409228986372" },
                    { "qr6L2rz6UFIKscLomGK7", "2FEzeyYHYe3zlhjMeaEF", new DateTimeOffset(new DateTime(2023, 4, 11, 13, 51, 43, 809, DateTimeKind.Unspecified).AddTicks(2470), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "NSX", "f83f43e0-f8ae-483c-8899-242fb19872d4" },
                    { "QVhQF8c3YbGgyNmEtNnD", "5kDhCqXf6JTAIvz61oEz", new DateTimeOffset(new DateTime(2023, 4, 11, 13, 51, 43, 809, DateTimeKind.Unspecified).AddTicks(6151), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "All Z-series", "2481ac9a-a41d-4a02-8b9c-26f05db408b9" },
                    { "QYf3zK8EDfc7g3p42Sav", "48xSUCHrRIfABkLmGHxD", new DateTimeOffset(new DateTime(2023, 4, 11, 13, 51, 43, 809, DateTimeKind.Unspecified).AddTicks(3704), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "A4 Allroad", "fba5f74e-a849-443b-afa8-060c2916a878" },
                    { "Qz0wHVEN0xxgpMH38jrU", "5kDhCqXf6JTAIvz61oEz", new DateTimeOffset(new DateTime(2023, 4, 11, 13, 51, 43, 809, DateTimeKind.Unspecified).AddTicks(4901), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "316", "773c3d7b-6705-4c8a-9e8f-9b92e85f17f1" },
                    { "qzECSnkXebjdz8V18Mxa", "5kDhCqXf6JTAIvz61oEz", new DateTimeOffset(new DateTime(2023, 4, 11, 13, 51, 43, 809, DateTimeKind.Unspecified).AddTicks(6098), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "X6", "640cc0a6-0cc8-4211-ba39-994a5d0e82ea" },
                    { "r1MqrJvXbXpVfI02a2Fc", "48xSUCHrRIfABkLmGHxD", new DateTimeOffset(new DateTime(2023, 4, 11, 13, 51, 43, 809, DateTimeKind.Unspecified).AddTicks(3997), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "RSQ8", "137dea45-9281-46e1-b886-0d919b65342b" },
                    { "R88KB1eXYGKgLDuEKtnD", "2FEzeyYHYe3zlhjMeaEF", new DateTimeOffset(new DateTime(2023, 4, 11, 13, 51, 43, 809, DateTimeKind.Unspecified).AddTicks(2453), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "Integra", "b47de8c6-ebd5-41f3-9778-380b158bb342" },
                    { "rht2GRAXVuTkl43Nf8Xa", "5kDhCqXf6JTAIvz61oEz", new DateTimeOffset(new DateTime(2023, 4, 11, 13, 51, 43, 809, DateTimeKind.Unspecified).AddTicks(5971), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "M2", "609135ae-de0e-468c-9a61-6007af7b46e5" },
                    { "RmnUBN2M9d6cJjpFjAfw", "5kDhCqXf6JTAIvz61oEz", new DateTimeOffset(new DateTime(2023, 4, 11, 13, 51, 43, 809, DateTimeKind.Unspecified).AddTicks(4991), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "335", "a885e99e-1c39-4070-b9a7-0d7bb6283abc" },
                    { "RqPjBJqnB5cW4fjfbdvH", "48xSUCHrRIfABkLmGHxD", new DateTimeOffset(new DateTime(2023, 4, 11, 13, 51, 43, 809, DateTimeKind.Unspecified).AddTicks(3892), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "Q7", "189d9f69-0e98-4826-88c0-80f1d9646685" },
                    { "rqtT8Mbmz2k47pNf8955", "5kDhCqXf6JTAIvz61oEz", new DateTimeOffset(new DateTime(2023, 4, 11, 13, 51, 43, 809, DateTimeKind.Unspecified).AddTicks(5346), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "750", "2bc1ed02-2681-42d9-87da-16cc9bfee7c7" },
                    { "S80IyERUVlovNTEU8vxd", "5kDhCqXf6JTAIvz61oEz", new DateTimeOffset(new DateTime(2023, 4, 11, 13, 51, 43, 809, DateTimeKind.Unspecified).AddTicks(5163), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "530", "6051065e-40c0-4219-b76a-3dbd44ca2a91" },
                    { "SCrSQGsb83jKp5DnHs6J", "5kDhCqXf6JTAIvz61oEz", new DateTimeOffset(new DateTime(2023, 4, 11, 13, 51, 43, 809, DateTimeKind.Unspecified).AddTicks(4786), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "123", "a3930025-e820-4985-8b2e-c063c0807837" },
                    { "SG24ELP5rdfPLsdYw9sy", "2FEzeyYHYe3zlhjMeaEF", new DateTimeOffset(new DateTime(2023, 4, 11, 13, 51, 43, 809, DateTimeKind.Unspecified).AddTicks(2566), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "Tsx", "8b45867c-f044-466b-836a-c69d94b4f605" },
                    { "SGtErd3HTXBK1JSC26kM", "5kDhCqXf6JTAIvz61oEz", new DateTimeOffset(new DateTime(2023, 4, 11, 13, 51, 43, 809, DateTimeKind.Unspecified).AddTicks(5191), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "All 6-series", "71667e41-9ca3-41c5-842c-a99a5eeb69b7" },
                    { "SoJP6SlNQSRaRtnJSKeu", "5kDhCqXf6JTAIvz61oEz", new DateTimeOffset(new DateTime(2023, 4, 11, 13, 51, 43, 809, DateTimeKind.Unspecified).AddTicks(5433), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "i3", "1b2cff29-733d-4beb-9f9f-0cbbdcd5e848" },
                    { "SrgI2I4z5EHzUdRjnR1H", "2VS5yLgAuj7VmYeRVxTD", new DateTimeOffset(new DateTime(2023, 4, 11, 13, 51, 43, 809, DateTimeKind.Unspecified).AddTicks(2810), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "Spider", "bf8c04e8-5af2-45bc-a56b-9a8b44ad33b3" },
                    { "SwfGBIhAYzJlN8DWpbGn", "5kDhCqXf6JTAIvz61oEz", new DateTimeOffset(new DateTime(2023, 4, 11, 13, 51, 43, 809, DateTimeKind.Unspecified).AddTicks(5427), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "Gran Coupe", "fc099971-2740-4cbc-a0f5-7f8eb839b82c" },
                    { "sypMP0CJWnSCgu3k4Brh", "5kDhCqXf6JTAIvz61oEz", new DateTimeOffset(new DateTime(2023, 4, 11, 13, 51, 43, 809, DateTimeKind.Unspecified).AddTicks(6158), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "Z3", "70b8eb0e-2fc0-445c-ab83-c768a56dfc6a" },
                    { "szcUoq7YRXsR27qGl8gb", "48xSUCHrRIfABkLmGHxD", new DateTimeOffset(new DateTime(2023, 4, 11, 13, 51, 43, 809, DateTimeKind.Unspecified).AddTicks(4052), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "S3 Sportback", "cd76eae3-80ad-4f76-ae9a-b88781ae6f16" },
                    { "T4gsjJp10b62tBWHt01P", "5kDhCqXf6JTAIvz61oEz", new DateTimeOffset(new DateTime(2023, 4, 11, 13, 51, 43, 809, DateTimeKind.Unspecified).AddTicks(4797), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "128", "30633cb5-6155-407b-8494-8b1b96c399f2" },
                    { "T8pHkc1WoNyyDGa92Flb", "48xSUCHrRIfABkLmGHxD", new DateTimeOffset(new DateTime(2023, 4, 11, 13, 51, 43, 809, DateTimeKind.Unspecified).AddTicks(3927), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "RS5", "1beb0cd1-21af-43d7-844d-111046670c18" },
                    { "toHqRle33WzAEgzMA9db", "3qGrKAnyJ2rmHlevXb8c", new DateTimeOffset(new DateTime(2023, 4, 11, 13, 51, 43, 809, DateTimeKind.Unspecified).AddTicks(3469), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "All", "4ed5299e-d5aa-467d-9074-f02fe3843a2b" },
                    { "tPHb5EYKQW6pBLpf3P1M", "5kDhCqXf6JTAIvz61oEz", new DateTimeOffset(new DateTime(2023, 4, 11, 13, 51, 43, 809, DateTimeKind.Unspecified).AddTicks(5106), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "523", "ae82b1ae-59ca-450a-b074-5e373e418dd5" },
                    { "TQ4z4yWpzuUkbRn7XeT5", "48xSUCHrRIfABkLmGHxD", new DateTimeOffset(new DateTime(2023, 4, 11, 13, 51, 43, 809, DateTimeKind.Unspecified).AddTicks(4087), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "S7", "c1af21c6-f922-4841-b32f-92436a49e7e8" },
                    { "Trqx9IejpCWMQJC4WGNQ", "48xSUCHrRIfABkLmGHxD", new DateTimeOffset(new DateTime(2023, 4, 11, 13, 51, 43, 809, DateTimeKind.Unspecified).AddTicks(3882), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "Q5", "a2e0547c-1099-4be5-9173-b735b9a58175" },
                    { "tsuYP3jaHSn39yI93CtS", "5kDhCqXf6JTAIvz61oEz", new DateTimeOffset(new DateTime(2023, 4, 11, 13, 51, 43, 809, DateTimeKind.Unspecified).AddTicks(5335), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "740", "ea0e9ef1-d68b-415a-bda2-19de0c638e4b" },
                    { "ubWdUYsJagYJNYwNzNxh", "48xSUCHrRIfABkLmGHxD", new DateTimeOffset(new DateTime(2023, 4, 11, 13, 51, 43, 809, DateTimeKind.Unspecified).AddTicks(3629), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "90", "7731cef0-ac84-4d3f-b2af-eae25059502b" },
                    { "ubzHJCCbc9GagVdxDWME", "2VS5yLgAuj7VmYeRVxTD", new DateTimeOffset(new DateTime(2023, 4, 11, 13, 51, 43, 809, DateTimeKind.Unspecified).AddTicks(2822), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "Tonale", "d7fb8f3d-9555-470f-8003-0569c56bca85" },
                    { "Ugw7xXqRjWwm1luoRt1I", "5kDhCqXf6JTAIvz61oEz", new DateTimeOffset(new DateTime(2023, 4, 11, 13, 51, 43, 809, DateTimeKind.Unspecified).AddTicks(5243), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "630", "55a35dc4-0741-401b-ba67-90f1fde05f6b" },
                    { "Ulh5YdlTAGLxRppTt18c", "5kDhCqXf6JTAIvz61oEz", new DateTimeOffset(new DateTime(2023, 4, 11, 13, 51, 43, 809, DateTimeKind.Unspecified).AddTicks(5144), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "524", "c6a9ff4e-077c-48e8-b77c-44ab0018cfdd" },
                    { "un31qV3n19B0492jC9qJ", "2xSRLgR4QgzYhDLjfgAM", new DateTimeOffset(new DateTime(2023, 4, 11, 13, 51, 43, 809, DateTimeKind.Unspecified).AddTicks(2943), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "D5", "791868c5-d779-4c4c-a0b0-0ea64812c0db" },
                    { "UxUW49lnda09TyqkjDd1", "5kDhCqXf6JTAIvz61oEz", new DateTimeOffset(new DateTime(2023, 4, 11, 13, 51, 43, 809, DateTimeKind.Unspecified).AddTicks(4834), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "220", "d1208dce-dca0-49bb-868c-5c46ff0ee551" },
                    { "vaRAVPYon4uglCSGLG34", "48xSUCHrRIfABkLmGHxD", new DateTimeOffset(new DateTime(2023, 4, 11, 13, 51, 43, 809, DateTimeKind.Unspecified).AddTicks(3909), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "RS3", "4b833b2e-6ccb-4e0d-82ff-cf92892b4f8e" },
                    { "VG1xBcs30rrL9nfABSC7", "5kDhCqXf6JTAIvz61oEz", new DateTimeOffset(new DateTime(2023, 4, 11, 13, 51, 43, 809, DateTimeKind.Unspecified).AddTicks(5003), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "All 4-series", "cd5e40a4-265e-4005-9d31-1df280267789" },
                    { "VHwfuUsfMfv83YQnvdjk", "2SBENlnqR76XRNAjbAs3", new DateTimeOffset(new DateTime(2023, 4, 11, 13, 51, 43, 809, DateTimeKind.Unspecified).AddTicks(2577), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "400", "b92178ef-8ebd-4e44-8582-597ad4cc5375" },
                    { "vjRwuuBbDqQjKCFzSRfk", "2xSRLgR4QgzYhDLjfgAM", new DateTimeOffset(new DateTime(2023, 4, 11, 13, 51, 43, 809, DateTimeKind.Unspecified).AddTicks(2839), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "B12", "8423fa09-40cf-4575-825b-b4fbb70ab5ff" },
                    { "VqYoB9qYwLrPRf304XtL", "48xSUCHrRIfABkLmGHxD", new DateTimeOffset(new DateTime(2023, 4, 11, 13, 51, 43, 809, DateTimeKind.Unspecified).AddTicks(3817), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "E-tron Sportback", "4fad7d53-e49b-4f5b-88ca-f107e3146d13" },
                    { "vueyJM1zlvrpLusQbDT6", "5kDhCqXf6JTAIvz61oEz", new DateTimeOffset(new DateTime(2023, 4, 11, 13, 51, 43, 809, DateTimeKind.Unspecified).AddTicks(5186), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "550", "43289e07-edee-4bed-822c-13f4ccc317e2" },
                    { "VVxChkQzDpceKkTUF5Jx", "5kDhCqXf6JTAIvz61oEz", new DateTimeOffset(new DateTime(2023, 4, 11, 13, 51, 43, 809, DateTimeKind.Unspecified).AddTicks(5101), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "520", "38a07b04-b334-4ce0-b7cf-529fd57860ac" },
                    { "W75KIuYCHTay8dgsP3S4", "48xSUCHrRIfABkLmGHxD", new DateTimeOffset(new DateTime(2023, 4, 11, 13, 51, 43, 809, DateTimeKind.Unspecified).AddTicks(4014), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "S3", "574223ee-a8be-481b-9f1b-c2662a3dbd17" },
                    { "wfygyLxazSlYEqwdzwmB", "2VS5yLgAuj7VmYeRVxTD", new DateTimeOffset(new DateTime(2023, 4, 11, 13, 51, 43, 809, DateTimeKind.Unspecified).AddTicks(2754), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "Giulietta", "032c5510-7da8-41ca-9375-457b007956cb" },
                    { "wh3wBeoA8FuJSUUtHol6", "2FEzeyYHYe3zlhjMeaEF", new DateTimeOffset(new DateTime(2023, 4, 11, 13, 51, 43, 809, DateTimeKind.Unspecified).AddTicks(2487), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "Rsx", "f89add41-b7cb-4feb-ba85-520a72aca888" },
                    { "WKLdD75F7mV9bwbaVEYX", "5kDhCqXf6JTAIvz61oEz", new DateTimeOffset(new DateTime(2023, 4, 11, 13, 51, 43, 809, DateTimeKind.Unspecified).AddTicks(5341), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "745", "dcb2a32f-8af7-46a9-81cf-73d4cab275bc" },
                    { "WMFoEJHuhFYcVr5FfKys", "5aFWwvagmpfBWQlHxU5M", new DateTimeOffset(new DateTime(2023, 4, 11, 13, 51, 43, 809, DateTimeKind.Unspecified).AddTicks(4700), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "Mg", "dc5b02ac-aac6-48f8-80c0-6337fe306d3b" },
                    { "WRfl8qT2C1njxXYPCw2w", "5kDhCqXf6JTAIvz61oEz", new DateTimeOffset(new DateTime(2023, 4, 11, 13, 51, 43, 809, DateTimeKind.Unspecified).AddTicks(5083), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "5 Gran Turismo", "ddf51e00-0f1d-460b-b5ac-dcf2a5e0a5b3" },
                    { "X7E8hMs1JY0gRVBUwjjG", "5aFWwvagmpfBWQlHxU5M", new DateTimeOffset(new DateTime(2023, 4, 11, 13, 51, 43, 809, DateTimeKind.Unspecified).AddTicks(4633), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "Allegro", "a438c0a5-10f0-4d30-89a8-4738f25f8049" },
                    { "XBzaEB6SYvYAjj1PT94N", "5kDhCqXf6JTAIvz61oEz", new DateTimeOffset(new DateTime(2023, 4, 11, 13, 51, 43, 809, DateTimeKind.Unspecified).AddTicks(5157), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "528", "85a5c63b-1ea0-4a93-bd07-b5ebe905f217" },
                    { "Xc4Shlm4eXU8rHCXdfg3", "2FEzeyYHYe3zlhjMeaEF", new DateTimeOffset(new DateTime(2023, 4, 11, 13, 51, 43, 809, DateTimeKind.Unspecified).AddTicks(2559), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "Tl", "ab826f13-b8e1-4131-bf57-d50475fdc583" },
                    { "XhfAtzcrGQwCWtCwXbFg", "5kDhCqXf6JTAIvz61oEz", new DateTimeOffset(new DateTime(2023, 4, 11, 13, 51, 43, 809, DateTimeKind.Unspecified).AddTicks(4828), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "218", "64df4cfb-1336-4284-ab94-c4be799ab2fe" },
                    { "XkkY10wcSo22RpDJgMy5", "5kDhCqXf6JTAIvz61oEz", new DateTimeOffset(new DateTime(2023, 4, 11, 13, 51, 43, 809, DateTimeKind.Unspecified).AddTicks(4895), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "315", "54081bb4-9e5b-4773-8820-51c5cbcc1bd4" },
                    { "xldwM5jf7nTlfYmNk3b1", "48xSUCHrRIfABkLmGHxD", new DateTimeOffset(new DateTime(2023, 4, 11, 13, 51, 43, 809, DateTimeKind.Unspecified).AddTicks(4607), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "TT", "9de14919-dcfa-4fe3-b7ee-1ad96ed0afa7" },
                    { "Xtu8azFM2ohtKghKzbn6", "48xSUCHrRIfABkLmGHxD", new DateTimeOffset(new DateTime(2023, 4, 11, 13, 51, 43, 809, DateTimeKind.Unspecified).AddTicks(3977), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "RS7", "275da6fd-0210-45ff-b933-8bf036312fe2" },
                    { "Xwm7I73v6qmnyP8p7mD6", "5kDhCqXf6JTAIvz61oEz", new DateTimeOffset(new DateTime(2023, 4, 11, 13, 51, 43, 809, DateTimeKind.Unspecified).AddTicks(4908), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "318", "6e733b75-238c-4f7c-984b-bd193b525aad" },
                    { "YdQxDu8CBkBo0hW1Xk7w", "5kDhCqXf6JTAIvz61oEz", new DateTimeOffset(new DateTime(2023, 4, 11, 13, 51, 43, 809, DateTimeKind.Unspecified).AddTicks(5451), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "i8", "f5f632a7-897c-4892-afcd-0cd330dff59c" },
                    { "YgkYBsYJXyFMqgvKpD5J", "5kDhCqXf6JTAIvz61oEz", new DateTimeOffset(new DateTime(2023, 4, 11, 13, 51, 43, 809, DateTimeKind.Unspecified).AddTicks(5229), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "620d", "b7afd7ac-a1af-44f8-8f4f-b82192bfe2de" },
                    { "YPc8pATPykGChLv7qwY1", "06MxFkB3ArFfVraVWN1u", new DateTimeOffset(new DateTime(2023, 4, 11, 13, 51, 43, 809, DateTimeKind.Unspecified).AddTicks(2433), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "All", "6590227a-6ede-4e01-860e-0f580474b3cf" },
                    { "YypT4sKmX2QPloFc1hAX", "5kDhCqXf6JTAIvz61oEz", new DateTimeOffset(new DateTime(2023, 4, 11, 13, 51, 43, 809, DateTimeKind.Unspecified).AddTicks(4889), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "All 3-series", "c4730f95-b01f-49e4-abee-5787dc73ddbb" },
                    { "z2IJPRlcBkBBm5WsmS7x", "5aFWwvagmpfBWQlHxU5M", new DateTimeOffset(new DateTime(2023, 4, 11, 13, 51, 43, 809, DateTimeKind.Unspecified).AddTicks(4639), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "Ambassador", "a56c2ce4-a559-4179-9207-318152ec5802" },
                    { "z6BBn2LYwMbYXMrylMRu", "5kDhCqXf6JTAIvz61oEz", new DateTimeOffset(new DateTime(2023, 4, 11, 13, 51, 43, 809, DateTimeKind.Unspecified).AddTicks(5078), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "440i", "a60cee0c-40d6-4142-ba8a-29d9bce71887" },
                    { "z80e1MYVpVj3BUJverQ1", "2VS5yLgAuj7VmYeRVxTD", new DateTimeOffset(new DateTime(2023, 4, 11, 13, 51, 43, 809, DateTimeKind.Unspecified).AddTicks(2676), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "164", "e4d91447-a8b9-4145-b020-cb13aff4ab94" },
                    { "zbKqejmflR4be7U0Wm8R", "2xSRLgR4QgzYhDLjfgAM", new DateTimeOffset(new DateTime(2023, 4, 11, 13, 51, 43, 809, DateTimeKind.Unspecified).AddTicks(2919), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "C1", "9d172d16-25d3-4903-a064-c0376ba423b9" },
                    { "zlGWgcEppC8ry7eCvDot", "5kDhCqXf6JTAIvz61oEz", new DateTimeOffset(new DateTime(2023, 4, 11, 13, 51, 43, 809, DateTimeKind.Unspecified).AddTicks(4723), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "All 1-series", "9c1b06d2-2a42-4806-82de-a5e41a8381f2" },
                    { "zR5qcJqVbDQD7wTzbnws", "5kDhCqXf6JTAIvz61oEz", new DateTimeOffset(new DateTime(2023, 4, 11, 13, 51, 43, 809, DateTimeKind.Unspecified).AddTicks(5059), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "430", "f08e6677-0703-4139-9dfe-8caec5846e99" }
                });

            migrationBuilder.UpdateData(
                schema: "Troshka",
                table: "Regions",
                keyColumn: "Id",
                keyValue: "04PuHiqcRv9DcREApg5u",
                columns: new[] { "DateCreated", "TrackId" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 4, 11, 13, 51, 43, 809, DateTimeKind.Unspecified).AddTicks(6790), new TimeSpan(0, 0, 0, 0, 0)), "199c61ec-9790-42cd-9243-f6fbd6665444" });

            migrationBuilder.UpdateData(
                schema: "Troshka",
                table: "Regions",
                keyColumn: "Id",
                keyValue: "0MQA2If8a5Z4HRefov5m",
                columns: new[] { "DateCreated", "TrackId" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 4, 11, 13, 51, 43, 809, DateTimeKind.Unspecified).AddTicks(6651), new TimeSpan(0, 0, 0, 0, 0)), "bb0ff8ec-87b7-4366-a8a9-7bec597f1354" });

            migrationBuilder.UpdateData(
                schema: "Troshka",
                table: "Regions",
                keyColumn: "Id",
                keyValue: "3Lvd5SaVBSvRZqXMpqgg",
                columns: new[] { "DateCreated", "TrackId" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 4, 11, 13, 51, 43, 809, DateTimeKind.Unspecified).AddTicks(6639), new TimeSpan(0, 0, 0, 0, 0)), "7202a0db-378f-4e91-8fb1-fc85fc6e5c11" });

            migrationBuilder.UpdateData(
                schema: "Troshka",
                table: "Regions",
                keyColumn: "Id",
                keyValue: "4zMLDb0jRA6DOWg2PGAu",
                columns: new[] { "DateCreated", "TrackId" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 4, 11, 13, 51, 43, 809, DateTimeKind.Unspecified).AddTicks(6825), new TimeSpan(0, 0, 0, 0, 0)), "03af657d-05d6-491f-8882-4833e1cb5679" });

            migrationBuilder.UpdateData(
                schema: "Troshka",
                table: "Regions",
                keyColumn: "Id",
                keyValue: "54yDT5opPXBpYNO2h6Xk",
                columns: new[] { "DateCreated", "TrackId" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 4, 11, 13, 51, 43, 809, DateTimeKind.Unspecified).AddTicks(6633), new TimeSpan(0, 0, 0, 0, 0)), "df87fc3a-09a7-4ea2-9ef3-cc28b13a3a5e" });

            migrationBuilder.UpdateData(
                schema: "Troshka",
                table: "Regions",
                keyColumn: "Id",
                keyValue: "8uqXyyo70K5SRg5ktRGQ",
                columns: new[] { "DateCreated", "TrackId" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 4, 11, 13, 51, 43, 809, DateTimeKind.Unspecified).AddTicks(6726), new TimeSpan(0, 0, 0, 0, 0)), "11298de6-eccc-48b3-b0b2-4f100bce4265" });

            migrationBuilder.UpdateData(
                schema: "Troshka",
                table: "Regions",
                keyColumn: "Id",
                keyValue: "A1CnH1tLY9MO6PWS6ORl",
                columns: new[] { "DateCreated", "TrackId" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 4, 11, 13, 51, 43, 809, DateTimeKind.Unspecified).AddTicks(6808), new TimeSpan(0, 0, 0, 0, 0)), "d2b1431d-bb1f-4a46-9469-58384e3ebd47" });

            migrationBuilder.UpdateData(
                schema: "Troshka",
                table: "Regions",
                keyColumn: "Id",
                keyValue: "AAH7gkgvxTPPovngcfsJ",
                columns: new[] { "DateCreated", "TrackId" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 4, 11, 13, 51, 43, 809, DateTimeKind.Unspecified).AddTicks(6819), new TimeSpan(0, 0, 0, 0, 0)), "3cbaca11-0efb-4fff-acc1-21b4cf3ec411" });

            migrationBuilder.UpdateData(
                schema: "Troshka",
                table: "Regions",
                keyColumn: "Id",
                keyValue: "AFmN6OptpMY0LezPyjyz",
                columns: new[] { "DateCreated", "TrackId" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 4, 11, 13, 51, 43, 809, DateTimeKind.Unspecified).AddTicks(6657), new TimeSpan(0, 0, 0, 0, 0)), "f1c471b8-0da3-4864-ab3f-1b9a4a984c88" });

            migrationBuilder.UpdateData(
                schema: "Troshka",
                table: "Regions",
                keyColumn: "Id",
                keyValue: "BzA0a14BLyuBXlDvgNVl",
                columns: new[] { "DateCreated", "TrackId" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 4, 11, 13, 51, 43, 809, DateTimeKind.Unspecified).AddTicks(6796), new TimeSpan(0, 0, 0, 0, 0)), "dceab512-14b2-4d3d-b4d3-2f11c6d8cf04" });

            migrationBuilder.UpdateData(
                schema: "Troshka",
                table: "Regions",
                keyColumn: "Id",
                keyValue: "cebjaOy1ByfOBnYYM8Ye",
                columns: new[] { "DateCreated", "TrackId" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 4, 11, 13, 51, 43, 809, DateTimeKind.Unspecified).AddTicks(6697), new TimeSpan(0, 0, 0, 0, 0)), "ce1ad9cc-a910-430b-8197-a7ab882d3e3f" });

            migrationBuilder.UpdateData(
                schema: "Troshka",
                table: "Regions",
                keyColumn: "Id",
                keyValue: "eVRJzKNQ1NW4BCuqwCkE",
                columns: new[] { "DateCreated", "TrackId" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 4, 11, 13, 51, 43, 809, DateTimeKind.Unspecified).AddTicks(6751), new TimeSpan(0, 0, 0, 0, 0)), "eab4a603-d4fe-4227-bcb4-716811a74035" });

            migrationBuilder.UpdateData(
                schema: "Troshka",
                table: "Regions",
                keyColumn: "Id",
                keyValue: "EWVXiJYgSdc7UFofpRDu",
                columns: new[] { "DateCreated", "TrackId" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 4, 11, 13, 51, 43, 809, DateTimeKind.Unspecified).AddTicks(6715), new TimeSpan(0, 0, 0, 0, 0)), "075c90d9-20ae-4d4c-ac54-2d8bc682eb16" });

            migrationBuilder.UpdateData(
                schema: "Troshka",
                table: "Regions",
                keyColumn: "Id",
                keyValue: "EzC6JDofCCRkKgHzu3dI",
                columns: new[] { "DateCreated", "TrackId" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 4, 11, 13, 51, 43, 809, DateTimeKind.Unspecified).AddTicks(6721), new TimeSpan(0, 0, 0, 0, 0)), "39554321-9b18-48ac-ba60-3897be675696" });

            migrationBuilder.UpdateData(
                schema: "Troshka",
                table: "Regions",
                keyColumn: "Id",
                keyValue: "hTvSc0MvBTkedmyyA7NN",
                columns: new[] { "DateCreated", "TrackId" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 4, 11, 13, 51, 43, 809, DateTimeKind.Unspecified).AddTicks(6710), new TimeSpan(0, 0, 0, 0, 0)), "63ced925-2ab6-4783-83e6-773b3302d329" });

            migrationBuilder.UpdateData(
                schema: "Troshka",
                table: "Regions",
                keyColumn: "Id",
                keyValue: "iP5gptdNCnAzqRorUYop",
                columns: new[] { "DateCreated", "TrackId" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 4, 11, 13, 51, 43, 809, DateTimeKind.Unspecified).AddTicks(7351), new TimeSpan(0, 0, 0, 0, 0)), "f559190a-8ea9-494a-9fd5-2c508036730b" });

            migrationBuilder.UpdateData(
                schema: "Troshka",
                table: "Regions",
                keyColumn: "Id",
                keyValue: "iW1OjUiHcqYURewMo7b7",
                columns: new[] { "DateCreated", "TrackId" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 4, 11, 13, 51, 43, 809, DateTimeKind.Unspecified).AddTicks(6705), new TimeSpan(0, 0, 0, 0, 0)), "e0f7ad13-7bdf-43fc-9a0a-7653b7aa8c38" });

            migrationBuilder.UpdateData(
                schema: "Troshka",
                table: "Regions",
                keyColumn: "Id",
                keyValue: "kUDuBIKZ6DZuHytq19Jp",
                columns: new[] { "DateCreated", "TrackId" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 4, 11, 13, 51, 43, 809, DateTimeKind.Unspecified).AddTicks(7359), new TimeSpan(0, 0, 0, 0, 0)), "2833239f-1c0a-4153-ae14-859da0181c98" });

            migrationBuilder.UpdateData(
                schema: "Troshka",
                table: "Regions",
                keyColumn: "Id",
                keyValue: "lfwOlRqHcAYTpbxUmiBK",
                columns: new[] { "DateCreated", "TrackId" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 4, 11, 13, 51, 43, 809, DateTimeKind.Unspecified).AddTicks(7324), new TimeSpan(0, 0, 0, 0, 0)), "9b9b1715-5e81-4f31-8790-04ddc788ddef" });

            migrationBuilder.UpdateData(
                schema: "Troshka",
                table: "Regions",
                keyColumn: "Id",
                keyValue: "m6nvdcOx04SwKS3JmQuu",
                columns: new[] { "DateCreated", "TrackId" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 4, 11, 13, 51, 43, 809, DateTimeKind.Unspecified).AddTicks(6814), new TimeSpan(0, 0, 0, 0, 0)), "4d4cab05-f831-413b-870d-fbb44706ab8e" });

            migrationBuilder.UpdateData(
                schema: "Troshka",
                table: "Regions",
                keyColumn: "Id",
                keyValue: "qys6uigQzGAe5CFRquPE",
                columns: new[] { "DateCreated", "TrackId" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 4, 11, 13, 51, 43, 809, DateTimeKind.Unspecified).AddTicks(6838), new TimeSpan(0, 0, 0, 0, 0)), "79d2d97b-84d6-4835-a5a1-259a41098359" });

            migrationBuilder.UpdateData(
                schema: "Troshka",
                table: "Regions",
                keyColumn: "Id",
                keyValue: "sPB8FQRwlj7zkzWNSHPp",
                columns: new[] { "DateCreated", "TrackId" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 4, 11, 13, 51, 43, 809, DateTimeKind.Unspecified).AddTicks(6645), new TimeSpan(0, 0, 0, 0, 0)), "ed2489cf-cf80-4b89-9ab3-23988a05014d" });

            migrationBuilder.UpdateData(
                schema: "Troshka",
                table: "Regions",
                keyColumn: "Id",
                keyValue: "ssHgRpb69ARnCL27lW8Z",
                columns: new[] { "DateCreated", "TrackId" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 4, 11, 13, 51, 43, 809, DateTimeKind.Unspecified).AddTicks(6802), new TimeSpan(0, 0, 0, 0, 0)), "aa76f16b-f311-4c7a-927c-2d35536c4ad9" });

            migrationBuilder.UpdateData(
                schema: "Troshka",
                table: "Regions",
                keyColumn: "Id",
                keyValue: "tGOFKGTIXre5MbB6nbPo",
                columns: new[] { "DateCreated", "TrackId" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 4, 11, 13, 51, 43, 809, DateTimeKind.Unspecified).AddTicks(6739), new TimeSpan(0, 0, 0, 0, 0)), "7b3309ef-a156-484b-96c4-35bc0d8cdfe0" });

            migrationBuilder.UpdateData(
                schema: "Troshka",
                table: "Regions",
                keyColumn: "Id",
                keyValue: "tISK82svC0LzIBzGRgRs",
                columns: new[] { "DateCreated", "TrackId" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 4, 11, 13, 51, 43, 809, DateTimeKind.Unspecified).AddTicks(6732), new TimeSpan(0, 0, 0, 0, 0)), "c8b24933-0f23-45fd-9c9f-4b75a00755b0" });

            migrationBuilder.UpdateData(
                schema: "Troshka",
                table: "Regions",
                keyColumn: "Id",
                keyValue: "U7BLcxhRiK259caYZtoe",
                columns: new[] { "DateCreated", "TrackId" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 4, 11, 13, 51, 43, 809, DateTimeKind.Unspecified).AddTicks(6744), new TimeSpan(0, 0, 0, 0, 0)), "dc33f213-765f-41b3-a679-1c800a0e9f2c" });

            migrationBuilder.UpdateData(
                schema: "Troshka",
                table: "Regions",
                keyColumn: "Id",
                keyValue: "xC8qGAbw5YtdET2UURuP",
                columns: new[] { "DateCreated", "TrackId" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 4, 11, 13, 51, 43, 809, DateTimeKind.Unspecified).AddTicks(7342), new TimeSpan(0, 0, 0, 0, 0)), "d8dbc35c-c7b4-4912-9770-fde3dc301ddf" });

            migrationBuilder.UpdateData(
                schema: "Troshka",
                table: "Regions",
                keyColumn: "Id",
                keyValue: "xseBOjqVjozxkJcgGubc",
                columns: new[] { "DateCreated", "TrackId" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 4, 11, 13, 51, 43, 809, DateTimeKind.Unspecified).AddTicks(6832), new TimeSpan(0, 0, 0, 0, 0)), "a159395c-638a-4b85-a408-d523cfbdc7bc" });

            migrationBuilder.InsertData(
                schema: "Troshka",
                table: "Transmissions",
                columns: new[] { "Id", "DateCreated", "DateDeleted", "DateUpdated", "IsDeleted", "Name", "TrackId" },
                values: new object[,]
                {
                    { "A246XfuSRCrP2zmtdslv", new DateTimeOffset(new DateTime(2023, 4, 11, 13, 51, 43, 810, DateTimeKind.Unspecified).AddTicks(2552), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "Ръчна", "8fcfb31d-cf08-430a-8fea-fac869542cea" },
                    { "DvsbpUJ0lzW5KWQ7htJy", new DateTimeOffset(new DateTime(2023, 4, 11, 13, 51, 43, 810, DateTimeKind.Unspecified).AddTicks(2546), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "Полу-автоматик", "e5cb66f0-d3b5-4df8-812d-09ed9fc00352" },
                    { "Jq1ISYuz8noh9Ql12dSn", new DateTimeOffset(new DateTime(2023, 4, 11, 13, 51, 43, 810, DateTimeKind.Unspecified).AddTicks(2538), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "Автоматик", "9abbd061-2546-4e34-9446-19a189a2b90e" }
                });

            migrationBuilder.AddForeignKey(
                name: "FK_CarOffers_Users_AuthorId",
                schema: "Cars",
                table: "CarOffers",
                column: "AuthorId",
                principalSchema: "Troshka",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_UserComments_Users_AuthorId",
                table: "UserComments",
                column: "AuthorId",
                principalSchema: "Troshka",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_UserComments_Users_RecipientId",
                table: "UserComments",
                column: "RecipientId",
                principalSchema: "Troshka",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CarOffers_Users_AuthorId",
                schema: "Cars",
                table: "CarOffers");

            migrationBuilder.DropForeignKey(
                name: "FK_UserComments_Users_AuthorId",
                table: "UserComments");

            migrationBuilder.DropForeignKey(
                name: "FK_UserComments_Users_RecipientId",
                table: "UserComments");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Users",
                schema: "Troshka",
                table: "Users");

            migrationBuilder.DeleteData(
                schema: "Troshka",
                table: "Currencies",
                keyColumn: "Id",
                keyValue: "cmxdWnb7d1XkI2kYt1tn");

            migrationBuilder.DeleteData(
                schema: "Troshka",
                table: "Currencies",
                keyColumn: "Id",
                keyValue: "GWFxeUMQybuo8ooG0C9N");

            migrationBuilder.DeleteData(
                schema: "Troshka",
                table: "Currencies",
                keyColumn: "Id",
                keyValue: "Nt6E95kKmje2yp0kpmnp");

            migrationBuilder.DeleteData(
                schema: "Troshka",
                table: "Engines",
                keyColumn: "Id",
                keyValue: "7nrfrATU6wYRFlYhXar2");

            migrationBuilder.DeleteData(
                schema: "Troshka",
                table: "Engines",
                keyColumn: "Id",
                keyValue: "Dz9jEbh3b3mqoGX9IIAd");

            migrationBuilder.DeleteData(
                schema: "Troshka",
                table: "Engines",
                keyColumn: "Id",
                keyValue: "gj7X5gw4FQ72IhK2eRfa");

            migrationBuilder.DeleteData(
                schema: "Troshka",
                table: "Engines",
                keyColumn: "Id",
                keyValue: "J90x9uTjNa7r8Ibt25rm");

            migrationBuilder.DeleteData(
                schema: "Troshka",
                table: "Engines",
                keyColumn: "Id",
                keyValue: "o6oHm8z2thPuvJpQX172");

            migrationBuilder.DeleteData(
                schema: "Troshka",
                table: "EuroStandards",
                keyColumn: "Id",
                keyValue: "KPEdwSvTqklMdWQxmN3e");

            migrationBuilder.DeleteData(
                schema: "Troshka",
                table: "EuroStandards",
                keyColumn: "Id",
                keyValue: "moRoTsTCTLIIW7Exek7j");

            migrationBuilder.DeleteData(
                schema: "Troshka",
                table: "EuroStandards",
                keyColumn: "Id",
                keyValue: "Nq9WCGKAkkt71dp0bFNv");

            migrationBuilder.DeleteData(
                schema: "Troshka",
                table: "EuroStandards",
                keyColumn: "Id",
                keyValue: "nsLxuvw3TUbyBPPa7MYj");

            migrationBuilder.DeleteData(
                schema: "Troshka",
                table: "EuroStandards",
                keyColumn: "Id",
                keyValue: "TgkPPQopzcI9gu276e95");

            migrationBuilder.DeleteData(
                schema: "Troshka",
                table: "EuroStandards",
                keyColumn: "Id",
                keyValue: "UE7q5pASKodSn9fm5glj");

            migrationBuilder.DeleteData(
                schema: "Troshka",
                table: "EuroStandards",
                keyColumn: "Id",
                keyValue: "y0zcBhtPxny7LFF2MI0Y");

            migrationBuilder.DeleteData(
                schema: "Troshka",
                table: "Interior",
                keyColumn: "Id",
                keyValue: "eP9bxgGoUkJm25GayNFT");

            migrationBuilder.DeleteData(
                schema: "Troshka",
                table: "Interior",
                keyColumn: "Id",
                keyValue: "QJTTXpWMEbft3uBSbd4G");

            migrationBuilder.DeleteData(
                schema: "Troshka",
                table: "Interior",
                keyColumn: "Id",
                keyValue: "yREGUWfTNNEjS61gp5Ee");

            migrationBuilder.DeleteData(
                schema: "Cars",
                table: "Models",
                keyColumn: "Id",
                keyValue: "02SaKt7gU9oX86ef2DD5");

            migrationBuilder.DeleteData(
                schema: "Cars",
                table: "Models",
                keyColumn: "Id",
                keyValue: "0nw9LrFtlk85PMFaF47X");

            migrationBuilder.DeleteData(
                schema: "Cars",
                table: "Models",
                keyColumn: "Id",
                keyValue: "14D6JWqXh1VM24x4jBDQ");

            migrationBuilder.DeleteData(
                schema: "Cars",
                table: "Models",
                keyColumn: "Id",
                keyValue: "15eehWsAdmrugzeG8gED");

            migrationBuilder.DeleteData(
                schema: "Cars",
                table: "Models",
                keyColumn: "Id",
                keyValue: "17mPIaBNLyVkMb0Bzl7A");

            migrationBuilder.DeleteData(
                schema: "Cars",
                table: "Models",
                keyColumn: "Id",
                keyValue: "20m0YumXhffMT735Yz4s");

            migrationBuilder.DeleteData(
                schema: "Cars",
                table: "Models",
                keyColumn: "Id",
                keyValue: "21ExoxLXTG93djXL3S4o");

            migrationBuilder.DeleteData(
                schema: "Cars",
                table: "Models",
                keyColumn: "Id",
                keyValue: "2AkBnL3lthpzVRMJTy6X");

            migrationBuilder.DeleteData(
                schema: "Cars",
                table: "Models",
                keyColumn: "Id",
                keyValue: "2lfGppvJN8z1lppRQdMG");

            migrationBuilder.DeleteData(
                schema: "Cars",
                table: "Models",
                keyColumn: "Id",
                keyValue: "2qbRq6VgFqePoHQLU9DJ");

            migrationBuilder.DeleteData(
                schema: "Cars",
                table: "Models",
                keyColumn: "Id",
                keyValue: "2qKSlVdx2xQI5yxFK5qR");

            migrationBuilder.DeleteData(
                schema: "Cars",
                table: "Models",
                keyColumn: "Id",
                keyValue: "31e44jEe2SXrk51Mu2LU");

            migrationBuilder.DeleteData(
                schema: "Cars",
                table: "Models",
                keyColumn: "Id",
                keyValue: "3d5I25wKSozAQAMtzPS7");

            migrationBuilder.DeleteData(
                schema: "Cars",
                table: "Models",
                keyColumn: "Id",
                keyValue: "3euKfNTXl3ug8n7eEB1f");

            migrationBuilder.DeleteData(
                schema: "Cars",
                table: "Models",
                keyColumn: "Id",
                keyValue: "3mRqG7BLMhgMnnCsK63k");

            migrationBuilder.DeleteData(
                schema: "Cars",
                table: "Models",
                keyColumn: "Id",
                keyValue: "4FYRWMwxPPUpXgglqw8L");

            migrationBuilder.DeleteData(
                schema: "Cars",
                table: "Models",
                keyColumn: "Id",
                keyValue: "4JS8QssV7EVRMe6u2u9o");

            migrationBuilder.DeleteData(
                schema: "Cars",
                table: "Models",
                keyColumn: "Id",
                keyValue: "53Gh5YBboF9MB9r74ILN");

            migrationBuilder.DeleteData(
                schema: "Cars",
                table: "Models",
                keyColumn: "Id",
                keyValue: "59BdngdbkFPnnj0xntyo");

            migrationBuilder.DeleteData(
                schema: "Cars",
                table: "Models",
                keyColumn: "Id",
                keyValue: "5cfVFCAc5Jlwp9hFokHx");

            migrationBuilder.DeleteData(
                schema: "Cars",
                table: "Models",
                keyColumn: "Id",
                keyValue: "5NP8g6fMLRXcGpIURYRt");

            migrationBuilder.DeleteData(
                schema: "Cars",
                table: "Models",
                keyColumn: "Id",
                keyValue: "5YBSSxVDhXhjargn5LpH");

            migrationBuilder.DeleteData(
                schema: "Cars",
                table: "Models",
                keyColumn: "Id",
                keyValue: "5YuVpdTIl8YkFxQ1KVeI");

            migrationBuilder.DeleteData(
                schema: "Cars",
                table: "Models",
                keyColumn: "Id",
                keyValue: "6Dqt6DEYhdsWJnAfgrJz");

            migrationBuilder.DeleteData(
                schema: "Cars",
                table: "Models",
                keyColumn: "Id",
                keyValue: "6EVr2IfvsCJxPsMcIh2g");

            migrationBuilder.DeleteData(
                schema: "Cars",
                table: "Models",
                keyColumn: "Id",
                keyValue: "6HkqdmpG81IqEGy9VNyq");

            migrationBuilder.DeleteData(
                schema: "Cars",
                table: "Models",
                keyColumn: "Id",
                keyValue: "6HobKUcCJyDdVLHpCU4e");

            migrationBuilder.DeleteData(
                schema: "Cars",
                table: "Models",
                keyColumn: "Id",
                keyValue: "6I65GCCwB2EFfcLh7pm8");

            migrationBuilder.DeleteData(
                schema: "Cars",
                table: "Models",
                keyColumn: "Id",
                keyValue: "6jREXXNKPBgjMsEpkgmD");

            migrationBuilder.DeleteData(
                schema: "Cars",
                table: "Models",
                keyColumn: "Id",
                keyValue: "6MuKfzcyCPfyVQM3WHba");

            migrationBuilder.DeleteData(
                schema: "Cars",
                table: "Models",
                keyColumn: "Id",
                keyValue: "6yTpk1frCTBHUEGt7p9I");

            migrationBuilder.DeleteData(
                schema: "Cars",
                table: "Models",
                keyColumn: "Id",
                keyValue: "774A0lmo27IHyrRIBu9E");

            migrationBuilder.DeleteData(
                schema: "Cars",
                table: "Models",
                keyColumn: "Id",
                keyValue: "7e1NBjSC3h70F28268XQ");

            migrationBuilder.DeleteData(
                schema: "Cars",
                table: "Models",
                keyColumn: "Id",
                keyValue: "8E6tCqBl3N6DesujECWd");

            migrationBuilder.DeleteData(
                schema: "Cars",
                table: "Models",
                keyColumn: "Id",
                keyValue: "8EVIgYAhWRE78pTgDUv6");

            migrationBuilder.DeleteData(
                schema: "Cars",
                table: "Models",
                keyColumn: "Id",
                keyValue: "8GMuJREeVo3TVACFYjpk");

            migrationBuilder.DeleteData(
                schema: "Cars",
                table: "Models",
                keyColumn: "Id",
                keyValue: "8yTeTI3bl7MX03BIq9bH");

            migrationBuilder.DeleteData(
                schema: "Cars",
                table: "Models",
                keyColumn: "Id",
                keyValue: "9jopsSFUULzC68AsFmts");

            migrationBuilder.DeleteData(
                schema: "Cars",
                table: "Models",
                keyColumn: "Id",
                keyValue: "9mQpu9qsD1TjrDjqaPmB");

            migrationBuilder.DeleteData(
                schema: "Cars",
                table: "Models",
                keyColumn: "Id",
                keyValue: "9pDbCh6wMapWCBFbWmX3");

            migrationBuilder.DeleteData(
                schema: "Cars",
                table: "Models",
                keyColumn: "Id",
                keyValue: "9xFoMzol4TrhmvN7HwJG");

            migrationBuilder.DeleteData(
                schema: "Cars",
                table: "Models",
                keyColumn: "Id",
                keyValue: "aCLQEq2HIfhzMmPfD0L8");

            migrationBuilder.DeleteData(
                schema: "Cars",
                table: "Models",
                keyColumn: "Id",
                keyValue: "aDCrGht19oYdrpmJCyJR");

            migrationBuilder.DeleteData(
                schema: "Cars",
                table: "Models",
                keyColumn: "Id",
                keyValue: "aKGhFykfXFfxY8NfbQv8");

            migrationBuilder.DeleteData(
                schema: "Cars",
                table: "Models",
                keyColumn: "Id",
                keyValue: "Al8QrWKsmEr8AkS9qmAI");

            migrationBuilder.DeleteData(
                schema: "Cars",
                table: "Models",
                keyColumn: "Id",
                keyValue: "Am3NKeHple4mdVP6hCkL");

            migrationBuilder.DeleteData(
                schema: "Cars",
                table: "Models",
                keyColumn: "Id",
                keyValue: "APV6Vp1X96VTbysrB3xu");

            migrationBuilder.DeleteData(
                schema: "Cars",
                table: "Models",
                keyColumn: "Id",
                keyValue: "ARJTLxp3BpBvpalFL53Y");

            migrationBuilder.DeleteData(
                schema: "Cars",
                table: "Models",
                keyColumn: "Id",
                keyValue: "B3JHFe4uKqg65VIzYLa2");

            migrationBuilder.DeleteData(
                schema: "Cars",
                table: "Models",
                keyColumn: "Id",
                keyValue: "B81uUI9NxhjLoJc6l5Cq");

            migrationBuilder.DeleteData(
                schema: "Cars",
                table: "Models",
                keyColumn: "Id",
                keyValue: "BGPIFuFmMdxCN5q5F6P0");

            migrationBuilder.DeleteData(
                schema: "Cars",
                table: "Models",
                keyColumn: "Id",
                keyValue: "bH5pRsv6e3g53gHPqSIP");

            migrationBuilder.DeleteData(
                schema: "Cars",
                table: "Models",
                keyColumn: "Id",
                keyValue: "bj8XwvTNucBLcYXlvCo5");

            migrationBuilder.DeleteData(
                schema: "Cars",
                table: "Models",
                keyColumn: "Id",
                keyValue: "bSLwRfQmHM6UqwjQWDrJ");

            migrationBuilder.DeleteData(
                schema: "Cars",
                table: "Models",
                keyColumn: "Id",
                keyValue: "BTsWxVrSeGcy1hj36ACh");

            migrationBuilder.DeleteData(
                schema: "Cars",
                table: "Models",
                keyColumn: "Id",
                keyValue: "btxPwsGw68HU1t5gczot");

            migrationBuilder.DeleteData(
                schema: "Cars",
                table: "Models",
                keyColumn: "Id",
                keyValue: "BVj3cLI0vRo5Ae0PhnFP");

            migrationBuilder.DeleteData(
                schema: "Cars",
                table: "Models",
                keyColumn: "Id",
                keyValue: "BWNkdN50tnyvPoSrHm5S");

            migrationBuilder.DeleteData(
                schema: "Cars",
                table: "Models",
                keyColumn: "Id",
                keyValue: "bWquPERClrGzu0BQaXG5");

            migrationBuilder.DeleteData(
                schema: "Cars",
                table: "Models",
                keyColumn: "Id",
                keyValue: "BWx7wk8XH8ksXIDrhvty");

            migrationBuilder.DeleteData(
                schema: "Cars",
                table: "Models",
                keyColumn: "Id",
                keyValue: "bXB7y9UXxFYhbGBBDUUt");

            migrationBuilder.DeleteData(
                schema: "Cars",
                table: "Models",
                keyColumn: "Id",
                keyValue: "ByqWvBp2Ra83LBUPDGud");

            migrationBuilder.DeleteData(
                schema: "Cars",
                table: "Models",
                keyColumn: "Id",
                keyValue: "c1gCdMoTS3BDBCKCAy70");

            migrationBuilder.DeleteData(
                schema: "Cars",
                table: "Models",
                keyColumn: "Id",
                keyValue: "C55XLJRSjMnezvJX26gR");

            migrationBuilder.DeleteData(
                schema: "Cars",
                table: "Models",
                keyColumn: "Id",
                keyValue: "C5VgYofpVU77YF1VcVkY");

            migrationBuilder.DeleteData(
                schema: "Cars",
                table: "Models",
                keyColumn: "Id",
                keyValue: "cAFpUYCk0Unov9QdeeCY");

            migrationBuilder.DeleteData(
                schema: "Cars",
                table: "Models",
                keyColumn: "Id",
                keyValue: "CdX9w9dQEfQJ3PVSPVJx");

            migrationBuilder.DeleteData(
                schema: "Cars",
                table: "Models",
                keyColumn: "Id",
                keyValue: "CgNSdrWE6lkWIWKy6azW");

            migrationBuilder.DeleteData(
                schema: "Cars",
                table: "Models",
                keyColumn: "Id",
                keyValue: "cJ5uGITtFyVjflbnUDIH");

            migrationBuilder.DeleteData(
                schema: "Cars",
                table: "Models",
                keyColumn: "Id",
                keyValue: "CNvqPpkTQdsUv04dEGy9");

            migrationBuilder.DeleteData(
                schema: "Cars",
                table: "Models",
                keyColumn: "Id",
                keyValue: "crat5VDyW9pE57bdsxe7");

            migrationBuilder.DeleteData(
                schema: "Cars",
                table: "Models",
                keyColumn: "Id",
                keyValue: "cUL2bq4xBRMvLbEyur6P");

            migrationBuilder.DeleteData(
                schema: "Cars",
                table: "Models",
                keyColumn: "Id",
                keyValue: "CUpJ5XUvhrgCJa4DDsHY");

            migrationBuilder.DeleteData(
                schema: "Cars",
                table: "Models",
                keyColumn: "Id",
                keyValue: "d1MGMwDmQLxRxrQeew0s");

            migrationBuilder.DeleteData(
                schema: "Cars",
                table: "Models",
                keyColumn: "Id",
                keyValue: "d2ujCB4mKmGByD7Jjmmb");

            migrationBuilder.DeleteData(
                schema: "Cars",
                table: "Models",
                keyColumn: "Id",
                keyValue: "Dazzz2VbvYxfHqAXwX0Y");

            migrationBuilder.DeleteData(
                schema: "Cars",
                table: "Models",
                keyColumn: "Id",
                keyValue: "DbTBVBDLvaNUfowR7WMc");

            migrationBuilder.DeleteData(
                schema: "Cars",
                table: "Models",
                keyColumn: "Id",
                keyValue: "DcA8jCj8E7MKdHf86RgA");

            migrationBuilder.DeleteData(
                schema: "Cars",
                table: "Models",
                keyColumn: "Id",
                keyValue: "DhUkpR3HpIzoN5TVvWmu");

            migrationBuilder.DeleteData(
                schema: "Cars",
                table: "Models",
                keyColumn: "Id",
                keyValue: "dKXMQJgo4mvcvc6rWKML");

            migrationBuilder.DeleteData(
                schema: "Cars",
                table: "Models",
                keyColumn: "Id",
                keyValue: "dLzXW1g2VzmkJSCBP9Yf");

            migrationBuilder.DeleteData(
                schema: "Cars",
                table: "Models",
                keyColumn: "Id",
                keyValue: "DzUm7JTeEF0GMhhtMAb5");

            migrationBuilder.DeleteData(
                schema: "Cars",
                table: "Models",
                keyColumn: "Id",
                keyValue: "E4bc7RBn4hJ078TqesIy");

            migrationBuilder.DeleteData(
                schema: "Cars",
                table: "Models",
                keyColumn: "Id",
                keyValue: "E4KJJ9kpR19SIvPyKKn3");

            migrationBuilder.DeleteData(
                schema: "Cars",
                table: "Models",
                keyColumn: "Id",
                keyValue: "eKyyFtddG0Ww4oapuX0S");

            migrationBuilder.DeleteData(
                schema: "Cars",
                table: "Models",
                keyColumn: "Id",
                keyValue: "eqp42zTFh4BkFL7Q87N6");

            migrationBuilder.DeleteData(
                schema: "Cars",
                table: "Models",
                keyColumn: "Id",
                keyValue: "F2jtUQa5cHzongYTBV9u");

            migrationBuilder.DeleteData(
                schema: "Cars",
                table: "Models",
                keyColumn: "Id",
                keyValue: "f2KdyjY97tAAYWqMNKyI");

            migrationBuilder.DeleteData(
                schema: "Cars",
                table: "Models",
                keyColumn: "Id",
                keyValue: "f98wSQT4amGCwvguPnoF");

            migrationBuilder.DeleteData(
                schema: "Cars",
                table: "Models",
                keyColumn: "Id",
                keyValue: "FKWp1dydzgEMgNFuKBXb");

            migrationBuilder.DeleteData(
                schema: "Cars",
                table: "Models",
                keyColumn: "Id",
                keyValue: "FlCgfto9005AulgaSLtT");

            migrationBuilder.DeleteData(
                schema: "Cars",
                table: "Models",
                keyColumn: "Id",
                keyValue: "fLfD3vWuJpL7UWH0IKHo");

            migrationBuilder.DeleteData(
                schema: "Cars",
                table: "Models",
                keyColumn: "Id",
                keyValue: "FQIlTJ7eE5jChttlVtIz");

            migrationBuilder.DeleteData(
                schema: "Cars",
                table: "Models",
                keyColumn: "Id",
                keyValue: "FWacLT8AtEGDB52EpPDg");

            migrationBuilder.DeleteData(
                schema: "Cars",
                table: "Models",
                keyColumn: "Id",
                keyValue: "fzAl25tH3yzmVQPpKoTX");

            migrationBuilder.DeleteData(
                schema: "Cars",
                table: "Models",
                keyColumn: "Id",
                keyValue: "G1mNSJe6JKjaaAHJ3XTD");

            migrationBuilder.DeleteData(
                schema: "Cars",
                table: "Models",
                keyColumn: "Id",
                keyValue: "G3RwU1fFboR50yJehJdb");

            migrationBuilder.DeleteData(
                schema: "Cars",
                table: "Models",
                keyColumn: "Id",
                keyValue: "g4IyHUarGUKVXFIYd5IH");

            migrationBuilder.DeleteData(
                schema: "Cars",
                table: "Models",
                keyColumn: "Id",
                keyValue: "GA5vh7RceCaCmoaNQpy5");

            migrationBuilder.DeleteData(
                schema: "Cars",
                table: "Models",
                keyColumn: "Id",
                keyValue: "GdIMyKJ5XWc68Fy9UdXj");

            migrationBuilder.DeleteData(
                schema: "Cars",
                table: "Models",
                keyColumn: "Id",
                keyValue: "GHA6rKPeFDu8vrYQNyvH");

            migrationBuilder.DeleteData(
                schema: "Cars",
                table: "Models",
                keyColumn: "Id",
                keyValue: "gPhyRTqaaS3UAFjdhybS");

            migrationBuilder.DeleteData(
                schema: "Cars",
                table: "Models",
                keyColumn: "Id",
                keyValue: "GSLo8s8hPM93yhuYqEWg");

            migrationBuilder.DeleteData(
                schema: "Cars",
                table: "Models",
                keyColumn: "Id",
                keyValue: "hcuyHthIVWW4G9s6TnkU");

            migrationBuilder.DeleteData(
                schema: "Cars",
                table: "Models",
                keyColumn: "Id",
                keyValue: "hDW5upCVANhq5Fd9lpCB");

            migrationBuilder.DeleteData(
                schema: "Cars",
                table: "Models",
                keyColumn: "Id",
                keyValue: "HlPr8e6DCnPqRjk3nuYe");

            migrationBuilder.DeleteData(
                schema: "Cars",
                table: "Models",
                keyColumn: "Id",
                keyValue: "HtrKqcMqRxQoQfdjY05d");

            migrationBuilder.DeleteData(
                schema: "Cars",
                table: "Models",
                keyColumn: "Id",
                keyValue: "hWwtdT3lDA4gDttLXYAP");

            migrationBuilder.DeleteData(
                schema: "Cars",
                table: "Models",
                keyColumn: "Id",
                keyValue: "HyLotD15xJrz4PY0X86u");

            migrationBuilder.DeleteData(
                schema: "Cars",
                table: "Models",
                keyColumn: "Id",
                keyValue: "I7jmrhXLDwFwHbpBfRwS");

            migrationBuilder.DeleteData(
                schema: "Cars",
                table: "Models",
                keyColumn: "Id",
                keyValue: "II2t2L1DcgLlaCDb9a7J");

            migrationBuilder.DeleteData(
                schema: "Cars",
                table: "Models",
                keyColumn: "Id",
                keyValue: "IJH2X0h5l06QnHtHHtx8");

            migrationBuilder.DeleteData(
                schema: "Cars",
                table: "Models",
                keyColumn: "Id",
                keyValue: "IjI5pF2rezVWvfLTzy1V");

            migrationBuilder.DeleteData(
                schema: "Cars",
                table: "Models",
                keyColumn: "Id",
                keyValue: "IQ7s1z1x8NqxAjITRyQs");

            migrationBuilder.DeleteData(
                schema: "Cars",
                table: "Models",
                keyColumn: "Id",
                keyValue: "IYuRS6V5HDI2PjUNgnvH");

            migrationBuilder.DeleteData(
                schema: "Cars",
                table: "Models",
                keyColumn: "Id",
                keyValue: "J13hr72ueSwf8C6Khect");

            migrationBuilder.DeleteData(
                schema: "Cars",
                table: "Models",
                keyColumn: "Id",
                keyValue: "j4UIKQ3Bgpge7mNJAYnp");

            migrationBuilder.DeleteData(
                schema: "Cars",
                table: "Models",
                keyColumn: "Id",
                keyValue: "J6EsJNx3sRvANKaS7z5y");

            migrationBuilder.DeleteData(
                schema: "Cars",
                table: "Models",
                keyColumn: "Id",
                keyValue: "JDE7udluXVMWEEjdtRQg");

            migrationBuilder.DeleteData(
                schema: "Cars",
                table: "Models",
                keyColumn: "Id",
                keyValue: "jFIVLK64LYnDKVpB9JI0");

            migrationBuilder.DeleteData(
                schema: "Cars",
                table: "Models",
                keyColumn: "Id",
                keyValue: "jhQxrDhQozD61WEKj3o8");

            migrationBuilder.DeleteData(
                schema: "Cars",
                table: "Models",
                keyColumn: "Id",
                keyValue: "jnlmSTj99deDxhEq3IPz");

            migrationBuilder.DeleteData(
                schema: "Cars",
                table: "Models",
                keyColumn: "Id",
                keyValue: "jo3qGo18DYMEpaQM1bIE");

            migrationBuilder.DeleteData(
                schema: "Cars",
                table: "Models",
                keyColumn: "Id",
                keyValue: "jPsc5n0eP4eTQeDkeuCX");

            migrationBuilder.DeleteData(
                schema: "Cars",
                table: "Models",
                keyColumn: "Id",
                keyValue: "JSSoF8UroY8CzUGqNArn");

            migrationBuilder.DeleteData(
                schema: "Cars",
                table: "Models",
                keyColumn: "Id",
                keyValue: "k6BfeL5bCscCS1p1jsLt");

            migrationBuilder.DeleteData(
                schema: "Cars",
                table: "Models",
                keyColumn: "Id",
                keyValue: "KNGUUV4K1GF0Tq4l0CMR");

            migrationBuilder.DeleteData(
                schema: "Cars",
                table: "Models",
                keyColumn: "Id",
                keyValue: "kSdRvgyWvLML8jtu6nXg");

            migrationBuilder.DeleteData(
                schema: "Cars",
                table: "Models",
                keyColumn: "Id",
                keyValue: "kSF9qPlHWpN2WuEoDhw5");

            migrationBuilder.DeleteData(
                schema: "Cars",
                table: "Models",
                keyColumn: "Id",
                keyValue: "ksVnqG1h2js96qv0RhFU");

            migrationBuilder.DeleteData(
                schema: "Cars",
                table: "Models",
                keyColumn: "Id",
                keyValue: "KtFvKrQrzmTv1SAdPMYx");

            migrationBuilder.DeleteData(
                schema: "Cars",
                table: "Models",
                keyColumn: "Id",
                keyValue: "kWDYA3pCp0DrHb3FmMMu");

            migrationBuilder.DeleteData(
                schema: "Cars",
                table: "Models",
                keyColumn: "Id",
                keyValue: "l4a1l4pM4FvH2L5ggG34");

            migrationBuilder.DeleteData(
                schema: "Cars",
                table: "Models",
                keyColumn: "Id",
                keyValue: "lATJaqSXcmorvGUu4zaX");

            migrationBuilder.DeleteData(
                schema: "Cars",
                table: "Models",
                keyColumn: "Id",
                keyValue: "LHcxSwzYltu3aUTdcjB9");

            migrationBuilder.DeleteData(
                schema: "Cars",
                table: "Models",
                keyColumn: "Id",
                keyValue: "ljxuyne3mLs07ArpyVm7");

            migrationBuilder.DeleteData(
                schema: "Cars",
                table: "Models",
                keyColumn: "Id",
                keyValue: "Loassx4UBfgDvA0FelE4");

            migrationBuilder.DeleteData(
                schema: "Cars",
                table: "Models",
                keyColumn: "Id",
                keyValue: "LoXk80vBEhal7e5DuWUM");

            migrationBuilder.DeleteData(
                schema: "Cars",
                table: "Models",
                keyColumn: "Id",
                keyValue: "ltqhJMyQ24KTrhSfWu7f");

            migrationBuilder.DeleteData(
                schema: "Cars",
                table: "Models",
                keyColumn: "Id",
                keyValue: "LWu8qDJ3MIx8d2fcfCYJ");

            migrationBuilder.DeleteData(
                schema: "Cars",
                table: "Models",
                keyColumn: "Id",
                keyValue: "mBwTrdcmsbo47aqeHL0T");

            migrationBuilder.DeleteData(
                schema: "Cars",
                table: "Models",
                keyColumn: "Id",
                keyValue: "MgCMLmE4mHKmXVXDcTqa");

            migrationBuilder.DeleteData(
                schema: "Cars",
                table: "Models",
                keyColumn: "Id",
                keyValue: "MkKrm5LjR5LpuyMx1xlf");

            migrationBuilder.DeleteData(
                schema: "Cars",
                table: "Models",
                keyColumn: "Id",
                keyValue: "MmQ0YmJYol90gFA42efA");

            migrationBuilder.DeleteData(
                schema: "Cars",
                table: "Models",
                keyColumn: "Id",
                keyValue: "MS3Je2qDvHl6Etf5dBek");

            migrationBuilder.DeleteData(
                schema: "Cars",
                table: "Models",
                keyColumn: "Id",
                keyValue: "mTjeE13Cn9XWcpwwfR2P");

            migrationBuilder.DeleteData(
                schema: "Cars",
                table: "Models",
                keyColumn: "Id",
                keyValue: "N2lWuC4aj5y7pbFsHuIP");

            migrationBuilder.DeleteData(
                schema: "Cars",
                table: "Models",
                keyColumn: "Id",
                keyValue: "n4jhE8TC6PVRvobedTHa");

            migrationBuilder.DeleteData(
                schema: "Cars",
                table: "Models",
                keyColumn: "Id",
                keyValue: "n69WpeY8UDYfA7uKujPd");

            migrationBuilder.DeleteData(
                schema: "Cars",
                table: "Models",
                keyColumn: "Id",
                keyValue: "nJWNLK1Bwhe3gSjywyKx");

            migrationBuilder.DeleteData(
                schema: "Cars",
                table: "Models",
                keyColumn: "Id",
                keyValue: "Nlx90WY9mPGcgeLYbmVf");

            migrationBuilder.DeleteData(
                schema: "Cars",
                table: "Models",
                keyColumn: "Id",
                keyValue: "nrp7CjqWvohe71eru0Tp");

            migrationBuilder.DeleteData(
                schema: "Cars",
                table: "Models",
                keyColumn: "Id",
                keyValue: "NtS2yswl6E7B6gjPSdhp");

            migrationBuilder.DeleteData(
                schema: "Cars",
                table: "Models",
                keyColumn: "Id",
                keyValue: "NuvBmKyRghdHjX4TLILz");

            migrationBuilder.DeleteData(
                schema: "Cars",
                table: "Models",
                keyColumn: "Id",
                keyValue: "NVslv4nJlKq7Nwd5yYMX");

            migrationBuilder.DeleteData(
                schema: "Cars",
                table: "Models",
                keyColumn: "Id",
                keyValue: "ofqvccesMEhVEdXznb1A");

            migrationBuilder.DeleteData(
                schema: "Cars",
                table: "Models",
                keyColumn: "Id",
                keyValue: "oJDBgMuEJ6XNbq0LQMC1");

            migrationBuilder.DeleteData(
                schema: "Cars",
                table: "Models",
                keyColumn: "Id",
                keyValue: "ol94SQnLksDcA3LvlBan");

            migrationBuilder.DeleteData(
                schema: "Cars",
                table: "Models",
                keyColumn: "Id",
                keyValue: "oLrS1FodKs8VWe3hKtyp");

            migrationBuilder.DeleteData(
                schema: "Cars",
                table: "Models",
                keyColumn: "Id",
                keyValue: "owNDA9jTb4sUTEMIANGg");

            migrationBuilder.DeleteData(
                schema: "Cars",
                table: "Models",
                keyColumn: "Id",
                keyValue: "p3KQpLPKjHydW70XBuNh");

            migrationBuilder.DeleteData(
                schema: "Cars",
                table: "Models",
                keyColumn: "Id",
                keyValue: "PctNmLyv1CuKPvecDD96");

            migrationBuilder.DeleteData(
                schema: "Cars",
                table: "Models",
                keyColumn: "Id",
                keyValue: "pfJDDu58RfaneBSPEARu");

            migrationBuilder.DeleteData(
                schema: "Cars",
                table: "Models",
                keyColumn: "Id",
                keyValue: "pIvEwHW0TJzjqh3eh1oA");

            migrationBuilder.DeleteData(
                schema: "Cars",
                table: "Models",
                keyColumn: "Id",
                keyValue: "pNHP4rnNEafLTSV26pMT");

            migrationBuilder.DeleteData(
                schema: "Cars",
                table: "Models",
                keyColumn: "Id",
                keyValue: "PR6d8JouFpJK6ADVLcjl");

            migrationBuilder.DeleteData(
                schema: "Cars",
                table: "Models",
                keyColumn: "Id",
                keyValue: "pSnybXwtzrE1qUHesIho");

            migrationBuilder.DeleteData(
                schema: "Cars",
                table: "Models",
                keyColumn: "Id",
                keyValue: "ptpYDtt2b3I0HSnLhL0b");

            migrationBuilder.DeleteData(
                schema: "Cars",
                table: "Models",
                keyColumn: "Id",
                keyValue: "PTvgjEEyQxH1h1PS7z8Y");

            migrationBuilder.DeleteData(
                schema: "Cars",
                table: "Models",
                keyColumn: "Id",
                keyValue: "PxTqCIcaYSGzJRuFMJWq");

            migrationBuilder.DeleteData(
                schema: "Cars",
                table: "Models",
                keyColumn: "Id",
                keyValue: "qb6GGSLcjR2t9Fla49e2");

            migrationBuilder.DeleteData(
                schema: "Cars",
                table: "Models",
                keyColumn: "Id",
                keyValue: "QLDSHkxnUu2LUaSXLycu");

            migrationBuilder.DeleteData(
                schema: "Cars",
                table: "Models",
                keyColumn: "Id",
                keyValue: "QnhWH1vEE5wL6JVabAeg");

            migrationBuilder.DeleteData(
                schema: "Cars",
                table: "Models",
                keyColumn: "Id",
                keyValue: "qP6cdyNrC8hMJSCslMjy");

            migrationBuilder.DeleteData(
                schema: "Cars",
                table: "Models",
                keyColumn: "Id",
                keyValue: "qr6L2rz6UFIKscLomGK7");

            migrationBuilder.DeleteData(
                schema: "Cars",
                table: "Models",
                keyColumn: "Id",
                keyValue: "QVhQF8c3YbGgyNmEtNnD");

            migrationBuilder.DeleteData(
                schema: "Cars",
                table: "Models",
                keyColumn: "Id",
                keyValue: "QYf3zK8EDfc7g3p42Sav");

            migrationBuilder.DeleteData(
                schema: "Cars",
                table: "Models",
                keyColumn: "Id",
                keyValue: "Qz0wHVEN0xxgpMH38jrU");

            migrationBuilder.DeleteData(
                schema: "Cars",
                table: "Models",
                keyColumn: "Id",
                keyValue: "qzECSnkXebjdz8V18Mxa");

            migrationBuilder.DeleteData(
                schema: "Cars",
                table: "Models",
                keyColumn: "Id",
                keyValue: "r1MqrJvXbXpVfI02a2Fc");

            migrationBuilder.DeleteData(
                schema: "Cars",
                table: "Models",
                keyColumn: "Id",
                keyValue: "R88KB1eXYGKgLDuEKtnD");

            migrationBuilder.DeleteData(
                schema: "Cars",
                table: "Models",
                keyColumn: "Id",
                keyValue: "rht2GRAXVuTkl43Nf8Xa");

            migrationBuilder.DeleteData(
                schema: "Cars",
                table: "Models",
                keyColumn: "Id",
                keyValue: "RmnUBN2M9d6cJjpFjAfw");

            migrationBuilder.DeleteData(
                schema: "Cars",
                table: "Models",
                keyColumn: "Id",
                keyValue: "RqPjBJqnB5cW4fjfbdvH");

            migrationBuilder.DeleteData(
                schema: "Cars",
                table: "Models",
                keyColumn: "Id",
                keyValue: "rqtT8Mbmz2k47pNf8955");

            migrationBuilder.DeleteData(
                schema: "Cars",
                table: "Models",
                keyColumn: "Id",
                keyValue: "S80IyERUVlovNTEU8vxd");

            migrationBuilder.DeleteData(
                schema: "Cars",
                table: "Models",
                keyColumn: "Id",
                keyValue: "SCrSQGsb83jKp5DnHs6J");

            migrationBuilder.DeleteData(
                schema: "Cars",
                table: "Models",
                keyColumn: "Id",
                keyValue: "SG24ELP5rdfPLsdYw9sy");

            migrationBuilder.DeleteData(
                schema: "Cars",
                table: "Models",
                keyColumn: "Id",
                keyValue: "SGtErd3HTXBK1JSC26kM");

            migrationBuilder.DeleteData(
                schema: "Cars",
                table: "Models",
                keyColumn: "Id",
                keyValue: "SoJP6SlNQSRaRtnJSKeu");

            migrationBuilder.DeleteData(
                schema: "Cars",
                table: "Models",
                keyColumn: "Id",
                keyValue: "SrgI2I4z5EHzUdRjnR1H");

            migrationBuilder.DeleteData(
                schema: "Cars",
                table: "Models",
                keyColumn: "Id",
                keyValue: "SwfGBIhAYzJlN8DWpbGn");

            migrationBuilder.DeleteData(
                schema: "Cars",
                table: "Models",
                keyColumn: "Id",
                keyValue: "sypMP0CJWnSCgu3k4Brh");

            migrationBuilder.DeleteData(
                schema: "Cars",
                table: "Models",
                keyColumn: "Id",
                keyValue: "szcUoq7YRXsR27qGl8gb");

            migrationBuilder.DeleteData(
                schema: "Cars",
                table: "Models",
                keyColumn: "Id",
                keyValue: "T4gsjJp10b62tBWHt01P");

            migrationBuilder.DeleteData(
                schema: "Cars",
                table: "Models",
                keyColumn: "Id",
                keyValue: "T8pHkc1WoNyyDGa92Flb");

            migrationBuilder.DeleteData(
                schema: "Cars",
                table: "Models",
                keyColumn: "Id",
                keyValue: "toHqRle33WzAEgzMA9db");

            migrationBuilder.DeleteData(
                schema: "Cars",
                table: "Models",
                keyColumn: "Id",
                keyValue: "tPHb5EYKQW6pBLpf3P1M");

            migrationBuilder.DeleteData(
                schema: "Cars",
                table: "Models",
                keyColumn: "Id",
                keyValue: "TQ4z4yWpzuUkbRn7XeT5");

            migrationBuilder.DeleteData(
                schema: "Cars",
                table: "Models",
                keyColumn: "Id",
                keyValue: "Trqx9IejpCWMQJC4WGNQ");

            migrationBuilder.DeleteData(
                schema: "Cars",
                table: "Models",
                keyColumn: "Id",
                keyValue: "tsuYP3jaHSn39yI93CtS");

            migrationBuilder.DeleteData(
                schema: "Cars",
                table: "Models",
                keyColumn: "Id",
                keyValue: "ubWdUYsJagYJNYwNzNxh");

            migrationBuilder.DeleteData(
                schema: "Cars",
                table: "Models",
                keyColumn: "Id",
                keyValue: "ubzHJCCbc9GagVdxDWME");

            migrationBuilder.DeleteData(
                schema: "Cars",
                table: "Models",
                keyColumn: "Id",
                keyValue: "Ugw7xXqRjWwm1luoRt1I");

            migrationBuilder.DeleteData(
                schema: "Cars",
                table: "Models",
                keyColumn: "Id",
                keyValue: "Ulh5YdlTAGLxRppTt18c");

            migrationBuilder.DeleteData(
                schema: "Cars",
                table: "Models",
                keyColumn: "Id",
                keyValue: "un31qV3n19B0492jC9qJ");

            migrationBuilder.DeleteData(
                schema: "Cars",
                table: "Models",
                keyColumn: "Id",
                keyValue: "UxUW49lnda09TyqkjDd1");

            migrationBuilder.DeleteData(
                schema: "Cars",
                table: "Models",
                keyColumn: "Id",
                keyValue: "vaRAVPYon4uglCSGLG34");

            migrationBuilder.DeleteData(
                schema: "Cars",
                table: "Models",
                keyColumn: "Id",
                keyValue: "VG1xBcs30rrL9nfABSC7");

            migrationBuilder.DeleteData(
                schema: "Cars",
                table: "Models",
                keyColumn: "Id",
                keyValue: "VHwfuUsfMfv83YQnvdjk");

            migrationBuilder.DeleteData(
                schema: "Cars",
                table: "Models",
                keyColumn: "Id",
                keyValue: "vjRwuuBbDqQjKCFzSRfk");

            migrationBuilder.DeleteData(
                schema: "Cars",
                table: "Models",
                keyColumn: "Id",
                keyValue: "VqYoB9qYwLrPRf304XtL");

            migrationBuilder.DeleteData(
                schema: "Cars",
                table: "Models",
                keyColumn: "Id",
                keyValue: "vueyJM1zlvrpLusQbDT6");

            migrationBuilder.DeleteData(
                schema: "Cars",
                table: "Models",
                keyColumn: "Id",
                keyValue: "VVxChkQzDpceKkTUF5Jx");

            migrationBuilder.DeleteData(
                schema: "Cars",
                table: "Models",
                keyColumn: "Id",
                keyValue: "W75KIuYCHTay8dgsP3S4");

            migrationBuilder.DeleteData(
                schema: "Cars",
                table: "Models",
                keyColumn: "Id",
                keyValue: "wfygyLxazSlYEqwdzwmB");

            migrationBuilder.DeleteData(
                schema: "Cars",
                table: "Models",
                keyColumn: "Id",
                keyValue: "wh3wBeoA8FuJSUUtHol6");

            migrationBuilder.DeleteData(
                schema: "Cars",
                table: "Models",
                keyColumn: "Id",
                keyValue: "WKLdD75F7mV9bwbaVEYX");

            migrationBuilder.DeleteData(
                schema: "Cars",
                table: "Models",
                keyColumn: "Id",
                keyValue: "WMFoEJHuhFYcVr5FfKys");

            migrationBuilder.DeleteData(
                schema: "Cars",
                table: "Models",
                keyColumn: "Id",
                keyValue: "WRfl8qT2C1njxXYPCw2w");

            migrationBuilder.DeleteData(
                schema: "Cars",
                table: "Models",
                keyColumn: "Id",
                keyValue: "X7E8hMs1JY0gRVBUwjjG");

            migrationBuilder.DeleteData(
                schema: "Cars",
                table: "Models",
                keyColumn: "Id",
                keyValue: "XBzaEB6SYvYAjj1PT94N");

            migrationBuilder.DeleteData(
                schema: "Cars",
                table: "Models",
                keyColumn: "Id",
                keyValue: "Xc4Shlm4eXU8rHCXdfg3");

            migrationBuilder.DeleteData(
                schema: "Cars",
                table: "Models",
                keyColumn: "Id",
                keyValue: "XhfAtzcrGQwCWtCwXbFg");

            migrationBuilder.DeleteData(
                schema: "Cars",
                table: "Models",
                keyColumn: "Id",
                keyValue: "XkkY10wcSo22RpDJgMy5");

            migrationBuilder.DeleteData(
                schema: "Cars",
                table: "Models",
                keyColumn: "Id",
                keyValue: "xldwM5jf7nTlfYmNk3b1");

            migrationBuilder.DeleteData(
                schema: "Cars",
                table: "Models",
                keyColumn: "Id",
                keyValue: "Xtu8azFM2ohtKghKzbn6");

            migrationBuilder.DeleteData(
                schema: "Cars",
                table: "Models",
                keyColumn: "Id",
                keyValue: "Xwm7I73v6qmnyP8p7mD6");

            migrationBuilder.DeleteData(
                schema: "Cars",
                table: "Models",
                keyColumn: "Id",
                keyValue: "YdQxDu8CBkBo0hW1Xk7w");

            migrationBuilder.DeleteData(
                schema: "Cars",
                table: "Models",
                keyColumn: "Id",
                keyValue: "YgkYBsYJXyFMqgvKpD5J");

            migrationBuilder.DeleteData(
                schema: "Cars",
                table: "Models",
                keyColumn: "Id",
                keyValue: "YPc8pATPykGChLv7qwY1");

            migrationBuilder.DeleteData(
                schema: "Cars",
                table: "Models",
                keyColumn: "Id",
                keyValue: "YypT4sKmX2QPloFc1hAX");

            migrationBuilder.DeleteData(
                schema: "Cars",
                table: "Models",
                keyColumn: "Id",
                keyValue: "z2IJPRlcBkBBm5WsmS7x");

            migrationBuilder.DeleteData(
                schema: "Cars",
                table: "Models",
                keyColumn: "Id",
                keyValue: "z6BBn2LYwMbYXMrylMRu");

            migrationBuilder.DeleteData(
                schema: "Cars",
                table: "Models",
                keyColumn: "Id",
                keyValue: "z80e1MYVpVj3BUJverQ1");

            migrationBuilder.DeleteData(
                schema: "Cars",
                table: "Models",
                keyColumn: "Id",
                keyValue: "zbKqejmflR4be7U0Wm8R");

            migrationBuilder.DeleteData(
                schema: "Cars",
                table: "Models",
                keyColumn: "Id",
                keyValue: "zlGWgcEppC8ry7eCvDot");

            migrationBuilder.DeleteData(
                schema: "Cars",
                table: "Models",
                keyColumn: "Id",
                keyValue: "zR5qcJqVbDQD7wTzbnws");

            migrationBuilder.DeleteData(
                schema: "Troshka",
                table: "Transmissions",
                keyColumn: "Id",
                keyValue: "A246XfuSRCrP2zmtdslv");

            migrationBuilder.DeleteData(
                schema: "Troshka",
                table: "Transmissions",
                keyColumn: "Id",
                keyValue: "DvsbpUJ0lzW5KWQ7htJy");

            migrationBuilder.DeleteData(
                schema: "Troshka",
                table: "Transmissions",
                keyColumn: "Id",
                keyValue: "Jq1ISYuz8noh9Ql12dSn");

            migrationBuilder.RenameTable(
                name: "Users",
                schema: "Troshka",
                newName: "UserComments",
                newSchema: "Troshka");

            migrationBuilder.AlterColumn<double>(
                name: "Rating",
                schema: "Troshka",
                table: "UserComments",
                type: "float",
                nullable: false,
                defaultValue: 0.0,
                oldClrType: typeof(double),
                oldType: "float",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Phone",
                schema: "Troshka",
                table: "UserComments",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_UserComments",
                schema: "Troshka",
                table: "UserComments",
                column: "Id");

            migrationBuilder.UpdateData(
                schema: "Cars",
                table: "Brands",
                keyColumn: "Id",
                keyValue: "06MxFkB3ArFfVraVWN1u",
                columns: new[] { "DateCreated", "TrackId" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 4, 11, 11, 39, 10, 483, DateTimeKind.Unspecified).AddTicks(1547), new TimeSpan(0, 0, 0, 0, 0)), "0b6dfef1-97bc-486e-8396-36ac1d427d58" });

            migrationBuilder.UpdateData(
                schema: "Cars",
                table: "Brands",
                keyColumn: "Id",
                keyValue: "0SlIJFKD3VdaMAEnxfTT",
                columns: new[] { "DateCreated", "TrackId" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 4, 11, 11, 39, 10, 483, DateTimeKind.Unspecified).AddTicks(1555), new TimeSpan(0, 0, 0, 0, 0)), "98ae4c75-e6e1-4e57-b53b-83c235eaf9ec" });

            migrationBuilder.UpdateData(
                schema: "Cars",
                table: "Brands",
                keyColumn: "Id",
                keyValue: "2FEzeyYHYe3zlhjMeaEF",
                columns: new[] { "DateCreated", "TrackId" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 4, 11, 11, 39, 10, 483, DateTimeKind.Unspecified).AddTicks(1562), new TimeSpan(0, 0, 0, 0, 0)), "81227d91-26c4-430f-a29c-4722619d5d4c" });

            migrationBuilder.UpdateData(
                schema: "Cars",
                table: "Brands",
                keyColumn: "Id",
                keyValue: "2SBENlnqR76XRNAjbAs3",
                columns: new[] { "DateCreated", "TrackId" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 4, 11, 11, 39, 10, 483, DateTimeKind.Unspecified).AddTicks(1568), new TimeSpan(0, 0, 0, 0, 0)), "7a597e32-b470-496f-9694-f2652691c007" });

            migrationBuilder.UpdateData(
                schema: "Cars",
                table: "Brands",
                keyColumn: "Id",
                keyValue: "2VS5yLgAuj7VmYeRVxTD",
                columns: new[] { "DateCreated", "TrackId" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 4, 11, 11, 39, 10, 483, DateTimeKind.Unspecified).AddTicks(1574), new TimeSpan(0, 0, 0, 0, 0)), "bd3ae7dc-8552-49b1-9f90-be807f307cad" });

            migrationBuilder.UpdateData(
                schema: "Cars",
                table: "Brands",
                keyColumn: "Id",
                keyValue: "2xSRLgR4QgzYhDLjfgAM",
                columns: new[] { "DateCreated", "TrackId" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 4, 11, 11, 39, 10, 483, DateTimeKind.Unspecified).AddTicks(1580), new TimeSpan(0, 0, 0, 0, 0)), "6e552a88-cf58-4052-955a-7ea13e2fd820" });

            migrationBuilder.UpdateData(
                schema: "Cars",
                table: "Brands",
                keyColumn: "Id",
                keyValue: "3qGrKAnyJ2rmHlevXb8c",
                columns: new[] { "DateCreated", "TrackId" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 4, 11, 11, 39, 10, 483, DateTimeKind.Unspecified).AddTicks(1589), new TimeSpan(0, 0, 0, 0, 0)), "3ae92c3e-6c7b-4bb9-8a26-565f77b5957b" });

            migrationBuilder.UpdateData(
                schema: "Cars",
                table: "Brands",
                keyColumn: "Id",
                keyValue: "3yTpJND7nxjtqoDcuc5M",
                columns: new[] { "DateCreated", "TrackId" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 4, 11, 11, 39, 10, 483, DateTimeKind.Unspecified).AddTicks(1595), new TimeSpan(0, 0, 0, 0, 0)), "70f081d5-ef46-4ddc-b9aa-d98888c2c1ec" });

            migrationBuilder.UpdateData(
                schema: "Cars",
                table: "Brands",
                keyColumn: "Id",
                keyValue: "470SJrcKER8YaPHSS0br",
                columns: new[] { "DateCreated", "TrackId" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 4, 11, 11, 39, 10, 483, DateTimeKind.Unspecified).AddTicks(1601), new TimeSpan(0, 0, 0, 0, 0)), "04127e90-2366-45a6-b3fa-236bf60a4092" });

            migrationBuilder.UpdateData(
                schema: "Cars",
                table: "Brands",
                keyColumn: "Id",
                keyValue: "48xSUCHrRIfABkLmGHxD",
                columns: new[] { "DateCreated", "TrackId" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 4, 11, 11, 39, 10, 483, DateTimeKind.Unspecified).AddTicks(1608), new TimeSpan(0, 0, 0, 0, 0)), "7e78f66c-0acb-4e1a-969b-32cbc3af9533" });

            migrationBuilder.UpdateData(
                schema: "Cars",
                table: "Brands",
                keyColumn: "Id",
                keyValue: "5aFWwvagmpfBWQlHxU5M",
                columns: new[] { "DateCreated", "TrackId" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 4, 11, 11, 39, 10, 483, DateTimeKind.Unspecified).AddTicks(1634), new TimeSpan(0, 0, 0, 0, 0)), "04c66e69-12b3-4a47-ac2a-fb65ab1a16c1" });

            migrationBuilder.UpdateData(
                schema: "Cars",
                table: "Brands",
                keyColumn: "Id",
                keyValue: "5kDhCqXf6JTAIvz61oEz",
                columns: new[] { "DateCreated", "TrackId" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 4, 11, 11, 39, 10, 483, DateTimeKind.Unspecified).AddTicks(1640), new TimeSpan(0, 0, 0, 0, 0)), "f0989766-af7b-46cc-a64d-e8ac679718c9" });

            migrationBuilder.UpdateData(
                schema: "Cars",
                table: "Brands",
                keyColumn: "Id",
                keyValue: "5TgVdpBPF4SsQWVFP08j",
                columns: new[] { "DateCreated", "TrackId" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 4, 11, 11, 39, 10, 483, DateTimeKind.Unspecified).AddTicks(1646), new TimeSpan(0, 0, 0, 0, 0)), "a9b4a62f-67cb-4b1c-bec5-f69f2aecc0b3" });

            migrationBuilder.UpdateData(
                schema: "Cars",
                table: "Brands",
                keyColumn: "Id",
                keyValue: "65B72rCez5bGWR7Po3Ny",
                columns: new[] { "DateCreated", "TrackId" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 4, 11, 11, 39, 10, 483, DateTimeKind.Unspecified).AddTicks(1652), new TimeSpan(0, 0, 0, 0, 0)), "5e3d7e99-efc3-49b6-9fd2-075dcba99c33" });

            migrationBuilder.UpdateData(
                schema: "Cars",
                table: "Brands",
                keyColumn: "Id",
                keyValue: "6mI4J3fGUdG5KvEHYjqL",
                columns: new[] { "DateCreated", "TrackId" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 4, 11, 11, 39, 10, 483, DateTimeKind.Unspecified).AddTicks(1659), new TimeSpan(0, 0, 0, 0, 0)), "014f1bba-689b-4631-b156-34971e51c1cf" });

            migrationBuilder.UpdateData(
                schema: "Cars",
                table: "Brands",
                keyColumn: "Id",
                keyValue: "7ReFhJXxyx7pAkvlW1eS",
                columns: new[] { "DateCreated", "TrackId" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 4, 11, 11, 39, 10, 483, DateTimeKind.Unspecified).AddTicks(1665), new TimeSpan(0, 0, 0, 0, 0)), "384efe23-f54a-47f5-b85c-4010b4898591" });

            migrationBuilder.UpdateData(
                schema: "Cars",
                table: "Brands",
                keyColumn: "Id",
                keyValue: "8mIlNn2498yIC72vgKBK",
                columns: new[] { "DateCreated", "TrackId" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 4, 11, 11, 39, 10, 483, DateTimeKind.Unspecified).AddTicks(1671), new TimeSpan(0, 0, 0, 0, 0)), "6d9c8c32-3530-4e05-8a7e-15e2bd32d0ed" });

            migrationBuilder.UpdateData(
                schema: "Cars",
                table: "Brands",
                keyColumn: "Id",
                keyValue: "9NRn3UNnrPnf2yJoGIBH",
                columns: new[] { "DateCreated", "TrackId" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 4, 11, 11, 39, 10, 483, DateTimeKind.Unspecified).AddTicks(1677), new TimeSpan(0, 0, 0, 0, 0)), "bed4b515-ff74-48ea-93c1-9d8dbc9035e5" });

            migrationBuilder.UpdateData(
                schema: "Cars",
                table: "Brands",
                keyColumn: "Id",
                keyValue: "aPIB6410rSAP3jxueo2Y",
                columns: new[] { "DateCreated", "TrackId" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 4, 11, 11, 39, 10, 483, DateTimeKind.Unspecified).AddTicks(1682), new TimeSpan(0, 0, 0, 0, 0)), "438adcc5-97a6-44b1-bc00-589685a991ec" });

            migrationBuilder.UpdateData(
                schema: "Cars",
                table: "Brands",
                keyColumn: "Id",
                keyValue: "ATbb9NezfDxSdpBXdqd6",
                columns: new[] { "DateCreated", "TrackId" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 4, 11, 11, 39, 10, 483, DateTimeKind.Unspecified).AddTicks(1714), new TimeSpan(0, 0, 0, 0, 0)), "475b4abe-584f-48df-955c-dc7de4e16876" });

            migrationBuilder.UpdateData(
                schema: "Cars",
                table: "Brands",
                keyColumn: "Id",
                keyValue: "axxx6410rzzz3jxueox5",
                columns: new[] { "DateCreated", "TrackId" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 4, 11, 11, 39, 10, 483, DateTimeKind.Unspecified).AddTicks(1707), new TimeSpan(0, 0, 0, 0, 0)), "df6ca12a-77b6-4ed7-bbb9-f7392895b0c7" });

            migrationBuilder.UpdateData(
                schema: "Cars",
                table: "Brands",
                keyColumn: "Id",
                keyValue: "B42TXsELwNJNBewRvcu5",
                columns: new[] { "DateCreated", "TrackId" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 4, 11, 11, 39, 10, 483, DateTimeKind.Unspecified).AddTicks(1720), new TimeSpan(0, 0, 0, 0, 0)), "f0b2c686-65e1-4f7c-8a2e-0061db02d0c7" });

            migrationBuilder.UpdateData(
                schema: "Cars",
                table: "Brands",
                keyColumn: "Id",
                keyValue: "BESQA89ghmpmxnMv6lb4",
                columns: new[] { "DateCreated", "TrackId" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 4, 11, 11, 39, 10, 483, DateTimeKind.Unspecified).AddTicks(1727), new TimeSpan(0, 0, 0, 0, 0)), "5f575804-3465-4a30-b8f3-daba4c7aa885" });

            migrationBuilder.UpdateData(
                schema: "Cars",
                table: "Brands",
                keyColumn: "Id",
                keyValue: "bshsdfzU1lNaPe58k9Io",
                columns: new[] { "DateCreated", "TrackId" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 4, 11, 11, 39, 10, 483, DateTimeKind.Unspecified).AddTicks(1734), new TimeSpan(0, 0, 0, 0, 0)), "5548cc3e-221c-4fcb-af79-f84765ea6ee1" });

            migrationBuilder.UpdateData(
                schema: "Cars",
                table: "Brands",
                keyColumn: "Id",
                keyValue: "bXGDbcoVlUUFaUAeuBhU",
                columns: new[] { "DateCreated", "TrackId" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 4, 11, 11, 39, 10, 483, DateTimeKind.Unspecified).AddTicks(1740), new TimeSpan(0, 0, 0, 0, 0)), "a758278e-ba77-47fa-94d6-38e26ee89742" });

            migrationBuilder.UpdateData(
                schema: "Cars",
                table: "Brands",
                keyColumn: "Id",
                keyValue: "bymbQs0TabKzPsrN3TlL",
                columns: new[] { "DateCreated", "TrackId" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 4, 11, 11, 39, 10, 483, DateTimeKind.Unspecified).AddTicks(1746), new TimeSpan(0, 0, 0, 0, 0)), "150937c3-d252-472a-a8af-f20f44eeed9b" });

            migrationBuilder.UpdateData(
                schema: "Cars",
                table: "Brands",
                keyColumn: "Id",
                keyValue: "CDKhu32A8uPkeWM4eblC",
                columns: new[] { "DateCreated", "TrackId" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 4, 11, 11, 39, 10, 483, DateTimeKind.Unspecified).AddTicks(1752), new TimeSpan(0, 0, 0, 0, 0)), "99b279fc-0ee3-4f00-9de7-05e55deadae1" });

            migrationBuilder.UpdateData(
                schema: "Cars",
                table: "Brands",
                keyColumn: "Id",
                keyValue: "cjnwEk8Wle037jtonYsj",
                columns: new[] { "DateCreated", "TrackId" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 4, 11, 11, 39, 10, 483, DateTimeKind.Unspecified).AddTicks(1758), new TimeSpan(0, 0, 0, 0, 0)), "614c03da-03e5-45e6-ba64-fe6f7f4f94b9" });

            migrationBuilder.UpdateData(
                schema: "Cars",
                table: "Brands",
                keyColumn: "Id",
                keyValue: "cYgoBzV1QqkgGALBMqxE",
                columns: new[] { "DateCreated", "TrackId" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 4, 11, 11, 39, 10, 483, DateTimeKind.Unspecified).AddTicks(1764), new TimeSpan(0, 0, 0, 0, 0)), "5d8474c1-2819-4618-bc6e-8972b2c4c4da" });

            migrationBuilder.UpdateData(
                schema: "Cars",
                table: "Brands",
                keyColumn: "Id",
                keyValue: "cYlq5o6z4W9RcnLLB6zq",
                columns: new[] { "DateCreated", "TrackId" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 4, 11, 11, 39, 10, 483, DateTimeKind.Unspecified).AddTicks(1789), new TimeSpan(0, 0, 0, 0, 0)), "535890c0-0a36-4524-9e45-51a50ee4ef2d" });

            migrationBuilder.UpdateData(
                schema: "Cars",
                table: "Brands",
                keyColumn: "Id",
                keyValue: "D67BxpjC6stcD4YYGmdn",
                columns: new[] { "DateCreated", "TrackId" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 4, 11, 11, 39, 10, 483, DateTimeKind.Unspecified).AddTicks(1796), new TimeSpan(0, 0, 0, 0, 0)), "35064612-101e-4cc8-a4b7-5bf1b0fb3d53" });

            migrationBuilder.UpdateData(
                schema: "Cars",
                table: "Brands",
                keyColumn: "Id",
                keyValue: "D6a4Vo3VE2WzDdgA5AFo",
                columns: new[] { "DateCreated", "TrackId" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 4, 11, 11, 39, 10, 483, DateTimeKind.Unspecified).AddTicks(1802), new TimeSpan(0, 0, 0, 0, 0)), "6b4973e6-bc82-4e07-aa06-d3fa1565e30e" });

            migrationBuilder.UpdateData(
                schema: "Cars",
                table: "Brands",
                keyColumn: "Id",
                keyValue: "d6V8Py7xGhHTTVvS02QR",
                columns: new[] { "DateCreated", "TrackId" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 4, 11, 11, 39, 10, 483, DateTimeKind.Unspecified).AddTicks(1808), new TimeSpan(0, 0, 0, 0, 0)), "05eb92e7-87c2-4059-8024-80eca95ea6b8" });

            migrationBuilder.UpdateData(
                schema: "Cars",
                table: "Brands",
                keyColumn: "Id",
                keyValue: "Dfej8VedBqRvW5SVCeo3",
                columns: new[] { "DateCreated", "TrackId" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 4, 11, 11, 39, 10, 483, DateTimeKind.Unspecified).AddTicks(1814), new TimeSpan(0, 0, 0, 0, 0)), "b3a50a9b-0fd1-4dac-a637-0bca7a8dcc2e" });

            migrationBuilder.UpdateData(
                schema: "Cars",
                table: "Brands",
                keyColumn: "Id",
                keyValue: "dksqVUhgDuHJ9KJ2uqyP",
                columns: new[] { "DateCreated", "TrackId" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 4, 11, 11, 39, 10, 483, DateTimeKind.Unspecified).AddTicks(1819), new TimeSpan(0, 0, 0, 0, 0)), "45d3dba1-a4cd-4774-bd2f-62e129945b0b" });

            migrationBuilder.UpdateData(
                schema: "Cars",
                table: "Brands",
                keyColumn: "Id",
                keyValue: "DsQDYqGhCx8KL7zF4UFK",
                columns: new[] { "DateCreated", "TrackId" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 4, 11, 11, 39, 10, 483, DateTimeKind.Unspecified).AddTicks(1825), new TimeSpan(0, 0, 0, 0, 0)), "d24ab1d8-e7c3-4c3d-b12b-db9a36e4b1d3" });

            migrationBuilder.UpdateData(
                schema: "Cars",
                table: "Brands",
                keyColumn: "Id",
                keyValue: "DumA309cvKSKLalqcW6h",
                columns: new[] { "DateCreated", "TrackId" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 4, 11, 11, 39, 10, 483, DateTimeKind.Unspecified).AddTicks(1831), new TimeSpan(0, 0, 0, 0, 0)), "9e054036-7098-4897-a579-60b88590c3f4" });

            migrationBuilder.UpdateData(
                schema: "Cars",
                table: "Brands",
                keyColumn: "Id",
                keyValue: "DV94kh1MyMbGW3P4aac5",
                columns: new[] { "DateCreated", "TrackId" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 4, 11, 11, 39, 10, 483, DateTimeKind.Unspecified).AddTicks(1837), new TimeSpan(0, 0, 0, 0, 0)), "01cf0843-3408-4b5b-a954-28c9b644f02d" });

            migrationBuilder.UpdateData(
                schema: "Cars",
                table: "Brands",
                keyColumn: "Id",
                keyValue: "e7NrNKeWFc73uCAkz1Ar",
                columns: new[] { "DateCreated", "TrackId" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 4, 11, 11, 39, 10, 483, DateTimeKind.Unspecified).AddTicks(1864), new TimeSpan(0, 0, 0, 0, 0)), "a53d52ed-a6e9-40a1-9968-440676d57c7d" });

            migrationBuilder.UpdateData(
                schema: "Cars",
                table: "Brands",
                keyColumn: "Id",
                keyValue: "eF1lrB1EP63Y0DablBJF",
                columns: new[] { "DateCreated", "TrackId" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 4, 11, 11, 39, 10, 483, DateTimeKind.Unspecified).AddTicks(1870), new TimeSpan(0, 0, 0, 0, 0)), "3b5e0174-fd27-4851-89f7-cef1073232f1" });

            migrationBuilder.UpdateData(
                schema: "Cars",
                table: "Brands",
                keyColumn: "Id",
                keyValue: "EMczl7VAvCRwT3kAz4In",
                columns: new[] { "DateCreated", "TrackId" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 4, 11, 11, 39, 10, 483, DateTimeKind.Unspecified).AddTicks(1875), new TimeSpan(0, 0, 0, 0, 0)), "b3561f34-f656-4124-b36f-367090009009" });

            migrationBuilder.UpdateData(
                schema: "Cars",
                table: "Brands",
                keyColumn: "Id",
                keyValue: "emn3h8NrhdSz7ojPBV2H",
                columns: new[] { "DateCreated", "TrackId" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 4, 11, 11, 39, 10, 483, DateTimeKind.Unspecified).AddTicks(1881), new TimeSpan(0, 0, 0, 0, 0)), "91a4d394-26e5-4a5a-a959-ba20f1dd5728" });

            migrationBuilder.UpdateData(
                schema: "Cars",
                table: "Brands",
                keyColumn: "Id",
                keyValue: "etMtb4JLm7eB90mlnd72",
                columns: new[] { "DateCreated", "TrackId" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 4, 11, 11, 39, 10, 483, DateTimeKind.Unspecified).AddTicks(1886), new TimeSpan(0, 0, 0, 0, 0)), "0da68588-1702-4aa6-aee8-e3063dc56236" });

            migrationBuilder.UpdateData(
                schema: "Cars",
                table: "Brands",
                keyColumn: "Id",
                keyValue: "eUMYrz00U0nQH5KTc7uR",
                columns: new[] { "DateCreated", "TrackId" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 4, 11, 11, 39, 10, 483, DateTimeKind.Unspecified).AddTicks(1892), new TimeSpan(0, 0, 0, 0, 0)), "682525f4-b8dd-4b74-b647-3c934c36c5b4" });

            migrationBuilder.UpdateData(
                schema: "Cars",
                table: "Brands",
                keyColumn: "Id",
                keyValue: "fAVrUUNVKFbMuNlP7oUW",
                columns: new[] { "DateCreated", "TrackId" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 4, 11, 11, 39, 10, 483, DateTimeKind.Unspecified).AddTicks(1898), new TimeSpan(0, 0, 0, 0, 0)), "0b7cec9a-9c17-481b-8daa-e0a544c607e3" });

            migrationBuilder.UpdateData(
                schema: "Cars",
                table: "Brands",
                keyColumn: "Id",
                keyValue: "FcCNt3RVlzMFl9Jtw38m",
                columns: new[] { "DateCreated", "TrackId" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 4, 11, 11, 39, 10, 483, DateTimeKind.Unspecified).AddTicks(1904), new TimeSpan(0, 0, 0, 0, 0)), "181b550d-e79c-48ce-a600-b2e1057f7121" });

            migrationBuilder.UpdateData(
                schema: "Cars",
                table: "Brands",
                keyColumn: "Id",
                keyValue: "Fjw2xBL9BqCaQBzxcxDI",
                columns: new[] { "DateCreated", "TrackId" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 4, 11, 11, 39, 10, 483, DateTimeKind.Unspecified).AddTicks(1910), new TimeSpan(0, 0, 0, 0, 0)), "7ef78ea0-c693-43fa-aa16-fdd49982a0ab" });

            migrationBuilder.UpdateData(
                schema: "Cars",
                table: "Brands",
                keyColumn: "Id",
                keyValue: "FtX2HosXUQDnvSScsyP8",
                columns: new[] { "DateCreated", "TrackId" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 4, 11, 11, 39, 10, 483, DateTimeKind.Unspecified).AddTicks(1916), new TimeSpan(0, 0, 0, 0, 0)), "48ab8765-2e7a-402b-82a2-d74e3ddad981" });

            migrationBuilder.UpdateData(
                schema: "Cars",
                table: "Brands",
                keyColumn: "Id",
                keyValue: "FXHe5SU6zyIfYHPGygNC",
                columns: new[] { "DateCreated", "TrackId" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 4, 11, 11, 39, 10, 483, DateTimeKind.Unspecified).AddTicks(1965), new TimeSpan(0, 0, 0, 0, 0)), "04af6f23-1ede-4c3b-a0ca-725cec5a0f22" });

            migrationBuilder.UpdateData(
                schema: "Cars",
                table: "Brands",
                keyColumn: "Id",
                keyValue: "GBnMMAvdjskIFpKTYLb1",
                columns: new[] { "DateCreated", "TrackId" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 4, 11, 11, 39, 10, 483, DateTimeKind.Unspecified).AddTicks(1971), new TimeSpan(0, 0, 0, 0, 0)), "e87ce0bd-a6f3-4b19-b379-762a69cb7e57" });

            migrationBuilder.UpdateData(
                schema: "Cars",
                table: "Brands",
                keyColumn: "Id",
                keyValue: "ghyFhm7jzcjYDrjMVLs1",
                columns: new[] { "DateCreated", "TrackId" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 4, 11, 11, 39, 10, 483, DateTimeKind.Unspecified).AddTicks(1977), new TimeSpan(0, 0, 0, 0, 0)), "f9d3a299-ee2c-462a-a186-f72b905ec7bf" });

            migrationBuilder.UpdateData(
                schema: "Cars",
                table: "Brands",
                keyColumn: "Id",
                keyValue: "gXuBjVjveGKf3R9Kc9vE",
                columns: new[] { "DateCreated", "TrackId" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 4, 11, 11, 39, 10, 483, DateTimeKind.Unspecified).AddTicks(1983), new TimeSpan(0, 0, 0, 0, 0)), "f8d6c591-d5c3-4d0e-9b8a-3627b49d2137" });

            migrationBuilder.UpdateData(
                schema: "Cars",
                table: "Brands",
                keyColumn: "Id",
                keyValue: "h6Bfvk5LdFwXv9QzKLxU",
                columns: new[] { "DateCreated", "TrackId" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 4, 11, 11, 39, 10, 483, DateTimeKind.Unspecified).AddTicks(1989), new TimeSpan(0, 0, 0, 0, 0)), "38d3e2a0-3539-4dda-92aa-7fa9242fd69f" });

            migrationBuilder.UpdateData(
                schema: "Cars",
                table: "Brands",
                keyColumn: "Id",
                keyValue: "hajLAGmn9WWXQco4CXw1",
                columns: new[] { "DateCreated", "TrackId" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 4, 11, 11, 39, 10, 483, DateTimeKind.Unspecified).AddTicks(1995), new TimeSpan(0, 0, 0, 0, 0)), "eb0f30d8-ae4c-45e7-a7c5-e5ff90a79667" });

            migrationBuilder.UpdateData(
                schema: "Cars",
                table: "Brands",
                keyColumn: "Id",
                keyValue: "Hc1zhgoBCF1639Rp1PkY",
                columns: new[] { "DateCreated", "TrackId" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 4, 11, 11, 39, 10, 483, DateTimeKind.Unspecified).AddTicks(2003), new TimeSpan(0, 0, 0, 0, 0)), "4403e66b-2c31-49c6-a7bc-9a9678254766" });

            migrationBuilder.UpdateData(
                schema: "Cars",
                table: "Brands",
                keyColumn: "Id",
                keyValue: "HhvYG9GBNEg7RhQBIjtY",
                columns: new[] { "DateCreated", "TrackId" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 4, 11, 11, 39, 10, 483, DateTimeKind.Unspecified).AddTicks(2009), new TimeSpan(0, 0, 0, 0, 0)), "98d211ac-47f5-4d98-9c83-18a54d8c32ef" });

            migrationBuilder.UpdateData(
                schema: "Cars",
                table: "Brands",
                keyColumn: "Id",
                keyValue: "HKjqbIm3EQ96YdfpakFI",
                columns: new[] { "DateCreated", "TrackId" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 4, 11, 11, 39, 10, 483, DateTimeKind.Unspecified).AddTicks(2014), new TimeSpan(0, 0, 0, 0, 0)), "3c1ba39b-52e1-4d5e-bbe9-9f6640df22f9" });

            migrationBuilder.UpdateData(
                schema: "Cars",
                table: "Brands",
                keyColumn: "Id",
                keyValue: "HrERVHUdBMrdUrgLsvuT",
                columns: new[] { "DateCreated", "TrackId" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 4, 11, 11, 39, 10, 483, DateTimeKind.Unspecified).AddTicks(2039), new TimeSpan(0, 0, 0, 0, 0)), "96fb09e5-4678-46de-9cdf-62a7415c8073" });

            migrationBuilder.UpdateData(
                schema: "Cars",
                table: "Brands",
                keyColumn: "Id",
                keyValue: "hy7DsFSFE0ugKvGj8Hfk",
                columns: new[] { "DateCreated", "TrackId" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 4, 11, 11, 39, 10, 483, DateTimeKind.Unspecified).AddTicks(2046), new TimeSpan(0, 0, 0, 0, 0)), "6cdaae69-8c86-4942-aee9-42d216852169" });

            migrationBuilder.UpdateData(
                schema: "Cars",
                table: "Brands",
                keyColumn: "Id",
                keyValue: "IIqtbBpQcKHy7TVA10Nl",
                columns: new[] { "DateCreated", "TrackId" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 4, 11, 11, 39, 10, 483, DateTimeKind.Unspecified).AddTicks(2052), new TimeSpan(0, 0, 0, 0, 0)), "ad57ed38-630e-4048-8b77-d087146a2a6f" });

            migrationBuilder.UpdateData(
                schema: "Cars",
                table: "Brands",
                keyColumn: "Id",
                keyValue: "IR6qs66ukTVnB4w0NIFq",
                columns: new[] { "DateCreated", "TrackId" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 4, 11, 11, 39, 10, 483, DateTimeKind.Unspecified).AddTicks(2058), new TimeSpan(0, 0, 0, 0, 0)), "f6a77cc1-b304-4a85-b2f1-7bd344b5db74" });

            migrationBuilder.UpdateData(
                schema: "Cars",
                table: "Brands",
                keyColumn: "Id",
                keyValue: "j0N3jEL5HfQ9Ve0KVNUl",
                columns: new[] { "DateCreated", "TrackId" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 4, 11, 11, 39, 10, 483, DateTimeKind.Unspecified).AddTicks(2064), new TimeSpan(0, 0, 0, 0, 0)), "b6d44ca1-be36-441e-bfa4-7487b62f267d" });

            migrationBuilder.UpdateData(
                schema: "Cars",
                table: "Brands",
                keyColumn: "Id",
                keyValue: "J3wnurM4CgKVkRFfRvHs",
                columns: new[] { "DateCreated", "TrackId" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 4, 11, 11, 39, 10, 483, DateTimeKind.Unspecified).AddTicks(2071), new TimeSpan(0, 0, 0, 0, 0)), "2fae3d77-5cf5-4b3b-a8e4-b292cea7df76" });

            migrationBuilder.UpdateData(
                schema: "Cars",
                table: "Brands",
                keyColumn: "Id",
                keyValue: "JqgJmqpSsWvQ7b60GLvq",
                columns: new[] { "DateCreated", "TrackId" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 4, 11, 11, 39, 10, 483, DateTimeKind.Unspecified).AddTicks(2078), new TimeSpan(0, 0, 0, 0, 0)), "528aa2fb-a33c-49da-acbb-ed1fd1cc880b" });

            migrationBuilder.UpdateData(
                schema: "Cars",
                table: "Brands",
                keyColumn: "Id",
                keyValue: "jyCumAseWnFjQjPzn3kQ",
                columns: new[] { "DateCreated", "TrackId" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 4, 11, 11, 39, 10, 483, DateTimeKind.Unspecified).AddTicks(2084), new TimeSpan(0, 0, 0, 0, 0)), "f8891a86-2658-450e-a310-e33ab5f0fa19" });

            migrationBuilder.UpdateData(
                schema: "Cars",
                table: "Brands",
                keyColumn: "Id",
                keyValue: "k4Lylg5nrM6Vt1MrWfxS",
                columns: new[] { "DateCreated", "TrackId" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 4, 11, 11, 39, 10, 483, DateTimeKind.Unspecified).AddTicks(2090), new TimeSpan(0, 0, 0, 0, 0)), "b3a1982e-f1a7-40ca-b170-b3cfe886bebf" });

            migrationBuilder.UpdateData(
                schema: "Cars",
                table: "Brands",
                keyColumn: "Id",
                keyValue: "KCEkkBQL72L0jmEutbgl",
                columns: new[] { "DateCreated", "TrackId" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 4, 11, 11, 39, 10, 483, DateTimeKind.Unspecified).AddTicks(2096), new TimeSpan(0, 0, 0, 0, 0)), "5ef9e0e8-5f80-45e1-b349-7bb1c20ab900" });

            migrationBuilder.UpdateData(
                schema: "Cars",
                table: "Brands",
                keyColumn: "Id",
                keyValue: "kF0x9WcUJs7aHYtoKzWY",
                columns: new[] { "DateCreated", "TrackId" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 4, 11, 11, 39, 10, 483, DateTimeKind.Unspecified).AddTicks(2121), new TimeSpan(0, 0, 0, 0, 0)), "c1abb3ff-2d65-4083-afa9-870335db3bd5" });

            migrationBuilder.UpdateData(
                schema: "Cars",
                table: "Brands",
                keyColumn: "Id",
                keyValue: "KQMma7dRwtXlcym9oSWC",
                columns: new[] { "DateCreated", "TrackId" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 4, 11, 11, 39, 10, 483, DateTimeKind.Unspecified).AddTicks(2127), new TimeSpan(0, 0, 0, 0, 0)), "3b4a5023-72af-4f32-a3d8-827734c2f465" });

            migrationBuilder.UpdateData(
                schema: "Cars",
                table: "Brands",
                keyColumn: "Id",
                keyValue: "KRmmVEwPAtzSzJQgD6HY",
                columns: new[] { "DateCreated", "TrackId" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 4, 11, 11, 39, 10, 483, DateTimeKind.Unspecified).AddTicks(2133), new TimeSpan(0, 0, 0, 0, 0)), "0a99d6ad-f486-4464-8164-2b607c64ac57" });

            migrationBuilder.UpdateData(
                schema: "Cars",
                table: "Brands",
                keyColumn: "Id",
                keyValue: "KvyHwQN3QMrXmgbsvne9",
                columns: new[] { "DateCreated", "TrackId" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 4, 11, 11, 39, 10, 483, DateTimeKind.Unspecified).AddTicks(2140), new TimeSpan(0, 0, 0, 0, 0)), "d922eea7-bca3-401b-84cd-77c483395119" });

            migrationBuilder.UpdateData(
                schema: "Cars",
                table: "Brands",
                keyColumn: "Id",
                keyValue: "kXULxNaVDJWKs2ACmH5C",
                columns: new[] { "DateCreated", "TrackId" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 4, 11, 11, 39, 10, 483, DateTimeKind.Unspecified).AddTicks(2146), new TimeSpan(0, 0, 0, 0, 0)), "1a18b0e7-fa96-4443-8dc7-e19ee5b51c68" });

            migrationBuilder.UpdateData(
                schema: "Cars",
                table: "Brands",
                keyColumn: "Id",
                keyValue: "l5Xv7WgEwDFBEEnFG9uC",
                columns: new[] { "DateCreated", "TrackId" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 4, 11, 11, 39, 10, 483, DateTimeKind.Unspecified).AddTicks(2152), new TimeSpan(0, 0, 0, 0, 0)), "f6685e2c-fd2c-48b2-8e14-c13c25f37797" });

            migrationBuilder.UpdateData(
                schema: "Cars",
                table: "Brands",
                keyColumn: "Id",
                keyValue: "laJM8lrsRY8D0eRYypqk",
                columns: new[] { "DateCreated", "TrackId" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 4, 11, 11, 39, 10, 483, DateTimeKind.Unspecified).AddTicks(2158), new TimeSpan(0, 0, 0, 0, 0)), "5ae5fbfe-fcdb-4736-947d-a238a287a02d" });

            migrationBuilder.UpdateData(
                schema: "Cars",
                table: "Brands",
                keyColumn: "Id",
                keyValue: "LcuKvSewzBSW3KEJdLIa",
                columns: new[] { "DateCreated", "TrackId" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 4, 11, 11, 39, 10, 483, DateTimeKind.Unspecified).AddTicks(2163), new TimeSpan(0, 0, 0, 0, 0)), "0008c25a-423f-491f-bb3d-f369077f2a54" });

            migrationBuilder.UpdateData(
                schema: "Cars",
                table: "Brands",
                keyColumn: "Id",
                keyValue: "lEVEcrE9FIVtGbtFarHV",
                columns: new[] { "DateCreated", "TrackId" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 4, 11, 11, 39, 10, 483, DateTimeKind.Unspecified).AddTicks(2169), new TimeSpan(0, 0, 0, 0, 0)), "79e3c487-34ce-422e-9b9f-3352795896c4" });

            migrationBuilder.UpdateData(
                schema: "Cars",
                table: "Brands",
                keyColumn: "Id",
                keyValue: "lgRSEHsdarS0gC4osQWQ",
                columns: new[] { "DateCreated", "TrackId" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 4, 11, 11, 39, 10, 483, DateTimeKind.Unspecified).AddTicks(2194), new TimeSpan(0, 0, 0, 0, 0)), "b81665ca-2037-4d77-a284-b133166bead3" });

            migrationBuilder.UpdateData(
                schema: "Cars",
                table: "Brands",
                keyColumn: "Id",
                keyValue: "Lxge9Bn07u7pWE0RqbwJ",
                columns: new[] { "DateCreated", "TrackId" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 4, 11, 11, 39, 10, 483, DateTimeKind.Unspecified).AddTicks(2200), new TimeSpan(0, 0, 0, 0, 0)), "582b70bf-36fa-429e-af11-cef21ecc4dae" });

            migrationBuilder.UpdateData(
                schema: "Cars",
                table: "Brands",
                keyColumn: "Id",
                keyValue: "m5L90Q8l2fTcbPyeA3GF",
                columns: new[] { "DateCreated", "TrackId" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 4, 11, 11, 39, 10, 483, DateTimeKind.Unspecified).AddTicks(2208), new TimeSpan(0, 0, 0, 0, 0)), "a9fcf7ae-d586-4f53-a4d6-961b38381525" });

            migrationBuilder.UpdateData(
                schema: "Cars",
                table: "Brands",
                keyColumn: "Id",
                keyValue: "mEjXfYc5wzIHYnGGpCbE",
                columns: new[] { "DateCreated", "TrackId" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 4, 11, 11, 39, 10, 483, DateTimeKind.Unspecified).AddTicks(2213), new TimeSpan(0, 0, 0, 0, 0)), "b4abc724-a3b0-4cb0-8fa0-072406a352b2" });

            migrationBuilder.UpdateData(
                schema: "Cars",
                table: "Brands",
                keyColumn: "Id",
                keyValue: "MlFe1uw8xqqhdAUnqcHd",
                columns: new[] { "DateCreated", "TrackId" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 4, 11, 11, 39, 10, 483, DateTimeKind.Unspecified).AddTicks(2220), new TimeSpan(0, 0, 0, 0, 0)), "cb104b6e-a1c2-42e9-a945-ff95c9f4f8bd" });

            migrationBuilder.UpdateData(
                schema: "Cars",
                table: "Brands",
                keyColumn: "Id",
                keyValue: "MvMqrrJaUbAAVIvJHQcu",
                columns: new[] { "DateCreated", "TrackId" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 4, 11, 11, 39, 10, 483, DateTimeKind.Unspecified).AddTicks(2226), new TimeSpan(0, 0, 0, 0, 0)), "35b14341-233f-4432-abe8-9fae7d165338" });

            migrationBuilder.UpdateData(
                schema: "Cars",
                table: "Brands",
                keyColumn: "Id",
                keyValue: "MX3aL9JN6gD0F4KRl0Nq",
                columns: new[] { "DateCreated", "TrackId" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 4, 11, 11, 39, 10, 483, DateTimeKind.Unspecified).AddTicks(2232), new TimeSpan(0, 0, 0, 0, 0)), "bfd15460-82b8-4003-9b17-8bb3254ceef9" });

            migrationBuilder.UpdateData(
                schema: "Cars",
                table: "Brands",
                keyColumn: "Id",
                keyValue: "n1jg2wtcteSRvhvMGm4n",
                columns: new[] { "DateCreated", "TrackId" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 4, 11, 11, 39, 10, 483, DateTimeKind.Unspecified).AddTicks(2238), new TimeSpan(0, 0, 0, 0, 0)), "1172857f-69e7-4dfc-84fb-4c35e7125c78" });

            migrationBuilder.UpdateData(
                schema: "Cars",
                table: "Brands",
                keyColumn: "Id",
                keyValue: "nDxKpo5IAKk62ekEBbNS",
                columns: new[] { "DateCreated", "TrackId" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 4, 11, 11, 39, 10, 483, DateTimeKind.Unspecified).AddTicks(2244), new TimeSpan(0, 0, 0, 0, 0)), "adb188dd-233b-4ec5-bc10-9b7798585b6c" });

            migrationBuilder.UpdateData(
                schema: "Cars",
                table: "Brands",
                keyColumn: "Id",
                keyValue: "nm2AJSoa0dWnayDNBRnh",
                columns: new[] { "DateCreated", "TrackId" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 4, 11, 11, 39, 10, 483, DateTimeKind.Unspecified).AddTicks(2250), new TimeSpan(0, 0, 0, 0, 0)), "39e36b9b-f73b-49a2-8cb3-eac2907d4133" });

            migrationBuilder.UpdateData(
                schema: "Cars",
                table: "Brands",
                keyColumn: "Id",
                keyValue: "nsITvMBs2Ujtv8rQ0KJM",
                columns: new[] { "DateCreated", "TrackId" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 4, 11, 11, 39, 10, 483, DateTimeKind.Unspecified).AddTicks(2278), new TimeSpan(0, 0, 0, 0, 0)), "578b2268-c571-43f5-8cd2-813fb826c1ba" });

            migrationBuilder.UpdateData(
                schema: "Cars",
                table: "Brands",
                keyColumn: "Id",
                keyValue: "nul5YjFdxToWeg1GrlCX",
                columns: new[] { "DateCreated", "TrackId" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 4, 11, 11, 39, 10, 483, DateTimeKind.Unspecified).AddTicks(2285), new TimeSpan(0, 0, 0, 0, 0)), "587c1869-e3bd-4559-9121-d2f2c1c8fc19" });

            migrationBuilder.UpdateData(
                schema: "Cars",
                table: "Brands",
                keyColumn: "Id",
                keyValue: "nWD6UJdXnV7cjq8tP6R8",
                columns: new[] { "DateCreated", "TrackId" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 4, 11, 11, 39, 10, 483, DateTimeKind.Unspecified).AddTicks(2290), new TimeSpan(0, 0, 0, 0, 0)), "5ed9191a-8afc-4804-9fc9-17f014dc880d" });

            migrationBuilder.UpdateData(
                schema: "Cars",
                table: "Brands",
                keyColumn: "Id",
                keyValue: "oyETMjvBlpVLEDFlVADI",
                columns: new[] { "DateCreated", "TrackId" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 4, 11, 11, 39, 10, 483, DateTimeKind.Unspecified).AddTicks(2296), new TimeSpan(0, 0, 0, 0, 0)), "ff78ffa1-8df6-4f29-aced-d626e60f7eef" });

            migrationBuilder.UpdateData(
                schema: "Cars",
                table: "Brands",
                keyColumn: "Id",
                keyValue: "p4hD4RsKIPD68JMtt4N2",
                columns: new[] { "DateCreated", "TrackId" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 4, 11, 11, 39, 10, 483, DateTimeKind.Unspecified).AddTicks(2301), new TimeSpan(0, 0, 0, 0, 0)), "8bded3b6-86cb-431a-8d22-580b01a20dc3" });

            migrationBuilder.UpdateData(
                schema: "Cars",
                table: "Brands",
                keyColumn: "Id",
                keyValue: "p6Wbw5sW2Fj67lvp482v",
                columns: new[] { "DateCreated", "TrackId" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 4, 11, 11, 39, 10, 483, DateTimeKind.Unspecified).AddTicks(2307), new TimeSpan(0, 0, 0, 0, 0)), "b21bb008-31e2-473f-beb0-a52ea30f660b" });

            migrationBuilder.UpdateData(
                schema: "Cars",
                table: "Brands",
                keyColumn: "Id",
                keyValue: "pjQ5tv7x5L1UYaKzhokc",
                columns: new[] { "DateCreated", "TrackId" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 4, 11, 11, 39, 10, 483, DateTimeKind.Unspecified).AddTicks(2318), new TimeSpan(0, 0, 0, 0, 0)), "033f3579-9f11-493c-b84f-ce50c755ca14" });

            migrationBuilder.UpdateData(
                schema: "Cars",
                table: "Brands",
                keyColumn: "Id",
                keyValue: "PpQFVF4cAQlfX3BppjFB",
                columns: new[] { "DateCreated", "TrackId" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 4, 11, 11, 39, 10, 483, DateTimeKind.Unspecified).AddTicks(2325), new TimeSpan(0, 0, 0, 0, 0)), "ec5074d5-0805-41b5-a525-8856e762c9de" });

            migrationBuilder.UpdateData(
                schema: "Cars",
                table: "Brands",
                keyColumn: "Id",
                keyValue: "PsbTIAKWHCVgruG7IgRE",
                columns: new[] { "DateCreated", "TrackId" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 4, 11, 11, 39, 10, 483, DateTimeKind.Unspecified).AddTicks(2331), new TimeSpan(0, 0, 0, 0, 0)), "a6ff6581-a39c-4c7c-abbb-442cc840144d" });

            migrationBuilder.UpdateData(
                schema: "Cars",
                table: "Brands",
                keyColumn: "Id",
                keyValue: "pTCUtnhqCmkJALgYU8NY",
                columns: new[] { "DateCreated", "TrackId" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 4, 11, 11, 39, 10, 483, DateTimeKind.Unspecified).AddTicks(2357), new TimeSpan(0, 0, 0, 0, 0)), "f1aac24f-6707-4956-9bb5-c57ebbc0ae36" });

            migrationBuilder.UpdateData(
                schema: "Cars",
                table: "Brands",
                keyColumn: "Id",
                keyValue: "Q6kJ5uDgBmklCCBwofrx",
                columns: new[] { "DateCreated", "TrackId" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 4, 11, 11, 39, 10, 483, DateTimeKind.Unspecified).AddTicks(2363), new TimeSpan(0, 0, 0, 0, 0)), "b0ae9b5e-b2b6-4d59-8fcf-1a4ee5e89ac4" });

            migrationBuilder.UpdateData(
                schema: "Cars",
                table: "Brands",
                keyColumn: "Id",
                keyValue: "QExc6n8HRxp39gGTKXSt",
                columns: new[] { "DateCreated", "TrackId" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 4, 11, 11, 39, 10, 483, DateTimeKind.Unspecified).AddTicks(2369), new TimeSpan(0, 0, 0, 0, 0)), "e35fa325-35b4-4e6a-bc31-81ee21f0cb5d" });

            migrationBuilder.UpdateData(
                schema: "Cars",
                table: "Brands",
                keyColumn: "Id",
                keyValue: "qnkV2dT7G6arP780Dwxs",
                columns: new[] { "DateCreated", "TrackId" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 4, 11, 11, 39, 10, 483, DateTimeKind.Unspecified).AddTicks(2375), new TimeSpan(0, 0, 0, 0, 0)), "3c6eb05d-d9f0-496a-aa8d-67ef509c61cd" });

            migrationBuilder.UpdateData(
                schema: "Cars",
                table: "Brands",
                keyColumn: "Id",
                keyValue: "QojugShL0F4QRXbwv1r3",
                columns: new[] { "DateCreated", "TrackId" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 4, 11, 11, 39, 10, 483, DateTimeKind.Unspecified).AddTicks(2380), new TimeSpan(0, 0, 0, 0, 0)), "f311dfd1-8b2c-4ba7-a708-833591b2bfd9" });

            migrationBuilder.UpdateData(
                schema: "Cars",
                table: "Brands",
                keyColumn: "Id",
                keyValue: "QS0jwSg5owyS3XS5xnbY",
                columns: new[] { "DateCreated", "TrackId" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 4, 11, 11, 39, 10, 483, DateTimeKind.Unspecified).AddTicks(2386), new TimeSpan(0, 0, 0, 0, 0)), "b585460f-02c6-49aa-9303-bc0e1199db3e" });

            migrationBuilder.UpdateData(
                schema: "Cars",
                table: "Brands",
                keyColumn: "Id",
                keyValue: "R0e7DzoQBFL5UIyTpqDP",
                columns: new[] { "DateCreated", "TrackId" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 4, 11, 11, 39, 10, 483, DateTimeKind.Unspecified).AddTicks(2392), new TimeSpan(0, 0, 0, 0, 0)), "7ffa4be1-50b2-4c83-b429-5fbdddaaa549" });

            migrationBuilder.UpdateData(
                schema: "Cars",
                table: "Brands",
                keyColumn: "Id",
                keyValue: "R9BIHlzCwb67GPT89e7F",
                columns: new[] { "DateCreated", "TrackId" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 4, 11, 11, 39, 10, 483, DateTimeKind.Unspecified).AddTicks(2398), new TimeSpan(0, 0, 0, 0, 0)), "08a27aa7-32e8-4034-833c-44e6ddd9d344" });

            migrationBuilder.UpdateData(
                schema: "Cars",
                table: "Brands",
                keyColumn: "Id",
                keyValue: "RgqbbBCJaJLWTlu87M9R",
                columns: new[] { "DateCreated", "TrackId" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 4, 11, 11, 39, 10, 483, DateTimeKind.Unspecified).AddTicks(2404), new TimeSpan(0, 0, 0, 0, 0)), "af460956-9250-4a8a-899d-2b909e32446c" });

            migrationBuilder.UpdateData(
                schema: "Cars",
                table: "Brands",
                keyColumn: "Id",
                keyValue: "RRr4RDrnqyqmT3ehdy6Q",
                columns: new[] { "DateCreated", "TrackId" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 4, 11, 11, 39, 10, 483, DateTimeKind.Unspecified).AddTicks(2430), new TimeSpan(0, 0, 0, 0, 0)), "e5839907-42a1-4f30-b6e9-dbacb7c1bfa4" });

            migrationBuilder.UpdateData(
                schema: "Cars",
                table: "Brands",
                keyColumn: "Id",
                keyValue: "RuSMmRIATbwWRYSkgIrH",
                columns: new[] { "DateCreated", "TrackId" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 4, 11, 11, 39, 10, 483, DateTimeKind.Unspecified).AddTicks(2436), new TimeSpan(0, 0, 0, 0, 0)), "ce153838-1f03-4b4a-87b3-21c28fb54e08" });

            migrationBuilder.UpdateData(
                schema: "Cars",
                table: "Brands",
                keyColumn: "Id",
                keyValue: "rYJp3Jg61wKdUqFGSAp3",
                columns: new[] { "DateCreated", "TrackId" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 4, 11, 11, 39, 10, 483, DateTimeKind.Unspecified).AddTicks(2442), new TimeSpan(0, 0, 0, 0, 0)), "bbbeece3-8d44-44c9-a93b-57cb2ad256f1" });

            migrationBuilder.UpdateData(
                schema: "Cars",
                table: "Brands",
                keyColumn: "Id",
                keyValue: "sAKTDDgl9EDeyYnG77R8",
                columns: new[] { "DateCreated", "TrackId" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 4, 11, 11, 39, 10, 483, DateTimeKind.Unspecified).AddTicks(2448), new TimeSpan(0, 0, 0, 0, 0)), "b645f7ce-63ce-4cb0-8c87-201ad505a7d7" });

            migrationBuilder.UpdateData(
                schema: "Cars",
                table: "Brands",
                keyColumn: "Id",
                keyValue: "SGKURGhEbYHIdqkxpDJh",
                columns: new[] { "DateCreated", "TrackId" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 4, 11, 11, 39, 10, 483, DateTimeKind.Unspecified).AddTicks(2454), new TimeSpan(0, 0, 0, 0, 0)), "0974b548-dd3e-4f33-bf3a-5a4f7e94ea74" });

            migrationBuilder.UpdateData(
                schema: "Cars",
                table: "Brands",
                keyColumn: "Id",
                keyValue: "Sn4CRrl6hfVTTra5B0pd",
                columns: new[] { "DateCreated", "TrackId" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 4, 11, 11, 39, 10, 483, DateTimeKind.Unspecified).AddTicks(2461), new TimeSpan(0, 0, 0, 0, 0)), "90958ad0-6376-46b7-a3ff-57eb61f9043c" });

            migrationBuilder.UpdateData(
                schema: "Cars",
                table: "Brands",
                keyColumn: "Id",
                keyValue: "sQ5C4f7H60rzJLhMA0T5",
                columns: new[] { "DateCreated", "TrackId" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 4, 11, 11, 39, 10, 483, DateTimeKind.Unspecified).AddTicks(2467), new TimeSpan(0, 0, 0, 0, 0)), "dd234279-a031-4fa8-941f-ead14637709f" });

            migrationBuilder.UpdateData(
                schema: "Cars",
                table: "Brands",
                keyColumn: "Id",
                keyValue: "sSh78RpjbHGvjL43TzMl",
                columns: new[] { "DateCreated", "TrackId" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 4, 11, 11, 39, 10, 483, DateTimeKind.Unspecified).AddTicks(2473), new TimeSpan(0, 0, 0, 0, 0)), "c59178ff-0047-4b66-ae51-60dcd1503a3f" });

            migrationBuilder.UpdateData(
                schema: "Cars",
                table: "Brands",
                keyColumn: "Id",
                keyValue: "Sw3e46nyzgd7zmMPVG4r",
                columns: new[] { "DateCreated", "TrackId" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 4, 11, 11, 39, 10, 483, DateTimeKind.Unspecified).AddTicks(2480), new TimeSpan(0, 0, 0, 0, 0)), "0dc06a3c-02af-42b1-9de8-af6bd53752f3" });

            migrationBuilder.UpdateData(
                schema: "Cars",
                table: "Brands",
                keyColumn: "Id",
                keyValue: "sx9Vqv3yxRnX4SGwQa4y",
                columns: new[] { "DateCreated", "TrackId" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 4, 11, 11, 39, 10, 483, DateTimeKind.Unspecified).AddTicks(2486), new TimeSpan(0, 0, 0, 0, 0)), "f2e3fb5a-80bc-41ee-8404-1e1ec52c4b11" });

            migrationBuilder.UpdateData(
                schema: "Cars",
                table: "Brands",
                keyColumn: "Id",
                keyValue: "T8karRTfSTcM29oupBnt",
                columns: new[] { "DateCreated", "TrackId" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 4, 11, 11, 39, 10, 483, DateTimeKind.Unspecified).AddTicks(2512), new TimeSpan(0, 0, 0, 0, 0)), "3a2cdee1-8c7f-4fba-ac81-7009b10af531" });

            migrationBuilder.UpdateData(
                schema: "Cars",
                table: "Brands",
                keyColumn: "Id",
                keyValue: "t9gPoXWQAlKYkzxc7EaK",
                columns: new[] { "DateCreated", "TrackId" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 4, 11, 11, 39, 10, 483, DateTimeKind.Unspecified).AddTicks(2518), new TimeSpan(0, 0, 0, 0, 0)), "9a8bc60a-47f5-4b68-9b76-675346fb0634" });

            migrationBuilder.UpdateData(
                schema: "Cars",
                table: "Brands",
                keyColumn: "Id",
                keyValue: "TjjXJlSeru5Ccm3G2Vet",
                columns: new[] { "DateCreated", "TrackId" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 4, 11, 11, 39, 10, 483, DateTimeKind.Unspecified).AddTicks(2524), new TimeSpan(0, 0, 0, 0, 0)), "bbf40a8c-e4e7-4783-9bfb-4165cd1fce03" });

            migrationBuilder.UpdateData(
                schema: "Cars",
                table: "Brands",
                keyColumn: "Id",
                keyValue: "TJTAqICS7fjRu8I4afxm",
                columns: new[] { "DateCreated", "TrackId" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 4, 11, 11, 39, 10, 483, DateTimeKind.Unspecified).AddTicks(2531), new TimeSpan(0, 0, 0, 0, 0)), "a29ff7bd-111c-4887-b3d3-14fc0fda78ec" });

            migrationBuilder.UpdateData(
                schema: "Cars",
                table: "Brands",
                keyColumn: "Id",
                keyValue: "Tuaz0kuNQvU5jsy459u2",
                columns: new[] { "DateCreated", "TrackId" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 4, 11, 11, 39, 10, 483, DateTimeKind.Unspecified).AddTicks(2537), new TimeSpan(0, 0, 0, 0, 0)), "b370c4f4-72cf-41e4-8ad4-d3154eb4bcd5" });

            migrationBuilder.UpdateData(
                schema: "Cars",
                table: "Brands",
                keyColumn: "Id",
                keyValue: "TXVRNj5SbqClTvNfEI8c",
                columns: new[] { "DateCreated", "TrackId" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 4, 11, 11, 39, 10, 483, DateTimeKind.Unspecified).AddTicks(2543), new TimeSpan(0, 0, 0, 0, 0)), "211cf60e-7258-4196-8da2-4a7ccaa3eb8c" });

            migrationBuilder.UpdateData(
                schema: "Cars",
                table: "Brands",
                keyColumn: "Id",
                keyValue: "u3lzgWdKo9KaByo34lmN",
                columns: new[] { "DateCreated", "TrackId" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 4, 11, 11, 39, 10, 483, DateTimeKind.Unspecified).AddTicks(2549), new TimeSpan(0, 0, 0, 0, 0)), "c4cff672-ab6a-4ed1-8eec-ef8c233d6df9" });

            migrationBuilder.UpdateData(
                schema: "Cars",
                table: "Brands",
                keyColumn: "Id",
                keyValue: "UG6N8tBL4hpBPkjX12Bh",
                columns: new[] { "DateCreated", "TrackId" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 4, 11, 11, 39, 10, 483, DateTimeKind.Unspecified).AddTicks(2555), new TimeSpan(0, 0, 0, 0, 0)), "76c69faf-5530-4204-94c7-d5b99da06151" });

            migrationBuilder.UpdateData(
                schema: "Cars",
                table: "Brands",
                keyColumn: "Id",
                keyValue: "ulCdKx22IbD50hbfYtIE",
                columns: new[] { "DateCreated", "TrackId" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 4, 11, 11, 39, 10, 483, DateTimeKind.Unspecified).AddTicks(2561), new TimeSpan(0, 0, 0, 0, 0)), "12f27716-0073-46c4-9f42-fa155e2cf5c4" });

            migrationBuilder.UpdateData(
                schema: "Cars",
                table: "Brands",
                keyColumn: "Id",
                keyValue: "UpE1pLHfAgAQDHEVWdAb",
                columns: new[] { "DateCreated", "TrackId" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 4, 11, 11, 39, 10, 483, DateTimeKind.Unspecified).AddTicks(2618), new TimeSpan(0, 0, 0, 0, 0)), "5f149bbf-0fa2-4ec1-a070-915b1b1c7537" });

            migrationBuilder.UpdateData(
                schema: "Cars",
                table: "Brands",
                keyColumn: "Id",
                keyValue: "UpsGGKBQ2fXfNQBgABoF",
                columns: new[] { "DateCreated", "TrackId" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 4, 11, 11, 39, 10, 483, DateTimeKind.Unspecified).AddTicks(2626), new TimeSpan(0, 0, 0, 0, 0)), "149ae45c-a889-468d-b8be-c1e2e2d46d29" });

            migrationBuilder.UpdateData(
                schema: "Cars",
                table: "Brands",
                keyColumn: "Id",
                keyValue: "v1Q2gNvx2B1YX6h2w0TR",
                columns: new[] { "DateCreated", "TrackId" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 4, 11, 11, 39, 10, 483, DateTimeKind.Unspecified).AddTicks(2633), new TimeSpan(0, 0, 0, 0, 0)), "e268760a-0f86-46d3-9a71-b312152bfb3c" });

            migrationBuilder.UpdateData(
                schema: "Cars",
                table: "Brands",
                keyColumn: "Id",
                keyValue: "v4vruTNk6WkdcxN3fFA0",
                columns: new[] { "DateCreated", "TrackId" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 4, 11, 11, 39, 10, 483, DateTimeKind.Unspecified).AddTicks(2639), new TimeSpan(0, 0, 0, 0, 0)), "4c2ef603-0737-48f6-9f74-1a4e17b1941a" });

            migrationBuilder.UpdateData(
                schema: "Cars",
                table: "Brands",
                keyColumn: "Id",
                keyValue: "V9HWmNFfpUS2Y5eLqrct",
                columns: new[] { "DateCreated", "TrackId" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 4, 11, 11, 39, 10, 483, DateTimeKind.Unspecified).AddTicks(2645), new TimeSpan(0, 0, 0, 0, 0)), "a7de5afa-0142-4aae-bdf3-a61a0170d6e2" });

            migrationBuilder.UpdateData(
                schema: "Cars",
                table: "Brands",
                keyColumn: "Id",
                keyValue: "vMFor3Ks1QECjDpWHUqW",
                columns: new[] { "DateCreated", "TrackId" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 4, 11, 11, 39, 10, 483, DateTimeKind.Unspecified).AddTicks(2651), new TimeSpan(0, 0, 0, 0, 0)), "4eafcf36-293a-441b-a131-0f57b0d02786" });

            migrationBuilder.UpdateData(
                schema: "Cars",
                table: "Brands",
                keyColumn: "Id",
                keyValue: "vYf86TFDqUkh9RcEN9VN",
                columns: new[] { "DateCreated", "TrackId" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 4, 11, 11, 39, 10, 483, DateTimeKind.Unspecified).AddTicks(2695), new TimeSpan(0, 0, 0, 0, 0)), "d3de8542-24fa-419f-bc17-52c3fe9138c6" });

            migrationBuilder.UpdateData(
                schema: "Cars",
                table: "Brands",
                keyColumn: "Id",
                keyValue: "W5TnArCA9xCEodsTpDHG",
                columns: new[] { "DateCreated", "TrackId" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 4, 11, 11, 39, 10, 483, DateTimeKind.Unspecified).AddTicks(2706), new TimeSpan(0, 0, 0, 0, 0)), "bb7fa238-1428-4f31-bd79-3f9f300181ea" });

            migrationBuilder.UpdateData(
                schema: "Cars",
                table: "Brands",
                keyColumn: "Id",
                keyValue: "wC0Q8eUqQLkE6cpVwHgu",
                columns: new[] { "DateCreated", "TrackId" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 4, 11, 11, 39, 10, 483, DateTimeKind.Unspecified).AddTicks(2716), new TimeSpan(0, 0, 0, 0, 0)), "15d7e7ba-bd1b-46fd-b015-7bc3edcd4f85" });

            migrationBuilder.UpdateData(
                schema: "Cars",
                table: "Brands",
                keyColumn: "Id",
                keyValue: "wDseIgWSpqkLesX2ftwn",
                columns: new[] { "DateCreated", "TrackId" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 4, 11, 11, 39, 10, 483, DateTimeKind.Unspecified).AddTicks(2727), new TimeSpan(0, 0, 0, 0, 0)), "9ff2626c-40ed-48c3-bd29-78644037b468" });

            migrationBuilder.UpdateData(
                schema: "Cars",
                table: "Brands",
                keyColumn: "Id",
                keyValue: "whPfE6p1LaKgaGTWoNqj",
                columns: new[] { "DateCreated", "TrackId" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 4, 11, 11, 39, 10, 483, DateTimeKind.Unspecified).AddTicks(2776), new TimeSpan(0, 0, 0, 0, 0)), "4dbe7862-b7b7-4660-ab6f-41c4787ac6fa" });

            migrationBuilder.UpdateData(
                schema: "Cars",
                table: "Brands",
                keyColumn: "Id",
                keyValue: "wMQSzkfJzJhYwfV22Ew6",
                columns: new[] { "DateCreated", "TrackId" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 4, 11, 11, 39, 10, 483, DateTimeKind.Unspecified).AddTicks(2787), new TimeSpan(0, 0, 0, 0, 0)), "cd57f091-5d6a-44c8-acb9-764fa6de2a5f" });

            migrationBuilder.UpdateData(
                schema: "Cars",
                table: "Brands",
                keyColumn: "Id",
                keyValue: "wwSqJWvMPuau2LBxW24w",
                columns: new[] { "DateCreated", "TrackId" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 4, 11, 11, 39, 10, 483, DateTimeKind.Unspecified).AddTicks(2794), new TimeSpan(0, 0, 0, 0, 0)), "9d5b00fb-f959-49b1-a95e-ba154036c0ff" });

            migrationBuilder.UpdateData(
                schema: "Cars",
                table: "Brands",
                keyColumn: "Id",
                keyValue: "XECbl6phGcsYXQWHwrT7",
                columns: new[] { "DateCreated", "TrackId" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 4, 11, 11, 39, 10, 483, DateTimeKind.Unspecified).AddTicks(2800), new TimeSpan(0, 0, 0, 0, 0)), "a834eb07-6368-41ab-935d-e320ccf511fa" });

            migrationBuilder.UpdateData(
                schema: "Cars",
                table: "Brands",
                keyColumn: "Id",
                keyValue: "xHqKd4nN6cMLEAaL4zdp",
                columns: new[] { "DateCreated", "TrackId" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 4, 11, 11, 39, 10, 483, DateTimeKind.Unspecified).AddTicks(2806), new TimeSpan(0, 0, 0, 0, 0)), "7d81753d-cfa4-4708-9560-37361429504e" });

            migrationBuilder.UpdateData(
                schema: "Cars",
                table: "Brands",
                keyColumn: "Id",
                keyValue: "XQ0Nk2N0zDYDydY9CEpC",
                columns: new[] { "DateCreated", "TrackId" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 4, 11, 11, 39, 10, 483, DateTimeKind.Unspecified).AddTicks(2812), new TimeSpan(0, 0, 0, 0, 0)), "7f147574-5916-47ac-a0a4-2d8d65a2048e" });

            migrationBuilder.UpdateData(
                schema: "Cars",
                table: "Brands",
                keyColumn: "Id",
                keyValue: "xqP1xuan2MoXnMkwolM7",
                columns: new[] { "DateCreated", "TrackId" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 4, 11, 11, 39, 10, 483, DateTimeKind.Unspecified).AddTicks(2817), new TimeSpan(0, 0, 0, 0, 0)), "0670aece-332e-40e1-aaaf-a227ed8a0fb9" });

            migrationBuilder.UpdateData(
                schema: "Cars",
                table: "Brands",
                keyColumn: "Id",
                keyValue: "Xsx7AcUNguMUYwC2eInr",
                columns: new[] { "DateCreated", "TrackId" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 4, 11, 11, 39, 10, 483, DateTimeKind.Unspecified).AddTicks(2823), new TimeSpan(0, 0, 0, 0, 0)), "54c5b627-c302-4632-8ff2-92bea7cda33d" });

            migrationBuilder.UpdateData(
                schema: "Cars",
                table: "Brands",
                keyColumn: "Id",
                keyValue: "XW7Xpw80z3VgX82egcWN",
                columns: new[] { "DateCreated", "TrackId" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 4, 11, 11, 39, 10, 483, DateTimeKind.Unspecified).AddTicks(2830), new TimeSpan(0, 0, 0, 0, 0)), "c50d072a-d73c-497c-bbd8-fd48fb395d10" });

            migrationBuilder.UpdateData(
                schema: "Cars",
                table: "Brands",
                keyColumn: "Id",
                keyValue: "Xz43eo1VM5H41uNJ9x28",
                columns: new[] { "DateCreated", "TrackId" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 4, 11, 11, 39, 10, 483, DateTimeKind.Unspecified).AddTicks(2858), new TimeSpan(0, 0, 0, 0, 0)), "e3ded5f9-447e-4ded-a96d-eb8af7295104" });

            migrationBuilder.UpdateData(
                schema: "Cars",
                table: "Brands",
                keyColumn: "Id",
                keyValue: "yjnmBGS0tfeUY6wppqlL",
                columns: new[] { "DateCreated", "TrackId" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 4, 11, 11, 39, 10, 483, DateTimeKind.Unspecified).AddTicks(2864), new TimeSpan(0, 0, 0, 0, 0)), "6cadc2f9-2a70-4664-9155-0435b5d58328" });

            migrationBuilder.UpdateData(
                schema: "Cars",
                table: "Brands",
                keyColumn: "Id",
                keyValue: "YK3JYVEmHcskgB4f1s9M",
                columns: new[] { "DateCreated", "TrackId" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 4, 11, 11, 39, 10, 483, DateTimeKind.Unspecified).AddTicks(2871), new TimeSpan(0, 0, 0, 0, 0)), "a1758a29-8469-4075-b230-83b00b5304aa" });

            migrationBuilder.UpdateData(
                schema: "Cars",
                table: "Brands",
                keyColumn: "Id",
                keyValue: "YK3zzVEmH55kg41f1s2M",
                columns: new[] { "DateCreated", "TrackId" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 4, 11, 11, 39, 10, 483, DateTimeKind.Unspecified).AddTicks(2877), new TimeSpan(0, 0, 0, 0, 0)), "e79c4634-b160-43ef-b4de-b33616e73f6c" });

            migrationBuilder.UpdateData(
                schema: "Cars",
                table: "Brands",
                keyColumn: "Id",
                keyValue: "yL0kvEf81nf8Sd7CGQys",
                columns: new[] { "DateCreated", "TrackId" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 4, 11, 11, 39, 10, 483, DateTimeKind.Unspecified).AddTicks(2883), new TimeSpan(0, 0, 0, 0, 0)), "59ed6440-46b7-404d-b45c-bc6cd8eb1be8" });

            migrationBuilder.UpdateData(
                schema: "Cars",
                table: "Brands",
                keyColumn: "Id",
                keyValue: "YSHfWTR5rJ8vCR2S95xp",
                columns: new[] { "DateCreated", "TrackId" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 4, 11, 11, 39, 10, 483, DateTimeKind.Unspecified).AddTicks(2888), new TimeSpan(0, 0, 0, 0, 0)), "9ddbe1d2-e510-4725-9c64-b76c1d39de6a" });

            migrationBuilder.UpdateData(
                schema: "Cars",
                table: "Brands",
                keyColumn: "Id",
                keyValue: "YUWNuWGy76j0cK9LWTP8",
                columns: new[] { "DateCreated", "TrackId" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 4, 11, 11, 39, 10, 483, DateTimeKind.Unspecified).AddTicks(2893), new TimeSpan(0, 0, 0, 0, 0)), "8fe5e077-6800-4916-971a-1853d73520f6" });

            migrationBuilder.UpdateData(
                schema: "Cars",
                table: "Brands",
                keyColumn: "Id",
                keyValue: "zlaX6newWoQPagELHC4J",
                columns: new[] { "DateCreated", "TrackId" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 4, 11, 11, 39, 10, 483, DateTimeKind.Unspecified).AddTicks(2901), new TimeSpan(0, 0, 0, 0, 0)), "357bf660-2517-460e-a74d-4f49ab97aae0" });

            migrationBuilder.UpdateData(
                schema: "Cars",
                table: "Brands",
                keyColumn: "Id",
                keyValue: "zmtbQwqcCyHjrSKk77Se",
                columns: new[] { "DateCreated", "TrackId" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 4, 11, 11, 39, 10, 483, DateTimeKind.Unspecified).AddTicks(2906), new TimeSpan(0, 0, 0, 0, 0)), "a0700ee7-38ea-4c57-9e9a-86cc0a254a75" });

            migrationBuilder.UpdateData(
                schema: "Cars",
                table: "Brands",
                keyColumn: "Id",
                keyValue: "zpPwsvLWKJ4CmjHmU1ES",
                columns: new[] { "DateCreated", "TrackId" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 4, 11, 11, 39, 10, 483, DateTimeKind.Unspecified).AddTicks(2915), new TimeSpan(0, 0, 0, 0, 0)), "44858c7a-87e6-4b43-a36c-8fd790d2b720" });

            migrationBuilder.UpdateData(
                schema: "Cars",
                table: "Brands",
                keyColumn: "Id",
                keyValue: "zvQcGcl1nR7SpAfIMvxF",
                columns: new[] { "DateCreated", "TrackId" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 4, 11, 11, 39, 10, 483, DateTimeKind.Unspecified).AddTicks(2941), new TimeSpan(0, 0, 0, 0, 0)), "c94b77e6-17c4-4725-a8fa-ec9c9713d177" });

            migrationBuilder.UpdateData(
                schema: "Cars",
                table: "Brands",
                keyColumn: "Id",
                keyValue: "zzzbw5sz2hj27fvp4x2v",
                columns: new[] { "DateCreated", "TrackId" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 4, 11, 11, 39, 10, 483, DateTimeKind.Unspecified).AddTicks(2313), new TimeSpan(0, 0, 0, 0, 0)), "64ce6b3a-f320-46c7-9c53-ecdaef3f0ca1" });

            migrationBuilder.UpdateData(
                schema: "Troshka",
                table: "Categories",
                keyColumn: "Id",
                keyValue: "0Uun56AGjKNM2f07qMBS",
                columns: new[] { "DateCreated", "TrackId" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 4, 11, 11, 39, 10, 483, DateTimeKind.Unspecified).AddTicks(895), new TimeSpan(0, 0, 0, 0, 0)), "28a7efc5-7ac0-4b70-8e98-07e071ccfcf8" });

            migrationBuilder.UpdateData(
                schema: "Troshka",
                table: "Categories",
                keyColumn: "Id",
                keyValue: "AhHuT41lRddLH1wachlm",
                columns: new[] { "DateCreated", "TrackId" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 4, 11, 11, 39, 10, 483, DateTimeKind.Unspecified).AddTicks(905), new TimeSpan(0, 0, 0, 0, 0)), "5b0dfc6b-2c32-4651-90e6-709d1a1109ce" });

            migrationBuilder.UpdateData(
                schema: "Troshka",
                table: "Categories",
                keyColumn: "Id",
                keyValue: "DARdvjHJcTyGCYGekfIn",
                columns: new[] { "DateCreated", "TrackId" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 4, 11, 11, 39, 10, 483, DateTimeKind.Unspecified).AddTicks(911), new TimeSpan(0, 0, 0, 0, 0)), "668ae417-12cf-43f6-bee4-b179168d5b40" });

            migrationBuilder.UpdateData(
                schema: "Troshka",
                table: "Categories",
                keyColumn: "Id",
                keyValue: "ExCL3LNxUqXNC8LFF8rL",
                columns: new[] { "DateCreated", "TrackId" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 4, 11, 11, 39, 10, 483, DateTimeKind.Unspecified).AddTicks(917), new TimeSpan(0, 0, 0, 0, 0)), "e2f32392-6b88-4709-bb70-8fc299ff1743" });

            migrationBuilder.UpdateData(
                schema: "Troshka",
                table: "Categories",
                keyColumn: "Id",
                keyValue: "GFF7R0xsM4muSxEG8k0J",
                columns: new[] { "DateCreated", "TrackId" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 4, 11, 11, 39, 10, 483, DateTimeKind.Unspecified).AddTicks(951), new TimeSpan(0, 0, 0, 0, 0)), "19ade312-fcff-4852-9d4a-77fdaf645c60" });

            migrationBuilder.UpdateData(
                schema: "Troshka",
                table: "Categories",
                keyColumn: "Id",
                keyValue: "lnm5mTuNV56JTQQYWPRe",
                columns: new[] { "DateCreated", "TrackId" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 4, 11, 11, 39, 10, 483, DateTimeKind.Unspecified).AddTicks(957), new TimeSpan(0, 0, 0, 0, 0)), "19d306a0-9400-4387-b1ae-f9a681f7b5c5" });

            migrationBuilder.UpdateData(
                schema: "Troshka",
                table: "Categories",
                keyColumn: "Id",
                keyValue: "NUSX1N5R2xUS9WfTo3lp",
                columns: new[] { "DateCreated", "TrackId" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 4, 11, 11, 39, 10, 483, DateTimeKind.Unspecified).AddTicks(970), new TimeSpan(0, 0, 0, 0, 0)), "aee6dd1f-7437-4db4-85dc-ec41e2aef22d" });

            migrationBuilder.UpdateData(
                schema: "Troshka",
                table: "Categories",
                keyColumn: "Id",
                keyValue: "poo2JeVEhMn8wJz0KJdR",
                columns: new[] { "DateCreated", "TrackId" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 4, 11, 11, 39, 10, 483, DateTimeKind.Unspecified).AddTicks(976), new TimeSpan(0, 0, 0, 0, 0)), "ef3604e3-1a38-4302-a5cd-3af05ac41d1c" });

            migrationBuilder.UpdateData(
                schema: "Cars",
                table: "Coupe",
                keyColumn: "Id",
                keyValue: "17uwRnksm3dHVtGXjxg8",
                columns: new[] { "DateCreated", "TrackId" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 4, 11, 11, 39, 10, 483, DateTimeKind.Unspecified).AddTicks(6919), new TimeSpan(0, 0, 0, 0, 0)), "37ccbd92-8b5b-45ba-a3c2-09dd391266db" });

            migrationBuilder.UpdateData(
                schema: "Cars",
                table: "Coupe",
                keyColumn: "Id",
                keyValue: "3GLNa5pkWPOWVuSdVjdX",
                columns: new[] { "DateCreated", "TrackId" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 4, 11, 11, 39, 10, 483, DateTimeKind.Unspecified).AddTicks(6894), new TimeSpan(0, 0, 0, 0, 0)), "599aab72-f485-4585-bac5-03fcfbfcd96d" });

            migrationBuilder.UpdateData(
                schema: "Cars",
                table: "Coupe",
                keyColumn: "Id",
                keyValue: "JD9wmJVdkgyRHCXjCs7V",
                columns: new[] { "DateCreated", "TrackId" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 4, 11, 11, 39, 10, 483, DateTimeKind.Unspecified).AddTicks(6902), new TimeSpan(0, 0, 0, 0, 0)), "0709ba96-afdd-48b7-913a-d67e45051bf4" });

            migrationBuilder.UpdateData(
                schema: "Cars",
                table: "Coupe",
                keyColumn: "Id",
                keyValue: "pPrhSk2DBNYBz6sCoF81",
                columns: new[] { "DateCreated", "TrackId" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 4, 11, 11, 39, 10, 483, DateTimeKind.Unspecified).AddTicks(6925), new TimeSpan(0, 0, 0, 0, 0)), "b4b96d7e-9446-4139-9921-81010af5b370" });

            migrationBuilder.UpdateData(
                schema: "Cars",
                table: "Coupe",
                keyColumn: "Id",
                keyValue: "qpfpQc2ba4RuH4SUb2uI",
                columns: new[] { "DateCreated", "TrackId" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 4, 11, 11, 39, 10, 483, DateTimeKind.Unspecified).AddTicks(6969), new TimeSpan(0, 0, 0, 0, 0)), "11dc759f-ef7b-42f4-b382-693704e68588" });

            migrationBuilder.UpdateData(
                schema: "Cars",
                table: "Coupe",
                keyColumn: "Id",
                keyValue: "vqB7n29Zlq6pL8TKKL7j",
                columns: new[] { "DateCreated", "TrackId" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 4, 11, 11, 39, 10, 483, DateTimeKind.Unspecified).AddTicks(6913), new TimeSpan(0, 0, 0, 0, 0)), "fefea29a-0f98-4553-9836-9d30011af3b2" });

            migrationBuilder.UpdateData(
                schema: "Cars",
                table: "Coupe",
                keyColumn: "Id",
                keyValue: "xrAUDYo0LOc0HQWGSXVW",
                columns: new[] { "DateCreated", "TrackId" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 4, 11, 11, 39, 10, 483, DateTimeKind.Unspecified).AddTicks(6962), new TimeSpan(0, 0, 0, 0, 0)), "d17075a8-6c2b-4b63-873d-0ee40ccf69bf" });

            migrationBuilder.UpdateData(
                schema: "Cars",
                table: "Coupe",
                keyColumn: "Id",
                keyValue: "ZfEvTe27FGIJe7I1eQkG",
                columns: new[] { "DateCreated", "TrackId" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 4, 11, 11, 39, 10, 483, DateTimeKind.Unspecified).AddTicks(6908), new TimeSpan(0, 0, 0, 0, 0)), "c2aed9f5-be55-44ce-b6ab-d6987b21db2d" });

            migrationBuilder.InsertData(
                schema: "Troshka",
                table: "Currencies",
                columns: new[] { "Id", "DateCreated", "DateDeleted", "DateUpdated", "IsDeleted", "Name", "TrackId" },
                values: new object[,]
                {
                    { "7rTgBav88Ef6JWaphCMx", new DateTimeOffset(new DateTime(2023, 4, 11, 11, 39, 10, 484, DateTimeKind.Unspecified).AddTicks(2327), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "USD", "d8fc780e-45f9-4687-a2f6-5178de00cf2a" },
                    { "S7pXo6rn1AFBvQ0mArI3", new DateTimeOffset(new DateTime(2023, 4, 11, 11, 39, 10, 484, DateTimeKind.Unspecified).AddTicks(2277), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "BGN", "d88957a2-d3fa-40cc-94ad-a13433cedd5d" },
                    { "V6yIzQ7lt8QV6b7TUb0m", new DateTimeOffset(new DateTime(2023, 4, 11, 11, 39, 10, 484, DateTimeKind.Unspecified).AddTicks(2317), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "EUR", "cd59f0bf-ab6d-4271-bd58-15dc3c09f0d6" }
                });

            migrationBuilder.InsertData(
                schema: "Troshka",
                table: "Engines",
                columns: new[] { "Id", "DateCreated", "DateDeleted", "DateUpdated", "IsDeleted", "Name", "TrackId" },
                values: new object[,]
                {
                    { "3wyflVbGIz37cAs6aDVK", new DateTimeOffset(new DateTime(2023, 4, 11, 11, 39, 10, 484, DateTimeKind.Unspecified).AddTicks(928), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "Plug-in хибрид", "16e0d139-d5dd-4d79-ae3a-10c2b2f3d645" },
                    { "65NKlTJ3zmRz5XvEMAWQ", new DateTimeOffset(new DateTime(2023, 4, 11, 11, 39, 10, 484, DateTimeKind.Unspecified).AddTicks(682), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "Електрически", "0724f7fa-0d30-4478-a1d1-85cbe92b7393" },
                    { "8Mf3vIu20SHalXvxPDf7", new DateTimeOffset(new DateTime(2023, 4, 11, 11, 39, 10, 484, DateTimeKind.Unspecified).AddTicks(660), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "Бензин", "52aac95c-658f-44c8-8f03-0aface9adaf8" },
                    { "MfwSv1JXDeRac9UT2RFn", new DateTimeOffset(new DateTime(2023, 4, 11, 11, 39, 10, 484, DateTimeKind.Unspecified).AddTicks(921), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "Хибрид", "ef53d019-9b96-4110-9339-2d1ebf57d93a" },
                    { "So8SFMu4XtALoluQncWW", new DateTimeOffset(new DateTime(2023, 4, 11, 11, 39, 10, 484, DateTimeKind.Unspecified).AddTicks(672), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "Дизел", "03b33dc6-3439-49a9-943c-56bfec62c9c9" }
                });

            migrationBuilder.InsertData(
                schema: "Troshka",
                table: "EuroStandards",
                columns: new[] { "Id", "DateCreated", "DateDeleted", "DateUpdated", "IsDeleted", "Name", "TrackId" },
                values: new object[,]
                {
                    { "45EWKLIMt3BShtG3AQTa", new DateTimeOffset(new DateTime(2023, 4, 11, 11, 39, 10, 484, DateTimeKind.Unspecified).AddTicks(2478), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "Евро 1", "d00b60f6-661c-443b-b489-64c82fcdc3a2" },
                    { "6nVWtynUjqNfYvJBHm9y", new DateTimeOffset(new DateTime(2023, 4, 11, 11, 39, 10, 484, DateTimeKind.Unspecified).AddTicks(2492), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "Евро 3", "d34d6d71-d18e-4577-a2db-22b4c61eb583" },
                    { "gf3m77hAch2dLJlboAmI", new DateTimeOffset(new DateTime(2023, 4, 11, 11, 39, 10, 484, DateTimeKind.Unspecified).AddTicks(2499), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "Евро 4", "4e8353a2-05ad-4595-8f1d-3138a5a31bdb" },
                    { "hq0VW30hpNMC51A82FNL", new DateTimeOffset(new DateTime(2023, 4, 11, 11, 39, 10, 484, DateTimeKind.Unspecified).AddTicks(2486), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "Евро 2", "efd9b290-6d98-417d-921b-4172a72fdd51" },
                    { "KVUaC1lF52IRhBaKUsSE", new DateTimeOffset(new DateTime(2023, 4, 11, 11, 39, 10, 484, DateTimeKind.Unspecified).AddTicks(2542), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "Евро 6", "3a9d777e-61d4-4616-ad02-b92955024436" },
                    { "XdTXJcYMG10CUtCUYHQ5", new DateTimeOffset(new DateTime(2023, 4, 11, 11, 39, 10, 484, DateTimeKind.Unspecified).AddTicks(2548), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "Евро 7", "d0a39e1d-538b-41db-bf0a-4c1d9c9b511a" },
                    { "XLvkvBUg2BqeWw1UqIJg", new DateTimeOffset(new DateTime(2023, 4, 11, 11, 39, 10, 484, DateTimeKind.Unspecified).AddTicks(2534), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "Евро 5", "a45c4141-2793-4a0d-a886-3bb4dd55d60a" }
                });

            migrationBuilder.InsertData(
                schema: "Troshka",
                table: "Interior",
                columns: new[] { "Id", "DateCreated", "DateDeleted", "DateUpdated", "IsDeleted", "Name", "TrackId" },
                values: new object[,]
                {
                    { "uLTgFceWHqWonJ0FyvY6", new DateTimeOffset(new DateTime(2023, 4, 11, 11, 39, 10, 484, DateTimeKind.Unspecified).AddTicks(2713), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "Кожа", "851ed34b-f149-4143-ae75-9ab514651732" },
                    { "y79EsvBfEnypVSHxD01W", new DateTimeOffset(new DateTime(2023, 4, 11, 11, 39, 10, 484, DateTimeKind.Unspecified).AddTicks(2703), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "Велур", "84e6eb02-7a58-4ee5-a158-88fedaf3abd6" },
                    { "zeStkXRJNMYVAx3Ch3S7", new DateTimeOffset(new DateTime(2023, 4, 11, 11, 39, 10, 484, DateTimeKind.Unspecified).AddTicks(2722), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "Текстил", "b4126f47-dcbc-4860-9016-be5d081c3b50" }
                });

            migrationBuilder.UpdateData(
                schema: "Troshka",
                table: "Locations",
                keyColumn: "Id",
                keyValue: "0CjCASZC0LSzs6ToWDPf",
                columns: new[] { "DateCreated", "TrackId" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 4, 11, 11, 39, 10, 483, DateTimeKind.Unspecified).AddTicks(9709), new TimeSpan(0, 0, 0, 0, 0)), "2b90aea0-357f-40f9-baf7-9e6ff47bb2c8" });

            migrationBuilder.UpdateData(
                schema: "Troshka",
                table: "Locations",
                keyColumn: "Id",
                keyValue: "0cN6OnAaAEe9twTMKNSL",
                columns: new[] { "DateCreated", "TrackId" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 4, 11, 11, 39, 10, 483, DateTimeKind.Unspecified).AddTicks(9374), new TimeSpan(0, 0, 0, 0, 0)), "07562be5-8bdf-4409-ab5c-dfcfd0b44f91" });

            migrationBuilder.UpdateData(
                schema: "Troshka",
                table: "Locations",
                keyColumn: "Id",
                keyValue: "0gRnjKRsK5HpggmJ35QP",
                columns: new[] { "DateCreated", "TrackId" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 4, 11, 11, 39, 10, 483, DateTimeKind.Unspecified).AddTicks(9870), new TimeSpan(0, 0, 0, 0, 0)), "a862da03-817c-469d-833b-ec02db1bb636" });

            migrationBuilder.UpdateData(
                schema: "Troshka",
                table: "Locations",
                keyColumn: "Id",
                keyValue: "0kOlcUqNX3GmlqXlAfpU",
                columns: new[] { "DateCreated", "TrackId" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 4, 11, 11, 39, 10, 483, DateTimeKind.Unspecified).AddTicks(9529), new TimeSpan(0, 0, 0, 0, 0)), "c9a99f03-eefd-4c25-b348-b9dc36d6ce8a" });

            migrationBuilder.UpdateData(
                schema: "Troshka",
                table: "Locations",
                keyColumn: "Id",
                keyValue: "0mJJ1TNvJytdx93FG939",
                columns: new[] { "DateCreated", "TrackId" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 4, 11, 11, 39, 10, 483, DateTimeKind.Unspecified).AddTicks(9317), new TimeSpan(0, 0, 0, 0, 0)), "0f917601-1939-465f-8fc5-57718139fbb3" });

            migrationBuilder.UpdateData(
                schema: "Troshka",
                table: "Locations",
                keyColumn: "Id",
                keyValue: "0OiRluH0unBrqtgrdIhc",
                columns: new[] { "DateCreated", "TrackId" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 4, 11, 11, 39, 10, 484, DateTimeKind.Unspecified).AddTicks(283), new TimeSpan(0, 0, 0, 0, 0)), "e4b049e1-16ea-4032-9ca3-318a6e1a268a" });

            migrationBuilder.UpdateData(
                schema: "Troshka",
                table: "Locations",
                keyColumn: "Id",
                keyValue: "10unCs9PybUykwTtnWpJ",
                columns: new[] { "DateCreated", "TrackId" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 4, 11, 11, 39, 10, 483, DateTimeKind.Unspecified).AddTicks(9930), new TimeSpan(0, 0, 0, 0, 0)), "d0509c4b-9f13-4345-b426-328eed0463e9" });

            migrationBuilder.UpdateData(
                schema: "Troshka",
                table: "Locations",
                keyColumn: "Id",
                keyValue: "1bHqd1rUVLg6h6qfGLcS",
                columns: new[] { "DateCreated", "TrackId" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 4, 11, 11, 39, 10, 483, DateTimeKind.Unspecified).AddTicks(9058), new TimeSpan(0, 0, 0, 0, 0)), "2cbe5e28-732d-4e56-8550-8879bbf54d27" });

            migrationBuilder.UpdateData(
                schema: "Troshka",
                table: "Locations",
                keyColumn: "Id",
                keyValue: "1GRbG3rjQ2ofrU18THaz",
                columns: new[] { "DateCreated", "TrackId" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 4, 11, 11, 39, 10, 483, DateTimeKind.Unspecified).AddTicks(7636), new TimeSpan(0, 0, 0, 0, 0)), "8a5b9089-52a0-4c00-bdae-d13babe2d51d" });

            migrationBuilder.UpdateData(
                schema: "Troshka",
                table: "Locations",
                keyColumn: "Id",
                keyValue: "1yxBQ20RxnTqWYg7ZpVO",
                columns: new[] { "DateCreated", "TrackId" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 4, 11, 11, 39, 10, 483, DateTimeKind.Unspecified).AddTicks(8380), new TimeSpan(0, 0, 0, 0, 0)), "6def3969-59c5-4a7d-9ddf-b890cc43f372" });

            migrationBuilder.UpdateData(
                schema: "Troshka",
                table: "Locations",
                keyColumn: "Id",
                keyValue: "20Fc8tVmtdLnnO9dK9PJ",
                columns: new[] { "DateCreated", "TrackId" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 4, 11, 11, 39, 10, 483, DateTimeKind.Unspecified).AddTicks(9702), new TimeSpan(0, 0, 0, 0, 0)), "ac3f1d88-06be-42bc-9136-7e1819335e0c" });

            migrationBuilder.UpdateData(
                schema: "Troshka",
                table: "Locations",
                keyColumn: "Id",
                keyValue: "21myeuJwmBnKkl1V22jb",
                columns: new[] { "DateCreated", "TrackId" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 4, 11, 11, 39, 10, 484, DateTimeKind.Unspecified).AddTicks(10), new TimeSpan(0, 0, 0, 0, 0)), "38a14197-6388-45d1-a9f0-fbfd251ea342" });

            migrationBuilder.UpdateData(
                schema: "Troshka",
                table: "Locations",
                keyColumn: "Id",
                keyValue: "2IGYvWW5HtTpuUhzJzW0",
                columns: new[] { "DateCreated", "TrackId" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 4, 11, 11, 39, 10, 483, DateTimeKind.Unspecified).AddTicks(9924), new TimeSpan(0, 0, 0, 0, 0)), "4ba85641-21c6-4828-817e-300f41d1354f" });

            migrationBuilder.UpdateData(
                schema: "Troshka",
                table: "Locations",
                keyColumn: "Id",
                keyValue: "2Q8Cnvp0xt0RlhXwWFrM",
                columns: new[] { "DateCreated", "TrackId" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 4, 11, 11, 39, 10, 483, DateTimeKind.Unspecified).AddTicks(9795), new TimeSpan(0, 0, 0, 0, 0)), "e0b91097-3b27-468c-a4be-8cb6056af1c0" });

            migrationBuilder.UpdateData(
                schema: "Troshka",
                table: "Locations",
                keyColumn: "Id",
                keyValue: "2RlfSIT8tVjqvQoF3Yzh",
                columns: new[] { "DateCreated", "TrackId" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 4, 11, 11, 39, 10, 483, DateTimeKind.Unspecified).AddTicks(9355), new TimeSpan(0, 0, 0, 0, 0)), "10b3443d-ce68-444b-8bee-5990b51ef35e" });

            migrationBuilder.UpdateData(
                schema: "Troshka",
                table: "Locations",
                keyColumn: "Id",
                keyValue: "3ON8ZtRO2cHeFGcMhvnT",
                columns: new[] { "DateCreated", "TrackId" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 4, 11, 11, 39, 10, 483, DateTimeKind.Unspecified).AddTicks(7938), new TimeSpan(0, 0, 0, 0, 0)), "b53e4544-d763-46a0-b2e3-59e5ecef96c7" });

            migrationBuilder.UpdateData(
                schema: "Troshka",
                table: "Locations",
                keyColumn: "Id",
                keyValue: "4Niku3WHFIAqKT1bLKbM",
                columns: new[] { "DateCreated", "TrackId" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 4, 11, 11, 39, 10, 483, DateTimeKind.Unspecified).AddTicks(9238), new TimeSpan(0, 0, 0, 0, 0)), "e21bec61-8c44-486d-8efe-0cc8ce9ad283" });

            migrationBuilder.UpdateData(
                schema: "Troshka",
                table: "Locations",
                keyColumn: "Id",
                keyValue: "51NCl8sofLRt5CZ6Ijb9",
                columns: new[] { "DateCreated", "TrackId" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 4, 11, 11, 39, 10, 483, DateTimeKind.Unspecified).AddTicks(8987), new TimeSpan(0, 0, 0, 0, 0)), "ead3af36-630a-456f-88b1-2ed40d8369a8" });

            migrationBuilder.UpdateData(
                schema: "Troshka",
                table: "Locations",
                keyColumn: "Id",
                keyValue: "58SC1K92gC6TIqc6YieE",
                columns: new[] { "DateCreated", "TrackId" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 4, 11, 11, 39, 10, 483, DateTimeKind.Unspecified).AddTicks(8117), new TimeSpan(0, 0, 0, 0, 0)), "7c5330a1-be79-48fa-8a83-45d1d4a35f5f" });

            migrationBuilder.UpdateData(
                schema: "Troshka",
                table: "Locations",
                keyColumn: "Id",
                keyValue: "5dVT6X9b1jLvkFx5kfAM",
                columns: new[] { "DateCreated", "TrackId" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 4, 11, 11, 39, 10, 483, DateTimeKind.Unspecified).AddTicks(9121), new TimeSpan(0, 0, 0, 0, 0)), "cc43020b-ceb5-4fb5-a538-1930da484421" });

            migrationBuilder.UpdateData(
                schema: "Troshka",
                table: "Locations",
                keyColumn: "Id",
                keyValue: "5fCsOxNvMUvksRS1ZpQV",
                columns: new[] { "DateCreated", "TrackId" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 4, 11, 11, 39, 10, 483, DateTimeKind.Unspecified).AddTicks(9311), new TimeSpan(0, 0, 0, 0, 0)), "4dbe7a12-2563-4ecd-85ed-ba22fbd9ac2e" });

            migrationBuilder.UpdateData(
                schema: "Troshka",
                table: "Locations",
                keyColumn: "Id",
                keyValue: "5m7B9g75rKUL9NPw6d8X",
                columns: new[] { "DateCreated", "TrackId" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 4, 11, 11, 39, 10, 483, DateTimeKind.Unspecified).AddTicks(7906), new TimeSpan(0, 0, 0, 0, 0)), "a6fae972-af9c-490e-8b6e-ec6ecc5dd85a" });

            migrationBuilder.UpdateData(
                schema: "Troshka",
                table: "Locations",
                keyColumn: "Id",
                keyValue: "5Rqixw4lSU7SBGqdw1Zw",
                columns: new[] { "DateCreated", "TrackId" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 4, 11, 11, 39, 10, 483, DateTimeKind.Unspecified).AddTicks(8609), new TimeSpan(0, 0, 0, 0, 0)), "568374cf-63d7-4e72-874b-364d2df30a4e" });

            migrationBuilder.UpdateData(
                schema: "Troshka",
                table: "Locations",
                keyColumn: "Id",
                keyValue: "60EtxqsrwIKU0ltomD8Z",
                columns: new[] { "DateCreated", "TrackId" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 4, 11, 11, 39, 10, 483, DateTimeKind.Unspecified).AddTicks(9986), new TimeSpan(0, 0, 0, 0, 0)), "140a3d1d-84c6-49a7-a048-cb9d7fa69155" });

            migrationBuilder.UpdateData(
                schema: "Troshka",
                table: "Locations",
                keyColumn: "Id",
                keyValue: "6GF8DxWoU9qXj4LQ5PQx",
                columns: new[] { "DateCreated", "TrackId" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 4, 11, 11, 39, 10, 483, DateTimeKind.Unspecified).AddTicks(7515), new TimeSpan(0, 0, 0, 0, 0)), "3bbbb480-c487-4b62-89ec-a1a86338049a" });

            migrationBuilder.UpdateData(
                schema: "Troshka",
                table: "Locations",
                keyColumn: "Id",
                keyValue: "72K7099RJLSbKsSfj3vN",
                columns: new[] { "DateCreated", "TrackId" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 4, 11, 11, 39, 10, 483, DateTimeKind.Unspecified).AddTicks(9269), new TimeSpan(0, 0, 0, 0, 0)), "299166e4-e2ae-492f-bcf0-335b68f26046" });

            migrationBuilder.UpdateData(
                schema: "Troshka",
                table: "Locations",
                keyColumn: "Id",
                keyValue: "7keXP3PumDqPy2TtIJyE",
                columns: new[] { "DateCreated", "TrackId" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 4, 11, 11, 39, 10, 483, DateTimeKind.Unspecified).AddTicks(7459), new TimeSpan(0, 0, 0, 0, 0)), "ae1be929-bf59-4ecf-b658-30862f8a6792" });

            migrationBuilder.UpdateData(
                schema: "Troshka",
                table: "Locations",
                keyColumn: "Id",
                keyValue: "7s493n3iCAcI9eV6xOsf",
                columns: new[] { "DateCreated", "TrackId" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 4, 11, 11, 39, 10, 483, DateTimeKind.Unspecified).AddTicks(9127), new TimeSpan(0, 0, 0, 0, 0)), "84ebcb7d-31b7-4e77-91c2-4b83681d4699" });

            migrationBuilder.UpdateData(
                schema: "Troshka",
                table: "Locations",
                keyColumn: "Id",
                keyValue: "7VIIUaptNwzhj8ej05ur",
                columns: new[] { "DateCreated", "TrackId" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 4, 11, 11, 39, 10, 483, DateTimeKind.Unspecified).AddTicks(8745), new TimeSpan(0, 0, 0, 0, 0)), "276d537d-a351-44f8-8490-9bb8c006c742" });

            migrationBuilder.UpdateData(
                schema: "Troshka",
                table: "Locations",
                keyColumn: "Id",
                keyValue: "818vJeBIuImlcdJGphu8",
                columns: new[] { "DateCreated", "TrackId" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 4, 11, 11, 39, 10, 483, DateTimeKind.Unspecified).AddTicks(8317), new TimeSpan(0, 0, 0, 0, 0)), "5ed9dc3f-9bb0-4cd5-9ada-b3df23d3dc14" });

            migrationBuilder.UpdateData(
                schema: "Troshka",
                table: "Locations",
                keyColumn: "Id",
                keyValue: "82mULi1IDzKqLOn3G2uP",
                columns: new[] { "DateCreated", "TrackId" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 4, 11, 11, 39, 10, 483, DateTimeKind.Unspecified).AddTicks(8432), new TimeSpan(0, 0, 0, 0, 0)), "60147e92-a5b6-4fa5-b4a3-a7a45b6f77bd" });

            migrationBuilder.UpdateData(
                schema: "Troshka",
                table: "Locations",
                keyColumn: "Id",
                keyValue: "8Be2RRzbuSU59GLX3Ezl",
                columns: new[] { "DateCreated", "TrackId" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 4, 11, 11, 39, 10, 483, DateTimeKind.Unspecified).AddTicks(9588), new TimeSpan(0, 0, 0, 0, 0)), "9b0c66c1-a2ca-44a3-80ee-99b4632b0504" });

            migrationBuilder.UpdateData(
                schema: "Troshka",
                table: "Locations",
                keyColumn: "Id",
                keyValue: "8HyYUQaPF48Tit9PqSQi",
                columns: new[] { "DateCreated", "TrackId" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 4, 11, 11, 39, 10, 483, DateTimeKind.Unspecified).AddTicks(8715), new TimeSpan(0, 0, 0, 0, 0)), "162feaec-169f-4152-8a27-7e8543f58083" });

            migrationBuilder.UpdateData(
                schema: "Troshka",
                table: "Locations",
                keyColumn: "Id",
                keyValue: "8nHE5KIPw9tUyknXo3Jl",
                columns: new[] { "DateCreated", "TrackId" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 4, 11, 11, 39, 10, 483, DateTimeKind.Unspecified).AddTicks(8854), new TimeSpan(0, 0, 0, 0, 0)), "80dedb71-2d6d-413c-9d0f-6648140cec1f" });

            migrationBuilder.UpdateData(
                schema: "Troshka",
                table: "Locations",
                keyColumn: "Id",
                keyValue: "8Q8i1YjiArjCDECWmWRb",
                columns: new[] { "DateCreated", "TrackId" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 4, 11, 11, 39, 10, 483, DateTimeKind.Unspecified).AddTicks(8860), new TimeSpan(0, 0, 0, 0, 0)), "6bab1c2c-cb41-4a1d-94fe-0d35ca29a61f" });

            migrationBuilder.UpdateData(
                schema: "Troshka",
                table: "Locations",
                keyColumn: "Id",
                keyValue: "8QQI9EeWHMOtwxCOcWIT",
                columns: new[] { "DateCreated", "TrackId" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 4, 11, 11, 39, 10, 484, DateTimeKind.Unspecified).AddTicks(239), new TimeSpan(0, 0, 0, 0, 0)), "29e95efe-0f6f-430d-a11c-9e9264a2911a" });

            migrationBuilder.UpdateData(
                schema: "Troshka",
                table: "Locations",
                keyColumn: "Id",
                keyValue: "8U43LpX9MGvI2cmLw4rD",
                columns: new[] { "DateCreated", "TrackId" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 4, 11, 11, 39, 10, 483, DateTimeKind.Unspecified).AddTicks(9477), new TimeSpan(0, 0, 0, 0, 0)), "d983fc20-b35b-4669-a197-2cb26f01b00b" });

            migrationBuilder.UpdateData(
                schema: "Troshka",
                table: "Locations",
                keyColumn: "Id",
                keyValue: "9feUqBzVA8eZsdMvXqvG",
                columns: new[] { "DateCreated", "TrackId" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 4, 11, 11, 39, 10, 483, DateTimeKind.Unspecified).AddTicks(7465), new TimeSpan(0, 0, 0, 0, 0)), "d1fb218c-73b1-4bd2-af4b-4929a645f4f1" });

            migrationBuilder.UpdateData(
                schema: "Troshka",
                table: "Locations",
                keyColumn: "Id",
                keyValue: "9sFruqb4xl1tBUAlCjnb",
                columns: new[] { "DateCreated", "TrackId" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 4, 11, 11, 39, 10, 483, DateTimeKind.Unspecified).AddTicks(8709), new TimeSpan(0, 0, 0, 0, 0)), "b15c3a2a-c305-47ce-95e0-71c4b474665a" });

            migrationBuilder.UpdateData(
                schema: "Troshka",
                table: "Locations",
                keyColumn: "Id",
                keyValue: "9twC0sUO1RE8B9LYfWdX",
                columns: new[] { "DateCreated", "TrackId" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 4, 11, 11, 39, 10, 483, DateTimeKind.Unspecified).AddTicks(9189), new TimeSpan(0, 0, 0, 0, 0)), "0ddd6214-ca89-43fe-a77d-bd625b8ebf24" });

            migrationBuilder.UpdateData(
                schema: "Troshka",
                table: "Locations",
                keyColumn: "Id",
                keyValue: "9vN2sGt2IhEntOysf32e",
                columns: new[] { "DateCreated", "TrackId" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 4, 11, 11, 39, 10, 483, DateTimeKind.Unspecified).AddTicks(9541), new TimeSpan(0, 0, 0, 0, 0)), "6a197982-5377-44e8-ae11-44fb3c9463fe" });

            migrationBuilder.UpdateData(
                schema: "Troshka",
                table: "Locations",
                keyColumn: "Id",
                keyValue: "a0p6Ajl1TVHmaGVNKNLi",
                columns: new[] { "DateCreated", "TrackId" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 4, 11, 11, 39, 10, 483, DateTimeKind.Unspecified).AddTicks(8777), new TimeSpan(0, 0, 0, 0, 0)), "a13252b3-59aa-47cd-a717-61cde600fc89" });

            migrationBuilder.UpdateData(
                schema: "Troshka",
                table: "Locations",
                keyColumn: "Id",
                keyValue: "AAAO3LJLeMao6iml66wC",
                columns: new[] { "DateCreated", "TrackId" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 4, 11, 11, 39, 10, 483, DateTimeKind.Unspecified).AddTicks(9936), new TimeSpan(0, 0, 0, 0, 0)), "8e80470a-33fb-457d-b09e-5b2970022252" });

            migrationBuilder.UpdateData(
                schema: "Troshka",
                table: "Locations",
                keyColumn: "Id",
                keyValue: "Ab0ApUhICf7zaMFmHTFt",
                columns: new[] { "DateCreated", "TrackId" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 4, 11, 11, 39, 10, 483, DateTimeKind.Unspecified).AddTicks(9460), new TimeSpan(0, 0, 0, 0, 0)), "f0863424-044b-4958-b72b-b3f0966b514e" });

            migrationBuilder.UpdateData(
                schema: "Troshka",
                table: "Locations",
                keyColumn: "Id",
                keyValue: "AcHS4Qb4HuqEnBoT32eu",
                columns: new[] { "DateCreated", "TrackId" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 4, 11, 11, 39, 10, 483, DateTimeKind.Unspecified).AddTicks(9214), new TimeSpan(0, 0, 0, 0, 0)), "c41be77b-efd7-4bf8-a0e4-e401f3d16d0a" });

            migrationBuilder.UpdateData(
                schema: "Troshka",
                table: "Locations",
                keyColumn: "Id",
                keyValue: "ady7xTwdtnixVQs3O2oz",
                columns: new[] { "DateCreated", "TrackId" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 4, 11, 11, 39, 10, 483, DateTimeKind.Unspecified).AddTicks(7931), new TimeSpan(0, 0, 0, 0, 0)), "11db2fbf-86cf-4617-8efb-e924b0dc20d3" });

            migrationBuilder.UpdateData(
                schema: "Troshka",
                table: "Locations",
                keyColumn: "Id",
                keyValue: "AMp3jRxQAkoccRtMGfvg",
                columns: new[] { "DateCreated", "TrackId" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 4, 11, 11, 39, 10, 483, DateTimeKind.Unspecified).AddTicks(9864), new TimeSpan(0, 0, 0, 0, 0)), "8ebba579-b873-4f0a-aeb2-02e30fbb935d" });

            migrationBuilder.UpdateData(
                schema: "Troshka",
                table: "Locations",
                keyColumn: "Id",
                keyValue: "an3o0hYhG7sP6YemnTPr",
                columns: new[] { "DateCreated", "TrackId" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 4, 11, 11, 39, 10, 484, DateTimeKind.Unspecified).AddTicks(78), new TimeSpan(0, 0, 0, 0, 0)), "d4ef2c57-484e-4624-8230-59f764f9e406" });

            migrationBuilder.UpdateData(
                schema: "Troshka",
                table: "Locations",
                keyColumn: "Id",
                keyValue: "aOeUgHmp1DYlbgus1iym",
                columns: new[] { "DateCreated", "TrackId" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 4, 11, 11, 39, 10, 483, DateTimeKind.Unspecified).AddTicks(9012), new TimeSpan(0, 0, 0, 0, 0)), "de0ce630-08b3-487f-9ba3-d526fae08412" });

            migrationBuilder.UpdateData(
                schema: "Troshka",
                table: "Locations",
                keyColumn: "Id",
                keyValue: "arzgr2kBPnf94eLvHmzF",
                columns: new[] { "DateCreated", "TrackId" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 4, 11, 11, 39, 10, 484, DateTimeKind.Unspecified).AddTicks(226), new TimeSpan(0, 0, 0, 0, 0)), "0a3e243e-3792-4346-9168-694df1383224" });

            migrationBuilder.UpdateData(
                schema: "Troshka",
                table: "Locations",
                keyColumn: "Id",
                keyValue: "AUdHMyIrucbK1QPSuEl6",
                columns: new[] { "DateCreated", "TrackId" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 4, 11, 11, 39, 10, 483, DateTimeKind.Unspecified).AddTicks(9721), new TimeSpan(0, 0, 0, 0, 0)), "ce0895d5-b749-4c4b-8c96-82d199e66528" });

            migrationBuilder.UpdateData(
                schema: "Troshka",
                table: "Locations",
                keyColumn: "Id",
                keyValue: "ayxopMnHP3GynSD3phZ0",
                columns: new[] { "DateCreated", "TrackId" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 4, 11, 11, 39, 10, 483, DateTimeKind.Unspecified).AddTicks(8637), new TimeSpan(0, 0, 0, 0, 0)), "209e6a55-4d0c-4961-80a6-f7b9cfa4f5c2" });

            migrationBuilder.UpdateData(
                schema: "Troshka",
                table: "Locations",
                keyColumn: "Id",
                keyValue: "B6fEB97ylQL7Np47vtYV",
                columns: new[] { "DateCreated", "TrackId" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 4, 11, 11, 39, 10, 483, DateTimeKind.Unspecified).AddTicks(9993), new TimeSpan(0, 0, 0, 0, 0)), "d5153577-521c-4e89-af29-02bc1d59414e" });

            migrationBuilder.UpdateData(
                schema: "Troshka",
                table: "Locations",
                keyColumn: "Id",
                keyValue: "BCxe8rk6vzMhYhXTO0rU",
                columns: new[] { "DateCreated", "TrackId" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 4, 11, 11, 39, 10, 483, DateTimeKind.Unspecified).AddTicks(9601), new TimeSpan(0, 0, 0, 0, 0)), "0dd231e1-de4d-407b-bdfa-5193696a7572" });

            migrationBuilder.UpdateData(
                schema: "Troshka",
                table: "Locations",
                keyColumn: "Id",
                keyValue: "bHGMKKJTtQuMC0vS9i3Z",
                columns: new[] { "DateCreated", "TrackId" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 4, 11, 11, 39, 10, 483, DateTimeKind.Unspecified).AddTicks(8414), new TimeSpan(0, 0, 0, 0, 0)), "6e82a68c-f4d4-407f-935d-ef2f7fa0dfd6" });

            migrationBuilder.UpdateData(
                schema: "Troshka",
                table: "Locations",
                keyColumn: "Id",
                keyValue: "Bj7la6MGA3NvSSopnJri",
                columns: new[] { "DateCreated", "TrackId" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 4, 11, 11, 39, 10, 483, DateTimeKind.Unspecified).AddTicks(8047), new TimeSpan(0, 0, 0, 0, 0)), "9fb55b86-25a5-4b6f-bcc3-088fd333007a" });

            migrationBuilder.UpdateData(
                schema: "Troshka",
                table: "Locations",
                keyColumn: "Id",
                keyValue: "blP0EqOltrrA4kScx9XG",
                columns: new[] { "DateCreated", "TrackId" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 4, 11, 11, 39, 10, 484, DateTimeKind.Unspecified).AddTicks(183), new TimeSpan(0, 0, 0, 0, 0)), "3d866ebb-7f7a-429b-ac0b-7438048a2c3c" });

            migrationBuilder.UpdateData(
                schema: "Troshka",
                table: "Locations",
                keyColumn: "Id",
                keyValue: "bnc8v9kl9VlsefVCPL0W",
                columns: new[] { "DateCreated", "TrackId" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 4, 11, 11, 39, 10, 483, DateTimeKind.Unspecified).AddTicks(9465), new TimeSpan(0, 0, 0, 0, 0)), "b291705c-d196-47d8-8afe-953c9fc57770" });

            migrationBuilder.UpdateData(
                schema: "Troshka",
                table: "Locations",
                keyColumn: "Id",
                keyValue: "BnHAwhVpD8t3wGhxo8Sg",
                columns: new[] { "DateCreated", "TrackId" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 4, 11, 11, 39, 10, 483, DateTimeKind.Unspecified).AddTicks(9000), new TimeSpan(0, 0, 0, 0, 0)), "df33adba-4f70-4610-a0f0-d25496f745bf" });

            migrationBuilder.UpdateData(
                schema: "Troshka",
                table: "Locations",
                keyColumn: "Id",
                keyValue: "BOqOCxCIc5jNlWXHJUK4",
                columns: new[] { "DateCreated", "TrackId" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 4, 11, 11, 39, 10, 483, DateTimeKind.Unspecified).AddTicks(8981), new TimeSpan(0, 0, 0, 0, 0)), "58186144-5001-474c-9b57-494eab0ba690" });

            migrationBuilder.UpdateData(
                schema: "Troshka",
                table: "Locations",
                keyColumn: "Id",
                keyValue: "BpmCmi2yyMLJaOKrSPZQ",
                columns: new[] { "DateCreated", "TrackId" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 4, 11, 11, 39, 10, 483, DateTimeKind.Unspecified).AddTicks(9772), new TimeSpan(0, 0, 0, 0, 0)), "33aad58e-ed5d-4914-a008-1e418bba0a6d" });

            migrationBuilder.UpdateData(
                schema: "Troshka",
                table: "Locations",
                keyColumn: "Id",
                keyValue: "bQptTR8qPbrqS4Wg6ZQN",
                columns: new[] { "DateCreated", "TrackId" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 4, 11, 11, 39, 10, 483, DateTimeKind.Unspecified).AddTicks(7924), new TimeSpan(0, 0, 0, 0, 0)), "822dfa52-93dc-4385-8682-88a69aea566e" });

            migrationBuilder.UpdateData(
                schema: "Troshka",
                table: "Locations",
                keyColumn: "Id",
                keyValue: "bsf5H4yuihOunxGQvTRs",
                columns: new[] { "DateCreated", "TrackId" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 4, 11, 11, 39, 10, 483, DateTimeKind.Unspecified).AddTicks(9554), new TimeSpan(0, 0, 0, 0, 0)), "5490c7be-d4c2-429f-9862-d645c635e18f" });

            migrationBuilder.UpdateData(
                schema: "Troshka",
                table: "Locations",
                keyColumn: "Id",
                keyValue: "BslBNBCNreUaRxaYYFz8",
                columns: new[] { "DateCreated", "TrackId" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 4, 11, 11, 39, 10, 484, DateTimeKind.Unspecified).AddTicks(4), new TimeSpan(0, 0, 0, 0, 0)), "7462450c-7c32-4e6b-8f96-6d8eaa2cf938" });

            migrationBuilder.UpdateData(
                schema: "Troshka",
                table: "Locations",
                keyColumn: "Id",
                keyValue: "BxBkLPfjqiPnspDDl02r",
                columns: new[] { "DateCreated", "TrackId" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 4, 11, 11, 39, 10, 483, DateTimeKind.Unspecified).AddTicks(9392), new TimeSpan(0, 0, 0, 0, 0)), "853172ed-c6da-434b-80f8-b2e2413816d8" });

            migrationBuilder.UpdateData(
                schema: "Troshka",
                table: "Locations",
                keyColumn: "Id",
                keyValue: "Byx9xuuqRVNwAvPtVdUA",
                columns: new[] { "DateCreated", "TrackId" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 4, 11, 11, 39, 10, 483, DateTimeKind.Unspecified).AddTicks(8890), new TimeSpan(0, 0, 0, 0, 0)), "7e4d993f-0d22-4350-a672-38b1c7946235" });

            migrationBuilder.UpdateData(
                schema: "Troshka",
                table: "Locations",
                keyColumn: "Id",
                keyValue: "cAm9i5Xr8AKbjxd4a0X5",
                columns: new[] { "DateCreated", "TrackId" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 4, 11, 11, 39, 10, 483, DateTimeKind.Unspecified).AddTicks(7897), new TimeSpan(0, 0, 0, 0, 0)), "f361ced2-b1a7-483e-b441-d1144a176f28" });

            migrationBuilder.UpdateData(
                schema: "Troshka",
                table: "Locations",
                keyColumn: "Id",
                keyValue: "CBDlQzM1rROQtTHgzVwT",
                columns: new[] { "DateCreated", "TrackId" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 4, 11, 11, 39, 10, 483, DateTimeKind.Unspecified).AddTicks(9443), new TimeSpan(0, 0, 0, 0, 0)), "2fb5fb6d-7add-4e9f-ba99-cc628073b16f" });

            migrationBuilder.UpdateData(
                schema: "Troshka",
                table: "Locations",
                keyColumn: "Id",
                keyValue: "cBnRQo0enzpUXFrymVl7",
                columns: new[] { "DateCreated", "TrackId" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 4, 11, 11, 39, 10, 483, DateTimeKind.Unspecified).AddTicks(7540), new TimeSpan(0, 0, 0, 0, 0)), "760b93d7-22b2-4d3a-89c2-4d93369bd975" });

            migrationBuilder.UpdateData(
                schema: "Troshka",
                table: "Locations",
                keyColumn: "Id",
                keyValue: "cEztanE91e85HAt8d1sE",
                columns: new[] { "DateCreated", "TrackId" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 4, 11, 11, 39, 10, 483, DateTimeKind.Unspecified).AddTicks(9695), new TimeSpan(0, 0, 0, 0, 0)), "7a21fd26-db53-444e-b088-66c327a3090d" });

            migrationBuilder.UpdateData(
                schema: "Troshka",
                table: "Locations",
                keyColumn: "Id",
                keyValue: "cHIsh4O8DiS3aa6BpqGy",
                columns: new[] { "DateCreated", "TrackId" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 4, 11, 11, 39, 10, 483, DateTimeKind.Unspecified).AddTicks(8041), new TimeSpan(0, 0, 0, 0, 0)), "a1a59d26-a7e4-40bd-a4d0-1ba0827bca64" });

            migrationBuilder.UpdateData(
                schema: "Troshka",
                table: "Locations",
                keyColumn: "Id",
                keyValue: "chRNgs4uXAUiB7dw6T4M",
                columns: new[] { "DateCreated", "TrackId" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 4, 11, 11, 39, 10, 483, DateTimeKind.Unspecified).AddTicks(9070), new TimeSpan(0, 0, 0, 0, 0)), "57882d98-03ab-471c-89e6-21690b98a8ff" });

            migrationBuilder.UpdateData(
                schema: "Troshka",
                table: "Locations",
                keyColumn: "Id",
                keyValue: "CM7iD1yu2CS7hvScKNMO",
                columns: new[] { "DateCreated", "TrackId" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 4, 11, 11, 39, 10, 483, DateTimeKind.Unspecified).AddTicks(9208), new TimeSpan(0, 0, 0, 0, 0)), "0ed4475b-1b54-4a6a-b53c-87558ff3fde3" });

            migrationBuilder.UpdateData(
                schema: "Troshka",
                table: "Locations",
                keyColumn: "Id",
                keyValue: "cr5i9babcZns6KgEyn24",
                columns: new[] { "DateCreated", "TrackId" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 4, 11, 11, 39, 10, 483, DateTimeKind.Unspecified).AddTicks(9523), new TimeSpan(0, 0, 0, 0, 0)), "6520e5c6-f78f-4bef-b2d3-f269d805afe7" });

            migrationBuilder.UpdateData(
                schema: "Troshka",
                table: "Locations",
                keyColumn: "Id",
                keyValue: "cU4r5FiNJgbiM6dhG8ER",
                columns: new[] { "DateCreated", "TrackId" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 4, 11, 11, 39, 10, 483, DateTimeKind.Unspecified).AddTicks(8698), new TimeSpan(0, 0, 0, 0, 0)), "81975e02-b017-47f1-90d6-b4d14afbb6e2" });

            migrationBuilder.UpdateData(
                schema: "Troshka",
                table: "Locations",
                keyColumn: "Id",
                keyValue: "cW98FxYnDNVMNflmC8q7",
                columns: new[] { "DateCreated", "TrackId" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 4, 11, 11, 39, 10, 483, DateTimeKind.Unspecified).AddTicks(9834), new TimeSpan(0, 0, 0, 0, 0)), "e21408af-4e85-4109-bd20-316ef0850e62" });

            migrationBuilder.UpdateData(
                schema: "Troshka",
                table: "Locations",
                keyColumn: "Id",
                keyValue: "dh8S1ZT9W1jajYz9EGG4",
                columns: new[] { "DateCreated", "TrackId" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 4, 11, 11, 39, 10, 484, DateTimeKind.Unspecified).AddTicks(102), new TimeSpan(0, 0, 0, 0, 0)), "b26b8591-2500-4494-ac61-8efe752723f0" });

            migrationBuilder.UpdateData(
                schema: "Troshka",
                table: "Locations",
                keyColumn: "Id",
                keyValue: "DjTHGizW8wBL6URovDng",
                columns: new[] { "DateCreated", "TrackId" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 4, 11, 11, 39, 10, 483, DateTimeKind.Unspecified).AddTicks(8347), new TimeSpan(0, 0, 0, 0, 0)), "689cf732-7f64-425b-a464-c0b483fad942" });

            migrationBuilder.UpdateData(
                schema: "Troshka",
                table: "Locations",
                keyColumn: "Id",
                keyValue: "dKTky4haW2fNOzMjNTiu",
                columns: new[] { "DateCreated", "TrackId" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 4, 11, 11, 39, 10, 484, DateTimeKind.Unspecified).AddTicks(84), new TimeSpan(0, 0, 0, 0, 0)), "2028a2db-4eca-4334-b901-5ce14d8f5b11" });

            migrationBuilder.UpdateData(
                schema: "Troshka",
                table: "Locations",
                keyColumn: "Id",
                keyValue: "dlWGw4uU8kpnrXq4zbyN",
                columns: new[] { "DateCreated", "TrackId" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 4, 11, 11, 39, 10, 483, DateTimeKind.Unspecified).AddTicks(8783), new TimeSpan(0, 0, 0, 0, 0)), "8fa9bdd2-2fd4-4a5f-937e-07b0ec23c457" });

            migrationBuilder.UpdateData(
                schema: "Troshka",
                table: "Locations",
                keyColumn: "Id",
                keyValue: "DNQ3KHJkxqiNtn14gcaB",
                columns: new[] { "DateCreated", "TrackId" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 4, 11, 11, 39, 10, 483, DateTimeKind.Unspecified).AddTicks(7522), new TimeSpan(0, 0, 0, 0, 0)), "5cf04f3f-61c7-493c-bbaa-2692ff1cdf30" });

            migrationBuilder.UpdateData(
                schema: "Troshka",
                table: "Locations",
                keyColumn: "Id",
                keyValue: "DUwLGmp9EcEq3WlpZPAt",
                columns: new[] { "DateCreated", "TrackId" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 4, 11, 11, 39, 10, 483, DateTimeKind.Unspecified).AddTicks(8867), new TimeSpan(0, 0, 0, 0, 0)), "bbe60a54-9e29-4df8-8f5f-83dc2f2f7edd" });

            migrationBuilder.UpdateData(
                schema: "Troshka",
                table: "Locations",
                keyColumn: "Id",
                keyValue: "DxK5hs209av1QkpAm0DU",
                columns: new[] { "DateCreated", "TrackId" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 4, 11, 11, 39, 10, 483, DateTimeKind.Unspecified).AddTicks(8426), new TimeSpan(0, 0, 0, 0, 0)), "11041715-5fed-4d2b-8eb4-821fa57d5d86" });

            migrationBuilder.UpdateData(
                schema: "Troshka",
                table: "Locations",
                keyColumn: "Id",
                keyValue: "e0HXhaClTvD2A0rwtnk8",
                columns: new[] { "DateCreated", "TrackId" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 4, 11, 11, 39, 10, 484, DateTimeKind.Unspecified).AddTicks(28), new TimeSpan(0, 0, 0, 0, 0)), "49bc5d28-4dcc-440a-b618-e9ffbe3e65d9" });

            migrationBuilder.UpdateData(
                schema: "Troshka",
                table: "Locations",
                keyColumn: "Id",
                keyValue: "e6WZlTMDT3B7oqZqPIVD",
                columns: new[] { "DateCreated", "TrackId" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 4, 11, 11, 39, 10, 483, DateTimeKind.Unspecified).AddTicks(9005), new TimeSpan(0, 0, 0, 0, 0)), "5e8ebf25-65d6-4036-96b6-086b79206e95" });

            migrationBuilder.UpdateData(
                schema: "Troshka",
                table: "Locations",
                keyColumn: "Id",
                keyValue: "E7yPisre4COe7jyOEBCT",
                columns: new[] { "DateCreated", "TrackId" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 4, 11, 11, 39, 10, 483, DateTimeKind.Unspecified).AddTicks(9163), new TimeSpan(0, 0, 0, 0, 0)), "bbca06ca-a05c-4901-bf64-b4af3ae9c544" });

            migrationBuilder.UpdateData(
                schema: "Troshka",
                table: "Locations",
                keyColumn: "Id",
                keyValue: "Eg5zvbKnhciCCWDjnQoJ",
                columns: new[] { "DateCreated", "TrackId" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 4, 11, 11, 39, 10, 483, DateTimeKind.Unspecified).AddTicks(9619), new TimeSpan(0, 0, 0, 0, 0)), "aaf75abc-340e-4c51-8008-9a05291cb06d" });

            migrationBuilder.UpdateData(
                schema: "Troshka",
                table: "Locations",
                keyColumn: "Id",
                keyValue: "EKkLEcWxNiBqkVhNmeOz",
                columns: new[] { "DateCreated", "TrackId" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 4, 11, 11, 39, 10, 483, DateTimeKind.Unspecified).AddTicks(8439), new TimeSpan(0, 0, 0, 0, 0)), "15257226-8d07-46b5-83af-6349d5152362" });

            migrationBuilder.UpdateData(
                schema: "Troshka",
                table: "Locations",
                keyColumn: "Id",
                keyValue: "eKyPX0e83l5ulQWnQqAI",
                columns: new[] { "DateCreated", "TrackId" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 4, 11, 11, 39, 10, 483, DateTimeKind.Unspecified).AddTicks(8948), new TimeSpan(0, 0, 0, 0, 0)), "ed3b6c72-bff0-4501-92fc-4aa5d36676ad" });

            migrationBuilder.UpdateData(
                schema: "Troshka",
                table: "Locations",
                keyColumn: "Id",
                keyValue: "EyhQMWwBO7hDquOyZ7UR",
                columns: new[] { "DateCreated", "TrackId" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 4, 11, 11, 39, 10, 483, DateTimeKind.Unspecified).AddTicks(8771), new TimeSpan(0, 0, 0, 0, 0)), "053bcb3a-db1c-4f34-a182-56547a764c8b" });

            migrationBuilder.UpdateData(
                schema: "Troshka",
                table: "Locations",
                keyColumn: "Id",
                keyValue: "f0B7ngALDcChR0qeW8Kx",
                columns: new[] { "DateCreated", "TrackId" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 4, 11, 11, 39, 10, 483, DateTimeKind.Unspecified).AddTicks(7949), new TimeSpan(0, 0, 0, 0, 0)), "c07651f5-4964-4854-bafd-72d113caf8d7" });

            migrationBuilder.UpdateData(
                schema: "Troshka",
                table: "Locations",
                keyColumn: "Id",
                keyValue: "f58Np5BqUrjaHzzHcI3B",
                columns: new[] { "DateCreated", "TrackId" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 4, 11, 11, 39, 10, 483, DateTimeKind.Unspecified).AddTicks(9150), new TimeSpan(0, 0, 0, 0, 0)), "b8521f86-a4e9-4712-b71d-c0cc0690ebd4" });

            migrationBuilder.UpdateData(
                schema: "Troshka",
                table: "Locations",
                keyColumn: "Id",
                keyValue: "fAzTPYCw6IPYt7r0nyQt",
                columns: new[] { "DateCreated", "TrackId" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 4, 11, 11, 39, 10, 483, DateTimeKind.Unspecified).AddTicks(9517), new TimeSpan(0, 0, 0, 0, 0)), "80e42df7-36c4-4b3c-98eb-e5e215e7c5a9" });

            migrationBuilder.UpdateData(
                schema: "Troshka",
                table: "Locations",
                keyColumn: "Id",
                keyValue: "fgY39cfPxP44RFl3ufXm",
                columns: new[] { "DateCreated", "TrackId" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 4, 11, 11, 39, 10, 483, DateTimeKind.Unspecified).AddTicks(9790), new TimeSpan(0, 0, 0, 0, 0)), "21462f4d-09f7-4778-9987-b62e750a774a" });

            migrationBuilder.UpdateData(
                schema: "Troshka",
                table: "Locations",
                keyColumn: "Id",
                keyValue: "FHbfSPlAuKWuO2xnrfmB",
                columns: new[] { "DateCreated", "TrackId" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 4, 11, 11, 39, 10, 483, DateTimeKind.Unspecified).AddTicks(9454), new TimeSpan(0, 0, 0, 0, 0)), "629580b9-85c7-489b-93f3-a7a7f4aeaaf3" });

            migrationBuilder.UpdateData(
                schema: "Troshka",
                table: "Locations",
                keyColumn: "Id",
                keyValue: "fjV17FeFYtdG87NIzTTV",
                columns: new[] { "DateCreated", "TrackId" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 4, 11, 11, 39, 10, 483, DateTimeKind.Unspecified).AddTicks(8643), new TimeSpan(0, 0, 0, 0, 0)), "225c72ed-8d6c-4c05-ad83-7a21d1eff303" });

            migrationBuilder.UpdateData(
                schema: "Troshka",
                table: "Locations",
                keyColumn: "Id",
                keyValue: "fz3K8nqEexm4AndgrQi4",
                columns: new[] { "DateCreated", "TrackId" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 4, 11, 11, 39, 10, 483, DateTimeKind.Unspecified).AddTicks(8036), new TimeSpan(0, 0, 0, 0, 0)), "3524e447-f498-4a0c-982a-bc695b719306" });

            migrationBuilder.UpdateData(
                schema: "Troshka",
                table: "Locations",
                keyColumn: "Id",
                keyValue: "G6fX1XjbGqPoS8RLnpnc",
                columns: new[] { "DateCreated", "TrackId" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 4, 11, 11, 39, 10, 483, DateTimeKind.Unspecified).AddTicks(9305), new TimeSpan(0, 0, 0, 0, 0)), "26b6bf8a-08f7-407c-b866-764ebe318ed5" });

            migrationBuilder.UpdateData(
                schema: "Troshka",
                table: "Locations",
                keyColumn: "Id",
                keyValue: "G9twrE4qbivdKWJfpaTn",
                columns: new[] { "DateCreated", "TrackId" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 4, 11, 11, 39, 10, 483, DateTimeKind.Unspecified).AddTicks(9294), new TimeSpan(0, 0, 0, 0, 0)), "7b968789-5d18-4725-bc19-1c5a417f49b8" });

            migrationBuilder.UpdateData(
                schema: "Troshka",
                table: "Locations",
                keyColumn: "Id",
                keyValue: "gaYFbNX9SJExqDV2IGvI",
                columns: new[] { "DateCreated", "TrackId" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 4, 11, 11, 39, 10, 483, DateTimeKind.Unspecified).AddTicks(8030), new TimeSpan(0, 0, 0, 0, 0)), "270c4123-6ac7-4e4f-905f-b69fc7207e1b" });

            migrationBuilder.UpdateData(
                schema: "Troshka",
                table: "Locations",
                keyColumn: "Id",
                keyValue: "GdwsyBgAwg4b5jBslBmv",
                columns: new[] { "DateCreated", "TrackId" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 4, 11, 11, 39, 10, 483, DateTimeKind.Unspecified).AddTicks(8728), new TimeSpan(0, 0, 0, 0, 0)), "bf2373d6-13c7-4ab7-a9a5-225ba35b231a" });

            migrationBuilder.UpdateData(
                schema: "Troshka",
                table: "Locations",
                keyColumn: "Id",
                keyValue: "GGQuu1mCVa2XyHe6OHwd",
                columns: new[] { "DateCreated", "TrackId" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 4, 11, 11, 39, 10, 483, DateTimeKind.Unspecified).AddTicks(8421), new TimeSpan(0, 0, 0, 0, 0)), "c7ba4c4c-74ca-4cf8-b0a9-4e9979285eec" });

            migrationBuilder.UpdateData(
                schema: "Troshka",
                table: "Locations",
                keyColumn: "Id",
                keyValue: "GPKXXzuRLzBmQY8OGUYN",
                columns: new[] { "DateCreated", "TrackId" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 4, 11, 11, 39, 10, 484, DateTimeKind.Unspecified).AddTicks(259), new TimeSpan(0, 0, 0, 0, 0)), "68d5e754-1789-4b33-b811-8d22997d4cc2" });

            migrationBuilder.UpdateData(
                schema: "Troshka",
                table: "Locations",
                keyColumn: "Id",
                keyValue: "GtwBz0xireBoNWHleled",
                columns: new[] { "DateCreated", "TrackId" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 4, 11, 11, 39, 10, 483, DateTimeKind.Unspecified).AddTicks(9607), new TimeSpan(0, 0, 0, 0, 0)), "c3aab792-90af-461e-ad58-5f379e9a878b" });

            migrationBuilder.UpdateData(
                schema: "Troshka",
                table: "Locations",
                keyColumn: "Id",
                keyValue: "GUdg4bsLNwKisWTQ9rHA",
                columns: new[] { "DateCreated", "TrackId" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 4, 11, 11, 39, 10, 483, DateTimeKind.Unspecified).AddTicks(7991), new TimeSpan(0, 0, 0, 0, 0)), "6122ed32-c996-49ac-bcde-fdeafa6b5da8" });

            migrationBuilder.UpdateData(
                schema: "Troshka",
                table: "Locations",
                keyColumn: "Id",
                keyValue: "gvRcMsNyR0UElUrasG12",
                columns: new[] { "DateCreated", "TrackId" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 4, 11, 11, 39, 10, 484, DateTimeKind.Unspecified).AddTicks(146), new TimeSpan(0, 0, 0, 0, 0)), "5a782fce-8277-4924-aaaa-d745dd65919d" });

            migrationBuilder.UpdateData(
                schema: "Troshka",
                table: "Locations",
                keyColumn: "Id",
                keyValue: "Gwe46q5lQ75V8o4b39Lc",
                columns: new[] { "DateCreated", "TrackId" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 4, 11, 11, 39, 10, 484, DateTimeKind.Unspecified).AddTicks(73), new TimeSpan(0, 0, 0, 0, 0)), "de477844-90e1-4c9c-a0e5-7042a5c3259d" });

            migrationBuilder.UpdateData(
                schema: "Troshka",
                table: "Locations",
                keyColumn: "Id",
                keyValue: "GXHYSrHAuQTT3NwQiNod",
                columns: new[] { "DateCreated", "TrackId" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 4, 11, 11, 39, 10, 483, DateTimeKind.Unspecified).AddTicks(8085), new TimeSpan(0, 0, 0, 0, 0)), "85008e14-966b-4777-950e-61f0b43dc428" });

            migrationBuilder.UpdateData(
                schema: "Troshka",
                table: "Locations",
                keyColumn: "Id",
                keyValue: "h7D65pNQ08GHx9b3AcxU",
                columns: new[] { "DateCreated", "TrackId" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 4, 11, 11, 39, 10, 483, DateTimeKind.Unspecified).AddTicks(9715), new TimeSpan(0, 0, 0, 0, 0)), "699bdda0-0f15-45be-8b34-c4f9f923ec92" });

            migrationBuilder.UpdateData(
                schema: "Troshka",
                table: "Locations",
                keyColumn: "Id",
                keyValue: "hcWnu9tdf7PvuUE1Z86G",
                columns: new[] { "DateCreated", "TrackId" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 4, 11, 11, 39, 10, 484, DateTimeKind.Unspecified).AddTicks(108), new TimeSpan(0, 0, 0, 0, 0)), "9f6fd46a-764f-4f48-8f71-b0ebcd62f519" });

            migrationBuilder.UpdateData(
                schema: "Troshka",
                table: "Locations",
                keyColumn: "Id",
                keyValue: "HDEj5O0QzUUz6dXZUQUC",
                columns: new[] { "DateCreated", "TrackId" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 4, 11, 11, 39, 10, 483, DateTimeKind.Unspecified).AddTicks(8815), new TimeSpan(0, 0, 0, 0, 0)), "d8637d8c-d20e-4767-a1c7-6e058841ae13" });

            migrationBuilder.UpdateData(
                schema: "Troshka",
                table: "Locations",
                keyColumn: "Id",
                keyValue: "hfO3HfINfWDV0vWSfNeY",
                columns: new[] { "DateCreated", "TrackId" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 4, 11, 11, 39, 10, 483, DateTimeKind.Unspecified).AddTicks(8734), new TimeSpan(0, 0, 0, 0, 0)), "6318881b-c010-4fc1-9073-40d1e24b18df" });

            migrationBuilder.UpdateData(
                schema: "Troshka",
                table: "Locations",
                keyColumn: "Id",
                keyValue: "hWDOJO1XVbMZtq69lVJo",
                columns: new[] { "DateCreated", "TrackId" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 4, 11, 11, 39, 10, 483, DateTimeKind.Unspecified).AddTicks(8803), new TimeSpan(0, 0, 0, 0, 0)), "05f816d8-5015-4787-b9b0-4744143508b0" });

            migrationBuilder.UpdateData(
                schema: "Troshka",
                table: "Locations",
                keyColumn: "Id",
                keyValue: "hY5scKz0GZmfw1t4hHrg",
                columns: new[] { "DateCreated", "TrackId" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 4, 11, 11, 39, 10, 484, DateTimeKind.Unspecified).AddTicks(35), new TimeSpan(0, 0, 0, 0, 0)), "c3619eb9-9c5c-4ffa-b87e-2fc9b8c0db51" });

            migrationBuilder.UpdateData(
                schema: "Troshka",
                table: "Locations",
                keyColumn: "Id",
                keyValue: "I3o2PelffQGQZ2tg4PCf",
                columns: new[] { "DateCreated", "TrackId" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 4, 11, 11, 39, 10, 484, DateTimeKind.Unspecified).AddTicks(315), new TimeSpan(0, 0, 0, 0, 0)), "3d65cfc3-98fc-4ae1-b3a3-8b72aec061e8" });

            migrationBuilder.UpdateData(
                schema: "Troshka",
                table: "Locations",
                keyColumn: "Id",
                keyValue: "i8zmw7rcQnoJw83TtkbJ",
                columns: new[] { "DateCreated", "TrackId" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 4, 11, 11, 39, 10, 483, DateTimeKind.Unspecified).AddTicks(8389), new TimeSpan(0, 0, 0, 0, 0)), "c53edba3-62a6-4735-adef-a60b8a06b988" });

            migrationBuilder.UpdateData(
                schema: "Troshka",
                table: "Locations",
                keyColumn: "Id",
                keyValue: "ICeAWglJ3SZW8AKlNJJV",
                columns: new[] { "DateCreated", "TrackId" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 4, 11, 11, 39, 10, 484, DateTimeKind.Unspecified).AddTicks(60), new TimeSpan(0, 0, 0, 0, 0)), "ebad1593-361e-43f2-883b-37ec6d21c9bd" });

            migrationBuilder.UpdateData(
                schema: "Troshka",
                table: "Locations",
                keyColumn: "Id",
                keyValue: "IlhkJUtQ8sLs4YnQmRHN",
                columns: new[] { "DateCreated", "TrackId" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 4, 11, 11, 39, 10, 483, DateTimeKind.Unspecified).AddTicks(7624), new TimeSpan(0, 0, 0, 0, 0)), "50a7a66c-2124-40ed-9ea2-9b468f15e28a" });

            migrationBuilder.UpdateData(
                schema: "Troshka",
                table: "Locations",
                keyColumn: "Id",
                keyValue: "iu4VWQqmLdHN17PQdvzH",
                columns: new[] { "DateCreated", "TrackId" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 4, 11, 11, 39, 10, 483, DateTimeKind.Unspecified).AddTicks(9397), new TimeSpan(0, 0, 0, 0, 0)), "6f1abf84-8f8b-4365-9c5a-4a51eda45a82" });

            migrationBuilder.UpdateData(
                schema: "Troshka",
                table: "Locations",
                keyColumn: "Id",
                keyValue: "iWDmKxgAGouVUA50vC4M",
                columns: new[] { "DateCreated", "TrackId" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 4, 11, 11, 39, 10, 484, DateTimeKind.Unspecified).AddTicks(276), new TimeSpan(0, 0, 0, 0, 0)), "f856cb10-1ea5-4002-87ae-8c79f7b181f4" });

            migrationBuilder.UpdateData(
                schema: "Troshka",
                table: "Locations",
                keyColumn: "Id",
                keyValue: "IxJYV5M8k3tW6QNI1XNy",
                columns: new[] { "DateCreated", "TrackId" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 4, 11, 11, 39, 10, 483, DateTimeKind.Unspecified).AddTicks(9139), new TimeSpan(0, 0, 0, 0, 0)), "27d3a30f-970d-491a-a89c-dd2d5ddef8b0" });

            migrationBuilder.UpdateData(
                schema: "Troshka",
                table: "Locations",
                keyColumn: "Id",
                keyValue: "j69zA6NGRTWjfaJiFgAv",
                columns: new[] { "DateCreated", "TrackId" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 4, 11, 11, 39, 10, 484, DateTimeKind.Unspecified).AddTicks(22), new TimeSpan(0, 0, 0, 0, 0)), "62ac4a06-0dd2-4fef-b1f2-917ec35894c5" });

            migrationBuilder.UpdateData(
                schema: "Troshka",
                table: "Locations",
                keyColumn: "Id",
                keyValue: "J9xfAHAcdeoqMZf5Z32o",
                columns: new[] { "DateCreated", "TrackId" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 4, 11, 11, 39, 10, 483, DateTimeKind.Unspecified).AddTicks(8975), new TimeSpan(0, 0, 0, 0, 0)), "afd32fd0-f88f-4e05-8d09-4e3805653ab6" });

            migrationBuilder.UpdateData(
                schema: "Troshka",
                table: "Locations",
                keyColumn: "Id",
                keyValue: "JcR9lG8H05RZRXqxVcdn",
                columns: new[] { "DateCreated", "TrackId" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 4, 11, 11, 39, 10, 484, DateTimeKind.Unspecified).AddTicks(309), new TimeSpan(0, 0, 0, 0, 0)), "32d41e2a-07f1-4456-b2d1-c1ddf94e3b9c" });

            migrationBuilder.UpdateData(
                schema: "Troshka",
                table: "Locations",
                keyColumn: "Id",
                keyValue: "jgBCeqg0TYU2bwGYLlyj",
                columns: new[] { "DateCreated", "TrackId" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 4, 11, 11, 39, 10, 483, DateTimeKind.Unspecified).AddTicks(9471), new TimeSpan(0, 0, 0, 0, 0)), "9fdb7220-c66d-4efe-8111-eb973e338bbb" });

            migrationBuilder.UpdateData(
                schema: "Troshka",
                table: "Locations",
                keyColumn: "Id",
                keyValue: "Jh36r96IWwkRc0jtT8Uz",
                columns: new[] { "DateCreated", "TrackId" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 4, 11, 11, 39, 10, 484, DateTimeKind.Unspecified).AddTicks(95), new TimeSpan(0, 0, 0, 0, 0)), "2b98d9b5-9773-420c-a10e-65d7c3b35d26" });

            migrationBuilder.UpdateData(
                schema: "Troshka",
                table: "Locations",
                keyColumn: "Id",
                keyValue: "jP1vOHqdRr77lzEQOhUV",
                columns: new[] { "DateCreated", "TrackId" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 4, 11, 11, 39, 10, 483, DateTimeKind.Unspecified).AddTicks(9535), new TimeSpan(0, 0, 0, 0, 0)), "d1b9555e-58a0-4361-9371-251011440481" });

            migrationBuilder.UpdateData(
                schema: "Troshka",
                table: "Locations",
                keyColumn: "Id",
                keyValue: "JsJF774TI5lhUXT7lyu6",
                columns: new[] { "DateCreated", "TrackId" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 4, 11, 11, 39, 10, 483, DateTimeKind.Unspecified).AddTicks(7912), new TimeSpan(0, 0, 0, 0, 0)), "a2564dae-15c5-41d1-b12b-ad14e26c6955" });

            migrationBuilder.UpdateData(
                schema: "Troshka",
                table: "Locations",
                keyColumn: "Id",
                keyValue: "jz9QoDqp8nMi3sT5bxrf",
                columns: new[] { "DateCreated", "TrackId" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 4, 11, 11, 39, 10, 483, DateTimeKind.Unspecified).AddTicks(8336), new TimeSpan(0, 0, 0, 0, 0)), "83505941-8543-49f6-afaf-8f0312d27247" });

            migrationBuilder.UpdateData(
                schema: "Troshka",
                table: "Locations",
                keyColumn: "Id",
                keyValue: "k0qeWBID2X22pEgtfvgo",
                columns: new[] { "DateCreated", "TrackId" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 4, 11, 11, 39, 10, 483, DateTimeKind.Unspecified).AddTicks(8005), new TimeSpan(0, 0, 0, 0, 0)), "d6415e70-69ed-43df-9d16-93cce8c61013" });

            migrationBuilder.UpdateData(
                schema: "Troshka",
                table: "Locations",
                keyColumn: "Id",
                keyValue: "K25n9KJ1vxNw3MGsoreR",
                columns: new[] { "DateCreated", "TrackId" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 4, 11, 11, 39, 10, 483, DateTimeKind.Unspecified).AddTicks(8822), new TimeSpan(0, 0, 0, 0, 0)), "567d51c5-bd68-42f2-8f88-c6bde6836def" });

            migrationBuilder.UpdateData(
                schema: "Troshka",
                table: "Locations",
                keyColumn: "Id",
                keyValue: "KmSbHInKfoSIyIlT2gWX",
                columns: new[] { "DateCreated", "TrackId" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 4, 11, 11, 39, 10, 483, DateTimeKind.Unspecified).AddTicks(8395), new TimeSpan(0, 0, 0, 0, 0)), "563ded12-087a-43f2-bff9-f857fb8e7e70" });

            migrationBuilder.UpdateData(
                schema: "Troshka",
                table: "Locations",
                keyColumn: "Id",
                keyValue: "Krd6NYyD0XMYztMGhAiX",
                columns: new[] { "DateCreated", "TrackId" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 4, 11, 11, 39, 10, 483, DateTimeKind.Unspecified).AddTicks(9852), new TimeSpan(0, 0, 0, 0, 0)), "99cd1209-7e78-4ebf-bb6f-d97c2526b251" });

            migrationBuilder.UpdateData(
                schema: "Troshka",
                table: "Locations",
                keyColumn: "Id",
                keyValue: "ktNgoxLzSAUwMztZhavh",
                columns: new[] { "DateCreated", "TrackId" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 4, 11, 11, 39, 10, 483, DateTimeKind.Unspecified).AddTicks(7453), new TimeSpan(0, 0, 0, 0, 0)), "b25c22f4-09d5-4ff3-b384-0796360db20e" });

            migrationBuilder.UpdateData(
                schema: "Troshka",
                table: "Locations",
                keyColumn: "Id",
                keyValue: "KzVg96EpghmFIyTZQXFu",
                columns: new[] { "DateCreated", "TrackId" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 4, 11, 11, 39, 10, 484, DateTimeKind.Unspecified).AddTicks(164), new TimeSpan(0, 0, 0, 0, 0)), "47e8580c-8a8a-4cc3-931b-729e748b2d4a" });

            migrationBuilder.UpdateData(
                schema: "Troshka",
                table: "Locations",
                keyColumn: "Id",
                keyValue: "l2yUOjlKLR2h1V5VrYsi",
                columns: new[] { "DateCreated", "TrackId" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 4, 11, 11, 39, 10, 483, DateTimeKind.Unspecified).AddTicks(7553), new TimeSpan(0, 0, 0, 0, 0)), "e4b78f81-0d7e-4291-a8d3-93122c0a348d" });

            migrationBuilder.UpdateData(
                schema: "Troshka",
                table: "Locations",
                keyColumn: "Id",
                keyValue: "lAdtqn0mI1TymJG9ZH8W",
                columns: new[] { "DateCreated", "TrackId" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 4, 11, 11, 39, 10, 483, DateTimeKind.Unspecified).AddTicks(9822), new TimeSpan(0, 0, 0, 0, 0)), "026cfd53-9395-4e0a-b545-891cbdeb3392" });

            migrationBuilder.UpdateData(
                schema: "Troshka",
                table: "Locations",
                keyColumn: "Id",
                keyValue: "lDcp7H9Ze01LedaVkc1t",
                columns: new[] { "DateCreated", "TrackId" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 4, 11, 11, 39, 10, 483, DateTimeKind.Unspecified).AddTicks(9689), new TimeSpan(0, 0, 0, 0, 0)), "e7d1094b-5565-4ebf-97c2-6fca0df4ebab" });

            migrationBuilder.UpdateData(
                schema: "Troshka",
                table: "Locations",
                keyColumn: "Id",
                keyValue: "LhvYW2Zd57VcnjPFJSSH",
                columns: new[] { "DateCreated", "TrackId" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 4, 11, 11, 39, 10, 483, DateTimeKind.Unspecified).AddTicks(9196), new TimeSpan(0, 0, 0, 0, 0)), "d3f15aa7-c1d4-4eae-9ce4-6e02f03271e9" });

            migrationBuilder.UpdateData(
                schema: "Troshka",
                table: "Locations",
                keyColumn: "Id",
                keyValue: "LMNgjYs8Wlk3fn3BAgwI",
                columns: new[] { "DateCreated", "TrackId" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 4, 11, 11, 39, 10, 484, DateTimeKind.Unspecified).AddTicks(153), new TimeSpan(0, 0, 0, 0, 0)), "379cded1-bb35-48be-b0c7-04df3450c89d" });

            migrationBuilder.UpdateData(
                schema: "Troshka",
                table: "Locations",
                keyColumn: "Id",
                keyValue: "LrGsNZNeH2n6cJIxmXxJ",
                columns: new[] { "DateCreated", "TrackId" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 4, 11, 11, 39, 10, 483, DateTimeKind.Unspecified).AddTicks(9511), new TimeSpan(0, 0, 0, 0, 0)), "800fb83a-020f-4e01-8a92-2de48d6ccd7f" });

            migrationBuilder.UpdateData(
                schema: "Troshka",
                table: "Locations",
                keyColumn: "Id",
                keyValue: "LvGdpqiL8WD3lrR9DTV5",
                columns: new[] { "DateCreated", "TrackId" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 4, 11, 11, 39, 10, 483, DateTimeKind.Unspecified).AddTicks(8624), new TimeSpan(0, 0, 0, 0, 0)), "8d26a594-94f2-4905-9f05-af27c50eaa01" });

            migrationBuilder.UpdateData(
                schema: "Troshka",
                table: "Locations",
                keyColumn: "Id",
                keyValue: "lY3jQ83TvYtUO7AGHTeG",
                columns: new[] { "DateCreated", "TrackId" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 4, 11, 11, 39, 10, 483, DateTimeKind.Unspecified).AddTicks(9758), new TimeSpan(0, 0, 0, 0, 0)), "1144397a-2d55-4484-82fb-2baa269a8d12" });

            migrationBuilder.UpdateData(
                schema: "Troshka",
                table: "Locations",
                keyColumn: "Id",
                keyValue: "M20lrAzqGZHVUI9MA8Wd",
                columns: new[] { "DateCreated", "TrackId" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 4, 11, 11, 39, 10, 484, DateTimeKind.Unspecified).AddTicks(245), new TimeSpan(0, 0, 0, 0, 0)), "47eae271-d140-443b-aa96-33315b5979de" });

            migrationBuilder.UpdateData(
                schema: "Troshka",
                table: "Locations",
                keyColumn: "Id",
                keyValue: "mcqsM242WDKe5RWonk0N",
                columns: new[] { "DateCreated", "TrackId" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 4, 11, 11, 39, 10, 483, DateTimeKind.Unspecified).AddTicks(8630), new TimeSpan(0, 0, 0, 0, 0)), "43657e31-0732-42cd-baa4-b952c1e927e8" });

            migrationBuilder.UpdateData(
                schema: "Troshka",
                table: "Locations",
                keyColumn: "Id",
                keyValue: "mHwqAk1qNheJohLB1Jzd",
                columns: new[] { "DateCreated", "TrackId" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 4, 11, 11, 39, 10, 483, DateTimeKind.Unspecified).AddTicks(7918), new TimeSpan(0, 0, 0, 0, 0)), "1a025b06-0c63-47be-a35e-58104d09b96b" });

            migrationBuilder.UpdateData(
                schema: "Troshka",
                table: "Locations",
                keyColumn: "Id",
                keyValue: "mJ1WHQcCFBdZ8GLGCU3Z",
                columns: new[] { "DateCreated", "TrackId" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 4, 11, 11, 39, 10, 483, DateTimeKind.Unspecified).AddTicks(9233), new TimeSpan(0, 0, 0, 0, 0)), "c118d7fe-1c5a-45cd-a853-b5a92c2c6494" });

            migrationBuilder.UpdateData(
                schema: "Troshka",
                table: "Locations",
                keyColumn: "Id",
                keyValue: "mjSinueV18LNv9TvBaYV",
                columns: new[] { "DateCreated", "TrackId" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 4, 11, 11, 39, 10, 483, DateTimeKind.Unspecified).AddTicks(9828), new TimeSpan(0, 0, 0, 0, 0)), "7b5781c4-c71b-4655-9264-c68d7e54b828" });

            migrationBuilder.UpdateData(
                schema: "Troshka",
                table: "Locations",
                keyColumn: "Id",
                keyValue: "mkCTXyHRMwybEqLo25cz",
                columns: new[] { "DateCreated", "TrackId" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 4, 11, 11, 39, 10, 483, DateTimeKind.Unspecified).AddTicks(9144), new TimeSpan(0, 0, 0, 0, 0)), "9b857735-2baa-4828-8274-d5fd73666a2c" });

            migrationBuilder.UpdateData(
                schema: "Troshka",
                table: "Locations",
                keyColumn: "Id",
                keyValue: "MleUdK6EdxEEgMvRFgvw",
                columns: new[] { "DateCreated", "TrackId" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 4, 11, 11, 39, 10, 484, DateTimeKind.Unspecified).AddTicks(90), new TimeSpan(0, 0, 0, 0, 0)), "1c64e7cc-9309-44a5-b9b8-5a3b8857e3f6" });

            migrationBuilder.UpdateData(
                schema: "Troshka",
                table: "Locations",
                keyColumn: "Id",
                keyValue: "mMScQFWGBGj82JUVSfa8",
                columns: new[] { "DateCreated", "TrackId" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 4, 11, 11, 39, 10, 483, DateTimeKind.Unspecified).AddTicks(9287), new TimeSpan(0, 0, 0, 0, 0)), "c0b50279-8f0e-49d4-991b-35bad63e6d3b" });

            migrationBuilder.UpdateData(
                schema: "Troshka",
                table: "Locations",
                keyColumn: "Id",
                keyValue: "MrQ6MrxoNdLH9AHWd1sZ",
                columns: new[] { "DateCreated", "TrackId" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 4, 11, 11, 39, 10, 483, DateTimeKind.Unspecified).AddTicks(9299), new TimeSpan(0, 0, 0, 0, 0)), "66de9f83-f6cb-457d-b557-0cd3eaf94678" });

            migrationBuilder.UpdateData(
                schema: "Troshka",
                table: "Locations",
                keyColumn: "Id",
                keyValue: "Mslmta38lcifuPv0Epep",
                columns: new[] { "DateCreated", "TrackId" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 4, 11, 11, 39, 10, 483, DateTimeKind.Unspecified).AddTicks(9082), new TimeSpan(0, 0, 0, 0, 0)), "3c04dff1-522f-4f17-8f6b-403e6f578ec1" });

            migrationBuilder.UpdateData(
                schema: "Troshka",
                table: "Locations",
                keyColumn: "Id",
                keyValue: "MWLluWB5yYYo6dNJNfEy",
                columns: new[] { "DateCreated", "TrackId" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 4, 11, 11, 39, 10, 483, DateTimeKind.Unspecified).AddTicks(8408), new TimeSpan(0, 0, 0, 0, 0)), "491304b5-c8b4-4367-b4c1-8f4e5ed0a4b5" });

            migrationBuilder.UpdateData(
                schema: "Troshka",
                table: "Locations",
                keyColumn: "Id",
                keyValue: "N7ZpDTXSfenP8ZWklmhn",
                columns: new[] { "DateCreated", "TrackId" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 4, 11, 11, 39, 10, 483, DateTimeKind.Unspecified).AddTicks(7483), new TimeSpan(0, 0, 0, 0, 0)), "d74b835c-3a0d-4900-9055-79afb1f12eb1" });

            migrationBuilder.UpdateData(
                schema: "Troshka",
                table: "Locations",
                keyColumn: "Id",
                keyValue: "n9ejZ3UFp2QRKGnJBZTQ",
                columns: new[] { "DateCreated", "TrackId" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 4, 11, 11, 39, 10, 483, DateTimeKind.Unspecified).AddTicks(8809), new TimeSpan(0, 0, 0, 0, 0)), "c0a0ea4d-79d0-46b3-b05a-cef63b5e7aa5" });

            migrationBuilder.UpdateData(
                schema: "Troshka",
                table: "Locations",
                keyColumn: "Id",
                keyValue: "neRh5vRSDkskEiRjkGmS",
                columns: new[] { "DateCreated", "TrackId" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 4, 11, 11, 39, 10, 483, DateTimeKind.Unspecified).AddTicks(7572), new TimeSpan(0, 0, 0, 0, 0)), "8a2b481f-1930-4d89-abc6-a86ea6a0b79b" });

            migrationBuilder.UpdateData(
                schema: "Troshka",
                table: "Locations",
                keyColumn: "Id",
                keyValue: "NJ4WrirIVRD2CL5LFVgZ",
                columns: new[] { "DateCreated", "TrackId" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 4, 11, 11, 39, 10, 483, DateTimeKind.Unspecified).AddTicks(8123), new TimeSpan(0, 0, 0, 0, 0)), "c6f29cc0-f906-48de-98e2-32755309738a" });

            migrationBuilder.UpdateData(
                schema: "Troshka",
                table: "Locations",
                keyColumn: "Id",
                keyValue: "NjMzJSgUCrBYha1Zyfz9",
                columns: new[] { "DateCreated", "TrackId" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 4, 11, 11, 39, 10, 483, DateTimeKind.Unspecified).AddTicks(9747), new TimeSpan(0, 0, 0, 0, 0)), "3aa7fb94-b582-4c6e-88e6-16eee2db6921" });

            migrationBuilder.UpdateData(
                schema: "Troshka",
                table: "Locations",
                keyColumn: "Id",
                keyValue: "nKjgqQ7r6rWE89oasS55",
                columns: new[] { "DateCreated", "TrackId" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 4, 11, 11, 39, 10, 483, DateTimeKind.Unspecified).AddTicks(9998), new TimeSpan(0, 0, 0, 0, 0)), "a0108df0-e313-4f72-b3a7-9195f22cd2f2" });

            migrationBuilder.UpdateData(
                schema: "Troshka",
                table: "Locations",
                keyColumn: "Id",
                keyValue: "nT6rVJX6LUwa4voci7P3",
                columns: new[] { "DateCreated", "TrackId" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 4, 11, 11, 39, 10, 483, DateTimeKind.Unspecified).AddTicks(8079), new TimeSpan(0, 0, 0, 0, 0)), "716623bb-773d-43a5-a8de-72c90530550b" });

            migrationBuilder.UpdateData(
                schema: "Troshka",
                table: "Locations",
                keyColumn: "Id",
                keyValue: "nXHE363SurLsIHyCMiBp",
                columns: new[] { "DateCreated", "TrackId" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 4, 11, 11, 39, 10, 483, DateTimeKind.Unspecified).AddTicks(7534), new TimeSpan(0, 0, 0, 0, 0)), "6989eb88-d277-4ff9-81c0-18316cdfd93f" });

            migrationBuilder.UpdateData(
                schema: "Troshka",
                table: "Locations",
                keyColumn: "Id",
                keyValue: "nXrAW7KU9IUVnH36ttyB",
                columns: new[] { "DateCreated", "TrackId" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 4, 11, 11, 39, 10, 483, DateTimeKind.Unspecified).AddTicks(9202), new TimeSpan(0, 0, 0, 0, 0)), "c04b673b-4588-4822-bbb2-9563449fdfa9" });

            migrationBuilder.UpdateData(
                schema: "Troshka",
                table: "Locations",
                keyColumn: "Id",
                keyValue: "o0cKUmrKeP32BdCL110f",
                columns: new[] { "DateCreated", "TrackId" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 4, 11, 11, 39, 10, 483, DateTimeKind.Unspecified).AddTicks(7607), new TimeSpan(0, 0, 0, 0, 0)), "5d975a8c-e187-40d2-8943-2f742c3ee168" });

            migrationBuilder.UpdateData(
                schema: "Troshka",
                table: "Locations",
                keyColumn: "Id",
                keyValue: "o5LA79ma20RbnbEWYkmI",
                columns: new[] { "DateCreated", "TrackId" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 4, 11, 11, 39, 10, 483, DateTimeKind.Unspecified).AddTicks(8309), new TimeSpan(0, 0, 0, 0, 0)), "d2a378cf-feb3-42ab-b637-f3056a5836ea" });

            migrationBuilder.UpdateData(
                schema: "Troshka",
                table: "Locations",
                keyColumn: "Id",
                keyValue: "oAcrUAlW0ogYQ0RbRpVR",
                columns: new[] { "DateCreated", "TrackId" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 4, 11, 11, 39, 10, 483, DateTimeKind.Unspecified).AddTicks(7444), new TimeSpan(0, 0, 0, 0, 0)), "0ede7017-f792-41e3-aa4f-ab9bfa0f688b" });

            migrationBuilder.UpdateData(
                schema: "Troshka",
                table: "Locations",
                keyColumn: "Id",
                keyValue: "oaVzgKrfm2dtvEtulIPH",
                columns: new[] { "DateCreated", "TrackId" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 4, 11, 11, 39, 10, 483, DateTimeKind.Unspecified).AddTicks(8649), new TimeSpan(0, 0, 0, 0, 0)), "cbfb1db9-2abd-4d07-9529-ec0365649ca8" });

            migrationBuilder.UpdateData(
                schema: "Troshka",
                table: "Locations",
                keyColumn: "Id",
                keyValue: "OCfs7lrhfbA9Wg6Rfx5F",
                columns: new[] { "DateCreated", "TrackId" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 4, 11, 11, 39, 10, 483, DateTimeKind.Unspecified).AddTicks(9448), new TimeSpan(0, 0, 0, 0, 0)), "567097a9-f790-43fa-a2fb-767d5051e251" });

            migrationBuilder.UpdateData(
                schema: "Troshka",
                table: "Locations",
                keyColumn: "Id",
                keyValue: "oEevNbxEQnzGOkwJ6yy6",
                columns: new[] { "DateCreated", "TrackId" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 4, 11, 11, 39, 10, 483, DateTimeKind.Unspecified).AddTicks(9275), new TimeSpan(0, 0, 0, 0, 0)), "30777b22-437f-4fbe-9ae5-1a612de4990f" });

            migrationBuilder.UpdateData(
                schema: "Troshka",
                table: "Locations",
                keyColumn: "Id",
                keyValue: "oJ208ZU4uli478vZ4M6i",
                columns: new[] { "DateCreated", "TrackId" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 4, 11, 11, 39, 10, 483, DateTimeKind.Unspecified).AddTicks(7436), new TimeSpan(0, 0, 0, 0, 0)), "9d7362e4-ceb1-46d9-90fd-0ae824038099" });

            migrationBuilder.UpdateData(
                schema: "Troshka",
                table: "Locations",
                keyColumn: "Id",
                keyValue: "OkZdYcu0vosTiBUlsaTK",
                columns: new[] { "DateCreated", "TrackId" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 4, 11, 11, 39, 10, 483, DateTimeKind.Unspecified).AddTicks(9960), new TimeSpan(0, 0, 0, 0, 0)), "c9f25c9f-9c51-4ec2-8aae-b1b030f5c42c" });

            migrationBuilder.UpdateData(
                schema: "Troshka",
                table: "Locations",
                keyColumn: "Id",
                keyValue: "OT5qlZSGxMGbWwUlhaKg",
                columns: new[] { "DateCreated", "TrackId" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 4, 11, 11, 39, 10, 483, DateTimeKind.Unspecified).AddTicks(8704), new TimeSpan(0, 0, 0, 0, 0)), "e38975e2-9701-419b-ad05-54248ef149fc" });

            migrationBuilder.UpdateData(
                schema: "Troshka",
                table: "Locations",
                keyColumn: "Id",
                keyValue: "OULp9a8mh6nxjaqmen44",
                columns: new[] { "DateCreated", "TrackId" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 4, 11, 11, 39, 10, 483, DateTimeKind.Unspecified).AddTicks(7565), new TimeSpan(0, 0, 0, 0, 0)), "ecad1364-a589-420c-ad97-602278549976" });

            migrationBuilder.UpdateData(
                schema: "Troshka",
                table: "Locations",
                keyColumn: "Id",
                keyValue: "OXQIGhEAp5LWzfAAiIMw",
                columns: new[] { "DateCreated", "TrackId" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 4, 11, 11, 39, 10, 483, DateTimeKind.Unspecified).AddTicks(8093), new TimeSpan(0, 0, 0, 0, 0)), "1ffa5550-3c6e-4dd9-8c51-30cad59a6e16" });

            migrationBuilder.UpdateData(
                schema: "Troshka",
                table: "Locations",
                keyColumn: "Id",
                keyValue: "OXw0BOe4VgQX1Dulp8Y7",
                columns: new[] { "DateCreated", "TrackId" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 4, 11, 11, 39, 10, 484, DateTimeKind.Unspecified).AddTicks(66), new TimeSpan(0, 0, 0, 0, 0)), "495d898c-0c5c-4bb5-ac0f-6e299bb8fa5c" });

            migrationBuilder.UpdateData(
                schema: "Troshka",
                table: "Locations",
                keyColumn: "Id",
                keyValue: "p2tNo4gVXkKryIhrQO7O",
                columns: new[] { "DateCreated", "TrackId" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 4, 11, 11, 39, 10, 483, DateTimeKind.Unspecified).AddTicks(9752), new TimeSpan(0, 0, 0, 0, 0)), "46b8be3b-3816-492c-b4e3-5712a432ad59" });

            migrationBuilder.UpdateData(
                schema: "Troshka",
                table: "Locations",
                keyColumn: "Id",
                keyValue: "PJj3P4Dm64a1F2VWqRoA",
                columns: new[] { "DateCreated", "TrackId" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 4, 11, 11, 39, 10, 483, DateTimeKind.Unspecified).AddTicks(8617), new TimeSpan(0, 0, 0, 0, 0)), "f467ad68-29c8-4248-b5f0-a48ee800261c" });

            migrationBuilder.UpdateData(
                schema: "Troshka",
                table: "Locations",
                keyColumn: "Id",
                keyValue: "pm4OxVXHinF0L6nCdnMD",
                columns: new[] { "DateCreated", "TrackId" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 4, 11, 11, 39, 10, 483, DateTimeKind.Unspecified).AddTicks(7619), new TimeSpan(0, 0, 0, 0, 0)), "28397d53-d0fb-492a-816b-401d50ed0fbb" });

            migrationBuilder.UpdateData(
                schema: "Troshka",
                table: "Locations",
                keyColumn: "Id",
                keyValue: "PnW2WNjEeVFRvyrv5ZBt",
                columns: new[] { "DateCreated", "TrackId" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 4, 11, 11, 39, 10, 484, DateTimeKind.Unspecified).AddTicks(171), new TimeSpan(0, 0, 0, 0, 0)), "c10efdd0-f389-4501-b813-e6c8f3690ff1" });

            migrationBuilder.UpdateData(
                schema: "Troshka",
                table: "Locations",
                keyColumn: "Id",
                keyValue: "psNuk1A7JD7egnOkzY7h",
                columns: new[] { "DateCreated", "TrackId" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 4, 11, 11, 39, 10, 483, DateTimeKind.Unspecified).AddTicks(9764), new TimeSpan(0, 0, 0, 0, 0)), "d2ea19c5-e082-4910-932e-25268dc04860" });

            migrationBuilder.UpdateData(
                schema: "Troshka",
                table: "Locations",
                keyColumn: "Id",
                keyValue: "PyyPB23ytzhgST9DVsqT",
                columns: new[] { "DateCreated", "TrackId" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 4, 11, 11, 39, 10, 484, DateTimeKind.Unspecified).AddTicks(16), new TimeSpan(0, 0, 0, 0, 0)), "f8d09c1f-ffa9-4e3c-962f-64dc235e4261" });

            migrationBuilder.UpdateData(
                schema: "Troshka",
                table: "Locations",
                keyColumn: "Id",
                keyValue: "pznK4lXtvyzmSPVnsE7K",
                columns: new[] { "DateCreated", "TrackId" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 4, 11, 11, 39, 10, 483, DateTimeKind.Unspecified).AddTicks(8353), new TimeSpan(0, 0, 0, 0, 0)), "c9242e5e-2812-4a1d-afa2-86c5b9f79d54" });

            migrationBuilder.UpdateData(
                schema: "Troshka",
                table: "Locations",
                keyColumn: "Id",
                keyValue: "QARSrEJj0U53F2F3gZw5",
                columns: new[] { "DateCreated", "TrackId" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 4, 11, 11, 39, 10, 483, DateTimeKind.Unspecified).AddTicks(8969), new TimeSpan(0, 0, 0, 0, 0)), "e6d8b1da-0d59-49e6-84d0-3f43cc5df0f9" });

            migrationBuilder.UpdateData(
                schema: "Troshka",
                table: "Locations",
                keyColumn: "Id",
                keyValue: "qctT3P6FBPGWKggtZQxz",
                columns: new[] { "DateCreated", "TrackId" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 4, 11, 11, 39, 10, 483, DateTimeKind.Unspecified).AddTicks(9953), new TimeSpan(0, 0, 0, 0, 0)), "722adfa1-146e-4198-bab9-e3bd8bb9fa38" });

            migrationBuilder.UpdateData(
                schema: "Troshka",
                table: "Locations",
                keyColumn: "Id",
                keyValue: "QdJXciCjgzXbHUnB0vdc",
                columns: new[] { "DateCreated", "TrackId" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 4, 11, 11, 39, 10, 483, DateTimeKind.Unspecified).AddTicks(8873), new TimeSpan(0, 0, 0, 0, 0)), "40cad603-22c3-4bfa-981f-39704d901c42" });

            migrationBuilder.UpdateData(
                schema: "Troshka",
                table: "Locations",
                keyColumn: "Id",
                keyValue: "QDy1m1rsNP05N2pThvQD",
                columns: new[] { "DateCreated", "TrackId" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 4, 11, 11, 39, 10, 483, DateTimeKind.Unspecified).AddTicks(7528), new TimeSpan(0, 0, 0, 0, 0)), "ea9d92d8-030e-488b-a11f-b2a6728a8e93" });

            migrationBuilder.UpdateData(
                schema: "Troshka",
                table: "Locations",
                keyColumn: "Id",
                keyValue: "QI7qoqQIrRMgOewnFUHl",
                columns: new[] { "DateCreated", "TrackId" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 4, 11, 11, 39, 10, 483, DateTimeKind.Unspecified).AddTicks(9379), new TimeSpan(0, 0, 0, 0, 0)), "ebe54253-87c2-46b9-add6-cae1047e1344" });

            migrationBuilder.UpdateData(
                schema: "Troshka",
                table: "Locations",
                keyColumn: "Id",
                keyValue: "qMj4zvnLsSjVcJIHifMa",
                columns: new[] { "DateCreated", "TrackId" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 4, 11, 11, 39, 10, 483, DateTimeKind.Unspecified).AddTicks(9040), new TimeSpan(0, 0, 0, 0, 0)), "2f4768c3-a2f4-47ee-a11e-4c0812d5d041" });

            migrationBuilder.UpdateData(
                schema: "Troshka",
                table: "Locations",
                keyColumn: "Id",
                keyValue: "qy9lR5La7DGButn4oAWa",
                columns: new[] { "DateCreated", "TrackId" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 4, 11, 11, 39, 10, 483, DateTimeKind.Unspecified).AddTicks(8024), new TimeSpan(0, 0, 0, 0, 0)), "0041ddff-322b-48e0-b006-8055ebef4819" });

            migrationBuilder.UpdateData(
                schema: "Troshka",
                table: "Locations",
                keyColumn: "Id",
                keyValue: "RaapWhH7MlJ4KqXrk1sK",
                columns: new[] { "DateCreated", "TrackId" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 4, 11, 11, 39, 10, 483, DateTimeKind.Unspecified).AddTicks(8011), new TimeSpan(0, 0, 0, 0, 0)), "4fe1ed4a-f69a-4acb-8703-25d059911bff" });

            migrationBuilder.UpdateData(
                schema: "Troshka",
                table: "Locations",
                keyColumn: "Id",
                keyValue: "rawPiSej2aJVSDBqB4OV",
                columns: new[] { "DateCreated", "TrackId" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 4, 11, 11, 39, 10, 484, DateTimeKind.Unspecified).AddTicks(140), new TimeSpan(0, 0, 0, 0, 0)), "d0f197c3-202a-49c1-acb6-6f83c8f8cc82" });

            migrationBuilder.UpdateData(
                schema: "Troshka",
                table: "Locations",
                keyColumn: "Id",
                keyValue: "RDwk0wPVlEf8krGzgn1F",
                columns: new[] { "DateCreated", "TrackId" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 4, 11, 11, 39, 10, 484, DateTimeKind.Unspecified).AddTicks(264), new TimeSpan(0, 0, 0, 0, 0)), "f6300c81-3e43-46b9-84b2-be937abb5efc" });

            migrationBuilder.UpdateData(
                schema: "Troshka",
                table: "Locations",
                keyColumn: "Id",
                keyValue: "rKsGztdt3tpTLP8oJaGm",
                columns: new[] { "DateCreated", "TrackId" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 4, 11, 11, 39, 10, 483, DateTimeKind.Unspecified).AddTicks(7471), new TimeSpan(0, 0, 0, 0, 0)), "eb73ce98-cf56-4b05-a132-1c117f052340" });

            migrationBuilder.UpdateData(
                schema: "Troshka",
                table: "Locations",
                keyColumn: "Id",
                keyValue: "RlHMkFktfQKSYU27BYAd",
                columns: new[] { "DateCreated", "TrackId" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 4, 11, 11, 39, 10, 483, DateTimeKind.Unspecified).AddTicks(9133), new TimeSpan(0, 0, 0, 0, 0)), "d9b44d08-aa73-45e8-854b-562fa62ca479" });

            migrationBuilder.UpdateData(
                schema: "Troshka",
                table: "Locations",
                keyColumn: "Id",
                keyValue: "RQXQFDTvCpoZ0a3Kayho",
                columns: new[] { "DateCreated", "TrackId" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 4, 11, 11, 39, 10, 483, DateTimeKind.Unspecified).AddTicks(9858), new TimeSpan(0, 0, 0, 0, 0)), "2842bf91-0f53-4ee7-a2ba-d7a8ab4b4edf" });

            migrationBuilder.UpdateData(
                schema: "Troshka",
                table: "Locations",
                keyColumn: "Id",
                keyValue: "rQywXXnmGKlGHQnnNhwN",
                columns: new[] { "DateCreated", "TrackId" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 4, 11, 11, 39, 10, 484, DateTimeKind.Unspecified).AddTicks(322), new TimeSpan(0, 0, 0, 0, 0)), "06cbeeca-ae25-43ca-bd72-237b72fbba60" });

            migrationBuilder.UpdateData(
                schema: "Troshka",
                table: "Locations",
                keyColumn: "Id",
                keyValue: "rViPdOyzRTCEfafaZZva",
                columns: new[] { "DateCreated", "TrackId" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 4, 11, 11, 39, 10, 483, DateTimeKind.Unspecified).AddTicks(9437), new TimeSpan(0, 0, 0, 0, 0)), "93fccbdc-1ae3-484e-bb12-b8880d97053c" });

            migrationBuilder.UpdateData(
                schema: "Troshka",
                table: "Locations",
                keyColumn: "Id",
                keyValue: "RxhSMfo1HmcWTgMQZq3K",
                columns: new[] { "DateCreated", "TrackId" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 4, 11, 11, 39, 10, 483, DateTimeKind.Unspecified).AddTicks(9942), new TimeSpan(0, 0, 0, 0, 0)), "101b9000-2845-44ec-aa94-b5f898a29c2e" });

            migrationBuilder.UpdateData(
                schema: "Troshka",
                table: "Locations",
                keyColumn: "Id",
                keyValue: "S1sGzqNFLkd3UFZaAo80",
                columns: new[] { "DateCreated", "TrackId" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 4, 11, 11, 39, 10, 483, DateTimeKind.Unspecified).AddTicks(9547), new TimeSpan(0, 0, 0, 0, 0)), "05f14955-927f-49ec-a911-eab0f601d6aa" });

            migrationBuilder.UpdateData(
                schema: "Troshka",
                table: "Locations",
                keyColumn: "Id",
                keyValue: "S2vkQdfficf7Nt5zW1qQ",
                columns: new[] { "DateCreated", "TrackId" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 4, 11, 11, 39, 10, 483, DateTimeKind.Unspecified).AddTicks(9361), new TimeSpan(0, 0, 0, 0, 0)), "e21d95a3-b8c9-4647-b0bf-7951913bd355" });

            migrationBuilder.UpdateData(
                schema: "Troshka",
                table: "Locations",
                keyColumn: "Id",
                keyValue: "S2w6rTeyOaF1tXhaJ8Jk",
                columns: new[] { "DateCreated", "TrackId" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 4, 11, 11, 39, 10, 483, DateTimeKind.Unspecified).AddTicks(7559), new TimeSpan(0, 0, 0, 0, 0)), "eeba0ef1-12ea-4b31-baa5-17c317032e88" });

            migrationBuilder.UpdateData(
                schema: "Troshka",
                table: "Locations",
                keyColumn: "Id",
                keyValue: "S4kkzIbMy9o6PaBFS1bp",
                columns: new[] { "DateCreated", "TrackId" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 4, 11, 11, 39, 10, 484, DateTimeKind.Unspecified).AddTicks(177), new TimeSpan(0, 0, 0, 0, 0)), "dcb2ee20-8ee3-43d2-93a2-6db194fd20ce" });

            migrationBuilder.UpdateData(
                schema: "Troshka",
                table: "Locations",
                keyColumn: "Id",
                keyValue: "s5pCgajzVG8nPssxC28v",
                columns: new[] { "DateCreated", "TrackId" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 4, 11, 11, 39, 10, 483, DateTimeKind.Unspecified).AddTicks(8074), new TimeSpan(0, 0, 0, 0, 0)), "121444a6-cd98-4f6d-a494-3f92054b4fda" });

            migrationBuilder.UpdateData(
                schema: "Troshka",
                table: "Locations",
                keyColumn: "Id",
                keyValue: "S7um2STVboFUapfqAwjX",
                columns: new[] { "DateCreated", "TrackId" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 4, 11, 11, 39, 10, 483, DateTimeKind.Unspecified).AddTicks(9917), new TimeSpan(0, 0, 0, 0, 0)), "a49bac35-ec89-4514-9f00-8ba8aff06a9c" });

            migrationBuilder.UpdateData(
                schema: "Troshka",
                table: "Locations",
                keyColumn: "Id",
                keyValue: "sB1J1ycWUKtRgMNkZPMs",
                columns: new[] { "DateCreated", "TrackId" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 4, 11, 11, 39, 10, 483, DateTimeKind.Unspecified).AddTicks(9244), new TimeSpan(0, 0, 0, 0, 0)), "d770dd42-30aa-4640-9348-e193426dd6f3" });

            migrationBuilder.UpdateData(
                schema: "Troshka",
                table: "Locations",
                keyColumn: "Id",
                keyValue: "SFS0FQsFpzKsA1bb8z8t",
                columns: new[] { "DateCreated", "TrackId" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 4, 11, 11, 39, 10, 483, DateTimeKind.Unspecified).AddTicks(9368), new TimeSpan(0, 0, 0, 0, 0)), "15440959-1845-4251-bbfc-356e1eda8707" });

            migrationBuilder.UpdateData(
                schema: "Troshka",
                table: "Locations",
                keyColumn: "Id",
                keyValue: "siPMFqiO6URwVNHYeZQe",
                columns: new[] { "DateCreated", "TrackId" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 4, 11, 11, 39, 10, 483, DateTimeKind.Unspecified).AddTicks(9645), new TimeSpan(0, 0, 0, 0, 0)), "a35fd574-e21a-4b8a-823e-dba41379b823" });

            migrationBuilder.UpdateData(
                schema: "Troshka",
                table: "Locations",
                keyColumn: "Id",
                keyValue: "t0rlN2Z8xXtbnjiGbn2g",
                columns: new[] { "DateCreated", "TrackId" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 4, 11, 11, 39, 10, 484, DateTimeKind.Unspecified).AddTicks(252), new TimeSpan(0, 0, 0, 0, 0)), "5619b967-abe8-45b5-8c22-93bef7736d1e" });

            migrationBuilder.UpdateData(
                schema: "Troshka",
                table: "Locations",
                keyColumn: "Id",
                keyValue: "T8SgJhTrIV9JeuZoxWmp",
                columns: new[] { "DateCreated", "TrackId" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 4, 11, 11, 39, 10, 483, DateTimeKind.Unspecified).AddTicks(9902), new TimeSpan(0, 0, 0, 0, 0)), "f5825044-f8d7-4cdc-b323-c5bd6f18ea92" });

            migrationBuilder.UpdateData(
                schema: "Troshka",
                table: "Locations",
                keyColumn: "Id",
                keyValue: "TCw3kE7IFoavq1DbZIQ4",
                columns: new[] { "DateCreated", "TrackId" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 4, 11, 11, 39, 10, 484, DateTimeKind.Unspecified).AddTicks(158), new TimeSpan(0, 0, 0, 0, 0)), "158ea82a-8b91-46ec-b07f-fe4d3060c549" });

            migrationBuilder.UpdateData(
                schema: "Troshka",
                table: "Locations",
                keyColumn: "Id",
                keyValue: "TeV2DdAFfdCOkrbb4CNX",
                columns: new[] { "DateCreated", "TrackId" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 4, 11, 11, 39, 10, 483, DateTimeKind.Unspecified).AddTicks(9385), new TimeSpan(0, 0, 0, 0, 0)), "10fe69c0-3c46-4b0f-8dcd-248a04b29564" });

            migrationBuilder.UpdateData(
                schema: "Troshka",
                table: "Locations",
                keyColumn: "Id",
                keyValue: "TfR3QRJKEIPZ013jXnSy",
                columns: new[] { "DateCreated", "TrackId" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 4, 11, 11, 39, 10, 483, DateTimeKind.Unspecified).AddTicks(9219), new TimeSpan(0, 0, 0, 0, 0)), "441cc810-12b3-4202-8ddb-a19b4243a429" });

            migrationBuilder.UpdateData(
                schema: "Troshka",
                table: "Locations",
                keyColumn: "Id",
                keyValue: "tnvDmxac1e1cknTnvewl",
                columns: new[] { "DateCreated", "TrackId" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 4, 11, 11, 39, 10, 483, DateTimeKind.Unspecified).AddTicks(8848), new TimeSpan(0, 0, 0, 0, 0)), "242c64ff-efa3-4158-9d3b-7ac1c2a52839" });

            migrationBuilder.UpdateData(
                schema: "Troshka",
                table: "Locations",
                keyColumn: "Id",
                keyValue: "tossPcPHuBlDNrBKT570",
                columns: new[] { "DateCreated", "TrackId" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 4, 11, 11, 39, 10, 483, DateTimeKind.Unspecified).AddTicks(9052), new TimeSpan(0, 0, 0, 0, 0)), "a3031909-4fcd-42cb-9948-c366c8056e7e" });

            migrationBuilder.UpdateData(
                schema: "Troshka",
                table: "Locations",
                keyColumn: "Id",
                keyValue: "tWUWYSi2oFeTNgxzijUa",
                columns: new[] { "DateCreated", "TrackId" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 4, 11, 11, 39, 10, 483, DateTimeKind.Unspecified).AddTicks(8884), new TimeSpan(0, 0, 0, 0, 0)), "f50ea703-50a8-48ac-8af6-3c71b0a82968" });

            migrationBuilder.UpdateData(
                schema: "Troshka",
                table: "Locations",
                keyColumn: "Id",
                keyValue: "TZS5F9cqVHqil0FHGjpq",
                columns: new[] { "DateCreated", "TrackId" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 4, 11, 11, 39, 10, 483, DateTimeKind.Unspecified).AddTicks(9677), new TimeSpan(0, 0, 0, 0, 0)), "916a6cfa-7df3-418f-bc05-2dd44420370e" });

            migrationBuilder.UpdateData(
                schema: "Troshka",
                table: "Locations",
                keyColumn: "Id",
                keyValue: "U7FlCWfts6poIKCBCEUU",
                columns: new[] { "DateCreated", "TrackId" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 4, 11, 11, 39, 10, 484, DateTimeKind.Unspecified).AddTicks(189), new TimeSpan(0, 0, 0, 0, 0)), "5bc0f719-bcf1-4480-8de8-e38066a6bb73" });

            migrationBuilder.UpdateData(
                schema: "Troshka",
                table: "Locations",
                keyColumn: "Id",
                keyValue: "ue1Ma8tBRIWUsbflrxM2",
                columns: new[] { "DateCreated", "TrackId" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 4, 11, 11, 39, 10, 483, DateTimeKind.Unspecified).AddTicks(9671), new TimeSpan(0, 0, 0, 0, 0)), "162ed6e7-48ef-4758-8da1-369a6645e0c5" });

            migrationBuilder.UpdateData(
                schema: "Troshka",
                table: "Locations",
                keyColumn: "Id",
                keyValue: "ueZ1MdWK7lmwfn8Z91ap",
                columns: new[] { "DateCreated", "TrackId" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 4, 11, 11, 39, 10, 483, DateTimeKind.Unspecified).AddTicks(9847), new TimeSpan(0, 0, 0, 0, 0)), "2a65a3ba-2792-40f5-92bb-53930deaf871" });

            migrationBuilder.UpdateData(
                schema: "Troshka",
                table: "Locations",
                keyColumn: "Id",
                keyValue: "UFqsRmjk0qf0RLhr0Auj",
                columns: new[] { "DateCreated", "TrackId" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 4, 11, 11, 39, 10, 483, DateTimeKind.Unspecified).AddTicks(9227), new TimeSpan(0, 0, 0, 0, 0)), "204d11dd-b9ad-4083-bd97-5a367ae83ea5" });

            migrationBuilder.UpdateData(
                schema: "Troshka",
                table: "Locations",
                keyColumn: "Id",
                keyValue: "UFVPO52TDL6wvWCmU2ZR",
                columns: new[] { "DateCreated", "TrackId" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 4, 11, 11, 39, 10, 483, DateTimeKind.Unspecified).AddTicks(7601), new TimeSpan(0, 0, 0, 0, 0)), "144d40e1-9f41-48e7-9f01-057a86c062f5" });

            migrationBuilder.UpdateData(
                schema: "Troshka",
                table: "Locations",
                keyColumn: "Id",
                keyValue: "UkaOFcL7n0R9GPOULEYg",
                columns: new[] { "DateCreated", "TrackId" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 4, 11, 11, 39, 10, 484, DateTimeKind.Unspecified).AddTicks(270), new TimeSpan(0, 0, 0, 0, 0)), "2e6a74d8-56fc-4b3d-a234-71e27cd31015" });

            migrationBuilder.UpdateData(
                schema: "Troshka",
                table: "Locations",
                keyColumn: "Id",
                keyValue: "ULEf4zBQJFH3WxKNk8qE",
                columns: new[] { "DateCreated", "TrackId" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 4, 11, 11, 39, 10, 483, DateTimeKind.Unspecified).AddTicks(9595), new TimeSpan(0, 0, 0, 0, 0)), "226a7a88-6de8-4052-bf03-53bea81c31ee" });

            migrationBuilder.UpdateData(
                schema: "Troshka",
                table: "Locations",
                keyColumn: "Id",
                keyValue: "uozP72hWugpEffJ4nCt8",
                columns: new[] { "DateCreated", "TrackId" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 4, 11, 11, 39, 10, 484, DateTimeKind.Unspecified).AddTicks(232), new TimeSpan(0, 0, 0, 0, 0)), "c9b3d002-68f8-46cc-ab5b-922cda7a7b48" });

            migrationBuilder.UpdateData(
                schema: "Troshka",
                table: "Locations",
                keyColumn: "Id",
                keyValue: "uRYk2q61neGVw3zxySGO",
                columns: new[] { "DateCreated", "TrackId" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 4, 11, 11, 39, 10, 483, DateTimeKind.Unspecified).AddTicks(7613), new TimeSpan(0, 0, 0, 0, 0)), "156038c2-0471-430b-82b8-737f77f749c8" });

            migrationBuilder.UpdateData(
                schema: "Troshka",
                table: "Locations",
                keyColumn: "Id",
                keyValue: "uviWBW7fJ2gsQ1lwXmdj",
                columns: new[] { "DateCreated", "TrackId" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 4, 11, 11, 39, 10, 483, DateTimeKind.Unspecified).AddTicks(9281), new TimeSpan(0, 0, 0, 0, 0)), "e94356d3-517a-4ecb-a29b-fd5260bd6232" });

            migrationBuilder.UpdateData(
                schema: "Troshka",
                table: "Locations",
                keyColumn: "Id",
                keyValue: "uwfIrR3Z8Ynyl0MG2A5s",
                columns: new[] { "DateCreated", "TrackId" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 4, 11, 11, 39, 10, 483, DateTimeKind.Unspecified).AddTicks(8401), new TimeSpan(0, 0, 0, 0, 0)), "42a2817e-6a35-4856-892d-096d168434a7" });

            migrationBuilder.UpdateData(
                schema: "Troshka",
                table: "Locations",
                keyColumn: "Id",
                keyValue: "V0LP9OYPgo6qtjJ9zHMi",
                columns: new[] { "DateCreated", "TrackId" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 4, 11, 11, 39, 10, 483, DateTimeKind.Unspecified).AddTicks(9157), new TimeSpan(0, 0, 0, 0, 0)), "3e0c645a-a316-417d-9c62-d8f029cdc82e" });

            migrationBuilder.UpdateData(
                schema: "Troshka",
                table: "Locations",
                keyColumn: "Id",
                keyValue: "v8hGEwckM6erxaGpA72C",
                columns: new[] { "DateCreated", "TrackId" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 4, 11, 11, 39, 10, 483, DateTimeKind.Unspecified).AddTicks(8656), new TimeSpan(0, 0, 0, 0, 0)), "5f579bf8-cf47-4e5e-952d-ca35e6cf9eb0" });

            migrationBuilder.UpdateData(
                schema: "Troshka",
                table: "Locations",
                keyColumn: "Id",
                keyValue: "vdSm3tjuFT4nRQYiGddC",
                columns: new[] { "DateCreated", "TrackId" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 4, 11, 11, 39, 10, 483, DateTimeKind.Unspecified).AddTicks(8110), new TimeSpan(0, 0, 0, 0, 0)), "0f23fcdb-92f8-4cb3-99af-28a8e88c9953" });

            migrationBuilder.UpdateData(
                schema: "Troshka",
                table: "Locations",
                keyColumn: "Id",
                keyValue: "Vfy5GV76GiSUSdOz5mwK",
                columns: new[] { "DateCreated", "TrackId" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 4, 11, 11, 39, 10, 483, DateTimeKind.Unspecified).AddTicks(7944), new TimeSpan(0, 0, 0, 0, 0)), "595656f6-2dd1-48c6-8104-c50e989e73e9" });

            migrationBuilder.UpdateData(
                schema: "Troshka",
                table: "Locations",
                keyColumn: "Id",
                keyValue: "VG0ih8K83XZFUAsfIqvH",
                columns: new[] { "DateCreated", "TrackId" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 4, 11, 11, 39, 10, 483, DateTimeKind.Unspecified).AddTicks(9089), new TimeSpan(0, 0, 0, 0, 0)), "2e272f92-12c8-4cfa-8be4-95293f438df7" });

            migrationBuilder.UpdateData(
                schema: "Troshka",
                table: "Locations",
                keyColumn: "Id",
                keyValue: "vGWAQsutHV7z2BelkL0i",
                columns: new[] { "DateCreated", "TrackId" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 4, 11, 11, 39, 10, 483, DateTimeKind.Unspecified).AddTicks(8323), new TimeSpan(0, 0, 0, 0, 0)), "56b4e831-ee8e-435a-9734-5631fb2f1754" });

            migrationBuilder.UpdateData(
                schema: "Troshka",
                table: "Locations",
                keyColumn: "Id",
                keyValue: "vihA0IRoR5Kl5EEfkVKA",
                columns: new[] { "DateCreated", "TrackId" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 4, 11, 11, 39, 10, 483, DateTimeKind.Unspecified).AddTicks(9683), new TimeSpan(0, 0, 0, 0, 0)), "6af76b84-f492-4f46-becb-d70d0f4a8f84" });

            migrationBuilder.UpdateData(
                schema: "Troshka",
                table: "Locations",
                keyColumn: "Id",
                keyValue: "vmzK8CfKyFJmDVvFPQ2u",
                columns: new[] { "DateCreated", "TrackId" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 4, 11, 11, 39, 10, 484, DateTimeKind.Unspecified).AddTicks(114), new TimeSpan(0, 0, 0, 0, 0)), "89539c8f-c01e-4a1f-a141-0cb1862647e8" });

            migrationBuilder.UpdateData(
                schema: "Troshka",
                table: "Locations",
                keyColumn: "Id",
                keyValue: "Vnt8sAfEcMbGnLsS2WVk",
                columns: new[] { "DateCreated", "TrackId" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 4, 11, 11, 39, 10, 483, DateTimeKind.Unspecified).AddTicks(8341), new TimeSpan(0, 0, 0, 0, 0)), "1ef6cae9-4daa-4977-ace5-37a58466576a" });

            migrationBuilder.UpdateData(
                schema: "Troshka",
                table: "Locations",
                keyColumn: "Id",
                keyValue: "vSQqEMQgaXGdqyiaTLFB",
                columns: new[] { "DateCreated", "TrackId" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 4, 11, 11, 39, 10, 483, DateTimeKind.Unspecified).AddTicks(9046), new TimeSpan(0, 0, 0, 0, 0)), "7d0158a5-a161-4e14-9ff8-7c880bb93c91" });

            migrationBuilder.UpdateData(
                schema: "Troshka",
                table: "Locations",
                keyColumn: "Id",
                keyValue: "VuIX2IXpHEMaONwRXNNc",
                columns: new[] { "DateCreated", "TrackId" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 4, 11, 11, 39, 10, 483, DateTimeKind.Unspecified).AddTicks(8105), new TimeSpan(0, 0, 0, 0, 0)), "d2cb795d-7cb4-4255-8b83-b311730602c8" });

            migrationBuilder.UpdateData(
                schema: "Troshka",
                table: "Locations",
                keyColumn: "Id",
                keyValue: "VuXIqlejSA1q847cQu09",
                columns: new[] { "DateCreated", "TrackId" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 4, 11, 11, 39, 10, 483, DateTimeKind.Unspecified).AddTicks(7649), new TimeSpan(0, 0, 0, 0, 0)), "6bc15b87-ac8e-4abc-87c3-dac7f0cc4d60" });

            migrationBuilder.UpdateData(
                schema: "Troshka",
                table: "Locations",
                keyColumn: "Id",
                keyValue: "w1Sz1FJaKCzennpUAe1k",
                columns: new[] { "DateCreated", "TrackId" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 4, 11, 11, 39, 10, 483, DateTimeKind.Unspecified).AddTicks(9076), new TimeSpan(0, 0, 0, 0, 0)), "28e05862-d408-4891-ac87-75b797fb2328" });

            migrationBuilder.UpdateData(
                schema: "Troshka",
                table: "Locations",
                keyColumn: "Id",
                keyValue: "w9zUArINXv0niL56fPfN",
                columns: new[] { "DateCreated", "TrackId" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 4, 11, 11, 39, 10, 483, DateTimeKind.Unspecified).AddTicks(9779), new TimeSpan(0, 0, 0, 0, 0)), "a1f94bb9-f030-4c6e-a1cf-3bd26464fb0c" });

            migrationBuilder.UpdateData(
                schema: "Troshka",
                table: "Locations",
                keyColumn: "Id",
                keyValue: "wf5BJ3JkTFhZmAvXig4z",
                columns: new[] { "DateCreated", "TrackId" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 4, 11, 11, 39, 10, 483, DateTimeKind.Unspecified).AddTicks(8993), new TimeSpan(0, 0, 0, 0, 0)), "5f94b74e-93aa-47f5-845b-007c8f7b2597" });

            migrationBuilder.UpdateData(
                schema: "Troshka",
                table: "Locations",
                keyColumn: "Id",
                keyValue: "Whp8KN0wly7vyJBV08dx",
                columns: new[] { "DateCreated", "TrackId" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 4, 11, 11, 39, 10, 483, DateTimeKind.Unspecified).AddTicks(7643), new TimeSpan(0, 0, 0, 0, 0)), "12aaf0c2-5a81-404b-bc11-b04825014875" });

            migrationBuilder.UpdateData(
                schema: "Troshka",
                table: "Locations",
                keyColumn: "Id",
                keyValue: "WKmKGc87G61qV36YDZQI",
                columns: new[] { "DateCreated", "TrackId" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 4, 11, 11, 39, 10, 483, DateTimeKind.Unspecified).AddTicks(9064), new TimeSpan(0, 0, 0, 0, 0)), "af03c8ee-d876-49f6-9d67-b9d7761662be" });

            migrationBuilder.UpdateData(
                schema: "Troshka",
                table: "Locations",
                keyColumn: "Id",
                keyValue: "wlwq7kXv477tP5l8h2w6",
                columns: new[] { "DateCreated", "TrackId" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 4, 11, 11, 39, 10, 483, DateTimeKind.Unspecified).AddTicks(8691), new TimeSpan(0, 0, 0, 0, 0)), "e6ce6143-3363-4b3f-88ff-27731cee7664" });

            migrationBuilder.UpdateData(
                schema: "Troshka",
                table: "Locations",
                keyColumn: "Id",
                keyValue: "WNsQxDfQ62aPnftdMy3Y",
                columns: new[] { "DateCreated", "TrackId" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 4, 11, 11, 39, 10, 483, DateTimeKind.Unspecified).AddTicks(7547), new TimeSpan(0, 0, 0, 0, 0)), "7ca9eed0-7b48-4593-8bed-c3e2b6a5a97b" });

            migrationBuilder.UpdateData(
                schema: "Troshka",
                table: "Locations",
                keyColumn: "Id",
                keyValue: "WNylfUSJCwHOuKoxQZto",
                columns: new[] { "DateCreated", "TrackId" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 4, 11, 11, 39, 10, 483, DateTimeKind.Unspecified).AddTicks(8896), new TimeSpan(0, 0, 0, 0, 0)), "7d49f20e-e0af-4811-9ca9-04c4b22b2e23" });

            migrationBuilder.UpdateData(
                schema: "Troshka",
                table: "Locations",
                keyColumn: "Id",
                keyValue: "WQKG79hP3NOpph6GIYmZ",
                columns: new[] { "DateCreated", "TrackId" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 4, 11, 11, 39, 10, 483, DateTimeKind.Unspecified).AddTicks(9632), new TimeSpan(0, 0, 0, 0, 0)), "68d05cae-ce90-4057-829d-e957a8c9f1d4" });

            migrationBuilder.UpdateData(
                schema: "Troshka",
                table: "Locations",
                keyColumn: "Id",
                keyValue: "WwDGt8iofwVBruHGDqvF",
                columns: new[] { "DateCreated", "TrackId" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 4, 11, 11, 39, 10, 483, DateTimeKind.Unspecified).AddTicks(8329), new TimeSpan(0, 0, 0, 0, 0)), "c79b2968-df92-4a72-aa85-466b7fbcfb0d" });

            migrationBuilder.UpdateData(
                schema: "Troshka",
                table: "Locations",
                keyColumn: "Id",
                keyValue: "x6bJPDAAZoGfIMiYm0A1",
                columns: new[] { "DateCreated", "TrackId" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 4, 11, 11, 39, 10, 483, DateTimeKind.Unspecified).AddTicks(8790), new TimeSpan(0, 0, 0, 0, 0)), "cc29ea74-6819-4968-a767-e0471f3c75e0" });

            migrationBuilder.UpdateData(
                schema: "Troshka",
                table: "Locations",
                keyColumn: "Id",
                keyValue: "Xc5DkNFRN3YDCKSXjqmD",
                columns: new[] { "DateCreated", "TrackId" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 4, 11, 11, 39, 10, 483, DateTimeKind.Unspecified).AddTicks(8663), new TimeSpan(0, 0, 0, 0, 0)), "2dfbd0eb-b1fb-494e-a031-c15860919f59" });

            migrationBuilder.UpdateData(
                schema: "Troshka",
                table: "Locations",
                keyColumn: "Id",
                keyValue: "xG94yBtSqXmcNHqlkfpF",
                columns: new[] { "DateCreated", "TrackId" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 4, 11, 11, 39, 10, 483, DateTimeKind.Unspecified).AddTicks(8960), new TimeSpan(0, 0, 0, 0, 0)), "7b8f93c3-e165-4af8-b7b2-4f8d813e59b9" });

            migrationBuilder.UpdateData(
                schema: "Troshka",
                table: "Locations",
                keyColumn: "Id",
                keyValue: "XITLm79cIkPGCUZIseRi",
                columns: new[] { "DateCreated", "TrackId" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 4, 11, 11, 39, 10, 483, DateTimeKind.Unspecified).AddTicks(8300), new TimeSpan(0, 0, 0, 0, 0)), "1b791e10-26df-42f7-a496-30f4db76834e" });

            migrationBuilder.UpdateData(
                schema: "Troshka",
                table: "Locations",
                keyColumn: "Id",
                keyValue: "xnp3ZB1fKARKQ1hlkCew",
                columns: new[] { "DateCreated", "TrackId" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 4, 11, 11, 39, 10, 483, DateTimeKind.Unspecified).AddTicks(9784), new TimeSpan(0, 0, 0, 0, 0)), "6af8a20d-13c0-46f7-9f1e-fbdd546ba8f2" });

            migrationBuilder.UpdateData(
                schema: "Troshka",
                table: "Locations",
                keyColumn: "Id",
                keyValue: "XQiCPslzUNbQ4bGuRTLH",
                columns: new[] { "DateCreated", "TrackId" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 4, 11, 11, 39, 10, 483, DateTimeKind.Unspecified).AddTicks(9639), new TimeSpan(0, 0, 0, 0, 0)), "75af8de0-79af-4ca3-a28a-993f5cb0eebe" });

            migrationBuilder.UpdateData(
                schema: "Troshka",
                table: "Locations",
                keyColumn: "Id",
                keyValue: "XQnjZaeTz0HbMKc25iUO",
                columns: new[] { "DateCreated", "TrackId" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 4, 11, 11, 39, 10, 483, DateTimeKind.Unspecified).AddTicks(8798), new TimeSpan(0, 0, 0, 0, 0)), "e0e68e5d-2add-46b0-b6f4-65d4b0be1c1b" });

            migrationBuilder.UpdateData(
                schema: "Troshka",
                table: "Locations",
                keyColumn: "Id",
                keyValue: "xtviuqZWNHgI8Vm3uDvm",
                columns: new[] { "DateCreated", "TrackId" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 4, 11, 11, 39, 10, 483, DateTimeKind.Unspecified).AddTicks(9613), new TimeSpan(0, 0, 0, 0, 0)), "75cfa26e-fae4-4ba1-889a-e1d79716fdf3" });

            migrationBuilder.UpdateData(
                schema: "Troshka",
                table: "Locations",
                keyColumn: "Id",
                keyValue: "XW6zBYsRpc1kLLE5Kz6m",
                columns: new[] { "DateCreated", "TrackId" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 4, 11, 11, 39, 10, 483, DateTimeKind.Unspecified).AddTicks(8016), new TimeSpan(0, 0, 0, 0, 0)), "88093156-6cc4-4299-8b1c-a9c5008eb00a" });

            migrationBuilder.UpdateData(
                schema: "Troshka",
                table: "Locations",
                keyColumn: "Id",
                keyValue: "XyBpFKul4FhqG6qJbjeJ",
                columns: new[] { "DateCreated", "TrackId" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 4, 11, 11, 39, 10, 483, DateTimeKind.Unspecified).AddTicks(8099), new TimeSpan(0, 0, 0, 0, 0)), "e8bad36a-7564-4369-8605-40b314912d43" });

            migrationBuilder.UpdateData(
                schema: "Troshka",
                table: "Locations",
                keyColumn: "Id",
                keyValue: "xzmKSRB4qDTxvbyF3uRp",
                columns: new[] { "DateCreated", "TrackId" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 4, 11, 11, 39, 10, 483, DateTimeKind.Unspecified).AddTicks(9403), new TimeSpan(0, 0, 0, 0, 0)), "2980cb11-7e8e-46cb-816d-54100ae49e6f" });

            migrationBuilder.UpdateData(
                schema: "Troshka",
                table: "Locations",
                keyColumn: "Id",
                keyValue: "yCK4ieG4tnpBiiDiZenX",
                columns: new[] { "DateCreated", "TrackId" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 4, 11, 11, 39, 10, 483, DateTimeKind.Unspecified).AddTicks(9625), new TimeSpan(0, 0, 0, 0, 0)), "209c687e-d520-4089-a245-d67f30338105" });

            migrationBuilder.UpdateData(
                schema: "Troshka",
                table: "Locations",
                keyColumn: "Id",
                keyValue: "yCp9InZJJIMpwiOkNs19",
                columns: new[] { "DateCreated", "TrackId" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 4, 11, 11, 39, 10, 483, DateTimeKind.Unspecified).AddTicks(9349), new TimeSpan(0, 0, 0, 0, 0)), "07104789-9c2b-48ad-a39f-279f2753b9c7" });

            migrationBuilder.UpdateData(
                schema: "Troshka",
                table: "Locations",
                keyColumn: "Id",
                keyValue: "Yf3xbaXybnoCEGoBzXXp",
                columns: new[] { "DateCreated", "TrackId" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 4, 11, 11, 39, 10, 483, DateTimeKind.Unspecified).AddTicks(9947), new TimeSpan(0, 0, 0, 0, 0)), "fa870f0c-a8af-403d-ba33-eac82f734e60" });

            migrationBuilder.UpdateData(
                schema: "Troshka",
                table: "Locations",
                keyColumn: "Id",
                keyValue: "YlRTjjDvXo6T9jUyAoXm",
                columns: new[] { "DateCreated", "TrackId" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 4, 11, 11, 39, 10, 483, DateTimeKind.Unspecified).AddTicks(7630), new TimeSpan(0, 0, 0, 0, 0)), "d75354f5-be7b-4850-9d37-09c7aeae0161" });

            migrationBuilder.UpdateData(
                schema: "Troshka",
                table: "Locations",
                keyColumn: "Id",
                keyValue: "yltDkNBX68HMpeUHLfOr",
                columns: new[] { "DateCreated", "TrackId" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 4, 11, 11, 39, 10, 483, DateTimeKind.Unspecified).AddTicks(9876), new TimeSpan(0, 0, 0, 0, 0)), "f892d5f5-49ae-4c10-9d65-64e6d06f32b2" });

            migrationBuilder.UpdateData(
                schema: "Troshka",
                table: "Locations",
                keyColumn: "Id",
                keyValue: "YLUdtyrlc6gLjsr7R609",
                columns: new[] { "DateCreated", "TrackId" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 4, 11, 11, 39, 10, 483, DateTimeKind.Unspecified).AddTicks(7490), new TimeSpan(0, 0, 0, 0, 0)), "548e6a9a-7cd4-4400-9beb-8b15b6be9465" });

            migrationBuilder.UpdateData(
                schema: "Troshka",
                table: "Locations",
                keyColumn: "Id",
                keyValue: "YryGMVv9dOjqLh0TT5Ip",
                columns: new[] { "DateCreated", "TrackId" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 4, 11, 11, 39, 10, 483, DateTimeKind.Unspecified).AddTicks(8879), new TimeSpan(0, 0, 0, 0, 0)), "1140cbd9-3c64-4de3-8c0a-0606cea4ac30" });

            migrationBuilder.UpdateData(
                schema: "Troshka",
                table: "Locations",
                keyColumn: "Id",
                keyValue: "YtdC9THcgwBXzcqEKCi5",
                columns: new[] { "DateCreated", "TrackId" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 4, 11, 11, 39, 10, 483, DateTimeKind.Unspecified).AddTicks(7998), new TimeSpan(0, 0, 0, 0, 0)), "ca2e72fc-4d52-458d-a1c9-5e56f396fb4a" });

            migrationBuilder.UpdateData(
                schema: "Troshka",
                table: "Locations",
                keyColumn: "Id",
                keyValue: "yuA0YdFLUb4Xs0ud6awq",
                columns: new[] { "DateCreated", "TrackId" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 4, 11, 11, 39, 10, 483, DateTimeKind.Unspecified).AddTicks(8721), new TimeSpan(0, 0, 0, 0, 0)), "d9641cc4-7565-499f-b676-df1fe219e08b" });

            migrationBuilder.UpdateData(
                schema: "Troshka",
                table: "Locations",
                keyColumn: "Id",
                keyValue: "YUgFQ7igSTdKCm5qBjl4",
                columns: new[] { "DateCreated", "TrackId" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 4, 11, 11, 39, 10, 483, DateTimeKind.Unspecified).AddTicks(9505), new TimeSpan(0, 0, 0, 0, 0)), "3ba4c4a0-7959-4393-ab94-c8080ea7bac6" });

            migrationBuilder.UpdateData(
                schema: "Troshka",
                table: "Locations",
                keyColumn: "Id",
                keyValue: "yURtV8KVpsCiFrfZfUOI",
                columns: new[] { "DateCreated", "TrackId" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 4, 11, 11, 39, 10, 483, DateTimeKind.Unspecified).AddTicks(9841), new TimeSpan(0, 0, 0, 0, 0)), "e46edd53-ef3b-488d-8c23-1e8f5441c6bb" });

            migrationBuilder.UpdateData(
                schema: "Troshka",
                table: "Locations",
                keyColumn: "Id",
                keyValue: "YvNF8L5OFrgNQAt8MyWv",
                columns: new[] { "DateCreated", "TrackId" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 4, 11, 11, 39, 10, 483, DateTimeKind.Unspecified).AddTicks(7477), new TimeSpan(0, 0, 0, 0, 0)), "27458218-a5d0-48ef-95cc-da5ef0150a27" });

            migrationBuilder.UpdateData(
                schema: "Troshka",
                table: "Locations",
                keyColumn: "Id",
                keyValue: "yXx1bXVPWWU4h7uV2zBo",
                columns: new[] { "DateCreated", "TrackId" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 4, 11, 11, 39, 10, 484, DateTimeKind.Unspecified).AddTicks(329), new TimeSpan(0, 0, 0, 0, 0)), "7134b966-29f0-4aaf-8b01-ce6436c0b94c" });

            migrationBuilder.UpdateData(
                schema: "Troshka",
                table: "Locations",
                keyColumn: "Id",
                keyValue: "ZMKNREeEFhom9N1wEbeO",
                columns: new[] { "DateCreated", "TrackId" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 4, 11, 11, 39, 10, 483, DateTimeKind.Unspecified).AddTicks(9429), new TimeSpan(0, 0, 0, 0, 0)), "056f73f3-5abb-40cb-871b-e82e911bef3f" });

            migrationBuilder.UpdateData(
                schema: "Troshka",
                table: "Locations",
                keyColumn: "Id",
                keyValue: "Zp2mKsaYrEc2WBZhjtj7",
                columns: new[] { "DateCreated", "TrackId" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 4, 11, 11, 39, 10, 483, DateTimeKind.Unspecified).AddTicks(8739), new TimeSpan(0, 0, 0, 0, 0)), "04363ae3-1258-419d-aaa0-17613e2afabf" });

            migrationBuilder.UpdateData(
                schema: "Troshka",
                table: "Locations",
                keyColumn: "Id",
                keyValue: "ZZTm6w0YgaHTc4LjEk5d",
                columns: new[] { "DateCreated", "TrackId" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 4, 11, 11, 39, 10, 483, DateTimeKind.Unspecified).AddTicks(9115), new TimeSpan(0, 0, 0, 0, 0)), "34608035-25d3-456a-9ae9-dedbe0630834" });

            migrationBuilder.InsertData(
                schema: "Cars",
                table: "Models",
                columns: new[] { "Id", "CarBrandId", "DateCreated", "DateDeleted", "DateUpdated", "IsDeleted", "Name", "TrackId" },
                values: new object[,]
                {
                    { "02ou3v8CF2F3wuXpcHvh", "5kDhCqXf6JTAIvz61oEz", new DateTimeOffset(new DateTime(2023, 4, 11, 11, 39, 10, 483, DateTimeKind.Unspecified).AddTicks(6038), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "420", "75a67c66-576b-4248-a9a1-b291deab0643" },
                    { "0bfyc9EoF50FnuyjKdje", "5kDhCqXf6JTAIvz61oEz", new DateTimeOffset(new DateTime(2023, 4, 11, 11, 39, 10, 483, DateTimeKind.Unspecified).AddTicks(5929), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "3 Gran Turismo", "a3216fb4-2069-46e3-b81e-f2ffd3e016e5" },
                    { "15M0XenEJr5AdvewD1Lj", "5kDhCqXf6JTAIvz61oEz", new DateTimeOffset(new DateTime(2023, 4, 11, 11, 39, 10, 483, DateTimeKind.Unspecified).AddTicks(6243), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "628", "830acb1b-ebd4-4fd0-8dd2-e1b1534ca564" },
                    { "1BXX4tbCjQRVDyPvNC0e", "5kDhCqXf6JTAIvz61oEz", new DateTimeOffset(new DateTime(2023, 4, 11, 11, 39, 10, 483, DateTimeKind.Unspecified).AddTicks(6617), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "X7", "9540167a-8942-438d-8cdd-e011fce1c3bb" },
                    { "1jyNV2FH0t6FXfBTxt1b", "470SJrcKER8YaPHSS0br", new DateTimeOffset(new DateTime(2023, 4, 11, 11, 39, 10, 483, DateTimeKind.Unspecified).AddTicks(5190), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "Rapide", "6264e68d-4dc9-435d-9e72-020b49f80c3a" },
                    { "1kEYqdGUBcHu7cFX1r0q", "5kDhCqXf6JTAIvz61oEz", new DateTimeOffset(new DateTime(2023, 4, 11, 11, 39, 10, 483, DateTimeKind.Unspecified).AddTicks(6464), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "iX3", "ac8e1a8b-0dca-48ac-babc-b137f9f59034" },
                    { "1pRFqHzTMXN3jJzqjkh1", "5kDhCqXf6JTAIvz61oEz", new DateTimeOffset(new DateTime(2023, 4, 11, 11, 39, 10, 483, DateTimeKind.Unspecified).AddTicks(6470), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "All M-series", "12920a23-23c0-4222-abd7-8dae15de7f3b" },
                    { "1rH1DzMrFhSbPTVzjqwY", "2VS5yLgAuj7VmYeRVxTD", new DateTimeOffset(new DateTime(2023, 4, 11, 11, 39, 10, 483, DateTimeKind.Unspecified).AddTicks(4925), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "Arna", "6ee6805c-a652-420f-b13b-bf4261ade3fd" },
                    { "1T0lmhar1vTmxaPnJoLm", "48xSUCHrRIfABkLmGHxD", new DateTimeOffset(new DateTime(2023, 4, 11, 11, 39, 10, 483, DateTimeKind.Unspecified).AddTicks(5696), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "SQ8", "e9519a26-5f21-4daf-8435-5ede7fd59fa9" },
                    { "1W31KD0Y6T1Pt2uTa16A", "2FEzeyYHYe3zlhjMeaEF", new DateTimeOffset(new DateTime(2023, 4, 11, 11, 39, 10, 483, DateTimeKind.Unspecified).AddTicks(4708), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "Rl", "a830c680-5054-4e11-a068-91240212943b" },
                    { "3EAsksmRLSWDVm0r7uwY", "5kDhCqXf6JTAIvz61oEz", new DateTimeOffset(new DateTime(2023, 4, 11, 11, 39, 10, 483, DateTimeKind.Unspecified).AddTicks(5805), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "116", "40c453ab-9cfb-47d1-b6be-1858542f1e4d" },
                    { "48K4JekuC7u1VQn7D67d", "5kDhCqXf6JTAIvz61oEz", new DateTimeOffset(new DateTime(2023, 4, 11, 11, 39, 10, 483, DateTimeKind.Unspecified).AddTicks(5959), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "320", "f07659c8-6026-435c-8e0d-8f4fcf8c2f86" },
                    { "4ETVKspl5xwsgnWL3lDh", "48xSUCHrRIfABkLmGHxD", new DateTimeOffset(new DateTime(2023, 4, 11, 11, 39, 10, 483, DateTimeKind.Unspecified).AddTicks(5422), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "Q3 Sportback", "af5ff58f-0863-4781-9176-7be38b8b928e" },
                    { "4GQT0aMYEz1fSY6eY8sB", "2SBENlnqR76XRNAjbAs3", new DateTimeOffset(new DateTime(2023, 4, 11, 11, 39, 10, 483, DateTimeKind.Unspecified).AddTicks(4772), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "400", "3f002e54-1237-49c1-ba4e-cd0d349cc7a6" },
                    { "4I11Bn1AvP9nI2mPtX9d", "48xSUCHrRIfABkLmGHxD", new DateTimeOffset(new DateTime(2023, 4, 11, 11, 39, 10, 483, DateTimeKind.Unspecified).AddTicks(5542), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "RS6 Avant", "6d1bfd75-505e-44df-898a-c7e3e872cec6" },
                    { "4jwjB0Crb3pnhQChKtyV", "2xSRLgR4QgzYhDLjfgAM", new DateTimeOffset(new DateTime(2023, 4, 11, 11, 39, 10, 483, DateTimeKind.Unspecified).AddTicks(5073), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "B7", "41182d5a-73a1-4d6b-b597-bb1229ff4d6e" },
                    { "4Lx37Bwu5v07caJb9qQ0", "5kDhCqXf6JTAIvz61oEz", new DateTimeOffset(new DateTime(2023, 4, 11, 11, 39, 10, 483, DateTimeKind.Unspecified).AddTicks(6328), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "740", "27ad3051-6a40-459f-bee6-90659cc0c02c" },
                    { "4oUCJnWsAMChRTcQqkPI", "5kDhCqXf6JTAIvz61oEz", new DateTimeOffset(new DateTime(2023, 4, 11, 11, 39, 10, 483, DateTimeKind.Unspecified).AddTicks(5940), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "315", "151cbd35-b1b8-406e-b8e7-6496d6374436" },
                    { "5dnCbDV8azPHnf9kygDa", "5kDhCqXf6JTAIvz61oEz", new DateTimeOffset(new DateTime(2023, 4, 11, 11, 39, 10, 483, DateTimeKind.Unspecified).AddTicks(6181), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "530", "af77339e-3a64-47aa-a735-e0f538646789" },
                    { "5MNsmv4qukD0lmsAIVWf", "48xSUCHrRIfABkLmGHxD", new DateTimeOffset(new DateTime(2023, 4, 11, 11, 39, 10, 483, DateTimeKind.Unspecified).AddTicks(5659), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "S8", "72e89097-b82a-4865-8765-e9d46ea5daae" },
                    { "5PCvLwD6dpJGCpzNWBuN", "5kDhCqXf6JTAIvz61oEz", new DateTimeOffset(new DateTime(2023, 4, 11, 11, 39, 10, 483, DateTimeKind.Unspecified).AddTicks(5855), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "128", "c71362d9-cd24-4213-a546-3b86f56bdedb" },
                    { "5THRg7LoXQQEpCwVrNdf", "470SJrcKER8YaPHSS0br", new DateTimeOffset(new DateTime(2023, 4, 11, 11, 39, 10, 483, DateTimeKind.Unspecified).AddTicks(5226), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "Vanquish", "cbe68c6b-f5a8-4b7c-a3b9-a4e466143f45" },
                    { "67YCQqod80IcxznEbYWG", "48xSUCHrRIfABkLmGHxD", new DateTimeOffset(new DateTime(2023, 4, 11, 11, 39, 10, 483, DateTimeKind.Unspecified).AddTicks(5386), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "A8", "3cfc5eff-bdac-420f-908e-d46aca6b30cb" },
                    { "6HLXKcue0uYRYyNIjsxA", "5kDhCqXf6JTAIvz61oEz", new DateTimeOffset(new DateTime(2023, 4, 11, 11, 39, 10, 483, DateTimeKind.Unspecified).AddTicks(6487), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "M240i", "8acd4192-2cbf-4510-8a12-0db714930e09" },
                    { "6hQdnWafPTHCqvoqBHH7", "5kDhCqXf6JTAIvz61oEz", new DateTimeOffset(new DateTime(2023, 4, 11, 11, 39, 10, 483, DateTimeKind.Unspecified).AddTicks(6506), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "M5", "d1e07552-ed0a-49f1-8f69-e9a93426e050" },
                    { "6pPAnb6rYwM9fe5bb1zb", "5kDhCqXf6JTAIvz61oEz", new DateTimeOffset(new DateTime(2023, 4, 11, 11, 39, 10, 483, DateTimeKind.Unspecified).AddTicks(6494), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "M3", "1f9ec0ff-67e3-4131-86b1-0441bff76c6d" },
                    { "6tXb8YTBAGwM6suLzEMI", "48xSUCHrRIfABkLmGHxD", new DateTimeOffset(new DateTime(2023, 4, 11, 11, 39, 10, 483, DateTimeKind.Unspecified).AddTicks(5482), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "RS3", "731de07c-3c59-4ebb-b49b-3ac416d16c92" },
                    { "719F6n5YUFR89dGEn2Th", "48xSUCHrRIfABkLmGHxD", new DateTimeOffset(new DateTime(2023, 4, 11, 11, 39, 10, 483, DateTimeKind.Unspecified).AddTicks(5330), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "A5 Sportback", "9944620f-af13-4d16-84f2-25299d0ccc5c" },
                    { "7bT2Tfmosj70qWS5yqzn", "48xSUCHrRIfABkLmGHxD", new DateTimeOffset(new DateTime(2023, 4, 11, 11, 39, 10, 483, DateTimeKind.Unspecified).AddTicks(5690), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "SQ7", "96b06eca-8f97-4f2c-a87b-357b2d985694" },
                    { "7MtcDjXXmGPNgDHmKVI6", "5kDhCqXf6JTAIvz61oEz", new DateTimeOffset(new DateTime(2023, 4, 11, 11, 39, 10, 483, DateTimeKind.Unspecified).AddTicks(5810), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "118", "1c9158fd-df80-4381-9741-1eb546b3e6c6" },
                    { "7w6v0Xwb2HVveB0T1EFn", "5aFWwvagmpfBWQlHxU5M", new DateTimeOffset(new DateTime(2023, 4, 11, 11, 39, 10, 483, DateTimeKind.Unspecified).AddTicks(5763), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "Metro", "d4f6bdfd-79df-48cf-87ef-2ad1091ffd3a" },
                    { "8pBqx2qA2ys4cNHardCp", "5kDhCqXf6JTAIvz61oEz", new DateTimeOffset(new DateTime(2023, 4, 11, 11, 39, 10, 483, DateTimeKind.Unspecified).AddTicks(6623), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "All Z-series", "56bfa230-e2ce-470c-b0d5-766bcfa4cbc7" },
                    { "9uDxeUbRhFKCAAVhdSU9", "2xSRLgR4QgzYhDLjfgAM", new DateTimeOffset(new DateTime(2023, 4, 11, 11, 39, 10, 483, DateTimeKind.Unspecified).AddTicks(5066), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "B6", "ce1ce7cc-4027-434d-91ff-c303e715f46a" },
                    { "A2ahzcpXnnELwActEbpe", "48xSUCHrRIfABkLmGHxD", new DateTimeOffset(new DateTime(2023, 4, 11, 11, 39, 10, 483, DateTimeKind.Unspecified).AddTicks(5453), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "Q5", "7dc29b3c-6819-4a1b-87d4-34e4a10b62a2" },
                    { "a4QvKfmbhDVS61JKsTej", "5kDhCqXf6JTAIvz61oEz", new DateTimeOffset(new DateTime(2023, 4, 11, 11, 39, 10, 483, DateTimeKind.Unspecified).AddTicks(6198), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "545", "e8b4e422-894e-4c78-b9cf-9b276074b137" },
                    { "AHAyq6UwalfeLjhq3rKL", "3yTpJND7nxjtqoDcuc5M", new DateTimeOffset(new DateTime(2023, 4, 11, 11, 39, 10, 483, DateTimeKind.Unspecified).AddTicks(5159), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "Rocsta", "fe3fab21-98df-4cda-864b-f0b4e82c3e07" },
                    { "AI4YMPFffh0hwUhmKAFu", "2VS5yLgAuj7VmYeRVxTD", new DateTimeOffset(new DateTime(2023, 4, 11, 11, 39, 10, 483, DateTimeKind.Unspecified).AddTicks(4865), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "166", "475246bf-63b7-4c39-9f47-934b95d0f2c1" },
                    { "aINSmDNJLmA4sXsV05Hl", "2SBENlnqR76XRNAjbAs3", new DateTimeOffset(new DateTime(2023, 4, 11, 11, 39, 10, 483, DateTimeKind.Unspecified).AddTicks(4778), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "505", "4e0283f1-c36d-41b1-abd9-5886395321a3" },
                    { "ANlb9yRm1dhe9wYwamuB", "2VS5yLgAuj7VmYeRVxTD", new DateTimeOffset(new DateTime(2023, 4, 11, 11, 39, 10, 483, DateTimeKind.Unspecified).AddTicks(4937), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "Crosswagon", "05c5cd05-a8ac-4bd5-a854-5c352780e397" },
                    { "AnrycCM7adRtDbY0TLvW", "48xSUCHrRIfABkLmGHxD", new DateTimeOffset(new DateTime(2023, 4, 11, 11, 39, 10, 483, DateTimeKind.Unspecified).AddTicks(5313), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "A4 Allroad", "ead98e18-4a55-4efa-93b3-e416828b1f1b" },
                    { "AP6rLPKGmQ2PQq5EUWUA", "2VS5yLgAuj7VmYeRVxTD", new DateTimeOffset(new DateTime(2023, 4, 11, 11, 39, 10, 483, DateTimeKind.Unspecified).AddTicks(4931), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "Brera", "69c5b65d-6051-4b51-b1ea-77ee5dd256f5" },
                    { "AsgvpgNKjkSTxdR9ckkp", "48xSUCHrRIfABkLmGHxD", new DateTimeOffset(new DateTime(2023, 4, 11, 11, 39, 10, 483, DateTimeKind.Unspecified).AddTicks(5374), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "A7", "3febfa49-5bf7-4e80-b42a-051e8e6eae25" },
                    { "aX3Vcbqx3fFK3vR5lHpQ", "5aFWwvagmpfBWQlHxU5M", new DateTimeOffset(new DateTime(2023, 4, 11, 11, 39, 10, 483, DateTimeKind.Unspecified).AddTicks(5726), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "Ambassador", "7cc4c057-c855-49b3-adde-52bef0266d9d" },
                    { "ay4g05uI9TjXMJa4kxqF", "48xSUCHrRIfABkLmGHxD", new DateTimeOffset(new DateTime(2023, 4, 11, 11, 39, 10, 483, DateTimeKind.Unspecified).AddTicks(5319), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "A4 Avant", "f1c4d8d1-7ed9-4aec-a311-3f1c425df5bf" },
                    { "bc6Mq8C4SFpUnMtF4zAI", "5kDhCqXf6JTAIvz61oEz", new DateTimeOffset(new DateTime(2023, 4, 11, 11, 39, 10, 483, DateTimeKind.Unspecified).AddTicks(6311), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "728", "f3085ea4-23c5-4f71-820f-290d018ee642" },
                    { "BCCVsH0XUAltrKeEuyW0", "48xSUCHrRIfABkLmGHxD", new DateTimeOffset(new DateTime(2023, 4, 11, 11, 39, 10, 483, DateTimeKind.Unspecified).AddTicks(5347), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "A6 Avant", "84efa51f-0598-4012-b71a-b1e051b4d8ee" },
                    { "Bex1oom6XuTQK9BqbGf8", "48xSUCHrRIfABkLmGHxD", new DateTimeOffset(new DateTime(2023, 4, 11, 11, 39, 10, 483, DateTimeKind.Unspecified).AddTicks(5232), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "100", "c425032e-dd6b-4a9a-959d-d8aa0b53e6b8" },
                    { "bGnvSLMaWVxumEyWCsWw", "48xSUCHrRIfABkLmGHxD", new DateTimeOffset(new DateTime(2023, 4, 11, 11, 39, 10, 483, DateTimeKind.Unspecified).AddTicks(5554), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "RS7 Sportback", "5aca881f-66d5-47c3-b1d7-96dc6dd90421" },
                    { "bKtjeHYxPQ6cw7WELzVH", "2VS5yLgAuj7VmYeRVxTD", new DateTimeOffset(new DateTime(2023, 4, 11, 11, 39, 10, 483, DateTimeKind.Unspecified).AddTicks(4968), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "MiTo", "5abeba24-a1e7-483e-aa79-cf19e5ed3987" },
                    { "blu063mPIqlhSnPnNd7Q", "5kDhCqXf6JTAIvz61oEz", new DateTimeOffset(new DateTime(2023, 4, 11, 11, 39, 10, 483, DateTimeKind.Unspecified).AddTicks(6156), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "523", "12949e0e-b835-4a22-9424-d90f4d85c730" },
                    { "brIy5gkFl6BugII58jGu", "5kDhCqXf6JTAIvz61oEz", new DateTimeOffset(new DateTime(2023, 4, 11, 11, 39, 10, 483, DateTimeKind.Unspecified).AddTicks(6267), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "645", "5a91b851-6a9e-4f05-8700-b33d9d9103f6" },
                    { "BscFAFYQjjJfS6Wlc78q", "2xSRLgR4QgzYhDLjfgAM", new DateTimeOffset(new DateTime(2023, 4, 11, 11, 39, 10, 483, DateTimeKind.Unspecified).AddTicks(5041), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "B5", "f75a2412-958a-4e5f-a611-2b17dd400de2" },
                    { "bwBqLQy6PoaMV2InXxW2", "0SlIJFKD3VdaMAEnxfTT", new DateTimeOffset(new DateTime(2023, 4, 11, 11, 39, 10, 483, DateTimeKind.Unspecified).AddTicks(4668), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "All", "eb91b298-2e80-4090-88fe-dc78373904bb" },
                    { "BxSuvWYkFLsUY6DuFUp4", "5kDhCqXf6JTAIvz61oEz", new DateTimeOffset(new DateTime(2023, 4, 11, 11, 39, 10, 483, DateTimeKind.Unspecified).AddTicks(6090), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "440i", "f2c4a3f3-f57e-48ae-b5dc-545e751df05f" },
                    { "byq3AN4fuByWgJ1XSNqv", "2xSRLgR4QgzYhDLjfgAM", new DateTimeOffset(new DateTime(2023, 4, 11, 11, 39, 10, 483, DateTimeKind.Unspecified).AddTicks(5023), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "B12", "7ba9c179-36e6-47c4-8691-00aca691d58b" },
                    { "c2T5e8jCmm6CIsk0SLs2", "5kDhCqXf6JTAIvz61oEz", new DateTimeOffset(new DateTime(2023, 4, 11, 11, 39, 10, 483, DateTimeKind.Unspecified).AddTicks(6279), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "All 7-series", "341ac89e-b761-4df4-a19b-d4ac68a8a429" },
                    { "C5DCvhzU3bze6eQ2xYkx", "2xSRLgR4QgzYhDLjfgAM", new DateTimeOffset(new DateTime(2023, 4, 11, 11, 39, 10, 483, DateTimeKind.Unspecified).AddTicks(5035), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "B4", "79bb7e44-3beb-4ad8-8c2a-125c5e02f5f9" },
                    { "C9CTaLjVWAYVpafFpMeF", "48xSUCHrRIfABkLmGHxD", new DateTimeOffset(new DateTime(2023, 4, 11, 11, 39, 10, 483, DateTimeKind.Unspecified).AddTicks(5341), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "A6 Allroad", "e10aafcf-7130-4564-aaa3-e136e03da757" },
                    { "CaNj6Jc7njD5GjIvW0T9", "5kDhCqXf6JTAIvz61oEz", new DateTimeOffset(new DateTime(2023, 4, 11, 11, 39, 10, 483, DateTimeKind.Unspecified).AddTicks(6083), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "435i", "af2ce42f-35f6-4ea9-bca6-bdfbd14565bd" },
                    { "ce5jwwR8qr4bgp9eN3BA", "5kDhCqXf6JTAIvz61oEz", new DateTimeOffset(new DateTime(2023, 4, 11, 11, 39, 10, 483, DateTimeKind.Unspecified).AddTicks(6236), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "620d", "a2cf4df6-cc37-423a-9c81-dcaa8b8cd177" },
                    { "CJPP5XSvKA4FLIGufCjC", "2VS5yLgAuj7VmYeRVxTD", new DateTimeOffset(new DateTime(2023, 4, 11, 11, 39, 10, 483, DateTimeKind.Unspecified).AddTicks(4993), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "Spider", "422180e2-ce46-42aa-8790-fadae488593b" },
                    { "CNFtr9KzWHdxd6S4ynff", "2VS5yLgAuj7VmYeRVxTD", new DateTimeOffset(new DateTime(2023, 4, 11, 11, 39, 10, 483, DateTimeKind.Unspecified).AddTicks(4830), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "155", "02b988de-f4bd-45de-9041-98e9a939f9a3" },
                    { "cNGFRPQoyxcPqdnEzTbT", "48xSUCHrRIfABkLmGHxD", new DateTimeOffset(new DateTime(2023, 4, 11, 11, 39, 10, 483, DateTimeKind.Unspecified).AddTicks(5703), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "TT", "879ed016-531b-4d3b-b3b8-5ddb376e40c6" },
                    { "CpdHbNhJGTlNL33GBG0Q", "48xSUCHrRIfABkLmGHxD", new DateTimeOffset(new DateTime(2023, 4, 11, 11, 39, 10, 483, DateTimeKind.Unspecified).AddTicks(5574), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "S1", "9d6d9d34-537e-4d72-9a1f-eed41648037e" },
                    { "CtN2chHHY3dryMG5m9v8", "5kDhCqXf6JTAIvz61oEz", new DateTimeOffset(new DateTime(2023, 4, 11, 11, 39, 10, 483, DateTimeKind.Unspecified).AddTicks(6273), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "650", "013ec321-215d-4bc9-8170-9398759b5bfb" },
                    { "CvopJBj5fUcFUTNRnW6a", "5kDhCqXf6JTAIvz61oEz", new DateTimeOffset(new DateTime(2023, 4, 11, 11, 39, 10, 483, DateTimeKind.Unspecified).AddTicks(6187), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "535", "d3ce33d6-ec7c-4cd3-a8be-4c14fa4b162f" },
                    { "CxuQRTlFShq2f6yScgcF", "2FEzeyYHYe3zlhjMeaEF", new DateTimeOffset(new DateTime(2023, 4, 11, 11, 39, 10, 483, DateTimeKind.Unspecified).AddTicks(4766), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "ZDX", "cd7fa9c4-ab48-4d7b-825f-13ef639af170" },
                    { "cYBY7915yxuKYT0UKexl", "2VS5yLgAuj7VmYeRVxTD", new DateTimeOffset(new DateTime(2023, 4, 11, 11, 39, 10, 483, DateTimeKind.Unspecified).AddTicks(4954), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "GT", "dff61cea-235c-41c9-88e0-bb02f4a9504e" },
                    { "D1csDfv4IoBJEH02eIf7", "5kDhCqXf6JTAIvz61oEz", new DateTimeOffset(new DateTime(2023, 4, 11, 11, 39, 10, 483, DateTimeKind.Unspecified).AddTicks(5878), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "216", "91296b8f-3355-4b3f-b032-2a1338062714" },
                    { "DDybMB4IdDvlyBgaPAR8", "5aFWwvagmpfBWQlHxU5M", new DateTimeOffset(new DateTime(2023, 4, 11, 11, 39, 10, 483, DateTimeKind.Unspecified).AddTicks(5731), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "Maestro", "d8c46152-1f22-41a2-9a83-16238e7114e4" },
                    { "dG0bA6JQ2nUeARTnAsDh", "48xSUCHrRIfABkLmGHxD", new DateTimeOffset(new DateTime(2023, 4, 11, 11, 39, 10, 483, DateTimeKind.Unspecified).AddTicks(5709), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "TT Roadster", "aacf4847-af6b-4f0f-8f30-2f790c4388ca" },
                    { "dIvQ5Gn1QdbPNdj8kThu", "48xSUCHrRIfABkLmGHxD", new DateTimeOffset(new DateTime(2023, 4, 11, 11, 39, 10, 483, DateTimeKind.Unspecified).AddTicks(5239), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "200", "8d0d974a-4aba-40a6-8499-d9efb81aa456" },
                    { "dzxvFU54f7ljnHWFJP96", "48xSUCHrRIfABkLmGHxD", new DateTimeOffset(new DateTime(2023, 4, 11, 11, 39, 10, 483, DateTimeKind.Unspecified).AddTicks(5586), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "S3", "c710147c-32ea-47c9-bdcd-347929f12ebf" },
                    { "E7Nm5XhM4BA0V2PeYgQm", "2xSRLgR4QgzYhDLjfgAM", new DateTimeOffset(new DateTime(2023, 4, 11, 11, 39, 10, 483, DateTimeKind.Unspecified).AddTicks(5089), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "C1", "592ff912-07fd-464d-b82e-dbff1483d70e" },
                    { "EfJn4ynnS35rT6otuGCo", "2FEzeyYHYe3zlhjMeaEF", new DateTimeOffset(new DateTime(2023, 4, 11, 11, 39, 10, 483, DateTimeKind.Unspecified).AddTicks(4747), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "TLX", "34375363-23c8-47a6-bb53-b96e2cee6b53" },
                    { "EHGGMQkx07fPupQQppxo", "5kDhCqXf6JTAIvz61oEz", new DateTimeOffset(new DateTime(2023, 4, 11, 11, 39, 10, 483, DateTimeKind.Unspecified).AddTicks(6580), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "X4", "d8b89e7a-95b2-4257-8c89-89fbc3d00dc5" },
                    { "ELQYNALcwpAAY0A43VLo", "48xSUCHrRIfABkLmGHxD", new DateTimeOffset(new DateTime(2023, 4, 11, 11, 39, 10, 483, DateTimeKind.Unspecified).AddTicks(5335), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "A6", "f4c90a4f-e172-4946-b2e5-0126d103386d" },
                    { "eLvfBuayX92MHMab0fUA", "5kDhCqXf6JTAIvz61oEz", new DateTimeOffset(new DateTime(2023, 4, 11, 11, 39, 10, 483, DateTimeKind.Unspecified).AddTicks(6537), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "M8", "549e7ad0-6c84-416b-bbd7-908a8eb129a3" },
                    { "EN0RlqRnxoNLIF6xN6oE", "48xSUCHrRIfABkLmGHxD", new DateTimeOffset(new DateTime(2023, 4, 11, 11, 39, 10, 483, DateTimeKind.Unspecified).AddTicks(5263), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "A1 Sportback", "a4bf973b-1ba2-4527-882a-4827f56ec789" },
                    { "EPfF9YCm4gKmxxhB8eSy", "48xSUCHrRIfABkLmGHxD", new DateTimeOffset(new DateTime(2023, 4, 11, 11, 39, 10, 483, DateTimeKind.Unspecified).AddTicks(5495), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "RS4", "a6779dcc-1650-437f-9991-b0bf77a6dfda" },
                    { "eRVY4UBabkU9mmkNbuRI", "5kDhCqXf6JTAIvz61oEz", new DateTimeOffset(new DateTime(2023, 4, 11, 11, 39, 10, 483, DateTimeKind.Unspecified).AddTicks(5867), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "2 Gran Tourer", "458374ec-099b-435f-8e5c-ec99b20ad20a" },
                    { "eURGdTpRyGkdCQhlD3jk", "2VS5yLgAuj7VmYeRVxTD", new DateTimeOffset(new DateTime(2023, 4, 11, 11, 39, 10, 483, DateTimeKind.Unspecified).AddTicks(4919), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "Alfetta", "db5297a8-d449-4729-a0f3-8e6812a11dc6" },
                    { "F90vVTgvvVKnKLYhHovu", "48xSUCHrRIfABkLmGHxD", new DateTimeOffset(new DateTime(2023, 4, 11, 11, 39, 10, 483, DateTimeKind.Unspecified).AddTicks(5398), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "E-tron", "0306e143-c30e-48af-8d64-7b61162ba048" },
                    { "feAY3Cmq1vphPgNHPvsG", "5aFWwvagmpfBWQlHxU5M", new DateTimeOffset(new DateTime(2023, 4, 11, 11, 39, 10, 483, DateTimeKind.Unspecified).AddTicks(5720), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "Allegro", "b3a0f20e-70ca-45a3-9a04-5b062e9c6459" },
                    { "fJmXusofopkDd67DQfee", "48xSUCHrRIfABkLmGHxD", new DateTimeOffset(new DateTime(2023, 4, 11, 11, 39, 10, 483, DateTimeKind.Unspecified).AddTicks(5642), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "S6", "0627ca58-76a5-4116-9364-0a077343ee65" },
                    { "fJSRzeTnwU8kBzVU0ayJ", "5kDhCqXf6JTAIvz61oEz", new DateTimeOffset(new DateTime(2023, 4, 11, 11, 39, 10, 483, DateTimeKind.Unspecified).AddTicks(6318), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "730", "08bec4cf-3713-411a-9dd2-6923c70dec0b" },
                    { "FjzDaNSmEQXr0Dm74KsC", "48xSUCHrRIfABkLmGHxD", new DateTimeOffset(new DateTime(2023, 4, 11, 11, 39, 10, 483, DateTimeKind.Unspecified).AddTicks(5684), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "SQ5", "5f7e2694-1776-4774-b144-9d68a457272f" },
                    { "FS2bYCBmXT2gov4qjDYx", "48xSUCHrRIfABkLmGHxD", new DateTimeOffset(new DateTime(2023, 4, 11, 11, 39, 10, 483, DateTimeKind.Unspecified).AddTicks(5629), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "S5", "6d479480-d273-46be-a85e-f8d1b04fcf90" },
                    { "FUlhe0lwljNDAGHm1EP7", "5kDhCqXf6JTAIvz61oEz", new DateTimeOffset(new DateTime(2023, 4, 11, 11, 39, 10, 483, DateTimeKind.Unspecified).AddTicks(6635), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "Z4", "9b881e11-d207-41ab-9ecc-f7db7941535e" },
                    { "FYq5M10U2KLfuEgpdQFn", "5kDhCqXf6JTAIvz61oEz", new DateTimeOffset(new DateTime(2023, 4, 11, 11, 39, 10, 483, DateTimeKind.Unspecified).AddTicks(5946), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "316", "7f5452f6-59fe-4677-b00c-f71394dd0337" },
                    { "g65Y6Ne5W8MWWM1kbL5s", "2VS5yLgAuj7VmYeRVxTD", new DateTimeOffset(new DateTime(2023, 4, 11, 11, 39, 10, 483, DateTimeKind.Unspecified).AddTicks(4790), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "145", "2c59e904-0c75-43d6-a9c0-8dff85ce4957" },
                    { "g94JGR1e1jMrGTa1sgYW", "48xSUCHrRIfABkLmGHxD", new DateTimeOffset(new DateTime(2023, 4, 11, 11, 39, 10, 483, DateTimeKind.Unspecified).AddTicks(5470), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "Q8", "8d69a986-f1f1-4715-a052-4415dec0fe45" },
                    { "GBJDvdYz9dUpvgkD503x", "48xSUCHrRIfABkLmGHxD", new DateTimeOffset(new DateTime(2023, 4, 11, 11, 39, 10, 483, DateTimeKind.Unspecified).AddTicks(5257), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "A1", "2c160a66-1c3b-45b9-8c08-58290d8fa902" },
                    { "GbXDueg2tzXnzzpcMXY6", "2FEzeyYHYe3zlhjMeaEF", new DateTimeOffset(new DateTime(2023, 4, 11, 11, 39, 10, 483, DateTimeKind.Unspecified).AddTicks(4696), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "NSX", "7fa41d9e-3ffa-41f2-9d80-e363083d2e2a" },
                    { "gcYrxL6MHRRPSEKaaHaM", "5kDhCqXf6JTAIvz61oEz", new DateTimeOffset(new DateTime(2023, 4, 11, 11, 39, 10, 483, DateTimeKind.Unspecified).AddTicks(5844), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "123", "f11c6296-6214-4360-8d1d-0b876e55da13" },
                    { "gj42wdfqwalIVSJmcvIW", "48xSUCHrRIfABkLmGHxD", new DateTimeOffset(new DateTime(2023, 4, 11, 11, 39, 10, 483, DateTimeKind.Unspecified).AddTicks(5636), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "S5 Sportback", "2ab6ac54-6019-4a03-a309-3d0ef7516dc3" },
                    { "gmMPfnNpeRz3ypy3Yoe8", "48xSUCHrRIfABkLmGHxD", new DateTimeOffset(new DateTime(2023, 4, 11, 11, 39, 10, 483, DateTimeKind.Unspecified).AddTicks(5293), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "A3", "4b8d93b8-83e6-4909-8d6b-360dad0e4dfe" },
                    { "GPE4xtczgMlj70Ada0CI", "5kDhCqXf6JTAIvz61oEz", new DateTimeOffset(new DateTime(2023, 4, 11, 11, 39, 10, 483, DateTimeKind.Unspecified).AddTicks(5872), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "All 2-series", "6d3a4fa2-2d8b-4c6d-b095-169e8b581ae0" },
                    { "Gs09goAhMe0x07137cWC", "5aFWwvagmpfBWQlHxU5M", new DateTimeOffset(new DateTime(2023, 4, 11, 11, 39, 10, 483, DateTimeKind.Unspecified).AddTicks(5776), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "Mini", "0dc0a5f4-8682-468c-a03f-12cb3bcbcae3" },
                    { "Gulu7urNWpXKdWsRf0Mk", "2FEzeyYHYe3zlhjMeaEF", new DateTimeOffset(new DateTime(2023, 4, 11, 11, 39, 10, 483, DateTimeKind.Unspecified).AddTicks(4753), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "Tl", "4e797d8c-e4d9-4d85-a3bf-01ee9312cccb" },
                    { "gUVqvnuzYLNMPYPEP5e6", "5kDhCqXf6JTAIvz61oEz", new DateTimeOffset(new DateTime(2023, 4, 11, 11, 39, 10, 483, DateTimeKind.Unspecified).AddTicks(6256), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "635", "b96698ef-3143-413b-b1de-cf10b6cc8dc4" },
                    { "GYPy3ly7DpwLWEgWY5u7", "5kDhCqXf6JTAIvz61oEz", new DateTimeOffset(new DateTime(2023, 4, 11, 11, 39, 10, 483, DateTimeKind.Unspecified).AddTicks(6500), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "M4", "5cca704c-54b0-4229-b776-8e06ff4c5732" },
                    { "h1ahgJASNltj9CNxP48p", "5kDhCqXf6JTAIvz61oEz", new DateTimeOffset(new DateTime(2023, 4, 11, 11, 39, 10, 483, DateTimeKind.Unspecified).AddTicks(6027), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "All 4-series", "5600ab18-ed90-4bb4-ba8f-9b2f2902f93c" },
                    { "H3HS2W3xAWPTumDH6QAb", "5kDhCqXf6JTAIvz61oEz", new DateTimeOffset(new DateTime(2023, 4, 11, 11, 39, 10, 483, DateTimeKind.Unspecified).AddTicks(6359), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "840", "9fe4c58e-21fd-4c32-bcea-1dd682e917bb" },
                    { "hHRwEEqyKJyrKv7LysD0", "2xSRLgR4QgzYhDLjfgAM", new DateTimeOffset(new DateTime(2023, 4, 11, 11, 39, 10, 483, DateTimeKind.Unspecified).AddTicks(5084), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "B9", "8ab02c01-2872-4b30-b7cb-5f79186263e2" },
                    { "HmS6qXL0BbGPrKaK7WhG", "48xSUCHrRIfABkLmGHxD", new DateTimeOffset(new DateTime(2023, 4, 11, 11, 39, 10, 483, DateTimeKind.Unspecified).AddTicks(5324), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "A5", "7cf81b2f-2faa-4e9a-bffb-c00353b11cea" },
                    { "HQbAfhmeluvRLDvoPzuT", "2FEzeyYHYe3zlhjMeaEF", new DateTimeOffset(new DateTime(2023, 4, 11, 11, 39, 10, 483, DateTimeKind.Unspecified).AddTicks(4702), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "Rdx", "920b15db-a036-4c7b-a78e-23cd7b87da0f" },
                    { "hSd3gUNHF7VFmp7pyW5f", "5aFWwvagmpfBWQlHxU5M", new DateTimeOffset(new DateTime(2023, 4, 11, 11, 39, 10, 483, DateTimeKind.Unspecified).AddTicks(5736), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "Maxi", "7246e4b3-b6b9-4c3a-b35f-94ae36d6178e" },
                    { "IaR1QKfhncLddtA6HA7K", "5kDhCqXf6JTAIvz61oEz", new DateTimeOffset(new DateTime(2023, 4, 11, 11, 39, 10, 483, DateTimeKind.Unspecified).AddTicks(6419), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "i4", "dd255bc8-7d1c-4791-8127-9d2ee2aeebe9" },
                    { "IKad54P2FLXqEBQNbHbp", "470SJrcKER8YaPHSS0br", new DateTimeOffset(new DateTime(2023, 4, 11, 11, 39, 10, 483, DateTimeKind.Unspecified).AddTicks(5164), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "DBS", "546bb55a-c346-4604-8202-f22225d1b80d" },
                    { "IlLqDmVAjqhvahXMtzbo", "2VS5yLgAuj7VmYeRVxTD", new DateTimeOffset(new DateTime(2023, 4, 11, 11, 39, 10, 483, DateTimeKind.Unspecified).AddTicks(4999), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "Stelvio", "5c654a14-d60b-4434-a0c4-d12eb63aa2fa" },
                    { "IsEFhX33bBwX90f6gdBQ", "5kDhCqXf6JTAIvz61oEz", new DateTimeOffset(new DateTime(2023, 4, 11, 11, 39, 10, 483, DateTimeKind.Unspecified).AddTicks(6007), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "330", "1fe5e3b6-db1d-43e1-a1ec-b42da9c3de4b" },
                    { "ISqlUSdE8PodsAvWq2nF", "5kDhCqXf6JTAIvz61oEz", new DateTimeOffset(new DateTime(2023, 4, 11, 11, 39, 10, 483, DateTimeKind.Unspecified).AddTicks(6176), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "528", "4ba9b904-63b7-4b96-bbd8-63b268eabb77" },
                    { "JawERxfAoj5Lg9o1QRBX", "2VS5yLgAuj7VmYeRVxTD", new DateTimeOffset(new DateTime(2023, 4, 11, 11, 39, 10, 483, DateTimeKind.Unspecified).AddTicks(4816), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "146", "eebeecfe-92b2-4c2d-bfdf-b27f7e7d76c7" },
                    { "JgTJmdhBqQJBIR4QLyDm", "2FEzeyYHYe3zlhjMeaEF", new DateTimeOffset(new DateTime(2023, 4, 11, 11, 39, 10, 483, DateTimeKind.Unspecified).AddTicks(4714), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "Rsx", "7a36883c-ac56-44ac-afdb-f38f318fbad7" },
                    { "jhFlnWeWNXtTPR0no0YT", "5kDhCqXf6JTAIvz61oEz", new DateTimeOffset(new DateTime(2023, 4, 11, 11, 39, 10, 483, DateTimeKind.Unspecified).AddTicks(6285), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "725", "352f913e-57a0-4403-bcc8-f9badd04fcc0" },
                    { "JJBnS7CxUjzn14TVGpWR", "470SJrcKER8YaPHSS0br", new DateTimeOffset(new DateTime(2023, 4, 11, 11, 39, 10, 483, DateTimeKind.Unspecified).AddTicks(5221), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "V8 Vantage", "f12af7a2-4a1b-4c42-9b7d-e5e0f41b9e29" },
                    { "JjhF08DxMUxGJudNjpCX", "48xSUCHrRIfABkLmGHxD", new DateTimeOffset(new DateTime(2023, 4, 11, 11, 39, 10, 483, DateTimeKind.Unspecified).AddTicks(5714), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "TTS", "6df5aa1c-fc27-4377-bb7e-7d061b1e0256" },
                    { "Jnk9ucrHKMmuWgGAjapb", "5kDhCqXf6JTAIvz61oEz", new DateTimeOffset(new DateTime(2023, 4, 11, 11, 39, 10, 483, DateTimeKind.Unspecified).AddTicks(6323), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "735", "28b99a16-4575-4122-ba78-12703ec3e949" },
                    { "jqPSQshtHXFtE4k0VWjk", "5kDhCqXf6JTAIvz61oEz", new DateTimeOffset(new DateTime(2023, 4, 11, 11, 39, 10, 483, DateTimeKind.Unspecified).AddTicks(6096), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "5 Gran Turismo", "255e7e8e-4c19-4df5-8e5b-4c64bbeda442" },
                    { "jsD6dxMpzvCYVHzb2sBd", "48xSUCHrRIfABkLmGHxD", new DateTimeOffset(new DateTime(2023, 4, 11, 11, 39, 10, 483, DateTimeKind.Unspecified).AddTicks(5549), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "RS7", "cb76e17d-20f7-47ab-ab85-eaf8f3c8f73b" },
                    { "k0lbeNfPqbxKJ2rUmqYV", "5kDhCqXf6JTAIvz61oEz", new DateTimeOffset(new DateTime(2023, 4, 11, 11, 39, 10, 483, DateTimeKind.Unspecified).AddTicks(6413), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "i3", "8a37779c-b8b9-4b73-b441-4926fbff8032" },
                    { "k2K1bUsRRwpLh4rUfdEr", "2VS5yLgAuj7VmYeRVxTD", new DateTimeOffset(new DateTime(2023, 4, 11, 11, 39, 10, 483, DateTimeKind.Unspecified).AddTicks(4960), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "GTV", "f1e7b63d-195b-4bb2-82c0-6f1325ceecae" },
                    { "k998a3MQP6ycBzj4rXY2", "2FEzeyYHYe3zlhjMeaEF", new DateTimeOffset(new DateTime(2023, 4, 11, 11, 39, 10, 483, DateTimeKind.Unspecified).AddTicks(4690), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "Mdx", "7b765db0-0522-4e58-89d9-762c83c2334d" },
                    { "kAXHV6pYVbD5dgdARAGY", "5kDhCqXf6JTAIvz61oEz", new DateTimeOffset(new DateTime(2023, 4, 11, 11, 39, 10, 483, DateTimeKind.Unspecified).AddTicks(6204), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "550", "3c891d5a-23c8-4463-a3fb-3d3cef1614c9" },
                    { "kj0UbtyvlCYj6m5qjapa", "5kDhCqXf6JTAIvz61oEz", new DateTimeOffset(new DateTime(2023, 4, 11, 11, 39, 10, 483, DateTimeKind.Unspecified).AddTicks(6396), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "Alpina XD3", "cc9c2bea-e2fe-43f9-9342-9bcdd2aa9861" },
                    { "knYn0wcpoEtwsKm24S94", "5kDhCqXf6JTAIvz61oEz", new DateTimeOffset(new DateTime(2023, 4, 11, 11, 39, 10, 483, DateTimeKind.Unspecified).AddTicks(6407), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "Gran Coupe", "1ad34802-d654-4935-84e9-a4eb60c8f541" },
                    { "KXYrA93YqsVUJwn1xFPp", "2VS5yLgAuj7VmYeRVxTD", new DateTimeOffset(new DateTime(2023, 4, 11, 11, 39, 10, 483, DateTimeKind.Unspecified).AddTicks(4835), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "156", "5ec95452-cbc9-41d5-94f2-e1334634600f" },
                    { "KyV3lBflXsIUlTlEIbfy", "48xSUCHrRIfABkLmGHxD", new DateTimeOffset(new DateTime(2023, 4, 11, 11, 39, 10, 483, DateTimeKind.Unspecified).AddTicks(5410), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "Q2", "78a0ad14-4005-4b82-b74f-4bffd588f2bb" },
                    { "L3qkfxgd6tMvKfAzmgC2", "5kDhCqXf6JTAIvz61oEz", new DateTimeOffset(new DateTime(2023, 4, 11, 11, 39, 10, 483, DateTimeKind.Unspecified).AddTicks(6077), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "435", "6c2d684a-f0ba-4bc8-84c6-7b1ab8c3bcfc" },
                    { "L5jqIPmjk0PaD43lclpj", "5kDhCqXf6JTAIvz61oEz", new DateTimeOffset(new DateTime(2023, 4, 11, 11, 39, 10, 483, DateTimeKind.Unspecified).AddTicks(6574), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "X3", "9ec034dd-91d7-4743-9dd5-1998c5da27c2" },
                    { "LAcvlURodT0DDGg29u11", "5kDhCqXf6JTAIvz61oEz", new DateTimeOffset(new DateTime(2023, 4, 11, 11, 39, 10, 483, DateTimeKind.Unspecified).AddTicks(6364), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "850", "0d6ac54c-3249-4147-8c3a-178dbd130066" },
                    { "lFb3tseSCC0zjAlEu6KN", "2VS5yLgAuj7VmYeRVxTD", new DateTimeOffset(new DateTime(2023, 4, 11, 11, 39, 10, 483, DateTimeKind.Unspecified).AddTicks(4943), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "Giulia", "286eb1db-5c88-493d-9ac5-e797d57d571e" },
                    { "LnTSKdwhMAs1XnqffsCb", "5kDhCqXf6JTAIvz61oEz", new DateTimeOffset(new DateTime(2023, 4, 11, 11, 39, 10, 483, DateTimeKind.Unspecified).AddTicks(6346), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "750IL", "ecd2118f-3c95-494f-a141-b02558bf1871" },
                    { "LphcdjHjpasuHpMokRr8", "5kDhCqXf6JTAIvz61oEz", new DateTimeOffset(new DateTime(2023, 4, 11, 11, 39, 10, 483, DateTimeKind.Unspecified).AddTicks(6481), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "M2", "bad352ec-def6-4a5b-912b-282d7e8e553b" },
                    { "lu9LqDx5AJzonlqDfxmn", "5kDhCqXf6JTAIvz61oEz", new DateTimeOffset(new DateTime(2023, 4, 11, 11, 39, 10, 483, DateTimeKind.Unspecified).AddTicks(5917), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "228", "5bb23d34-1a15-4da8-9b8d-7c073be39518" },
                    { "lwohUeP6mGh7gNTsJVd0", "2xSRLgR4QgzYhDLjfgAM", new DateTimeOffset(new DateTime(2023, 4, 11, 11, 39, 10, 483, DateTimeKind.Unspecified).AddTicks(5104), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "D3", "2fc7f84e-0534-4ad8-9356-c2bc3c2ba25e" },
                    { "lXaz1PUCpmIw4YDL8q85", "5kDhCqXf6JTAIvz61oEz", new DateTimeOffset(new DateTime(2023, 4, 11, 11, 39, 10, 483, DateTimeKind.Unspecified).AddTicks(6013), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "335", "55197995-d246-4aad-87c9-aeb57e1c7d3b" },
                    { "m1HlHc849BVPq5pycUhh", "5kDhCqXf6JTAIvz61oEz", new DateTimeOffset(new DateTime(2023, 4, 11, 11, 39, 10, 483, DateTimeKind.Unspecified).AddTicks(6162), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "524", "8ee7ef86-7e18-482f-96ad-874140ba8f1c" },
                    { "M4x9BV0yxbocgW7F6gzV", "2FEzeyYHYe3zlhjMeaEF", new DateTimeOffset(new DateTime(2023, 4, 11, 11, 39, 10, 483, DateTimeKind.Unspecified).AddTicks(4741), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "Slx", "4a40be66-34cb-4173-ac8e-cf7f5d86dfe2" },
                    { "MdympetsemdCQeWQ2Uhc", "2VS5yLgAuj7VmYeRVxTD", new DateTimeOffset(new DateTime(2023, 4, 11, 11, 39, 10, 483, DateTimeKind.Unspecified).AddTicks(4871), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "33", "592d0553-fb11-4b4a-b938-6aca580bd336" },
                    { "me19B1bHzqP8fUoYEJ6w", "2xSRLgR4QgzYhDLjfgAM", new DateTimeOffset(new DateTime(2023, 4, 11, 11, 39, 10, 483, DateTimeKind.Unspecified).AddTicks(5147), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "XD3", "661ce5a4-6d85-49a7-b800-60f87b43a417" },
                    { "MLJEeKjPMD7p2E4V9yru", "2VS5yLgAuj7VmYeRVxTD", new DateTimeOffset(new DateTime(2023, 4, 11, 11, 39, 10, 483, DateTimeKind.Unspecified).AddTicks(4948), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "Giulietta", "cfb1629b-01bc-4818-b456-4a7082e34781" },
                    { "msDQhJSKuySCV5jcXcPH", "5kDhCqXf6JTAIvz61oEz", new DateTimeOffset(new DateTime(2023, 4, 11, 11, 39, 10, 483, DateTimeKind.Unspecified).AddTicks(5990), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "324", "0fc4dc38-f5e3-434b-b1c5-5e645db0dddd" },
                    { "n4aK8REHYKK4Da1Ej7MH", "5kDhCqXf6JTAIvz61oEz", new DateTimeOffset(new DateTime(2023, 4, 11, 11, 39, 10, 483, DateTimeKind.Unspecified).AddTicks(5935), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "All 3-series", "ac258cc7-894c-4b59-8db1-29a47cbff7d6" },
                    { "n8xh44259tJbDDPV2XJg", "5kDhCqXf6JTAIvz61oEz", new DateTimeOffset(new DateTime(2023, 4, 11, 11, 39, 10, 483, DateTimeKind.Unspecified).AddTicks(5996), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "325", "d3114485-ab1e-4b73-834c-95690f93ffb4" },
                    { "NekGGPYsherm6gTH202f", "2xSRLgR4QgzYhDLjfgAM", new DateTimeOffset(new DateTime(2023, 4, 11, 11, 39, 10, 483, DateTimeKind.Unspecified).AddTicks(5109), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "D4", "3ac5228f-75f8-4ceb-bbf1-dfef299edb10" },
                    { "NkEjCDRl5c3qwgyMtND7", "470SJrcKER8YaPHSS0br", new DateTimeOffset(new DateTime(2023, 4, 11, 11, 39, 10, 483, DateTimeKind.Unspecified).AddTicks(5177), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "Db7", "f515f639-eb14-4218-bde4-cc2d56b9c318" },
                    { "nPvvwGx0JzsFR9e4N7Fw", "5kDhCqXf6JTAIvz61oEz", new DateTimeOffset(new DateTime(2023, 4, 11, 11, 39, 10, 483, DateTimeKind.Unspecified).AddTicks(6591), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "X6", "ad8369ab-f61f-4c54-8ad0-c4582b2c1da0" },
                    { "Nz5w4whgUrJxmo7ujhuu", "5kDhCqXf6JTAIvz61oEz", new DateTimeOffset(new DateTime(2023, 4, 11, 11, 39, 10, 483, DateTimeKind.Unspecified).AddTicks(5911), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "220", "aa35e404-167d-4e4a-8bdf-62813e00a610" },
                    { "o2UaRk8B87gNQQR0Dyfb", "5kDhCqXf6JTAIvz61oEz", new DateTimeOffset(new DateTime(2023, 4, 11, 11, 39, 10, 483, DateTimeKind.Unspecified).AddTicks(5838), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "120", "55dd688c-913d-4b46-8a04-cec6ab3a3357" },
                    { "o9WkVwIEU28LaCV8kJEQ", "48xSUCHrRIfABkLmGHxD", new DateTimeOffset(new DateTime(2023, 4, 11, 11, 39, 10, 483, DateTimeKind.Unspecified).AddTicks(5245), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "80", "02102657-d41b-43ab-a180-8edeaecb003d" },
                    { "oDJncLBGoHrqTNGTwMtV", "48xSUCHrRIfABkLmGHxD", new DateTimeOffset(new DateTime(2023, 4, 11, 11, 39, 10, 483, DateTimeKind.Unspecified).AddTicks(5380), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "A7 Sportback", "3c7376b2-2da0-4e9e-8809-08f856a64cd8" },
                    { "oelzQ4purnelV64XnKcF", "5kDhCqXf6JTAIvz61oEz", new DateTimeOffset(new DateTime(2023, 4, 11, 11, 39, 10, 483, DateTimeKind.Unspecified).AddTicks(5861), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "135", "a12ed07d-d667-470c-8d4c-4b4c7c27e8cc" },
                    { "oKbjhgWsh89c8oMXVDK1", "2VS5yLgAuj7VmYeRVxTD", new DateTimeOffset(new DateTime(2023, 4, 11, 11, 39, 10, 483, DateTimeKind.Unspecified).AddTicks(4859), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "164", "baf8799a-e273-40fe-ba61-4a560a53396f" },
                    { "oY4glkSkb7PrtAT7FpLK", "5kDhCqXf6JTAIvz61oEz", new DateTimeOffset(new DateTime(2023, 4, 11, 11, 39, 10, 483, DateTimeKind.Unspecified).AddTicks(5885), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "218", "bc45715c-0359-4518-b912-56d4bc886e41" },
                    { "P6v2KSwEXaFvuJ96vkAp", "5kDhCqXf6JTAIvz61oEz", new DateTimeOffset(new DateTime(2023, 4, 11, 11, 39, 10, 483, DateTimeKind.Unspecified).AddTicks(6550), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "X6 M", "6c486181-e609-4768-92b5-1d6db94c6148" },
                    { "pbE1oQ2C3dFSeckEEs93", "2xSRLgR4QgzYhDLjfgAM", new DateTimeOffset(new DateTime(2023, 4, 11, 11, 39, 10, 483, DateTimeKind.Unspecified).AddTicks(5017), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "B11", "fcd3df20-85ec-447e-894c-e03c7989b83b" },
                    { "pCbFHTuzXIC1hUtgL2go", "2xSRLgR4QgzYhDLjfgAM", new DateTimeOffset(new DateTime(2023, 4, 11, 11, 39, 10, 483, DateTimeKind.Unspecified).AddTicks(5116), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "D5", "ed901d44-cba1-4515-b95c-1aeb5b985cb9" },
                    { "pct4pqnYgAUhv8BUQ43b", "48xSUCHrRIfABkLmGHxD", new DateTimeOffset(new DateTime(2023, 4, 11, 11, 39, 10, 483, DateTimeKind.Unspecified).AddTicks(5251), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "90", "5a4d27dd-cc98-45c2-8f31-a3d79833a0a0" },
                    { "PlGp4odGKDAkEEvoL7qX", "5aFWwvagmpfBWQlHxU5M", new DateTimeOffset(new DateTime(2023, 4, 11, 11, 39, 10, 483, DateTimeKind.Unspecified).AddTicks(5770), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "Mg", "e87ba49b-f4c6-4775-9089-10f4e299bf08" },
                    { "pUTzAqBudg67k4bqWcJT", "5kDhCqXf6JTAIvz61oEz", new DateTimeOffset(new DateTime(2023, 4, 11, 11, 39, 10, 483, DateTimeKind.Unspecified).AddTicks(6109), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "518", "ec45885f-1c6c-4ca2-b2c6-c4368d503bf4" },
                    { "pwnUgQMV48UXDmJ0jtgw", "5kDhCqXf6JTAIvz61oEz", new DateTimeOffset(new DateTime(2023, 4, 11, 11, 39, 10, 483, DateTimeKind.Unspecified).AddTicks(6114), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "520", "c5fd9d58-7f02-4d62-84ba-25a320d3cffe" },
                    { "pzetmWHB9vQcosNRCKGC", "2xSRLgR4QgzYhDLjfgAM", new DateTimeOffset(new DateTime(2023, 4, 11, 11, 39, 10, 483, DateTimeKind.Unspecified).AddTicks(5078), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "B8", "df7d84bb-1d95-4474-afec-e30170bdf6c5" },
                    { "q1g7vpPPj43d4b4HjfPj", "5kDhCqXf6JTAIvz61oEz", new DateTimeOffset(new DateTime(2023, 4, 11, 11, 39, 10, 483, DateTimeKind.Unspecified).AddTicks(5923), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "2800", "09acecc2-9eb1-47f2-ac5d-bc668ffbd9dd" },
                    { "q2cX9d56ywdlann16lA3", "2VS5yLgAuj7VmYeRVxTD", new DateTimeOffset(new DateTime(2023, 4, 11, 11, 39, 10, 483, DateTimeKind.Unspecified).AddTicks(4823), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "147", "47db3ae9-4bbd-49b1-9316-6d68ccdcc81f" },
                    { "q5IRP8CTHQVIpskPfjt1", "48xSUCHrRIfABkLmGHxD", new DateTimeOffset(new DateTime(2023, 4, 11, 11, 39, 10, 483, DateTimeKind.Unspecified).AddTicks(5465), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "Q7", "510670c2-3692-428b-a262-6efee7ac428b" },
                    { "q94FD2cKHtXqdVRlHWkA", "2xSRLgR4QgzYhDLjfgAM", new DateTimeOffset(new DateTime(2023, 4, 11, 11, 39, 10, 483, DateTimeKind.Unspecified).AddTicks(5029), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "B3", "e64f5004-fe5b-4b5f-b5d0-bd65e8f05b24" },
                    { "qfERIfrfKCftuV4Lj9p6", "48xSUCHrRIfABkLmGHxD", new DateTimeOffset(new DateTime(2023, 4, 11, 11, 39, 10, 483, DateTimeKind.Unspecified).AddTicks(5529), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "RS5", "4016ff57-8776-42a7-a383-e5136049ecb1" },
                    { "QhjAkCzrphd8UWqUJdb0", "2VS5yLgAuj7VmYeRVxTD", new DateTimeOffset(new DateTime(2023, 4, 11, 11, 39, 10, 483, DateTimeKind.Unspecified).AddTicks(5005), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "Tonale", "2c1bf7f5-ebed-42f5-bbb9-9ecc99b771d3" },
                    { "QQy4jKAqzeMLX4BudGsm", "48xSUCHrRIfABkLmGHxD", new DateTimeOffset(new DateTime(2023, 4, 11, 11, 39, 10, 483, DateTimeKind.Unspecified).AddTicks(5404), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "E-tron Sportback", "cde920ba-abad-4f07-bfde-ed58015ddd91" },
                    { "QRBrkIawcEDj0cKzeVyB", "48xSUCHrRIfABkLmGHxD", new DateTimeOffset(new DateTime(2023, 4, 11, 11, 39, 10, 483, DateTimeKind.Unspecified).AddTicks(5392), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "Allroad", "0b307c9b-ed22-45fe-b041-a5b2caa59cb1" },
                    { "qXeSoLuFHD8uEJeruDx0", "48xSUCHrRIfABkLmGHxD", new DateTimeOffset(new DateTime(2023, 4, 11, 11, 39, 10, 483, DateTimeKind.Unspecified).AddTicks(5489), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "RS3 Sportback", "aac5a746-5191-4869-a83d-142e41af6492" },
                    { "R1QCgRzpv1736f2o9KQh", "5kDhCqXf6JTAIvz61oEz", new DateTimeOffset(new DateTime(2023, 4, 11, 11, 39, 10, 483, DateTimeKind.Unspecified).AddTicks(6351), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "760", "1c143a20-caee-46f5-a5cd-53d8895fd23e" },
                    { "r6VyGBpLonVohz14lnER", "2xSRLgR4QgzYhDLjfgAM", new DateTimeOffset(new DateTime(2023, 4, 11, 11, 39, 10, 483, DateTimeKind.Unspecified).AddTicks(5122), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "Roadster", "e85fa586-a7ec-4a9f-a72a-1d96f90b2160" },
                    { "RC2tBfSrmMwkylzf1Uys", "470SJrcKER8YaPHSS0br", new DateTimeOffset(new DateTime(2023, 4, 11, 11, 39, 10, 483, DateTimeKind.Unspecified).AddTicks(5172), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "DBX", "c08f9a2b-70f9-4fc1-86f4-60021c99dd2f" },
                    { "Rc5y62n0Hb1hQGwEI8wg", "48xSUCHrRIfABkLmGHxD", new DateTimeOffset(new DateTime(2023, 4, 11, 11, 39, 10, 483, DateTimeKind.Unspecified).AddTicks(5653), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "S7 Sportback", "33aae702-db0f-4140-9409-e6e88a6a73ab" },
                    { "rhWo0L7jItll98lxMteW", "470SJrcKER8YaPHSS0br", new DateTimeOffset(new DateTime(2023, 4, 11, 11, 39, 10, 483, DateTimeKind.Unspecified).AddTicks(5184), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "Db9", "d743bde6-133a-43b5-82db-858285dde3b3" },
                    { "RIL5IMgII6zgoYt4EpSo", "5kDhCqXf6JTAIvz61oEz", new DateTimeOffset(new DateTime(2023, 4, 11, 11, 39, 10, 483, DateTimeKind.Unspecified).AddTicks(6210), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "All 6-series", "089765ea-0b9c-469e-9f40-42fc93e60540" },
                    { "rqef80XGNAaSPMRFu8C9", "5kDhCqXf6JTAIvz61oEz", new DateTimeOffset(new DateTime(2023, 4, 11, 11, 39, 10, 483, DateTimeKind.Unspecified).AddTicks(6334), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "745", "6eb4c5ff-315a-4d75-b70e-56c10ebf6188" },
                    { "RSS5yaVGgojbYQLC0E0n", "5kDhCqXf6JTAIvz61oEz", new DateTimeOffset(new DateTime(2023, 4, 11, 11, 39, 10, 483, DateTimeKind.Unspecified).AddTicks(6021), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "340", "4d120adf-23f3-45e8-bbad-6291466cbfc3" },
                    { "RtG1EDoXqamMdqSEzQdP", "48xSUCHrRIfABkLmGHxD", new DateTimeOffset(new DateTime(2023, 4, 11, 11, 39, 10, 483, DateTimeKind.Unspecified).AddTicks(5560), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "RSQ3", "be18939a-374d-4ed5-8fa7-1537ab204d69" },
                    { "S1y5zYDcNwurb5sI3nRw", "5kDhCqXf6JTAIvz61oEz", new DateTimeOffset(new DateTime(2023, 4, 11, 11, 39, 10, 483, DateTimeKind.Unspecified).AddTicks(6402), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "Bertone", "c7615bd5-9dab-42e9-b88b-c01664603958" },
                    { "slow7XQw5qE4yjSyoStg", "5kDhCqXf6JTAIvz61oEz", new DateTimeOffset(new DateTime(2023, 4, 11, 11, 39, 10, 483, DateTimeKind.Unspecified).AddTicks(5793), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "All 1-series", "fa339fcc-e996-4482-b0d6-c620aa167928" },
                    { "sQdT9PnrhKuyNgVr8xhP", "5kDhCqXf6JTAIvz61oEz", new DateTimeOffset(new DateTime(2023, 4, 11, 11, 39, 10, 483, DateTimeKind.Unspecified).AddTicks(6568), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "X2", "ff53cfbc-969d-4332-8b26-31d247a9866d" },
                    { "SqS9Iq87IubmqNFSp0my", "5kDhCqXf6JTAIvz61oEz", new DateTimeOffset(new DateTime(2023, 4, 11, 11, 39, 10, 483, DateTimeKind.Unspecified).AddTicks(6476), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "M135i", "39129d2e-e391-47cc-82c4-adf9eb5b96bf" },
                    { "T1qxcYPqpLv7T50oY9ww", "5kDhCqXf6JTAIvz61oEz", new DateTimeOffset(new DateTime(2023, 4, 11, 11, 39, 10, 483, DateTimeKind.Unspecified).AddTicks(5799), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "114", "57ddbd31-40ad-4c81-9a70-93a193b38e68" },
                    { "t5yJF11f5PbJMK0cwyRu", "5kDhCqXf6JTAIvz61oEz", new DateTimeOffset(new DateTime(2023, 4, 11, 11, 39, 10, 483, DateTimeKind.Unspecified).AddTicks(6563), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "X1", "d48764de-c0c9-4330-81ae-b1c30b81448d" },
                    { "T72MvA1JYk8WP0tkvjfJ", "5kDhCqXf6JTAIvz61oEz", new DateTimeOffset(new DateTime(2023, 4, 11, 11, 39, 10, 483, DateTimeKind.Unspecified).AddTicks(5850), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "125", "5af966c9-fbb0-4b74-813d-cf94bb31b58b" },
                    { "tE85W2keDNUQ6RrnEIbc", "5kDhCqXf6JTAIvz61oEz", new DateTimeOffset(new DateTime(2023, 4, 11, 11, 39, 10, 483, DateTimeKind.Unspecified).AddTicks(6390), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "Alpina D4", "11b54d38-4f01-403c-abca-8ae8f6438fb8" },
                    { "TkYaSk7R7wGeaB24BGe8", "2VS5yLgAuj7VmYeRVxTD", new DateTimeOffset(new DateTime(2023, 4, 11, 11, 39, 10, 483, DateTimeKind.Unspecified).AddTicks(4841), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "156 Sportwagon", "a2ee60da-5406-4692-8822-eef7e0d7c6da" },
                    { "TpmXBSdASAWr2xlnarV9", "2SBENlnqR76XRNAjbAs3", new DateTimeOffset(new DateTime(2023, 4, 11, 11, 39, 10, 483, DateTimeKind.Unspecified).AddTicks(4784), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "600", "b683823f-ff9b-4c36-afb6-7ccde8c59f44" },
                    { "tTbGnB3dHJS2Stg8eref", "48xSUCHrRIfABkLmGHxD", new DateTimeOffset(new DateTime(2023, 4, 11, 11, 39, 10, 483, DateTimeKind.Unspecified).AddTicks(5624), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "S4 Avant", "4442db54-ab26-4843-9d41-d66ad7b6064f" },
                    { "U0CAlqS7JEqN69eVtteg", "48xSUCHrRIfABkLmGHxD", new DateTimeOffset(new DateTime(2023, 4, 11, 11, 39, 10, 483, DateTimeKind.Unspecified).AddTicks(5567), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "RSQ8", "ea55b331-2cbe-4429-8105-49fee61fa87d" },
                    { "UaTlBMeCSBzm6LaVT5pT", "3qGrKAnyJ2rmHlevXb8c", new DateTimeOffset(new DateTime(2023, 4, 11, 11, 39, 10, 483, DateTimeKind.Unspecified).AddTicks(5153), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "All", "9f7ab26a-e289-4ec7-ac45-b32274e2e08d" },
                    { "Ud7oHftVxFX5ERzvV3NM", "5kDhCqXf6JTAIvz61oEz", new DateTimeOffset(new DateTime(2023, 4, 11, 11, 39, 10, 483, DateTimeKind.Unspecified).AddTicks(6426), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "i7", "0df31416-fa90-4308-a9a4-a436e65851be" },
                    { "UDSnDkTyRQEesnsvITL1", "5kDhCqXf6JTAIvz61oEz", new DateTimeOffset(new DateTime(2023, 4, 11, 11, 39, 10, 483, DateTimeKind.Unspecified).AddTicks(6586), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "X5", "04306f0d-7ac7-4754-8eb0-c1651e00b182" },
                    { "ujX7wGYSEQPjoeXdtuWn", "48xSUCHrRIfABkLmGHxD", new DateTimeOffset(new DateTime(2023, 4, 11, 11, 39, 10, 483, DateTimeKind.Unspecified).AddTicks(5307), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "A4", "4b5d9239-4752-4794-b8e5-59905f27a9c4" },
                    { "uLHYuSXef81hYeG7q2IE", "5kDhCqXf6JTAIvz61oEz", new DateTimeOffset(new DateTime(2023, 4, 11, 11, 39, 10, 483, DateTimeKind.Unspecified).AddTicks(6340), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "750", "58cdf992-7680-4de7-9fde-ddfbc1babb91" },
                    { "ulxCpA8k55JYSIBuKzh1", "5kDhCqXf6JTAIvz61oEz", new DateTimeOffset(new DateTime(2023, 4, 11, 11, 39, 10, 483, DateTimeKind.Unspecified).AddTicks(6556), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "All X-series", "99773f36-e213-4224-a215-636d54d185ac" },
                    { "UoPjR0JQx0LvtNeFlSMs", "5kDhCqXf6JTAIvz61oEz", new DateTimeOffset(new DateTime(2023, 4, 11, 11, 39, 10, 483, DateTimeKind.Unspecified).AddTicks(6261), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "640", "bb4a6907-e7f9-4c72-a65b-be5b70238884" },
                    { "VauHLBe2mqryLlIRGzaK", "5kDhCqXf6JTAIvz61oEz", new DateTimeOffset(new DateTime(2023, 4, 11, 11, 39, 10, 483, DateTimeKind.Unspecified).AddTicks(5964), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "323", "df2b21d7-a55c-4568-8ebe-73f39e73ca5b" },
                    { "vBAg071uEM3NEho2gQMl", "5kDhCqXf6JTAIvz61oEz", new DateTimeOffset(new DateTime(2023, 4, 11, 11, 39, 10, 483, DateTimeKind.Unspecified).AddTicks(6169), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "525", "ed2bd250-9e91-46b8-9739-fa16e4aa2693" },
                    { "vbCmtrTayQQsPokySE3B", "5kDhCqXf6JTAIvz61oEz", new DateTimeOffset(new DateTime(2023, 4, 11, 11, 39, 10, 483, DateTimeKind.Unspecified).AddTicks(6033), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "418", "2be15080-80a4-43cc-a09b-0a857f1d2426" },
                    { "vEDkHPchaoYryD7U5h53", "470SJrcKER8YaPHSS0br", new DateTimeOffset(new DateTime(2023, 4, 11, 11, 39, 10, 483, DateTimeKind.Unspecified).AddTicks(5196), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "V12 Vantage", "f0c15b1d-c892-41b6-81ee-7dbb0e3c2a59" },
                    { "VeI2bCf5hRBpTvB1fBWw", "48xSUCHrRIfABkLmGHxD", new DateTimeOffset(new DateTime(2023, 4, 11, 11, 39, 10, 483, DateTimeKind.Unspecified).AddTicks(5618), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "S4", "059f307b-e4a3-4901-aa21-def622090097" },
                    { "VEI6wIu7Ecb5S2CV3sFo", "48xSUCHrRIfABkLmGHxD", new DateTimeOffset(new DateTime(2023, 4, 11, 11, 39, 10, 483, DateTimeKind.Unspecified).AddTicks(5300), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "A3 Sportback", "e2ec4081-e63c-45b6-b09c-af42b1c2f277" },
                    { "vlcwwc45C7SXjNscx7c6", "06MxFkB3ArFfVraVWN1u", new DateTimeOffset(new DateTime(2023, 4, 11, 11, 39, 10, 483, DateTimeKind.Unspecified).AddTicks(4659), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "All", "434a3279-e5be-4112-89dc-a7d91ebfc29c" },
                    { "Vxr8why3L70IXkoroWjp", "48xSUCHrRIfABkLmGHxD", new DateTimeOffset(new DateTime(2023, 4, 11, 11, 39, 10, 483, DateTimeKind.Unspecified).AddTicks(5415), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "Q3", "71bd4595-601f-40dd-a260-7aad7e69707c" },
                    { "w0XbHkkmrRLtq0RqwHAs", "48xSUCHrRIfABkLmGHxD", new DateTimeOffset(new DateTime(2023, 4, 11, 11, 39, 10, 483, DateTimeKind.Unspecified).AddTicks(5611), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "S3 Sportback", "709501ed-220e-4684-8bbb-062f07a1fe25" },
                    { "W3vaFqojEDtIQVvx3dLC", "5kDhCqXf6JTAIvz61oEz", new DateTimeOffset(new DateTime(2023, 4, 11, 11, 39, 10, 483, DateTimeKind.Unspecified).AddTicks(6002), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "328", "f0ea2e79-40a5-4b63-a9c5-65ec655c3de7" },
                    { "wb1rUXaWnBLcsKQHgLkP", "48xSUCHrRIfABkLmGHxD", new DateTimeOffset(new DateTime(2023, 4, 11, 11, 39, 10, 483, DateTimeKind.Unspecified).AddTicks(5476), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "R8", "7c905a75-fc9c-497d-87fe-969daa9ac768" },
                    { "wkVj1M9h9oj2mp5tH5Ad", "5kDhCqXf6JTAIvz61oEz", new DateTimeOffset(new DateTime(2023, 4, 11, 11, 39, 10, 483, DateTimeKind.Unspecified).AddTicks(6438), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "iX", "127bac60-161b-4f86-8f5a-27be6cbad939" },
                    { "WMJW6MPA8fft7gvAD9xw", "48xSUCHrRIfABkLmGHxD", new DateTimeOffset(new DateTime(2023, 4, 11, 11, 39, 10, 483, DateTimeKind.Unspecified).AddTicks(5447), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "Q4 e-tron", "7bb328b8-74e1-48cc-8024-e5823b541e98" },
                    { "WnQrWhdlJ4fegxzEL4E5", "2VS5yLgAuj7VmYeRVxTD", new DateTimeOffset(new DateTime(2023, 4, 11, 11, 39, 10, 483, DateTimeKind.Unspecified).AddTicks(4848), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "159", "12c29dde-8402-4026-86ae-9baeb0664e36" },
                    { "WvnfKRv9U9CrQYYp9YEg", "48xSUCHrRIfABkLmGHxD", new DateTimeOffset(new DateTime(2023, 4, 11, 11, 39, 10, 483, DateTimeKind.Unspecified).AddTicks(5268), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "A2", "9e998c25-38af-4acb-96fe-dde6bdea9f43" },
                    { "Wz27oW5TMjtMpsGjXBUM", "5kDhCqXf6JTAIvz61oEz", new DateTimeOffset(new DateTime(2023, 4, 11, 11, 39, 10, 483, DateTimeKind.Unspecified).AddTicks(6544), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "X5 M", "ab81a300-e1ea-46e7-94d6-d99cdf81952f" },
                    { "x22vj9FSy0BtRWSP7quD", "5kDhCqXf6JTAIvz61oEz", new DateTimeOffset(new DateTime(2023, 4, 11, 11, 39, 10, 483, DateTimeKind.Unspecified).AddTicks(6064), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "428", "33982f49-b8a4-4719-926e-402aa472cd3e" },
                    { "X3aK4l1BhBBDt6B0eYnR", "48xSUCHrRIfABkLmGHxD", new DateTimeOffset(new DateTime(2023, 4, 11, 11, 39, 10, 483, DateTimeKind.Unspecified).AddTicks(5648), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "S7", "00fd1469-0bed-4ab3-9f8c-590c14b4d1ad" },
                    { "xAyAgIEG5bhhTtBlDYYQ", "5kDhCqXf6JTAIvz61oEz", new DateTimeOffset(new DateTime(2023, 4, 11, 11, 39, 10, 483, DateTimeKind.Unspecified).AddTicks(6630), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "Z3", "6ae4035c-1717-4a4e-9173-b8046fc8f7ba" },
                    { "xkm3jUaw3HYhNfkbdwrz", "2VS5yLgAuj7VmYeRVxTD", new DateTimeOffset(new DateTime(2023, 4, 11, 11, 39, 10, 483, DateTimeKind.Unspecified).AddTicks(4854), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "159 SW", "8ecae63b-3680-437a-9474-bae1d784bf60" },
                    { "xq76wYlx37wX0oPc66Q5", "5kDhCqXf6JTAIvz61oEz", new DateTimeOffset(new DateTime(2023, 4, 11, 11, 39, 10, 483, DateTimeKind.Unspecified).AddTicks(6511), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "M6", "96e31798-64b0-4abe-b2b6-a91f3388d252" },
                    { "xQwDukKmAIqevJ01GCuN", "2xSRLgR4QgzYhDLjfgAM", new DateTimeOffset(new DateTime(2023, 4, 11, 11, 39, 10, 483, DateTimeKind.Unspecified).AddTicks(5011), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "B10", "a527fd6f-f6e0-4abf-9116-28712e9e1af6" },
                    { "xQxzCWaPDDw7CLLxC47Q", "5aFWwvagmpfBWQlHxU5M", new DateTimeOffset(new DateTime(2023, 4, 11, 11, 39, 10, 483, DateTimeKind.Unspecified).AddTicks(5781), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "Montego", "87ed8644-9931-4df5-8263-d1926fe5ed0d" },
                    { "XsHSmxwlNq15EVjwXe77", "5kDhCqXf6JTAIvz61oEz", new DateTimeOffset(new DateTime(2023, 4, 11, 11, 39, 10, 483, DateTimeKind.Unspecified).AddTicks(6103), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "All 5-series", "4adb86bc-8f77-42ae-9eac-008bbb0b0a53" },
                    { "XtsFJt3J6wXVqQrCIS19", "2FEzeyYHYe3zlhjMeaEF", new DateTimeOffset(new DateTime(2023, 4, 11, 11, 39, 10, 483, DateTimeKind.Unspecified).AddTicks(4680), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "Integra", "d3e563bd-126d-4a42-a959-4fef87ad6245" },
                    { "XXp36Ws6zhI7KC1P7jw6", "5kDhCqXf6JTAIvz61oEz", new DateTimeOffset(new DateTime(2023, 4, 11, 11, 39, 10, 483, DateTimeKind.Unspecified).AddTicks(6071), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "430", "a0a6f8e9-f8ed-46ed-9c8e-cb31dcf942ab" },
                    { "y4nG1TwRVu0yWpnPhkBX", "5aFWwvagmpfBWQlHxU5M", new DateTimeOffset(new DateTime(2023, 4, 11, 11, 39, 10, 483, DateTimeKind.Unspecified).AddTicks(5787), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "Princess", "eb5b34d4-1c62-4edc-9b62-264e6900faf3" },
                    { "yAukqYPYxM8L0jAcNhHd", "48xSUCHrRIfABkLmGHxD", new DateTimeOffset(new DateTime(2023, 4, 11, 11, 39, 10, 483, DateTimeKind.Unspecified).AddTicks(5536), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "RS6", "02b170d5-1bb1-455b-8b6c-93e0d0f73374" },
                    { "yBjfcxenW2AjN2rPjgd4", "48xSUCHrRIfABkLmGHxD", new DateTimeOffset(new DateTime(2023, 4, 11, 11, 39, 10, 483, DateTimeKind.Unspecified).AddTicks(5580), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "S2", "46b748e9-4b7b-4a6a-8570-e6bf3f0281e7" },
                    { "ycVbnDUsw9nFqtEpIYJ0", "5kDhCqXf6JTAIvz61oEz", new DateTimeOffset(new DateTime(2023, 4, 11, 11, 39, 10, 483, DateTimeKind.Unspecified).AddTicks(5953), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "318", "aad5df58-fefa-4e02-9560-761d0b0ecbc0" },
                    { "Yk45dIha5TrwHPTrDzsD", "5kDhCqXf6JTAIvz61oEz", new DateTimeOffset(new DateTime(2023, 4, 11, 11, 39, 10, 483, DateTimeKind.Unspecified).AddTicks(6193), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "540", "842c8a5b-2963-4624-900b-9a5e595a9457" },
                    { "yp58tHU08gK3nJWW0yMb", "5kDhCqXf6JTAIvz61oEz", new DateTimeOffset(new DateTime(2023, 4, 11, 11, 39, 10, 483, DateTimeKind.Unspecified).AddTicks(6249), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "630", "165897e3-3245-433a-aaa4-c36c03c3e13a" },
                    { "z35bUECEfLTPTsXKYBac", "2FEzeyYHYe3zlhjMeaEF", new DateTimeOffset(new DateTime(2023, 4, 11, 11, 39, 10, 483, DateTimeKind.Unspecified).AddTicks(4674), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "ILX", "10911252-b141-43fa-bf73-6d6854c59277" },
                    { "zF2hz2XDRHDsI6Hq1Ipd", "5kDhCqXf6JTAIvz61oEz", new DateTimeOffset(new DateTime(2023, 4, 11, 11, 39, 10, 483, DateTimeKind.Unspecified).AddTicks(6432), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "i8", "13a3ae54-3f44-41b1-8ec5-1a05e073a3f8" },
                    { "zGjGkgw9SbxhJH9fYxtL", "48xSUCHrRIfABkLmGHxD", new DateTimeOffset(new DateTime(2023, 4, 11, 11, 39, 10, 483, DateTimeKind.Unspecified).AddTicks(5459), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "Q5 Sportback", "a28eefc5-fb77-4a68-9883-3fd75a6881cc" },
                    { "zN6e6y99qLNG6w4q85H9", "2FEzeyYHYe3zlhjMeaEF", new DateTimeOffset(new DateTime(2023, 4, 11, 11, 39, 10, 483, DateTimeKind.Unspecified).AddTicks(4760), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "Tsx", "cc523036-32a7-4880-b1be-94b8bb47496f" },
                    { "zzM7cs7s7RPHYbNnDrQh", "2xSRLgR4QgzYhDLjfgAM", new DateTimeOffset(new DateTime(2023, 4, 11, 11, 39, 10, 483, DateTimeKind.Unspecified).AddTicks(5095), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "C2", "3495343f-e78d-422d-95a0-ea0c9efc3f9b" }
                });

            migrationBuilder.UpdateData(
                schema: "Troshka",
                table: "Regions",
                keyColumn: "Id",
                keyValue: "04PuHiqcRv9DcREApg5u",
                columns: new[] { "DateCreated", "TrackId" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 4, 11, 11, 39, 10, 483, DateTimeKind.Unspecified).AddTicks(7190), new TimeSpan(0, 0, 0, 0, 0)), "e0917486-0a4c-4a9a-afeb-75c46bf6bdf0" });

            migrationBuilder.UpdateData(
                schema: "Troshka",
                table: "Regions",
                keyColumn: "Id",
                keyValue: "0MQA2If8a5Z4HRefov5m",
                columns: new[] { "DateCreated", "TrackId" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 4, 11, 11, 39, 10, 483, DateTimeKind.Unspecified).AddTicks(7076), new TimeSpan(0, 0, 0, 0, 0)), "b8f20ee1-4eda-4a21-9f14-908329de4a24" });

            migrationBuilder.UpdateData(
                schema: "Troshka",
                table: "Regions",
                keyColumn: "Id",
                keyValue: "3Lvd5SaVBSvRZqXMpqgg",
                columns: new[] { "DateCreated", "TrackId" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 4, 11, 11, 39, 10, 483, DateTimeKind.Unspecified).AddTicks(7064), new TimeSpan(0, 0, 0, 0, 0)), "506bc8d1-a96b-44fe-9411-ed81577ac894" });

            migrationBuilder.UpdateData(
                schema: "Troshka",
                table: "Regions",
                keyColumn: "Id",
                keyValue: "4zMLDb0jRA6DOWg2PGAu",
                columns: new[] { "DateCreated", "TrackId" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 4, 11, 11, 39, 10, 483, DateTimeKind.Unspecified).AddTicks(7226), new TimeSpan(0, 0, 0, 0, 0)), "28c57e81-ffa5-46f0-86f7-939bf3e64c71" });

            migrationBuilder.UpdateData(
                schema: "Troshka",
                table: "Regions",
                keyColumn: "Id",
                keyValue: "54yDT5opPXBpYNO2h6Xk",
                columns: new[] { "DateCreated", "TrackId" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 4, 11, 11, 39, 10, 483, DateTimeKind.Unspecified).AddTicks(7058), new TimeSpan(0, 0, 0, 0, 0)), "e8603baa-499a-407b-bd03-14b106ea2036" });

            migrationBuilder.UpdateData(
                schema: "Troshka",
                table: "Regions",
                keyColumn: "Id",
                keyValue: "8uqXyyo70K5SRg5ktRGQ",
                columns: new[] { "DateCreated", "TrackId" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 4, 11, 11, 39, 10, 483, DateTimeKind.Unspecified).AddTicks(7140), new TimeSpan(0, 0, 0, 0, 0)), "22d863d0-ed49-4ae2-84f2-226f94b521b4" });

            migrationBuilder.UpdateData(
                schema: "Troshka",
                table: "Regions",
                keyColumn: "Id",
                keyValue: "A1CnH1tLY9MO6PWS6ORl",
                columns: new[] { "DateCreated", "TrackId" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 4, 11, 11, 39, 10, 483, DateTimeKind.Unspecified).AddTicks(7208), new TimeSpan(0, 0, 0, 0, 0)), "b45bbee1-18dc-42d4-8956-d5c6aa48bb16" });

            migrationBuilder.UpdateData(
                schema: "Troshka",
                table: "Regions",
                keyColumn: "Id",
                keyValue: "AAH7gkgvxTPPovngcfsJ",
                columns: new[] { "DateCreated", "TrackId" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 4, 11, 11, 39, 10, 483, DateTimeKind.Unspecified).AddTicks(7220), new TimeSpan(0, 0, 0, 0, 0)), "4d3573f3-1781-4660-8343-fc4fb0491af8" });

            migrationBuilder.UpdateData(
                schema: "Troshka",
                table: "Regions",
                keyColumn: "Id",
                keyValue: "AFmN6OptpMY0LezPyjyz",
                columns: new[] { "DateCreated", "TrackId" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 4, 11, 11, 39, 10, 483, DateTimeKind.Unspecified).AddTicks(7082), new TimeSpan(0, 0, 0, 0, 0)), "9d9da2cd-92a8-412e-b14a-59128e871737" });

            migrationBuilder.UpdateData(
                schema: "Troshka",
                table: "Regions",
                keyColumn: "Id",
                keyValue: "BzA0a14BLyuBXlDvgNVl",
                columns: new[] { "DateCreated", "TrackId" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 4, 11, 11, 39, 10, 483, DateTimeKind.Unspecified).AddTicks(7197), new TimeSpan(0, 0, 0, 0, 0)), "e1bd0eae-84f1-457b-ada9-f8e3b3dfb59e" });

            migrationBuilder.UpdateData(
                schema: "Troshka",
                table: "Regions",
                keyColumn: "Id",
                keyValue: "cebjaOy1ByfOBnYYM8Ye",
                columns: new[] { "DateCreated", "TrackId" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 4, 11, 11, 39, 10, 483, DateTimeKind.Unspecified).AddTicks(7109), new TimeSpan(0, 0, 0, 0, 0)), "46e81d6f-4cac-48d0-827e-a39b6d864e8c" });

            migrationBuilder.UpdateData(
                schema: "Troshka",
                table: "Regions",
                keyColumn: "Id",
                keyValue: "eVRJzKNQ1NW4BCuqwCkE",
                columns: new[] { "DateCreated", "TrackId" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 4, 11, 11, 39, 10, 483, DateTimeKind.Unspecified).AddTicks(7164), new TimeSpan(0, 0, 0, 0, 0)), "9deedbe3-1a51-4684-ac81-58e306fd19e8" });

            migrationBuilder.UpdateData(
                schema: "Troshka",
                table: "Regions",
                keyColumn: "Id",
                keyValue: "EWVXiJYgSdc7UFofpRDu",
                columns: new[] { "DateCreated", "TrackId" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 4, 11, 11, 39, 10, 483, DateTimeKind.Unspecified).AddTicks(7128), new TimeSpan(0, 0, 0, 0, 0)), "7c72e19f-ae0c-4ac3-9c40-0e351b443374" });

            migrationBuilder.UpdateData(
                schema: "Troshka",
                table: "Regions",
                keyColumn: "Id",
                keyValue: "EzC6JDofCCRkKgHzu3dI",
                columns: new[] { "DateCreated", "TrackId" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 4, 11, 11, 39, 10, 483, DateTimeKind.Unspecified).AddTicks(7134), new TimeSpan(0, 0, 0, 0, 0)), "5cde84f5-ddad-49ac-893e-010800c8b6b5" });

            migrationBuilder.UpdateData(
                schema: "Troshka",
                table: "Regions",
                keyColumn: "Id",
                keyValue: "hTvSc0MvBTkedmyyA7NN",
                columns: new[] { "DateCreated", "TrackId" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 4, 11, 11, 39, 10, 483, DateTimeKind.Unspecified).AddTicks(7123), new TimeSpan(0, 0, 0, 0, 0)), "04dbd1c8-ead4-4165-af0c-15318088f7a6" });

            migrationBuilder.UpdateData(
                schema: "Troshka",
                table: "Regions",
                keyColumn: "Id",
                keyValue: "iP5gptdNCnAzqRorUYop",
                columns: new[] { "DateCreated", "TrackId" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 4, 11, 11, 39, 10, 483, DateTimeKind.Unspecified).AddTicks(7277), new TimeSpan(0, 0, 0, 0, 0)), "0cbe3257-3ef0-4e4f-9f11-d834f39db1bb" });

            migrationBuilder.UpdateData(
                schema: "Troshka",
                table: "Regions",
                keyColumn: "Id",
                keyValue: "iW1OjUiHcqYURewMo7b7",
                columns: new[] { "DateCreated", "TrackId" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 4, 11, 11, 39, 10, 483, DateTimeKind.Unspecified).AddTicks(7116), new TimeSpan(0, 0, 0, 0, 0)), "dd38e28a-7517-40c2-a22e-354760ef58b8" });

            migrationBuilder.UpdateData(
                schema: "Troshka",
                table: "Regions",
                keyColumn: "Id",
                keyValue: "kUDuBIKZ6DZuHytq19Jp",
                columns: new[] { "DateCreated", "TrackId" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 4, 11, 11, 39, 10, 483, DateTimeKind.Unspecified).AddTicks(7282), new TimeSpan(0, 0, 0, 0, 0)), "8ee8628b-acc9-4bef-be73-264bada9874f" });

            migrationBuilder.UpdateData(
                schema: "Troshka",
                table: "Regions",
                keyColumn: "Id",
                keyValue: "lfwOlRqHcAYTpbxUmiBK",
                columns: new[] { "DateCreated", "TrackId" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 4, 11, 11, 39, 10, 483, DateTimeKind.Unspecified).AddTicks(7265), new TimeSpan(0, 0, 0, 0, 0)), "2be77667-5f3c-4d01-96fe-d2dbc48fae0c" });

            migrationBuilder.UpdateData(
                schema: "Troshka",
                table: "Regions",
                keyColumn: "Id",
                keyValue: "m6nvdcOx04SwKS3JmQuu",
                columns: new[] { "DateCreated", "TrackId" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 4, 11, 11, 39, 10, 483, DateTimeKind.Unspecified).AddTicks(7214), new TimeSpan(0, 0, 0, 0, 0)), "7a1efd0a-a1a4-4b4d-a683-8c1f6ccdf820" });

            migrationBuilder.UpdateData(
                schema: "Troshka",
                table: "Regions",
                keyColumn: "Id",
                keyValue: "qys6uigQzGAe5CFRquPE",
                columns: new[] { "DateCreated", "TrackId" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 4, 11, 11, 39, 10, 483, DateTimeKind.Unspecified).AddTicks(7239), new TimeSpan(0, 0, 0, 0, 0)), "b779e45f-3f96-4135-8588-5d0120888da9" });

            migrationBuilder.UpdateData(
                schema: "Troshka",
                table: "Regions",
                keyColumn: "Id",
                keyValue: "sPB8FQRwlj7zkzWNSHPp",
                columns: new[] { "DateCreated", "TrackId" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 4, 11, 11, 39, 10, 483, DateTimeKind.Unspecified).AddTicks(7070), new TimeSpan(0, 0, 0, 0, 0)), "eed40d2d-1921-49c2-83f0-8b0c86a707cd" });

            migrationBuilder.UpdateData(
                schema: "Troshka",
                table: "Regions",
                keyColumn: "Id",
                keyValue: "ssHgRpb69ARnCL27lW8Z",
                columns: new[] { "DateCreated", "TrackId" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 4, 11, 11, 39, 10, 483, DateTimeKind.Unspecified).AddTicks(7202), new TimeSpan(0, 0, 0, 0, 0)), "d26f6fd3-1177-4900-9d0e-cf86bed85613" });

            migrationBuilder.UpdateData(
                schema: "Troshka",
                table: "Regions",
                keyColumn: "Id",
                keyValue: "tGOFKGTIXre5MbB6nbPo",
                columns: new[] { "DateCreated", "TrackId" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 4, 11, 11, 39, 10, 483, DateTimeKind.Unspecified).AddTicks(7151), new TimeSpan(0, 0, 0, 0, 0)), "d7078225-fd4d-41e0-9456-026c029f1572" });

            migrationBuilder.UpdateData(
                schema: "Troshka",
                table: "Regions",
                keyColumn: "Id",
                keyValue: "tISK82svC0LzIBzGRgRs",
                columns: new[] { "DateCreated", "TrackId" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 4, 11, 11, 39, 10, 483, DateTimeKind.Unspecified).AddTicks(7146), new TimeSpan(0, 0, 0, 0, 0)), "f82820a6-d31d-41cb-8688-1417912385e1" });

            migrationBuilder.UpdateData(
                schema: "Troshka",
                table: "Regions",
                keyColumn: "Id",
                keyValue: "U7BLcxhRiK259caYZtoe",
                columns: new[] { "DateCreated", "TrackId" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 4, 11, 11, 39, 10, 483, DateTimeKind.Unspecified).AddTicks(7157), new TimeSpan(0, 0, 0, 0, 0)), "150c4528-99fa-46bd-936b-c2f2a185d117" });

            migrationBuilder.UpdateData(
                schema: "Troshka",
                table: "Regions",
                keyColumn: "Id",
                keyValue: "xC8qGAbw5YtdET2UURuP",
                columns: new[] { "DateCreated", "TrackId" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 4, 11, 11, 39, 10, 483, DateTimeKind.Unspecified).AddTicks(7271), new TimeSpan(0, 0, 0, 0, 0)), "1c3ce57a-a69d-478e-8e91-a689db977e87" });

            migrationBuilder.UpdateData(
                schema: "Troshka",
                table: "Regions",
                keyColumn: "Id",
                keyValue: "xseBOjqVjozxkJcgGubc",
                columns: new[] { "DateCreated", "TrackId" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 4, 11, 11, 39, 10, 483, DateTimeKind.Unspecified).AddTicks(7233), new TimeSpan(0, 0, 0, 0, 0)), "45b4cf9d-22bc-4dd8-9cc7-cf43d94b9f5f" });

            migrationBuilder.InsertData(
                schema: "Troshka",
                table: "Transmissions",
                columns: new[] { "Id", "DateCreated", "DateDeleted", "DateUpdated", "IsDeleted", "Name", "TrackId" },
                values: new object[,]
                {
                    { "0hIuCr30Ilby0G7FjHsx", new DateTimeOffset(new DateTime(2023, 4, 11, 11, 39, 10, 484, DateTimeKind.Unspecified).AddTicks(1067), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "Автоматик", "7d2ba5cd-f127-4b07-b25e-f9b02443859c" },
                    { "N0UwUhF63UJrmTwUPdhQ", new DateTimeOffset(new DateTime(2023, 4, 11, 11, 39, 10, 484, DateTimeKind.Unspecified).AddTicks(1081), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "Полу-автоматик", "c2175486-a467-4a49-9a01-e1519d533fec" },
                    { "PIQ3kQjDmKkE6MS8BRmY", new DateTimeOffset(new DateTime(2023, 4, 11, 11, 39, 10, 484, DateTimeKind.Unspecified).AddTicks(1091), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "Ръчна", "96ca7eac-9d5a-44cd-8dfc-6347f46780d8" }
                });

            migrationBuilder.AddForeignKey(
                name: "FK_CarOffers_UserComments_AuthorId",
                schema: "Cars",
                table: "CarOffers",
                column: "AuthorId",
                principalSchema: "Troshka",
                principalTable: "UserComments",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_UserComments_UserComments_AuthorId",
                table: "UserComments",
                column: "AuthorId",
                principalSchema: "Troshka",
                principalTable: "UserComments",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_UserComments_UserComments_RecipientId",
                table: "UserComments",
                column: "RecipientId",
                principalSchema: "Troshka",
                principalTable: "UserComments",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
