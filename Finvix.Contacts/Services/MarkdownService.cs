using Markdig;

namespace Finvix.Contacts.Services;

public interface IMarkdownService
{
    string RenderMarkdown(string filePath);
}

public class MarkdownService : IMarkdownService
{
    private readonly IWebHostEnvironment _env;
    private readonly MarkdownPipeline _pipeline;

    public MarkdownService(IWebHostEnvironment env)
    {
        _env = env;
        _pipeline = new MarkdownPipelineBuilder()
            .UseAdvancedExtensions()
            .Build();
    }

    public string RenderMarkdown(string filePath)
    {
        // El README está en la raíz del repositorio (un nivel arriba del proyecto)
        var fullPath = Path.Combine(_env.ContentRootPath, "..", filePath);

        if (!File.Exists(fullPath))
            return $"<p>Archivo no encontrado: {filePath}</p>";

        var markdown = File.ReadAllText(fullPath);
        return Markdown.ToHtml(markdown, _pipeline);
    }
}
