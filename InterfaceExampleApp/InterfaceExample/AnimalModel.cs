using System;

namespace InterfaceExample
{
    public class AnimalModel : IRun
    {
        public string Species { get; set; }
        public string Age { get; set; }
        public int KilometersRun { get; set; }
        public DateTime RunTime { get; set; }

        public void Born()
        {
            // code goes here
        }
        public void Growth()
        {
            // code goes here
        }
        public void Reproduce()
        {
            // code goes here
        }
        public void Die()
        {
            // code goes here
        }

        public void Run()
        {
            // Interface code goes here 
        }

        public void Stop()
        {
            // Interface code goes here 
        }
    }

}
