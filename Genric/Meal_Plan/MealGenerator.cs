namespace Meal_Plan;
public static class MealGenerator
{
    public static Meal<T> GenerateMeal<T>(T mealPlan)
        where T : IMealPlan
    {
        if (mealPlan.Calories < 500)
        {
            throw new Exception("Calories too low for a proper meal plan.");
        }

        return new Meal<T>(mealPlan);
    }
}
