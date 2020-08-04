using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace InovexiaEBS
{
    public class BOFebChemicalConsumption
    {
        private int sampleNo;
        public int SampleNo
        {
            get { return sampleNo; }
            set { sampleNo = value; }
        }


        private int chemicalId;
        public int ChemicalID
        {
            get { return chemicalId; }
            set { chemicalId = value; }
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

        private int productionStageFlag;

        public int ProductionStageFlag
        {
            get { return productionStageFlag; }
            set { productionStageFlag = value; }
        }
    }
}