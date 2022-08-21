using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace u21475009_HW04.Models
{
    public class Measles : Vaccination
    {
        private string mImmunity;
        private string mPeriod;
        private int mAge;


        public Measles()
        {

        }

        public Measles(string _Name, string _Type, int _ID, string _Immunity, string _Immunity, int _Age) : base
            (string _Name, string _Type, int _ID)

        {
            mImmunity = _Immunity;
            mPeriod = _Period;
            mAge = _Age;
        }

        public string Immunity
        {
            get { return mImmunity; }
            set { mImmunity = value; }

        }

        public string Period
        {
            get { return mPeriod; }
            set { mPeriod = value; }
        }

        public int Age
        {
            get { return mAge; }
            set { mAge = value; }
        }