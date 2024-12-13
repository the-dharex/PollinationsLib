# PollinationsLib

## Descripción del Proyecto

PollinationsLib es una biblioteca .NET que proporciona una interfaz simple para interactuar con los servicios de generación de imágenes y texto de Pollinations.ai. La librería permite a los desarrolladores generar imágenes y texto utilizando diversos modelos de inteligencia artificial de manera sencilla.

## Características principales

- Generación de imágenes mediante múltiples modelos de IA
- Generación de texto con diferentes modelos de lenguaje
- Soporte para personalización de prompts
- Manejo de excepciones integrado
- Compatibilidad con .NET 6.0 y superior

## Modelos Soportados

### Modelos de Imagen
- Flux
- FluxRealism
- FluxCablyai
- FluxAnime
- Flux3D
- AnyDark
- FluxPro
- Turbo

### Modelos de Texto
- OpenAI
- Mistral
- MistralLarge
- Llama
- CommandR
- Unity
- Midijourney
- Rtist
- SearchGPT
- Evil
- QwenCoder
- P1

## Instalación

Puedes instalar PollinationsLib a través de NuGet:

```bash
dotnet add package PollinationsLib
```

## Uso Básico

### Generación de Imágenes

```csharp
var imagePrompt = new ImagePrompt 
{
    Text = "Paisaje de montaña con atardecer",
    Width = 512,
    Height = 512,
    Seed = 42
};

Image? generatedImage = await PollinationsApi.GenerateImageAsync(imagePrompt, ImageModel.Flux);
```

### Generación de Texto

```csharp
var textPrompt = new TextPrompt 
{
    Text = "Escribe un poema sobre la naturaleza",
    Seed = 42,
    SystemBehavior = "Sé creativo y poético"
};

string generatedText = await PollinationsApi.GenerateTextAsync(textPrompt, TextModel.OpenAI);
```

## Requisitos del Sistema

- .NET 6.0 o superior
- Conexión a Internet
- Acceso a los servicios de Pollinations.ai

## Manejo de Errores

La biblioteca incluye manejo básico de errores que imprime mensajes de error en la consola y devuelve `null` o `string.Empty` en caso de fallo.

## Licencia MIT

MIT License

<<<<<<< HEAD
Copyright (c) [2024] [thedharex]
=======
Copyright (c) [año] [nombre completo o nombre de la organización]
>>>>>>> 37b42b77db6709df2d6c271be3cb710a7d5d825e

Permission is hereby granted, free of charge, to any person obtaining a copy
of this software and associated documentation files (the "Software"), to deal
in the Software without restriction, including without limitation the rights
to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
copies of the Software, and to permit persons to whom the Software is
furnished to do so, subject to the following conditions:

The above copyright notice and this permission notice shall be included in all
copies or substantial portions of the Software.

THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE
SOFTWARE.

## Contribuciones

Las contribuciones son bienvenidas. Por favor, abre un issue o envía un pull request en el repositorio del proyecto.

## Contacto

Para más información o soporte, por favor contacta con el mantenedor del proyecto.

## Advertencia

<<<<<<< HEAD
Esta biblioteca depende de servicios de terceros. Asegúrate de revisar los términos de servicio de Pollinations.ai antes de su uso en producción.
=======
Esta biblioteca depende de servicios de terceros. Asegúrate de revisar los términos de servicio de Pollinations.ai antes de su uso en producción.
>>>>>>> 37b42b77db6709df2d6c271be3cb710a7d5d825e
