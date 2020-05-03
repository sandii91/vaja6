using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace vaja6
{
    class Program
    {
        static void Main(string[] args)
        {
            float stanje = 0;
            float novoStanje = 0;
            float popravek = 0;
            string odgovor;
            string seKaksenPosel;

            Console.Write(" Želiš opravljati bančne posle ?");
            seKaksenPosel = Console.ReadLine();
            seKaksenPosel = seKaksenPosel.ToUpper();

            while (seKaksenPosel == "DA")
            {
                Console.Write(" Kaj želiš?  1= polog, 2= dvig, 3= stanje ");
                odgovor = Console.ReadLine();
                if (odgovor == "")
                {
                    Console.WriteLine(" Vnesti moraš izbiro ");
                    Environment.Exit(0);
                }
                else
                    if (int.Parse(odgovor) < 1 | int.Parse(odgovor) >3 )
                {
                    Console.WriteLine(" vnesti moraš izbiro ");
                    Environment.Exit(0);
                }
                switch (int.Parse(odgovor))
                {
                    case 1:
                        Console.Write(" koliko boste položili ");
                        popravek = float.Parse(Console.ReadLine());
                        novoStanje = stanje + popravek;
                        MessageBox.Show(" Staro stanje " + stanje + "\n" + "Popravek" + popravek + "\n" + "Novo stanje" + novoStanje,
                            "VSS banka ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        break;
                    case 2:
                        Console.Write(" Koliko boš dvignil ?");
                        popravek = float.Parse(Console.ReadLine());
                        novoStanje = stanje - popravek;
                        MessageBox.Show(" Staro stanje " + stanje + "\n" + " Popravek -" + popravek + "\n" + "Novo stanje" + novoStanje,
                            "VSS banka", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        break;
                    case 3:
                        MessageBox.Show("Stanje" + stanje,
                            "VSS banka", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        break;
                }
                stanje = novoStanje;
                Console.Write(" Bi želeli še kakšno transakcijo? ");
                seKaksenPosel = Console.ReadLine();
                seKaksenPosel = seKaksenPosel.ToUpper();
            }
            MessageBox.Show(" Hvala ker ste poslovali z nami ",
                "VSS banka", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
