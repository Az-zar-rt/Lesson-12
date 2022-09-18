class Program
{
    static void Main(string[] args)
    {
        Cars cars = new Cars();
        Engines engines = new Engines();
        Model model = new Model();
        
      
            Console.WriteLine("What list you wont? '1'-Cars '2'-Engines '3'-Model");
            int i = Convert.ToInt32(Console.ReadLine());//what will happened if user will input the character? It would be better to use try catch for some unexpected cases
            if (i == 1)
            {
            cars.CarList();
            }
            else if (i == 2)
            {
            engines.EnginesModels();
            }
            else if (i == 3)
            {
             model.ModelCar();
            }
            else
            {
            cars.CarList();
            engines.EnginesModels();
            model.ModelCar();
            }
        
    }
    public class Cars
    {
        string[] cars = { "Tesla", "Mercedes", "BMW" };
        public void CarList()
        {
            for (int i = 0; i < cars.Length; i++)
            {
                Console.WriteLine(cars[i]);
            }
        }
    }

    class Engines : Cars
    {
        string[] EngineList = { "Model 2.3(Tesla)", "Model 1.5(Mercedes)", "Model 5.5(BMW)" };
        public void EnginesModels()
        {
            for (int i = 0; i < EngineList.Length; i++)
            {
                Console.WriteLine(EngineList[i]);
            }
        }
    }

    class Model : Cars
    {
        string[] ModelList = { "Roadster", "A5", "BMW X5" };
        public void ModelCar()
        {
            for (int i = 0; i < ModelList.Length; i++)
            {
                Console.WriteLine(ModelList[i]);
            }
        }
    }
}
//checked
