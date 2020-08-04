using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace InovexiaEBS
{
    public class BOYarnConsumption
    {
        private int sampleNo;
        public int SampleNo
        {
            get { return sampleNo; }
            set { sampleNo = value; }
        }


        private int yarnId;
        public int YarnID
        {
            get { return yarnId; }
            set { yarnId = value; }
        }



        private string yarnCount;
        public string YarnCount
        {
            get { return yarnCount; }
            set { yarnCount = value; }
        }

        private string countSpecification;
        public string CountSpecification
        {
            get { return countSpecification; }
            set { countSpecification = value; }
        }

        private string lotNo;
        public string LotNo
        {
            get { return lotNo; }
            set { lotNo = value; }
        }

        private string beam;
        public string Beam
        {
            get { return beam; }
            set { beam = value; }
        }

        private double kgPerYd;
        public double KGPerYd
        {
            get { return kgPerYd; }
            set { kgPerYd = value; }
        }

        private double totalEnds;
        public double TotalEnds
        {
            get { return totalEnds; }
            set { totalEnds = value; }
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