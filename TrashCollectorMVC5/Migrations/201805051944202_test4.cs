namespace TrashCollectorMVC5.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class test4 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.AspNetRoles",
                c => new
                    {
                        Id = c.String(nullable: false, maxLength: 128),
                        Name = c.String(nullable: false, maxLength: 256),
                    })
                .PrimaryKey(t => t.Id)
                .Index(t => t.Name, unique: true, name: "RoleNameIndex");
            
            CreateTable(
                "dbo.AspNetUserRoles",
                c => new
                    {
                        UserId = c.String(nullable: false, maxLength: 128),
                        RoleId = c.String(nullable: false, maxLength: 128),
                    })
                .PrimaryKey(t => new { t.UserId, t.RoleId })
                .ForeignKey("dbo.AspNetRoles", t => t.RoleId, cascadeDelete: true)
                .ForeignKey("dbo.AspNetUsers", t => t.UserId, cascadeDelete: true)
                .Index(t => t.UserId)
                .Index(t => t.RoleId);
            
            CreateTable(
                "dbo.TrashUserAddresses",
                c => new
                    {
                        TrashUserAddressId = c.Int(nullable: false),
                        PrimaryStreetAddress = c.String(),
                        SecondaryStreetAddress = c.String(),
                        City = c.String(),
                        State = c.String(),
                        Zip = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.TrashUserAddressId)
                .ForeignKey("dbo.TrashUsers", t => t.TrashUserAddressId)
                .Index(t => t.TrashUserAddressId);
            
            CreateTable(
                "dbo.TrashUsers",
                c => new
                    {
                        TrashUserId = c.Int(nullable: false, identity: true),
                        ApplicationUserId = c.String(maxLength: 128),
                        FirstName = c.String(),
                        LastName = c.String(),
                        DOB = c.String(),
                        IsEmployee = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.TrashUserId)
                .ForeignKey("dbo.AspNetUsers", t => t.ApplicationUserId)
                .Index(t => t.ApplicationUserId);
            
            CreateTable(
                "dbo.AspNetUsers",
                c => new
                    {
                        Id = c.String(nullable: false, maxLength: 128),
                        Email = c.String(maxLength: 256),
                        EmailConfirmed = c.Boolean(nullable: false),
                        PasswordHash = c.String(),
                        SecurityStamp = c.String(),
                        PhoneNumber = c.String(),
                        PhoneNumberConfirmed = c.Boolean(nullable: false),
                        TwoFactorEnabled = c.Boolean(nullable: false),
                        LockoutEndDateUtc = c.DateTime(),
                        LockoutEnabled = c.Boolean(nullable: false),
                        AccessFailedCount = c.Int(nullable: false),
                        UserName = c.String(nullable: false, maxLength: 256),
                    })
                .PrimaryKey(t => t.Id)
                .Index(t => t.UserName, unique: true, name: "UserNameIndex");
            
            CreateTable(
                "dbo.AspNetUserClaims",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        UserId = c.String(nullable: false, maxLength: 128),
                        ClaimType = c.String(),
                        ClaimValue = c.String(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.AspNetUsers", t => t.UserId, cascadeDelete: true)
                .Index(t => t.UserId);
            
            CreateTable(
                "dbo.AspNetUserLogins",
                c => new
                    {
                        LoginProvider = c.String(nullable: false, maxLength: 128),
                        ProviderKey = c.String(nullable: false, maxLength: 128),
                        UserId = c.String(nullable: false, maxLength: 128),
                    })
                .PrimaryKey(t => new { t.LoginProvider, t.ProviderKey, t.UserId })
                .ForeignKey("dbo.AspNetUsers", t => t.UserId, cascadeDelete: true)
                .Index(t => t.UserId);
            
            CreateTable(
                "dbo.TrashUserPickupDateExtras",
                c => new
                    {
                        TrashUserPickupDateExtraId = c.Int(nullable: false),
                        TrashUserPickupDateTime = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.TrashUserPickupDateExtraId)
                .ForeignKey("dbo.TrashUsers", t => t.TrashUserPickupDateExtraId)
                .Index(t => t.TrashUserPickupDateExtraId);
            
            CreateTable(
                "dbo.TrashUserPickupDatePauses",
                c => new
                    {
                        TrashUserPickupDatePauseId = c.Int(nullable: false),
                        TrashUserPickupStart = c.DateTime(nullable: false),
                        TrashUserPickupEnd = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.TrashUserPickupDatePauseId)
                .ForeignKey("dbo.TrashUsers", t => t.TrashUserPickupDatePauseId)
                .Index(t => t.TrashUserPickupDatePauseId);
            
            CreateTable(
                "dbo.TrashUserPickupDates",
                c => new
                    {
                        TrashUserPickupDateId = c.Int(nullable: false),
                        TrashUserPickupDateTime = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.TrashUserPickupDateId)
                .ForeignKey("dbo.TrashUsers", t => t.TrashUserPickupDateId)
                .Index(t => t.TrashUserPickupDateId);
            
            CreateTable(
                "dbo.TrashUserStates",
                c => new
                    {
                        TrashUserStateId = c.Int(nullable: false),
                        TrashUserStateAbbreviated = c.String(),
                        TrashUserStateFullName = c.String(),
                    })
                .PrimaryKey(t => t.TrashUserStateId)
                .ForeignKey("dbo.TrashUsers", t => t.TrashUserStateId)
                .Index(t => t.TrashUserStateId);
            
            CreateTable(
                "dbo.TrashUserTelephoneNumbers",
                c => new
                    {
                        TrashUserTelephoneNumberId = c.Int(nullable: false),
                        PhoneNumber = c.String(),
                    })
                .PrimaryKey(t => t.TrashUserTelephoneNumberId)
                .ForeignKey("dbo.TrashUsers", t => t.TrashUserTelephoneNumberId)
                .Index(t => t.TrashUserTelephoneNumberId);
            
            CreateTable(
                "dbo.TrashUserZipCodeAssigneds",
                c => new
                    {
                        TrashUserZipCodeAssignedId = c.Int(nullable: false),
                        TrashUserId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.TrashUserZipCodeAssignedId)
                .ForeignKey("dbo.TrashUsers", t => t.TrashUserId, cascadeDelete: true)
                .ForeignKey("dbo.TrashUserZipCodes", t => t.TrashUserZipCodeAssignedId)
                .Index(t => t.TrashUserZipCodeAssignedId)
                .Index(t => t.TrashUserId);
            
            CreateTable(
                "dbo.TrashUserZipCodes",
                c => new
                    {
                        TrashUserZipCodeId = c.Int(nullable: false),
                        TrashUserZipCodeInt = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.TrashUserZipCodeId)
                .ForeignKey("dbo.TrashUsers", t => t.TrashUserZipCodeId)
                .Index(t => t.TrashUserZipCodeId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.TrashUserZipCodeAssigneds", "TrashUserZipCodeAssignedId", "dbo.TrashUserZipCodes");
            DropForeignKey("dbo.TrashUserZipCodes", "TrashUserZipCodeId", "dbo.TrashUsers");
            DropForeignKey("dbo.TrashUserZipCodeAssigneds", "TrashUserId", "dbo.TrashUsers");
            DropForeignKey("dbo.TrashUserTelephoneNumbers", "TrashUserTelephoneNumberId", "dbo.TrashUsers");
            DropForeignKey("dbo.TrashUserStates", "TrashUserStateId", "dbo.TrashUsers");
            DropForeignKey("dbo.TrashUserPickupDates", "TrashUserPickupDateId", "dbo.TrashUsers");
            DropForeignKey("dbo.TrashUserPickupDatePauses", "TrashUserPickupDatePauseId", "dbo.TrashUsers");
            DropForeignKey("dbo.TrashUserPickupDateExtras", "TrashUserPickupDateExtraId", "dbo.TrashUsers");
            DropForeignKey("dbo.TrashUserAddresses", "TrashUserAddressId", "dbo.TrashUsers");
            DropForeignKey("dbo.TrashUsers", "ApplicationUserId", "dbo.AspNetUsers");
            DropForeignKey("dbo.AspNetUserRoles", "UserId", "dbo.AspNetUsers");
            DropForeignKey("dbo.AspNetUserLogins", "UserId", "dbo.AspNetUsers");
            DropForeignKey("dbo.AspNetUserClaims", "UserId", "dbo.AspNetUsers");
            DropForeignKey("dbo.AspNetUserRoles", "RoleId", "dbo.AspNetRoles");
            DropIndex("dbo.TrashUserZipCodes", new[] { "TrashUserZipCodeId" });
            DropIndex("dbo.TrashUserZipCodeAssigneds", new[] { "TrashUserId" });
            DropIndex("dbo.TrashUserZipCodeAssigneds", new[] { "TrashUserZipCodeAssignedId" });
            DropIndex("dbo.TrashUserTelephoneNumbers", new[] { "TrashUserTelephoneNumberId" });
            DropIndex("dbo.TrashUserStates", new[] { "TrashUserStateId" });
            DropIndex("dbo.TrashUserPickupDates", new[] { "TrashUserPickupDateId" });
            DropIndex("dbo.TrashUserPickupDatePauses", new[] { "TrashUserPickupDatePauseId" });
            DropIndex("dbo.TrashUserPickupDateExtras", new[] { "TrashUserPickupDateExtraId" });
            DropIndex("dbo.AspNetUserLogins", new[] { "UserId" });
            DropIndex("dbo.AspNetUserClaims", new[] { "UserId" });
            DropIndex("dbo.AspNetUsers", "UserNameIndex");
            DropIndex("dbo.TrashUsers", new[] { "ApplicationUserId" });
            DropIndex("dbo.TrashUserAddresses", new[] { "TrashUserAddressId" });
            DropIndex("dbo.AspNetUserRoles", new[] { "RoleId" });
            DropIndex("dbo.AspNetUserRoles", new[] { "UserId" });
            DropIndex("dbo.AspNetRoles", "RoleNameIndex");
            DropTable("dbo.TrashUserZipCodes");
            DropTable("dbo.TrashUserZipCodeAssigneds");
            DropTable("dbo.TrashUserTelephoneNumbers");
            DropTable("dbo.TrashUserStates");
            DropTable("dbo.TrashUserPickupDates");
            DropTable("dbo.TrashUserPickupDatePauses");
            DropTable("dbo.TrashUserPickupDateExtras");
            DropTable("dbo.AspNetUserLogins");
            DropTable("dbo.AspNetUserClaims");
            DropTable("dbo.AspNetUsers");
            DropTable("dbo.TrashUsers");
            DropTable("dbo.TrashUserAddresses");
            DropTable("dbo.AspNetUserRoles");
            DropTable("dbo.AspNetRoles");
        }
    }
}
