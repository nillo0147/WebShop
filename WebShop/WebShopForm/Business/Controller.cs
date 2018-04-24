﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WebShopForm.Persistence;

namespace WebShopForm.Business
{
    public class Controller
    {
        PersistenceCode persistenceCode = new PersistenceCode();

        public List<Product> GetProducts()
        {
            return persistenceCode.GetProducts();
        }

        public bool Login(string loginName, string password)
        {
            return persistenceCode.Login(loginName, password);
        }

        public bool UserExists(string loginName)
        {
            return persistenceCode.UserExists(loginName);
        }

        public User GetUser(string loginName)
        {
            return persistenceCode.GetUser(loginName);
        }

        public User GetUser(int id)
        {
            return persistenceCode.GetUser(id);
        }

        public Product GetProduct(int id)
        {
            return persistenceCode.GetProduct(id);
        }

        public List<Product> GetCart(User user)
        {
            return persistenceCode.GetCart(user);
        }

        public void AddToCart(Product product, User user, int amount)
        {
            persistenceCode.AddToCart(product, user, amount);
        }

        public void RemoveFromCart(Product product, User user)
        {
            persistenceCode.RemoveFromCart(product, user);
        }

        public int GetStock(int id)
        {
            return persistenceCode.GetStock(id);
        }

        public void SetStock(int id, int amount)
        {
            persistenceCode.SetStock(id, amount);
        }
    }
}