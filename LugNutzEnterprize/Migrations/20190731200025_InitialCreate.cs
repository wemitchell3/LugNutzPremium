﻿using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace LugNutzEnterprize.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AspNetRoles",
                columns: table => new
                {
                    Id = table.Column<string>(nullable: false),
                    Name = table.Column<string>(maxLength: 256, nullable: true),
                    NormalizedName = table.Column<string>(maxLength: 256, nullable: true),
                    ConcurrencyStamp = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUsers",
                columns: table => new
                {
                    Id = table.Column<string>(nullable: false),
                    UserName = table.Column<string>(maxLength: 256, nullable: true),
                    NormalizedUserName = table.Column<string>(maxLength: 256, nullable: true),
                    Email = table.Column<string>(maxLength: 256, nullable: true),
                    NormalizedEmail = table.Column<string>(maxLength: 256, nullable: true),
                    EmailConfirmed = table.Column<bool>(nullable: false),
                    PasswordHash = table.Column<string>(nullable: true),
                    SecurityStamp = table.Column<string>(nullable: true),
                    ConcurrencyStamp = table.Column<string>(nullable: true),
                    PhoneNumber = table.Column<string>(nullable: true),
                    PhoneNumberConfirmed = table.Column<bool>(nullable: false),
                    TwoFactorEnabled = table.Column<bool>(nullable: false),
                    LockoutEnd = table.Column<DateTimeOffset>(nullable: true),
                    LockoutEnabled = table.Column<bool>(nullable: false),
                    AccessFailedCount = table.Column<int>(nullable: false),
                    FirstName = table.Column<string>(nullable: false),
                    LastName = table.Column<string>(nullable: false),
                    StreetAddress = table.Column<string>(nullable: true),
                    City = table.Column<string>(nullable: true),
                    State = table.Column<string>(nullable: true),
                    Zip = table.Column<int>(nullable: false),
                    IsMasterMechanic = table.Column<bool>(nullable: false),
                    IsAdmin = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUsers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "MaintenanceTask",
                columns: table => new
                {
                    MaintenanceTaskId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    VehicleId = table.Column<int>(nullable: false),
                    MaintenanceTaskTitle = table.Column<string>(nullable: false),
                    MaintenanceTaskDescription = table.Column<string>(nullable: false),
                    TaskDueAtMileage = table.Column<int>(nullable: false),
                    IsComplete = table.Column<bool>(nullable: false),
                    DateCreated = table.Column<DateTime>(nullable: false),
                    TargetCompleteDate = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MaintenanceTask", x => x.MaintenanceTaskId);
                });

            migrationBuilder.CreateTable(
                name: "Message",
                columns: table => new
                {
                    MessageId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    UserId = table.Column<string>(nullable: false),
                    DateCreated = table.Column<DateTime>(nullable: false),
                    MessageContent = table.Column<string>(nullable: false),
                    Topic = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Message", x => x.MessageId);
                });

            migrationBuilder.CreateTable(
                name: "Vehicle",
                columns: table => new
                {
                    VehicleId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    UserId = table.Column<int>(nullable: false),
                    VehicleMileage = table.Column<int>(nullable: false),
                    ABS = table.Column<string>(nullable: true),
                    ActiveSafetySysNote = table.Column<string>(nullable: true),
                    AdaptiveCruiseControl = table.Column<string>(nullable: true),
                    AdaptiveDrivingBeam = table.Column<string>(nullable: true),
                    AdaptiveHeadlights = table.Column<string>(nullable: true),
                    AdditionalErrorText = table.Column<string>(nullable: true),
                    AirBagLocCurtain = table.Column<string>(nullable: true),
                    AirBagLocFront = table.Column<string>(nullable: true),
                    AirBagLocKnee = table.Column<string>(nullable: true),
                    AirBagLocSeatCushion = table.Column<string>(nullable: true),
                    AirBagLocSide = table.Column<string>(nullable: true),
                    AutoReverseSystem = table.Column<string>(nullable: true),
                    AutomaticPedestrianAlertingSound = table.Column<string>(nullable: true),
                    AxleConfiguration = table.Column<string>(nullable: true),
                    Axles = table.Column<string>(nullable: true),
                    BasePrice = table.Column<string>(nullable: true),
                    BatteryA = table.Column<string>(nullable: true),
                    BatteryA_to = table.Column<string>(nullable: true),
                    BatteryCells = table.Column<string>(nullable: true),
                    BatteryInfo = table.Column<string>(nullable: true),
                    BatteryKWh = table.Column<string>(nullable: true),
                    BatteryKWh_to = table.Column<string>(nullable: true),
                    BatteryModules = table.Column<string>(nullable: true),
                    BatteryPacks = table.Column<string>(nullable: true),
                    BatteryType = table.Column<string>(nullable: true),
                    BatteryV = table.Column<string>(nullable: true),
                    BatteryV_to = table.Column<string>(nullable: true),
                    BedLengthIN = table.Column<string>(nullable: true),
                    BedType = table.Column<string>(nullable: true),
                    BlindSpotMon = table.Column<string>(nullable: true),
                    BodyCabType = table.Column<string>(nullable: true),
                    BodyClass = table.Column<string>(nullable: true),
                    BrakeSystemDesc = table.Column<string>(nullable: true),
                    BrakeSystemType = table.Column<string>(nullable: true),
                    BusFloorConfigType = table.Column<string>(nullable: true),
                    BusLength = table.Column<string>(nullable: true),
                    BusType = table.Column<string>(nullable: true),
                    CAN_AACN = table.Column<string>(nullable: true),
                    CIB = table.Column<string>(nullable: true),
                    CashForClunkers = table.Column<string>(nullable: true),
                    ChargerLevel = table.Column<string>(nullable: true),
                    ChargerPowerKW = table.Column<string>(nullable: true),
                    CoolingType = table.Column<string>(nullable: true),
                    CurbWeightLB = table.Column<string>(nullable: true),
                    CustomMotorcycleType = table.Column<string>(nullable: true),
                    DaytimeRunningLight = table.Column<string>(nullable: true),
                    DestinationMarket = table.Column<string>(nullable: true),
                    DisplacementCC = table.Column<string>(nullable: true),
                    DisplacementCI = table.Column<string>(nullable: true),
                    DisplacementL = table.Column<string>(nullable: true),
                    Doors = table.Column<string>(nullable: true),
                    DriveType = table.Column<string>(nullable: true),
                    DriverAssist = table.Column<string>(nullable: true),
                    DynamicBrakeSupport = table.Column<string>(nullable: true),
                    EDR = table.Column<string>(nullable: true),
                    ESC = table.Column<string>(nullable: true),
                    EVDriveUnit = table.Column<string>(nullable: true),
                    ElectrificationLevel = table.Column<string>(nullable: true),
                    EngineConfiguration = table.Column<string>(nullable: true),
                    EngineCycles = table.Column<string>(nullable: true),
                    EngineCylinders = table.Column<string>(nullable: true),
                    EngineHP = table.Column<string>(nullable: true),
                    EngineHP_to = table.Column<string>(nullable: true),
                    EngineKW = table.Column<string>(nullable: true),
                    EngineManufacturer = table.Column<string>(nullable: true),
                    EngineModel = table.Column<string>(nullable: true),
                    EntertainmentSystem = table.Column<string>(nullable: true),
                    ErrorCode = table.Column<string>(nullable: true),
                    ErrorText = table.Column<string>(nullable: true),
                    ForwardCollisionWarning = table.Column<string>(nullable: true),
                    FuelInjectionType = table.Column<string>(nullable: true),
                    FuelTypePrimary = table.Column<string>(nullable: true),
                    FuelTypeSecondary = table.Column<string>(nullable: true),
                    GCWR = table.Column<string>(nullable: true),
                    GCWR_to = table.Column<string>(nullable: true),
                    GVWR = table.Column<string>(nullable: true),
                    GVWR_to = table.Column<string>(nullable: true),
                    KeylessIgnition = table.Column<string>(nullable: true),
                    LaneDepartureWarning = table.Column<string>(nullable: true),
                    LaneKeepSystem = table.Column<string>(nullable: true),
                    LowerBeamHeadlampLightSource = table.Column<string>(nullable: true),
                    Make = table.Column<string>(nullable: false),
                    Manufacturer = table.Column<string>(nullable: true),
                    ManufacturerId = table.Column<string>(nullable: true),
                    Model = table.Column<string>(nullable: false),
                    ModelYear = table.Column<string>(nullable: false),
                    MotorcycleChassisType = table.Column<string>(nullable: true),
                    MotorcycleSuspensionType = table.Column<string>(nullable: true),
                    NCSABodyType = table.Column<string>(nullable: true),
                    NCSAMake = table.Column<string>(nullable: true),
                    NCSAMapExcApprovedBy = table.Column<string>(nullable: true),
                    NCSAMapExcApprovedOn = table.Column<string>(nullable: true),
                    NCSAMappingException = table.Column<string>(nullable: true),
                    NCSAModel = table.Column<string>(nullable: true),
                    NCSANote = table.Column<string>(nullable: true),
                    Note = table.Column<string>(nullable: true),
                    OtherBusInfo = table.Column<string>(nullable: true),
                    OtherEngineInfo = table.Column<string>(nullable: true),
                    OtherMotorcycleInfo = table.Column<string>(nullable: true),
                    OtherRestraintSystemInfo = table.Column<string>(nullable: true),
                    OtherTrailerInfo = table.Column<string>(nullable: true),
                    ParkAssist = table.Column<string>(nullable: true),
                    PedestrianAutomaticEmergencyBraking = table.Column<string>(nullable: true),
                    PlantCity = table.Column<string>(nullable: true),
                    PlantCompanyName = table.Column<string>(nullable: true),
                    PlantCountry = table.Column<string>(nullable: true),
                    PlantState = table.Column<string>(nullable: true),
                    PossibleValues = table.Column<string>(nullable: true),
                    Pretensioner = table.Column<string>(nullable: true),
                    RearCrossTrafficAlert = table.Column<string>(nullable: true),
                    RearVisibilitySystem = table.Column<string>(nullable: true),
                    SAEAutomationLevel = table.Column<string>(nullable: true),
                    SAEAutomationLevel_to = table.Column<string>(nullable: true),
                    SeatBeltsAll = table.Column<string>(nullable: true),
                    SeatRows = table.Column<string>(nullable: true),
                    Seats = table.Column<string>(nullable: true),
                    SemiautomaticHeadlampBeamSwitching = table.Column<string>(nullable: true),
                    Series = table.Column<string>(nullable: true),
                    Series2 = table.Column<string>(nullable: true),
                    SteeringLocation = table.Column<string>(nullable: true),
                    SuggestedVIN = table.Column<string>(nullable: true),
                    TPMS = table.Column<string>(nullable: true),
                    TopSpeedMPH = table.Column<string>(nullable: true),
                    TrackWidth = table.Column<string>(nullable: true),
                    TractionControl = table.Column<string>(nullable: true),
                    TrailerBodyType = table.Column<string>(nullable: true),
                    TrailerLength = table.Column<string>(nullable: true),
                    TrailerType = table.Column<string>(nullable: true),
                    TransmissionSpeeds = table.Column<string>(nullable: true),
                    TransmissionStyle = table.Column<string>(nullable: true),
                    Trim = table.Column<string>(nullable: true),
                    Trim2 = table.Column<string>(nullable: true),
                    Turbo = table.Column<string>(nullable: true),
                    VIN = table.Column<string>(nullable: true),
                    ValveTrainDesign = table.Column<string>(nullable: true),
                    VehicleType = table.Column<string>(nullable: true),
                    WheelBaseLong = table.Column<string>(nullable: true),
                    WheelBaseShort = table.Column<string>(nullable: true),
                    WheelBaseType = table.Column<string>(nullable: true),
                    WheelSizeFront = table.Column<string>(nullable: true),
                    WheelSizeRear = table.Column<string>(nullable: true),
                    Wheels = table.Column<string>(nullable: true),
                    Windows = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Vehicle", x => x.VehicleId);
                });

            migrationBuilder.CreateTable(
                name: "WishList",
                columns: table => new
                {
                    WishListId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    VehicleId = table.Column<int>(nullable: false),
                    WishListTitle = table.Column<string>(nullable: false),
                    WishListDescription = table.Column<string>(nullable: false),
                    IsComplete = table.Column<bool>(nullable: false),
                    DateCreated = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_WishList", x => x.WishListId);
                });

            migrationBuilder.CreateTable(
                name: "AspNetRoleClaims",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    RoleId = table.Column<string>(nullable: false),
                    ClaimType = table.Column<string>(nullable: true),
                    ClaimValue = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoleClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetRoleClaims_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserClaims",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    UserId = table.Column<string>(nullable: false),
                    ClaimType = table.Column<string>(nullable: true),
                    ClaimValue = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetUserClaims_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserLogins",
                columns: table => new
                {
                    LoginProvider = table.Column<string>(maxLength: 128, nullable: false),
                    ProviderKey = table.Column<string>(maxLength: 128, nullable: false),
                    ProviderDisplayName = table.Column<string>(nullable: true),
                    UserId = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserLogins", x => new { x.LoginProvider, x.ProviderKey });
                    table.ForeignKey(
                        name: "FK_AspNetUserLogins_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserRoles",
                columns: table => new
                {
                    UserId = table.Column<string>(nullable: false),
                    RoleId = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserRoles", x => new { x.UserId, x.RoleId });
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserTokens",
                columns: table => new
                {
                    UserId = table.Column<string>(nullable: false),
                    LoginProvider = table.Column<string>(maxLength: 128, nullable: false),
                    Name = table.Column<string>(maxLength: 128, nullable: false),
                    Value = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserTokens", x => new { x.UserId, x.LoginProvider, x.Name });
                    table.ForeignKey(
                        name: "FK_AspNetUserTokens_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_AspNetRoleClaims_RoleId",
                table: "AspNetRoleClaims",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "RoleNameIndex",
                table: "AspNetRoles",
                column: "NormalizedName",
                unique: true,
                filter: "[NormalizedName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserClaims_UserId",
                table: "AspNetUserClaims",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserLogins_UserId",
                table: "AspNetUserLogins",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserRoles_RoleId",
                table: "AspNetUserRoles",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "EmailIndex",
                table: "AspNetUsers",
                column: "NormalizedEmail");

            migrationBuilder.CreateIndex(
                name: "UserNameIndex",
                table: "AspNetUsers",
                column: "NormalizedUserName",
                unique: true,
                filter: "[NormalizedUserName] IS NOT NULL");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AspNetRoleClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserLogins");

            migrationBuilder.DropTable(
                name: "AspNetUserRoles");

            migrationBuilder.DropTable(
                name: "AspNetUserTokens");

            migrationBuilder.DropTable(
                name: "MaintenanceTask");

            migrationBuilder.DropTable(
                name: "Message");

            migrationBuilder.DropTable(
                name: "Vehicle");

            migrationBuilder.DropTable(
                name: "WishList");

            migrationBuilder.DropTable(
                name: "AspNetRoles");

            migrationBuilder.DropTable(
                name: "AspNetUsers");
        }
    }
}
