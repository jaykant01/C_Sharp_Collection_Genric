namespace Meal_Plan;

public class VeganMeal : IMealPlan
{
    public string Name
    {
        get
        {
            return "Vegan Meal";
        }
    }

    public int Calories
    {
        get
        {
            return 550;
        }
    }
}
