using System.Text;
using Image = System.Drawing.Image;

namespace PollinationsLib
{

    public enum ImageModel
    {
        Flux,
        FluxRealism,
        FluxCablyai,
        FluxAnime,
        Flux3D,
        AnyDark,
        FluxPro,
        Turbo
    }

    public enum TextModel
    {
        OpenAI,
        Mistral,
        MistralLarge,
        Llama,
        CommandR,
        Unity,
        Midijourney,
        Rtist,
        SearchGPT,
        Evil,
        QwenCoder,
        P1
    }

    public static class PollinationsApi
    {
        private static readonly HttpClient HttpClient = new();

#if NET6_0_OR_GREATER
        public static async Task<Image?> GenerateImageAsync(ImagePrompt prompt, ImageModel model)
        {
            try
            {
                string encodedPrompt = Uri.EscapeDataString(prompt.Text);
                string modelString = model.ToString().Replace("FluxRealism", "flux-realism")
                                                  .Replace("FluxCablyai", "flux-cablyai")
                                                  .Replace("FluxAnime", "flux-anime")
                                                  .Replace("Flux3D", "flux-3d")
                                                  .Replace("AnyDark", "any-dark")
                                                  .Replace("FluxPro", "flux-pro")
                                                  .ToLower();

                string imageUrl = $"https://pollinations.ai/p/{encodedPrompt}?width={prompt.Width}&height={prompt.Height}&seed={prompt.Seed}&model={modelString}";
                HttpResponseMessage response = await HttpClient.GetAsync(imageUrl);
                response.EnsureSuccessStatusCode();

                Stream imageStream = await response.Content.ReadAsStreamAsync();

#pragma warning disable CA1416
                return Image.FromStream(imageStream);
#pragma warning restore CA1416

            }
            catch (Exception ex)
            {
                Console.WriteLine("Error recuperando textp: " + ex.Message);
                return null;
            }
        }
#endif
        public static async Task<string> GenerateTextAsync(TextPrompt prompt, TextModel model)
        {
            try
            {
                string encodedPrompt = Uri.EscapeDataString(prompt.Text);
                string encodedSystem = string.IsNullOrEmpty(prompt.SystemBehavior) ? string.Empty : Uri.EscapeDataString(prompt.SystemBehavior);

                string modelString = model.ToString().ToLower();

                StringBuilder urlBuilder = new($"https://text.pollinations.ai/{encodedPrompt}?");
                urlBuilder.Append($"seed={prompt.Seed}&model={modelString}");
                if (!string.IsNullOrEmpty(encodedSystem))
                {
                    urlBuilder.Append($"&system={encodedSystem}");
                }

                HttpResponseMessage response = await HttpClient.GetAsync(urlBuilder.ToString());
                response.EnsureSuccessStatusCode();
                return await response.Content.ReadAsStringAsync();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error recuperando textp: " + ex.Message);
                return String.Empty;
            }
        }
    }
}