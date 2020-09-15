using System;
using System.Collections.Generic;
using System.Text;

namespace ERES.Payment.Server.Common
{
    public class CommonEnums
    {
        public enum PaymentType : int
        {
            Cheque = 1,
            Cash = 2,
            Online = 3,
            Prepaid = 4,
            CreditNote = 5,
            DepositReceipt = 6,
            DebitCard = 7,
            CreditCard = 8,
            BankAccount = 9,
            DirectDebit = 10,
            CurrentOrSavingAccount = 11,
            BankCreditCard = 12,
            PrePaidCard = 13,
            POS = 15,
            KioskTerminal = 16
        }

        public enum PaymentChannels
        {
           
            None = 0,
           
            ATM = 1,
           
            CDM = 2,
           
            KIOSK = 3,
           
            POS = 4,
           
            Online = 5,
           
            DebitCard = 6,
           
            CreditCard = 7,
           
            DirectDebit = 8,
           
            PGS = 9,
           
            NOQONL = 10,
           
            NOQEXP = 11,
           
            ERESOnline = 12,
           
            ERESCash = 13,
           
            ERESCheque = 14,
           
            ERESDeposit = 15,
           
            ERESPOS = 16,
           
            eDirhamOnline = 4001,
           
            eDirhamPOSOnline = 18,
           
            NOQODI_BROKER_PAYMENT = 20,
           
            V2_NOQODI_ONLINE = 19,
           
            V2_NOQODI_EXP = 21,
           
            NOQODI_BILLER = 22
        }

        public enum PaymentTransactionStatus
        {
           
            Pending = 1,
           
            Completed = 2,
           
            Cancelled = 3,
           
            Invalid = 4,
           
            Refuneded = 5,
           
            Expired = 6,
           
            Created = 7,
           
            WaitingForResponse = 8,
           
            Paid = 9,
           
            Review = 10,
           
            Error = 11,
           
            RefundInProgress = 12,
           
            Declined = 14,
           
            Failed = 15,
           
            Hold = 16,
           
            Rejected = 17,
           
            UnderProcess = 18,

        }

        public enum PaymentMethod : int
        {
           
            Normal = 1,
           
            Express = 2
        }

        
        public enum NoqodiV1PaymentStatus
        {           
            Success = 'S',         
            Failed = 'F',            
            Exist = 'N',            
            NotExist = 'E',            
            AlreadyReconciled = 'D',            
            Invalid = 'I',            
            Hold = 'H'
        }
    }
}
