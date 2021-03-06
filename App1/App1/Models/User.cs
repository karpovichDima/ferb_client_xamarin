﻿using System;
using System.Collections.Generic;
using System.Text;
using SQLite;

namespace App1.Models
{
    public class User
    {
        [PrimaryKey]    
        public int Id { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }

        public User(){}

        public User(string username, string password)
        {
            if (password == null || username == null)
            {
                Password = "";
                Username = "";
                return;
            }
            
            Username = username;
            Password = password;
        }

        public bool CheckInformation()
        {
            if (!Username.Equals("") && !Password.Equals(""))
            {
                return true;
            }

            return false;
        }
    }
}
