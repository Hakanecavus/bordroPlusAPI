using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace bordroPlus.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Companies",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    mersisNumber = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    taxOffice = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    taxNumber = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    tradeRegisteryNumber = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    workPlaceNumber = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    website = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    address = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    hasBranch = table.Column<bool>(type: "bit", nullable: false),
                    numberOfBranches = table.Column<int>(type: "int", nullable: false),
                    createdByPersonId = table.Column<int>(type: "int", nullable: false),
                    createdByUserId = table.Column<int>(type: "int", nullable: false),
                    createdByName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    modifiedByPersonId = table.Column<int>(type: "int", nullable: false),
                    modifiedByUserId = table.Column<int>(type: "int", nullable: false),
                    modifiedByName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    created = table.Column<DateTime>(type: "datetime2", nullable: false),
                    modified = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Companies", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Employees",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    surname = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    legalId = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    onBoardingDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    dismissalDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    phoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    address = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    branch = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    duty = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    unit = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    createdByPersonId = table.Column<int>(type: "int", nullable: false),
                    createdByUserId = table.Column<int>(type: "int", nullable: false),
                    createdByName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    modifiedByPersonId = table.Column<int>(type: "int", nullable: false),
                    modifiedByUserId = table.Column<int>(type: "int", nullable: false),
                    modifiedByName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    created = table.Column<DateTime>(type: "datetime2", nullable: false),
                    modified = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Employees", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    firstName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    lastName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    passwordHash = table.Column<byte[]>(type: "varbinary(max)", nullable: false),
                    passwordSalt = table.Column<byte[]>(type: "varbinary(max)", nullable: false),
                    phone = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    identityNumber = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "CompanyBranches",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    address = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    taxOffice = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    taxNumber = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    tradeRegisteryNumber = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CompanyId = table.Column<long>(type: "bigint", nullable: true),
                    createdByPersonId = table.Column<int>(type: "int", nullable: false),
                    createdByUserId = table.Column<int>(type: "int", nullable: false),
                    createdByName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    modifiedByPersonId = table.Column<int>(type: "int", nullable: false),
                    modifiedByUserId = table.Column<int>(type: "int", nullable: false),
                    modifiedByName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    created = table.Column<DateTime>(type: "datetime2", nullable: false),
                    modified = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CompanyBranches", x => x.Id);
                    table.ForeignKey(
                        name: "FK_CompanyBranches_Companies_CompanyId",
                        column: x => x.CompanyId,
                        principalTable: "Companies",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "JobDefinitions",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    definition = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    EmployeeId = table.Column<long>(type: "bigint", nullable: true),
                    createdByPersonId = table.Column<int>(type: "int", nullable: false),
                    createdByUserId = table.Column<int>(type: "int", nullable: false),
                    createdByName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    modifiedByPersonId = table.Column<int>(type: "int", nullable: false),
                    modifiedByUserId = table.Column<int>(type: "int", nullable: false),
                    modifiedByName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    created = table.Column<DateTime>(type: "datetime2", nullable: false),
                    modified = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_JobDefinitions", x => x.Id);
                    table.ForeignKey(
                        name: "FK_JobDefinitions_Employees_EmployeeId",
                        column: x => x.EmployeeId,
                        principalTable: "Employees",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Payrolls",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    payrollType = table.Column<int>(type: "int", nullable: false),
                    payrollStatus = table.Column<int>(type: "int", nullable: false),
                    salary = table.Column<float>(type: "real", nullable: false),
                    netSalary = table.Column<float>(type: "real", nullable: false),
                    hourlyPayment = table.Column<float>(type: "real", nullable: false),
                    dailyPayment = table.Column<float>(type: "real", nullable: false),
                    currency = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    weeklyWorkHours = table.Column<float>(type: "real", nullable: false),
                    daysAtWork = table.Column<float>(type: "real", nullable: false),
                    daysOffWork = table.Column<float>(type: "real", nullable: false),
                    overTime = table.Column<float>(type: "real", nullable: false),
                    overTimeCoef = table.Column<float>(type: "real", nullable: false),
                    advancePayment = table.Column<float>(type: "real", nullable: false),
                    levyPayment = table.Column<float>(type: "real", nullable: false),
                    paymentDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    unitPayment = table.Column<float>(type: "real", nullable: false),
                    numberOfUnit = table.Column<float>(type: "real", nullable: false),
                    totalTaxes = table.Column<float>(type: "real", nullable: false),
                    incomeTax = table.Column<float>(type: "real", nullable: false),
                    stampTax = table.Column<float>(type: "real", nullable: false),
                    stampTaxWage = table.Column<float>(type: "real", nullable: false),
                    incomeTaxException = table.Column<float>(type: "real", nullable: false),
                    stampTaxException = table.Column<float>(type: "real", nullable: false),
                    incomeTaxWage = table.Column<float>(type: "real", nullable: false),
                    unemploymentInsurance = table.Column<float>(type: "real", nullable: false),
                    agi = table.Column<float>(type: "real", nullable: false),
                    bonus = table.Column<float>(type: "real", nullable: false),
                    totalWageCut = table.Column<float>(type: "real", nullable: false),
                    additionalRights = table.Column<float>(type: "real", nullable: false),
                    incomeTaxBase = table.Column<float>(type: "real", nullable: false),
                    insuranceCut = table.Column<float>(type: "real", nullable: false),
                    BES = table.Column<float>(type: "real", nullable: false),
                    disablityDiscount = table.Column<float>(type: "real", nullable: false),
                    EmployeeId = table.Column<long>(type: "bigint", nullable: true),
                    createdByPersonId = table.Column<int>(type: "int", nullable: false),
                    createdByUserId = table.Column<int>(type: "int", nullable: false),
                    createdByName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    modifiedByPersonId = table.Column<int>(type: "int", nullable: false),
                    modifiedByUserId = table.Column<int>(type: "int", nullable: false),
                    modifiedByName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    created = table.Column<DateTime>(type: "datetime2", nullable: false),
                    modified = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Payrolls", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Payrolls_Employees_EmployeeId",
                        column: x => x.EmployeeId,
                        principalTable: "Employees",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "UploadFiles",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    fileName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    filePath = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    fileTypes = table.Column<int>(type: "int", nullable: false),
                    EmployeeId = table.Column<long>(type: "bigint", nullable: true),
                    createdByPersonId = table.Column<int>(type: "int", nullable: false),
                    createdByUserId = table.Column<int>(type: "int", nullable: false),
                    createdByName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    modifiedByPersonId = table.Column<int>(type: "int", nullable: false),
                    modifiedByUserId = table.Column<int>(type: "int", nullable: false),
                    modifiedByName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    created = table.Column<DateTime>(type: "datetime2", nullable: false),
                    modified = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UploadFiles", x => x.Id);
                    table.ForeignKey(
                        name: "FK_UploadFiles_Employees_EmployeeId",
                        column: x => x.EmployeeId,
                        principalTable: "Employees",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Roles",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    role = table.Column<int>(type: "int", nullable: false),
                    UserId = table.Column<long>(type: "bigint", nullable: true),
                    createdByPersonId = table.Column<int>(type: "int", nullable: false),
                    createdByUserId = table.Column<int>(type: "int", nullable: false),
                    createdByName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    modifiedByPersonId = table.Column<int>(type: "int", nullable: false),
                    modifiedByUserId = table.Column<int>(type: "int", nullable: false),
                    modifiedByName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    created = table.Column<DateTime>(type: "datetime2", nullable: false),
                    modified = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Roles", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Roles_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Vacations",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    numberOfHours = table.Column<float>(type: "real", nullable: false),
                    startDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    endDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    numberOfDaysOffWork = table.Column<float>(type: "real", nullable: false),
                    vacationType = table.Column<int>(type: "int", nullable: false),
                    userId = table.Column<long>(type: "bigint", nullable: false),
                    createdByPersonId = table.Column<int>(type: "int", nullable: false),
                    createdByUserId = table.Column<int>(type: "int", nullable: false),
                    createdByName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    modifiedByPersonId = table.Column<int>(type: "int", nullable: false),
                    modifiedByUserId = table.Column<int>(type: "int", nullable: false),
                    modifiedByName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    created = table.Column<DateTime>(type: "datetime2", nullable: false),
                    modified = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Vacations", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Vacations_Users_userId",
                        column: x => x.userId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Permissions",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    RoleId = table.Column<long>(type: "bigint", nullable: true),
                    createdByPersonId = table.Column<int>(type: "int", nullable: false),
                    createdByUserId = table.Column<int>(type: "int", nullable: false),
                    createdByName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    modifiedByPersonId = table.Column<int>(type: "int", nullable: false),
                    modifiedByUserId = table.Column<int>(type: "int", nullable: false),
                    modifiedByName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    created = table.Column<DateTime>(type: "datetime2", nullable: false),
                    modified = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Permissions", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Permissions_Roles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "Roles",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateIndex(
                name: "IX_CompanyBranches_CompanyId",
                table: "CompanyBranches",
                column: "CompanyId");

            migrationBuilder.CreateIndex(
                name: "IX_JobDefinitions_EmployeeId",
                table: "JobDefinitions",
                column: "EmployeeId");

            migrationBuilder.CreateIndex(
                name: "IX_Payrolls_EmployeeId",
                table: "Payrolls",
                column: "EmployeeId");

            migrationBuilder.CreateIndex(
                name: "IX_Permissions_RoleId",
                table: "Permissions",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "IX_Roles_UserId",
                table: "Roles",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_UploadFiles_EmployeeId",
                table: "UploadFiles",
                column: "EmployeeId");

            migrationBuilder.CreateIndex(
                name: "IX_Vacations_userId",
                table: "Vacations",
                column: "userId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CompanyBranches");

            migrationBuilder.DropTable(
                name: "JobDefinitions");

            migrationBuilder.DropTable(
                name: "Payrolls");

            migrationBuilder.DropTable(
                name: "Permissions");

            migrationBuilder.DropTable(
                name: "UploadFiles");

            migrationBuilder.DropTable(
                name: "Vacations");

            migrationBuilder.DropTable(
                name: "Companies");

            migrationBuilder.DropTable(
                name: "Roles");

            migrationBuilder.DropTable(
                name: "Employees");

            migrationBuilder.DropTable(
                name: "Users");
        }
    }
}
