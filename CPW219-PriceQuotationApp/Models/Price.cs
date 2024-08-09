using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace CPW219_PriceQuotationApp.Models
{
    public class Price
    {
        /// <summary>
        /// Price before any discounts are applied
        /// </summary>
        [Range(0.1, double.MaxValue, ErrorMessage = "Subtotal must be greater than 0")]
        [Required]
        public double Subtotal { get; set; }

        /// <summary>
        /// Percentage of subtotal that is discounted (0-100)
        /// </summary>
        [Range(0, 100, ErrorMessage = "Discount percent MUST be an integer 0 - 100")]
        [Required]
        public int DiscountPercent { get; set; }

        /// <summary>
        /// Price that was subtracted from subtotal
        /// </summary
        public decimal DiscountAmount 
        {
            get 
            {
                return (Decimal)Subtotal * DiscountPercent / 100;
            }
        }

        /// <summary>
        /// Price after discounts are applied
        /// </summary>
        public decimal Total 
        {
            get 
            {
                return (Decimal)Subtotal - DiscountAmount;
            } 
        }
    }
}
