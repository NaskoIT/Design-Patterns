using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Complaint
{
  public class Waiter : Employee
  {
    public Waiter(Priority level)
    {
      this.level = level;
    }
  }
}
