// <auto-generated />
using Biblioteca.UsuarioAPI.Model.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Biblioteca.UsuarioAPI.Migrations
{
    [DbContext(typeof(MySqlContext))]
    [Migration("20220622134024_UsuarioDataTablesOnDb")]
    partial class UsuarioDataTablesOnDb
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.3")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("Biblioteca.UsuarioAPI.Model.Usuario", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .HasColumnName("id");

                    b.Property<int>("Count")
                        .HasMaxLength(10)
                        .HasColumnType("int")
                        .HasColumnName("count");

                    b.Property<string>("Cpf")
                        .IsRequired()
                        .HasMaxLength(15)
                        .HasColumnType("varchar(15)")
                        .HasColumnName("cpf");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("varchar(100)")
                        .HasColumnName("nome");

                    b.HasKey("Id");

                    b.ToTable("Usuario");

                    b.HasData(
                        new
                        {
                            Id = 1L,
                            Count = 0,
                            Cpf = "11111111111",
                            Nome = "Everton David"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
