using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace DatabaseFirst.Models
{
    public partial class NMSContext : DbContext
    {
        public NMSContext()
        {
        }

        public NMSContext(DbContextOptions<NMSContext> options)
            : base(options)
        {
        }

        public virtual DbSet<EtCircleDetail> EtCircleDetails { get; set; } = null!;
        public virtual DbSet<EtDeviceDetail> EtDeviceDetails { get; set; } = null!;
        public virtual DbSet<EtDivisionDetail> EtDivisionDetails { get; set; } = null!;
        public virtual DbSet<EtDtrDetail> EtDtrDetails { get; set; } = null!;
        public virtual DbSet<EtFeederDetail> EtFeederDetails { get; set; } = null!;
        public virtual DbSet<EtHierarchyLevel> EtHierarchyLevels { get; set; } = null!;
        public virtual DbSet<EtModemDetail> EtModemDetails { get; set; } = null!;
        public virtual DbSet<EtRegionDetail> EtRegionDetails { get; set; } = null!;
        public virtual DbSet<EtSectionDetail> EtSectionDetails { get; set; } = null!;
        public virtual DbSet<EtSubstationDetail> EtSubstationDetails { get; set; } = null!;
        public virtual DbSet<HtDeviceNwInteruption> HtDeviceNwInteruptions { get; set; } = null!;
        public virtual DbSet<TtDeviceNwInteruption> TtDeviceNwInteruptions { get; set; } = null!;
        public virtual DbSet<VwNm> VwNms { get; set; } = null!;
        public virtual DbSet<VwNms1> VwNms1s { get; set; } = null!;

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("Server=172.16.15.26; database=NMS; User id=sa; Password=Pa55w0rd99");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.UseCollation("Latin1_General_CI_AI");

            modelBuilder.Entity<EtCircleDetail>(entity =>
            {
                entity.HasKey(e => e.EtCircleDetails)
                    .HasName("PK_ET_CIRCLE_DETAILS_CIRCLEID");

                entity.ToTable("ET_CIRCLE_DETAILS");

                entity.HasIndex(e => e.CircleName, "UK_ET_CIRCLE_DETAILS_CIRCLENAME")
                    .IsUnique();

                entity.HasIndex(e => e.InchargeContactNumber, "UK_ET_CIRCLE_DETAILS_MOBILENO")
                    .IsUnique();

                entity.Property(e => e.EtCircleDetails).HasColumnName("ET_CIRCLE_DETAILS");

                entity.Property(e => e.CircleId).HasColumnName("CIRCLE_ID");

                entity.Property(e => e.CircleName)
                    .HasMaxLength(50)
                    .HasColumnName("CIRCLE_NAME");

                entity.Property(e => e.Crts).HasColumnName("CRTS");

                entity.Property(e => e.InchargeContactNumber)
                    .HasMaxLength(15)
                    .HasColumnName("INCHARGE_CONTACT_NUMBER");

                entity.Property(e => e.InchargeName)
                    .HasMaxLength(50)
                    .HasColumnName("INCHARGE_NAME");

                entity.Property(e => e.InchargeUserid).HasColumnName("INCHARGE_USERID");

                entity.Property(e => e.IsActive).HasColumnName("IS_ACTIVE");

                entity.Property(e => e.Latitude)
                    .HasMaxLength(10)
                    .HasColumnName("LATITUDE");

                entity.Property(e => e.Location)
                    .HasMaxLength(150)
                    .HasColumnName("LOCATION");

                entity.Property(e => e.Longitude)
                    .HasMaxLength(10)
                    .HasColumnName("LONGITUDE");

                entity.Property(e => e.RegionId).HasColumnName("REGION_ID");

                entity.Property(e => e.UserIp)
                    .HasMaxLength(16)
                    .HasColumnName("USER_IP");
            });

            modelBuilder.Entity<EtDeviceDetail>(entity =>
            {
                entity.HasKey(e => e.DeviceTid)
                    .HasName("PK_ET_DEVICE_DETAILS_1");

                entity.ToTable("ET_DEVICE_DETAILS");

                entity.HasIndex(e => e.DeviceId, "UK_DEVICE_ID")
                    .IsUnique();

                entity.Property(e => e.DeviceTid).HasColumnName("DEVICE_TID");

                entity.Property(e => e.ConnectionStatus)
                    .HasColumnName("CONNECTION_STATUS")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Crts)
                    .HasColumnName("CRTS")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.DeviceId).HasColumnName("DEVICE_ID");

                entity.Property(e => e.DeviceIp)
                    .HasMaxLength(50)
                    .HasColumnName("DEVICE_IP");

                entity.Property(e => e.DeviceName)
                    .HasMaxLength(50)
                    .HasColumnName("DEVICE_NAME");

                entity.Property(e => e.DeviceSerialNo)
                    .HasMaxLength(20)
                    .HasColumnName("DEVICE_SERIAL_NO");

                entity.Property(e => e.DeviceType)
                    .HasMaxLength(25)
                    .HasColumnName("DEVICE_TYPE");

                entity.Property(e => e.DtrId).HasColumnName("DTR_ID");

                entity.Property(e => e.IsActive)
                    .HasColumnName("IS_ACTIVE")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Landmark)
                    .HasMaxLength(150)
                    .HasColumnName("LANDMARK");

                entity.Property(e => e.Latitude)
                    .HasMaxLength(15)
                    .HasColumnName("LATITUDE");

                entity.Property(e => e.Location)
                    .HasMaxLength(150)
                    .HasColumnName("LOCATION");

                entity.Property(e => e.Longitude)
                    .HasMaxLength(15)
                    .HasColumnName("LONGITUDE");

                entity.HasOne(d => d.Dtr)
                    .WithMany(p => p.EtDeviceDetails)
                    .HasPrincipalKey(p => p.DtrId)
                    .HasForeignKey(d => d.DtrId)
                    .HasConstraintName("FK_ET_DEVICE_DETAILS_DTR_ID");
            });

            modelBuilder.Entity<EtDivisionDetail>(entity =>
            {
                entity.HasKey(e => e.EtDivisionId);

                entity.ToTable("ET_DIVISION_DETAILS");

                entity.HasIndex(e => e.DivisionId, "UK_ET_DIVISION_DETAILS")
                    .IsUnique();

                entity.Property(e => e.EtDivisionId).HasColumnName("ET_DIVISION_ID");

                entity.Property(e => e.CircleId).HasColumnName("CIRCLE_ID");

                entity.Property(e => e.Crts)
                    .HasColumnName("CRTS")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.DivisionId).HasColumnName("DIVISION_ID");

                entity.Property(e => e.DivisionName)
                    .HasMaxLength(50)
                    .HasColumnName("DIVISION_NAME");

                entity.Property(e => e.InchargeContactNumber)
                    .HasMaxLength(15)
                    .HasColumnName("INCHARGE_CONTACT_NUMBER");

                entity.Property(e => e.InchargeName)
                    .HasMaxLength(50)
                    .HasColumnName("INCHARGE_NAME");

                entity.Property(e => e.InchargeUserid).HasColumnName("INCHARGE_USERID");

                entity.Property(e => e.IsActive).HasColumnName("IS_ACTIVE");

                entity.Property(e => e.LocationName)
                    .HasMaxLength(50)
                    .HasColumnName("LOCATION_NAME");

                entity.Property(e => e.UserIp)
                    .HasMaxLength(16)
                    .HasColumnName("USER_IP");
            });

            modelBuilder.Entity<EtDtrDetail>(entity =>
            {
                entity.HasKey(e => e.EtDtrId);

                entity.ToTable("ET_DTR_DETAILS");

                entity.HasIndex(e => e.DtrId, "UK_ET_DTR_DETAILS_DTRID")
                    .IsUnique();

                entity.HasIndex(e => e.StructureCode, "UK_ET_DTR_DETAILS_STRUCTURE_CODE")
                    .IsUnique()
                    .HasFilter("([STRUCTURE_CODE] IS NOT NULL)");

                entity.HasIndex(e => e.TransformerSno, "UK_ET_DTR_DETAILS_TRANSFORMER_SNO")
                    .IsUnique();

                entity.Property(e => e.EtDtrId).HasColumnName("ET_DTR_ID");

                entity.Property(e => e.Capacity).HasColumnName("CAPACITY");

                entity.Property(e => e.Crts)
                    .HasColumnName("CRTS")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.DtrId).HasColumnName("DTR_ID");

                entity.Property(e => e.FeederId).HasColumnName("FEEDER_ID");

                entity.Property(e => e.IsActive).HasColumnName("IS_ACTIVE");

                entity.Property(e => e.Latitude)
                    .HasMaxLength(10)
                    .HasColumnName("LATITUDE");

                entity.Property(e => e.Location)
                    .HasMaxLength(150)
                    .HasColumnName("LOCATION");

                entity.Property(e => e.Longitude)
                    .HasMaxLength(10)
                    .HasColumnName("LONGITUDE");

                entity.Property(e => e.MountType)
                    .HasMaxLength(15)
                    .HasColumnName("MOUNT_TYPE");

                entity.Property(e => e.Ratio)
                    .HasMaxLength(5)
                    .HasColumnName("RATIO");

                entity.Property(e => e.StructureCode)
                    .HasMaxLength(16)
                    .HasColumnName("STRUCTURE_CODE");

                entity.Property(e => e.TransformerSno)
                    .HasMaxLength(16)
                    .HasColumnName("TRANSFORMER_SNO");

                entity.Property(e => e.TransformerType)
                    .HasMaxLength(15)
                    .HasColumnName("TRANSFORMER_TYPE");

                entity.Property(e => e.UtilityRefno)
                    .HasMaxLength(16)
                    .HasColumnName("UTILITY_REFNO");

                entity.HasOne(d => d.Feeder)
                    .WithMany(p => p.EtDtrDetails)
                    .HasPrincipalKey(p => p.FeederId)
                    .HasForeignKey(d => d.FeederId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ET_DTR_DETAILS_FEEDER_ID");
            });

            modelBuilder.Entity<EtFeederDetail>(entity =>
            {
                entity.HasKey(e => e.EtFeederId);

                entity.ToTable("ET_FEEDER_DETAILS");

                entity.HasIndex(e => e.FeederId, "UK_ET_FEEDER_DETAILS_FEEDERID")
                    .IsUnique();

                entity.HasIndex(e => e.FeederName, "UK_ET_FEEDER_DETAILS_FEEDER_NAME")
                    .IsUnique();

                entity.Property(e => e.EtFeederId).HasColumnName("ET_FEEDER_ID");

                entity.Property(e => e.Crts)
                    .HasColumnName("CRTS")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.FeederId).HasColumnName("FEEDER_ID");

                entity.Property(e => e.FeederName)
                    .HasMaxLength(50)
                    .HasColumnName("FEEDER_NAME");

                entity.Property(e => e.FeederType)
                    .HasMaxLength(50)
                    .HasColumnName("FEEDER_TYPE");

                entity.Property(e => e.InchargeContactNumber)
                    .HasMaxLength(15)
                    .HasColumnName("INCHARGE_CONTACT_NUMBER");

                entity.Property(e => e.InchargeName)
                    .HasMaxLength(50)
                    .HasColumnName("INCHARGE_NAME");

                entity.Property(e => e.IsActive).HasColumnName("IS_ACTIVE");

                entity.Property(e => e.Latitude)
                    .HasMaxLength(10)
                    .HasColumnName("LATITUDE");

                entity.Property(e => e.Location)
                    .HasMaxLength(150)
                    .HasColumnName("LOCATION");

                entity.Property(e => e.Longitude)
                    .HasMaxLength(10)
                    .HasColumnName("LONGITUDE");

                entity.Property(e => e.SubstationId).HasColumnName("SUBSTATION_ID");

                entity.Property(e => e.UserIp)
                    .HasMaxLength(16)
                    .HasColumnName("USER_IP");

                entity.HasOne(d => d.Substation)
                    .WithMany(p => p.EtFeederDetails)
                    .HasPrincipalKey(p => p.SubstationId)
                    .HasForeignKey(d => d.SubstationId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ET_FEEDER_DETAILS_SUBSTATION_ID");
            });

            modelBuilder.Entity<EtHierarchyLevel>(entity =>
            {
                entity.ToTable("ET_HIERARCHY_LEVEL");

                entity.HasIndex(e => e.LevelName, "UK_ET_HIERARCHY_LEVEL_NAME")
                    .IsUnique();

                entity.HasIndex(e => e.InchargeContactNumber, "UK_ET_HIERARCHY_LEVEL_PHONE")
                    .IsUnique();

                entity.Property(e => e.EtHierarchyLevelId).HasColumnName("ET_HIERARCHY_LEVEL_ID");

                entity.Property(e => e.EmailId)
                    .HasMaxLength(100)
                    .HasColumnName("EMAIL_ID");

                entity.Property(e => e.InchargeContactNumber).HasColumnName("INCHARGE_CONTACT_NUMBER");

                entity.Property(e => e.InchargeName)
                    .HasMaxLength(50)
                    .HasColumnName("INCHARGE_NAME");

                entity.Property(e => e.IsActive).HasColumnName("IS_ACTIVE");

                entity.Property(e => e.Latitude)
                    .HasMaxLength(16)
                    .HasColumnName("LATITUDE");

                entity.Property(e => e.LevelId).HasColumnName("LEVEL_ID");

                entity.Property(e => e.LevelName)
                    .HasMaxLength(100)
                    .HasColumnName("LEVEL_NAME");

                entity.Property(e => e.LevelType)
                    .HasMaxLength(50)
                    .HasColumnName("LEVEL_TYPE");

                entity.Property(e => e.Location)
                    .HasMaxLength(250)
                    .HasColumnName("LOCATION");

                entity.Property(e => e.Longitude)
                    .HasMaxLength(16)
                    .HasColumnName("LONGITUDE");

                entity.Property(e => e.Sts)
                    .HasColumnName("STS")
                    .HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<EtModemDetail>(entity =>
            {
                entity.HasKey(e => e.ModemId);

                entity.ToTable("ET_MODEM_DETAILS");

                entity.Property(e => e.ModemId).HasColumnName("MODEM_ID");

                entity.Property(e => e.DeviceId).HasColumnName("DEVICE_ID");

                entity.Property(e => e.IsActive)
                    .IsRequired()
                    .HasColumnName("IS_ACTIVE")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.ModemAddress)
                    .HasMaxLength(50)
                    .HasColumnName("MODEM_ADDRESS");

                entity.Property(e => e.Status)
                    .HasColumnName("STATUS")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.Sts)
                    .HasColumnName("STS")
                    .HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<EtRegionDetail>(entity =>
            {
                entity.HasKey(e => e.EtRegionId);

                entity.ToTable("ET_REGION_DETAILS");

                entity.HasIndex(e => e.RegionId, "UK_ET_REGION_DETAILS")
                    .IsUnique();

                entity.HasIndex(e => e.RegionName, "UK_ET_REGION_DETAILS_REGION_NAME")
                    .IsUnique();

                entity.Property(e => e.EtRegionId).HasColumnName("ET_REGION_ID");

                entity.Property(e => e.Crts)
                    .HasColumnName("CRTS")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Districts)
                    .HasMaxLength(50)
                    .HasColumnName("DISTRICTS");

                entity.Property(e => e.InchargeContactNumber)
                    .HasMaxLength(15)
                    .HasColumnName("INCHARGE_CONTACT_NUMBER");

                entity.Property(e => e.InchargeName)
                    .HasMaxLength(50)
                    .HasColumnName("INCHARGE_NAME");

                entity.Property(e => e.InchargeUserid).HasColumnName("INCHARGE_USERID");

                entity.Property(e => e.IsActive)
                    .HasColumnName("IS_ACTIVE")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Latitude)
                    .HasMaxLength(10)
                    .HasColumnName("LATITUDE");

                entity.Property(e => e.Location)
                    .HasMaxLength(150)
                    .HasColumnName("LOCATION");

                entity.Property(e => e.Longitude)
                    .HasMaxLength(10)
                    .HasColumnName("LONGITUDE");

                entity.Property(e => e.RegionCode)
                    .HasMaxLength(50)
                    .HasColumnName("REGION_CODE");

                entity.Property(e => e.RegionId).HasColumnName("REGION_ID");

                entity.Property(e => e.RegionName)
                    .HasMaxLength(50)
                    .HasColumnName("REGION_NAME");

                entity.Property(e => e.TotalConsumers).HasColumnName("TOTAL_CONSUMERS");

                entity.Property(e => e.UserIp)
                    .HasMaxLength(16)
                    .HasColumnName("USER_IP");
            });

            modelBuilder.Entity<EtSectionDetail>(entity =>
            {
                entity.HasKey(e => e.EtSectionId);

                entity.ToTable("ET_SECTION_DETAILS");

                entity.HasIndex(e => e.SectionId, "UK_ET_SECTION_DETAILS_SECTIONID")
                    .IsUnique();

                entity.Property(e => e.EtSectionId).HasColumnName("ET_SECTION_ID");

                entity.Property(e => e.Crts)
                    .HasColumnName("CRTS")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.DivisionId).HasColumnName("DIVISION_ID");

                entity.Property(e => e.InchargeMobileNumber)
                    .HasMaxLength(15)
                    .HasColumnName("INCHARGE_MOBILE_NUMBER");

                entity.Property(e => e.InchargeName)
                    .HasMaxLength(50)
                    .HasColumnName("INCHARGE_NAME");

                entity.Property(e => e.InchargeUserid).HasColumnName("INCHARGE_USERID");

                entity.Property(e => e.IsActive).HasColumnName("IS_ACTIVE");

                entity.Property(e => e.Latitude)
                    .HasMaxLength(10)
                    .HasColumnName("LATITUDE");

                entity.Property(e => e.Location)
                    .HasMaxLength(150)
                    .HasColumnName("LOCATION");

                entity.Property(e => e.Longitude)
                    .HasMaxLength(10)
                    .HasColumnName("LONGITUDE");

                entity.Property(e => e.SectionId).HasColumnName("SECTION_ID");

                entity.Property(e => e.SectionName)
                    .HasMaxLength(50)
                    .HasColumnName("SECTION_NAME");

                entity.Property(e => e.UserIp)
                    .HasMaxLength(16)
                    .HasColumnName("USER_IP");

                entity.HasOne(d => d.Division)
                    .WithMany(p => p.EtSectionDetails)
                    .HasPrincipalKey(p => p.DivisionId)
                    .HasForeignKey(d => d.DivisionId)
                    .HasConstraintName("FK_ET_SECTION_DETAILS_DIVISION_ID");
            });

            modelBuilder.Entity<EtSubstationDetail>(entity =>
            {
                entity.HasKey(e => e.EtSubstationId);

                entity.ToTable("ET_SUBSTATION_DETAILS");

                entity.HasIndex(e => e.SubstationId, "UK_ET_SUBSTATION_DETAILS_SUBSTATIONID")
                    .IsUnique();

                entity.HasIndex(e => e.SubstationName, "UK_ET_SUBSTATION_DETAILS_SUBSTATION_NAME")
                    .IsUnique();

                entity.Property(e => e.EtSubstationId).HasColumnName("ET_SUBSTATION_ID");

                entity.Property(e => e.Crts)
                    .HasColumnName("CRTS")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.InchargeContactNumber)
                    .HasMaxLength(15)
                    .HasColumnName("INCHARGE_CONTACT_NUMBER");

                entity.Property(e => e.InchargeName)
                    .HasMaxLength(50)
                    .HasColumnName("INCHARGE_NAME");

                entity.Property(e => e.InchargeUserid).HasColumnName("INCHARGE_USERID");

                entity.Property(e => e.IsActive).HasColumnName("IS_ACTIVE");

                entity.Property(e => e.Latitude)
                    .HasMaxLength(10)
                    .HasColumnName("LATITUDE");

                entity.Property(e => e.Location)
                    .HasMaxLength(150)
                    .HasColumnName("LOCATION");

                entity.Property(e => e.Longitude)
                    .HasMaxLength(10)
                    .HasColumnName("LONGITUDE");

                entity.Property(e => e.SectionId).HasColumnName("SECTION_ID");

                entity.Property(e => e.SubstationId).HasColumnName("SUBSTATION_ID");

                entity.Property(e => e.SubstationName)
                    .HasMaxLength(50)
                    .HasColumnName("SUBSTATION_NAME");

                entity.Property(e => e.UserIp)
                    .HasMaxLength(16)
                    .HasColumnName("USER_IP");

                entity.HasOne(d => d.Section)
                    .WithMany(p => p.EtSubstationDetails)
                    .HasPrincipalKey(p => p.SectionId)
                    .HasForeignKey(d => d.SectionId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ET_SUBSTATION_DETAILS_SECTION_ID");
            });

            modelBuilder.Entity<HtDeviceNwInteruption>(entity =>
            {
                entity.HasKey(e => e.HtId);

                entity.ToTable("HT_DEVICE_NW_INTERUPTION");

                entity.Property(e => e.HtId).HasColumnName("HT_Id");

                entity.Property(e => e.DeviceId).HasColumnName("DEVICE_ID");

                entity.Property(e => e.DeviceIp)
                    .HasMaxLength(50)
                    .HasColumnName("DEVICE_IP");

                entity.Property(e => e.NwIntEnd).HasColumnName("NW_int_End");

                entity.Property(e => e.NwIntStart).HasColumnName("NW_int_start");

                entity.Property(e => e.Sts)
                    .HasColumnName("STS")
                    .HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<TtDeviceNwInteruption>(entity =>
            {
                entity.HasKey(e => e.TtId);

                entity.ToTable("TT_DEVICE_NW_INTERUPTION");

                entity.Property(e => e.TtId).HasColumnName("TT_id");

                entity.Property(e => e.DeviceId).HasColumnName("DEVICE_ID");

                entity.Property(e => e.DeviceIp)
                    .HasMaxLength(50)
                    .HasColumnName("DEVICE_IP");

                entity.Property(e => e.NwIntEnd).HasColumnName("NW_int_End");

                entity.Property(e => e.NwIntStart)
                    .HasColumnName("NW_int_start")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Sts)
                    .HasColumnName("STS")
                    .HasDefaultValueSql("(getdate())");

                entity.HasOne(d => d.Device)
                    .WithMany(p => p.TtDeviceNwInteruptions)
                    .HasPrincipalKey(p => p.DeviceId)
                    .HasForeignKey(d => d.DeviceId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_TT_DEVICE_NW_INTERUPTION_DEVICEID");
            });

            modelBuilder.Entity<VwNm>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("VW_NMS");

                entity.Property(e => e.Connected).HasColumnName("CONNECTED");

                entity.Property(e => e.DeviceIp)
                    .HasMaxLength(50)
                    .HasColumnName("DEVICE_IP");

                entity.Property(e => e.DeviceName)
                    .HasMaxLength(50)
                    .HasColumnName("DEVICE_NAME");

                entity.Property(e => e.DeviceSerialNo)
                    .HasMaxLength(20)
                    .HasColumnName("DEVICE_SERIAL_NO");

                entity.Property(e => e.Disconnected).HasColumnName("DISCONNECTED");

                entity.Property(e => e.InNetwork).HasColumnName(" IN Network");

                entity.Property(e => e.IsActive).HasColumnName("IS_ACTIVE");

                entity.Property(e => e.NotInNetwork).HasColumnName(" Not In Network");

                entity.Property(e => e.NwIntEnd).HasColumnName("NW_int_End");

                entity.Property(e => e.NwIntStart).HasColumnName("NW_int_start");

                entity.Property(e => e.TransformerSno)
                    .HasMaxLength(16)
                    .HasColumnName("TRANSFORMER_SNO");
            });

            modelBuilder.Entity<VwNms1>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vw_nms1");

                entity.Property(e => e.DeviceIp)
                    .HasMaxLength(50)
                    .HasColumnName("DEVICE_IP");

                entity.Property(e => e.NwIntStart).HasColumnName("NW_int_start");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
