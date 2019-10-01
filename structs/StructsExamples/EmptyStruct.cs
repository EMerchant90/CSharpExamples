using System;


namespace structs
{

    enum EngineType
    {
        gasolone, electric, hybrid, hydrogen
    }

    struct Car
    {
        public string Name;
        public EngineType Engine;
        public string color;

    }
}