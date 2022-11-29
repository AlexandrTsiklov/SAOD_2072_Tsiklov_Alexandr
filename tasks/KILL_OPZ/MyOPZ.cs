namespace KILL_OPZ {
	internal class MyOPZ {

		private Dictionary<char, int> operators = new() {
			{'(', 0}, {'+', 1}, {'-', 1}, {'*', 2}, {'/', 2}, {'^', 3}, {'~', 4}
		};

		public string calculate(string input) {
			validateOperatorsSequence(input);
			string convertedInput = convertToOpz(input);
			Stack<double> stack = new();
			int counter = 0;
			
			for (int i = 0; i < convertedInput.Length; i++) {
				char currentChar = convertedInput[i];
				
				if (char.IsDigit(currentChar)) {
					string number = parseIfNumber(convertedInput, ref i);
					stack.Push(Convert.ToDouble(number));
				}
				else if (operators.ContainsKey(currentChar)) {
					counter += 1;
					if (currentChar == '~') {
						double last = stack.Count > 0 ? stack.Pop() : 0;
						stack.Push(calculatePart('-', 0, last));
						Console.WriteLine(counter + ") " +  currentChar + last + " = " + stack.Peek().ToString());
					} 
					else {
						double second = stack.Count > 0 ? stack.Pop() : 0;
						double first = stack.Count > 0 ? stack.Pop() : 0;
						stack.Push(calculatePart(currentChar, first, second));
						Console.WriteLine(counter + ") " +  first + " " + currentChar + " " + second + " = " + stack.Peek().ToString());
					}
				}
			}
			return stack.Pop().ToString();
		}

		public string convertToOpz(string input) {
			Stack<char> stack = new();
			string output = "";			
			
			for(int i = 0; i < input.Length; i++) {
				char currentChar = input[i];
			    
				if (char.IsDigit(currentChar)) {
					output += parseIfNumber(input, ref i) + " ";
				} 
				else if (currentChar == '(') {
					stack.Push(currentChar);				
				} 
				else if (currentChar == ')') {
					if(!stack.Contains('(')) throw new BracketsConfusingException("Brackets confusing");

					while (stack.Count > 0 && stack.Peek() != '(') {
						output += stack.Pop() + " ";
					}
					// removing '('
					stack.Pop();
				} 
				else if (operators.ContainsKey(currentChar)) {
					// ither this: -3 * 6 or this 6 * -3. But not 6 - 3
					if (currentChar == '-' && (i == 0 || (i > 0 && operators.ContainsKey(input[i-1])))) {
						currentChar = '~';
					}
					while (stack.Count > 0 && ( operators[stack.Peek()] >= operators[currentChar])) {
					    output += stack.Pop() + " ";
					}		
					stack.Push(currentChar);
				}
				else throw new IncorrectInputDataException("Incorrect input data");
			}

			// extracting the rest of operators
			foreach(char currentChar in stack) {
				output += currentChar + " ";
			}
			Console.WriteLine("OPZ looks like: " + output);
			return output;
		}

        private string parseIfNumber(string input, ref int index) {
			string numberAsString = "";
			
			for(; index < input.Length; index++) {
				char currentChar = input[index];

				if (char.IsDigit(currentChar)) 
					numberAsString += currentChar;
				else {
					index--;
					break;
				}
			}
			return numberAsString;
		}

		private double calculatePart(char operat0r, double first, double second) {
			if(operat0r == '+') return first + second;
			if(operat0r == '-') return first - second;
			if(operat0r == '*') return first * second;
			if(operat0r == '/') return first / second;
			if(operat0r == '^') return Math.Pow(first, second);
			return 0;
		}

		private void validateOperatorsSequence(string input) {
			int count = 0;
			List<char> ops = new List<char>{'+', '*', '/'};
			foreach(char currentChar in input) {
				if (ops.Contains(currentChar)){
					count += 1;
					if(count > 1) throw new IncorrectOperatorsSequenceException("Incorrect operators sequence");
				}
			    else {
					count = 0;
				}
			}
		}
	}
}
