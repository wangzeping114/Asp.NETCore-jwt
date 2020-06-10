using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace HYPJ.Infrastructure.Migrations
{
    public partial class InitData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.EnsureSchema(
                name: "LYPJ");

            migrationBuilder.CreateTable(
                name: "Address",
                schema: "LYPJ",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Country = table.Column<string>(nullable: true),
                    CountryCode = table.Column<string>(nullable: true),
                    Province = table.Column<string>(nullable: false),
                    ProvinceCode = table.Column<string>(nullable: false),
                    City = table.Column<string>(nullable: false),
                    CityCode = table.Column<string>(nullable: false),
                    District = table.Column<string>(nullable: false),
                    DistrictCode = table.Column<string>(nullable: false),
                    Detail = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Address", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Advert",
                schema: "LYPJ",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    ImagePath = table.Column<string>(nullable: false),
                    Alt = table.Column<string>(nullable: true),
                    MaxNumber = table.Column<int>(nullable: false),
                    FailureAt = table.Column<DateTime>(nullable: false),
                    IsShow = table.Column<bool>(nullable: false, defaultValue: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Advert", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Category",
                schema: "LYPJ",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Key = table.Column<string>(nullable: false),
                    Icon = table.Column<string>(nullable: false),
                    Name = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Category", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "CdyDThelabel",
                schema: "LYPJ",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    TheLabel = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CdyDThelabel", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "CdySmallestUnit",
                schema: "LYPJ",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    UnitType = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CdySmallestUnit", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "CdyThelabel",
                schema: "LYPJ",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Type = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CdyThelabel", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Customer",
                schema: "LYPJ",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Phone = table.Column<string>(nullable: false),
                    Password = table.Column<string>(nullable: false),
                    Salt = table.Column<string>(nullable: false),
                    CreateOn = table.Column<DateTime>(nullable: false),
                    LastOn = table.Column<DateTime>(nullable: false),
                    DefaultBillingAddressId = table.Column<long>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Customer", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Menu",
                schema: "LYPJ",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    ParentId = table.Column<int>(nullable: true),
                    Icon = table.Column<string>(nullable: true),
                    Name = table.Column<string>(nullable: true),
                    ActionSref = table.Column<string>(nullable: true),
                    Path = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Menu", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Menu_Menu_ParentId",
                        column: x => x.ParentId,
                        principalSchema: "LYPJ",
                        principalTable: "Menu",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "MerchantInfo",
                schema: "LYPJ",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    MerchatId = table.Column<long>(nullable: false),
                    Name = table.Column<string>(nullable: false),
                    IdCard = table.Column<string>(nullable: true),
                    Phone = table.Column<string>(nullable: false),
                    BankCardId = table.Column<long>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MerchantInfo", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Role",
                schema: "LYPJ",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(type: "NVARCHAR(32)", nullable: false),
                    Description = table.Column<string>(nullable: true),
                    IsSuperAdmin = table.Column<bool>(nullable: false, defaultValue: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Role", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "SetMeal",
                schema: "LYPJ",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Title = table.Column<string>(nullable: false),
                    Description = table.Column<string>(nullable: true),
                    Price = table.Column<decimal>(type: "DECIMAL(9,2)", nullable: false),
                    MarketPrice = table.Column<decimal>(type: "DECIMAL(9,2)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SetMeal", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Commodity",
                schema: "LYPJ",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    TitileOrName = table.Column<string>(nullable: false),
                    SerialNumber = table.Column<string>(nullable: false),
                    CommodityStatus = table.Column<int>(nullable: false, defaultValue: 1),
                    ImagePath = table.Column<string>(nullable: true),
                    Price = table.Column<decimal>(type: "DECIMAL(9,2)", nullable: false),
                    MarketPrice = table.Column<decimal>(type: "DECIMAL(9,2)", nullable: false),
                    Sequence = table.Column<int>(nullable: false, defaultValue: 1),
                    ShelfTime = table.Column<DateTime>(nullable: true),
                    CreateTime = table.Column<DateTime>(nullable: false),
                    AsOfTime = table.Column<DateTime>(nullable: false),
                    CategoryId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Commodity", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Commodity_Category_CategoryId",
                        column: x => x.CategoryId,
                        principalSchema: "LYPJ",
                        principalTable: "Category",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "CustomerAddress",
                schema: "LYPJ",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    CustomerId = table.Column<int>(nullable: false),
                    AddressId = table.Column<int>(nullable: false),
                    CreateOn = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CustomerAddress", x => x.Id);
                    table.ForeignKey(
                        name: "FK_CustomerAddress_Address_AddressId",
                        column: x => x.AddressId,
                        principalSchema: "LYPJ",
                        principalTable: "Address",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CustomerAddress_Customer_CustomerId",
                        column: x => x.CustomerId,
                        principalSchema: "LYPJ",
                        principalTable: "Customer",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Order",
                schema: "LYPJ",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    OrderSerialNumber = table.Column<string>(nullable: false),
                    LatestUpdatedOn = table.Column<DateTime>(nullable: false),
                    CreatedOn = table.Column<DateTime>(nullable: false),
                    SubTotal = table.Column<decimal>(type: "Decimal(9,2)", nullable: false),
                    OrderTotal = table.Column<decimal>(type: "Decimal(9,2)", nullable: false),
                    OrderCount = table.Column<int>(nullable: false, defaultValue: 0),
                    TitileOrName = table.Column<string>(nullable: false),
                    CommoditySerialNumber = table.Column<string>(nullable: false),
                    Contact = table.Column<string>(nullable: false),
                    Phone = table.Column<string>(nullable: false),
                    OrderStatus = table.Column<int>(nullable: false, defaultValue: 1),
                    CustomerId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Order", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Order_Customer_CustomerId",
                        column: x => x.CustomerId,
                        principalSchema: "LYPJ",
                        principalTable: "Customer",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "WxCustomer",
                schema: "LYPJ",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    OpenId = table.Column<string>(nullable: false),
                    Avtar = table.Column<string>(nullable: true),
                    NickName = table.Column<string>(nullable: true),
                    Country = table.Column<string>(nullable: true),
                    Province = table.Column<string>(nullable: true),
                    City = table.Column<string>(nullable: true),
                    GenderType = table.Column<int>(nullable: false, defaultValue: 0),
                    CreateTime = table.Column<DateTime>(nullable: false),
                    CustomerId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_WxCustomer", x => x.Id);
                    table.ForeignKey(
                        name: "FK_WxCustomer_Customer_CustomerId",
                        column: x => x.CustomerId,
                        principalSchema: "LYPJ",
                        principalTable: "Customer",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "BankCard",
                schema: "LYPJ",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    OpeningBank = table.Column<string>(nullable: false),
                    BankCode = table.Column<string>(nullable: false),
                    CardNumber = table.Column<string>(nullable: false),
                    MerchantId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BankCard", x => x.Id);
                    table.ForeignKey(
                        name: "FK_BankCard_MerchantInfo_MerchantId",
                        column: x => x.MerchantId,
                        principalSchema: "LYPJ",
                        principalTable: "MerchantInfo",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Store",
                schema: "LYPJ",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(nullable: false),
                    BusinessTime = table.Column<DateTime>(nullable: false),
                    BusinessLicense = table.Column<string>(nullable: true),
                    LegalPerson = table.Column<string>(nullable: false),
                    Longitude = table.Column<double>(nullable: true),
                    Latitude = table.Column<double>(nullable: true),
                    StoreAddressId = table.Column<int>(nullable: false),
                    MerchantId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Store", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Store_MerchantInfo_MerchantId",
                        column: x => x.MerchantId,
                        principalSchema: "LYPJ",
                        principalTable: "MerchantInfo",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Account",
                schema: "LYPJ",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    IsDisplay = table.Column<bool>(nullable: false),
                    UserName = table.Column<string>(nullable: false),
                    FullName = table.Column<string>(nullable: false),
                    Password = table.Column<string>(nullable: false),
                    CreatedOn = table.Column<DateTime>(nullable: false, defaultValueSql: "GETDATE()"),
                    LatestUpdatedOn = table.Column<DateTime>(nullable: false, defaultValueSql: "GETDATE()"),
                    Salt = table.Column<string>(nullable: false),
                    BirthOn = table.Column<DateTime>(nullable: true),
                    Phone = table.Column<string>(nullable: true),
                    Avatar = table.Column<string>(nullable: true),
                    RoleId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Account", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Account_Role_RoleId",
                        column: x => x.RoleId,
                        principalSchema: "LYPJ",
                        principalTable: "Role",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "RoleMenu",
                schema: "LYPJ",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Permission = table.Column<int>(nullable: false, defaultValue: 0),
                    MenuId = table.Column<int>(nullable: false),
                    RoleId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RoleMenu", x => x.Id);
                    table.ForeignKey(
                        name: "FK_RoleMenu_Menu_MenuId",
                        column: x => x.MenuId,
                        principalSchema: "LYPJ",
                        principalTable: "Menu",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_RoleMenu_Role_RoleId",
                        column: x => x.RoleId,
                        principalSchema: "LYPJ",
                        principalTable: "Role",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "SetMealStock",
                schema: "LYPJ",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Quantity = table.Column<int>(nullable: false, defaultValue: 1),
                    ReservedQuantity = table.Column<int>(nullable: false, defaultValue: 1),
                    HaveSalesQuantity = table.Column<int>(nullable: false, defaultValue: 0),
                    SetMealId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SetMealStock", x => x.Id);
                    table.ForeignKey(
                        name: "FK_SetMealStock_SetMeal_SetMealId",
                        column: x => x.SetMealId,
                        principalSchema: "LYPJ",
                        principalTable: "SetMeal",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AdvertCommodity",
                schema: "LYPJ",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    CommodityId = table.Column<int>(nullable: false),
                    AdvertId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AdvertCommodity", x => new { x.AdvertId, x.CommodityId });
                    table.ForeignKey(
                        name: "FK_AdvertCommodity_Advert_AdvertId",
                        column: x => x.AdvertId,
                        principalSchema: "LYPJ",
                        principalTable: "Advert",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AdvertCommodity_Commodity_CommodityId",
                        column: x => x.CommodityId,
                        principalSchema: "LYPJ",
                        principalTable: "Commodity",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "CdySalesPlan",
                schema: "LYPJ",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    PlanPrice = table.Column<decimal>(type: "Decimal(9,2)", nullable: false),
                    PlanTime = table.Column<DateTime>(nullable: false),
                    CommodityId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CdySalesPlan", x => x.Id);
                    table.ForeignKey(
                        name: "FK_CdySalesPlan_Commodity_CommodityId",
                        column: x => x.CommodityId,
                        principalSchema: "LYPJ",
                        principalTable: "Commodity",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "CdySmallestUnitCommodities",
                schema: "LYPJ",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    CdySamllestUnitId = table.Column<int>(nullable: false),
                    CommodityId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CdySmallestUnitCommodities", x => new { x.CommodityId, x.CdySamllestUnitId });
                    table.ForeignKey(
                        name: "FK_CdySmallestUnitCommodities_CdySmallestUnit_CdySamllestUnitId",
                        column: x => x.CdySamllestUnitId,
                        principalSchema: "LYPJ",
                        principalTable: "CdySmallestUnit",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CdySmallestUnitCommodities_Commodity_CommodityId",
                        column: x => x.CommodityId,
                        principalSchema: "LYPJ",
                        principalTable: "Commodity",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "CdyThelabelCommodity",
                schema: "LYPJ",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    CdyThelabelId = table.Column<int>(nullable: false),
                    CommdityId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CdyThelabelCommodity", x => new { x.CommdityId, x.CdyThelabelId });
                    table.ForeignKey(
                        name: "FK_CdyThelabelCommodity_CdyThelabel_CdyThelabelId",
                        column: x => x.CdyThelabelId,
                        principalSchema: "LYPJ",
                        principalTable: "CdyThelabel",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CdyThelabelCommodity_Commodity_CommdityId",
                        column: x => x.CommdityId,
                        principalSchema: "LYPJ",
                        principalTable: "Commodity",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "CommodityDetail",
                schema: "LYPJ",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    CommodityId = table.Column<int>(nullable: false),
                    ActivityAddressDescription = table.Column<string>(nullable: false),
                    ActivityTimeDescription = table.Column<string>(nullable: false),
                    NeedKnowPath = table.Column<string>(nullable: false),
                    DetailPath = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CommodityDetail", x => x.Id);
                    table.ForeignKey(
                        name: "FK_CommodityDetail_Commodity_CommodityId",
                        column: x => x.CommodityId,
                        principalSchema: "LYPJ",
                        principalTable: "Commodity",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Stock",
                schema: "LYPJ",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Quantity = table.Column<int>(nullable: false, defaultValue: 1),
                    ReservedQuantity = table.Column<int>(nullable: false, defaultValue: 0),
                    HaveSalesQuantity = table.Column<int>(nullable: false, defaultValue: 0),
                    CommodityId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Stock", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Stock_Commodity_CommodityId",
                        column: x => x.CommodityId,
                        principalSchema: "LYPJ",
                        principalTable: "Commodity",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "OrderAddress",
                schema: "LYPJ",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    ContactName = table.Column<string>(nullable: false),
                    Phone = table.Column<string>(nullable: false),
                    ZipCode = table.Column<string>(nullable: true),
                    AddressLine = table.Column<string>(nullable: true),
                    OrderId = table.Column<long>(nullable: false),
                    AddressId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OrderAddress", x => x.Id);
                    table.ForeignKey(
                        name: "FK_OrderAddress_Address_AddressId",
                        column: x => x.AddressId,
                        principalSchema: "LYPJ",
                        principalTable: "Address",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_OrderAddress_Order_OrderId",
                        column: x => x.OrderId,
                        principalSchema: "LYPJ",
                        principalTable: "Order",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "PaymentRecord",
                schema: "LYPJ",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    PaymentSerialNumber = table.Column<string>(nullable: false),
                    PaymentType = table.Column<int>(nullable: false, defaultValue: 0),
                    OrderId = table.Column<long>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PaymentRecord", x => x.Id);
                    table.ForeignKey(
                        name: "FK_PaymentRecord_Order_OrderId",
                        column: x => x.OrderId,
                        principalSchema: "LYPJ",
                        principalTable: "Order",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "StoreAddress",
                schema: "LYPJ",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    AddressId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_StoreAddress", x => x.Id);
                    table.UniqueConstraint("AK_StoreAddress_AddressId", x => x.AddressId);
                    table.ForeignKey(
                        name: "FK_StoreAddress_Address_AddressId",
                        column: x => x.AddressId,
                        principalSchema: "LYPJ",
                        principalTable: "Address",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_StoreAddress_Store_AddressId",
                        column: x => x.AddressId,
                        principalSchema: "LYPJ",
                        principalTable: "Store",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "StoreCommodities",
                schema: "LYPJ",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    StoreId = table.Column<int>(nullable: false),
                    CommodityId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_StoreCommodities", x => new { x.CommodityId, x.StoreId });
                    table.ForeignKey(
                        name: "FK_StoreCommodities_Commodity_CommodityId",
                        column: x => x.CommodityId,
                        principalSchema: "LYPJ",
                        principalTable: "Commodity",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_StoreCommodities_Store_StoreId",
                        column: x => x.StoreId,
                        principalSchema: "LYPJ",
                        principalTable: "Store",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "CdyDThelabelCommodityDetail",
                schema: "LYPJ",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    CdyDThelabelId = table.Column<int>(nullable: false),
                    CommodityDetailId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CdyDThelabelCommodityDetail", x => new { x.CdyDThelabelId, x.CommodityDetailId });
                    table.ForeignKey(
                        name: "FK_CdyDThelabelCommodityDetail_CdyDThelabel_CdyDThelabelId",
                        column: x => x.CdyDThelabelId,
                        principalSchema: "LYPJ",
                        principalTable: "CdyDThelabel",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CdyDThelabelCommodityDetail_CommodityDetail_CommodityDetailId",
                        column: x => x.CommodityDetailId,
                        principalSchema: "LYPJ",
                        principalTable: "CommodityDetail",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "CommodityDetailPirture",
                schema: "LYPJ",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Path = table.Column<string>(nullable: false),
                    Sequence = table.Column<int>(nullable: false, defaultValue: 1),
                    CommodityDetailId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CommodityDetailPirture", x => x.Id);
                    table.ForeignKey(
                        name: "FK_CommodityDetailPirture_CommodityDetail_CommodityDetailId",
                        column: x => x.CommodityDetailId,
                        principalSchema: "LYPJ",
                        principalTable: "CommodityDetail",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "BillsFlow",
                schema: "LYPJ",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    PaymentRecordId = table.Column<long>(nullable: false),
                    BillsStatus = table.Column<int>(nullable: false, defaultValue: 204),
                    Note = table.Column<string>(nullable: true),
                    AccountId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BillsFlow", x => x.Id);
                    table.ForeignKey(
                        name: "FK_BillsFlow_Account_AccountId",
                        column: x => x.AccountId,
                        principalSchema: "LYPJ",
                        principalTable: "Account",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_BillsFlow_PaymentRecord_PaymentRecordId",
                        column: x => x.PaymentRecordId,
                        principalSchema: "LYPJ",
                        principalTable: "PaymentRecord",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Account_RoleId",
                schema: "LYPJ",
                table: "Account",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "IX_AdvertCommodity_CommodityId",
                schema: "LYPJ",
                table: "AdvertCommodity",
                column: "CommodityId");

            migrationBuilder.CreateIndex(
                name: "IX_BankCard_MerchantId",
                schema: "LYPJ",
                table: "BankCard",
                column: "MerchantId");

            migrationBuilder.CreateIndex(
                name: "IX_BillsFlow_AccountId",
                schema: "LYPJ",
                table: "BillsFlow",
                column: "AccountId");

            migrationBuilder.CreateIndex(
                name: "IX_BillsFlow_PaymentRecordId",
                schema: "LYPJ",
                table: "BillsFlow",
                column: "PaymentRecordId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_CdyDThelabelCommodityDetail_CommodityDetailId",
                schema: "LYPJ",
                table: "CdyDThelabelCommodityDetail",
                column: "CommodityDetailId");

            migrationBuilder.CreateIndex(
                name: "IX_CdySalesPlan_CommodityId",
                schema: "LYPJ",
                table: "CdySalesPlan",
                column: "CommodityId");

            migrationBuilder.CreateIndex(
                name: "IX_CdySmallestUnitCommodities_CdySamllestUnitId",
                schema: "LYPJ",
                table: "CdySmallestUnitCommodities",
                column: "CdySamllestUnitId");

            migrationBuilder.CreateIndex(
                name: "IX_CdyThelabelCommodity_CdyThelabelId",
                schema: "LYPJ",
                table: "CdyThelabelCommodity",
                column: "CdyThelabelId");

            migrationBuilder.CreateIndex(
                name: "IX_Commodity_CategoryId",
                schema: "LYPJ",
                table: "Commodity",
                column: "CategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_CommodityDetail_CommodityId",
                schema: "LYPJ",
                table: "CommodityDetail",
                column: "CommodityId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_CommodityDetailPirture_CommodityDetailId",
                schema: "LYPJ",
                table: "CommodityDetailPirture",
                column: "CommodityDetailId");

            migrationBuilder.CreateIndex(
                name: "IX_CustomerAddress_AddressId",
                schema: "LYPJ",
                table: "CustomerAddress",
                column: "AddressId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_CustomerAddress_CustomerId",
                schema: "LYPJ",
                table: "CustomerAddress",
                column: "CustomerId");

            migrationBuilder.CreateIndex(
                name: "IX_Menu_ParentId",
                schema: "LYPJ",
                table: "Menu",
                column: "ParentId");

            migrationBuilder.CreateIndex(
                name: "IX_Order_CustomerId",
                schema: "LYPJ",
                table: "Order",
                column: "CustomerId");

            migrationBuilder.CreateIndex(
                name: "IX_OrderAddress_AddressId",
                schema: "LYPJ",
                table: "OrderAddress",
                column: "AddressId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_OrderAddress_OrderId",
                schema: "LYPJ",
                table: "OrderAddress",
                column: "OrderId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_PaymentRecord_OrderId",
                schema: "LYPJ",
                table: "PaymentRecord",
                column: "OrderId");

            migrationBuilder.CreateIndex(
                name: "IX_RoleMenu_MenuId",
                schema: "LYPJ",
                table: "RoleMenu",
                column: "MenuId");

            migrationBuilder.CreateIndex(
                name: "IX_RoleMenu_RoleId",
                schema: "LYPJ",
                table: "RoleMenu",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "IX_SetMealStock_SetMealId",
                schema: "LYPJ",
                table: "SetMealStock",
                column: "SetMealId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Stock_CommodityId",
                schema: "LYPJ",
                table: "Stock",
                column: "CommodityId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Store_MerchantId",
                schema: "LYPJ",
                table: "Store",
                column: "MerchantId");

            migrationBuilder.CreateIndex(
                name: "IX_StoreCommodities_StoreId",
                schema: "LYPJ",
                table: "StoreCommodities",
                column: "StoreId");

            migrationBuilder.CreateIndex(
                name: "IX_WxCustomer_CustomerId",
                schema: "LYPJ",
                table: "WxCustomer",
                column: "CustomerId",
                unique: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AdvertCommodity",
                schema: "LYPJ");

            migrationBuilder.DropTable(
                name: "BankCard",
                schema: "LYPJ");

            migrationBuilder.DropTable(
                name: "BillsFlow",
                schema: "LYPJ");

            migrationBuilder.DropTable(
                name: "CdyDThelabelCommodityDetail",
                schema: "LYPJ");

            migrationBuilder.DropTable(
                name: "CdySalesPlan",
                schema: "LYPJ");

            migrationBuilder.DropTable(
                name: "CdySmallestUnitCommodities",
                schema: "LYPJ");

            migrationBuilder.DropTable(
                name: "CdyThelabelCommodity",
                schema: "LYPJ");

            migrationBuilder.DropTable(
                name: "CommodityDetailPirture",
                schema: "LYPJ");

            migrationBuilder.DropTable(
                name: "CustomerAddress",
                schema: "LYPJ");

            migrationBuilder.DropTable(
                name: "OrderAddress",
                schema: "LYPJ");

            migrationBuilder.DropTable(
                name: "RoleMenu",
                schema: "LYPJ");

            migrationBuilder.DropTable(
                name: "SetMealStock",
                schema: "LYPJ");

            migrationBuilder.DropTable(
                name: "Stock",
                schema: "LYPJ");

            migrationBuilder.DropTable(
                name: "StoreAddress",
                schema: "LYPJ");

            migrationBuilder.DropTable(
                name: "StoreCommodities",
                schema: "LYPJ");

            migrationBuilder.DropTable(
                name: "WxCustomer",
                schema: "LYPJ");

            migrationBuilder.DropTable(
                name: "Advert",
                schema: "LYPJ");

            migrationBuilder.DropTable(
                name: "Account",
                schema: "LYPJ");

            migrationBuilder.DropTable(
                name: "PaymentRecord",
                schema: "LYPJ");

            migrationBuilder.DropTable(
                name: "CdyDThelabel",
                schema: "LYPJ");

            migrationBuilder.DropTable(
                name: "CdySmallestUnit",
                schema: "LYPJ");

            migrationBuilder.DropTable(
                name: "CdyThelabel",
                schema: "LYPJ");

            migrationBuilder.DropTable(
                name: "CommodityDetail",
                schema: "LYPJ");

            migrationBuilder.DropTable(
                name: "Menu",
                schema: "LYPJ");

            migrationBuilder.DropTable(
                name: "SetMeal",
                schema: "LYPJ");

            migrationBuilder.DropTable(
                name: "Address",
                schema: "LYPJ");

            migrationBuilder.DropTable(
                name: "Store",
                schema: "LYPJ");

            migrationBuilder.DropTable(
                name: "Role",
                schema: "LYPJ");

            migrationBuilder.DropTable(
                name: "Order",
                schema: "LYPJ");

            migrationBuilder.DropTable(
                name: "Commodity",
                schema: "LYPJ");

            migrationBuilder.DropTable(
                name: "MerchantInfo",
                schema: "LYPJ");

            migrationBuilder.DropTable(
                name: "Customer",
                schema: "LYPJ");

            migrationBuilder.DropTable(
                name: "Category",
                schema: "LYPJ");
        }
    }
}
