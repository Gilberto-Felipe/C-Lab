using System;

namespace InterfaceExample
{
    public interface IRun 
    {
        int KilometersRun { get; set; }
        DateTime RunTime { get; set; }
        void Run();
        void Stop();
    }

}
