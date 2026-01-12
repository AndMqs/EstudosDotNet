					
public class Program
{
	public static void Main()
	{
		Console.WriteLine("*****Tabuada*****");
		Console.WriteLine(" ");
		
		int count = 1;
		
		while(count <= 10){
			Console.WriteLine($"Tabuada de {count}");
			Console.WriteLine(" ");
			for(int contador = 1; contador <= 10 ; contador++){
			int result = contador * count;
			Console.WriteLine($"{contador} * {count} = {result}");
		}
			Console.WriteLine(" ");
			Console.WriteLine(" ");
			count++;				
		
			
        }
		
	}	
}