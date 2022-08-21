using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace u21475009_HW04.Models
{
    public abstract class Vaccination
    {
        private string mName;
        private string mType;
        private int mID;


        public Vaccination()
        {

        }

        public Vaccination(string _Name, string _Type, int _ID)
        {
            mName = _Name;
            mType = _Type;
            mID = _ID;
        

        public string Name
        {
            get { return mName; }
            set { mName = value; }
        }

        public string Type
        {
            get { return mType; }
            set { mType = value; }
        }

        public int ID
        {
            get { return mID; }
            set { mID = value; }
        }
    }


}