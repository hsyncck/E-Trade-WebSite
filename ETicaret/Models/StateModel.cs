﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ETicaret.Models
{
    public class StateModel
    {
        public int UrunSayisi { get; set; }
        public int SiparisSayisi { get; set; }
        public int BekleyenSiparisSayisi { get; set; }
        public int TamamlananSiparisSayisi { get; set; }
        public int PaketlenenSiparisSayisi { get; set; }
        public int KargolanSiparisSayisi { get; set; }
    }
}