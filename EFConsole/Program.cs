using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EFConsole.Models;
using Newtonsoft.Json;
using System.Data.Common;
using System.Data.SqlClient;

namespace EFConsole
{
    class Program
    {
        //EF 6.0 基础学习和linq
        static void Main(string[] args)
        {
            //using (aehyokContext db = new aehyokContext())
            //{
            //db.Configuration.
            //查询
            //var a = db.Set<BlogUser>().ToArray();
            //指定查询
            //var a = db.BlogUsers.Where(c => c.Id == 64).First();
            //EF查询相关
            //查询整个类所有字段
            //var a = from p in db.BlogUsers where p.Id > 65 && p.Id < 70 select p;
            //查询类的指定某个字段
            //var a = from p in db.BlogUsers where p.Id > 65 && p.Id < 70 select p.Id;
            //查询类的指定某些字段(创建匿名类)
            //var a = from p in db.BlogUsers where p.Id > 65 && p.Id < 70 select new { id = p.Id, username = p.UserName };
            //查询指定字段的最大值
            //var a = db.BlogUsers.Max(c => c.Id);
            //查询指定字段
            //var a = db.BlogUsers.Select(c => c.Id);
            //查询指定字段的和：Sum
            //var a = db.BlogUsers.Sum(c => c.Id);


            //EF新增
            //var model = new BlogUser { Id = 73, UserName = "ChenRanReal", DisplayName = "陈然Real", Email = "10600chen@gmail.com", Password = "123", IsValid = 1 };
            //db.BlogUsers.Add(model);
            //批量新增
            //List<BlogUser> listbu = new List<BlogUser>
            //{
            //    new BlogUser {
            //        Id = 74, UserName = "ChenRanReal", DisplayName = "陈然Real", Email = "10600chen@gmail.com", Password = "123", IsValid = 1
            //    },
            //    new BlogUser {
            //        Id = 73, UserName = "ChenRanReal", DisplayName = "陈然Real", Email = "10600chen@gmail.com", Password = "123", IsValid = 1
            //    }
            //};
            //listbu 添加元素
            //循环添加
            //listbu.ForEach(c => db.BlogUsers.Add(c));
            //直接添加
            //db.BlogUsers.AddRange(listbu);
            //var a = db.SaveChanges();

            //EF修改
            //var model = new BlogUser();
            //var result = (from p in db.BlogUsers where p.Id == 73 select p).First();
            //model = result as BlogUser;
            //model.Password = Guid.NewGuid().ToString();
            //db.SaveChanges();

            //EF删除
            //var result = (from p in db.BlogUsers where p.Id == 71 select p).First();
            //db.BlogUsers.Remove(result);
            //批量删除
            //var result = from p in db.BlogUsers where p.Id > 65 && p.Id < 70 select p;
            //db.BlogUsers.RemoveRange(result);
            //db.SaveChanges();

            //SQL语句查询(参数化)
            //string sql = "select * from BlogUsers t where t.Id = @id";
            //var d = db.Database.SqlQuery<BlogUser>(sql, new DbParameter[] { new SqlParameter { ParameterName = "id", Value = 73 } }).First();
            //Console.WriteLine(d.DisplayName);

            //事务
            //using (var tran = db.Database.BeginTransaction())
            //{
            //    try
            //    {
            //        var result = (from p in db.BlogUsers where p.Id == 74 select p).First();
            //        result.Password = Guid.NewGuid().ToString();
            //        db.SaveChanges();
            //        tran.Commit();
            //    }
            //    catch
            //    {
            //        tran.Rollback();
            //    }
            //}
            Console.ReadLine();
            //}
        }
    }
}
