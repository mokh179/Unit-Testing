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
        IOperations<user> _db;
        public apiTest(IOperations<user> db)
        {
            _db = db;
        }
        //apiCon _db = new apiCon();
        [Fact]
        public void Test1()
        {
            user u=_db.getByID(1);
            Assert.Equal(1, u.ID);
        }
    }
}
