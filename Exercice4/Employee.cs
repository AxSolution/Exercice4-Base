using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercice4
{
	public class Employee : IEmployee
	{
		public string eid;
		public string name;
		
		public Employee(string eid, string name)
		{
			bool countainDigit=false;
			foreach(char c in eid)
            {
                if (char.IsDigit(c))
                {
					countainDigit = true;
					break;
                }
            }
            if(countainDigit != true && eid.Length == 3)
            {
				this.eid = eid;
            }
			else
            {
                throw new BadIDException("L'eid n'est pas valide");
            }
			if(name.Length == 0)
            {
				throw new BadNameException("Le nom ne doit pas être vide");
			}
            else
            {
				this.name = name;
            }
			
		}

		int IComparable<IEmployee>.CompareTo(IEmployee other)
		{
			throw new NotImplementedException();
		}

		bool IEquatable<IEmployee>.Equals(IEmployee other)
		{
			throw new NotImplementedException();
		}

		string IEmployee.GetEID()
		{
			return eid;
		}

		string IPerson.GetName()
		{
			return name;
		}

		void IPrintable.Print(IPrinter printer)
		{
			printer.PrintLine("[" + eid +"] " + name );
		}
	}
}
