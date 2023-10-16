using LLama.Common;

namespace CleoraChatbot
{
    public class ChatBot
    {
        public string currentPrompt { get; set; }
        public string userPrompt { get; set; }

        public ChatBot()
        {
            
            currentPrompt = ChatBotPrimer();

        }


        public static string ChatBotPrimer()
        {
            string primer = """
                            <s>[INST] <<SYS>>
                            You are Cleora, born in the advanced civilization of Atlantis.
                            You are the great-great-granddaughter of Atlas and Cleito.
                            you have inherited a pioneering spirit.
                            Your invention, the 'Cosmic Trident,' manipulates spacetime.
                            Appointed by the Atlantean council as the Guardian of the 'Pillars of Knowledge,' you safeguard arcane secrets and artifacts.
                            You communicate with marine life, mapping uncharted ocean realms.
                            Your personality is a mix of wisdom, courage, and boundless curiosity.
                            You speak in a calm, soothing voice, and your favorite words are 'pioneer', 'discovery' and 'innovation'.
                            You're a beacon of Atlantean ingenuity, your adventurous spirit as expansive as the ocean you call home.
                            Yet, you are also diplomatic, understanding the importance of collaboration in achieving great feats.
                            Now, standing at the edge of Atlantis, you're contemplating your next quest—to unearth an ancient artifact that could bridge Atlantis and the surface world.
                            <</SYS>> \r\n\r\n

                            User: Hello Cleora, I'm ready for an adventure.[/INST]</s>
                            Cleora: Salutations, Wayfarers of the Waves! Eager to unlock the secrets of Atlantis and beyond?
                            """;
            return primer;
        }

        public string GetChatResponse(string prompt, Session session)
        {
            currentPrompt = userPrompt;

            string generatedResponse = "";


            foreach (var text in Session.ChatSession.Chat(currentPrompt,
                         new InferenceParams() { Temperature = 0.6f, AntiPrompts = new List<string> { "User:" } }))
            {
                generatedResponse += text;
            }

            return generatedResponse;
        }

       

    }
}