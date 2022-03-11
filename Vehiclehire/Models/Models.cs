using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Web;
using System.Web.Mvc;

namespace Vehiclehire.Models
{
    public class Models
    {
    }
    public class Role
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
    }

    public class UserRole
    {
        [Key, Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int UserId { get; set; }
        [Key, Column(Order = 1)]
        public int RoleId { get; set; }


        [ForeignKey("RoleId")]
        public virtual Role Role { get; set; }
    }

    public class User
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Id { get; set; }
        [Display(Name = "First Name(s)")]
        public string FirstName { get; set; }
        [Display(Name = "Last Name")]

        public string LastName { get; set; }

        [DataType(DataType.EmailAddress)]
        public string EmailAddress { get; set; }

        [DataType(DataType.Password)]
        public string Password { get; set; }

        public string PhoneNumber { get; set; }

        public int Credit { get; set; }

        public string Status { get; set; }
        public string AvailabilityStatus { get; set; }



    }



    public class GetQuery
    {

        public string Main()
        {
            int length = 20;

            // creating a StringBuilder object()
            StringBuilder str_build = new StringBuilder();
            Random random = new Random();

            char letter;

            for (int i = 0; i < length; i++)
            {
                double flt = random.NextDouble();
                int shift = Convert.ToInt32(Math.Floor(25 * flt));
                letter = Convert.ToChar(shift + 65);
                str_build.Append(letter);
            }
            return str_build.ToString();
        }
    }

    public class Verify
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int AccountId { get; set; }
        public string Code { get; set; }

    }


    public class Address
    {
        [Key]

        public int Id { get; set; }
        public string City { get; set; }
        public string Province { get; set; }
        public int Zip { get; set; }
        public string Addres { get; set; }
        public string Username { get; set; }
    }



    public class Category
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public string NameFix { get; set; }

    }
    public class Product
    {
        [Key]
        public int Id { get; set; }
        [Required]

        public string Name { get; set; }

        public string Query { get; set; }
        [Required]
        public int Quantity { get; set; }

        [AllowHtml]
        public string Description { get; set; }
        [Required]

        public int Price { get; set; }
        public string CategoryName { get; set; }
        public string ImageName { get; set; }
        public int CategoryId { get; set; }
        public string color { get; set; }
        public string NumberPlate { get; set; }


        [ForeignKey("CategoryId")]
        public virtual Category Category { get; set; }

    }



    public class Order
    {
        [Key]
        public int OrderId { get; set; }
        public int UserId { get; set; }
        public int DeliveryFee { get; set; }
        [Display(Name = "Date")]

        public DateTime CreatedAt { get; set; }
        public string Destination { get; set; }
        public string Status { get; set; }
        [Display(Name = "Order code")]
        public int Statusnum { get; set; }

        public string OrderCode { get; set; }
        [Display(Name = "Delivery status")]

        public string DeliveryStatus { get; set; }
        [Display(Name = "Total price")]

        public int TotalPrice { get; set; }
        [ForeignKey("UserId")]
        public virtual User User { get; set; }
    }
    public class OrderDetails
    {
        [Key]
        public int Id { get; set; }
        public int OrderId { get; set; }
        public int ProductId { get; set; }
        public int Quantity { get; set; }
        public string Color { get; set; }

        [ForeignKey("OrderId")]
        public virtual Order Orders { get; set; }
        [ForeignKey("ProductId")]
        public virtual Product Product { get; set; }

    }


    public class Booking
    {
        [Key]
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Qr { get; set; }
        public string Email { get; set; }
        public int PhoneNumber { get; set; }
        public string Address { get; set; }
        public string SUrbace { get; set; }
        public int ZipCode { get; set; }
        public string Servicetype { get; set; }
        public DateTime InspectionDate { get; set; }
        public DateTime ServicingDate { get; set; }
        public string Satatus { get; set; }
        public string Constractor { get; set; }
        public string InspectinStatus { get; set; }
        public string ServiceStatus { get; set; }
        public int Total { get; set; }

        public int StatusNum { get; set; }
    }

   

    public class Delivery
    {
        [Key]
        public int Id { get; set; }
        public int OrderId { get; set; }
        public int DriverId { get; set; }
        [Display(Name = "Driver Username")]
        public string DriverName { get; set; }
        public string Destination { get; set; }
        public DateTime PickUpTime { get; set; }
        public string PickUpAddress { get; set; }
        public DateTime Date { get; set; }

        public string DriverConfirm { get; set; }

        [ForeignKey("DriverId")]
        public virtual User Driver { get; set; }

    }


    public class PickPoint
    {
        [Key]
        public int Id { get; set; }
        public string PointAddress { get; set; }
        public string DriverEmail { get; set; }
        public string PickUpPhone { get; set; }
        public int PickVehId { get; set; }
        public string NumberPlate { get; set; }
    }

    public class Refund
    {
        [Key]
        public int Id { get; set; }
        public string Reason { get; set; }
        public string Destination { get; set; }
        public string PickupAddress { get; set; }
        public int OrderNum { get; set; }
        public string CustomerEmail { get; set; }
        public string Status { get; set; }
        public DateTime Date { get; set; }

    }
}