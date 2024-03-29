using System;

public class ProteinCheck : Check
{
    private List<int> _productMasses = new List<int>();

    private float _totalMass;
    public ProteinCheck()
    {
        _foodProducts.Clear();
        _foodProducts.Add("white Bread>8");
        _foodProducts.Add("potato>2");
        _foodProducts.Add("beans>7");
        _foodProducts.Add("Yam>2");
        _foodProducts.Add("egg>13");
        _foodProducts.Add("butter>1");
        _foodProducts.Add("rice>3");
        _foodProducts.Add("wheat Bread>9");
    }


    public override void  Run()
    {
        Console.Clear();
        Console.Write("welcome, your protein check is about to start. In this check, your daily consumption of proteins");
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

        Console.Write($"What is your body weight in kilogram? ");
        int weight = int.Parse(Console.ReadLine());

        _totalPercentage = _totalMass * 100 / (weight * 8 / 10);
    }

    public override void StoreHistory()
    {
        int num2 = 0;
        
        _recordings.Add("Protein Check ");

        foreach (string product in _foodProducts)
        {
            string[] lines = product.Split(">");
            string text2 = $"{num2 + 1}) {lines[1]} {_productMasses[num2]}grams ";
            _recordings.Add(text2);

            num2++;
        }  

        _recordings.Add($"You consumed {_totalPercentage}% of the recommended daily intake of Proteins");   
    }
}