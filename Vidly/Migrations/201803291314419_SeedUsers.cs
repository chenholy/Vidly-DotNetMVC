namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class SeedUsers : DbMigration
    {
        public override void Up()
        {
            Sql(@"
INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'6f5f54b0-4dfe-4256-9869-1f4b775d2591', N'admin@asp.com', 0, N'AFKLjV+WlltHJjBM13BDepjqzm6Ddd5pTfKuCnRJmHEPZobXmfQ+RPTq/231zHmPVg==', N'43724090-2d08-48c2-a35e-5f2b839e222a', NULL, 0, 0, NULL, 1, 0, N'admin@asp.com')
INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'ad31b0bd-5e0d-48b5-97ab-029d6afcc1ae', N'pchen2230@gmail.com', 0, N'AIVBkT5Ux9kdZgAV3qUmy2S9w/mfRsQL4Bv75HUFlZuxaiXVcanP4J0n/jr6HTcg5w==', N'40f8b5ed-bb6a-4040-b899-6211e864d196', NULL, 0, 0, NULL, 1, 0, N'pchen2230@gmail.com')
INSERT INTO [dbo].[AspNetRoles] ([Id], [Name]) VALUES (N'badef0e8-527d-48c8-9aeb-3c3e4c40f24d', N'CanManageMovies')
INSERT INTO [dbo].[AspNetUserRoles] ([UserId], [RoleId]) VALUES (N'6f5f54b0-4dfe-4256-9869-1f4b775d2591', N'badef0e8-527d-48c8-9aeb-3c3e4c40f24d')

");
            //error can occur if insert statement is not executed in right order
            //need to be users -> roles -> userroles
        }
        
        public override void Down()
        {
        }
    }
}
