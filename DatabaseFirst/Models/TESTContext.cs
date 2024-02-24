using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace DatabaseFirst.Models
{
    public partial class TESTContext : DbContext
    {
        public TESTContext()
        {
        }

        public TESTContext(DbContextOptions<TESTContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Abc1> Abc1s { get; set; } = null!;
        public virtual DbSet<ActiveDirectory> ActiveDirectories { get; set; } = null!;
        public virtual DbSet<ActiveDirectory1> ActiveDirectory1s { get; set; } = null!;
        public virtual DbSet<Agent> Agents { get; set; } = null!;
        public virtual DbSet<Agentsview> Agentsviews { get; set; } = null!;
        public virtual DbSet<AlekyaActiveDirectory> AlekyaActiveDirectories { get; set; } = null!;
        public virtual DbSet<AnilActiveDirectory> AnilActiveDirectories { get; set; } = null!;
        public virtual DbSet<Anji> Anjis { get; set; } = null!;
        public virtual DbSet<Anji1> Anji1s { get; set; } = null!;
        public virtual DbSet<AspNetUserClaim> AspNetUserClaims { get; set; } = null!;
        public virtual DbSet<AspNetUserRole> AspNetUserRoles { get; set; } = null!;
        public virtual DbSet<Bi> Bis { get; set; } = null!;
        public virtual DbSet<Bi1> Bi1s { get; set; } = null!;
        public virtual DbSet<Bi2> Bi2s { get; set; } = null!;
        public virtual DbSet<BiTeam> BiTeams { get; set; } = null!;
        public virtual DbSet<Book> Books { get; set; } = null!;
        public virtual DbSet<Car> Cars { get; set; } = null!;
        public virtual DbSet<Car1> Cars1 { get; set; } = null!;
        public virtual DbSet<ChaitanyaActiveDirectory> ChaitanyaActiveDirectories { get; set; } = null!;
        public virtual DbSet<City> Cities { get; set; } = null!;
        public virtual DbSet<Commanddetail> Commanddetails { get; set; } = null!;
        public virtual DbSet<Configuration> Configurations { get; set; } = null!;
        public virtual DbSet<ConnectedNnotConnected> ConnectedNnotConnecteds { get; set; } = null!;
        public virtual DbSet<Country> Countries { get; set; } = null!;
        public virtual DbSet<Crud> Cruds { get; set; } = null!;
        public virtual DbSet<Customer> Customers { get; set; } = null!;
        public virtual DbSet<Customer4> Customer4s { get; set; } = null!;
        public virtual DbSet<CustomerDatum> CustomerData { get; set; } = null!;
        public virtual DbSet<Customers1> Customers1s { get; set; } = null!;
        public virtual DbSet<Customers2> Customers2s { get; set; } = null!;
        public virtual DbSet<Customers22> Customers22s { get; set; } = null!;
        public virtual DbSet<Dataparamdt> Dataparamdts { get; set; } = null!;
        public virtual DbSet<DeepikaActiveDirectory> DeepikaActiveDirectories { get; set; } = null!;
        public virtual DbSet<Dell> Dells { get; set; } = null!;
        public virtual DbSet<Dell1> Dell1s { get; set; } = null!;
        public virtual DbSet<Demo> Demos { get; set; } = null!;
        public virtual DbSet<DepartmentName> DepartmentNames { get; set; } = null!;
        public virtual DbSet<Dept2> Dept2s { get; set; } = null!;
        public virtual DbSet<DetailsEmp> DetailsEmps { get; set; } = null!;
        public virtual DbSet<Districctinfoo> Districctinfoos { get; set; } = null!;
        public virtual DbSet<Districctinfoo1> Districctinfoo1s { get; set; } = null!;
        public virtual DbSet<Districtinfo> Districtinfos { get; set; } = null!;
        public virtual DbSet<EDetali> EDetalis { get; set; } = null!;
        public virtual DbSet<EDetalis1> EDetalis1s { get; set; } = null!;
        public virtual DbSet<EficaaBi> EficaaBis { get; set; } = null!;
        public virtual DbSet<Emp> Emps { get; set; } = null!;
        public virtual DbSet<Emp1> Emp1s { get; set; } = null!;
        public virtual DbSet<Emp10> Emp10s { get; set; } = null!;
        public virtual DbSet<Emp11> Emp1s1 { get; set; } = null!;
        public virtual DbSet<Emp2> Emp2s { get; set; } = null!;
        public virtual DbSet<EmpDetail> EmpDetails { get; set; } = null!;
        public virtual DbSet<Employee0> Employee0s { get; set; } = null!;
        public virtual DbSet<Employee123> Employee123s { get; set; } = null!;
        public virtual DbSet<EmployeeDetail> EmployeeDetails { get; set; } = null!;
        public virtual DbSet<EmployeeDetails3> EmployeeDetails3s { get; set; } = null!;
        public virtual DbSet<EmployeeView1> EmployeeView1s { get; set; } = null!;
        public virtual DbSet<EmployeeView2> EmployeeView2s { get; set; } = null!;
        public virtual DbSet<EmployeeView3> EmployeeView3s { get; set; } = null!;
        public virtual DbSet<EmployeeView4> EmployeeView4s { get; set; } = null!;
        public virtual DbSet<Employees1> Employees1s { get; set; } = null!;
        public virtual DbSet<EtConsumerDetail> EtConsumerDetails { get; set; } = null!;
        public virtual DbSet<EtDcuDetail> EtDcuDetails { get; set; } = null!;
        public virtual DbSet<EtInterfaceTypeDetail> EtInterfaceTypeDetails { get; set; } = null!;
        public virtual DbSet<EtManufacturerDetail> EtManufacturerDetails { get; set; } = null!;
        public virtual DbSet<EtMeterDetail> EtMeterDetails { get; set; } = null!;
        public virtual DbSet<EtMeterTypeDetail> EtMeterTypeDetails { get; set; } = null!;
        public virtual DbSet<EtNopDetail> EtNopDetails { get; set; } = null!;
        public virtual DbSet<EtPrivilegeDetail> EtPrivilegeDetails { get; set; } = null!;
        public virtual DbSet<EtRoleDetail> EtRoleDetails { get; set; } = null!;
        public virtual DbSet<EtRolePrivRelDetail> EtRolePrivRelDetails { get; set; } = null!;
        public virtual DbSet<EtServiceDetail> EtServiceDetails { get; set; } = null!;
        public virtual DbSet<EtSimDetail> EtSimDetails { get; set; } = null!;
        public virtual DbSet<EtUserDetail> EtUserDetails { get; set; } = null!;
        public virtual DbSet<EtUserRoleRelDetail> EtUserRoleRelDetails { get; set; } = null!;
        public virtual DbSet<FemaleEmployee> FemaleEmployees { get; set; } = null!;
        public virtual DbSet<Food> Foods { get; set; } = null!;
        public virtual DbSet<Gl70> Gl70s { get; set; } = null!;
        public virtual DbSet<Gl701> Gl701s { get; set; } = null!;
        public virtual DbSet<Gl70network> Gl70networks { get; set; } = null!;
        public virtual DbSet<Gl70network1> Gl70networks1 { get; set; } = null!;
        public virtual DbSet<Gl70network11> Gl70network11s { get; set; } = null!;
        public virtual DbSet<GrtEmp> GrtEmps { get; set; } = null!;
        public virtual DbSet<Hardware> Hardwares { get; set; } = null!;
        public virtual DbSet<Hierarcy> Hierarcies { get; set; } = null!;
        public virtual DbSet<HirerarchyLevel> HirerarchyLevels { get; set; } = null!;
        public virtual DbSet<HtDataParamTmultct> HtDataParamTmultcts { get; set; } = null!;
        public virtual DbSet<InputDataFile> InputDataFiles { get; set; } = null!;
        public virtual DbSet<Interval> Intervals { get; set; } = null!;
        public virtual DbSet<Level> Levels { get; set; } = null!;
        public virtual DbSet<LnkRolePermission> LnkRolePermissions { get; set; } = null!;
        public virtual DbSet<LnkRolePermission1> LnkRolePermission1s { get; set; } = null!;
        public virtual DbSet<LnkUserRole> LnkUserRoles { get; set; } = null!;
        public virtual DbSet<LnkUserRole1> LnkUserRole1s { get; set; } = null!;
        public virtual DbSet<MaleEmployee> MaleEmployees { get; set; } = null!;
        public virtual DbSet<MasterList> MasterLists { get; set; } = null!;
        public virtual DbSet<Message> Messages { get; set; } = null!;
        public virtual DbSet<MeterDataGl703114th> MeterDataGl703114ths { get; set; } = null!;
        public virtual DbSet<MetersDatum> MetersData { get; set; } = null!;
        public virtual DbSet<Order> Orders { get; set; } = null!;
        public virtual DbSet<Orders1> Orders1s { get; set; } = null!;
        public virtual DbSet<Orders2> Orders2s { get; set; } = null!;
        public virtual DbSet<Orders3> Orders3s { get; set; } = null!;
        public virtual DbSet<OrdersView> OrdersViews { get; set; } = null!;
        public virtual DbSet<Ordersview1> Ordersviews1 { get; set; } = null!;
        public virtual DbSet<Ordview> Ordviews { get; set; } = null!;
        public virtual DbSet<Oreders21> Oreders21s { get; set; } = null!;
        public virtual DbSet<OrgaDeportment> OrgaDeportments { get; set; } = null!;
        public virtual DbSet<OutputAndPredDatum> OutputAndPredData { get; set; } = null!;
        public virtual DbSet<P1> P1s { get; set; } = null!;
        public virtual DbSet<P2> P2s { get; set; } = null!;
        public virtual DbSet<Parameterdetail> Parameterdetails { get; set; } = null!;
        public virtual DbSet<PcommInboxProcess> PcommInboxProcesses { get; set; } = null!;
        public virtual DbSet<Person> Persons { get; set; } = null!;
        public virtual DbSet<Pp1> Pp1s { get; set; } = null!;
        public virtual DbSet<Product> Products { get; set; } = null!;
        public virtual DbSet<Product1> Products1 { get; set; } = null!;
        public virtual DbSet<Product2> Product2s { get; set; } = null!;
        public virtual DbSet<Product2Price> Product2Prices { get; set; } = null!;
        public virtual DbSet<ProductTest> ProductTests { get; set; } = null!;
        public virtual DbSet<ProductsV> ProductsVs { get; set; } = null!;
        public virtual DbSet<RajEmp> RajEmps { get; set; } = null!;
        public virtual DbSet<RbacTest> RbacTests { get; set; } = null!;
        public virtual DbSet<RechargeServiceInput> RechargeServiceInputs { get; set; } = null!;
        public virtual DbSet<Regexdetail> Regexdetails { get; set; } = null!;
        public virtual DbSet<Registation> Registations { get; set; } = null!;
        public virtual DbSet<Registation1> Registations1 { get; set; } = null!;
        public virtual DbSet<Requestoutbox> Requestoutboxes { get; set; } = null!;
        public virtual DbSet<Responseinbox> Responseinboxes { get; set; } = null!;
        public virtual DbSet<Role> Roles { get; set; } = null!;
        public virtual DbSet<Roles1> Roles1s { get; set; } = null!;
        public virtual DbSet<Sale> Sales { get; set; } = null!;
        public virtual DbSet<Sarwanadnd> Sarwanadnds { get; set; } = null!;
        public virtual DbSet<ServiceTest> ServiceTests { get; set; } = null!;
        public virtual DbSet<Software> Softwares { get; set; } = null!;
        public virtual DbSet<SowmyaHtParamTmu> SowmyaHtParamTmus { get; set; } = null!;
        public virtual DbSet<SowmyaInnerJoin> SowmyaInnerJoins { get; set; } = null!;
        public virtual DbSet<SowmyaInnerJoin1> SowmyaInnerJoin1s { get; set; } = null!;
        public virtual DbSet<Sowmyatable> Sowmyatables { get; set; } = null!;
        public virtual DbSet<Sowmyatable1Nf> Sowmyatable1Nfs { get; set; } = null!;
        public virtual DbSet<Statesinfo> Statesinfos { get; set; } = null!;
        public virtual DbSet<Statesinfoo> Statesinfoos { get; set; } = null!;
        public virtual DbSet<Stud> Studs { get; set; } = null!;
        public virtual DbSet<Student> Students { get; set; } = null!;
        public virtual DbSet<Student7> Student7s { get; set; } = null!;
        public virtual DbSet<StudentDetails1> StudentDetails1s { get; set; } = null!;
        public virtual DbSet<StudentDetails2> StudentDetails2s { get; set; } = null!;
        public virtual DbSet<TblUser> TblUsers { get; set; } = null!;
        public virtual DbSet<Test> Tests { get; set; } = null!;
        public virtual DbSet<Testing> Testings { get; set; } = null!;
        public virtual DbSet<TmmsDashboard> TmmsDashboards { get; set; } = null!;
        public virtual DbSet<V2> V2s { get; set; } = null!;
        public virtual DbSet<Worker> Workers { get; set; } = null!;
        public virtual DbSet<Worker1> Workers1 { get; set; } = null!;
        public virtual DbSet<Worker10> Worker10s { get; set; } = null!;
        public virtual DbSet<Worker9> Worker9s { get; set; } = null!;
        public virtual DbSet<Workers1> Workers1s { get; set; } = null!;

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("Server=172.16.15.26; database=TEST; User id=sa; Password=Pa55w0rd99");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Abc1>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("abc1");

                entity.Property(e => e.City)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("city");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Name)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("name");
            });

            modelBuilder.Entity<ActiveDirectory>(entity =>
            {
                entity.ToTable("ActiveDirectory");

                entity.Property(e => e.ActiveDirectoryId).HasColumnName("ActiveDirectoryID");

                entity.Property(e => e.FirstName).HasMaxLength(50);

                entity.Property(e => e.LastName).HasMaxLength(50);

                entity.Property(e => e.Role).HasMaxLength(50);

                entity.Property(e => e.UserName).HasMaxLength(100);
            });

            modelBuilder.Entity<ActiveDirectory1>(entity =>
            {
                entity.HasKey(e => e.ActiveDirectoryId)
                    .HasName("PK__ActiveDi__6F5BD3B85AB29964");

                entity.ToTable("ActiveDirectory1");

                entity.Property(e => e.ActiveDirectoryId).HasColumnName("ActiveDirectoryID");

                entity.Property(e => e.FirstName).HasMaxLength(50);

                entity.Property(e => e.LastName).HasMaxLength(50);

                entity.Property(e => e.Role).HasMaxLength(50);

                entity.Property(e => e.UserName).HasMaxLength(100);
            });

            modelBuilder.Entity<Agent>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("agents");

                entity.Property(e => e.AgentCode)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("AGENT_CODE")
                    .IsFixedLength();

                entity.Property(e => e.AgentName)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("AGENT_NAME");

                entity.Property(e => e.Comm).HasColumnName("COMM");

                entity.Property(e => e.PhoneNo).HasColumnName("PHONE_NO");

                entity.Property(e => e.WorkingArea)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("WORKING_AREA");
            });

            modelBuilder.Entity<Agentsview>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("agentsview");

                entity.Property(e => e.AgentName)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("AGENT_NAME");

                entity.Property(e => e.CustCity)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("CUST_CITY");

                entity.Property(e => e.CustName)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("CUST_NAME");

                entity.Property(e => e.WorkingArea)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("WORKING_AREA");
            });

            modelBuilder.Entity<AlekyaActiveDirectory>(entity =>
            {
                entity.HasKey(e => e.ActiveDirectoryId)
                    .HasName("PK__AlekyaAc__6F5BD3B8803D7A60");

                entity.ToTable("AlekyaActiveDirectory");

                entity.Property(e => e.ActiveDirectoryId).HasColumnName("ActiveDirectoryID");

                entity.Property(e => e.FirstName).HasMaxLength(50);

                entity.Property(e => e.GroupName).HasMaxLength(100);

                entity.Property(e => e.LastName).HasMaxLength(50);

                entity.Property(e => e.Role).HasMaxLength(50);

                entity.Property(e => e.UserName).HasMaxLength(100);
            });

            modelBuilder.Entity<AnilActiveDirectory>(entity =>
            {
                entity.HasKey(e => e.ActiveDirectoryId)
                    .HasName("PK__AnilActi__6F5BD3B80C3D34D2");

                entity.ToTable("AnilActiveDirectory");

                entity.Property(e => e.ActiveDirectoryId).HasColumnName("ActiveDirectoryID");

                entity.Property(e => e.FirstName).HasMaxLength(50);

                entity.Property(e => e.GroupName).HasMaxLength(100);

                entity.Property(e => e.LastName).HasMaxLength(50);

                entity.Property(e => e.Members).HasMaxLength(100);

                entity.Property(e => e.Role).HasMaxLength(50);

                entity.Property(e => e.UserName).HasMaxLength(100);
            });

            modelBuilder.Entity<Anji>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("anji");

                entity.Property(e => e.Eid).HasColumnName("eid");

                entity.Property(e => e.Email)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("email");

                entity.Property(e => e.Ename)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("ename");

                entity.Property(e => e.MobileNumber).HasColumnName("mobile_number");

                entity.Property(e => e.Sal).HasColumnName("sal");
            });

            modelBuilder.Entity<Anji1>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("anji1");

                entity.Property(e => e.Eid).HasColumnName("eid");

                entity.Property(e => e.Email)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("email");

                entity.Property(e => e.Ename)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("ename");

                entity.Property(e => e.MobileNumber).HasColumnName("mobile_number");

                entity.Property(e => e.Sal).HasColumnName("sal");
            });

            modelBuilder.Entity<AspNetUserClaim>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.ClaimType).HasMaxLength(50);

                entity.Property(e => e.ClaimValue).HasMaxLength(50);

                entity.Property(e => e.UserId).HasMaxLength(50);
            });

            modelBuilder.Entity<AspNetUserRole>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.RoleId).HasMaxLength(50);
            });

            modelBuilder.Entity<Bi>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("BI");

                entity.Property(e => e.DeviceIp).HasMaxLength(50);

                entity.Property(e => e.NwIntEnd).HasColumnName("Nw_int_End");

                entity.Property(e => e.NwIntStart).HasColumnName("Nw_int_Start");

                entity.Property(e => e.TransformerSno).HasColumnName("TransformerSNO");
            });

            modelBuilder.Entity<Bi1>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("BI1");

                entity.Property(e => e.DeviceIp)
                    .HasMaxLength(50)
                    .HasColumnName("DeviceIP");

                entity.Property(e => e.Duration).HasMaxLength(50);

                entity.Property(e => e.NwIntEnd).HasColumnName("Nw_Int_End");

                entity.Property(e => e.NwIntStart).HasColumnName("Nw_Int_Start");

                entity.Property(e => e.Timee).HasColumnName("TIMEE");

                entity.Property(e => e.Timee1).HasColumnName("timee1");
            });

            modelBuilder.Entity<Bi2>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("BI2");

                entity.Property(e => e.DeviceIp)
                    .HasMaxLength(50)
                    .HasColumnName("DeviceIP");

                entity.Property(e => e.NwIntEnd)
                    .HasMaxLength(50)
                    .HasColumnName("Nw_Int_End");

                entity.Property(e => e.NwIntStart)
                    .HasMaxLength(50)
                    .HasColumnName("Nw_Int_Start");
            });

            modelBuilder.Entity<BiTeam>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("BI_TEAM");

                entity.Property(e => e.ConvertedToDHhMmSsMs)
                    .HasMaxLength(61)
                    .IsUnicode(false)
                    .HasColumnName("Converted to D:HH:MM:SS.MS");

                entity.Property(e => e.DeviceIp).HasMaxLength(50);

                entity.Property(e => e.DeviceSerialNo)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Hrs).HasColumnName("hrs");

                entity.Property(e => e.Minutess).HasColumnName("minutess");

                entity.Property(e => e.NwIntEnd).HasColumnName("Nw_int_end");

                entity.Property(e => e.NwIntStart).HasColumnName("Nw_int_start");

                entity.Property(e => e.Secondds).HasColumnName("secondds");

                entity.Property(e => e.StructureCode).HasMaxLength(50);

                entity.Property(e => e.Timee)
                    .HasMaxLength(51)
                    .IsUnicode(false);

                entity.Property(e => e.Transformersno)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Car>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Car");

                entity.Property(e => e.Location)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("location");

                entity.Property(e => e.Name)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Price).HasColumnName("price");
            });

            modelBuilder.Entity<Car1>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Cars");

                entity.Property(e => e.Location)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("location");

                entity.Property(e => e.Name)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Price).HasColumnName("price");
            });

            modelBuilder.Entity<ChaitanyaActiveDirectory>(entity =>
            {
                entity.HasKey(e => e.ActiveDirectoryId)
                    .HasName("PK__Chaitany__6F5BD3B8E79B98B2");

                entity.ToTable("ChaitanyaActiveDirectory");

                entity.Property(e => e.ActiveDirectoryId).HasColumnName("ActiveDirectoryID");

                entity.Property(e => e.FirstName).HasMaxLength(50);

                entity.Property(e => e.GroupName).HasMaxLength(100);

                entity.Property(e => e.LastName).HasMaxLength(50);

                entity.Property(e => e.Members).HasMaxLength(100);

                entity.Property(e => e.Role).HasMaxLength(50);

                entity.Property(e => e.UserName).HasMaxLength(100);
            });

            modelBuilder.Entity<City>(entity =>
            {
                entity.ToTable("city");
            });

            modelBuilder.Entity<Commanddetail>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("commanddetails");

                entity.Property(e => e.CommandId).HasColumnName("CommandID");

                entity.Property(e => e.CommandIsActive).HasMaxLength(255);

                entity.Property(e => e.CommandName).HasMaxLength(255);

                entity.Property(e => e.CommandType).HasMaxLength(255);

                entity.Property(e => e.CrTs).HasColumnType("datetime");

                entity.Property(e => e.DeviceId).HasColumnName("DeviceID");

                entity.Property(e => e.LogicalName).HasMaxLength(255);

                entity.Property(e => e.Obiscode)
                    .HasMaxLength(255)
                    .HasColumnName("OBISCode");

                entity.Property(e => e.Obiscodehex)
                    .HasMaxLength(255)
                    .HasColumnName("OBISCODEHEX");
            });

            modelBuilder.Entity<Configuration>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("configurations");

                entity.Property(e => e.AssociationId).HasColumnName("AssociationID");

                entity.Property(e => e.AttributeId).HasColumnName("AttributeID");

                entity.Property(e => e.CommandId).HasColumnName("CommandID");

                entity.Property(e => e.ConfigurationId).HasColumnName("ConfigurationID");

                entity.Property(e => e.CrTs).HasColumnType("datetime");

                entity.Property(e => e.DataTypeId)
                    .HasMaxLength(255)
                    .HasColumnName("DataTypeID");

                entity.Property(e => e.InterfaceClassId).HasColumnName("InterfaceClassID");

                entity.Property(e => e.MethodId)
                    .HasMaxLength(255)
                    .HasColumnName("MethodID");

                entity.Property(e => e.ParameterId).HasColumnName("ParameterID");
            });

            modelBuilder.Entity<ConnectedNnotConnected>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("ConnectedNnotConnected");

                entity.Property(e => e.DateTime)
                    .HasMaxLength(50)
                    .HasColumnName("Date_Time");

                entity.Property(e => e.DcSno)
                    .HasMaxLength(50)
                    .HasColumnName("DC_SNo");

                entity.Property(e => e.EventStatus)
                    .HasMaxLength(50)
                    .HasColumnName("Event_Status");

                entity.Property(e => e.MdKVa).HasColumnName("MD_kVA");

                entity.Property(e => e.MdKVaTs).HasColumnName("MD_kVA_TS");

                entity.Property(e => e.MdKW).HasColumnName("MD_kW");

                entity.Property(e => e.MdKWTs).HasColumnName("MD_kW_TS");

                entity.Property(e => e.MeterReadingKVah).HasColumnName("Meter_Reading_kVAh");

                entity.Property(e => e.MeterReadingKWh).HasColumnName("Meter_Reading_kWh");

                entity.Property(e => e.Msn)
                    .HasMaxLength(50)
                    .HasColumnName("MSN");

                entity.Property(e => e.NeutralCurrent).HasColumnName("Neutral_Current");

                entity.Property(e => e.PhaseCurrent).HasColumnName("Phase_Current");

                entity.Property(e => e.PhysicalAddress).HasMaxLength(50);

                entity.Property(e => e.PowerFactor).HasColumnName("Power_Factor");

                entity.Property(e => e.Ranks1).HasColumnName("RANKS1");

                entity.Property(e => e.ServiceNo)
                    .HasMaxLength(50)
                    .HasColumnName("Service_No");
            });

            modelBuilder.Entity<Country>(entity =>
            {
                entity.ToTable("Country");

                entity.Property(e => e.Capital).HasMaxLength(50);

                entity.Property(e => e.Currency).HasMaxLength(50);

                entity.Property(e => e.Economy).HasColumnType("numeric(18, 0)");

                entity.Property(e => e.Name).HasMaxLength(50);
            });

            modelBuilder.Entity<Crud>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("CRUD");

                entity.Property(e => e.Cname)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("CName");
            });

            modelBuilder.Entity<Customer>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("customers");

                entity.Property(e => e.AgentCode)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("AGENT_CODE")
                    .IsFixedLength();

                entity.Property(e => e.CustCity)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("CUST_CITY");

                entity.Property(e => e.CustCode)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("CUST_CODE")
                    .IsFixedLength();

                entity.Property(e => e.CustCountry)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("CUST_COUNTRY");

                entity.Property(e => e.CustName)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("CUST_NAME");

                entity.Property(e => e.Grade)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("GRADE")
                    .IsFixedLength();

                entity.Property(e => e.OpeningAmount).HasColumnName("OPENING_AMOUNT");

                entity.Property(e => e.OutstandingAmt).HasColumnName("OUTSTANDING_AMT");

                entity.Property(e => e.PaymentAmt).HasColumnName("PAYMENT_AMT");

                entity.Property(e => e.PhoneNo).HasColumnName("PHONE_NO");

                entity.Property(e => e.ReceiveAmt).HasColumnName("RECEIVE_AMT");
            });

            modelBuilder.Entity<Customer4>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("customer4");

                entity.Property(e => e.Contactname)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("contactname");

                entity.Property(e => e.Country)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("country");

                entity.Property(e => e.Customerid).HasColumnName("customerid");

                entity.Property(e => e.Customername)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("customername");
            });

            modelBuilder.Entity<CustomerDatum>(entity =>
            {
                entity.HasKey(e => e.CustId)
                    .HasName("PK__customer__A1B71F909310876A");

                entity.ToTable("customer_data");

                entity.Property(e => e.CustId)
                    .ValueGeneratedNever()
                    .HasColumnName("cust_id");

                entity.Property(e => e.Address)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("address");

                entity.Property(e => e.CustName)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("cust_name");

                entity.Property(e => e.Email)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("email");

                entity.Property(e => e.Phone).HasColumnName("phone");
            });

            modelBuilder.Entity<Customers1>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("customers1");

                entity.Property(e => e.Adress)
                    .HasMaxLength(50)
                    .HasColumnName("adress");

                entity.Property(e => e.City)
                    .HasMaxLength(20)
                    .HasColumnName("city");

                entity.Property(e => e.ContactNo).HasColumnName("contactNo");

                entity.Property(e => e.Country).HasMaxLength(30);

                entity.Property(e => e.Customername)
                    .HasMaxLength(20)
                    .HasColumnName("customername");

                entity.Property(e => e.PostalCode)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("postalCode");
            });

            modelBuilder.Entity<Customers2>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("customers2");

                entity.Property(e => e.Adress)
                    .HasMaxLength(50)
                    .HasColumnName("adress");

                entity.Property(e => e.City)
                    .HasMaxLength(20)
                    .HasColumnName("city");

                entity.Property(e => e.ContactNo).HasColumnName("contactNo");

                entity.Property(e => e.Country).HasMaxLength(30);

                entity.Property(e => e.Customername)
                    .HasMaxLength(20)
                    .HasColumnName("customername");

                entity.Property(e => e.PostalCode)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("postalCode");

                entity.Property(e => e.RegiDate)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("Regi_date");

                entity.Property(e => e.Salary)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("salary");
            });

            modelBuilder.Entity<Customers22>(entity =>
            {
                entity.ToTable("CUSTOMERS22");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("ID");

                entity.Property(e => e.Address)
                    .HasMaxLength(25)
                    .IsUnicode(false)
                    .HasColumnName("ADDRESS")
                    .IsFixedLength();

                entity.Property(e => e.Age).HasColumnName("AGE");

                entity.Property(e => e.Name)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("NAME");

                entity.Property(e => e.Salary)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("SALARY");
            });

            modelBuilder.Entity<Dataparamdt>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("dataparamdt");

                entity.Property(e => e.BackupAmountFromPreviousBilling).HasMaxLength(255);

                entity.Property(e => e.BlueToothRechargeHappened).HasMaxLength(255);

                entity.Property(e => e.Category1).HasMaxLength(255);

                entity.Property(e => e.Category2).HasMaxLength(255);

                entity.Property(e => e.Category3).HasMaxLength(255);

                entity.Property(e => e.Cjid)
                    .HasMaxLength(255)
                    .HasColumnName("CJID");

                entity.Property(e => e.Cjidheader)
                    .HasMaxLength(255)
                    .HasColumnName("CJIDHeader");

                entity.Property(e => e.CoOrdinatorPhysicalAddress).HasMaxLength(255);

                entity.Property(e => e.CommandCode).HasMaxLength(255);

                entity.Property(e => e.ConsumedAmountforPreviousBilling).HasMaxLength(255);

                entity.Property(e => e.ConsumedKwhunitsforPreviousBilling)
                    .HasMaxLength(255)
                    .HasColumnName("ConsumedKWHUnitsforPreviousBilling");

                entity.Property(e => e.ConsumedPrepaidkWhForCurrentBilling).HasMaxLength(255);

                entity.Property(e => e.CrTs).HasColumnType("datetime");

                entity.Property(e => e.CumulativeRechargeAmount).HasMaxLength(255);

                entity.Property(e => e.CumulativeRechargeAmountBillingMonth).HasMaxLength(255);

                entity.Property(e => e.CurrentCategory).HasMaxLength(255);

                entity.Property(e => e.CurrentSlab).HasMaxLength(255);

                entity.Property(e => e.CurrentTariff).HasMaxLength(255);

                entity.Property(e => e.DataParamDtid).HasColumnName("DataParamDTId");

                entity.Property(e => e.Dcustatus)
                    .HasMaxLength(255)
                    .HasColumnName("DCUStatus");

                entity.Property(e => e.DtdataPushInterval)
                    .HasMaxLength(255)
                    .HasColumnName("DTDataPushInterval");

                entity.Property(e => e.Dtdelay).HasColumnName("DTDelay");

                entity.Property(e => e.Dtmode)
                    .HasMaxLength(255)
                    .HasColumnName("DTMode");

                entity.Property(e => e.Dtversion)
                    .HasMaxLength(255)
                    .HasColumnName("DTVersion");

                entity.Property(e => e.HhuphysicalAddress)
                    .HasMaxLength(255)
                    .HasColumnName("HHUPhysicalAddress");

                entity.Property(e => e.Hhustatus)
                    .HasMaxLength(255)
                    .HasColumnName("HHUStatus");

                entity.Property(e => e.IhdphysicalAddress)
                    .HasMaxLength(255)
                    .HasColumnName("IHDPhysicalAddress");

                entity.Property(e => e.Ihdstatus)
                    .HasMaxLength(255)
                    .HasColumnName("IHDStatus");

                entity.Property(e => e.LatestBillingResetDate).HasMaxLength(255);

                entity.Property(e => e.LatestRechargeAmount).HasMaxLength(255);

                entity.Property(e => e.LowBalanceAlert).HasMaxLength(255);

                entity.Property(e => e.LowBalanceAmount).HasMaxLength(255);

                entity.Property(e => e.MeterInstantantenousBalanceForCurrentBilling).HasMaxLength(255);

                entity.Property(e => e.MeterMode).HasMaxLength(255);

                entity.Property(e => e.MeterPowerOn)
                    .HasMaxLength(255)
                    .HasColumnName("MeterPowerON");

                entity.Property(e => e.MeterReferenceBalanceForCurrentMonth).HasMaxLength(255);

                entity.Property(e => e.NegativeBalanceForCurrentBilling).HasMaxLength(255);

                entity.Property(e => e.NegativeBalanceforPreviousBilling).HasMaxLength(255);

                entity.Property(e => e.PhysicalAddress).HasMaxLength(255);

                entity.Property(e => e.PowerFail).HasMaxLength(255);

                entity.Property(e => e.PowerOn).HasMaxLength(255);

                entity.Property(e => e.PrepaidConsumedAmountForCurrentBilling).HasMaxLength(255);

                entity.Property(e => e.RelayStatus).HasMaxLength(255);

                entity.Property(e => e.Rj11status)
                    .HasMaxLength(255)
                    .HasColumnName("RJ11Status");

                entity.Property(e => e.Slab1).HasMaxLength(255);

                entity.Property(e => e.Slab2).HasMaxLength(255);

                entity.Property(e => e.Slab21)
                    .HasMaxLength(255)
                    .HasColumnName("Slab2_1");

                entity.Property(e => e.Slab22)
                    .HasMaxLength(255)
                    .HasColumnName("Slab2_2");

                entity.Property(e => e.Slab23)
                    .HasMaxLength(255)
                    .HasColumnName("Slab2_3");

                entity.Property(e => e.Slab24)
                    .HasMaxLength(255)
                    .HasColumnName("Slab2_4");

                entity.Property(e => e.Slab25)
                    .HasMaxLength(255)
                    .HasColumnName("Slab2_5");

                entity.Property(e => e.Slab3).HasMaxLength(255);

                entity.Property(e => e.Slab31)
                    .HasMaxLength(255)
                    .HasColumnName("Slab3_1");

                entity.Property(e => e.Slab32)
                    .HasMaxLength(255)
                    .HasColumnName("Slab3_2");

                entity.Property(e => e.Slab33)
                    .HasMaxLength(255)
                    .HasColumnName("Slab3_3");

                entity.Property(e => e.Slab34)
                    .HasMaxLength(255)
                    .HasColumnName("Slab3_4");

                entity.Property(e => e.Slab35)
                    .HasMaxLength(255)
                    .HasColumnName("Slab3_5");

                entity.Property(e => e.Slab4).HasMaxLength(255);

                entity.Property(e => e.Slab5).HasMaxLength(255);

                entity.Property(e => e.Success).HasMaxLength(255);

                entity.Property(e => e.Tariff1).HasMaxLength(255);

                entity.Property(e => e.Tariff2).HasMaxLength(255);

                entity.Property(e => e.Tariff21)
                    .HasMaxLength(255)
                    .HasColumnName("Tariff2_1");

                entity.Property(e => e.Tariff22)
                    .HasMaxLength(255)
                    .HasColumnName("Tariff2_2");

                entity.Property(e => e.Tariff23)
                    .HasMaxLength(255)
                    .HasColumnName("Tariff2_3");

                entity.Property(e => e.Tariff24)
                    .HasMaxLength(255)
                    .HasColumnName("Tariff2_4");

                entity.Property(e => e.Tariff25)
                    .HasMaxLength(255)
                    .HasColumnName("Tariff2_5");

                entity.Property(e => e.Tariff3).HasMaxLength(255);

                entity.Property(e => e.Tariff31)
                    .HasMaxLength(255)
                    .HasColumnName("Tariff3_1");

                entity.Property(e => e.Tariff32)
                    .HasMaxLength(255)
                    .HasColumnName("Tariff3_2");

                entity.Property(e => e.Tariff33)
                    .HasMaxLength(255)
                    .HasColumnName("Tariff3_3");

                entity.Property(e => e.Tariff34)
                    .HasMaxLength(255)
                    .HasColumnName("Tariff3_4");

                entity.Property(e => e.Tariff35)
                    .HasMaxLength(255)
                    .HasColumnName("Tariff3_5");

                entity.Property(e => e.Tariff4).HasMaxLength(255);

                entity.Property(e => e.Tariff5).HasMaxLength(255);
            });

            modelBuilder.Entity<DeepikaActiveDirectory>(entity =>
            {
                entity.HasKey(e => e.ActiveDirectoryId)
                    .HasName("PK__DeepikaA__6F5BD3B80C6843C0");

                entity.ToTable("DeepikaActiveDirectory");

                entity.Property(e => e.ActiveDirectoryId).HasColumnName("ActiveDirectoryID");

                entity.Property(e => e.FirstName).HasMaxLength(50);

                entity.Property(e => e.GroupName).HasMaxLength(100);

                entity.Property(e => e.LastName).HasMaxLength(50);

                entity.Property(e => e.Members).HasMaxLength(100);

                entity.Property(e => e.Role).HasMaxLength(50);

                entity.Property(e => e.UserName).HasMaxLength(100);
            });

            modelBuilder.Entity<Dell>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("dell");

                entity.Property(e => e.DId).HasColumnName("d_id");

                entity.Property(e => e.DName)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("d_name");

                entity.Property(e => e.DPerson)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("d_person");

                entity.Property(e => e.DPrice).HasColumnName("d_price");
            });

            modelBuilder.Entity<Dell1>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("dell_1");

                entity.Property(e => e.DId).HasColumnName("d_id");

                entity.Property(e => e.DName)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("d_name");

                entity.Property(e => e.DPerson)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("d_person");

                entity.Property(e => e.DPrice).HasColumnName("d_price");
            });

            modelBuilder.Entity<Demo>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("demo");

                entity.Property(e => e.Empid).HasColumnName("empid");

                entity.Property(e => e.Month).HasColumnName("month");

                entity.Property(e => e.Salary).HasColumnName("salary");
            });

            modelBuilder.Entity<DepartmentName>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("DepartmentName");

                entity.Property(e => e.DepartmentHead).HasMaxLength(50);

                entity.Property(e => e.DepartmentName1)
                    .HasMaxLength(50)
                    .HasColumnName("DepartmentName");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Location).HasMaxLength(50);
            });

            modelBuilder.Entity<Dept2>(entity =>
            {
                entity.HasKey(e => e.Deptno)
                    .HasName("PK__DEPT2__E0EB08D796E33B59");

                entity.ToTable("DEPT2");

                entity.Property(e => e.Deptno)
                    .ValueGeneratedNever()
                    .HasColumnName("DEPTNO");

                entity.Property(e => e.Dname)
                    .HasMaxLength(14)
                    .IsUnicode(false)
                    .HasColumnName("DNAME");

                entity.Property(e => e.Loc)
                    .HasMaxLength(13)
                    .IsUnicode(false)
                    .HasColumnName("LOC");
            });

            modelBuilder.Entity<DetailsEmp>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("details_emp");

                entity.Property(e => e.Empno).HasColumnName("empno");

                entity.Property(e => e.Ename)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("ename");

                entity.Property(e => e.Job)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("job");

                entity.Property(e => e.Sal)
                    .HasColumnType("date")
                    .HasColumnName("sal");
            });

            modelBuilder.Entity<Districctinfoo>(entity =>
            {
                entity.HasKey(e => e.Dctid)
                    .HasName("PK__districc__3055B79E7C896F37");

                entity.ToTable("districctinfoo");

                entity.Property(e => e.Dctid)
                    .ValueGeneratedNever()
                    .HasColumnName("dctid");

                entity.Property(e => e.Dctname)
                    .HasMaxLength(50)
                    .HasColumnName("dctname");

                entity.Property(e => e.Stateid).HasColumnName("stateid");

                entity.HasOne(d => d.State)
                    .WithMany(p => p.Districctinfoos)
                    .HasForeignKey(d => d.Stateid)
                    .HasConstraintName("FK__districct__state__290D0E62");
            });

            modelBuilder.Entity<Districctinfoo1>(entity =>
            {
                entity.HasKey(e => e.Dctid)
                    .HasName("PK__districc__3055B79E393CEA1C");

                entity.ToTable("districctinfoo1");

                entity.Property(e => e.Dctid)
                    .ValueGeneratedNever()
                    .HasColumnName("dctid");

                entity.Property(e => e.Dctname)
                    .HasMaxLength(50)
                    .HasColumnName("dctname");

                entity.Property(e => e.Stateid).HasColumnName("stateid");

                entity.HasOne(d => d.State)
                    .WithMany(p => p.Districctinfoo1s)
                    .HasForeignKey(d => d.Stateid)
                    .HasConstraintName("fk_stateid1");
            });

            modelBuilder.Entity<Districtinfo>(entity =>
            {
                entity.HasKey(e => e.Districtid)
                    .HasName("PK__DISTRICT__55510159119D1D37");

                entity.ToTable("DISTRICTINFO");

                entity.Property(e => e.Districtid).HasColumnName("DISTRICTID");

                entity.Property(e => e.Districtname)
                    .HasMaxLength(50)
                    .HasColumnName("DISTRICTNAME");

                entity.Property(e => e.Stateid).HasColumnName("STATEID");

                entity.HasOne(d => d.State)
                    .WithMany(p => p.Districtinfos)
                    .HasForeignKey(d => d.Stateid)
                    .HasConstraintName("FK_STATEID");
            });

            modelBuilder.Entity<EDetali>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("e_detalis");

                entity.Property(e => e.EId).HasColumnName("e_id");

                entity.Property(e => e.EName)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("e_name");

                entity.Property(e => e.ESal).HasColumnName("e_sal");

                entity.Property(e => e.Job)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("job");
            });

            modelBuilder.Entity<EDetalis1>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("e_detalis1");

                entity.Property(e => e.EId).HasColumnName("e_id");

                entity.Property(e => e.EName)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("e_name");

                entity.Property(e => e.ESal).HasColumnName("e_sal");

                entity.Property(e => e.Job)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("job");
            });

            modelBuilder.Entity<EficaaBi>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("EficaaBi");

                entity.Property(e => e.ConvertedToDHhMmSsMs)
                    .HasMaxLength(61)
                    .IsUnicode(false)
                    .HasColumnName("Converted to D:HH:MM:SS.MS");

                entity.Property(e => e.DeviceIp).HasMaxLength(50);

                entity.Property(e => e.DeviceSerialNo)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.NwIntEnd).HasColumnName("Nw_int_end");

                entity.Property(e => e.NwIntStart).HasColumnName("Nw_int_start");

                entity.Property(e => e.StructureCode).HasMaxLength(50);

                entity.Property(e => e.Transformersno)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Emp>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("EMP");

                entity.Property(e => e.Comm).HasColumnName("COMM");

                entity.Property(e => e.Deptno).HasColumnName("DEPTNO");

                entity.Property(e => e.Empno).HasColumnName("EMPNO");

                entity.Property(e => e.Ename)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("ENAME");

                entity.Property(e => e.Grade).HasColumnName("GRADE");

                entity.Property(e => e.Hiredate)
                    .HasColumnType("date")
                    .HasColumnName("HIREDATE");

                entity.Property(e => e.Job)
                    .HasMaxLength(9)
                    .IsUnicode(false)
                    .HasColumnName("JOB");

                entity.Property(e => e.Mgr).HasColumnName("MGR");

                entity.Property(e => e.Sal).HasColumnName("SAL");
            });

            modelBuilder.Entity<Emp1>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("emp_1");

                entity.Property(e => e.EDept)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("e_dept");

                entity.Property(e => e.EId).HasColumnName("e_id");

                entity.Property(e => e.EName)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("e_name");

                entity.Property(e => e.ESal).HasColumnName("e_sal");
            });

            modelBuilder.Entity<Emp10>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("emp10");

                entity.Property(e => e.EId).HasColumnName("e_id");

                entity.Property(e => e.EName)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("e_name");

                entity.Property(e => e.ESal).HasColumnName("e_sal");

                entity.Property(e => e.ESurname)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("e_surname");
            });

            modelBuilder.Entity<Emp11>(entity =>
            {
                entity.HasKey(e => e.Empno)
                    .HasName("PK__EMP1__14CCF2EE24519BA0");

                entity.ToTable("EMP1");

                entity.Property(e => e.Empno)
                    .ValueGeneratedNever()
                    .HasColumnName("EMPNO");

                entity.Property(e => e.Comm).HasColumnName("COMM");

                entity.Property(e => e.Deptno).HasColumnName("DEPTNO");

                entity.Property(e => e.Ename)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("ENAME");

                entity.Property(e => e.Hiredate)
                    .HasColumnType("date")
                    .HasColumnName("HIREDATE");

                entity.Property(e => e.Job)
                    .HasMaxLength(9)
                    .IsUnicode(false)
                    .HasColumnName("JOB");

                entity.Property(e => e.Mgr).HasColumnName("MGR");

                entity.Property(e => e.Sal).HasColumnName("SAL");

                entity.HasOne(d => d.DeptnoNavigation)
                    .WithMany(p => p.Emp11s)
                    .HasForeignKey(d => d.Deptno)
                    .HasConstraintName("FK__EMP1__DEPTNO__06ED0088");
            });

            modelBuilder.Entity<Emp2>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("emp_2");

                entity.Property(e => e.EDept)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("e_dept");

                entity.Property(e => e.EId).HasColumnName("e_id");

                entity.Property(e => e.EName)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("e_name");

                entity.Property(e => e.ESalary).HasColumnName("E_SALARY");
            });

            modelBuilder.Entity<EmpDetail>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("emp_details");

                entity.Property(e => e.EId).HasColumnName("e_id");

                entity.Property(e => e.EName)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("e_name");

                entity.Property(e => e.ESal).HasColumnName("e_sal");

                entity.Property(e => e.ESurname)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("e_surname");
            });

            modelBuilder.Entity<Employee0>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("EMPLOYEE0");

                entity.Property(e => e.Empcity)
                    .HasMaxLength(20)
                    .HasColumnName("EMPCITY");

                entity.Property(e => e.Empname)
                    .HasMaxLength(20)
                    .HasColumnName("EMPNAME");

                entity.Property(e => e.Empno)
                    .HasMaxLength(20)
                    .HasColumnName("EMPNO");

                entity.Property(e => e.Empsalary).HasColumnName("EMPSALARY");

                entity.Property(e => e.JoiningDate)
                    .IsRowVersion()
                    .IsConcurrencyToken()
                    .HasColumnName("JOINING_DATE");
            });

            modelBuilder.Entity<Employee123>(entity =>
            {
                entity.HasKey(e => e.EmpId)
                    .HasName("PK__employee__1299A8611E40A0AB");

                entity.ToTable("employee123");

                entity.Property(e => e.EmpId)
                    .ValueGeneratedNever()
                    .HasColumnName("emp_id");

                entity.Property(e => e.EmpCity)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("emp_city");

                entity.Property(e => e.EmpCountry)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("emp_country");

                entity.Property(e => e.EmpName)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("emp_name");
            });

            modelBuilder.Entity<EmployeeDetail>(entity =>
            {
                entity.HasKey(e => e.EmpId);

                entity.ToTable("Employee_Details");

                entity.Property(e => e.EmpId).HasColumnName("Emp_Id");

                entity.Property(e => e.EmpCity)
                    .HasMaxLength(50)
                    .HasColumnName("Emp_City");

                entity.Property(e => e.EmpName)
                    .HasMaxLength(50)
                    .HasColumnName("Emp_Name");

                entity.Property(e => e.EmpSalary).HasColumnName("Emp_Salary");

                entity.Property(e => e.Gender)
                    .HasMaxLength(10)
                    .IsFixedLength();

                entity.Property(e => e.MySal)
                    .HasMaxLength(50)
                    .HasColumnName("MY_sal");
            });

            modelBuilder.Entity<EmployeeDetails3>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("Employee_Details3");

                entity.Property(e => e.EmpCity)
                    .HasMaxLength(50)
                    .HasColumnName("Emp_City");

                entity.Property(e => e.EmpId)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("Emp_Id");

                entity.Property(e => e.EmpName)
                    .HasMaxLength(50)
                    .HasColumnName("Emp_Name");

                entity.Property(e => e.EmpSalary).HasColumnName("Emp_Salary");
            });

            modelBuilder.Entity<EmployeeView1>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("Employee_View1");

                entity.Property(e => e.EmpCity)
                    .HasMaxLength(50)
                    .HasColumnName("Emp_City");

                entity.Property(e => e.EmpId)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("Emp_Id");

                entity.Property(e => e.EmpName)
                    .HasMaxLength(50)
                    .HasColumnName("Emp_Name");

                entity.Property(e => e.EmpSalary).HasColumnName("Emp_Salary");
            });

            modelBuilder.Entity<EmployeeView2>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("Employee_View2");

                entity.Property(e => e.EmpCity)
                    .HasMaxLength(50)
                    .HasColumnName("Emp_City");

                entity.Property(e => e.EmpId)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("Emp_Id");

                entity.Property(e => e.EmpName)
                    .HasMaxLength(50)
                    .HasColumnName("Emp_Name");
            });

            modelBuilder.Entity<EmployeeView3>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("Employee_View3");

                entity.Property(e => e.EmpCity)
                    .HasMaxLength(50)
                    .HasColumnName("Emp_City");

                entity.Property(e => e.EmpId)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("Emp_Id");

                entity.Property(e => e.EmpName)
                    .HasMaxLength(50)
                    .HasColumnName("Emp_Name");

                entity.Property(e => e.EmpSalary).HasColumnName("Emp_Salary");
            });

            modelBuilder.Entity<EmployeeView4>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("Employee_View4");

                entity.Property(e => e.EmpId).HasColumnName("Emp_Id");

                entity.Property(e => e.EmpName)
                    .HasMaxLength(50)
                    .HasColumnName("Emp_Name");

                entity.Property(e => e.EmpSalary).HasColumnName("Emp_Salary");

                entity.Property(e => e.MobileNo).HasMaxLength(50);
            });

            modelBuilder.Entity<Employees1>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("EMPLOYEES1");

                entity.Property(e => e.EmployeeId).HasColumnName("EMPLOYEE_ID");

                entity.Property(e => e.FirstName)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("FIRST_NAME");

                entity.Property(e => e.LastName)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("LAST_NAME");

                entity.Property(e => e.Salary).HasColumnName("SALARY");
            });

            modelBuilder.Entity<EtConsumerDetail>(entity =>
            {
                entity.HasKey(e => e.ConsumerId)
                    .HasName("PK_ET_CONSUMERDETAILS_CONSUMERID");

                entity.ToTable("ET_CONSUMER_DETAILS");

                entity.HasIndex(e => e.ConsumerId, "UK_ET_CONSUMER_DETAILS_AADHAR_NO")
                    .IsUnique();

                entity.HasIndex(e => e.ConsumerId, "UK_ET_CONSUMER_DETAILS_CONSUMERRELATIONNO")
                    .IsUnique();

                entity.HasIndex(e => e.ConsumerId, "UK_ET_CONSUMER_DETAILS_MOBILENO")
                    .IsUnique();

                entity.HasIndex(e => e.ConsumerId, "UK_ET_CONSUMER_DETAILS_PHONENO")
                    .IsUnique();

                entity.Property(e => e.ConsumerId).HasColumnName("CONSUMER_ID");

                entity.Property(e => e.AadharNo)
                    .HasColumnType("numeric(12, 0)")
                    .HasColumnName("AADHAR_NO");

                entity.Property(e => e.Address)
                    .HasMaxLength(500)
                    .HasColumnName("ADDRESS");

                entity.Property(e => e.CityVillage)
                    .HasMaxLength(50)
                    .HasColumnName("CITY/VILLAGE");

                entity.Property(e => e.ConsumerRelationNo)
                    .HasMaxLength(15)
                    .HasColumnName("CONSUMER_RELATION_NO");

                entity.Property(e => e.Crts)
                    .HasColumnName("CRTS")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.EmailId)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("EMAIL_ID");

                entity.Property(e => e.FatherHusbandName)
                    .HasMaxLength(50)
                    .HasColumnName("FATHER/HUSBAND_NAME");

                entity.Property(e => e.FirstName)
                    .HasMaxLength(50)
                    .HasColumnName("FIRST_NAME");

                entity.Property(e => e.GovtEmployee)
                    .HasColumnName("GOVT_EMPLOYEE")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.LastName)
                    .HasMaxLength(50)
                    .HasColumnName("LAST_NAME");

                entity.Property(e => e.Mandal)
                    .HasMaxLength(50)
                    .HasColumnName("MANDAL");

                entity.Property(e => e.MiddleName)
                    .HasMaxLength(50)
                    .HasColumnName("MIDDLE_NAME");

                entity.Property(e => e.MobileNo)
                    .HasMaxLength(15)
                    .HasColumnName("MOBILE_NO");

                entity.Property(e => e.PhoneNo)
                    .HasMaxLength(15)
                    .HasColumnName("PHONE_NO");

                entity.Property(e => e.Pincode).HasColumnName("PINCODE");

                entity.Property(e => e.Title)
                    .HasMaxLength(10)
                    .HasColumnName("TITLE");
            });

            modelBuilder.Entity<EtDcuDetail>(entity =>
            {
                entity.HasKey(e => e.DcuId)
                    .HasName("PK_ET_DCU_DETAILS_DCUID");

                entity.ToTable("ET_DCU_DETAILS");

                entity.HasIndex(e => e.DcuSno, "UK_ET_DCU_DETAILS_DCUSNO")
                    .IsUnique();

                entity.Property(e => e.DcuId).HasColumnName("DCU_ID");

                entity.Property(e => e.Crts)
                    .HasColumnName("CRTS")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.DcuFwVersion)
                    .HasMaxLength(10)
                    .HasColumnName("DCU_FW_VERSION");

                entity.Property(e => e.DcuHwVersion)
                    .HasMaxLength(10)
                    .HasColumnName("DCU_HW_VERSION");

                entity.Property(e => e.DcuProdVersion)
                    .HasMaxLength(50)
                    .HasColumnName("DCU_PROD_VERSION");

                entity.Property(e => e.DcuSno)
                    .HasMaxLength(15)
                    .HasColumnName("DCU_SNO");

                entity.Property(e => e.DeviceId).HasColumnName("DEVICE_ID");

                entity.Property(e => e.FeederId).HasColumnName("FEEDER_ID");

                entity.Property(e => e.IsActive)
                    .HasColumnName("IS_ACTIVE")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Latitude)
                    .HasMaxLength(10)
                    .HasColumnName("LATITUDE");

                entity.Property(e => e.Longitude)
                    .HasMaxLength(10)
                    .HasColumnName("LONGITUDE");

                entity.Property(e => e.ManufacturedDate).HasColumnName("MANUFACTURED_DATE");

                entity.Property(e => e.ManufacturerId).HasColumnName("MANUFACTURER_ID");

                entity.Property(e => e.PanId).HasColumnName("PAN_ID");

                entity.Property(e => e.RfId).HasColumnName("RF_ID");

                entity.Property(e => e.SimId).HasColumnName("SIM_ID");

                entity.HasOne(d => d.Manufacturer)
                    .WithMany(p => p.EtDcuDetails)
                    .HasForeignKey(d => d.ManufacturerId)
                    .HasConstraintName("FK_ET_DCU_DETAILS_MANUFACTURERID");

                entity.HasOne(d => d.Sim)
                    .WithMany(p => p.EtDcuDetails)
                    .HasForeignKey(d => d.SimId)
                    .HasConstraintName("FK_ET_DCU_DETAILS_SIMID");
            });

            modelBuilder.Entity<EtInterfaceTypeDetail>(entity =>
            {
                entity.HasKey(e => e.InterfaceTypeId);

                entity.ToTable("ET_INTERFACE_TYPE_DETAILS");

                entity.HasIndex(e => e.InterfaceType, "UK_ET_INTERFACE_TYPE_DETAILS_INTERFACETYPE")
                    .IsUnique();

                entity.Property(e => e.InterfaceTypeId).HasColumnName("INTERFACE_TYPE_ID");

                entity.Property(e => e.InterfaceType)
                    .HasMaxLength(50)
                    .HasColumnName("INTERFACE_TYPE");

                entity.Property(e => e.Sts)
                    .HasColumnName("STS")
                    .HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<EtManufacturerDetail>(entity =>
            {
                entity.HasKey(e => e.MfId)
                    .HasName("PK_ET_MANUFACTURER_DETAILS_MF_ID");

                entity.ToTable("ET_MANUFACTURER_DETAILS");

                entity.HasIndex(e => e.Phone, "UK_ET_MANUFACTURER_DETAILS_PHONE")
                    .IsUnique();

                entity.HasIndex(e => e.MfId, "UK_MANUFACTURER_DETAILS_MANUFACTURERNAME")
                    .IsUnique();

                entity.Property(e => e.MfId).HasColumnName("MF_ID");

                entity.Property(e => e.Crts)
                    .HasColumnName("CRTS")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.ManufacturerName)
                    .HasMaxLength(50)
                    .HasColumnName("MANUFACTURER_NAME");

                entity.Property(e => e.MfAddress)
                    .HasMaxLength(150)
                    .HasColumnName("MF_ADDRESS");

                entity.Property(e => e.Phone)
                    .HasMaxLength(15)
                    .HasColumnName("PHONE");
            });

            modelBuilder.Entity<EtMeterDetail>(entity =>
            {
                entity.HasKey(e => e.MeterId)
                    .HasName("PK_ET_METER_DETAILS_METER_ID");

                entity.ToTable("ET_METER_DETAILS");

                entity.HasIndex(e => e.ModemAddress, "UK_ET_METER_DETAILS_MODEMADDRESS")
                    .IsUnique();

                entity.HasIndex(e => e.SerialNumber, "UK_ET_METER_DETAILS_SERIAL_NUMBER")
                    .IsUnique();

                entity.Property(e => e.MeterId).HasColumnName("METER_ID");

                entity.Property(e => e.AuthenticationKey)
                    .HasMaxLength(50)
                    .HasColumnName("AUTHENTICATION_KEY");

                entity.Property(e => e.ClientSystemTitle)
                    .HasMaxLength(50)
                    .HasColumnName("CLIENT_SYSTEM_TITLE");

                entity.Property(e => e.CommType)
                    .HasMaxLength(15)
                    .HasColumnName("COMM_TYPE");

                entity.Property(e => e.CommisioningDate).HasColumnName("COMMISIONING_DATE");

                entity.Property(e => e.Crts)
                    .HasColumnName("CRTS")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.DcuId).HasColumnName("DCU_ID");

                entity.Property(e => e.DeCommissioningDate).HasColumnName("DE_COMMISSIONING_DATE");

                entity.Property(e => e.DedicatedKey)
                    .HasMaxLength(50)
                    .HasColumnName("DEDICATED_KEY");

                entity.Property(e => e.Description)
                    .HasMaxLength(50)
                    .HasColumnName("DESCRIPTION");

                entity.Property(e => e.DeviceTid).HasColumnName("DEVICE_TID");

                entity.Property(e => e.DtrId).HasColumnName("DTR_ID");

                entity.Property(e => e.EncryptionKey)
                    .HasMaxLength(50)
                    .HasColumnName("ENCRYPTION_KEY");

                entity.Property(e => e.FlagId)
                    .HasMaxLength(50)
                    .HasColumnName("FLAG_ID");

                entity.Property(e => e.Impulse)
                    .HasMaxLength(10)
                    .HasColumnName("IMPULSE");

                entity.Property(e => e.InstallationDate).HasColumnName("INSTALLATION_DATE");

                entity.Property(e => e.InterfaceType)
                    .HasMaxLength(50)
                    .HasColumnName("INTERFACE_TYPE");

                entity.Property(e => e.IsActive)
                    .HasColumnName("IS_ACTIVE")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.LandMark)
                    .HasMaxLength(150)
                    .HasColumnName("LAND_MARK");

                entity.Property(e => e.Latitude)
                    .HasMaxLength(10)
                    .HasColumnName("LATITUDE");

                entity.Property(e => e.Location)
                    .HasMaxLength(150)
                    .HasColumnName("LOCATION");

                entity.Property(e => e.Longitude)
                    .HasMaxLength(10)
                    .HasColumnName("LONGITUDE");

                entity.Property(e => e.MeterAccuracyClass)
                    .HasMaxLength(10)
                    .HasColumnName("METER_ACCURACY_CLASS");

                entity.Property(e => e.MeterCategory)
                    .HasMaxLength(10)
                    .HasColumnName("METER_CATEGORY");

                entity.Property(e => e.MeterCurrentRating)
                    .HasMaxLength(10)
                    .HasColumnName("METER_CURRENT_RATING");

                entity.Property(e => e.MeterFirmwareVersion)
                    .HasMaxLength(10)
                    .HasColumnName("METER_FIRMWARE_VERSION");

                entity.Property(e => e.MeterHardwareVersion)
                    .HasMaxLength(10)
                    .HasColumnName("METER_HARDWARE_VERSION");

                entity.Property(e => e.MeterPicture).HasColumnName("METER_PICTURE");

                entity.Property(e => e.MeterStatus)
                    .HasMaxLength(50)
                    .HasColumnName("METER_STATUS");

                entity.Property(e => e.MeterTypeId).HasColumnName("METER_TYPE_ID");

                entity.Property(e => e.MeterValidFor)
                    .HasMaxLength(10)
                    .HasColumnName("METER_VALID_FOR");

                entity.Property(e => e.MfId).HasColumnName("MF_ID");

                entity.Property(e => e.MfgDate).HasColumnName("MFG_DATE");

                entity.Property(e => e.ModemAddress)
                    .HasColumnType("numeric(15, 0)")
                    .HasColumnName("MODEM_ADDRESS");

                entity.Property(e => e.ModemDescription)
                    .HasMaxLength(50)
                    .HasColumnName("MODEM_DESCRIPTION");

                entity.Property(e => e.MultiplicationFactor)
                    .HasColumnName("MULTIPLICATION_FACTOR")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.OldSystemTitle)
                    .HasMaxLength(50)
                    .HasColumnName("OLD_SYSTEM_TITLE");

                entity.Property(e => e.PaymentMode)
                    .HasMaxLength(50)
                    .HasColumnName("PAYMENT_MODE")
                    .HasDefaultValueSql("(N'POSTPAID')");

                entity.Property(e => e.PhysicalAddress)
                    .HasMaxLength(50)
                    .HasColumnName("PHYSICAL_ADDRESS");

                entity.Property(e => e.PoleId).HasColumnName("POLE_ID");

                entity.Property(e => e.ProductionVersion)
                    .HasMaxLength(10)
                    .HasColumnName("PRODUCTION_VERSION");

                entity.Property(e => e.Protocol)
                    .HasMaxLength(50)
                    .HasColumnName("PROTOCOL");

                entity.Property(e => e.SerialNumber)
                    .HasMaxLength(15)
                    .HasColumnName("SERIAL_NUMBER");

                entity.Property(e => e.SimId).HasColumnName("SIM_ID");

                entity.Property(e => e.SystemTitle)
                    .HasMaxLength(50)
                    .HasColumnName("SYSTEM_TITLE");

                entity.Property(e => e.WarrentyEnd).HasColumnName("WARRENTY_END");

                entity.HasOne(d => d.MeterType)
                    .WithMany(p => p.EtMeterDetails)
                    .HasForeignKey(d => d.MeterTypeId)
                    .HasConstraintName("FK_ET_METER_DETAILS_METER_TYPE_ID");

                entity.HasOne(d => d.Mf)
                    .WithMany(p => p.EtMeterDetails)
                    .HasForeignKey(d => d.MfId)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("FK_ET_METER_DETAILS_MF_ID");

                entity.HasOne(d => d.Sim)
                    .WithMany(p => p.EtMeterDetails)
                    .HasForeignKey(d => d.SimId)
                    .OnDelete(DeleteBehavior.SetNull)
                    .HasConstraintName("FK_ET_METER_DETAILS_SIM_ID");
            });

            modelBuilder.Entity<EtMeterTypeDetail>(entity =>
            {
                entity.HasKey(e => e.MeterTypeId)
                    .HasName("PK_ET_METERTYPE_DETAILS_METER_TYPE_ID");

                entity.ToTable("ET_METER_TYPE_DETAILS");

                entity.HasIndex(e => e.MeterTypeId, "UK_ET_METER_TYPE_DETAILS_METERTYPE")
                    .IsUnique();

                entity.Property(e => e.MeterTypeId).HasColumnName("METER_TYPE_ID");

                entity.Property(e => e.Crts)
                    .HasColumnName("CRTS")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.MeterType)
                    .HasMaxLength(50)
                    .HasColumnName("METER_TYPE");
            });

            modelBuilder.Entity<EtNopDetail>(entity =>
            {
                entity.HasKey(e => e.NopId)
                    .HasName("PK_NOP_DETAILS_NOP_ID");

                entity.ToTable("ET_NOP_DETAILS");

                entity.HasIndex(e => e.NopName, "UK_ET_NOP_DETAILS_NOP_NAME")
                    .IsUnique();

                entity.Property(e => e.NopId).HasColumnName("NOP_ID");

                entity.Property(e => e.Apn)
                    .HasMaxLength(50)
                    .HasColumnName("APN");

                entity.Property(e => e.ApnNo)
                    .HasMaxLength(20)
                    .HasColumnName("APN_NO");

                entity.Property(e => e.CrTs)
                    .HasColumnName("CrTS")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.IsActive).HasColumnName("IS_ACTIVE");

                entity.Property(e => e.NopName)
                    .HasMaxLength(50)
                    .HasColumnName("NOP_NAME");

                entity.Property(e => e.Password)
                    .HasMaxLength(50)
                    .HasColumnName("PASSWORD");

                entity.Property(e => e.UserName)
                    .HasMaxLength(50)
                    .HasColumnName("USER_NAME");
            });

            modelBuilder.Entity<EtPrivilegeDetail>(entity =>
            {
                entity.HasKey(e => e.PrivilegeId);

                entity.ToTable("ET_PRIVILEGE_DETAILS");

                entity.Property(e => e.PrivilegeId).HasColumnName("PRIVILEGE_ID");

                entity.Property(e => e.Crts)
                    .HasColumnName("CRTS")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Privilege)
                    .HasMaxLength(50)
                    .HasColumnName("PRIVILEGE");
            });

            modelBuilder.Entity<EtRoleDetail>(entity =>
            {
                entity.HasKey(e => e.RoleId);

                entity.ToTable("ET_ROLE_DETAILS");

                entity.Property(e => e.RoleId).HasColumnName("ROLE_ID");

                entity.Property(e => e.Crts)
                    .HasColumnName("CRTS")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Name)
                    .HasMaxLength(50)
                    .HasColumnName("NAME");
            });

            modelBuilder.Entity<EtRolePrivRelDetail>(entity =>
            {
                entity.HasKey(e => e.RolePrivilegeRelId);

                entity.ToTable("ET_ROLE_PRIV_REL_DETAILS");

                entity.HasIndex(e => new { e.RoleId, e.PrivilegeId }, "UK_ET_ROLE_PRIV_REL_DETAILS")
                    .IsUnique();

                entity.Property(e => e.RolePrivilegeRelId).HasColumnName("ROLE_PRIVILEGE_REL_ID");

                entity.Property(e => e.Crts)
                    .HasColumnName("CRTS")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.PrivilegeId).HasColumnName("PRIVILEGE_ID");

                entity.Property(e => e.RoleId).HasColumnName("ROLE_ID");

                entity.HasOne(d => d.Privilege)
                    .WithMany(p => p.EtRolePrivRelDetails)
                    .HasForeignKey(d => d.PrivilegeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ET_ROLE_PRIV_REL_DETAILS_ET_PRIVILEGE_DETAILS");

                entity.HasOne(d => d.Role)
                    .WithMany(p => p.EtRolePrivRelDetails)
                    .HasForeignKey(d => d.RoleId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ET_ROLE_PRIV_REL_DETAILS_ET_ROLE_DETAILS");
            });

            modelBuilder.Entity<EtServiceDetail>(entity =>
            {
                entity.HasKey(e => e.ServiceId);

                entity.ToTable("ET_SERVICE_DETAILS");

                entity.HasIndex(e => e.ServiceNo, "UK_ET_SERVICE_DETAILS_SERVICENO")
                    .IsUnique();

                entity.Property(e => e.ServiceId).HasColumnName("SERVICE_ID");

                entity.Property(e => e.Address)
                    .HasMaxLength(250)
                    .HasColumnName("ADDRESS");

                entity.Property(e => e.CategoryId).HasColumnName("CATEGORY_ID");

                entity.Property(e => e.ConsumerId).HasColumnName("CONSUMER_ID");

                entity.Property(e => e.ContractedLoad)
                    .HasColumnType("numeric(18, 2)")
                    .HasColumnName("CONTRACTED_LOAD");

                entity.Property(e => e.Crts)
                    .HasColumnName("CRTS")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.DtrId).HasColumnName("DTR_ID");

                entity.Property(e => e.FeederId).HasColumnName("FEEDER_ID");

                entity.Property(e => e.IsActive).HasColumnName("IS_ACTIVE");

                entity.Property(e => e.Latitude)
                    .HasMaxLength(20)
                    .HasColumnName("LATITUDE");

                entity.Property(e => e.Longitude)
                    .HasMaxLength(20)
                    .HasColumnName("LONGITUDE");

                entity.Property(e => e.MeterId).HasColumnName("METER_ID");

                entity.Property(e => e.OdMeterReading)
                    .HasColumnType("numeric(18, 2)")
                    .HasColumnName("OD_METER_READING");

                entity.Property(e => e.OldMeterNo)
                    .HasMaxLength(15)
                    .HasColumnName("OLD_METER_NO");

                entity.Property(e => e.Phasetype)
                    .HasMaxLength(20)
                    .HasColumnName("PHASETYPE");

                entity.Property(e => e.PoleId)
                    .HasMaxLength(15)
                    .HasColumnName("POLE_ID");

                entity.Property(e => e.ServiceNo)
                    .HasMaxLength(15)
                    .HasColumnName("SERVICE_NO");

                entity.Property(e => e.StatusCode).HasColumnName("STATUS_CODE");

                entity.Property(e => e.UniqueserviceNo)
                    .HasMaxLength(16)
                    .HasColumnName("UNIQUESERVICE_NO");

                entity.HasOne(d => d.Meter)
                    .WithMany(p => p.EtServiceDetails)
                    .HasForeignKey(d => d.MeterId)
                    .HasConstraintName("FK_ET_SERVICE_DETAILS_METERID");
            });

            modelBuilder.Entity<EtSimDetail>(entity =>
            {
                entity.HasKey(e => e.SimId)
                    .HasName("PK_ET_SIM_DETAILS_SIM_ID");

                entity.ToTable("ET_SIM_DETAILS");

                entity.Property(e => e.SimId).HasColumnName("SIM_ID");

                entity.Property(e => e.Crts)
                    .HasColumnName("CRTS")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.IsActive).HasColumnName("IS_ACTIVE");

                entity.Property(e => e.NopId).HasColumnName("NOP_ID");

                entity.Property(e => e.SimGsmno)
                    .HasMaxLength(20)
                    .HasColumnName("SIM_GSMNO");

                entity.Property(e => e.SimIp)
                    .HasMaxLength(100)
                    .HasColumnName("SIM_IP");

                entity.Property(e => e.SimPlan)
                    .HasMaxLength(50)
                    .HasColumnName("SIM_PLAN");

                entity.Property(e => e.SimPort).HasColumnName("SIM_PORT");

                entity.Property(e => e.UniqueSimno)
                    .HasMaxLength(50)
                    .HasColumnName("UNIQUE_SIMNO");

                entity.HasOne(d => d.Nop)
                    .WithMany(p => p.EtSimDetails)
                    .HasForeignKey(d => d.NopId)
                    .HasConstraintName("FK_ET_SIM_DETAILS_NOP_ID");
            });

            modelBuilder.Entity<EtUserDetail>(entity =>
            {
                entity.HasKey(e => e.UserId)
                    .HasName("PK_ET_USER_DETAILS_USERID");

                entity.ToTable("ET_USER_DETAILS");

                entity.HasIndex(e => e.MobileNo, "UK_ET_USER_DETAILS_MOBILENO")
                    .IsUnique();

                entity.HasIndex(e => e.UserName, "UK_ET_USER_DETAILS_USERNAME")
                    .IsUnique();

                entity.Property(e => e.UserId).HasColumnName("USER_ID");

                entity.Property(e => e.Crts)
                    .HasColumnName("CRTS")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Designation)
                    .HasMaxLength(100)
                    .HasColumnName("DESIGNATION");

                entity.Property(e => e.Email)
                    .HasMaxLength(100)
                    .HasColumnName("EMAIL");

                entity.Property(e => e.Firstname)
                    .HasMaxLength(50)
                    .HasColumnName("FIRSTNAME");

                entity.Property(e => e.IsActive).HasColumnName("IS_ACTIVE");

                entity.Property(e => e.LastLoginTimeMdms)
                    .HasColumnName("LAST_LOGIN_TIME_MDMS")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.LastLoginTimeUhes)
                    .HasColumnName("LAST_LOGIN_TIME_UHES")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.LastPasswordChangedTime).HasColumnName("LAST_PASSWORD_CHANGED_TIME");

                entity.Property(e => e.Lastname)
                    .HasMaxLength(50)
                    .HasColumnName("LASTNAME");

                entity.Property(e => e.MobileNo)
                    .HasMaxLength(15)
                    .HasColumnName("MOBILE_NO");

                entity.Property(e => e.Password).HasColumnName("PASSWORD");

                entity.Property(e => e.Salt)
                    .HasMaxLength(300)
                    .HasColumnName("SALT");

                entity.Property(e => e.UserName)
                    .HasMaxLength(50)
                    .HasColumnName("USER_NAME");
            });

            modelBuilder.Entity<EtUserRoleRelDetail>(entity =>
            {
                entity.HasKey(e => e.UserRoleRelId)
                    .HasName("PK_USER_ROLE_REL_DETAILS");

                entity.ToTable("ET_USER_ROLE_REL_DETAILS");

                entity.HasIndex(e => new { e.UserId, e.RoleId }, "UK_USER_ROLE_REL_DETAILS")
                    .IsUnique();

                entity.Property(e => e.UserRoleRelId).HasColumnName("USER_ROLE_REL_ID");

                entity.Property(e => e.Crts)
                    .HasColumnName("CRTS")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.RoleId).HasColumnName("ROLE_ID");

                entity.Property(e => e.UserId).HasColumnName("USER_ID");

                entity.HasOne(d => d.Role)
                    .WithMany(p => p.EtUserRoleRelDetails)
                    .HasForeignKey(d => d.RoleId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ET_USER_ROLE_REL_DETAILS_ET_ROLE_DETAILS");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.EtUserRoleRelDetails)
                    .HasForeignKey(d => d.UserId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ET_USER_ROLE_REL_DETAILS_ET_USER_DETAILS");
            });

            modelBuilder.Entity<FemaleEmployee>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("female_employees");

                entity.Property(e => e.EAge).HasColumnName("e_age");

                entity.Property(e => e.EDept)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("e_dept");

                entity.Property(e => e.EGender)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("e_gender");

                entity.Property(e => e.EId).HasColumnName("e_id");

                entity.Property(e => e.EName)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("e_name");

                entity.Property(e => e.ESalary).HasColumnName("e_salary");
            });

            modelBuilder.Entity<Food>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Food");

                entity.Property(e => e.ItemName).HasMaxLength(50);
            });

            modelBuilder.Entity<Gl70>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("gl_70");

                entity.Property(e => e.DeviceIp)
                    .HasMaxLength(50)
                    .HasColumnName("DEVICE_IP");

                entity.Property(e => e.DeviceSerialNo).HasColumnName("DEVICE_SERIAL_NO");

                entity.Property(e => e.DiffDuration)
                    .HasMaxLength(51)
                    .IsUnicode(false)
                    .HasColumnName("Diff_duration");

                entity.Property(e => e.NwIntEnd).HasColumnName("NW_int_End");

                entity.Property(e => e.NwIntStart).HasColumnName("NW_int_start");

                entity.Property(e => e.StructureCode).HasColumnName("STRUCTURE_CODE");

                entity.Property(e => e.Sts).HasColumnName("STS");

                entity.Property(e => e.TransformerSno).HasColumnName("TRANSFORMER_SNO");
            });

            modelBuilder.Entity<Gl701>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("gl701");

                entity.Property(e => e.DeviceIp).HasMaxLength(50);

                entity.Property(e => e.DeviceSerialNo)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.NwIntEnd).HasColumnName("Nw_int_end");

                entity.Property(e => e.NwIntStart).HasColumnName("Nw_int_start");

                entity.Property(e => e.StructureCode).HasMaxLength(50);

                entity.Property(e => e.Transformersno)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Gl70network>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("GL_70network");

                entity.Property(e => e.DeviceIp).HasMaxLength(50);

                entity.Property(e => e.DeviceSerialNo)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.NwIntEnd).HasColumnName("Nw_int_end");

                entity.Property(e => e.NwIntStart).HasColumnName("Nw_int_start");

                entity.Property(e => e.StructureCode).HasMaxLength(50);

                entity.Property(e => e.Transformersno)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Gl70network1>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("GL70NETWORK");

                entity.Property(e => e.DeviceIp)
                    .HasMaxLength(50)
                    .HasColumnName("DEVICE_IP");

                entity.Property(e => e.DeviceSerialNo).HasColumnName("DEVICE_SERIAL_NO");

                entity.Property(e => e.NwIntEnd).HasColumnName("NW_int_End");

                entity.Property(e => e.NwIntStart).HasColumnName("NW_int_start");

                entity.Property(e => e.StructureCode).HasColumnName("STRUCTURE_CODE");

                entity.Property(e => e.Sts).HasColumnName("STS");

                entity.Property(e => e.TransformerSno).HasColumnName("TRANSFORMER_SNO");
            });

            modelBuilder.Entity<Gl70network11>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("GL70NETWORK11");

                entity.Property(e => e.DeviceIp)
                    .HasMaxLength(50)
                    .HasColumnName("DEVICE_IP");

                entity.Property(e => e.DeviceSerialNo).HasColumnName("DEVICE_SERIAL_NO");

                entity.Property(e => e.Duration)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.NwIntEnd).HasColumnName("NW_int_End");

                entity.Property(e => e.NwIntStart).HasColumnName("NW_int_start");

                entity.Property(e => e.StructureCode).HasColumnName("STRUCTURE_CODE");

                entity.Property(e => e.Sts).HasColumnName("STS");

                entity.Property(e => e.TimeDiffSec).HasColumnName("Time_diff_sec");

                entity.Property(e => e.TransformerSno).HasColumnName("TRANSFORMER_SNO");
            });

            modelBuilder.Entity<GrtEmp>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("grt_emp");

                entity.Property(e => e.Empno).HasColumnName("empno");

                entity.Property(e => e.Ename)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("ename");
            });

            modelBuilder.Entity<Hardware>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("hardware");

                entity.Property(e => e.EDept)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("e_dept");

                entity.Property(e => e.EId).HasColumnName("e_id");

                entity.Property(e => e.EName)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("e_name");

                entity.Property(e => e.ESal).HasColumnName("e_sal");
            });

            modelBuilder.Entity<Hierarcy>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("HIERARCY");

                entity.Property(e => e.CommisioningDate).HasColumnName("COMMISIONING_DATE");

                entity.Property(e => e.InstallationDate).HasColumnName("INSTALLATION_DATE");

                entity.Property(e => e.ManufacturerName)
                    .HasMaxLength(50)
                    .HasColumnName("MANUFACTURER_NAME");

                entity.Property(e => e.MfgDate).HasColumnName("MFG_DATE");

                entity.Property(e => e.SerialNumber)
                    .HasMaxLength(15)
                    .HasColumnName("SERIAL_NUMBER");

                entity.Property(e => e.SimGsmno)
                    .HasMaxLength(20)
                    .HasColumnName("SIM_GSMNO");

                entity.Property(e => e.SimIp)
                    .HasMaxLength(100)
                    .HasColumnName("SIM_IP");
            });

            modelBuilder.Entity<HirerarchyLevel>(entity =>
            {
                entity.ToTable("Hirerarchy_level");

                entity.Property(e => e.HirerarchyLevelId).HasColumnName("Hirerarchy_levelID");

                entity.Property(e => e.LevelId).HasColumnName("LevelID");

                entity.Property(e => e.LevelName).HasMaxLength(100);

                entity.Property(e => e.LevelType).HasMaxLength(50);

                entity.Property(e => e.Sts)
                    .HasColumnName("STS")
                    .HasDefaultValueSql("(getdate())");

                entity.HasOne(d => d.Level)
                    .WithMany(p => p.InverseLevel)
                    .HasForeignKey(d => d.LevelId)
                    .HasConstraintName("FK__Hirerarch__Level__668030F6");
            });

            modelBuilder.Entity<HtDataParamTmultct>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("HT_DataParamTMULTCT");

                entity.Property(e => e.AbnormalExternalMagnetInfluence)
                    .HasMaxLength(50)
                    .HasColumnName("Abnormal_external_magnet_influence");

                entity.Property(e => e.AbnormalExternalMagnetInfluenceTs).HasColumnName("Abnormal_external_magnet_influence_TS");

                entity.Property(e => e.ActionAtAmbtemp).HasColumnName("ActionAtAMBTemp");

                entity.Property(e => e.ActionAtAmbtempMedium).HasColumnName("ActionAtAMBTempMedium");

                entity.Property(e => e.ActionEnableDisablebitdescription).HasMaxLength(50);

                entity.Property(e => e.ActiveFirmwareIdentifier).HasMaxLength(50);

                entity.Property(e => e.ActivePowerImport).HasColumnType("numeric(18, 2)");

                entity.Property(e => e.AmbTemperature)
                    .HasMaxLength(50)
                    .HasColumnName("AMB_Temperature");

                entity.Property(e => e.AmbTemperatureTs).HasColumnName("AMB_Temperature_TS");

                entity.Property(e => e.AmbientTemperatureCalibration).HasMaxLength(100);

                entity.Property(e => e.AmbientTemperatureThresholdHigh).HasMaxLength(100);

                entity.Property(e => e.AmbientTemperatureThresholdMedium).HasMaxLength(100);

                entity.Property(e => e.AmbtempHighOccurencePersistance).HasColumnName("AMBTempHighOccurencePersistance");

                entity.Property(e => e.AmbtempHighOccurrence)
                    .HasColumnType("numeric(18, 2)")
                    .HasColumnName("AMBTempHighOccurrence");

                entity.Property(e => e.AmbtempHighRestoration)
                    .HasColumnType("numeric(18, 2)")
                    .HasColumnName("AMBTempHighRestoration");

                entity.Property(e => e.AmbtempHighRestorationPersistance).HasColumnName("AMBTempHighRestorationPersistance");

                entity.Property(e => e.AmbtempMediumOccurencePersistance).HasColumnName("AMBTempMediumOccurencePersistance");

                entity.Property(e => e.AmbtempMediumOccurrence)
                    .HasColumnType("numeric(18, 2)")
                    .HasColumnName("AMBTempMediumOccurrence");

                entity.Property(e => e.AmbtempMediumRestoration)
                    .HasColumnType("numeric(18, 2)")
                    .HasColumnName("AMBTempMediumRestoration");

                entity.Property(e => e.AmbtempMediumRestorationPersistance).HasColumnName("AMBTempMediumRestorationPersistance");

                entity.Property(e => e.ApparentPowerkVa)
                    .HasColumnType("numeric(18, 2)")
                    .HasColumnName("ApparentPowerkVA");

                entity.Property(e => e.AvgCurrentIb).HasColumnType("numeric(18, 2)");

                entity.Property(e => e.AvgCurrentIr).HasColumnType("numeric(18, 2)");

                entity.Property(e => e.AvgCurrentIy).HasColumnType("numeric(18, 2)");

                entity.Property(e => e.AvgVoltageVbn).HasColumnType("numeric(18, 2)");

                entity.Property(e => e.AvgVoltageVrn).HasColumnType("numeric(18, 2)");

                entity.Property(e => e.AvgVoltageVyn).HasColumnType("numeric(18, 2)");

                entity.Property(e => e.BillingDateChanged)
                    .HasMaxLength(25)
                    .HasColumnName("Billing_Date_changed");

                entity.Property(e => e.BillingDateChangedTs).HasColumnName("Billing_Date_changed_TS");

                entity.Property(e => e.BillingDateLastReset).IsUnicode(false);

                entity.Property(e => e.BlockEnergyVahExport)
                    .HasColumnType("numeric(18, 2)")
                    .HasColumnName("BlockEnergyVAhExport");

                entity.Property(e => e.BlockEnergyVahImport)
                    .HasColumnType("numeric(18, 2)")
                    .HasColumnName("BlockEnergyVAhImport");

                entity.Property(e => e.BlockEnergyWhExport).HasColumnType("numeric(18, 2)");

                entity.Property(e => e.BlockEnergyWhImport).HasColumnType("numeric(18, 2)");

                entity.Property(e => e.BlockEnergykvarhLagIiexport)
                    .HasColumnType("numeric(18, 2)")
                    .HasColumnName("BlockEnergykvarhLagIIExport");

                entity.Property(e => e.BlockEnergykvarhLagIimport)
                    .HasColumnType("numeric(18, 2)")
                    .HasColumnName("BlockEnergykvarhLagIImport");

                entity.Property(e => e.BlockEnergykvarhLeadIiiimport)
                    .HasColumnType("numeric(18, 2)")
                    .HasColumnName("BlockEnergykvarhLeadIIIImport");

                entity.Property(e => e.BlockEnergykvarhLeadIvexport)
                    .HasColumnType("numeric(18, 2)")
                    .HasColumnName("BlockEnergykvarhLeadIVExport");

                entity.Property(e => e.BlockLoadInterval).HasMaxLength(50);

                entity.Property(e => e.BphaseContactorCoilSupplyAlert)
                    .HasMaxLength(50)
                    .HasColumnName("BPhase_Contactor_Coil_Supply_Alert");

                entity.Property(e => e.BphaseContactorCoilSupplyAlertTs).HasColumnName("BPhase_Contactor_Coil_Supply_Alert_TS");

                entity.Property(e => e.BphaseCtOpen)
                    .HasMaxLength(50)
                    .HasColumnName("BPhase_CT_Open");

                entity.Property(e => e.BphaseCtOpenTs).HasColumnName("BPhase_CT_Open_TS");

                entity.Property(e => e.BphaseCtReverse)
                    .HasMaxLength(50)
                    .HasColumnName("BPhase_CT_reverse");

                entity.Property(e => e.BphaseCtReverseTs).HasColumnName("BPhase_CT_reverse_TS");

                entity.Property(e => e.BphasePotential)
                    .HasMaxLength(35)
                    .HasColumnName("BPhase_Potential");

                entity.Property(e => e.BphasePotentialTs).HasColumnName("BPhase_Potential_TS");

                entity.Property(e => e.Category).HasMaxLength(50);

                entity.Property(e => e.Channel0L0currentNeutralAvgCurrent)
                    .HasMaxLength(50)
                    .HasColumnName("Channel0L0CurrentNeutralAvgCurrent");

                entity.Property(e => e.Channel0L1reactivePowerQ1q2timeIntegral)
                    .HasMaxLength(50)
                    .HasColumnName("Channel0L1ReactivePowerQ1Q2TimeIntegral");

                entity.Property(e => e.Channel0L2apparentPowerQ1q4timeIntegral)
                    .HasMaxLength(50)
                    .HasColumnName("Channel0L2ApparentPowerQ1Q4TimeIntegral");

                entity.Property(e => e.Channel0L3reactivePowerQ1q2timeIntegral)
                    .HasMaxLength(50)
                    .HasColumnName("Channel0L3ReactivePowerQ1Q2TimeIntegral");

                entity.Property(e => e.Channel0SumLiActivePowerQ1q4max)
                    .HasMaxLength(50)
                    .HasColumnName("Channel0SumLiActivePowerQ1Q4Max");

                entity.Property(e => e.Channel0SumLiActivePowerQ1q4minusQ2q3timeIntegral)
                    .HasMaxLength(50)
                    .HasColumnName("Channel0SumLiActivePowerQ1Q4MinusQ2Q3TimeIntegral");

                entity.Property(e => e.Channel0SumLiApparentPowerQ1q4max)
                    .HasMaxLength(50)
                    .HasColumnName("Channel0SumLiApparentPowerQ1Q4Max");

                entity.Property(e => e.Cjid)
                    .HasMaxLength(25)
                    .IsUnicode(false)
                    .HasColumnName("CJID");

                entity.Property(e => e.CommunicationModemStatusByte)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CommunicationModule)
                    .HasMaxLength(50)
                    .HasColumnName("Communication_Module");

                entity.Property(e => e.CommunicationModuleTs).HasColumnName("Communication_Module_TS");

                entity.Property(e => e.ConfigurationChangeToForwardedModeOnlyMode)
                    .HasMaxLength(50)
                    .HasColumnName("Configuration_change_to_Forwarded_mode_only_mode");

                entity.Property(e => e.ConfigurationChangeToForwardedModeOnlyModeTs).HasColumnName("Configuration_change_to_Forwarded_mode_only_mode_TS");

                entity.Property(e => e.ConfigurationChangeToImportExportMode)
                    .HasMaxLength(50)
                    .HasColumnName("Configuration_change_to_Import_Export_mode");

                entity.Property(e => e.ConfigurationChangeToImportExportModeTs).HasColumnName("Configuration_change_to_Import_Export_mode_TS");

                entity.Property(e => e.ContactorAlert)
                    .HasMaxLength(50)
                    .HasColumnName("Contactor_Alert");

                entity.Property(e => e.ContactorAlertTs).HasColumnName("Contactor_Alert_TS");

                entity.Property(e => e.CtBypass)
                    .HasMaxLength(30)
                    .HasColumnName("CT_Bypass");

                entity.Property(e => e.CtBypassTs).HasColumnName("CT_Bypass_TS");

                entity.Property(e => e.CumEnergykVarhLdImport)
                    .HasColumnType("numeric(18, 2)")
                    .HasColumnName("CumEnergykVArhLdImport");

                entity.Property(e => e.CumEnergykVarhLgImport)
                    .HasColumnType("numeric(18, 2)")
                    .HasColumnName("CumEnergykVArhLgImport");

                entity.Property(e => e.CumulativeEnergykVahForTz1).HasColumnName("CumulativeEnergykVAhForTZ1");

                entity.Property(e => e.CumulativeEnergykVahForTz2).HasColumnName("CumulativeEnergykVAhForTZ2");

                entity.Property(e => e.CumulativeEnergykVahForTz3).HasColumnName("CumulativeEnergykVAhForTZ3");

                entity.Property(e => e.CumulativeEnergykVahForTz4).HasColumnName("CumulativeEnergykVAhForTZ4");

                entity.Property(e => e.CumulativeEnergykVahForTz5).HasColumnName("CumulativeEnergykVAhForTZ5");

                entity.Property(e => e.CumulativeEnergykVahForTz6).HasColumnName("CumulativeEnergykVAhForTZ6");

                entity.Property(e => e.CumulativeEnergykVahForTz7).HasColumnName("CumulativeEnergykVAhForTZ7");

                entity.Property(e => e.CumulativeEnergykVahForTz8).HasColumnName("CumulativeEnergykVAhForTZ8");

                entity.Property(e => e.CumulativeEnergykVahexport)
                    .HasColumnType("numeric(18, 2)")
                    .HasColumnName("CumulativeEnergykVAhexport");

                entity.Property(e => e.CumulativeEnergykVahimport)
                    .HasColumnType("numeric(18, 2)")
                    .HasColumnName("CumulativeEnergykVAhimport");

                entity.Property(e => e.CumulativeEnergykWhForTz1).HasColumnName("CumulativeEnergykWhForTZ1");

                entity.Property(e => e.CumulativeEnergykWhForTz2).HasColumnName("CumulativeEnergykWhForTZ2");

                entity.Property(e => e.CumulativeEnergykWhForTz3).HasColumnName("CumulativeEnergykWhForTZ3");

                entity.Property(e => e.CumulativeEnergykWhForTz4).HasColumnName("CumulativeEnergykWhForTZ4");

                entity.Property(e => e.CumulativeEnergykWhForTz5).HasColumnName("CumulativeEnergykWhForTZ5");

                entity.Property(e => e.CumulativeEnergykWhForTz6).HasColumnName("CumulativeEnergykWhForTZ6");

                entity.Property(e => e.CumulativeEnergykWhForTz7).HasColumnName("CumulativeEnergykWhForTZ7");

                entity.Property(e => e.CumulativeEnergykWhForTz8).HasColumnName("CumulativeEnergykWhForTZ8");

                entity.Property(e => e.CumulativeEnergykWhexport).HasColumnType("numeric(18, 2)");

                entity.Property(e => e.CumulativeEnergykWhimport).HasColumnType("numeric(18, 2)");

                entity.Property(e => e.CumulativeEnergykvarhLagIiexport)
                    .HasColumnType("numeric(18, 2)")
                    .HasColumnName("CumulativeEnergykvarhLagIIExport");

                entity.Property(e => e.CumulativeEnergykvarhLagIimport)
                    .HasColumnType("numeric(18, 2)")
                    .HasColumnName("CumulativeEnergykvarhLagIImport");

                entity.Property(e => e.CumulativeEnergykvarhLeadIiiimport)
                    .HasColumnType("numeric(18, 2)")
                    .HasColumnName("CumulativeEnergykvarhLeadIIIImport");

                entity.Property(e => e.CumulativeEnergykvarhLeadIvexport)
                    .HasColumnType("numeric(18, 2)")
                    .HasColumnName("CumulativeEnergykvarhLeadIVExport");

                entity.Property(e => e.CumulativeFundamentalEnergyKwhImport)
                    .HasColumnType("numeric(18, 2)")
                    .HasColumnName("CumulativeFundamentalEnergyKWhImport");

                entity.Property(e => e.CumulativeFundamentalEnergykWhExport).HasColumnType("numeric(18, 2)");

                entity.Property(e => e.CurrentBphase).HasColumnType("numeric(18, 2)");

                entity.Property(e => e.CurrentRating).HasMaxLength(50);

                entity.Property(e => e.CurrentRphase).HasColumnType("numeric(18, 2)");

                entity.Property(e => e.CurrentUnbalance)
                    .HasMaxLength(35)
                    .HasColumnName("Current_Unbalance");

                entity.Property(e => e.CurrentUnbalanceTs).HasColumnName("Current_Unbalance_TS");

                entity.Property(e => e.CurrentYphase).HasColumnType("numeric(18, 2)");

                entity.Property(e => e.Date).HasMaxLength(50);

                entity.Property(e => e.DateAndTimeChanged)
                    .HasMaxLength(30)
                    .HasColumnName("Date_and_Time_changed");

                entity.Property(e => e.DateAndTimeChangedTs).HasColumnName("Date_and_Time_changed_TS");

                entity.Property(e => e.DemandIntegrationPeriodChanged)
                    .HasMaxLength(50)
                    .HasColumnName("Demand_integration_Period_Changed");

                entity.Property(e => e.DemandIntegrationPeriodChangedTs).HasColumnName("Demand_integration_Period_changed_TS");

                entity.Property(e => e.DeviceId)
                    .HasMaxLength(50)
                    .HasColumnName("DeviceID");

                entity.Property(e => e.Dip)
                    .HasMaxLength(50)
                    .HasColumnName("DIP");

                entity.Property(e => e.Dtrid).HasColumnName("DTRId");

                entity.Property(e => e.EmeventCode).HasColumnName("EMEventCode");

                entity.Property(e => e.EmeventStatusWord).HasColumnName("EMEventStatusWord");

                entity.Property(e => e.EnableDisable).HasMaxLength(100);

                entity.Property(e => e.EventCounterForTmurelatedEvents).HasColumnName("EventCounterForTMURelatedEvents");

                entity.Property(e => e.EventRegisterChanged)
                    .HasMaxLength(25)
                    .HasColumnName("Event_Register_Changed");

                entity.Property(e => e.EventRegisterChangedTs).HasColumnName("Event_Register_Changed_TS");

                entity.Property(e => e.Frequency).HasColumnType("numeric(18, 2)");

                entity.Property(e => e.GlobalKeyChange)
                    .HasMaxLength(50)
                    .HasColumnName("Global_key_change");

                entity.Property(e => e.GlobalKeyChangeTs).HasColumnName("Global_key_change_TS");

                entity.Property(e => e.GsmrssisignalStrength)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("GSMRSSISignalStrength");

                entity.Property(e => e.HlsKeyFwChange)
                    .HasMaxLength(25)
                    .HasColumnName("HLS_key_FW_change");

                entity.Property(e => e.HlsKeyFwChangeTs).HasColumnName("HLS_key_FW_change_TS");

                entity.Property(e => e.HlsKeyUsChange)
                    .HasMaxLength(25)
                    .HasColumnName("HLS_key_US_change");

                entity.Property(e => e.HlsKeyUsChangeTs).HasColumnName("HLS_key_US_change_TS");

                entity.Property(e => e.HtDataParamTmultctid)
                    .HasColumnType("numeric(25, 0)")
                    .HasColumnName("HT_DataParamTMULTCTId");

                entity.Property(e => e.ImageActivationDateAndTimeChanged)
                    .HasMaxLength(50)
                    .HasColumnName("Image_activation_Date_and_time_changed");

                entity.Property(e => e.ImageActivationDateAndTimeChangedTs).HasColumnName("Image_activation_Date_and_time_changed_TS");

                entity.Property(e => e.L1signedPowerFactorRphase)
                    .HasColumnType("numeric(18, 2)")
                    .HasColumnName("L1SignedPowerFactorRPhase");

                entity.Property(e => e.L1voltageVrn)
                    .HasColumnType("numeric(18, 2)")
                    .HasColumnName("L1VoltageVRN");

                entity.Property(e => e.L2signedPowerFactorYphase)
                    .HasColumnType("numeric(18, 2)")
                    .HasColumnName("L2SignedPowerFactorYPhase");

                entity.Property(e => e.L2voltageVyn)
                    .HasColumnType("numeric(18, 2)")
                    .HasColumnName("L2VoltageVYN");

                entity.Property(e => e.L3signedPowerFactorBphase)
                    .HasColumnType("numeric(18, 2)")
                    .HasColumnName("L3SignedPowerFactorBPhase");

                entity.Property(e => e.L3voltageVbn)
                    .HasColumnType("numeric(18, 2)")
                    .HasColumnName("L3VoltageVBN");

                entity.Property(e => e.LlsSecretMrChange)
                    .HasMaxLength(25)
                    .HasColumnName("LLS_secret_MR_change");

                entity.Property(e => e.LlsSecretMrChangeTs).HasColumnName("LLS_secret_MR_change_TS");

                entity.Property(e => e.LoadLimitFunctionStatus).HasMaxLength(50);

                entity.Property(e => e.LoadLimitValueinkW).HasColumnType("numeric(18, 2)");

                entity.Property(e => e.LoadSwitch)
                    .HasMaxLength(50)
                    .HasColumnName("Load_Switch");

                entity.Property(e => e.LoadSwitchTs).HasColumnName("Load_Switch_TS");

                entity.Property(e => e.LocalRemote).HasMaxLength(50);

                entity.Property(e => e.LowPf)
                    .HasMaxLength(50)
                    .HasColumnName("Low_PF");

                entity.Property(e => e.LowPfTs).HasColumnName("Low_PF_TS");

                entity.Property(e => e.LowVoltagePhase)
                    .HasMaxLength(50)
                    .HasColumnName("Low_Voltage_Phase");

                entity.Property(e => e.LowVoltagePhaseTs).HasColumnName("Low_Voltage_Phase_TS");

                entity.Property(e => e.ManufacturerName).HasMaxLength(100);

                entity.Property(e => e.MaximumDemandkVadtexport).HasColumnName("MaximumDemandkVADTExport");

                entity.Property(e => e.MaximumDemandkVaexport)
                    .HasColumnType("numeric(18, 2)")
                    .HasColumnName("MaximumDemandkVAExport");

                entity.Property(e => e.MaximumDemandkVaimport)
                    .HasColumnType("numeric(18, 2)")
                    .HasColumnName("MaximumDemandkVAImport");

                entity.Property(e => e.MaximumDemandkWdtexport)
                    .HasMaxLength(50)
                    .HasColumnName("MaximumDemandkWDTExport");

                entity.Property(e => e.MaximumDemandkWexport)
                    .HasColumnType("numeric(18, 2)")
                    .HasColumnName("MaximumDemandkWExport");

                entity.Property(e => e.MaximumDemandkWimport)
                    .HasColumnType("numeric(18, 2)")
                    .HasColumnName("MaximumDemandkWImport");

                entity.Property(e => e.MdReset)
                    .HasMaxLength(20)
                    .HasColumnName("MD_reset");

                entity.Property(e => e.MdResetTs).HasColumnName("MD_reset_TS");

                entity.Property(e => e.MdkVaimport)
                    .HasColumnType("numeric(18, 2)")
                    .HasColumnName("MDkVAImport");

                entity.Property(e => e.MdkVaimportTimeStamp).HasColumnName("MDkVAImportTimeStamp");

                entity.Property(e => e.MdkWimport)
                    .HasColumnType("numeric(18, 2)")
                    .HasColumnName("MDkWImport");

                entity.Property(e => e.MdkWimportTimeStamp).HasColumnName("MDkWImportTimeStamp");

                entity.Property(e => e.Mdkvat1)
                    .HasColumnType("numeric(18, 2)")
                    .HasColumnName("MDKVAT1");

                entity.Property(e => e.Mdkvat1timeStamp).HasColumnName("MDKVAT1TimeStamp");

                entity.Property(e => e.Mdkvat2)
                    .HasColumnType("numeric(18, 2)")
                    .HasColumnName("MDKVAT2");

                entity.Property(e => e.Mdkvat2timeStamp).HasColumnName("MDKVAT2TimeStamp");

                entity.Property(e => e.Mdkvat3)
                    .HasColumnType("numeric(18, 2)")
                    .HasColumnName("MDKVAT3");

                entity.Property(e => e.Mdkvat3timeStamp).HasColumnName("MDKVAT3TimeStamp");

                entity.Property(e => e.Mdkvat4)
                    .HasColumnType("numeric(18, 2)")
                    .HasColumnName("MDKVAT4");

                entity.Property(e => e.Mdkvat4timeStamp).HasColumnName("MDKVAT4TimeStamp");

                entity.Property(e => e.Mdkvat5)
                    .HasColumnType("numeric(18, 2)")
                    .HasColumnName("MDKVAT5");

                entity.Property(e => e.Mdkvat5timeStamp).HasColumnName("MDKVAT5TimeStamp");

                entity.Property(e => e.Mdkvat6)
                    .HasColumnType("numeric(18, 2)")
                    .HasColumnName("MDKVAT6");

                entity.Property(e => e.Mdkvat6timeStamp).HasColumnName("MDKVAT6TimeStamp");

                entity.Property(e => e.Mdkvat7)
                    .HasColumnType("numeric(18, 2)")
                    .HasColumnName("MDKVAT7");

                entity.Property(e => e.Mdkvat7timeStamp).HasColumnName("MDKVAT7TimeStamp");

                entity.Property(e => e.Mdkvat8)
                    .HasColumnType("numeric(18, 2)")
                    .HasColumnName("MDKVAT8");

                entity.Property(e => e.Mdkvat8timeStamp).HasColumnName("MDKVAT8TimeStamp");

                entity.Property(e => e.Mdkwt1)
                    .HasColumnType("numeric(18, 2)")
                    .HasColumnName("MDKWT1");

                entity.Property(e => e.Mdkwt1timeStamp).HasColumnName("MDKWT1TimeStamp");

                entity.Property(e => e.Mdkwt2)
                    .HasColumnType("numeric(18, 2)")
                    .HasColumnName("MDKWT2");

                entity.Property(e => e.Mdkwt2timeStamp).HasColumnName("MDKWT2TimeStamp");

                entity.Property(e => e.Mdkwt3)
                    .HasColumnType("numeric(18, 2)")
                    .HasColumnName("MDKWT3");

                entity.Property(e => e.Mdkwt3timeStamp).HasColumnName("MDKWT3TimeStamp");

                entity.Property(e => e.Mdkwt4)
                    .HasColumnType("numeric(18, 2)")
                    .HasColumnName("MDKWT4");

                entity.Property(e => e.Mdkwt4timeStamp).HasColumnName("MDKWT4TimeStamp");

                entity.Property(e => e.Mdkwt5)
                    .HasColumnType("numeric(18, 2)")
                    .HasColumnName("MDKWT5");

                entity.Property(e => e.Mdkwt5timeStamp).HasColumnName("MDKWT5TimeStamp");

                entity.Property(e => e.Mdkwt6)
                    .HasColumnType("numeric(18, 2)")
                    .HasColumnName("MDKWT6");

                entity.Property(e => e.Mdkwt6timeStamp).HasColumnName("MDKWT6TimeStamp");

                entity.Property(e => e.Mdkwt7)
                    .HasColumnType("numeric(18, 2)")
                    .HasColumnName("MDKWT7");

                entity.Property(e => e.Mdkwt7timeStamp).HasColumnName("MDKWT7TimeStamp");

                entity.Property(e => e.Mdkwt8)
                    .HasColumnType("numeric(18, 2)")
                    .HasColumnName("MDKWT8");

                entity.Property(e => e.Mdkwt8timeStamp).HasColumnName("MDKWT8TimeStamp");

                entity.Property(e => e.MeterCoverOpening)
                    .HasMaxLength(50)
                    .HasColumnName("Meter_Cover_Opening");

                entity.Property(e => e.MeterCoverOpeningTs).HasColumnName("Meter_Cover_Opening_TS");

                entity.Property(e => e.MeterSerialNumber).HasMaxLength(50);

                entity.Property(e => e.MeterType3P3w3p4w)
                    .HasMaxLength(50)
                    .HasColumnName("MeterType3P3W3P4W");

                entity.Property(e => e.MeterYearofManufacture).HasMaxLength(50);

                entity.Property(e => e.MeteringModeChanged)
                    .HasMaxLength(25)
                    .HasColumnName("Metering_mode_changed");

                entity.Property(e => e.MeteringModeChangedTs).HasColumnName("Metering_mode_changed_TS");

                entity.Property(e => e.NetEnergykVah)
                    .HasColumnType("numeric(18, 2)")
                    .HasColumnName("NetEnergykVAh");

                entity.Property(e => e.NetEnergykVarhLag)
                    .HasColumnType("numeric(18, 2)")
                    .HasColumnName("NetEnergykVArhLag");

                entity.Property(e => e.NetEnergykVarhLead)
                    .HasColumnType("numeric(18, 0)")
                    .HasColumnName("NetEnergykVArhLead");

                entity.Property(e => e.NetEnergykWh).HasColumnType("numeric(18, 2)");

                entity.Property(e => e.NeutralCurrent).HasColumnType("numeric(18, 2)");

                entity.Property(e => e.NeutralDisturbance)
                    .HasMaxLength(50)
                    .HasColumnName("Neutral_disturbance");

                entity.Property(e => e.NeutralDisturbanceTs).HasColumnName("Neutral_disturbance_TS");

                entity.Property(e => e.NewFirmwareActivated)
                    .HasMaxLength(25)
                    .HasColumnName("New_firmware_activated");

                entity.Property(e => e.NewFirmwareActivatedTs).HasColumnName("New_firmware_activated_TS");

                entity.Property(e => e.OilLevel)
                    .HasMaxLength(50)
                    .HasColumnName("Oil_Level");

                entity.Property(e => e.OilLevelTs).HasColumnName("Oil_Level_TS");

                entity.Property(e => e.OilTempHighOccurrence).HasColumnType("numeric(18, 2)");

                entity.Property(e => e.OilTempHighRestoration).HasColumnType("numeric(18, 2)");

                entity.Property(e => e.OilTempMediumOccurrence).HasColumnType("numeric(18, 2)");

                entity.Property(e => e.OilTempMediumRestoration).HasColumnType("numeric(18, 2)");

                entity.Property(e => e.OilTemperature)
                    .HasMaxLength(50)
                    .HasColumnName("Oil_Temperature");

                entity.Property(e => e.OilTemperatureCalibration).HasMaxLength(100);

                entity.Property(e => e.OilTemperatureThresholdHigh).HasMaxLength(100);

                entity.Property(e => e.OilTemperatureThresholdMedium).HasMaxLength(100);

                entity.Property(e => e.OilTemperatureTs).HasColumnName("Oil_Temperature_TS");

                entity.Property(e => e.OverCurrentPhase)
                    .HasMaxLength(50)
                    .HasColumnName("Over_Current_Phase");

                entity.Property(e => e.OverCurrentPhaseTs).HasColumnName("Over_Current_Phase_TS");

                entity.Property(e => e.OverVoltagePhase)
                    .HasMaxLength(50)
                    .HasColumnName("Over_Voltage_Phase");

                entity.Property(e => e.OverVoltagePhaseTs).HasColumnName("Over_Voltage_Phase_TS");

                entity.Property(e => e.Overload).HasMaxLength(50);

                entity.Property(e => e.OverloadTs).HasColumnName("Overload_TS");

                entity.Property(e => e.PowerAlert)
                    .HasMaxLength(50)
                    .HasColumnName("Power_Alert");

                entity.Property(e => e.PowerAlertTs).HasColumnName("Power_Alert_TS");

                entity.Property(e => e.PowerFailure)
                    .HasMaxLength(50)
                    .HasColumnName("Power_failure");

                entity.Property(e => e.PowerFailureTs).HasColumnName("Power_failure_TS");

                entity.Property(e => e.ProfileCapturePeriod).HasMaxLength(50);

                entity.Property(e => e.ProfileCapturePeriodChanged)
                    .HasMaxLength(35)
                    .HasColumnName("Profile_capture_period_changed");

                entity.Property(e => e.ProfileCapturePeriodChangedTs).HasColumnName("Profile_capture_period_changed_TS");

                entity.Property(e => e.PushSetupId).HasMaxLength(50);

                entity.Property(e => e.RelayAlert)
                    .HasMaxLength(50)
                    .HasColumnName("Relay_Alert");

                entity.Property(e => e.RelayAlertTs).HasColumnName("Relay_Alert_TS");

                entity.Property(e => e.RelayStatusBphase)
                    .HasMaxLength(50)
                    .HasColumnName("RelayStatusBPhase");

                entity.Property(e => e.RelayStatusNeutral).HasMaxLength(50);

                entity.Property(e => e.RelayStatusRphase)
                    .HasMaxLength(50)
                    .HasColumnName("RelayStatusRPhase");

                entity.Property(e => e.RelayStatusYphase)
                    .HasMaxLength(50)
                    .HasColumnName("RelayStatusYPhase");

                entity.Property(e => e.RphaseContactorCoilSupplyAlert)
                    .HasMaxLength(50)
                    .HasColumnName("RPhase_Contactor_Coil_Supply_Alert");

                entity.Property(e => e.RphaseContactorCoilSupplyAlertTs).HasColumnName("RPhase_Contactor_Coil_Supply_Alert_TS");

                entity.Property(e => e.RphaseContactorCoilSupplyOnAlert)
                    .HasMaxLength(50)
                    .HasColumnName("RPhase_Contactor_Coil_Supply_ON_Alert");

                entity.Property(e => e.RphaseContactorCoilSupplyOnAlertTs).HasColumnName("RPhase_Contactor_Coil_Supply_ON_Alert_TS");

                entity.Property(e => e.RphaseCtOpen)
                    .HasMaxLength(50)
                    .HasColumnName("RPhase_CT_Open");

                entity.Property(e => e.RphaseCtOpenTs).HasColumnName("RPhase_CT_Open_TS");

                entity.Property(e => e.RphaseCtReverse)
                    .HasMaxLength(50)
                    .HasColumnName("RPhase_CT_reverse");

                entity.Property(e => e.RphaseCtReverseTs).HasColumnName("RPhase_CT_reverse_TS");

                entity.Property(e => e.RphasePotential)
                    .HasMaxLength(35)
                    .HasColumnName("RPhase_Potential");

                entity.Property(e => e.RphasePotentialTs).HasColumnName("RPhase_Potential_TS");

                entity.Property(e => e.Rtc).HasColumnName("RTC");

                entity.Property(e => e.SetResponse).HasMaxLength(50);

                entity.Property(e => e.SignedActivePowerkW).HasColumnType("numeric(18, 2)");

                entity.Property(e => e.SignedReactivePowerkvar).HasColumnType("numeric(18, 2)");

                entity.Property(e => e.SignedThreePhasePowerFactorPf)
                    .HasColumnType("numeric(18, 2)")
                    .HasColumnName("SignedThreePhasePowerFactorPF");

                entity.Property(e => e.SizeExecutionTime).HasMaxLength(100);

                entity.Property(e => e.SrlcBypassAlert)
                    .HasMaxLength(50)
                    .HasColumnName("SRLC_Bypass_Alert");

                entity.Property(e => e.SrlcBypassAlertTs).HasColumnName("SRLC_Bypass_Alert_TS");

                entity.Property(e => e.SrlcCoverAlert)
                    .HasMaxLength(50)
                    .HasColumnName("SRLC_Cover_Alert");

                entity.Property(e => e.SrlcCoverAlertTs).HasColumnName("SRLC_Cover_Alert_TS");

                entity.Property(e => e.Srlcambtemperature)
                    .HasColumnType("numeric(18, 2)")
                    .HasColumnName("SRLCAMBTemperature");

                entity.Property(e => e.SrlcconnectStatus).HasColumnName("SRLCConnectStatus");

                entity.Property(e => e.SrlccontrolMode).HasColumnName("SRLCControlMode");

                entity.Property(e => e.SrlccumulativeEventcounter).HasColumnName("SRLCCumulativeEventcounter");

                entity.Property(e => e.SrlcddoorStatusTs).HasColumnName("SRLCDDoorStatus_TS");

                entity.Property(e => e.SrlcdeviceId).HasColumnName("SRLCDeviceID");

                entity.Property(e => e.SrlcdoorsStatus)
                    .HasMaxLength(250)
                    .HasColumnName("SRLCDoorsStatus");

                entity.Property(e => e.SrlceventId)
                    .HasMaxLength(50)
                    .HasColumnName("SRLCEventId");

                entity.Property(e => e.SrlceventStatusWord).HasColumnName("SRLCEventStatusWord");

                entity.Property(e => e.SrlceventTimestamp)
                    .HasMaxLength(50)
                    .HasColumnName("SRLCEventTimestamp");

                entity.Property(e => e.SrlcoilLevel)
                    .HasMaxLength(50)
                    .HasColumnName("SRLCOilLevel");

                entity.Property(e => e.SrlcoilTemperature)
                    .HasColumnType("numeric(18, 2)")
                    .HasColumnName("SRLCOilTemperature");

                entity.Property(e => e.SrlcsurfaceTemperature)
                    .HasColumnType("numeric(18, 2)")
                    .HasColumnName("SRLCSurfaceTemperature");

                entity.Property(e => e.Srlcversion)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("SRLCVersion");

                entity.Property(e => e.SrlcyearofManufacture)
                    .HasMaxLength(100)
                    .HasColumnName("SRLCYearofManufacture");

                entity.Property(e => e.Sts).HasColumnName("STS");

                entity.Property(e => e.Success).HasMaxLength(50);

                entity.Property(e => e.SurafaceTempHighOccurrence).HasColumnType("numeric(18, 2)");

                entity.Property(e => e.SurafaceTempMediumOccurrence).HasColumnType("numeric(18, 2)");

                entity.Property(e => e.SurfaceTempHighRestoration).HasColumnType("numeric(18, 2)");

                entity.Property(e => e.SurfaceTempMediumRestoration).HasColumnType("numeric(18, 2)");

                entity.Property(e => e.SurfaceTemperature)
                    .HasMaxLength(50)
                    .HasColumnName("Surface_Temperature");

                entity.Property(e => e.SurfaceTemperatureCalibration).HasMaxLength(100);

                entity.Property(e => e.SurfaceTemperatureThresholdHigh).HasMaxLength(100);

                entity.Property(e => e.SurfaceTemperatureThresholdMedium).HasMaxLength(100);

                entity.Property(e => e.SurfaceTemperatureTs).HasColumnName("Surface_Temperature_TS");

                entity.Property(e => e.SystemPowerFactorForBillingPeriod).HasMaxLength(50);

                entity.Property(e => e.TerminalAlert)
                    .HasMaxLength(50)
                    .HasColumnName("Terminal_Alert");

                entity.Property(e => e.TerminalAlertTs).HasColumnName("Terminal_Alert_TS");

                entity.Property(e => e.ThdbphaseCurrent)
                    .HasColumnType("numeric(18, 2)")
                    .HasColumnName("THDBPhaseCurrent");

                entity.Property(e => e.ThdbphaseVoltage)
                    .HasColumnType("numeric(18, 2)")
                    .HasColumnName("THDBPhaseVoltage");

                entity.Property(e => e.ThdrphaseCurrent)
                    .HasColumnType("numeric(18, 2)")
                    .HasColumnName("THDRPhaseCurrent");

                entity.Property(e => e.ThdrphaseVoltage)
                    .HasColumnType("numeric(18, 2)")
                    .HasColumnName("THDRPhaseVoltage");

                entity.Property(e => e.ThdyphaseCurrent)
                    .HasColumnType("numeric(18, 2)")
                    .HasColumnName("THDYPhaseCurrent");

                entity.Property(e => e.ThdyphaseVoltage)
                    .HasColumnType("numeric(18, 2)")
                    .HasColumnName("THDYPhaseVoltage");

                entity.Property(e => e.Time).HasMaxLength(50);

                entity.Property(e => e.TimeZonesChanged)
                    .HasMaxLength(20)
                    .HasColumnName("Time_Zones_changed");

                entity.Property(e => e.TimeZonesChangedTs).HasColumnName("Time_Zones_changed_TS");

                entity.Property(e => e.TmdsDoorAlert)
                    .HasMaxLength(50)
                    .HasColumnName("TMDS_Door_Alert");

                entity.Property(e => e.TmdsDoorAlertTs).HasColumnName("TMDS_Door_Alert_TS");

                entity.Property(e => e.TypeOfBillReset).HasMaxLength(50);

                entity.Property(e => e.Value).HasMaxLength(50);

                entity.Property(e => e.VoltageUnbalance)
                    .HasMaxLength(35)
                    .HasColumnName("Voltage_Unbalance");

                entity.Property(e => e.VoltageUnbalanceTs).HasColumnName("Voltage_Unbalance_TS");

                entity.Property(e => e.YphaseCtOpen)
                    .HasMaxLength(50)
                    .HasColumnName("YPhase_CT_Open");

                entity.Property(e => e.YphaseCtOpenTs).HasColumnName("YPhase_CT_Open_TS");

                entity.Property(e => e.YphaseCtReverse)
                    .HasMaxLength(50)
                    .HasColumnName("YPhase_CT_reverse");

                entity.Property(e => e.YphaseCtReverseTs).HasColumnName("YPhase_CT_reverse_TS");

                entity.Property(e => e.YphasePotential)
                    .HasMaxLength(35)
                    .HasColumnName("YPhase_Potential");

                entity.Property(e => e.YphasePotentialTs).HasColumnName("YPhase_Potential_TS");
            });

            modelBuilder.Entity<InputDataFile>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("INPUT_DATA_FILE");

                entity.Property(e => e.ApparentTemperature)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("apparentTemperature");

                entity.Property(e => e.DewPoint)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("dewPoint");

                entity.Property(e => e.Energy)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Energy1DMa)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("Energy1D_MA");

                entity.Property(e => e.Energy1DSa)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("Energy1D_SA");

                entity.Property(e => e.Energy3TsMa)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("Energy3TS_MA");

                entity.Property(e => e.Energy5TsMa)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("Energy5TS_MA");

                entity.Property(e => e.Energy7TsMa)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("Energy7TS_MA");

                entity.Property(e => e.Humidity)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("humidity");

                entity.Property(e => e.Index)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("index");

                entity.Property(e => e.Pressure)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("pressure");

                entity.Property(e => e.Temperature)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("temperature");

                entity.Property(e => e.Timestamp)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Visibility)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("visibility");

                entity.Property(e => e.WindBearing)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("windBearing");

                entity.Property(e => e.WindSpeed)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("windSpeed");
            });

            modelBuilder.Entity<Interval>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.Column1).HasColumnName("column1");

                entity.Property(e => e.Column2).HasColumnName("column2");

                entity.Property(e => e.Column3).HasColumnName("column3");
            });

            modelBuilder.Entity<Level>(entity =>
            {
                entity.HasKey(e => e.Regionid)
                    .HasName("PK_REGION");

                entity.ToTable("LEVEL");

                entity.Property(e => e.Regionid).HasColumnName("REGIONID");

                entity.Property(e => e.Circleid).HasColumnName("CIRCLEID");

                entity.Property(e => e.Name).HasMaxLength(50);

                entity.HasOne(d => d.Circle)
                    .WithMany(p => p.InverseCircle)
                    .HasForeignKey(d => d.Circleid)
                    .HasConstraintName("FK_CIRCLE_REGION");
            });

            modelBuilder.Entity<LnkRolePermission>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("LNK_ROLE_PERMISSION");

                entity.Property(e => e.PermissionId).HasColumnName("Permission_Id");

                entity.Property(e => e.RoleId).HasColumnName("Role_Id");
            });

            modelBuilder.Entity<LnkRolePermission1>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("LNK_ROLE_PERMISSION1");

                entity.Property(e => e.PermissionId).HasColumnName("Permission_Id");

                entity.Property(e => e.RoleId).HasColumnName("Role_Id");
            });

            modelBuilder.Entity<LnkUserRole>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("LNK_USER_ROLE");

                entity.Property(e => e.RoleId).HasColumnName("Role_Id");

                entity.Property(e => e.UserId).HasColumnName("User_Id");
            });

            modelBuilder.Entity<LnkUserRole1>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("LNK_USER_ROLE1");

                entity.Property(e => e.RoleId).HasColumnName("Role_Id");

                entity.Property(e => e.UserId).HasColumnName("User_Id");
            });

            modelBuilder.Entity<MaleEmployee>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("male_employees");

                entity.Property(e => e.EAge).HasColumnName("e_age");

                entity.Property(e => e.EDept)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("e_dept");

                entity.Property(e => e.EGender)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("e_gender");

                entity.Property(e => e.EId).HasColumnName("e_id");

                entity.Property(e => e.EName)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("e_name");

                entity.Property(e => e.ESalary).HasColumnName("e_salary");
            });

            modelBuilder.Entity<MasterList>(entity =>
            {
                entity.HasKey(e => e.ServiceNo);

                entity.ToTable("MasterList");

                entity.Property(e => e.ServiceNo).HasMaxLength(50);

                entity.Property(e => e.DcboxNo)
                    .HasMaxLength(50)
                    .HasColumnName("DCBoxNo");

                entity.Property(e => e.Dcsno)
                    .HasMaxLength(50)
                    .HasColumnName("DCSno");

                entity.Property(e => e.Dtsno)
                    .HasMaxLength(50)
                    .HasColumnName("DTSno");

                entity.Property(e => e.MeterSno)
                    .HasMaxLength(50)
                    .HasColumnName("MeterSNo");

                entity.Property(e => e.PhysicalAddress).HasMaxLength(50);

                entity.Property(e => e.StatusDescription).HasMaxLength(50);
            });

            modelBuilder.Entity<Message>(entity =>
            {
                entity.HasKey(e => e.OrderId)
                    .HasName("PK__Message__C3905BAFA1F9B118");

                entity.ToTable("Message");

                entity.Property(e => e.OrderId)
                    .ValueGeneratedNever()
                    .HasColumnName("OrderID");

                entity.Property(e => e.OrderDate).HasColumnType("date");

                entity.Property(e => e.ProductCode)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Quantity).HasColumnType("numeric(9, 2)");

                entity.Property(e => e.UnitPrice).HasColumnType("numeric(9, 2)");
            });

            modelBuilder.Entity<MeterDataGl703114th>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Meter_DataGL7031_14th");

                entity.Property(e => e.DateTime)
                    .HasMaxLength(50)
                    .HasColumnName("Date_Time");

                entity.Property(e => e.DcSno)
                    .HasMaxLength(50)
                    .HasColumnName("DC_SNo");

                entity.Property(e => e.EventStatus)
                    .HasMaxLength(50)
                    .HasColumnName("Event_Status");

                entity.Property(e => e.MdKVa).HasColumnName("MD_kVA");

                entity.Property(e => e.MdKVaTs)
                    .HasMaxLength(50)
                    .HasColumnName("MD_kVA_TS");

                entity.Property(e => e.MdKW).HasColumnName("MD_kW");

                entity.Property(e => e.MdKWTs)
                    .HasMaxLength(50)
                    .HasColumnName("MD_kW_TS");

                entity.Property(e => e.MeterReadingKVah).HasColumnName("Meter_Reading_kVAh");

                entity.Property(e => e.MeterReadingKWh).HasColumnName("Meter_Reading_kWh");

                entity.Property(e => e.Msn)
                    .HasMaxLength(50)
                    .HasColumnName("MSN");

                entity.Property(e => e.NeutralCurrent).HasColumnName("Neutral_Current");

                entity.Property(e => e.PhaseCurrent).HasColumnName("Phase_Current");

                entity.Property(e => e.PhysicalAddress).HasMaxLength(50);

                entity.Property(e => e.PowerFactor).HasColumnName("Power_Factor");

                entity.Property(e => e.Ranks1).HasColumnName("RANKS1");

                entity.Property(e => e.ServiceNo)
                    .HasMaxLength(50)
                    .HasColumnName("Service_No");
            });

            modelBuilder.Entity<MetersDatum>(entity =>
            {
                entity.HasKey(e => e.ServiceNo);

                entity.Property(e => e.ServiceNo)
                    .HasMaxLength(50)
                    .HasColumnName("Service_No");

                entity.Property(e => e.DateTime).HasColumnName("Date_Time");

                entity.Property(e => e.DcSno)
                    .HasMaxLength(50)
                    .HasColumnName("DC_SNO");

                entity.Property(e => e.EventStatus)
                    .HasMaxLength(50)
                    .HasColumnName("Event_Status");

                entity.Property(e => e.MdKVa).HasColumnName("MD_kVA");

                entity.Property(e => e.MdKVaTs)
                    .HasMaxLength(50)
                    .HasColumnName("MD_kVA_TS");

                entity.Property(e => e.MdKW).HasColumnName("MD_kW");

                entity.Property(e => e.MdKWTs)
                    .HasMaxLength(50)
                    .HasColumnName("MD_kW_TS");

                entity.Property(e => e.MeterReadingKVah).HasColumnName("Meter_Reading_kVAh");

                entity.Property(e => e.MeterReadingKWh).HasColumnName("Meter_Reading_kWh");

                entity.Property(e => e.NeutralCurrent).HasColumnName("Neutral_Current");

                entity.Property(e => e.PhaseCurrent).HasColumnName("Phase_Current");

                entity.Property(e => e.PowerFactor).HasColumnName("Power_Factor");

                entity.Property(e => e.VlookDcstatus).HasColumnName("vlookDCstatus");
            });

            modelBuilder.Entity<Order>(entity =>
            {
                entity.HasKey(e => new { e.OrderId, e.ProductCode })
                    .HasName("PK__Orders");

                entity.Property(e => e.OrderId).HasColumnName("OrderID");

                entity.Property(e => e.ProductCode)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.OrderDate).HasColumnType("date");

                entity.Property(e => e.Quantity).HasColumnType("numeric(9, 2)");
            });

            modelBuilder.Entity<Orders1>(entity =>
            {
                entity.HasKey(e => e.OrderId)
                    .HasName("PK__Orders1__C3905BAF3A8DD99C");

                entity.ToTable("Orders1");

                entity.Property(e => e.OrderId)
                    .ValueGeneratedNever()
                    .HasColumnName("OrderID");

                entity.Property(e => e.PersonId).HasColumnName("PersonID");

                entity.HasOne(d => d.Person)
                    .WithMany(p => p.Orders1s)
                    .HasForeignKey(d => d.PersonId)
                    .HasConstraintName("FK__Orders1__PersonI__3B2BBE9D");
            });

            modelBuilder.Entity<Orders2>(entity =>
            {
                entity.HasKey(e => e.OrderId)
                    .HasName("PK__Orders2__46596229A46C38BF");

                entity.ToTable("Orders2");

                entity.Property(e => e.OrderId)
                    .ValueGeneratedNever()
                    .HasColumnName("order_id");

                entity.Property(e => e.CustomerId).HasColumnName("customer_id");

                entity.Property(e => e.DepartmentName)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("departmentName");

                entity.Property(e => e.OrderDate)
                    .HasColumnType("date")
                    .HasColumnName("order_date");
            });

            modelBuilder.Entity<Orders3>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("orders3");

                entity.Property(e => e.Customerid).HasColumnName("customerid");

                entity.Property(e => e.Orderdate)
                    .HasColumnType("date")
                    .HasColumnName("orderdate");

                entity.Property(e => e.Orderid).HasColumnName("orderid");
            });

            modelBuilder.Entity<OrdersView>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("orders_view");

                entity.Property(e => e.AgentCode)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("agent_code")
                    .IsFixedLength();

                entity.Property(e => e.AgentName)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("agent_name");

                entity.Property(e => e.CustName)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("CUST_NAME");

                entity.Property(e => e.OrdAmount).HasColumnName("ord_amount");

                entity.Property(e => e.OrdNum).HasColumnName("ord_num");
            });

            modelBuilder.Entity<Ordersview1>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("ordersview");

                entity.Property(e => e.AgentCode)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("agent_code")
                    .IsFixedLength();

                entity.Property(e => e.AgentName)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("agent_name");

                entity.Property(e => e.CustName)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("CUST_NAME");

                entity.Property(e => e.OrdAmount).HasColumnName("ord_amount");

                entity.Property(e => e.OrdNum).HasColumnName("ord_num");
            });

            modelBuilder.Entity<Ordview>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("ordview");

                entity.Property(e => e.AgentCode)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("agent_code")
                    .IsFixedLength();

                entity.Property(e => e.AgentName)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("agent_name");

                entity.Property(e => e.CustName)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("cust_name");

                entity.Property(e => e.OrdAmount).HasColumnName("ord_amount");

                entity.Property(e => e.OrdNum).HasColumnName("ord_num");
            });

            modelBuilder.Entity<Oreders21>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("oreders21");

                entity.Property(e => e.Comments)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("comments");

                entity.Property(e => e.Customerno).HasColumnName("customerno");

                entity.Property(e => e.Orderdate)
                    .HasColumnType("date")
                    .HasColumnName("orderdate");

                entity.Property(e => e.Ordernumber).HasColumnName("ordernumber");

                entity.Property(e => e.Requireddate)
                    .HasColumnType("date")
                    .HasColumnName("requireddate");

                entity.Property(e => e.Shippeddate)
                    .HasColumnType("date")
                    .HasColumnName("shippeddate");

                entity.Property(e => e.Status)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("status");
            });

            modelBuilder.Entity<OrgaDeportment>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("OrgaDeportment");

                entity.Property(e => e.Compeny)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("compeny");

                entity.Property(e => e.Developer)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("developer");

                entity.Property(e => e.Mobapp)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.SNo).HasColumnName("S_NO");

                entity.Property(e => e.TeamLead)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("team_lead");

                entity.Property(e => e.Testing)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("testing");
            });

            modelBuilder.Entity<OutputAndPredDatum>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("OUTPUT_AND_PRED_DATA");

                entity.Property(e => e.PredictedTarget).HasColumnName("predicted_target");
            });

            modelBuilder.Entity<P1>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("p1");

                entity.Property(e => e.Company)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("company");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Name)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("name");

                entity.Property(e => e.Sal).HasColumnName("sal");
            });

            modelBuilder.Entity<P2>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("p2");

                entity.Property(e => e.Company)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("company");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Name)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("name");

                entity.Property(e => e.Sal).HasColumnName("sal");
            });

            modelBuilder.Entity<Parameterdetail>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("parameterdetails");

                entity.Property(e => e.CrTs).HasColumnType("datetime");

                entity.Property(e => e.IsReverse).HasMaxLength(255);

                entity.Property(e => e.OperationType).HasMaxLength(255);

                entity.Property(e => e.ParameterDescription).HasMaxLength(255);

                entity.Property(e => e.ParameterId).HasColumnName("ParameterID");

                entity.Property(e => e.ParameterIsActive).HasMaxLength(255);

                entity.Property(e => e.ParameterName).HasMaxLength(255);

                entity.Property(e => e.ParameterUnits).HasMaxLength(255);
            });

            modelBuilder.Entity<PcommInboxProcess>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("PCommInboxProcess");

                entity.Property(e => e.Cjid)
                    .HasMaxLength(25)
                    .IsUnicode(false)
                    .HasColumnName("CJID");

                entity.Property(e => e.CommandCode)
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.CrTs).HasColumnName("CrTS");

                entity.Property(e => e.DeviceTid).HasColumnName("DeviceTId");

                entity.Property(e => e.DeviceTs).HasColumnName("DeviceTS");

                entity.Property(e => e.InboxFrameId).HasColumnType("numeric(25, 0)");

                entity.Property(e => e.ModemImeino)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("ModemIMEIno");

                entity.Property(e => e.NodeId)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.PayLoad)
                    .HasMaxLength(2000)
                    .IsUnicode(false);

                entity.Property(e => e.PhysicalAddress)
                    .HasMaxLength(16)
                    .IsUnicode(false);

                entity.Property(e => e.PinboxProcessId)
                    .HasColumnType("numeric(25, 0)")
                    .HasColumnName("PInboxProcessId");

                entity.Property(e => e.ProcessedTs).HasColumnName("ProcessedTS");
            });

            modelBuilder.Entity<Person>(entity =>
            {
                entity.Property(e => e.PersonId)
                    .ValueGeneratedNever()
                    .HasColumnName("PersonID");

                entity.Property(e => e.FirstName)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.LastName)
                    .HasMaxLength(255)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Pp1>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("pp1");

                entity.Property(e => e.Eaddress)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("EADDRESS");

                entity.Property(e => e.Eid).HasColumnName("EID");

                entity.Property(e => e.Ename)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("ENAME");

                entity.Property(e => e.Esal).HasColumnName("ESAL");
            });

            modelBuilder.Entity<Product>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("product");

                entity.Property(e => e.PId).HasColumnName("p_id");

                entity.Property(e => e.PName)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("p_name");

                entity.Property(e => e.PPrice).HasColumnName("p_price");

                entity.Property(e => e.PSuppname)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("p_suppname");
            });

            modelBuilder.Entity<Product1>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("PRODUCTS");

                entity.Property(e => e.ProductId).HasColumnName("ProductID");

                entity.Property(e => e.ProductName)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Productprice).HasColumnName("productprice");
            });

            modelBuilder.Entity<Product2>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("product2");

                entity.Property(e => e.DId).HasColumnName("d_id");

                entity.Property(e => e.DName)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("d_name");

                entity.Property(e => e.DPerson)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("d_person");

                entity.Property(e => e.DPrice).HasColumnName("d_price");
            });

            modelBuilder.Entity<Product2Price>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("product2_price");

                entity.Property(e => e.DId).HasColumnName("d_id");

                entity.Property(e => e.DName)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("d_name");

                entity.Property(e => e.DPerson)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("d_person");

                entity.Property(e => e.DPrice).HasColumnName("d_price");
            });

            modelBuilder.Entity<ProductTest>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("product_test");

                entity.Property(e => e.PId).HasColumnName("p_id");

                entity.Property(e => e.PName)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("p_name");

                entity.Property(e => e.PPrice).HasColumnName("p_price");

                entity.Property(e => e.PSuppname)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("p_suppname");
            });

            modelBuilder.Entity<ProductsV>(entity =>
            {
                entity.ToTable("ProductsVS");

                entity.Property(e => e.Description).HasMaxLength(50);

                entity.Property(e => e.Name).HasMaxLength(50);
            });

            modelBuilder.Entity<RajEmp>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("RajEMP");

                entity.Property(e => e.Age).HasColumnName("AGE");

                entity.Property(e => e.Empid).HasColumnName("EMPID");

                entity.Property(e => e.Ename)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("ENAME");

                entity.Property(e => e.Gender)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("GENDER")
                    .IsFixedLength();

                entity.Property(e => e.Hiredate)
                    .HasColumnType("date")
                    .HasColumnName("HIREDATE");

                entity.Property(e => e.Job)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("JOB");

                entity.Property(e => e.Sal)
                    .HasColumnType("smallmoney")
                    .HasColumnName("SAL");
            });

            modelBuilder.Entity<RbacTest>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("RBAC_Test");

                entity.Property(e => e.RoleName)
                    .HasMaxLength(20)
                    .HasColumnName("Role_name")
                    .IsFixedLength();

                entity.Property(e => e.RolePermission)
                    .HasMaxLength(50)
                    .HasColumnName("Role_Permission")
                    .IsFixedLength();

                entity.Property(e => e.UserId).HasColumnName("User_Id");
            });

            modelBuilder.Entity<RechargeServiceInput>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.Rsid)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("RSID");

                entity.Property(e => e.Sts)
                    .HasColumnName("STS")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.TransactionDate)
                    .IsUnicode(false)
                    .HasColumnName("transactionDate");

                entity.Property(e => e.TransactionNumber).HasColumnName("transactionNumber");

                entity.Property(e => e.UniqueServiceNumber).HasMaxLength(50);
            });

            modelBuilder.Entity<Regexdetail>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("regexdetails");

                entity.Property(e => e.CommandId).HasColumnName("CommandID");

                entity.Property(e => e.CrTs).HasColumnType("datetime");

                entity.Property(e => e.RegexId).HasColumnName("RegexID");
            });

            modelBuilder.Entity<Registation>(entity =>
            {
                entity.ToTable("Registation");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Address)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.City)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.FirstName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.LastName)
                    .HasMaxLength(100)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Registation1>(entity =>
            {
                entity.ToTable("Registations");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Address)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.City)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.FirstName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.LastName)
                    .HasMaxLength(100)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Requestoutbox>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("requestoutbox");

                entity.Property(e => e.Cjid)
                    .HasMaxLength(255)
                    .HasColumnName("CJID");

                entity.Property(e => e.CommandId).HasColumnName("CommandID");

                entity.Property(e => e.DeviceId).HasColumnName("DeviceID");

                entity.Property(e => e.PhysicalAddress).HasMaxLength(255);

                entity.Property(e => e.RequestFrame).HasMaxLength(255);

                entity.Property(e => e.RequestId).HasColumnName("RequestID");

                entity.Property(e => e.RequestTs)
                    .HasColumnType("datetime")
                    .HasColumnName("RequestTS");
            });

            modelBuilder.Entity<Responseinbox>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("responseinbox");

                entity.Property(e => e.Cjid)
                    .HasMaxLength(255)
                    .HasColumnName("CJID");

                entity.Property(e => e.PhysicalAddress).HasMaxLength(255);

                entity.Property(e => e.ResponseId).HasColumnName("ResponseID");

                entity.Property(e => e.ResponseTs)
                    .HasColumnType("datetime")
                    .HasColumnName("ResponseTS");
            });

            modelBuilder.Entity<Role>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("ROLES");

                entity.Property(e => e.LastModified).HasColumnType("datetime");

                entity.Property(e => e.RoleDescription).HasMaxLength(250);

                entity.Property(e => e.RoleId).HasColumnName("Role_Id");

                entity.Property(e => e.RoleName).HasMaxLength(50);
            });

            modelBuilder.Entity<Roles1>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("ROLES1");

                entity.Property(e => e.LastModified).HasColumnType("datetime");

                entity.Property(e => e.RoleDescription).HasMaxLength(250);

                entity.Property(e => e.RoleId).HasColumnName("Role_Id");

                entity.Property(e => e.RoleName).HasMaxLength(50);
            });

            modelBuilder.Entity<Sale>(entity =>
            {
                entity.ToTable("SALES");

                entity.Property(e => e.SaleId).HasColumnName("Sale_Id");

                entity.Property(e => e.Colour).HasMaxLength(30);

                entity.Property(e => e.Date)
                    .HasColumnType("date")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.EngineSize).HasColumnType("decimal(3, 1)");

                entity.Property(e => e.FuelType).HasMaxLength(10);

                entity.Property(e => e.Lhd).HasColumnName("LHD");

                entity.Property(e => e.ManufacturerName).HasMaxLength(30);

                entity.Property(e => e.Model).HasMaxLength(30);

                entity.Property(e => e.Price).HasColumnType("money");
            });

            modelBuilder.Entity<Sarwanadnd>(entity =>
            {
                entity.ToTable("Sarwanadnd");

                entity.Property(e => e.Location)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.Name)
                    .HasMaxLength(30)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<ServiceTest>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("ServiceTest");

                entity.Property(e => e.FirstName).HasMaxLength(50);

                entity.Property(e => e.GroupName).HasMaxLength(100);

                entity.Property(e => e.LastName).HasMaxLength(50);

                entity.Property(e => e.Members).HasMaxLength(100);

                entity.Property(e => e.Role).HasMaxLength(50);

                entity.Property(e => e.ServiceTestId)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("ServiceTestID");

                entity.Property(e => e.UserName).HasMaxLength(100);
            });

            modelBuilder.Entity<Software>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("software");

                entity.Property(e => e.EDept)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("e_dept");

                entity.Property(e => e.EId).HasColumnName("e_id");

                entity.Property(e => e.EName)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("e_name");

                entity.Property(e => e.ESal).HasColumnName("e_sal");
            });

            modelBuilder.Entity<SowmyaHtParamTmu>(entity =>
            {
                entity.HasKey(e => e.HtDataParamTmultctid)
                    .HasName("PK__Sowmya_H__D497B8867078A805");

                entity.ToTable("Sowmya_HT_ParamTMU");

                entity.Property(e => e.HtDataParamTmultctid)
                    .HasColumnType("numeric(25, 0)")
                    .HasColumnName("HT_DataParamTMULTCTId");

                entity.Property(e => e.AvgCurrentIb).HasColumnType("numeric(18, 2)");

                entity.Property(e => e.AvgCurrentIr).HasColumnType("numeric(18, 2)");

                entity.Property(e => e.AvgCurrentIy).HasColumnType("numeric(18, 2)");

                entity.Property(e => e.AvgVoltageVbn).HasColumnType("numeric(18, 2)");

                entity.Property(e => e.AvgVoltageVrn).HasColumnType("numeric(18, 2)");

                entity.Property(e => e.AvgVoltageVyn).HasColumnType("numeric(18, 2)");

                entity.Property(e => e.BlockEnergyVahExport)
                    .HasColumnType("numeric(18, 2)")
                    .HasColumnName("BlockEnergyVAhExport");

                entity.Property(e => e.BlockEnergyVahImport)
                    .HasColumnType("numeric(18, 2)")
                    .HasColumnName("BlockEnergyVAhImport");

                entity.Property(e => e.BlockEnergyWhExport).HasColumnType("numeric(18, 2)");

                entity.Property(e => e.BlockEnergyWhImport).HasColumnType("numeric(18, 2)");

                entity.Property(e => e.BlockEnergykvarhLagIiexport)
                    .HasColumnType("numeric(18, 2)")
                    .HasColumnName("BlockEnergykvarhLagIIExport");

                entity.Property(e => e.BlockEnergykvarhLagIimport)
                    .HasColumnType("numeric(18, 2)")
                    .HasColumnName("BlockEnergykvarhLagIImport");

                entity.Property(e => e.BlockEnergykvarhLeadIiiimport)
                    .HasColumnType("numeric(18, 2)")
                    .HasColumnName("BlockEnergykvarhLeadIIIImport");

                entity.Property(e => e.Cjid)
                    .HasMaxLength(25)
                    .IsUnicode(false)
                    .HasColumnName("CJID");

                entity.Property(e => e.CurrentBphase).HasColumnType("numeric(18, 2)");

                entity.Property(e => e.CurrentRphase).HasColumnType("numeric(18, 2)");

                entity.Property(e => e.CurrentYphase).HasColumnType("numeric(18, 2)");

                entity.Property(e => e.Dtrid).HasColumnName("DTRId");

                entity.Property(e => e.EmeventCode).HasColumnName("EMEventCode");

                entity.Property(e => e.EmeventStatusWord).HasColumnName("EMEventStatusWord");

                entity.Property(e => e.Frequency).HasColumnType("numeric(18, 2)");

                entity.Property(e => e.L1signedPowerFactorRphase)
                    .HasColumnType("numeric(18, 2)")
                    .HasColumnName("L1SignedPowerFactorRPhase");

                entity.Property(e => e.L1voltageVrn)
                    .HasColumnType("numeric(18, 2)")
                    .HasColumnName("L1VoltageVRN");

                entity.Property(e => e.L2signedPowerFactorYphase)
                    .HasColumnType("numeric(18, 2)")
                    .HasColumnName("L2SignedPowerFactorYPhase");

                entity.Property(e => e.L2voltageVyn)
                    .HasColumnType("numeric(18, 2)")
                    .HasColumnName("L2VoltageVYN");

                entity.Property(e => e.L3signedPowerFactorBphase)
                    .HasColumnType("numeric(18, 2)")
                    .HasColumnName("L3SignedPowerFactorBPhase");

                entity.Property(e => e.L3voltageVbn)
                    .HasColumnType("numeric(18, 2)")
                    .HasColumnName("L3VoltageVBN");

                entity.Property(e => e.LoadLimitFunctionStatus).HasMaxLength(50);

                entity.Property(e => e.OilLevel)
                    .HasMaxLength(50)
                    .HasColumnName("Oil_Level");

                entity.Property(e => e.PowerAlert)
                    .HasMaxLength(50)
                    .HasColumnName("Power_Alert");

                entity.Property(e => e.PushSetupId).HasMaxLength(50);

                entity.Property(e => e.RelayAlert)
                    .HasMaxLength(50)
                    .HasColumnName("Relay_Alert");

                entity.Property(e => e.Rtc).HasColumnName("RTC");

                entity.Property(e => e.SignedActivePowerkW).HasColumnType("numeric(18, 2)");

                entity.Property(e => e.Srlcambtemperature)
                    .HasColumnType("numeric(18, 2)")
                    .HasColumnName("SRLCAMBTemperature");

                entity.Property(e => e.SrlcconnectStatus).HasColumnName("SRLCConnectStatus");

                entity.Property(e => e.SrlccontrolMode).HasColumnName("SRLCControlMode");

                entity.Property(e => e.SrlccumulativeEventcounter).HasColumnName("SRLCCumulativeEventcounter");

                entity.Property(e => e.SrlcdeviceId).HasColumnName("SRLCDeviceID");

                entity.Property(e => e.SrlcdoorsStatus)
                    .HasMaxLength(250)
                    .HasColumnName("SRLCDoorsStatus");

                entity.Property(e => e.SrlcoilLevel)
                    .HasMaxLength(50)
                    .HasColumnName("SRLCOilLevel");

                entity.Property(e => e.SrlcoilTemperature)
                    .HasColumnType("numeric(18, 2)")
                    .HasColumnName("SRLCOilTemperature");

                entity.Property(e => e.SrlcsurfaceTemperature)
                    .HasColumnType("numeric(18, 2)")
                    .HasColumnName("SRLCSurfaceTemperature");

                entity.Property(e => e.Sts).HasColumnName("STS");
            });

            modelBuilder.Entity<SowmyaInnerJoin>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("sowmya_inner_join");

                entity.Property(e => e.Dtrid).HasColumnName("DTRId");

                entity.Property(e => e.HtDataParamTmultctid)
                    .HasColumnType("numeric(25, 0)")
                    .HasColumnName("HT_DataParamTMULTCTId");

                entity.Property(e => e.Name)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Paramid)
                    .HasColumnType("numeric(25, 0)")
                    .HasColumnName("paramid");

                entity.Property(e => e.Rtc).HasColumnName("RTC");
            });

            modelBuilder.Entity<SowmyaInnerJoin1>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("sowmya_inner_join1");

                entity.Property(e => e.Dtrid).HasColumnName("DTRId");

                entity.Property(e => e.HtDataParamTmultctid)
                    .HasColumnType("numeric(25, 0)")
                    .HasColumnName("HT_DataParamTMULTCTId");

                entity.Property(e => e.Name)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Paramid)
                    .HasColumnType("numeric(25, 0)")
                    .HasColumnName("paramid");

                entity.Property(e => e.Rtc).HasColumnName("RTC");
            });

            modelBuilder.Entity<Sowmyatable>(entity =>
            {
                entity.ToTable("sowmyatable");

                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.HtDataParamTmultctid)
                    .HasColumnType("numeric(25, 0)")
                    .HasColumnName("HT_DataParamTMULTCTId");

                entity.Property(e => e.Name)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Role)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("role");

                entity.Property(e => e.Rtc)
                    .HasColumnType("datetime")
                    .HasColumnName("rtc");

                entity.Property(e => e.Time).HasColumnName("Time_");

                entity.HasOne(d => d.HtDataParamTmultct)
                    .WithMany(p => p.Sowmyatables)
                    .HasForeignKey(d => d.HtDataParamTmultctid)
                    .HasConstraintName("FK__sowmyatab__HT_Da__1D314762");
            });

            modelBuilder.Entity<Sowmyatable1Nf>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("sowmyatable1NF");

                entity.Property(e => e.HtDataParamTmultctid)
                    .HasColumnType("numeric(25, 0)")
                    .HasColumnName("HT_DataParamTMULTCTId");

                entity.Property(e => e.Name)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Role1)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("role1");

                entity.Property(e => e.Role2)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("role2");

                entity.Property(e => e.Rtc)
                    .HasColumnType("datetime")
                    .HasColumnName("rtc");

                entity.Property(e => e.Time).HasColumnName("Time_");
            });

            modelBuilder.Entity<Statesinfo>(entity =>
            {
                entity.HasKey(e => e.Stateid)
                    .HasName("PK__STATESIN__5014B1E03010CDD9");

                entity.ToTable("STATESINFO");

                entity.Property(e => e.Stateid).HasColumnName("STATEID");

                entity.Property(e => e.Statecode)
                    .HasMaxLength(20)
                    .HasColumnName("STATECODE");

                entity.Property(e => e.Statename)
                    .HasMaxLength(50)
                    .HasColumnName("STATENAME");
            });

            modelBuilder.Entity<Statesinfoo>(entity =>
            {
                entity.HasKey(e => e.Stateid)
                    .HasName("PK__statesin__A666BDB9716D9DF5");

                entity.ToTable("statesinfoo");

                entity.Property(e => e.Stateid).HasColumnName("stateid");

                entity.Property(e => e.Statecode)
                    .HasMaxLength(50)
                    .HasColumnName("statecode");

                entity.Property(e => e.Statenmae)
                    .HasMaxLength(50)
                    .HasColumnName("statenmae");
            });

            modelBuilder.Entity<Stud>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Stud");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Name)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("name");
            });

            modelBuilder.Entity<Student>(entity =>
            {
                entity.Property(e => e.Gender)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Name)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Student7>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("STUDENT7");

                entity.Property(e => e.Scity)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("scity");

                entity.Property(e => e.Sid).HasColumnName("SID");

                entity.Property(e => e.Sname)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("SNAME");
            });

            modelBuilder.Entity<StudentDetails1>(entity =>
            {
                entity.HasKey(e => e.SId)
                    .HasName("PK__student___2F3684F44748654C");

                entity.ToTable("student_details1");

                entity.Property(e => e.SId)
                    .ValueGeneratedNever()
                    .HasColumnName("s_id");

                entity.Property(e => e.SMarks).HasColumnName("s_marks");

                entity.Property(e => e.SName)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("s_name");
            });

            modelBuilder.Entity<StudentDetails2>(entity =>
            {
                entity.HasKey(e => e.SId)
                    .HasName("PK__student___2F3684F4FB0B1B91");

                entity.ToTable("student_details2");

                entity.Property(e => e.SId)
                    .ValueGeneratedNever()
                    .HasColumnName("s_id");

                entity.Property(e => e.SMarks).HasColumnName("s_marks");

                entity.Property(e => e.SName)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("s_name");
            });

            modelBuilder.Entity<TblUser>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("tblUsers");

                entity.Property(e => e.Contactno)
                    .HasMaxLength(50)
                    .HasColumnName("contactno");

                entity.Property(e => e.Dob)
                    .HasMaxLength(50)
                    .HasColumnName("dob");

                entity.Property(e => e.Email)
                    .HasMaxLength(50)
                    .HasColumnName("email");

                entity.Property(e => e.Firstname)
                    .HasMaxLength(20)
                    .HasColumnName("firstname");

                entity.Property(e => e.Gender)
                    .HasMaxLength(50)
                    .HasColumnName("gender");

                entity.Property(e => e.Id)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("id");

                entity.Property(e => e.Lastname)
                    .HasMaxLength(20)
                    .HasColumnName("lastname");

                entity.Property(e => e.Password).HasColumnName("password");

                entity.Property(e => e.Role)
                    .HasMaxLength(50)
                    .HasColumnName("role");

                entity.Property(e => e.Username).HasColumnName("username");
            });

            modelBuilder.Entity<Test>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("TEST");

                entity.Property(e => e.Address)
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.City)
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.FirstName)
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.LastName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.PersonId).HasColumnName("PersonID");
            });

            modelBuilder.Entity<Testing>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("TESTING");

                entity.Property(e => e.Coursename)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("COURSENAME");

                entity.Property(e => e.Courseprice).HasColumnName("COURSEPRICE");

                entity.Property(e => e.Months).HasColumnName("MONTHS");
            });

            modelBuilder.Entity<TmmsDashboard>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("TMMS_DASHBOARD");

                entity.Property(e => e.Frequency).HasColumnType("numeric(18, 2)");

                entity.Property(e => e.L1signedPowerFactorRphase)
                    .HasColumnType("numeric(18, 2)")
                    .HasColumnName("L1SignedPowerFactorRPhase");

                entity.Property(e => e.L1voltageVrn)
                    .HasColumnType("numeric(18, 2)")
                    .HasColumnName("L1VoltageVRN");

                entity.Property(e => e.OilLevel)
                    .HasMaxLength(50)
                    .HasColumnName("oil_Level");

                entity.Property(e => e.Rtc).HasColumnName("RTC");

                entity.Property(e => e.Sts).HasColumnName("STS");
            });

            modelBuilder.Entity<V2>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("v2");

                entity.Property(e => e.Dname)
                    .HasMaxLength(14)
                    .IsUnicode(false)
                    .HasColumnName("DNAME");

                entity.Property(e => e.Empno).HasColumnName("EMPNO");

                entity.Property(e => e.Job)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("JOB");

                entity.Property(e => e.Loc)
                    .HasMaxLength(13)
                    .IsUnicode(false)
                    .HasColumnName("LOC");

                entity.Property(e => e.Sal).HasColumnName("SAL");
            });

            modelBuilder.Entity<Worker>(entity =>
            {
                entity.ToTable("WORKER");

                entity.Property(e => e.Workerid)
                    .ValueGeneratedNever()
                    .HasColumnName("WORKERID");

                entity.Property(e => e.Emailid)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("EMAILID");

                entity.Property(e => e.Firstname)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("FIRSTNAME");

                entity.Property(e => e.Lastname)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("LASTNAME");

                entity.Property(e => e.Phonenumber)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("PHONENUMBER");
            });

            modelBuilder.Entity<Worker1>(entity =>
            {
                entity.HasKey(e => e.Workerid)
                    .HasName("PK__WORKERS__BFB443CA3FE064F7");

                entity.ToTable("WORKERS");

                entity.Property(e => e.Workerid)
                    .ValueGeneratedNever()
                    .HasColumnName("WORKERID");

                entity.Property(e => e.Department)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("department");

                entity.Property(e => e.Emailid)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("EMAILID");

                entity.Property(e => e.Firstname)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("FIRSTNAME");

                entity.Property(e => e.Lastname)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("LASTNAME");

                entity.Property(e => e.Phonenumber)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("PHONENUMBER");
            });

            modelBuilder.Entity<Worker10>(entity =>
            {
                entity.HasKey(e => e.Workerid)
                    .HasName("PK__WORKER10__BFB443CA024A4C0E");

                entity.ToTable("WORKER10");

                entity.Property(e => e.Workerid)
                    .ValueGeneratedNever()
                    .HasColumnName("WORKERID");

                entity.Property(e => e.Emailid)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("EMAILID");

                entity.Property(e => e.Firstname)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("FIRSTNAME");

                entity.Property(e => e.Lastname)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("LASTNAME");

                entity.Property(e => e.Phonenumber)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("PHONENUMBER");
            });

            modelBuilder.Entity<Worker9>(entity =>
            {
                entity.HasKey(e => e.Workerid)
                    .HasName("PK__WORKER9__BFB443CAD59583F7");

                entity.ToTable("WORKER9");

                entity.Property(e => e.Workerid)
                    .ValueGeneratedNever()
                    .HasColumnName("WORKERID");

                entity.Property(e => e.Emailid)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("EMAILID");

                entity.Property(e => e.Firstname)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("FIRSTNAME");

                entity.Property(e => e.Lastname)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("LASTNAME");

                entity.Property(e => e.Phonenumber)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("PHONENUMBER");
            });

            modelBuilder.Entity<Workers1>(entity =>
            {
                entity.HasKey(e => e.Workerid)
                    .HasName("PK__WORKERS1__BFB443CA10E949E6");

                entity.ToTable("WORKERS1");

                entity.Property(e => e.Workerid)
                    .ValueGeneratedNever()
                    .HasColumnName("WORKERID");

                entity.Property(e => e.Emailid)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("EMAILID");

                entity.Property(e => e.Firstname)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("FIRSTNAME");

                entity.Property(e => e.Lastname)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("LASTNAME");

                entity.Property(e => e.Phonenumber)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("PHONENUMBER");
            });

            modelBuilder.HasSequence("s1");

            modelBuilder.HasSequence<int>("stud_seq").StartsAt(101);

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
