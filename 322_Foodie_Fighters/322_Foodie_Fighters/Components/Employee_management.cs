 using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _322_Foodie_Fighters
{
    static public class EmployeeManagement
    {
        private class TimeSheet
        {
            string checkInTime;
            string checkOutTime;
            double totalTime;
            public void checkIn(int employeeID)
            {
                throw new NotImplementedException("Not yet implemented"); //TO-DO
            }
            public void checkOut(int employeeID)
            {
                throw new NotImplementedException("Not yet implemented"); //TO-DO
            }
        }

        private class TipsHandler
        {
            double tips;
            Dictionary<Waiter, int[]> serverTables;
            Dictionary<int, double> tableTips;
            public void divideTipsEqually(int employeeID)
            {
                throw new NotImplementedException("Not yet implemented"); //TO-DO
            }
            public void divideTipsByTable()
            {
                throw new NotImplementedException("Not yet implemented"); //TO-DO
            }

        }

        private class Manager
        {
            List<Waiter> staffList;
        }



        static  public void managerAccess()
        {

        }
        static public void clockIn(int employeeID)
        {

        }
        static public void clockOut(int employeeID)
        {

        }
        static private void distributeTips()
        {

        }
        static private TimeSheet modifyTimeSheet(TimeSheet beforeSheet)
        {
            throw new NotImplementedException("Not yet implemented"); //TO-DO
        }


    }
}
