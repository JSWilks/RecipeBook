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
        private string name = "";
        private List<string> ingredients = new List<string> { };
        private List<string> steps = new List<string> { };
        private List<string> notes = new List<string> { };  

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

        public void AddIngredient(string ingredient)
        { 
            ingredients.Add(ingredient);
        }

        public void AddStep(string step)
        {
            steps.Add(step);
        }

        public void AddNote(string note)
        {
            notes.Add(note);
        }

        public override string ToString()
        {
            return JsonSerializer.Serialize(this);
        }
    }

}
