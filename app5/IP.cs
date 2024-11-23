using System;
using System.Net;

namespace adresacjaIP {

    public class IP : AIP {

        public IP(uint adresip, uint maskasieci = 0B11111111111111111111111100000000) 
            : base(adresip, maskasieci){

            }

        public override string uint2bin(uint adres, byte intMaska){
            string res = "";
            for(int i=0; i<4; i++)
                {
                    int octet = (int)(adres & 0xFF);
                    adres >>= 8;
                    if(res!= "")
                        res = "." + res;
                    res = Convert.ToString(octet, 2).PadLeft(8, '0') + res;    

                }
                int pos = intMaska+((intMaska-1)/8)-1;
                if(pos>0)
                    res = res.Insert(pos, "|");

            return res;
        }

        public override string uint2IPv4(uint adres){
            string res = "";
            for(int i=0; i<4; i++)
                {
                    int octet = (int)(adres & 0xFF);
                    adres >>= 8;
                    if(res!= "")
                        res = "." + res;
                    res = Convert.ToString(octet, 10) + res;    

                }

            return res;
        }

        // public override string uint2IPv4(uint adres){
        //     return "";
        // }

        private static uint konvMaskiByte2uint(byte maska){
            uint umaska = 0;
            for(byte i = 0; i<=maska; i++)
                umaska |= (uint)(1 << (32-i));

            return umaska;
        }

        private static uint konvIP(string adres){
            IPAddress _adres = IPAddress.Parse(adres);
            byte[] bajty = _adres.GetAddressBytes();
            return (uint) (bajty[0]<<24 | bajty[1]<<16 | bajty[2]<<8 | bajty[3]);

        }
        public IP(string adresip, string maskasieci = "255.255.255.0")
          :  base(konvIP(adresip), konvIP(maskasieci)){
        }    
        public IP(string adresip, byte maskasieci = 24)
          :  base(konvIP(adresip), konvMaskiByte2uint(maskasieci)){
        }    

    }

}