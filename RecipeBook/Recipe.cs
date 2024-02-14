using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace RecipeBook
{
    [Table("RecipesTBL")]
    public class Recipe
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        private int id;
        private string name = null!;
        private List<string>? ingredients;
        private List<string>? steps;
        private List<string>? notes;

        public Recipe()
        {

        }

        public Recipe(string name, List<string> ingredients, List<string> steps, List<string> notes)
        {
            Name = name;
            Ingredients = ingredients;
            Steps = steps;
            Notes = notes;
        }


        public int Id { get => id; set => id = value; }

        public string Name { get => name; set => name = value; }


        public List<string> Ingredients { get => ingredients; set => ingredients = value; }

        public List<string> Steps { get => steps; set => steps = value; }

        public List<string> Notes { get => notes; set => notes = value; }

        public override string ToString()
        {
            return JsonSerializer.Serialize(this);
        }
    }

}
