// 4. Personalized Meal Plan Generator
// o Concepts: Generic Methods, Constraints, Interfaces
// o Problem Statement: Design a system where users can choose
// different meal categories like Vegetarian, Vegan, Keto, or
// High-Protein.
// o Hints:
// ▪ Define an interface IMealPlan with subtypes
// (VegetarianMeal, VeganMeal).
// ▪ Implement a generic class Meal<T> where T : IMealPlan.
// ▪ Use a generic method to validate and generate meal plans
// dynamically.

using System;

namespace CSharp_Advance_Collections.Generics.PersonalizedMealPlanGenerator
{
    internal class MealExecutable
    {
        internal static void Execute()
        {
            //creating a list of meals plan of type of IMealPlan an interface.
            Meal<IMealPlan> myMealPlan = new Meal<IMealPlan>();

            //making different meal plans like for vegetarians and vegans.
            VegetarianMeal veg = new VegetarianMeal("Paneer Salad", 350);
            VeganMeal vegan = new VeganMeal("Quinoa Bowl", 420);

            //validating the meals have the adequate amount of nutrition or not.
            MealValidator.ValidateMeal(veg);
            MealValidator.ValidateMeal(vegan);

            myMealPlan.AddMeal(veg);
            myMealPlan.AddMeal(vegan);

            //displaying the meals.
            myMealPlan.DisplayMeals();
        }
    }
}