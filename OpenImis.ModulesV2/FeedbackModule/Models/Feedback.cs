﻿using System;
using System.Collections.Generic;
using System.Text;

namespace OpenImis.ModulesV2.FeedbackModule.Models
{
    public class Feedback
    {
        public string Officer { get; set; }
        public int ClaimID { get; set; }
        public string CHFID { get; set; }
        public string Answers { get; set; }
        public string Date { get; set; }
    }
}
