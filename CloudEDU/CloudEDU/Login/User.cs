﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CloudEDU.Login
{
    /// <summary>
    /// User model
    /// </summary>
    public class User 
    {
        public string Username { get; set; }
        public string Password { get; set; }
        public string ImageSource { get; set; }

        public User(string username, string password, string imageSource)
        {
            Username = username;
            Password = password;
            ImageSource = imageSource;
        }
    }
}
