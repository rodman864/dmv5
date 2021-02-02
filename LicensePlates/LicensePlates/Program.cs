using System;
using System.Collections.Generic;

namespace LicensePlates
{
    public class MyDMV
    {

        static void Main()
        {

            DMV myDMV = new DMV();

            LicensePlateInfo firstPlate = new LicensePlateInfo();
            firstPlate.LicensePlate = "EAS3247";
            firstPlate.State = "South Carolina";

            LicensePlateInfo secondPlate = new LicensePlateInfo();
            secondPlate.LicensePlate = "EAS3247";
            secondPlate.State = "South Carolina";

            LicensePlateInfo thirdPlate = new LicensePlateInfo();
            thirdPlate.LicensePlate = "EAS3249";
            thirdPlate.State = "South Carolina";

            LicensePlateInfo fourthPlate = new LicensePlateInfo();
            fourthPlate.LicensePlate = "EAS3250";
            fourthPlate.State = "South Carolina";

            myDMV.AddLicensePlate(firstPlate);
            myDMV.AddLicensePlate(secondPlate);
            myDMV.AddLicensePlate(thirdPlate);
            myDMV.AddLicensePlate(fourthPlate);


        }
    }
}
public class DMV
{
   
    private HashSet<LicensePlateInfo> licensePlates = new HashSet<LicensePlateInfo>();

    public void AddLicensePlate(LicensePlateInfo licensePlate)
    {
        bool licensePlateExist =
        licensePlates.Add(licensePlate);

        Console.BackgroundColor = ConsoleColor.DarkBlue;
        Console.ForegroundColor = ConsoleColor.Yellow;

        if (!licensePlateExist)
        {
            Console.WriteLine("The license plate: " +
                          licensePlate +
                          " already exists!");
        }
        else
        {
            Console.WriteLine("License Plate was added into the system!");
        }
    }

}
public class LicensePlateInfo
{
    public string LicensePlate { get; set; }
    public string State { get; set; }

    public override bool Equals(object obj)
    {
        LicensePlateInfo comparePlate = obj as LicensePlateInfo;

        return this.LicensePlate.Equals(comparePlate.LicensePlate);
    }
    public override int GetHashCode()
    {
        return this.LicensePlate.GetHashCode();
    }
}
