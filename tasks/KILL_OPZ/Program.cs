using KILL_OPZ;


MyOPZ myOpz = new MyOPZ();

while (true) { 
	Console.WriteLine("Enter your expression: ");
	string inputString = Console.ReadLine();
	
	if(inputString == "")
		Console.WriteLine("Expression can't be empty");
	else {
		try {
			Console.WriteLine(myOpz.calculate(inputString));
		} catch (Exception e) {
			Console.WriteLine(e.Message);
		}
	}
}
