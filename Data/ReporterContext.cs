using System;
using EditorApp.API.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace EditorApp.API.Data
{
    public partial class ReporterContext : DbContext
    {
        public ReporterContext()
        {
        }

        public ReporterContext(DbContextOptions<ReporterContext> options)
            : base(options)
        {
        }

        public virtual DbSet<View_StorySearch> View_StorySearch { get; set; }
        public virtual DbSet<AcAccident> AcAccident { get; set; }
        public virtual DbSet<AcAccidentDetail> AcAccidentDetail { get; set; }
        public virtual DbSet<AcAccidentType> AcAccidentType { get; set; }
        public virtual DbSet<AcAccidentVictim> AcAccidentVictim { get; set; }
        public virtual DbSet<AcVehichleType> AcVehichleType { get; set; }
        public virtual DbSet<ActivityDetail> ActivityDetail { get; set; }
        public virtual DbSet<Anientry> Anientry { get; set; }
        public virtual DbSet<Area> Area { get; set; }
        public virtual DbSet<AreaPermission> AreaPermission { get; set; }
        public virtual DbSet<Assignment> Assignment { get; set; }
        public virtual DbSet<AssignmentDetail> AssignmentDetail { get; set; }
        public virtual DbSet<AssignmentPhotographer> AssignmentPhotographer { get; set; }
        public virtual DbSet<AssignmentType> AssignmentType { get; set; }
        public virtual DbSet<CsCaseSummary> CsCaseSummary { get; set; }
        public virtual DbSet<Dcsms> Dcsms { get; set; }
        public virtual DbSet<Dctask> Dctask { get; set; }
        public virtual DbSet<DctaskSdetail> DctaskSdetail { get; set; }
        public virtual DbSet<DeletedUser> DeletedUser { get; set; }
        public virtual DbSet<Designation> Designation { get; set; }
        public virtual DbSet<DeskPermission> DeskPermission { get; set; }
        public virtual DbSet<DigiSecurityActAccused> DigiSecurityActAccused { get; set; }
        public virtual DbSet<DigiSecurityActVictim> DigiSecurityActVictim { get; set; }
        public virtual DbSet<DigiSecurityActWitness> DigiSecurityActWitness { get; set; }
        public virtual DbSet<DigitalSecurityActCase> DigitalSecurityActCase { get; set; }
        public virtual DbSet<District> District { get; set; }
        public virtual DbSet<DwEdition> DwEdition { get; set; }
        public virtual DbSet<DwEmployee> DwEmployee { get; set; }
        public virtual DbSet<DwGuestAuthorStory> DwGuestAuthorStory { get; set; }
        public virtual DbSet<DwLastStoryPagewise> DwLastStoryPagewise { get; set; }
        public virtual DbSet<DwLastStoryVersion> DwLastStoryVersion { get; set; }
        public virtual DbSet<DwLogTime> DwLogTime { get; set; }
        public virtual DbSet<DwOnlineContribution> DwOnlineContribution { get; set; }
        public virtual DbSet<DwPageWiseStory> DwPageWiseStory { get; set; }
        public virtual DbSet<DwPhotoReport> DwPhotoReport { get; set; }
        public virtual DbSet<DwStorySummaryBreakdown> DwStorySummaryBreakdown { get; set; }
        public virtual DbSet<DwStoryTye> DwStoryTye { get; set; }
        public virtual DbSet<DwUserWiseStory> DwUserWiseStory { get; set; }
        public virtual DbSet<DwVersionWordCount> DwVersionWordCount { get; set; }
        public virtual DbSet<ElArea> ElArea { get; set; }
        public virtual DbSet<ElAreaAssignment> ElAreaAssignment { get; set; }
        public virtual DbSet<ElAsset> ElAsset { get; set; }
        public virtual DbSet<ElCase> ElCase { get; set; }
        public virtual DbSet<ElCentralPolitician> ElCentralPolitician { get; set; }
        public virtual DbSet<ElDistrict> ElDistrict { get; set; }
        public virtual DbSet<ElDivision> ElDivision { get; set; }
        public virtual DbSet<ElEducation> ElEducation { get; set; }
        public virtual DbSet<ElEducationType> ElEducationType { get; set; }
        public virtual DbSet<ElElection> ElElection { get; set; }
        public virtual DbSet<ElElectionArea> ElElectionArea { get; set; }
        public virtual DbSet<ElElectionAreaDetail> ElElectionAreaDetail { get; set; }
        public virtual DbSet<ElElectionAreaHistory> ElElectionAreaHistory { get; set; }
        public virtual DbSet<ElFamilyPolitician> ElFamilyPolitician { get; set; }
        public virtual DbSet<ElIncidentDetail> ElIncidentDetail { get; set; }
        public virtual DbSet<ElIncome> ElIncome { get; set; }
        public virtual DbSet<ElInternalClash> ElInternalClash { get; set; }
        public virtual DbSet<ElLiability> ElLiability { get; set; }
        public virtual DbSet<ElMinorityAttack> ElMinorityAttack { get; set; }
        public virtual DbSet<ElMinorityVoterCount> ElMinorityVoterCount { get; set; }
        public virtual DbSet<ElNomination> ElNomination { get; set; }
        public virtual DbSet<ElOccupation> ElOccupation { get; set; }
        public virtual DbSet<ElOccupationType> ElOccupationType { get; set; }
        public virtual DbSet<ElOnJamanotBajeapto> ElOnJamanotBajeapto { get; set; }
        public virtual DbSet<ElOnResult> ElOnResult { get; set; }
        public virtual DbSet<ElOnResultUponirbachon> ElOnResultUponirbachon { get; set; }
        public virtual DbSet<ElOnVoterInfo> ElOnVoterInfo { get; set; }
        public virtual DbSet<ElOneEleven> ElOneEleven { get; set; }
        public virtual DbSet<ElPerson> ElPerson { get; set; }
        public virtual DbSet<ElPersonCase> ElPersonCase { get; set; }
        public virtual DbSet<ElPersonPartyHistory> ElPersonPartyHistory { get; set; }
        public virtual DbSet<ElPoliticalParty> ElPoliticalParty { get; set; }
        public virtual DbSet<ElProbableNomination> ElProbableNomination { get; set; }
        public virtual DbSet<ElSpecialCase> ElSpecialCase { get; set; }
        public virtual DbSet<ElSuspension> ElSuspension { get; set; }
        public virtual DbSet<ElTempPerson> ElTempPerson { get; set; }
        public virtual DbSet<ElUpload> ElUpload { get; set; }
        public virtual DbSet<ElVoterCount> ElVoterCount { get; set; }
        public virtual DbSet<EmailCc> EmailCc { get; set; }
        public virtual DbSet<EmailLog> EmailLog { get; set; }
        public virtual DbSet<EmailQue> EmailQue { get; set; }
        public virtual DbSet<EmployeeWork> EmployeeWork { get; set; }
        public virtual DbSet<Event> Event { get; set; }
        public virtual DbSet<GroupPermission> GroupPermission { get; set; }
        public virtual DbSet<MamsIdData> MamsIdData { get; set; }
        public virtual DbSet<Ncenter> Ncenter { get; set; }
        public virtual DbSet<NewswrapDesk> NewswrapDesk { get; set; }
        public virtual DbSet<PhotoAll> PhotoAll { get; set; }
        public virtual DbSet<PhotoSelection> PhotoSelection { get; set; }
        public virtual DbSet<PhotoSummary> PhotoSummary { get; set; }
        public virtual DbSet<PlanDetail> PlanDetail { get; set; }
        public virtual DbSet<Preference> Preference { get; set; }
        public virtual DbSet<ProposedNews> ProposedNews { get; set; }
        public virtual DbSet<RapeCase> RapeCase { get; set; }
        public virtual DbSet<RapeCaseDetail> RapeCaseDetail { get; set; }
        public virtual DbSet<RapeCaseDetailVictim> RapeCaseDetailVictim { get; set; }
        public virtual DbSet<RapeCaseStatus> RapeCaseStatus { get; set; }
        public virtual DbSet<RapeIncidentPlace> RapeIncidentPlace { get; set; }
        public virtual DbSet<ReporterSection> ReporterSection { get; set; }
        public virtual DbSet<ReporterSms> ReporterSms { get; set; }
        public virtual DbSet<ReporterStory> ReporterStory { get; set; }
        public virtual DbSet<ServicePermission> ServicePermission { get; set; }
        public virtual DbSet<Smslog> Smslog { get; set; }
        public virtual DbSet<Smsque> Smsque { get; set; }
        public virtual DbSet<Story> Story { get; set; }
        public virtual DbSet<StoryPage> StoryPage { get; set; }
        public virtual DbSet<TblDeskinchargeReport> TblDeskinchargeReport { get; set; }
        public virtual DbSet<TblObject> TblObject { get; set; }
        public virtual DbSet<TblObjectRole> TblObjectRole { get; set; }
        public virtual DbSet<TblRole> TblRole { get; set; }
        public virtual DbSet<TblUser> TblUser { get; set; }
        public virtual DbSet<TblUserRole> TblUserRole { get; set; }
        public virtual DbSet<Upazila> Upazila { get; set; }
        public virtual DbSet<UserGroup> UserGroup { get; set; }
        public virtual DbSet<VideoSummary> VideoSummary { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                // #warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseSqlServer("data source=paloreportdbs.palonet.org;initial catalog=Reporter;Trusted_Connection=True;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("ProductVersion", "2.2.6-servicing-10079");

            modelBuilder.Entity<View_StorySearch>(entity =>
            {
                entity.HasKey(e => e.StoryId);

                entity.Property(e => e.StoryHeading).HasMaxLength(500);

                entity.Property(e => e.EntryDate).HasColumnType("datetime");

                entity.Property(e => e.StoryDate).HasColumnType("date");

                entity.Property(e => e.StoryDesk)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Keyword).HasMaxLength(250);

                entity.Property(e => e.UserCode)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.StoryType).HasMaxLength(50);

                entity.Property(e => e.ldapint)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.displayname)
                    .HasColumnName("displayname")
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.CenterName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

            });

            modelBuilder.Entity<AcAccident>(entity =>
            {
                entity.HasKey(e => e.AccidentId);

                entity.ToTable("AC_Accident");

                entity.Property(e => e.AccidentSummary).HasMaxLength(500);

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.DateofAccident).HasColumnType("date");

                entity.Property(e => e.HighwayCode).HasMaxLength(50);

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.TypeofRoad).HasMaxLength(50);
            });

            modelBuilder.Entity<AcAccidentDetail>(entity =>
            {
                entity.HasKey(e => e.AccidentDetailId);

                entity.ToTable("AC_AccidentDetail");

                entity.HasIndex(e => new { e.AccidentId, e.AccidentTypeId })
                    .HasName("IX_AC_AccidentDetail")
                    .IsUnique();
            });

            modelBuilder.Entity<AcAccidentType>(entity =>
            {
                entity.HasKey(e => e.AccidentTypeId);

                entity.ToTable("AC_AccidentType");

                entity.Property(e => e.AccidentTypeName).HasMaxLength(500);

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");
            });

            modelBuilder.Entity<AcAccidentVictim>(entity =>
            {
                entity.HasKey(e => e.AccidentVictimId);

                entity.ToTable("AC_AccidentVictim");

                entity.Property(e => e.Gender)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.InjuredorKilled)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Name).HasMaxLength(150);
            });

            modelBuilder.Entity<AcVehichleType>(entity =>
            {
                entity.HasKey(e => e.VehichleTypeId);

                entity.ToTable("AC_VehichleType");

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.VehichleCategory).HasMaxLength(50);

                entity.Property(e => e.VehichleTypeName).HasMaxLength(50);
            });

            modelBuilder.Entity<ActivityDetail>(entity =>
            {
                entity.HasKey(e => e.ActivityId);

                entity.Property(e => e.ActivityId)
                    .HasColumnType("numeric(18, 0)")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.ActivityDescription)
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.EntryDate).HasColumnType("datetime");

                entity.Property(e => e.Heading).HasMaxLength(500);
            });

            modelBuilder.Entity<Anientry>(entity =>
            {
                entity.HasKey(e => e.AniNewsId)
                    .HasName("PK_ANI_NewsEntry");

                entity.ToTable("ANIEntry");

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.FileName).HasMaxLength(500);

                entity.Property(e => e.NewsName).HasMaxLength(500);
            });

            modelBuilder.Entity<Area>(entity =>
            {
                entity.Property(e => e.AreaName).HasMaxLength(50);

                entity.Property(e => e.EmailCc)
                    .HasColumnName("EmailCC")
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.MobileCc)
                    .HasColumnName("MobileCC")
                    .HasMaxLength(150)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Assignment>(entity =>
            {
                entity.HasIndex(e => e.AssignmentDate)
                    .HasName("AssignmentDateIndex");

                entity.Property(e => e.AssgingmentSubject).HasMaxLength(550);

                entity.Property(e => e.AssignedDate).HasColumnType("datetime");

                entity.Property(e => e.AssignmentDate).HasColumnType("date");

                entity.Property(e => e.AssignmentOrganization).HasMaxLength(550);

                entity.Property(e => e.AssignmentPersonality).HasMaxLength(550);

                entity.Property(e => e.AssignmentPlace).HasMaxLength(550);

                entity.Property(e => e.EmployeeCode)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.EndTime)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.PictureNeed).HasMaxLength(50);

                entity.Property(e => e.SpecialNote).HasMaxLength(1500);

                entity.Property(e => e.StartTime)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.UpdateDate).HasColumnType("datetime");
            });

            modelBuilder.Entity<AssignmentDetail>(entity =>
            {
                entity.HasKey(e => e.AssignmenDetailtId);

                entity.Property(e => e.Latitude)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Longitude)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.PlaceofReply)
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.ReplyMessage).HasMaxLength(150);

                entity.Property(e => e.ReplyTime).HasColumnType("datetime");
            });

            modelBuilder.Entity<AssignmentPhotographer>(entity =>
            {
                entity.Property(e => e.AssignedDate).HasColumnType("datetime");

                entity.Property(e => e.AssignedPgid).HasColumnName("AssignedPGId");
            });

            modelBuilder.Entity<AssignmentType>(entity =>
            {
                entity.Property(e => e.AssignmentTypeName).HasMaxLength(50);
            });

            modelBuilder.Entity<CsCaseSummary>(entity =>
            {
                entity.HasKey(e => e.CaseId);

                entity.ToTable("CS_CaseSummary");

                entity.Property(e => e.ArrestedPerson).HasMaxLength(150);

                entity.Property(e => e.CaseClosedViaMedia)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.CaseDate).HasColumnType("date");

                entity.Property(e => e.CaseDetails).HasMaxLength(250);

                entity.Property(e => e.CaseFiledAgainstAddress).HasMaxLength(500);

                entity.Property(e => e.CaseFiledAgainstAge)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CaseFiledAgainstName).HasMaxLength(150);

                entity.Property(e => e.CaseFiledAgainstPoliticalIdentity).HasMaxLength(150);

                entity.Property(e => e.CaseFiledAgainstType)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CaseFiledByDesignation).HasMaxLength(100);

                entity.Property(e => e.CaseFiledByName).HasMaxLength(150);

                entity.Property(e => e.CaseFiledType)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CaseSection).HasMaxLength(250);

                entity.Property(e => e.CaseThanaName)
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.ChargeSheetDate).HasColumnType("date");

                entity.Property(e => e.ChargeSheetPerson).HasMaxLength(150);

                entity.Property(e => e.CreatedDate).HasColumnType("date");

                entity.Property(e => e.ModifiedDate).HasColumnType("date");
            });

            modelBuilder.Entity<Dcsms>(entity =>
            {
                entity.ToTable("DCSMS");

                entity.Property(e => e.MobileNo)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SmssendTime)
                    .HasColumnName("SMSSendTime")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Smstext)
                    .HasColumnName("SMSText")
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.Status)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Dctask>(entity =>
            {
                entity.HasKey(e => e.TaskId);

                entity.ToTable("DCTask");

                entity.Property(e => e.AssignedTime).HasColumnType("datetime");

                entity.Property(e => e.TaskDetail).HasMaxLength(3500);

                entity.Property(e => e.TaskSubject).HasMaxLength(250);
            });

            modelBuilder.Entity<DctaskSdetail>(entity =>
            {
                entity.HasKey(e => e.TaskDetailId)
                    .HasName("PK_DCTaskDetail");

                entity.ToTable("DCTaskSDetail");

                entity.Property(e => e.ReplyText).HasMaxLength(1500);

                entity.Property(e => e.ReplyTime).HasColumnType("datetime");
            });

            modelBuilder.Entity<DeletedUser>(entity =>
            {
                entity.HasKey(e => e.AutoId);

                entity.Property(e => e.Address).HasMaxLength(500);

                entity.Property(e => e.DeleteDate).HasColumnType("date");

                entity.Property(e => e.EmailAddress)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.FullName).HasMaxLength(500);

                entity.Property(e => e.MobileNo)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.UserGroup).HasMaxLength(500);

                entity.Property(e => e.UserName)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Designation>(entity =>
            {
                entity.Property(e => e.DesignationName).HasMaxLength(150);
            });

            modelBuilder.Entity<DeskPermission>(entity =>
            {
                entity.Property(e => e.DeskCode)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<DigiSecurityActAccused>(entity =>
            {
                entity.HasKey(e => e.DigiSecurityAccusedId);

                entity.Property(e => e.DigiSecurityAccusedAge).HasMaxLength(50);
            });

            modelBuilder.Entity<DigiSecurityActVictim>(entity =>
            {
                entity.HasKey(e => e.DigiSecurityVictimId);

                entity.Property(e => e.DigiSecurityVictimAge).HasMaxLength(50);
            });

            modelBuilder.Entity<DigiSecurityActWitness>(entity =>
            {
                entity.HasKey(e => e.DigiSecurityWitnessId);

                entity.Property(e => e.DigiSecurityWitnessAge).HasMaxLength(50);
            });

            modelBuilder.Entity<DigitalSecurityActCase>(entity =>
            {
                entity.Property(e => e.CommentFir).HasColumnName("CommentFIR");

                entity.Property(e => e.CreatedBy)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.DigitalCaseDate).HasColumnType("datetime");

                entity.Property(e => e.EditedBy)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.EditedDate).HasColumnType("datetime");

                entity.Property(e => e.Io).HasColumnName("IO");

                entity.Property(e => e.Oc).HasColumnName("OC");

                entity.Property(e => e.Ro).HasColumnName("RO");

                entity.Property(e => e.SerialNo).HasMaxLength(50);
            });

            modelBuilder.Entity<District>(entity =>
            {
                entity.HasKey(e => e.DistrictNameId);

                entity.Property(e => e.DistrictName).HasMaxLength(150);
            });

            modelBuilder.Entity<DwEdition>(entity =>
            {
                entity.HasKey(e => e.AutoId);

                entity.ToTable("DW_Edition");

                entity.Property(e => e.EditionName).HasMaxLength(50);
            });

            modelBuilder.Entity<DwEmployee>(entity =>
            {
                entity.HasKey(e => e.Employeecode);

                entity.ToTable("DW_Employee");

                entity.Property(e => e.Employeecode)
                    .HasColumnName("employeecode")
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .ValueGeneratedNever();

                entity.Property(e => e.Deskcode).HasColumnName("deskcode");

                entity.Property(e => e.Displayname)
                    .HasColumnName("displayname")
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.Groupcode).HasColumnName("groupcode");

                entity.Property(e => e.Id).ValueGeneratedOnAdd();

                entity.Property(e => e.Ldapint)
                    .HasColumnName("ldapint")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Publicationcode).HasColumnName("publicationcode");

                entity.Property(e => e.Reportingdesk)
                    .HasColumnName("reportingdesk")
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<DwGuestAuthorStory>(entity =>
            {
                entity.ToTable("DW_GuestAuthorStory");

                entity.Property(e => e.ActionBy)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.AuthorName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Desk)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.DisplayName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Flag)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Heading).HasMaxLength(500);

                entity.Property(e => e.Publication)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.StoryDate).HasColumnType("datetime");

                entity.Property(e => e.Storycode)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<DwLastStoryPagewise>(entity =>
            {
                entity.HasKey(e => e.AutoId);

                entity.ToTable("DW_LastStoryPagewise");

                entity.Property(e => e.EditionCode)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.StoryCode)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.StoryDate).HasColumnType("date");

                entity.Property(e => e.StoryTime).HasColumnType("datetime");
            });

            modelBuilder.Entity<DwLastStoryVersion>(entity =>
            {
                entity.HasKey(e => e.AutoId)
                    .HasName("PK_DW_LastStoryVersion_1");

                entity.ToTable("DW_LastStoryVersion");

                entity.Property(e => e.LastHeading).HasMaxLength(4000);

                entity.Property(e => e.StoryCode)
                    .IsRequired()
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<DwLogTime>(entity =>
            {
                entity.HasKey(e => e.AutoId);

                entity.ToTable("DW_LogTime");

                entity.Property(e => e.EmployeeCode)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.LoginDate).HasColumnType("date");
            });

            modelBuilder.Entity<DwOnlineContribution>(entity =>
            {
                entity.ToTable("DW_OnlineContribution");

                entity.Property(e => e.Contributor).HasMaxLength(200);

                entity.Property(e => e.DeskFrom)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Heading).HasMaxLength(500);

                entity.Property(e => e.NewStoryCode)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.StoryCode)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.TransferDate).HasColumnType("datetime");

                entity.Property(e => e.TransferedBy)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<DwPageWiseStory>(entity =>
            {
                entity.HasKey(e => e.AutoId);

                entity.ToTable("DW_PageWiseStory");

                entity.Property(e => e.FlowStatus)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.StoryCode)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.StoryDate).HasColumnType("date");
            });

            modelBuilder.Entity<DwPhotoReport>(entity =>
            {
                entity.ToTable("DW_PhotoReport");

                entity.Property(e => e.Employeecode)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Name).HasMaxLength(250);

                entity.Property(e => e.PhotoDate).HasColumnType("date");
            });

            modelBuilder.Entity<DwStorySummaryBreakdown>(entity =>
            {
                entity.ToTable("DW_Story_Summary_Breakdown");

                entity.Property(e => e.Displayname).HasMaxLength(250);

                entity.Property(e => e.Employeecode)
                    .HasColumnName("employeecode")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Remark)
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.StoryDate).HasColumnType("date");
            });

            modelBuilder.Entity<DwStoryTye>(entity =>
            {
                entity.ToTable("DW_StoryTye");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Deskcode).HasColumnName("deskcode");

                entity.Property(e => e.Employeecode)
                    .HasColumnName("employeecode")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Storycode)
                    .IsRequired()
                    .HasColumnName("storycode")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Storydate)
                    .HasColumnName("storydate")
                    .HasColumnType("datetime");

                entity.Property(e => e.Type)
                    .HasColumnName("type")
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<DwUserWiseStory>(entity =>
            {
                entity.HasKey(e => e.AutoId)
                    .HasName("PK_DW_UserWiseStory_1");

                entity.ToTable("DW_UserWiseStory");

                entity.Property(e => e.EmployeeCode)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.Status).HasMaxLength(50);

                entity.Property(e => e.StoryCode)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.StoryDate).HasColumnType("datetime");
            });

            modelBuilder.Entity<DwVersionWordCount>(entity =>
            {
                entity.HasKey(e => new { e.StoryCode, e.Version });

                entity.ToTable("DW_VersionWordCount");

                entity.Property(e => e.StoryCode).HasMaxLength(50);

                entity.Property(e => e.Author)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Owner)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Status)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Storydate).HasColumnType("datetime");

                entity.Property(e => e.WordCountId).ValueGeneratedOnAdd();
            });

            modelBuilder.Entity<ElArea>(entity =>
            {
                entity.HasKey(e => e.AreaId);

                entity.ToTable("EL_Area");

                entity.Property(e => e.AreaName).HasMaxLength(250);
            });

            modelBuilder.Entity<ElAreaAssignment>(entity =>
            {
                entity.HasKey(e => e.AreaAssignmentId);

                entity.ToTable("EL_AreaAssignment");

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");
            });

            modelBuilder.Entity<ElAsset>(entity =>
            {
                entity.HasKey(e => e.AssetId);

                entity.ToTable("EL_Asset");

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.DependentAsset).HasMaxLength(50);

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.PersonName).HasMaxLength(500);

                entity.Property(e => e.SelfAsset).HasMaxLength(50);
            });

            modelBuilder.Entity<ElCase>(entity =>
            {
                entity.HasKey(e => e.CaseId);

                entity.ToTable("EL_Case");

                entity.Property(e => e.PreviousCase).HasMaxLength(10);
            });

            modelBuilder.Entity<ElCentralPolitician>(entity =>
            {
                entity.HasKey(e => e.CentralPoliticianId);

                entity.ToTable("El_CentralPolitician");

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.CurrentDesignation).HasMaxLength(500);

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.PersonName).HasMaxLength(500);
            });

            modelBuilder.Entity<ElDistrict>(entity =>
            {
                entity.HasKey(e => e.DistrictId);

                entity.ToTable("EL_District");

                entity.Property(e => e.DistrictName).HasMaxLength(50);

                entity.Property(e => e.DistrictNameEn)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<ElDivision>(entity =>
            {
                entity.HasKey(e => e.DivisionId);

                entity.ToTable("EL_Division");

                entity.Property(e => e.DivisionName).HasMaxLength(50);
            });

            modelBuilder.Entity<ElEducation>(entity =>
            {
                entity.HasKey(e => e.EducationId);

                entity.ToTable("EL_Education");
            });

            modelBuilder.Entity<ElEducationType>(entity =>
            {
                entity.HasKey(e => e.EducationTypeId);

                entity.ToTable("EL_EducationType");

                entity.Property(e => e.EducationTypeName).HasMaxLength(50);
            });

            modelBuilder.Entity<ElElection>(entity =>
            {
                entity.HasKey(e => e.ElectionId);

                entity.ToTable("EL_Election");

                entity.Property(e => e.Comments).HasMaxLength(500);

                entity.Property(e => e.ElectionName).HasMaxLength(150);

                entity.Property(e => e.FromDate).HasColumnType("date");

                entity.Property(e => e.ToDate).HasColumnType("date");
            });

            modelBuilder.Entity<ElElectionArea>(entity =>
            {
                entity.HasKey(e => e.ElectionAreaId);

                entity.ToTable("EL_ElectionArea");

                entity.HasIndex(e => e.ElectionAreaName)
                    .HasName("IX_EL_ElectionArea")
                    .IsUnique();

                entity.HasIndex(e => new { e.ElectionAreaSerial, e.ElectionId })
                    .HasName("IX_EL_ElectionArea_1")
                    .IsUnique();

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.ElectionAreaName).HasMaxLength(50);

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.RegularorReserved).HasMaxLength(50);
            });

            modelBuilder.Entity<ElElectionAreaDetail>(entity =>
            {
                entity.HasKey(e => e.ElectionAreaDetailId);

                entity.ToTable("EL_ElectionAreaDetail");

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");
            });

            modelBuilder.Entity<ElElectionAreaHistory>(entity =>
            {
                entity.HasKey(e => e.ElectionAreaHistoryId);

                entity.ToTable("EL_ElectionAreaHistory");

                entity.Property(e => e.TotalVote).HasMaxLength(10);
            });

            modelBuilder.Entity<ElFamilyPolitician>(entity =>
            {
                entity.HasKey(e => e.FamilyPloiticianId);

                entity.ToTable("EL_FamilyPolitician");

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.CurrentDesignation).HasMaxLength(500);

                entity.Property(e => e.FamilyPoliticianName).HasMaxLength(500);

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.PersonName).HasMaxLength(500);

                entity.Property(e => e.PoliticsEntryYear).HasMaxLength(50);
            });

            modelBuilder.Entity<ElIncidentDetail>(entity =>
            {
                entity.HasKey(e => e.CurrentMpId);

                entity.ToTable("EL_IncidentDetail");

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.Description).HasMaxLength(50);

                entity.Property(e => e.Detail).HasMaxLength(50);

                entity.Property(e => e.IncidentType).HasMaxLength(50);

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.PersonName).HasMaxLength(500);
            });

            modelBuilder.Entity<ElIncome>(entity =>
            {
                entity.HasKey(e => e.IncomeId);

                entity.ToTable("EL_Income");

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.DependentIncome).HasMaxLength(50);

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.PersonName).HasMaxLength(500);

                entity.Property(e => e.SelfIncome).HasMaxLength(50);
            });

            modelBuilder.Entity<ElInternalClash>(entity =>
            {
                entity.HasKey(e => e.InternalClashId);

                entity.ToTable("EL_InternalClash");

                entity.Property(e => e.ClashDescription).HasMaxLength(500);

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.Injured).HasMaxLength(50);

                entity.Property(e => e.Killed).HasMaxLength(50);

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.SelfClash).HasMaxLength(50);
            });

            modelBuilder.Entity<ElLiability>(entity =>
            {
                entity.HasKey(e => e.LiabilityId);

                entity.ToTable("EL_Liability");

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.PersonName).HasMaxLength(500);

                entity.Property(e => e.SelfLiability).HasMaxLength(50);
            });

            modelBuilder.Entity<ElMinorityAttack>(entity =>
            {
                entity.HasKey(e => e.MinorityAttackId)
                    .HasName("PK_EL_MinorityAttach");

                entity.ToTable("EL_MinorityAttack");

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.Description).HasMaxLength(500);

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.PersonName).HasMaxLength(500);
            });

            modelBuilder.Entity<ElMinorityVoterCount>(entity =>
            {
                entity.HasKey(e => e.MinorityVoterCountId);

                entity.ToTable("EL_MinorityVoterCount");

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.UpdatedDate).HasColumnType("datetime");
            });

            modelBuilder.Entity<ElNomination>(entity =>
            {
                entity.HasKey(e => e.NominationId);

                entity.ToTable("EL_Nomination");
            });

            modelBuilder.Entity<ElOccupation>(entity =>
            {
                entity.HasKey(e => e.OccupationId);

                entity.ToTable("EL_Occupation");
            });

            modelBuilder.Entity<ElOccupationType>(entity =>
            {
                entity.HasKey(e => e.OccupationTypeId);

                entity.ToTable("EL_OccupationType");

                entity.Property(e => e.OccupationTypeName).HasMaxLength(50);

                entity.Property(e => e.OccupationTypeNameEn)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<ElOnJamanotBajeapto>(entity =>
            {
                entity.HasKey(e => e.JamanotBajeaptoId);

                entity.ToTable("EL_OnJamanotBajeapto");

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.UpdatedDate).HasColumnType("datetime");
            });

            modelBuilder.Entity<ElOnResult>(entity =>
            {
                entity.HasKey(e => e.VoteResultId);

                entity.ToTable("EL_OnResult");

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.ElectionSymbol).HasMaxLength(150);

                entity.Property(e => e.UpdatedDate).HasColumnType("datetime");
            });

            modelBuilder.Entity<ElOnResultUponirbachon>(entity =>
            {
                entity.HasKey(e => e.UponirbachonId);

                entity.ToTable("EL_OnResultUponirbachon");

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.UpdatedDate).HasColumnType("datetime");
            });

            modelBuilder.Entity<ElOnVoterInfo>(entity =>
            {
                entity.HasKey(e => e.VoterInfoId);

                entity.ToTable("EL_OnVoterInfo");

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.UpdatedDate).HasColumnType("datetime");
            });

            modelBuilder.Entity<ElOneEleven>(entity =>
            {
                entity.HasKey(e => e.OneElevenId);

                entity.ToTable("EL_OneEleven");

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.Influence).HasMaxLength(50);

                entity.Property(e => e.IsKnown).HasMaxLength(50);

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.PersonName).HasMaxLength(500);
            });

            modelBuilder.Entity<ElPerson>(entity =>
            {
                entity.HasKey(e => e.PersonId);

                entity.ToTable("EL_Person");

                entity.HasIndex(e => e.PersonName)
                    .HasName("IX_EL_Person")
                    .IsUnique();

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.FatherName).HasMaxLength(500);

                entity.Property(e => e.MotherName).HasMaxLength(500);

                entity.Property(e => e.PersonName).HasMaxLength(250);

                entity.Property(e => e.PhotoUrl).HasMaxLength(250);

                entity.Property(e => e.UpdatedDate).HasColumnType("datetime");
            });

            modelBuilder.Entity<ElPersonCase>(entity =>
            {
                entity.HasKey(e => e.PersonCaseId);

                entity.ToTable("EL_PersonCase");

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.PersonName).HasMaxLength(500);
            });

            modelBuilder.Entity<ElPersonPartyHistory>(entity =>
            {
                entity.HasKey(e => e.PersonPartyHistoryId);

                entity.ToTable("EL_PersonPartyHistory");

                entity.Property(e => e.CentralPost).HasMaxLength(500);

                entity.Property(e => e.LocalPost).HasMaxLength(500);
            });

            modelBuilder.Entity<ElPoliticalParty>(entity =>
            {
                entity.HasKey(e => e.PoliticalPartyId);

                entity.ToTable("EL_PoliticalParty");

                entity.Property(e => e.ElectionLogo).HasMaxLength(150);

                entity.Property(e => e.PoliticalPartyName).HasMaxLength(150);
            });

            modelBuilder.Entity<ElProbableNomination>(entity =>
            {
                entity.HasKey(e => e.ProbableNominationId);

                entity.ToTable("EL_ProbableNomination");

                entity.Property(e => e.Age)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.Designation).HasMaxLength(500);

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.PersonName).HasMaxLength(500);
            });

            modelBuilder.Entity<ElSpecialCase>(entity =>
            {
                entity.HasKey(e => e.SpecialCaseId);

                entity.ToTable("EL_SpecialCase");

                entity.Property(e => e.Case2014).HasMaxLength(50);

                entity.Property(e => e.Case2015).HasMaxLength(50);

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.SpecialAccused).HasMaxLength(50);

                entity.Property(e => e.Thana).HasMaxLength(500);

                entity.Property(e => e.TotalAccused).HasMaxLength(50);
            });

            modelBuilder.Entity<ElSuspension>(entity =>
            {
                entity.HasKey(e => e.SuspendId);

                entity.ToTable("EL_Suspension");

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.PersonName).HasMaxLength(500);

                entity.Property(e => e.ReturnYear).HasMaxLength(50);

                entity.Property(e => e.SuspendReason).HasMaxLength(50);

                entity.Property(e => e.SuspendYear).HasMaxLength(50);
            });

            modelBuilder.Entity<ElTempPerson>(entity =>
            {
                entity.HasKey(e => e.TempPersonId);

                entity.ToTable("EL_TempPerson");

                entity.Property(e => e.TempPersonName).HasMaxLength(500);
            });

            modelBuilder.Entity<ElUpload>(entity =>
            {
                entity.HasKey(e => e.UploadId);

                entity.ToTable("EL_Upload");

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.FileName).HasMaxLength(250);

                entity.Property(e => e.Remarks).HasMaxLength(500);
            });

            modelBuilder.Entity<ElVoterCount>(entity =>
            {
                entity.HasKey(e => e.VoterCountId);

                entity.ToTable("EL_VoterCount");

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.UpdatedDate).HasColumnType("datetime");
            });

            modelBuilder.Entity<EmailCc>(entity =>
            {
                entity.HasKey(e => e.AutoId);

                entity.ToTable("EmailCC");

                entity.Property(e => e.EmailId)
                    .HasColumnName("EmailID")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Name).HasMaxLength(150);
            });

            modelBuilder.Entity<EmailLog>(entity =>
            {
                entity.HasKey(e => e.EmailId);

                entity.Property(e => e.EntryTime).HasColumnType("datetime");
            });

            modelBuilder.Entity<EmailQue>(entity =>
            {
                entity.HasKey(e => e.EmailId);

                entity.Property(e => e.EmailAttachment)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.EmailBody).HasMaxLength(500);

                entity.Property(e => e.EmailCc)
                    .HasColumnName("EmailCC")
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.EmailReceipient)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.EmailSubject).HasMaxLength(500);

                entity.Property(e => e.EmailTitle).HasMaxLength(500);

                entity.Property(e => e.EmailType)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ProcessedTime).HasColumnType("datetime");
            });

            modelBuilder.Entity<EmployeeWork>(entity =>
            {
                entity.HasKey(e => new { e.Userid, e.Entrydate });

                entity.Property(e => e.Userid).HasColumnName("userid");

                entity.Property(e => e.Entrydate)
                    .HasColumnName("entrydate")
                    .HasColumnType("datetime");

                entity.Property(e => e.Approved).HasColumnName("approved");

                entity.Property(e => e.Comment)
                    .HasColumnName("comment")
                    .HasMaxLength(250);

                entity.Property(e => e.Day)
                    .IsRequired()
                    .HasColumnName("day")
                    .HasMaxLength(50);

                entity.Property(e => e.Edit).HasColumnName("edit");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.Selfwritten).HasColumnName("selfwritten");

                entity.Property(e => e.Translation).HasColumnName("translation");

                entity.Property(e => e.Words).HasColumnName("words");
            });

            modelBuilder.Entity<Event>(entity =>
            {
                entity.Property(e => e.EntryDate).HasColumnType("datetime");

                entity.Property(e => e.EventBar)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.EventDate).HasColumnType("date");

                entity.Property(e => e.EventDescription).HasMaxLength(500);

                entity.Property(e => e.UpdateDate).HasColumnType("datetime");
            });

            modelBuilder.Entity<MamsIdData>(entity =>
            {
                entity.HasKey(e => e.MamsId);

                entity.Property(e => e.MamsId).ValueGeneratedNever();

                entity.Property(e => e.Idno).HasColumnName("IDNo");

                entity.Property(e => e.UpdatedTime).HasColumnType("datetime");
            });

            modelBuilder.Entity<Ncenter>(entity =>
            {
                entity.HasKey(e => e.CenterCode)
                    .HasName("PK_Center");

                entity.ToTable("NCenter");

                entity.Property(e => e.CenterCode).ValueGeneratedNever();

                entity.Property(e => e.CenterName)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<NewswrapDesk>(entity =>
            {
                entity.HasKey(e => e.DeskId);

                entity.Property(e => e.DeskId).HasColumnName("DeskID");

                entity.Property(e => e.DeskCode)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.DeskName)
                    .HasMaxLength(150)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<PhotoAll>(entity =>
            {
                entity.HasIndex(e => new { e.PhotoDate, e.UserId, e.PhotoName })
                    .HasName("IX_PhotoAll")
                    .IsUnique();

                entity.Property(e => e.Id)
                    .HasColumnType("numeric(18, 0)")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.EntryDate).HasColumnType("datetime");

                entity.Property(e => e.PhotoDate).HasColumnType("date");

                entity.Property(e => e.PhotoDesk)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.PhotoName)
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.PhotoPath)
                    .HasMaxLength(550)
                    .IsUnicode(false);

                entity.Property(e => e.PhotoSize)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.UpdateDate).HasColumnType("datetime");
            });

            modelBuilder.Entity<PhotoSelection>(entity =>
            {
                entity.HasKey(e => e.Photoid);

                entity.Property(e => e.Photoid)
                    .HasColumnName("photoid")
                    .ValueGeneratedNever();

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.Selection).HasColumnName("selection");
            });

            modelBuilder.Entity<PhotoSummary>(entity =>
            {
                entity.HasIndex(e => e.PhotoDate)
                    .HasName("PhotodateIndex");

                entity.HasIndex(e => new { e.PhotoDate, e.UserId, e.PhotoName })
                    .HasName("IX_PhotoSummary")
                    .IsUnique();

                entity.Property(e => e.Id)
                    .HasColumnType("numeric(18, 0)")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.EntryDate).HasColumnType("datetime");

                entity.Property(e => e.PhotoDate).HasColumnType("date");

                entity.Property(e => e.PhotoDesk)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.PhotoName)
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.PhotoPath)
                    .HasMaxLength(550)
                    .IsUnicode(false);

                entity.Property(e => e.PhotoSize)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.UpdateDate).HasColumnType("datetime");

                entity.Property(e => e.UserCode)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<PlanDetail>(entity =>
            {
                entity.HasKey(e => e.PlanId);

                entity.Property(e => e.EntryDate).HasColumnType("datetime");

                entity.Property(e => e.PlanDate).HasColumnType("date");

                entity.Property(e => e.PlanSummary).HasMaxLength(1500);

                entity.Property(e => e.UpdateDate).HasColumnType("datetime");
            });

            modelBuilder.Entity<Preference>(entity =>
            {
                entity.Property(e => e.PreferenceType)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<ProposedNews>(entity =>
            {
                entity.Property(e => e.Ad)
                    .HasColumnName("ad")
                    .HasMaxLength(50);

                entity.Property(e => e.Author).HasMaxLength(150);

                entity.Property(e => e.Comment).HasMaxLength(500);

                entity.Property(e => e.Edition).HasMaxLength(150);

                entity.Property(e => e.EditionPage)
                    .HasColumnName("Edition_Page")
                    .HasMaxLength(250);

                entity.Property(e => e.Entryby).HasMaxLength(50);

                entity.Property(e => e.Picture).HasMaxLength(50);

                entity.Property(e => e.Pubdate).HasColumnType("date");

                entity.Property(e => e.Subject).HasMaxLength(250);
            });

            modelBuilder.Entity<RapeCase>(entity =>
            {
                entity.Property(e => e.CaseDate).HasColumnType("datetime");

                entity.Property(e => e.CaseUpdateDate).HasColumnType("date");

                entity.Property(e => e.Comment).HasMaxLength(500);

                entity.Property(e => e.ContactInfo).HasMaxLength(200);

                entity.Property(e => e.CreatedBy)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.IncidentDate).HasColumnType("datetime");

                entity.Property(e => e.IncidentDetail).HasMaxLength(500);

                entity.Property(e => e.InfoSource).HasMaxLength(200);

                entity.Property(e => e.MainConvictArrestDate).HasColumnType("date");

                entity.Property(e => e.OtherIncidentPlace).HasMaxLength(500);

                entity.Property(e => e.UpdatedBy)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.UpdatedDate).HasColumnType("datetime");
            });

            modelBuilder.Entity<RapeCaseDetail>(entity =>
            {
                entity.Property(e => e.ConvictAge)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ConvictIdentityOrRelationship).HasMaxLength(200);

                entity.Property(e => e.ConvictName).HasMaxLength(200);

                entity.Property(e => e.ConvictsOccupation).HasMaxLength(200);
            });

            modelBuilder.Entity<RapeCaseDetailVictim>(entity =>
            {
                entity.HasKey(e => e.RapeCaseVictimId);

                entity.Property(e => e.VictimsAge)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.VictimsCondition).HasMaxLength(50);

                entity.Property(e => e.VictimsName).HasMaxLength(500);

                entity.Property(e => e.VictimsOccupation).HasMaxLength(200);
            });

            modelBuilder.Entity<RapeCaseStatus>(entity =>
            {
                entity.HasKey(e => e.CaseStatusId);

                entity.Property(e => e.CaseStatus).HasMaxLength(200);
            });

            modelBuilder.Entity<RapeIncidentPlace>(entity =>
            {
                entity.HasKey(e => e.IncidentPlaceId);

                entity.Property(e => e.IncidentPlace).HasMaxLength(100);
            });

            modelBuilder.Entity<ReporterSection>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.SectionName)
                    .IsRequired()
                    .HasMaxLength(100);
            });

            modelBuilder.Entity<ReporterSms>(entity =>
            {
                entity.ToTable("ReporterSMS");

                entity.Property(e => e.SmssendTime)
                    .HasColumnName("SMSSendTime")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Status)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<ReporterStory>(entity =>
            {
                entity.Property(e => e.EntryDate).HasColumnType("datetime");

                entity.Property(e => e.Keyword)
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.Media)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.StoryCode)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.StoryDate).HasColumnType("date");

                entity.Property(e => e.StoryType)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SubmitDesk)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<ServicePermission>(entity =>
            {
                entity.HasKey(e => e.ServiceId);

                entity.HasIndex(e => new { e.ServiceName, e.UserId })
                    .HasName("uq_ServicePermission")
                    .IsUnique();

                entity.Property(e => e.ServiceName)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Smslog>(entity =>
            {
                entity.HasKey(e => e.SmsId);

                entity.ToTable("SMSLog");

                entity.Property(e => e.EntryTime).HasColumnType("datetime");

                entity.Property(e => e.SmssendBy).HasColumnName("SMSSendBy");

                entity.Property(e => e.Smstext)
                    .HasColumnName("SMSText")
                    .HasMaxLength(160)
                    .IsUnicode(false);

                entity.Property(e => e.Smsto).HasColumnName("SMSTo");
            });

            modelBuilder.Entity<Smsque>(entity =>
            {
                entity.HasKey(e => e.SmsId);

                entity.ToTable("SMSQue");

                entity.Property(e => e.EmpId)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.MobileNo)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ProcessedTime).HasColumnType("datetime");

                entity.Property(e => e.SmsBody).HasMaxLength(500);

                entity.Property(e => e.SmsType)
                    .HasMaxLength(100)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Story>(entity =>
            {
                entity.HasIndex(e => e.StoryDate)
                    .HasName("StoryDateIndex");

                entity.Property(e => e.ApprovalStatus)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ApprovedTime).HasColumnType("datetime");

                entity.Property(e => e.EntryDate).HasColumnType("datetime");

                entity.Property(e => e.Keyword).HasMaxLength(250);

                entity.Property(e => e.LastHeading).HasMaxLength(500);

                entity.Property(e => e.NewswrapCode)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SaveMsword).HasColumnName("SaveMSWord");

                entity.Property(e => e.StoryDate).HasColumnType("date");

                entity.Property(e => e.StoryDesk)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.StoryHeading).HasMaxLength(500);

                entity.Property(e => e.StoryType).HasMaxLength(50);

                entity.Property(e => e.TransferStoryCode)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.UpdateDate).HasColumnType("datetime");

                entity.Property(e => e.UploadTime).HasColumnType("datetime");

                entity.Property(e => e.UserCode)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<StoryPage>(entity =>
            {
                entity.Property(e => e.StoryPageId)
                    .HasColumnType("numeric(18, 0)")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.Flown)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TblDeskinchargeReport>(entity =>
            {
                entity.ToTable("tbl_Deskincharge_Report");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Comment)
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.DeskIncharge)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Subordinates)
                    .HasMaxLength(500)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TblObject>(entity =>
            {
                entity.HasKey(e => e.ObjectId);

                entity.ToTable("tbl_Object");

                entity.Property(e => e.ObjectDes)
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.ObjectName)
                    .HasMaxLength(150)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TblObjectRole>(entity =>
            {
                entity.HasKey(e => e.RoleObjectId)
                    .HasName("PK_tbl_RoleObject");

                entity.ToTable("tbl_ObjectRole");
            });

            modelBuilder.Entity<TblRole>(entity =>
            {
                entity.HasKey(e => e.RoleId);

                entity.ToTable("tbl_Role");

                entity.Property(e => e.RoleName)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TblUser>(entity =>
            {
                entity.HasKey(e => e.UserId);

                entity.ToTable("tbl_User");

                entity.HasIndex(e => e.NewswrapCode)
                    .HasName("NWCodeUni")
                    .IsUnique();

                entity.HasIndex(e => e.UserName)
                    .HasName("UserUnique")
                    .IsUnique();

                entity.Property(e => e.Address).HasMaxLength(500);

                entity.Property(e => e.BishalGroup)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.EmailAddress)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.EntryDate).HasColumnType("datetime");

                entity.Property(e => e.FirstName)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.Holiday)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.LastName)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.MobileNo)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.NewswrapCode)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.NewswrapDesk)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Password).HasMaxLength(100);

                entity.Property(e => e.ReportGroup).HasMaxLength(100);

                entity.Property(e => e.SectionId).HasColumnName("SectionID");

                entity.Property(e => e.UpdateDate).HasColumnType("datetime");

                entity.Property(e => e.UserCode)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.UserName)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TblUserRole>(entity =>
            {
                entity.HasKey(e => e.UserRoleId);

                entity.ToTable("tbl_UserRole");
            });

            modelBuilder.Entity<Upazila>(entity =>
            {
                entity.HasKey(e => e.UpazilaNameId);

                entity.Property(e => e.UpazilaName).HasMaxLength(150);
            });

            modelBuilder.Entity<UserGroup>(entity =>
            {
                entity.HasKey(e => e.GroupId);

                entity.Property(e => e.GroupName)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<VideoSummary>(entity =>
            {
                entity.HasIndex(e => new { e.VideoDate, e.UserId, e.VideoName })
                    .HasName("IX_VideoSummary")
                    .IsUnique();

                entity.Property(e => e.Id)
                    .HasColumnType("numeric(18, 0)")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.EntryDate).HasColumnType("datetime");

                entity.Property(e => e.UpdateDate).HasColumnType("datetime");

                entity.Property(e => e.VideoDate).HasColumnType("date");

                entity.Property(e => e.VideoName)
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.VideoPath)
                    .HasMaxLength(550)
                    .IsUnicode(false);

                entity.Property(e => e.VideoSize)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });
        }
    }
}
