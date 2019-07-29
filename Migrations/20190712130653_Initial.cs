using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace EditorApp.API.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AC_Accident",
                columns: table => new
                {
                    AccidentId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    DateofAccident = table.Column<DateTime>(type: "date", nullable: true),
                    AccidentSummary = table.Column<string>(maxLength: 500, nullable: true),
                    DistrictId = table.Column<int>(nullable: true),
                    AreaId = table.Column<int>(nullable: true),
                    HighwayCode = table.Column<string>(maxLength: 50, nullable: true),
                    TypeofRoad = table.Column<string>(maxLength: 50, nullable: true),
                    VehichleCausingId = table.Column<int>(nullable: true),
                    VehichleVictimId = table.Column<int>(nullable: true),
                    VehichleCausedLicensed = table.Column<int>(nullable: true),
                    VehichleVictimLicensed = table.Column<int>(nullable: true),
                    VehichleCausedFit = table.Column<int>(nullable: true),
                    VehichleVictimFit = table.Column<int>(nullable: true),
                    VehichleCausedInsuranced = table.Column<int>(nullable: true),
                    VehichleVictimInsuranced = table.Column<int>(nullable: true),
                    CausedDriverAge = table.Column<int>(nullable: true),
                    VictimDriverAge = table.Column<int>(nullable: true),
                    CausedRegistration = table.Column<int>(nullable: true),
                    VictimRegistration = table.Column<int>(nullable: true),
                    CreatedBy = table.Column<int>(nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    ModifiedBy = table.Column<int>(nullable: true),
                    ModifiedDate = table.Column<DateTime>(type: "datetime", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AC_Accident", x => x.AccidentId);
                });

            migrationBuilder.CreateTable(
                name: "AC_AccidentDetail",
                columns: table => new
                {
                    AccidentDetailId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    AccidentId = table.Column<int>(nullable: true),
                    AccidentTypeId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AC_AccidentDetail", x => x.AccidentDetailId);
                });

            migrationBuilder.CreateTable(
                name: "AC_AccidentType",
                columns: table => new
                {
                    AccidentTypeId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    AccidentTypeName = table.Column<string>(maxLength: 500, nullable: true),
                    CreatedBy = table.Column<int>(nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    ModifiedBy = table.Column<int>(nullable: true),
                    ModifiedDate = table.Column<DateTime>(type: "datetime", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AC_AccidentType", x => x.AccidentTypeId);
                });

            migrationBuilder.CreateTable(
                name: "AC_AccidentVictim",
                columns: table => new
                {
                    AccidentVictimId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    AccidentId = table.Column<int>(nullable: true),
                    Name = table.Column<string>(maxLength: 150, nullable: true),
                    Age = table.Column<int>(nullable: true),
                    Gender = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
                    InjuredorKilled = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
                    VictimDistrictId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AC_AccidentVictim", x => x.AccidentVictimId);
                });

            migrationBuilder.CreateTable(
                name: "AC_VehichleType",
                columns: table => new
                {
                    VehichleTypeId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    VehichleTypeName = table.Column<string>(maxLength: 50, nullable: true),
                    VehichleCategory = table.Column<string>(maxLength: 50, nullable: true),
                    CreatedBy = table.Column<int>(nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    ModifiedBy = table.Column<int>(nullable: true),
                    ModifiedDate = table.Column<DateTime>(type: "datetime", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AC_VehichleType", x => x.VehichleTypeId);
                });

            migrationBuilder.CreateTable(
                name: "ActivityDetail",
                columns: table => new
                {
                    ActivityId = table.Column<decimal>(type: "numeric(18, 0)", nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    UserId = table.Column<int>(nullable: true),
                    ActivityDescription = table.Column<string>(unicode: false, maxLength: 150, nullable: true),
                    EntryDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    Heading = table.Column<string>(maxLength: 500, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ActivityDetail", x => x.ActivityId);
                });

            migrationBuilder.CreateTable(
                name: "ANIEntry",
                columns: table => new
                {
                    AniNewsId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    NewsName = table.Column<string>(maxLength: 500, nullable: true),
                    FileName = table.Column<string>(maxLength: 500, nullable: true),
                    Createdby = table.Column<int>(nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ANI_NewsEntry", x => x.AniNewsId);
                });

            migrationBuilder.CreateTable(
                name: "Area",
                columns: table => new
                {
                    AreaId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    AreaName = table.Column<string>(maxLength: 50, nullable: true),
                    EmailCC = table.Column<string>(unicode: false, maxLength: 150, nullable: true),
                    MobileCC = table.Column<string>(unicode: false, maxLength: 150, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Area", x => x.AreaId);
                });

            migrationBuilder.CreateTable(
                name: "AreaPermission",
                columns: table => new
                {
                    AreaPermissionId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    UserId = table.Column<int>(nullable: true),
                    AreaId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AreaPermission", x => x.AreaPermissionId);
                });

            migrationBuilder.CreateTable(
                name: "Assignment",
                columns: table => new
                {
                    AssignmentId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    AssignmentDate = table.Column<DateTime>(type: "date", nullable: true),
                    StartTime = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
                    EndTime = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
                    AssgingmentSubject = table.Column<string>(maxLength: 550, nullable: true),
                    AssignmentPlace = table.Column<string>(maxLength: 550, nullable: true),
                    AssignmentOrganization = table.Column<string>(maxLength: 550, nullable: true),
                    AssignmentPersonality = table.Column<string>(maxLength: 550, nullable: true),
                    AssignedBy = table.Column<int>(nullable: true),
                    AssignedTo = table.Column<int>(nullable: true),
                    AssignedDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    UpdateBy = table.Column<int>(nullable: true),
                    UpdateDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    PictureNeed = table.Column<string>(maxLength: 50, nullable: true),
                    OnLeave = table.Column<int>(nullable: true),
                    SpecialNote = table.Column<string>(maxLength: 1500, nullable: true),
                    AssignmentDay = table.Column<int>(nullable: true),
                    Followup = table.Column<int>(nullable: true),
                    AssignmentStatus = table.Column<int>(nullable: true),
                    AssignmentTypeId = table.Column<int>(nullable: true),
                    EmployeeCode = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
                    IsPhotographerAssigned = table.Column<bool>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Assignment", x => x.AssignmentId);
                });

            migrationBuilder.CreateTable(
                name: "AssignmentDetail",
                columns: table => new
                {
                    AssignmenDetailtId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    AssignmentId = table.Column<int>(nullable: true),
                    Latitude = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
                    Longitude = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
                    ReplyTime = table.Column<DateTime>(type: "datetime", nullable: true),
                    PlaceofReply = table.Column<string>(unicode: false, maxLength: 150, nullable: true),
                    ReplyMessage = table.Column<string>(maxLength: 150, nullable: true),
                    RepliedBy = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AssignmentDetail", x => x.AssignmenDetailtId);
                });

            migrationBuilder.CreateTable(
                name: "AssignmentPhotographer",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    AssignmentId = table.Column<int>(nullable: false),
                    AssignedById = table.Column<int>(nullable: true),
                    AssignedPGId = table.Column<int>(nullable: true),
                    AssignedDate = table.Column<DateTime>(type: "datetime", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AssignmentPhotographer", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AssignmentType",
                columns: table => new
                {
                    AssignmentTypeId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    AssignmentTypeName = table.Column<string>(maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AssignmentType", x => x.AssignmentTypeId);
                });

            migrationBuilder.CreateTable(
                name: "CS_CaseSummary",
                columns: table => new
                {
                    CaseId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    CaseDetails = table.Column<string>(maxLength: 250, nullable: true),
                    CaseDate = table.Column<DateTime>(type: "date", nullable: true),
                    CaseDistrictId = table.Column<int>(nullable: false),
                    CaseThanaName = table.Column<string>(unicode: false, maxLength: 150, nullable: true),
                    CaseSection = table.Column<string>(maxLength: 250, nullable: true),
                    ChargeSheetDate = table.Column<DateTime>(type: "date", nullable: true),
                    ChargeSheetPerson = table.Column<string>(maxLength: 150, nullable: true),
                    ArrestedPerson = table.Column<string>(maxLength: 150, nullable: true),
                    CaseClosedViaMedia = table.Column<string>(unicode: false, maxLength: 100, nullable: true),
                    CaseFiledType = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
                    CaseFiledByName = table.Column<string>(maxLength: 150, nullable: true),
                    CaseFiledByDesignation = table.Column<string>(maxLength: 100, nullable: true),
                    CaseFiledAgainstType = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
                    CaseFiledAgainstName = table.Column<string>(maxLength: 150, nullable: true),
                    CaseFiledAgainstAddress = table.Column<string>(maxLength: 500, nullable: true),
                    CaseFiledAgainstAge = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
                    CaseFiledAgainstOccupation = table.Column<int>(nullable: false),
                    CaseFiledAgainstPoliticalIdentity = table.Column<string>(maxLength: 150, nullable: true),
                    CreatedBy = table.Column<int>(nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "date", nullable: true),
                    ModifiedBy = table.Column<int>(nullable: true),
                    ModifiedDate = table.Column<DateTime>(type: "date", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CS_CaseSummary", x => x.CaseId);
                });

            migrationBuilder.CreateTable(
                name: "DCSMS",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    MobileNo = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
                    SMSText = table.Column<string>(unicode: false, maxLength: 250, nullable: true),
                    Status = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
                    SMSSendTime = table.Column<string>(unicode: false, maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DCSMS", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "DCTask",
                columns: table => new
                {
                    TaskId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    TaskSubject = table.Column<string>(maxLength: 250, nullable: true),
                    TaskDetail = table.Column<string>(maxLength: 3500, nullable: true),
                    AssignedBy = table.Column<int>(nullable: true),
                    AssignedTo = table.Column<int>(nullable: true),
                    AssignedTime = table.Column<DateTime>(type: "datetime", nullable: true),
                    TaskStatus = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DCTask", x => x.TaskId);
                });

            migrationBuilder.CreateTable(
                name: "DCTaskSDetail",
                columns: table => new
                {
                    TaskDetailId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    TaskId = table.Column<int>(nullable: true),
                    ReplyTime = table.Column<DateTime>(type: "datetime", nullable: true),
                    ReplyText = table.Column<string>(maxLength: 1500, nullable: true),
                    RepliedBy = table.Column<int>(nullable: true),
                    ReplyStatus = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DCTaskDetail", x => x.TaskDetailId);
                });

            migrationBuilder.CreateTable(
                name: "DeletedUser",
                columns: table => new
                {
                    AutoId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    UserId = table.Column<int>(nullable: true),
                    FullName = table.Column<string>(maxLength: 500, nullable: true),
                    EmailAddress = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
                    MobileNo = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
                    UserName = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
                    Address = table.Column<string>(maxLength: 500, nullable: true),
                    UserGroup = table.Column<string>(maxLength: 500, nullable: true),
                    DeleteDate = table.Column<DateTime>(type: "date", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DeletedUser", x => x.AutoId);
                });

            migrationBuilder.CreateTable(
                name: "Designation",
                columns: table => new
                {
                    DesignationId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    DesignationName = table.Column<string>(maxLength: 150, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Designation", x => x.DesignationId);
                });

            migrationBuilder.CreateTable(
                name: "DeskPermission",
                columns: table => new
                {
                    DeskPermissionId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    UserId = table.Column<int>(nullable: true),
                    DeskCode = table.Column<string>(unicode: false, maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DeskPermission", x => x.DeskPermissionId);
                });

            migrationBuilder.CreateTable(
                name: "DigiSecurityActAccused",
                columns: table => new
                {
                    DigiSecurityAccusedId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    DigitalSecurityActCaseId = table.Column<int>(nullable: true),
                    DigiSecurityAccusedName = table.Column<string>(nullable: true),
                    DigiSecurityAccusedAge = table.Column<string>(maxLength: 50, nullable: true),
                    DigiSecurityAccusedOccupation = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DigiSecurityActAccused", x => x.DigiSecurityAccusedId);
                });

            migrationBuilder.CreateTable(
                name: "DigiSecurityActVictim",
                columns: table => new
                {
                    DigiSecurityVictimId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    DigitalSecurityActCaseId = table.Column<int>(nullable: true),
                    DigiSecurityVictimName = table.Column<string>(nullable: true),
                    DigiSecurityVictimAge = table.Column<string>(maxLength: 50, nullable: true),
                    DigiSecurityVictimOccupation = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DigiSecurityActVictim", x => x.DigiSecurityVictimId);
                });

            migrationBuilder.CreateTable(
                name: "DigiSecurityActWitness",
                columns: table => new
                {
                    DigiSecurityWitnessId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    DigitalSecurityActCaseId = table.Column<int>(nullable: true),
                    DigiSecurityWitnessName = table.Column<string>(nullable: true),
                    DigiSecurityWitnessAge = table.Column<string>(maxLength: 50, nullable: true),
                    DigiSecurityWitnessOccupation = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DigiSecurityActWitness", x => x.DigiSecurityWitnessId);
                });

            migrationBuilder.CreateTable(
                name: "DigitalSecurityActCase",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    SerialNo = table.Column<string>(maxLength: 50, nullable: true),
                    DigitalCaseDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    DistrictId = table.Column<int>(nullable: true),
                    ThanaId = table.Column<int>(nullable: true),
                    DigitalCaseNo = table.Column<string>(nullable: true),
                    Section = table.Column<string>(nullable: true),
                    Informant = table.Column<string>(nullable: true),
                    RO = table.Column<string>(nullable: true),
                    OC = table.Column<string>(nullable: true),
                    IO = table.Column<string>(nullable: true),
                    Contacts = table.Column<string>(nullable: true),
                    CaseState = table.Column<string>(nullable: true),
                    Incident = table.Column<string>(nullable: true),
                    Evidence = table.Column<string>(nullable: true),
                    CommentFIR = table.Column<string>(nullable: true),
                    Cmnt = table.Column<string>(nullable: true),
                    Quotes = table.Column<string>(nullable: true),
                    CreatedBy = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    EditedBy = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
                    EditedDate = table.Column<DateTime>(type: "datetime", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DigitalSecurityActCase", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "District",
                columns: table => new
                {
                    DistrictNameId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    DistrictName = table.Column<string>(maxLength: 150, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_District", x => x.DistrictNameId);
                });

            migrationBuilder.CreateTable(
                name: "DW_Edition",
                columns: table => new
                {
                    AutoId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    EditionCode = table.Column<int>(nullable: true),
                    EditionName = table.Column<string>(maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DW_Edition", x => x.AutoId);
                });

            migrationBuilder.CreateTable(
                name: "DW_Employee",
                columns: table => new
                {
                    employeecode = table.Column<string>(unicode: false, maxLength: 50, nullable: false),
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    displayname = table.Column<string>(unicode: false, maxLength: 150, nullable: true),
                    deskcode = table.Column<int>(nullable: true),
                    publicationcode = table.Column<int>(nullable: true),
                    ldapint = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
                    groupcode = table.Column<int>(nullable: true),
                    reportingdesk = table.Column<string>(unicode: false, maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DW_Employee", x => x.employeecode);
                });

            migrationBuilder.CreateTable(
                name: "DW_GuestAuthorStory",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Storycode = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
                    Version = table.Column<int>(nullable: true),
                    StoryDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    AuthorName = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
                    ActionBy = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
                    Flag = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
                    Heading = table.Column<string>(maxLength: 500, nullable: true),
                    DeskCode = table.Column<int>(nullable: true),
                    PublicationCode = table.Column<int>(nullable: true),
                    DisplayName = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
                    AuthorDeskCode = table.Column<int>(nullable: true),
                    Publication = table.Column<string>(unicode: false, maxLength: 100, nullable: true),
                    Desk = table.Column<string>(unicode: false, maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DW_GuestAuthorStory", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "DW_LastStoryPagewise",
                columns: table => new
                {
                    AutoId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    StoryDate = table.Column<DateTime>(type: "date", nullable: true),
                    StoryCode = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
                    EditionCode = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
                    PageNo = table.Column<int>(nullable: true),
                    StoryTime = table.Column<DateTime>(type: "datetime", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DW_LastStoryPagewise", x => x.AutoId);
                });

            migrationBuilder.CreateTable(
                name: "DW_LastStoryVersion",
                columns: table => new
                {
                    AutoId = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    StoryCode = table.Column<string>(maxLength: 50, nullable: false),
                    LastHeading = table.Column<string>(maxLength: 4000, nullable: true),
                    LastVersion = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DW_LastStoryVersion_1", x => x.AutoId);
                });

            migrationBuilder.CreateTable(
                name: "DW_LogTime",
                columns: table => new
                {
                    AutoId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    EmployeeCode = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
                    LoginDate = table.Column<DateTime>(type: "date", nullable: true),
                    NoofMin = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DW_LogTime", x => x.AutoId);
                });

            migrationBuilder.CreateTable(
                name: "DW_OnlineContribution",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    StoryCode = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
                    NewStoryCode = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
                    Heading = table.Column<string>(maxLength: 500, nullable: true),
                    Contributor = table.Column<string>(maxLength: 200, nullable: true),
                    DeskFrom = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
                    FromPublication = table.Column<int>(nullable: true),
                    ToPublication = table.Column<int>(nullable: true),
                    FromDesk = table.Column<int>(nullable: true),
                    ToDesk = table.Column<int>(nullable: true),
                    TransferedBy = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
                    TransferDate = table.Column<DateTime>(type: "datetime", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DW_OnlineContribution", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "DW_PageWiseStory",
                columns: table => new
                {
                    AutoId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    StoryCode = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
                    VersionCode = table.Column<int>(nullable: true),
                    EditionCode = table.Column<int>(nullable: true),
                    PageNo = table.Column<int>(nullable: true),
                    FlowStatus = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
                    StoryDate = table.Column<DateTime>(type: "date", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DW_PageWiseStory", x => x.AutoId);
                });

            migrationBuilder.CreateTable(
                name: "DW_PhotoReport",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(maxLength: 250, nullable: true),
                    Employeecode = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
                    PhotoDate = table.Column<DateTime>(type: "date", nullable: true),
                    Uploaded = table.Column<int>(nullable: true),
                    Published = table.Column<int>(nullable: true),
                    DeskCode = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DW_PhotoReport", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "DW_Story_Summary_Breakdown",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    employeecode = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
                    Displayname = table.Column<string>(maxLength: 250, nullable: true),
                    StoryDate = table.Column<DateTime>(type: "date", nullable: true),
                    Selfwritten = table.Column<int>(nullable: true),
                    Translated = table.Column<int>(nullable: true),
                    Compiled = table.Column<int>(nullable: true),
                    Assignment = table.Column<int>(nullable: true),
                    Report = table.Column<int>(nullable: true),
                    Interview = table.Column<int>(nullable: true),
                    Edited = table.Column<int>(nullable: true),
                    Approved = table.Column<int>(nullable: true),
                    TotalStories = table.Column<int>(nullable: true),
                    TotalWords = table.Column<int>(nullable: true),
                    DaysWorked = table.Column<int>(nullable: true),
                    AvgWordsPerDay = table.Column<int>(nullable: true),
                    Remark = table.Column<string>(unicode: false, maxLength: 150, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DW_Story_Summary_Breakdown", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "DW_StoryTye",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    storycode = table.Column<string>(unicode: false, maxLength: 50, nullable: false),
                    deskcode = table.Column<int>(nullable: true),
                    type = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
                    employeecode = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
                    storydate = table.Column<DateTime>(type: "datetime", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DW_StoryTye", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "DW_UserWiseStory",
                columns: table => new
                {
                    AutoId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    EmployeeCode = table.Column<string>(maxLength: 50, nullable: false),
                    StoryCode = table.Column<string>(maxLength: 50, nullable: false),
                    Version = table.Column<int>(nullable: false),
                    StoryDate = table.Column<DateTime>(type: "datetime", nullable: false),
                    Status = table.Column<string>(maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DW_UserWiseStory_1", x => x.AutoId);
                });

            migrationBuilder.CreateTable(
                name: "DW_VersionWordCount",
                columns: table => new
                {
                    StoryCode = table.Column<string>(maxLength: 50, nullable: false),
                    Version = table.Column<int>(nullable: false),
                    WordCountId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    WordCount = table.Column<int>(nullable: true),
                    Author = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
                    Owner = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
                    Storydate = table.Column<DateTime>(type: "datetime", nullable: true),
                    Status = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
                    Deskcode = table.Column<int>(nullable: true),
                    PublicationCode = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DW_VersionWordCount", x => new { x.StoryCode, x.Version });
                });

            migrationBuilder.CreateTable(
                name: "EL_Area",
                columns: table => new
                {
                    AreaId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    DistrictId = table.Column<int>(nullable: true),
                    AreaName = table.Column<string>(maxLength: 250, nullable: true),
                    IsUpazila = table.Column<int>(nullable: true),
                    IsUnion = table.Column<int>(nullable: true),
                    IsThana = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EL_Area", x => x.AreaId);
                });

            migrationBuilder.CreateTable(
                name: "EL_AreaAssignment",
                columns: table => new
                {
                    AreaAssignmentId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    ElectionAreaId = table.Column<int>(nullable: true),
                    UserId = table.Column<int>(nullable: true),
                    CreatedBy = table.Column<int>(nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    ModifiedBy = table.Column<int>(nullable: true),
                    ModifiedDate = table.Column<DateTime>(type: "datetime", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EL_AreaAssignment", x => x.AreaAssignmentId);
                });

            migrationBuilder.CreateTable(
                name: "EL_Asset",
                columns: table => new
                {
                    AssetId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    ElectionId = table.Column<int>(nullable: true),
                    ElectionAreaId = table.Column<int>(nullable: true),
                    PersonId = table.Column<int>(nullable: true),
                    PersonName = table.Column<string>(maxLength: 500, nullable: true),
                    SelfAsset = table.Column<string>(maxLength: 50, nullable: true),
                    DependentAsset = table.Column<string>(maxLength: 50, nullable: true),
                    CreatedBy = table.Column<int>(nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    ModifiedBy = table.Column<int>(nullable: true),
                    ModifiedDate = table.Column<DateTime>(type: "datetime", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EL_Asset", x => x.AssetId);
                });

            migrationBuilder.CreateTable(
                name: "EL_Case",
                columns: table => new
                {
                    CaseId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    ElectionId = table.Column<int>(nullable: true),
                    PersonId = table.Column<int>(nullable: true),
                    CurrentCase = table.Column<int>(nullable: true),
                    PreviousCase = table.Column<string>(maxLength: 10, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EL_Case", x => x.CaseId);
                });

            migrationBuilder.CreateTable(
                name: "El_CentralPolitician",
                columns: table => new
                {
                    CentralPoliticianId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    ElectionId = table.Column<int>(nullable: true),
                    ElectionAreaId = table.Column<int>(nullable: true),
                    PersonId = table.Column<int>(nullable: true),
                    PersonName = table.Column<string>(maxLength: 500, nullable: true),
                    CurrentDesignation = table.Column<string>(maxLength: 500, nullable: true),
                    CreatedBy = table.Column<int>(nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    ModifiedBy = table.Column<int>(nullable: true),
                    ModifiedDate = table.Column<DateTime>(type: "datetime", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_El_CentralPolitician", x => x.CentralPoliticianId);
                });

            migrationBuilder.CreateTable(
                name: "EL_District",
                columns: table => new
                {
                    DistrictId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    DistrictName = table.Column<string>(maxLength: 50, nullable: true),
                    DistrictNameEn = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
                    DivisionId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EL_District", x => x.DistrictId);
                });

            migrationBuilder.CreateTable(
                name: "EL_Division",
                columns: table => new
                {
                    DivisionId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    DivisionName = table.Column<string>(maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EL_Division", x => x.DivisionId);
                });

            migrationBuilder.CreateTable(
                name: "EL_Education",
                columns: table => new
                {
                    EducationId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    ElectionId = table.Column<int>(nullable: true),
                    PersonId = table.Column<int>(nullable: true),
                    EducationTypeId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EL_Education", x => x.EducationId);
                });

            migrationBuilder.CreateTable(
                name: "EL_EducationType",
                columns: table => new
                {
                    EducationTypeId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    EducationTypeName = table.Column<string>(maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EL_EducationType", x => x.EducationTypeId);
                });

            migrationBuilder.CreateTable(
                name: "EL_Election",
                columns: table => new
                {
                    ElectionId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    ElectionName = table.Column<string>(maxLength: 150, nullable: true),
                    ElectionYear = table.Column<int>(nullable: true),
                    FromDate = table.Column<DateTime>(type: "date", nullable: true),
                    ToDate = table.Column<DateTime>(type: "date", nullable: true),
                    MajorityPartyId = table.Column<int>(nullable: true),
                    OppositionPartyId = table.Column<int>(nullable: true),
                    Comments = table.Column<string>(maxLength: 500, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EL_Election", x => x.ElectionId);
                });

            migrationBuilder.CreateTable(
                name: "EL_ElectionArea",
                columns: table => new
                {
                    ElectionAreaId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    ElectionId = table.Column<int>(nullable: true),
                    ElectionAreaName = table.Column<string>(maxLength: 50, nullable: true),
                    ElectionAreaSerial = table.Column<int>(nullable: true),
                    RegularorReserved = table.Column<string>(maxLength: 50, nullable: true),
                    CreatedBy = table.Column<int>(nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    ModifiedBy = table.Column<int>(nullable: true),
                    ModifiedDate = table.Column<DateTime>(type: "datetime", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EL_ElectionArea", x => x.ElectionAreaId);
                });

            migrationBuilder.CreateTable(
                name: "EL_ElectionAreaDetail",
                columns: table => new
                {
                    ElectionAreaDetailId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    ElectionAreaId = table.Column<int>(nullable: true),
                    AreaId = table.Column<int>(nullable: true),
                    CreatedBy = table.Column<int>(nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    ModifiedBy = table.Column<int>(nullable: true),
                    ModifiedDate = table.Column<DateTime>(type: "datetime", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EL_ElectionAreaDetail", x => x.ElectionAreaDetailId);
                });

            migrationBuilder.CreateTable(
                name: "EL_ElectionAreaHistory",
                columns: table => new
                {
                    ElectionAreaHistoryId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    ElectionId = table.Column<int>(nullable: true),
                    ElectionAreaId = table.Column<int>(nullable: true),
                    PersonId = table.Column<int>(nullable: true),
                    PoliticalPartyId = table.Column<int>(nullable: true),
                    TotalVote = table.Column<string>(maxLength: 10, nullable: true),
                    Position = table.Column<int>(nullable: true),
                    IsUncompetitionally = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EL_ElectionAreaHistory", x => x.ElectionAreaHistoryId);
                });

            migrationBuilder.CreateTable(
                name: "EL_FamilyPolitician",
                columns: table => new
                {
                    FamilyPloiticianId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    ElectionId = table.Column<int>(nullable: true),
                    ElectionAreaId = table.Column<int>(nullable: true),
                    PersonId = table.Column<int>(nullable: true),
                    PersonName = table.Column<string>(maxLength: 500, nullable: true),
                    PoliticalPartyId = table.Column<int>(nullable: true),
                    FamilyPoliticianName = table.Column<string>(maxLength: 500, nullable: true),
                    PoliticsEntryYear = table.Column<string>(maxLength: 50, nullable: true),
                    CurrentDesignation = table.Column<string>(maxLength: 500, nullable: true),
                    CreatedBy = table.Column<int>(nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    ModifiedBy = table.Column<int>(nullable: true),
                    ModifiedDate = table.Column<DateTime>(type: "datetime", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EL_FamilyPolitician", x => x.FamilyPloiticianId);
                });

            migrationBuilder.CreateTable(
                name: "EL_IncidentDetail",
                columns: table => new
                {
                    CurrentMpId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    ElectionId = table.Column<int>(nullable: true),
                    ElectionAreaId = table.Column<int>(nullable: true),
                    PersonId = table.Column<int>(nullable: true),
                    PersonName = table.Column<string>(maxLength: 500, nullable: true),
                    IncidentType = table.Column<string>(maxLength: 50, nullable: true),
                    Description = table.Column<string>(maxLength: 50, nullable: true),
                    Detail = table.Column<string>(maxLength: 50, nullable: true),
                    CreatedBy = table.Column<int>(nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    ModifiedBy = table.Column<int>(nullable: true),
                    ModifiedDate = table.Column<DateTime>(type: "datetime", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EL_IncidentDetail", x => x.CurrentMpId);
                });

            migrationBuilder.CreateTable(
                name: "EL_Income",
                columns: table => new
                {
                    IncomeId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    ElectionId = table.Column<int>(nullable: true),
                    ElectionAreaId = table.Column<int>(nullable: true),
                    PersonId = table.Column<int>(nullable: true),
                    PersonName = table.Column<string>(maxLength: 500, nullable: true),
                    SelfIncome = table.Column<string>(maxLength: 50, nullable: true),
                    DependentIncome = table.Column<string>(maxLength: 50, nullable: true),
                    CreatedBy = table.Column<int>(nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    ModifiedBy = table.Column<int>(nullable: true),
                    ModifiedDate = table.Column<DateTime>(type: "datetime", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EL_Income", x => x.IncomeId);
                });

            migrationBuilder.CreateTable(
                name: "EL_InternalClash",
                columns: table => new
                {
                    InternalClashId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    ElectionId = table.Column<int>(nullable: true),
                    ElectionAreaId = table.Column<int>(nullable: true),
                    PoliticalPartyId = table.Column<int>(nullable: true),
                    ClashDescription = table.Column<string>(maxLength: 500, nullable: true),
                    SelfClash = table.Column<string>(maxLength: 50, nullable: true),
                    Killed = table.Column<string>(maxLength: 50, nullable: true),
                    Injured = table.Column<string>(maxLength: 50, nullable: true),
                    CreatedBy = table.Column<int>(nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    ModifiedBy = table.Column<int>(nullable: true),
                    ModifiedDate = table.Column<DateTime>(type: "datetime", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EL_InternalClash", x => x.InternalClashId);
                });

            migrationBuilder.CreateTable(
                name: "EL_Liability",
                columns: table => new
                {
                    LiabilityId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    ElectionId = table.Column<int>(nullable: true),
                    ElectionAreaId = table.Column<int>(nullable: true),
                    PersonId = table.Column<int>(nullable: true),
                    PersonName = table.Column<string>(maxLength: 500, nullable: true),
                    SelfLiability = table.Column<string>(maxLength: 50, nullable: true),
                    CreatedBy = table.Column<int>(nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    ModifiedBy = table.Column<int>(nullable: true),
                    ModifiedDate = table.Column<DateTime>(type: "datetime", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EL_Liability", x => x.LiabilityId);
                });

            migrationBuilder.CreateTable(
                name: "EL_MinorityAttack",
                columns: table => new
                {
                    MinorityAttackId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    ElectionId = table.Column<int>(nullable: true),
                    ElectionAreaId = table.Column<int>(nullable: true),
                    PersonId = table.Column<int>(nullable: true),
                    PersonName = table.Column<string>(maxLength: 500, nullable: true),
                    Description = table.Column<string>(maxLength: 500, nullable: true),
                    CreatedBy = table.Column<int>(nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    ModifiedBy = table.Column<int>(nullable: true),
                    ModifiedDate = table.Column<DateTime>(type: "datetime", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EL_MinorityAttach", x => x.MinorityAttackId);
                });

            migrationBuilder.CreateTable(
                name: "EL_MinorityVoterCount",
                columns: table => new
                {
                    MinorityVoterCountId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    ElectionAreaId = table.Column<int>(nullable: true),
                    LastUpdatedYear = table.Column<int>(nullable: true),
                    HinduVoter = table.Column<int>(nullable: true),
                    BuddhaVoter = table.Column<int>(nullable: true),
                    ChristianVoter = table.Column<int>(nullable: true),
                    TribalVoter = table.Column<int>(nullable: true),
                    CreatedBy = table.Column<int>(nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    UpdatedBy = table.Column<int>(nullable: true),
                    UpdatedDate = table.Column<DateTime>(type: "datetime", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EL_MinorityVoterCount", x => x.MinorityVoterCountId);
                });

            migrationBuilder.CreateTable(
                name: "EL_Nomination",
                columns: table => new
                {
                    NominationId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    ElectionId = table.Column<int>(nullable: true),
                    ElectionAreaId = table.Column<int>(nullable: true),
                    PersonId = table.Column<int>(nullable: true),
                    PoliticalPartyId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EL_Nomination", x => x.NominationId);
                });

            migrationBuilder.CreateTable(
                name: "EL_Occupation",
                columns: table => new
                {
                    OccupationId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    ElectionId = table.Column<int>(nullable: true),
                    PersonId = table.Column<int>(nullable: true),
                    OccupationTypeId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EL_Occupation", x => x.OccupationId);
                });

            migrationBuilder.CreateTable(
                name: "EL_OccupationType",
                columns: table => new
                {
                    OccupationTypeId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    OccupationTypeName = table.Column<string>(maxLength: 50, nullable: true),
                    OccupationTypeNameEn = table.Column<string>(unicode: false, maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EL_OccupationType", x => x.OccupationTypeId);
                });

            migrationBuilder.CreateTable(
                name: "EL_OneEleven",
                columns: table => new
                {
                    OneElevenId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    ElectionId = table.Column<int>(nullable: true),
                    ElectionAreaId = table.Column<int>(nullable: true),
                    PersonId = table.Column<int>(nullable: true),
                    PersonName = table.Column<string>(maxLength: 500, nullable: true),
                    IsKnown = table.Column<string>(maxLength: 50, nullable: true),
                    Influence = table.Column<string>(maxLength: 50, nullable: true),
                    CreatedBy = table.Column<int>(nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    ModifiedBy = table.Column<int>(nullable: true),
                    ModifiedDate = table.Column<DateTime>(type: "datetime", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EL_OneEleven", x => x.OneElevenId);
                });

            migrationBuilder.CreateTable(
                name: "EL_OnJamanotBajeapto",
                columns: table => new
                {
                    JamanotBajeaptoId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    ElectionAreaId = table.Column<int>(nullable: true),
                    ElectionId = table.Column<int>(nullable: true),
                    PersonId = table.Column<int>(nullable: true),
                    PoliticalPartyId = table.Column<int>(nullable: true),
                    TotalVote = table.Column<int>(nullable: true),
                    CreatedBy = table.Column<int>(nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    UpdatedBy = table.Column<int>(nullable: true),
                    UpdatedDate = table.Column<DateTime>(type: "datetime", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EL_OnJamanotBajeapto", x => x.JamanotBajeaptoId);
                });

            migrationBuilder.CreateTable(
                name: "EL_OnResult",
                columns: table => new
                {
                    VoteResultId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    ElectionAreaId = table.Column<int>(nullable: true),
                    ElectionId = table.Column<int>(nullable: true),
                    PersonId = table.Column<int>(nullable: true),
                    PoliticalPartyId = table.Column<int>(nullable: true),
                    ElectionSymbol = table.Column<string>(maxLength: 150, nullable: true),
                    TotalVote = table.Column<int>(nullable: true),
                    SerialNo = table.Column<int>(nullable: true),
                    WithoutCompetition = table.Column<int>(nullable: true),
                    CreatedBy = table.Column<int>(nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    UpdatedBy = table.Column<int>(nullable: true),
                    UpdatedDate = table.Column<DateTime>(type: "datetime", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EL_OnResult", x => x.VoteResultId);
                });

            migrationBuilder.CreateTable(
                name: "EL_OnResultUponirbachon",
                columns: table => new
                {
                    UponirbachonId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    ElectionAreaId = table.Column<int>(nullable: true),
                    ElectionId = table.Column<int>(nullable: true),
                    PersonId = table.Column<int>(nullable: true),
                    PoliticalPartyId = table.Column<int>(nullable: true),
                    TotalVote = table.Column<int>(nullable: true),
                    SerialNo = table.Column<int>(nullable: true),
                    WithoutCompetition = table.Column<int>(nullable: true),
                    CreatedBy = table.Column<int>(nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    UpdatedBy = table.Column<int>(nullable: true),
                    UpdatedDate = table.Column<DateTime>(type: "datetime", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EL_OnResultUponirbachon", x => x.UponirbachonId);
                });

            migrationBuilder.CreateTable(
                name: "EL_OnVoterInfo",
                columns: table => new
                {
                    VoterInfoId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    ElectionAreaId = table.Column<int>(nullable: true),
                    ElectionId = table.Column<int>(nullable: true),
                    TotalVoter = table.Column<int>(nullable: true),
                    TotalCenter = table.Column<int>(nullable: true),
                    ValidVote = table.Column<int>(nullable: true),
                    NonValidVote = table.Column<int>(nullable: true),
                    NoVote = table.Column<int>(nullable: true),
                    CreatedBy = table.Column<int>(nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    UpdatedBy = table.Column<int>(nullable: true),
                    UpdatedDate = table.Column<DateTime>(type: "datetime", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EL_OnVoterInfo", x => x.VoterInfoId);
                });

            migrationBuilder.CreateTable(
                name: "EL_Person",
                columns: table => new
                {
                    PersonId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    PersonName = table.Column<string>(maxLength: 250, nullable: true),
                    PhotoUrl = table.Column<string>(maxLength: 250, nullable: true),
                    CurrentDistrictId = table.Column<int>(nullable: true),
                    PermanentDistrictId = table.Column<int>(nullable: true),
                    FatherName = table.Column<string>(maxLength: 500, nullable: true),
                    MotherName = table.Column<string>(maxLength: 500, nullable: true),
                    CreatedBy = table.Column<int>(nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    UpdatedBy = table.Column<int>(nullable: true),
                    UpdatedDate = table.Column<DateTime>(type: "datetime", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EL_Person", x => x.PersonId);
                });

            migrationBuilder.CreateTable(
                name: "EL_PersonCase",
                columns: table => new
                {
                    PersonCaseId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    ElectionId = table.Column<int>(nullable: true),
                    ElectionAreaId = table.Column<int>(nullable: true),
                    PersonId = table.Column<int>(nullable: true),
                    PersonName = table.Column<string>(maxLength: 500, nullable: true),
                    CurrentCaseFrom2014 = table.Column<int>(nullable: true),
                    PreviousCases = table.Column<int>(nullable: true),
                    CreatedBy = table.Column<int>(nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    ModifiedBy = table.Column<int>(nullable: true),
                    ModifiedDate = table.Column<DateTime>(type: "datetime", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EL_PersonCase", x => x.PersonCaseId);
                });

            migrationBuilder.CreateTable(
                name: "EL_PersonPartyHistory",
                columns: table => new
                {
                    PersonPartyHistoryId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    ElectionId = table.Column<int>(nullable: true),
                    PersonId = table.Column<int>(nullable: true),
                    CentralPost = table.Column<string>(maxLength: 500, nullable: true),
                    LocalPost = table.Column<string>(maxLength: 500, nullable: true),
                    FromYear = table.Column<int>(nullable: true),
                    ToYear = table.Column<int>(nullable: true),
                    IsCurrent = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EL_PersonPartyHistory", x => x.PersonPartyHistoryId);
                });

            migrationBuilder.CreateTable(
                name: "EL_PoliticalParty",
                columns: table => new
                {
                    PoliticalPartyId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    PoliticalPartyName = table.Column<string>(maxLength: 150, nullable: true),
                    ElectionLogo = table.Column<string>(maxLength: 150, nullable: true),
                    EstablishedYear = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EL_PoliticalParty", x => x.PoliticalPartyId);
                });

            migrationBuilder.CreateTable(
                name: "EL_ProbableNomination",
                columns: table => new
                {
                    ProbableNominationId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    ElectionId = table.Column<int>(nullable: true),
                    ElectionAreaId = table.Column<int>(nullable: true),
                    PersonId = table.Column<int>(nullable: true),
                    PersonName = table.Column<string>(maxLength: 500, nullable: true),
                    PoliticalPartyId = table.Column<int>(nullable: true),
                    Designation = table.Column<string>(maxLength: 500, nullable: true),
                    Age = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
                    EducationTypeId = table.Column<int>(nullable: true),
                    OccupationTypeId = table.Column<int>(nullable: true),
                    ChangeHistory = table.Column<string>(nullable: true),
                    CreatedBy = table.Column<int>(nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    ModifiedBy = table.Column<int>(nullable: true),
                    ModifiedDate = table.Column<DateTime>(type: "datetime", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EL_ProbableNomination", x => x.ProbableNominationId);
                });

            migrationBuilder.CreateTable(
                name: "EL_SpecialCase",
                columns: table => new
                {
                    SpecialCaseId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    ElectionId = table.Column<int>(nullable: true),
                    ElectionAreaId = table.Column<int>(nullable: true),
                    Thana = table.Column<string>(maxLength: 500, nullable: true),
                    Case2014 = table.Column<string>(maxLength: 50, nullable: true),
                    Case2015 = table.Column<string>(maxLength: 50, nullable: true),
                    TotalAccused = table.Column<string>(maxLength: 50, nullable: true),
                    SpecialAccused = table.Column<string>(maxLength: 50, nullable: true),
                    CreatedBy = table.Column<int>(nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    ModifiedBy = table.Column<int>(nullable: true),
                    ModifiedDate = table.Column<DateTime>(type: "datetime", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EL_SpecialCase", x => x.SpecialCaseId);
                });

            migrationBuilder.CreateTable(
                name: "EL_Suspension",
                columns: table => new
                {
                    SuspendId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    ElectionId = table.Column<int>(nullable: true),
                    ElectionAreaId = table.Column<int>(nullable: true),
                    PersonId = table.Column<int>(nullable: true),
                    PersonName = table.Column<string>(maxLength: 500, nullable: true),
                    SuspendReason = table.Column<string>(maxLength: 50, nullable: true),
                    SuspendYear = table.Column<string>(maxLength: 50, nullable: true),
                    ReturnYear = table.Column<string>(maxLength: 50, nullable: true),
                    CreatedBy = table.Column<int>(nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    ModifiedBy = table.Column<int>(nullable: true),
                    ModifiedDate = table.Column<DateTime>(type: "datetime", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EL_Suspension", x => x.SuspendId);
                });

            migrationBuilder.CreateTable(
                name: "EL_TempPerson",
                columns: table => new
                {
                    TempPersonId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    TempPersonName = table.Column<string>(maxLength: 500, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EL_TempPerson", x => x.TempPersonId);
                });

            migrationBuilder.CreateTable(
                name: "EL_Upload",
                columns: table => new
                {
                    UploadId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    ElectionAreaId = table.Column<int>(nullable: true),
                    FileName = table.Column<string>(maxLength: 250, nullable: true),
                    Remarks = table.Column<string>(maxLength: 500, nullable: true),
                    CreatedBy = table.Column<int>(nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EL_Upload", x => x.UploadId);
                });

            migrationBuilder.CreateTable(
                name: "EL_VoterCount",
                columns: table => new
                {
                    VoterCountId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    ElectionAreaId = table.Column<int>(nullable: true),
                    LastUpdatedYear = table.Column<int>(nullable: true),
                    MaleVoter = table.Column<int>(nullable: true),
                    FemaleVoter = table.Column<int>(nullable: true),
                    TotalVoter = table.Column<int>(nullable: true),
                    CreatedBy = table.Column<int>(nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    UpdatedBy = table.Column<int>(nullable: true),
                    UpdatedDate = table.Column<DateTime>(type: "datetime", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EL_VoterCount", x => x.VoterCountId);
                });

            migrationBuilder.CreateTable(
                name: "EmailCC",
                columns: table => new
                {
                    AutoId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(maxLength: 150, nullable: true),
                    EmailID = table.Column<string>(unicode: false, maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EmailCC", x => x.AutoId);
                });

            migrationBuilder.CreateTable(
                name: "EmailLog",
                columns: table => new
                {
                    EmailId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    EmailText = table.Column<string>(nullable: true),
                    EmailTo = table.Column<int>(nullable: true),
                    EmailSendBy = table.Column<int>(nullable: true),
                    EntryTime = table.Column<DateTime>(type: "datetime", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EmailLog", x => x.EmailId);
                });

            migrationBuilder.CreateTable(
                name: "EmailQue",
                columns: table => new
                {
                    EmailId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    EmailType = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
                    EmailTitle = table.Column<string>(maxLength: 500, nullable: true),
                    EmailSubject = table.Column<string>(maxLength: 500, nullable: true),
                    EmailBody = table.Column<string>(maxLength: 500, nullable: true),
                    EmailReceipient = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
                    EmailCC = table.Column<string>(unicode: false, maxLength: 200, nullable: true),
                    EmailAttachment = table.Column<string>(unicode: false, maxLength: 500, nullable: true),
                    Status = table.Column<int>(nullable: true),
                    ProcessedTime = table.Column<DateTime>(type: "datetime", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EmailQue", x => x.EmailId);
                });

            migrationBuilder.CreateTable(
                name: "EmployeeWork",
                columns: table => new
                {
                    userid = table.Column<int>(nullable: false),
                    entrydate = table.Column<DateTime>(type: "datetime", nullable: false),
                    id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    day = table.Column<string>(maxLength: 50, nullable: false),
                    selfwritten = table.Column<int>(nullable: true),
                    translation = table.Column<int>(nullable: true),
                    edit = table.Column<int>(nullable: true),
                    approved = table.Column<int>(nullable: true),
                    words = table.Column<int>(nullable: true),
                    comment = table.Column<string>(maxLength: 250, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EmployeeWork", x => new { x.userid, x.entrydate });
                });

            migrationBuilder.CreateTable(
                name: "Event",
                columns: table => new
                {
                    EventId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    EventDate = table.Column<DateTime>(type: "date", nullable: true),
                    EventDescription = table.Column<string>(maxLength: 500, nullable: true),
                    EntryBy = table.Column<int>(nullable: true),
                    EntryDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    UpdateBy = table.Column<int>(nullable: true),
                    UpdateDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    EventDay = table.Column<int>(nullable: true),
                    EventMonth = table.Column<int>(nullable: true),
                    EventYear = table.Column<int>(nullable: true),
                    EventBar = table.Column<string>(unicode: false, maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Event", x => x.EventId);
                });

            migrationBuilder.CreateTable(
                name: "GroupPermission",
                columns: table => new
                {
                    GroupPermissionId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    UserId = table.Column<int>(nullable: true),
                    GroupId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GroupPermission", x => x.GroupPermissionId);
                });

            migrationBuilder.CreateTable(
                name: "MamsIdData",
                columns: table => new
                {
                    MamsId = table.Column<int>(nullable: false),
                    IDNo = table.Column<int>(nullable: true),
                    UpdatedTime = table.Column<DateTime>(type: "datetime", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MamsIdData", x => x.MamsId);
                });

            migrationBuilder.CreateTable(
                name: "NCenter",
                columns: table => new
                {
                    CenterCode = table.Column<int>(nullable: false),
                    CenterName = table.Column<string>(unicode: false, maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Center", x => x.CenterCode);
                });

            migrationBuilder.CreateTable(
                name: "NewswrapDesk",
                columns: table => new
                {
                    DeskID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    DeskCode = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
                    DeskName = table.Column<string>(unicode: false, maxLength: 150, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_NewswrapDesk", x => x.DeskID);
                });

            migrationBuilder.CreateTable(
                name: "PhotoAll",
                columns: table => new
                {
                    Id = table.Column<decimal>(type: "numeric(18, 0)", nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    PhotoName = table.Column<string>(unicode: false, maxLength: 150, nullable: true),
                    PhotoPath = table.Column<string>(unicode: false, maxLength: 550, nullable: true),
                    UserId = table.Column<int>(nullable: true),
                    CenterCode = table.Column<int>(nullable: true),
                    PhotoDate = table.Column<DateTime>(type: "date", nullable: true),
                    Description = table.Column<string>(nullable: true),
                    UsedStatus = table.Column<int>(nullable: true),
                    PhotoSize = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
                    EntryDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    UpdateDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    PhotoDesk = table.Column<string>(unicode: false, maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PhotoAll", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "PhotoSelection",
                columns: table => new
                {
                    photoid = table.Column<int>(nullable: false),
                    id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    selection = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PhotoSelection", x => x.photoid);
                });

            migrationBuilder.CreateTable(
                name: "PhotoSummary",
                columns: table => new
                {
                    Id = table.Column<decimal>(type: "numeric(18, 0)", nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    PhotoName = table.Column<string>(unicode: false, maxLength: 150, nullable: true),
                    PhotoPath = table.Column<string>(unicode: false, maxLength: 550, nullable: true),
                    UserId = table.Column<int>(nullable: true),
                    CenterCode = table.Column<int>(nullable: true),
                    PhotoDate = table.Column<DateTime>(type: "date", nullable: true),
                    Description = table.Column<string>(nullable: true),
                    UsedStatus = table.Column<int>(nullable: true),
                    PhotoSize = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
                    EntryDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    UpdateDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    PhotoDesk = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
                    UserCode = table.Column<string>(unicode: false, maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PhotoSummary", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "PlanDetail",
                columns: table => new
                {
                    PlanId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    PlanDate = table.Column<DateTime>(type: "date", nullable: true),
                    PlanSummary = table.Column<string>(maxLength: 1500, nullable: true),
                    Entryby = table.Column<int>(nullable: true),
                    EntryDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    UpdateBy = table.Column<int>(nullable: true),
                    UpdateDate = table.Column<DateTime>(type: "datetime", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PlanDetail", x => x.PlanId);
                });

            migrationBuilder.CreateTable(
                name: "Preference",
                columns: table => new
                {
                    PreferenceId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    UserId = table.Column<int>(nullable: true),
                    PreferenceType = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
                    Status = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Preference", x => x.PreferenceId);
                });

            migrationBuilder.CreateTable(
                name: "ProposedNews",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Subject = table.Column<string>(maxLength: 250, nullable: true),
                    Author = table.Column<string>(maxLength: 150, nullable: true),
                    Edition = table.Column<string>(maxLength: 150, nullable: true),
                    Page = table.Column<int>(nullable: true),
                    Edition_Page = table.Column<string>(maxLength: 250, nullable: true),
                    Picture = table.Column<string>(maxLength: 50, nullable: true),
                    Comment = table.Column<string>(maxLength: 500, nullable: true),
                    Pubdate = table.Column<DateTime>(type: "date", nullable: true),
                    Entryby = table.Column<string>(maxLength: 50, nullable: true),
                    ad = table.Column<string>(maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProposedNews", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "RapeCase",
                columns: table => new
                {
                    RapeCaseId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    CaseDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    IncidentDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    IncidentPlace = table.Column<int>(nullable: true),
                    OtherIncidentPlace = table.Column<string>(maxLength: 500, nullable: true),
                    IncidentDetail = table.Column<string>(maxLength: 500, nullable: true),
                    DistrictId = table.Column<int>(nullable: true),
                    UpazillaId = table.Column<int>(nullable: true),
                    InfoSource = table.Column<string>(maxLength: 200, nullable: true),
                    CaseUpdateDate = table.Column<DateTime>(type: "date", nullable: true),
                    CaseUpdateStatus = table.Column<int>(nullable: true),
                    ContactInfo = table.Column<string>(maxLength: 200, nullable: true),
                    IsMainConvictFugitive = table.Column<bool>(nullable: false),
                    MainConvictArrestDate = table.Column<DateTime>(type: "date", nullable: true),
                    TotalConvictedCount = table.Column<int>(nullable: true),
                    Comment = table.Column<string>(maxLength: 500, nullable: true),
                    CreatedBy = table.Column<string>(unicode: false, maxLength: 100, nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    UpdatedBy = table.Column<string>(unicode: false, maxLength: 100, nullable: true),
                    UpdatedDate = table.Column<DateTime>(type: "datetime", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RapeCase", x => x.RapeCaseId);
                });

            migrationBuilder.CreateTable(
                name: "RapeCaseDetail",
                columns: table => new
                {
                    RapeCaseDetailId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    RapeCaseId = table.Column<int>(nullable: false),
                    ConvictName = table.Column<string>(maxLength: 200, nullable: true),
                    ConvictAge = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
                    ConvictIdentityOrRelationship = table.Column<string>(maxLength: 200, nullable: true),
                    ConvictsOccupation = table.Column<string>(maxLength: 200, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RapeCaseDetail", x => x.RapeCaseDetailId);
                });

            migrationBuilder.CreateTable(
                name: "RapeCaseDetailVictim",
                columns: table => new
                {
                    RapeCaseVictimId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    RapeCaseId = table.Column<int>(nullable: false),
                    VictimsName = table.Column<string>(maxLength: 500, nullable: true),
                    VictimsAge = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
                    VictimsCondition = table.Column<string>(maxLength: 50, nullable: true),
                    VictimsOccupation = table.Column<string>(maxLength: 200, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RapeCaseDetailVictim", x => x.RapeCaseVictimId);
                });

            migrationBuilder.CreateTable(
                name: "RapeCaseStatus",
                columns: table => new
                {
                    CaseStatusId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    CaseStatus = table.Column<string>(maxLength: 200, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RapeCaseStatus", x => x.CaseStatusId);
                });

            migrationBuilder.CreateTable(
                name: "RapeIncidentPlace",
                columns: table => new
                {
                    IncidentPlaceId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    IncidentPlace = table.Column<string>(maxLength: 100, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RapeIncidentPlace", x => x.IncidentPlaceId);
                });

            migrationBuilder.CreateTable(
                name: "ReporterSection",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    SectionName = table.Column<string>(maxLength: 100, nullable: false),
                    Sorting = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ReporterSection", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "ReporterSMS",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    AssignmentId = table.Column<int>(nullable: true),
                    Status = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
                    SMSSendTime = table.Column<string>(unicode: false, maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ReporterSMS", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ReporterStory",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    StoryHeading = table.Column<string>(nullable: true),
                    StoryBody = table.Column<string>(nullable: true),
                    EntryDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    UserId = table.Column<int>(nullable: true),
                    StoryType = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
                    SubmitDesk = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
                    StoryCode = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
                    StoryDate = table.Column<DateTime>(type: "date", nullable: true),
                    Media = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
                    Status = table.Column<int>(nullable: true),
                    Keyword = table.Column<string>(unicode: false, maxLength: 150, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ReporterStory", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ServicePermission",
                columns: table => new
                {
                    ServiceId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    ServiceName = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
                    UserId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ServicePermission", x => x.ServiceId);
                });

            migrationBuilder.CreateTable(
                name: "SMSLog",
                columns: table => new
                {
                    SmsId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    SMSText = table.Column<string>(unicode: false, maxLength: 160, nullable: true),
                    SMSTo = table.Column<int>(nullable: true),
                    SMSSendBy = table.Column<int>(nullable: true),
                    EntryTime = table.Column<DateTime>(type: "datetime", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SMSLog", x => x.SmsId);
                });

            migrationBuilder.CreateTable(
                name: "SMSQue",
                columns: table => new
                {
                    SmsId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    SmsType = table.Column<string>(unicode: false, maxLength: 100, nullable: true),
                    MobileNo = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
                    EmpId = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
                    SmsBody = table.Column<string>(maxLength: 500, nullable: true),
                    Status = table.Column<bool>(nullable: true),
                    ProcessedTime = table.Column<DateTime>(type: "datetime", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SMSQue", x => x.SmsId);
                });

            migrationBuilder.CreateTable(
                name: "Story",
                columns: table => new
                {
                    StoryId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    StoryHeading = table.Column<string>(maxLength: 500, nullable: true),
                    StoryBody = table.Column<string>(nullable: true),
                    StoryWord = table.Column<int>(nullable: true),
                    EntryBy = table.Column<int>(nullable: true),
                    EntryDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    UpdateDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    NewswrapCode = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
                    Status = table.Column<int>(nullable: true),
                    StoryDate = table.Column<DateTime>(type: "date", nullable: true),
                    StoryDesk = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
                    Keyword = table.Column<string>(maxLength: 250, nullable: true),
                    ApprovalStatus = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
                    PublishedWord = table.Column<int>(nullable: true),
                    StoryVersion = table.Column<int>(nullable: true),
                    TransferStoryCode = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
                    ApprovedTime = table.Column<DateTime>(type: "datetime", nullable: true),
                    UploadTime = table.Column<DateTime>(type: "datetime", nullable: true),
                    ApprovalCheck = table.Column<int>(nullable: true),
                    PageCheck = table.Column<int>(nullable: true),
                    LastHeading = table.Column<string>(maxLength: 500, nullable: true),
                    SaveMSWord = table.Column<int>(nullable: true),
                    UserCode = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
                    StoryType = table.Column<string>(maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Story", x => x.StoryId);
                });

            migrationBuilder.CreateTable(
                name: "StoryPage",
                columns: table => new
                {
                    StoryPageId = table.Column<decimal>(type: "numeric(18, 0)", nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    StoryId = table.Column<int>(nullable: true),
                    EditionId = table.Column<int>(nullable: true),
                    PageNo = table.Column<int>(nullable: true),
                    Flown = table.Column<string>(unicode: false, maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_StoryPage", x => x.StoryPageId);
                });

            migrationBuilder.CreateTable(
                name: "tbl_Deskincharge_Report",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    DeskIncharge = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
                    Subordinates = table.Column<string>(unicode: false, maxLength: 500, nullable: true),
                    Comment = table.Column<string>(unicode: false, maxLength: 250, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tbl_Deskincharge_Report", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "tbl_Object",
                columns: table => new
                {
                    ObjectId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    ObjectName = table.Column<string>(unicode: false, maxLength: 150, nullable: true),
                    ObjectDes = table.Column<string>(unicode: false, maxLength: 150, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tbl_Object", x => x.ObjectId);
                });

            migrationBuilder.CreateTable(
                name: "tbl_ObjectRole",
                columns: table => new
                {
                    RoleObjectId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    ObjectId = table.Column<int>(nullable: true),
                    RoleId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tbl_RoleObject", x => x.RoleObjectId);
                });

            migrationBuilder.CreateTable(
                name: "tbl_Role",
                columns: table => new
                {
                    RoleId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    RoleName = table.Column<string>(unicode: false, maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tbl_Role", x => x.RoleId);
                });

            migrationBuilder.CreateTable(
                name: "tbl_User",
                columns: table => new
                {
                    UserId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    UserCode = table.Column<string>(unicode: false, maxLength: 10, nullable: false),
                    FirstName = table.Column<string>(maxLength: 50, nullable: false),
                    LastName = table.Column<string>(maxLength: 50, nullable: false),
                    EmailAddress = table.Column<string>(unicode: false, maxLength: 50, nullable: false),
                    MobileNo = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
                    DesignationId = table.Column<int>(nullable: false),
                    UserName = table.Column<string>(unicode: false, maxLength: 50, nullable: false),
                    Password = table.Column<string>(maxLength: 100, nullable: true),
                    EntryBy = table.Column<int>(nullable: true),
                    EntryDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    UpdateBy = table.Column<int>(nullable: true),
                    UpdateDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    IsReporter = table.Column<int>(nullable: true),
                    GroupId = table.Column<int>(nullable: true),
                    Holiday = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
                    NewswrapCode = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
                    NewswrapDesk = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
                    NewswrapCenter = table.Column<int>(nullable: true),
                    AreaId = table.Column<int>(nullable: true),
                    BishalGroup = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
                    Address = table.Column<string>(maxLength: 500, nullable: true),
                    DistrictNameId = table.Column<int>(nullable: true),
                    UpazillaNameId = table.Column<int>(nullable: true),
                    IsMohanogor = table.Column<int>(nullable: true),
                    ReportGroup = table.Column<string>(maxLength: 100, nullable: true),
                    ReportOrder = table.Column<int>(nullable: true),
                    ApprovePermission = table.Column<int>(nullable: true),
                    SectionID = table.Column<int>(nullable: true),
                    IsPhotoHead = table.Column<bool>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tbl_User", x => x.UserId);
                });

            migrationBuilder.CreateTable(
                name: "tbl_UserRole",
                columns: table => new
                {
                    UserRoleId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    RoleId = table.Column<int>(nullable: true),
                    UserId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tbl_UserRole", x => x.UserRoleId);
                });

            migrationBuilder.CreateTable(
                name: "Upazila",
                columns: table => new
                {
                    UpazilaNameId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    UpazilaName = table.Column<string>(maxLength: 150, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Upazila", x => x.UpazilaNameId);
                });

            migrationBuilder.CreateTable(
                name: "UserGroup",
                columns: table => new
                {
                    GroupId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    GroupName = table.Column<string>(unicode: false, maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserGroup", x => x.GroupId);
                });

            migrationBuilder.CreateTable(
                name: "VideoSummary",
                columns: table => new
                {
                    Id = table.Column<decimal>(type: "numeric(18, 0)", nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    VideoName = table.Column<string>(unicode: false, maxLength: 150, nullable: true),
                    VideoPath = table.Column<string>(unicode: false, maxLength: 550, nullable: true),
                    UserId = table.Column<int>(nullable: true),
                    CenterCode = table.Column<int>(nullable: true),
                    VideoDate = table.Column<DateTime>(type: "date", nullable: true),
                    Description = table.Column<string>(nullable: true),
                    VideoSize = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
                    EntryDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    UpdateDate = table.Column<DateTime>(type: "datetime", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_VideoSummary", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_AC_AccidentDetail",
                table: "AC_AccidentDetail",
                columns: new[] { "AccidentId", "AccidentTypeId" },
                unique: true,
                filter: "[AccidentId] IS NOT NULL AND [AccidentTypeId] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "AssignmentDateIndex",
                table: "Assignment",
                column: "AssignmentDate");

            migrationBuilder.CreateIndex(
                name: "IX_EL_ElectionArea",
                table: "EL_ElectionArea",
                column: "ElectionAreaName",
                unique: true,
                filter: "[ElectionAreaName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_EL_ElectionArea_1",
                table: "EL_ElectionArea",
                columns: new[] { "ElectionAreaSerial", "ElectionId" },
                unique: true,
                filter: "[ElectionAreaSerial] IS NOT NULL AND [ElectionId] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_EL_Person",
                table: "EL_Person",
                column: "PersonName",
                unique: true,
                filter: "[PersonName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_PhotoAll",
                table: "PhotoAll",
                columns: new[] { "PhotoDate", "UserId", "PhotoName" },
                unique: true,
                filter: "[PhotoDate] IS NOT NULL AND [UserId] IS NOT NULL AND [PhotoName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "PhotodateIndex",
                table: "PhotoSummary",
                column: "PhotoDate");

            migrationBuilder.CreateIndex(
                name: "IX_PhotoSummary",
                table: "PhotoSummary",
                columns: new[] { "PhotoDate", "UserId", "PhotoName" },
                unique: true,
                filter: "[PhotoDate] IS NOT NULL AND [UserId] IS NOT NULL AND [PhotoName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "uq_ServicePermission",
                table: "ServicePermission",
                columns: new[] { "ServiceName", "UserId" },
                unique: true,
                filter: "[ServiceName] IS NOT NULL AND [UserId] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "StoryDateIndex",
                table: "Story",
                column: "StoryDate");

            migrationBuilder.CreateIndex(
                name: "NWCodeUni",
                table: "tbl_User",
                column: "NewswrapCode",
                unique: true,
                filter: "[NewswrapCode] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "UserUnique",
                table: "tbl_User",
                column: "UserName",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_VideoSummary",
                table: "VideoSummary",
                columns: new[] { "VideoDate", "UserId", "VideoName" },
                unique: true,
                filter: "[VideoDate] IS NOT NULL AND [UserId] IS NOT NULL AND [VideoName] IS NOT NULL");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AC_Accident");

            migrationBuilder.DropTable(
                name: "AC_AccidentDetail");

            migrationBuilder.DropTable(
                name: "AC_AccidentType");

            migrationBuilder.DropTable(
                name: "AC_AccidentVictim");

            migrationBuilder.DropTable(
                name: "AC_VehichleType");

            migrationBuilder.DropTable(
                name: "ActivityDetail");

            migrationBuilder.DropTable(
                name: "ANIEntry");

            migrationBuilder.DropTable(
                name: "Area");

            migrationBuilder.DropTable(
                name: "AreaPermission");

            migrationBuilder.DropTable(
                name: "Assignment");

            migrationBuilder.DropTable(
                name: "AssignmentDetail");

            migrationBuilder.DropTable(
                name: "AssignmentPhotographer");

            migrationBuilder.DropTable(
                name: "AssignmentType");

            migrationBuilder.DropTable(
                name: "CS_CaseSummary");

            migrationBuilder.DropTable(
                name: "DCSMS");

            migrationBuilder.DropTable(
                name: "DCTask");

            migrationBuilder.DropTable(
                name: "DCTaskSDetail");

            migrationBuilder.DropTable(
                name: "DeletedUser");

            migrationBuilder.DropTable(
                name: "Designation");

            migrationBuilder.DropTable(
                name: "DeskPermission");

            migrationBuilder.DropTable(
                name: "DigiSecurityActAccused");

            migrationBuilder.DropTable(
                name: "DigiSecurityActVictim");

            migrationBuilder.DropTable(
                name: "DigiSecurityActWitness");

            migrationBuilder.DropTable(
                name: "DigitalSecurityActCase");

            migrationBuilder.DropTable(
                name: "District");

            migrationBuilder.DropTable(
                name: "DW_Edition");

            migrationBuilder.DropTable(
                name: "DW_Employee");

            migrationBuilder.DropTable(
                name: "DW_GuestAuthorStory");

            migrationBuilder.DropTable(
                name: "DW_LastStoryPagewise");

            migrationBuilder.DropTable(
                name: "DW_LastStoryVersion");

            migrationBuilder.DropTable(
                name: "DW_LogTime");

            migrationBuilder.DropTable(
                name: "DW_OnlineContribution");

            migrationBuilder.DropTable(
                name: "DW_PageWiseStory");

            migrationBuilder.DropTable(
                name: "DW_PhotoReport");

            migrationBuilder.DropTable(
                name: "DW_Story_Summary_Breakdown");

            migrationBuilder.DropTable(
                name: "DW_StoryTye");

            migrationBuilder.DropTable(
                name: "DW_UserWiseStory");

            migrationBuilder.DropTable(
                name: "DW_VersionWordCount");

            migrationBuilder.DropTable(
                name: "EL_Area");

            migrationBuilder.DropTable(
                name: "EL_AreaAssignment");

            migrationBuilder.DropTable(
                name: "EL_Asset");

            migrationBuilder.DropTable(
                name: "EL_Case");

            migrationBuilder.DropTable(
                name: "El_CentralPolitician");

            migrationBuilder.DropTable(
                name: "EL_District");

            migrationBuilder.DropTable(
                name: "EL_Division");

            migrationBuilder.DropTable(
                name: "EL_Education");

            migrationBuilder.DropTable(
                name: "EL_EducationType");

            migrationBuilder.DropTable(
                name: "EL_Election");

            migrationBuilder.DropTable(
                name: "EL_ElectionArea");

            migrationBuilder.DropTable(
                name: "EL_ElectionAreaDetail");

            migrationBuilder.DropTable(
                name: "EL_ElectionAreaHistory");

            migrationBuilder.DropTable(
                name: "EL_FamilyPolitician");

            migrationBuilder.DropTable(
                name: "EL_IncidentDetail");

            migrationBuilder.DropTable(
                name: "EL_Income");

            migrationBuilder.DropTable(
                name: "EL_InternalClash");

            migrationBuilder.DropTable(
                name: "EL_Liability");

            migrationBuilder.DropTable(
                name: "EL_MinorityAttack");

            migrationBuilder.DropTable(
                name: "EL_MinorityVoterCount");

            migrationBuilder.DropTable(
                name: "EL_Nomination");

            migrationBuilder.DropTable(
                name: "EL_Occupation");

            migrationBuilder.DropTable(
                name: "EL_OccupationType");

            migrationBuilder.DropTable(
                name: "EL_OneEleven");

            migrationBuilder.DropTable(
                name: "EL_OnJamanotBajeapto");

            migrationBuilder.DropTable(
                name: "EL_OnResult");

            migrationBuilder.DropTable(
                name: "EL_OnResultUponirbachon");

            migrationBuilder.DropTable(
                name: "EL_OnVoterInfo");

            migrationBuilder.DropTable(
                name: "EL_Person");

            migrationBuilder.DropTable(
                name: "EL_PersonCase");

            migrationBuilder.DropTable(
                name: "EL_PersonPartyHistory");

            migrationBuilder.DropTable(
                name: "EL_PoliticalParty");

            migrationBuilder.DropTable(
                name: "EL_ProbableNomination");

            migrationBuilder.DropTable(
                name: "EL_SpecialCase");

            migrationBuilder.DropTable(
                name: "EL_Suspension");

            migrationBuilder.DropTable(
                name: "EL_TempPerson");

            migrationBuilder.DropTable(
                name: "EL_Upload");

            migrationBuilder.DropTable(
                name: "EL_VoterCount");

            migrationBuilder.DropTable(
                name: "EmailCC");

            migrationBuilder.DropTable(
                name: "EmailLog");

            migrationBuilder.DropTable(
                name: "EmailQue");

            migrationBuilder.DropTable(
                name: "EmployeeWork");

            migrationBuilder.DropTable(
                name: "Event");

            migrationBuilder.DropTable(
                name: "GroupPermission");

            migrationBuilder.DropTable(
                name: "MamsIdData");

            migrationBuilder.DropTable(
                name: "NCenter");

            migrationBuilder.DropTable(
                name: "NewswrapDesk");

            migrationBuilder.DropTable(
                name: "PhotoAll");

            migrationBuilder.DropTable(
                name: "PhotoSelection");

            migrationBuilder.DropTable(
                name: "PhotoSummary");

            migrationBuilder.DropTable(
                name: "PlanDetail");

            migrationBuilder.DropTable(
                name: "Preference");

            migrationBuilder.DropTable(
                name: "ProposedNews");

            migrationBuilder.DropTable(
                name: "RapeCase");

            migrationBuilder.DropTable(
                name: "RapeCaseDetail");

            migrationBuilder.DropTable(
                name: "RapeCaseDetailVictim");

            migrationBuilder.DropTable(
                name: "RapeCaseStatus");

            migrationBuilder.DropTable(
                name: "RapeIncidentPlace");

            migrationBuilder.DropTable(
                name: "ReporterSection");

            migrationBuilder.DropTable(
                name: "ReporterSMS");

            migrationBuilder.DropTable(
                name: "ReporterStory");

            migrationBuilder.DropTable(
                name: "ServicePermission");

            migrationBuilder.DropTable(
                name: "SMSLog");

            migrationBuilder.DropTable(
                name: "SMSQue");

            migrationBuilder.DropTable(
                name: "Story");

            migrationBuilder.DropTable(
                name: "StoryPage");

            migrationBuilder.DropTable(
                name: "tbl_Deskincharge_Report");

            migrationBuilder.DropTable(
                name: "tbl_Object");

            migrationBuilder.DropTable(
                name: "tbl_ObjectRole");

            migrationBuilder.DropTable(
                name: "tbl_Role");

            migrationBuilder.DropTable(
                name: "tbl_User");

            migrationBuilder.DropTable(
                name: "tbl_UserRole");

            migrationBuilder.DropTable(
                name: "Upazila");

            migrationBuilder.DropTable(
                name: "UserGroup");

            migrationBuilder.DropTable(
                name: "VideoSummary");
        }
    }
}
