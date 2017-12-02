using System;
using Bot;

namespace Bot
{
    public class Dialog
    {
        private Feeder feeder;
        

        public string identifier(string instruction)
        {
            /* Three version:
                 - version use Luis IA
                 - version switch
                 - version analytic data
            */
            switch (instruction.ToLower())
            {
                case "oi":
                    return "Ola!";
                    break;
                case "tchau":
                    return "Tchau!";
                default:
                    return "não encontrado";
                    break;
            }
        }
    }
}