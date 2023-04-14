namespace Troshka.Blazor.Infrastructure.Scripts
{
    public static class OfferSQL
    {
        public static string GetOfferById = @"
            DECLARE @OfferId AS VARCHAR(20);

            SELECT 
	            c.Id,
	            c.Name
            FROM Troshka.OfferCategoriesView
            WHERE OfferId = @OfferId
        ";
    }
}
