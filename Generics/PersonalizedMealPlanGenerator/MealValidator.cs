using System;

namespace CSharp_Advance_Collections.Generics.PersonalizedMealPlanGenerator
{
    internal static class MealValidator
    {
        internal static void ValidateMeal<T>(T meal) where T : IMealPlan
        {
            if (meal.Calories <= 0)
            {
                Console.WriteLine("Invalid meal: Calories must be positive.");
            }
            else
            {
                Console.WriteLine($"Meal '{meal.MealName}' is valid with {meal.Calories} calories.");
            }
        }
    }
}