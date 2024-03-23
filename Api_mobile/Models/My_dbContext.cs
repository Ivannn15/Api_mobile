using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace Api_mobile.Models
{
    public partial class My_dbContext : DbContext
    {
        public My_dbContext()
        {
        }

        public My_dbContext(DbContextOptions<My_dbContext> options)
            : base(options)
        {
        }

        public virtual DbSet<CommandToTheDevice> CommandToTheDevices { get; set; } = null!;
        public virtual DbSet<ConnectionType> ConnectionTypes { get; set; } = null!;
        public virtual DbSet<Device> Devices { get; set; } = null!;
        public virtual DbSet<DevicesScript> DevicesScripts { get; set; } = null!;
        public virtual DbSet<Password> Passwords { get; set; } = null!;
        public virtual DbSet<Regularity> Regularities { get; set; } = null!;
        public virtual DbSet<Script> Scripts { get; set; } = null!;
        public virtual DbSet<Status> Statuses { get; set; } = null!;
        public virtual DbSet<Step> Steps { get; set; } = null!;
        public virtual DbSet<StepCommand> StepCommands { get; set; } = null!;
        public virtual DbSet<StepScript> StepScripts { get; set; } = null!;
        public virtual DbSet<Type> Types { get; set; } = null!;
        public virtual DbSet<User> Users { get; set; } = null!;
        public virtual DbSet<UserScript> UserScripts { get; set; } = null!;

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseNpgsql("Host=localhost;Port=5432;Database=My_db;Username=postgres;Password=123");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<CommandToTheDevice>(entity =>
            {
                entity.HasKey(e => e.IdCommandToTheDevice)
                    .HasName("command_to_the_device_pk");

                entity.ToTable("command_to_the_device", "SomeScheme");

                entity.Property(e => e.IdCommandToTheDevice)
                    .HasColumnName("id_command_to_the_device")
                    .UseIdentityAlwaysColumn();

                entity.Property(e => e.DateAdd).HasColumnName("date_add");

                entity.Property(e => e.DateChange).HasColumnName("date_change");

                entity.Property(e => e.DateDelete).HasColumnName("date_delete");

                entity.Property(e => e.DescriptionOfTheCommand).HasColumnName("description_of_the_command");

                entity.Property(e => e.IdDevices).HasColumnName("id_devices");

                entity.Property(e => e.NumOfCommand).HasColumnName("num_of_command");

                entity.HasOne(d => d.IdDevicesNavigation)
                    .WithMany(p => p.CommandToTheDevices)
                    .HasForeignKey(d => d.IdDevices)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("command_to_the_device_fk");
            });

            modelBuilder.Entity<ConnectionType>(entity =>
            {
                entity.HasKey(e => e.IdConnectionType)
                    .HasName("connection_type_pk");

                entity.ToTable("connection_type", "SomeScheme");

                entity.Property(e => e.IdConnectionType)
                    .HasColumnName("id_connection_type")
                    .UseIdentityAlwaysColumn();

                entity.Property(e => e.DateAdd).HasColumnName("date_add");

                entity.Property(e => e.DateChange).HasColumnName("date_change");

                entity.Property(e => e.DateDelete).HasColumnName("date_delete");

                entity.Property(e => e.NameConnectionType).HasColumnName("name_connection_type");
            });

            modelBuilder.Entity<Device>(entity =>
            {
                entity.HasKey(e => e.IdDevices)
                    .HasName("devices_pk");

                entity.ToTable("devices", "SomeScheme");

                entity.Property(e => e.IdDevices)
                    .HasColumnName("id_devices")
                    .UseIdentityAlwaysColumn();

                entity.Property(e => e.DateAdd).HasColumnName("date_add");

                entity.Property(e => e.DateChange).HasColumnName("date_change");

                entity.Property(e => e.DateDelete).HasColumnName("date_delete");

                entity.Property(e => e.DescriptionDevices).HasColumnName("description_devices");

                entity.Property(e => e.IdConnectionType).HasColumnName("id_connection_type");

                entity.Property(e => e.IdStatus).HasColumnName("id_status");

                entity.Property(e => e.IdType).HasColumnName("id_type");

                entity.Property(e => e.Model).HasColumnName("model");

                entity.Property(e => e.NameDevices).HasColumnName("name_devices");

                entity.HasOne(d => d.IdConnectionTypeNavigation)
                    .WithMany(p => p.Devices)
                    .HasForeignKey(d => d.IdConnectionType)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("devices_fk_2");

                entity.HasOne(d => d.IdStatusNavigation)
                    .WithMany(p => p.Devices)
                    .HasForeignKey(d => d.IdStatus)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("devices_fk_1");

                entity.HasOne(d => d.IdTypeNavigation)
                    .WithMany(p => p.Devices)
                    .HasForeignKey(d => d.IdType)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("devices_fk");
            });

            modelBuilder.Entity<DevicesScript>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("devices_script", "SomeScheme");

                entity.Property(e => e.IdDevices).HasColumnName("id_devices");

                entity.Property(e => e.IdScript).HasColumnName("id_script");

                entity.HasOne(d => d.IdDevicesNavigation)
                    .WithMany()
                    .HasForeignKey(d => d.IdDevices)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("devices_script_fk_1");

                entity.HasOne(d => d.IdScriptNavigation)
                    .WithMany()
                    .HasForeignKey(d => d.IdScript)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("devices_script_fk");
            });

            modelBuilder.Entity<Password>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("password", "SomeScheme");

                entity.Property(e => e.Hash).HasColumnName("hash");
            });

            modelBuilder.Entity<Regularity>(entity =>
            {
                entity.HasKey(e => e.IdRegularity)
                    .HasName("regularity_pk");

                entity.ToTable("regularity", "SomeScheme");

                entity.Property(e => e.IdRegularity)
                    .HasColumnName("id_regularity")
                    .UseIdentityAlwaysColumn();

                entity.Property(e => e.DateAdd).HasColumnName("date_add");

                entity.Property(e => e.DateChange).HasColumnName("date_change");

                entity.Property(e => e.DateDelete).HasColumnName("date_delete");

                entity.Property(e => e.NameRegularity).HasColumnName("name_regularity");
            });

            modelBuilder.Entity<Script>(entity =>
            {
                entity.HasKey(e => e.IdScript)
                    .HasName("script_pk");

                entity.ToTable("script", "SomeScheme");

                entity.Property(e => e.IdScript)
                    .HasColumnName("id_script")
                    .UseIdentityAlwaysColumn();

                entity.Property(e => e.DateAdd).HasColumnName("date_add");

                entity.Property(e => e.DateChange).HasColumnName("date_change");

                entity.Property(e => e.DateDelete).HasColumnName("date_delete");

                entity.Property(e => e.DescriptionString).HasColumnName("description_string");

                entity.Property(e => e.IdRegularity).HasColumnName("id_regularity");

                entity.Property(e => e.NameScript).HasColumnName("name_script");

                entity.Property(e => e.StartTime).HasColumnName("start_time");

                entity.HasOne(d => d.IdRegularityNavigation)
                    .WithMany(p => p.Scripts)
                    .HasForeignKey(d => d.IdRegularity)
                    .HasConstraintName("script_fk");
            });

            modelBuilder.Entity<Status>(entity =>
            {
                entity.HasKey(e => e.IdStatus)
                    .HasName("status_pk");

                entity.ToTable("status", "SomeScheme");

                entity.Property(e => e.IdStatus)
                    .HasColumnName("id_status")
                    .UseIdentityAlwaysColumn();

                entity.Property(e => e.DateAdd).HasColumnName("date_add");

                entity.Property(e => e.DateChange).HasColumnName("date_change");

                entity.Property(e => e.DateDelete).HasColumnName("date_delete");

                entity.Property(e => e.NameStatus).HasColumnName("name_status");
            });

            modelBuilder.Entity<Step>(entity =>
            {
                entity.HasKey(e => e.IdStep)
                    .HasName("step_pk");

                entity.ToTable("step", "SomeScheme");

                entity.Property(e => e.IdStep)
                    .HasColumnName("id_step")
                    .UseIdentityAlwaysColumn();

                entity.Property(e => e.DateAdd).HasColumnName("date_add");

                entity.Property(e => e.DateChange).HasColumnName("date_change");

                entity.Property(e => e.DateDelete).HasColumnName("date_delete");

                entity.Property(e => e.IdCommandToTheDevice).HasColumnName("id_command_to_the_device");

                entity.Property(e => e.IdDevices).HasColumnName("id_devices");

                entity.Property(e => e.NameStep).HasColumnName("name_step");

                entity.Property(e => e.Priority).HasColumnName("priority");

                entity.HasOne(d => d.IdCommandToTheDeviceNavigation)
                    .WithMany(p => p.Steps)
                    .HasForeignKey(d => d.IdCommandToTheDevice)
                    .HasConstraintName("step_fk_1");

                entity.HasOne(d => d.IdDevicesNavigation)
                    .WithMany(p => p.Steps)
                    .HasForeignKey(d => d.IdDevices)
                    .HasConstraintName("step_fk");
            });

            modelBuilder.Entity<StepCommand>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("step_command", "SomeScheme");

                entity.Property(e => e.IdCommandToTheDevice).HasColumnName("id_command_to_the_device");

                entity.Property(e => e.IdStep).HasColumnName("id_step");

                entity.HasOne(d => d.IdCommandToTheDeviceNavigation)
                    .WithMany()
                    .HasForeignKey(d => d.IdCommandToTheDevice)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("step_command_fk_1");

                entity.HasOne(d => d.IdStepNavigation)
                    .WithMany()
                    .HasForeignKey(d => d.IdStep)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("step_command_fk");
            });

            modelBuilder.Entity<StepScript>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("step_script", "SomeScheme");

                entity.Property(e => e.IdScript).HasColumnName("id_script");

                entity.Property(e => e.IdStep).HasColumnName("id_step");

                entity.HasOne(d => d.IdScriptNavigation)
                    .WithMany()
                    .HasForeignKey(d => d.IdScript)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("step_script_fk");

                entity.HasOne(d => d.IdStepNavigation)
                    .WithMany()
                    .HasForeignKey(d => d.IdStep)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("step_script_fk_1");
            });

            modelBuilder.Entity<Type>(entity =>
            {
                entity.HasKey(e => e.IdType)
                    .HasName("type_pk");

                entity.ToTable("type", "SomeScheme");

                entity.Property(e => e.IdType)
                    .HasColumnName("id_type")
                    .UseIdentityAlwaysColumn();

                entity.Property(e => e.DateAdd).HasColumnName("date_add");

                entity.Property(e => e.DateChange).HasColumnName("date_change");

                entity.Property(e => e.DateDelete).HasColumnName("date_delete");

                entity.Property(e => e.ImageUrl).HasColumnName("image_url");

                entity.Property(e => e.NameType).HasColumnName("name_type");
            });

            modelBuilder.Entity<User>(entity =>
            {
                entity.HasKey(e => e.IdUser)
                    .HasName("user_pk");

                entity.ToTable("User", "SomeScheme");

                entity.Property(e => e.IdUser)
                    .HasColumnName("id_user")
                    .UseIdentityAlwaysColumn();

                entity.Property(e => e.DateAdd).HasColumnName("date_add");

                entity.Property(e => e.DateChange).HasColumnName("date_change");

                entity.Property(e => e.DateDelete).HasColumnName("date_delete");

                entity.Property(e => e.EmailUser).HasColumnName("email_user");

                entity.Property(e => e.NameUser).HasColumnName("name_user");

                entity.Property(e => e.SaltUser).HasColumnName("salt_user");
            });

            modelBuilder.Entity<UserScript>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("user_script", "SomeScheme");

                entity.Property(e => e.IdScript).HasColumnName("id_script");

                entity.Property(e => e.IdUser).HasColumnName("id_user");

                entity.HasOne(d => d.IdScriptNavigation)
                    .WithMany()
                    .HasForeignKey(d => d.IdScript)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("user_script_fk_1");

                entity.HasOne(d => d.IdUserNavigation)
                    .WithMany()
                    .HasForeignKey(d => d.IdUser)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("user_script_fk");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
