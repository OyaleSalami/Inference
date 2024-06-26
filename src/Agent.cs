namespace Inference
{
    public class Agent
    {
        public string mName { get; set; }
        public string mGuid { get; }

        public AgentState state { get; }

        public Agent(string name)
        {
            mName = name;
            state = AgentState.idle;
            Core.RegisterAgent(mName);
        }

        public static Agent GetById(string id)
        {
            Core.agents.TryGetValue(id, out Agent agent);
            return agent;
        }

        public static Agent GetByName(string name)
        {
            string id = Utility.GenerateMD5Hash(name); //Get the agent id
            return GetById(id);
        }
    }
}
