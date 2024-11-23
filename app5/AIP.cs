namespace adresacjaIP {

    public abstract class AIP {
        private uint _maska = 0;
        private uint _ip = 0;
        public uint ip {get=>_ip;}
        public uint maska {get=>_maska;}

        public AIP(uint adresip, uint maskasieci = 0xffffff00) //255.255.255.0
        {
            this._ip = adresip;
            this._maska = maskasieci;
        }

        public abstract string uint2bin(uint adres, byte intMaska);
        public abstract string uint2IPv4(uint adres);



        public int wielkoscMaski(){
            uint lmaska = this._maska;
            int ileJedynek = 0;
            while(lmaska>0){
                if((lmaska & 1) == 1)
                    ileJedynek++;
                lmaska >>= 1;
            }
            return ileJedynek*1;
        }

        public uint adresSieci(){
            return _ip & _maska;
        }

        public uint adresRozgloszeniowy(){
            return (_ip & _maska) | (~_maska & 0xffffffff);
        }

        public uint pierwszyHost() {
            return adresSieci()+1;
        }
        public uint ostatniHost() {
            return adresRozgloszeniowy()-1;
        }

        public int ileHostow(){
            // ile (2^32-maska)-2
            return (int) Math.Pow(2, 32-this.wielkoscMaski())-2;
        }

    }


}