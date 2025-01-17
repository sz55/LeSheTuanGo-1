﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LeSheTuanGo.Models
{
    public class PayModel
    {
        public string MerchantID { get; set; }
        public string MerchantTradeNo { get; set; }
        public string MerchantTradeDate { get; set; }
        public string PaymentType { get; set; }
        public string TotalAmount { get; set; }
        public string TradeDesc { get; set; }
        public string ItemName { get; set; }
        public string ReturnURL { get; set; }
        public string ChoosePayment { get; set; }
        public string StoreID { get; set; }
        public string ClientBackURL { get; set; }
        public string CreditInstallment { get; set; }
        public string InstallmentAmount { get; set; }
        public string Redeem { get; set; }
        public string EncryptType { get; set; }
        public string CheckMacValue { get; set; }
        public string SuccessUrl { get; set; }
        public string HashKey { get; set; }
        public string HashIV { get; set; }
    }
}
