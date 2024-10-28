using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace UTT_21_22.ProjectFinal.Data.Migrations
{
    public partial class StoreWatchInformationDB : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "CategoryAccount",
                columns: table => new
                {
                    CategoryAccountId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CategoryAccountName = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CategoryAccount", x => x.CategoryAccountId);
                });

            migrationBuilder.CreateTable(
                name: "CategoryPost",
                columns: table => new
                {
                    CategoryPostId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CategoryPostName = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CategoryPost", x => x.CategoryPostId);
                });

            migrationBuilder.CreateTable(
                name: "CategoryStore",
                columns: table => new
                {
                    CategoryStoreId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CategoryStoreName = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CategoryStore", x => x.CategoryStoreId);
                });

            migrationBuilder.CreateTable(
                name: "CategoryWatch",
                columns: table => new
                {
                    CategoryWatchId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CategoryWatchName = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    Description = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CategoryWatch", x => x.CategoryWatchId);
                });

            migrationBuilder.CreateTable(
                name: "Color",
                columns: table => new
                {
                    ColorId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ColorName = table.Column<string>(type: "nvarchar(25)", maxLength: 25, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Color", x => x.ColorId);
                });

            migrationBuilder.CreateTable(
                name: "Review",
                columns: table => new
                {
                    ReviewId = table.Column<string>(type: "varchar", nullable: false),
                    PointRating = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    ReviewContent = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: true),
                    Status = table.Column<int>(type: "int", nullable: true),
                    TimePost = table.Column<DateTime>(type: "datetime2", nullable: false),
                    TimeModified = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Review", x => x.ReviewId);
                });

            migrationBuilder.CreateTable(
                name: "Rule",
                columns: table => new
                {
                    RuleId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RuleName = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Rule", x => x.RuleId);
                });

            migrationBuilder.CreateTable(
                name: "Account",
                columns: table => new
                {
                    AccountId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CategoryAccountId = table.Column<int>(type: "int", nullable: false),
                    UserName = table.Column<string>(type: "varchar(20)", maxLength: 20, nullable: false),
                    Password = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: false),
                    CreateUser = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    CreateTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    TimeExpired = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Account", x => x.AccountId);
                    table.ForeignKey(
                        name: "FK_Account_CategoryAccount_CategoryAccountId",
                        column: x => x.CategoryAccountId,
                        principalTable: "CategoryAccount",
                        principalColumn: "CategoryAccountId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Post",
                columns: table => new
                {
                    PostId = table.Column<string>(type: "varchar", nullable: false),
                    PostTitle = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    PostContent = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    CategoryPostId = table.Column<int>(type: "int", nullable: true),
                    Image = table.Column<byte[]>(type: "varbinary(max)", nullable: true),
                    Status = table.Column<int>(type: "int", nullable: false),
                    TimePost = table.Column<DateTime>(type: "datetime2", nullable: false),
                    TimeModified = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ReviewId = table.Column<string>(type: "varchar", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Post", x => x.PostId);
                    table.ForeignKey(
                        name: "FK_Post_CategoryPost_CategoryPostId",
                        column: x => x.CategoryPostId,
                        principalTable: "CategoryPost",
                        principalColumn: "CategoryPostId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Post_Review_ReviewId",
                        column: x => x.ReviewId,
                        principalTable: "Review",
                        principalColumn: "ReviewId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Stores",
                columns: table => new
                {
                    StoreId = table.Column<string>(type: "varchar(20)", maxLength: 20, nullable: false),
                    StoreName = table.Column<string>(type: "nvarchar(80)", maxLength: 80, nullable: false),
                    CategoryStoreId = table.Column<int>(type: "int", nullable: true),
                    CategoryShopId = table.Column<int>(type: "int", nullable: true),
                    Owner = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    GetStatus = table.Column<int>(type: "int", nullable: true),
                    Address = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: false),
                    HotLine = table.Column<string>(type: "varchar(20)", maxLength: 20, nullable: false),
                    Email = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: true),
                    Website = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: false),
                    Image = table.Column<byte[]>(type: "varbinary(max)", nullable: true),
                    ReviewId = table.Column<string>(type: "varchar", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Stores", x => x.StoreId);
                    table.ForeignKey(
                        name: "FK_Stores_CategoryStore_CategoryShopId",
                        column: x => x.CategoryShopId,
                        principalTable: "CategoryStore",
                        principalColumn: "CategoryStoreId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Stores_Review_ReviewId",
                        column: x => x.ReviewId,
                        principalTable: "Review",
                        principalColumn: "ReviewId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Watches",
                columns: table => new
                {
                    WatchId = table.Column<string>(type: "varchar(20)", maxLength: 20, nullable: false),
                    WatchName = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    ColorId = table.Column<int>(type: "int", nullable: true),
                    CategoryWatchId = table.Column<int>(type: "int", nullable: true),
                    Status = table.Column<int>(type: "int", nullable: false),
                    BusinessStatus = table.Column<int>(type: "int", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: true),
                    DetailInformation = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: true),
                    TimeManufacture = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Insurance = table.Column<int>(type: "int", nullable: false),
                    Price = table.Column<double>(type: "float", nullable: true),
                    Image = table.Column<byte[]>(type: "varbinary(max)", nullable: true),
                    ReviewId = table.Column<string>(type: "varchar", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Watches", x => x.WatchId);
                    table.ForeignKey(
                        name: "FK_Watches_CategoryWatch_CategoryWatchId",
                        column: x => x.CategoryWatchId,
                        principalTable: "CategoryWatch",
                        principalColumn: "CategoryWatchId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Watches_Color_ColorId",
                        column: x => x.ColorId,
                        principalTable: "Color",
                        principalColumn: "ColorId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Watches_Review_ReviewId",
                        column: x => x.ReviewId,
                        principalTable: "Review",
                        principalColumn: "ReviewId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Role",
                columns: table => new
                {
                    RoleId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RoleName = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    RuleId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Role", x => x.RoleId);
                    table.ForeignKey(
                        name: "FK_Role_Rule_RuleId",
                        column: x => x.RuleId,
                        principalTable: "Rule",
                        principalColumn: "RuleId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Customer",
                columns: table => new
                {
                    CustomerId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    CustomerName = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    Sex = table.Column<int>(type: "int", nullable: false),
                    BirthDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    NumberPhone = table.Column<string>(type: "varchar(20)", maxLength: 20, nullable: false),
                    Email = table.Column<string>(type: "varchar(25)", maxLength: 25, nullable: false),
                    HomeTown = table.Column<string>(type: "nvarchar(25)", maxLength: 25, nullable: true),
                    PermanentAddress = table.Column<string>(type: "nvarchar(25)", maxLength: 25, nullable: false),
                    Note = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true),
                    AccountId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Customer", x => x.CustomerId);
                    table.ForeignKey(
                        name: "FK_Customer_Account_AccountId",
                        column: x => x.AccountId,
                        principalTable: "Account",
                        principalColumn: "AccountId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Admin",
                columns: table => new
                {
                    AdminId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    AdminName = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    Sex = table.Column<int>(type: "int", nullable: false),
                    BirthDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    NumberPhone = table.Column<string>(type: "varchar(20)", maxLength: 20, nullable: false),
                    Email = table.Column<string>(type: "varchar(25)", maxLength: 25, nullable: false),
                    Description = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: true),
                    Note = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true),
                    RuleId = table.Column<int>(type: "int", nullable: false),
                    AccountId = table.Column<int>(type: "int", nullable: false),
                    PostId = table.Column<string>(type: "varchar", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Admin", x => x.AdminId);
                    table.ForeignKey(
                        name: "FK_Admin_Account_AccountId",
                        column: x => x.AccountId,
                        principalTable: "Account",
                        principalColumn: "AccountId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Admin_Post_PostId",
                        column: x => x.PostId,
                        principalTable: "Post",
                        principalColumn: "PostId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Admin_Rule_RuleId",
                        column: x => x.RuleId,
                        principalTable: "Rule",
                        principalColumn: "RuleId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "StoreWatches",
                columns: table => new
                {
                    StoreId = table.Column<string>(type: "varchar(20)", maxLength: 20, nullable: false),
                    WatchId = table.Column<string>(type: "varchar(20)", maxLength: 20, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_StoreWatches", x => new { x.StoreId, x.WatchId });
                    table.ForeignKey(
                        name: "FK_StoreWatches_Stores_StoreId",
                        column: x => x.StoreId,
                        principalTable: "Stores",
                        principalColumn: "StoreId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_StoreWatches_Watches_WatchId",
                        column: x => x.WatchId,
                        principalTable: "Watches",
                        principalColumn: "WatchId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Account_CategoryAccountId",
                table: "Account",
                column: "CategoryAccountId");

            migrationBuilder.CreateIndex(
                name: "IX_Admin_AccountId",
                table: "Admin",
                column: "AccountId");

            migrationBuilder.CreateIndex(
                name: "IX_Admin_PostId",
                table: "Admin",
                column: "PostId");

            migrationBuilder.CreateIndex(
                name: "IX_Admin_RuleId",
                table: "Admin",
                column: "RuleId");

            migrationBuilder.CreateIndex(
                name: "IX_Customer_AccountId",
                table: "Customer",
                column: "AccountId");

            migrationBuilder.CreateIndex(
                name: "IX_Post_CategoryPostId",
                table: "Post",
                column: "CategoryPostId");

            migrationBuilder.CreateIndex(
                name: "IX_Post_ReviewId",
                table: "Post",
                column: "ReviewId");

            migrationBuilder.CreateIndex(
                name: "IX_Role_RuleId",
                table: "Role",
                column: "RuleId");

            migrationBuilder.CreateIndex(
                name: "IX_Stores_CategoryShopId",
                table: "Stores",
                column: "CategoryShopId");

            migrationBuilder.CreateIndex(
                name: "IX_Stores_ReviewId",
                table: "Stores",
                column: "ReviewId");

            migrationBuilder.CreateIndex(
                name: "IX_StoreWatches_WatchId",
                table: "StoreWatches",
                column: "WatchId");

            migrationBuilder.CreateIndex(
                name: "IX_Watches_CategoryWatchId",
                table: "Watches",
                column: "CategoryWatchId");

            migrationBuilder.CreateIndex(
                name: "IX_Watches_ColorId",
                table: "Watches",
                column: "ColorId");

            migrationBuilder.CreateIndex(
                name: "IX_Watches_ReviewId",
                table: "Watches",
                column: "ReviewId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Admin");

            migrationBuilder.DropTable(
                name: "Customer");

            migrationBuilder.DropTable(
                name: "Role");

            migrationBuilder.DropTable(
                name: "StoreWatches");

            migrationBuilder.DropTable(
                name: "Post");

            migrationBuilder.DropTable(
                name: "Account");

            migrationBuilder.DropTable(
                name: "Rule");

            migrationBuilder.DropTable(
                name: "Stores");

            migrationBuilder.DropTable(
                name: "Watches");

            migrationBuilder.DropTable(
                name: "CategoryPost");

            migrationBuilder.DropTable(
                name: "CategoryAccount");

            migrationBuilder.DropTable(
                name: "CategoryStore");

            migrationBuilder.DropTable(
                name: "CategoryWatch");

            migrationBuilder.DropTable(
                name: "Color");

            migrationBuilder.DropTable(
                name: "Review");
        }
    }
}
