﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercice4
{
	public class BadNameException : Exception
	{
		string message;

		public BadNameException(string? message) : base(message)
        {
		}
	}
}
