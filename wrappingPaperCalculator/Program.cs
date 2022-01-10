int counter = 0;
int finalSum = 0;
int packageSum = 0;

int length = 0;
int width = 0;
int height = 0;

int smallestSide = 0;


//System.Console.WriteLine("Test creating a class: " + wrappingPaperCalculator.Class1.testInt() );

//string text = System.IO.File.ReadAllText(@"C:\Users\19084\source\repos\wrappingPaperCalculator\wrapping.txt");

foreach (string line in System.IO.File.ReadLines(@"C:\Users\19084\source\repos\wrappingPaperCalculator\wrapping.txt"))
{
   //System.Console.WriteLine(line);
   var boxDims = line.Split('x');
    
    smallestSide = Int16.Parse(boxDims[0]) * Int16.Parse(boxDims[1]);
    if (smallestSide >= Int16.Parse(boxDims[0]) * Int16.Parse(boxDims[2]))
        smallestSide = Int16.Parse(boxDims[0]) * Int16.Parse(boxDims[2]);






   counter++;
}

//System.Console.WriteLine(line);


//System.Console.WriteLine("There were {0} lines.", counter);
// Suspend the screen.  
System.Console.ReadLine();
