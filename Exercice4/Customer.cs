using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercice4
{
	public class Customer : ICustomer
	{
		string cid;
		string name;
		public Customer(string cid, string name)
		{
			uint i = 0;
			if (uint.TryParse(cid, out i))
			{
				this.cid = cid;
			}
            else
            {
				throw new BadIDException();
            }
			this.name = name;
		}

		int IComparable<ICustomer>.CompareTo(ICustomer other)
		{
			throw new NotImplementedException();
		}

		bool IEquatable<ICustomer>.Equals(ICustomer other)
		{
			throw new NotImplementedException();
		}

		string ICustomer.GetCID()
		{
			return cid;
		}

		string IPerson.GetName()
		{
			return name;
		}

		void IPrintable.Print(IPrinter printer)
		{
			Console.WriteLine("cid: " + this.cid + " - name: " + this.name);
		}
	}
}
