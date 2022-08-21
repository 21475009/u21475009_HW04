using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace u21475009_HW04.Models
{
    public class ChickenPox : Vaccination
    {
        private string mSymptoms;
        private int mStrain;
        private int mAge;


        public ChickenPox()
        {

        }

        public CHickenPox(string _Name, string _Type, int _ID, string _Symptoms, int _Strain, int _Age) : base
            (string _Name, string _Type, int _ID)

        {
            mSymptoms= _Symptoms;
            mStrain = _Strain;
            mAge = _Age;
        }

        public string Symptoms
        {
            get { return mSymptoms; }
            set { mSymptoms = value; }

        }

        public int Strain
        {
            get { return mStrain; }
            set { mStrain = value; }
        }

        public int Age
        {
            get { return mAge; }
            set { mAge = value; }
        }