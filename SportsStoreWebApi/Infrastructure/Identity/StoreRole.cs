﻿using Microsoft.AspNet.Identity.EntityFramework;

namespace SportsStoreWebApi.Infrastructure.Identity
{
    public class StoreRole : IdentityRole
    {
        public StoreRole() : base() { }
        public StoreRole(string name) : base(name) { }
    }
}