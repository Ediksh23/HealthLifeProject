using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace HealthLifeProject.Migrations
{
    /// <inheritdoc />
    public partial class Initial : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Category",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NameCategory = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Desc = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Category", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Cities",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NameCity = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Desc = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cities", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Diagnoses",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NameDiagnosis = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Desc = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Diagnoses", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Entrances",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NumbEntrance = table.Column<int>(type: "int", nullable: false),
                    Desc = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Entrances", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "FundraisingStatuses",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NameFundraisingStatus = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Desc = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FundraisingStatuses", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Gender",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NameGender = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Desc = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Gender", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Houses",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NumbHouse = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Desc = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Houses", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Names",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Desc = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Names", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "NavagateLink",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Href = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Order = table.Column<int>(type: "int", nullable: false),
                    ParentId = table.Column<int>(type: "int", nullable: true),
                    NavagateLinkId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_NavagateLink", x => x.Id);
                    table.ForeignKey(
                        name: "FK_NavagateLink_NavagateLink_NavagateLinkId",
                        column: x => x.NavagateLinkId,
                        principalTable: "NavagateLink",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Option",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Key = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Value = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Relation = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Order = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Option", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Partners",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NamePartners = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Linc = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Notate = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Partners", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Patronymics",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Patronymic = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Desc = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Patronymics", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Positions",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NamePositions = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Desc = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Positions", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Roles",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NameRole = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Desc = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Roles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "StreetTypes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NameStreetTypes = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Desc = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_StreetTypes", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Surnames",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Surname = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Desc = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Surnames", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "TreatmentCategory",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NameTreatmentCategory = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Desc = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TreatmentCategory", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Benefactors",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SurnameID = table.Column<int>(type: "int", nullable: false),
                    NameID = table.Column<int>(type: "int", nullable: false),
                    ContactPhone = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Login = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Password = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    RegisterDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    BirthDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    RoleID = table.Column<int>(type: "int", nullable: false),
                    Notate = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Benefactors", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Benefactors_Roles_RoleID",
                        column: x => x.RoleID,
                        principalTable: "Roles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Streets",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NameStreet = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    StreetTypesId = table.Column<int>(type: "int", nullable: false),
                    Desc = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Streets", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Streets_StreetTypes_StreetTypesId",
                        column: x => x.StreetTypesId,
                        principalTable: "StreetTypes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "PartnersRepresentatives",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SurnameID = table.Column<int>(type: "int", nullable: false),
                    NameID = table.Column<int>(type: "int", nullable: false),
                    PatronymicID = table.Column<int>(type: "int", nullable: false),
                    ContactPhone = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    BirthDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    PartnerID = table.Column<int>(type: "int", nullable: false),
                    Login = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Password = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    RegisterDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    RoleID = table.Column<int>(type: "int", nullable: false),
                    Notate = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    GenderId = table.Column<int>(type: "int", nullable: true),
                    CityId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PartnersRepresentatives", x => x.Id);
                    table.ForeignKey(
                        name: "FK_PartnersRepresentatives_Cities_CityId",
                        column: x => x.CityId,
                        principalTable: "Cities",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_PartnersRepresentatives_Gender_GenderId",
                        column: x => x.GenderId,
                        principalTable: "Gender",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_PartnersRepresentatives_Names_NameID",
                        column: x => x.NameID,
                        principalTable: "Names",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_PartnersRepresentatives_Partners_PartnerID",
                        column: x => x.PartnerID,
                        principalTable: "Partners",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_PartnersRepresentatives_Patronymics_PatronymicID",
                        column: x => x.PatronymicID,
                        principalTable: "Patronymics",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_PartnersRepresentatives_Roles_RoleID",
                        column: x => x.RoleID,
                        principalTable: "Roles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_PartnersRepresentatives_Surnames_SurnameID",
                        column: x => x.SurnameID,
                        principalTable: "Surnames",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Hospitals",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NameHospital = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CityID = table.Column<int>(type: "int", nullable: false),
                    StreetID = table.Column<int>(type: "int", nullable: false),
                    EntranceID = table.Column<int>(type: "int", nullable: false),
                    HouseID = table.Column<int>(type: "int", nullable: false),
                    Linc = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DonationAmount = table.Column<int>(type: "int", nullable: false),
                    Desc = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Hospitals", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Hospitals_Cities_CityID",
                        column: x => x.CityID,
                        principalTable: "Cities",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Hospitals_Entrances_EntranceID",
                        column: x => x.EntranceID,
                        principalTable: "Entrances",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Hospitals_Houses_HouseID",
                        column: x => x.HouseID,
                        principalTable: "Houses",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Hospitals_Streets_StreetID",
                        column: x => x.StreetID,
                        principalTable: "Streets",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "HospitalsPhotos",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    WayToPhoto = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Desc = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    HospitalID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HospitalsPhotos", x => x.Id);
                    table.ForeignKey(
                        name: "FK_HospitalsPhotos_Hospitals_HospitalID",
                        column: x => x.HospitalID,
                        principalTable: "Hospitals",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Wards",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NameWard = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    HospitalID = table.Column<int>(type: "int", nullable: false),
                    CityID = table.Column<int>(type: "int", nullable: false),
                    StreetID = table.Column<int>(type: "int", nullable: false),
                    EntranceID = table.Column<int>(type: "int", nullable: false),
                    HouseID = table.Column<int>(type: "int", nullable: false),
                    Linc = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DonationAmount = table.Column<int>(type: "int", nullable: false),
                    Desc = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Wards", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Wards_Cities_CityID",
                        column: x => x.CityID,
                        principalTable: "Cities",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Wards_Entrances_EntranceID",
                        column: x => x.EntranceID,
                        principalTable: "Entrances",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Wards_Hospitals_HospitalID",
                        column: x => x.HospitalID,
                        principalTable: "Hospitals",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Wards_Houses_HouseID",
                        column: x => x.HouseID,
                        principalTable: "Houses",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Wards_Streets_StreetID",
                        column: x => x.StreetID,
                        principalTable: "Streets",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "HospitalsCharitableContributions",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    BenefactorID = table.Column<int>(type: "int", nullable: false),
                    HospitalID = table.Column<int>(type: "int", nullable: false),
                    WardID = table.Column<int>(type: "int", nullable: false),
                    Card_number_of_benefactor = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Bank_account_of_benefactor = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Amount = table.Column<int>(type: "int", nullable: false),
                    Notate = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HospitalsCharitableContributions", x => x.Id);
                    table.ForeignKey(
                        name: "FK_HospitalsCharitableContributions_Benefactors_BenefactorID",
                        column: x => x.BenefactorID,
                        principalTable: "Benefactors",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_HospitalsCharitableContributions_Hospitals_HospitalID",
                        column: x => x.HospitalID,
                        principalTable: "Hospitals",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_HospitalsCharitableContributions_Wards_WardID",
                        column: x => x.WardID,
                        principalTable: "Wards",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "HospitalsRepresentatives",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SurnameID = table.Column<int>(type: "int", nullable: false),
                    NameID = table.Column<int>(type: "int", nullable: false),
                    PatronymicID = table.Column<int>(type: "int", nullable: false),
                    ContactPhone = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    BirthDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    GenderID = table.Column<int>(type: "int", nullable: false),
                    CityID = table.Column<int>(type: "int", nullable: false),
                    HospitalID = table.Column<int>(type: "int", nullable: false),
                    WardID = table.Column<int>(type: "int", nullable: true),
                    PositionID = table.Column<int>(type: "int", nullable: false),
                    Login = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Password = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    RegisterDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    RoleID = table.Column<int>(type: "int", nullable: false),
                    Notate = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HospitalsRepresentatives", x => x.Id);
                    table.ForeignKey(
                        name: "FK_HospitalsRepresentatives_Cities_CityID",
                        column: x => x.CityID,
                        principalTable: "Cities",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_HospitalsRepresentatives_Gender_GenderID",
                        column: x => x.GenderID,
                        principalTable: "Gender",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_HospitalsRepresentatives_Hospitals_HospitalID",
                        column: x => x.HospitalID,
                        principalTable: "Hospitals",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_HospitalsRepresentatives_Names_NameID",
                        column: x => x.NameID,
                        principalTable: "Names",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_HospitalsRepresentatives_Patronymics_PatronymicID",
                        column: x => x.PatronymicID,
                        principalTable: "Patronymics",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_HospitalsRepresentatives_Positions_PositionID",
                        column: x => x.PositionID,
                        principalTable: "Positions",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_HospitalsRepresentatives_Roles_RoleID",
                        column: x => x.RoleID,
                        principalTable: "Roles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_HospitalsRepresentatives_Surnames_SurnameID",
                        column: x => x.SurnameID,
                        principalTable: "Surnames",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_HospitalsRepresentatives_Wards_WardID",
                        column: x => x.WardID,
                        principalTable: "Wards",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Patients",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SurnameID = table.Column<int>(type: "int", nullable: false),
                    NameID = table.Column<int>(type: "int", nullable: false),
                    PatronymicID = table.Column<int>(type: "int", nullable: false),
                    BirthDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    GenderID = table.Column<int>(type: "int", nullable: false),
                    CityID = table.Column<int>(type: "int", nullable: false),
                    HospitalID = table.Column<int>(type: "int", nullable: false),
                    WardID = table.Column<int>(type: "int", nullable: true),
                    DiagnosisID = table.Column<int>(type: "int", nullable: false),
                    CategoryID = table.Column<int>(type: "int", nullable: false),
                    TreatmentCategoryID = table.Column<int>(type: "int", nullable: false),
                    FeeAmount = table.Column<int>(type: "int", nullable: false),
                    DonationAmount = table.Column<int>(type: "int", nullable: false),
                    Bank_account = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Bank_card_number = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FundraisingStatusID = table.Column<int>(type: "int", nullable: false),
                    Inn = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Descript_patient_and_disease = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Notate = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DiagnosesId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Patients", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Patients_Category_CategoryID",
                        column: x => x.CategoryID,
                        principalTable: "Category",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Patients_Cities_CityID",
                        column: x => x.CityID,
                        principalTable: "Cities",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Patients_Diagnoses_DiagnosesId",
                        column: x => x.DiagnosesId,
                        principalTable: "Diagnoses",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Patients_FundraisingStatuses_FundraisingStatusID",
                        column: x => x.FundraisingStatusID,
                        principalTable: "FundraisingStatuses",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Patients_Gender_GenderID",
                        column: x => x.GenderID,
                        principalTable: "Gender",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Patients_Hospitals_HospitalID",
                        column: x => x.HospitalID,
                        principalTable: "Hospitals",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Patients_Names_NameID",
                        column: x => x.NameID,
                        principalTable: "Names",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Patients_Patronymics_PatronymicID",
                        column: x => x.PatronymicID,
                        principalTable: "Patronymics",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Patients_Surnames_SurnameID",
                        column: x => x.SurnameID,
                        principalTable: "Surnames",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Patients_TreatmentCategory_TreatmentCategoryID",
                        column: x => x.TreatmentCategoryID,
                        principalTable: "TreatmentCategory",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Patients_Wards_WardID",
                        column: x => x.WardID,
                        principalTable: "Wards",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "WardsPhotos",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    WayToPhoto = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Desc = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    WardID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_WardsPhotos", x => x.Id);
                    table.ForeignKey(
                        name: "FK_WardsPhotos_Wards_WardID",
                        column: x => x.WardID,
                        principalTable: "Wards",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ContactPhones",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Number = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Desc = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    HospitalsRepresentativeID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ContactPhones", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ContactPhones_HospitalsRepresentatives_HospitalsRepresentativeID",
                        column: x => x.HospitalsRepresentativeID,
                        principalTable: "HospitalsRepresentatives",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "PatientPhotos",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    WayToPhoto = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Desc = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PatientID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PatientPhotos", x => x.Id);
                    table.ForeignKey(
                        name: "FK_PatientPhotos_Patients_PatientID",
                        column: x => x.PatientID,
                        principalTable: "Patients",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "PatientsCharitableContributions",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    BenefactorID = table.Column<int>(type: "int", nullable: false),
                    PatientID = table.Column<int>(type: "int", nullable: false),
                    Card_number_of_benefactor = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Amount = table.Column<int>(type: "int", nullable: false),
                    Notate = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PatientsCharitableContributions", x => x.Id);
                    table.ForeignKey(
                        name: "FK_PatientsCharitableContributions_Benefactors_BenefactorID",
                        column: x => x.BenefactorID,
                        principalTable: "Benefactors",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_PatientsCharitableContributions_Patients_PatientID",
                        column: x => x.PatientID,
                        principalTable: "Patients",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Category",
                columns: new[] { "Id", "Desc", "NameCategory" },
                values: new object[,]
                {
                    { 1, "", "Дорослі" },
                    { 2, "", "Діти" },
                    { 3, "", "Військові" }
                });

            migrationBuilder.InsertData(
                table: "Cities",
                columns: new[] { "Id", "Desc", "NameCity" },
                values: new object[,]
                {
                    { 1, "", "Київ" },
                    { 2, "", "Дніпро" },
                    { 3, "", "Полтава" },
                    { 4, "", "Харків" },
                    { 5, "", "Львів" }
                });

            migrationBuilder.InsertData(
                table: "Diagnoses",
                columns: new[] { "Id", "Desc", "NameDiagnosis" },
                values: new object[,]
                {
                    { 1, "", "Проникаюче поранення суглоба" },
                    { 2, "", "Вибухове поранення множинне лівої нижньої кінціки" },
                    { 3, "", "Проникаюче поранення живота" },
                    { 4, "", "Аномалія Ебштейна" },
                    { 5, "", "Тетрада Фалло" },
                    { 6, "", "Кардіоміопатія" },
                    { 7, "", "Проникаюче поранення грудної порожнини" },
                    { 8, "", "Хронічна серцева недостатность" },
                    { 9, "", "Мієлодиспластичний синдром" },
                    { 10, "", "Апластична анемія" },
                    { 11, "", "Хронічна ниркова  недостатність (ХНН V)" },
                    { 12, "", "Пухлина головного мозку" },
                    { 13, "", "Пухлина головного мозку" },
                    { 14, "", "Гідроцефалія набута" }
                });

            migrationBuilder.InsertData(
                table: "Entrances",
                columns: new[] { "Id", "Desc", "NumbEntrance" },
                values: new object[,]
                {
                    { 1, "", 1 },
                    { 2, "", 2 },
                    { 3, "", 3 },
                    { 4, "", 4 }
                });

            migrationBuilder.InsertData(
                table: "FundraisingStatuses",
                columns: new[] { "Id", "Desc", "NameFundraisingStatus" },
                values: new object[,]
                {
                    { 1, "Відкритий, мета збору не досягнуа, час збору не завершився", "Актуально" },
                    { 2, "Призупинений через певні об'єктивні причини", "Призупинено" },
                    { 3, "Завершено недосягнувши Мети", "Завершено" },
                    { 4, "Мета досягнуа, збір закрито", "Закрито" }
                });

            migrationBuilder.InsertData(
                table: "Gender",
                columns: new[] { "Id", "Desc", "NameGender" },
                values: new object[,]
                {
                    { 1, "", "Чоловік" },
                    { 2, "", "Жінка" }
                });

            migrationBuilder.InsertData(
                table: "Houses",
                columns: new[] { "Id", "Desc", "NumbHouse" },
                values: new object[,]
                {
                    { 1, "", "28/1" },
                    { 2, "", "266" },
                    { 3, "", "14" },
                    { 4, "", "10" },
                    { 5, "", "6" },
                    { 6, "", "9" }
                });

            migrationBuilder.InsertData(
                table: "Names",
                columns: new[] { "Id", "Desc", "Name" },
                values: new object[,]
                {
                    { 1, "", "Андрій" },
                    { 2, "", "Анна" },
                    { 3, "", "Артем" },
                    { 4, "", "Вікторія" },
                    { 5, "", "Богдан" },
                    { 6, "", "Єва" },
                    { 7, "", "Давид" },
                    { 8, "", "Злата" },
                    { 9, "", "Данило" },
                    { 10, "", "Катерина" },
                    { 11, "", "Дмитро" },
                    { 12, "", "Мирослава" },
                    { 13, "", "Максим" },
                    { 14, "", "Марія" },
                    { 15, "", "Матвій" },
                    { 16, "", "Мілана" },
                    { 17, "", "Марк" },
                    { 18, "", "Софія" },
                    { 19, "", "Микола" },
                    { 20, "", "Соломія" },
                    { 21, "", "Олександр" },
                    { 22, "", "Джульєта" },
                    { 23, "", "Відар" },
                    { 24, "", "Юстінія" },
                    { 25, "", "Ілай" },
                    { 26, "", "Жива" }
                });

            migrationBuilder.InsertData(
                table: "NavagateLink",
                columns: new[] { "Id", "Href", "NavagateLinkId", "Order", "ParentId", "Title" },
                values: new object[,]
                {
                    { 1, "/", null, 1, null, "Головна" },
                    { 2, "/about/index", null, 1, null, "Про нас" },
                    { 3, "/about/index", null, 1, null, "Пацієнти" },
                    { 4, "/about/index", null, 2, 3, "Категорії" },
                    { 5, "/about/index", null, 2, 3, "Напрямок лікування" },
                    { 6, "/about/index", null, 2, 3, "Стать" },
                    { 7, "/about/index", null, 2, 3, "Міста" },
                    { 8, "/about/index", null, 2, 3, "Медичні установи" },
                    { 9, "/about/index", null, 2, 3, "Відділення" },
                    { 10, "/about/index", null, 3, 9, "Діагнози" },
                    { 11, "/about/index", null, 1, null, "Медичні установи" }
                });

            migrationBuilder.InsertData(
                table: "Partners",
                columns: new[] { "Id", "Linc", "NamePartners", "Notate" },
                values: new object[,]
                {
                    { 1, "https://tabletochki.org/?utm_source=google.g&utm_medium=cpc&utm_campaign=18598589187&utm_term=tabletochki&utm_content=628336089002&gad_source=1&gclid=CjwKCAjw_ZC2BhAQEiwAXSgClq_iiioQDMNQ8LrMTTn4MRMp1Cw8BC4HbtP8KWXMON5MttAnlqWVFRoCoygQAvD_BwE", "Tabletochki", "Лікування раку складне і тривале. Та навіть під час війни «Таблеточки» залишаються поруч із сім’ями, які зіткнулись з дитячим раком, на кожному етапі. Обстеження, придбання ліків в Україні та за кордоном, психологічна та паліативна підтримка, соціальна реабілітація, проживання біля лікарні — по цю та іншу адресну допомогу можна звернутися до фонду." },
                    { 2, "https://zerocancer.org/", "ZERO Prostate Cancer", "Ми разом подолаємо рак простати\r\nОтримайте доступ до життєво необхідної інформації та підтримки, зв’яжіться з іншими в спільноті хворих на рак передміхурової залози та вживайте заходів, щоб ZERO від раку простати." },
                    { 3, "https://www.unicef.org/ukraine/", "UNICEF", "ЮНІСЕФ працює у 190 країнах і територіях для охоплення найуразливіших дітей та молоді, які найбільше потребують допомоги. Організація працюємо над тим, щоб зберегти їхні життя. Захистити їхні права. Уберегти їх від шкоди. Дати їм дитинство, в якому вони будуть захищеними, здоровими та освіченими. Дати їм рівні можливості реалізувати свій потенціал, щоб одного дня вони могли зробити світ кращим." },
                    { 4, "https://ucf.in.ua/", "Український культурний фонд", "Український культурний фонд – державна установа, створена у 2017 році, на підставі відповідного Закону України, з метою сприяння розвитку національної культури та мистецтва в державі, забезпечення сприятливих умов для розвитку інтелектуального та духовного потенціалу особистості і суспільства, широкого доступу громадян до національного культурного надбання, підтримки культурного розмаїття та інтеграції української культури у світовий культурний простір. Підтримка проектів Українським культурним фондом здійснюється на конкурсних засадах." },
                    { 5, "https://ridni.org.ua/?gad_source=1&gclid=CjwKCAjw_ZC2BhAQEiwAXSgCls6FKpoSHuN_lOSC02vxHQ1X2xiij4U47olk0g9AqA44zJKgV5hViRoCS6QQAvD_BwE", "Ridni", "Подолання сирітства та розвиток інституту сім’ї.\r\n\r\nПрацюють заради того, щоб кожна дитина зростала у люблячій сім 'ї з духовними цінностями та мала щасливе майбутнє. Для цього організація надає дітям та дорослим психологічну, соціальну, освітню підтримку. Забезпечує консультаційний супровід усиновлювачів, батьків-вихователів дитячих будинків сімейного типу та прийомних сімей." }
                });

            migrationBuilder.InsertData(
                table: "Patronymics",
                columns: new[] { "Id", "Desc", "Patronymic" },
                values: new object[,]
                {
                    { 1, "", "Миколайович" },
                    { 2, "", "Миколаївна" },
                    { 3, "", "Володимирович" },
                    { 4, "", "Володимирівна" },
                    { 5, "", "Олександрович" },
                    { 6, "", "Олександрівна" },
                    { 7, "", "Іванович" },
                    { 8, "", "Іванівна" },
                    { 9, "", "Васильович" },
                    { 10, "", "Василівна" },
                    { 11, "", "Сергійович" },
                    { 12, "", "Сергіївна" },
                    { 13, "", "Вікторович" },
                    { 14, "", "Вікторівна" },
                    { 15, "", "Михайлович" },
                    { 16, "", "Михайлівна" }
                });

            migrationBuilder.InsertData(
                table: "Positions",
                columns: new[] { "Id", "Desc", "NamePositions" },
                values: new object[,]
                {
                    { 1, "", "Лікар" },
                    { 2, "", "Лікар-лаборант" },
                    { 3, "", "Лікар-інтерн" },
                    { 4, "", "Лікар-методист" },
                    { 5, "", "Лікар-стажист" },
                    { 6, "", "Лаборант" },
                    { 7, "", "Сестра медична" },
                    { 8, "", "Фельдшер" },
                    { 9, "", "Реєстратор медичний" },
                    { 10, "", "Молодша медична сестра" },
                    { 11, "", "Старша медична сестра" }
                });

            migrationBuilder.InsertData(
                table: "Roles",
                columns: new[] { "Id", "Desc", "NameRole" },
                values: new object[,]
                {
                    { 1, "Адміністратор з повними правами дотупа", "admin" },
                    { 2, "Предтавник медичного закладу, має доступ на створення нової картки пацієнта та перегляду всіх зборів його мадичного закладу", "hospitalsRepresent" },
                    { 3, "Предтавни партнера, має дотуп на перегляд всіх зборів, та окремо зборів, яким було надано допомогу даним партнером", "partner" },
                    { 4, "БлагодійникЮ, що зареєструвався на платформі. Має дотуп на перегляд всіх актуальних зборів, та окремо зборів, яким було надано допомогу даним благодійником(в тому числі  закритих)", "benefactorRegistered" },
                    { 5, "БлагодійникЮ, що не зареєструваний на платформі. Має дотуп на перегляд всіх актуальних зборів", "benefactorGuest" }
                });

            migrationBuilder.InsertData(
                table: "StreetTypes",
                columns: new[] { "Id", "Desc", "NameStreetTypes" },
                values: new object[,]
                {
                    { 1, "", "вулиця" },
                    { 2, "", "провулок" },
                    { 3, "", "площа" },
                    { 4, "", "шое" },
                    { 5, "", "" }
                });

            migrationBuilder.InsertData(
                table: "Surnames",
                columns: new[] { "Id", "Desc", "Surname" },
                values: new object[,]
                {
                    { 1, "", "Мельник" },
                    { 2, "", "Шевченко" },
                    { 3, "", "Коваленко" },
                    { 4, "", "Бондаренко" },
                    { 5, "", "Бойко" },
                    { 6, "", "Ткаченко" },
                    { 7, "", "Кравченко" },
                    { 8, "", "Ковальчук" },
                    { 9, "", "Коваль" },
                    { 10, "", "Олійник" },
                    { 11, "", "Акименко" },
                    { 12, "", "Бабченко" },
                    { 13, "", "Багрій" },
                    { 14, "", "Багрій" },
                    { 15, "", "Максимейко" },
                    { 16, "", "Сало" },
                    { 17, "", "Грінка" },
                    { 18, "", "Стопка" }
                });

            migrationBuilder.InsertData(
                table: "TreatmentCategory",
                columns: new[] { "Id", "Desc", "NameTreatmentCategory" },
                values: new object[,]
                {
                    { 1, "", "Лікування" },
                    { 2, "", "Реабілітація" },
                    { 3, "", "Протезування" },
                    { 4, "", "Підтимка життедіяльності" }
                });

            migrationBuilder.InsertData(
                table: "Benefactors",
                columns: new[] { "Id", "BirthDate", "ContactPhone", "Email", "Login", "NameID", "Notate", "Password", "RegisterDate", "RoleID", "SurnameID" },
                values: new object[,]
                {
                    { 1, new DateTime(1998, 3, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), "0958675421", "Benefactor1@gmail.com", "Benefactor1", 7, null, "Benefactor1", new DateTime(2024, 8, 21, 0, 35, 36, 998, DateTimeKind.Local).AddTicks(6037), 4, 15 },
                    { 2, new DateTime(1993, 8, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "0558675469", "Benefactor2@gmail.com", "Benefactor2", 12, null, "Benefactor2", new DateTime(2024, 8, 21, 0, 35, 36, 998, DateTimeKind.Local).AddTicks(6056), 4, 1 },
                    { 3, new DateTime(1989, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "0667845123", "Benefactor3@gmail.com", "Benefactor3", 14, null, "Benefactor3", new DateTime(2024, 8, 21, 0, 35, 36, 998, DateTimeKind.Local).AddTicks(6061), 4, 6 },
                    { 4, new DateTime(2002, 4, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), "0963584756", "Benefactor4@gmail.com", "Benefactor4", 12, null, "Benefactor4", new DateTime(2024, 8, 21, 0, 35, 36, 998, DateTimeKind.Local).AddTicks(6065), 4, 11 }
                });

            migrationBuilder.InsertData(
                table: "PartnersRepresentatives",
                columns: new[] { "Id", "BirthDate", "CityId", "ContactPhone", "Email", "GenderId", "Login", "NameID", "Notate", "PartnerID", "Password", "PatronymicID", "RegisterDate", "RoleID", "SurnameID" },
                values: new object[,]
                {
                    { 1, new DateTime(1997, 6, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "0668912435", "Partner1@gmail.com", null, "Partner1", 3, null, 1, "Partner1", 7, new DateTime(2024, 8, 21, 0, 35, 36, 998, DateTimeKind.Local).AddTicks(6176), 3, 6 },
                    { 2, new DateTime(2001, 7, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "0672536149", "Partner2@gmail.com", null, "Partner2", 8, null, 2, "Partner2", 10, new DateTime(2024, 8, 21, 0, 35, 36, 998, DateTimeKind.Local).AddTicks(6189), 3, 12 },
                    { 3, new DateTime(1996, 3, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "0964528753", "Partner3@gmail.com", null, "Partner3", 4, null, 3, "Partner3", 12, new DateTime(2024, 8, 21, 0, 35, 36, 998, DateTimeKind.Local).AddTicks(6193), 3, 11 },
                    { 4, new DateTime(2002, 4, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "0995873654", "Partner4@gmail.com", null, "Partner4", 6, null, 4, "Partner4", 8, new DateTime(2024, 8, 21, 0, 35, 36, 998, DateTimeKind.Local).AddTicks(6198), 3, 5 },
                    { 5, new DateTime(2001, 1, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "0975249875", "Partner5@gmail.com", null, "Partner5", 4, null, 5, "Partner5", 8, new DateTime(2024, 8, 21, 0, 35, 36, 998, DateTimeKind.Local).AddTicks(6203), 3, 1 }
                });

            migrationBuilder.InsertData(
                table: "Streets",
                columns: new[] { "Id", "Desc", "NameStreet", "StreetTypesId" },
                values: new object[,]
                {
                    { 1, "", "Чорновола", 1 },
                    { 2, "", "Салтівське", 4 },
                    { 3, "", "Соборна", 3 },
                    { 4, "", "Шевченка", 1 },
                    { 5, "", "Амосова", 1 },
                    { 6, "", "Миколайчука", 1 }
                });

            migrationBuilder.InsertData(
                table: "Hospitals",
                columns: new[] { "Id", "CityID", "Desc", "DonationAmount", "EntranceID", "HouseID", "Linc", "NameHospital", "StreetID" },
                values: new object[,]
                {
                    { 1, 1, "НДСЛ «Охматдит» – багатопрофільний діагностично-лікувальний заклад, який надає спеціалізовану висококваліфіковану медичну допомогу дитячому населенню України. Найбільша дитяча лікарня в Україні. На сьогодні НДСЛ «Охматдит» МОЗ України – сучасна лікувально-діагностична установа, де виконуються реконструктивно-пластичні операції, пересадка кісткового мозку (в т.ч. від неродинного донора), хірургічна корекція складних вроджених вад розвитку у новонароджених дітей, виходжування за сучасними технологіями глибоко недоношених дітей, онконейрохірургія, діагностика та лікування ретинопатії новонароджених, функціонує потужний медико-генетичний центр для діагностики та лікування рідкісних спадкових та генетичних захворювань у дітей тощо.", 0, 1, 1, "https://ohmatdyt.com.ua/", "НДСЛ «Охматдит»", 1 },
                    { 2, 4, "На сьогоднішній день Харківська обласна клінічна травматологічна лікарня - це провідний центр по роботі з ОДС. Ретельно підібраний персонал проводить діагностику, лікування та реабілітацію пацієнтів з найрізноманітнішими клінічними картинами. Головним правилом клініки травматології та ортопедії є дотримання комплексу декомпрессіонних вправ на спеціалізованих тренажерах. Під кожен випадок нами розробляється індивідуальна програма.", 0, 2, 2, "https://oktl.kh.ua/", "КНП Харківської обласної ради «Обласна клінічна травматологічна лікарня»", 2 },
                    { 3, 2, "Дніпропетровська обласна клінічна лікарня імені І. І. Мечникова[2]  — одна з найстаріших багатопрофільних лікувальних медичних установ України, обласний центр спеціалізованої хірургічної допомоги.", 0, 1, 3, "https://oktl.kh.ua/", "БО ДОБФ «Лікарня ім. І.І. МЕЧНИКОВА»", 3 },
                    { 4, 3, "Обласна клінічна лікарня відновного лікування та діагностики, яка заснована 11 лютого 1947 року, сьогодні є одним з найсучасніших  лікувально-профілактичних закладів області.", 0, 1, 4, "http://www.oklvld.pl.ua/", "Обласна клінічна лікарня відновного лікування та діагностики", 4 },
                    { 5, 1, "Історія Інституту починається з 1955 року, коли на базі 24-ї міської лікарні м. Києва М. М. Амосовим була відкрита перша в Україні спеціалізована клініка серцевої хірургії, яка в 1957 р. перейшла до Українського НДІ туберкульозу, в 1961 р. перейменованого в Київський НДІ туберкульозу і грудної хірургії. В 1983 р. ця клініка серцевої хірургії реорганізована в Київський НДІ серцево-судинної хірургії Міністерства охорони здоров’я України, з 1993 р. – Інститут серцево-судинної хірургії (ІССХ) АМН України.", 0, 1, 5, "https://amosovinstitute.org.ua/", "Інститут серцево-судинної хірургії (ІССХ) АМН України", 5 },
                    { 6, 5, "Центр трансплантології Першого медоб'єднання Львова — лідер за кількістю пересаджених органів в Україні. Функціонує з 2020 року. Відтоді тут виконано понад 250 трансплантацій нирок, печінки, серця, легень та підшлункової залози. \r\nУсі медичні послуги з трансплантації оплачуються державним коштом. Тому для пацієнта трансплантація БЕЗКОШТОВНА.", 0, 1, 6, "https://emergency-hospital.lviv.ua/tsentry/tsentr-transplantolohii", "Центр трансплантології Першого медоб'єднання Львова", 6 }
                });

            migrationBuilder.InsertData(
                table: "HospitalsRepresentatives",
                columns: new[] { "Id", "BirthDate", "CityID", "ContactPhone", "Email", "GenderID", "HospitalID", "Login", "NameID", "Notate", "Password", "PatronymicID", "PositionID", "RegisterDate", "RoleID", "SurnameID", "WardID" },
                values: new object[,]
                {
                    { 5, new DateTime(1968, 11, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), 4, "0654215854", "Hosp2@gmail.com", 1, 2, "Hosp2", 8, "", "Hosp2", 10, 5, new DateTime(2024, 8, 21, 0, 35, 36, 998, DateTimeKind.Local).AddTicks(5597), 2, 4, null },
                    { 6, new DateTime(1975, 12, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, "0993265789", "Hosp3@gmail.com", 2, 3, "Hosp3", 2, "", "Hosp3", 8, 6, new DateTime(2024, 8, 21, 0, 35, 36, 998, DateTimeKind.Local).AddTicks(5610), 2, 9, null },
                    { 7, new DateTime(1975, 7, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), 3, "", "Hosp4@gmail.com", 2, 4, "Hosp4", 4, "", "Hosp4", 6, 1, new DateTime(2024, 8, 21, 0, 35, 36, 998, DateTimeKind.Local).AddTicks(5621), 2, 5, null },
                    { 11, new DateTime(1989, 3, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), 5, "0501278456", "Hosp6@gmail.com", 2, 6, "Hosp6", 2, "", "Hosp6", 14, 10, new DateTime(2024, 8, 21, 0, 35, 36, 998, DateTimeKind.Local).AddTicks(5655), 2, 12, null }
                });

            migrationBuilder.InsertData(
                table: "Patients",
                columns: new[] { "Id", "Bank_account", "Bank_card_number", "BirthDate", "CategoryID", "CityID", "Descript_patient_and_disease", "DiagnosesId", "DiagnosisID", "DonationAmount", "FeeAmount", "FundraisingStatusID", "GenderID", "HospitalID", "Inn", "NameID", "Notate", "PatronymicID", "SurnameID", "TreatmentCategoryID", "WardID" },
                values: new object[,]
                {
                    { 1, "UA010000001568456978544123", "1568456978544123", new DateTime(1990, 3, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), 3, 5, "", null, 1, 0, 180000, 1, 1, 4, "1568456978", 7, "", 7, 1, 1, null },
                    { 3, "UA010000004563789542631284", "4563789542631284", new DateTime(1991, 6, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), 3, 1, "", null, 2, 0, 600000, 1, 1, 6, "4563789542", 1, "", 9, 7, 3, null },
                    { 7, "UA010000002574128956122345", "2574128956122345", new DateTime(1988, 6, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), 3, 5, "", null, 3, 0, 170000, 1, 1, 3, "2574128956", 9, "", 3, 2, 1, null },
                    { 17, "UA010000006456532123575455", "6456532123575455", new DateTime(1986, 6, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), 3, 2, "", null, 2, 0, 70000, 1, 1, 4, "6456532123", 11, "", 9, 17, 2, null },
                    { 18, "UA010000007645289634567812", "7645289634567812", new DateTime(1988, 8, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), 3, 2, "", null, 3, 0, 150000, 1, 1, 3, "7645289634", 15, "", 7, 12, 2, null },
                    { 19, "UA010000006587128953869784", "6587128953869784", new DateTime(1988, 6, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, 5, "", null, 15, 0, 700000, 1, 2, 6, "6587128953", 16, "", 8, 14, 1, null },
                    { 20, "UA010000007542152686425378", "7542152686425378", new DateTime(1993, 6, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, 4, "", null, 15, 0, 100000, 1, 1, 6, "7542152686", 15, "", 11, 6, 2, null }
                });

            migrationBuilder.InsertData(
                table: "Wards",
                columns: new[] { "Id", "CityID", "Desc", "DonationAmount", "EntranceID", "HospitalID", "HouseID", "Linc", "NameWard", "StreetID" },
                values: new object[,]
                {
                    { 1, 1, "Історично це було перше відділення кардіо-торакальної хірургії на базі Київського НДІ серцево-судинної хірургії МОЗ України, засноване М.М. Амосовим. З моменту створення і по теперішній час кураторами відділу завжди були директори Інституту, академіки, – спершу М.М. Амосов, потім Г.В. Книшов, на теперішній час – В.В. Лазоришинець.\r\n\r\nЩорічно у відділенні оперують в середньому 600 пацієнтів. Хірургічна активність включає увесь спектр кардіохірургічних втручань: лікування ішемічної хвороби серця (як інтервенційне – експертні стентування стовбурових уражень, стентування при багатосудинному ураженні пацієнтів з високим кардіохірургічним ризиком та пацієнтів з обтяженою коморбідністю, так і хірургічне), критичних клапанних вад серця (набуті та вроджені), життєвозагрозливих порушень ритму серця, патології аорти (як ендоваскулярне, так і хірургічне), захворювання перикарду, плеври, міокарду (ГКМП, ДКМП, амілоїдоз, міокардити), хірургічне лікування аневризм лівого шлуночка та постінфарктні розриви міжшлуночкової перетинки. Більшість кардіохірургічних втручань з реваскуляризації міокарду відбуваються на працюючому серці (off-pump CABG у 96% випадків). У межах відділення виконуються також операції з міні-доступу (шунтування MIDCAB) та тотальна артеріальна реваскуляризація (TAR).", 0, 1, 5, 5, "https://amosovinstitute.org.ua/2023/07/06/viddilennya-ekstrenoyi-ta-nevidkladnoyi-kardiohirurgiyi/", "Відділення воєнної та інноваційної кардіохірургії", 5 },
                    { 2, 1, "ОСНОВНІ НАПРЯМИ РОБОТИ:\r\n\r\nТрансплантація серця та робота над впровадженням в рутинну практику трансплантації комплексу легені-серце та імплантації пристроїв механічної підтримки кровообігу;\r\nОперативне, інтервенційне та терапевтичне лікування всіх варіантів кардіоміопатій та хронічної серцевої недостатності із застосуванням найсучасніших методик інвазивних та консервативних втручань;\r\nУнікальна операція Феррацці при гіпертрофічній кардіоміопатії з високими показниками якості життя у віддаленому періоді. Досягнуто найвищого європейського рівня виконаних операцій Феррацці за рік.\r\nТранскатетерна алкогольна септальна абляція, як альтернатива у пацієнтів з гіпертрофічною кардіоміопатією при наявності протипоказань до відкритих оперативних втручань;\r\nІмплантація ресинхронізаційних штучних водіїв ритму серця при кардіоміопатіях з важкими порушеннями серцевої провідності;\r\nПротезування та пластичні операції для корекція клапанних вад серця, у тому числі у пацієнтів зі зниженою фракцією викиду лівого шлуночка;\r\nЄвропейський підхід до стратегії медикаментозного лікування та хірургії. Більшість лікарів відділення пройшли тривалі стажування у провідних клініках Європи.", 0, 1, 5, 5, "https://amosovinstitute.org.ua/2023/07/03/viddil-hirurgichnogo-likuvannya-sertsevoyi-nedostatnosti-ta-mehanichnoyi-pidtrimki-sertsya-i-legen/", "Відділення хірургічного лікування патології міокарда, трансплантації та механічної підтримки серця і легень", 5 },
                    { 3, 1, "Відділення хірургічного лікування вроджених вад серця у новонароджених та дітей молодшого віку", 0, 1, 5, 5, "Відділення хірургічного лікування вроджених вад серця у новонароджених та дітей молодшого віку", "Відділення хірургічного лікування вроджених вад серця у новонароджених та дітей молодшого віку", 5 },
                    { 4, 1, "Відділення дитячої нейрохірургії створено  у 2018 році з метою покращення надання високоспеціалізованої медичної допомоги дітям з нейрохірургічною патологією. У відділенні надається висококваліфікована медична допомога дітям у віці від 0 до 18 років із різноманітною нейрохірургічною патологією. Відділення є клінічною базою кафедри дитячої хірургії Національного медичного університету ім. О.О. Богомольця.", 0, 1, 1, 1, "https://ohmatdyt.com.ua/viddilennya-nejrohirurgiyi/", "Відділення дитячої нейрохірургії", 1 },
                    { 5, 1, "Відділення інтенсивної терапії хронічних інтоксикацій складається з 25 ліжок з 4 ліжками денного стаціонару. У відділенні знаходяться на лікуванні діти від 0 до 18 років з термінальною стадією ниркової недостатності, які потребують проведення замісної ниркової терапії.", 0, 1, 1, 1, "HospitalID=1, CityID=1, StreetID=1, HouseID=1, EntranceID=1,", "Відділення інтенсивної та еферентної терапії хронічних інтоксикацій зі стаціонаром денного перебування", 1 },
                    { 6, 1, "Вiддiлення відновлювального лікування є одним iз пiдроздiлiв Національної дитячої спеціалізованої лiкарнi “Охматдит”. Основним завданням його с надання профілактичної, лікувальної та реабілітаційної допомоги дітям, які знаходяться на стаціонарному лікуванні.", 0, 1, 1, 1, "https://ohmatdyt.com.ua/viddilennya-vidnovnogo-likuvannya/", "Відділення відновлювального лікування\r\n", 1 },
                    { 7, 1, "Відділення інтенсивної хіміотерапії надає високоспеціалізовану консультативну та лікувальну медичну допомогу дітям  з різних регіонів України з онкогематологічними та гематологічними захворюваннями  на основі сучасних методів діагностики, комплексного лікування у відповідності до міжнародних стандартів діагностики та лікування дітей з онкогематологічними та гематологічними захворюваннями, затвердженими МОЗ України. У відділенні впроваджуються передові методи лікування гемобластозів, найбільш ефективні терапевтичні протоколи, пілотні програми, комбіновані технології лікування.", 0, 1, 1, 1, "Відділення інтенсивної хіміотерапії", "Відділення інтенсивної хіміотерапії", 1 }
                });

            migrationBuilder.InsertData(
                table: "HospitalsRepresentatives",
                columns: new[] { "Id", "BirthDate", "CityID", "ContactPhone", "Email", "GenderID", "HospitalID", "Login", "NameID", "Notate", "Password", "PatronymicID", "PositionID", "RegisterDate", "RoleID", "SurnameID", "WardID" },
                values: new object[,]
                {
                    { 1, new DateTime(1987, 5, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, "0678943567", "Hosp1ward1@gmail.com", 2, 1, "Hosp1ward1", 14, "", "Hosp1ward1", 8, 3, new DateTime(2024, 8, 21, 0, 35, 36, 998, DateTimeKind.Local).AddTicks(5490), 2, 16, 4 },
                    { 2, new DateTime(1989, 11, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, "0665483157", "Hosp1ward2@gmail.com", 2, 1, "Hosp1ward2", 6, "", "Hosp1ward2", 16, 8, new DateTime(2024, 8, 21, 0, 35, 36, 998, DateTimeKind.Local).AddTicks(5574), 2, 8, 5 },
                    { 3, new DateTime(1974, 3, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, "0667842357", "Hosp1ward3@gmail.com", 1, 1, "Hosp1ward3", 13, "", "Hosp1ward3", 15, 2, new DateTime(2024, 8, 21, 0, 35, 36, 998, DateTimeKind.Local).AddTicks(5584), 2, 11, 6 },
                    { 4, new DateTime(1969, 2, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, "0554236987", "Hosp1ward4@gmail.com", 2, 1, "Hosp1ward4", 12, "", "Hosp1ward4", 14, 7, new DateTime(2024, 8, 21, 0, 35, 36, 998, DateTimeKind.Local).AddTicks(5591), 2, 6, 7 },
                    { 8, new DateTime(1979, 10, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, "0954615795", "Hosp5ward1@gmail.com", 1, 5, "Hosp5ward1", 5, "", "Hosp5ward1", 11, 4, new DateTime(2024, 8, 21, 0, 35, 36, 998, DateTimeKind.Local).AddTicks(5629), 2, 13, 1 },
                    { 9, new DateTime(1985, 8, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, "0553491267", "Hosp5ward2@gmail.com", 2, 5, "Hosp5ward1", 16, "", "Hosp5ward1", 12, 9, new DateTime(2024, 8, 21, 0, 35, 36, 998, DateTimeKind.Local).AddTicks(5636), 2, 10, 2 },
                    { 10, new DateTime(1990, 6, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, "0684815123", "Hosp5ward3@gmail.com", 2, 5, "Hosp5ward3", 18, "", "Hosp5ward3", 10, 11, new DateTime(2024, 8, 21, 0, 35, 36, 998, DateTimeKind.Local).AddTicks(5642), 2, 7, 3 }
                });

            migrationBuilder.InsertData(
                table: "Patients",
                columns: new[] { "Id", "Bank_account", "Bank_card_number", "BirthDate", "CategoryID", "CityID", "Descript_patient_and_disease", "DiagnosesId", "DiagnosisID", "DonationAmount", "FeeAmount", "FundraisingStatusID", "GenderID", "HospitalID", "Inn", "NameID", "Notate", "PatronymicID", "SurnameID", "TreatmentCategoryID", "WardID" },
                values: new object[,]
                {
                    { 2, "UA010000001246796423589124", "1246796423589124", new DateTime(1982, 2, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, 2, "", null, 8, 0, 230000, 1, 2, 5, "1246796423", 10, "", 2, 4, 1, 2 },
                    { 4, "UA010000002596345678412578", "2596345678412578", new DateTime(2023, 6, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, 3, "", null, 5, 0, 250000, 1, 2, 5, "2596345678", 2, "", 8, 11, 2, 3 },
                    { 5, "UA010000005489632452478965", "5489632452478965", new DateTime(2019, 8, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, 1, "", null, 10, 0, 400000, 1, 2, 1, "5489632452", 4, "", 6, 5, 1, 7 },
                    { 6, "UA010000002587963245617896", "2587963245617896", new DateTime(2018, 5, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, 4, "", null, 12, 0, 360000, 1, 2, 1, "2587963245", 8, "", 4, 3, 1, 4 },
                    { 8, "UA010000002893567817393719", "2893567817393719", new DateTime(2018, 8, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), 3, 3, "", null, 14, 0, 90000, 1, 1, 1, "2893567817", 5, "", 11, 13, 2, 6 },
                    { 9, "UA010000007595426215354868", "7595426215354868", new DateTime(2021, 6, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, 1, "", null, 11, 0, 350000, 1, 1, 1, "7595426215", 9, "", 5, 6, 1, 5 },
                    { 10, "UA010000002165784598542345", "2165784598542345", new DateTime(2024, 2, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, 4, "", null, 4, 0, 620000, 1, 2, 5, "2165784598", 6, "", 10, 8, 1, 3 },
                    { 11, "UA010000002596368514857452", "2596368514857452", new DateTime(1990, 6, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), 3, 5, "", null, 7, 0, 420000, 1, 1, 5, "2596368514", 11, "", 15, 9, 1, 1 },
                    { 12, "UA010000003694561275429863", "3694561275429863", new DateTime(2011, 9, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, 1, "", null, 9, 0, 120000, 1, 2, 1, "3694561275", 14, "", 12, 11, 2, 6 },
                    { 13, "UA010000003644552388964543", "3644552388964543", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, 2, "", null, 9, 0, 460000, 1, 2, 1, "3644552388", 12, "", 16, 14, 1, 7 },
                    { 14, "UA010000005645122378896554", "5645122378896554", new DateTime(2017, 3, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, 4, "", null, 13, 0, 600000, 1, 2, 1, "5645122378", 16, "", 14, 12, 1, 4 },
                    { 15, "UA010000002585963674148213", "2585963674148213", new DateTime(1987, 4, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, 1, "", null, 8, 0, 60000, 1, 1, 5, "2585963674", 13, "", 13, 16, 2, 2 },
                    { 16, "UA010000003695784365214896", "3695784365214896", new DateTime(1964, 5, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, 2, "", null, 8, 0, 120000, 1, 1, 5, "3695784365", 19, "", 11, 15, 4, 2 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Benefactors_RoleID",
                table: "Benefactors",
                column: "RoleID");

            migrationBuilder.CreateIndex(
                name: "IX_ContactPhones_HospitalsRepresentativeID",
                table: "ContactPhones",
                column: "HospitalsRepresentativeID");

            migrationBuilder.CreateIndex(
                name: "IX_Hospitals_CityID",
                table: "Hospitals",
                column: "CityID");

            migrationBuilder.CreateIndex(
                name: "IX_Hospitals_EntranceID",
                table: "Hospitals",
                column: "EntranceID");

            migrationBuilder.CreateIndex(
                name: "IX_Hospitals_HouseID",
                table: "Hospitals",
                column: "HouseID");

            migrationBuilder.CreateIndex(
                name: "IX_Hospitals_StreetID",
                table: "Hospitals",
                column: "StreetID");

            migrationBuilder.CreateIndex(
                name: "IX_HospitalsCharitableContributions_BenefactorID",
                table: "HospitalsCharitableContributions",
                column: "BenefactorID");

            migrationBuilder.CreateIndex(
                name: "IX_HospitalsCharitableContributions_HospitalID",
                table: "HospitalsCharitableContributions",
                column: "HospitalID");

            migrationBuilder.CreateIndex(
                name: "IX_HospitalsCharitableContributions_WardID",
                table: "HospitalsCharitableContributions",
                column: "WardID");

            migrationBuilder.CreateIndex(
                name: "IX_HospitalsPhotos_HospitalID",
                table: "HospitalsPhotos",
                column: "HospitalID");

            migrationBuilder.CreateIndex(
                name: "IX_HospitalsRepresentatives_CityID",
                table: "HospitalsRepresentatives",
                column: "CityID");

            migrationBuilder.CreateIndex(
                name: "IX_HospitalsRepresentatives_GenderID",
                table: "HospitalsRepresentatives",
                column: "GenderID");

            migrationBuilder.CreateIndex(
                name: "IX_HospitalsRepresentatives_HospitalID",
                table: "HospitalsRepresentatives",
                column: "HospitalID");

            migrationBuilder.CreateIndex(
                name: "IX_HospitalsRepresentatives_NameID",
                table: "HospitalsRepresentatives",
                column: "NameID");

            migrationBuilder.CreateIndex(
                name: "IX_HospitalsRepresentatives_PatronymicID",
                table: "HospitalsRepresentatives",
                column: "PatronymicID");

            migrationBuilder.CreateIndex(
                name: "IX_HospitalsRepresentatives_PositionID",
                table: "HospitalsRepresentatives",
                column: "PositionID");

            migrationBuilder.CreateIndex(
                name: "IX_HospitalsRepresentatives_RoleID",
                table: "HospitalsRepresentatives",
                column: "RoleID");

            migrationBuilder.CreateIndex(
                name: "IX_HospitalsRepresentatives_SurnameID",
                table: "HospitalsRepresentatives",
                column: "SurnameID");

            migrationBuilder.CreateIndex(
                name: "IX_HospitalsRepresentatives_WardID",
                table: "HospitalsRepresentatives",
                column: "WardID");

            migrationBuilder.CreateIndex(
                name: "IX_NavagateLink_NavagateLinkId",
                table: "NavagateLink",
                column: "NavagateLinkId");

            migrationBuilder.CreateIndex(
                name: "IX_PartnersRepresentatives_CityId",
                table: "PartnersRepresentatives",
                column: "CityId");

            migrationBuilder.CreateIndex(
                name: "IX_PartnersRepresentatives_GenderId",
                table: "PartnersRepresentatives",
                column: "GenderId");

            migrationBuilder.CreateIndex(
                name: "IX_PartnersRepresentatives_NameID",
                table: "PartnersRepresentatives",
                column: "NameID");

            migrationBuilder.CreateIndex(
                name: "IX_PartnersRepresentatives_PartnerID",
                table: "PartnersRepresentatives",
                column: "PartnerID");

            migrationBuilder.CreateIndex(
                name: "IX_PartnersRepresentatives_PatronymicID",
                table: "PartnersRepresentatives",
                column: "PatronymicID");

            migrationBuilder.CreateIndex(
                name: "IX_PartnersRepresentatives_RoleID",
                table: "PartnersRepresentatives",
                column: "RoleID");

            migrationBuilder.CreateIndex(
                name: "IX_PartnersRepresentatives_SurnameID",
                table: "PartnersRepresentatives",
                column: "SurnameID");

            migrationBuilder.CreateIndex(
                name: "IX_PatientPhotos_PatientID",
                table: "PatientPhotos",
                column: "PatientID");

            migrationBuilder.CreateIndex(
                name: "IX_Patients_CategoryID",
                table: "Patients",
                column: "CategoryID");

            migrationBuilder.CreateIndex(
                name: "IX_Patients_CityID",
                table: "Patients",
                column: "CityID");

            migrationBuilder.CreateIndex(
                name: "IX_Patients_DiagnosesId",
                table: "Patients",
                column: "DiagnosesId");

            migrationBuilder.CreateIndex(
                name: "IX_Patients_FundraisingStatusID",
                table: "Patients",
                column: "FundraisingStatusID");

            migrationBuilder.CreateIndex(
                name: "IX_Patients_GenderID",
                table: "Patients",
                column: "GenderID");

            migrationBuilder.CreateIndex(
                name: "IX_Patients_HospitalID",
                table: "Patients",
                column: "HospitalID");

            migrationBuilder.CreateIndex(
                name: "IX_Patients_NameID",
                table: "Patients",
                column: "NameID");

            migrationBuilder.CreateIndex(
                name: "IX_Patients_PatronymicID",
                table: "Patients",
                column: "PatronymicID");

            migrationBuilder.CreateIndex(
                name: "IX_Patients_SurnameID",
                table: "Patients",
                column: "SurnameID");

            migrationBuilder.CreateIndex(
                name: "IX_Patients_TreatmentCategoryID",
                table: "Patients",
                column: "TreatmentCategoryID");

            migrationBuilder.CreateIndex(
                name: "IX_Patients_WardID",
                table: "Patients",
                column: "WardID");

            migrationBuilder.CreateIndex(
                name: "IX_PatientsCharitableContributions_BenefactorID",
                table: "PatientsCharitableContributions",
                column: "BenefactorID");

            migrationBuilder.CreateIndex(
                name: "IX_PatientsCharitableContributions_PatientID",
                table: "PatientsCharitableContributions",
                column: "PatientID");

            migrationBuilder.CreateIndex(
                name: "IX_Streets_StreetTypesId",
                table: "Streets",
                column: "StreetTypesId");

            migrationBuilder.CreateIndex(
                name: "IX_Wards_CityID",
                table: "Wards",
                column: "CityID");

            migrationBuilder.CreateIndex(
                name: "IX_Wards_EntranceID",
                table: "Wards",
                column: "EntranceID");

            migrationBuilder.CreateIndex(
                name: "IX_Wards_HospitalID",
                table: "Wards",
                column: "HospitalID");

            migrationBuilder.CreateIndex(
                name: "IX_Wards_HouseID",
                table: "Wards",
                column: "HouseID");

            migrationBuilder.CreateIndex(
                name: "IX_Wards_StreetID",
                table: "Wards",
                column: "StreetID");

            migrationBuilder.CreateIndex(
                name: "IX_WardsPhotos_WardID",
                table: "WardsPhotos",
                column: "WardID");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ContactPhones");

            migrationBuilder.DropTable(
                name: "HospitalsCharitableContributions");

            migrationBuilder.DropTable(
                name: "HospitalsPhotos");

            migrationBuilder.DropTable(
                name: "NavagateLink");

            migrationBuilder.DropTable(
                name: "Option");

            migrationBuilder.DropTable(
                name: "PartnersRepresentatives");

            migrationBuilder.DropTable(
                name: "PatientPhotos");

            migrationBuilder.DropTable(
                name: "PatientsCharitableContributions");

            migrationBuilder.DropTable(
                name: "WardsPhotos");

            migrationBuilder.DropTable(
                name: "HospitalsRepresentatives");

            migrationBuilder.DropTable(
                name: "Partners");

            migrationBuilder.DropTable(
                name: "Benefactors");

            migrationBuilder.DropTable(
                name: "Patients");

            migrationBuilder.DropTable(
                name: "Positions");

            migrationBuilder.DropTable(
                name: "Roles");

            migrationBuilder.DropTable(
                name: "Category");

            migrationBuilder.DropTable(
                name: "Diagnoses");

            migrationBuilder.DropTable(
                name: "FundraisingStatuses");

            migrationBuilder.DropTable(
                name: "Gender");

            migrationBuilder.DropTable(
                name: "Names");

            migrationBuilder.DropTable(
                name: "Patronymics");

            migrationBuilder.DropTable(
                name: "Surnames");

            migrationBuilder.DropTable(
                name: "TreatmentCategory");

            migrationBuilder.DropTable(
                name: "Wards");

            migrationBuilder.DropTable(
                name: "Hospitals");

            migrationBuilder.DropTable(
                name: "Cities");

            migrationBuilder.DropTable(
                name: "Entrances");

            migrationBuilder.DropTable(
                name: "Houses");

            migrationBuilder.DropTable(
                name: "Streets");

            migrationBuilder.DropTable(
                name: "StreetTypes");
        }
    }
}
