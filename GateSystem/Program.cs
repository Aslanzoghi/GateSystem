using System;
namespace GateSystem
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Please Enter System Depth:");
            
            string input = Console.ReadLine();
            TreeFactory factory = new TreeFactory();
            int val=0;
            int.TryParse(input,out val);
            if (val == 0)
            {
                Console.WriteLine("Depth must be greater than Zero");
            }
            if (val > 21)
            {
                Console.WriteLine("Depth must be less than 21 ");
            }
            else
            {
                TreeSystem system = factory.Create(val);
                GateRunner runner = new GateRunner();

                // Enable This part to Print tree
                //var v = new TextVisualizer();
                //system.Visualize(v);

                Console.WriteLine($"Answer (Running System) : {runner.RunSystem(system)}");
                Console.WriteLine($"Answer (Prediction) : {runner.Predict(system)}");
            }

        }
      
    }
}
