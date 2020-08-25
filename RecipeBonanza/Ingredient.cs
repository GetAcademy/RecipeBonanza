namespace RecipeBonanza
{
    class Ingredient
    {
        private int _amount;
        private string _amountUnit;
        public string FoodItem { get; }
        public string Description => _amount + _amountUnit + " " + FoodItem;

        public Ingredient(int amount, string amountUnit, string foodItem)
        {
            _amount = amount;
            _amountUnit = amountUnit;
            FoodItem = foodItem;
        }
    }
}
