﻿using ImisRestApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ImisRestApi.Data;
using Microsoft.Extensions.Configuration;
using Microsoft.AspNetCore.Hosting;
using ImisRestApi.Models.Payment;

namespace ImisRestApi.Logic
{
    public class PaymentLogic
    {
        public ImisBasePayment _imisPayment;
        private IConfiguration _configuration;
        private readonly IHostingEnvironment _hostingEnvironment;

        public PaymentLogic(IConfiguration configuration, IHostingEnvironment hostingEnvironment)
        {
            _configuration = configuration;
            _hostingEnvironment = hostingEnvironment;
            _imisPayment = new ImisBasePayment(configuration, hostingEnvironment);
        }
        public bool SaveIntent(IntentOfPay intent)
        {
             //save the intent of pay
            _imisPayment.SaveIntent(intent);

            string url = _configuration["PaymentGateWay:Url"] + _configuration["PaymentGateWay:CNRequest"];

            ImisBasePayment payment = new ImisBasePayment(_configuration,_hostingEnvironment);
            payment.GenerateCtrlNoRequest(intent.OfficerCode,intent.InsureeNumber, _imisPayment.PaymentId, _imisPayment.ExpectedAmount,intent.PaymentDetails);

            //ControlNumberRequest response = ControlNumberChanel.PostRequest(url, _paymentRepo.PaymentId, _paymentRepo.ExpectedAmount);

            //if (response.ControlNumber != null)
            //{
            //    _paymentRepo.SaveControlNumber(response.ControlNumber);

            //}
            //else if (response.ControlNumber == null)
            //{
            //    _paymentRepo.SaveControlNumber();
            //}
            //else if (response.RequestAcknowledged)
            //{
            //    _paymentRepo.SaveControlNumberAkn(response.RequestAcknowledged,"");
            //}

           // string test = await Message.PushSMS("Your Request for control number was Sent", "+255767057265");

          //  return Json(new { status = true, sms_reply = true, sms_text = "Your Request for control number was Sent" });
            return true;
        }

        internal void ReceiveControlNumberAck(Acknowledgement model)
        {
            throw new NotImplementedException();
        }

        public String ReceiveControlNumber(ControlNumberResp model)
        {
            return "0";
        }


    }
}
