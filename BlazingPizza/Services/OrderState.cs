using BlazingPizza.Models;

namespace BlazingPizza.Services;

public class OrderState
{
    public bool ConfigureDialogVisible { get; private set; }
    public Pizza ConfiguringPizza { get; private set; }
    public Order Order { get; private set; } = new();

    public void ShowConfigurePizzaDialog(PizzaSpecial special)
    {
        ConfiguringPizza = new()
        {
            Special = special,
            SpecialId = special.Id,
            Size = Pizza.DefaultSize,
            Toppings = new List<PizzaTopping>()
        };

        ConfigureDialogVisible = true;
    }

    public void CancelConfigurePizzaDialog() => ResetState();

    public void ConfirmConfigurePizzaDialog()
    {
        Order.Pizzas.Add(ConfiguringPizza);
        ResetState();
    }

    public void RemoveConfiguredPizza(Pizza pizza)
    {
        Order.Pizzas.Remove(pizza);
    }

    private void ResetState()
    {
        ConfiguringPizza = default;
        ConfigureDialogVisible = default;
    }
}
