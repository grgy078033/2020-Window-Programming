using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace f74086381_practice4_2
{
    class Program
    {
        static void Main(string[] args)
        {
            int i, j;
            int unit_point = 0;
            int building_point = 1;
            Random rd = new Random();
            int rand_num;
            string instruction = "";
            bool game = true;
            int round = 0;
            int temp_round = 0;
            int food = 500;
            int wood = 500;
            int gold = 500;
            int Villager_num = 0;
            int Militia_num = 0;
            int Archer_num = 0;
            int Scout_num = 0;
            int TC_num = 1;
            int Barracks_num = 0;
            int ArcheryRange_num = 0;
            int Stable_num = 0;
            int unit_num = 0;
            int building_num = 1;
            Unit[] unit = new Unit[1000];
            Building[] building = new Building[1000];
            for(i = 0; i < 1000; ++i)
            {
                unit[i] = new Unit();
                building[i] = new Building();
            }
            building[0].set_type("TC");

            do
            {
                if (round >= 3 && round > temp_round)
                {
                    if (unit_num > 0)
                    {
                        rand_num = rd.Next(0, 1000);
                        while(unit[rand_num].get_type() == "")
                        {
                            rand_num = rd.Next(0, 1000);
                        }
                        unit[rand_num].set_HP(unit[rand_num].get_HP() - 50);
                        if (unit[rand_num].get_HP() <= 0)
                        {
                            --unit_num;
                            switch (unit[rand_num].get_type())
                            {
                                case "Villager":
                                    --Villager_num;
                                    break;
                                case "Militia":
                                    --Militia_num;
                                    break;
                                case "Archer":
                                    --Archer_num;
                                    break;
                                case "Scout":
                                    --Scout_num;
                                    break;
                            }
                            unit[rand_num].set_type("");
                        }
                    }
                    else if (unit_num == 0)
                    {
                        while (true)
                        {
                            rand_num = rd.Next(0, 1000);
                            while(building[rand_num].get_type() == "")
                            {
                                rand_num = rd.Next(0, 1000);
                            }
                            if (building[rand_num].get_type() != "TC")
                                continue;
                            else
                            {
                                building[rand_num].set_HP(building[rand_num].get_HP() - 500);
                                if (building[rand_num].get_HP() <= 0)
                                {
                                    --building_num;
                                    --TC_num;
                                    building[rand_num].set_type("");
                                    if (TC_num == 0)
                                    {
                                        Console.WriteLine("你輸了");
                                        game = false;
                                    }
                                }
                                break;
                            }
                        }
                    }
                }

                if (game)
                {
                    Console.WriteLine("第{0}回合", round); // Print out round and the number of each kind of building and unit.
                    Console.WriteLine("目前資源 : 食物 : {0}, 木材 : {1}, 黃金 : {2}", food, wood, gold);
                    Console.WriteLine("目前建築 : 城鎮中心 x{0}, 兵營 x{1}, 射箭場 x{2}, 馬廄 x{3}", TC_num, Barracks_num, ArcheryRange_num, Stable_num);
                    Console.WriteLine("目前建築 : 村民 x{0}, 民兵 x{1}, 弓箭手 x{2}, 斥候 x{3}", Villager_num, Militia_num, Archer_num, Scout_num);

                    instruction = Console.ReadLine(); // input
                }
                temp_round = round;

                switch (instruction)
                {
                    case "TC": // buildings
                        if (wood < 200 || gold < 100)
                        {
                            Console.WriteLine("資源不足");
                            break;
                        }
                        else
                        {
                            building[building_point].set_type("TC");
                            wood -= 200;
                            gold -= 100;
                            ++TC_num;
                            ++building_num;
                            ++building_point;
                            ++round;
                            food += Villager_num * 10;
                            wood += Villager_num * 10;
                            gold += Villager_num * 10;
                            break;
                        }
                    case "Barracks":
                        if (wood < 100)
                        {
                            Console.WriteLine("資源不足");
                            break;
                        }
                        else
                        {
                            building[building_point].set_type("Barracks");
                            wood -= 100;
                            ++Barracks_num;
                            ++building_num;
                            ++building_point;
                            ++round;
                            food += Villager_num * 10;
                            wood += Villager_num * 10;
                            gold += Villager_num * 10;
                            break;
                        }
                    case "ArcheryRange":
                        if (wood < 150 || gold < 50)
                        {
                            Console.WriteLine("資源不足");
                            break;
                        }
                        else
                        {
                            building[building_point].set_type("ArcheryRange");
                            wood -= 150;
                            gold -= 50;
                            ++ArcheryRange_num;
                            ++building_num;
                            ++building_point;
                            ++round;
                            food += Villager_num * 10;
                            wood += Villager_num * 10;
                            gold += Villager_num * 10;
                            break;
                        }
                    case "Stable":
                        if (wood < 200)
                        {
                            Console.WriteLine("資源不足");
                            break;
                        }
                        else
                        {
                            building[building_point].set_type("Stable");
                            wood -= 200;
                            ++Stable_num;
                            ++building_num;
                            ++building_point;
                            ++round;
                            food += Villager_num * 10;
                            wood += Villager_num * 10;
                            gold += Villager_num * 10;
                            break;
                        }

                    case "Villager": // units
                        if (food < 50)
                        {
                            Console.WriteLine("資源不足或無生產建築");
                            break;
                        }
                        else
                        {
                            unit[unit_point].set_type("Villager");
                            food -= 50;
                            food += Villager_num * 10;
                            wood += Villager_num * 10;
                            gold += Villager_num * 10;
                            ++Villager_num;
                            ++unit_num;
                            ++unit_point;
                            ++round;
                            break;
                        }
                    case "Militia":
                        if (food < 100 || gold < 50 || Barracks_num == 0)
                        {
                            Console.WriteLine("資源不足或無生產建築");
                            break;
                        }
                        else
                        {
                            unit[unit_point].set_type("Militia");
                            food -= 100;
                            gold -= 50;
                            ++Militia_num;
                            ++unit_num;
                            ++unit_point;
                            ++round;
                            food += Villager_num * 10;
                            wood += Villager_num * 10;
                            gold += Villager_num * 10;
                            break;
                        }
                    case "Archer":
                        if (wood < 75 || gold < 25 || ArcheryRange_num == 0)
                        {
                            Console.WriteLine("資源不足或無生產建築");
                            break;
                        }
                        else
                        {
                            unit[unit_point].set_type("Archer");
                            wood -= 75;
                            gold -= 25;
                            ++Archer_num;
                            ++unit_num;
                            ++unit_point;
                            ++round;
                            food += Villager_num * 10;
                            wood += Villager_num * 10;
                            gold += Villager_num * 10;
                            break;
                        }
                    case "Scout":
                        if (food < 80 || Stable_num == 0)
                        {
                            Console.WriteLine("資源不足或無生產建築");
                            break;
                        }
                        else
                        {
                            unit[unit_point].set_type("Scout");
                            food -= 80;
                            ++Scout_num;
                            ++unit_num;
                            ++unit_point;
                            ++round;
                            food += Villager_num * 10;
                            wood += Villager_num * 10;
                            gold += Villager_num * 10;
                            break;
                        }

                    case "skip": // special instructions
                        ++round;
                        food += Villager_num * 10;
                        wood += Villager_num * 10;
                        gold += Villager_num * 10;
                        break;
                    case "units_status":
                        for (i = 0; i < 1000; ++i)
                        {
                            if (unit[i].get_type() == "Villager" || unit[i].get_type() == "Militia" || unit[i].get_type() == "Archer" || unit[i].get_type() == "Scout")
                            {
                                Console.WriteLine("{0} attack:{1} HP:{2}", unit[i].get_type(), unit[i].get_attack(), unit[i].get_HP());
                            }
                        }
                        break;
                    case "TC_status":
                        for (i = 0; i < 1000; ++i)
                        {
                            if (building[i].get_type() == "TC")
                                Console.WriteLine("TC HP:{0}", building[i].get_HP());
                        }
                        break;
                    case "Feudal":
                        if (food >= 500)
                        {
                            Console.WriteLine("你贏了");
                            game = false;
                        }
                        break;
                    case "how_do_you_turn_this_on":
                        food = 50000;
                        wood = 50000;
                        gold = 50000;
                        break;
                    default:
                        break;
                }
            } while (game);

            Console.ReadKey();
        }
    }
}
