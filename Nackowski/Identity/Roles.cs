using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Nackowski.Identity
{
    public class Roles
    {
        public static class Users
        {
            public const string AddBid = "users.add.bids";
            
        }

        public static class Admin
        {
            public const string AddAuction = "admin.add.auctions";
            public const string AddBid = "admin.add.bids";
            public const string EditRole = "admin.edit.roles";
            public const string EditAuction = "admin.edit.auctions";
            public const string Delete = "admin.delete.auctions";
        }
    }
}
