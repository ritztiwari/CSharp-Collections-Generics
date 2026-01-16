using System;

namespace CSharp_Advance_Collections.Generics.PersonalizedMealPlanGenerator
{
    internal class VeganMeal : IMealPlan
    {
        public string MealName { get; private set; }
        public int Calories { get; private set; }

        public VeganMeal(string mealName, int calories)
        {
            MealName = mealName;
            Calories = calories;
        }

        public void ShowMealDetails()
        {
            Console.WriteLine($"[Vegan] {MealName} | Calories: {Calories}");
        }
    }
}
