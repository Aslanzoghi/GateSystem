using System.Threading.Tasks;

namespace GateSystem
{
    public class GateRunner
    {
        public int RunSystem(TreeSystem system)
        {
            int numberOfBalles = system.Containers.Count - 1;
            Parallel.For(0, numberOfBalles, (int ball) =>
            {
                system.RunBall();
            });
            return system.Containers.Find(c => c.HasBall == false).ContainerNumber;
        }

        public int Predict(TreeSystem system)
        {
             return  system.Predict().ContainerNumber;
        }
    }
}
