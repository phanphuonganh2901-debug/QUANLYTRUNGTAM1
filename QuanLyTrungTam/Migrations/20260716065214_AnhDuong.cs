using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace QuanLyTrungTam.Migrations
{
    public partial class AnhDuong : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "GiaoVien",
                columns: table => new
                {
                    MaGV = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    TenGV = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    NgaySinh = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DiaChi = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    SDT = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GiaoVien", x => x.MaGV);
                });

            migrationBuilder.CreateTable(
                name: "HocVien",
                columns: table => new
                {
                    MaHV = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    CMND = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TenHV = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    NgaySinh = table.Column<DateTime>(type: "datetime2", nullable: false),
                    NgheNghiep = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HocVien", x => x.MaHV);
                });

            migrationBuilder.CreateTable(
                name: "KhoaHoc",
                columns: table => new
                {
                    MaKH = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    TenKH = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    NgayBatDau = table.Column<DateTime>(type: "datetime2", nullable: false),
                    NgayKetThuc = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_KhoaHoc", x => x.MaKH);
                });

            migrationBuilder.CreateTable(
                name: "TaiKhoan",
                columns: table => new
                {
                    TenDangNhap = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    MatKhau = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    VaiTro = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    MaNguoiDung = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TrangThai = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TaiKhoan", x => x.TenDangNhap);
                });

            migrationBuilder.CreateTable(
                name: "DanhGiaHocVien",
                columns: table => new
                {
                    MaDanhGia = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MaHV = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    MaLop = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DiemDanhGia = table.Column<int>(type: "int", nullable: false),
                    NoiDung = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    NgayDanhGia = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DanhGiaHocVien", x => x.MaDanhGia);
                    table.ForeignKey(
                        name: "FK_DanhGiaHocVien_HocVien_MaHV",
                        column: x => x.MaHV,
                        principalTable: "HocVien",
                        principalColumn: "MaHV",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "KetQuaThi",
                columns: table => new
                {
                    MaKQT = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SoBienLai = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    MaHV = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    MaGV = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    NgayThi = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DiemThi = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    XepLoai = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_KetQuaThi", x => x.MaKQT);
                    table.ForeignKey(
                        name: "FK_KetQuaThi_HocVien_MaHV",
                        column: x => x.MaHV,
                        principalTable: "HocVien",
                        principalColumn: "MaHV",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "LopHoc",
                columns: table => new
                {
                    MaLop = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    TenLop = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    SiSo = table.Column<int>(type: "int", nullable: false),
                    PhongHoc = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    MaGV = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    MaKH = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LopHoc", x => x.MaLop);
                    table.ForeignKey(
                        name: "FK_LopHoc_GiaoVien_MaGV",
                        column: x => x.MaGV,
                        principalTable: "GiaoVien",
                        principalColumn: "MaGV",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_LopHoc_KhoaHoc_MaKH",
                        column: x => x.MaKH,
                        principalTable: "KhoaHoc",
                        principalColumn: "MaKH",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "BienLaiHocPhi",
                columns: table => new
                {
                    SoBienLai = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    MaHV = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    MaLop = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    MaKH = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TienNop = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    NgayNop = table.Column<DateTime>(type: "datetime2", nullable: false),
                    NguoiThu = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BienLaiHocPhi", x => x.SoBienLai);
                    table.ForeignKey(
                        name: "FK_BienLaiHocPhi_HocVien_MaHV",
                        column: x => x.MaHV,
                        principalTable: "HocVien",
                        principalColumn: "MaHV",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_BienLaiHocPhi_LopHoc_MaLop",
                        column: x => x.MaLop,
                        principalTable: "LopHoc",
                        principalColumn: "MaLop",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "LichHoc",
                columns: table => new
                {
                    MaLich = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    MaLop = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    NgayHoc = table.Column<DateTime>(type: "datetime2", nullable: false),
                    GioBatDau = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    GioKetThuc = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PhongHoc = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    NoiDungBuoi = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LichHoc", x => x.MaLich);
                    table.ForeignKey(
                        name: "FK_LichHoc_LopHoc_MaLop",
                        column: x => x.MaLop,
                        principalTable: "LopHoc",
                        principalColumn: "MaLop",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_BienLaiHocPhi_MaHV",
                table: "BienLaiHocPhi",
                column: "MaHV");

            migrationBuilder.CreateIndex(
                name: "IX_BienLaiHocPhi_MaLop",
                table: "BienLaiHocPhi",
                column: "MaLop");

            migrationBuilder.CreateIndex(
                name: "IX_DanhGiaHocVien_MaHV",
                table: "DanhGiaHocVien",
                column: "MaHV");

            migrationBuilder.CreateIndex(
                name: "IX_KetQuaThi_MaHV",
                table: "KetQuaThi",
                column: "MaHV");

            migrationBuilder.CreateIndex(
                name: "IX_LichHoc_MaLop",
                table: "LichHoc",
                column: "MaLop");

            migrationBuilder.CreateIndex(
                name: "IX_LopHoc_MaGV",
                table: "LopHoc",
                column: "MaGV");

            migrationBuilder.CreateIndex(
                name: "IX_LopHoc_MaKH",
                table: "LopHoc",
                column: "MaKH");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "BienLaiHocPhi");

            migrationBuilder.DropTable(
                name: "DanhGiaHocVien");

            migrationBuilder.DropTable(
                name: "KetQuaThi");

            migrationBuilder.DropTable(
                name: "LichHoc");

            migrationBuilder.DropTable(
                name: "TaiKhoan");

            migrationBuilder.DropTable(
                name: "HocVien");

            migrationBuilder.DropTable(
                name: "LopHoc");

            migrationBuilder.DropTable(
                name: "GiaoVien");

            migrationBuilder.DropTable(
                name: "KhoaHoc");
        }
    }
}
