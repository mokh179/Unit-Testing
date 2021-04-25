using System;
using System.Collections.Generic;
using System.Text;
using Xunit;
using services;
using Model;
using apiUT;
namespace ApiTest
{
    
    public class apiTest
    {
        [Fact]
        public void userRole()
        {
            apiCon db = new apiCon();
            UsersMoc us = new UsersMoc(db);
            RolesMoc r = new RolesMoc(db);
            Assert.True(us.getByID(1)!=null);
            Assert.True(r.getByID(1)!=null);

        }

        [Fact]
        public void logintest()
        {
            apiCon db = new apiCon();
            UsersMoc us = new UsersMoc(db);
            Assert.True(us.test("mohammed", "123"));

        }
    }
}
