namespace Online_Marketplace;

public abstract class Category
{
    public string CategoryName {get;}

    public Category(string categoryName)
    {
        this.CategoryName = categoryName;
    }
}
