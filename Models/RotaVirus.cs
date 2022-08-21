using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace u21475009_HW04.Models
{
    public class RotaVirus : Vaccination
    {
        private int mDoses;
        private string mSeverity;
        private int mAge;


        public Rotavirus()
        {

        }

        public RotaVirus(string _Name, string _Type, int _ID, int _Doses, string _Severity, int _Age) : base
            (string _Name, string _Type, int _ID)

        {
            mDoses = _Doses;
            mSeverity = _Severity;
            mAge = _Age;
        }

        public string Doses
        {
            get { return mDoses; }
            set { mDoses = value; }

        }

        public string Severity
        {
            get { return mSeverity; }
            set { mSeverity = value; }
        }

        public int Age
        {
            get { return mAge; }
            set { mAge = value; }
        }