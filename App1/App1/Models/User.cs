﻿using System;
using System.Collections.Generic;
using System.Text;

namespace App1.Models
{
    class User
    {
        public int Id { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }

        public User(){}

        public User(string username, string password)
        {
            Username = username;
            Password = password;
        }

        public bool CheckInformation()
        {
            if (!this.Username.Equals("") && !this.Password.Equals(""))
                return true;
            else
                return false;
        }
    }
}
