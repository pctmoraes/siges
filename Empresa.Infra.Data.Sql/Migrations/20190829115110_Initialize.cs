using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Empresa.Infra.Data.Sql.Migrations
{
    public partial class Initialize : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Empresas",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Cnpj = table.Column<string>(type: "varchar(80)", nullable: true),
                    NomeEmpresarial = table.Column<string>(type: "varchar(80)", nullable: true),
                    NomeFantasia = table.Column<string>(type: "varchar(80)", nullable: true),
                    Porte = table.Column<string>(type: "varchar(80)", nullable: true),
                    Logradouro = table.Column<string>(type: "varchar(80)", nullable: true),
                    Numero = table.Column<string>(type: "varchar(80)", nullable: true),
                    Complemento = table.Column<string>(type: "varchar(80)", nullable: true),
                    Cep = table.Column<string>(type: "varchar(80)", nullable: true),
                    Bairro = table.Column<string>(type: "varchar(80)", nullable: true),
                    Municipio = table.Column<string>(type: "varchar(80)", nullable: true),
                    Uf = table.Column<string>(nullable: true),
                    Email = table.Column<string>(type: "varchar(80)", nullable: true),
                    Telefone = table.Column<string>(type: "varchar(80)", nullable: true),
                    SituacaoCadastral = table.Column<string>(type: "varchar(80)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Empresas", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Items",
                columns: table => new
                {
                    ItemId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Codigo = table.Column<string>(type: "varchar(80)", nullable: true),
                    Descricao = table.Column<string>(type: "varchar(80)", nullable: true),
                    Quantidade = table.Column<int>(nullable: false),
                    PrecoDeCompra = table.Column<decimal>(type: "decimal(6,2)", nullable: false),
                    PrecoDeVenda = table.Column<decimal>(type: "decimal(6,2)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Items", x => x.ItemId);
                });

            migrationBuilder.CreateTable(
                name: "Pedidos",
                columns: table => new
                {
                    PedidoId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    EmpresaId = table.Column<int>(nullable: false),
                    DataDoPedido = table.Column<DateTime>(nullable: false),
                    DataDaEntrega = table.Column<DateTime>(nullable: false),
                    Status = table.Column<string>(type: "varchar(80)", nullable: true),
                    ValorSemDesconto = table.Column<decimal>(type: "decimal(6,2)", nullable: false),
                    ValorComDesconto = table.Column<decimal>(type: "decimal(6,2)", nullable: false),
                    Desconto = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Pedidos", x => x.PedidoId);
                });

            migrationBuilder.CreateTable(
                name: "LinhasPedidos",
                columns: table => new
                {
                    LinhasId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    PedidoId = table.Column<int>(nullable: false),
                    ItemId = table.Column<int>(nullable: false),
                    Codigo = table.Column<string>(type: "varchar(80)", nullable: true),
                    Descricao = table.Column<string>(type: "varchar(80)", nullable: true),
                    Preco = table.Column<decimal>(type: "decimal(6,2)", nullable: false),
                    Quantidade = table.Column<int>(nullable: false),
                    Desconto = table.Column<int>(nullable: false),
                    ValorTotal = table.Column<decimal>(type: "decimal(6,2)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LinhasPedidos", x => x.LinhasId);
                    table.ForeignKey(
                        name: "FK_LinhasPedidos_Items_ItemId",
                        column: x => x.ItemId,
                        principalTable: "Items",
                        principalColumn: "ItemId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_LinhasPedidos_Pedidos_PedidoId",
                        column: x => x.PedidoId,
                        principalTable: "Pedidos",
                        principalColumn: "PedidoId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_LinhasPedidos_ItemId",
                table: "LinhasPedidos",
                column: "ItemId");

            migrationBuilder.CreateIndex(
                name: "IX_LinhasPedidos_PedidoId",
                table: "LinhasPedidos",
                column: "PedidoId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Empresas");

            migrationBuilder.DropTable(
                name: "LinhasPedidos");

            migrationBuilder.DropTable(
                name: "Items");

            migrationBuilder.DropTable(
                name: "Pedidos");
        }
    }
}
