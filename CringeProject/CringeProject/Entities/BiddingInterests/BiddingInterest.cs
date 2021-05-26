using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CringeProject.Entities.BiddingInterests {
    public class BiddingInterest {
        public const string StrongAccept = "StrongAccept";
        public const string Accept = "Accept";

        public const string StrongDecline = "StrongDecline";
        public const string Decline = "Decline";

        public static bool IsPositive(string biddingInterest) {
            return biddingInterest == StrongAccept || biddingInterest == Accept;
        }
        public static bool IsNegative(string biddingInterest) {
            return !IsPositive(biddingInterest);
        }
    }
}
