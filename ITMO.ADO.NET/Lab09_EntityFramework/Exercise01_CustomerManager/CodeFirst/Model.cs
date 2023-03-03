﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;



namespace ITMO.ADO2023.Task09.Ex01.CodeFirst
{
    public class Model
    {
        public class Customer
        {
            public int CustomerId { get; set; }

            [Required]
            [MaxLength(30)]
            public string FirstName { get; set; }
            public string LastName { get; set; }


            [MaxLength(100)]
            public string Email { get; set; }

            [Range(8, 100)]
            public int Age { get; set; }

            [Column(TypeName = "image")]
            public byte[] Photo { get; set; }


            public override string ToString()
            {
                string s = FirstName + ", электронный адрес: " + Email;
                return s;
            }
            // Ссылка на заказы
            public virtual List<Order> Orders { get; set; }
            public Customer()
            {
                Orders = new List<Order>();
            }
        }

        public class Order
        {
            public int OrderId { get; set; }
            public string ProductName { get; set; }
            public string Description { get; set; }
            public int Quantity { get; set; }
            public DateTime PurchaseDate { get; set; }

            // Ссылка на покупателя
            public Customer Customer { get; set; }

            public override string ToString()
            {
                string s = ProductName + " " + Quantity + "шт., дата: " + PurchaseDate;
                return s;
            }

        }

        [Table("VipOrders")]
        public class VipOrder : Order
        {
            public string status { get; set; }
        }

    }
}
