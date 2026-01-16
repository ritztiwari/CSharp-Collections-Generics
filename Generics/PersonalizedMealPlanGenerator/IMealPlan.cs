using System;

namespace CSharp_Advance_Collections.Generics.PersonalizedMealPlanGenerator
{
    internal interface IMealPlan
    {
        string MealName {get;}
        int Calories {get;}
        void ShowMealDetails();
    }
}