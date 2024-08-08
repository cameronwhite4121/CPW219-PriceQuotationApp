namespace CPW219_PriceQuotationApp.Models
{
    public class Price
    {
        /// <summary>
        /// Price before any discounts are applied
        /// </summary>
        decimal Subtotal { get; set; }

        /// <summary>
        /// Percentage of subtotal that is discounted
        /// </summary>
        decimal DiscountPercent { get; set; }

        /// <summary>
        /// Price that was subtracted from subtotal
        /// </summary>
        decimal DiscountAmount { get; set; }

        /// <summary>
        /// Price after discounts are applied
        /// </summary>
        decimal Total { get; set; }
    }
}
