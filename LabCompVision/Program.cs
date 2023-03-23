using Microsoft.Azure.CognitiveServices.Vision.ComputerVision;
using Microsoft.Azure.CognitiveServices.Vision.ComputerVision.Models;

string endPoint = "https://lopatincompvision.cognitiveservices.azure.com/";
string key = "18145f58fb0d44e5a01e60da9cadbdf5";
string urlString = "https://i0.wp.com/adashofdata.com/wp-content/uploads/2014/10/text_words2.gif";
//connecting
ComputerVisionClient client = new ComputerVisionClient(new ApiKeyServiceClientCredentials(key)) { Endpoint=endPoint};
//characteristics for analys
List<VisualFeatureTypes?> featureTypes = Enum.GetValues(typeof(VisualFeatureTypes)).OfType<VisualFeatureTypes?>().ToList();

//ImageAnalysis imageAnalysis = await client.AnalyzeImageAsync(urlString,featureTypes);
//List<VisualFeatureTypes?> features = new List<VisualFeatureTypes?>() { VisualFeatureTypes.Tags };
//foreach (var item in imageAnalysis.)
//{
//    Console.WriteLine($"Gender: {item.Gender}");
//    Console.WriteLine($"Age: {item.Age}");
//    Console.WriteLine($"X: {item.Rectangle.X}; Y:{item.Rectangle.Y}");
//    Console.WriteLine($"Width: {item.Rectangle.W}");
//    Console.WriteLine($"Height: {item}");
//}
//Console.WriteLine($"{imageAnalysis.Adult.IsAdultContent} / {imageAnalysis.Adult.AdultScore}");
//Console.WriteLine($"{imageAnalysis.Adult.IsGoryContent} / {imageAnalysis.Adult.RacyScore}");
//Console.WriteLine($"{imageAnalysis.Adult.IsRacyContent} / {imageAnalysis.Adult.RacyScore}");
//foreach (var item in imageAnalysis.Categories)
//{
//    if(item.Detail.Landmarks!=null){
//        foreach (var subitem in item.Detail.Landmarks)
//        {
//            Console.WriteLine("Name: "+ subitem.Name);
//            Console.WriteLine("Confidence: "+ subitem.Confidence);
//        }
//    }
//}
//foreach (var item in imageAnalysis.Categories)
//{
//    if (item.Detail.Celebrities != null)
//    {
//        foreach (var subitem in item.Detail.Landmarks)
//        {
//            Console.WriteLine("Name: "+ subitem.Name);
//            Console.WriteLine("Confidence: "+ subitem.Confidence);
//        }
//    }
//}
var text=await client.RecognizePrintedTextAsync(true, urlString); 
foreach (var item in text.Regions)
{
	foreach (var subitem in item.Lines)
	{
		foreach (var word in subitem.Words)
		{
            Console.Write(word.Text+ " ");
        }
	}
}



//Console.WriteLine("Accept color: "+ imageAnalysis.Color.AccentColor);
//Console.WriteLine("Foreground color: "+ imageAnalysis.Color.DominantColorForeground);
//Console.WriteLine("Background color: "+ imageAnalysis.Color.DominantColorBackground);
//Console.WriteLine("Colors: "+ string.Join(", ", imageAnalysis.Color.DominantColors));