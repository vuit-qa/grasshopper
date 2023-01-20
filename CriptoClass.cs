using System;
using System.Text;

namespace Cripto {
    internal class CriptoClass {

        byte[][] iterationC = new byte[32][];
        byte[][] iterationK = new byte[10][];

        static byte[] Pi = new byte[256] {
         252,
         238,
         221,
         17,
         207,
         110,
         49,
         22,
         251,
         196,
         250,
         218,
         35,
         197,
         4,
         77,
         233,
         119,
         240,
         219,
         147,
         46,
         153,
         186,
         23,
         54,
         241,
         187,
         20,
         205,
         95,
         193,
         249,
         24,
         101,
         90,
         226,
         92,
         239,
         33,
         129,
         28,
         60,
         66,
         139,
         1,
         142,
         79,
         5,
         132,
         2,
         174,
         227,
         106,
         143,
         160,
         6,
         11,
         237,
         152,
         127,
         212,
         211,
         31,
         235,
         52,
         44,
         81,
         234,
         200,
         72,
         171,
         242,
         42,
         104,
         162,
         253,
         58,
         206,
         204,
         181,
         112,
         14,
         86,
         8,
         12,
         118,
         18,
         191,
         114,
         19,
         71,
         156,
         183,
         93,
         135,
         21,
         161,
         150,
         41,
         16,
         123,
         154,
         199,
         243,
         145,
         120,
         111,
         157,
         158,
         178,
         177,
         50,
         117,
         25,
         61,
         255,
         53,
         138,
         126,
         109,
         84,
         198,
         128,
         195,
         189,
         13,
         87,
         223,
         245,
         36,
         169,
         62,
         168,
         67,
         201,
         215,
         121,
         214,
         246,
         124,
         34,
         185,
         3,
         224,
         15,
         236,
         222,
         122,
         148,
         176,
         188,
         220,
         232,
         40,
         80,
         78,
         51,
         10,
         74,
         167,
         151,
         96,
         115,
         30,
         0,
         98,
         68,
         26,
         184,
         56,
         130,
         100,
         159,
         38,
         65,
         173,
         69,
         70,
         146,
         39,
         94,
         85,
         47,
         140,
         163,
         165,
         125,
         105,
         213,
         149,
         59,
         7,
         88,
         179,
         64,
         134,
         172,
         29,
         247,
         48,
         55,
         107,
         228,
         136,
         217,
         231,
         137,
         225,
         27,
         131,
         73,
         76,
         63,
         248,
         254,
         141,
         83,
         170,
         144,
         202,
         216,
         133,
         97,
         32,
         113,
         103,
         164,
         45,
         43,
         9,
         91,
         203,
         155,
         37,
         208,
         190,
         229,
         108,
         82,
         89,
         166,
         116,
         210,
         230,
         244,
         180,
         192,
         209,
         102,
         175,
         194,
         57,
         75,
         99,
         182
      };

        static byte[] Pi_Reverse = new byte[256] {
         0xA5,
         0x2D,
         0x32,
         0x8F,
         0x0E,
         0x30,
         0x38,
         0xC0,
         0x54,
         0xE6,
         0x9E,
         0x39,
         0x55,
         0x7E,
         0x52,
         0x91,
         0x64,
         0x03,
         0x57,
         0x5A,
         0x1C,
         0x60,
         0x07,
         0x18,
         0x21,
         0x72,
         0xA8,
         0xD1,
         0x29,
         0xC6,
         0xA4,
         0x3F,
         0xE0,
         0x27,
         0x8D,
         0x0C,
         0x82,
         0xEA,
         0xAE,
         0xB4,
         0x9A,
         0x63,
         0x49,
         0xE5,
         0x42,
         0xE4,
         0x15,
         0xB7,
         0xC8,
         0x06,
         0x70,
         0x9D,
         0x41,
         0x75,
         0x19,
         0xC9,
         0xAA,
         0xFC,
         0x4D,
         0xBF,
         0x2A,
         0x73,
         0x84,
         0xD5,
         0xC3,
         0xAF,
         0x2B,
         0x86,
         0xA7,
         0xB1,
         0xB2,
         0x5B,
         0x46,
         0xD3,
         0x9F,
         0xFD,
         0xD4,
         0x0F,
         0x9C,
         0x2F,
         0x9B,
         0x43,
         0xEF,
         0xD9,
         0x79,
         0xB6,
         0x53,
         0x7F,
         0xC1,
         0xF0,
         0x23,
         0xE7,
         0x25,
         0x5E,
         0xB5,
         0x1E,
         0xA2,
         0xDF,
         0xA6,
         0xFE,
         0xAC,
         0x22,
         0xF9,
         0xE2,
         0x4A,
         0xBC,
         0x35,
         0xCA,
         0xEE,
         0x78,
         0x05,
         0x6B,
         0x51,
         0xE1,
         0x59,
         0xA3,
         0xF2,
         0x71,
         0x56,
         0x11,
         0x6A,
         0x89,
         0x94,
         0x65,
         0x8C,
         0xBB,
         0x77,
         0x3C,
         0x7B,
         0x28,
         0xAB,
         0xD2,
         0x31,
         0xDE,
         0xC4,
         0x5F,
         0xCC,
         0xCF,
         0x76,
         0x2C,
         0xB8,
         0xD8,
         0x2E,
         0x36,
         0xDB,
         0x69,
         0xB3,
         0x14,
         0x95,
         0xBE,
         0x62,
         0xA1,
         0x3B,
         0x16,
         0x66,
         0xE9,
         0x5C,
         0x6C,
         0x6D,
         0xAD,
         0x37,
         0x61,
         0x4B,
         0xB9,
         0xE3,
         0xBA,
         0xF1,
         0xA0,
         0x85,
         0x83,
         0xDA,
         0x47,
         0xC5,
         0xB0,
         0x33,
         0xFA,
         0x96,
         0x6F,
         0x6E,
         0xC2,
         0xF6,
         0x50,
         0xFF,
         0x5D,
         0xA9,
         0x8E,
         0x17,
         0x1B,
         0x97,
         0x7D,
         0xEC,
         0x58,
         0xF7,
         0x1F,
         0xFB,
         0x7C,
         0x09,
         0x0D,
         0x7A,
         0x67,
         0x45,
         0x87,
         0xDC,
         0xE8,
         0x4F,
         0x1D,
         0x4E,
         0x04,
         0xEB,
         0xF8,
         0xF3,
         0x3E,
         0x3D,
         0xBD,
         0x8A,
         0x88,
         0xDD,
         0xCD,
         0x0B,
         0x13,
         0x98,
         0x02,
         0x93,
         0x80,
         0x90,
         0xD0,
         0x24,
         0x34,
         0xCB,
         0xED,
         0xF4,
         0xCE,
         0x99,
         0x10,
         0x44,
         0x40,
         0x92,
         0x3A,
         0x01,
         0x26,
         0x12,
         0x1A,
         0x48,
         0x68,
         0xF5,
         0x81,
         0x8B,
         0xC7,
         0xD6,
         0x20,
         0x0A,
         0x08,
         0x00,
         0x4C,
         0xD7,
         0x74
      };

        static byte[] AlgoritmX(byte[] FirstValue, byte[] SecondValue) {
            byte[] Output = new byte[16];
            for(int i = 0; i < 16; i++) {
                Output[i] = Convert.ToByte(FirstValue[i] ^ SecondValue[i]);
            }
            return Output;
        }



        public static byte[] AlgoritmS(byte[] input) {
            byte[] output = new byte[16];
            for(int i = 0; i < 16; i++) {
                output[i] = Pi[input[i]];
            }
            return output;
        }

        public static byte[] AlgoritmSReverse(byte[] input) {
            byte[] output = new byte[16];
            for(int i = 0; i < 16; i++) {
                output[i] = Pi_Reverse[input[i]];
            }
            return output;
        }


        static byte KuzMulInGF(byte a, byte b) {
            byte p = 0;
            byte counter;
            byte hi_bit_set;
            for(counter = 0; counter < 8 && a != 0 && b != 0; counter++) {
                if((b & 1) != 0)
                    p ^= a;
                hi_bit_set = (byte)(a & 0x80);
                a <<= 1;
                if(hi_bit_set != 0)
                    a ^= 0xc3;

                b >>= 1;
            }
            return p;
        }

        static byte[] LVec = new byte[] {
         148,
         32,
         133,
         16,
         194,
         192,
         1,
         251,
         1,
         192,
         194,
         16,
         133,
         32,
         148,
         1
      };

        static byte[] AlgoritmR(byte[] input) {
            byte a_15 = 0;
            byte[] state = new byte[16];
            for(int i = 0; i <= 15; i++) {
                a_15 ^= KuzMulInGF(input[i], LVec[i]);
            }
            for(int i = 15; i > 0; i--) {
                state[i] = input[i - 1];
            }
            state[0] = a_15;
            return state;
        }

        static byte[] AlgoritmL(byte[] input) {
            byte[] state = input;
            for(int i = 0; i < 16; i++) {
                state = AlgoritmR(state);
            }
            return state;
        }

        static byte[] AlgoritmRReverse(byte[] input) {
            byte a_15 = input[0];
            byte[] state = new byte[16];
            for(int i = 0; i < 15; i++) {
                state[i] = input[i + 1];
            }
            for(int i = 15; i >= 0; i--) {
                a_15 ^= KuzMulInGF(state[i], LVec[i]);
            }
            state[15] = a_15;
            return state;
        }

        static byte[] AlgoritmLReverse(byte[] input) {
            byte[] state = input;
            for(int i = 0; i < 16; i++) {
                state = AlgoritmRReverse(state);
            }
            return state;
        }


        private string LengthTo32Bytes(string StringValue) {
            if(StringValue.Length < 32) {
                int j = 0;
                for(int i = StringValue.Length; i < 32; i++) {
                    StringValue += StringValue.Substring(j, 1);
                    if(j == StringValue.Length - 1) {
                        j = 0;
                    } else {
                        j++;
                    }
                }
                return StringValue;
            } else if(StringValue.Length > 32) {
                return StringValue.Substring(0, 32);
            } else {
                return StringValue;
            }
        }

        void AlgoritmF(byte[] input1, byte[] input2, ref byte[] output1, ref byte[] output2, byte[] round_C) {
            byte[] state = new byte[16];
            state = AlgoritmX(input1, round_C);
            state = AlgoritmS(state);
            state = AlgoritmL(state);
            output1 = AlgoritmX(state, input2);
            output2 = input1;
        }

        void AlgorintGenRaundConst(byte[] mas_key) {

            byte[][] iterNum = new byte[32][];
            for(int i = 0; i < 32; i++) {
                iterNum[i] = new byte[] {
               0,
               0,
               0,
               0,
               0,
               0,
               0,
               0,
               0,
               0,
               0,
               0,
               0,
               0,
               0,
               Convert.ToByte(i + 1)
            };
                iterationC[i] = AlgoritmL(iterNum[i]);
            }

            byte[] A = new byte[16];
            for(int i = 0; i < 16; i++) A[i] = mas_key[i];
            byte[] B = new byte[16];
            int j = 0;
            for(int i = 16; i < 32; i++) {
                B[j] = mas_key[i];
                j++;
            }
            j = 0;
            iterationK[0] = B;
            iterationK[1] = A;

            byte[] C = new byte[16];
            byte[] D = new byte[16];
     

            for(int i = 0; i < 4; i++) {
                AlgoritmF(A, B, ref C, ref D, iterationC[0 + 8 * i]);
                AlgoritmF(C, D, ref A, ref B, iterationC[1 + 8 * i]);
                AlgoritmF(A, B, ref C, ref D, iterationC[2 + 8 * i]);
                AlgoritmF(C, D, ref A, ref B, iterationC[3 + 8 * i]);
                AlgoritmF(A, B, ref C, ref D, iterationC[4 + 8 * i]);
                AlgoritmF(C, D, ref A, ref B, iterationC[5 + 8 * i]);
                AlgoritmF(A, B, ref C, ref D, iterationC[6 + 8 * i]);
                AlgoritmF(C, D, ref A, ref B, iterationC[7 + 8 * i]);
                iterationK[2 * i + 2] = A;
                iterationK[2 * i + 3] = B;
            }
        }

        public byte[] GrasshopperEncript(byte[] file, byte[] masterKey) {
            masterKey = Encoding.Default.GetBytes(LengthTo32Bytes(Encoding.Default.GetString(masterKey)));
            AlgorintGenRaundConst(masterKey);
            int NumOfBlocks;
            int NumberOfNull;
            byte[] OriginText = file;
            byte[] encrText = new byte[0];
            if((file.Length % 16) == 0) {
                NumOfBlocks = file.Length / 16;
                Array.Resize(ref encrText, file.Length);
            } else {
                NumOfBlocks = (file.Length / 16) + 1;
                NumberOfNull = NumOfBlocks * 16 - file.Length;
                int StartLength = file.Length;
                Array.Resize(ref OriginText, OriginText.Length + NumberOfNull);
                Array.Resize(ref encrText, OriginText.Length);
                if(NumberOfNull == 1) OriginText[OriginText.Length - 1] = 0x80;
                else {
                    for(int i = OriginText.Length - 1; i >= 0; i--) {
                        if(i == OriginText.Length - 1) {
                            OriginText[OriginText.Length - 1] = 0x81;
                        } else if(OriginText[i] != 0) {
                            OriginText[i + 1] = 0x01;
                            break;
                        }
                    }
                }
            }
            for(int i = 0; i < NumOfBlocks; i++) {
                byte[] block = new byte[16];
                for(int j = 0; j < 16; j++) {
                    block[j] = OriginText[i * 16 + j];
                }
                for(int j = 0; j < 9; j++) {
                    block = AlgoritmX(block, iterationK[j]);
                    block = AlgoritmS(block);
                    block = AlgoritmL(block);
                }
                block = AlgoritmX(block, iterationK[9]);
                for(int j = 0; j < 16; j++) {
                    encrText[i * 16 + j] = block[j];
                }
            }
            return encrText;
        }

        public byte[] GrasshopperDecript(byte[] file, byte[] masterKey) {
            AlgorintGenRaundConst(masterKey);
            int NumOfBlocks = file.Length / 16;
            byte[] OriginText = file;
            byte[] decrText = new byte[file.Length];
            for(int i = 0; i < NumOfBlocks; i++) {
                byte[] block = new byte[16];
                for(int j = 0; j < 16; j++) {
                    block[j] = OriginText[i * 16 + j];
                }
                block = AlgoritmX(block, iterationK[9]);
                for(int j = 8; j >= 0; j--) {
                    block = AlgoritmLReverse(block);
                    block = AlgoritmSReverse(block);
                    block = AlgoritmX(block, iterationK[j]);
                }
                for(int j = 0; j < 16; j++) {
                    decrText[i * 16 + j] = block[j];
                }
                if(i == NumOfBlocks - 1 && (decrText[decrText.Length - 1] == 0x81 || decrText[decrText.Length - 1] == 0x80)) {
                    if(decrText[decrText.Length - 1] == 0x81) {
                        int Zeros = 0;
                        for(int j = decrText.Length - 1; j > 0; j--) {
                            if(decrText[j] == 0x81 || decrText[j] == 0x01 || decrText[j] == 0) Zeros++;
                            else break;
                        }
                        Array.Resize(ref decrText, decrText.Length - Zeros);
                    }
                    if(decrText[decrText.Length - 1] == 0x80) Array.Resize(ref decrText, decrText.Length - 1);
                }
            }
            return decrText;
        }


    }

}