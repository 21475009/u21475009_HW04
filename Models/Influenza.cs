using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace u21475009_HW04.Models
{
    public class Influenza : Vaccination
    {
        private string mLocation;
        private string mSeason;
        private int mAge;
           
    
        public Influenza()
        {

        }

        public Influenza(string _Name, string _Type, int _ID, string _Location, string _Season, int _Age) : base
            (string _Name, string _Type, int _ID )

        {
            mLocation = _Location;
            mSeason = _Season;
            mAge = _Age;
        }

        public string Location
        {
            get { return mLocation; }
            set { mLocation = value; }

        }

        public string Season
        {
            get { return mSeason; }
            set { mSeason = value; }
        }

        public int Age
        {
            get { return mAge; }
            set { mAge = value; }
        }




}