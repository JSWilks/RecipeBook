using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace RecipeBook.Migrations
{
    /// <inheritdoc />
    public partial class InitCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "RecipesTBL",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Ingredients = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Steps = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Notes = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RecipesTBL", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "RecipesTBL",
                columns: new[] { "Id", "Ingredients", "Name", "Notes", "Steps" },
                values: new object[] { 1, "[\"1 white onion (halved and sliced)\",\"3 garlic cloves (diced)\",\"4 golden sweet potatoes (halved and sliced)\",\"2 large carrots (sliced into rounds)\",\"1 jalapeno (diced)\",\"1 tomato (diced)\",\"1-2 TBS butter or coconut oil\",\"Apple cider vinegar\",\"1 TBS horseradish powder\",\"1 TBS Better than bouillon adobo\",\"1 tsp dried basil\",\"~ 3qts of water\",\"1 can coconut milk\",\"Salt and pepper\"]", "Sweet potato soup", "[\"If you want a more savory soup- \\r\\nUse regular potatoes \\r\\nAdd 1/4 tsp ground fennel seed \\r\\nAdd sliced celery\\r\\nLeave out the coconut milk.\\r\\nAfter the soup is done cooking, remove from heat and immediately stir in 1 cup of heavy cream.\"]", "[\"In a 6 qt stock pot (with lid), use butter or coconut oil to saute onion and garlic cloves for about 5 minutes.\",\"Add horseradish powder and stir until\",\"It has absorbed the oil.\",\"Deglaze using a splash of apple cider vinegar.\",\"Add water.\",\"Add sweet potatoes, carrots, jalapenos, tomato, and basil.\",\"Stir in bouillon and coconut milk.\",\"Bring to a simmer and cover for about 45 minutes, stirring occasionally.\",\"Should be good once you can smash a potato pretty easy with your spoon.\",\"Salt and pepper to taste!\"]" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "RecipesTBL");
        }
    }
}
