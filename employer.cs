using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Employer
{
	class Program
	{
	    class Employee
	    {
	        public int clearanceType {get; set;}
	        public int Age {get; set;}
	    }
	    
	    class Marketer: Employee
	    {
	        public Marketer()
	        {
	            clearanceType = 4;
	        }
	        public void Style()
	        {
	            Console.Write("I will not take NO for an answer!");
	        }
	        
	    }
		static void Main(string[] args)
		{
		    Marketer m = new Marketer();
		    
		    Console.WriteLine(m.clearanceType);
		    
		    m.Style();
		}
	}
}
