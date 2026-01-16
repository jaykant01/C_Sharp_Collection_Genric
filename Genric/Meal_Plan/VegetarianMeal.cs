namespace Meal_Plan;

public class VegetarianMeal : IMealPlan
{
    public string Name
    {
        get
        {
            return "Vegetarian Meal";
        }
    }

    public int Calories
    {
        get
        {
            return 600;
        }
    }
}
