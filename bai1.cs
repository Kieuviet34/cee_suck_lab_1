using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cee_suck_lab_1
{
    internal class bai1
    {
        enum HangTram { KHONG, MOT, HAI, BA, BON, NAM, SAU, BAY, TAM, CHIN }
        enum HangChuc { KHONG, MUOI, HAI_MUOI, BA_MUOI, BON_MUOI, NAM_MUOI, SAU_MUOI, BAY_MUOI, TAM_MUOI, CHIN_MUOI }
        enum HangDonVi { KHONG, MOT, HAI, BA, BON, NAM, SAU, BAY, TAM, CHIN }
        static void DocSo(int so)
        {
            int tram, chuc, dvi;
            tram = so / 100;
            chuc = (so % 100) / 10;
            dvi = so % 10;
            switch ((HangTram)tram)
            {
                case HangTram.MOT:
                    Console.Write("Một trăm ");
                    break;
                case HangTram.HAI:
                    Console.Write("Hai trăm ");
                    break;
                case HangTram.BA:
                    Console.Write("Ba trăm ");
                    break;
                case HangTram.BON:
                    Console.Write("Bốn trăm ");
                    break;
                case HangTram.NAM:
                    Console.Write("Năm trăm ");
                    break;
                case HangTram.SAU:
                    Console.Write("Sáu trăm ");
                    break;
                case HangTram.BAY:
                    Console.Write("Bảy trăm ");
                    break;
                case HangTram.TAM:
                    Console.Write("Tám trăm ");
                    break;
                case HangTram.CHIN:
                    Console.Write("Chín trăm ");
                    break;
            }

            switch ((HangChuc)chuc)
            {
                case HangChuc.KHONG:
                    break;
                case HangChuc.MUOI:
                    Console.Write("Mười ");
                    break;
                case HangChuc.HAI_MUOI:
                    Console.Write("Hai mươi ");
                    break;
                case HangChuc.BA_MUOI:
                    Console.Write("Ba mươi ");
                    break;
                case HangChuc.BON_MUOI:
                    Console.Write("Bốn mươi ");
                    break;
                case HangChuc.NAM_MUOI:
                    Console.Write("Năm mươi ");
                    break;
                case HangChuc.SAU_MUOI:
                    Console.Write("Sáu mươi ");
                    break;
                case HangChuc.BAY_MUOI:
                    Console.Write("Bảy mươi ");
                    break;
                case HangChuc.TAM_MUOI:
                    Console.Write("Tám mươi ");
                    break;
                case HangChuc.CHIN_MUOI:
                    Console.Write("Chín mươi ");
                    break;
            }

            switch ((HangDonVi)dvi)
            {
                case HangDonVi.KHONG:
                    if (so == 0)
                        Console.Write("Không");
                    break;
                case HangDonVi.MOT:
                    Console.Write("Một");
                    break;
                case HangDonVi.HAI:
                    Console.Write("Hai");
                    break;
                case HangDonVi.BA:
                    Console.Write("Ba");
                    break;
                case HangDonVi.BON:
                    Console.Write("Bốn");
                    break;
                case HangDonVi.NAM:
                    Console.Write("Năm");
                    break;
                case HangDonVi.SAU:
                    Console.Write("Sáu");
                    break;
                case HangDonVi.BAY:
                    Console.Write("Bảy");
                    break;
                case HangDonVi.TAM:
                    Console.Write("Tám");
                    break;
                case HangDonVi.CHIN:
                    Console.Write("Chín");
                    break;
            }
        }
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.WriteLine("Nhập số: ");
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine("cách đọc số " + n + ": ");
            DocSo(n);
            Console.ReadLine();
        }
    }
}
