using System;

namespace CSharp_Advance_Collections.Generics.PersonalizedMealPlanGenerator
{
    internal class Meal<T> where T : IMealPlan
    {
        private readonly List<T> meals = new List<T>();

        public void AddMeal(T meal)
        {
            meals.Add(meal);
        }
        
        public void DisplayMeals()
        {
            System.Console.WriteLine("\n-----The Meals are-----\n");

            foreach (T item in meals)
            {
                item.ShowMealDetails();
            }
        }
    }
}