using ObjectOrientedPractics.Services;
using System;
using System.Collections.Generic;

namespace ObjectOrientedPractics.Model
{
    public class Order
    {
        private int _id;

        private DateTime _createdDate;

        private OrderStatus _status;

        private Address _address;

        private List<Item> _items;

        private double _amount;

        public int Id { get { return _id; } private set { _id = value; } }

        public DateTime CreatedDate { get { return _createdDate; } private set { _createdDate = value; } }

        public OrderStatus Status { get { return _status; } set { _status = value; } }

        public Address Address { get { return _address; } set { _address = value; } }

        public List<Item> Items { get { return _items; } set { _items = value; } }

        public double Amount { get { return _amount; } set { _amount = value; } }

        public Order(Address address, List<Item> items, double amount)
        {
            Id = IdGenerator.GetNewIdOrder();
            CreatedDate = DateTime.Now;
            Status = OrderStatus.New;
            Address = address;
            Items = items;
            Amount = amount;
        }
    }
}
