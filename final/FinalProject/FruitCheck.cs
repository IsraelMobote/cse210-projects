using System;


public class FruitCheck : Check
{
    private List<float> _servings = new List<float>();

    private float _totalServing;
 

    public FruitCheck()
    {
        _totalServing = 0;
        _foodProducts.Clear();
        _foodProducts.Add("Oranges>1");
        _foodProducts.Add("Apples>1");
        _foodProducts.Add("Pieces of Banana>1");
        _foodProducts.Add("Pieces of Strawberry>8");
        _foodProducts.Add("Pieces of Mango>1");
        _foodProducts.Add("Grams of Watermelon>152");
        _foodProducts.Add("Grams of Paw-Paw>145");
    }
    public override void Run()
    {
        Console.Clear();
        Console.Write("welcome, your fruit servings check is about to start. In this check, your daily consumption of fruit");
        Console.WriteLine(" will be estimated and you will know if you are below or above the recommended daily Consumption ");
        Console.WriteLine();
    }


    public override void PerformCheck()
    {
        foreach (string food in _foodProducts)
        {
            string[] foods = food.Split(">");
            Console.Write($"How many {foods[0]} did you have today? ");
            float foodMass = float.Parse(Console.ReadLine());
            _servings.Add(foodMass);
            _totalServing = _totalServing + (foodMass / float.Parse(foods[1]));
           
        }

        _totalPercentage = _totalServing * 100 / 5;

    }
    public override void StoreHistory()
    {
        int num2 = 0;

        _recordings.Add("Fruit Check ");
        
        foreach (string product in _foodProducts)
        {
            string[] lines = product.Split(">");
            string text2 = $"{num2 + 1}) {lines[0]} {_servings[num2]}servings ";
            _recordings.Add(text2);

            num2++;
        }   

        _recordings.Add($"You consumed {_totalPercentage}% of the recommended daily servings of fruits"); 
    }


}