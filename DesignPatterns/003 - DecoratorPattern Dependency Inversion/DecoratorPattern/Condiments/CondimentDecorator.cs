using DecoratorPattern.Beverages;

internal abstract class CondimentDecorator : Beverage
{
    protected Beverage baseBeverage = null;

    public CondimentDecorator(Beverage beverage)
    {
        this.baseBeverage = beverage;
    }

    public abstract override string GetDescription();

}