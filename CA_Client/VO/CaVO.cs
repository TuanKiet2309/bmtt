using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace CA_Client.VO
{
    public class CaVO
    {
        private string SerialNumber;
        private int UserID;
        private string Version = "3";
        private string SignatureAlgorithm = "md5WithRSAencryption";
        private string IssuerName = "E=finalcl@bmtt.com.vn, CN= FinalC-L, L=HCMUTE, OU=BMTT, O=CA, C=VN";
        private string ValidityPeriod_before;
        private string ValidityPeriod_after;
        private string SubjectName;
        private string PublicKey;
        private string PrivateKey;
        private string Extensions = "X.509v3 Basic Constraints: critical, ca: false ";
        private string ContentSubject;
        private string SignatureCA;
        public CaVO()
        {
            //
            // TODO: Add constructor logic here
            //
        }
        public CaVO(string SerialNumber, int UserID, string ValidityPeriod_before, string ValidityPeriod_after, string SubjectName, string PublicKey, string PrivateKey, string SignatureCA)
        {
            //
            // TODO: Add constructor logic here
            //
            this.SerialNumber1 = SerialNumber;
            this.UserID1 = UserID;
            this.ValidityPeriod_before1 = ValidityPeriod_before;
            this.ValidityPeriod_after1 = ValidityPeriod_after;
            this.SubjectName1 = SubjectName;
            this.PublicKey1 = PublicKey;
            this.PrivateKey1 = PrivateKey;
            this.Extensions1 = Extensions;
            this.SignatureCA1 = SignatureCA;
        }
        public string SerialNumber1
        {
            get => SerialNumber;
            set
            {
                SerialNumber = value;
            }
        }
        public int UserID1 { get => UserID; set => UserID = value; }
        public string Version1 { get => Version; set => Version = value; }
        public string SignatureAlgorithm1 { get => SignatureAlgorithm; set => SignatureAlgorithm = value; }
        public string IssuerName1 { get => IssuerName; set => IssuerName = value; }
        public string ValidityPeriod_before1 { get => ValidityPeriod_before; set => ValidityPeriod_before = value; }
        public string ValidityPeriod_after1 { get => ValidityPeriod_after; set => ValidityPeriod_after = value; }
        public string SubjectName1 { get => SubjectName; set => SubjectName = value; }
        public string PublicKey1 { get => PublicKey; set => PublicKey = value; }
        public string PrivateKey1 { get => PrivateKey; set => PrivateKey = value; }
        public string Extensions1 { get => Extensions; set => Extensions = value; }
        public string ContentSubject1 { get => ContentSubject; set => ContentSubject = value; }
        public string SignatureCA1 { get => SignatureCA; set => SignatureCA = value; }
    }
}
