using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercice4
{ 

	
	public class BadIDException : Exception
	{
		string message;
		public BadIDException(Exception e)
    {
			message = e.Message;
    }
		
	}
}
