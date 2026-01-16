using System;

namespace CSharp_Advance_Collections.Generics.PersonalizedMealPlanGenerator
{
    internal class VegetarianMeal : IMealPlan
    {
        public string MealName { get; private set; }
        public int Calories { get; private set; }

        public VegetarianMeal(string mealName, int calories)
        {
            MealName = mealName;
            Calories = calories;
        }

        public void ShowMealDetails()
        {
            Console.WriteLine($"[Vegetarian] {MealName} | Calories: {Calories}");
        }
    }
}