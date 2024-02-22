using System;

public class SodiumCheck : Check
{
    private List<int> _productMasses = new List<int>();
    float _totalMass;
 
    public SodiumCheck()
    {
          _totalMass = 0;
        _foodProducts.Clear();
        _foodProducts.Add("white Bread>681");
        _foodProducts.Add("potato>254");
        _foodProducts.Add("beans>215");
        _foodProducts.Add("Yam>9");
        _foodProducts.Add("egg>140");
        _foodProducts.Add("butter>11");
        _foodProducts.Add("rice>365");
        _foodProducts.Add("wheat Bread>530");
    }
    public override void  Run()
    {
        Console.Clear();
        Console.WriteLine();
        Console.Write("welcome, your Sodium check is about to start. In this check, your daily consumption of Sodium");
        Console.WriteLine("will be estimated and you will know if you are below or above the recommended Daily Consumption ");
        Console.WriteLine();
    }


    public override void PerformCheck()
    {
        foreach (string food in _foodProducts)
        {
            string[] foods = food.Split(">");
            Console.Write($"How many grams in whole number of {foods[0]} did you have today? ");
            int foodMass = int.Parse(Console.ReadLine());
            _productMasses.Add(foodMass);
            _totalMass = _totalMass + (foodMass * int.Parse(foods[1])) / 100;
           
        }

        _totalPercentage = _totalMass * 100 / 2200;

    }

    public override void StoreHistory()
    {
        int num2 = 0;

        _recordings.Add("Sodium Check ");
        
        foreach (string product in _foodProducts)
        {
            string[] lines = product.Split(">");
            string text2 = $"{num2 + 1}) {lines[0]} {_productMasses[num2]}grams ";
            _recordings.Add(text2);

            num2++;
        }   

        _recordings.Add($"You consumed {_totalPercentage}% of the recommended daily intake of Sodium"); 
    }

}
