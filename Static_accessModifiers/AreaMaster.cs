using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day3_static_accessModifiers
{
    public enum AreaType { country, state, city, district };

    public class AreaMaster
    {
        public int ID;
        public string Code;
        public string Name;
        public string Description;
        //string areatype;

        AreaType areaType;

        public virtual AreaType areat
        {

            get { return areaType; }
            set { areaType = value; }

        }

        public int AreaID;

        public static List<AreaMaster> areaCollection = new List<AreaMaster>();


        public AreaMaster()
        {
            ID = 0;
            Code = null;
            Name = null;
            Description = null;
            //areatype = null;
            AreaID = 0;
        }

        public AreaMaster(int id, string code, string name, string desc, AreaType areat, int areaid)
        {

            this.ID = id;
            this.Code = code;
            this.Name = name;
            this.Description = desc;
            this.areaType = areat;
            this.AreaID = areaid;
        }

        public void addToList(AreaMaster a)
        {

            areaCollection.Add(a);

            //  Console.WriteLine(areaCollection[0].ID);
            foreach (var item in areaCollection)
            {
                //   Console.WriteLine("\n"+item.ID+"\n"+item.Name+"\n"+item.Code+"\n"+item.Description+"\n"+item.areaType+"\n"+item.AreaID);
            }

        }

    }



    public class countryMaster : AreaMaster
    {
        AreaType areaType;
        public override AreaType areat
        {
            get { return areaType; }
            set { areaType = AreaType.country; }
        }

        public void GetAreaMasterByCountry(string s)
        {
            // Console.WriteLine("input" + s);
            int flag = 0;
            foreach (var item in areaCollection)
            {
                //  Console.WriteLine(item.Name);
                if (item.Name == s)
                {
                    Console.WriteLine("Country Name : " + item.Name + "\nCountry Code : " + item.Code + "\nArea : " + AreaType.country + "\nAreaId : " + item.AreaID);
                    flag = 1;
                    break;
                }


            }

            if (flag == 0)
            {
                Console.WriteLine("No entry");
            }
        }

    }

    public class stateMaster : AreaMaster
    {

        AreaType areaType;
        public override AreaType areat
        {
            get { return areaType; }
            set { areaType = AreaType.state; }
        }

        public void GetAreaMasterByState(string s)
        {
            int flag1 = 0;
            int countryCode;

            foreach (var item in areaCollection)
            {
                //  Console.WriteLine(item.Name);
                if (item.Name == s)
                {
                    countryCode = item.AreaID;

                    Console.WriteLine("State Name : " + item.Name);
                    foreach (var item1 in areaCollection)
                    {
                        if (item1.ID == countryCode)
                        {
                            Console.WriteLine("Country : " + item1.Name);
                            break;
                        }
                    }
                    Console.WriteLine("State Code : " + item.Code + "\nArea : " + AreaType.state + "\nAreaId : " + item.AreaID);
                    flag1 = 1;
                    break;
                }



            }

            if (flag1 == 0)
            {
                Console.WriteLine("No entry");
            }



        }

    }

    public class cityMaster : AreaMaster
    {

        AreaType areaType;
        public override AreaType areat
        {
            get { return areaType; }
            set { areaType = AreaType.city; }
        }

        public void GetAreaMasterByCity(string s)
        {
            int flag1 = 0;
            int countryCode, stateCode;

            foreach (var item in areaCollection)
            {
                //  Console.WriteLine(item.Name);
                if (item.Name == s)
                {
                    stateCode = item.AreaID;

                    Console.WriteLine("City Name : " + item.Name);
                    foreach (var item1 in areaCollection)
                    {
                        if (item1.ID == stateCode)
                        {
                            Console.WriteLine("State : " + item1.Name);
                            countryCode = item1.AreaID;
                            foreach (var item2 in areaCollection)
                            {
                                if (item2.ID == countryCode)
                                {
                                    Console.WriteLine("Country : " + item2.Name);
                                    break;
                                }

                            }
                            break;
                        }
                    }
                    Console.WriteLine("State Code : " + item.Code + "\nArea : " + AreaType.city + "\nAreaId : " + item.AreaID);
                    flag1 = 1;
                    break;
                }



            }

            if (flag1 == 0)
            {
                Console.WriteLine("No entry");
            }



        }


    }

    public class districtMaster : AreaMaster
    {

        AreaType areaType;
        public override AreaType areat
        {
            get { return areaType; }
            set { areaType = AreaType.district; }
        }

        public void GetAreaMasterByDistrict(string s)
        {
            int flag1 = 0;
            int countryCode, stateCode, cityCode;

            foreach (var item in areaCollection)
            {
                //  Console.WriteLine(item.Name);
                if (item.Name == s)
                {
                    cityCode = item.AreaID;

                    Console.WriteLine("District : " + item.Name);
                    foreach (var item1 in areaCollection)
                    {
                        if (item1.ID == cityCode)
                        {
                            Console.WriteLine("City : " + item1.Name);
                            stateCode = item1.AreaID;
                            foreach (var item2 in areaCollection)
                            {
                                if (item2.ID == stateCode)
                                {
                                    Console.WriteLine("State : " + item2.Name);
                                    countryCode = item2.AreaID;
                                    foreach (var item3 in areaCollection)
                                    {
                                        if (item3.ID == countryCode)
                                        {
                                            Console.WriteLine("Country : " + item3.Name);
                                            break;
                                        }

                                    }
                                    break;
                                }

                            }
                            break;
                        }
                    }
                    Console.WriteLine("State Code : " + item.Code + "\nArea : " + AreaType.district + "\nAreaId : " + item.AreaID);
                    flag1 = 1;
                    break;
                }



            }

            if (flag1 == 0)
            {
                Console.WriteLine("No entry");
            }


        }

    }
}
