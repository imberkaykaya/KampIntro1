﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Metotlar
{
	public class Urun
	{
		//Property - özellik -- > (n: dbdeki özllkleri(verileri) kullanmak için)
        public int Id { get; set; }
		public string Adi { get; set; }
		public double Fiyati { get; set; }
		public string Aciklama { get; set; }
        public int StokAdet { get; set; }
    }
}