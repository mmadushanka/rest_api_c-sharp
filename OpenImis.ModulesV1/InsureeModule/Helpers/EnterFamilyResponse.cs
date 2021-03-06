﻿using OpenImis.ModulesV1.InsureeModule.Helpers.Messages;
using System;
using System.Collections.Generic;
using System.Text;

namespace OpenImis.ModulesV1.InsureeModule.Helpers
{
    public class EnterFamilyResponse : ImisApiResponse
    {
        public EnterFamilyResponse(Exception e) : base(e)
        {
        }

        public EnterFamilyResponse(int value, bool error, int lang) : base(value, error, lang)
        {
            SetMessage(value);
        }

        public EnterFamilyResponse(int value, bool error, object data, int lang) : base(value, error, data, lang)
        {
            SetMessage(value);
        }

        private void SetMessage(int value)
        {
            switch (value)
            {
                case 0:

                    msg.Code = value;
                    msg.MessageValue = new Language().GetMessage(language, "Success");
                    Message = msg;
                    break;
                case 1:

                    msg.Code = value;
                    msg.MessageValue = new Language().GetMessage(language, "WrongOrMissingHeadIN");
                    Message = msg;
                    break;
                case 2:

                    msg.Code = value;
                    msg.MessageValue = new Language().GetMessage(language, "DuplicateINHead");
                    Message = msg;
                    break;
                case 3:

                    msg.Code = value;
                    msg.MessageValue = new Language().GetMessage(language, "WrongOrMissingPVC");
                    Message = msg;
                    break;
                case 4:

                    msg.Code = value;
                    msg.MessageValue = new Language().GetMessage(language, "WrongCVillageCode");
                    Message = msg;
                    break;
                case 5:

                    msg.Code = value;
                    msg.MessageValue = new Language().GetMessage(language, "WrongOrMissingGender");
                    Message = msg;
                    break;
                case 6:
                    msg.Code = value;
                    msg.MessageValue = new Language().GetMessage(language, "WrongFrOrMissingBd");
                    Message = msg;
                    break;
                case 7:
                    msg.Code = value;
                    msg.MessageValue = new Language().GetMessage(language, "MissingLastName");
                    Message = msg;
                    break;
                case 8:
                    msg.Code = value;
                    msg.MessageValue = new Language().GetMessage(language, "MissingOtherName");
                    Message = msg;
                    break;
                case 9:
                    msg.Code = value;
                    msg.MessageValue = new Language().GetMessage(language, "WrongConfirmationType");
                    Message = msg;
                    break;
                case 10:

                    msg.Code = value;
                    msg.MessageValue = new Language().GetMessage(language, "WrongGroupType");
                    Message = msg;
                    break;
                case 11:
                    msg.Code = value;
                    msg.MessageValue = new Language().GetMessage(language, "WrongMaritalStatus");
                    Message = msg;
                    break;
                case 12:
                    msg.Code = value;
                    msg.MessageValue = new Language().GetMessage(language, "WrongEducation");
                    Message = msg;
                    break;
                case 13:
                    msg.Code = value;
                    msg.MessageValue = new Language().GetMessage(language, "WrongProfession");
                    Message = msg;
                    break;
                case 14:

                    msg.Code = value;
                    msg.MessageValue = new Language().GetMessage(language, "FSPCodeNotFound");
                    Message = msg;
                    break;
                case 15:

                    msg.Code = value;
                    msg.MessageValue = new Language().GetMessage(language, "WrongIdentificationType");
                    Message = msg;
                    break;
            }
        }
    }
}
