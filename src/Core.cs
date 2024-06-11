namespace Inference
{
    public class AIAgent
    {
        public string mName { get; set; }
        public string mGuid { get; }

        public AIAgent(string name)
        {
            //TODO : Assign the Guid for the AI agent
            mName = name;
        }

        public static AIAgent GetById(string id)
        {
            return null;
        }
        public static AIAgent GetByName(string name)
        {
            return null;
        }
    }
}
