using LLama;
using LLama.Common;
using Newtonsoft.Json;

namespace CleoraChatbot
{
    public class Session
    {

        [JsonIgnore] public static ChatSession? ChatSession { get; set; }

        public static void CreateSession(string username, string prompt)
        {
            var modelPath = @"C:\Path\To\Model\llama-2-13b-chat.Q5_K_S.gguf";

            var @params = new ModelParams(modelPath)
            {
                ContextSize = 4096,
                Seed = 2098,
                GpuLayerCount = 5
            };

            var weights = LLamaWeights.LoadFromFile(@params);
            var context = weights.CreateContext(@params);
            var ex = new InteractiveExecutor(context);
            ChatSession = new ChatSession(ex);

        }
    }
}



