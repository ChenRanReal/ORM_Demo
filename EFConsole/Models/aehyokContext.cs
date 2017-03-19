using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using EFConsole.Models.Mapping;

namespace EFConsole.Models
{
    public partial class aehyokContext : DbContext
    {
        static aehyokContext()
        {
            Database.SetInitializer<aehyokContext>(null);
        }

        public aehyokContext()
            : base("Name=aehyokContext")
        {
        }

        public DbSet<Article> Articles { get; set; }
        public DbSet<ArticleTag> ArticleTags { get; set; }
        public DbSet<Blog_Article> Blog_Article { get; set; }
        public DbSet<Blog_Comment> Blog_Comment { get; set; }
        public DbSet<Blog_Tag> Blog_Tag { get; set; }
        public DbSet<BlogUser> BlogUsers { get; set; }
        public DbSet<Comment> Comments { get; set; }
        public DbSet<Menu> Menus { get; set; }
        public DbSet<PersonalStatement> PersonalStatements { get; set; }
        public DbSet<RD_Department> RD_Department { get; set; }
        public DbSet<RD_Employee> RD_Employee { get; set; }
        public DbSet<RD_Post> RD_Post { get; set; }
        public DbSet<Role> Roles { get; set; }
        public DbSet<Sys_Department> Sys_Department { get; set; }
        public DbSet<Sys_Menu> Sys_Menu { get; set; }
        public DbSet<Sys_Post> Sys_Post { get; set; }
        public DbSet<Sys_Role> Sys_Role { get; set; }
        public DbSet<Sys_User> Sys_User { get; set; }
        public DbSet<sysdiagram> sysdiagrams { get; set; }
        public DbSet<Tag> Tags { get; set; }
        public DbSet<Test_Order> Test_Order { get; set; }
        public DbSet<Test_User> Test_User { get; set; }
        public DbSet<Test_UserOrder> Test_UserOrder { get; set; }
        public DbSet<User> Users { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new ArticleMap());
            modelBuilder.Configurations.Add(new ArticleTagMap());
            modelBuilder.Configurations.Add(new Blog_ArticleMap());
            modelBuilder.Configurations.Add(new Blog_CommentMap());
            modelBuilder.Configurations.Add(new Blog_TagMap());
            modelBuilder.Configurations.Add(new BlogUserMap());
            modelBuilder.Configurations.Add(new CommentMap());
            modelBuilder.Configurations.Add(new MenuMap());
            modelBuilder.Configurations.Add(new PersonalStatementMap());
            modelBuilder.Configurations.Add(new RD_DepartmentMap());
            modelBuilder.Configurations.Add(new RD_EmployeeMap());
            modelBuilder.Configurations.Add(new RD_PostMap());
            modelBuilder.Configurations.Add(new RoleMap());
            modelBuilder.Configurations.Add(new Sys_DepartmentMap());
            modelBuilder.Configurations.Add(new Sys_MenuMap());
            modelBuilder.Configurations.Add(new Sys_PostMap());
            modelBuilder.Configurations.Add(new Sys_RoleMap());
            modelBuilder.Configurations.Add(new Sys_UserMap());
            modelBuilder.Configurations.Add(new sysdiagramMap());
            modelBuilder.Configurations.Add(new TagMap());
            modelBuilder.Configurations.Add(new Test_OrderMap());
            modelBuilder.Configurations.Add(new Test_UserMap());
            modelBuilder.Configurations.Add(new Test_UserOrderMap());
            modelBuilder.Configurations.Add(new UserMap());
        }
    }
}
