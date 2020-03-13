using System;

namespace GameGenieEncoderDecoder
{
    public class Genie
    {


        #region SNES

        public string DecryptSnesCodeToAddressAndValue(string codeString)
        {
            string decryptedString;
            string decodedValueString = "";
            string decryptedAddress = "";
            string temp1 = "";
            string temp2 = "";
            string temp3 = "";
            int i = 0;

            foreach (char c in codeString)
            {
                if (i < 2)
                {
                    decodedValueString += DecodeSnes(c.ToString());
                }
                else if (i < 4)
                {
                    temp1 += DecodeSnes(c.ToString());
                }
                else if (i < 6)
                {
                    temp2 += DecodeSnes(c.ToString());
                }
                else if (i < 8)
                {
                    temp3 += DecodeSnes(c.ToString());
                }

                i++;
            }

            decryptedAddress = DecryptSnesAddress(temp1, temp2, temp3);

            decryptedString = decodedValueString + decryptedAddress;

            return decryptedString;
        }

        /*
         * SNES Cipher
         * Code:  D F 4 7 0 9 1 5 6 B C 8 A 2 3 E
         * Hex:   0 1 2 3 4 5 6 7 8 9 A B C D E F
         */
        private string DecodeSnes(string character)
        {
            character = character.ToUpper();
            string decodedCharacter = "";

            switch (character)
            {
                case "D":
                    decodedCharacter = "0";
                    break;
                case "F":
                    decodedCharacter = "1";
                    break;
                case "4":
                    decodedCharacter = "2";
                    break;
                case "7":
                    decodedCharacter = "3";
                    break;
                case "0":
                    decodedCharacter = "4";
                    break;
                case "9":
                    decodedCharacter = "5";
                    break;
                case "1":
                    decodedCharacter = "6";
                    break;
                case "5":
                    decodedCharacter = "7";
                    break;
                case "6":
                    decodedCharacter = "8";
                    break;
                case "B":
                    decodedCharacter = "9";
                    break;
                case "C":
                    decodedCharacter = "A";
                    break;
                case "8":
                    decodedCharacter = "B";
                    break;
                case "A":
                    decodedCharacter = "C";
                    break;
                case "2":
                    decodedCharacter = "D";
                    break;
                case "3":
                    decodedCharacter = "E";
                    break;
                case "E":
                    decodedCharacter = "F";
                    break;
            }

            return decodedCharacter;
        }

        /*
         * Code:           ijklqrst opabcduv wxefghmn e.g. 10100000 11110001 00010001 = A0 F1 11
         * Decrypted Code: abcdefgh ijklmnop qrstuvwx e.g. 11000100 10100111 00000100 = C4 A7 04
         */
        private string DecryptSnesAddress(string hex1, string hex2, string hex3)
        {
            string decodedAddress;

            string bin1 = Convert.ToString(Convert.ToInt32(hex1, 16), 2).PadLeft(8, '0');
            string bin2 = Convert.ToString(Convert.ToInt32(hex2, 16), 2).PadLeft(8, '0');
            string bin3 = Convert.ToString(Convert.ToInt32(hex3, 16), 2).PadLeft(8, '0');

            string decodedBin1 = bin2[2].ToString() + bin2[3].ToString() + bin2[4].ToString() + bin2[5].ToString() + bin3[2].ToString() + bin3[3].ToString() + bin3[4].ToString() + bin3[5].ToString();
            string decodedBin2 = bin1[0].ToString() + bin1[1].ToString() + bin1[2].ToString() + bin1[3].ToString() + bin3[6].ToString() + bin3[7].ToString() + bin2[0].ToString() + bin2[1].ToString();
            string decodedBin3 = bin1[4].ToString() + bin1[5].ToString() + bin1[6].ToString() + bin1[7].ToString() + bin2[6].ToString() + bin2[7].ToString() + bin3[0].ToString() + bin3[1].ToString();

            string decodedHex1 = Convert.ToInt32(decodedBin1, 2).ToString("X").PadLeft(2, '0');
            string decodedHex2 = Convert.ToInt32(decodedBin2, 2).ToString("X").PadLeft(2, '0');
            string decodedHex3 = Convert.ToInt32(decodedBin3, 2).ToString("X").PadLeft(2, '0');

            decodedAddress = decodedHex1 + decodedHex2 + decodedHex3;

            return decodedAddress;
        }

        public string EncryptSnesAddressAndValueToCode(string hexString)
        {
            string encryptedString;
            string encryptedAddress;
            string temp1;
            string temp2;
            string temp3;
            string encodedAddress1;
            string encodedAddress2;
            string encodedAddress3;
            string encodedAddress4;
            string encodedAddress5;
            string encodedAddress6;

            encryptedString = EncodeSnes(hexString[0].ToString());
            encryptedString += EncodeSnes(hexString[1].ToString());

            temp1 = hexString.Substring(2, 2);
            temp2 = hexString.Substring(4, 2);
            temp3 = hexString.Substring(6, 2);

            encryptedAddress = EncryptSnesAddress(temp1, temp2, temp3);

            encodedAddress1 = EncodeSnes(encryptedAddress[0].ToString());
            encodedAddress2 = EncodeSnes(encryptedAddress[1].ToString());
            encodedAddress3 = EncodeSnes(encryptedAddress[2].ToString());
            encodedAddress4 = EncodeSnes(encryptedAddress[3].ToString());
            encodedAddress5 = EncodeSnes(encryptedAddress[4].ToString());
            encodedAddress6 = EncodeSnes(encryptedAddress[5].ToString());

            encryptedString += encodedAddress1 + encodedAddress2 + encodedAddress3 + encodedAddress4 + encodedAddress5 + encodedAddress6;

            return encryptedString;
        }

        /*
         * SNES Cipher
         * Hex:   0 1 2 3 4 5 6 7 8 9 A B C D E F
         * Code:  D F 4 7 0 9 1 5 6 B C 8 A 2 3 E
         */
        private string EncodeSnes(string character)
        {
            character = character.ToUpper();
            string encodedCharacter = "";

            switch (character)
            {
                case "0":
                    encodedCharacter = "D";
                    break;
                case "1":
                    encodedCharacter = "F";
                    break;
                case "2":
                    encodedCharacter = "4";
                    break;
                case "3":
                    encodedCharacter = "7";
                    break;
                case "4":
                    encodedCharacter = "0";
                    break;
                case "5":
                    encodedCharacter = "9";
                    break;
                case "6":
                    encodedCharacter = "1";
                    break;
                case "7":
                    encodedCharacter = "5";
                    break;
                case "8":
                    encodedCharacter = "6";
                    break;
                case "9":
                    encodedCharacter = "B";
                    break;
                case "A":
                    encodedCharacter = "C";
                    break;
                case "B":
                    encodedCharacter = "8";
                    break;
                case "C":
                    encodedCharacter = "A";
                    break;
                case "D":
                    encodedCharacter = "2";
                    break;
                case "E":
                    encodedCharacter = "3";
                    break;
                case "F":
                    encodedCharacter = "E";
                    break;
            }

            return encodedCharacter;
        }

        /*
         * Code:           abcdefgh ijklmnop qrstuvwx e.g. 11000100 10100111 00000100 = C4 A7 04
         * Encrypted Code: ijklqrst opabcduv wxefghmn e.g. 10100000 11110001 00010001 = A0 F1 11
         */
        private string EncryptSnesAddress(string hex1, string hex2, string hex3)
        {
            string encodedAddress;

            string bin1 = Convert.ToString(Convert.ToInt32(hex1, 16), 2).PadLeft(8, '0');
            string bin2 = Convert.ToString(Convert.ToInt32(hex2, 16), 2).PadLeft(8, '0');
            string bin3 = Convert.ToString(Convert.ToInt32(hex3, 16), 2).PadLeft(8, '0');

            string encodedBin1 = bin2[0].ToString() + bin2[1].ToString() + bin2[2].ToString() + bin2[3].ToString() + bin3[0].ToString() + bin3[1].ToString() + bin3[2].ToString() + bin3[3].ToString();
            string encodedBin2 = bin2[6].ToString() + bin2[7].ToString() + bin1[0].ToString() + bin1[1].ToString() + bin1[2].ToString() + bin1[3].ToString() + bin3[4].ToString() + bin3[5].ToString();
            string encodedBin3 = bin3[6].ToString() + bin3[7].ToString() + bin1[4].ToString() + bin1[5].ToString() + bin1[6].ToString() + bin1[7].ToString() + bin2[4].ToString() + bin2[5].ToString();

            string encodedHex1 = Convert.ToInt32(encodedBin1, 2).ToString("X").PadLeft(2, '0');
            string encodedHex2 = Convert.ToInt32(encodedBin2, 2).ToString("X").PadLeft(2, '0');
            string encodedHex3 = Convert.ToInt32(encodedBin3, 2).ToString("X").PadLeft(2, '0');

            encodedAddress = encodedHex1 + encodedHex2 + encodedHex3;

            return encodedAddress;
        }

        #endregion

        #region Sega Genesis / MegaDrive

        private string DecodeGenMD(string character)
        {
            character = character.ToUpper();
            string decodeBinaryString = "";

            switch (character)
            {
                case "A":
                    decodeBinaryString = "00000";
                    break;
                case "B":
                    decodeBinaryString = "00001";
                    break;
                case "C":
                    decodeBinaryString = "00010";
                    break;
                case "D":
                    decodeBinaryString = "00011";
                    break;
                case "E":
                    decodeBinaryString = "00100";
                    break;
                case "F":
                    decodeBinaryString = "00101";
                    break;
                case "G":
                    decodeBinaryString = "00110";
                    break;
                case "H":
                    decodeBinaryString = "00111";
                    break;
                case "J":
                    decodeBinaryString = "01000";
                    break;
                case "K":
                    decodeBinaryString = "01001";
                    break;
                case "L":
                    decodeBinaryString = "01010";
                    break;
                case "M":
                    decodeBinaryString = "01011";
                    break;
                case "N":
                    decodeBinaryString = "01100";
                    break;
                case "P":
                    decodeBinaryString = "01101";
                    break;
                case "R":
                    decodeBinaryString = "01110";
                    break;
                case "S":
                    decodeBinaryString = "01111";
                    break;
                case "T":
                    decodeBinaryString = "10000";
                    break;
                case "V":
                    decodeBinaryString = "10001";
                    break;
                case "W":
                    decodeBinaryString = "10010";
                    break;
                case "X":
                    decodeBinaryString = "10011";
                    break;
                case "Y":
                    decodeBinaryString = "10100";
                    break;
                case "Z":
                    decodeBinaryString = "10101";
                    break;
                case "0":
                    decodeBinaryString = "10110";
                    break;
                case "1":
                    decodeBinaryString = "10111";
                    break;
                case "2":
                    decodeBinaryString = "11000";
                    break;
                case "3":
                    decodeBinaryString = "11001";
                    break;
                case "4":
                    decodeBinaryString = "11010";
                    break;
                case "5":
                    decodeBinaryString = "11011";
                    break;
                case "6":
                    decodeBinaryString = "11100";
                    break;
                case "7":
                    decodeBinaryString = "11101";
                    break;
                case "8":
                    decodeBinaryString = "11110";
                    break;
                case "9":
                    decodeBinaryString = "11111";
                    break;
            }

            return decodeBinaryString;
        }

        /*
         * Code:           ijklmnop IJKLMNOP ABCDEFGH defghabc QRSTUVWX
         * Decrypted Code: ABCDEFGH IJKLMNOP QRSTUVWX abcdefgh ijklmnop
         */
        private string DecryptGenMDAddressAndValue(string binaryString)
        {
            string decodedString;
            string bin1 = "";
            string bin2 = "";
            string bin3 = "";
            string bin4 = "";
            string bin5 = "";
            int i = 0;

            /** - binaryString is a 40-digit binary number, break this number up into 8-digit pieces. */
            foreach (char c in binaryString)
            {
                if (i < 8)
                {
                    bin1 += c;
                }
                else if (i < 16)
                {
                    bin2 += c;
                }
                else if (i < 24)
                {
                    bin3 += c;
                }
                else if (i < 32)
                {
                    bin4 += c;
                }
                else if (i < 40)
                {
                    bin5 += c;
                }

                i++;
            }

            string decodedBin1 = bin3;
            string decodedBin2 = bin2;
            string decodedBin3 = bin5;
            string decodedBin4 = bin4[5].ToString() + bin4[6].ToString() + bin4[7].ToString() + bin4[0].ToString() + bin4[1].ToString() + bin4[2].ToString() + bin4[3].ToString() + bin4[4].ToString();
            string decodedBin5 = bin1;

            string decodedHex1 = Convert.ToInt32(decodedBin1, 2).ToString("X").PadLeft(2, '0');
            string decodedHex2 = Convert.ToInt32(decodedBin2, 2).ToString("X").PadLeft(2, '0');
            string decodedHex3 = Convert.ToInt32(decodedBin3, 2).ToString("X").PadLeft(2, '0');
            string decodedHex4 = Convert.ToInt32(decodedBin4, 2).ToString("X").PadLeft(2, '0');
            string decodedHex5 = Convert.ToInt32(decodedBin5, 2).ToString("X").PadLeft(2, '0');

            decodedString = decodedHex1 + decodedHex2 + decodedHex3 + decodedHex4 + decodedHex5;

            return decodedString;
        }

        public string DecryptGenMDCodeToAddressAndValue(string codeString)
        {
            string binaryString;
            string decryptedString;
            string code1 = codeString[0].ToString();
            string code2 = codeString[1].ToString();
            string code3 = codeString[2].ToString();
            string code4 = codeString[3].ToString();
            string code5 = codeString[4].ToString();
            string code6 = codeString[5].ToString();
            string code7 = codeString[6].ToString();
            string code8 = codeString[7].ToString();

            binaryString = DecodeGenMD(code1);
            binaryString += DecodeGenMD(code2);
            binaryString += DecodeGenMD(code3);
            binaryString += DecodeGenMD(code4);
            binaryString += DecodeGenMD(code5);
            binaryString += DecodeGenMD(code6);
            binaryString += DecodeGenMD(code7);
            binaryString += DecodeGenMD(code8);

            decryptedString = DecryptGenMDAddressAndValue(binaryString);
            return decryptedString;
        }


        private string EncodeGenMD(string binaryString)
        {
            binaryString = binaryString.ToUpper();
            string encodedCharacter = "";


            switch (binaryString)
            {
                case "00000":
                    encodedCharacter = "A";
                    break;
                case "00001":
                    encodedCharacter = "B";
                    break;
                case "00010":
                    encodedCharacter = "C";
                    break;
                case "00011":
                    encodedCharacter = "D";
                    break;
                case "00100":
                    encodedCharacter = "E";
                    break;
                case "00101":
                    encodedCharacter = "F";
                    break;
                case "00110":
                    encodedCharacter = "G";
                    break;
                case "00111":
                    encodedCharacter = "H";
                    break;
                case "01000":
                    encodedCharacter = "J";
                    break;
                case "01001":
                    encodedCharacter = "K";
                    break;
                case "01010":
                    encodedCharacter = "L";
                    break;
                case "01011":
                    encodedCharacter = "M";
                    break;
                case "01100":
                    encodedCharacter = "N";
                    break;
                case "01101":
                    encodedCharacter = "P";
                    break;
                case "01110":
                    encodedCharacter = "R";
                    break;
                case "01111":
                    encodedCharacter = "S";
                    break;
                case "10000":
                    encodedCharacter = "T";
                    break;
                case "10001":
                    encodedCharacter = "V";
                    break;
                case "10010":
                    encodedCharacter = "W";
                    break;
                case "10011":
                    encodedCharacter = "X";
                    break;
                case "10100":
                    encodedCharacter = "Y";
                    break;
                case "10101":
                    encodedCharacter = "Z";
                    break;
                case "10110":
                    encodedCharacter = "0";
                    break;
                case "10111":
                    encodedCharacter = "1";
                    break;
                case "11000":
                    encodedCharacter = "2";
                    break;
                case "11001":
                    encodedCharacter = "3";
                    break;
                case "11010":
                    encodedCharacter = "4";
                    break;
                case "11011":
                    encodedCharacter = "5";
                    break;
                case "11100":
                    encodedCharacter = "6";
                    break;
                case "11101":
                    encodedCharacter = "7";
                    break;
                case "11110":
                    encodedCharacter = "8";
                    break;
                case "11111":
                    encodedCharacter = "9";
                    break;
            }


            return encodedCharacter;
        }

        /*
         * Code:           ABCDEFGH IJKLMNOP QRSTUVWX abcdefgh ijklmnop
         * Encrypted Code: ijklmnop IJKLMNOP ABCDEFGH defghabc QRSTUVWX
         */
        public string EncryptGenMDAddressAndValueToCode(string hexString)
        {
            string encryptedString;
            string encodedString;
            string hex1 = hexString[0] + hexString[1].ToString();
            string hex2 = hexString[2] + hexString[3].ToString();
            string hex3 = hexString[4] + hexString[5].ToString();
            string hex4 = hexString[6] + hexString[7].ToString();
            string hex5 = hexString[8] + hexString[9].ToString();

            string bin1 = Convert.ToString(Convert.ToInt32(hex1, 16), 2).PadLeft(8, '0');
            string bin2 = Convert.ToString(Convert.ToInt32(hex2, 16), 2).PadLeft(8, '0');
            string bin3 = Convert.ToString(Convert.ToInt32(hex3, 16), 2).PadLeft(8, '0');
            string bin4 = Convert.ToString(Convert.ToInt32(hex4, 16), 2).PadLeft(8, '0');
            string bin5 = Convert.ToString(Convert.ToInt32(hex5, 16), 2).PadLeft(8, '0');
            
            string encodedBin1 = bin5;
            string encodedBin2 = bin2;
            string encodedBin3 = bin1;
            string encodedBin4 = bin4[3].ToString() + bin4[4].ToString() + bin4[5].ToString() + bin4[6].ToString() + bin4[7].ToString() + bin4[0].ToString() + bin4[1].ToString() + bin4[2].ToString();
            string encodedBin5 = bin3;

            encodedString = encodedBin1 + encodedBin2 + encodedBin3 + encodedBin4 + encodedBin5;

            encryptedString = EncryptGenMDAddressAndValue(encodedString);

            return encryptedString;
        }

        private string EncryptGenMDAddressAndValue(string binaryString)
        {
            string encryptedCode = "";

            string eBin1 = "";
            string eBin2 = "";
            string eBin3 = "";
            string eBin4 = "";
            string eBin5 = "";
            string eBin6 = "";
            string eBin7 = "";
            string eBin8 = "";

            int i = 0;
            foreach (char c in binaryString)
            {
                if (i < 5)
                {
                    eBin1 += c;
                }
                else if (i < 10)
                {
                    eBin2 += c;
                }
                else if (i < 15)
                {
                    eBin3 += c;
                }
                else if (i < 20)
                {
                    eBin4 += c;
                }
                else if (i < 25)
                {
                    eBin5 += c;
                }
                else if (i < 30)
                {
                    eBin6 += c;
                }
                else if (i < 35)
                {
                    eBin7 += c;
                }
                else if (i < 40)
                {
                    eBin8 += c;
                }

                i++;
            }

            encryptedCode = EncodeGenMD(eBin1);
            encryptedCode += EncodeGenMD(eBin2);
            encryptedCode += EncodeGenMD(eBin3);
            encryptedCode += EncodeGenMD(eBin4);
            encryptedCode += EncodeGenMD(eBin5);
            encryptedCode += EncodeGenMD(eBin6);
            encryptedCode += EncodeGenMD(eBin7);
            encryptedCode += EncodeGenMD(eBin8);

            return encryptedCode;
        }
        #endregion

        #region NES



        #endregion

        #region GameBoy / GameGear



        #endregion

    }
}