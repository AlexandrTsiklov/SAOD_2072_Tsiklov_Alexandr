using System.Collections.Generic;
using System.Collections;
using System;


namespace KILL_HashTable {

	internal class HashTable<Tkey, Tvalue> {

		private static int Capasity { get { return 10; } }
		List<HashTableElement<Tkey, Tvalue>>[] hashTable = new List<HashTableElement<Tkey, Tvalue>> [Capasity];
		private int count;
		public  int Count { get { return count; }}

		public void add(Tkey key, Tvalue value) {
			int hashCode = getHashCode(key);
			
			if(hashTable[hashCode] == null) {
				hashTable[hashCode] = new List<HashTableElement<Tkey, Tvalue>>();
			}
			else {
				foreach(var hashTableElement in hashTable[hashCode]) {
					if(hashTableElement.key.Equals(key)) {
						hashTableElement.value = value;
						return;
					}
				}
			}
			hashTable[hashCode].Add(new HashTableElement<Tkey, Tvalue>(key, value));
			count++;
		}

		public Tvalue find(Tkey key) {
		    int hashCode = getHashCode(key);
			List<HashTableElement<Tkey, Tvalue>> listWithThisHashCode = findListByHash(hashCode);
			return findElementInList(listWithThisHashCode, key).value;
		}

		public void remove(Tkey key) {
			int hashCode = getHashCode(key);
			if(findListByHash(hashCode).RemoveAll(elem => elem.key.Equals(key)) != 0) {
				count--;
			}
		}

		public List<string> toList() {
			List<string> outputList = new List<string>();

			foreach(var list in hashTable) {
				if(list != null) {
					foreach(var element in list) {
						outputList.Add(element.key.ToString() + ": " + element.value.ToString());
					}
				}
			}
			return outputList;
		}

		private int getHashCode(Tkey key) {
			return Math.Abs(key.GetHashCode() % Capasity);
		}

		private List<HashTableElement<Tkey, Tvalue>> findListByHash(int hashCode) {
			List<HashTableElement<Tkey, Tvalue>> listWithThisHashCode = hashTable[hashCode];
			
			if(listWithThisHashCode == null) {
				throw new KeyDoesNotExistException("This key does not exist!");
			}
			return listWithThisHashCode;
		}

		private HashTableElement<Tkey, Tvalue> findElementInList(List<HashTableElement<Tkey, Tvalue>> listWithThisHashCode, Tkey key) {
			foreach(var hashTableElement in listWithThisHashCode) {
				if(hashTableElement.key.Equals(key)) {
					return hashTableElement;
				}
			}
			throw new KeyDoesNotExistException("This key does not exist!");
		}

		private class HashTableElement<Tkey, Tvalue> {
			
			public Tkey key;
			public Tvalue value;

			public HashTableElement(Tkey key, Tvalue value) {
				this.key = key;
				this.value = value;
			}
		}

		 private class ListPrototypeEnumerator : IEnumerator {
			List<HashTableElement<Tkey, Tvalue>>[] hashTable;
			private int capasity;
			private int indexInHashTable;
			private int indexInList = -1;

            public ListPrototypeEnumerator(List<HashTableElement<Tkey, Tvalue>>[] hashTable, int capasity) {
                this.hashTable = hashTable;
				this.capasity = capasity;
            }

            public object Current {
                get {
                    return indexInHashTable.ToString() + ": " + hashTable[indexInHashTable][indexInList].value.ToString();
                }
            }

            public bool MoveNext() {
				while(indexInHashTable != capasity) {
					if(hashTable[indexInHashTable] == null) {
						indexInHashTable++;
					}
					else {
						if(indexInList + 1 != hashTable[indexInHashTable].Count) {
							indexInList++;
							return true;
						} else {
							indexInList = 0;
							indexInHashTable++; 
						}
					}
				}
                return false;

            }
            public void Reset() => indexInHashTable = 0;
        }

        public IEnumerator GetEnumerator() => new ListPrototypeEnumerator(hashTable, Capasity);
    }
}