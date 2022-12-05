using System;


namespace KILL_HashTable {
	internal class KeyDoesNotExistException: Exception {
		public KeyDoesNotExistException(string message): base(message) { }
	}
}
