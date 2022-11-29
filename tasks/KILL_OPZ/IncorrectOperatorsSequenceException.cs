using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KILL_OPZ {
	internal class IncorrectOperatorsSequenceException: Exception {
		public IncorrectOperatorsSequenceException(string message): base(message) {
		}
	}
}
