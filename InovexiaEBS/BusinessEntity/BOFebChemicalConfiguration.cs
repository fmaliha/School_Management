using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace InovexiaEBS
{
    public class BOFebChemicalConfiguration
    {
        private int sample;

        public int Sample
        {
            get { return sample; }
            set { sample = value; }
        }


        private double sWeighht;

        public double SWeight
        {
            get { return sWeighht; }
            set { sWeighht = value; }
        }

        private double eWeighht;

        public double EWeight
        {
            get { return eWeighht; }
            set { eWeighht = value; }
        }

        private int chemicalID;

        public int ChemicalId
        {
            get { return chemicalID; }
            set { chemicalID = value; }
        }

        private double chemicalWeight;

        public double ChemicalWeight
        {
            get { return chemicalWeight; }
            set { chemicalWeight = value; }
        }



        private Boolean Transfered;

        public Boolean Transfered1
        {
            get { return Transfered; }
            set { Transfered = value; }
        }
        private string AddedBy;

        public string AddedBy1
        {
            get { return AddedBy; }
            set { AddedBy = value; }
        }

        private DateTime DateAdded;

        public DateTime DateAdded1
        {
            get { return DateAdded; }
            set { DateAdded = value; }
        }

        private string UpdatedBy;

        public string UpdatedBy1
        {
            get { return UpdatedBy; }
            set { UpdatedBy = value; }
        }

        private DateTime DateUpdated;

        public DateTime DateUpdated1
        {
            get { return DateUpdated; }
            set { DateUpdated = value; }
        }


        private int serialNo;

        public int SerialNo
        {
            get { return serialNo; }
            set { serialNo = value; }
        }

    }
}