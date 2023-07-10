//************************************************************
//Copyright: http://jesse2013.cnblogs.com
//************************************************************
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Reflection;
using System.Text;

namespace JesseLinqProvider
{

    class Program
    {
        static void Main(string[] args)
        {
            List<User> myUsers = new List<User>();
            var userSql = myUsers.AsQueryable().Where(u => u.Age > 2);
            Console.WriteLine(userSql);
            // SELECT * FROM (SELECT * FROM User) AS T WHERE (Age>2)

            List<User> myUsers2 = new List<User>();
            var userSql2 = myUsers.AsQueryable().Where(u => u.Name=="Jesse");
            Console.WriteLine(userSql2);
            //SELECT * FROM (SELECT * FROM USER) AS T WHERE (Name='Jesse')


            Console.ReadLine();
        }
    }
}
