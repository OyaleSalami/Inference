using System.Collections.Generic;

namespace Inference
{
    class Core
    {
        WorldState worldState { get; }
        public static Dictionary<string, Agent> agents;

        public static bool RegisterAgent(string name)
        {

            return false; //Return the GUID for the agent
        }

        private static string GenerateAgentId()
        {
            return ""; //Return the GUID for the agent
        }
    }
}
